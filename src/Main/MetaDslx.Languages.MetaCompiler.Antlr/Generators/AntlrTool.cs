using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace MetaDslx.Languages.MetaCompiler.Antlr.Generators
{
    public class AntlrTool
    {
        private ArrayBuilder<string> _generatedFiles = new ArrayBuilder<string>();
        private ArrayBuilder<AntlrToolMessage> _diagnostics = new ArrayBuilder<AntlrToolMessage>();

        public AntlrTool()
        {
            this.TimeoutInSeconds = 30;
            this.Encoding = "UTF-8";
            this.Diagnostics = ImmutableArray<AntlrToolMessage>.Empty;
        }

        public List<string> GrammarFiles { get; set; }
        public ImmutableArray<string> GeneratedFiles { get; set; }
        public ImmutableArray<AntlrToolMessage> Diagnostics { get; private set; }

        public int TimeoutInSeconds { get; set; }
        public string? JavaExe { get; set; }
        public string? ToolPath { get; set; }
        public string OutputPath { get; set; }
        public string Encoding { get; set; }
        public string TargetNamespace { get; set; }
        public bool GenerateListener { get; set; }
        public bool GenerateVisitor { get; set; }
        public bool ForceAtn { get; set; }

        public string? JavaHome
        {
            get
            {
                if (Directory.Exists(Environment.GetEnvironmentVariable("JAVA_HOME")))
                {
                    return Environment.GetEnvironmentVariable("JAVA_HOME");
                }
                else
                {
                    return null;
                }
            }
        }

        public bool Execute(CancellationToken cancellationToken)
        {
            bool success = false;
            _generatedFiles.Clear();
            _diagnostics.Clear();
            try
            {
                if (GrammarFiles.Count == 0)
                {
                    throw new FileNotFoundException("There is no input file.");
                }

                if (string.IsNullOrWhiteSpace(JavaExe))
                {
                    var javaHome = this.JavaHome;
                    if (!string.IsNullOrWhiteSpace(javaHome))
                    {
                        JavaExe = Path.Combine(javaHome, "bin", "java.exe");
                    }
                }

                if (string.IsNullOrWhiteSpace(JavaExe) || !File.Exists(JavaExe))
                {
                    throw new FileNotFoundException("Could not find 'java.exe'. Please, install a JRE and set the JAVA_HOME environment variable.");
                }

                if (string.IsNullOrWhiteSpace(ToolPath))
                {
                    var assemblyPath = Path.GetDirectoryName(typeof(AntlrTool).Assembly.Location);
                    var toolFolder = Path.Combine(assemblyPath, "tools");
                    ToolPath = toolFolder;
                    foreach (var antlrJarName in Directory.EnumerateFiles(toolFolder, "antlr-*-complete.jar"))
                    {
                        ToolPath = antlrJarName;
                        break;
                    }
                }

                if (string.IsNullOrWhiteSpace(ToolPath) || !File.Exists(ToolPath))
                {
                    throw new FileNotFoundException($"Could not find the ANTLR tools JAR at '{ToolPath}'.");
                }

                List<string> arguments = new List<string>();
                arguments.Add("-cp");
                arguments.Add(ToolPath);
                arguments.Add("org.antlr.v4.Tool");

                if (!string.IsNullOrEmpty(OutputPath))
                {
                    arguments.Add("-o");
                    arguments.Add(this.OutputPath);
                    Directory.CreateDirectory(OutputPath);
                }

                foreach (var src in GrammarFiles)
                {
                    if (string.IsNullOrWhiteSpace(src)) continue;
                    arguments.Add("-lib");
                    arguments.Add(Path.GetDirectoryName(src));
                }

                if (!string.IsNullOrEmpty(Encoding))
                {
                    arguments.Add("-encoding");
                    arguments.Add(Encoding);
                }

                if (GenerateListener)
                    arguments.Add("-listener");
                else
                    arguments.Add("-no-listener");

                if (GenerateVisitor)
                    arguments.Add("-visitor");
                else
                    arguments.Add("-no-visitor");

                if (!string.IsNullOrWhiteSpace(TargetNamespace))
                {
                    arguments.Add("-package");
                    arguments.Add(TargetNamespace);
                }

                arguments.Add("-Dlanguage=CSharp");

                if (ForceAtn)
                    arguments.Add("-Xforce-atn");

                arguments.AddRange(GrammarFiles);

                var startInfo = new ProcessStartInfo(JavaExe, JoinArguments(arguments))
                {
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                };

                this.AddDiagnosticInfo($"Executing command: '{startInfo.FileName}' {startInfo.Arguments}");

                var process = new Process();
                process.StartInfo = startInfo;
                process.ErrorDataReceived += HandleErrorDataReceived;
                process.OutputDataReceived += HandleOutputDataReceived;
                process.Start();
                process.BeginErrorReadLine();
                process.BeginOutputReadLine();
                process.StandardInput.Dispose();

                var time = 0;
                var timeout = TimeoutInSeconds > 0 ? TimeoutInSeconds * 10 : 10 * 10;
                while (time < timeout)
                {
                    process.WaitForExit(100);
                    if (cancellationToken.IsCancellationRequested) return false;
                    if (process.HasExited) break;
                    ++time;
                }

                if (process.HasExited)
                {
                    this.AddDiagnosticInfo($"The generated file list contains {_generatedFiles.Count()} items.");

                    success = process.ExitCode == 0;

                    if (success)
                    {
                        GeneratedFiles = _generatedFiles.ToImmutable();
                    }
                }
                else
                {
                    this.AddDiagnosticError("ANTLR tool timed out.");

                    try
                    {
                        process.Kill();
                    }
                    catch (Exception)
                    {
                        // nop
                    }
                }
            }
            catch (Exception exception)
            {
                ProcessException(exception);
                success = false;
            }

            return success;
        }

        private void AddDiagnosticInfo(string message)
        {
            this.AddDiagnostic(DiagnosticSeverity.Info, -1, null, -1, -1, message);
        }

        private void AddDiagnosticError(string message)
        {
            this.AddDiagnostic(DiagnosticSeverity.Error, -1, null, -1, -1, message);
        }

        private void ProcessException(Exception ex)
        {
            this.AddDiagnostic(DiagnosticSeverity.Error, -1, null, -1, -1, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
        }

        internal static bool IsFatalException(Exception exception)
        {
            while (exception != null)
            {
                if (exception is OutOfMemoryException)
                {
                    return true;
                }

                if (!(exception is TypeInitializationException) && !(exception is TargetInvocationException))
                {
                    break;
                }

                exception = exception.InnerException;
            }

            return false;
        }


        private static string JoinArguments(IEnumerable<string> arguments)
        {
            if (arguments == null)
                throw new ArgumentNullException("arguments");

            StringBuilder builder = new StringBuilder();
            foreach (string argument in arguments)
            {
                if (builder.Length > 0)
                    builder.Append(' ');

                if (argument.IndexOfAny(new[] { '"', ' ' }) < 0)
                {
                    builder.Append(argument);
                    continue;
                }

                // escape a backslash appearing before a quote
                string arg = argument.Replace("\\\"", "\\\\\"");
                // escape double quotes
                arg = arg.Replace("\"", "\\\"");

                // wrap the argument in outer quotes
                builder.Append('"').Append(arg).Append('"');
            }

            return builder.ToString();
        }

        private static readonly Regex ErrorMessageFormat = new Regex(@"^(?<SEVERITY>[a-z]+)\((?<ERRORCODE>[0-9]+)\): (?<FILE>.*?):(?<LINE>[0-9]*?):(?<COLUMN>[0-9]*?): (?<MESSAGE>.*?)$", RegexOptions.Compiled);
        private static readonly Regex GeneratedFileMessageFormat = new Regex(@"^Generating file '(?<OUTPUT>.*?)' for grammar '(?<GRAMMAR>.*?)'$", RegexOptions.Compiled);
        private static readonly Regex DependFileMessageFormat = new Regex(@"^(?<OUTPUT>\S+)\s*:", RegexOptions.Compiled);

        private void HandleErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            HandleErrorDataReceived(e.Data);
        }

        private void HandleErrorDataReceived(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
                return;

            try
            {
                Match match = ErrorMessageFormat.Match(data);
                if (!match.Success)
                {
                    this.AddDiagnostic(DiagnosticSeverity.Info, -1, null, -1, -1, data);
                    return;
                }

                string severity = match.Groups["SEVERITY"].Value;
                string fileName = match.Groups["FILE"].Value;
                int.TryParse(match.Groups["ERRORCODE"].Value, out int errorCode);
                int.TryParse(match.Groups["LINE"].Value, out int line);
                int.TryParse(match.Groups["COLUMN"].Value, out int column);
                string message = match.Groups["MESSAGE"].Value;

                string filePath = GrammarFiles.FirstOrDefault(f => f.EndsWith(fileName)) ?? fileName;
                switch (severity)
                {
                    case "error":
                    case "fatal":
                        this.AddDiagnostic(DiagnosticSeverity.Error, errorCode, filePath, line, column, message);
                        break;
                    case "warning":
                        this.AddDiagnostic(DiagnosticSeverity.Warning, errorCode, filePath, line, column, message);
                        break;
                    case "info":
                    default:
                        this.AddDiagnostic(DiagnosticSeverity.Info, errorCode, filePath, line, column, message);
                        break;
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }

        private void HandleOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            HandleOutputDataReceived(e.Data);
        }

        private void HandleOutputDataReceived(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
                return;

            try
            {
                Match match = GeneratedFileMessageFormat.Match(data);
                if (!match.Success)
                {
                    this.AddDiagnostic(DiagnosticSeverity.Info, -1, null, -1, -1, data);
                    return;
                }

                string fileName = match.Groups["OUTPUT"].Value;
                if (Path.GetExtension(fileName).ToLower() == ".cs")
                {
                    _generatedFiles.Add(match.Groups["OUTPUT"].Value);
                }
            }
            catch (Exception ex)
            {
                this.AddDiagnostic(DiagnosticSeverity.Error, -1, null, -1, -1, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
            }
        }

        private void HandleOutputDataReceivedFirstTime(object sender, DataReceivedEventArgs e)
        {
            string data = e.Data as string;
            if (string.IsNullOrEmpty(data))
                return;

            try
            {
                Match match = DependFileMessageFormat.Match(data);
                if (!match.Success)
                {
                    this.AddDiagnostic(DiagnosticSeverity.Info, -1, null, -1, -1, data);
                    return;
                }

                string fileName = match.Groups["OUTPUT"].Value;
                if (Path.GetExtension(fileName).ToLower() == ".cs")
                {
                    _generatedFiles.Add(match.Groups["OUTPUT"].Value);
                }
            }
            catch (Exception ex)
            {
                this.AddDiagnostic(DiagnosticSeverity.Error, -1, null, -1, -1, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
            }
        }

        private void AddDiagnostic(DiagnosticSeverity severity, int errorCode, string filePath, int line, int column, string message)
        {
            var diag = new AntlrToolMessage(severity, errorCode, filePath, line, column, message);
            _diagnostics.Add(diag);
        }
    }
}
