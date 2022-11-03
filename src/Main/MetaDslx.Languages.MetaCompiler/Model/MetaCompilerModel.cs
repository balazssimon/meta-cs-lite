using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    public class Language
    {
        public ImmutableArray<string> Namespace { get; set; }
        public List<ImmutableArray<string>> Usings { get; } = new List<ImmutableArray<string>>();
        public Grammar Grammar { get; set; }
    }

    public enum AnnotationKind
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
        public List<Annotation> Annotations { get; } = new List<Annotation>();
    }

    public class Annotation
    {
        public AnnotationKind Kind { get; set; }
        public ImmutableArray<string> Name { get; set; }
        public List<AnnotationProperty> Properties { get; } = new List<AnnotationProperty>();
    }

    public class AnnotationProperty
    {
        public string Name { get; set; }
        public string? Value { get; set; }
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

    public abstract class ParserRuleElement : NamedElement
    {
        public bool IsNegated { get; set; }
        public AssignmentOperator AssignmentOperator { get; set; }
        public Multiplicity Multiplicity { get; set; }
    }

    public class ParserRuleReferenceElement : ParserRuleElement
    {
        public ImmutableArray<string> RuleName { get; set; }
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

    public abstract class LexerRuleElement : NamedElement
    {
        public bool IsNegated { get; set; }
        public Multiplicity Multiplicity { get; set; }
    }

    public class LexerRuleReferenceElement : LexerRuleElement
    {
        public ImmutableArray<string> RuleName { get; set; }
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
