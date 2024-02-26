using MetaDslx.Bootstrap.MetaCompiler3.Model;
using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace MetaDslx.Bootstrap.MetaCompiler3.Generators
{
    using DiagnosticBag = MetaDslx.CodeAnalysis.DiagnosticBag;
    using ErrorCode = MetaDslx.CodeAnalysis.ErrorCode;
    using ExternalFileLocation = MetaDslx.CodeAnalysis.ExternalFileLocation;
    using TextSpan = MetaDslx.CodeAnalysis.Text.TextSpan;
    using LinePositionSpan = MetaDslx.CodeAnalysis.Text.LinePositionSpan;
    using LinePosition = MetaDslx.CodeAnalysis.Text.LinePosition;

    public partial class RoslynApiGenerator
    {
        private readonly Language _language;
        private List<Rule>? _rulesAndBlocks;

        public RoslynApiGenerator(Language language)
        {
            _language = language;
        }

        public string Namespace => _language.Namespace;
        public string Lang => _language.Name;

        public Language Language => _language;
        public Grammar Grammar => _language.Grammar;
        public Rule? MainRule => Grammar.MainRule;

        public IList<Token> Tokens => Grammar.Tokens;
        public IList<Rule> Rules => Grammar.Rules;
        public IList<Block> Blocks => Grammar.Blocks;

        public IList<TokenKind> TokenKinds => Grammar.TokenKinds;

        public IList<Rule> RulesAndBlocks
        {
            get
            {
                if (_rulesAndBlocks is null)
                {
                    _rulesAndBlocks = new List<Rule>();
                    _rulesAndBlocks.AddRange(Grammar.Rules);
                    _rulesAndBlocks.AddRange(Grammar.Blocks);
                }
                return _rulesAndBlocks;
            }
        }
        public IList<Token> FixedTokens => Grammar.Tokens.Where(t => t.IsFixed).ToList();
        public IList<Token> NonFixedTokens => Grammar.Tokens.Where(t => !t.IsFixed).ToList();
        public IList<Fragment> Fragments => Grammar.GrammarRules.OfType<Fragment>().ToList();

        public List<(string FileName, string Content)> GenerateAntlr(string path, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var result = new List<(string FileName, string Content)>();
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            try
            {
                Directory.CreateDirectory(tempDirectory);
                var lexerCode = GenerateLexer();
                var parserCode = GenerateParser();
                if (lexerCode is not null)
                {
                    var lexerFileName = $"{Lang}Lexer.g4";
                    var lexerFilePath = Path.Combine(tempDirectory, lexerFileName);
                    result.Add((lexerFileName, lexerCode));
                    File.WriteAllText(lexerFilePath, lexerCode);

                    var antlrTool = new AntlrTool();
                    antlrTool.GrammarFiles.Add(lexerFileName);
                    antlrTool.WorkingDirectory = tempDirectory;
                    antlrTool.TargetNamespace = Namespace;
                    antlrTool.Execute(cancellationToken);
                    if (antlrTool.Diagnostics.Length > 0)
                    {
                        foreach (var diag in antlrTool.Diagnostics)
                        {
                            var metaDiag = MetaDslx.CodeAnalysis.Diagnostic.Create(ErrorCode.ERR_SyntaxError, new ExternalFileLocation(diag.FilePath ?? path, TextSpan.FromBounds(0, 0), new LinePositionSpan(new LinePosition(diag.Line, diag.Column), new LinePosition(diag.Line, diag.Column))), diag.Message);
                            diagnostics.Add(metaDiag);
                        }
                    }
                    foreach (var antlrFile in antlrTool.GeneratedFiles)
                    {
                        var fileName = Path.GetFileNameWithoutExtension(antlrFile);
                        string? code;
                        if (antlrFile == $"{Lang}Lexer.cs")
                        {
                            code = GetLexerCode(Path.Combine(tempDirectory, antlrFile));
                        }
                        else
                        {
                            code = File.ReadAllText(Path.Combine(tempDirectory, antlrFile));
                        }
                        if (code is not null)
                        {
                            result.Add(($"MetaCompiler.Antlr.{fileName}.g.cs", code));
                        }
                    }
                }
                if (parserCode is not null)
                {
                    var parserFileName = $"{Lang}Parser.g4";
                    var parserFilePath = Path.Combine(tempDirectory, parserFileName);
                    result.Add((parserFileName, parserCode));
                    File.WriteAllText(parserFilePath, parserCode);

                    var antlrTool = new AntlrTool();
                    antlrTool.GrammarFiles.Add(parserFileName);
                    antlrTool.WorkingDirectory = tempDirectory;
                    antlrTool.TargetNamespace = Namespace;
                    antlrTool.GenerateVisitor = true;
                    antlrTool.Execute(cancellationToken);
                    if (antlrTool.Diagnostics.Length > 0)
                    {
                        foreach (var diag in antlrTool.Diagnostics)
                        {
                            var metaDiag = MetaDslx.CodeAnalysis.Diagnostic.Create(ErrorCode.ERR_SyntaxError, new ExternalFileLocation(diag.FilePath ?? path, TextSpan.FromBounds(0, 0), new LinePositionSpan(new LinePosition(diag.Line, diag.Column), new LinePosition(diag.Line, diag.Column))), diag.Message);
                            diagnostics.Add(metaDiag);
                        }
                    }
                    foreach (var antlrFile in antlrTool.GeneratedFiles)
                    {
                        var fileName = Path.GetFileNameWithoutExtension(antlrFile);
                        string? code;
                        if (antlrFile == $"{Lang}Parser.cs")
                        {
                            code = GetParserCode(Path.Combine(tempDirectory, antlrFile));
                        }
                        else
                        {
                            code = File.ReadAllText(Path.Combine(tempDirectory, antlrFile));
                        }
                        if (code is not null)
                        {
                            result.Add(($"MetaCompiler.Antlr.{fileName}.g.cs", code));
                        }
                    }
                    var syntaxLexerCode = GenerateAntlrSyntaxLexer();
                    result.Add(($"MetaCompiler.Antlr.SyntaxLexer.g.cs", syntaxLexerCode));
                    var syntaxParserCode = GenerateAntlrSyntaxParser();
                    result.Add(($"MetaCompiler.Antlr.SyntaxParser.g.cs", syntaxParserCode));
                    var syntaxFactoryCode = GenerateAntlrInternalSyntaxFactory();
                    result.Add(($"MetaCompiler.Antlr.InternalSyntaxFactory.g.cs", syntaxFactoryCode));
                }
            }
            catch (Exception ex)
            {
                var exLocation = MetaDslx.CodeAnalysis.ExternalFileLocation.Create(path, TextSpan.FromBounds(0, 0), new LinePositionSpan(LinePosition.Zero, LinePosition.Zero));
                var exDiag = MetaDslx.CodeAnalysis.Diagnostic.Create(MetaDslx.CodeAnalysis.ErrorCode.ERR_CodeGenerationError, exLocation, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
                diagnostics.Add(exDiag);
                Debug.WriteLine(ex);
            }
            finally
            {
                try
                {
                    Directory.Delete(tempDirectory, true);
                }
                catch (Exception)
                {
                    // nop
                }
            }
            return result;
        }

        private string GetLexerCode(string filePath)
        {
            var builder = PooledStringBuilder.GetInstance();
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line is not null)
                    {
                        if (line.Contains("public partial class") && line.Contains(": Lexer {"))
                        {
                            line = line.Replace(": Lexer {", ": global::MetaDslx.CodeAnalysis.Parsers.Antlr.AntlrLexer {");
                        }
                        builder.Builder.AppendLine(line);
                    }
                }
            }
            return builder.ToStringAndFree();
        }

        private string GetParserCode(string filePath)
        {
            var builder = PooledStringBuilder.GetInstance();
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line is not null)
                    {
                        if (line.Contains("public partial class") && line.Contains(": Parser {"))
                        {
                            line = line.Replace(": Parser {", ": global::MetaDslx.CodeAnalysis.Parsers.Antlr.AntlrParser {");
                        }
                        builder.Builder.AppendLine(line);
                    }
                }
            }
            return builder.ToStringAndFree();
        }

    }
}
