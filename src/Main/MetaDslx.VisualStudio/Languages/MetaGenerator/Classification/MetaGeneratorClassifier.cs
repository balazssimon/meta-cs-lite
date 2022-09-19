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
    /*internal class MetaGeneratorClassifier : IClassifier
    {
        private IClassificationTypeRegistryService _classificationRegistryService;
        private IStandardClassificationService _standardClassificationService;
        private ITextBuffer _textBuffer;
        private CodeTemplateLexer _lexer;

        public MetaGeneratorClassifier(ITextBuffer textBuffer, MetaDslxMefServices mefServices)
        {
            _textBuffer = textBuffer;
            this.lexer = lexer;
            this.classificationRegistryService = mefServices.GetService<IClassificationTypeRegistryService>();
            this.standardClassificationService = mefServices.GetService<IStandardClassificationService>();
        }

        public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;
        public IClassificationTypeRegistryService ClassificationTypeRegistryService => this.classificationRegistryService;
        public IStandardClassificationService StandardClassificationService => this.standardClassificationService;

        protected void Invalidate(SnapshotSpan span)
        {
            if (ClassificationChanged != null)
                ClassificationChanged(this, new ClassificationChangedEventArgs(span));
        }

        public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan span)
        {
            throw new NotImplementedException();
        }
    }*/
}
