using Microsoft.Extensions.DependencyInjection;
using OmniSharp.Extensions.LanguageServer.Server;
using MetaDslx.LanguageServer.MetaGenerator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.LanguageServer
{
    public static class MetaDslxLanguageServerExtensions
    {
        public static LanguageServerOptions WithMetaDslx(this LanguageServerOptions options)
        {
            options.WithServices(ConfigureServices);
            options.WithHandler<TextDocumentSyncHandler>();
            options.WithHandler<CompletionHandler>();
            return options;
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<DocumentManager>();
        }
    }
}
