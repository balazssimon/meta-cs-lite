using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.Languages.MetaCompiler.Symbols.Impl
{
    using __Model = MetaDslx.Modeling.Model;
    using __IModelObject = MetaDslx.Modeling.IModelObject;
    using __ISymbol = Microsoft.CodeAnalysis.ISymbol;

    public class ParserRuleSymbolImpl : ParserRuleSymbol
    {
        public ParserRuleSymbolImpl(Symbol? container, Compilation? compilation = null, MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, global::MetaDslx.CodeAnalysis.MetaType returnType = default, global::System.Collections.Immutable.ImmutableArray<PAlternativeSymbol> alternatives = default, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility = default, bool isStatic = default, bool isExtern = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments = default, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes)
        {
        }

        protected override MetaType Compute_ReturnType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var returnType = base.Compute_ReturnType(diagnostics, cancellationToken);
            if (returnType.IsDefaultOrNull)
            {
                diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, Location, $"Could not determine the return type of the rule '{Name}'"));
            }
            return returnType;
        }

        protected override void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            base.CompletePart_Validate(diagnostics, cancellationToken);
            var returnType = this.ReturnType;
            if (!returnType.IsDefaultOrNull)
            {
                foreach (var alt in this.Alternatives)
                {
                    if (!returnType.IsAssignableFrom(alt.ReturnType) && returnType.SpecialType != SpecialType.MetaDslx_CodeAnalysis_MetaSymbol)
                    {
                        diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_IncompatibleAltReturnType, alt.Location, alt.ReturnType, alt.Name, this.ReturnType, this.Name));
                    }
                }
            }
        }
    }
}