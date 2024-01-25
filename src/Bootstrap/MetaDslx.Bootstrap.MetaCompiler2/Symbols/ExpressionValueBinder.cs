using MetaDslx.Bootstrap.MetaCompiler2.Compiler.Syntax;
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

namespace MetaDslx.Bootstrap.MetaCompiler2.Symbols
{
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;
    using IParameterSymbol = Microsoft.CodeAnalysis.IParameterSymbol;

    internal class ExpressionValueBinder : ValueBinder
    {
        private ExpressionSymbol? _containingExpression;
        private PAlternativeSymbol? _containingPAlternative;
        private AnnotationArgumentSymbol? _containingAnnotationArgument;
        private MetaType _expectedType;

        public SingleExpressionBlock1Syntax? Syntax => base.Syntax.AsNode() as SingleExpressionBlock1Syntax;
        public SingleExpressionBlock1Alt2Syntax? TokensSyntax => this.Syntax as SingleExpressionBlock1Alt2Syntax;
        public SingleExpressionBlock1Alt3Syntax? QualifierSyntax => this.Syntax as SingleExpressionBlock1Alt3Syntax;

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

        protected override ImmutableArray<object?> BindValues(CancellationToken cancellationToken = default)
        {
            var diagnostics = DiagnosticBag.GetInstance();
            var expectedType = GetExpectedType(diagnostics, cancellationToken);
            var result = ArrayBuilder<object?>.GetInstance();
            if (ComputeValue(expectedType, out var value, diagnostics, cancellationToken))
            {
                result.Add(value);
            }
            else
            {
                result.Add(null);
            }
            this.AddDiagnostics(diagnostics);
            diagnostics.Free();
            return result.ToImmutableAndFree();
        }

        protected override bool ComputeValue(MetaType expectedType, out object? value, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (expectedType.IsEnum)
            {
                if (expectedType.TryGetEnumValue(this.RawValue, out var enumLiteral, diagnostics, cancellationToken))
                {
                    value = enumLiteral;
                    return true;
                }
            }
            if (expectedType.SpecialType == CodeAnalysis.SpecialType.System_Type || expectedType.SpecialType == SpecialType.MetaDslx_CodeAnalysis_MetaType)
            {
                value = this.BindSymbol(expectedType, diagnostics, cancellationToken);
                return true;
            }
            return base.ComputeValue(expectedType, out value, diagnostics, cancellationToken);
        }

        private object? BindSymbol(MetaType expectedType, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var identifiers = ImmutableArray<SyntaxNodeOrToken>.Empty;
            if (this.TokensSyntax is not null)
            {
                identifiers = ImmutableArray.Create<SyntaxNodeOrToken>(this.TokensSyntax.Tokens);
            }
            else if (this.QualifierSyntax is not null)
            {
                identifiers = this.QualifierSyntax.Qualifier.Select(id => (SyntaxNodeOrToken)id).ToImmutableArray();
            }
            if (identifiers.Length == 0) return null;
            var context = this.AllocateLookupContext();
            context.Diagnose = true;
            if (expectedType.SpecialType == SpecialType.System_Type || expectedType.SpecialType == SpecialType.MetaDslx_CodeAnalysis_MetaType) 
            {
                context.Validators.Add(LookupValidators.TypeOnly);
            }
            //var identifiers = qualifier.Element.Select(id => (SyntaxNodeOrToken)id).ToImmutableArray();
            var result = this.BindQualifiedName(context, identifiers);
            diagnostics.AddRange(context.Diagnostics);
            context.Free();
            return result[result.Length - 1];
        }
    }
}
