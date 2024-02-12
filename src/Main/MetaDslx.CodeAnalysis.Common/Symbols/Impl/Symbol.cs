using MetaDslx.CodeAnalysis.Text;
using System.Collections.Immutable;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public interface Symbol
    {
        string Name { get; }
        string MetadataName { get; }
        string Kind { get; }
        string DisplayKind { get; }
        bool IsError { get; }

        Symbol ContainingSymbol { get; }
        AssemblySymbol? ContainingAssembly { get; }
        ModuleSymbol? ContainingModule {  get; }
        DeclarationSymbol? ContainingDeclaration {  get; }
        TypeSymbol? ContainingType { get; }
        NamespaceSymbol? ContainingNamespace {  get; }

        ImmutableArray<Symbol> ContainedSymbols { get; }
        Compilation? DeclaringCompilation {  get; }

        LexicalSortKey GetLexicalSortKey();
        ImmutableArray<Location> Locations { get; }
        Location Location { get; }

        global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> Attributes { get; }

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
