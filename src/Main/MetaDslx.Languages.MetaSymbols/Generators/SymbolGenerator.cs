﻿using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Languages.MetaSymbols.Model;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MetaDslx.Languages.MetaSymbols.Generators
{
    public partial class SymbolGenerator
    {
        private Dictionary<Symbol, ImmutableArray<Symbol>> _baseTypes = new Dictionary<Symbol, ImmutableArray<Symbol>>();
        private Dictionary<Symbol, ImmutableArray<string>> _phases = new Dictionary<Symbol, ImmutableArray<string>>();
        private Dictionary<Symbol, ImmutableArray<Property>> _properties = new Dictionary<Symbol, ImmutableArray<Property>>();
        private Dictionary<Symbol, ImmutableArray<Operation>> _operations = new Dictionary<Symbol, ImmutableArray<Operation>>();

        public string GetIntfName(Symbol context, Symbol type)
        {
            if (type.Parent == context.Parent) return type.Name;
            else return $"global::{type.FullName}";
        }

        public string GetBaseName(Symbol context, Symbol type)
        {
            if (type.Parent == context.Parent) return $"{type.Name}Base";
            else return $"global::{type.FullName}Base";
        }

        public string GetImplName(Symbol context, Symbol type)
        {
            if (type.Parent == context.Parent) return $"{type.Name}Impl";
            else return $"global::{type.FullName}Impl";
        }

        public string GetTypeName(Symbol context, TypeReference type)
        {
            var typeName = GetTypeName(context, type.Type);
            if (type.Type.SpecialType != SpecialType.MetaDslx_CodeAnalysis_MetaType &&
                type.Type.SpecialType != SpecialType.MetaDslx_CodeAnalysis_MetaSymbol)
            {
                if (type.IsNullable) typeName = $"{typeName}?";
            }
            if (type.Dimensions > 0)
            {
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                for (int i = 0; i < type.Dimensions; i++)
                {
                    sb.Append("ImmutableArray<");
                }
                sb.Append(typeName);
                for (int i = 0; i < type.Dimensions; i++)
                {
                    sb.Append(">");
                }
                typeName = builder.ToStringAndFree();
            }
            return typeName;
        }

        public string GetTypeName(Symbol context, MetaType type)
        {
            if (type.OriginalModelObject is Symbol symbol)
            {
                return GetIntfName(context, symbol);
            }
            else
            {
                return $"global::{type.CSharpFullName}";
            }
        }

        public string? GetFieldName(Property prop)
        {
            if (prop.IsWeak) return $"s_{prop.Name}";
            return $"_{prop.Name.ToCamelCase()}";
        }

        public string? GetFieldType(Symbol context, Property prop)
        {
            if (prop.IsWeak)
            {
                if (prop.Type.Type.IsValueType) return $"static ConditionalWeakTable<Symbol, object>";
                else return $"static ConditionalWeakTable<Symbol, {GetTypeName(context, prop.Type)}>";
            }
            else
            {
                return GetTypeName(context, prop.Type);
            }
        }

        public string GetDefaultValue(Symbol context, Property prop)
        {
            if (prop.DefaultValue is not null) return prop.DefaultValue.ToString();
            else if (prop.Type.Dimensions > 0) return $"{GetTypeName(context, prop.Type)}.Empty";
            else return "default";
        }

        public ImmutableArray<Symbol> GetBaseTypes(Symbol symbol)
        {
            var visited = PooledHashSet<Symbol>.GetInstance();
            ComputeBaseTypes(symbol, visited);
            visited.Free();
            if (_baseTypes.TryGetValue(symbol, out var baseTypes)) return baseTypes;
            else return ImmutableArray<Symbol>.Empty;
        }

        private void ComputeBaseTypes(Symbol symbol, HashSet<Symbol> visited)
        {
            if (_baseTypes.ContainsKey(symbol) || visited.Contains(symbol)) return;
            visited.Add(symbol);
            var baseTypes = ArrayBuilder<Symbol>.GetInstance();
            foreach (var baseSymbol in symbol.BaseTypes)
            {
                if (!baseTypes.Contains(baseSymbol) && baseSymbol != symbol)
                {
                    baseTypes.Add(baseSymbol);
                    ComputeBaseTypes(baseSymbol, visited);
                    if (_baseTypes.TryGetValue(baseSymbol, out var baseSymbols))
                    {
                        foreach (var bs in baseSymbols)
                        {
                            if (!baseTypes.Contains(bs)) baseTypes.Add(bs);
                        }
                    }
                }
            }
            _baseTypes.Add(symbol, baseTypes.ToImmutableAndFree());
        }

        public ImmutableArray<string> GetPhases(Symbol symbol)
        {
            if (_phases.TryGetValue(symbol, out var phases)) return phases;
            var phs = ArrayBuilder<string>.GetInstance();
            foreach (var decl in symbol.Declarations)
            {
                if (!string.IsNullOrEmpty(decl.Name)) phs.Add(decl.Name);
            }
            foreach (var bs in GetBaseTypes(symbol))
            {
                foreach (var phase in GetPhases(bs))
                {
                    if (!phs.Contains(phase))
                    {
                        phs.Add(phase);
                    }
                }
            }
            var result = phs.ToImmutableAndFree();
            _phases.Add(symbol, result);
            return result;
        }

        public ImmutableArray<Property> GetProperties(Symbol symbol)
        {
            if (_properties.TryGetValue(symbol, out var properties)) return properties;
            var props = ArrayBuilder<Property>.GetInstance();
            props.AddRange(symbol.Properties);
            foreach (var bs in GetBaseTypes(symbol))
            {
                foreach (var prop in bs.Properties)
                {
                    if (!props.Where(p => p.Name == prop.Name).Any())
                    {
                        props.Add(prop);
                    }
                }
            }
            var result = props.ToImmutableAndFree();
            _properties.Add(symbol, result);
            return result;
        }

        public ImmutableArray<Operation> GetOperations(Symbol symbol)
        {
            if (_operations.TryGetValue(symbol, out var operations)) return operations;
            var ops = ArrayBuilder<Operation>.GetInstance();
            ops.AddRange(symbol.Operations);
            foreach (var bs in GetBaseTypes(symbol))
            {
                foreach (var op in bs.Operations)
                {
                    if (!ops.Where(o => o.Name == op.Name).Any())
                    {
                        ops.Add(op);
                    }
                }
            }
            var result = ops.ToImmutableAndFree();
            _operations.Add(symbol, result);
            return result;
        }

        public ImmutableArray<Property> GetPhaseProperties(Symbol symbol, string phase)
        {
            var props = ArrayBuilder<Property>.GetInstance();
            foreach (var prop in GetProperties(symbol))
            {
                if (prop.Name == phase || prop.Phase?.Name == phase)  props.Add(prop);
            }
            return props.ToImmutableAndFree();
        }
    }
}