using MetaDslx.CodeGeneration;
using MetaDslx.Modeling;
using MetaDslx.Languages.MetaModel.Model;

using Microsoft.CodeAnalysis;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Xml.Linq;

using static System.Net.Mime.MediaTypeNames;

namespace MetaDslx.Languages.MetaModel.Generators
{

    internal static class ModelImplementationGenerator
    {
        private const string IMetaModelType = "global::MetaDslx.Modeling.IMetaModel";
        private const string IModelType = "global::MetaDslx.Modeling.IModel";
        private const string ModelType = "global::MetaDslx.Modeling.Model";
        private const string ModelVersionType = "global::MetaDslx.Modeling.ModelVersion";
        private const string IModelObjectType = "global::MetaDslx.Modeling.IModelObject";
        private const string ModelObjectType = "global::MetaDslx.Modeling.ModelObject";
        private const string ISingleModelFactoryType = "global::MetaDslx.Modeling.IModelFactory";
        private const string IMultiModelFactoryType = "global::MetaDslx.Modeling.IMultiModelFactory";
        private const string SingleModelFactoryType = "global::MetaDslx.Modeling.ModelFactory";
        private const string MultiModelFactoryType = "global::MetaDslx.Modeling.MultiModelFactory";
        private const string IMetaModelInfoType = "global::MetaDslx.Modeling.IMetaModelInfo";
        private const string IModelObjectInfoType = "global::MetaDslx.Modeling.IModelObjectInfo";
        private const string ModelObjectInfoType = "global::MetaDslx.Modeling.ModelObjectInfo";
        private const string ModelExceptionType = "global::MetaDslx.Modeling.ModelException";
        private const string ModelPropertyType = "global::MetaDslx.Modeling.ModelProperty";
        private const string ModelPropertyFlagsType = "global::MetaDslx.Modeling.ModelPropertyFlags";
        private const string ModelPropertyInfoType = "global::MetaDslx.Modeling.ModelPropertyInfo";
        private const string ModelPropertySlotType = "global::MetaDslx.Modeling.ModelPropertySlot";
        private const string ModelObjectListType = "global::MetaDslx.Modeling.ModelObjectList";
        private const string ListType = "global::System.Collections.Generic.List";
        private const string DictionaryType = "global::System.Collections.Generic.Dictionary";
        private const string ImmutableArrayType = "global::System.Collections.Immutable.ImmutableArray";

        public static string Generate(ImmutableArray<MetaModelInfo> metaModels)
        {
            var cb = CodeBuilder.GetInstance();
            foreach (var metaModel in metaModels)
            {
                Generate(cb, metaModel);
                cb.WriteLine();
            }
            return cb.ToStringAndFree();
        }

        private static void Generate(CodeBuilder cb, MetaModelInfo metaModel)
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
            GenerateMetaModelInfo(cb, metaModel);
            cb.WriteLine();
            /*foreach (var metaClass in metaModel.MetaClasses)
            {
                GenerateMetaClassInterface(cb, metaClass);
                cb.WriteLine();
            }*/
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

        private static void GenerateMetaModel(CodeBuilder cb, MetaModelInfo metaModel)
        {
            cb.WriteLine($"public partial interface {metaModel.Name} : {IMetaModelType}");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"public static {metaModel.Name} Instance => {metaModel.FullyQualifiedMetaModelImplName}.Instance;");
            cb.Pop();
            cb.WriteLine("}");
        }

        private static void GenerateMetaModelFactory(CodeBuilder cb, MetaModelInfo metaModel)
        {
            cb.WriteLine($"public partial class {metaModel.SingleFactoryName} : {ISingleModelFactoryType}");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"private static readonly {DictionaryType}<global::System.Type, global::System.Func<{metaModel.SingleFactoryName}, string?, {IModelObjectType}>> s_factoryMethodsByType;");
            cb.WriteLine($"private static readonly {DictionaryType}<string, global::System.Func<{metaModel.SingleFactoryName}, string?, {IModelObjectType}>> s_factoryMethodsByName;");
            cb.WriteLine();
            cb.WriteLine($"static {metaModel.SingleFactoryName}()");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"s_factoryMethodsByType = new {DictionaryType}<global::System.Type, global::System.Func<{metaModel.SingleFactoryName}, string?, {IModelObjectType}>>()");
            cb.WriteLine("{");
            cb.Push();
            foreach (var metaClass in metaModel.MetaClasses.Where(mc => !mc.IsAbstract))
            {
                cb.WriteLine($"{{ typeof({metaClass.FullyQualifiedName}), (f, id) => ({IModelObjectType})f.{metaClass.Name}(id) }},");
            }
            cb.Pop();
            cb.WriteLine("};");
            cb.WriteLine($"s_factoryMethodsByName = new {DictionaryType}<string, global::System.Func<{metaModel.SingleFactoryName}, string?, {IModelObjectType}>>()");
            cb.WriteLine("{");
            cb.Push();
            foreach (var metaClass in metaModel.MetaClasses.Where(mc => !mc.IsAbstract))
            {
                cb.WriteLine($"{{ \"{metaClass.Name}\",  (f, id) => ({IModelObjectType})f.{metaClass.Name}(id) }},");
            }
            cb.Pop();
            cb.WriteLine("};");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine($"private {IModelType} _model;");
            cb.WriteLine();
            cb.WriteLine($"public {metaModel.SingleFactoryName}({ModelType} model)");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine("_model = model;");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine($"{IModelType} {ISingleModelFactoryType}.Model => _model;");
            cb.WriteLine();
            cb.WriteLine($"{IMetaModelType} {ISingleModelFactoryType}.MetaModel => {metaModel.FullyQualifiedMetaModelImplName}.Instance;");
            cb.WriteLine();
            cb.WriteLine($"{IModelObjectType}? {ISingleModelFactoryType}.Create(global::System.Type modelObjectType, string? id)");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"if (s_factoryMethodsByType.TryGetValue(modelObjectType, out var factoryMethod)) return factoryMethod(this, id);");
            cb.WriteLine("else return null;");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine($"{IModelObjectType}? {ISingleModelFactoryType}.Create(string modelObjectTypeName, string? id)");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"if (s_factoryMethodsByName.TryGetValue(modelObjectTypeName, out var factoryMethod)) return factoryMethod(this, id);");
            cb.WriteLine("else return null;");
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
            cb.WriteLine();

            cb.WriteLine($"public partial class {metaModel.MultiFactoryName} : {IMultiModelFactoryType}");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"private static readonly {ImmutableArrayType}<{IMetaModelType}> s_metaModels;");
            cb.WriteLine($"private static readonly {DictionaryType}<global::System.Type, global::System.Func<{metaModel.MultiFactoryName}, {ModelType}, string?, {IModelObjectType}>> s_factoryMethodsByType;");
            cb.WriteLine($"private static readonly {DictionaryType}<string, global::System.Func<{metaModel.MultiFactoryName}, {ModelType}, string?, {IModelObjectType}>> s_factoryMethodsByName;");
            cb.WriteLine();
            cb.WriteLine($"static {metaModel.MultiFactoryName}()");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"s_metaModels = {ImmutableArrayType}.Create<{IMetaModelType}>({metaModel.Name}.Instance);");
            cb.WriteLine($"s_factoryMethodsByType = new {DictionaryType}<global::System.Type, global::System.Func<{metaModel.MultiFactoryName}, {ModelType}, string?, {IModelObjectType}>>()");
            cb.WriteLine("{");
            cb.Push();
            foreach (var metaClass in metaModel.MetaClasses.Where(mc => !mc.IsAbstract))
            {
                cb.WriteLine($"{{ typeof({metaClass.FullyQualifiedName}), (f, model, id) => ({IModelObjectType})f.{metaClass.Name}(model, id) }},");
            }
            cb.Pop();
            cb.WriteLine("};");
            cb.WriteLine($"s_factoryMethodsByName = new {DictionaryType}<string, global::System.Func<{metaModel.MultiFactoryName}, {ModelType}, string?, {IModelObjectType}>>()");
            cb.WriteLine("{");
            cb.Push();
            foreach (var metaClass in metaModel.MetaClasses.Where(mc => !mc.IsAbstract))
            {
                cb.WriteLine($"{{ \"{metaClass.Name}\", (f, model, id) => ({IModelObjectType})f.{metaClass.Name}(model, id) }},");
            }
            cb.Pop();
            cb.WriteLine("};");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine($"{ImmutableArrayType}<{IMetaModelType}> {IMultiModelFactoryType}.MetaModels => s_metaModels;");
            cb.WriteLine();
            cb.WriteLine($"{IModelObjectType}? {IMultiModelFactoryType}.Create({ModelType} model, global::System.Type modelObjectType, string? id)");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"if (s_factoryMethodsByType.TryGetValue(modelObjectType, out var factoryMethod)) return factoryMethod(this, model, id);");
            cb.WriteLine("else return null;");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine($"{IModelObjectType}? {IMultiModelFactoryType}.Create({ModelType} model, string modelObjectTypeName, string? id)");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"if (s_factoryMethodsByName.TryGetValue(modelObjectTypeName, out var factoryMethod)) return factoryMethod(this, model, id);");
            cb.WriteLine("else return null;");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            foreach (var metaClass in metaModel.MetaClasses.Where(mc => !mc.IsAbstract))
            {
                cb.WriteLine($"public {metaClass.FullyQualifiedName} {metaClass.Name}({ModelType} model, string? id = null)");
                cb.WriteLine("{");
                cb.Push();
                cb.WriteLine($"var result = new {metaClass.FullyQualifiedImplName}(id);");
                cb.WriteLine($"model.AddObject(result);");
                cb.WriteLine("return result;");
                cb.Pop();
                cb.WriteLine("}");
                cb.WriteLine();
            }
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
        }

        private static void GenerateMetaModelInfo(CodeBuilder cb, MetaModelInfo metaModel)
        {
            cb.WriteLine($"public partial class {metaModel.InfoName} : {IMetaModelInfoType}");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"private {ImmutableArrayType}<global::System.Type> _modelObjectTypes;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"private {ImmutableArrayType}<{IModelObjectInfoType}> _modelObjectInfos;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"private {DictionaryType}<global::System.Type, {IModelObjectInfoType}> _modelObjectInfosByType;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"private {DictionaryType}<string, {IModelObjectInfoType}> _modelObjectInfosByName;");
            cb.WriteLine();
            cb.WriteLine($"internal {metaModel.InfoName}()");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"var typesBuilder = {ImmutableArrayType}.CreateBuilder<global::System.Type>();");
            cb.WriteLine($"var infosBuilder = {ImmutableArrayType}.CreateBuilder<{IModelObjectInfoType}>();");
            cb.WriteLine($"_modelObjectInfosByType = new {DictionaryType}<global::System.Type, {IModelObjectInfoType}>();");
            cb.WriteLine($"_modelObjectInfosByName = new {DictionaryType}<string, {IModelObjectInfoType}>();");
            foreach (var metaClass in metaModel.MetaClasses)
            {
                cb.WriteLine($"typesBuilder.Add(typeof({metaClass.FullyQualifiedName}));");
                cb.WriteLine($"infosBuilder.Add({metaClass.FullyQualifiedImplName}.s_Info);");
                cb.WriteLine($"_modelObjectInfosByType.Add(typeof({metaClass.FullyQualifiedName}), {metaClass.FullyQualifiedImplName}.s_Info);");
                cb.WriteLine($"_modelObjectInfosByName.Add(\"{metaClass.Name}\", {metaClass.FullyQualifiedImplName}.s_Info);");
            }
            cb.WriteLine($"_modelObjectTypes = typesBuilder.ToImmutable();");
            cb.WriteLine($"_modelObjectInfos = infosBuilder.ToImmutable();");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"{IMetaModelType} {IMetaModelInfoType}.MetaModel => {metaModel.Name}.Instance;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"{ImmutableArrayType}<global::System.Type> {IMetaModelInfoType}.ModelObjectTypes => _modelObjectTypes;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"{ImmutableArrayType}<{IModelObjectInfoType}> {IMetaModelInfoType}.ModelObjectInfos => _modelObjectInfos;");
            cb.WriteLine();
            cb.WriteLine($"bool {IMetaModelInfoType}.Contains(global::System.Type modelObjectType)");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine("return _modelObjectInfosByType.ContainsKey(modelObjectType);");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine($"bool {IMetaModelInfoType}.Contains(string modelObjectTypeName)");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine("return _modelObjectInfosByName.ContainsKey(modelObjectTypeName);");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine($"bool {IMetaModelInfoType}.TryGetInfo(global::System.Type modelObjectType, out {IModelObjectInfoType} info)");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine("return _modelObjectInfosByType.TryGetValue(modelObjectType, out info);");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine($"bool {IMetaModelInfoType}.TryGetInfo(string modelObjectTypeName, out {IModelObjectInfoType} info)");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine("return _modelObjectInfosByName.TryGetValue(modelObjectTypeName, out info);");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            foreach (var metaClass in metaModel.MetaClasses)
            {
                GenerateMetaClassInfo(cb, metaClass);
                cb.WriteLine();
            }
            cb.Pop();
            cb.WriteLine("}");
        }

        private static void GenerateMetaClassInfo(CodeBuilder cb, MetaClass metaClass)
        {
            cb.WriteLine($"public partial class {metaClass.Name} : {ModelObjectInfoType}, {IModelObjectInfoType}");
            cb.WriteLine("{");
            cb.Push();
            foreach (var prop in metaClass.DeclaredProperties)
            {
                cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
                cb.Write($"public static readonly {ModelPropertyType} {prop.PropertyName} = new {ModelPropertyType}(typeof({metaClass.FullyQualifiedName}), nameof({prop.Name}), typeof({prop.Type?.ToDisplayString(NullableFlowState.None)}), {prop.CSharpDefaultValue}, ");
                GenerateModelPropertyFlags(cb, prop.Flags);
                if (prop.SymbolProperty is not null)
                {
                    cb.Write(", \"");
                    cb.Write(prop.SymbolProperty);
                    cb.Write("\"");
                }
                cb.WriteLine(");");
            }
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.Write($"public static readonly {ImmutableArrayType}<{ModelPropertyType}> MDeclaredProperties = ");
            GeneratePropertyArray(cb, metaClass.DeclaredProperties);
            cb.WriteLine(";");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.Write($"public static readonly {ImmutableArrayType}<{ModelPropertyType}> MAllDeclaredProperties = ");
            GeneratePropertyArray(cb, metaClass.AllDeclaredProperties);
            cb.WriteLine(";");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.Write($"public static readonly {ImmutableArrayType}<{ModelPropertyType}> MPublicProperties = ");
            GeneratePropertyArray(cb, metaClass.PublicProperties);
            cb.WriteLine(";");
            cb.WriteLine();
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"private static readonly {DictionaryType}<string, {ModelPropertyType}> s_PublicPropertiesByName =");
            cb.Push();
            cb.WriteLine($"new {DictionaryType}<string, {ModelPropertyType}>()");
            cb.Push();
            cb.WriteLine("{");
            cb.Push();
            foreach (var prop in metaClass.PublicProperties)
            {
                cb.WriteLine($"[\"{prop.Name}\"] = {prop.FullyQualifiedPropertyName},");
            }
            cb.Pop();
            cb.WriteLine("};");
            cb.Pop();
            cb.Pop();
            cb.WriteLine();
            cb.WriteLine();
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"private static readonly {DictionaryType}<{ModelPropertyType}, {ModelPropertyInfoType}> s_PropertyInfos =");
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
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"{IMetaModelInfoType} {IModelObjectInfoType}.MetaModelInfo => {metaClass.MetaModel.FullyQualifiedMetaModelImplName}.Instance.Info;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"{IMetaModelType} {IModelObjectInfoType}.MetaModel => {metaClass.MetaModel.FullyQualifiedMetaModelImplName}.Instance;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"{IModelObjectType}? {IModelObjectInfoType}.MetaClass => null;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"global::System.Type {IModelObjectInfoType}.MetaType => typeof({metaClass.FullyQualifiedName});");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.Write($"global::System.Type {IModelObjectInfoType}.SymbolType => ");
            if (metaClass.SymbolType is null) cb.WriteLine("null;");
            else cb.WriteLine($"typeof({metaClass.SymbolType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)});");
            MetaProperty? nameProperty = metaClass.NameProperty;
            MetaProperty? typeProperty = metaClass.TypeProperty;
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"{ModelPropertyType}? {IModelObjectInfoType}.NameProperty => {nameProperty?.FullyQualifiedPropertyName ?? "null"};");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"{ModelPropertyType}? {IModelObjectInfoType}.TypeProperty => {typeProperty?.FullyQualifiedPropertyName ?? "null"};");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"{ImmutableArrayType}<{ModelPropertyType}> {IModelObjectInfoType}.DeclaredProperties => MDeclaredProperties;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"{ImmutableArrayType}<{ModelPropertyType}> {IModelObjectInfoType}.AllDeclaredProperties => MAllDeclaredProperties;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"{ImmutableArrayType}<{ModelPropertyType}> {IModelObjectInfoType}.PublicProperties => MPublicProperties;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {DictionaryType}<string, {ModelPropertyType}> PublicPropertiesByName => s_PublicPropertiesByName;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {DictionaryType}<{ModelPropertyType}, {ModelPropertyInfoType}> ModelPropertyInfos => s_PropertyInfos;");
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
                if (prop.SymbolProperty is not null)
                {
                    cb.Write(", \"");
                    cb.Write(prop.SymbolProperty);
                    cb.Write("\"");
                }
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

        private static void GenerateMetaModelImplementation(CodeBuilder cb, MetaModelInfo metaModel)
        {
            cb.WriteLine($"public partial class {metaModel.MetaModelImplName} : {metaModel.Name}");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"public static readonly {metaModel.MetaModelImplName} Instance = new {metaModel.MetaModelImplName}();");
            cb.WriteLine();
            cb.WriteLine($"private {IMetaModelInfoType} _info;");
            cb.WriteLine($"private {ModelVersionType} _version;");
            cb.WriteLine();
            cb.WriteLine($"private {metaModel.MetaModelImplName}()");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"_info = new {metaModel.FullyQualifiedInfoName}();");
            cb.WriteLine($"_version = new {ModelVersionType}({metaModel.Version.Major}, {metaModel.Version.Minor});");
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine($"public string Name => \"{metaModel.Name}\";");
            cb.WriteLine($"public string FullName => \"{metaModel.ModelInterface.ToDisplayString()}\";");
            cb.WriteLine($"public {ModelVersionType} Version => _version;");
            cb.WriteLine($"public string Uri => \"{metaModel.Uri}\";");
            cb.WriteLine($"public string Prefix => \"{metaModel.Prefix}\";");
            cb.WriteLine($"public {IMetaModelInfoType} Info => _info;");
            cb.WriteLine();
            cb.WriteLine($"{IMultiModelFactoryType} {IMetaModelType}.CreateFactory() => new {metaModel.FullyQualifiedMultiFactoryName}();");
            cb.WriteLine($"{ISingleModelFactoryType} {IMetaModelType}.CreateFactory({IModelType} model) => new {metaModel.FullyQualifiedSingleFactoryName}(({ModelType})model);");
            cb.Pop();
            cb.WriteLine("}");
        }

        private static void GenerateMetaClassImplementation(CodeBuilder cb, MetaClass metaClass)
        {
            cb.WriteLine($"internal partial class {metaClass.ImplName} : global::MetaDslx.Modeling.ModelObject, {metaClass.FullyQualifiedName}");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"internal static readonly {metaClass.FullyQualifiedInfoName} s_Info = new {metaClass.FullyQualifiedInfoName}();");
            cb.WriteLine();
            cb.WriteLine($"internal {metaClass.ImplName}(string? id = null)");
            cb.WriteLine("    : base(id)");
            cb.WriteLine("{");
            cb.Push();
            foreach (var slot in metaClass.GetSlots())
            {
                if (slot.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    cb.WriteLine($"(({IModelObjectType})this).Init({slot.SlotProperty.FullyQualifiedPropertyName}, new {ModelObjectListType}<{slot.SlotProperty.Type.ToDisplayString()}>(this, s_Info.GetSlot({slot.SlotProperty.FullyQualifiedPropertyName})));");
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
            cb.WriteLine($"protected override {IModelObjectInfoType} MInfo => s_Info;");
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
