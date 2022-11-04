﻿using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    public interface IElementWithLocation
    {
        Location Location { get; }
    }

    public class Language : IElementWithLocation
    {
        public ImmutableArray<string> Namespace { get; set; }
        public List<ImmutableArray<string>> Usings { get; } = new List<ImmutableArray<string>>();
        public string Name { get; set; }
        public Grammar Grammar { get; set; }

        public Location Location { get; set; }
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

    public class NamedElement : IElementWithLocation
    {
        public string Name { get; set; }
        public List<Annotation> Annotations { get; } = new List<Annotation>();

        public Location Location { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Annotation : IElementWithLocation
    {
        public AnnotationKind Kind { get; set; }
        public ImmutableArray<string> Name { get; set; }
        public List<AnnotationProperty> Properties { get; } = new List<AnnotationProperty>();

        public Location Location { get; set; }

        public override string ToString()
        {
            return string.Join(".", Name);
        }
    }

    public class AnnotationProperty : IElementWithLocation
    {
        public string Name { get; set; }
        public string? Value { get; set; }

        public Location Location { get; set; }

        public override string ToString()
        {
            return $"{Name}={Value}";
        }
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
        public Location? NameLocation { get; set; }
        public List<Annotation> NameAnnotations { get; } = new List<Annotation>();
        public bool IsNegated { get; set; }
        public AssignmentOperator AssignmentOperator { get; set; }
        public Multiplicity Multiplicity { get; set; }
    }

    public class ParserRuleReferenceElement : ParserRuleElement
    {
        public ImmutableArray<string> RuleName { get; set; }
        public Rule Rule { get; set; }

        public override string ToString()
        {
            return $"{Name}={string.Join(".", RuleName)}";
        }
    }

    public class ParserRuleEofElement : ParserRuleElement
    {
    }

    public class ParserRuleFixedStringElement : ParserRuleElement
    {
        public string ValueText { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{Name}={ValueText}";
        }
    }

    public class ParserRuleWildcardElement : ParserRuleElement
    {
    }

    public class ParserRuleBlockElement : ParserRuleElement
    {
        public List<ParserRuleAlternative> Alternatives { get; } = new List<ParserRuleAlternative>();
    }

    public class ParserRuleListElement : ParserRuleElement
    {
        public ParserRuleReferenceElement First { get; set; }
        public object Separator { get; set; }
        public ParserRuleReferenceElement Next { get; set; }
        public ParserRuleBlockElement Block { get; set; }
    }

    public class LexerRule : Rule
    {
        public bool IsFragment { get; set; }
        public bool IsHidden { get; set; }
        public bool IsFixed => Alternatives.Count == 1 && Alternatives[0].IsFixed;
        public List<LexerRuleAlternative> Alternatives { get; } = new List<LexerRuleAlternative>();
    }

    public class LexerRuleAlternative : NamedElement
    {
        public bool IsFixed => Elements.All(e => e.IsFixed);
        public List<LexerRuleElement> Elements { get; } = new List<LexerRuleElement>();
    }

    public abstract class LexerRuleElement
    {
        public abstract bool IsFixed { get; }
        public bool IsNegated { get; set; }
        public Multiplicity Multiplicity { get; set; }
    }

    public class LexerRuleReferenceElement : LexerRuleElement, IElementWithLocation
    {
        public override bool IsFixed => Rule?.IsFixed ?? false;
        public ImmutableArray<string> RuleName { get; set; }
        public LexerRule? Rule { get; set; }
        public Location Location { get; set; }

        public override string ToString()
        {
            return string.Join(".", RuleName);
        }
    }

    public class LexerRuleFixedStringElement : LexerRuleElement
    {
        public override bool IsFixed => true;
        public string ValueText { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return ValueText;
        }
    }

    public class LexerRuleWildcardElement : LexerRuleElement
    {
        public override bool IsFixed => false;
    }

    public class LexerRuleBlockElement : LexerRuleElement
    {
        public override bool IsFixed => Alternatives.Count == 1 && Alternatives[0].IsFixed;
        public List<LexerRuleAlternative> Alternatives { get; } = new List<LexerRuleAlternative>();
    }

    public class LexerRuleRangeElement : LexerRuleElement
    {
        public override bool IsFixed => false;
        public string StartText { get; set; }
        public char Start { get; set; }
        public string EndText { get; set; }
        public char End { get; set; }

        public override string ToString()
        {
            return $"{StartText}..{EndText}";
        }
    }
}
