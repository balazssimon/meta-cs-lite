using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpAssemblySymbol : AssemblySymbol
    {
        private IAssemblySymbol _csharpSymbol;

        public CSharpAssemblySymbol(IAssemblySymbol csharpSymbol)
        {
            _csharpSymbol = csharpSymbol;
        }

        public IAssemblySymbol CSharpSymbol => _csharpSymbol;

        public bool IsInteractive => _csharpSymbol.IsInteractive;

        public AssemblyIdentity Identity => _csharpSymbol.Identity;

        public INamespaceSymbol GlobalNamespace => throw new NotImplementedException();

        public IEnumerable<IModuleSymbol> Modules => throw new NotImplementedException();

        public ICollection<string> TypeNames => _csharpSymbol.TypeNames;

        public ICollection<string> NamespaceNames => _csharpSymbol.NamespaceNames;

        public bool MightContainExtensionMethods => _csharpSymbol.MightContainExtensionMethods;

        public SymbolKind Kind => _csharpSymbol.Kind;

        public string Language => _csharpSymbol.Language;

        public string MetadataName => _csharpSymbol.MetadataName;

        public int MetadataToken => _csharpSymbol.MetadataToken;

        public ISymbol ContainingSymbol => throw new NotImplementedException();

        public IAssemblySymbol ContainingAssembly => throw new NotImplementedException();

        public IModuleSymbol ContainingModule => throw new NotImplementedException();

        public INamedTypeSymbol ContainingType => throw new NotImplementedException();

        public INamespaceSymbol ContainingNamespace => throw new NotImplementedException();

        public bool IsDefinition => _csharpSymbol.IsDefinition;

        public bool IsStatic => _csharpSymbol.IsStatic;

        public bool IsVirtual => _csharpSymbol.IsVirtual;

        public bool IsOverride => _csharpSymbol.IsOverride;

        public bool IsAbstract => _csharpSymbol.IsAbstract;

        public bool IsSealed => _csharpSymbol.IsSealed;

        public bool IsExtern => _csharpSymbol.IsExtern;

        public bool IsImplicitlyDeclared => _csharpSymbol.IsImplicitlyDeclared;

        public bool CanBeReferencedByName => _csharpSymbol.CanBeReferencedByName;

        public ImmutableArray<Microsoft.CodeAnalysis.Location> Locations => throw new NotImplementedException();

        public ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference> DeclaringSyntaxReferences => throw new NotImplementedException();

        public Accessibility DeclaredAccessibility => throw new NotImplementedException();

        public ISymbol OriginalDefinition => throw new NotImplementedException();

        public bool HasUnsupportedMetadata => _csharpSymbol.HasUnsupportedMetadata;

        public void Accept(SymbolVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public TResult? Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            throw new NotImplementedException();
        }

        public bool Equals(ISymbol? other, SymbolEqualityComparer equalityComparer)
        {
            throw new NotImplementedException();
        }

        public bool Equals(ISymbol? other)
        {
            throw new NotImplementedException();
        }

        public ImmutableArray<Microsoft.CodeAnalysis.AttributeData> GetAttributes()
        {
            throw new NotImplementedException();
        }

        public string? GetDocumentationCommentId()
        {
            return _csharpSymbol.GetDocumentationCommentId();
        }

        public string? GetDocumentationCommentXml(CultureInfo? preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default)
        {
            return _csharpSymbol.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
        }

        public ImmutableArray<INamedTypeSymbol> GetForwardedTypes()
        {
            throw new NotImplementedException();
        }

        public AssemblyMetadata? GetMetadata()
        {
            return _csharpSymbol.GetMetadata();
        }

        public INamedTypeSymbol? GetTypeByMetadataName(string fullyQualifiedMetadataName)
        {
            throw new NotImplementedException();
        }

        public bool GivesAccessTo(IAssemblySymbol toAssembly)
        {
            throw new NotImplementedException();
        }

        public INamedTypeSymbol? ResolveForwardedType(string fullyQualifiedMetadataName)
        {
            throw new NotImplementedException();
        }

        public ImmutableArray<SymbolDisplayPart> ToDisplayParts(SymbolDisplayFormat? format = null)
        {
            throw new NotImplementedException();
        }

        public string ToDisplayString(SymbolDisplayFormat? format = null)
        {
            throw new NotImplementedException();
        }

        public ImmutableArray<SymbolDisplayPart> ToMinimalDisplayParts(SemanticModel semanticModel, int position, SymbolDisplayFormat? format = null)
        {
            throw new NotImplementedException();
        }

        public string ToMinimalDisplayString(SemanticModel semanticModel, int position, SymbolDisplayFormat? format = null)
        {
            throw new NotImplementedException();
        }
    }
}
