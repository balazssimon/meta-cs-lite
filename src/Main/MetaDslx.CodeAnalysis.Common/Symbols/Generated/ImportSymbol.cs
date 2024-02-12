namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ModelProperty = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;

public interface ImportSymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        [__ModelProperty]
        global::System.Collections.Immutable.ImmutableArray<string> Files { get; }
        [__ModelProperty]
        global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Aliases { get; }
        [__ModelProperty]
        global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Namespaces { get; }
        [__ModelProperty]
        global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Symbols { get; }

        public static class CompletionParts
        {
            public static readonly CompletionPart Start_Files = new CompletionPart(nameof(Start_Files));
            public static readonly CompletionPart Finish_Files = new CompletionPart(nameof(Finish_Files));
            public static readonly CompletionPart Start_Aliases = new CompletionPart(nameof(Start_Aliases));
            public static readonly CompletionPart Finish_Aliases = new CompletionPart(nameof(Finish_Aliases));
            public static readonly CompletionPart Start_Namespaces = new CompletionPart(nameof(Start_Namespaces));
            public static readonly CompletionPart Finish_Namespaces = new CompletionPart(nameof(Finish_Namespaces));
            public static readonly CompletionPart Start_Symbols = new CompletionPart(nameof(Start_Symbols));
            public static readonly CompletionPart Finish_Symbols = new CompletionPart(nameof(Finish_Symbols));
            public static readonly CompletionPart Start_Attribute = new CompletionPart(nameof(Start_Attribute));
            public static readonly CompletionPart Finish_Attribute = new CompletionPart(nameof(Finish_Attribute));

            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    Start_Files, Finish_Files,
                    Start_Aliases, Finish_Aliases,
                    Start_Namespaces, Finish_Namespaces,
                    Start_Symbols, Finish_Symbols,
                    Start_Attribute, Finish_Attribute
                );
        }
    }
}
