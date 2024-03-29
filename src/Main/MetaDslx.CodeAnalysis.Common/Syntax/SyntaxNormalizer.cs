﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using System.Linq;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis.Syntax
{
    public class SyntaxNormalizer : SyntaxRewriter
    {
        private readonly TextSpan _consideredSpan;
        private readonly int _initialDepth;
        private readonly string _indentWhitespace;
        private readonly bool _useElasticTrivia;
        private readonly SyntaxTrivia _eolTrivia;

        private bool _isInStructuredTrivia;

        private SyntaxToken _previousToken;

        private bool _afterLineBreak;
        private bool _afterIndentation;

        // CONSIDER: if we become concerned about space, we shouldn't actually need any 
        // of the values between indentations[0] and indentations[initialDepth] (exclusive).
        private ArrayBuilder<SyntaxTrivia>? _indentations;

        private int DefaultEndOfLineKind;
        private int DefaultWhitespaceKind;
        private int DefaultIdentifierKind;
        private int EndOfDirectiveTokenKind;

        protected SyntaxNormalizer(Language language, TextSpan consideredSpan, int initialDepth, string indentWhitespace, string eolWhitespace, bool useElasticTrivia)
            : base(language, visitIntoStructuredTrivia: true)
        {
            _consideredSpan = consideredSpan;
            _initialDepth = initialDepth;
            _indentWhitespace = indentWhitespace;
            _useElasticTrivia = useElasticTrivia;
            _eolTrivia = useElasticTrivia ? SyntaxFactory.ElasticEndOfLine(eolWhitespace) : SyntaxFactory.EndOfLine(eolWhitespace);
            _afterLineBreak = true;

            DefaultEndOfLineKind = language.SyntaxFacts.DefaultEndOfLineRawKind;
            DefaultWhitespaceKind = language.SyntaxFacts.DefaultWhitespaceRawKind;
            DefaultIdentifierKind = language.SyntaxFacts.DefaultIdentifierRawKind;
            EndOfDirectiveTokenKind = language.SyntaxFacts.EndOfDirectiveTokenRawKind;
        }

        public static TNode Normalize<TNode>(TNode node, string indentWhitespace, string eolWhitespace, bool useElasticTrivia = false)
            where TNode : SyntaxNode
        {
            Language language = node.Language;
            var normalizer = new SyntaxNormalizer(language, node.FullSpan, language.SyntaxFacts.GetDeclarationDepth(node), indentWhitespace, eolWhitespace, useElasticTrivia);
            var result = (TNode)normalizer.Visit(node)!;
            normalizer.Free();
            return result;
        }

        public static SyntaxToken Normalize(SyntaxToken token, string indentWhitespace, string eolWhitespace, bool useElasticTrivia = false)
        {
            Language language = token.Language;
            var normalizer = new SyntaxNormalizer(language, token.FullSpan, language.SyntaxFacts.GetDeclarationDepth(token), indentWhitespace, eolWhitespace, useElasticTrivia);
            var result = normalizer.VisitToken(token);
            normalizer.Free();
            return result;
        }

        public static SyntaxTriviaList Normalize(SyntaxTriviaList trivia, string indentWhitespace, string eolWhitespace, bool useElasticTrivia = false)
        {
            if (trivia.Node is null) return default;
            Language language = trivia.Node.Language;
            var normalizer = new SyntaxNormalizer(language, trivia.FullSpan, language.SyntaxFacts.GetDeclarationDepth(trivia.Token), indentWhitespace, eolWhitespace, useElasticTrivia);
            var result = normalizer.RewriteTrivia(
                trivia,
                language.SyntaxFacts.GetDeclarationDepth((SyntaxToken)trivia.ElementAt(0).Token),
                isTrailing: false,
                indentAfterLineBreak: false,
                mustHaveSeparator: false,
                lineBreaksAfter: 0);
            normalizer.Free();
            return result;
        }

        protected void Free()
        {
            if (_indentations != null)
            {
                _indentations.Free();
            }
        }

        public override SyntaxToken VisitToken(SyntaxToken token)
        {
            if (token.RawKind == (int)InternalSyntaxKind.None || (token.IsMissing && token.FullWidth == 0))
            {
                return token;
            }

            try
            {
                var tk = token;

                var depth = Language.SyntaxFacts.GetDeclarationDepth(token);

                tk = tk.WithLeadingTrivia(RewriteTrivia(
                    token.LeadingTrivia,
                    depth,
                    isTrailing: false,
                    indentAfterLineBreak: NeedsIndentAfterLineBreak(token),
                    mustHaveSeparator: false,
                    lineBreaksAfter: 0));

                var nextToken = this.GetNextRelevantToken(token);

                _afterLineBreak = IsLineBreak(token);
                _afterIndentation = false;

                var lineBreaksAfter = LineBreaksAfter(token, nextToken);
                var needsSeparatorAfter = NeedsSeparator(token, nextToken);
                tk = tk.WithTrailingTrivia(RewriteTrivia(
                    token.TrailingTrivia,
                    depth,
                    isTrailing: true,
                    indentAfterLineBreak: false,
                    mustHaveSeparator: needsSeparatorAfter,
                    lineBreaksAfter: lineBreaksAfter));

                return tk;
            }
            finally
            {
                // to help debugging
                _previousToken = token;
            }
        }

        protected virtual SyntaxToken GetNextRelevantToken(SyntaxToken token)
        {
            // get next token, skipping zero width tokens except for end-of-directive tokens
            var nextToken = token.GetNextToken(
                t => SyntaxToken.NonZeroWidth(t) || t.RawKind == EndOfDirectiveTokenKind,
                t => t.RawKind == (int)InternalSyntaxKind.SkippedTokensTrivia);

            if (_consideredSpan.Contains(nextToken.FullSpan))
            {
                return nextToken;
            }
            else
            {
                return default(SyntaxToken);
            }
        }

        protected SyntaxTrivia GetIndentation(int count)
        {
            count = Math.Max(count - _initialDepth, 0);

            int capacity = count + 1;
            if (_indentations == null)
            {
                _indentations = ArrayBuilder<SyntaxTrivia>.GetInstance(capacity);
            }
            else
            {
                _indentations.EnsureCapacity(capacity);
            }

            // grow indentation collection if necessary
            for (int i = _indentations.Count; i <= count; i++)
            {
                string text = i == 0
                    ? ""
                    : _indentations[i - 1].ToString() + _indentWhitespace;
                _indentations.Add(_useElasticTrivia ? SyntaxFactory.ElasticWhitespace(text) : SyntaxFactory.Whitespace(text));
            }

            return _indentations[count];
        }

        protected virtual bool NeedsIndentAfterLineBreak(SyntaxToken token)
        {
            return token.RawKind != (int)InternalSyntaxKind.Eof;
        }

        protected virtual int LineBreaksAfter(SyntaxToken currentToken, SyntaxToken nextToken)
        {
            if (currentToken.RawKind == EndOfDirectiveTokenKind)
            {
                return 1;
            }

            if (nextToken.RawKind == (int)InternalSyntaxKind.None)
            {
                return 0;
            }

            // none of the following tests currently have meaning for structured trivia
            if (_isInStructuredTrivia)
            {
                return 0;
            }

            return 0;
        }

        protected virtual bool NeedsSeparator(SyntaxToken token, SyntaxToken next)
        {
            if (token.Parent == null || next.Parent == null)
            {
                return false;
            }

            if (next.RawKind == EndOfDirectiveTokenKind)
            {
                // In a directive, there's often no token between the directive keyword and 
                // the end-of-directive, so we may need a separator.
                return Language.SyntaxFacts.IsKeyword(token.RawKind) && next.LeadingWidth > 0;
            }

            if (IsWord(token.RawKind) && IsWord(next.RawKind))
            {
                return true;
            }
            else if (token.Width > 1 && next.Width > 1)
            {
                var tokenLastChar = token.Text.Last();
                var nextFirstChar = next.Text.First();
                if (tokenLastChar == nextFirstChar && TokenCharacterCanBeDoubled(tokenLastChar))
                {
                    return true;
                }
            }

            return false;
        }

        protected virtual SyntaxTriviaList RewriteTrivia(
            SyntaxTriviaList triviaList,
            int depth,
            bool isTrailing,
            bool indentAfterLineBreak,
            bool mustHaveSeparator,
            int lineBreaksAfter)
        {
            ArrayBuilder<SyntaxTrivia> currentTriviaList = ArrayBuilder<SyntaxTrivia>.GetInstance(triviaList.Count);
            try
            {
                foreach (var trivia in triviaList)
                {
                    if (trivia.RawKind == DefaultWhitespaceKind ||
                        trivia.RawKind == DefaultEndOfLineKind ||
                        trivia.FullWidth == 0)
                    {
                        continue;
                    }

                    var needsSeparator =
                        (currentTriviaList.Count > 0 && NeedsSeparatorBetween(currentTriviaList.Last())) ||
                            (currentTriviaList.Count == 0 && isTrailing);

                    var needsLineBreak = NeedsLineBreakBefore(trivia, isTrailing)
                        || (currentTriviaList.Count > 0 && NeedsLineBreakBetween(currentTriviaList.Last(), trivia, isTrailing));

                    if (needsLineBreak && !_afterLineBreak)
                    {
                        currentTriviaList.Add(GetEndOfLine());
                        _afterLineBreak = true;
                        _afterIndentation = false;
                    }

                    if (_afterLineBreak)
                    {
                        if (!_afterIndentation && NeedsIndentAfterLineBreak(trivia))
                        {
                            currentTriviaList.Add(this.GetIndentation(Language.SyntaxFacts.GetDeclarationDepth(trivia)));
                            _afterIndentation = true;
                        }
                    }
                    else if (needsSeparator)
                    {
                        currentTriviaList.Add(GetSpace());
                        _afterLineBreak = false;
                        _afterIndentation = false;
                    }

                    if (trivia.HasStructure)
                    {
                        var tr = this.VisitStructuredTrivia(trivia);
                        currentTriviaList.Add(tr);
                    }
                    else
                    {
                        currentTriviaList.Add(trivia);
                    }

                    if (NeedsLineBreakAfter(trivia, isTrailing)
                        && (currentTriviaList.Count == 0 || !EndsInLineBreak(currentTriviaList.Last())))
                    {
                        currentTriviaList.Add(GetEndOfLine());
                        _afterLineBreak = true;
                        _afterIndentation = false;
                    }
                }

                if (lineBreaksAfter > 0)
                {
                    if (currentTriviaList.Count > 0
                        && EndsInLineBreak(currentTriviaList.Last()))
                    {
                        lineBreaksAfter--;
                    }

                    for (int i = 0; i < lineBreaksAfter; i++)
                    {
                        currentTriviaList.Add(GetEndOfLine());
                        _afterLineBreak = true;
                        _afterIndentation = false;
                    }
                }
                else if (indentAfterLineBreak && _afterLineBreak && !_afterIndentation)
                {
                    currentTriviaList.Add(this.GetIndentation(depth));
                    _afterIndentation = true;
                }
                else if (mustHaveSeparator)
                {
                    currentTriviaList.Add(GetSpace());
                    _afterLineBreak = false;
                    _afterIndentation = false;
                }

                if (currentTriviaList.Count == 0)
                {
                    return default(SyntaxTriviaList);
                }
                else if (currentTriviaList.Count == 1)
                {
                    return SyntaxFactory.TriviaList(currentTriviaList.First());
                }
                else
                {
                    return SyntaxFactory.TriviaList(currentTriviaList);
                }
            }
            finally
            {
                currentTriviaList.Free();
            }
        }

        protected SyntaxTrivia GetSpace()
        {
            return _useElasticTrivia ? SyntaxFactory.ElasticSpace : SyntaxFactory.Space;
        }

        protected SyntaxTrivia GetEndOfLine()
        {
            return _eolTrivia;
        }

        protected virtual SyntaxTrivia VisitStructuredTrivia(SyntaxTrivia trivia)
        {
            bool oldIsInStructuredTrivia = _isInStructuredTrivia;
            _isInStructuredTrivia = true;

            SyntaxToken oldPreviousToken = _previousToken;
            _previousToken = default(SyntaxToken);

            SyntaxTrivia result = VisitTrivia(trivia);

            _isInStructuredTrivia = oldIsInStructuredTrivia;
            _previousToken = oldPreviousToken;

            return result;
        }

        protected virtual bool NeedsSeparatorBetween(SyntaxTrivia trivia)
        {
            var kind = trivia.RawKind;
            if (kind == (int)InternalSyntaxKind.None || kind == DefaultWhitespaceKind)
            {
                return false;
            }
            else
            { 
                return !Language.SyntaxFacts.IsPreprocessorDirective(trivia.RawKind);
            }
        }

        protected virtual bool NeedsLineBreakBetween(SyntaxTrivia trivia, SyntaxTrivia next, bool isTrailingTrivia)
        {
            return NeedsLineBreakAfter(trivia, isTrailingTrivia)
                || NeedsLineBreakBefore(next, isTrailingTrivia);
        }

        protected virtual bool NeedsLineBreakBefore(SyntaxTrivia trivia, bool isTrailingTrivia)
        {
            var kind = trivia.RawKind;
            return Language.SyntaxFacts.IsPreprocessorDirective(kind);
        }

        protected virtual bool NeedsLineBreakAfter(SyntaxTrivia trivia, bool isTrailingTrivia)
        {
            var kind = trivia.RawKind;
            return Language.SyntaxFacts.IsPreprocessorDirective(kind);
        }

        protected virtual bool NeedsIndentAfterLineBreak(SyntaxTrivia trivia)
        {
            var kind = trivia.RawKind;
            return Language.SyntaxFacts.IsCommentTrivia(kind);
        }

        protected virtual bool IsLineBreak(SyntaxToken token)
        {
            return token.RawKind == DefaultEndOfLineKind;
        }

        protected virtual bool EndsInLineBreak(SyntaxTrivia trivia)
        {
            if (trivia.RawKind == DefaultEndOfLineKind) return true;
            return trivia.UnderlyingNode?.IsTriviaWithEndOfLine() ?? false;
        }

        protected virtual bool IsWord(int rawKind)
        {
            return rawKind == DefaultIdentifierKind || IsKeyword(rawKind);
        }

        protected virtual bool IsKeyword(int rawKind)
        {
            return Language.SyntaxFacts.IsKeyword(rawKind) || Language.SyntaxFacts.IsPreprocessorKeyword(rawKind);
        }

        protected virtual bool TokenCharacterCanBeDoubled(char c)
        {
            return false;
        }
    }
}
