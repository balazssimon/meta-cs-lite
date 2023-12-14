using MetaDslx.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public partial class TypeSymbol
    {
        private class BaseTypeInfo
        {
            private readonly TypeSymbol _symbol;
            // all direct base types
            private readonly ImmutableArray<TypeSymbol> _baseTypes;
            // all direct and indirect base types
            private ImmutableArray<TypeSymbol> _allBaseTypes;

            public BaseTypeInfo(TypeSymbol symbol, ImmutableArray<TypeSymbol> baseTypes)
            {
                _symbol = symbol;
                _baseTypes = baseTypes;
            }

            public ImmutableArray<TypeSymbol> BaseTypes => _baseTypes;

            public ImmutableArray<TypeSymbol> AllBaseTypes
            {
                get
                {
                    if (_allBaseTypes.IsDefault)
                    {
                        ImmutableInterlocked.InterlockedInitialize(ref _allBaseTypes, MakeAllBaseTypes());
                    }
                    return _allBaseTypes;
                }
            }

            // TODO:MetaDslx
            public ImmutableDictionary<TypeSymbol, TypeSymbol> BaseTypesAndTheirBaseTypes => ImmutableDictionary<TypeSymbol, TypeSymbol>.Empty;
            // TODO:MetaDslx
            public ImmutableDictionary<DeclarationSymbol, DeclarationSymbol> ImplementationForBaseMemberMap => ImmutableDictionary<DeclarationSymbol, DeclarationSymbol>.Empty;
            // TODO:MetaDslx
            public ImmutableDictionary<DeclarationSymbol, DeclarationSymbol> ExplicitBaseTypeImplementationMap => ImmutableDictionary<DeclarationSymbol, DeclarationSymbol>.Empty;

            public bool IsDefault => _symbol == null && _allBaseTypes.IsDefault;

            /// Produce all implemented interfaces in topologically sorted order. We use
            /// TypeSymbol.Interfaces as the source of edge data, which has had cycles and infinitely
            /// long dependency cycles removed. Consequently, it is possible (and we do) use the
            /// simplest version of Tarjan's topological sorting algorithm.
            private ImmutableArray<TypeSymbol> MakeAllBaseTypes()
            {
                var result = ArrayBuilder<TypeSymbol>.GetInstance();
                var visited = new HashSet<TypeSymbol>();
                for (int i = _baseTypes.Length - 1; i >= 0; i--)
                {
                    AddAllBaseTypes(_baseTypes[i], visited, result);
                }
                result.ReverseContents();
                return result.ToImmutableAndFree();
            }

            private static void AddAllBaseTypes(TypeSymbol baseType, HashSet<TypeSymbol> visited, ArrayBuilder<TypeSymbol> result)
            {
                if (visited.Add(baseType))
                {
                    ImmutableArray<TypeSymbol> baseTypes = baseType.BaseTypes;
                    for (int i = baseTypes.Length - 1; i >= 0; i--)
                    {
                        var nextBaseType = baseTypes[i];
                        AddAllBaseTypes(nextBaseType, visited, result);
                    }
                    result.Add(baseType);
                }
            }

        }
    }
}
