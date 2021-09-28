using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax
{
    public abstract class SyntaxFacts
    {
        // Maximum size of tokens/trivia that we cache and use in quick scanner.
        // From what I see in our own codebase, tokens longer then 40-50 chars are 
        // not very common. 
        // So it seems reasonable to limit the sizes to some round number like 42.
        public virtual int MaxCachedTokenSize => 42;

        public SyntaxFacts()
        {
        }

        public abstract int DefaultWhitespaceKind { get; }
        public abstract int DefaultEndOfLineKind { get; }
        public abstract int DefaultSeparatorKind { get; }
        public abstract int DefaultIdentifierKind { get; }
        public virtual int EndOfDirectiveTokenKind => (int)InternalSyntaxKind.None;
        public virtual int CompilationUnitKind => (int)InternalSyntaxKind.None;

        public abstract bool IsToken(int rawKind);
        public abstract bool IsFixedToken(int rawKind);
        public abstract bool IsTrivia(int rawKind);
        public abstract bool IsReservedKeyword(int rawKind);
        public abstract bool IsContextualKeyword(int rawKind);
        public abstract bool IsPreprocessorKeyword(int rawKind);
        public abstract bool IsPreprocessorContextualKeyword(int rawKind);
        public abstract bool IsPreprocessorDirective(int rawKind);
        public abstract bool IsIdentifier(int rawKind);
        public abstract bool IsGeneralCommentTrivia(int rawKind);
        public abstract bool IsDocumentationCommentTrivia(int rawKind);
        public abstract string GetKindText(int rawKind);
        public abstract string GetText(int rawKind);
        public abstract object GetValue(int rawKind);
        public abstract int GetReservedKeywordKind(string text);
        public abstract int GetContextualKeywordKind(string text);
        public abstract int GetFixedTokenKind(string text);

        protected abstract IEnumerable<int> GetRawReservedKeywordKinds();
        protected abstract IEnumerable<int> GetRawContextualKeywordKinds();

        public bool IsCommentTrivia(int rawKind)
        {
            return IsGeneralCommentTrivia(rawKind) || IsDocumentationCommentTrivia(rawKind);
        }

        public bool IsKeyword(int rawKind)
        {
            return IsReservedKeyword(rawKind) || IsContextualKeyword(rawKind);
        }

        protected IEnumerable<int> GetRawKeywordKinds()
        {
            foreach (var reserved in GetRawReservedKeywordKinds())
            {
                yield return reserved;
            }

            foreach (var contextual in GetRawContextualKeywordKinds())
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
                return StringUtilities.UnescapeCharLiteralValue(value.Substring(1, value.Length - 2));
            }
            else if (value.Length >= 3 && value.StartsWith("@\"") && value.EndsWith("\""))
            {
                return value.Substring(2, value.Length - 3).Replace("\"\"", "\"");
            }
            else if (value.Length >= 2 && value.StartsWith("\"") && value.EndsWith("\""))
            {
                return StringUtilities.UnescapeStringLiteralValue(value.Substring(1, value.Length - 2));
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
                    if (node.Parent.RawKind == CompilationUnitKind)
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
