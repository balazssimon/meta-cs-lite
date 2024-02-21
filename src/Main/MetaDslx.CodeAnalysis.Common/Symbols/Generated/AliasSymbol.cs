namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ModelProperty = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;

public interface AliasSymbol: DeclarationSymbol
    {
        [__ModelProperty]
        Symbol Target { get; }


        public static new class CompletionParts
        {
            public static readonly CompletionPart Start_Target = new CompletionPart(nameof(Start_Target));
            public static readonly CompletionPart Finish_Target = new CompletionPart(nameof(Finish_Target));
            public static readonly CompletionPart Start_DeclaredAccessibility = new CompletionPart(nameof(Start_DeclaredAccessibility));
            public static readonly CompletionPart Finish_DeclaredAccessibility = new CompletionPart(nameof(Finish_DeclaredAccessibility));
            public static readonly CompletionPart Start_IsStatic = new CompletionPart(nameof(Start_IsStatic));
            public static readonly CompletionPart Finish_IsStatic = new CompletionPart(nameof(Finish_IsStatic));
            public static readonly CompletionPart Start_IsExtern = new CompletionPart(nameof(Start_IsExtern));
            public static readonly CompletionPart Finish_IsExtern = new CompletionPart(nameof(Finish_IsExtern));
            public static readonly CompletionPart Start_TypeArguments = new CompletionPart(nameof(Start_TypeArguments));
            public static readonly CompletionPart Finish_TypeArguments = new CompletionPart(nameof(Finish_TypeArguments));
            public static readonly CompletionPart Start_Imports = new CompletionPart(nameof(Start_Imports));
            public static readonly CompletionPart Finish_Imports = new CompletionPart(nameof(Finish_Imports));
            public static readonly CompletionPart Start_MemberNames = new CompletionPart(nameof(Start_MemberNames));
            public static readonly CompletionPart Finish_MemberNames = new CompletionPart(nameof(Finish_MemberNames));
            public static readonly CompletionPart Start_Members = new CompletionPart(nameof(Start_Members));
            public static readonly CompletionPart Finish_Members = new CompletionPart(nameof(Finish_Members));
            public static readonly CompletionPart Start_TypeMembers = new CompletionPart(nameof(Start_TypeMembers));
            public static readonly CompletionPart Finish_TypeMembers = new CompletionPart(nameof(Finish_TypeMembers));
            public static readonly CompletionPart Start_Attribute = new CompletionPart(nameof(Start_Attribute));
            public static readonly CompletionPart Finish_Attribute = new CompletionPart(nameof(Finish_Attribute));

            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    Start_Attribute, Finish_Attribute
                    , Start_Target, Finish_Target
                    , Start_DeclaredAccessibility, Finish_DeclaredAccessibility
                    , Start_IsStatic, Finish_IsStatic
                    , Start_IsExtern, Finish_IsExtern
                    , Start_TypeArguments, Finish_TypeArguments
                    , Start_Imports, Finish_Imports
                    , Start_MemberNames, Finish_MemberNames
                    , Start_Members, Finish_Members
                    , Start_TypeMembers, Finish_TypeMembers
                );
        }
    }
}
