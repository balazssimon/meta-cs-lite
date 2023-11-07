using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Languages.MetaModel.Model;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.MetaModel.Meta
{
    public sealed class MetaMetaGraph : MetaGraph<MetaType, MetaProperty, MetaOperation>
    {
        public MetaMetaGraph(IEnumerable<MetaType> classTypes) 
            : base(classTypes)
        {
        }

        protected override bool IsCollectionType(MetaType type, out MetaType? itemType, out ModelPropertyFlags collectionFlags)
        {
            if (type is MetaArrayType arrayType)
            {
                itemType = arrayType.ItemType;
                collectionFlags = ModelPropertyFlags.None;
                return true;
            }
            else
            {
                itemType = null;
                collectionFlags = ModelPropertyFlags.None;
                return false;
            }
        }

        protected override bool IsEnumType(MetaType type)
        {
            return type is MetaEnumType;
        }

        protected override bool IsNullableType(MetaType type, out MetaType innerType)
        {
            innerType = type;
            return type is MetaClass;
        }

        protected override bool IsPrimitiveType(MetaType type)
        {
            return type is MetaPrimitiveType;
        }

        protected override bool IsValueType(MetaType type)
        {
            return type is MetaPrimitiveType || type is MetaEnumType;
        }

        protected override MetaClass<MetaType, MetaProperty, MetaOperation> MakeClass(MetaType classType)
        {
            return new MetaMetaClass((MetaClass)classType);
        }

        protected override MetaOperation<MetaType, MetaProperty, MetaOperation> MakeOperation(MetaClass<MetaType, MetaProperty, MetaOperation> declaringType, MetaOperation operation)
        {
            return new MetaMetaOperation(declaringType, operation);
        }

        protected override MetaOperationInfo<MetaType, MetaProperty, MetaOperation> MakeOperationInfo(ImmutableArray<MetaOperation<MetaType, MetaProperty, MetaOperation>> overridenOperations, ImmutableArray<MetaOperation<MetaType, MetaProperty, MetaOperation>> overridingOperations)
        {
            return new MetaMetaOperationInfo(overridenOperations, overridingOperations);
        }

        protected override MetaProperty<MetaType, MetaProperty, MetaOperation> MakeProperty(MetaClass<MetaType, MetaProperty, MetaOperation> declaringType, MetaProperty property)
        {
            return new MetaMetaProperty(declaringType, property);
        }

        protected override MetaPropertyInfo<MetaType, MetaProperty, MetaOperation> MakePropertyInfo(MetaPropertySlot<MetaType, MetaProperty, MetaOperation> slot, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> oppositeProperties, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> subsettedProperties, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> subsettingProperties, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> redefinedProperties, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> redefiningProperties, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> hiddenProperties, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> hidingProperties)
        {
            return new MetaMetaPropertyInfo(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties, hiddenProperties, hidingProperties);
        }

        protected override MetaPropertySlot<MetaType, MetaProperty, MetaOperation> MakePropertySlot(MetaProperty<MetaType, MetaProperty, MetaOperation> slotProperty, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> slotProperties, object? defaultValue, ModelPropertyFlags flags)
        {
            return new MetaMetaPropertySlot(slotProperty, slotProperties, defaultValue, flags);
        }
    }
}
