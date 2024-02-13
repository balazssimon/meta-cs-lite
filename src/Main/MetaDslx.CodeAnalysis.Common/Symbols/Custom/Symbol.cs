using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Modeling;
using System;
using System.Collections.Immutable;
using System.Globalization;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;

    public interface Symbol
    {
        /// <summary>
        /// Gets the name of this symbol. Symbols without a name return the empty string; 
        /// null is never returned.
        /// </summary>
        [ModelProperty]
        string Name { get; }

        /// <summary>
        /// Gets the name of a symbol as it appears in metadata. Most of the time, this
        /// is the same as the Name property, with the following exceptions:
        /// 1) The metadata name of generic types includes the "`1", "`2" etc. suffix that
        /// indicates the number of type parameters (it does not include, however, names of
        /// containing types or namespaces).
        /// 2) The metadata name of explicit interface names have spaces removed, compared to
        /// the name property.
        /// </summary>
        [ModelProperty]
        string MetadataName { get; }

        [ModelProperty]
        ImmutableArray<AttributeSymbol> Attributes { get; }

        string Kind { get; }
        string DisplayKind { get; }
        /// <summary>
        /// Should the name returned by Name property be mangled with any suffix in order to get metadata name.
        /// </summary>
        bool MangleName { get; }

        /// <summary>
        /// Returns true if the symbol could not be resolved, 
        /// and this symbol serves as a placeholder, instead.
        /// </summary>
        bool IsErrorSymbol { get; }
        bool IsSourceSymbol { get; }
        bool IsModelSymbol { get; }
        bool IsCSharpSymbol { get; }

        /// <summary>
        /// Get the symbol that directly contains this symbol. 
        /// </summary>
        Symbol ContainingSymbol { get; }

        /// <summary>
        /// Returns the assembly containing this symbol. If this symbol is shared across multiple
        /// assemblies, or doesn't belong to an assembly, returns null.
        /// </summary>
        AssemblySymbol? ContainingAssembly { get; }

        /// <summary>
        /// Returns the module containing this symbol. If this symbol is shared across multiple
        /// modules, or doesn't belong to a module, returns null.
        /// </summary>
        ModuleSymbol? ContainingModule {  get; }

        /// <summary>
        /// Returns the nearest lexically enclosing named declaration, or null if there is none.
        /// </summary>
        DeclarationSymbol? ContainingDeclaration {  get; }

        /// <summary>
        /// Returns the nearest lexically enclosing named type, or null if there is none.
        /// </summary>
        TypeSymbol? ContainingType { get; }

        /// <summary>
        /// Gets the nearest enclosing namespace for this symbol. For a nested type,
        /// returns the namespace that contains its container.
        /// </summary>
        NamespaceSymbol? ContainingNamespace {  get; }

        /// <summary>
        /// Get the symbols that are directly contained by this symbol. 
        /// </summary>
        ImmutableArray<Symbol> ContainedSymbols { get; }

        /// <summary>
        /// For a source assembly, the associated compilation.
        /// For any other assembly, null.
        /// For a source module and modules from embedded references, 
        /// the DeclaringCompilation of the associated source assembly.
        /// For any other module, null.
        /// For any other symbol, the DeclaringCompilation of the associated module.
        /// </summary>
        /// <remarks>
        /// We're going through the containing module, rather than the containing assembly,
        /// because of /addmodule (symbols in such modules should return null).
        /// 
        /// Remarks, not "ContainingCompilation" because it isn't transitive.
        /// </remarks>
        Compilation? DeclaringCompilation {  get; }

        /// <summary>
        /// Returns true if this symbol was automatically created by the compiler, and does not
        /// have an explicit corresponding source code declaration.  
        /// 
        /// This is intended for symbols that are ordinary symbols in the language sense,
        /// and may be used by code, but that are simply declared implicitly rather than
        /// with explicit language syntax.
        /// 
        /// Examples include (this list is not exhaustive):
        ///   the default constructor for a class or struct that is created if one is not provided,
        ///   the BeginInvoke/Invoke/EndInvoke methods for a delegate,
        ///   the generated backing field for an auto property or a field-like event,
        ///   the "this" parameter for non-static methods,
        ///   the "value" parameter for a property setter,
        ///   the parameters on indexer accessor methods (not on the indexer itself),
        ///   methods in anonymous types,
        ///   anonymous functions
        /// </summary>
        bool IsImplicitlyDeclared { get; }

        /// <summary>
        /// <para>
        /// Get a source location key for sorting. For performance, it's important that this
        /// be able to be returned from a symbol without doing any additional allocations (even
        /// if nothing is cached yet.)
        /// </para>
        /// <para>
        /// Only (original) source symbols and namespaces that can be merged
        /// need implement this function if they want to do so for efficiency.
        /// </para>
        /// </summary>
        LexicalSortKey GetLexicalSortKey();

        MergedDeclaration? MergedDeclaration { get; }
        ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences { get; }
        ImmutableArray<Location> Locations { get; }
        Location Location { get; }

        IModelObject? ModelObject { get; }
        Type? ModelObjectType { get; }

        __ISymbol? CSharpSymbol { get; }

        ImmutableArray<Diagnostic> Diagnostics { get; }
        bool HasAnyErrors { get; }
        bool HasUseSiteError { get; }

        /// <summary>
        /// Indicates that this symbol uses metadata that cannot be supported by the language.
        /// 
        /// Examples include:
        ///    - Pointer types in VB
        ///    - ByRef return type
        ///    - Required custom modifiers
        ///    
        /// This is distinguished from, for example, references to metadata symbols defined in assemblies that weren't referenced.
        /// Symbols where this returns true can never be used successfully, and thus should never appear in any IDE feature.
        /// 
        /// This is set for metadata symbols, as follows:
        /// Type - if a type is unsupported (e.g., a pointer type, etc.)
        /// Method - parameter or return type is unsupported
        /// Field - type is unsupported
        /// Event - type is unsupported
        /// Property - type is unsupported
        /// Parameter - type is unsupported
        /// </summary>
        bool HasUnsupportedMetadata { get; }

        string GetDocumentationCommentId();
        string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default);

        void ForceComplete(CompletionPart completionPart, SourceLocation? locationOpt, CancellationToken cancellationToken);
        bool HasComplete(CompletionPart part);

        bool IsFromCompilation(Compilation compilation);
        bool IsDefinedInSourceTree(SyntaxTree tree, TextSpan? definedWithinSpan, CancellationToken cancellationToken = default);
        bool IsDefinedBySyntax(SyntaxNodeOrToken syntax, CancellationToken cancellationToken = default);

        public static class CompletionParts
        {
            public static readonly CompletionPart Start_Attributes = new CompletionPart(nameof(Start_Attributes));
            public static readonly CompletionPart Finish_Attributes = new CompletionPart(nameof(Finish_Attributes));
            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    Start_Attributes, Finish_Attributes
                );
        }
    }
}
