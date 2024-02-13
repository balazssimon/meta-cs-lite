namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ModelProperty = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;

public interface ModuleSymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        [__ModelProperty]
        NamespaceSymbol GlobalNamespace { get; }

        public static new class CompletionParts
        {
            public static readonly CompletionPart Start_GlobalNamespace = new CompletionPart(nameof(Start_GlobalNamespace));
            public static readonly CompletionPart Finish_GlobalNamespace = new CompletionPart(nameof(Finish_GlobalNamespace));
            public static readonly CompletionPart Start_Attribute = new CompletionPart(nameof(Start_Attribute));
            public static readonly CompletionPart Finish_Attribute = new CompletionPart(nameof(Finish_Attribute));

            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    Start_GlobalNamespace, Finish_GlobalNamespace,
                    Start_Attribute, Finish_Attribute
                );
        }
    }
}
