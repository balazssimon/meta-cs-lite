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
    public sealed class MetaMetaGraph : MetaGraph<object, MetaProperty, MetaOperation>
    {
        public MetaMetaGraph(IEnumerable<MetaType> classTypes) 
            : base(classTypes)
        {
        }

        protected override bool IsCollectionType(object type, out object? itemType, out ModelPropertyFlags collectionFlags)
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

        protected override bool IsEnumType(object type)
        {
            return type is MetaEnumType;
        }

        protected override bool IsNullableType(object type, out object innerType)
        {
            if (type is MetaNullableType nullableType)
            {
                innerType = nullableType.InnerType;
                return true;
            }
            else if (type is MetaClass)
            {
                innerType = type;
                return true;
            }
            else
            {
                innerType = null;
                return false;
            }
        }

        protected override bool IsPrimitiveType(object type)
        {
            return type is MetaPrimitiveType;
        }

        protected override bool IsValueType(object type)
        {
            return type is MetaPrimitiveType || type is MetaEnumType;
        }

        protected override MetaClass<object, MetaProperty, MetaOperation> MakeClass(object classType)
        {
            return new MetaMetaClass((MetaClass)classType);
        }

        protected override MetaOperation<object, MetaProperty, MetaOperation> MakeOperation(MetaClass<object, MetaProperty, MetaOperation> declaringType, MetaOperation operation)
        {
            return new MetaMetaOperation(declaringType, operation);
        }

        protected override MetaOperationInfo<object, MetaProperty, MetaOperation> MakeOperationInfo(ImmutableArray<MetaOperation<object, MetaProperty, MetaOperation>> overridenOperations, ImmutableArray<MetaOperation<object, MetaProperty, MetaOperation>> overridingOperations)
        {
            return new MetaMetaOperationInfo(overridenOperations, overridingOperations);
        }

        protected override MetaProperty<object, MetaProperty, MetaOperation> MakeProperty(MetaClass<object, MetaProperty, MetaOperation> declaringType, MetaProperty property)
        {
            return new MetaMetaProperty(declaringType, property);
        }

        protected override MetaPropertyInfo<object, MetaProperty, MetaOperation> MakePropertyInfo(MetaPropertySlot<object, MetaProperty, MetaOperation> slot, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> oppositeProperties, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> subsettedProperties, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> subsettingProperties, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> redefinedProperties, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> redefiningProperties, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> hiddenProperties, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> hidingProperties)
        {
            return new MetaMetaPropertyInfo(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties, hiddenProperties, hidingProperties);
        }

        protected override MetaPropertySlot<object, MetaProperty, MetaOperation> MakePropertySlot(MetaProperty<object, MetaProperty, MetaOperation> slotProperty, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> slotProperties, object? defaultValue, ModelPropertyFlags flags)
        {
            return new MetaMetaPropertySlot(slotProperty, slotProperties, defaultValue, flags);
        }
    }
}
