namespace MetaDslx.CodeAnalysis.Symbols
{
public interface ModuleSymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        NamespaceSymbol GlobalNamespace { get; }

        public static class CompletionParts
        {
            public static readonly CompletionPart Start_GlobalNamespace = new CompletionPart(nameof(Start_GlobalNamespace));
            public static readonly CompletionPart Finish_GlobalNamespace = new CompletionPart(nameof(Finish_GlobalNamespace));
            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    Start_GlobalNamespace, Finish_GlobalNamespace
                );
        }
    }
}
