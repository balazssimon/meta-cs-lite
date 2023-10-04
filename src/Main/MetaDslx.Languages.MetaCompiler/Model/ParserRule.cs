using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    using CSharpCompilation = Microsoft.CodeAnalysis.CSharp.CSharpCompilation;
    using INamespaceSymbol = Microsoft.CodeAnalysis.INamespaceSymbol;
    using INamespaceOrTypeSymbol = Microsoft.CodeAnalysis.INamespaceOrTypeSymbol;
    using INamedTypeSymbol = Microsoft.CodeAnalysis.INamedTypeSymbol;
    using ITypeSymbol = Microsoft.CodeAnalysis.ITypeSymbol;
    using IArrayTypeSymbol = Microsoft.CodeAnalysis.IArrayTypeSymbol;
    using IMethodSymbol = Microsoft.CodeAnalysis.IMethodSymbol;
    using IParameterSymbol = Microsoft.CodeAnalysis.IParameterSymbol;
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;
    using SymbolDisplayFormat = Microsoft.CodeAnalysis.SymbolDisplayFormat;

    public interface IParserRuleAlternativeParent
    {
        Language Language { get; }
        Grammar Grammar { get; }
        string Name { get; }
        bool IsPart { get; }
        string GreenName { get; }
        string RedName { get; }
        List<ParserRuleAlternative> Alternatives { get; }
        CSharpTypeInfo CSharpReturnType { get; }
    }

    public class ParserRule : Rule, IParserRuleAlternativeParent
    {
        public ParserRule(Grammar grammar)
            : base(grammar)
        {

        }

        public bool IsPart { get; set; }
        public override string GreenName => Name.ToPascalCase() + "Green";
        public override string RedName => Name.ToPascalCase() + "Syntax";
        public override string AntlrName => "pr_"+Name.ToPascalCase();

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

        public CSharpTypeInfo CSharpReturnType { get; set; }
        public List<ParserRuleElement> Elements { get; } = new List<ParserRuleElement>();
        public Expression? ReturnValue { get; set; }

        public string GreenName => Name.ToPascalCase() + "Green";
        public string RedName => Name.ToPascalCase() + "Syntax";
        public string AntlrName => "pr_" + Name.ToPascalCase();

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
        public virtual string FieldName => "_" + Name.ToCamelCase();
        public virtual string ParameterName => StringUtilities.EscapeCSharpKeyword(Name.ToCamelCase());
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
        public string? ModelPropertyName { get; set; }
        public CSharpPropertyInfo CSharpModelProperty { get; set; }
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
        public string RuleName { get; set; }
        public Rule? Rule { get; set; }
        public ImmutableArray<CSharpTypeInfo> ReferencedCSharpTypes { get; set; }

        public override string GreenItemType => Rule?.GreenName;
        public override string RedItemType => Rule?.RedName;
        public override bool IsToken => Rule is LexerRule;
        public override bool IsFixedToken => Rule is LexerRule lr && lr.IsFixed;
        public override string RedToGreenOptionalArgument => IsFixedToken && !IsList && !IsOptional ? $"this.Token({Language.Name}SyntaxKind.{Rule.CSharpName})" : base.RedToGreenOptionalArgument;

        public override string ToString()
        {
            return $"{Name}={RuleName}";
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
                if (_value is null) _value = StringUtilities.DecodeString(ValueText);
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
        public bool IsPart => false;
        public CSharpTypeInfo CSharpReturnType { get; set; }

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

        public override string DefaultName => RepeatedItem.DefaultName + "List";
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
        public ParserRuleReferenceElement? FirstItem { get; set; }
        public ParserRuleReferenceElement RepeatedRule { get; set; }
        public ParserRuleElement RepeatedSeparator { get; set; }
        public ParserRuleReferenceElement RepeatedItem { get; set; }
        public ParserRuleElement? LastSeparator { get; set; }
        public ParserRuleReferenceElement? LastItem { get; set; }

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

}
