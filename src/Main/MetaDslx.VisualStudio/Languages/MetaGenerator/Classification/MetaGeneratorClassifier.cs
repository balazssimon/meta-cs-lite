using MetaDslx.CodeAnalysis.CodeGeneration;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.VisualStudio.Utilities;
using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.VisualStudio.Languages.MetaGenerator.Classification
{
    internal class MetaGeneratorClassifier : IClassifier
    {
        private IClassificationTypeRegistryService _classificationRegistryService;
        private IStandardClassificationService _standardClassificationService;
        private ITextBuffer _textBuffer;
        private ITextVersion _version;
        private List<ClassificationSpan> _classificationSpans;

        public MetaGeneratorClassifier(ITextBuffer textBuffer, MetaDslxMefServices mefServices)
        {
            _textBuffer = textBuffer;
            _classificationRegistryService = mefServices.GetService<IClassificationTypeRegistryService>();
            _standardClassificationService = mefServices.GetService<IStandardClassificationService>();
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
            var lexer = new MetaGeneratorLexer("", SourceText.From(text, Encoding.UTF8));
            var state = MetaGeneratorLexerState.None;
            var token = lexer.Lex(ref state);
            while (token.Kind != MetaGeneratorTokenKind.None && token.Kind != MetaGeneratorTokenKind.EndOfFile)
            {
                var tokenSpan = new Span(token.Position, token.Text.Length);
                _classificationSpans.Add(new ClassificationSpan(new SnapshotSpan(snapshot, tokenSpan), GetClassificationType(token.Kind)));
                token = lexer.Lex(ref state);
            }
        }

        private IClassificationType GetClassificationType(MetaGeneratorTokenKind tokenKind)
        {
            switch (tokenKind)
            {
                case MetaGeneratorTokenKind.SingleLineComment:
                case MetaGeneratorTokenKind.MultiLineComment:
                    return StandardClassificationService.Comment;
                case MetaGeneratorTokenKind.Identifier:
                case MetaGeneratorTokenKind.VerbatimIdentifier:
                    return StandardClassificationService.Identifier;
                case MetaGeneratorTokenKind.Keyword:
                    return StandardClassificationService.Keyword;
                case MetaGeneratorTokenKind.Number:
                    return StandardClassificationService.NumberLiteral;
                case MetaGeneratorTokenKind.String:
                case MetaGeneratorTokenKind.VerbatimString:
                    return StandardClassificationService.StringLiteral;
                case MetaGeneratorTokenKind.TemplateControlBegin:
                case MetaGeneratorTokenKind.TemplateControlEnd:
                    return ClassificationTypeRegistryService.GetClassificationType(MetaGeneratorClassificationTypes.TemplateControl);
                case MetaGeneratorTokenKind.TemplateOutput:
                    return ClassificationTypeRegistryService.GetClassificationType(MetaGeneratorClassificationTypes.TemplateOutput);
                default:
                    return StandardClassificationService.Other;
            }

        }

    }
}
