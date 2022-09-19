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
            options = options.WithHandler<TextDocumentSyncHandler>();

            var metaDslx = new MetaDslxLanguageServer(options.LoggerFactory);
            metaDslx.InitServer(options);
            return options;
        }
    }
}
