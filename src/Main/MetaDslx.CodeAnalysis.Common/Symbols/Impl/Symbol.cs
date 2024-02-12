using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Modeling;
using System;
using System.Collections.Immutable;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;

    public interface Symbol
    {
        [ModelProperty]
        string Name { get; }

        [ModelProperty]
        string MetadataName { get; }

        bool MangleName { get; }

        [ModelProperty]
        ImmutableArray<AttributeSymbol> Attributes { get; }

        string Kind { get; }

        string DisplayKind { get; }

        bool IsErrorSymbol { get; }
        bool IsSourceSymbol { get; }
        bool IsModelSymbol { get; }
        bool IsCSharpSymbol { get; }

        Symbol ContainingSymbol { get; }
        AssemblySymbol? ContainingAssembly { get; }
        ModuleSymbol? ContainingModule {  get; }
        DeclarationSymbol? ContainingDeclaration {  get; }
        TypeSymbol? ContainingType { get; }
        NamespaceSymbol? ContainingNamespace {  get; }

        ImmutableArray<Symbol> ContainedSymbols { get; }
        Compilation? DeclaringCompilation {  get; }

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

        void ForceComplete(CompletionPart completionPart, SourceLocation? locationOpt, CancellationToken cancellationToken);
        bool HasComplete(CompletionPart part);

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
