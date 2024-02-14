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
using System.Collections.Concurrent;

namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;

    public class SymbolImplBase : Symbol
    {
        private static ConcurrentDictionary<Type, IObjectPool> s_pools = new ConcurrentDictionary<Type, IObjectPool>();
        private IObjectPool _pool;
        private Symbol? _wrapped;

        protected SymbolImplBase()
        {
        }

        internal static TImpl GetInstance<TIntf, TImpl>(TIntf wrapped)
            where TIntf: Symbol
            where TImpl: SymbolImpl, TIntf, new()
        {
            var pool = (ObjectPool<TImpl>)s_pools.GetOrAdd(typeof(TImpl), new ObjectPool<TImpl>(() => new TImpl()));
            var result = pool.Allocate();
            global::System.Diagnostics.Debug.Assert(result._wrapped is null);
            result._pool = pool;
            result._wrapped = wrapped is SymbolImplBase sib ? sib._wrapped : wrapped;
            return result;
        }

        public void Free()
        {
            _wrapped = null;
            _pool?.Free(this);
        }

        protected Symbol? __Wrapped => _wrapped;

        public string Name => _wrapped.Name;

        public string MetadataName => _wrapped.MetadataName;

        public bool MangleName => _wrapped.MangleName;

        public ImmutableArray<AttributeSymbol> Attributes => _wrapped.Attributes;

        public string Kind => _wrapped.Kind;

        public string DisplayKind => _wrapped.DisplayKind;

        public bool IsImplicitlyDeclared => _wrapped.IsImplicitlyDeclared;

        public bool IsErrorSymbol => _wrapped.IsErrorSymbol;

        public bool IsSourceSymbol => _wrapped.IsSourceSymbol;

        public bool IsModelSymbol => _wrapped.IsModelSymbol;

        public bool IsCSharpSymbol => _wrapped.IsCSharpSymbol;

        public virtual ISymbolFactory SymbolFactory => _wrapped.SymbolFactory;

        public Symbol ContainingSymbol => _wrapped.ContainingSymbol;

        public virtual AssemblySymbol? ContainingAssembly => _wrapped.ContainingAssembly;

        public virtual ModuleSymbol? ContainingModule => _wrapped.ContainingModule;

        public virtual DeclarationSymbol? ContainingDeclaration => _wrapped.ContainingDeclaration;

        public virtual TypeSymbol? ContainingType => _wrapped.ContainingType;

        public virtual NamespaceSymbol? ContainingNamespace => _wrapped.ContainingNamespace;

        public ImmutableArray<Symbol> ContainedSymbols => _wrapped.ContainedSymbols;

        public virtual Compilation? DeclaringCompilation => _wrapped.DeclaringCompilation;

        public MergedDeclaration? MergedDeclaration => _wrapped.MergedDeclaration;

        public ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => _wrapped.DeclaringSyntaxReferences;

        public ImmutableArray<Location> Locations => _wrapped.Locations;

        public Location Location => _wrapped.Location;

        public IModelObject? ModelObject => _wrapped.ModelObject;

        public Type? ModelObjectType => _wrapped.ModelObjectType;

        public __ISymbol? CSharpSymbol => _wrapped.CSharpSymbol;

        public ImmutableArray<Diagnostic> Diagnostics => _wrapped.Diagnostics;

        public bool HasAnyErrors => _wrapped.HasAnyErrors;

        public bool HasUseSiteError => _wrapped.HasUseSiteError;

        public virtual bool HasUnsupportedMetadata => _wrapped.HasUnsupportedMetadata;

        public void ForceComplete(CompletionPart completionPart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            _wrapped.ForceComplete(completionPart, locationOpt, cancellationToken);
        }

        public virtual LexicalSortKey GetLexicalSortKey()
        {
            return _wrapped.GetLexicalSortKey();
        }

        public bool HasComplete(CompletionPart part)
        {
            return _wrapped.HasComplete(part);
        }

        public bool IsDefinedBySyntax(SyntaxNodeOrToken syntax, CancellationToken cancellationToken = default)
        {
            return _wrapped.IsDefinedBySyntax(syntax, cancellationToken);
        }

        public bool IsDefinedInSourceTree(SyntaxTree tree, TextSpan? definedWithinSpan, CancellationToken cancellationToken = default)
        {
            return _wrapped.IsDefinedInSourceTree(tree, definedWithinSpan, cancellationToken);
        }

        public virtual string GetDocumentationCommentId()
        {
            return _wrapped.GetDocumentationCommentId();
        }

        public virtual string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default)
        {
            return _wrapped.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
        }

        public bool IsFromCompilation(Compilation compilation)
        {
            return _wrapped.IsFromCompilation(compilation);
        }
    }
}
