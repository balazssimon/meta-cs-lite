using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Languages.MetaCompiler.Model;

namespace MetaDslx.Languages.MetaCompiler.Symbols.Implementation
{
    using __Model = MetaDslx.Modeling.Model;
    using __IModelObject = MetaDslx.Modeling.IModelObject;
    using __ISymbol = Microsoft.CodeAnalysis.ISymbol;

    public class PAlternativeSymbolImpl : PAlternativeSymbol
    {
        public PAlternativeSymbolImpl(Symbol? container, Compilation? compilation, MergedDeclaration? declaration, __IModelObject? modelObject, __ISymbol? csharpSymbol, ErrorSymbolInfo? errorInfo)
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
        }

        protected override ImmutableArray<PElementSymbol> Compute_AllSimpleElements(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var builder = ArrayBuilder<PElementSymbol>.GetInstance();
            foreach (var elem in Elements)
            {
                if (elem.Value.OriginalSymbol is PBlockSymbol pbs)
                {
                    foreach (var balt in pbs.Alternatives)
                    {
                        builder.AddRange(balt.AllSimpleElements);
                    }
                }
                else
                {
                    builder.Add(elem);
                }
            }
            builder.AddRange(Elements);
            return builder.ToImmutableAndFree();
        }

        protected override ParserRuleSymbol? Compute_ContainingParserRuleSymbol(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.ContainingSymbol as ParserRuleSymbol;
        }

        protected override PBlockSymbol? Compute_ContainingPBlockSymbol(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.ContainingSymbol as PBlockSymbol;
        }

        protected override MetaType Compute_ExpectedType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (!this.ReturnType.IsDefaultOrNull)
            {
                return this.ReturnType;
            }
            var block = this.ContainingPBlockSymbol;
            if (block is not null)
            {
                return block.ExpectedType;
            }
            diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, Location, $"Could not determine the expected type of the alternative '{Name}'"));
            return default;
        }

        protected override MetaType Compute_ReturnType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var returnType = this.SymbolFactory.GetSymbolPropertyValue<MetaType>(this, nameof(ReturnType), diagnostics, cancellationToken);
            if (returnType.IsDefaultOrNull)
            {
                if (this.Elements.Length == 1)
                {
                    var elem = this.Elements[0];
                    if (elem is not null && !elem.IsNamedElement && elem.Value.OriginalSymbol is PReferenceSymbol pref && !pref.Rule.IsDefaultOrNull)
                    {
                        if (pref.Rule.OriginalSymbol is ParserRuleSymbol pr && pr.ReturnType.SpecialType != SpecialType.System_Void)
                        {
                            return pr.ReturnType;
                        }
                    }
                }
                var rule = this.ContainingParserRuleSymbol;
                if (rule is not null)
                {
                    returnType = rule.ReturnType;
                }
            }
            var alt = ModelObject as Alternative;
            if (alt is not null) alt.ReturnType = returnType;
            return returnType;
        }
    }
}
