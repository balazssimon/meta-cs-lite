using MetaDslx.Languages.Uml.Model;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UmlGenerator
{
    internal class UmlModelToMetaModelGeneratorExtensions : IUmlModelToMetaModelGeneratorExtensions
    {
        private Dictionary<Class, List<Property>> _declaredAttributes = new Dictionary<Class, List<Property>>();
        private Dictionary<Class, List<Operation>> _declaredOperations = new Dictionary<Class, List<Operation>>();
        private Dictionary<Property, List<Property>> _overridenProperties = new Dictionary<Property, List<Property>>();
        private Dictionary<Operation, List<Operation>> _overridenOperations = new Dictionary<Operation, List<Operation>>();

        public UmlModelToMetaModelGeneratorExtensions()
        {

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

        public List<Property> GetDeclaredAttributes(Class cls)
        {
            if (_declaredAttributes.TryGetValue(cls, out var result)) return result;
            result = new List<Property>();
            result.AddRange(cls.OwnedAttribute);
            /*foreach (var assoc in cls.MModel.Objects.OfType<Association>().Where(assoc => assoc.MemberEnd.Count == 2))
            {
                Property first = assoc.MemberEnd[0];
                Property second = assoc.MemberEnd[1];
                if (first.Type == cls && !result.Contains(second)) result.Add(second);
                if (second.Type == cls && !result.Contains(first)) result.Add(first);
            }*/
            _declaredAttributes.Add(cls, result);
            return result;
        }

        public List<Operation> GetDeclaredOperations(Class cls)
        {
            if (_declaredOperations.TryGetValue(cls, out var result)) return result;
            result = new List<Operation>();
            var attrs = GetDeclaredAttributes(cls);
            foreach (var op in cls.OwnedOperation.Where(op => !attrs.Any(prop => op.Name == prop.Name && prop.IsDerived && !prop.IsDerivedUnion)))
            {
                result.Add(op);
            }
            _declaredOperations.Add(cls, result);
            return result;
        }

        public List<Property> GetOverridenProperties(Property prop)
        {
            if (_overridenProperties.TryGetValue(prop, out var result)) return result;
            result = new List<Property>();
            foreach (var baseProp in prop.RedefinedProperty)
            {
                if (baseProp.Class.Name != prop.Class.Name && baseProp.Name == prop.Name)
                {
                    if (!result.Contains(baseProp))
                    {
                        result.Add(baseProp);
                    }
                }
            }
            foreach (var baseProp in prop.Class.AllAttributes().OfType<Property>())
            {
                if (baseProp.Class.Name != prop.Class.Name && baseProp.Name == prop.Name)
                {
                    if (!result.Contains(baseProp))
                    {
                        result.Add(baseProp);
                    }
                }
            }
            _overridenProperties.Add(prop, result);
            return result;
        }


        public List<Operation> GetOverridenOperations(Operation op)
        {
            if (_overridenOperations.TryGetValue(op, out var result)) return result;
            result = new List<Operation>();
            foreach (var baseOp in op.Class.AllFeatures().OfType<Operation>())
            {
                if (baseOp.Class.Name != op.Class.Name && baseOp.Name == op.Name && baseOp.OwnedParameter.Count == op.OwnedParameter.Count)
                {
                    if (!result.Contains(baseOp))
                    {
                        result.Add(baseOp);
                    }
                }
            }
            _overridenOperations.Add(op, result);
            return result;
        }

        public Property GetOpposite(Property property)
        {
            var assoc = property.Association;
            if (assoc == null || assoc.OwnedEnd.Count > 0) return null;
            Property first = assoc.MemberEnd[0];
            Property second = assoc.MemberEnd[1];
            if (first == property) return second;
            else return first;
        }

        public List<Property> GetOpposites(Property property)
        {
            var associations = property.MModel.Objects.OfType<Association>().Where(assoc => assoc.MemberEnd.Count == 2 && assoc.MemberEnd.Any(me => me.Name == property.Name && me.Type == property.Type));
            var result = new List<Property>();
            foreach (var assoc in associations)
            {
                Property first = assoc.MemberEnd[0];
                Property second = assoc.MemberEnd[1];
                if (first.Name == property.Name && first.Type == property.Type) result.Add(second);
                else result.Add(first);
            }
            return result;
        }
    }
}
