using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Languages.MetaSymbols.Model;
using Roslyn.Utilities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace MetaDslx.Languages.MetaSymbols.Generators
{
    public partial class SymbolGenerator
    {
        private DiagnosticBag _diagnostics = new DiagnosticBag();

        private Dictionary<Symbol, ImmutableArray<Symbol>> _baseTypes = new Dictionary<Symbol, ImmutableArray<Symbol>>();
        private Dictionary<Symbol, ImmutableArray<string>> _phases = new Dictionary<Symbol, ImmutableArray<string>>();
        private Dictionary<Symbol, ImmutableArray<Property>> _properties = new Dictionary<Symbol, ImmutableArray<Property>>();
        private Dictionary<Symbol, ImmutableArray<Operation>> _operations = new Dictionary<Symbol, ImmutableArray<Operation>>();
        private Dictionary<Operation, string> _operationUniqueNames = new Dictionary<Operation, string>();
        private Dictionary<string, int> _uniqueCounter = new Dictionary<string, int>();

        public ImmutableArray<Diagnostic> Diagnostics => _diagnostics.ToReadOnly();

        public string GetIntfName(Symbol context, Symbol type)
        {
            if (type.FullName == "MetaDslx.CodeAnalysis.Symbols.Symbol")
            {
                if (type.Parent == context.Parent) return "Symbol";
                else return $"global::{type.FullName}";
            }
            else
            {
                if (type.Parent == context.Parent) return $"{type.Name}Symbol";
                else return $"global::{type.FullName}Symbol";
            }
        }

        public string GetInstName(Symbol context, Symbol type)
        {
            if (type.Parent == context.Parent) return $"{type.Name}SymbolInst";
            else return $"global::{type.FullName}SymbolInst";
        }

        public string GetBaseName(Symbol context, Symbol type)
        {
            if (type.Parent == context.Parent) return $"Impl.{type.Name}SymbolImpl";
            else return $"global::{type.Parent?.FullName}.Impl.{type.Name}SymbolImpl";
        }

        public string GetImplName(Symbol context, Symbol type)
        {
            if (type.Parent == context.Parent) return $"{type.Name}SymbolImpl";
            else return $"global::{type.FullName}SymbolImpl";
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
                    sb.Append("global::System.Collections.Immutable.ImmutableArray<");
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
            else if (type.CSharpKeyword is not null)
            {
                return type.CSharpKeyword;
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

        public string? GetParamName(Property prop)
        {
            return prop.Name.ToCamelCase().EscapeCSharpKeyword();
        }

        public string? GetFieldType(Symbol context, Property prop)
        {
            if (prop.IsWeak)
            {
                if (prop.Type.Type.IsValueType || prop.Type.Dimensions > 0) return $"global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>";
                else return $"global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, {GetTypeName(context, prop.Type)}>";
            }
            else
            {
                return GetTypeName(context, prop.Type);
            }
        }

        public string? GetFieldName(Operation op)
        {
            return $"s_{GetUniqueName(op)}";
        }

        public string? GetFieldType(Symbol context, Operation op)
        {
            string valueType;
            if (op.Parameters.Count == 0)
            {
                valueType = op.ReturnType.Type.IsValueType || op.ReturnType.Dimensions > 0 ? "object" : GetTypeName(context, op.ReturnType);
            }
            else
            {
                valueType = $"global::System.Collections.Concurrent.ConcurrentDictionary<{GetCacheKeyType(context, op)}, {GetTypeName(context, op.ReturnType)}>";
            }
            return $"global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, {valueType}>";
        }

        public string? GetCacheKeyType(Symbol context, Operation op)
        {
            if (op.Parameters.Count == 0)
            {
                return null;
            }
            else if (op.Parameters.Count == 1)
            {
                var param = op.Parameters[0];
                return GetTypeName(context, param.Type);
            }
            else
            {
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                foreach (var param in op.Parameters)
                {
                    if (sb.Length == 0) sb.Append("(");
                    else sb.Append(", ");
                    var paramType = GetTypeName(context, param.Type);
                    sb.Append(paramType);
                }
                sb.Append(")");
                return builder.ToStringAndFree();
            }
        }

        public string GetDefaultValue(Symbol context, Property prop)
        {
            if (prop.DefaultValue is not null) return prop.DefaultValue.ToString();
            else if (prop.Type.Dimensions > 0) return $"{GetTypeName(context, prop.Type)}.Empty";
            else return "default";
        }

        public string GetConstDefaultValue(Symbol context, Property prop)
        {
            if (prop.DefaultValue is not null) return prop.DefaultValue.ToString();
            else return "default";
        }

        public string GetDefaultValue(Symbol context, TypeReference type)
        {
            if (type.Dimensions > 0) return $"{GetTypeName(context, type)}.Empty";
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

        public ImmutableArray<string> GetAllPhases(Symbol? symbol)
        {
            if (symbol is null) return ImmutableArray<string>.Empty;
            var phs = ArrayBuilder<string>.GetInstance();
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
            foreach (var phase in GetPhases(symbol))
            {
                if (!phs.Contains(phase))
                {
                    phs.Add(phase);
                }
            }
            var result = phs.ToImmutableAndFree();
            return result;
        }

        public ImmutableArray<string> GetPhases(Symbol? symbol)
        {
            if (symbol is null) return ImmutableArray<string>.Empty;
            if (_phases.TryGetValue(symbol, out var phases)) return phases;
            var phs = ArrayBuilder<string>.GetInstance();
            foreach (var decl in symbol.Declarations)
            {
                if (decl is Property prop && !prop.IsPlain)
                {
                    if (prop.Phase is null) phs.Add(prop.Name);
                }
                if (decl is Operation op)
                {
                    if (op.IsPhase) phs.Add(op.Name);
                }
            }
            var result = phs.ToImmutableAndFree();
            _phases.Add(symbol, result);
            return result;
        }

        public ImmutableArray<Property> GetProperties(Symbol? symbol)
        {
            if (symbol is null) return ImmutableArray<Property>.Empty;
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

        public ImmutableArray<Operation> GetOperations(Symbol? symbol)
        {
            if (symbol is null) return ImmutableArray<Operation>.Empty;
            if (_operations.TryGetValue(symbol, out var operations)) return operations;
            var ops = ArrayBuilder<Operation>.GetInstance();
            ops.AddRange(symbol.Operations/*.Where(o => !o.IsPhase)*/);
            foreach (var op in symbol.Operations)
            {
                if (!_uniqueCounter.ContainsKey(op.Name))
                {
                    _uniqueCounter.Add(op.Name, 0);
                }
                var uniqueId = _uniqueCounter[op.Name] + 1;
                _uniqueCounter[op.Name] = uniqueId;
                var uniqueName = $"{op.Name}{uniqueId}";
                _operationUniqueNames.Add(op, uniqueName);
                if (op.IsCached)
                {
                    if (op.ReturnType.Type.SpecialType == SpecialType.System_Void)
                    {
                        _diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_CodeGenerationError, op.ReturnType.MSourceLocation, $"Return type must not be void if the result of the operation is to be cached."));
                    }
                    /*foreach (var param in op.Parameters)
                    {
                        if (param.Type.Dimensions > 0)
                        {
                            _diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_CodeGenerationError, param.MSourceLocation, $"Parameter '{param.Name}' must be a simple value, not an array, if the result of the operation is to be cached."));
                        }
                    }*/
                }
            }
            foreach (var bs in GetBaseTypes(symbol))
            {
                foreach (var op in bs.Operations)
                {
                    ops.Add(op);
                }
            }
            var result = ops.ToImmutableAndFree();
            _operations.Add(symbol, result);
            return result;
        }

        public string GetUniqueName(Operation op)
        {
            if (!_operationUniqueNames.ContainsKey(op)) GetOperations(op.MParent as Symbol);
            if (_operationUniqueNames.TryGetValue(op, out var uniqueName)) return uniqueName;
            else return string.Empty;
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
