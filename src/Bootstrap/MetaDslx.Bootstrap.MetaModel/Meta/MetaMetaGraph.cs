﻿using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Bootstrap.MetaModel.Model;
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
    public sealed class MetaMetaGraph : MetaGraph<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>
    {
        public MetaMetaGraph(IEnumerable<MetaClass> classTypes) 
            : base(classTypes.Select(ct => MetaDslx.CodeAnalysis.MetaType.FromModelObject((IModelObject)ct)))
        {
        }

        protected override bool IsCollectionType(MetaDslx.CodeAnalysis.MetaType type, out MetaDslx.CodeAnalysis.MetaType itemType, out ModelPropertyFlags collectionFlags)
        {
            if (type.OriginalModelObject is MetaTypeReference typeRef && typeRef.IsArray)
            {
                itemType = typeRef.Type;
                collectionFlags = ModelPropertyFlags.None;
                if (typeRef.IsNullable) collectionFlags |= ModelPropertyFlags.NullableType;
                return true;
            }
            else
            {
                itemType = default;
                collectionFlags = ModelPropertyFlags.None;
                return false;
            }
        }

        protected override bool IsEnumType(MetaDslx.CodeAnalysis.MetaType type)
        {
            return type.OriginalModelObject is MetaEnum;
        }

        protected override bool IsMapType(CodeAnalysis.MetaType type, out CodeAnalysis.MetaType keyType, out ModelPropertyFlags keyFlags, out CodeAnalysis.MetaType valueType, out ModelPropertyFlags valueFlags)
        {
            keyType = default;
            keyFlags = ModelPropertyFlags.None;
            valueType = default;
            valueFlags = ModelPropertyFlags.None;
            return false;
        }

        protected override bool IsNullableType(MetaDslx.CodeAnalysis.MetaType type, out MetaDslx.CodeAnalysis.MetaType innerType)
        {
            if (type.OriginalModelObject is MetaTypeReference typeRef && typeRef.IsNullable)
            {
                innerType = typeRef.Type;
                return true;
            }
            else if (type.OriginalModelObject is MetaClass)
            {
                innerType = type;
                return true;
            }
            else
            {
                innerType = default;
                return false;
            }
        }

        protected override bool IsPrimitiveType(MetaDslx.CodeAnalysis.MetaType type)
        {
            if (type.OriginalModelObject is MetaTypeReference typeRef && typeRef.Type.MetaKeyword is not null) return true;
            if (type.MetaKeyword is not null) return true;
            return false;
        }

        protected override bool IsValueType(MetaDslx.CodeAnalysis.MetaType type)
        {
            return type.OriginalModelObject is MetaEnum || IsPrimitiveType(type);
        }

        protected override MetaClass<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> MakeClass(MetaDslx.CodeAnalysis.MetaType classType)
        {
            return new MetaMetaClass(classType);
        }

        protected override MetaOperation<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> MakeOperation(MetaClass<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> declaringType, MetaOperation operation)
        {
            return new MetaMetaOperation(declaringType, operation);
        }

        protected override MetaOperationInfo<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> MakeOperationInfo(ImmutableArray<MetaOperation<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> overridenOperations, ImmutableArray<MetaOperation<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> overridingOperations)
        {
            return new MetaMetaOperationInfo(overridenOperations, overridingOperations);
        }

        protected override MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> MakeProperty(MetaClass<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> declaringType, MetaProperty property)
        {
            return new MetaMetaProperty(declaringType, property);
        }

        protected override MetaPropertyInfo<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> MakePropertyInfo(MetaPropertySlot<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> slot, ImmutableArray<MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> oppositeProperties, ImmutableArray<MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> subsettedProperties, ImmutableArray<MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> subsettingProperties, ImmutableArray<MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> redefinedProperties, ImmutableArray<MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> redefiningProperties, ImmutableArray<MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> hiddenProperties, ImmutableArray<MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> hidingProperties)
        {
            return new MetaMetaPropertyInfo(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties, hiddenProperties, hidingProperties);
        }

        protected override MetaPropertySlot<CodeAnalysis.MetaType, MetaProperty, MetaOperation> MakePropertySlot(MetaProperty<CodeAnalysis.MetaType, MetaProperty, MetaOperation> slotProperty, ImmutableArray<MetaProperty<CodeAnalysis.MetaType, MetaProperty, MetaOperation>> slotProperties, object? defaultValue, ModelPropertyFlags flags, ModelPropertyFlags keyFlags)
        {
            return new MetaMetaPropertySlot(slotProperty, slotProperties, defaultValue, flags, keyFlags);
        }
    }
}
