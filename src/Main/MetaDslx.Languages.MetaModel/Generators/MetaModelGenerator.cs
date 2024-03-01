using MetaDslx.Languages.MetaModel.Model;
using MetaDslx.Languages.MetaModel.Meta;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Meta;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.CodeGeneration;
using System.Xml.Linq;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Symbols.CSharp;

namespace MetaDslx.Languages.MetaModel.Generators
{
    public partial class MetaModelGenerator
    {
        private bool _isMetaMetaModel;
        private Modeling.Model _model;
        private Model.MetaModel _metaModel;
        private MetaMetaGraph _graph;
        private ImmutableArray<MetaConstant> _constants;
        private ImmutableArray<MetaClass> _classes;
        private ImmutableArray<MetaEnum> _enums;
        private ImmutableArray<IModelObject> _objects;
        private Dictionary<object, string>? _objectNames;

        public MetaModelGenerator(bool isMetaMetaModel, Modeling.Model model, Model.MetaModel metaModel)
        {
            _isMetaMetaModel = isMetaMetaModel;
            _model = model;
            _metaModel = metaModel;
            var metaClasses = _model.Objects.OfType<MetaClass>().Where(mc => mc.MRootNamespace == _metaModel.MRootNamespace).ToImmutableArray();
            _graph = new MetaMetaGraph(metaClasses);
            _classes = _graph.Compute().Select(c => ((MetaMetaClass)c).UnderlyingClass).OrderBy(c => c.Name).ToImmutableArray();
            _enums = _model.Objects.OfType<MetaEnum>().Where(e => e.MRootNamespace == _metaModel.MRootNamespace).OrderBy(e => e.Name).ToImmutableArray();
            _constants = _model.Objects.OfType<MetaConstant>().Where(c => c.MRootNamespace == _metaModel.MRootNamespace).OrderBy(c => c.Name).ToImmutableArray();
            var objects = ArrayBuilder<IModelObject>.GetInstance();
            objects.AddRange(metaModel.GetAllContainedObjects<IModelObject>(includeSelf: true));
            foreach (var cls in _classes)
            {
                objects.AddRange(cls.GetAllContainedObjects<IModelObject>(includeSelf: true));
            }
            foreach (var enm in _enums)
            {
                objects.AddRange(enm.GetAllContainedObjects<IModelObject>(includeSelf: true));
            }
            _objects = objects.ToImmutableAndFree();
        }

        public bool IsMetaMetaModel => _isMetaMetaModel;
        public Modeling.Model Model => _model;
        public Model.MetaModel MetaModel => _metaModel;
        public string Namespace => _metaModel.MRootNamespace;
        public ImmutableArray<MetaConstant> Constants => _constants;
        public ImmutableArray<MetaEnum> Enums => _enums;
        public ImmutableArray<MetaClass> Classes => _classes;
        public ImmutableArray<IModelObject> Objects => _objects;
        public MetaMetaGraph Graph => _graph;
        public ImmutableArray<MetaDslx.CodeAnalysis.Diagnostic> Diagnostics => _graph.Diagnostics;

        public string ToCSharp(object? type)
        {
            type = ExtractMetaType(type);
            if (type is null) return string.Empty;
            if (type is MetaTypeReference typeRef)
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
                    result = $"global::MetaDslx.Modeling.ICollectionSlot<{result}>";
                }
                return result;
            }
            if (type is string stype) return PrimitiveTypeToString(stype);
            if (type is Type t) return $"global::{t.FullName}";
            if (type is MetaClass mc && _classes.Contains(mc))
            {
                return mc.Name;
            }
            if (type is MetaDslx.CodeAnalysis.MetaType mt)
            {
                return $"global::{mt.FullName}";
            }
            if (type is TypeSymbol ts)
            {
                return SymbolDisplayFormat.FullyQualifiedFormat.ToString(ts);
            }
            return type.ToString();
        }

        public string ToCSharpOpType(object? type)
        {
            type = ExtractMetaType(type);
            if (type is null) return string.Empty;
            if (type is MetaTypeReference typeRef)
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
            if (type is string stype) return PrimitiveTypeToString(stype);
            if (type is Type t) return $"global::{t.FullName}";
            if (type is MetaClass mc && _classes.Contains(mc))
            {
                return mc.Name;
            }
            if (type is MetaDslx.CodeAnalysis.MetaType mt)
            {
                return $"global::{mt.FullName}";
            }
            if (type is TypeSymbol ts)
            {
                return SymbolDisplayFormat.FullyQualifiedFormat.ToString(ts);
            }
            return type.ToString();
        }

        public string ToCSharpImpl(object type)
        {
            return ToCSharp(type);
        }

        public bool HasSetter(MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> property)
        {
            return property.HasSetter && !property.Flags.HasFlag(ModelPropertyFlags.ReadOnly) && !property.Flags.HasFlag(ModelPropertyFlags.Collection);
        }

        public string ToCSharp(MetaClass<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> metaClass)
        {
            return $"{MetaModel.Name}.{metaClass.Name}Info";
        }

        public bool IsCollection(MetaPropertySlot<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> slot)
        {
            return slot.Flags.HasFlag(ModelPropertyFlags.Collection);
        }

        public string ToCSharp(MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> property)
        {
            return $"{MetaModel.Name}.{property.DeclaringType.Name}_{property.Name}";
        }

        public string ToCSharp(MetaOperation<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> op)
        {
            return $"{MetaModel.Name}.{op.DeclaringType.Name}_{op.UniqueName}";
        }

        public string ToCSharp(ImmutableArray<MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> properties)
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append("__ImmutableArray.Create<__ModelProperty>(");
            var comma = string.Empty;
            foreach (var property in properties)
            {
                if (string.IsNullOrEmpty(comma)) comma = ", ";
                else sb.Append(comma);
                sb.Append(ToCSharp(property));
            }
            sb.Append(")");
            return builder.ToStringAndFree();
        }

        public string ToCSharp(ImmutableArray<MetaOperation<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> operations)
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append("__ImmutableArray.Create<__ModelOperation>(");
            var comma = string.Empty;
            foreach (var operation in operations)
            {
                if (string.IsNullOrEmpty(comma)) comma = ", ";
                else sb.Append(comma);
                sb.Append(ToCSharp(operation));
            }
            sb.Append(")");
            return builder.ToStringAndFree();
        }

        public string ToCSharp(ModelPropertyFlags flags)
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            var bar = string.Empty;
            foreach (ModelPropertyFlags flag in Enum.GetValues(typeof(ModelPropertyFlags)))
            {
                if (flags.HasFlag(flag))
                {
                    if (string.IsNullOrEmpty(bar)) bar = " | ";
                    else sb.Append(bar);
                    sb.Append($"__ModelPropertyFlags.{flag}");
                }
            }
            return builder.ToStringAndFree();
        }

        public string ToCSharpValue(MetaDslx.CodeAnalysis.MetaType propertyType, object? value)
        {
            if (value is MetaDslx.CodeAnalysis.MetaSymbol ms) value = ms.OriginalValue;
            value = ExtractMetaType(value);
            if (value is null) return "default";
            if (propertyType == typeof(MetaDslx.CodeAnalysis.MetaType) || propertyType == typeof(Type) || propertyType == typeof(TypeSymbol))
            {
                //if (value is MetaPrimitiveType pt) value = pt.Name;
                if (value is null) return "default";
                else if (value is string svalue) return $"typeof({PrimitiveTypeToString(svalue)})";
                else if (value is Type t) return $"typeof(global::{t.FullName})";
                else if (value is TypeSymbol ts) return $"typeof({SymbolDisplayFormat.FullyQualifiedFormat.ToString(ts)})";
                return $"__MetaType.FromModelObject({GetName(value)})";
            }
            if (propertyType == typeof(bool))
            {
                return ((bool)value) ? "true" : "false";
            }
            if (propertyType == typeof(string))
            {
                return StringUtilities.EncodeString(value.ToString());
            }
            if (propertyType == typeof(MetaDslx.CodeAnalysis.MetaSymbol))
            {
                var symbolValue = value.ToString();
                if (value.GetType() == typeof(bool)) symbolValue = symbolValue.ToLower();
                if (value.GetType() == typeof(string)) symbolValue = symbolValue.EncodeString();
                if (value is MetaEnumLiteral lit2) symbolValue = $"{lit2.MParent?.MName}.{lit2.MName}";
                if (value is Symbol sym2)
                {
                    if (sym2.ModelObject is not null) return GetName(sym2.ModelObject);
                    if (sym2.IsCSharpSymbol) symbolValue = sym2.Name.EncodeString();
                }
                return $"__MetaSymbol.FromValue({symbolValue})";
            }
            var type = value.GetType();
            if (type == typeof(bool)) return value.ToString().ToLower();
            if (type == typeof(string)) return value.ToString().EncodeString();
            if (type.IsPrimitive) return value.ToString();
            if (value is Symbol sym)
            {
                if (sym.ModelObject is not null) return GetName(sym.ModelObject);
                if (sym.IsCSharpSymbol) return sym.Name.EncodeString();
            }
            return GetName(value);
        }

        public string ToDefaultValue(MetaDslx.CodeAnalysis.MetaType propertyType, object? value)
        {
            if (propertyType == typeof(MetaDslx.CodeAnalysis.MetaSymbol))
            {
                string? symbolValue = null;
                if (value is MetaEnumLiteral lit2)
                {
                    symbolValue = $"{lit2.MParent?.MName}.{lit2.MName}";
                }
                if (value is DeclarationSymbol sym2)
                {
                    var fullName = SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(sym2);
                    return fullName;
                }
                if (symbolValue is not null)
                {
                    return $"__MetaSymbol.FromValue({symbolValue})";
                }
            }
            if (value is MetaEnumLiteral lit) return $"{lit.MParent?.MName}.{lit.MName}";
            if (value is DeclarationSymbol sym)
            {
                var fullName = SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(sym);
                return fullName;
            }
            return ToCSharpValue(propertyType, value);
        }

        private string PrimitiveTypeToString(string type)
        {
            if (type == "type") return "__MetaType";
            else if (type == "symbol") return "__MetaSymbol";
            else if (type == "object" || type == "bool" || type == "char" || type == "string" ||
                type == "byte" || type == "sbyte" || type == "short" || type == "ushort" ||
                type == "int" || type == "uint" || type == "long" || type == "ulong" ||
                type == "float" || type == "double" || type == "decimal" || type == "void") return type;
            else return $"global::{type}";
        }

        public string ToCSharpValue(ModelProperty property, MetaDslx.CodeAnalysis.MetaSymbol value)
        {
            var propertyType = property.Type;
            return ToCSharpValue(propertyType, value);
        }

        public string GetName(object? obj)
        {
            if (obj is null) return string.Empty;
            if (_objectNames is null)
            {
                var index = 0;
                var objectNames = new Dictionary<object, string>();
                foreach (var mobj in Objects)
                {
                    var mname = $"obj{++index}";
                    objectNames.Add(mobj, mname);
                }
                Interlocked.CompareExchange(ref _objectNames, objectNames, null);
            }
            if (_objectNames.TryGetValue(obj, out var name)) return name;
            else if (obj is IModelObject mobj && _objectNames.TryGetValue(mobj, out var mname)) return mname;
            else return string.Empty;
        }

        private object? ExtractMetaType(object? type)
        {
            if (type is MetaDslx.CodeAnalysis.MetaType camt)
            {
                type = camt.OriginalModelObject;
                if (type is null && camt.MetaKeyword is not null) type = camt.MetaKeyword;
                if (type is null) type = camt.Original;
            }
            return type;
        }

        public string? GetDocumentationComment(IModelObject mobj)
        {
            var node = mobj.MSyntax.AsNode();
            if (node is null) return null;
            var firstToken = node.GetFirstToken(includeDocumentationComments: true).Node as InternalSyntaxToken;
            var trivia = firstToken?.GetLeadingTrivia()?.ToFullString()?.Trim();
            if (trivia is null) return null;
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            var reader = new LineReader(trivia);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line == null) continue;
                var lineStr = line.ToString().Trim();
                if (lineStr.StartsWith("///")) sb.AppendLine(lineStr);
            }
            return builder.ToStringAndFree();
        }
    }
}
