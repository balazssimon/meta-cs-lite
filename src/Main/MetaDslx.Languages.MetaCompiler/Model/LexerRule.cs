using MetaDslx.CodeAnalysis;
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

    public class LexerRule : Rule
    {
        public LexerRule(Grammar grammar)
            : base(grammar)
        {

        }

        public CSharpTypeInfo CSharpTokenKind { get; set; }
        public bool IsFragment { get; set; }
        public List<LexerRuleAlternative> Alternatives { get; } = new List<LexerRuleAlternative>();
        public Expression? ReturnValue => Alternatives.Count == 1 ? Alternatives[0].ReturnValue : null;

        public override string GreenName => "InternalSyntaxToken";
        public override string RedName => "SyntaxToken";

        public bool IsHidden
        {
            get
            {
                var type = CSharpTokenKind.Type;
                while (type != null)
                {
                    if (type.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) == MetaDslxTypes.MetaDslxHiddenTokenKind) return true;
                    type = type.BaseType;
                }
                return false;
            }
        }
        public bool IsFixed => Alternatives.Count == 1 && Alternatives[0].IsFixed;
        public bool IsKeyword => !IsHidden && IsFixed && StringUtilities.IsIdentifier(FixedValue);
        public string? FixedValue => IsFixed ? Alternatives[0].FixedValue : null;
    }

    public class LexerRuleAlternative
    {
        public bool IsFixed => Elements.All(e => e.IsFixed);
        public string? FixedValue => IsFixed ? string.Concat(Elements.Select(e => e.FixedValue)) : null;
        public List<LexerRuleElement> Elements { get; } = new List<LexerRuleElement>();
        public Expression? ReturnValue { get; set; }
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
                if (_value is null) _value = StringUtilities.DecodeString(ValueText);
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
        public char Start => StringUtilities.DecodeChar(StartText);
        public string EndText { get; set; }
        public char End => StringUtilities.DecodeChar(EndText);

        public override string ToString()
        {
            return $"{StartText}..{EndText}";
        }
    }

}
