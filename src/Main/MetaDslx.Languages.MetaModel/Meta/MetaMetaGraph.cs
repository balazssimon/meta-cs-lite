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
    internal class MetaMetaGraph : MetaGraph<MetaType, MetaProperty>
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
            return type is MetaPrimitiveType && type.Name != "type";
        }

        protected override bool IsValueType(MetaType type)
        {
            return type is MetaPrimitiveType && type.Name != "type" || type is MetaEnumType;
        }

        protected override MetaClass<MetaType, MetaProperty> MakeClass(MetaType classType)
        {
            return new MetaMetaClass((MetaClass)classType);
        }

        protected override MetaProperty<MetaType, MetaProperty> MakeProperty(MetaClass<MetaType, MetaProperty> declaringType, MetaProperty property)
        {
            return new MetaMetaProperty(declaringType, property);
        }

        protected override MetaPropertyInfo<MetaType, MetaProperty> MakePropertyInfo(MetaPropertySlot<MetaType, MetaProperty> slot, ImmutableArray<MetaProperty<MetaType, MetaProperty>> oppositeProperties, ImmutableArray<MetaProperty<MetaType, MetaProperty>> subsettedProperties, ImmutableArray<MetaProperty<MetaType, MetaProperty>> subsettingProperties, ImmutableArray<MetaProperty<MetaType, MetaProperty>> redefinedProperties, ImmutableArray<MetaProperty<MetaType, MetaProperty>> redefiningProperties, ImmutableArray<MetaProperty<MetaType, MetaProperty>> hiddenProperties, ImmutableArray<MetaProperty<MetaType, MetaProperty>> hidingProperties)
        {
            return new MetaMetaPropertyInfo(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties, hiddenProperties, hidingProperties);
        }

        protected override MetaPropertySlot<MetaType, MetaProperty> MakePropertySlot(MetaProperty<MetaType, MetaProperty> slotProperty, ImmutableArray<MetaProperty<MetaType, MetaProperty>> slotProperties, object? defaultValue, ModelPropertyFlags flags)
        {
            return new MetaMetaPropertySlot(slotProperty, slotProperties, defaultValue, flags);
        }
    }
}
