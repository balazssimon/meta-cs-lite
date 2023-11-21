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
        private readonly ParserRuleSymbol _referencedBlock;

        public BlockRuleReference(ParserRuleSymbol viaBlock, ParserRuleSymbol referencedBlock)
        {
            _viaBlock = viaBlock;
            _referencedBlock = referencedBlock;
        }

        public ParserRuleSymbol ViaBlock => _viaBlock;
        public ParserRuleSymbol ReferencedBlock => _referencedBlock;
    }
}
