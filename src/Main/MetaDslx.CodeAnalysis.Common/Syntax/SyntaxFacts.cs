using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
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
            if (nodeOrToken.IsToken) return nodeOrToken.AsToken().ValueText;
            else return nodeOrToken.AsNode()?.ToString();
        }

        public virtual string? ExtractMetadataName(SyntaxNodeOrToken nodeOrToken)
        {
            return this.ExtractName(nodeOrToken);
        }

        public virtual object? ExtractValue(SyntaxNodeOrToken nodeOrToken)
        {
            if (nodeOrToken.IsToken) return nodeOrToken.AsToken().Value;
            else return ExtractValue(nodeOrToken.AsNode()?.ToString());
        }

        public virtual object? ExtractValue(string? value)
        {
            if (value == null) return null;
            if (value == "null") return null;
            if (value.Length >= 3 && value.StartsWith("@\'") && value.EndsWith("\'"))
            {
                return value.Substring(2, value.Length - 3).Replace("\'\'", "\'");
            }
            else if (value.Length >= 2 && value.StartsWith("\'") && value.EndsWith("\'"))
            {
                return StringUtilities.DecodeChar(value);
            }
            else if (value.Length >= 3 && value.StartsWith("@\"") && value.EndsWith("\""))
            {
                return value.Substring(2, value.Length - 3).Replace("\"\"", "\"");
            }
            else if (value.Length >= 2 && value.StartsWith("\"") && value.EndsWith("\""))
            {
                return StringUtilities.DecodeString(value);
            }
            bool boolValue;
            if (bool.TryParse(value, out boolValue))
            {
                return boolValue;
            }
            int intValue;
            if (int.TryParse(value, out intValue))
            {
                return intValue;
            }
            long longValue;
            if (long.TryParse(value, out longValue))
            {
                return longValue;
            }
            float floatValue;
            if (float.TryParse(value, out floatValue))
            {
                return floatValue;
            }
            double doubleValue;
            if (double.TryParse(value, out doubleValue))
            {
                return doubleValue;
            }
            return value;
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
    }
}
