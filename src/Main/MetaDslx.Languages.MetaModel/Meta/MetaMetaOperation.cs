using MetaDslx.CodeAnalysis;
using MetaDslx.Languages.MetaModel.Model;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaDslx.Languages.MetaModel.Meta
{
    public sealed class MetaMetaOperation : MetaOperation<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>
    {
        public MetaMetaOperation(MetaClass<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> declaringType, MetaOperation underlyingOperation)
            : base(declaringType, underlyingOperation)
        {
        }

        public override Location? Location => UnderlyingOperation.MLocation;

        public override string Name => UnderlyingOperation.Name;

        public override string Signature => $"{Name}({string.Join(",", UnderlyingOperation.Parameters.Select(p => CSharpFullNameOf(p.Type)))})";

        private static string CSharpFullNameOf(MetaTypeReference typeRef)
        {
            var result = typeRef.Type.CSharpFullName;
            if (typeRef.IsNullable &&
                typeRef.Type.SpecialType != CodeAnalysis.SpecialType.MetaDslx_CodeAnalysis_MetaType &&
                typeRef.Type.SpecialType != CodeAnalysis.SpecialType.MetaDslx_CodeAnalysis_MetaSymbol)
            {
                result += "?";
            }
            if (typeRef.IsArray)
            {
                result = $"global::System.Collections.Generic.IList<{result}>";
            }
            return result;
        }
    }
}
