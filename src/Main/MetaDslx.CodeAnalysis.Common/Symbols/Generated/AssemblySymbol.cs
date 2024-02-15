namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ModelProperty = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;

public interface AssemblySymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        [__ModelProperty]
        bool IsCorLibrary { get; }
        [__ModelProperty]
        global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Modules { get; }
        [__ModelProperty]
        NamespaceSymbol GlobalNamespace { get; }


        public static new class CompletionParts
        {
            public static readonly CompletionPart Start_IsCorLibrary = new CompletionPart(nameof(Start_IsCorLibrary));
            public static readonly CompletionPart Finish_IsCorLibrary = new CompletionPart(nameof(Finish_IsCorLibrary));
            public static readonly CompletionPart Start_Modules = new CompletionPart(nameof(Start_Modules));
            public static readonly CompletionPart Finish_Modules = new CompletionPart(nameof(Finish_Modules));
            public static readonly CompletionPart Start_GlobalNamespace = new CompletionPart(nameof(Start_GlobalNamespace));
            public static readonly CompletionPart Finish_GlobalNamespace = new CompletionPart(nameof(Finish_GlobalNamespace));
            public static readonly CompletionPart Start_Attribute = new CompletionPart(nameof(Start_Attribute));
            public static readonly CompletionPart Finish_Attribute = new CompletionPart(nameof(Finish_Attribute));

            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    Start_IsCorLibrary, Finish_IsCorLibrary,
                    Start_Modules, Finish_Modules,
                    Start_GlobalNamespace, Finish_GlobalNamespace,
                    Start_Attribute, Finish_Attribute
                );
        }
    }
}
