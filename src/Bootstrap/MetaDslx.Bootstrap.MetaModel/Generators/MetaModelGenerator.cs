using MetaDslx.Bootstrap.MetaModel.Core;
using MetaDslx.Bootstrap.MetaModel.Meta;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Meta;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaModel.Generators
{
    public partial class MetaModelGenerator
    {
        private Core.MetaModel _metaModel;
        private MetaMetaGraph _graph;
        private ImmutableArray<MetaClass> _classes;

        public MetaModelGenerator(Core.MetaModel metaModel, MetaMetaGraph graph)
        {
            _metaModel = metaModel;
            _graph = graph;
            _classes = _metaModel.Parent.Declarations.OfType<MetaClass>().ToImmutableArray();
        }

        public Core.MetaModel MetaModel => _metaModel;
        public MetaMetaGraph Graph => _graph;
        public string Namespace => _metaModel.Parent.FullName;
        public ImmutableArray<MetaClass> Classes => _classes;

        public string ToCSharp(MetaType type)
        {
            if (type is null) return string.Empty;
            if (type is MetaPrimitiveType mpt)
            {
                if (mpt.Name == "type") return "__Type";
                else return mpt.Name;
            }
            if (type is MetaArrayType at)
            {
                return $"global::System.Collections.Generic.IList<{ToCSharp(at.ItemType)}>";
            }
            if (type is MetaClass mc && _classes.Contains(mc))
            {
                return mc.Name;
            }
            return $"global::{type.FullName}";
        }

        public string ToCSharpImpl(MetaType type)
        {
            if (type is null) return string.Empty;
            if (type is MetaPrimitiveType mpt)
            {
                if (mpt.Name == "type") return "__Type";
                else return mpt.Name;
            }
            if (type is MetaArrayType at)
            {
                return $"global::MetaDslx.Modeling.ModelObjectList<{ToCSharp(at.ItemType)}>";
            }
            return $"global::{type.FullName}";
        }

        public string ToCSharp(TypeSymbol? type)
        {
            if (type is null) return string.Empty;
            return SymbolDisplayFormat.FullyQualifiedFormat.ToString(type);
        }

        public bool HasSetter(MetaProperty<MetaType, MetaProperty, TypeSymbol> property)
        {
            return property.HasSetter && !property.Flags.HasFlag(ModelPropertyFlags.ReadOnly) && !property.Flags.HasFlag(ModelPropertyFlags.Collection);
        }

        public bool IsCollection(MetaPropertySlot<MetaType, MetaProperty, TypeSymbol> slot)
        {
            return slot.Flags.HasFlag(ModelPropertyFlags.Collection);
        }

        public string ToCSharp(MetaProperty<MetaType, MetaProperty, TypeSymbol> property)
        {
            return $"{MetaModel.Name}.{property.DeclaringType.Name}_{property.Name}";
        }

        public string ToCSharp(ImmutableArray<MetaProperty<MetaType, MetaProperty, TypeSymbol>> properties)
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append("__ImmutableArray.Create<__ModelProperty>(");
            var comma = string.Empty;
            foreach (var property in properties)
            {
                if (string.IsNullOrEmpty(comma)) comma = ", ";
                else sb.Append(comma);
                sb.Append(ToCSharp(property));
            }
            sb.Append(")");
            return builder.ToStringAndFree();
        }

        public string ToCSharp(ModelPropertyFlags flags)
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            var bar = string.Empty;
            foreach (var flag in Enum.GetValues<ModelPropertyFlags>())
            {
                if (flags.HasFlag(flag))
                {
                    if (string.IsNullOrEmpty(bar)) bar = " | ";
                    else sb.Append(bar);
                    sb.Append($"__ModelPropertyFlags.{flag}");
                }
            }
            return builder.ToStringAndFree();
        }

        public string ToCSharpValue(MetaType propertyType, object? value)
        {
            if (value is null) return $"default({ToCSharp(propertyType)})";
            var type = value.GetType();
            if (type == typeof(bool)) return ((bool)value) ? "true" : "false";
            if (type == typeof(string)) return StringUtilities.EncodeString(value.ToString());
            if (type.IsPrimitive) return value.ToString();
            return value.ToString();
        }

    }
}
