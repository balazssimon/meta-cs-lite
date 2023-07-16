using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class MemberSymbol
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
            public static readonly CompletionPart StartComputingProperty_IsStatic = new CompletionPart(nameof(StartComputingProperty_IsStatic));
            public static readonly CompletionPart FinishComputingProperty_IsStatic = new CompletionPart(nameof(FinishComputingProperty_IsStatic));
            public static readonly CompletionPart StartComputingProperty_IsVirtual = new CompletionPart(nameof(StartComputingProperty_IsVirtual));
            public static readonly CompletionPart FinishComputingProperty_IsVirtual = new CompletionPart(nameof(FinishComputingProperty_IsVirtual));
            public static readonly CompletionPart StartComputingProperty_IsOverride = new CompletionPart(nameof(StartComputingProperty_IsOverride));
            public static readonly CompletionPart FinishComputingProperty_IsOverride = new CompletionPart(nameof(FinishComputingProperty_IsOverride));
            public static readonly CompletionPart StartComputingProperty_IsAbstract = new CompletionPart(nameof(StartComputingProperty_IsAbstract));
            public static readonly CompletionPart FinishComputingProperty_IsAbstract = new CompletionPart(nameof(FinishComputingProperty_IsAbstract));
            public static readonly CompletionPart StartComputingProperty_IsSealed = new CompletionPart(nameof(StartComputingProperty_IsSealed));
            public static readonly CompletionPart FinishComputingProperty_IsSealed = new CompletionPart(nameof(FinishComputingProperty_IsSealed));
            public static readonly ImmutableHashSet<CompletionPart> AllWithLocation = CompletionPart.Combine(CompletionGraph.StartInitializing, CompletionGraph.FinishInitializing, CompletionGraph.StartCreatingChildren, CompletionGraph.FinishCreatingChildren, StartComputingProperty_Attributes, FinishComputingProperty_Attributes, StartComputingProperty_TypeParameters, FinishComputingProperty_TypeParameters, StartComputingProperty_DeclaredAccessibility, FinishComputingProperty_DeclaredAccessibility, StartComputingProperty_IsExtern, FinishComputingProperty_IsExtern, StartComputingProperty_Members, FinishComputingProperty_Members, StartComputingProperty_IsStatic, FinishComputingProperty_IsStatic, StartComputingProperty_IsVirtual, FinishComputingProperty_IsVirtual, StartComputingProperty_IsOverride, FinishComputingProperty_IsOverride, StartComputingProperty_IsAbstract, FinishComputingProperty_IsAbstract, StartComputingProperty_IsSealed, FinishComputingProperty_IsSealed, CompletionGraph.StartComputingNonSymbolProperties, CompletionGraph.FinishComputingNonSymbolProperties);
            public static readonly ImmutableHashSet<CompletionPart> All = CompletionPart.Combine(CompletionGraph.StartInitializing, CompletionGraph.FinishInitializing, CompletionGraph.StartCreatingChildren, CompletionGraph.FinishCreatingChildren, StartComputingProperty_Attributes, FinishComputingProperty_Attributes, StartComputingProperty_TypeParameters, FinishComputingProperty_TypeParameters, StartComputingProperty_DeclaredAccessibility, FinishComputingProperty_DeclaredAccessibility, StartComputingProperty_IsExtern, FinishComputingProperty_IsExtern, StartComputingProperty_Members, FinishComputingProperty_Members, StartComputingProperty_IsStatic, FinishComputingProperty_IsStatic, StartComputingProperty_IsVirtual, FinishComputingProperty_IsVirtual, StartComputingProperty_IsOverride, FinishComputingProperty_IsOverride, StartComputingProperty_IsAbstract, FinishComputingProperty_IsAbstract, StartComputingProperty_IsSealed, FinishComputingProperty_IsSealed, CompletionGraph.StartComputingNonSymbolProperties, CompletionGraph.FinishComputingNonSymbolProperties, CompletionGraph.ChildrenCompleted, CompletionGraph.StartValidatingSymbol, CompletionGraph.FinishValidatingSymbol);
            public static readonly CompletionGraph CompletionGraph = CompletionGraph.FromCompletionParts(CompletionGraph.StartInitializing, CompletionGraph.FinishInitializing, CompletionGraph.StartCreatingChildren, CompletionGraph.FinishCreatingChildren, StartComputingProperty_Attributes, FinishComputingProperty_Attributes, StartComputingProperty_TypeParameters, FinishComputingProperty_TypeParameters, StartComputingProperty_DeclaredAccessibility, FinishComputingProperty_DeclaredAccessibility, StartComputingProperty_IsExtern, FinishComputingProperty_IsExtern, StartComputingProperty_Members, FinishComputingProperty_Members, StartComputingProperty_IsStatic, FinishComputingProperty_IsStatic, StartComputingProperty_IsVirtual, FinishComputingProperty_IsVirtual, StartComputingProperty_IsOverride, FinishComputingProperty_IsOverride, StartComputingProperty_IsAbstract, FinishComputingProperty_IsAbstract, StartComputingProperty_IsSealed, FinishComputingProperty_IsSealed, CompletionGraph.StartComputingNonSymbolProperties, CompletionGraph.FinishComputingNonSymbolProperties, CompletionGraph.ChildrenCompleted, CompletionGraph.StartValidatingSymbol, CompletionGraph.FinishValidatingSymbol);
        }
    }
}
