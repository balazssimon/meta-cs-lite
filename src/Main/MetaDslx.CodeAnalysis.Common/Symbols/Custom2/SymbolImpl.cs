using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.CodeAnalysis.Symbols.Source;
using Roslyn.Utilities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System;
using MetaDslx.CodeAnalysis.Text;
using System.Xml.Linq;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols.__Impl;

namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;
    using __ObjectPool = global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<SymbolImpl>;

    public class SymbolImpl : SymbolImplBase
    {
        public override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences
        {
            get
            {
                return MergedDeclaration?.SyntaxReferences ?? ImmutableArray<SyntaxNodeOrToken>.Empty;
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                return MergedDeclaration?.NameLocations.Cast<SourceLocation, Location>() ?? this.ContainingModule?.Locations ?? ImmutableArray<Location>.Empty;
            }
        }

        public override AssemblySymbol? ContainingAssembly
        {
            get
            {
                // Default implementation gets the container's assembly.
                var container = this.ContainingSymbol;
                return container?.ContainingAssembly;
            }
        }

        public override Compilation? DeclaringCompilation
        {
            get
            {
                if (this is AssemblySymbol)
                {
                    Debug.Assert(!this.IsSourceSymbol, "SourceAssemblySymbol must override DeclaringCompilation");
                }
                if (this is ModuleSymbol)
                {
                    Debug.Assert(!this.IsSourceSymbol, "SourceModuleSymbol must override DeclaringCompilation");
                }
                return this.ContainingModule.DeclaringCompilation;
            }
        }

        public override ModuleSymbol? ContainingModule
        {
            get
            {
                // Default implementation gets the container's module.
                var container = this.ContainingSymbol;
                if (container is ModuleSymbol moduleSymbol) return moduleSymbol;
                return container?.ContainingModule;
            }
        }

        public override DeclarationSymbol? ContainingDeclaration
        {
            get
            {
                Symbol container = this.ContainingSymbol;
                while (container is not null)
                {
                    if (container is DeclarationSymbol result)
                    {
                        return result;
                    }
                    container = container.ContainingSymbol;
                }
                return null;
            }
        }

        public override TypeSymbol? ContainingType
        {
            get
            {
                Symbol container = this.ContainingSymbol;
                while (container is not null)
                {
                    if (container is TypeSymbol result)
                    {
                        return result;
                    }
                    container = container.ContainingSymbol;
                }
                return null;
            }
        }

        public override NamespaceSymbol? ContainingNamespace
        {
            get
            {
                Symbol container = this.ContainingSymbol;
                while (container is not null)
                {
                    if (container is NamespaceSymbol result)
                    {
                        return result;
                    }
                    container = container.ContainingSymbol;
                }
                return null;
            }
        }

        public override LexicalSortKey GetLexicalSortKey()
        {
            var declaringCompilation = this.DeclaringCompilation;
            if (declaringCompilation is null) return LexicalSortKey.NotInSource;
            var sourceLocation = this.Locations.OfType<SourceLocation>().FirstOrDefault();
            if (sourceLocation is null) return LexicalSortKey.NotInSource;
            else return new LexicalSortKey(sourceLocation, declaringCompilation);
        }

        #region Use-Site Diagnostics

        public override bool HasUnsupportedMetadata => false;

        #endregion

        public override string GetDocumentationCommentId()
        {
            return "";
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default)
        {
            return "";
        }

        #region Completion graph

        public virtual void CompletePart_Initialize(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
        }

        public virtual string? Complete_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetName(__Wrapped._underlyingObject, diagnostics, cancellationToken);
        }

        public virtual string? Complete_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetMetadataName(__Wrapped._underlyingObject, diagnostics, cancellationToken);
        }

        public virtual ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.CreateContainedSymbols(this, diagnostics, cancellationToken);
        }

        public virtual ImmutableArray<AttributeSymbol> Complete_Attributes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValues<AttributeSymbol>(this, nameof(Attributes), diagnostics, cancellationToken);
        }

        public virtual void CompletePart_ComputeNonSymbolProperties(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            ContainingModule!.SymbolFactory.ComputeNonSymbolProperties(this, diagnostics, cancellationToken);
        }

        public virtual void CompletePart_Finalize(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
        }

        public virtual void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
        }

        #endregion
    }
}
