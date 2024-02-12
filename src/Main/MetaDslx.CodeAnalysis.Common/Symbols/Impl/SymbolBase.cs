namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __MergedDeclaration = global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;
    using __Symbol = global::MetaDslx.CodeAnalysis.Symbols.Symbol;
    using __ErrorSymbolInfo = global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;
    using __ModelProperty = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;
    using __CompletionGraph = global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;
    using __CompletionPart = global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;
    using __DiagnosticBag = global::MetaDslx.CodeAnalysis.DiagnosticBag;
    using __SourceLocation = global::MetaDslx.CodeAnalysis.SourceLocation;
    using __CancellationToken = global::System.Threading.CancellationToken;

    internal abstract class SymbolBase : Symbol
    {
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol>> s_Attributes = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol>>();

        protected SymbolBase(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
        {
        }

        protected SymbolBase(__Symbol container, __IModelObject modelObject) 
        {
        }

        protected SymbolBase(__Symbol container, __ISymbol csharpSymbol) 
        {
        }

        protected SymbolBase(__Symbol container, __ErrorSymbolInfo errorInfo) 
        {
        }

        protected abstract __CompletionGraph CompletionGraph { get; }

        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> Attributes
        {
            get
            {
                this.ForceComplete(SymbolSymbol.CompletionParts.Finish_Attributes, null, default);
                if (s_Attributes.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<AttributeSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<AttributeSymbol>.Empty;
            }
        }

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == SymbolSymbol.CompletionParts.Start_Attributes || incompletePart == SymbolSymbol.CompletionParts.Finish_Attributes)
            {
                if (NotePartComplete(SymbolSymbol.CompletionParts.Start_Attributes))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Attributes(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_Attributes.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(SymbolSymbol.CompletionParts.Finish_Attributes);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> Complete_Attributes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<AttributeSymbol>.Empty;
        }
    }
}
