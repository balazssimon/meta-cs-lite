using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public partial class TypeSymbol
    {
        public static new class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_Attributes = MetaDslx.CodeAnalysis.Symbols.Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = MetaDslx.CodeAnalysis.Symbols.Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionPart StartComputingProperty_TypeParameters = MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol.CompletionParts.StartComputingProperty_TypeParameters;
            public static readonly CompletionPart FinishComputingProperty_TypeParameters = MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol.CompletionParts.FinishComputingProperty_TypeParameters;
            public static readonly CompletionPart StartComputingProperty_DeclaredAccessibility = MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol.CompletionParts.StartComputingProperty_DeclaredAccessibility;
            public static readonly CompletionPart FinishComputingProperty_DeclaredAccessibility = MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol.CompletionParts.FinishComputingProperty_DeclaredAccessibility;
            public static readonly CompletionPart StartComputingProperty_IsExtern = MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol.CompletionParts.StartComputingProperty_IsExtern;
            public static readonly CompletionPart FinishComputingProperty_IsExtern = MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol.CompletionParts.FinishComputingProperty_IsExtern;
            public static readonly CompletionPart StartComputingProperty_Members = MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol.CompletionParts.StartComputingProperty_Members;
            public static readonly CompletionPart FinishComputingProperty_Members = MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol.CompletionParts.FinishComputingProperty_Members;
            public static readonly CompletionPart StartComputingProperty_BaseTypes = new CompletionPart(nameof(StartComputingProperty_BaseTypes));
            public static readonly CompletionPart FinishComputingProperty_BaseTypes = new CompletionPart(nameof(FinishComputingProperty_BaseTypes));
            public static readonly ImmutableHashSet<CompletionPart> AllWithLocation = CompletionPart.Combine(CompletionGraph.StartInitializing, CompletionGraph.FinishInitializing, CompletionGraph.StartCreatingChildren, CompletionGraph.FinishCreatingChildren, StartComputingProperty_Attributes, FinishComputingProperty_Attributes, StartComputingProperty_TypeParameters, FinishComputingProperty_TypeParameters, StartComputingProperty_DeclaredAccessibility, FinishComputingProperty_DeclaredAccessibility, StartComputingProperty_IsExtern, FinishComputingProperty_IsExtern, StartComputingProperty_Members, FinishComputingProperty_Members, StartComputingProperty_BaseTypes, FinishComputingProperty_BaseTypes, CompletionGraph.StartComputingNonSymbolProperties, CompletionGraph.FinishComputingNonSymbolProperties);
            public static readonly ImmutableHashSet<CompletionPart> All = CompletionPart.Combine(CompletionGraph.StartInitializing, CompletionGraph.FinishInitializing, CompletionGraph.StartCreatingChildren, CompletionGraph.FinishCreatingChildren, StartComputingProperty_Attributes, FinishComputingProperty_Attributes, StartComputingProperty_TypeParameters, FinishComputingProperty_TypeParameters, StartComputingProperty_DeclaredAccessibility, FinishComputingProperty_DeclaredAccessibility, StartComputingProperty_IsExtern, FinishComputingProperty_IsExtern, StartComputingProperty_Members, FinishComputingProperty_Members, StartComputingProperty_BaseTypes, FinishComputingProperty_BaseTypes, CompletionGraph.StartComputingNonSymbolProperties, CompletionGraph.FinishComputingNonSymbolProperties, CompletionGraph.ChildrenCompleted, CompletionGraph.StartValidatingSymbol, CompletionGraph.FinishValidatingSymbol);
            public static readonly CompletionGraph CompletionGraph = CompletionGraph.FromCompletionParts(CompletionGraph.StartInitializing, CompletionGraph.FinishInitializing, CompletionGraph.StartCreatingChildren, CompletionGraph.FinishCreatingChildren, StartComputingProperty_Attributes, FinishComputingProperty_Attributes, StartComputingProperty_TypeParameters, FinishComputingProperty_TypeParameters, StartComputingProperty_DeclaredAccessibility, FinishComputingProperty_DeclaredAccessibility, StartComputingProperty_IsExtern, FinishComputingProperty_IsExtern, StartComputingProperty_Members, FinishComputingProperty_Members, StartComputingProperty_BaseTypes, FinishComputingProperty_BaseTypes, CompletionGraph.StartComputingNonSymbolProperties, CompletionGraph.FinishComputingNonSymbolProperties, CompletionGraph.ChildrenCompleted, CompletionGraph.StartValidatingSymbol, CompletionGraph.FinishValidatingSymbol);
        }
    }
}
