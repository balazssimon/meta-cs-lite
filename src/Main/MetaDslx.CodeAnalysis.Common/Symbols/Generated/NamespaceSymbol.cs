namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ModelProperty = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;

public interface NamespaceSymbol: DeclarationSymbol
    {
        [__ModelProperty]
        global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent Extent { get; }
        [__ModelProperty]
        bool IsGlobalNamespace { get; }
        [__ModelProperty]
        global::MetaDslx.CodeAnalysis.NamespaceKind NamespaceKind { get; }
        [__ModelProperty]
        global::MetaDslx.CodeAnalysis.Compilation? ContainingCompilation { get; }
        [__ModelProperty]
        global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> ConstituentNamespaces { get; }
        [__ModelProperty]
        global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> NamespaceMembers { get; }

        NamespaceSymbol? LookupNestedNamespace(global::System.Collections.Immutable.ImmutableArray<string> names);
        NamespaceSymbol? LookupNestedNamespace(string name);

        public static new class CompletionParts
        {
            public static readonly CompletionPart Start_Extent = new CompletionPart(nameof(Start_Extent));
            public static readonly CompletionPart Finish_Extent = new CompletionPart(nameof(Finish_Extent));
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
            public static readonly CompletionPart Start_IsGlobalNamespace = new CompletionPart(nameof(Start_IsGlobalNamespace));
            public static readonly CompletionPart Finish_IsGlobalNamespace = new CompletionPart(nameof(Finish_IsGlobalNamespace));
            public static readonly CompletionPart Start_NamespaceKind = new CompletionPart(nameof(Start_NamespaceKind));
            public static readonly CompletionPart Finish_NamespaceKind = new CompletionPart(nameof(Finish_NamespaceKind));
            public static readonly CompletionPart Start_ContainingCompilation = new CompletionPart(nameof(Start_ContainingCompilation));
            public static readonly CompletionPart Finish_ContainingCompilation = new CompletionPart(nameof(Finish_ContainingCompilation));
            public static readonly CompletionPart Start_ConstituentNamespaces = new CompletionPart(nameof(Start_ConstituentNamespaces));
            public static readonly CompletionPart Finish_ConstituentNamespaces = new CompletionPart(nameof(Finish_ConstituentNamespaces));
            public static readonly CompletionPart Start_NamespaceMembers = new CompletionPart(nameof(Start_NamespaceMembers));
            public static readonly CompletionPart Finish_NamespaceMembers = new CompletionPart(nameof(Finish_NamespaceMembers));
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
                    , Start_Extent, Finish_Extent
                    , Start_DeclaredAccessibility, Finish_DeclaredAccessibility
                    , Start_IsStatic, Finish_IsStatic
                    , Start_IsExtern, Finish_IsExtern
                    , Start_TypeArguments, Finish_TypeArguments
                    , Start_Imports, Finish_Imports
                    , Start_IsGlobalNamespace, Finish_IsGlobalNamespace
                    , Start_NamespaceKind, Finish_NamespaceKind
                    , Start_ContainingCompilation, Finish_ContainingCompilation
                    , Start_ConstituentNamespaces, Finish_ConstituentNamespaces
                    , Start_NamespaceMembers, Finish_NamespaceMembers
                    , Start_MemberNames, Finish_MemberNames
                    , Start_Members, Finish_Members
                    , Start_TypeMembers, Finish_TypeMembers
                );
        }
    }
}
