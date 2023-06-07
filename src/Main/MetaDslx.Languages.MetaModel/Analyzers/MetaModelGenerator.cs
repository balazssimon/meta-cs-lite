using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Languages.MetaModel.Analyzers
{
    using MetaDslx.Languages.MetaModel.Model;
    using MetaDslx.CodeAnalysis.PooledObjects;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Microsoft.CodeAnalysis.Text;
    using System.Diagnostics;
    using System.Linq;
    using System.Xml.Linq;
    using MetaDslx.Languages.MetaModel.Generators;
    using System.IO;

    [Generator]
    public class MetaModelGenerator : IIncrementalGenerator
    {
        private static readonly DiagnosticDescriptor MultipleMetaModelsInNamespace =
            new DiagnosticDescriptor("MM0001", "Multiple metamodels", "There is already another metamodel '{0}' defined in the namespace '{1}' of '{2}'", "Generator", DiagnosticSeverity.Error, true);
        private static readonly DiagnosticDescriptor MetaModelAndClassAttributesMixed =
            new DiagnosticDescriptor("MM0002", "Mixed attributes", "MetaModelAttribute and MetaClassAttribute cannot be used at the same time", "Generator", DiagnosticSeverity.Error, true);
        private static readonly DiagnosticDescriptor MetaModelIsMissingInNamespace =
            new DiagnosticDescriptor("MM0003", "Missing metamodel", "An interface with a MetaModelAttribute is missing in the namespace '{0}' of '{1}'", "Generator", DiagnosticSeverity.Error, true);

        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            IncrementalValuesProvider<InterfaceDeclarationSyntax> interfaceDeclarations = 
                context.SyntaxProvider.CreateSyntaxProvider(
                    predicate: static (s, _) => IsSyntaxTargetForGeneration(s),
                    transform: static (ctx, _) => GetSemanticTargetForGeneration(ctx))
                .Where(static intf => intf is not null)
                .Select(static (intf, _) => intf!);
            IncrementalValueProvider<(Compilation, ImmutableArray<InterfaceDeclarationSyntax>)> compilationAndInterfaces
                 = context.CompilationProvider.Combine(interfaceDeclarations.Collect());
            context.RegisterSourceOutput(compilationAndInterfaces, static (spc, source) => Execute(source.Item1, source.Item2, spc));
        }

        private static bool IsSyntaxTargetForGeneration(SyntaxNode node) => node is InterfaceDeclarationSyntax;

        private static InterfaceDeclarationSyntax? GetSemanticTargetForGeneration(GeneratorSyntaxContext context)
        {
            var interfaceDeclarationSyntax = (InterfaceDeclarationSyntax)context.Node;
            var intf = context.SemanticModel.GetDeclaredSymbol(interfaceDeclarationSyntax);
            if (intf == null) return null;
            if (HasAttribute(intf, MetaModelInfo.MetaModelAttributeName, false)) return interfaceDeclarationSyntax;
            if (HasAttribute(intf, MetaClass.MetaClassAttributeName, true)) return interfaceDeclarationSyntax;
            return null;
        }

        private static bool HasAttribute(INamedTypeSymbol type, string attributeName, bool checkBaseTypes)
        {
            foreach (var attr in type.GetAttributes())
            {
                var attrName = attr.AttributeClass?.ToDisplayString();
                if (attrName == attributeName) return true;
            }
            if (checkBaseTypes)
            {
                foreach (var baseType in type.AllInterfaces)
                {
                    if (HasAttribute(baseType, attributeName, false)) return true;
                }
            }
            return false;
        }


        private static void Execute(Compilation compilation, ImmutableArray<InterfaceDeclarationSyntax> metaInterfaces, SourceProductionContext context)
        {
            try
            {
                if (metaInterfaces.IsDefaultOrEmpty)
                {
                    return;
                }
                var models = new Dictionary<string, ModelNamespace>();
                foreach (var metaInterface in metaInterfaces)
                {
                    var sm = compilation.GetSemanticModel(metaInterface.SyntaxTree);
                    var intf = sm.GetDeclaredSymbol(metaInterface);
                    if (intf != null)
                    {
                        var ns = intf.ContainingNamespace;
                        if (ns != null)
                        {
                            var nsName = ns.ToDisplayString();
                            if (!models.TryGetValue(nsName, out var modelNs))
                            {
                                modelNs = new ModelNamespace() { Namespace = ns };
                                models.Add(nsName, modelNs);
                            }
                            if (HasAttribute(intf, MetaModelInfo.MetaModelAttributeName, false))
                            {
                                if (modelNs.Model != null && modelNs.Model.Name != intf.Name)
                                {
                                    context.ReportDiagnostic(Diagnostic.Create(MultipleMetaModelsInNamespace, intf.Locations.FirstOrDefault(), modelNs.Model.Name, nsName, intf.Name));
                                }
                                else if (modelNs.Model == null)
                                {
                                    modelNs.Model = intf;
                                }
                                if (HasAttribute(intf, MetaClass.MetaClassAttributeName, true))
                                {
                                    context.ReportDiagnostic(Diagnostic.Create(MetaModelAndClassAttributesMixed, intf.Locations.FirstOrDefault()));
                                }
                            }
                            else if (HasAttribute(intf, MetaClass.MetaClassAttributeName, true))
                            {
                                if (modelNs.Classes == null)
                                {
                                    modelNs.Classes = ArrayBuilder<INamedTypeSymbol>.GetInstance();
                                }
                                modelNs.Classes.Add(intf);
                            }
                        }
                    }
                }
                var metaModels = ArrayBuilder<MetaModelInfo>.GetInstance();
                foreach (var nsName in models.Keys)
                {
                    var modelNs = models[nsName];
                    if (modelNs.Model != null)
                    {
                        var metaModel = new MetaModelInfo(compilation, context, modelNs.Model, modelNs.Classes?.ToImmutable() ?? ImmutableArray<INamedTypeSymbol>.Empty);
                        metaModels.Add(metaModel);
                    }
                    else if (modelNs.Classes != null && modelNs.Classes.Count > 0)
                    {
                        context.ReportDiagnostic(Diagnostic.Create(MetaModelIsMissingInNamespace, modelNs.Classes[0].Locations.FirstOrDefault(), nsName, modelNs.Classes[0].Name));
                    }
                    modelNs.Classes?.Free();
                }
                // TODO: separate generated source files
                var metaModelImplementationCode = ModelImplementationGenerator.Generate(metaModels.ToImmutableAndFree());
                context.AddSource("MetaModel.Implementation.g.cs", SourceText.From(metaModelImplementationCode, Encoding.UTF8));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private class ModelNamespace
        {
            public INamespaceSymbol Namespace;
            public INamedTypeSymbol? Model;
            public ArrayBuilder<INamedTypeSymbol>? Classes;
        }
    }
}
