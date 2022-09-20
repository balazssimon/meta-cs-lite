using Microsoft.Extensions.DependencyInjection;
using OmniSharp.Extensions.LanguageServer.Server;
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

            var metaDslx = new MetaDslxLanguageServer(options.LoggerFactory);
            metaDslx.InitServer(options);
            return options;
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<BufferManager>();
        }
    }
}
