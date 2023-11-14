using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    internal class ImportedMetaTypeSymbol : TypeSymbol
    {
        private readonly MetaModel _metaModel;
        private readonly MetaType _metaType;

        public ImportedMetaTypeSymbol(DeclaredSymbol container, MetaModel metaModel, MetaType metaType) 
            : base(container)
        {
            _metaModel = metaModel;
            _metaType = metaType;
        }

        public MetaModel MetaModel => _metaModel;
        public MetaType MetaType => _metaType;

        public override ImmutableArray<Location> Locations => ContainingSymbol.Locations;

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _metaType.Name;
        }
    }
}
