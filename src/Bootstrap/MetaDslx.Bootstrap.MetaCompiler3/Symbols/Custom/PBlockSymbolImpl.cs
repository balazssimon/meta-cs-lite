using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.Bootstrap.MetaCompiler3.Symbols
{
    public partial class PBlockSymbol
    {
        public abstract PElementSymbol? ContainingElementSymbol { get; }
    }
}

namespace MetaDslx.Bootstrap.MetaCompiler3.Symbols.Impl
{
    using __Model = MetaDslx.Modeling.Model;
    using __IModelObject = MetaDslx.Modeling.IModelObject;
    using __ISymbol = Microsoft.CodeAnalysis.ISymbol;

    public class PBlockSymbolImpl : PBlockSymbol
    {
        public PBlockSymbolImpl(Symbol? container, Compilation? compilation = null, MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, global::System.Collections.Immutable.ImmutableArray<PAlternativeSymbol> alternatives = default, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility = default, bool isStatic = default, bool isExtern = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments = default, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes)
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
