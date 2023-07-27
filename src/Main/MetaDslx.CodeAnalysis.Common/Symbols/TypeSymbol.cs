using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class TypeSymbol : DeclaredSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_TypeParameters = new CompletionPart(nameof(StartComputingProperty_TypeParameters));
            public static readonly CompletionPart FinishComputingProperty_TypeParameters = new CompletionPart(nameof(FinishComputingProperty_TypeParameters));
            public static readonly CompletionPart StartComputingProperty_BaseTypes = new CompletionPart(nameof(StartComputingProperty_BaseTypes));
            public static readonly CompletionPart FinishComputingProperty_BaseTypes = new CompletionPart(nameof(FinishComputingProperty_BaseTypes));
            public static readonly CompletionPart StartComputingProperty_TypeArguments = DeclaredSymbol.CompletionParts.StartComputingProperty_TypeArguments;
            public static readonly CompletionPart FinishComputingProperty_TypeArguments = DeclaredSymbol.CompletionParts.FinishComputingProperty_TypeArguments;
            public static readonly CompletionPart StartComputingProperty_Imports = DeclaredSymbol.CompletionParts.StartComputingProperty_Imports;
            public static readonly CompletionPart FinishComputingProperty_Imports = DeclaredSymbol.CompletionParts.FinishComputingProperty_Imports;
            public static readonly CompletionPart StartComputingProperty_Members = DeclaredSymbol.CompletionParts.StartComputingProperty_Members;
            public static readonly CompletionPart FinishComputingProperty_Members = DeclaredSymbol.CompletionParts.FinishComputingProperty_Members;
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    CompletionGraph.StartInitializing, CompletionGraph.FinishInitializing, 
                    CompletionGraph.StartCreatingContainedSymbols, CompletionGraph.FinishCreatingContainedSymbols,
                    StartComputingProperty_TypeParameters, FinishComputingProperty_TypeParameters, 
                    StartComputingProperty_BaseTypes, FinishComputingProperty_BaseTypes, 
                    StartComputingProperty_TypeArguments, FinishComputingProperty_TypeArguments, 
                    StartComputingProperty_Imports, FinishComputingProperty_Imports, 
                    StartComputingProperty_Members, FinishComputingProperty_Members, 
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes, 
                    CompletionGraph.StartComputingNonSymbolProperties, CompletionGraph.FinishComputingNonSymbolProperties, 
                    CompletionGraph.ContainedSymbolsCompleted, 
                    CompletionGraph.StartValidatingSymbol, CompletionGraph.FinishValidatingSymbol);
        }

        private static ConditionalWeakTable<TypeSymbol, object> s_typeParameters = new ConditionalWeakTable<TypeSymbol, object>();
        private static ConditionalWeakTable<TypeSymbol, BaseTypeInfo> s_baseTypeInfos = new ConditionalWeakTable<TypeSymbol, BaseTypeInfo>();

        protected TypeSymbol(Symbol container)
            : base(container)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [ModelProperty]
        public virtual bool IsReferenceType => false;

        [ModelProperty]
        public virtual bool IsValueType => false;

        [ModelProperty]
        public ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_TypeParameters, null, default);
                if (s_typeParameters.TryGetValue(this, out var param)) return (ImmutableArray<TypeParameterSymbol>)param;
                else return ImmutableArray<TypeParameterSymbol>.Empty;
            }
        }

        [ModelProperty]
        public ImmutableArray<TypeSymbol> BaseTypes
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_BaseTypes, null, default);
                if (s_baseTypeInfos.TryGetValue(this, out var info)) return info.BaseTypes;
                else return ImmutableArray<TypeSymbol>.Empty;
            }
        }

        public ImmutableArray<TypeSymbol> AllBaseTypes
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_BaseTypes, null, default);
                if (s_baseTypeInfos.TryGetValue(this, out var info)) return info.AllBaseTypes;
                else return ImmutableArray<TypeSymbol>.Empty;
            }
        }

        /// <summary>
        /// Returns true if this type derives from a given type.
        /// </summary>
        public bool IsDerivedFrom(TypeSymbol type, TypeEqualityComparer comparison)
        {
            Debug.Assert(type is not null);
            if (object.ReferenceEquals(this, type)) return false;
            return AllBaseTypes.Any(t => comparison.Equals(t, type));
        }

        /// <summary>
        /// Returns true if this type is equal or derives from a given type.
        /// </summary>
        public bool IsEqualToOrDerivedFrom(TypeSymbol type, TypeEqualityComparer comparison)
        {
            return comparison.Equals(this, type) || this.IsDerivedFrom(type, comparison);
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_TypeParameters || incompletePart == CompletionParts.FinishComputingProperty_TypeParameters)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_TypeParameters))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var typeParameters = CompleteProperty_TypeParameters(diagnostics, cancellationToken);
                    if (!typeParameters.IsDefaultOrEmpty)
                    {
                        s_typeParameters.Add(this, typeParameters);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_TypeParameters);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_BaseTypes || incompletePart == CompletionParts.FinishComputingProperty_BaseTypes)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_BaseTypes))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var baseTypes = CompleteProperty_BaseTypes(diagnostics, cancellationToken);
                    if (!baseTypes.IsDefaultOrEmpty)
                    {
                        s_baseTypeInfos.Add(this, new BaseTypeInfo(this, baseTypes));
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_BaseTypes);
                }
                return true;
            }
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected virtual ImmutableArray<TypeParameterSymbol> CompleteProperty_TypeParameters(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<TypeParameterSymbol>.Empty;
        }

        protected virtual ImmutableArray<TypeSymbol> CompleteProperty_BaseTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<TypeSymbol>.Empty;
        }

    }
}
