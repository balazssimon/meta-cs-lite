using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Meta
{
    internal class SymbolMetaModel : MetaModel
    {
        public override string Name => throw new NotImplementedException();

        public override string Namespace => throw new NotImplementedException();

        public override ModelVersion Version => throw new NotImplementedException();

        public override string Uri => throw new NotImplementedException();

        public override string Prefix => throw new NotImplementedException();

        public override Modeling.Model Model => throw new NotImplementedException();

        public override ImmutableArray<Type> ModelObjectTypes => throw new NotImplementedException();

        public override ImmutableArray<ModelObjectInfo> ModelObjectInfos => throw new NotImplementedException();

        public override bool Contains(Type modelObjectType)
        {
            throw new NotImplementedException();
        }

        public override bool Contains(string modelObjectTypeName)
        {
            throw new NotImplementedException();
        }

        public override bool TryGetInfo(Type modelObjectType, out ModelObjectInfo? info)
        {
            throw new NotImplementedException();
        }

        public override bool TryGetInfo(string modelObjectTypeName, out ModelObjectInfo? info)
        {
            throw new NotImplementedException();
        }
    }
}
