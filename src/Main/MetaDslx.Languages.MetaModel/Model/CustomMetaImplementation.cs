using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaModel.Model
{
    internal class CustomMetaImplementation : CustomMetaImplementationBase
    {
        public override string MetaDeclaration_FullName(MetaDeclaration _this)
        {
            if (string.IsNullOrEmpty(_this.Namespace)) return _this.Name;
            else return $"{_this.Namespace}.{_this.Name}";
        }

        public override string MetaDeclaration_Namespace(MetaDeclaration _this)
        {
            return _this.MRootNamespace ?? string.Empty;
        }

    }
}
