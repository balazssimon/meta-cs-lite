using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis
{
    public struct MetaSymbol : IEquatable<MetaSymbol>
    {
        private object? _original;

        private MetaSymbol(Symbol symbol)
        {
            _original = symbol;
        }

        private MetaSymbol(IModelObject modelObject)
        {
            _original = modelObject;
        }

        private MetaSymbol(object value)
        {
            _original = value;
        }

        public static MetaSymbol FromSymbol(Symbol symbol) => new MetaSymbol(symbol);
        public static MetaSymbol FromModelObject(IModelObject modelObject) => new MetaSymbol(modelObject);
        public static MetaSymbol FromValue(object value) => new MetaSymbol(value);

        public bool InterlockedInitialize(MetaSymbol value)
        {
            return Interlocked.CompareExchange(ref _original, value._original, null) == null;
        }

        public bool IsNull => _original is null;
        public bool IsSymbol => _original is Symbol;
        public bool IsModelObject => _original is IModelObject;
        public bool IsValue => !IsSymbol && !IsModelObject;

        public IModelObject? OriginalModelObject => _original as IModelObject;
        public Symbol? OriginalSymbol => _original as Symbol;
        public object? OriginalValue => _original;

        public string Name
        {
            get
            {
                if (IsSymbol) return OriginalSymbol.Name;
                if (IsModelObject) return OriginalModelObject.Name;
                return null;
            }
        }

        public string FullName
        {
            get
            {
                if (IsSymbol) return SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(OriginalSymbol);
                if (IsModelObject) return GetModelObjectFullName(OriginalModelObject);
                return Name;
            }
        }

        public Symbol? AsSymbol(Compilation compilation)
        {
            if (compilation is null) return OriginalSymbol;
            if (_original is DeclaredSymbol declared)
            {
                if (declared.DeclaringCompilation == compilation) return declared;
                else return compilation.ResolveType(SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(declared));
            }
            if (IsModelObject)
            {
                return compilation.ResolveModelObject(OriginalModelObject);
            }
            return OriginalSymbol;
        }

        public IModelObject? AsModelObject(Compilation compilation)
        {
            throw new NotImplementedException();
        }

        public IModelObject? AsModelObject(Model model)
        {
            throw new NotImplementedException();
        }

        public IModelObject? AsModelObject(ModelGroup modelGroup)
        {
            throw new NotImplementedException();
        }

        public bool Equals(MetaSymbol other)
        {
            return object.ReferenceEquals(_original, other._original);
        }

        public override bool Equals(object obj)
        {
            if (obj is MetaSymbol ms) return Equals(ms);
            else return this.IsNull && obj is null;
        }

        public override int GetHashCode()
        {
            return _original?.GetHashCode() ?? base.GetHashCode();
        }

        public override string ToString()
        {
            return _original?.ToString();
        }

        public static bool operator ==(MetaSymbol lhs, MetaSymbol rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(MetaSymbol lhs, MetaSymbol rhs)
        {
            return !lhs.Equals(rhs);
        }

        public static implicit operator MetaSymbol(Symbol symbol)
        {
            return MetaSymbol.FromSymbol(symbol);
        }

        public static implicit operator MetaSymbol(ModelObject modelObject)
        {
            return MetaSymbol.FromModelObject(modelObject);
        }

        internal static string GetModelObjectFullName(IModelObject modelObject)
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            var current = modelObject;
            sb.Append(current.Name);
            while (current is not null)
            {
                var parent = current.Parent;
                if (!string.IsNullOrEmpty(parent?.Name))
                {
                    sb.Insert(0, ".");
                    sb.Insert(0, parent.Name);
                }
                current = parent;
            }
            return builder.ToStringAndFree();
        }
    }
}
