using MetaDslx.LanguageServer.MetaGenerator;
using OmniSharp.Extensions.LanguageServer.Protocol.Client.Capabilities;
using OmniSharp.Extensions.LanguageServer.Protocol.Document;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using OmniSharp.Extensions.LanguageServer.Protocol.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetaDslx.LanguageServer
{
    using OmniRange = OmniSharp.Extensions.LanguageServer.Protocol.Models.Range;

    internal class CompletionHandler : ICompletionHandler
    {
        private readonly ILanguageServerFacade _languageServer;
        private readonly DocumentManager _documentManager;

        private readonly DocumentSelector _documentSelector = new DocumentSelector(
            new DocumentFilter()
            {
                Pattern = "**/*.mxg"
            }
        );

        public CompletionHandler(ILanguageServerFacade languageServer, DocumentManager documentManager)
        {
            _languageServer = languageServer;
            _documentManager = documentManager;
        }

        public CompletionRegistrationOptions GetRegistrationOptions(CompletionCapability capability, ClientCapabilities clientCapabilities)
        {
            return new CompletionRegistrationOptions() { DocumentSelector = _documentSelector };
        }

        public async Task<CompletionList> Handle(CompletionParams request, CancellationToken cancellationToken)
        {
            CompletionList result = null;
            var compiler = _documentManager.GetCompiler(request.TextDocument.Uri) as MetaGeneratorDocumentCompiler;
            if (compiler?.Parser != null)
            {
                var parser = compiler.Parser;
                var isTemplateOutput = parser.IsPositionInsideTemplateOutput(request.Position.Line, request.Position.Character);
                if (isTemplateOutput)
                {
                    var control = parser.GetControlBeginEndForPosition(request.Position.Line, request.Position.Character);
                    result = new CompletionList(
                        new CompletionItem() 
                        {
                            Kind = CompletionItemKind.Snippet,
                            TextEdit = new TextEditOrInsertReplaceEdit(
                                new TextEdit() 
                                { 
                                    Range = new OmniRange(request.Position.Line, request.Position.Character, request.Position.Line, request.Position.Character),
                                    NewText = $"{control.Item1}{control.Item2}"
                                }),
                            InsertTextFormat = InsertTextFormat.Snippet
                        });
                }
            }
            return result;
        }
    }
}
