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
    [Generator]
    public class MetaGeneratorGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            try
            {
                //Debugger.Launch();
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
                            var csharpFilePath = Path.GetFileNameWithoutExtension(mgenFile.Path) + ".g.cs";
                            context.AddSource(csharpFilePath, csharpCode);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
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
