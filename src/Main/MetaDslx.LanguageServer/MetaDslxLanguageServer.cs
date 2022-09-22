using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OmniSharp.Extensions.LanguageServer.Protocol.Document;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using OmniSharp.Extensions.LanguageServer.Protocol.Server;
using OmniSharp.Extensions.LanguageServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetaDslx.LanguageServer
{
    internal class MetaDslxLanguageServer
    {
        private ILoggerFactory _loggerFactory;
        private ILogger _logger;

        internal MetaDslxLanguageServer(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
            _logger = _loggerFactory.CreateLogger("MetaDslx");
        }

        internal void InitServer(LanguageServerOptions options)
        {
            options.OnCompletion(Completion, (_, _) => new CompletionRegistrationOptions());
        }

        public async Task<CompletionList> Completion(CompletionParams completionParams, CancellationToken cancellationToken)
        {
            var completions = new CompletionList(
                /*new CompletionItem() { Label = "Ook!", InsertText = "Ook!" },
                new CompletionItem() { Label = "Ook.", InsertText = "Ook." },
                new CompletionItem() { Label = "Ook?", InsertText = "Ook?" }*/
                );
            return completions;
        }

    }
}
