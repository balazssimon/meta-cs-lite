using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaModel.Model
{
    internal class CustomMetaImplementation : CustomMetaImplementationBase
    {
        public override void Meta(Meta _this)
        {
            _this._voidType.Name = "void";
            _this._boolType.Name = "bool";
            _this._intType.Name = "int";
            _this._stringType.Name = "string";
            _this._typeType.Name = "type";
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
