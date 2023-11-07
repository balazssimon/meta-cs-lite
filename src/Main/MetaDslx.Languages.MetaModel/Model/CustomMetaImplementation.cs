using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaModel.Model
{
    internal class CustomMetaImplementation : CustomMetaImplementationBase
    {
        public override void Meta(IMeta _this)
        {
            _this.VoidType.Name = "void";
            _this.BoolType.Name = "bool";
            _this.IntType.Name = "int";
            _this.StringType.Name = "string";
            _this.TypeType.Name = "type";
        }

        public override string MetaDeclaration_FullName(MetaDeclaration _this)
        {
            var parent = _this.Parent;
            if (parent is null) return _this.Name;
            else return $"{parent.FullName}.{_this.Name}";
        }

        public override string MetaModel_NamespaceName(MetaModel _this)
        {
            return _this?.Parent?.FullName ?? string.Empty;
        }
    }
}
