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

        public override Modeling.Model MModel => throw new NotImplementedException();

        public override ImmutableArray<MetaType> MModelObjectTypes => throw new NotImplementedException();

        public override ImmutableArray<ModelObjectInfo> MModelObjectInfos => throw new NotImplementedException();

        public override bool Contains(MetaType modelObjectType)
        {
            throw new NotImplementedException();
        }

        public override bool Contains(string modelObjectTypeName)
        {
            throw new NotImplementedException();
        }

        public override bool TryGetInfo(MetaType modelObjectType, out ModelObjectInfo? info)
        {
            throw new NotImplementedException();
        }

        public override bool TryGetInfo(string modelObjectTypeName, out ModelObjectInfo? info)
        {
            throw new NotImplementedException();
        }
    }
}
