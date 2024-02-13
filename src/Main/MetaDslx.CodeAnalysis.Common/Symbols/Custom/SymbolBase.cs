using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.CodeAnalysis.Symbols.Source;
using Roslyn.Utilities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System;
using MetaDslx.CodeAnalysis.Text;
using System.Xml.Linq;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;

namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;

    public abstract class SymbolBase : Symbol
    {
        protected SymbolBase()
        {
        }

        public abstract string Name { get; }
        public abstract string MetadataName { get; }
        public abstract bool MangleName { get; }
        public abstract ImmutableArray<AttributeSymbol> Attributes { get; }
        public abstract string Kind { get; }
        public abstract string DisplayKind { get; }
        public abstract bool IsImplicitlyDeclared { get; }
        public abstract bool IsErrorSymbol { get; }
        public abstract bool IsSourceSymbol { get; }
        public abstract bool IsModelSymbol { get; }
        public abstract bool IsCSharpSymbol { get; }
        public abstract Symbol ContainingSymbol { get; }
        public abstract AssemblySymbol? ContainingAssembly { get; }
        public abstract ModuleSymbol? ContainingModule { get; }
        public abstract DeclarationSymbol? ContainingDeclaration { get; }
        public abstract TypeSymbol? ContainingType { get; }
        public abstract NamespaceSymbol? ContainingNamespace { get; }
        public abstract ImmutableArray<Symbol> ContainedSymbols { get; }
        public abstract Compilation? DeclaringCompilation { get; }
        public abstract MergedDeclaration? MergedDeclaration { get; }
        public abstract ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences { get; }
        public abstract ImmutableArray<Location> Locations { get; }
        public abstract Location Location { get; }
        public abstract IModelObject? ModelObject { get; }
        public abstract Type? ModelObjectType { get; }
        public abstract __ISymbol? CSharpSymbol { get; }
        public abstract ImmutableArray<Diagnostic> Diagnostics { get; }
        public abstract bool HasAnyErrors { get; }
        public abstract bool HasUseSiteError { get; }
        public abstract bool HasUnsupportedMetadata { get; }

        public abstract void ForceComplete(CompletionPart completionPart, SourceLocation? locationOpt, CancellationToken cancellationToken);

        /// <summary>
        /// Returns the Documentation Comment ID for the symbol, or null if the symbol doesn't
        /// support documentation comments.
        /// </summary>
        public abstract string GetDocumentationCommentId();

        /// <summary>
        /// Fetches the documentation comment for this element with a cancellation token.
        /// </summary>
        /// <param name="preferredCulture">Optionally, retrieve the comments formatted for a particular culture. No impact on source documentation comments.</param>
        /// <param name="expandIncludes">Optionally, expand <![CDATA[<include>]]> elements. No impact on non-source documentation comments.</param>
        /// <param name="cancellationToken">Optionally, allow cancellation of documentation comment retrieval.</param>
        /// <returns>The XML that would be written to the documentation file for the symbol.</returns>
        public abstract string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default);

        public abstract LexicalSortKey GetLexicalSortKey();
        public abstract bool HasComplete(CompletionPart part);
        public abstract bool IsDefinedBySyntax(SyntaxNodeOrToken syntax, CancellationToken cancellationToken = default);
        public abstract bool IsDefinedInSourceTree(SyntaxTree tree, TextSpan? definedWithinSpan, CancellationToken cancellationToken = default);
        public abstract bool IsFromCompilation(Compilation compilation);
    }
}
