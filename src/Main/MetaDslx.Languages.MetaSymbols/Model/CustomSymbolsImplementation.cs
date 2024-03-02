using MetaDslx.Languages.MetaModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaSymbols.Model
{
    internal class CustomSymbolsImplementation : CustomSymbolsImplementationBase
    {
        public override string? Declaration_FullName(Declaration _this)
        {
            if (string.IsNullOrEmpty(_this.Namespace)) return _this.Name;
            else return $"{_this.Namespace}.{_this.Name}";
        }

        public override string Declaration_Namespace(Declaration _this)
        {
            return _this.MRootNamespace ?? string.Empty;
        }

    }

}
