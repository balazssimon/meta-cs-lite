using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roslyn.Utilities;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    internal class SymbolPropertyBinder : UseBinder, IMultiLookupBinder
    {
        private ImmutableArray<MetaType> _expectedTypes;
        private ImmutableArray<object?> _expectedTypeObjects;
        private PElementSymbol? _containingElement;

        public SymbolPropertyBinder()
            : base(ImmutableArray.Create(typeof(DeclaredSymbol)))
        {
        }

        public PElementSymbol? ContainingElement
        {
            get
            {
                if (_containingElement is null)
                {
                    PElementSymbol? containingElement = null;
                    Binder? currentBinder = this;
                    while (currentBinder != null)
                    {
                        if (currentBinder is IDefineBinder defineBinder)
                        {
                            foreach (var symbol in defineBinder.DefinedSymbols)
                            {
                                containingElement = symbol.GetInnermostContainingSymbol<PElementSymbol>(includeSelf: true);
                                break;
                            }
                            break;
                        }
                        currentBinder = currentBinder.ParentBinder;
                    }
                    Interlocked.CompareExchange(ref _containingElement, containingElement, null);
                }
                return _containingElement;
            }
        }

        public ImmutableArray<MetaType> ExpectedTypes
        {
            get
            {
                if (_expectedTypes.IsDefault)
                {
                    ImmutableInterlocked.InterlockedInitialize(ref _expectedTypes, GetExpectedTypes());
                }
                return _expectedTypes;
            }
        }

        private ImmutableArray<MetaType> GetExpectedTypes()
        {
            var alt = ContainingElement?.ContainingPAlternativeSymbol;
            if (alt is null || alt.IsResolvingExpectedTypes) return ImmutableArray<MetaType>.Empty;
            else return alt.ExpectedTypes;
        }

        public ImmutableArray<object> GetMultiLookupKeys(CancellationToken cancellationToken = default)
        {
            if (_expectedTypeObjects.IsDefault)
            {
                ImmutableInterlocked.InterlockedInitialize(ref _expectedTypeObjects, ExpectedTypes.Where(et => et.IsTypeSymbol).Select(et => (object)et).ToImmutableArray());
            }
            return _expectedTypeObjects;
        }

        protected override bool IsViable(LookupContext context, DeclaredSymbol symbol)
        {
            if (context.MultiLookupKey is null) return false;
            var alt = (MetaType)context.MultiLookupKey;
            if (alt.IsNull || !alt.IsTypeSymbol) return false;
            return base.IsViable(context, symbol);
        }

        protected override void AdjustFinalLookupContext(LookupContext context)
        {
            base.AdjustFinalLookupContext(context);
            if (context.MultiLookupKey is null) return;
            context.IsCaseSensitive = false;
            var alt = (MetaType)context.MultiLookupKey;
            if (alt.IsNull || !alt.IsTypeSymbol) return;
            context.Qualifier = alt.OriginalTypeSymbol;
        }

        protected override Diagnostic UpdateDiagnostic(LookupContext context, Diagnostic diagnostic)
        {
            var trace = string.Join(", ", ResolveTrace());
            return Diagnostic.Create(CommonErrorCode.ERR_BindingError, this.Location, $"{diagnostic} [{trace}]" );
        }

        private ImmutableArray<string> ResolveTrace()
        {
            var alt = ContainingElement.ContainingPAlternativeSymbol;
            var rule = alt.GetOutermostContainingSymbol<PBlockSymbol>();
            var grammar = alt.GetOutermostContainingSymbol<GrammarSymbol>();
            if (grammar is null || rule is null) return ImmutableArray<string>.Empty;
            var result = ArrayBuilder<string>.GetInstance();
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            var visited = PooledHashSet<DeclaredSymbol>.GetInstance();
            var stack = ArrayBuilder<DeclaredSymbol>.GetInstance();
            stack.Add(rule);
            visited.Add(rule);
            while (stack.Count > 0)
            {
                var currentRule = stack[stack.Count - 1];
                if (currentRule is PBlockSymbol currentBlock)
                {
                    bool added = false;
                    var refElems = grammar.BlockReferences[currentBlock];
                    foreach (var refElem in refElems)
                    {
                        var refAlt = refElem.ContainingPAlternativeSymbol;
                        var refRule = refElem.GetOutermostContainingSymbol<ParserRuleSymbol>();
                        if (refRule is not null)
                        {
                            sb.Clear();
                            sb.Append(refRule.Name);
                            for (int i = stack.Count - 1; i >= 0; --i)
                            {
                                sb.Append("/");
                                sb.Append(stack[i].Name);
                            }
                            var trace = sb.ToString();
                            if (!result.Contains(trace)) result.Add(trace);
                        }
                        else
                        {
                            var refBlock = refElem.GetOutermostContainingSymbol<PBlockSymbol>();
                            if (refBlock is not null && !visited.Contains(refBlock))
                            {
                                visited.Add(refBlock);
                                stack.Add(refBlock);
                                added = true;
                                break;
                            }
                        }
                    }
                    if (!added) stack.RemoveAt(stack.Count - 1);
                }
            }
            stack.Free();
            visited.Free();
            builder.Free();
            return result.ToImmutableAndFree();
        }

    }
}
