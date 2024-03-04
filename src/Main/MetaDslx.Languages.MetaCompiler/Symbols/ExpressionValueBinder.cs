using MetaDslx.Languages.MetaCompiler.Compiler.Syntax;
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
using MetaDslx.Languages.MetaModel.Model;

namespace MetaDslx.Languages.MetaCompiler.Symbols
{
    internal class ExpressionValueBinder : UseBinder
    {
        private ExpressionSymbol? _containingExpression;
        private MetaType _modelObjectType;
        private MetaType _expectedType;

        public ExpressionValueBinder()
            : base(types: ImmutableArray.Create(typeof(MetaSymbol)))
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
                if (_expectedType.IsDefault)
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
            var containingAlt = expr.GetOutermostContainingSymbol<PAlternativeSymbol>();
            if (containingAlt is not null)
            {
                _modelObjectType = MetaType.FromTypeSymbol(containingAlt.ReturnType.AsTypeSymbol(Compilation));
            }
            if (result.IsDefaultOrNull) return result;
            if (result.TryGetCoreType(out var coreType, diagnostics, cancellationToken) && !coreType.IsDefaultOrNull)
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
            if (context.Qualifier is null)
            {
                var expectedType = ExpectedType;
                if (expectedType.IsEnum)
                {
                    context.Qualifier = expectedType.AsTypeSymbol(this.Compilation);
                }
                else if (expectedType.OriginalModelObject is MetaEnum)
                {
                    context.Qualifier = expectedType.AsTypeSymbol(this.Compilation);
                }
                if (expectedType.FullName == typeof(ModelProperty).FullName)
                {
                    context.Qualifier = _modelObjectType.AsTypeSymbol(this.Compilation);
                }
            }
            base.AdjustFinalLookupContext(context);
        }

        
    }
}
