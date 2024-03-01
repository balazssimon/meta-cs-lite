using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.Languages.MetaCompiler.Symbols
{
    public partial class PBlockSymbol
    {
        public abstract PElementSymbol? ContainingElementSymbol { get; }
    }
}

namespace MetaDslx.Languages.MetaCompiler.Symbols.Impl
{
    using __Model = MetaDslx.Modeling.Model;
    using __IModelObject = MetaDslx.Modeling.IModelObject;
    using __ISymbol = Microsoft.CodeAnalysis.ISymbol;

    public class PBlockSymbolImpl : PBlockSymbol
    {
        public PBlockSymbolImpl(Symbol? container, Compilation? compilation, MergedDeclaration? declaration, __IModelObject? modelObject, __ISymbol? csharpSymbol, ErrorSymbolInfo? errorInfo)
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
        }

        public override PElementSymbol? ContainingElementSymbol => this.ContainingSymbol as PElementSymbol;

        protected override MetaType Compute_ExpectedType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.ContainingElementSymbol?.ExpectedType ?? default;
        }

        protected override void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            base.CompletePart_Validate(diagnostics, cancellationToken);
            var expectedType = this.ExpectedType;
            if (!expectedType.IsDefaultOrNull && expectedType.SpecialType != SpecialType.MetaDslx_CodeAnalysis_MetaSymbol)
            {
                foreach (var alt in Alternatives)
                {
                    if (alt.ReturnValue is null)
                    {
                        diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_AltMustHaveReturnValue, alt.Location, expectedType));
                    }
                }
            }
        }

    }
}
