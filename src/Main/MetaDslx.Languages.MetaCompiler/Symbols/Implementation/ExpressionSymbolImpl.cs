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

    public class ExpressionSymbolImpl : ExpressionSymbol
    {
        public ExpressionSymbolImpl(Symbol? container, Compilation? compilation, MergedDeclaration? declaration, __IModelObject? modelObject, __ISymbol? csharpSymbol, ErrorSymbolInfo? errorInfo)
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
        }

        protected override AnnotationArgumentSymbol? Compute_ContainingAnnotationArgumentSymbol(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var container = this.ContainingSymbol;
            while (container is not null)
            {
                if (container is AnnotationArgumentSymbol aas) return aas;
                container = container.ContainingSymbol;
            }
            return null;
        }

        protected override PAlternativeSymbol? Compute_ContainingPAlternativeSymbol(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var container = this.ContainingSymbol;
            while (container is not null)
            {
                if (container is PAlternativeSymbol pas) return pas;
                container = container.ContainingSymbol;
            }
            return null;
        }

        protected override MetaType Compute_ExpectedType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var alt = this.ContainingPAlternativeSymbol;
            if (alt is not null)
            {
                return alt.ExpectedType;
            }
            var arg = this.ContainingAnnotationArgumentSymbol;
            if (arg is not null)
            {
                return arg.ParameterType;
            }
            return default;
        }

        protected override (MetaSymbol Value, ImmutableArray<MetaSymbol> Values) Compute_Value(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (this.ModelObjectType == typeof(ArrayExpression))
            {
                var results = ArrayBuilder<MetaSymbol>.GetInstance();
                foreach (var exprSymbol in this.ContainedSymbols.OfType<ExpressionSymbol>())
                {
                    foreach (var value in exprSymbol.Values)
                    {
                        results.Add(value);
                    }
                }
                var values = results.ToImmutableAndFree();
                return (values.FirstOrDefault(), values);
            }
            else
            {
                var values = this.ContainingModule.SymbolFactory.GetSymbolPropertyValues<MetaSymbol>(this, nameof(Value), diagnostics, cancellationToken);
                return (values.FirstOrDefault(), values);
            }
        }

        protected override void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            base.CompletePart_Validate(diagnostics, cancellationToken);
            if (!this.Value.IsNull)
            {
                var valueType = this.Value.Type;
                if (!valueType.IsDefaultOrNull)
                {
                    var expectedType = this.ExpectedType;
                    if (expectedType.TryGetCoreType(out var coreType, diagnostics, cancellationToken))
                    {
                        if (!valueType.IsAssignableTo(coreType))
                        {
                            if (coreType.SpecialType == SpecialType.MetaDslx_Modeling_ModelProperty && valueType.IsAssignableTo(typeof(DeclarationSymbol)))
                            {
                                // nop
                            }
                            else
                            {
                                diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_IncompatibleExpressionType, this.Location, this.DeclaringSyntaxReference, valueType, coreType));
                            }
                        }
                    }
                }
                else
                {
                    diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, this.Location, $"Could not determine the type of the value '{this.DeclaringSyntaxReference}'"));
                }
            }
        }

    }
}
