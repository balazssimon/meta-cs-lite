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
using System.Threading;
using System.Threading.Tasks;

namespace MetaDslx.Languages.MetaCompiler.Symbols
{
    internal class AnnotationArgumentBinder : UseBinder, IMultiLookupBinder
    {
        private AnnotationArgumentSymbol? _annotationArgument;

        public AnnotationArgumentBinder()
            : base(ImmutableArray.Create(typeof(DeclarationSymbol)))
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

        public ImmutableArray<object> GetMultiLookupKeys(CancellationToken cancellationToken = default)
        {
            return AnnotationSymbol?.Constructors.CastArray<object>() ?? ImmutableArray<object>.Empty;
        }

        protected override void AddLookupCandidateSymbolsInSingleBinder(LookupContext context, LookupCandidates result)
        {
            var ctr = context.MultiLookupKey as DeclarationSymbol;
            var index = AnnotationSymbol?.Constructors.IndexOf(ctr) ?? -1;
            if (index < 0) return;
            var parameters = AnnotationSymbol.Parameters[index];
            foreach (var param in parameters)
            {
                if (context.IsViable(param))
                {
                    result.Add(param); 
                }
            }
        }

    }
}
