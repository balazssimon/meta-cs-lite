﻿using MetaDslx.Languages.MetaModel.Model;
using MetaDslx.Languages.MetaModel.Meta;
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
using System.Threading;

namespace MetaDslx.Languages.MetaModel.Generators
{
    public partial class MetaModelGenerator
    {
        private Modeling.Model _model;
        private Model.MetaModel _metaModel;
        private MetaMetaGraph _graph;
        private ImmutableArray<MetaClass> _classes;
        private ImmutableArray<IModelObject> _modelObjects;
        private ImmutableArray<object> _objects;
        private Dictionary<object, string>? _objectNames;

        public MetaModelGenerator(Modeling.Model model, Model.MetaModel metaModel, MetaMetaGraph graph)
        {
            _model = model;
            _metaModel = metaModel;
            _graph = graph;
            _classes = _metaModel.Parent.Declarations.OfType<MetaClass>().ToImmutableArray();
            _modelObjects = model.ModelObjects.ToImmutableArray();
            _objects = model.Objects.ToImmutableArray();
        }

        public Modeling.Model Model => _model;
        public Model.MetaModel MetaModel => _metaModel;
        public string Namespace => _metaModel.Parent.FullName;
        public ImmutableArray<MetaClass> Classes => _classes;
        public ImmutableArray<IModelObject> ModelObjects => _modelObjects;
        public ImmutableArray<object> Objects => _objects;
        public MetaMetaGraph Graph => _graph;

        public string ToCSharp(MetaType type)
        {
            if (type is null) return string.Empty;
            if (type is MetaPrimitiveType mpt)
            {
                if (mpt.Name == "type") return "string";
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
                if (mpt.Name == "type") return "string";
                else return mpt.Name;
            }
            if (type is MetaArrayType at)
            {
                return $"global::System.Collections.Generic.IList<{ToCSharp(at.ItemType)}>";
            }
            return $"global::{type.FullName}";
        }

        public string ToCSharp(TypeSymbol? type)
        {
            if (type is null) return string.Empty;
            return SymbolDisplayFormat.FullyQualifiedFormat.ToString(type);
        }

        public bool HasSetter(MetaProperty<MetaType, MetaProperty, MetaOperation> property)
        {
            return property.HasSetter && !property.Flags.HasFlag(ModelPropertyFlags.ReadOnly) && !property.Flags.HasFlag(ModelPropertyFlags.Collection);
        }

        public bool IsCollection(MetaPropertySlot<MetaType, MetaProperty, MetaOperation> slot)
        {
            return slot.Flags.HasFlag(ModelPropertyFlags.Collection);
        }

        public string ToCSharp(MetaProperty<MetaType, MetaProperty, MetaOperation> property)
        {
            return $"{MetaModel.Name}.{property.DeclaringType.Name}_{property.Name}";
        }

        public string ToCSharp(MetaOperation<MetaType, MetaProperty, MetaOperation> op)
        {
            return $"{MetaModel.Name}.{op.DeclaringType.Name}_{op.Name}";
        }

        public string ToCSharp(ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> properties)
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

        public string ToCSharp(ImmutableArray<MetaOperation<MetaType, MetaProperty, MetaOperation>> operations)
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append("__ImmutableArray.Create<__ModelOperation>(");
            var comma = string.Empty;
            foreach (var operation in operations)
            {
                if (string.IsNullOrEmpty(comma)) comma = ", ";
                else sb.Append(comma);
                sb.Append(ToCSharp(operation));
            }
            sb.Append(")");
            return builder.ToStringAndFree();
        }

        public string ToCSharp(ModelPropertyFlags flags)
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            var bar = string.Empty;
            foreach (ModelPropertyFlags flag in Enum.GetValues(typeof(ModelPropertyFlags)))
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

        public string ToCSharpValue(ModelProperty property, object? value)
        {
            var propertyType = property.Type;
            if (value is null) return $"default(global::{propertyType.FullName})";
            if (propertyType == typeof(Type))
            {
                var typeName = ((Type)value)?.FullName;
                return $"typeof({typeName})";
            }
            if (propertyType == typeof(TypeSymbol))
            {
                var typeName = SymbolDisplayFormat.FullyQualifiedFormat.ToString((TypeSymbol)value);
                return $"typeof({typeName})";
            }
            if (propertyType == typeof(bool)) return ((bool)value) ? "true" : "false";
            if (propertyType == typeof(string))
            {
                return StringUtilities.EncodeString(value.ToString());
            }
            if (value is MetaPrimitiveType mpt) return $"_{mpt.Name}Type";
            var type = value.GetType();
            if (type.IsPrimitive) return value.ToString();
            return GetName(value);
        }

        public string GetName(object? obj)
        {
            if (obj is null) return string.Empty;
            if (_objectNames is null)
            {
                var index = 0;
                var objectNames = new Dictionary<object, string>();
                foreach (var mobj in Objects)
                {
                    var mname = $"obj{++index}";
                    objectNames.Add(mobj, mname);
                }
                Interlocked.CompareExchange(ref _objectNames, objectNames, null);
            }
            if (_objectNames.TryGetValue(obj, out var name)) return name;
            else if (obj is IModelObject mobj && mobj.UnderlyingObject is not null && _objectNames.TryGetValue(mobj.UnderlyingObject, out var mname)) return mname;
            else return string.Empty;
        }
    }
}
