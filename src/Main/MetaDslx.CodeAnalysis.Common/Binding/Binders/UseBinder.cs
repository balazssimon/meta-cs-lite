using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class UseBinder : Binder, IUseBinder
    {
        private readonly bool _isType;
        private readonly bool _isSymbol;
        private readonly ImmutableArray<MetaType> _types;
        private readonly ImmutableArray<string> _prefixes;
        private readonly ImmutableArray<string> _suffixes;

        public UseBinder(ImmutableArray<Type> types = default, ImmutableArray<string> prefixes = default, ImmutableArray<string> suffixes = default)
        {
            _isType = types.Contains(typeof(MetaType)) || types.Contains(typeof(Type));
            _isSymbol = types.Contains(typeof(MetaSymbol)) || types.Contains(typeof(object));
            _types = types.SelectAsArray(t => MetaType.FromType(t));
            _prefixes = prefixes;
            _suffixes = suffixes;
        }

        public ImmutableArray<MetaType> Types => _types;
        public ImmutableArray<string> Prefixes => _prefixes;
        public ImmutableArray<string> Suffixes => _suffixes;
        public List<Type> TypesList { get; }

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            return ImmutableArray<SingleDeclaration>.Empty;
        }

        protected override void CollectNameBinders(ArrayBuilder<INameBinder> nameBinders, CancellationToken cancellationToken)
        {
        }

        protected override void AdjustFinalLookupContext(LookupContext context)
        {
            if (!_prefixes.IsDefaultOrEmpty) context.SetNamePrefixes(_prefixes);
            if (!_suffixes.IsDefaultOrEmpty) context.SetNameSuffixes(_suffixes);
            context.Validators.Add(this);
        }

        protected override bool IsViable(LookupContext context, DeclaredSymbol symbol)
        {
            if (symbol is null) return false;
            if (_types.IsDefaultOrEmpty) return true;
            if (_isType) return symbol is TypeSymbol;
            if (_isSymbol) return true;
            if (symbol is IModelSymbol modelSymbol)
            {
                foreach (var type in _types)
                {
                    if (type.IsAssignableFrom(modelSymbol.ModelObjectType)) return true;
                }
            }
            foreach (var type in _types)
            {
                if (symbol is TypeSymbol typeSymbol && type.IsAssignableFrom(typeSymbol)) return true;
                if (type.IsAssignableFrom(symbol.GetType())) return true;
            }
            return false;
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            sb.Append(": [");
            var comma = false;
            foreach (var type in _types)
            {
                if (comma) sb.Append(", ");
                else comma = true;
                sb.Append(type.Name);
            }
            sb.Append("]");
            if (!_prefixes.IsDefaultOrEmpty)
            {
                sb.Append("[");
                comma = false;
                foreach (var prefix in _prefixes)
                {
                    if (comma) sb.Append("*, ");
                    else comma = true;
                    sb.Append(prefix);
                }
                sb.Append("*]");
            }
            if (!_suffixes.IsDefaultOrEmpty)
            {
                sb.Append("[*");
                comma = false;
                foreach (var suffix in _suffixes)
                {
                    if (comma) sb.Append(", *");
                    else comma = true;
                    sb.Append(suffix);
                }
                sb.Append("]");
            }
            return builder.ToStringAndFree();
        }
    }
}
