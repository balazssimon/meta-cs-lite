using MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Binding.Lookup;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    internal class ExpressionValueBinder : UseBinder
    {
        private ExpressionSymbol? _containingExpression;
        private MetaType _expectedType;

        public ExpressionValueBinder()
        {
            
        }

        public ExpressionSymbol? ContainingExpression 
        {
            get
            {
                if (_containingExpression is null)
                {
                    Interlocked.CompareExchange(ref _containingExpression, this.ContainingDefinedSymbols.OfType<ExpressionSymbol>().FirstOrDefault(), null);
                }
                return _containingExpression;
            }
        }

        public MetaType ExpectedType
        {
            get
            {
                if (_expectedType.IsNull)
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var expectedType = GetExpectedType(diagnostics, cancellationToken: default);
                    this.AddDiagnostics(diagnostics);
                    diagnostics.Free();
                    _expectedType.InterlockedInitialize(expectedType);
                }
                return _expectedType;
            }
        }

        private MetaType GetExpectedType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var expr = this.ContainingExpression;
            if (expr is null) return default;
            MetaType result = default;
            var arg = expr.GetInnermostContainingSymbol<AnnotationArgumentSymbol>();
            if (arg is not null)
            {
                result = arg.ParameterType;
            }
            else
            {
                var alt = expr.GetInnermostContainingSymbol<PAlternativeSymbol>();
                if (alt is not null)
                {
                    result = alt.ExpectedType;
                }
                else
                {
                    var token = expr.GetInnermostContainingSymbol<TokenSymbol>();
                    if (token is not null)
                    {
                        result = token.ExpectedType;
                    }
                    else
                    {
                        diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, this.Location, $"Could not determine the expected type of the expression"));
                    }
                }
            }
            if (result.IsNull) return default;
            if (result.TryGetCoreType(out var coreType, diagnostics, cancellationToken) && !coreType.IsNull)
            {
                return coreType;
            }
            else
            {
                return default;
            }
        }

        protected override void AdjustFinalLookupContext(LookupContext context)
        {
            var expectedType = ExpectedType;
            if (expectedType.IsEnum && context.Qualifier is null)
            {
                context.Qualifier = expectedType.AsTypeSymbol(this.Compilation);
            }
            base.AdjustFinalLookupContext(context);
        }

    }
}
