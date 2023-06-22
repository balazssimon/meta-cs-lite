using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Annotations
{
    [Flags]
    public enum AnnotationTargets
    {
        None = 0,
        LexerRuleName = 0x0001,
        ParserRuleNonTerminalName = 0x0002,
        ParserRuleAlternativeName = 0x0004,
        ParserRuleElementName = 0x0008,
        ParserRuleElementValue = 0x0010,

        ParserRuleName = ParserRuleNonTerminalName | ParserRuleAlternativeName,
        ParserRuleElement = ParserRuleElementName | ParserRuleElementValue,
        ParserRule = ParserRuleName | ParserRuleElement,
        RuleName = LexerRuleName | ParserRuleName | ParserRuleAlternativeName,
        Name = RuleName | ParserRuleElementName,
        All = LexerRuleName | ParserRule
    }
}
