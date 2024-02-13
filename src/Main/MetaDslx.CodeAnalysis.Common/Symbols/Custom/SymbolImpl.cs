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
        private static readonly __ObjectPool s_poolInstance = new __ObjectPool(() => new SymbolImpl(s_poolInstance), 32);

        private readonly IObjectPool _pool;

        protected SymbolImpl(IObjectPool pool)
            : base()
        {
            _pool = pool;
        }

        public static SymbolImpl GetInstance(Symbol wrapped)
        {
            var result = s_poolInstance.Allocate();
            global::System.Diagnostics.Debug.Assert(result.__Wrapped is null);
            result.__InitWrapped(wrapped);
            return result;
        }

        public void Free()
        {
            this.__ClearWrapped();
            _pool?.Free(this);
        }

        private SymbolInst _wrapped => (SymbolInst)__Wrapped;

        public override ISymbolFactory SymbolFactory
        {
            get
            {
                var container = this.ContainingModule;
                return container?.SymbolFactory;
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
            return null;
        }

        public virtual string? Complete_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return null;
        }

        public virtual ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<Symbol>.Empty;
        }

        public virtual ImmutableArray<AttributeSymbol> Complete_Attributes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<AttributeSymbol>.Empty;
        }

        public virtual void CompletePart_ComputeNonSymbolProperties(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
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
