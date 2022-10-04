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
        internal const string MetaModelAttributeName = "MetaDslx.Modeling.MetaModelAttribute";

        private SourceProductionContext _context;
        private INamedTypeSymbol _modelInterface;
        private ImmutableArray<INamedTypeSymbol> _classInterfaces;
        private ImmutableArray<MetaClass> _metaClasses;
        private Dictionary<string, MetaClass>? _metaClassMap;

        public MetaModel(SourceProductionContext context, INamedTypeSymbol modelInterface, ImmutableArray<INamedTypeSymbol> classInterfaces)
        {
            _context = context;
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

        public SourceProductionContext Context => _context;
        public INamedTypeSymbol ModelInterface => _modelInterface;
        public ImmutableArray<INamedTypeSymbol> ClassInterfaces => _classInterfaces;

        public string NamespaceName => _modelInterface.ContainingNamespace.ToDisplayString();
        public string Name => _modelInterface.Name;
        public string FactoryName => Name + "Factory";

        public ImmutableArray<MetaClass> MetaClasses
        {
            get
            {
                if (_metaClasses.IsDefault) ComputeClasses();
                return _metaClasses;
            }
        }

        public MetaClass? GetMetaClass(string name)
        {
            if (_metaClassMap == null) ComputeClasses();
            if (_metaClassMap!.TryGetValue(name, out var result)) return result;
            else return null;
        }

        public MetaClass? GetMetaClass(INamedTypeSymbol intf)
        {
            if (SymbolEqualityComparer.Default.Equals(intf.ContainingSymbol, _modelInterface.ContainingNamespace))
            {
                return GetMetaClass(intf.Name);
            }
            else
            {
                return null;
            }
        }

        private void ComputeClasses()
        {
            if (_metaClassMap != null) return;
            var builder = ArrayBuilder<MetaClass>.GetInstance();
            _metaClassMap = new Dictionary<string, MetaClass>();
            foreach (var intf in _classInterfaces)
            {
                var metaClass = new MetaClass(this, intf);
                builder.Add(metaClass);
                _metaClassMap.Add(intf.Name, metaClass);
            }
            ImmutableInterlocked.InterlockedExchange(ref _metaClasses, builder.ToImmutableAndFree());
        }
    }
}
