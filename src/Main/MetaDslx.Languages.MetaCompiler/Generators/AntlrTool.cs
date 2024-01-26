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

namespace MetaDslx.Languages.MetaCompiler.Generators
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
            this.GrammarFiles = new List<string>();
        }

        public List<string> GrammarFiles { get; private set; }
        public ImmutableArray<string> GeneratedFiles { get; set; }
        public ImmutableArray<AntlrToolMessage> Diagnostics { get; private set; }

        public int TimeoutInSeconds { get; set; }
        public string? JavaExe { get; set; }
        public string? ToolPath { get; set; }
        public string WorkingDirectory { get; set; }
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
            GeneratedFiles = ImmutableArray<string>.Empty;
            Diagnostics = ImmutableArray<AntlrToolMessage>.Empty;

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

                // Because we're using the Java version of the Antlr tool,
                // we're going to execute this command twice: first with the
                // -depend option so as to get the list of generated files,
                // then a second time to actually generate the files.
                // The code that was here probably worked, but only for the C#
                // version of the Antlr tool chain.
                //
                // After collecting the output of the first command, convert the
                // output so as to get a clean list of files generated.

                List<string> arguments = new List<string>();
                arguments.Add("-cp");
                arguments.Add(ToolPath);
                arguments.Add("org.antlr.v4.Tool");
                arguments.Add("-depend");

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

                if (!ExecuteAntlrTool(JavaExe, JoinArguments(arguments), true, cancellationToken)) return false;

                // Add in tokens and interp files since Antlr Tool does not do that.
                var old_list = _generatedFiles.ToList();
                _generatedFiles.Clear();
                foreach (var s in old_list)
                {
                    if (Path.GetExtension(s) == ".tokens")
                    {
                        var interp = s.Replace(Path.GetExtension(s), ".interp");
                        _generatedFiles.Add(interp);
                    }
                    _generatedFiles.Add(s);
                }

                // Remove the -depend option from the second run
                arguments.Remove("-depend");

                if (!ExecuteAntlrTool(JavaExe, JoinArguments(arguments), false, cancellationToken)) return false;

                // At this point, regenerate the entire _generatedCodeFiles list.
                // This is because (1) it contains duplicates; (2) it contains
                // files that really actually weren't generated. This can happen
                // if the grammar was a Lexer grammar. (Note, I don't think it
                // wise to look at the grammar file to figure out what it is, nor
                // do I think it wise to expose a switch to the user for him to
                // indicate what type of grammar it is.)
                GeneratedFiles = _generatedFiles.Distinct().Where(fn => File.Exists(Path.Combine(WorkingDirectory, fn))).ToImmutableArray();
            }
            catch (Exception exception)
            {
                ProcessException(exception);
                success = false;
            }
            finally
            {
                Diagnostics = _diagnostics.ToImmutable();
            }

            return success;
        }

        private bool ExecuteAntlrTool(string javaExe, string arguments, bool depend, CancellationToken cancellationToken)
        {
            var startInfo = new ProcessStartInfo(JavaExe, arguments)
            {
                WorkingDirectory = WorkingDirectory,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
            };

            Debug.WriteLine($"Executing command: '{startInfo.FileName}' {startInfo.Arguments}");

            var process = new Process();
            process.StartInfo = startInfo;
            process.ErrorDataReceived += HandleErrorDataReceived;
            process.OutputDataReceived += depend ? HandleOutputDataReceivedFirstTime : HandleOutputDataReceived;
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
                Debug.WriteLine($"The generated file list contains {_generatedFiles.Count()} items.");
                return process.ExitCode == 0;
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
                return false;
            }
        }

        private void AddDiagnosticInfo(string message)
        {
            this.AddDiagnostic(DiagnosticSeverity.Info, -1, null, 0, 0, message);
        }

        private void AddDiagnosticError(string message)
        {
            this.AddDiagnostic(DiagnosticSeverity.Error, -1, null, 0, 0, message);
        }

        private void ProcessException(Exception ex)
        {
            this.AddDiagnostic(DiagnosticSeverity.Error, -1, null, 0, 0, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
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
        //private static readonly Regex GeneratedFileMessageFormat = new Regex(@"^(?<OUTPUT>.*?)\s*:\s*(?<GRAMMAR>.*?)$", RegexOptions.Compiled);
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
                    this.AddDiagnostic(DiagnosticSeverity.Info, -1, null, 0, 0, data);
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
                    this.AddDiagnostic(DiagnosticSeverity.Info, -1, null, 0, 0, data);
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
                this.AddDiagnostic(DiagnosticSeverity.Error, -1, null, 0, 0, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
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
                    this.AddDiagnostic(DiagnosticSeverity.Info, -1, null, 0, 0, data);
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
                this.AddDiagnostic(DiagnosticSeverity.Error, -1, null, 0, 0, ex.ToString().Replace('\r', ' ').Replace('\n', ' '));
            }
        }

        private void AddDiagnostic(DiagnosticSeverity severity, int errorCode, string filePath, int line, int column, string message)
        {
            var diag = new AntlrToolMessage(severity, errorCode, filePath, line, column, message);
            _diagnostics.Add(diag);
        }
    }
}
