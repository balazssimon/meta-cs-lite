namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ModelProperty = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;

public interface ImportMetaModelSymbol: ImportSymbol
    {
        [__ModelProperty]
        global::MetaDslx.CodeAnalysis.MetaSymbol MetaModelSymbols { get; }
        [__ModelProperty]
        global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> MetaModels { get; }

        public static new class CompletionParts
        {
            public static readonly CompletionPart Start_MetaModelSymbols = new CompletionPart(nameof(Start_MetaModelSymbols));
            public static readonly CompletionPart Finish_MetaModelSymbols = new CompletionPart(nameof(Finish_MetaModelSymbols));
            public static readonly CompletionPart Start_MetaModels = new CompletionPart(nameof(Start_MetaModels));
            public static readonly CompletionPart Finish_MetaModels = new CompletionPart(nameof(Finish_MetaModels));
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
                    Start_MetaModelSymbols, Finish_MetaModelSymbols,
                    Start_MetaModels, Finish_MetaModels,
                    Start_Files, Finish_Files,
                    Start_Aliases, Finish_Aliases,
                    Start_Namespaces, Finish_Namespaces,
                    Start_Symbols, Finish_Symbols,
                    Start_Attribute, Finish_Attribute
                );
        }
    }
}
