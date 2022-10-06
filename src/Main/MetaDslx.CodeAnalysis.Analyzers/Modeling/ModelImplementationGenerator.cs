using MetaDslx.CodeGeneration;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Analyzers.Modeling
{
    internal static class ModelImplementationGenerator
    {
        private const string ModelType = "global::MetaDslx.Modeling.Model";
        private const string IModelType = "global::MetaDslx.Modeling.IModel";
        private const string ModelObjectType = "global::MetaDslx.Modeling.ModelObject";
        private const string IModelObjectType = "global::MetaDslx.Modeling.IModelObject";
        private const string ModelFactoryType = "global::MetaDslx.Modeling.ModelFactory";
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
            cb.WriteLine($"namespace {metaModel.NamespaceName}");
            cb.WriteLine("{");
            cb.Push();
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

        private static void GenerateMetaModelFactory(CodeBuilder cb, MetaModel metaModel)
        {
            cb.WriteLine($"public partial class {metaModel.FactoryName} : {ModelFactoryType}");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"public {metaModel.FactoryName}({ModelType} model)");
            cb.WriteLine("    : base(model)");
            cb.WriteLine("{");
            cb.WriteLine("}");
            cb.WriteLine();
            foreach (var metaClass in metaModel.MetaClasses.Where(mc => !mc.IsAbstract))
            {
                cb.WriteLine($"public {metaClass.Name} {metaClass.Name}()");
                cb.WriteLine("{");
                cb.Push();
                cb.WriteLine($"var result = new Internal.{metaClass.ImplName}();");
                cb.WriteLine($"(({IModelType})Model).AddObject(result);");
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
                cb.Write($"public static readonly {ModelPropertyType} {prop.PropertyName} = new {ModelPropertyType}(typeof({metaClass.Name}), nameof({prop.Name}), typeof({prop.Type?.ToDisplayString(NullableFlowState.None)}), ");
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
                    cb.Write(prop.QualifiedPropertyName);
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

        private static void GenerateMetaClassImplementation(CodeBuilder cb, MetaClass metaClass)
        {
            cb.WriteLine($"internal partial class {metaClass.ImplName} : global::MetaDslx.Modeling.ModelObject, {metaClass.Name}");
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
                cb.WriteLine($"[{prop.QualifiedPropertyName}] = new {ModelPropertyInfoType}(");
                cb.Push();
                cb.Write($"slot: new {ModelPropertySlotType}({slot.SlotProperty.QualifiedPropertyName}, ");
                GeneratePropertyArray(cb, slot.SlotProperties);
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
            cb.WriteLine($"internal {metaClass.ImplName}()");
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
                    if (slot.Flags.HasFlag(ModelPropertyFlags.MetaClassType))
                    {
                        cb.WriteLine($"(({IModelObjectType})this).MInit({slot.SlotProperty.QualifiedPropertyName}, new {ModelObjectListType}<{slot.SlotProperty.Type.ToDisplayString()}>(this, s_PropertyInfo[{slot.SlotProperty.QualifiedPropertyName}].Slot));");
                    }
                    else
                    {
                        cb.WriteLine($"(({IModelObjectType})this).MInit({slot.SlotProperty.QualifiedPropertyName}, new {ListType}<{slot.SlotProperty.CSharpType}>());");
                    }
                }
            }
            cb.Pop();
            cb.WriteLine("}");
            cb.WriteLine();
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {ImmutableArrayType}<{ModelPropertyType}> MDeclaredProperties => {metaClass.Name}.MDeclaredProperties;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {ImmutableArrayType}<{ModelPropertyType}> MAllDeclaredProperties => {metaClass.Name}.MAllDeclaredProperties;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {ImmutableArrayType}<{ModelPropertyType}> MPublicProperties => {metaClass.Name}.MPublicProperties;");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {ModelPropertyType}? MNameProperty => {nameProperty?.QualifiedPropertyName ?? "null"};");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {ModelPropertyType}? MTypeProperty => {typeProperty?.QualifiedPropertyName ?? "null"};");
            cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
            cb.WriteLine($"protected override {DictionaryType}<{ModelPropertyType}, {ModelPropertyInfoType}> MModelPropertyInfos => s_PropertyInfo;");
            cb.WriteLine();
            foreach (var prop in metaClass.PublicProperties)
            {
                cb.WriteLine($"public {prop.CSharpType} {prop.Name}");
                cb.WriteLine("{");
                cb.Push();
                cb.WriteLine($"get => MGet<{prop.CSharpType}>({prop.QualifiedPropertyName});");
                if (!prop.Flags.HasFlag(ModelPropertyFlags.Readonly) && !prop.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    cb.WriteLine($"set => MSet<{prop.CSharpType}>({prop.QualifiedPropertyName}, value);");
                }
                cb.Pop();
                cb.WriteLine("}");
            }
            foreach (var prop in metaClass.AllDeclaredProperties)
            {
                cb.WriteLine("[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]");
                cb.WriteLine($"{prop.CSharpType} {prop.MetaClass.Name}.{prop.Name}");
                cb.WriteLine("{");
                cb.Push();
                cb.WriteLine($"get => MGet<{prop.CSharpType}>({prop.QualifiedPropertyName});");
                if (!prop.Flags.HasFlag(ModelPropertyFlags.Readonly) && !prop.Flags.HasFlag(ModelPropertyFlags.Collection))
                {
                    cb.WriteLine($"set => MSet<{prop.CSharpType}>({prop.QualifiedPropertyName}, value);");
                }
                cb.Pop();
                cb.WriteLine("}");
            }
            cb.Pop();
            cb.WriteLine("}");
        }
    }
}
