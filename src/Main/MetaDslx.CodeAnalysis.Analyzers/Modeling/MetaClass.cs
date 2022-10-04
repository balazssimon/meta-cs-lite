using MetaDslx.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Analyzers.Modeling
{
    internal class MetaClass
    {
        internal const string MetaClassAttributeName = "MetaDslx.Modeling.MetaClassAttribute";

        private MetaModel _metaModel;
        private INamedTypeSymbol _classInterface;
        private bool _isAbstract;
        private ImmutableArray<MetaClass> _baseTypes;
        private ImmutableArray<MetaProperty> _declaredProperties;
        private ImmutableArray<MetaProperty> _allDeclaredProperties;
        private ImmutableArray<MetaProperty> _publicProperties;

        public MetaClass(MetaModel metaModel, INamedTypeSymbol classInterface)
        {
            _metaModel = metaModel;
            _classInterface = classInterface;
            foreach (var attr in classInterface.GetAttributes())
            {
                var attrName = attr.AttributeClass?.ToDisplayString();
                if (attrName == MetaClassAttributeName)
                {
                    foreach (var arg in attr.NamedArguments)
                    {
                        if (arg.Key == "IsAbstract" && arg.Value.Equals(true))
                        {
                            _isAbstract = true;
                        }
                    }
                }
            }
        }

        public SourceProductionContext Context => _metaModel.Context;
        public MetaModel MetaModel => _metaModel;
        public INamedTypeSymbol ClassInterface => _classInterface;

        public ImmutableArray<MetaClass> BaseTypes
        {
            get
            {
                if (_baseTypes.IsDefault)
                {
                    var baseTypes = ArrayBuilder<MetaClass>.GetInstance();
                    foreach (var intf in _classInterface.AllInterfaces)
                    {
                        var baseType = _metaModel.GetMetaClass(intf);
                        if (baseType != null)
                        {
                            baseTypes.Add(baseType);
                        }
                    }
                    ImmutableInterlocked.InterlockedExchange(ref _baseTypes, baseTypes.ToImmutableAndFree());
                }
                return _baseTypes;
            }
        }

        public string Name => _classInterface.Name;
        public string ImplName => _classInterface.Name + "Impl";
        public bool IsAbstract => _isAbstract;
        public bool IsRoot => BaseTypes.Length == 0;

        public ImmutableArray<MetaProperty> DeclaredProperties
        {
            get
            {
                if (_declaredProperties.IsDefault)
                {
                    ImmutableInterlocked.InterlockedExchange(ref _declaredProperties, ComputeDeclaredProperties());
                }
                return _declaredProperties;
            }
        }

        public ImmutableArray<MetaProperty> AllDeclaredProperties
        {
            get
            {
                if (_allDeclaredProperties.IsDefault) ComputeAllProperties();
                return _allDeclaredProperties;
            }
        }

        public ImmutableArray<MetaProperty> PublicProperties
        {
            get
            {
                if (_publicProperties.IsDefault) ComputeAllProperties();
                return _publicProperties;
            }
        }

        private ImmutableArray<MetaProperty> ComputeDeclaredProperties()
        {
            var declaredProperties = ArrayBuilder<MetaProperty>.GetInstance();
            foreach (var member in _classInterface.GetMembers())
            {
                if (member is IPropertySymbol propertySymbol)
                {
                    if (SymbolEqualityComparer.Default.Equals(propertySymbol.ContainingType, _classInterface))
                    {
                        declaredProperties.Add(new MetaProperty(this, propertySymbol));
                    }
                }
            }
            return declaredProperties.ToImmutableAndFree();
        }

        private void ComputeAllProperties()
        {
            var allDeclaredProperties = ArrayBuilder<MetaProperty>.GetInstance();
            var publicProperties = ArrayBuilder<MetaProperty>.GetInstance();
            allDeclaredProperties.AddRange(DeclaredProperties);
            publicProperties.AddRange(DeclaredProperties);
            foreach (var baseType in _classInterface.AllInterfaces)
            {
                var baseMetaClass = _metaModel.GetMetaClass(baseType);
                if (baseMetaClass != null)
                {
                    foreach (var prop in baseMetaClass.DeclaredProperties)
                    {
                        allDeclaredProperties.Add(prop);
                        if (!publicProperties.Any(p => p.Name == prop.Name))
                        {
                            publicProperties.Add(prop);
                        }
                    }
                }
            }
            ImmutableInterlocked.InterlockedExchange(ref _allDeclaredProperties, allDeclaredProperties.ToImmutableAndFree());
            ImmutableInterlocked.InterlockedExchange(ref _publicProperties, publicProperties.ToImmutableAndFree());
        }
    }
}
