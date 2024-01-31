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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class PropertyBinder : Binder, IPropertyBinder, IValueBinder
    {
        private static readonly ConditionalWeakTable<PropertyBinder, object?> s_valuesOpt = new ConditionalWeakTable<PropertyBinder, object?>();

        private readonly string _name;
        private MetaType _type;

        public PropertyBinder(string name)
        {
            _name = name;
        }

        public PropertyBinder(string name, ImmutableArray<object?> valuesOpt = default)
        {
            _name = name;
            s_valuesOpt.Add(this, valuesOpt);
        }

        public string Name => _name;

        public ImmutableArray<object?> ValuesOpt
        {
            get
            {
                if (s_valuesOpt.TryGetValue(this, out var valuesOpt)) return (ImmutableArray<object?>)valuesOpt;
                else return default;
            }
        }

        public string RawValue => ValuesOpt.ToString();

        public MetaType Type
        {
            get
            {
                if (_type.IsDefault)
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var type = ComputeType(diagnostics, default);
                    if (_type.InterlockedInitialize(type))
                    {
                        AddDiagnostics(diagnostics);
                    }
                    diagnostics.Free();
                }
                return _type;
            }
        }
        
        public MetaType OwnerType
        {
            get
            {
                var firstSymbol = ContainingDefinedSymbols.FirstOrDefault();
                if (firstSymbol is null) return default;
                var modelObjectType = firstSymbol.GetSingleDeclarations().FirstOrDefault()?.ModelObjectType;
                return modelObjectType;
            }
        }

        public ImmutableArray<IValueBinder> GetValueBinders(CancellationToken cancellationToken = default)
        {
            if (!this.ValuesOpt.IsDefault) return ImmutableArray.Create<IValueBinder>(this);
            var valueBinders = ArrayBuilder<IValueBinder>.GetInstance();
            var queue = ArrayBuilder<Binder>.GetInstance();
            queue.Add(this);
            int i = 0;
            while (i < queue.Count)
            {
                var binder = queue[i];
                var addChildren = true;
                if (i > 0)
                {
                    if (binder is IPropertyBinder propertyBinder)
                    {
                        if (propertyBinder.ValuesOpt.IsDefault)
                        {
                            addChildren = false;
                        }
                    }
                    else if (binder is IValueBinder valueBinder)
                    {
                        valueBinders.Add(valueBinder);
                        addChildren = false;
                    }
                    else if (binder is IScopeBinder)
                    {
                        addChildren = false;
                    }
                }
                if (addChildren)
                {
                    foreach (var child in binder.GetChildBinders(false, cancellationToken))
                    {
                        queue.Add(child);
                    }
                }
                ++i;
            }
            queue.Free();
            return valueBinders.ToImmutableAndFree();
        }

        protected override IPropertyBinder? GetEnclosingPropertyBinder()
        {
            if (ValuesOpt.IsDefault) return this;
            else return base.GetEnclosingPropertyBinder();
        }

        protected override ImmutableArray<object?> BindValues(CancellationToken cancellationToken = default)
        {
            if (ValuesOpt.IsDefault)
            {
                var result = ArrayBuilder<object?>.GetInstance();
                var valueBinders = GetValueBinders(cancellationToken);
                foreach (var valueBinder in valueBinders)
                {
                    var binder = (Binder)valueBinder;
                    var values = binder.Bind(cancellationToken);
                    result.AddRange(values);
                }
                return result.ToImmutableAndFree();
            }
            else
            {
                return ValuesOpt;
            }
        }

        private MetaType ComputeType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (!_type.IsDefault) return _type;
            var modelObjectTypes = PooledHashSet<Type>.GetInstance();
            foreach (var symbol in ContainingDefinedSymbols)
            {
                foreach (var decl in symbol.GetSingleDeclarations(cancellationToken))
                {
                    var mot = decl.ModelObjectType;
                    if (mot is not null) modelObjectTypes.Add(mot);
                }
            }
            if (modelObjectTypes.Count == 0)
            {
                diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, this.Location, $"Could not resolve the containing model object of the property '{_name}'."));
                return typeof(ErrorType);
            }
            if (modelObjectTypes.Count >= 2)
            {
                diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, this.Location, $"Ambiguous containing model object of the property '{_name}': {string.Join(", ", modelObjectTypes.Select(t => t.FullName))}."));
                return typeof(ErrorType);
            }
            var modelObjectType = modelObjectTypes.First();
            modelObjectTypes.Free();
            var module = Compilation.SourceModule;
            var symbolFactory = module.SymbolFactory;
            MetaType propertyType = default;
            if (typeof(Symbol).IsAssignableFrom(modelObjectType))
            {
                var symbolProperty = modelObjectType.GetProperty(this.Name, BindingFlags.Public | BindingFlags.Instance);
                if (symbolProperty is not null)
                {
                    propertyType = symbolProperty.PropertyType;
                    if (propertyType.IsDefaultOrNull)
                    {
                        diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, Location, $"Property '{Name}' of symbol '{modelObjectType}' has no type."));
                    }
                }
                else
                {
                    diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, Location, $"Property '{Name}' of symbol '{modelObjectType}' does not exist."));
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
                        propertyType = modelProperty.Type;
                        if (propertyType.IsDefaultOrNull)
                        {
                            diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, Location, $"Property '{Name}' of model object '{modelObjectType}' has no type."));
                        }
                    }
                    else
                    {
                        diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, Location, $"Property '{Name}' of model object '{modelObjectType}' does not exist."));
                    }
                }
            }
            return propertyType;
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            sb.Append(": [");
            sb.Append(OwnerType.Name);
            sb.Append(".");
            sb.Append(Name);
            sb.Append(": ");
            sb.Append(Type);
            if (!ValuesOpt.IsDefault)
            {
                sb.Append(" = ");
                sb.Append(ValuesOpt);
            }
            sb.Append("]");
            return builder.ToStringAndFree();
        }

        private class ErrorType { }
    }
}
