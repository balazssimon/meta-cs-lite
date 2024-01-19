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

namespace MetaDslx.Languages.MetaGenerator.Tests
{
    public class MetaGeneratorTests
    {
        private static readonly Compilation BaseCompilation = CreateCompilation();

        protected dynamic Generator(string mgenCode, [CallerMemberName] string? method = null)
        {
            var fullMgenCode = @$"
namespace GeneratorTests

using System
using System.Text
using System.Collections.Generic
using System.Linq

generator Generator

{mgenCode}
";
            var generatorCode = Compile(fullMgenCode);
            var generatorTree = CSharpSyntaxTree.ParseText(text: generatorCode, path: $"{method}.cs");
            var compilation = BaseCompilation.AddSyntaxTrees(generatorTree);
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
            dynamic generator = assembly.CreateInstance("GeneratorTests.Generator")!;
            return generator;
        }

        protected string Compile(string mgenCode, [CallerMemberName] string? method = null)
        {
            var fileName = method ?? this.GetType().Name;
            var mgenCompiler = new MetaGeneratorParser(fileName, SourceText.From(mgenCode));
            var csharpCode = mgenCompiler.Compile();
            var errors = mgenCompiler.Diagnostics.Where(d => d.Severity == CodeAnalysis.DiagnosticSeverity.Error).ToArray();
            if (errors.Length > 0) Assert.False(true, errors[0].ToString());
            return csharpCode;
        }

        static Compilation CreateCompilation()
        {
            var coreLocation = typeof(object).GetTypeInfo().Assembly.Location;
            var coreDir = Directory.GetParent(coreLocation)?.FullName ?? RuntimeEnvironment.GetRuntimeDirectory();
            var netstandardPath = Path.Combine(coreDir, "netstandard.dll");
            var mscorlibPath = Path.Combine(coreDir, "mscorlib.dll");
            var systemRuntimePath = Path.Combine(coreDir, "System.Runtime.dll");
            var systemMemoryPath = Path.Combine(coreDir, "System.Memory.dll");
            var systemCollectionsPath = Path.Combine(coreDir, "System.Collections.dll");
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
                    MetadataReference.CreateFromFile(typeof(object).GetTypeInfo().Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(Attribute).GetTypeInfo().Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(MetaDslx.CodeGeneration.CodeBuilder).GetTypeInfo().Assembly.Location),
                });
        }
    }
}
