using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaCompiler.Compiler;
using MetaDslx.Languages.MetaCompiler.Compiler.Syntax;
using MetaDslx.VisualStudio.Utilities;
using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using MetaDslx.CodeAnalysis.Parsers.Antlr;
using MetaDslx.CodeAnalysis.Syntax;

namespace MetaDslx.VisualStudio.Languages.MetaCompiler.Classification
{
    internal class MetaCompilerClassifier : IClassifier
    {
        private IClassificationTypeRegistryService _classificationRegistryService;
        private IStandardClassificationService _standardClassificationService;
        private ITextBuffer _textBuffer;
        private ITextVersion _version;
        private List<ClassificationSpan> _classificationSpans;
        private CompilerSyntaxFacts _syntaxFacts;

        public MetaCompilerClassifier(ITextBuffer textBuffer, MetaDslxMefServices mefServices)
        {
            _textBuffer = textBuffer;
            _classificationRegistryService = mefServices.GetService<IClassificationTypeRegistryService>();
            _standardClassificationService = mefServices.GetService<IStandardClassificationService>();
            _syntaxFacts = CompilerLanguage.Instance.SyntaxFacts;
        }

        public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;
        public IClassificationTypeRegistryService ClassificationTypeRegistryService => _classificationRegistryService;
        public IStandardClassificationService StandardClassificationService => _standardClassificationService;

        protected void Invalidate(SnapshotSpan span)
        {
            if (ClassificationChanged != null)
                ClassificationChanged(this, new ClassificationChangedEventArgs(span));
        }

        public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan span)
        {
            var result = new List<ClassificationSpan>();
            if (_version != span.Snapshot.Version)
            {
                _version = span.Snapshot.Version;
                ComputeClassifications(span.Snapshot);
            }
            foreach (var classification in _classificationSpans)
            {
                if (span.IntersectsWith(classification.Span))
                {
                    result.Add(classification);
                }
            }
            return result;
        }

        private void ComputeClassifications(ITextSnapshot snapshot)
        {
            _classificationSpans = new List<ClassificationSpan>();
            var text = snapshot.GetText();
            var lexer = new CompilerLexer(new Antlr4.Runtime.AntlrInputStream(text));
            var tokens = new BufferedTokenStream(lexer);
            var token = tokens.LT(1);
            while (token.Type > 0)
            {
                tokens.Consume();
                var tokenSpan = new Span(token.StartIndex, token.Text.Length);
                _classificationSpans.Add(new ClassificationSpan(new SnapshotSpan(snapshot, tokenSpan), GetClassificationType((CompilerSyntaxKind)AntlrSyntaxKind.FromAntlr(token.Type))));
                token = tokens.LT(1);
            }
        }

        private IClassificationType GetClassificationType(CompilerSyntaxKind syntaxKind)
        {
            var tokenKind = _syntaxFacts.GetTokenKind(syntaxKind);
            if (tokenKind is KeywordTokenKind) return StandardClassificationService.Keyword;
            if (tokenKind is CommentTokenKind) return StandardClassificationService.Comment;
            if (tokenKind is IdentifierTokenKind) return StandardClassificationService.Identifier;
            if (tokenKind is NumberTokenKind) return StandardClassificationService.NumberLiteral;
            if (tokenKind is StringTokenKind) return StandardClassificationService.StringLiteral;
            return StandardClassificationService.Other;
        }

    }
}
