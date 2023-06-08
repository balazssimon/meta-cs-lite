using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.NetworkInformation;
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
        public string QualifiedNamespace => string.Join(".", Namespace);
        public List<Using> Usings { get; } = new List<Using>();
        public string Name { get; set; }
        public Grammar Grammar { get; set; }

        public Location Location { get; set; }
    }

    public enum UsingKind
    {
        None,
        Language
    }

    public class Using
    {
        public UsingKind Kind { get; set; }
        public string? Alias { get; set; }
        public Location AliasLocation { get; set; }
        public ImmutableArray<string> Reference { get; set; }
        public string QualifiedReference => string.Join(".", Reference);
        public Location ReferenceLocation { get; set; }
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
        None,
        Assign,
        QuestionAssign,
        NegatedAssign,
        PlusAssign
    }

    public class NamedElement : IElementWithLocation
    {
        public string Name { get; set; }
        public string CSharpName => Name.ToPascalCase();
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
        public string QualifiedName => string.Join(".", Name);
        public List<AnnotationProperty> Properties { get; } = new List<AnnotationProperty>();

        public Location Location { get; set; }

        public override string ToString()
        {
            return QualifiedName;
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
        private ImmutableArray<LexerRule> _fixedLexerRules;
        private ImmutableArray<LexerRule> _nonFixedLexerRules;
        private ImmutableArray<LexerRule> _lexerRules;
        private ImmutableArray<ParserRule> _parserRules;

        public GrammarOptions Options { get; set; }
        public List<Rule> Rules { get; } = new List<Rule>();
        public ImmutableArray<LexerRule> FixedLexerRules
        {
            get
            {
                if (_fixedLexerRules == null) _fixedLexerRules = Rules.OfType<LexerRule>().Where(lr => lr.IsFixed).ToImmutableArray();
                return _fixedLexerRules;
            }
        }
        public ImmutableArray<LexerRule> NonFixedLexerRules
        {
            get
            {
                if (_nonFixedLexerRules == null) _nonFixedLexerRules = Rules.OfType<LexerRule>().Where(lr => !lr.IsFixed).ToImmutableArray();
                return _nonFixedLexerRules;
            }
        }
        public ImmutableArray<LexerRule> LexerRules
        {
            get
            {
                if (_lexerRules == null)
                {
                    var lexerRules = ArrayBuilder<LexerRule>.GetInstance();
                    lexerRules.AddRange(FixedLexerRules);
                    lexerRules.AddRange(NonFixedLexerRules);
                    _lexerRules = lexerRules.ToImmutableAndFree();
                }
                return _lexerRules;
            }
        }
        public ImmutableArray<ParserRule> ParserRules
        {
            get
            {
                if (_parserRules == null) _parserRules = Rules.OfType<ParserRule>().ToImmutableArray();
                return _parserRules;
            }
        }
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
        public string QualifiedName => string.Join(".", Name);
        public Rule Rule { get; set; }

        public override string ToString()
        {
            return $"{Name}={QualifiedName}";
        }
    }

    public class ParserRuleEofElement : ParserRuleElement
    {
    }

    public class ParserRuleFixedStringElement : ParserRuleElement
    {
        private string _value;

        public string ValueText { get; set; }
        public string Value
        {
            get
            {
                if (_value is null) _value = StringUtils.DecodeString(ValueText);
                return _value;
            }
        }

        public LexerRule LexerRule { get; set; }

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
        public LexerRule Separator { get; set; }
        public ParserRuleReferenceElement Next { get; set; }
        public ParserRuleBlockElement Block { get; set; }
    }

    public class LexerRule : Rule
    {
        public bool IsFragment { get; set; }
        public bool IsHidden { get; set; }
        public bool IsFixed => Alternatives.Count == 1 && Alternatives[0].IsFixed;
        public bool IsKeyword => !IsHidden && IsFixed && StringUtils.IsIdentifier(FixedValue);
        public string? FixedValue => IsFixed ? Alternatives[0].FixedValue : null;
        public List<LexerRuleAlternative> Alternatives { get; } = new List<LexerRuleAlternative>();
    }

    public class LexerRuleAlternative : NamedElement
    {
        public bool IsFixed => Elements.All(e => e.IsFixed);
        public string? FixedValue => IsFixed ? string.Concat(Elements.Select(e => e.FixedValue)) : null;
        public List<LexerRuleElement> Elements { get; } = new List<LexerRuleElement>();
    }

    public abstract class LexerRuleElement
    {
        public abstract bool IsFixed { get; }
        public abstract string? FixedValue { get; }
        public bool IsNegated { get; set; }
        public Multiplicity Multiplicity { get; set; }
    }

    public class LexerRuleReferenceElement : LexerRuleElement, IElementWithLocation
    {
        public override bool IsFixed => Rule?.IsFixed ?? false;
        public override string? FixedValue => Rule?.FixedValue;
        public ImmutableArray<string> RuleName { get; set; }
        public string QualifiedName => string.Join(".", RuleName);
        public LexerRule? Rule { get; set; }
        public Location Location { get; set; }

        public override string ToString()
        {
            return QualifiedName;
        }
    }

    public class LexerRuleFixedStringElement : LexerRuleElement
    {
        private string _value;

        public override bool IsFixed => true;
        public override string? FixedValue => Value;
        public string ValueText { get; set; }
        public string Value
        {
            get
            {
                if (_value is null) _value = StringUtils.DecodeString(ValueText);
                return _value;
            }
        }

        public override string ToString()
        {
            return ValueText;
        }
    }

    public class LexerRuleWildcardElement : LexerRuleElement
    {
        public override bool IsFixed => false;
        public override string? FixedValue => null;
    }

    public class LexerRuleBlockElement : LexerRuleElement
    {
        public override bool IsFixed => Alternatives.Count == 1 && Alternatives[0].IsFixed;
        public override string? FixedValue => IsFixed ? Alternatives[0].FixedValue : null;
        public List<LexerRuleAlternative> Alternatives { get; } = new List<LexerRuleAlternative>();
    }

    public class LexerRuleRangeElement : LexerRuleElement
    {
        public override bool IsFixed => Start == End;
        public override string? FixedValue => IsFixed ? Start.ToString() : null;
        public string StartText { get; set; }
        public char Start => StringUtils.DecodeChar(StartText);
        public string EndText { get; set; }
        public char End => StringUtils.DecodeChar(EndText);

        public override string ToString()
        {
            return $"{StartText}..{EndText}";
        }
    }
}
