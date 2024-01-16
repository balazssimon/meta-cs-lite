using MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Binding.Lookup;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
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
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;
    using IParameterSymbol = Microsoft.CodeAnalysis.IParameterSymbol;

    internal class ExpressionValueBinder : ValueBinder
    {
        private ExpressionSymbol? _containingExpression;
        private PAlternativeSymbol? _containingPAlternative;
        private AnnotationArgumentSymbol? _containingAnnotationArgument;
        private ImmutableArray<DeclarationSymbol> _targetProperties;
        private ImmutableArray<LookupKey> _expectedTypes;

        public SingleExpressionBlock1Syntax? Syntax => base.Syntax.AsNode() as SingleExpressionBlock1Syntax;
        public SimpleQualifierSyntax? QualifierSyntax => this.Syntax as SimpleQualifierSyntax;

        //public SingleExpressionValueSyntax? Syntax => base.Syntax.AsNode() as SingleExpressionValueSyntax;
        //public SimpleQualifierSyntax? QualifierSyntax => (this.Syntax as SingleExpressionValueAlt2Syntax)?.Element1;

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

        public PAlternativeSymbol? ContainingPAlternativeSymbol
        {
            get
            {
                if (_containingPAlternative is null)
                {
                    Interlocked.CompareExchange(ref _containingPAlternative, ContainingExpression?.ContainingPAlternativeSymbol, null);
                }
                return _containingPAlternative;
            }
        }

        public AnnotationArgumentSymbol? ContainingAnnotationArgumentSymbol
        {
            get
            {
                if (_containingAnnotationArgument is null)
                {
                    Interlocked.CompareExchange(ref _containingAnnotationArgument, ContainingExpression?.ContainingAnnotationArgumentSymbol, null);
                }
                return _containingAnnotationArgument;
            }
        }

        public ImmutableArray<DeclarationSymbol> TargetProperties
        {
            get
            {
                if (_targetProperties.IsDefault)
                {
                    var arg = ContainingAnnotationArgumentSymbol;
                    if (arg is not null)
                    {
                        ImmutableInterlocked.InterlockedInitialize(ref _targetProperties, arg.Parameter is null ? ImmutableArray<DeclarationSymbol>.Empty : ImmutableArray.Create(arg.Parameter));
                    }
                    else
                    {
                        var alt = ContainingPAlternativeSymbol;
                        if (alt is not null)
                        {
                            var block = alt?.ContainingSymbol as PBlockSymbol;
                            var blockElem = block?.ContainingSymbol as PElementSymbol;
                            if (blockElem is not null)
                            {
                                var targetProperties = ArrayBuilder<DeclarationSymbol>.GetInstance();
                                foreach (var prop in blockElem.SymbolProperty)
                                {
                                    if (prop.OriginalSymbol is DeclarationSymbol declaredSymbol)
                                    {
                                        targetProperties.Add(declaredSymbol);
                                    }
                                }
                                ImmutableInterlocked.InterlockedInitialize(ref _targetProperties, targetProperties.ToImmutableAndFree());
                            }
                            else
                            {
                                ImmutableInterlocked.InterlockedInitialize(ref _targetProperties, ImmutableArray<DeclarationSymbol>.Empty);
                            }
                        }
                    }
                }
                return _targetProperties;
            }
        }

        private ImmutableArray<LookupKey> GetExpectedTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (_expectedTypes.IsDefault)
            {
                var targetProperties = TargetProperties;
                if (targetProperties.IsDefaultOrEmpty)
                {
                    var expectedType = ContainingPAlternativeSymbol?.ReturnType ?? default;
                    expectedType.TryGetCoreType(out var coreType, diagnostics, cancellationToken);
                    ImmutableInterlocked.InterlockedInitialize(ref _expectedTypes, ImmutableArray.Create(new LookupKey(default, coreType)));
                }
                else
                {
                    var expectedTypes = ArrayBuilder<LookupKey>.GetInstance();
                    foreach (var targetProperty in TargetProperties)
                    {
                        var property = targetProperty as ICSharpSymbol;
                        var csType = (property?.CSharpSymbol as IPropertySymbol)?.Type ?? (property?.CSharpSymbol as IParameterSymbol)?.Type;
                        if (csType is not null)
                        {
                            var type = MetaType.FromTypeSymbol(property.SymbolFactory.GetSymbol<TypeSymbol>(csType, diagnostics, cancellationToken));
                            type.TryGetCoreType(out var coreType, diagnostics, cancellationToken);
                            expectedTypes.Add(new LookupKey(targetProperty, coreType));
                        }
                        else
                        {
                            expectedTypes.Add(default);
                        }
                    }
                    ImmutableInterlocked.InterlockedInitialize(ref _expectedTypes, expectedTypes.ToImmutableAndFree());
                }
            }
            return _expectedTypes;
        }

        protected override ImmutableArray<object?> BindValues(CancellationToken cancellationToken = default)
        {
            var diagnostics = DiagnosticBag.GetInstance();
            var expectedTypes = GetExpectedTypes(diagnostics, cancellationToken);
            var result = ArrayBuilder<object?>.GetInstance();
            foreach (var expectedType in expectedTypes)
            {
                if (ComputeValue(expectedType.Type, out var value, diagnostics, cancellationToken))
                {
                    result.Add(value);
                }
                else
                {
                    result.Add(null);
                }
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
            var qualifier = this.QualifierSyntax;
            if (qualifier is null) return null;
            if (qualifier.SimpleIdentifierList.Count == 0) return null;
            //if (qualifier.Element.Count == 0) return null;
            var context = this.AllocateLookupContext();
            context.Diagnose = true;
            if (expectedType.SpecialType == SpecialType.System_Type || expectedType.SpecialType == SpecialType.MetaDslx_CodeAnalysis_MetaType) 
            {
                context.Validators.Add(LookupValidators.TypeOnly);
            }
            var identifiers = qualifier.SimpleIdentifierList.Select(id => (SyntaxNodeOrToken)id).ToImmutableArray();
            //var identifiers = qualifier.Element.Select(id => (SyntaxNodeOrToken)id).ToImmutableArray();
            var result = this.BindQualifiedName(context, identifiers);
            diagnostics.AddRange(context.Diagnostics);
            context.Free();
            return result[result.Length - 1];
        }

        private class LookupKey
        {
            private readonly MetaSymbol _property;
            private readonly MetaType _type;

            public LookupKey(MetaSymbol property, MetaType type)
            {
                _property = property;
                _type = type;
            }

            public MetaSymbol Property => _property;
            public MetaType Type => _type;
        }
    }
}
