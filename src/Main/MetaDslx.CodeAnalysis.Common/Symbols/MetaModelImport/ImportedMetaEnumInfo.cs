using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.MetaModelImport
{
    internal class ImportedMetaEnumInfo : ModelEnumInfo
    {
        private readonly ImportedMetaModel _metaModel;
        private readonly CSharpTypeSymbol _underlyingType;
        private ImmutableArray<string> _literals;
        private ImmutableDictionary<string, MetaSymbol> _literalsByName;

        public ImportedMetaEnumInfo(ImportedMetaModel metaModel, CSharpTypeSymbol underlyingType)
        {
            _metaModel = metaModel;
            _underlyingType = underlyingType;
        }

        public override MetaModel MetaModel => _metaModel;

        public override MetaType MetaType => _underlyingType;

        public override ImmutableArray<string> Literals
        {
            get
            {
                ComputeLiterals();
                return _literals;
            }
        }

        protected override ImmutableDictionary<string, MetaSymbol> LiteralsByName
        {
            get
            {
                ComputeLiterals();
                return _literalsByName;
            }
        }

        private void ComputeLiterals()
        {
            if (!_literals.IsDefault) return;
            var literals = ArrayBuilder<string>.GetInstance();
            var literalsByName = ImmutableDictionary.CreateBuilder<string, MetaSymbol>();
            foreach (var literal in _underlyingType.Members)
            {
                literals.Add(literal.Name);
                literalsByName.Add(literal.Name, literal);
            }
            Interlocked.CompareExchange(ref _literalsByName, literalsByName.ToImmutable(), null);
            ImmutableInterlocked.InterlockedInitialize(ref _literals, literals.ToImmutableAndFree());
        }
    }
}
