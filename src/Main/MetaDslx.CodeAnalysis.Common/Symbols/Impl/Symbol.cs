namespace MetaDslx.CodeAnalysis.Symbols
{
    public interface Symbol
    {
        global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> Attributes { get; }

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
