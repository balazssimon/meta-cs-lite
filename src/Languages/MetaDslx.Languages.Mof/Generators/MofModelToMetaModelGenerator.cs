using MetaDslx.Modeling;
using MetaDslx.Languages.Mof.Model;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Immutable;
using MetaDslx.CodeGeneration;
using MetaDslx.CodeAnalysis.PooledObjects;

namespace MetaDslx.Languages.Mof.Generator
{
    using Model = MetaDslx.Modeling.Model;

    public partial class MofModelToMetaModelGenerator
    {
        private readonly Model _model;

        public MofModelToMetaModelGenerator(Model mofModel)
        {
            _model = mofModel;
        }

        public Model Model => _model;
        public IEnumerable<IModelObject> Objects => _model.Objects;
        public IEnumerable<PrimitiveType> PrimitiveTypes => _model.Objects.OfType<PrimitiveType>();
        public IEnumerable<Enumeration> Enums => _model.Objects.OfType<Enumeration>();
        public IEnumerable<Class> Classes => _model.Objects.OfType<Class>();
        public IEnumerable<Association> Associations => _model.Objects.OfType<Association>();

        public ImmutableArray<Property> GetAssociationProperties(Class cls)
        {
            return ImmutableArray<Property>.Empty;
            /*var result = ArrayBuilder<Property>.GetInstance();
            foreach (var assoc in Associations.Where(a => a.MemberEnd.Any(e => e.Type == cls)))
            {
                foreach (var prop in assoc.MemberEnd.Where(e => e.Type != cls))
                {
                    if (!result.Contains(prop)) result.Add(prop);
                }
            }
            return result.ToImmutableAndFree();*/
        }

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
            if (value is LiteralString ls) result = ls.Value.EncodeString();
            if (value is InstanceValue iv && iv.Instance is EnumerationLiteral el) result = el.Enumeration.Name + "." + el.Name.ToPascalCase();
            if (result != null) return $" = {result}";
            else return "/* unhandled default value: " + value.MInfo.MetaType + " */";
        }

        public ImmutableArray<string> CommentLines(Element element, bool escapeHtml)
        {
            if (element == null) return ImmutableArray<string>.Empty;
            var result = ArrayBuilder<string>.GetInstance();
            foreach (var comment in element.OwnedComment)
            {
                foreach (var body in comment.Body)
                {
                    if (string.IsNullOrWhiteSpace(body)) continue;
                    var reader = new LineReader(body);
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line == null) break;
                        var lineStr = line.ToString();
                        if (escapeHtml) lineStr = lineStr.EncodeHtml();
                        result.Add(lineStr);
                    }
                }
            }
            return result.ToImmutableAndFree();
        }

        public ImmutableArray<string> CommentLines(string body, bool escapeHtml)
        {
            if (string.IsNullOrWhiteSpace(body)) return ImmutableArray<string>.Empty;
            var result = ArrayBuilder<string>.GetInstance();
            var reader = new LineReader(body);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line == null) break;
                var lineStr = line.ToString();
                if (escapeHtml) lineStr = lineStr.EncodeHtml();
                result.Add(lineStr);
            }
            return result.ToImmutableAndFree();
        }

        public string GeneratePrimitiveType(MetaDslx.Languages.Mof.Model.Type type)
        {
            switch (type.Name)
            {
                case "Boolean": return "bool";
                case "String": return "string";
                case "Integer": return "int";
                case "Real": return "double";
                case "UnlimitedNatural": return "int";
                default: return type.Name;
            }
        }

        public bool IsPropertyImplementation(Operation op)
        {
            foreach (var prop in op.Class.OwnedAttribute)
            {
                if (op.Name == prop.Name && prop.IsDerived && !prop.IsDerivedUnion) return true;
            }
            return false;
        }
    }
}
