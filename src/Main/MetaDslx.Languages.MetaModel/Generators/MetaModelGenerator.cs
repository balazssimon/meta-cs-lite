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
using System.Security;

namespace MetaDslx.Languages.MetaModel.Generators
{
    public partial class MetaModelGenerator
    {
        private bool _isMetaMetaModel;
        private Modeling.Model _model;
        private Model.MetaModel _metaModel;
        private MetaMetaGraph _graph;
        private ImmutableArray<MetaClass> _classes;
        private ImmutableArray<MetaEnumType> _enums;
        private ImmutableArray<IModelObject> _modelObjects;
        private ImmutableArray<object> _objects;
        private Dictionary<object, string>? _objectNames;

        public MetaModelGenerator(bool isMetaMetaModel, Modeling.Model model, Model.MetaModel metaModel, MetaMetaGraph graph)
        {
            _isMetaMetaModel = isMetaMetaModel;
            _model = model;
            _metaModel = metaModel;
            _graph = graph;
            _classes = _metaModel.Parent.Declarations.OfType<MetaClass>().ToImmutableArray();
            _enums = _metaModel.Parent.Declarations.OfType<MetaEnumType>().ToImmutableArray();
            _modelObjects = model.ModelObjects.ToImmutableArray();
            _objects = model.Objects.ToImmutableArray();
        }

        public bool IsMetaMetaModel => _isMetaMetaModel;
        public Modeling.Model Model => _model;
        public Model.MetaModel MetaModel => _metaModel;
        public string Namespace => _metaModel.Parent.FullName;
        public ImmutableArray<MetaClass> Classes => _classes;
        public ImmutableArray<MetaEnumType> Enums => _enums;
        public ImmutableArray<IModelObject> ModelObjects => _modelObjects;
        public ImmutableArray<object> Objects => _objects;
        public MetaMetaGraph Graph => _graph;

        public string ToCSharp(object? type)
        {
            type = ExtractMetaType(type);
            if (type is null) return string.Empty;
            if (type is MetaPrimitiveType mpt) type = mpt.Name;
            if (type is string stype) return PrimitiveTypeToString(stype);
            if (type is Type t) return $"global::{t.FullName}";
            if (type is MetaNullableType nt)
            {
                return $"{ToCSharp(nt.InnerType)}?";
            }
            if (type is MetaArrayType at)
            {
                return $"global::System.Collections.Generic.IList<{ToCSharp(at.ItemType)}>";
            }
            if (type is MetaClass mc && _classes.Contains(mc))
            {
                return mc.Name;
            }
            if (type is MetaType mt)
            {
                return $"global::{mt.FullName}";
            }
            if (type is TypeSymbol ts)
            {
                return SymbolDisplayFormat.FullyQualifiedFormat.ToString(ts);
            }
            return type.ToString();
        }

        public string ToCSharpImpl(object type)
        {
            return ToCSharp(type);
        }

        public bool HasSetter(MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> property)
        {
            return property.HasSetter && !property.Flags.HasFlag(ModelPropertyFlags.ReadOnly) && !property.Flags.HasFlag(ModelPropertyFlags.Collection);
        }

        public string ToCSharp(MetaClass<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> metaClass)
        {
            return $"{MetaModel.Name}.{metaClass.Name}Info";
        }

        public bool IsCollection(MetaPropertySlot<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> slot)
        {
            return slot.Flags.HasFlag(ModelPropertyFlags.Collection);
        }

        public string ToCSharp(MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> property)
        {
            return $"{MetaModel.Name}.{property.DeclaringType.Name}_{property.Name}";
        }

        public string ToCSharp(MetaOperation<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> op)
        {
            return $"{MetaModel.Name}.{op.DeclaringType.Name}_{op.Name}";
        }

        public string ToCSharp(ImmutableArray<MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> properties)
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

        public string ToCSharp(ImmutableArray<MetaOperation<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> operations)
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

        public string ToCSharpValue(object propertyType, object? value)
        {
            value = ExtractMetaType(value);
            if (propertyType == typeof(MetaDslx.CodeAnalysis.MetaType) || propertyType == typeof(Type) || propertyType == typeof(TypeSymbol))
            {
                if (value is MetaPrimitiveType pt) value = pt.Name;
                if (value is null) return "default";
                else if (value is string svalue) return $"typeof({PrimitiveTypeToString(svalue)})";
                else if (value is Type t) return $"typeof(global::{t.FullName})";
                else if (value is TypeSymbol ts) return $"typeof({SymbolDisplayFormat.FullyQualifiedFormat.ToString(ts)})";
                return $"__MetaType.FromModelObject((__IModelObject){GetName(value)})";
            }
            if (propertyType == typeof(bool))
            {
                return ((bool)value) ? "true" : "false";
            }
            if (propertyType == typeof(string))
            {
                return StringUtilities.EncodeString(value.ToString());
            }
            var type = value.GetType();
            if (type.IsPrimitive) return value.ToString();
            return GetName(value);
        }

        private string PrimitiveTypeToString(string type)
        {
            if (type == "type") return "__MetaType";
            else if (type == "symbol") return "__MetaSymbol";
            else if (type == "object" || type == "bool" || type == "char" || type == "string" ||
                type == "byte" || type == "sbyte" || type == "short" || type == "ushort" ||
                type == "int" || type == "uint" || type == "long" || type == "ulong" ||
                type == "float" || type == "double" || type == "decimal") return type;
            else return $"global::{type}";
        }

        public string ToCSharpValue(ModelProperty property, object? value)
        {
            var propertyType = property.Type;
            return ToCSharpValue(propertyType, value);
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

        private object? ExtractMetaType(object? type)
        {
            if (type is MetaDslx.CodeAnalysis.MetaType camt)
            {
                type = camt.OriginalModelObject;
                if (type is null && camt.SpecialType != CodeAnalysis.SpecialType.None) type = camt.FullName;
                if (type is null) type = camt.Original;
            }
            return type;
        }
    }
}