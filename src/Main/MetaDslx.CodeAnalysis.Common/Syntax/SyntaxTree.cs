// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MetaDslx.CodeAnalysis.Debugging;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis
{
    /// <summary>
    /// The parsed representation of a source document.
    /// </summary>
    public abstract class SyntaxTree
    {
        private ImmutableArray<byte> _lazyChecksum;
        private SourceHashAlgorithm _lazyHashAlgorithm;

        /// <summary>
        /// The path of the source document file.
        /// </summary>
        /// <remarks>
        /// If this syntax tree is not associated with a file, this value can be empty.
        /// The path shall not be null.
        /// 
        /// The file doesn't need to exist on disk. The path is opaque to the compiler.
        /// The only requirement on the path format is that the implementations of 
        /// <see cref="SourceReferenceResolver"/>
        /// passed to the compilation that contains the tree understand it.
        /// 
        /// Clients must also not assume that the values of this property are unique
        /// within a Compilation.
        /// 
        /// The path is used as follows:
        ///    - When debug information is emitted, this path is embedded in the debug information.
        ///    - When resolving and normalizing relative paths in #r, #load, #line/#ExternalSource, 
        ///      #pragma checksum, #ExternalChecksum directives, XML doc comment include elements, etc.
        /// </remarks>
        public abstract string FilePath { get; }

        /// <summary>
        /// Returns true if this syntax tree has a root with SyntaxKind "CompilationUnit".
        /// </summary>
        public abstract bool HasCompilationUnitRoot { get; }

        public Language Language => this.Options.Language;

        /// <summary>
        /// The options used by the parser to produce the syntax tree.
        /// </summary>
        public ParseOptions Options => this.OptionsCore;

        /// <summary>
        /// The options used by the parser to produce the syntax tree.
        /// </summary>
        protected abstract ParseOptions OptionsCore { get; }

        /// <summary>
        /// The length of the text of the syntax tree.
        /// </summary>
        public abstract int Length { get; }

        /// <summary>
        /// Gets the syntax tree's text if it is available.
        /// </summary>
        public abstract bool TryGetText([NotNullWhen(true)] out SourceText? text);

        /// <summary>
        /// Gets the text of the source document.
        /// </summary>
        public abstract SourceText GetText(CancellationToken cancellationToken = default);

        /// <summary>
        /// The text encoding of the source document.
        /// </summary>
        public abstract Encoding? Encoding { get; }

        /// <summary>
        /// Gets the text of the source document asynchronously.
        /// </summary>
        /// <remarks>
        /// By default, the work associated with this method will be executed immediately on the current thread.
        /// Implementations that wish to schedule this work differently should override <see cref="GetTextAsync(CancellationToken)"/>.
        /// </remarks>
        public virtual Task<SourceText> GetTextAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(this.TryGetText(out SourceText? text) ? text : this.GetText(cancellationToken));
        }

        /// <summary>
        /// Gets the root of the syntax tree if it is available.
        /// </summary>
        public bool TryGetRoot([NotNullWhen(true)] out SyntaxNode? root)
        {
            return TryGetRootCore(out root);
        }

        /// <summary>
        /// Gets the root of the syntax tree if it is available.
        /// </summary>
        protected abstract bool TryGetRootCore([NotNullWhen(true)] out SyntaxNode? root);

        /// <summary>
        /// Gets the root node of the syntax tree, causing computation if necessary.
        /// </summary>
        public SyntaxNode GetRoot(CancellationToken cancellationToken = default)
        {
            return GetRootCore(cancellationToken);
        }

        /// <summary>
        /// Gets the root node of the syntax tree, causing computation if necessary.
        /// </summary>
        protected abstract SyntaxNode GetRootCore(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the root node of the syntax tree asynchronously.
        /// </summary>
        public Task<SyntaxNode> GetRootAsync(CancellationToken cancellationToken = default)
        {
            return GetRootAsyncCore(cancellationToken);
        }

        /// <summary>
        /// Gets the root node of the syntax tree asynchronously.
        /// </summary>
        [SuppressMessage("Style", "VSTHRD200:Use \"Async\" suffix for async methods", Justification = "Public API.")]
        protected abstract Task<SyntaxNode> GetRootAsyncCore(CancellationToken cancellationToken);

        /// <summary>
        /// Create a new syntax tree based off this tree using a new source text.
        /// 
        /// If the new source text is a minor change from the current source text an incremental
        /// parse will occur reusing most of the current syntax tree internal data.  Otherwise, a
        /// full parse will occur using the new source text.
        /// </summary>
        public abstract SyntaxTree WithChangedText(SourceText newText);

        /// <summary>
        /// Returns a path for particular location in source that is presented to the user. 
        /// </summary>
        /// <remarks>
        /// Used for implementation of <see cref="System.Runtime.CompilerServices.CallerFilePathAttribute"/> 
        /// or for embedding source paths in error messages.
        /// 
        /// Unlike Dev12 we do account for #line and #ExternalSource directives when determining value for 
        /// <see cref="System.Runtime.CompilerServices.CallerFilePathAttribute"/>.
        /// </remarks>
        internal string GetDisplayPath(TextSpan span, SourceReferenceResolver? resolver)
        {
            var mappedSpan = GetMappedLineSpan(span);
            if (resolver == null || mappedSpan.Path.IsEmpty())
            {
                return mappedSpan.Path;
            }

            return resolver.NormalizePath(mappedSpan.Path, baseFilePath: mappedSpan.HasMappedPath ? FilePath : null) ?? mappedSpan.Path;
        }

        /// <summary>
        /// Returns a line number for particular location in source that is presented to the user. 
        /// </summary>
        /// <remarks>
        /// Used for implementation of <see cref="System.Runtime.CompilerServices.CallerLineNumberAttribute"/> 
        /// or for embedding source line numbers in error messages.
        /// 
        /// Unlike Dev12 we do account for #line and #ExternalSource directives when determining value for 
        /// <see cref="System.Runtime.CompilerServices.CallerLineNumberAttribute"/>.
        /// </remarks>
        internal int GetDisplayLineNumber(TextSpan span)
        {
            // display line numbers are 1-based
            return GetMappedLineSpan(span).StartLinePosition.Line + 1;
        }

        /// <summary>
        /// Determines if two trees are the same, disregarding trivia differences.
        /// </summary>
        /// <param name="tree">The tree to compare against.</param>
        /// <param name="topLevel"> If true then the trees are equivalent if the contained nodes and tokens declaring
        /// metadata visible symbolic information are equivalent, ignoring any differences of nodes inside method bodies
        /// or initializer expressions, otherwise all nodes and tokens must be equivalent. 
        /// </param>
        public bool IsEquivalentTo(SyntaxTree tree, bool topLevel = false)
        {
            return Language.SyntaxFactory.AreEquivalent(this, tree, topLevel);
        }

        /// <summary>
        /// Gets a SyntaxReference for a specified syntax node. SyntaxReferences can be used to
        /// regain access to a syntax node without keeping the entire tree and source text in
        /// memory.
        /// </summary>
        public abstract SyntaxReference GetReference(SyntaxNode node);

        /// <summary>
        /// Gets the checksum + algorithm id to use in the PDB.
        /// </summary>
        internal DebugSourceInfo GetDebugSourceInfo()
        {
            if (_lazyChecksum.IsDefault)
            {
                var text = this.GetText();
                _lazyChecksum = text.GetChecksum();
                _lazyHashAlgorithm = text.ChecksumAlgorithm;
            }

            Debug.Assert(!_lazyChecksum.IsDefault);
            Debug.Assert(_lazyHashAlgorithm != default(SourceHashAlgorithm));

            // NOTE: If this tree is to be embedded, it's debug source info should have
            // been obtained via EmbeddedText.GetDebugSourceInfo() and not here.
            return new DebugSourceInfo(_lazyChecksum, _lazyHashAlgorithm);
        }

        /// <summary>
        /// Returns a new tree whose root and options are as specified and other properties are copied from the current tree.
        /// </summary>
        public abstract SyntaxTree WithRootAndOptions(SyntaxNode root, ParseOptions options);

        /// <summary>
        /// Returns a new tree whose <see cref="FilePath"/> is the specified node and other properties are copied from the current tree.
        /// </summary>
        public abstract SyntaxTree WithFilePath(string path);

        /// <summary>
        /// Returns a <see cref="String" /> that represents the entire source text of this <see cref="SyntaxTree"/>.
        /// </summary>
        public override string ToString()
        {
            return this.GetText(CancellationToken.None).ToString();
        }

        internal virtual bool SupportsLocations
        {
            get { return this.HasCompilationUnitRoot; }
        }

        internal protected ICompilationUnitRootSyntax GetCompilationUnitRoot()
        {
            return (ICompilationUnitRootSyntax)GetRoot();
        }

        public bool HasReferenceDirectives
        {
            get
            {
                Debug.Assert(HasCompilationUnitRoot);
                return Options.Kind == SourceCodeKind.Script && GetCompilationUnitRoot().GetReferenceDirectives().Count > 0;
            }
        }

        public bool HasReferenceOrLoadDirectives
        {
            get
            {
                Debug.Assert(HasCompilationUnitRoot);

                if (Options.Kind == SourceCodeKind.Script)
                {
                    var compilationUnitRoot = GetCompilationUnitRoot();
                    return compilationUnitRoot.GetReferenceDirectives().Count > 0 || compilationUnitRoot.GetLoadDirectives().Count > 0;
                }

                return false;
            }
        }

        #region Preprocessor Symbols

        protected abstract Syntax.InternalSyntax.ParseData ParseData { get; }

        protected DirectiveStack GetDirectives()
        {
            return ParseData.Directives;
        }

        public bool IsAnyPreprocessorSymbolDefined(ImmutableArray<string> conditionalSymbols)
        {
            Debug.Assert(conditionalSymbols != null);

            foreach (string conditionalSymbol in conditionalSymbols)
            {
                if (IsPreprocessorSymbolDefined(conditionalSymbol))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsPreprocessorSymbolDefined(string symbolName)
        {
            return IsPreprocessorSymbolDefined(GetDirectives(), symbolName);
        }

        private bool IsPreprocessorSymbolDefined(DirectiveStack directives, string symbolName)
        {
            switch (directives.IsDefined(symbolName))
            {
                case DefineState.Defined:
                    return true;
                case DefineState.Undefined:
                    return false;
                default:
                    return this.Options.PreprocessorSymbols.Contains(symbolName);
            }
        }

        /// <summary>
        /// Stores positions where preprocessor state changes. Sorted by position.
        /// The updated state can be found in <see cref="_preprocessorStates"/> array at the same index.
        /// </summary>
        private ImmutableArray<int> _preprocessorStateChangePositions;

        /// <summary>
        /// Preprocessor states corresponding to positions in <see cref="_preprocessorStateChangePositions"/>.
        /// </summary>
        private ImmutableArray<DirectiveStack> _preprocessorStates;

        public bool IsPreprocessorSymbolDefined(string symbolName, int position)
        {
            if (_preprocessorStateChangePositions.IsDefault)
            {
                BuildPreprocessorStateChangeMap();
            }

            int searchResult = _preprocessorStateChangePositions.BinarySearch(position);
            DirectiveStack directives;

            if (searchResult < 0)
            {
                searchResult = (~searchResult) - 1;

                if (searchResult >= 0)
                {
                    directives = _preprocessorStates[searchResult];
                }
                else
                {
                    directives = DirectiveStack.Empty;
                }
            }
            else
            {
                directives = _preprocessorStates[searchResult];
            }

            return IsPreprocessorSymbolDefined(directives, symbolName);
        }

        private void BuildPreprocessorStateChangeMap()
        {
            DirectiveStack currentState = DirectiveStack.Empty;
            var positions = ArrayBuilder<int>.GetInstance();
            var states = ArrayBuilder<DirectiveStack>.GetInstance();

            foreach (IDirectiveTriviaSyntax directive in this.GetRoot().
                GetDirectives(d =>
                {
                    switch (((IDirectiveTriviaSyntax)d).Directive.Kind)
                    {
                        case DirectiveKind.If:
                        case DirectiveKind.Elif:
                        case DirectiveKind.Else:
                        case DirectiveKind.EndIf:
                        case DirectiveKind.Define:
                        case DirectiveKind.Undef:
                            return true;
                        default:
                            return false;
                    }
                }))
            {
                currentState = currentState.Add(directive.Directive);
                int position = ((SyntaxNode)directive).SpanStart;
                switch (directive.Directive.Kind)
                {
                    case DirectiveKind.If:
                        // #if directive doesn't affect the set of defined/undefined symbols
                        break;
                    case DirectiveKind.Elif:
                    case DirectiveKind.Else:
                    case DirectiveKind.EndIf:
                    case DirectiveKind.Define:
                    case DirectiveKind.Undef:
                        states.Add(currentState);
                        positions.Add(position);
                        break;
                    default:
                        throw ExceptionUtilities.UnexpectedValue(directive.Directive.Kind);
                }
            }

#if DEBUG
            int currentPos = -1;
            foreach (int pos in positions)
            {
                Debug.Assert(currentPos < pos);
                currentPos = pos;
            }
#endif

            ImmutableInterlocked.InterlockedInitialize(ref _preprocessorStates, states.ToImmutableAndFree());
            ImmutableInterlocked.InterlockedInitialize(ref _preprocessorStateChangePositions, positions.ToImmutableAndFree());
        }

        #endregion

        #region Changes

        /// <summary>
        /// Produces a pessimistic list of spans that denote the regions of text in this tree that
        /// are changed from the text of the old tree.
        /// </summary>
        /// <param name="oldTree">The old tree. Cannot be <c>null</c>.</param>
        /// <remarks>The list is pessimistic because it may claim more or larger regions than actually changed.</remarks>
        public IList<TextSpan> GetChangedSpans(SyntaxTree oldTree)
        {
            if (oldTree == null)
            {
                throw new ArgumentNullException(nameof(oldTree));
            }

            return SyntaxDiffer.GetPossiblyDifferentTextSpans(oldTree, this);
        }

        /// <summary>
        /// Gets a list of text changes that when applied to the old tree produce this tree.
        /// </summary>
        /// <param name="oldTree">The old tree. Cannot be <c>null</c>.</param>
        /// <remarks>The list of changes may be different than the original changes that produced this tree.</remarks>
        public IList<TextChange> GetChanges(SyntaxTree oldTree)
        {
            if (oldTree == null)
            {
                throw new ArgumentNullException(nameof(oldTree));
            }

            return SyntaxDiffer.GetTextChanges(oldTree, this);
        }

        #endregion

        #region LinePositions and Locations

        /// <summary>
        /// Gets the location in terms of path, line and column for a given span.
        /// </summary>
        /// <param name="span">Span within the tree.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>
        /// <see cref="FileLinePositionSpan"/> that contains path, line and column information.
        /// </returns>
        /// <remarks>The values are not affected by line mapping directives (<c>#line</c>).</remarks>
        public FileLinePositionSpan GetLineSpan(TextSpan span, CancellationToken cancellationToken = default(CancellationToken))
        {
            return new FileLinePositionSpan(this.FilePath, GetLinePosition(span.Start), GetLinePosition(span.End));
        }

        /// <summary>
        /// Gets the location in terms of path, line and column after applying source line mapping directives (<c>#line</c>). 
        /// </summary>
        /// <param name="span">Span within the tree.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>
        /// <para>A valid <see cref="FileLinePositionSpan"/> that contains path, line and column information.</para>
        /// <para>
        /// If the location path is mapped the resulting path is the path specified in the corresponding <c>#line</c>,
        /// otherwise it's <see cref="SyntaxTree.FilePath"/>.
        /// </para>
        /// <para>
        /// A location path is considered mapped if the first <c>#line</c> directive that precedes it and that
        /// either specifies an explicit file path or is <c>#line default</c> exists and specifies an explicit path.
        /// </para>
        /// </returns>
        public FileLinePositionSpan GetMappedLineSpan(TextSpan span, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (_lazyLineDirectiveMap == null)
            {
                // Create the line directive map on demand.
                Interlocked.CompareExchange(ref _lazyLineDirectiveMap, new LineDirectiveMap(this), null);
            }

            return _lazyLineDirectiveMap.TranslateSpan(this.GetText(cancellationToken), this.FilePath, span);
        }

        public LineVisibility GetLineVisibility(int position, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (_lazyLineDirectiveMap == null)
            {
                // Create the line directive map on demand.
                Interlocked.CompareExchange(ref _lazyLineDirectiveMap, new LineDirectiveMap(this), null);
            }

            return _lazyLineDirectiveMap.GetLineVisibility(this.GetText(cancellationToken), position);
        }

        /// <summary>
        /// Gets a <see cref="FileLinePositionSpan"/> for a <see cref="TextSpan"/>. FileLinePositionSpans are used
        /// primarily for diagnostics and source locations.
        /// </summary>
        /// <param name="span">The source <see cref="TextSpan" /> to convert.</param>
        /// <param name="isHiddenPosition">When the method returns, contains a boolean value indicating whether this span is considered hidden or not.</param>
        /// <returns>A resulting <see cref="FileLinePositionSpan"/>.</returns>
        internal FileLinePositionSpan GetMappedLineSpanAndVisibility(TextSpan span, out bool isHiddenPosition)
        {
            if (_lazyLineDirectiveMap == null)
            {
                // Create the line directive map on demand.
                Interlocked.CompareExchange(ref _lazyLineDirectiveMap, new LineDirectiveMap(this), null);
            }

            return _lazyLineDirectiveMap.TranslateSpanAndVisibility(this.GetText(), this.FilePath, span, out isHiddenPosition);
        }

        /// <summary>
        /// Gets a boolean value indicating whether there are any hidden regions in the tree.
        /// </summary>
        /// <returns>True if there is at least one hidden region.</returns>
        public bool HasHiddenRegions()
        {
            if (_lazyLineDirectiveMap == null)
            {
                // Create the line directive map on demand.
                Interlocked.CompareExchange(ref _lazyLineDirectiveMap, new LineDirectiveMap(this), null);
            }

            return _lazyLineDirectiveMap.HasAnyHiddenRegions();
        }

        /// <summary>
        /// Given the error code and the source location, get the warning state based on <c>#pragma warning</c> directives.
        /// </summary>
        /// <param name="id">Error code.</param>
        /// <param name="position">Source location.</param>
        internal PragmaWarningState GetPragmaDirectiveWarningState(string id, int position)
        {
            if (_lazyPragmaWarningStateMap == null)
            {
                // Create the warning state map on demand.
                Interlocked.CompareExchange(ref _lazyPragmaWarningStateMap, new PragmaWarningStateMap(this), null);
            }

            return _lazyPragmaWarningStateMap.GetWarningState(id, position);
        }

        internal bool IsGeneratedCode(CancellationToken cancellationToken)
        {
            if (_lazyIsGeneratedCode == GeneratedKind.Unknown)
            {
                // Create the generated code status on demand
                bool isGenerated = GeneratedCodeUtilities.IsGeneratedCode(
                        this,
                        isComment: trivia => Language.SyntaxFacts.IsCommentTrivia(trivia.RawKind),
                        cancellationToken: default);
                _lazyIsGeneratedCode = isGenerated ? GeneratedKind.MarkedGenerated : GeneratedKind.NotGenerated;
            }

            return _lazyIsGeneratedCode == GeneratedKind.MarkedGenerated;
        }

        private LineDirectiveMap? _lazyLineDirectiveMap;
        private PragmaWarningStateMap? _lazyPragmaWarningStateMap;

        private GeneratedKind _lazyIsGeneratedCode = GeneratedKind.Unknown;

        private LinePosition GetLinePosition(int position)
        {
            return this.GetText().Lines.GetLinePosition(position);
        }

        /// <summary>
        /// Gets a <see cref="Location"/> for the specified text <paramref name="span"/>.
        /// </summary>
        public Location GetLocation(TextSpan span)
        {
            return new SourceLocation(this, span);
        }

        #endregion

        #region Diagnostics

        /// <summary>
        /// Gets a list of all the diagnostics in the sub tree that has the specified node as its root.
        /// </summary>
        /// <remarks>
        /// This method does not filter diagnostics based on <c>#pragma</c>s and compiler options
        /// like /nowarn, /warnaserror etc.
        /// </remarks>
        public IEnumerable<Diagnostic> GetDiagnostics(SyntaxNode? node)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            return GetDiagnostics(node.Green, node.Position);
        }

        private IEnumerable<Diagnostic> GetDiagnostics(GreenNode? greenNode, int position)
        {
            if (greenNode == null)
            {
                throw new InvalidOperationException();
            }

            if (greenNode.ContainsDiagnostics)
            {
                return EnumerateDiagnostics(greenNode, position);
            }

            return SpecializedCollections.EmptyEnumerable<Diagnostic>();
        }

        private IEnumerable<Diagnostic> EnumerateDiagnostics(GreenNode node, int position)
        {
            var enumerator = new SyntaxTreeDiagnosticEnumerator(this, node, position);
            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }
        }

        /// <summary>
        /// Gets a list of all the diagnostics associated with the token and any related trivia.
        /// </summary>
        /// <remarks>
        /// This method does not filter diagnostics based on <c>#pragma</c>s and compiler options
        /// like /nowarn, /warnaserror etc.
        /// </remarks>
        public IEnumerable<Diagnostic> GetDiagnostics(SyntaxToken token)
        {
            return GetDiagnostics(token.Node, token.Position);
        }

        /// <summary>
        /// Gets a list of all the diagnostics associated with the trivia.
        /// </summary>
        /// <remarks>
        /// This method does not filter diagnostics based on <c>#pragma</c>s and compiler options
        /// like /nowarn, /warnaserror etc.
        /// </remarks>
        public IEnumerable<Diagnostic> GetDiagnostics(SyntaxTrivia trivia)
        {
            return GetDiagnostics(trivia.UnderlyingNode, trivia.Position);
        }

        /// <summary>
        /// Gets a list of all the diagnostics in either the sub tree that has the specified node as its root or
        /// associated with the token and its related trivia. 
        /// </summary>
        /// <remarks>
        /// This method does not filter diagnostics based on <c>#pragma</c>s and compiler options
        /// like /nowarn, /warnaserror etc.
        /// </remarks>
        public IEnumerable<Diagnostic> GetDiagnostics(SyntaxNodeOrToken nodeOrToken)
        {
            return GetDiagnostics(nodeOrToken.UnderlyingNode, nodeOrToken.Position);
        }

        /// <summary>
        /// Gets a list of all the diagnostics in the syntax tree.
        /// </summary>
        /// <remarks>
        /// This method does not filter diagnostics based on <c>#pragma</c>s and compiler options
        /// like /nowarn, /warnaserror etc.
        /// </remarks>
        public IEnumerable<Diagnostic> GetDiagnostics(CancellationToken cancellationToken = default)
        {
            return this.GetDiagnostics(this.GetRoot(cancellationToken));
        }

        #endregion

        protected void VerifySource(IEnumerable<TextChangeRange>? changes = null)
        {
            SyntaxTreeExtensions.VerifySource(this, changes);
        }

        // REVIEW: I would prefer to not expose CloneAsRoot and make the functionality
        // internal to CaaS layer, to ensure that for a given SyntaxTree there can not
        // be multiple trees claiming to be its children.
        // 
        // However, as long as we provide GetRoot extensibility point on SyntaxTree
        // the guarantee above cannot be implemented and we have to provide some way for
        // creating root nodes.
        //
        // Therefore I place CloneAsRoot API on SyntaxTree and make it protected to
        // at least limit its visibility to SyntaxTree extenders.
        /// <summary>
        /// Produces a clone of a <see cref="SyntaxNode"/> which will have current syntax tree as its parent.
        /// 
        /// Caller must guarantee that if the same instance of <see cref="SyntaxNode"/> makes multiple calls
        /// to this function, only one result is observable.
        /// </summary>
        /// <typeparam name="T">Type of the syntax node.</typeparam>
        /// <param name="node">The original syntax node.</param>
        /// <returns>A clone of the original syntax node that has current <see cref="SyntaxTree"/> as its parent.</returns>
        protected T CloneNodeAsRoot<T>(T node) where T : SyntaxNode
        {
            return SyntaxNode.CloneNodeAsRoot(node, this);
        }

    }
}
