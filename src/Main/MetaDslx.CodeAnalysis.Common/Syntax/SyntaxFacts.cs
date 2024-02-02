using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace MetaDslx.CodeAnalysis.Syntax
{
    public abstract class SyntaxFacts
    {
        private static readonly Regex s_IdentifierPattern = new Regex(@"[a-zA-Z_][a-zA-Z_0-9]*", RegexOptions.Compiled);

        // Maximum size of tokens/trivia that we cache and use in quick scanner.
        // From what I see in our own codebase, tokens longer then 40-50 chars are 
        // not very common. 
        // So it seems reasonable to limit the sizes to some round number like 42.
        public virtual int MaxCachedTokenSize => 42;

        public SyntaxFacts()
        {
        }

        internal protected abstract int DefaultWhitespaceRawKind { get; }
        internal protected abstract int DefaultEndOfLineRawKind { get; }
        internal protected abstract int DefaultSeparatorRawKind { get; }
        internal protected abstract int DefaultIdentifierRawKind { get; }
        internal protected virtual int EndOfDirectiveTokenRawKind => (int)InternalSyntaxKind.None;
        internal protected virtual int CompilationUnitRawKind => (int)InternalSyntaxKind.None;

        internal protected abstract bool IsToken(int rawKind);
        internal protected abstract bool IsFixedToken(int rawKind);
        internal protected abstract bool IsTrivia(int rawKind);
        internal protected abstract bool IsReservedKeyword(int rawKind);
        internal protected abstract bool IsContextualKeyword(int rawKind);
        internal protected abstract bool IsPreprocessorKeyword(int rawKind);
        internal protected abstract bool IsPreprocessorContextualKeyword(int rawKind);
        internal protected abstract bool IsPreprocessorDirective(int rawKind);
        internal protected abstract bool IsIdentifier(int rawKind);
        internal protected abstract bool IsGeneralCommentTrivia(int rawKind);
        internal protected abstract bool IsDocumentationCommentTrivia(int rawKind);
        internal protected abstract string GetKindText(int rawKind);
        internal protected abstract string GetText(int rawKind);
        internal protected abstract object? GetValue(int rawKind);
        internal protected abstract int GetReservedKeywordRawKind(string text);
        internal protected abstract int GetContextualKeywordRawKind(string text);
        internal protected abstract int GetFixedTokenRawKind(string text);

        internal protected abstract IEnumerable<int> GetReservedKeywordRawKinds();
        internal protected abstract IEnumerable<int> GetContextualKeywordRawKinds();

        public virtual TokenKind? GetTokenKind(int rawSyntaxKind)
        {
            return null;
        }

        public virtual bool IsValidIdentifier(string identifier)
        {
            return s_IdentifierPattern.IsMatch(identifier);
        }

        internal protected bool IsCommentTrivia(int rawKind)
        {
            return IsGeneralCommentTrivia(rawKind) || IsDocumentationCommentTrivia(rawKind);
        }

        internal protected bool IsKeyword(int rawKind)
        {
            return IsReservedKeyword(rawKind) || IsContextualKeyword(rawKind);
        }

        internal protected IEnumerable<int> GetRawKeywordKinds()
        {
            foreach (var reserved in GetReservedKeywordRawKinds())
            {
                yield return reserved;
            }

            foreach (var contextual in GetContextualKeywordRawKinds())
            {
                yield return contextual;
            }
        }

        public virtual string? ExtractName(SyntaxNodeOrToken nodeOrToken)
        {
            if (nodeOrToken.IsToken) return ExtractVerbatimIdentifier(nodeOrToken.AsToken().ValueText);
            else return ExtractVerbatimIdentifier(nodeOrToken.AsNode()?.ToString());
        }

        public virtual string? ExtractMetadataName(SyntaxNodeOrToken nodeOrToken)
        {
            return this.ExtractName(nodeOrToken);
        }

        public virtual string? ExtractVerbatimIdentifier(string? identifier)
        {
            if (identifier is null) return null;
            if (identifier.StartsWith("@")) return identifier.Substring(1);
            else return identifier;
        }

        public object? ExtractValue(SyntaxNodeOrToken nodeOrToken)
        {
            if (TryExtractValue(default, nodeOrToken, out var value)) return value;
            else return null;
        }

        public object? ExtractValue(MetaType expectedType, SyntaxNodeOrToken nodeOrToken)
        {
            if (TryExtractValue(expectedType, nodeOrToken, out var value)) return value;
            else return null;
        }

        public bool TryExtractValue(MetaType expectedType, SyntaxNodeOrToken nodeOrToken, out object? value)
        {
            if (nodeOrToken.IsToken)
            {
                return TryExtractValue(expectedType, nodeOrToken.AsToken().Text, out value);
            }
            else
            {
                return TryExtractValue(expectedType, nodeOrToken.AsNode()?.ToString(), out value);
            }
        }

        public virtual bool TryExtractValue(MetaType expectedType, string? valueText, out object? value)
        {
            if (expectedType.IsDefaultOrNull || expectedType.SpecialType == SpecialType.MetaDslx_CodeAnalysis_MetaSymbol ||
                expectedType.SpecialType == SpecialType.System_String || expectedType.SpecialType == SpecialType.System_Object)
            {
                if (valueText == null)
                {
                    value = null;
                    return true;
                }
                if (valueText == "null")
                {
                    value = null;
                    return true;
                }
                if (valueText.Length >= 3 && valueText.StartsWith("@\'") && valueText.EndsWith("\'"))
                {
                    value = valueText.Substring(2, valueText.Length - 3).Replace("\'\'", "\'");
                    return true;
                }
                else if (valueText.Length >= 2 && valueText.StartsWith("\'") && valueText.EndsWith("\'"))
                {
                    value = StringUtilities.DecodeString(valueText);
                    return true;
                }
                else if (valueText.Length >= 3 && valueText.StartsWith("@\"") && valueText.EndsWith("\""))
                {
                    value = valueText.Substring(2, valueText.Length - 3).Replace("\"\"", "\"");
                    return true;
                }
                else if (valueText.Length >= 2 && valueText.StartsWith("\"") && valueText.EndsWith("\""))
                {
                    value = StringUtilities.DecodeString(valueText);
                    return true;
                }
            }
            if (expectedType.IsDefaultOrNull || expectedType.SpecialType == SpecialType.MetaDslx_CodeAnalysis_MetaSymbol ||
                expectedType.SpecialType == SpecialType.System_Object)
            {
                bool boolValue;
                if (bool.TryParse(valueText, out boolValue))
                {
                    value = boolValue;
                    return true;
                }
                int intValue;
                if (int.TryParse(valueText, out intValue))
                {
                    value = intValue;
                    return true;
                }
                long longValue;
                if (long.TryParse(valueText, out longValue))
                {
                    value = longValue;
                    return true;
                }
                float floatValue;
                if (float.TryParse(valueText, out floatValue))
                {
                    value = floatValue;
                    return true;
                }
                double doubleValue;
                if (double.TryParse(valueText, out doubleValue))
                {
                    value = doubleValue;
                    return true;
                }
                value = valueText;
                return true;
            }
            var type = expectedType.AsType();
            if (type is not null)
            {
                try
                {
                    value = TypeDescriptor.GetConverter(expectedType).ConvertFromInvariantString(valueText);
                    return true;
                }
                catch (NotSupportedException)
                {
                    value = null;
                    return false;
                }
            }
            value = null;
            return false;
        }

        public virtual bool IsTriviaWithEndOfLine(GreenNode trivia)
        {
            if (trivia is InternalSyntaxTrivia internalSyntaxTrivia)
            {
                string text = internalSyntaxTrivia.Text;
                if (string.IsNullOrEmpty(text)) return false;
                if (text.EndsWith("\r") || text.EndsWith("\n")) return true;
            }
            return false;
        }

        public virtual int GetDeclarationDepth(SyntaxToken token)
        {
            return GetDeclarationDepth(token.Parent);
        }

        public virtual int GetDeclarationDepth(SyntaxTrivia trivia)
        {
            if (IsPreprocessorDirective(trivia.RawKind))
            {
                return 0;
            }

            return GetDeclarationDepth(trivia.Token);
        }

        public virtual int GetDeclarationDepth(SyntaxNode? node)
        {
            if (node != null)
            {
                if (node.IsStructuredTrivia)
                {
                    var tr = ((IStructuredTriviaSyntax)node).ParentTrivia;
                    return GetDeclarationDepth(tr);
                }
                else if (node.Parent != null)
                {
                    if (node.Parent.RawKind == CompilationUnitRawKind)
                    {
                        return 0;
                    }

                    int parentDepth = GetDeclarationDepth(node.Parent);
                    return parentDepth;
                }
            }

            return 0;
        }

        public virtual bool IsGlobalAlias(SyntaxNodeOrToken alias)
        {
            return alias.IsToken && alias.AsToken().Text == "global";
        }
    }
}
