using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    public class Language
    {
        public string Namespace { get; set; }
        public Grammar Grammar { get; set; }
    }

    public enum AttributeKind
    {
        None,
        Def,
        Use
    }
    
    public enum Multiplicity
    {
        ExactlyOne,
        ZeroOrOne,
        ZeroOrMore,
        OneOrMore,
        NonGreedyZeroOrOne,
        NonGreedyZeroOrMore,
        NonGreedyOneOrMore
    }

    public enum AssignmentOperator
    {
        Assign,
        QuestionAssign,
        NegatedAssign,
        PlusAssign
    }

    public class NamedElement
    {
        public string Name { get; set; }
        public List<Attribute> Attributes { get; } = new List<Attribute>();
    }

    public class Attribute
    {
        public AttributeKind Kind { get; set; }
        public string Name { get; set; }
        public List<AttributeProperty> Properties { get; } = new List<AttributeProperty>();
    }

    public class AttributeProperty
    {
        public string Name { get; set; }
        public object? Value { get; set; }
    }

    public class GrammarOptions
    {
        public bool IsCaseInsensitive { get; set; }
        public bool IsWhitespaceIndented { get; set; }
    }

    public class Grammar : NamedElement
    {
        public GrammarOptions Options { get; set; }
        public List<Rule> Rules { get; } = new List<Rule>();
    }

    public abstract class Rule : NamedElement
    {
    }

    public class ParserRule : Rule
    {
        public List<ParserRuleAlternative> Alternatives { get; } = new List<ParserRuleAlternative>();
    }

    public class ParserRuleAlternative : NamedElement
    {
        public List<ParserRuleElement> Elements { get; } = new List<ParserRuleElement>();
    }

    public class ParserRuleElement : NamedElement
    {
        public bool IsNegated { get; set; }
        public AssignmentOperator AssignmentOperator { get; set; }
        public Multiplicity Multiplicity { get; set; }
    }

    public class ParserRuleReferenceElement : ParserRuleElement
    {
        public Rule Rule { get; set; }
    }

    public class ParserRuleEofElement : ParserRuleElement
    {
    }

    public class ParserRuleFixedElement : ParserRuleElement
    {
        public string Value { get; set; }
    }

    public class ParserRuleWildcardElement : ParserRuleElement
    {
    }

    public class ParserRuleBlockElement : ParserRuleElement
    {
        public List<ParserRuleAlternative> Alternatives { get; } = new List<ParserRuleAlternative>();
    }

    public class LexerRule : Rule
    {
        public bool IsFragment { get; set; }
        public bool IsHidden { get; set; }
        public List<LexerRuleAlternative> Alternatives { get; } = new List<LexerRuleAlternative>();
    }

    public class LexerRuleAlternative : NamedElement
    {
        public List<LexerRuleElement> Elements { get; } = new List<LexerRuleElement>();
    }

    public class LexerRuleElement : NamedElement
    {
        public bool IsNegated { get; set; }
        public Multiplicity Multiplicity { get; set; }
    }

    public class LexerRuleReferenceElement : LexerRuleElement
    {
        public LexerRule Rule { get; set; }
    }

    public class LexerRuleFixedStringElement : LexerRuleElement
    {
        public string Value { get; set; }
    }

    public class LexerRuleFixedCharElement : LexerRuleElement
    {
        public string Value { get; set; }
    }

    public class LexerRuleWildcardElement : LexerRuleElement
    {
    }

    public class LexerRuleBlockElement : LexerRuleElement
    {
        public List<LexerRuleAlternative> Alternatives { get; } = new List<LexerRuleAlternative>();
    }

    public class LexerRuleRangeElement : LexerRuleElement
    {
        public LexerRuleFixedCharElement Start { get; set; }
        public LexerRuleFixedCharElement End { get; set; }
    }
}
