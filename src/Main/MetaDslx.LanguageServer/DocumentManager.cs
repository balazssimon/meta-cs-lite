using MetaDslx.CodeAnalysis.Text;
using MetaDslx.LanguageServer.MetaGenerator;
using OmniSharp.Extensions.LanguageServer.Protocol;
using OmniSharp.Extensions.LanguageServer.Protocol.Server;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace MetaDslx.LanguageServer
{
    internal class DocumentManager
    {
        private ConcurrentDictionary<DocumentUri, DocumentCompiler> _documents = new ConcurrentDictionary<DocumentUri, DocumentCompiler>();

        public void AddDocument(ILanguageServerFacade languageServer, DocumentUri uri)
        {
            if (!_documents.ContainsKey(uri))
            {
                _documents.TryAdd(uri, new MetaGeneratorDocumentCompiler(languageServer, uri));
            }
        }

        public void RemoveDocument(DocumentUri uri)
        {
            _documents.TryRemove(uri, out var compiler);
        }

        public void UpdateDocument(DocumentUri uri, int? version, SourceText sourceText)
        {
            var compiler = GetCompiler(uri);
            compiler?.Update(version, sourceText);
        }

        public DocumentCompiler? GetCompiler(DocumentUri uri)
        {
            return _documents.TryGetValue(uri, out var compiler) ? compiler : null;
        }
    }
}
