using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.CodeGeneration;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Text;
using OmniSharp.Extensions.LanguageServer.Protocol;
using OmniSharp.Extensions.LanguageServer.Protocol.Document;
using OmniSharp.Extensions.LanguageServer.Protocol.Server;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetaDslx.LanguageServer.MetaGenerator
{
    using OmniDiagnostic = OmniSharp.Extensions.LanguageServer.Protocol.Models.Diagnostic;
    using OmniRange = OmniSharp.Extensions.LanguageServer.Protocol.Models.Range;
    using OmniSeverity = OmniSharp.Extensions.LanguageServer.Protocol.Models.DiagnosticSeverity;
    using PublishDiagnosticsParams = OmniSharp.Extensions.LanguageServer.Protocol.Models.PublishDiagnosticsParams;

    internal class MetaGeneratorDocumentCompiler : DocumentCompiler
    {
        private MetaGeneratorParser? _parser;
        private ImmutableArray<Diagnostic> _diagnostics;

        public MetaGeneratorDocumentCompiler(ILanguageServerFacade languageServer, DocumentUri document)
            : base(languageServer, document)
        {
            _diagnostics = ImmutableArray<Diagnostic>.Empty;
        }

        public MetaGeneratorParser? Parser => _parser;
        public ImmutableArray<Diagnostic> Diagnostics => _diagnostics;

        protected override void SourceUpdated()
        {
            Task.Run(async () => await Compile());
        }

        private async Task Compile()
        {
            if (CancellationToken.IsCancellationRequested) return;
            var parser = new MetaGeneratorParser(Uri.ToString(), SourceText);
            parser.Compile();
            Interlocked.Exchange(ref _parser, parser);
            var uri = Uri;
            var version = Version;
            if (CancellationToken.IsCancellationRequested) return;
            ImmutableInterlocked.InterlockedExchange(ref _diagnostics, parser.Diagnostics);
            var builder = ArrayBuilder<OmniDiagnostic>.GetInstance();
            foreach (var diag in _diagnostics)
            {
                var span = diag.Location.GetLineSpan();
                builder.Add(
                    new OmniDiagnostic()
                    {
                        Code = diag.Id,
                        Message = diag.GetMessage(),
                        Range = new OmniRange(span.StartLinePosition.Line, span.StartLinePosition.Character, span.EndLinePosition.Line, span.EndLinePosition.Character),
                        Severity = ToOmniSharp(diag.Severity)
                    });
            }
            if (CancellationToken.IsCancellationRequested)
            {
                builder.Free();
                return;
            }
            LanguageServer.TextDocument.PublishDiagnostics(new PublishDiagnosticsParams() { Diagnostics = builder.ToArrayAndFree(), Uri = uri, Version = version });
        }

        private static OmniSeverity ToOmniSharp(DiagnosticSeverity severity)
        {
            switch (severity)
            {
                case DiagnosticSeverity.Info:
                    return OmniSeverity.Information;
                case DiagnosticSeverity.Warning:
                    return OmniSeverity.Warning;
                case DiagnosticSeverity.Error:
                    return OmniSeverity.Error;
                default:
                    return OmniSeverity.Hint;
            }
        }
    }
}
