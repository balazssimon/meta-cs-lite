using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MetaDslx.CodeAnalysis.Text;
using OmniSharp.Extensions.LanguageServer.Protocol;
using OmniSharp.Extensions.LanguageServer.Protocol.Client.Capabilities;
using OmniSharp.Extensions.LanguageServer.Protocol.Document;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using OmniSharp.Extensions.LanguageServer.Protocol.Server;
using OmniSharp.Extensions.LanguageServer.Protocol.Server.Capabilities;
using OmniSharp.Extensions.LanguageServer.Protocol.Window;

namespace MetaDslx.LanguageServer
{
    internal class TextDocumentSyncHandler : ITextDocumentSyncHandler
    {
        private readonly ILanguageServerFacade _languageServer;
        private readonly DocumentManager _documentManager;

        private readonly DocumentSelector _documentSelector = new DocumentSelector(
            new DocumentFilter()
            {
                Pattern = "**/*.mxg"
            }
        );

        private SynchronizationCapability _capability;

        public TextDocumentSyncHandler(ILanguageServerFacade languageServer, DocumentManager documentManager)
        {
            _languageServer = languageServer;
            _documentManager = documentManager;
        }

        public TextDocumentSyncKind Change { get; } = TextDocumentSyncKind.Full;

        public void SetCapability(SynchronizationCapability capability)
        {
            _capability = capability;
        }

        TextDocumentChangeRegistrationOptions IRegistration<TextDocumentChangeRegistrationOptions, SynchronizationCapability>.GetRegistrationOptions(SynchronizationCapability capability, ClientCapabilities clientCapabilities)
        {
            return new TextDocumentChangeRegistrationOptions()
            {
                DocumentSelector = _documentSelector,
                SyncKind = Change
            };
        }

        TextDocumentOpenRegistrationOptions IRegistration<TextDocumentOpenRegistrationOptions, SynchronizationCapability>.GetRegistrationOptions(SynchronizationCapability capability, ClientCapabilities clientCapabilities)
        {
            return new TextDocumentOpenRegistrationOptions()
            {
                DocumentSelector = _documentSelector
            };
        }

        TextDocumentCloseRegistrationOptions IRegistration<TextDocumentCloseRegistrationOptions, SynchronizationCapability>.GetRegistrationOptions(SynchronizationCapability capability, ClientCapabilities clientCapabilities)
        {
            return new TextDocumentCloseRegistrationOptions()
            {
                DocumentSelector = _documentSelector
            };
        }

        TextDocumentSaveRegistrationOptions IRegistration<TextDocumentSaveRegistrationOptions, SynchronizationCapability>.GetRegistrationOptions(SynchronizationCapability capability, ClientCapabilities clientCapabilities)
        {
            return new TextDocumentSaveRegistrationOptions()
            {
                DocumentSelector = _documentSelector,
                IncludeText = true
            };
        }

        TextDocumentAttributes ITextDocumentIdentifier.GetTextDocumentAttributes(DocumentUri uri)
        {
            return new TextDocumentAttributes(uri, "mxg");
        }

        Task<Unit> IRequestHandler<DidChangeTextDocumentParams, Unit>.Handle(DidChangeTextDocumentParams request, CancellationToken cancellationToken)
        {
            var document = request.TextDocument.Uri;
            var text = request.ContentChanges.FirstOrDefault()?.Text;

            if (text != null)
            {
                _documentManager.UpdateDocument(document, request.TextDocument.Version, SourceText.From(text));
                _languageServer.Window.LogInfo($"Updated buffer for document: {document}\n{text}");
            }

            return Unit.Task;
        }

        Task<Unit> IRequestHandler<DidOpenTextDocumentParams, Unit>.Handle(DidOpenTextDocumentParams request, CancellationToken cancellationToken)
        {
            _documentManager.AddDocument(_languageServer, request.TextDocument.Uri);
            _documentManager.UpdateDocument(request.TextDocument.Uri, request.TextDocument.Version, SourceText.From(request.TextDocument.Text));
            return Unit.Task;
        }

        Task<Unit> IRequestHandler<DidCloseTextDocumentParams, Unit>.Handle(DidCloseTextDocumentParams request, CancellationToken cancellationToken)
        {
            _documentManager.RemoveDocument(request.TextDocument.Uri);
            return Unit.Task;
        }

        Task<Unit> IRequestHandler<DidSaveTextDocumentParams, Unit>.Handle(DidSaveTextDocumentParams request, CancellationToken cancellationToken)
        {
            return Unit.Task;
        }
    }
}
