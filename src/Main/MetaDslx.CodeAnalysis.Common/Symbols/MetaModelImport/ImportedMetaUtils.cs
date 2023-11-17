using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.MetaModelImport
{
    internal static class ImportedMetaUtils
    {
        private const string IModelObjectFullName = "MetaDslx.Modeling.IModelObject";
        private const string SymbolFullName = "MetaDslx.CodeAnalysis.Symbols.Symbol";

        public static ImmutableArray<CSharpTypeSymbol> CollectTypes(NamespaceSymbol namespaceSymbol, bool collectSymbols)
        {
            var types = ArrayBuilder<CSharpTypeSymbol>.GetInstance();
            if (namespaceSymbol is CSharpNamespaceSymbol csns)
            {
                CollectTypes(csns, types, collectSymbols);
            }
            else
            {
                foreach (var ns in namespaceSymbol.ConstituentNamespaces.OfType<CSharpNamespaceSymbol>())
                {
                    CollectTypes(ns, types, collectSymbols);
                }
            }
            return types.ToImmutableAndFree();
        }

        private static void CollectTypes(CSharpNamespaceSymbol csns, ArrayBuilder<CSharpTypeSymbol> types, bool collectSymbols)
        {
            foreach (CSharpTypeSymbol type in csns.GetTypeMembers())
            {
                var typeKind = type.CSharpSymbol.TypeKind;
                if (typeKind == Microsoft.CodeAnalysis.TypeKind.Enum)
                {
                    types.Add(type);
                }
                else if ((typeKind == Microsoft.CodeAnalysis.TypeKind.Class || typeKind == Microsoft.CodeAnalysis.TypeKind.Interface) && ConsiderType(type, collectSymbols))
                {
                    types.Add(type);
                }
            }
        }

        private static bool ConsiderType(CSharpTypeSymbol type, bool collectSymbols)
        {
            if (collectSymbols)
            {
                return type.AllBaseTypes.Any(bt => bt.Name == "Symbol" && SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(bt) == SymbolFullName);
            }
            else
            {
                return type.AllBaseTypes.Any(bt => bt.Name == "IModelObject" && SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(bt) == IModelObjectFullName);
            }
        }
    }
}
