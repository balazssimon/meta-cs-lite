using MetaDslx.Bootstrap.MetaModel.Core;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaModel.Meta
{
    public class MetaMetaGraph : MetaGraph<MetaType, MetaProperty, TypeSymbol>
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

        protected override MetaClass<MetaType, MetaProperty, TypeSymbol> MakeClass(MetaType classType)
        {
            return new MetaMetaClass((MetaClass)classType);
        }

        protected override MetaProperty<MetaType, MetaProperty, TypeSymbol> MakeProperty(MetaClass<MetaType, MetaProperty, TypeSymbol> declaringType, MetaProperty property)
        {
            return new MetaMetaProperty(declaringType, property);
        }

        protected override MetaPropertyInfo<MetaType, MetaProperty, TypeSymbol> MakePropertyInfo(MetaPropertySlot<MetaType, MetaProperty, TypeSymbol> slot, ImmutableArray<MetaProperty<MetaType, MetaProperty, TypeSymbol>> oppositeProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, TypeSymbol>> subsettedProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, TypeSymbol>> subsettingProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, TypeSymbol>> redefinedProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, TypeSymbol>> redefiningProperties = default)
        {
            return new MetaMetaPropertyInfo(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties);
        }

        protected override MetaPropertySlot<MetaType, MetaProperty, TypeSymbol> MakePropertySlot(MetaProperty<MetaType, MetaProperty, TypeSymbol> slotProperty, ImmutableArray<MetaProperty<MetaType, MetaProperty, TypeSymbol>> slotProperties, object? defaultValue, ModelPropertyFlags flags)
        {
            return new MetaMetaPropertySlot(slotProperty, slotProperties, defaultValue, flags);
        }
    }
}
