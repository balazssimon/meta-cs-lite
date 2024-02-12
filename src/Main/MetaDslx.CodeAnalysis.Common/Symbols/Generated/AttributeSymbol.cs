namespace MetaDslx.CodeAnalysis.Symbols
{
public interface AttributeSymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        TypeSymbol AttributeClass { get; }

        public static class CompletionParts
        {
            public static readonly CompletionPart Start_AttributeClass = new CompletionPart(nameof(Start_AttributeClass));
            public static readonly CompletionPart Finish_AttributeClass = new CompletionPart(nameof(Finish_AttributeClass));
            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    Start_AttributeClass, Finish_AttributeClass
                );
        }
    }
}
