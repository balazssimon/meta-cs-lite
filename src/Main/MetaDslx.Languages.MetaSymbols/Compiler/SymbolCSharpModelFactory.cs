using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.Languages.MetaSymbols.Compiler
{
    using ISymbol = Microsoft.CodeAnalysis.ISymbol;
    using INamedTypeSymbol = Microsoft.CodeAnalysis.INamedTypeSymbol;
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;
    using SymbolKind = Microsoft.CodeAnalysis.SymbolKind;
    using TypeKind = Microsoft.CodeAnalysis.TypeKind;
    using SymbolsModelMultiFactory = MetaDslx.Languages.MetaSymbols.Model.SymbolsModelMultiFactory;

    internal class SymbolCSharpModelFactory : CSharpModelFactory
    {
        private SymbolsModelMultiFactory _modelFactory = new SymbolsModelMultiFactory();

        public override IModelObject? Create(Symbol container, ISymbol csharpSymbol, MetaDslx.Modeling.Model model, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (csharpSymbol.Name.EndsWith("Symbol") && csharpSymbol.Kind == SymbolKind.NamedType && ((INamedTypeSymbol)csharpSymbol).TypeKind == TypeKind.Class)
            {
                var attrs = csharpSymbol.GetAttributes();
                if (attrs.Any(attr => attr.AttributeClass?.Name == "SymbolAttribute"/* && attr.AttributeClass.ContainingNamespace.ToDisplayString(Microsoft.CodeAnalysis.SymbolDisplayFormat.FullyQualifiedFormat) == "global::MetaDslx.CodeAnalysis.Symbols"*/))
                {
                    var symbol = _modelFactory.Symbol(model);
                    symbol.MRootNamespace = csharpSymbol.ContainingNamespace.ToDisplayString(Microsoft.CodeAnalysis.SymbolDisplayFormat.CSharpErrorMessageFormat);
                    var name = csharpSymbol.Name;
                    if (name is not null && name.EndsWith("Symbol") && name != "Symbol") name = name.Substring(0, name.Length - 6);
                    symbol.Name = name;
                    return symbol;
                }
            }
            if (container.Name.EndsWith("Symbol") && container.ModelObject is MetaDslx.Languages.MetaSymbols.Model.Symbol containerSymbol && csharpSymbol.Kind == SymbolKind.Property && !csharpSymbol.IsStatic && !csharpSymbol.IsOverride)
            {
                var symbol = _modelFactory.Property(model);
                symbol.Name = csharpSymbol.Name;
                containerSymbol.Properties.Add(symbol);
                symbol.IsAbstract = csharpSymbol.IsAbstract;
                var attrs = csharpSymbol.GetAttributes();
                var derivedAttr = attrs.Where(attr => attr.AttributeClass?.Name == "DerivedAttribute").FirstOrDefault();
                if (derivedAttr is not null)
                {
                    symbol.IsDerived = true;
                    symbol.IsCached = derivedAttr.NamedArguments.Any(arg => arg.Key == "Cached" && (arg.Value.Value as bool?) == true);
                }
                symbol.IsWeak = attrs.Any(attr => attr.AttributeClass?.Name == "WeakAttribute");
                //symbol.Phase = attrs.Where(attr => attr.AttributeClass?.Name == "PhaseAttribute" && attr.ConstructorArguments.Length > 0).FirstOrDefault().ConstructorArguments[0].Value as string;
                var isModelProperty = attrs.Any(attr => attr.AttributeClass?.Name == "ModelPropertyAttribute");
                symbol.IsPlain = !symbol.IsDerived && !isModelProperty;
                var csharpProp = (IPropertySymbol)csharpSymbol;
                var propTypeSymbol = container.SymbolFactory.GetSymbol<TypeSymbol>(csharpProp.Type, diagnostics, cancellationToken);
                var type = MetaType.FromTypeSymbol(propTypeSymbol);
                var isNullable = false;
                var dimensions = 0;
                while (true)
                {
                    if (type.TryExtractNullableType(out type)) isNullable = true;
                    if (type.TryExtractCollectionType(out type)) ++dimensions;
                    else break;
                }
                isNullable = type.TryExtractNullableType(out type);
                var propType = _modelFactory.TypeReference(model);
                propType.IsNullable = isNullable;
                propType.Dimensions = dimensions;
                propType.Type = type;
                symbol.Type = propType;
                return symbol;
            }
            return null;
        }
    }
}
