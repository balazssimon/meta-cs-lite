using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MetaDslx.Languages.MetaModel.Model
{
    using Compilation = Microsoft.CodeAnalysis.Compilation;

    internal class MetaModelInfo
    {
        internal const string MetaModelAttributeName = "MetaDslx.Modeling.MetaModelAttribute";

        private Compilation _compilation;
        private SourceProductionContext _context;
        private INamedTypeSymbol _modelInterface;
        private ModelVersion _version;
        private string? _uri;
        private string? _prefix;
        private ImmutableArray<INamedTypeSymbol> _classInterfaces;
        private ImmutableArray<MetaClass> _metaClasses;
        private Dictionary<string, MetaClass>? _metaClassMap;

        public MetaModelInfo(Compilation compilation, SourceProductionContext context, INamedTypeSymbol modelInterface, ImmutableArray<INamedTypeSymbol> classInterfaces)
        {
            _compilation = compilation;
            _context = context;
            _modelInterface = modelInterface;
            ushort majorVersion = 0;
            ushort minorVersion = 0;
            foreach (var attr in modelInterface.GetAttributes())
            {
                var attrName = attr.AttributeClass?.ToDisplayString();
                if (attrName == MetaModelAttributeName)
                {
                    foreach (var arg in attr.NamedArguments)
                    {
                        if (arg.Key == "MajorVersion") majorVersion = (ushort)arg.Value.Value;
                        if (arg.Key == "MinorVersion") minorVersion = (ushort)arg.Value.Value;
                        if (arg.Key == "Uri") _uri = (string?)arg.Value.Value;
                        if (arg.Key == "Prefix") _prefix = (string?)arg.Value.Value;
                    }
                }
            }
            _version = new ModelVersion(majorVersion, minorVersion);
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

        public Compilation Compilation => _compilation;
        public SourceProductionContext Context => _context;
        public INamedTypeSymbol ModelInterface => _modelInterface;
        public ModelVersion Version => _version;
        public string Uri => _uri;
        public string Prefix => _prefix;
        public ImmutableArray<INamedTypeSymbol> ClassInterfaces => _classInterfaces;

        public string NamespaceName => _modelInterface.ContainingNamespace.ToDisplayString();
        public string Name => _modelInterface.Name;
        public string FullyQualifiedName => $"global::{NamespaceName}.{Name}";
        public string InfoName => Name + "Info";
        public string FullyQualifiedInfoName => $"global::{NamespaceName}.{InfoName}";
        public string SingleFactoryName => Name + "Factory";
        public string FullyQualifiedSingleFactoryName => $"global::{NamespaceName}.{SingleFactoryName}";
        public string MultiFactoryName => Name + "MultiFactory";
        public string FullyQualifiedMultiFactoryName => $"global::{NamespaceName}.{MultiFactoryName}";
        public string MetaModelImplName => Name + "Impl";
        public string FullyQualifiedMetaModelImplName => $"global::{NamespaceName}.Internal.{MetaModelImplName}";

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

        public override string ToString()
        {
            return Name;
        }
    }
}
