using MetaDslx.Languages.Uml.MetaModel;
using MetaDslx.Modeling;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.Uml.CodeGeneration
{
    public partial class UmlModelToMetaModelGenerator
    {
        private MetaDslx.Modeling.Model _model;

        public UmlModelToMetaModelGenerator(MetaDslx.Modeling.Model model)
        {
            _model = model;
        }

        public MetaDslx.Modeling.Model Model => _model;
        public IEnumerable<IModelObject> Objects => _model.Objects;
        public string? Namespace { get; set; }
        public string? ModelName { get; set; }
        public string? Uri { get; set; }
        public string? Prefix { get; set; }


        public string GenerateDefaultValue(Property property)
        {
            if (property.IsDerived || property.IsDerivedUnion) return string.Empty;
            var value = property.DefaultValue;
            if (value == null) return string.Empty;
            string result = null;
            if (value is LiteralBoolean lb) result = lb.Value.ToString().ToLower();
            if (value is LiteralInteger li) result = li.Value.ToString();
            if (value is LiteralNull) result = "null";
            if (value is LiteralReal lr) result = lr.Value.ToString();
            if (value is LiteralUnlimitedNatural lun) result = lun.Value.ToString();
            if (value is LiteralString ls) result = ls.Value.Replace("\\", "\\\\").Replace("\"", "\\\"");
            if (value is InstanceValue iv && iv.Instance is EnumerationLiteral el) result = el.Enumeration.Name + "." + el.Name.ToPascalCase();
            if (result != null) return result;
            else return "/* unhandled default value: " + value.MId.DisplayTypeName + " */";
        }

        public IEnumerable<string> CommentLines(string text, bool escapeHtml)
        {
            if (text == null) return new string[0];
            if (escapeHtml) text = text.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("'", "&apos;").Replace("\"", "&quot;");
            var result = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return result;
        }

        public bool IsCollection(MultiplicityElement me)
        {
            return me.Upper < 0 || me.Upper > 1;
        }

        public Property GetOpposite(Property property)
        {
            var assoc = property.Association;
            if (assoc == null) return null;
            Property first = assoc.MemberEnd[0];
            Property second = assoc.MemberEnd[1];
            if (first == property) return second;
            else return first;
        }
    }
}
