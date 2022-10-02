using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Analyzers
{
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Microsoft.CodeAnalysis.Text;

    [Generator]
    public class MetaModelGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            IncrementalValuesProvider<InterfaceDeclarationSyntax?> interfaceDeclarations = 
                context.SyntaxProvider.CreateSyntaxProvider(
                    predicate: static (s, _) => IsSyntaxTargetForGeneration(s),
                    transform: static (ctx, _) => GetSemanticTargetForGeneration(ctx))
                .Where(static intf => intf is not null);
            IncrementalValueProvider<(Compilation, ImmutableArray<InterfaceDeclarationSyntax>)> compilationAndInterfaces
                 = context.CompilationProvider.Combine(interfaceDeclarations.Collect());
            context.RegisterSourceOutput(compilationAndInterfaces, static (spc, source) => Execute(source.Item1, source.Item2, spc));
        }

        private static bool IsSyntaxTargetForGeneration(SyntaxNode node) => node is InterfaceDeclarationSyntax;

        private static InterfaceDeclarationSyntax? GetSemanticTargetForGeneration(GeneratorSyntaxContext context)
        {
            var interfaceDeclarationSyntax = (InterfaceDeclarationSyntax)context.Node;
            var intf = (INamedTypeSymbol?)context.SemanticModel.GetDeclaredSymbol(interfaceDeclarationSyntax);
            if (intf == null) return null;
            if (HasAttribute(intf, "MetaDslx.Modeling.MetaModelAttribute")) return interfaceDeclarationSyntax;
            if (HasAttribute(intf, "MetaDslx.Modeling.MetaClassAttribute")) return interfaceDeclarationSyntax;
            foreach (var type in intf.AllInterfaces)
            {
                if (HasAttribute(type, "MetaDslx.Modeling.MetaClassAttribute")) return interfaceDeclarationSyntax;
            }
            return null;
        }

        private static bool HasAttribute(INamedTypeSymbol type, string attributeName)
        {
            foreach (var attr in type.GetAttributes())
            {
                var attrName = attr.AttributeClass?.ToDisplayString();
                if (attrName == attributeName) return true;
            }
            return false;
        }

        private static void Execute(Compilation compilation, ImmutableArray<InterfaceDeclarationSyntax> metaInterfaces, SourceProductionContext context)
        {
            if (metaInterfaces.IsDefaultOrEmpty)
            {
                // nothing to do yet
                return;
            }

            context.AddSource("MetaModel.Implementation.g.cs", SourceText.From(result, Encoding.UTF8));
        }


    }
}
