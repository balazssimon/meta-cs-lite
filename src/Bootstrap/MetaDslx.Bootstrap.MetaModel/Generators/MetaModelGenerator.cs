using MetaDslx.Bootstrap.MetaModel.Core;
using MetaDslx.Bootstrap.MetaModel.Meta;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Meta;
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
                if (mpt.Name == "Type") return "__Type";
                else return mpt.Name;
            }
            return type.FullName;
        }

        public string ToCSharp(MetaProperty<MetaType, MetaProperty, Type> property)
        {
            return $"{MetaModel.Name}.{property.DeclaringType.Name}_{property.Name}";
        }

        public string ToCSharp(ImmutableArray<MetaProperty<MetaType, MetaProperty, Type>> properties)
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
    }
}
