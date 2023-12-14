using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Model
{
    public class CompilerModelPostProcessor
    {
        private readonly MetaDslx.Modeling.Model _model;

        public CompilerModelPostProcessor(MetaDslx.Modeling.Model model)
        {
            _model = model;
        }

        public MetaDslx.Modeling.Model Model => _model;

        public ImmutableArray<Diagnostic> GetDiagnostics()
        {
            return ImmutableArray<Diagnostic>.Empty;
        }

        public void Execute()
        {

        }
    }
}
