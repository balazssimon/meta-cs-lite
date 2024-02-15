namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ModelProperty = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;

public interface AttributeSymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        [__ModelProperty]
        TypeSymbol AttributeClass { get; }


        public static new class CompletionParts
        {
            public static readonly CompletionPart Start_AttributeClass = new CompletionPart(nameof(Start_AttributeClass));
            public static readonly CompletionPart Finish_AttributeClass = new CompletionPart(nameof(Finish_AttributeClass));
            public static readonly CompletionPart Start_Attribute = new CompletionPart(nameof(Start_Attribute));
            public static readonly CompletionPart Finish_Attribute = new CompletionPart(nameof(Finish_Attribute));

            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    Start_AttributeClass, Finish_AttributeClass,
                    Start_Attribute, Finish_Attribute
                );
        }
    }
}
