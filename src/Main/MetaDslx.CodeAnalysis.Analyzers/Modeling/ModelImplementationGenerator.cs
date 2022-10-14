using MetaDslx.CodeGeneration;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace MetaDslx.CodeAnalysis.Analyzers.Modeling
{
    internal static class ModelImplementationGenerator
    {
        private const string IMetaModelType = "global::MetaDslx.Modeling.IMetaModel";
        private const string IModelType = "global::MetaDslx.Modeling.IModel";
        private const string ModelType = "global::MetaDslx.Modeling.Model";
        private const string ModelVersionType = "global::MetaDslx.Modeling.ModelVersion";
        private const string IModelObjectType = "global::MetaDslx.Modeling.IModelObject";
        private const string ModelObjectType = "global::MetaDslx.Modeling.ModelObject";
        private const string IModelFactoryType = "global::MetaDslx.Modeling.IModelFactory";
        private const string ModelFactoryType = "global::MetaDslx.Modeling.ModelFactory";
        private const string ModelExceptionType = "global::MetaDslx.Modeling.ModelException";
        private const string ModelPropertyType = "global::MetaDslx.Modeling.ModelProperty";
        private const string ModelPropertyFlagsType = "global::MetaDslx.Modeling.ModelPropertyFlags";
        private const string ModelPropertyInfoType = "global::MetaDslx.Modeling.ModelPropertyInfo";
        private const string ModelPropertySlotType = "global::MetaDslx.Modeling.ModelPropertySlot";
        private const string ModelObjectListType = "global::MetaDslx.Modeling.ModelObjectList";
        private const string ListType = "global::System.Collections.Generic.List";
        private const string DictionaryType = "global::System.Collections.Generic.Dictionary";
        private const string ImmutableArrayType = "global::System.Collections.Immutable.ImmutableArray";

        public static string Generate(ImmutableArray<MetaModel> metaModels)
        {
            var cb = CodeBuilder.GetInstance();
            foreach (var metaModel in metaModels)
            {
                Generate(cb, metaModel);
                cb.WriteLine();
            }
            return cb.ToStringAndFree();
        }

        private static void Generate(CodeBuilder cb, MetaModel metaModel)
        {
            cb.WriteLine("#nullable enable");
            cb.WriteLine();
            cb.WriteLine($"namespace {metaModel.NamespaceName}");
            cb.WriteLine("{");
            cb.Push();
            GenerateMetaModel(cb, metaModel);
            cb.WriteLine();
            GenerateMetaModelFactory(cb, metaModel);
            cb.WriteLine();
            foreach (var metaClass in metaModel.MetaClasses)
            {
                GenerateMetaClassInterface(cb, metaClass);
                cb.WriteLine();
            }
            cb.WriteLine("namespace Internal");
            cb.WriteLine("{");
            cb.Push();
            GenerateMetaModelImplementation(cb, metaModel);
            cb.WriteLine();
            foreach (var metaClass in metaModel.MetaClasses.Where(mc => !mc.IsAbstract))
            {
                GenerateMetaClassImplementation(cb, metaClass);
                cb.WriteLine();
            }
            cb.Pop();
            cb.WriteLine("}");
            cb.Pop();
            cb.WriteLine("}");
        }

        private static void GenerateMetaModel(CodeBuilder cb, MetaModel metaModel)
        {
            cb.WriteLine($"public partial interface {metaModel.Name} : {IMetaModelType}");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"public static {metaModel.Name} Instance => {metaModel.FullyQualifiedMetaModelImplName}.Instance;");
            cb.Pop();
            cb.WriteLine("}");
        }

        private static void GenerateMetaModelFactory(CodeBuilder cb, MetaModel metaModel)
        {
            cb.WriteLine($"public partial class {metaModel.FactoryName} : {IModelFactoryType}");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"private {IModelType} _model;");
            cb.WriteLine();
            cb.WriteLine($"public {metaModel.FactoryName}({ModelType} model)");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine("_model = model;");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine($"{IModelType} {IModelFactoryType}.Model => _model;");
            cb.WriteLine();
            cb.WriteLine($"{IMetaModelType} {IModelFactoryType}.MetaModel => {metaModel.Name}.Instance;");
            cb.WriteLine();
            cb.WriteLine($"{IModelObjectType} {IModelFactoryType}.Create(global::System.Type type, string? id)");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"return (({IModelFactoryType})this).Create(type.Name);");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine($"{IModelObjectType} {IModelFactoryType}.Create(string type, string? id)");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"switch (type)");
            cb.WriteLine("{");
            cb.Push();
            foreach (var metaClass in metaModel.MetaClasses.Where(mc => !mc.IsAbstract))
            {
                cb.WriteLine($"case \"{metaClass.Name}\": return ({IModelObjectType}){metaClass.Name}(id);");
            }
            cb.Write($"default: throw new {ModelExceptionType}($\"");
            cb.Write("Unknown type '{type}' in metamodel ");
            cb.WriteLine($"'{metaModel.Name}'\");");
            cb.Pop();
            cb.WriteLine("}");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            foreach (var metaClass in metaModel.MetaClasses.Where(mc => !mc.IsAbstract))
            {
                cb.WriteLine($"public {metaClass.FullyQualifiedName} {metaClass.Name}(string? id = null)");
                cb.WriteLine("{");
                cb.Push();
                cb.WriteLine($"var result = new {metaClass.FullyQualifiedImplName}(id);");
                cb.WriteLine($"_model.AddObject(result);");
                cb.WriteLine("return result;");
                cb.Pop();
                cb.WriteLine("}");
                cb.WriteLine();
            }
            cb.Pop();
            cb.WriteLine("}");
        }

        private static void GenerateMetaClassInterface(CodeBuilder cb, MetaClass metaClass)
        {
            cb.WriteLine($"public partial interface {metaClass.Name}");
            cb.WriteLine("{");
            cb.Push();
            foreach (var prop in metaClass.DeclaredProperties)
            {
                cb.Write($"public static readonly {ModelPropertyType} {prop.PropertyName} = new {ModelPropertyType}(typeof({metaClass.FullyQualifiedName}), nameof({prop.Name}), typeof({prop.Type?.ToDisplayString(NullableFlowState.None)}), {prop.CSharpDefaultValue}, ");
                GenerateModelPropertyFlags(cb, prop.Flags);
                cb.WriteLine(");");
            }
            var newKeyword = metaClass.IsRoot ? "" : "new ";
            cb.Write($"public static {newKeyword}readonly {ImmutableArrayType}<{ModelPropertyType}> MDeclaredProperties = ");
            GeneratePropertyArray(cb, metaClass.DeclaredProperties);
            cb.WriteLine(";");
            cb.Write($"public static {newKeyword}readonly {ImmutableArrayType}<{ModelPropertyType}> MAllDeclaredProperties = ");
            GeneratePropertyArray(cb, metaClass.AllDeclaredProperties);
            cb.WriteLine(";");
            cb.Write($"public static {newKeyword}readonly {ImmutableArrayType}<{ModelPropertyType}> MPublicProperties = ");
            GeneratePropertyArray(cb, metaClass.PublicProperties);
            cb.WriteLine(";");
            cb.Pop();
            cb.WriteLine("}");
        }

        private static void GeneratePropertyArray(CodeBuilder cb, ImmutableArray<MetaProperty> properties)
        {
            if (properties.Length > 0)
            {
                cb.Write($"{ImmutableArrayType}.Create<{ModelPropertyType}>(");
                var comma = "";
                foreach (var prop in properties)
                {
                    cb.Write(comma);
                    cb.Write(prop.FullyQualifiedPropertyName);
                    comma = ", ";
                }
                cb.Write(")");
            }
            else
            {
                cb.Write($"{ImmutableArrayType}<{ModelPropertyType}>.Empty");
            }
        }

        private static void GenerateModelPropertyFlags(CodeBuilder cb, ModelPropertyFlags flags)
        {
            var empty = true;
            foreach (ModelPropertyFlags flag in Enum.GetValues(typeof(ModelPropertyFlags)))
            {
                if (flag != ModelPropertyFlags.None && flags.HasFlag(flag))
                {
                    if (!empty) cb.Write(" | ");
                    cb.Write(ModelPropertyFlagsType);
                    cb.Write(".");
                    cb.Write(Enum.GetName(typeof(ModelPropertyFlags), flag));
                    empty = false;
                }
            }
            if (empty) cb.Write($"{ModelPropertyFlagsType}.None");
        }

        private static void GenerateMetaModelImplementation(CodeBuilder cb, MetaModel metaModel)
        {
            cb.WriteLine($"public partial class {metaModel.MetaModelImplName} : {metaModel.Name}");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"public static readonly {metaModel.MetaModelImplName} Instance = new {metaModel.MetaModelImplName}();");
            cb.WriteLine();
            cb.WriteLine($"private {ModelVersionType} _version;");
            cb.WriteLine();
            cb.WriteLine($"private {metaModel.MetaModelImplName}()");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"_version = new {ModelVersionType}({metaModel.Version.Major}, {metaModel.Version.Minor});");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine($"public string Name => \"{metaModel.Name}\";");
            cb.WriteLine($"public string FullName => \"{metaModel.ModelInterface.ToDisplayString()}\";");
            cb.WriteLine($"public {ModelVersionType} Version => _version;");
            cb.WriteLine($"public string Uri => \"{metaModel.Uri}\";");
            cb.WriteLine($"public string Prefix => \"{metaModel.Prefix}\";");
            cb.WriteLine();
            cb.WriteLine($"{IModelFactoryType} {IMetaModelType}.CreateFactory({IModelType} model) => new {metaModel.FullyQualifiedFactoryName}(({ModelType})model);");
            cb.Pop();
            cb.WriteLine("}");
        }

        private static void GenerateMetaClassImplementation(CodeBuilder cb, MetaClass metaClass)
        {
            cb.WriteLine($"internal partial class {metaClass.ImplName} : global::MetaDslx.Modeling.ModelObject, {metaClass.FullyQualifiedName}");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"private static readonly {DictionaryType}<{ModelPropertyType}, {ModelPropertyInfoType}> s_PropertyInfo =");
            cb.Push();
            cb.WriteLine($"new {DictionaryType}<{ModelPropertyType}, {ModelPropertyInfoType}>()");
            cb.Push();
            cb.WriteLine("{");
            cb.Push();
            foreach (var prop in metaClass.AllDeclaredProperties)
            {
                var slot = metaClass.GetSlot(prop);
                cb.WriteLine($"[{prop.FullyQualifiedPropertyName}] = new {ModelPropertyInfoType}(");
                cb.Push();
                cb.Write($"slot: new {ModelPropertySlotType}({slot.SlotProperty.FullyQualifiedPropertyName}, ");
                GeneratePropertyArray(cb, slot.SlotProperties);
                cb.Write(", ");
                cb.Write(slot.SlotProperty.CSharpDefaultValue);
                cb.Write(", ");
                GenerateModelPropertyFlags(cb, slot.Flags);
                cb.WriteLine("),");
                cb.Write($"oppositeProperties: ");
                GeneratePropertyArray(cb, prop.OppositeProperties);
                cb.WriteLine(",");
                cb.Write($"subsettedProperties: ");
                GeneratePropertyArray(cb, prop.SubsettedProperties);
                cb.WriteLine(",");
                cb.Write($"subsettingProperties: ");
                GeneratePropertyArray(cb, prop.GetSubsettingProperties(metaClass));
                cb.WriteLine(",");
                cb.Write($"redefinedProperties: ");
                GeneratePropertyArray(cb, prop.RedefinedProperties);
                cb.WriteLine(",");
                cb.Write($"redefiningProperties: ");
                GeneratePropertyArray(cb, prop.GetRedefiningProperties(metaClass));
                cb.WriteLine();
                cb.Pop();
                cb.WriteLine("),");
            }
            cb.Pop();
            cb.WriteLine("};");
            cb.Pop();
            cb.Pop();
            cb.WriteLine();
            cb.WriteLine($"internal {metaClass.ImplName}(string? id = null)");
            cb.WriteLine("    : base(id)");
            cb.WriteLine("{");
            cb.Push();
            MetaProperty? nameProperty = null;
            MetaProperty? typeProperty = null;
            foreach (var prop in metaClass.AllDeclaredProperties)
            {
                if (prop.Flags.HasFlag(ModelPropertyFlags.Name) && nameProperty == null)
                {
                    nameProperty = prop;
                }
                if (prop.Flags.HasFlag(ModelPropertyFlags.Type) && typeProperty == null)
                {
                    typeProperty = prop;
                }
            }
            foreach (var slot in metaClass.GetSlots())
            {
                if (slot.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    cb.WriteLine($"(({IModelObjectType})this).Init({slot.SlotProperty.FullyQualifiedPropertyName}, new {ModelObjectListType}<{slot.SlotProperty.Type.ToDisplayString()}>(this, s_PropertyInfo[{slot.SlotProperty.FullyQualifiedPropertyName}].Slot));");
                }
                else if (slot.SlotProperty.DefaultValue != null)
                {
                    cb.WriteLine($"(({IModelObjectType})this).Init({slot.SlotProperty.FullyQualifiedPropertyName}, ({slot.SlotProperty.Type.ToDisplayString()}){slot.SlotProperty.CSharpDefaultValue});");
                }
            }
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {IMetaModelType} MMetaModel => {metaClass.MetaModel.FullyQualifiedMetaModelImplName}.Instance;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {IModelObjectType}? MMetaClass => null;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override global::System.Type MMetaType => typeof({metaClass.FullyQualifiedName});");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {ImmutableArrayType}<{ModelPropertyType}> MDeclaredProperties => {metaClass.FullyQualifiedName}.MDeclaredProperties;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {ImmutableArrayType}<{ModelPropertyType}> MAllDeclaredProperties => {metaClass.FullyQualifiedName}.MAllDeclaredProperties;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {ImmutableArrayType}<{ModelPropertyType}> MPublicProperties => {metaClass.FullyQualifiedName}.MPublicProperties;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {ModelPropertyType}? MNameProperty => {nameProperty?.FullyQualifiedPropertyName ?? "null"};");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {ModelPropertyType}? MTypeProperty => {typeProperty?.FullyQualifiedPropertyName ?? "null"};");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {DictionaryType}<{ModelPropertyType}, {ModelPropertyInfoType}> MModelPropertyInfos => s_PropertyInfo;");
            cb.WriteLine();
            foreach (var prop in metaClass.PublicProperties.Where(p => !(p.Flags.HasFlag(ModelPropertyFlags.Derived) && !p.Flags.HasFlag(ModelPropertyFlags.DerivedUnion))))
            {
                cb.WriteLine($"public {prop.CSharpType} {prop.Name}");
                cb.WriteLine("{");
                cb.Push();
                cb.WriteLine($"get => MGet<{prop.CSharpType}>({prop.FullyQualifiedPropertyName});");
                if (!prop.Flags.HasFlag(ModelPropertyFlags.ReadOnly) && !prop.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    cb.WriteLine($"set => MAdd<{prop.CSharpType}>({prop.FullyQualifiedPropertyName}, value);");
                }
                cb.Pop();
                cb.WriteLine("}");
            }
            foreach (var prop in metaClass.AllDeclaredProperties.Where(p => !(p.Flags.HasFlag(ModelPropertyFlags.Derived) && !p.Flags.HasFlag(ModelPropertyFlags.DerivedUnion))))
            {
                cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
                cb.WriteLine($"{prop.CSharpType} {prop.MetaClass.FullyQualifiedName}.{prop.Name}");
                cb.WriteLine("{");
                cb.Push();
                cb.WriteLine($"get => MGet<{prop.CSharpType}>({prop.FullyQualifiedPropertyName});");
                if (!prop.Flags.HasFlag(ModelPropertyFlags.ReadOnly) && !prop.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    cb.WriteLine($"set => MAdd<{prop.CSharpType}>({prop.FullyQualifiedPropertyName}, value);");
                }
                cb.Pop();
                cb.WriteLine("}");
            }
            cb.Pop();
            cb.WriteLine("}");
        }

    }
}
