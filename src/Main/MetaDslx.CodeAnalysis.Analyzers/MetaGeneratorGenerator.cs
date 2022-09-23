using MetaDslx.CodeAnalysis.CodeGeneration;
using MetaDslx.CodeAnalysis.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace MetaDslx.CodeAnalysis.Analyzers
{
    // TODO: Target netstandard2.0!!!
    [Generator]
    public class MetaGeneratorGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            try
            {
                var csharpFilePaths = new HashSet<string>();
                var csharpCodes = new List<Entry>();
                foreach (var mgenFile in context.AdditionalFiles.Where(file => Path.GetExtension(file.Path) == ".mgen"))
                {
                    var source = mgenFile.GetText()?.ToString();
                    if (source != null)
                    {
                        var mgenCompiler = new CodeTemplateParser(mgenFile.Path, SourceText.From(source));
                        var csharpCode = mgenCompiler.Compile();
                        if (mgenCompiler.Diagnostics.Length > 0)
                        {
                            foreach (var diag in mgenCompiler.Diagnostics)
                            {
                                context.ReportDiagnostic(diag.ToMicrosoft());
                            }
                        }
                        else
                        {
                            var csharpFilePath = Path.GetFileNameWithoutExtension(mgenFile.Path) + ".Generated.cs";
                            csharpFilePaths.Add(csharpFilePath);
                            csharpCodes.Add(
                                new Entry() 
                                {
                                    MgenPath = mgenFile.Path,
                                    CSharpPath = csharpFilePath,
                                    Compiler = mgenCompiler,
                                    SourceText = Microsoft.CodeAnalysis.Text.SourceText.From(csharpCode, Encoding.UTF8) 
                                });
                        }
                    }
                }
                var syntaxTrees = csharpCodes.Select(code => CSharpSyntaxTree.ParseText(text: code.SourceText, path: code.CSharpPath));
                var compilation = context.Compilation.AddSyntaxTrees(syntaxTrees);
                foreach (var diagnostic in compilation.GetDiagnostics())
                {
                    var path = diagnostic.Location.GetLineSpan().Path;
                    if (diagnostic.Location.IsInSource && csharpFilePaths.Contains(path))
                    {
                        var csharpCode = csharpCodes.FirstOrDefault(code => code.CSharpPath == path);
                        if (csharpCode.CSharpPath == path)
                        {
                            if (!csharpCode.Compiler.FromCSharpToMgen(diagnostic.Location.SourceSpan.ToMetaDslx(), out var mgenTextSpan)) continue;
                            if (!csharpCode.Compiler.FromCSharpToMgen(diagnostic.Location.GetLineSpan().Span.ToMetaDslx(), out var mgenLinePositionSpan)) continue;
                            var mgenLocation = Microsoft.CodeAnalysis.Location.Create(csharpCode.MgenPath, mgenTextSpan.ToMicrosoft(), mgenLinePositionSpan.ToMicrosoft());
                            context.ReportDiagnostic(Microsoft.CodeAnalysis.Diagnostic.Create(descriptor: diagnostic.Descriptor, location: mgenLocation));
                            if (diagnostic.Severity == Microsoft.CodeAnalysis.DiagnosticSeverity.Error)
                            {
                                csharpCode.HasErrors = true;
                            }
                        }
                    }
                }
                foreach (var csharpCode in csharpCodes)
                {
                    context.AddSource(csharpCode.CSharpPath, csharpCode.SourceText);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void Initialize(GeneratorInitializationContext context)
        {
        }

        private struct Entry
        {
            public string MgenPath;
            public string CSharpPath;
            public CodeTemplateParser Compiler;
            public Microsoft.CodeAnalysis.Text.SourceText SourceText;
            public bool HasErrors;
        }
    }
}
