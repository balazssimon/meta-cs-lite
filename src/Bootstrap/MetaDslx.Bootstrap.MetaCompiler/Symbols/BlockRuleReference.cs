using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    internal struct BlockRuleReference
    {
        private readonly ParserRuleSymbol _viaBlock;
        private readonly PAlternativeSymbol _referencingPAlternative;

        public BlockRuleReference(ParserRuleSymbol viaBlock, PAlternativeSymbol referencingPAlternative)
        {
            _viaBlock = viaBlock;
            _referencingPAlternative = referencingPAlternative;
        }

        public ParserRuleSymbol ViaBlock => _viaBlock;
        public PAlternativeSymbol ReferencingPAlternative => _referencingPAlternative;
        public ParserRuleSymbol ReferencingRule => _referencingPAlternative.ContainingSymbol as ParserRuleSymbol;
    }
}
