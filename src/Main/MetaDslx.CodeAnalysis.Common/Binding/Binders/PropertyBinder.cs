using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class PropertyBinder : Binder, IPropertyBinder, IValueBinder
    {
        private readonly string _name;
        private readonly Optional<object?> _valueOpt;
        private Type? _valueType;
        private ImmutableArray<Type> _modelObjectTypes;

        public PropertyBinder(string name)
        {
            _name = name;
        }

        public PropertyBinder(string name, object? value)
        {
            _name = name;
            _valueOpt = value;
        }

        public string Name => _name;
        public Optional<object?> ValueOpt => _valueOpt;
        public bool IsSymbolProperty => _modelObjectTypes.Any(t => typeof(Symbol).IsAssignableFrom(t));

        protected override void CollectQualifierBinders(ArrayBuilder<IQualifierBinder> qualifierBinders, CancellationToken cancellationToken)
        {
            if (_valueOpt.HasValue) base.CollectQualifierBinders(qualifierBinders, cancellationToken);
        }

        protected override void CollectIdentifierBinders(ArrayBuilder<IIdentifierBinder> identifierBinders, CancellationToken cancellationToken)
        {
            if (_valueOpt.HasValue) base.CollectIdentifierBinders(identifierBinders, cancellationToken);
        }
        
        protected override void CollectPropertyBinders(string? propertyName, ArrayBuilder<IPropertyBinder> propertyBinders, CancellationToken cancellationToken)
        {
            if (propertyName is null || propertyName == this.Name) propertyBinders.Add(this);
            base.CollectPropertyBinders(propertyName, propertyBinders, cancellationToken);
        }

        protected override void CollectValueBinders(IPropertyBinder propertyBinder, ArrayBuilder<IValueBinder> valueBinders, CancellationToken cancellationToken)
        {
            if (propertyBinder == this)
            {
                if (_valueOpt.HasValue)
                {
                    valueBinders.Add(this);
                }
                else
                {
                    base.CollectValueBinders(propertyBinder, valueBinders, cancellationToken);
                }
            }
        }

        protected override IPropertyBinder? GetEnclosingPropertyBinder()
        {
            if (!_valueOpt.HasValue) return this;
            else return base.GetEnclosingPropertyBinder();
        }

        protected override ImmutableArray<object?> BindValues(BindingContext context)
        {
            if (_valueOpt.HasValue)
            {
                return ImmutableArray.Create(_valueOpt.Value);
            }
            else
            {
                var propertyType = GetValueType(context, out var isName);
                var isSymbol = IsSymbolProperty;
                var result = ArrayBuilder<object?>.GetInstance();
                var valueBinders = GetValueBinders(this, context.CancellationToken);
                foreach (var valueBinder in valueBinders)
                {
                    var binder = (Binder)valueBinder;
                    var values = binder.Bind(context);
                    foreach (var value in values)
                    {
                        if (value is IErrorSymbol) continue;
                        if (value is null)
                        {
                            if (propertyType is null || !propertyType.IsValueType)
                            {
                                result.Add(value);
                            }
                            else
                            {
                                if (isSymbol) context.AddDiagnostic(Diagnostic.Create(CommonErrorCode.ERR_InvalidSymbolPrimitivePropertyValue, binder.Location, "'null'", propertyType.Name, FullName, propertyType.Name));
                                else context.AddDiagnostic(Diagnostic.Create(CommonErrorCode.ERR_InvalidModelObjectPrimitivePropertyValue, binder.Location, "'null'", propertyType.Name, FullName, propertyType.Name));
                            }
                        }
                        else if (value is Symbol symbol)
                        {
                            var modelSymbol = value as IModelSymbol;
                            var valueType = modelSymbol?.ModelObject is not null ? modelSymbol.ModelObjectType : value.GetType();
                            if (propertyType is null)
                            {
                                result.Add(symbol);
                            }
                            else if (propertyType == typeof(MetaModel))
                            {
                                var fullName = SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(symbol);
                                var metaModels = Compilation.ExternalReferences.OfType<MetaModelReference>().Where(r => r.MetaModel.FullName == fullName);
                                result.AddRange(metaModels);
                            }
                            else if (isName && propertyType == typeof(string))
                            {
                                result.Add(symbol.Name);
                            }
                            else if (propertyType == typeof(MetaType) && symbol is TypeSymbol typeSymbol)
                            {
                                result.Add(MetaType.FromTypeSymbol(typeSymbol));
                            }
                            else if (propertyType == typeof(MetaSymbol))
                            {
                                result.Add(MetaSymbol.FromSymbol(symbol));
                            }
                            else if (typeof(Symbol).IsAssignableFrom(propertyType) && propertyType.IsAssignableFrom(symbol.GetType()))
                            {
                                result.Add(symbol);
                            }
                            else if (propertyType.IsAssignableFrom(valueType))
                            {
                                result.Add(value);
                            }
                            else
                            {
                                if (isSymbol) context.AddDiagnostic(Diagnostic.Create(CommonErrorCode.ERR_InvalidSymbolPropertyValue, binder.Location, value.ToString().ToPascalCase(), valueType.Name, FullName, propertyType.Name));
                                else context.AddDiagnostic(Diagnostic.Create(CommonErrorCode.ERR_InvalidModelObjectPropertyValue, binder.Location, (modelSymbol?.ModelObject ?? value).ToString().ToPascalCase(), valueType.Name, FullName, propertyType.Name));
                            }
                        }
                        else
                        {
                            if (propertyType is null || propertyType.IsAssignableFrom(value.GetType()))
                            {
                                result.Add(value);
                            }
                            else if (propertyType == typeof(MetaType) && (value is string || value is Type || value is IModelObject))
                            {
                                if (value is string stringValue) result.Add(MetaType.FromName(stringValue));
                                else if (value is Type typeValue) result.Add(MetaType.FromType(typeValue));
                                else if (value is IModelObject mobjValue) result.Add(MetaType.FromModelObject(mobjValue));
                            }
                            else if (propertyType == typeof(MetaSymbol) && value is IModelObject modelObject)
                            {
                                result.Add(MetaSymbol.FromModelObject(modelObject));
                            }
                            else
                            {
                                if (isSymbol) context.AddDiagnostic(Diagnostic.Create(CommonErrorCode.ERR_InvalidSymbolPrimitivePropertyValue, binder.Location, value, value.GetType(), FullName, propertyType.Name));
                                else context.AddDiagnostic(Diagnostic.Create(CommonErrorCode.ERR_InvalidModelObjectPrimitivePropertyValue, binder.Location, value, value.GetType(), FullName, propertyType.Name));
                            }
                        }
                    }
                }
                return result.ToImmutableAndFree();
            }
        }

        public string FullName
        {
            get
            {
                if (_modelObjectTypes.IsDefaultOrEmpty) return Name;
                if (_modelObjectTypes.Length == 1) return $"{_modelObjectTypes[0].Name}.{Name}";
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                var separator = "{";
                foreach (var type in _modelObjectTypes)
                {
                    sb.Append(separator);
                    sb.Append(type.Name);
                    separator = ", ";
                }
                sb.Append("}.");
                sb.Append(Name);
                return builder.ToStringAndFree();
            }
        }

        public Type? GetValueType(BindingContext context)
        {
            return GetValueType(context, out var _);
        }

        private Type? GetValueType(BindingContext context, out bool isName)
        {
            isName = false;
            if (_modelObjectTypes.IsDefault)
            {
                Type? valueType = null;
                var modelObjectTypes = PooledHashSet<Type>.GetInstance();
                foreach (var symbol in ContainingDefinedSymbols)
                {
                    foreach (var decl in symbol.GetSingleDeclarations(context.CancellationToken))
                    {
                        var modelObjectType = decl.ModelObjectType;
                        if (modelObjectType is not null) modelObjectTypes.Add(modelObjectType);
                    }
                }
                var module = Compilation.SourceModule;
                var symbolFactory = module.SymbolFactory;
                var valueTypes = PooledHashSet<Type>.GetInstance();
                foreach (var modelObjectType in modelObjectTypes)
                {
                    if (typeof(Symbol).IsAssignableFrom(modelObjectType))
                    {
                        if (this.Name == "Name") isName = true;
                        var symbolProperty = modelObjectType.GetProperty(this.Name, BindingFlags.Public | BindingFlags.Instance);
                        var propertyType = ExtractCoreType(symbolProperty.PropertyType);
                        if (propertyType is not null)
                        {
                            valueTypes.Add(propertyType);
                        }
                    }
                    else
                    {
                        var info = symbolFactory.GetModelObjectInfo(modelObjectType);
                        if (info is not null)
                        {
                            var modelProperty = info.GetProperty(this.Name);
                            if (modelProperty is not null)
                            {
                                if (modelProperty.IsName) isName = true;
                                var modelPropertyType = modelProperty.Type;
                                if (modelPropertyType is not null)
                                {
                                    valueTypes.Add(modelPropertyType);
                                }
                                else
                                {
                                    context.AddDiagnostic(Diagnostic.Create(CommonErrorCode.ERR_BindingError, Location, $"Property '{Name}' of model object '{modelObjectType}' has no type."));
                                }
                            }
                            else
                            {
                                context.AddDiagnostic(Diagnostic.Create(CommonErrorCode.ERR_BindingError, Location, $"Property '{Name}' of model object '{modelObjectType}' does not exist."));
                            }
                        }
                    }
                }
                if (valueTypes.Count == 1)
                {
                    valueType = valueTypes.First();
                }
                else if (valueTypes.Count == 0)
                {
                    var modelObjectTypeNames = string.Join(",", modelObjectTypes.Select(t => t.FullName));
                    context.AddDiagnostic(Diagnostic.Create(CommonErrorCode.ERR_BindingError, Location, $"Property '{Name}' (of {modelObjectTypeNames}) has no type"));
                }
                else
                {
                    var modelObjectTypeNames = string.Join(",", modelObjectTypes.Select(t => t.FullName));
                    var typeNames = string.Join(",", valueTypes.Select(t => t.FullName));
                    context.AddDiagnostic(Diagnostic.Create(CommonErrorCode.ERR_BindingError, Location, $"Property '{Name}' (of {modelObjectTypeNames}) has multiple possible types: {typeNames}"));
                }
                Interlocked.CompareExchange(ref _valueType, valueType, null);
                ImmutableInterlocked.InterlockedInitialize(ref _modelObjectTypes, modelObjectTypes.ToImmutableArray());
                valueTypes.Free();
                modelObjectTypes.Free();
            }
            return _valueType;
        }

        private Type ExtractCoreType(Type type)
        {
            if (type is null) return null;
            return ExtractNullableType(ExtractItemType(ExtractNullableType(type)));
        }

        private Type ExtractNullableType(Type type)
        {
            if (type.Namespace == "System" && type.Name == "Nullable`1")
            {
                var targs = type.GenericTypeArguments;
                if (targs.Length == 1) return targs[0];
            }
            return type;
        }

        private Type ExtractItemType(Type type)
        {
            var targs = type.GenericTypeArguments;
            if (targs.Length == 0) return type;
            if (type.Namespace == "System.Collections.Immutable")
            {
                switch (type.Name)
                {
                    case "ImmutableArray`1":
                    case "ImmutableList`1":
                    case "ImmutableHashSet`1":
                    case "ImmutableSortedSet`1":
                        return targs[0];
                    default:
                        break;
                }
            }
            if (typeof(ICollection<>).IsAssignableFrom(type))
            {
                return targs[0];
            }
            return type;
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            sb.Append(": [");
            sb.Append(Name);
            sb.Append(": ");
            sb.Append(_valueType);
            if (_valueOpt.HasValue)
            {
                sb.Append(" = ");
                sb.Append(_valueOpt.Value);
            }
            sb.Append("]");
            return builder.ToStringAndFree();
        }
    }
}
