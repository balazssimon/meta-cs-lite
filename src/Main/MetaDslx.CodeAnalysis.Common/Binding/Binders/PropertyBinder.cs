using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
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

        protected override void CollectQualifierBinders(ArrayBuilder<IQualifierBinder> qualifierBinders, CancellationToken cancellationToken)
        {
            if (_valueOpt.HasValue) base.CollectQualifierBinders(qualifierBinders, cancellationToken);
        }

        protected override void CollectIdentifierBinders(ArrayBuilder<IIdentifierBinder> identifierBinders, CancellationToken cancellationToken)
        {
            if (_valueOpt.HasValue) base.CollectIdentifierBinders(identifierBinders, cancellationToken);
        }

        protected override void CollectPropertyBinders(ArrayBuilder<IPropertyBinder> propertyBinders, CancellationToken cancellationToken)
        {
            propertyBinders.Add(this);
            base.CollectPropertyBinders(propertyBinders, cancellationToken);
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
                var valueType = GetValueType(context);
                var result = ArrayBuilder<object?>.GetInstance();
                var valueBinders = GetValueBinders(this, context.CancellationToken);
                foreach (var valueBinder in valueBinders)
                {
                    var binder = (Binder)valueBinder;
                    var values = binder.Bind(context);
                    foreach (var value in values)
                    {
                        if (value is null)
                        {
                            if (valueType is null || !valueType.IsValueType)
                            {
                                result.Add(value);
                            }
                            else
                            {
                                var modelObjectTypeNames = string.Join(",", _modelObjectTypes.Select(t => t.FullName));
                                context.AddDiagnostic(Diagnostic.Create(ErrorCode.ERR_BindingError, binder.Location, $"Cannot assign value 'null' to property '{Name}':'{valueType}' (of {modelObjectTypeNames})"));
                            }
                        }
                        else if (value is Symbol symbol && value is IModelSymbol modelSymbol && modelSymbol.ModelObject is not null)
                        {
                            if (valueType is null || valueType.IsAssignableFrom(modelSymbol.ModelObject.GetType()))
                            {
                                result.Add(symbol);
                            }
                            else
                            {
                                var modelObjectTypeNames = string.Join(",", _modelObjectTypes.Select(t => t.FullName));
                                context.AddDiagnostic(Diagnostic.Create(ErrorCode.ERR_BindingError, binder.Location, $"Cannot assign value '{modelSymbol.ModelObject}':'{modelSymbol.ModelObject.GetType()}' to property '{Name}':'{valueType}' (of {modelObjectTypeNames})"));
                            }
                        }
                        else
                        {
                            if (valueType is null || valueType.IsAssignableFrom(value.GetType()))
                            {
                                result.Add(value);
                            }
                            else
                            {
                                var modelObjectTypeNames = string.Join(",", _modelObjectTypes.Select(t => t.FullName));
                                context.AddDiagnostic(Diagnostic.Create(ErrorCode.ERR_BindingError, binder.Location, $"Cannot assign value '{value}':'{value.GetType()}' to property '{Name}':'{valueType}' (of {modelObjectTypeNames})"));
                            }
                        }
                    }
                }
                return result.ToImmutableAndFree();
            }
        }

        public Type? GetValueType(BindingContext context)
        {
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
                    var info = symbolFactory.GetModelObjectInfo(modelObjectType);
                    if (info is not null)
                    {
                        var modelProperty = info.GetProperty(this.Name);
                        if (modelProperty is not null)
                        {
                            var modelPropertyType = modelProperty.Type;
                            if (modelPropertyType is not null)
                            {
                                valueTypes.Add(modelPropertyType);
                            }
                            else
                            {
                                context.AddDiagnostic(Diagnostic.Create(ErrorCode.ERR_BindingError, Location, $"Property '{Name}' of model object '{modelObjectType}' has no type."));
                            }
                        }
                        else
                        {
                            context.AddDiagnostic(Diagnostic.Create(ErrorCode.ERR_BindingError, Location, $"Property '{Name}' of model object '{modelObjectType}' does not exist."));
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
                    context.AddDiagnostic(Diagnostic.Create(ErrorCode.ERR_BindingError, Location, $"Property '{Name}' (of {modelObjectTypeNames}) has no type"));
                }
                else
                {
                    var modelObjectTypeNames = string.Join(",", modelObjectTypes.Select(t => t.FullName));
                    var typeNames = string.Join(",", valueTypes.Select(t => t.FullName));
                    context.AddDiagnostic(Diagnostic.Create(ErrorCode.ERR_BindingError, Location, $"Property '{Name}' (of {modelObjectTypeNames}) has multiple possible types: {typeNames}"));
                }
                Interlocked.CompareExchange(ref _valueType, valueType, null);
                ImmutableInterlocked.InterlockedInitialize(ref _modelObjectTypes, modelObjectTypes.ToImmutableArray());
                valueTypes.Free();
                modelObjectTypes.Free();
            }
            return _valueType;
        }
    }
}
