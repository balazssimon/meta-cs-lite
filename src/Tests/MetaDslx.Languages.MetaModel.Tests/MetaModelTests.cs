using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaGenerator.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.CodeAnalysis.Emit;
using System.IO;
using System.Runtime.InteropServices;
using MetaDslx.Languages.MetaModel.Compiler;

namespace MetaDslx.Languages.MetaModel.Tests
{
    using Model = MetaDslx.Modeling.Model;
    using ModelFactory = MetaDslx.Modeling.ModelFactory;
    using MetaModel = MetaDslx.Modeling.MetaModel;

    public class MetaModelTests
    {
        private static readonly CSharpCompilation BaseCompilation = CreateCompilation();

        protected ModelFactory Factory(string mmCode, Model? model = null, [CallerMemberName] string? method = null)
        {
            var assembly = Compile(mmCode, method);
            return Factory(assembly, model);
        }

        protected ModelFactory Factory(Assembly assembly, Model? model = null, [CallerMemberName] string? method = null)
        {
            Type? factoryType = assembly.GetType("MetaModelTests.TestModelModelFactory")!;
            Assert.NotNull(factoryType);
            var ctr = factoryType.GetConstructor(new[] { typeof(Model) });
            Assert.NotNull(ctr);
            var factory = ctr.Invoke(new[] { model ?? new Model() }) as ModelFactory;
            Assert.NotNull(factory);
            return factory!;
        }

        protected MetaModel MetaModel(string mmCode, [CallerMemberName] string? method = null)
        {
            var assembly = Compile(mmCode, method);
            return MetaModel(assembly);
        }

        protected MetaModel MetaModel(Assembly assembly, [CallerMemberName] string? method = null)
        {
            Type? metaModelType = assembly.GetType("MetaModelTests.TestModel")!;
            Assert.NotNull(metaModelType);
            var instanceProperty = metaModelType.GetProperty("MInstance", BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
            Assert.NotNull(instanceProperty);
            var metaModel = instanceProperty!.GetValue(null) as MetaModel;
            Assert.NotNull(metaModel);
            return metaModel!;
        }

        protected Assembly Compile(string mmCode, [CallerMemberName] string? method = null)
        {
            var fullMmCode = @$"
namespace MetaModelTests;

using MetaDslx.CodeAnalysis.Symbols;

metamodel TestModel;

{mmCode}
";
            var customCode = @"
[assembly:System.Runtime.CompilerServices.InternalsVisibleTo(""MetaDslx.Languages.MetaModel.Tests"")]
namespace MetaModelTests
{
    internal class CustomTestModelImplementation : CustomTestModelImplementationBase
    {
    }
}
";
            var csCode = Generate(fullMmCode);
            var csTree = CSharpSyntaxTree.ParseText(text: csCode, path: $"{method}.cs");
            var customTree = CSharpSyntaxTree.ParseText(text: customCode, path: $"CustomTestModelImplementation.cs");
            var compilation = BaseCompilation.AddSyntaxTrees(csTree, customTree);
            Assembly? assembly = null;
            using (var codeStream = new MemoryStream())
            {
                var compilationResult = compilation.Emit(codeStream);
                if (!compilationResult.Success)
                {
                    var errors = compilationResult.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
                    if (errors.Length > 0) Assert.False(true, errors[0].ToString());
                }
                assembly = Assembly.Load(codeStream.ToArray());
            }
            Assert.NotNull(assembly);
            return assembly;
        }

        protected string Generate(string mmCode, [CallerMemberName] string? method = null)
        {
            var fileName = method ?? this.GetType().Name;
            var syntaxTree = MetaSyntaxTree.ParseText(mmCode, path: fileName);
            var mmCompiler = MetaDslx.CodeAnalysis.Compilation.Create(method,
                syntaxTrees: new[] { syntaxTree },
                initialCompilation: BaseCompilation,
                references: new[]
                {
                    MetaDslx.CodeAnalysis.MetadataReference.CreateFromMetaModel(MetaDslx.Languages.MetaModel.Model.Meta.MInstance)
                },
                options: MetaDslx.CodeAnalysis.CompilationOptions.Default.WithConcurrentBuild(false));
            mmCompiler.Compile();
            var model = mmCompiler.SourceModule.Model;
            var mm = model.Objects.OfType<MetaDslx.Languages.MetaModel.Model.MetaModel>().FirstOrDefault();
            var errors = mmCompiler.GetDiagnostics().Where(d => d.Severity == CodeAnalysis.DiagnosticSeverity.Error).ToArray();
            if (errors.Length > 0) Assert.False(true, errors[0].ToString());
            var generator = new MetaDslx.Languages.MetaModel.Generators.MetaModelGenerator(true, model, mm);
            var output = generator.Generate();
            return output;
        }

        static CSharpCompilation CreateCompilation()
        {
            var coreLocation = typeof(object).GetTypeInfo().Assembly.Location;
            var coreDir = Directory.GetParent(coreLocation)?.FullName ?? RuntimeEnvironment.GetRuntimeDirectory();
            var netstandardPath = Path.Combine(coreDir, "netstandard.dll");
            var mscorlibPath = Path.Combine(coreDir, "mscorlib.dll");
            var systemRuntimePath = Path.Combine(coreDir, "System.Runtime.dll");
            var systemMemoryPath = Path.Combine(coreDir, "System.Memory.dll");
            var systemCollectionsPath = Path.Combine(coreDir, "System.Collections.dll");
            var systemCollectionsImmutablePath = Path.Combine(coreDir, "System.Collections.Immutable.dll");
            var systemLinqPath = Path.Combine(coreDir, "System.Linq.dll");
            var systemLinqExpressionsPath = Path.Combine(coreDir, "System.Linq.Expressions.dll");
            var systemLinqQueryablePath = Path.Combine(coreDir, "System.Linq.Queryable.dll");
            return CSharpCompilation.Create(
                assemblyName: "TestCompilation",
                options: new CSharpCompilationOptions(
                    outputKind: OutputKind.DynamicallyLinkedLibrary, 
                    optimizationLevel: OptimizationLevel.Debug),
                references: new[] {
                    MetadataReference.CreateFromFile(netstandardPath),
                    MetadataReference.CreateFromFile(mscorlibPath),
                    MetadataReference.CreateFromFile(systemRuntimePath),
                    MetadataReference.CreateFromFile(systemMemoryPath),
                    MetadataReference.CreateFromFile(systemCollectionsPath),
                    MetadataReference.CreateFromFile(systemCollectionsImmutablePath),
                    MetadataReference.CreateFromFile(systemLinqPath),
                    MetadataReference.CreateFromFile(systemLinqExpressionsPath),
                    MetadataReference.CreateFromFile(systemLinqQueryablePath),
                    MetadataReference.CreateFromFile(typeof(object).GetTypeInfo().Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(Attribute).GetTypeInfo().Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(MetaDslx.CodeGeneration.CodeBuilder).GetTypeInfo().Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(MetaDslx.Modeling.MetaModel).GetTypeInfo().Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(MetaDslx.Languages.MetaModel.Model.MetaModel).GetTypeInfo().Assembly.Location),
                });
        }
    }
}
