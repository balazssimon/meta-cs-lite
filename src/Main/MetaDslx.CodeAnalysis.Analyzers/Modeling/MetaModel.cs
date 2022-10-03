using MetaDslx.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MetaDslx.CodeAnalysis.Analyzers.Modeling
{
    internal class MetaModel
    {
        private INamedTypeSymbol _modelInterface;
        private ImmutableArray<INamedTypeSymbol> _classInterfaces;
        private ImmutableArray<MetaClass> _metaClasses;

        public MetaModel(INamedTypeSymbol modelInterface, ImmutableArray<INamedTypeSymbol> classInterfaces)
        {
            _modelInterface = modelInterface;
            var builder = new List<INamedTypeSymbol>();
            foreach (var nts in classInterfaces)
            {
                if (!builder.Any(s => SymbolEqualityComparer.Default.Equals(s, nts)))
                {
                    builder.Add(nts);
                }
            }
            _classInterfaces = builder.OrderBy(s => s.Name).ToImmutableArray();
        }

        public INamedTypeSymbol ModelInterface => _modelInterface;
        public ImmutableArray<INamedTypeSymbol> ClassInterfaces => _classInterfaces;

        public string NamespaceName => _modelInterface.ContainingNamespace.ToDisplayString();
        public string Name => _modelInterface.Name;
        public string FactoryName => Name + "Factory";

        public ImmutableArray<MetaClass> MetaClasses
        {
            get
            {
                if (_metaClasses.IsDefault)
                {
                    ImmutableInterlocked.InterlockedExchange(ref _metaClasses, _classInterfaces.SelectAsArray(nts => new MetaClass(nts)));
                }
                return _metaClasses;
            }
        }
    }
}
