using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Text;
using OmniSharp.Extensions.LanguageServer.Protocol;
using OmniSharp.Extensions.LanguageServer.Protocol.Server;
using OmniSharp.Extensions.LanguageServer.Server;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.LanguageServer
{
    internal abstract class DocumentCompiler
    {
        private CancellationTokenSource? _cancellationTokenSource;
        private ILanguageServerFacade _languageServer;
        private DocumentUri _uri;
        private int? _version;
        private SourceText _sourceText;

        public DocumentCompiler(ILanguageServerFacade languageServer, DocumentUri uri)
        {
            _languageServer = languageServer;
            _uri = uri;
        }

        public ILanguageServerFacade LanguageServer => _languageServer;
        public DocumentUri Uri => _uri;
        public int? Version => _version;
        public SourceText SourceText => _sourceText;
        public CancellationToken CancellationToken => _cancellationTokenSource.Token;

        public void Update(int? version, SourceText sourceText)
        {
            if (_cancellationTokenSource != null) _cancellationTokenSource.Cancel();
            _cancellationTokenSource = new CancellationTokenSource();
            Interlocked.Exchange(ref _sourceText, sourceText);
            _version = version;
            SourceUpdated();
        }

        protected abstract void SourceUpdated();
    }
}
