using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Meta
{
    internal class SymbolMetaModel : MetaModel
    {
        public SymbolMetaModel(CSharpTypeSymbol metaModelSymbol)
        {
            
        }

        public override string MName => throw new NotImplementedException();

        public override string MNamespace => throw new NotImplementedException();

        public override ModelVersion MVersion => throw new NotImplementedException();

        public override string MUri => throw new NotImplementedException();

        public override string MPrefix => throw new NotImplementedException();

        public override MetaDslx.Modeling.Model MModel => throw new NotImplementedException();

        public override ImmutableDictionary<MetaType, ModelEnumInfo> MEnumInfosByType => throw new NotImplementedException();

        public override ImmutableDictionary<string, ModelEnumInfo> MEnumInfosByName => throw new NotImplementedException();

        public override ImmutableDictionary<MetaType, ModelClassInfo> MClassInfosByType => throw new NotImplementedException();

        public override ImmutableDictionary<string, ModelClassInfo> MClassInfosByName => throw new NotImplementedException();

        public override ImmutableArray<MetaType> MEnumTypes => throw new NotImplementedException();

        public override ImmutableArray<ModelEnumInfo> MEnumInfos => throw new NotImplementedException();

        public override ImmutableArray<MetaType> MClassTypes => throw new NotImplementedException();

        public override ImmutableArray<ModelClassInfo> MClassInfos => throw new NotImplementedException();

    }
}
