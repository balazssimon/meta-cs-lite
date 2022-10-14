using MetaDslx.Languages.Uml.MetaModel;
using MetaDslx.Modeling;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaDslx.Languages.Uml.CodeGeneration
{
    public partial class UmlModelToMetaModelGenerator
    {
        private MetaDslx.Modeling.Model _model;
        private Dictionary<Class, UmlClass> _umlClasses = new Dictionary<Class, UmlClass>();

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

        public string GetTypeName(MetaDslx.Languages.Uml.MetaModel.Type t)
        {
            switch (t.Name)
            {
                case "Boolean": return "bool";
                case "String": return "string";
                case "Integer": return "int";
                case "Real": return "double";
                case "UnlimitedNatural": return "long";
                default: return t.Name;
            }
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
            else return "/* unhandled default value: " + ((IModelObject)value).MetaType.Name + " */";
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

        public bool IsNullable(MetaDslx.Languages.Uml.MetaModel.Type t, MultiplicityElement me)
        {
            if (t.Name == "Boolean" || t.Name == "Integer" || t.Name == "Real" || t.Name == "String" || t.Name == "UnlimitedNatural") return false;
            return me.Lower == 0 && me.Upper == 1;
        }

        public UmlClass GetUmlClass(Class cls)
        {
            if (_umlClasses.TryGetValue(cls, out var result)) return result;
            result = new UmlClass();
            result.Class = cls;
            _umlClasses.Add(cls, result);
            foreach (var attr in cls.OwnedAttribute)
            {
                var uprop = AddUmlProperty(result, attr);
                if (attr.Opposite is not null)
                {
                    uprop.Opposites.Add(attr.Opposite.Name);
                }
            }
            /*/
            foreach (var assoc in cls.MModel.Objects.OfType<Association>().Where(assoc => assoc.MemberEnd.Count == 2))
            {
                Property first = assoc.MemberEnd[0];
                Property second = assoc.MemberEnd[1];
                if (first.Type == cls)
                {
                    var existing = result.Attributes.Where(attr => attr.Name == second.Name).FirstOrDefault();
                    if (existing == null) existing = AddUmlProperty(result, second);
                    if (!existing.Opposites.Contains(first.Name)) existing.Opposites.Add(first.Name);
                }
                if (second.Type == cls)
                {
                    var existing = result.Attributes.Where(attr => attr.Name == first.Name).FirstOrDefault();
                    if (existing == null) existing = AddUmlProperty(result, first);
                    if (!existing.Opposites.Contains(second.Name)) existing.Opposites.Add(second.Name);
                }
            }
            //*/
            foreach (var prop in result.Attributes)
            {
                foreach (var baseProp in prop.Property.RedefinedProperty)
                {
                    if ((baseProp.Class == null || baseProp.Class.Name != cls.Name) && baseProp.Name == prop.Name)
                    {
                        if (!prop.Overrides.Contains(baseProp))
                        {
                            prop.Overrides.Add(baseProp);
                        }
                    }
                }
                foreach (var baseProp in cls.AllAttributes().OfType<Property>())
                {
                    if ((baseProp.Class == null || baseProp.Class.Name != cls.Name) && baseProp.Name == prop.Name)
                    {
                        if (!prop.Overrides.Contains(baseProp))
                        {
                            prop.Overrides.Add(baseProp);
                        }
                    }
                }
            }
            foreach (var op in cls.OwnedOperation)
            {
                var derivedProp = result.Attributes.Where(prop => prop.Name == op.Name && prop.Property.IsDerived && !prop.Property.IsDerivedUnion).FirstOrDefault();
                if (derivedProp != null)
                {
                    derivedProp.Operation = op;
                }
                else
                {
                    var uop = AddUmlOperation(result, op);
                    var baseClasses = new List<Class>(cls.Generalization.Select(g => g.General).OfType<Class>());
                    while (baseClasses.Count > 0)
                    {
                        var baseClass = baseClasses[0];
                        baseClasses.RemoveAt(0);
                        baseClasses.AddRange(baseClass.Generalization.Select(g => g.General).OfType<Class>());
                        foreach (var baseOp in baseClass.OwnedMember.OfType<Operation>())
                        {
                            if (baseOp.Class.Name != op.Class.Name && baseOp.Name == op.Name && baseOp.OwnedParameter.Count == op.OwnedParameter.Count)
                            {
                                if (!uop.Overrides.Contains(baseOp))
                                {
                                    uop.Overrides.Add(baseOp);
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        private UmlProperty AddUmlProperty(UmlClass ucls, Property prop)
        {
            var existing = ucls.Attributes.Where(attr => attr.Name == prop.Name).FirstOrDefault();
            if (existing != null) return existing;
            var uprop = new UmlProperty() { Class = ucls, Property = prop, Name = prop.Name };
            ucls.Attributes.Add(uprop);
            return uprop;
        }

        private UmlOperation AddUmlOperation(UmlClass ucls, Operation op)
        {
            var existing = ucls.Operations.Where(attr => attr.Name == op.Name).FirstOrDefault();
            if (existing != null) return existing;
            var uop = new UmlOperation() { Class = ucls, Operation = op, Name = op.Name };
            ucls.Operations.Add(uop);
            return uop;
        }

    }

    public class UmlClass
    {
        public Class Class;
        public List<UmlProperty> Attributes = new List<UmlProperty>();
        public List<UmlOperation> Operations = new List<UmlOperation>();
    }

    public class UmlProperty
    {
        public string Name;
        public UmlClass Class;
        public Property Property;
        public Operation Operation;
        public List<Property> Overrides = new List<Property>();
        public List<string> Opposites = new List<string>();
    }

    public class UmlOperation
    {
        public string Name;
        public UmlClass Class;
        public Operation Operation;
        public List<Operation> Overrides = new List<Operation>();
    }
}
