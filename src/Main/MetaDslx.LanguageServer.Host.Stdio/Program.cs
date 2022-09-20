using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OmniSharp.Extensions.LanguageServer.Protocol.Server;
using OmniSharp.Extensions.LanguageServer.Server;
using Serilog;
using System.Diagnostics;
using System.Reactive;
using System.Reflection;

namespace MetaDslx.LanguageServer.Host.Stdio
{
    internal class Program
    {
        private static ILanguageServer? _server;

        static async Task Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                //.WriteTo.Console()
                .WriteTo.File(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "logs", "MetaDslxLanguageServer.log"), rollingInterval: RollingInterval.Day)
                .CreateLogger();

            int hostPid = -1;
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "--pid":
                        ++i;
                        if (i < args.Length)
                        {
                            int.TryParse(args[i], out hostPid);
                        }
                        break;
                    default:
                        break;
                }
            }

            if (hostPid != -1)
            {
                var hostProcess = Process.GetProcessById(hostPid);
                hostProcess.EnableRaisingEvents = true;
                hostProcess.Exited += HostProcess_Exited;
            }

            Log.Information("Starting MetaDslx LanguageServer...");

            var server = await OmniSharp.Extensions.LanguageServer.Server.LanguageServer.From(options =>
            options
                .WithInput(Console.OpenStandardInput())
                .WithOutput(Console.OpenStandardOutput())
                .ConfigureLogging(
                            x => x
                                .AddSerilog(Log.Logger)
                                .AddLanguageProtocolLogging()
                                .SetMinimumLevel(LogLevel.Debug)
                        )
                .WithServices(x => x.AddLogging(b => b.SetMinimumLevel(LogLevel.Trace)))
                .WithMetaDslx()
                .OnStarted(async (languageServer, token) => {
                    _server = languageServer;
                    Log.Information("MetaDslx LanguageServer is up and running.");
                })
             );

            await server.WaitForExit;

            Log.Information("MetaDslx LanguageServer has exited.");
        }

        private static void HostProcess_Exited(object? sender, EventArgs e)
        {
            Log.Information("Terminating MetaDslx LanguageServer, since host process has exited.");
            System.Environment.Exit(1);
        }
    }
}