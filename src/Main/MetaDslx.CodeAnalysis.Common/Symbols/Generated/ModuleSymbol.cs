namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ModelProperty = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;

public interface ModuleSymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory SymbolFactory { get; }
        [__ModelProperty]
        NamespaceSymbol GlobalNamespace { get; }

        global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol? GetRootNamespace(global::MetaDslx.CodeAnalysis.SyntaxTree syntaxTree);

        public static new class CompletionParts
        {
            public static readonly CompletionPart Start_GlobalNamespace = new CompletionPart(nameof(Start_GlobalNamespace));
            public static readonly CompletionPart Finish_GlobalNamespace = new CompletionPart(nameof(Finish_GlobalNamespace));
            public static readonly CompletionPart Start_Attribute = new CompletionPart(nameof(Start_Attribute));
            public static readonly CompletionPart Finish_Attribute = new CompletionPart(nameof(Finish_Attribute));

            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    Start_Attribute, Finish_Attribute
                    , Start_GlobalNamespace, Finish_GlobalNamespace
                );
        }
    }
}
