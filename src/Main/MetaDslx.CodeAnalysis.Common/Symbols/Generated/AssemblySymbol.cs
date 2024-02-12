namespace MetaDslx.CodeAnalysis.Symbols
{
public interface AssemblySymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        bool IsCorLibrary { get; }
        global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Modules { get; }

        public static class CompletionParts
        {
            public static readonly CompletionPart Start_IsCorLibrary = new CompletionPart(nameof(Start_IsCorLibrary));
            public static readonly CompletionPart Finish_IsCorLibrary = new CompletionPart(nameof(Finish_IsCorLibrary));
            public static readonly CompletionPart Start_Modules = new CompletionPart(nameof(Start_Modules));
            public static readonly CompletionPart Finish_Modules = new CompletionPart(nameof(Finish_Modules));
            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    Start_IsCorLibrary, Finish_IsCorLibrary,
                    Start_Modules, Finish_Modules
                );
        }
    }
}
