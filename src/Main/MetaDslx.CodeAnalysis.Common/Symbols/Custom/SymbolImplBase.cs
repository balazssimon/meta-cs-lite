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

namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;

    public class SymbolImplBase : SymbolBase
    {
        private Symbol? _wrapped;

        protected SymbolImplBase()
        {
        }

        public void __InitWrapped(Symbol wrapped)
        {
            _wrapped = wrapped is SymbolImplBase sib ? sib._wrapped : wrapped;
        }

        protected void __ClearWrapped()
        {
            _wrapped = null;
        }


        protected Symbol? __Wrapped => _wrapped;

        public override string Name => _wrapped.Name;

        public override string MetadataName => _wrapped.MetadataName;

        public override bool MangleName => _wrapped.MangleName;

        public override ImmutableArray<AttributeSymbol> Attributes => _wrapped.Attributes;

        public override string Kind => _wrapped.Kind;

        public override string DisplayKind => _wrapped.DisplayKind;

        public override bool IsImplicitlyDeclared => _wrapped.IsImplicitlyDeclared;

        public override bool IsErrorSymbol => _wrapped.IsErrorSymbol;

        public override bool IsSourceSymbol => _wrapped.IsSourceSymbol;

        public override bool IsModelSymbol => _wrapped.IsModelSymbol;

        public override bool IsCSharpSymbol => _wrapped.IsCSharpSymbol;

        public override Symbol ContainingSymbol => _wrapped.ContainingSymbol;

        public override AssemblySymbol? ContainingAssembly => _wrapped.ContainingAssembly;

        public override ModuleSymbol? ContainingModule => _wrapped.ContainingModule;

        public override DeclarationSymbol? ContainingDeclaration => _wrapped.ContainingDeclaration;

        public override TypeSymbol? ContainingType => _wrapped.ContainingType;

        public override NamespaceSymbol? ContainingNamespace => _wrapped.ContainingNamespace;

        public override ImmutableArray<Symbol> ContainedSymbols => _wrapped.ContainedSymbols;

        public override Compilation? DeclaringCompilation => _wrapped.DeclaringCompilation;

        public override MergedDeclaration? MergedDeclaration => _wrapped.MergedDeclaration;

        public override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => _wrapped.DeclaringSyntaxReferences;

        public override ImmutableArray<Location> Locations => _wrapped.Locations;

        public override Location Location => _wrapped.Location;

        public override IModelObject? ModelObject => _wrapped.ModelObject;

        public override Type? ModelObjectType => _wrapped.ModelObjectType;

        public override __ISymbol? CSharpSymbol => _wrapped.CSharpSymbol;

        public override ImmutableArray<Diagnostic> Diagnostics => _wrapped.Diagnostics;

        public override bool HasAnyErrors => _wrapped.HasAnyErrors;

        public override void ForceComplete(CompletionPart completionPart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            _wrapped.ForceComplete(completionPart, locationOpt, cancellationToken);
        }

        public override LexicalSortKey GetLexicalSortKey()
        {
            return _wrapped.GetLexicalSortKey();
        }

        public override bool HasComplete(CompletionPart part)
        {
            return _wrapped.HasComplete(part);
        }

        public override bool IsDefinedBySyntax(SyntaxNodeOrToken syntax, CancellationToken cancellationToken = default)
        {
            return _wrapped.IsDefinedBySyntax(syntax, cancellationToken);
        }

        public override bool IsDefinedInSourceTree(SyntaxTree tree, TextSpan? definedWithinSpan, CancellationToken cancellationToken = default)
        {
            return _wrapped.IsDefinedInSourceTree(tree, definedWithinSpan, cancellationToken);
        }
    }
}
