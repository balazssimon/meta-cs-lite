using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis
{
    using INamedTypeSymbol = Microsoft.CodeAnalysis.INamedTypeSymbol;


    public struct MetaSymbol : IEquatable<MetaSymbol>
    {
        public static readonly MetaSymbol Null = new MetaSymbol((object?)null);
        private static readonly object? DefaultValue = null;
        private static readonly object? NullValue = new object();
        private object? _original;

        private MetaSymbol(Symbol? symbol)
        {
            _original = symbol ?? NullValue;
        }

        private MetaSymbol(IModelObject? modelObject)
        {
            _original = modelObject ?? NullValue;
        }

        private MetaSymbol(object? value)
        {
            if (value is MetaSymbol metaSymbol) _original = metaSymbol._original;
            else _original = value ?? NullValue;
        }

        public static MetaSymbol FromSymbol(Symbol? symbol) => new MetaSymbol(symbol);
        public static MetaSymbol FromModelObject(IModelObject? modelObject) => new MetaSymbol(modelObject);
        public static MetaSymbol FromValue(object? value) => new MetaSymbol(value);

        public bool InterlockedInitialize(MetaSymbol value)
        {
            return Interlocked.CompareExchange(ref _original, value._original, DefaultValue) == DefaultValue;
        }

        public bool IsDefault => _original == DefaultValue;
        public bool IsNull => _original == NullValue;
        public bool IsDefaultOrNull => IsDefault || IsNull;
        public bool IsSymbol => _original is Symbol;
        public bool IsModelObject => _original is IModelObject;
        public bool IsValueOnly => !IsDefaultOrNull && !IsSymbol && !IsModelObject;

        public IModelObject? OriginalModelObject => _original as IModelObject;
        public Symbol? OriginalSymbol => _original as Symbol;
        public object? OriginalValue => IsDefaultOrNull ? null : _original;

        public string? Name
        {
            get
            {
                if (IsSymbol) return OriginalSymbol.Name;
                if (IsModelObject) return OriginalModelObject.MName;
                return null;
            }
        }

        public string? FullName
        {
            get
            {
                if (IsSymbol) return SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(OriginalSymbol);
                if (IsModelObject) return GetModelObjectFullName(OriginalModelObject);
                return Name;
            }
        }

        public MetaType Type
        {
            get
            {
                if (IsDefault) return default;
                if (IsNull) return MetaType.Null;
                if (IsModelObject)
                {
                    return OriginalModelObject.MInfo.MetaType;
                }
                else if (IsSymbol)
                {
                    if (_original is ICSharpSymbol csharpSymbol)
                    {
                        var parent = MetaType.FromTypeSymbol(OriginalSymbol?.ContainingSymbol as TypeSymbol);
                        if (parent.IsEnum) return parent;
                    }
                }
                return _original?.GetType();
            }
        }

        public Symbol? AsSymbol(Compilation compilation)
        {
            if (IsSymbol) return OriginalSymbol;
            if (IsModelObject) return compilation.ResolveModelObject(OriginalModelObject);
            return OriginalSymbol;
        }

        public IModelObject? AsModelObject()
        {
            return _original is IModelObject mobj ? mobj : (_original as IModelSymbol)?.ModelObject;
        }

        public IModelObject? AsModelObject(Compilation compilation)
        {
            return AsModelObject();
            // TODO
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
            if (IsDefault) return "default";
            if (IsNull) return "null";
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
            sb.Append(current.MName);
            while (current is not null)
            {
                var parent = current.MParent;
                if (!string.IsNullOrEmpty(parent?.MName))
                {
                    sb.Insert(0, ".");
                    sb.Insert(0, parent.MName);
                }
                current = parent;
            }
            return builder.ToStringAndFree();
        }
    }
}
