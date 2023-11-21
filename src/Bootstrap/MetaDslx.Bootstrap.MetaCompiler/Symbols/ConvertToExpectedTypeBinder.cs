using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using Microsoft.CodeAnalysis;
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
    internal class ConvertToExpectedTypeBinder : UseBinder, IMultiLookupBinder
    {
        private ExpressionSymbol? _containingExpression;
        private PAlternativeSymbol? _containingPAlternative;
        private AnnotationArgumentSymbol? _containingAnnotationArgument;
        private ImmutableArray<MetaSymbol> _targetProperties;
        private ImmutableArray<LookupKey> _expectedTypes;

        public ConvertToExpectedTypeBinder()
            : base(ImmutableArray.Create(typeof(MetaSymbol)))
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

        public ImmutableArray<MetaSymbol> TargetProperties
        {
            get
            {
                if (_targetProperties.IsDefault)
                {
                    var alt = ContainingPAlternativeSymbol;
                    var block = alt?.ContainingSymbol as PBlockSymbol;
                    var blockElem = block?.ContainingSymbol as PElementSymbol;
                    if (blockElem is not null)
                    {
                        ImmutableInterlocked.InterlockedInitialize(ref _targetProperties, blockElem.SymbolProperty);
                    }
                    else
                    {
                        ImmutableInterlocked.InterlockedInitialize(ref _targetProperties, ImmutableArray<MetaSymbol>.Empty);
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
                    ImmutableInterlocked.InterlockedInitialize(ref _expectedTypes, ImmutableArray.Create(new LookupKey(default, ContainingPAlternativeSymbol?.ReturnType ?? default)));
                }
                else
                {
                    var expectedTypes = ArrayBuilder<LookupKey>.GetInstance();
                    foreach (var targetProperty in TargetProperties)
                    {
                        var property = targetProperty.OriginalSymbol as ICSharpSymbol;
                        var csType = (property?.CSharpSymbol as IPropertySymbol)?.Type;
                        if (csType is not null)
                        {
                            var type = property.SymbolFactory.GetSymbol<TypeSymbol>(csType, diagnostics, cancellationToken);
                            expectedTypes.Add(new LookupKey(targetProperty, type));
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

        public ImmutableArray<object> GetMultiLookupKeys(CancellationToken cancellationToken = default)
        {
            var diagnostics = DiagnosticBag.GetInstance();
            var result = GetExpectedTypes(diagnostics, cancellationToken);
            this.AddDiagnostics(diagnostics);
            diagnostics.Free();
            return result.CastArray<object>();
        }

        protected override void AdjustFinalLookupContext(LookupContext context)
        {
            base.AdjustFinalLookupContext(context);
            if (context.Qualifier is null)
            {
                context.Qualifier = ((LookupKey)context.MultiLookupKey).Type.OriginalTypeSymbol;
            }
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
