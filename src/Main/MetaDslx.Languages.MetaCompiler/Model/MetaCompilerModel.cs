using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
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
        public Microsoft.CodeAnalysis.INamespaceOrTypeSymbol? CSharpSymbol { get; set; }
    }

    public enum AnnotationKind
    {
        None,
        Def,
        Use
    }

    public enum ListKind
    {
        SeparatorItem, // (, item)*
        ItemSeparator, // (item, )*
        WithFirstItem, // item (, item)*
        WithFirstItemSeparator, // item (, item)* ,
        WithLastItem, // (item, )* item
        WithLastItemSeparator, // (item, )* item ,
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

    public static class MultiplicityExtensions
    {
        public static bool IsList(this Multiplicity multiplicity)
        {
            return multiplicity == Multiplicity.ZeroOrMore || multiplicity == Multiplicity.OneOrMore || multiplicity == Multiplicity.NonGreedyZeroOrMore || multiplicity == Multiplicity.NonGreedyOneOrMore;
        }

        public static bool IsOptional(this Multiplicity multiplicity)
        {
            return multiplicity == Multiplicity.ZeroOrOne || multiplicity == Multiplicity.NonGreedyZeroOrOne;
        }
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
        public Microsoft.CodeAnalysis.INamedTypeSymbol? CSharpClass { get; set; }

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
        private readonly Language _language;
        private ImmutableArray<LexerRule> _fixedLexerRules;
        private ImmutableArray<LexerRule> _nonFixedLexerRules;
        private ImmutableArray<LexerRule> _lexerRules;
        private ImmutableArray<ParserRule> _parserRules;

        public Grammar(Language language)
        {
            _language = language;
        }

        public Language Language => _language;

        public GrammarOptions Options { get; set; }
        public List<Rule> Rules { get; } = new List<Rule>();

        public LexerRule? DefaultWhitespace { get; set; }
        public LexerRule? DefaultEndOfLine { get; set; }
        public LexerRule? DefaultSeparator { get; set; }
        public LexerRule? DefaultIdentifier { get; set; }
        public ParserRule? MainRule { get; set; }

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
        private readonly Grammar _grammar;

        public Rule(Grammar grammar)
        {
            _grammar = grammar;
        }

        public Grammar Grammar => _grammar;
        public Language Language => _grammar.Language;

        public abstract string GreenName { get; }
        public abstract string RedName { get; }
    }

    public interface IParserRuleAlternativeParent
    {
        Language Language { get; }
        Grammar Grammar { get; }
        string Name { get; }
        string GreenName { get; }
        string RedName { get; }
        List<ParserRuleAlternative> Alternatives { get; }
    }

    public class ParserRule : Rule, IParserRuleAlternativeParent
    {
        public ParserRule(Grammar grammar)
            : base(grammar)
        {
            
        }

        public override string GreenName => Name.ToPascalCase() + "Green";
        public override string RedName => Name.ToPascalCase() + "Syntax";

        public List<ParserRuleAlternative> Alternatives { get; } = new List<ParserRuleAlternative>();
        public List<ParserRuleAlternative> ReferencedBy { get; } = new List<ParserRuleAlternative>();
    }

    public class ParserRuleAlternative : NamedElement
    {
        private IParserRuleAlternativeParent _parent;

        public ParserRuleAlternative(IParserRuleAlternativeParent parent)
        {
            _parent = parent;
        }

        public Language Language => _parent.Language;
        public Grammar Grammar => _parent.Grammar;
        public IParserRuleAlternativeParent Parent
        {
            get => _parent;
            set => _parent = value;
        }

        public string GreenName => Name.ToPascalCase() + "Green";
        public string RedName => Name.ToPascalCase() + "Syntax";

        public List<ParserRuleElement> Elements { get; } = new List<ParserRuleElement>();
        public string GreenConstructorParameters => string.Concat(Elements.Select(e => $", {e.GreenFieldType} {e.ParameterName}"));
        public string GreenConstructorArguments => string.Concat(Elements.Select(e => $", {e.FieldName}"));
        public string GreenUpdateParameters => string.Join(", ", Elements.Select(e => $"{e.GreenPropertyType} {e.ParameterName}"));
        public string GreenUpdateArguments => string.Join(", ", Elements.Select(e => e.ParameterName));
        public string RedUpdateParameters => string.Join(", ", Elements.Select(e => $"{e.RedPropertyType} {e.ParameterName}"));
        public string RedUpdateArguments => string.Join(", ", Elements.Select(e => e.ParameterName));
        public string RedOptionalUpdateParameters => string.Join(", ", Elements.Where(e => !e.IsOptional && (!e.IsToken || e.IsList)).Select(e => $"{e.RedPropertyType} {e.ParameterName}"));
        public string RedToGreenArgumentList => string.Join(", ", Elements.Select(e => e.RedToGreenArgument));
        public string RedToGreenOptionalArgumentList => string.Join(", ", Elements.Select(e => e.RedToGreenOptionalArgument));
    }

    public abstract class ParserRuleElement : NamedElement
    {
        private ParserRuleAlternative _parserRuleAlternative;

        public ParserRuleElement(ParserRuleAlternative parserRuleAlternative)
        {
            _parserRuleAlternative = parserRuleAlternative;
        }

        public Language Language => _parserRuleAlternative.Language;
        public Grammar Grammar => _parserRuleAlternative.Grammar;
        public ParserRuleAlternative ParserRuleAlternative
        {
            get => _parserRuleAlternative;
            set => _parserRuleAlternative = value;
        }

        public virtual string DefaultName => Name.ToCamelCase();
        public virtual string FieldName => "_"+Name.ToCamelCase();
        public virtual string ParameterName => Name.ToCamelCase().EscapeCSharpKeyword();
        public virtual string PropertyName => Name.ToPascalCase();
        public abstract string GreenItemType { get; }
        public virtual string GreenFieldType => IsList ? "GreenNode" : GreenItemType;
        public virtual string GreenPropertyType => IsList ? $"MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<{GreenItemType}>" : GreenItemType;
        public abstract string RedItemType { get; }
        public virtual string RedFieldType => IsList ? "MetaDslx.CodeAnalysis.SyntaxNode" : RedItemType;
        public virtual string RedPropertyType => IsList ? $"MetaDslx.CodeAnalysis.SyntaxList<{RedItemType}>" : RedItemType;
        public virtual string RedToGreenArgument => IsList ? $"{ParameterName}.Node.ToGreenList<{GreenItemType}>()" : IsOptional && !IsToken ? $"({GreenPropertyType}?){ParameterName}?.Green" : $"({GreenPropertyType}){ParameterName}{(IsToken ? ".Node" : ".Green")}";
        public virtual string RedToGreenOptionalArgument => IsOptional ? "default" : ParameterName;

        public string? AntlrName { get; set; }
        public Location? NameLocation { get; set; }
        public List<Annotation> NameAnnotations { get; } = new List<Annotation>();
        public bool IsNegated { get; set; }
        public AssignmentOperator AssignmentOperator { get; set; }
        public Multiplicity Multiplicity { get; set; }
        public virtual bool IsToken => false;
        public virtual bool IsFixedToken => false;
        public virtual bool IsFixedTokenAlt => false;
        public virtual bool IsSeparated => false;
        public virtual bool IsReversed => false;
        public virtual bool IsList => Multiplicity.IsList();
        public virtual bool IsOptional => Multiplicity.IsOptional();
    }

    public class ParserRuleReferenceElement : ParserRuleElement
    {
        public ParserRuleReferenceElement(ParserRuleAlternative parserRuleAlternative)
            : base(parserRuleAlternative)
        {
        }

        public override string DefaultName => Rule?.Name.ToCamelCase();
        public ImmutableArray<string> RuleName { get; set; }
        public string QualifiedName => string.Join(".", Name);
        public Rule? Rule { get; set; }
        public override string GreenItemType => Rule?.GreenName;
        public override string RedItemType => Rule?.RedName;
        public override bool IsToken => Rule is LexerRule;
        public override bool IsFixedToken => Rule is LexerRule lr && lr.IsFixed;
        public override string RedToGreenOptionalArgument => IsFixedToken && !IsList && !IsOptional ? $"this.Token({Language.Name}SyntaxKind.{Rule.CSharpName})" : base.RedToGreenOptionalArgument;

        public override string ToString()
        {
            return $"{Name}={QualifiedName}";
        }
    }

    public class ParserRuleEofElement : ParserRuleElement
    {
        public ParserRuleEofElement(ParserRuleAlternative parserRuleAlternative)
            : base(parserRuleAlternative)
        {
        }

        public override string DefaultName => "eof";
        public override bool IsList => false;
        public override bool IsToken => true;
        public override bool IsFixedToken => true;
        public override string PropertyName => "EndOfFileToken";
        public override string GreenItemType => "InternalSyntaxToken";
        public override string RedItemType => "SyntaxToken";
        public override string RedToGreenOptionalArgument => $"this.Token({Language.Name}SyntaxKind.Eof)";
    }

    public class ParserRuleFixedStringElement : ParserRuleElement
    {
        private string _value;

        public ParserRuleFixedStringElement(ParserRuleAlternative parserRuleAlternative) 
            : base(parserRuleAlternative)
        {
        }

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
        public override string GreenItemType => "InternalSyntaxToken";
        public override string RedItemType => "SyntaxToken";
        public override string DefaultName => LexerRule.Name.ToCamelCase();
        public override bool IsToken => true;
        public override bool IsFixedToken => true;
        public override string RedToGreenOptionalArgument => !IsList && !IsOptional ? $"this.Token({Language.Name}SyntaxKind.{LexerRule.CSharpName})" : base.RedToGreenOptionalArgument;

        public override string ToString()
        {
            return $"{Name}={ValueText}";
        }
    }

    public class ParserRuleFixedStringAlternativesElement : ParserRuleElement
    {
        public ParserRuleFixedStringAlternativesElement(ParserRuleAlternative parserRuleAlternative)
            : base(parserRuleAlternative)
        {
        }

        public List<ParserRuleFixedStringElement> Alternatives { get; } = new List<ParserRuleFixedStringElement>();
        public override string GreenItemType => "InternalSyntaxToken";
        public override string RedItemType => "SyntaxToken";
        public override bool IsToken => true;
        public override bool IsFixedToken => true;
        public override bool IsFixedTokenAlt => true;
        public override bool IsOptional => base.IsOptional || Alternatives.Any(alt => alt.IsOptional);

        public override string ToString()
        {
            return $"{Name}=[{string.Join(", ", Alternatives.Select(alt => alt.ValueText))}]";
        }
    }

    public class ParserRuleWildcardElement : ParserRuleElement
    {
        public ParserRuleWildcardElement(ParserRuleAlternative parserRuleAlternative) 
            : base(parserRuleAlternative)
        {
        }

        public override string DefaultName => "any";
        public override string GreenItemType => "GreenNode";
        public override string RedItemType => "SyntaxNode";
    }

    public class ParserRuleBlockElement : ParserRuleElement, IParserRuleAlternativeParent
    {
        public ParserRuleBlockElement(ParserRuleAlternative parserRuleAlternative) 
            : base(parserRuleAlternative)
        {
        }

        public override string DefaultName => "block";
        public string GreenName => Name.ToPascalCase() + "Green";
        public string RedName => Name.ToPascalCase() + "Syntax";

        public override string GreenItemType => GreenName;
        public override string RedItemType => RedName;

        public List<ParserRuleAlternative> Alternatives { get; } = new List<ParserRuleAlternative>();
    }

    public class ParserRuleListElement : ParserRuleElement
    {
        public ParserRuleListElement(ParserRuleAlternative parserRuleAlternative)
            : base(parserRuleAlternative)
        {
        }

        public override string DefaultName => RepeatedItem.DefaultName+"List";
        public override bool IsList => true;
        public override bool IsSeparated => true;
        public override bool IsReversed => ListKind == ListKind.SeparatorItem;
        public override string GreenItemType => RepeatedItem.GreenItemType;
        public override string GreenPropertyType => $"MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<{GreenItemType}>";
        public override string RedItemType => RepeatedItem.RedItemType;
        public override string RedPropertyType => $"MetaDslx.CodeAnalysis.SeparatedSyntaxList<{RedItemType}>";
        public override string RedToGreenArgument => $"{ParameterName}.Node.ToGreenSeparatedList<{GreenItemType}>(reversed: {(IsReversed ? "true" : "false")})";
        public string SeparatorAntlrName => $"{AntlrName}Separator";
        public ListKind ListKind { get; set; }
        public ParserRuleReferenceElement FirstItem { get; set; }
        public ParserRuleReferenceElement RepeatedRule { get; set; }
        public ParserRuleElement RepeatedSeparator { get; set; }
        public ParserRuleReferenceElement RepeatedItem { get; set; }
        public ParserRuleElement LastSeparator { get; set; }
        public ParserRuleReferenceElement LastItem { get; set; }

        public IEnumerable<ParserRuleElement> AllElements
        {
            get
            {
                if (FirstItem is not null) yield return FirstItem;
                if (RepeatedRule is not null) yield return RepeatedRule;
                if (RepeatedSeparator is not null) yield return RepeatedSeparator;
                if (RepeatedItem is not null) yield return RepeatedItem;
                if (LastSeparator is not null) yield return LastSeparator;
                if (LastItem is not null) yield return LastItem;
            }
        }
    }

    public class LexerRule : Rule
    {
        public LexerRule(Grammar grammar)
            : base(grammar)
        {

        }

        public override string GreenName => "InternalSyntaxToken";
        public override string RedName => "SyntaxToken";
        public bool IsFragment { get; set; }
        public bool IsHidden { get; set; }
        public bool IsFixed => Alternatives.Count == 1 && Alternatives[0].IsFixed;
        public bool IsKeyword => !IsHidden && IsFixed && StringUtils.IsIdentifier(FixedValue);
        public string? FixedValue => IsFixed ? Alternatives[0].FixedValue : null;
        public List<LexerRuleAlternative> Alternatives { get; } = new List<LexerRuleAlternative>();
    }

    public class LexerRuleAlternative 
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
