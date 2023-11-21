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
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    internal class AnnotationArgumentBinder : UseBinder
    {
        private AnnotationArgumentSymbol? _annotationArgument;
        private ImmutableArray<MetaSymbol> _annotationParameters;

        public AnnotationArgumentBinder()
            : base(ImmutableArray.Create(typeof(DeclaredSymbol)))
        {
        }

        public AnnotationSymbol? AnnotationSymbol => AnnotationArgumentSymbol?.AnnotationSymbol;

        public AnnotationArgumentSymbol? AnnotationArgumentSymbol
        {
            get
            {
                if (_annotationArgument is null)
                {
                    Interlocked.CompareExchange(ref _annotationArgument, GetAnnotationArgumentSymbol(), null);
                }
                return _annotationArgument;
            }
        }

        private AnnotationArgumentSymbol? GetAnnotationArgumentSymbol()
        {
            Binder? currentBinder = this;
            while (currentBinder != null)
            {
                if (currentBinder is IDefineBinder defineBinder)
                {
                    foreach (var symbol in defineBinder.DefinedSymbols)
                    {
                        if (symbol is AnnotationArgumentSymbol annotArgSymbol)
                        {
                            return annotArgSymbol;
                        }
                    }
                    return null;
                }
                currentBinder = currentBinder.ParentBinder;
            }
            return null;
        }

        private ImmutableArray<MetaSymbol> GetAnnotationParameters(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (_annotationParameters.IsDefault)
            {
                var annotation = this.AnnotationSymbol;
                var parameters = ArrayBuilder<MetaSymbol>.GetInstance();
                if (annotation is not null)
                {
                    var csType = annotation.Type.OriginalTypeSymbol as ICSharpSymbol;
                    var msType = csType?.CSharpSymbol as INamedTypeSymbol;
                    if (msType is not null)
                    {
                        foreach (var ctr in msType.InstanceConstructors)
                        {
                            foreach (var ctrParam in ctr.Parameters)
                            {
                                if (!parameters.Any(p => p.Name == ctrParam.Name))
                                {
                                    var ctrParamSymbol = csType.SymbolFactory.GetSymbol(ctrParam, diagnostics, cancellationToken);
                                    if (ctrParamSymbol is not null)
                                    {
                                        parameters.Add(ctrParamSymbol);
                                    }
                                }
                            }
                        } 
                    }
                }
                ImmutableInterlocked.InterlockedInitialize(ref _annotationParameters, parameters.ToImmutableAndFree());
            }
            return _annotationParameters;
        }

        protected override bool IsViable(LookupContext context, DeclaredSymbol symbol)
        {
            var alt = context.MultiLookupKey as PAlternativeSymbol;
            if (alt is null) return false;
            var returnType = alt.ReturnType;
            if (returnType.IsNull || !returnType.IsTypeSymbol) return false;
            return base.IsViable(context, symbol);
        }

        protected override void AdjustFinalLookupContext(LookupContext context)
        {
            base.AdjustFinalLookupContext(context);
            context.IsCaseSensitive = false;
            var alt = context.MultiLookupKey as PAlternativeSymbol;
            context.Qualifier = alt?.ReturnType.OriginalTypeSymbol;
        }
    }
}
