using MetaDslx.CodeGeneration;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Analyzers.Modeling
{
    internal static class ModelImplementationGenerator
    {
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
            foreach (var metaClass in metaModel.MetaClasses)
            {
                GenerateMetaClassImplementation(cb, metaClass);
                cb.WriteLine();
            }
            cb.Pop();
            cb.WriteLine("}");
        }

        private static void GenerateMetaModelFactory(CodeBuilder cb, MetaModel metaModel)
        {
            cb.WriteLine($"public partial class {metaModel.FactoryName} : global::MetaDslx.Modeling.ModelFactory");
            cb.WriteLine("{");
            cb.Push();
            cb.WriteLine($"public {metaModel.FactoryName}(global::MetaDslx.Modeling.Model model)");
            cb.WriteLine("    : base(model)");
            cb.WriteLine("{");
            cb.WriteLine("}");
            cb.WriteLine();
            foreach (var metaClass in metaModel.MetaClasses)
            {
                cb.WriteLine($"public {metaClass.Name} {metaClass.Name}()");
                cb.WriteLine("{");
                cb.Push();
                cb.WriteLine($"var result = new {metaClass.ImplName}();");
                cb.WriteLine("((global::MetaDslx.Modeling.IModel)Model).AddObject(result);");
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
            cb.Pop();
            cb.WriteLine("}");
        }

        private static void GenerateMetaClassImplementation(CodeBuilder cb, MetaClass metaClass)
        {
            cb.WriteLine($"internal partial class {metaClass.ImplName} : global::MetaDslx.Modeling.ModelObject, {metaClass.Name}");
            cb.WriteLine("{");
            cb.Push();
            cb.Pop();
            cb.WriteLine("}");
        }
    }
}
