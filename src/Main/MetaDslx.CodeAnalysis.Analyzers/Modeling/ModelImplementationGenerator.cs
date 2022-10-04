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
        private const string ModelFactoryType = "global::MetaDslx.Modeling.ModelFactory";
        private const string ModelPropertyType = "global::MetaDslx.Modeling.ModelProperty";
        private const string ModelPropertyFlagsType = "global::MetaDslx.Modeling.ModelPropertyFlags";
        private const string PropertyArrayType = "global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.ModelProperty>";

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
            foreach (var metaClass in metaModel.MetaClasses.Where(mc => !mc.IsAbstract))
            {
                GenerateMetaClassImplementation(cb, metaClass);
                cb.WriteLine();
            }
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
                cb.WriteLine($"var result = new {metaClass.ImplName}();");
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
            var newKeyword = metaClass.IsRoot ? "" : "new ";
            cb.Write($"public static {newKeyword}readonly {PropertyArrayType} MDeclaredProperties = ");
            GeneratePropertyArray(cb, metaClass.DeclaredProperties);
            cb.WriteLine(";");
            cb.Write($"public static {newKeyword}readonly {PropertyArrayType} MPublicProperties = ");
            GeneratePropertyArray(cb, metaClass.PublicProperties);
            cb.WriteLine(";");
            cb.Write($"public static {newKeyword}readonly {PropertyArrayType} MAllProperties = ");
            GeneratePropertyArray(cb, metaClass.AllProperties);
            cb.WriteLine(";");
            foreach (var prop in metaClass.DeclaredProperties)
            {
                cb.Write($"public static readonly {ModelPropertyType} MProperty_{metaClass.Name}_{prop.Name} = new {ModelPropertyType}(typeof({metaClass.Name}), nameof({prop.Name}), typeof({prop.Type?.ToDisplayString()}), ");
                GenerateModelPropertyFlags(cb, prop.Flags);
                cb.WriteLine(");");
            }
            cb.Pop();
            cb.WriteLine("}");
        }

        private static void GeneratePropertyArray(CodeBuilder cb, ImmutableArray<MetaProperty> properties)
        {
            if (properties.Length > 0)
            {
                cb.Write($"{PropertyArrayType}.Create(");
                var comma = "";
                foreach (var prop in properties)
                {
                    cb.Write(comma);
                    cb.Write($"MProperty_{prop.MetaClass.Name}_{prop.Name}");
                    comma = ", ";
                }
                cb.Write(")");
            }
            else
            {
                cb.Write($"{PropertyArrayType}.Empty");
            }
        }

        private static void GenerateModelPropertyFlags(CodeBuilder cb, ModelPropertyFlags flags)
        {
            // TODO
        }

        private static void GenerateMetaClassImplementation(CodeBuilder cb, MetaClass metaClass)
        {
            cb.WriteLine($"internal partial class {metaClass.ImplName} : global::MetaDslx.Modeling.ModelObject, {metaClass.Name}");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"protected override {PropertyArrayType} MDeclaredProperties = {metaClass.Name}.MDeclaredProperties;");
            cb.WriteLine($"protected override {PropertyArrayType} MPublicProperties = {metaClass.Name}.MPublicProperties;");
            cb.WriteLine($"protected override {PropertyArrayType} MAllProperties = {metaClass.Name}.MAllProperties;");
            cb.WriteLine();
            foreach (var prop in metaClass.AllProperties)
            {
                cb.WriteLine($"{prop.PropertySymbol.ToDisplayString()} {prop.MetaClass.Name}.{prop.Name}");
                cb.WriteLine("{");
                cb.Push();
                cb.WriteLine("");
                cb.Pop();
                cb.WriteLine("}");
                cb.WriteLine("Wife? Husband.Wife { get => (Wife?)((IModelObject)this).MGet(Husband.MProperty_Wife); set => ((IModelObject)this).MSet(Husband.MProperty_Wife, value); }");
            }
            cb.Pop();
            cb.WriteLine("}");
        }
    }
}
