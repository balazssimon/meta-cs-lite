using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaClass<TType, TProperty, TOperation>
    {
        public MetaClass(TType underlyingType)
        {
            UnderlyingType = underlyingType;
        }

        public TType UnderlyingType { get; }

        public abstract string Name { get; }
        public abstract object? SymbolType { get; set; }
        public abstract ImmutableArray<TType> OriginalBaseTypes { get; }
        public abstract ImmutableArray<TProperty> OriginalDeclaredProperties { get; }
        public abstract ImmutableArray<TOperation> OriginalDeclaredOperations { get; }

        public ImmutableArray<MetaClass<TType, TProperty, TOperation>> AllBaseTypes { get; internal set; }
        public MetaProperty<TType, TProperty, TOperation>? NameProperty { get; internal set; }
        public MetaProperty<TType, TProperty, TOperation>? TypeProperty { get; internal set; }
        public ImmutableArray<MetaProperty<TType, TProperty, TOperation>> DeclaredProperties { get; internal set; }
        public ImmutableArray<MetaProperty<TType, TProperty, TOperation>> AllDeclaredProperties { get; internal set; }
        public ImmutableArray<MetaProperty<TType, TProperty, TOperation>> PublicProperties { get; internal set; }
        public ImmutableArray<MetaPropertySlot<TType, TProperty, TOperation>> Slots { get; internal set; }
        public ImmutableDictionary<string, MetaProperty<TType, TProperty, TOperation>> PublicPropertiesByName { get; internal set; }
        public ImmutableDictionary<MetaProperty<TType, TProperty, TOperation>, MetaPropertyInfo<TType, TProperty, TOperation>> ModelPropertyInfos { get; internal set; }
        public ImmutableArray<MetaOperation<TType, TProperty, TOperation>> DeclaredOperations { get; internal set; }
        public ImmutableArray<MetaOperation<TType, TProperty, TOperation>> AllDeclaredOperations { get; internal set; }
        public ImmutableArray<MetaOperation<TType, TProperty, TOperation>> PublicOperations { get; internal set; }
        public ImmutableDictionary<MetaOperation<TType, TProperty, TOperation>, MetaOperationInfo<TType, TProperty, TOperation>> ModelOperationInfos { get; internal set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
