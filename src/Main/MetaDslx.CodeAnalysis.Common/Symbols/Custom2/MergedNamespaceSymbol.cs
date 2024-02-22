// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Modeling;

namespace MetaDslx.CodeAnalysis.Symbols
{
    /// <summary>
    /// A MergedNamespaceSymbol represents a namespace that merges the contents of two or more other
    /// namespaces. Any sub-namespaces with the same names are also merged if they have two or more
    /// instances.
    /// 
    /// Merged namespaces are used to merge the symbols from multiple metadata modules and the
    /// source "module" into a single symbol tree that represents all the available symbols. The
    /// compiler resolves names against this merged set of symbols.
    /// 
    /// Typically there will not be very many merged namespaces in a Compilation: only the root
    /// namespaces and namespaces that are used in multiple referenced modules. (Microsoft, System,
    /// System.Xml, System.Diagnostics, System.Threading, ...)
    /// </summary>
    internal sealed class MergedNamespaceSymbol : Impl.NamespaceSymbolImpl
    {
        private readonly ImmutableArray<NamespaceSymbol> _namespacesToMerge;

        // Constructor. Use static Create method to create instances.
        private MergedNamespaceSymbol(NamespaceExtent extent, NamespaceSymbol containingNamespace, ImmutableArray<NamespaceSymbol> namespacesToMerge, string nameOpt)
            : base(container: containingNamespace, compilation: extent.DeclaringCompilation, name: nameOpt ?? namespacesToMerge.FirstOrDefault()?.Name, extent: extent)
        {
            _namespacesToMerge = namespacesToMerge;

#if DEBUG
            // We shouldn't merged namespaces that are already merged.
            foreach (NamespaceSymbol ns in namespacesToMerge)
            {
                Debug.Assert(ns.ConstituentNamespaces.Length == 1);
            }
#endif
        }

        /// <summary>
        /// Create a possibly merged namespace symbol. If only a single namespace is passed it, it
        /// is just returned directly. If two or more namespaces are passed in, then a new merged
        /// namespace is created with the given extent and container.
        /// </summary>
        /// <param name="extent">The namespace extent to use, IF a merged namespace is created.</param>
        /// <param name="containingNamespace">The containing namespace to used, IF a merged
        /// namespace is created.</param>
        /// <param name="namespacesToMerge">One or more namespaces to merged. If just one, then it
        /// is returned. The merged namespace symbol may hold onto the array.</param>
        /// <param name="nameOpt">An optional name to give the resulting namespace.</param>
        /// <returns>A namespace symbol representing the merged namespace.</returns>
        internal static NamespaceSymbol Create(
            NamespaceExtent extent,
            NamespaceSymbol containingNamespace,
            ImmutableArray<NamespaceSymbol> namespacesToMerge,
            string nameOpt = null)
        {
            // Currently, if we are just merging 1 namespace, we just return the namespace itself.
            // This is by far the most efficient, because it means that we don't create merged
            // namespaces (which have a fair amount of memory overhead) unless there is actual
            // merging going on. However, it means that the child namespace of a Compilation extent
            // namespace may be a Module extent namespace, and the containing of that module extent
            // namespace will be another module extent namespace. This is basically no different
            // than type members of namespaces, so it shouldn't be TOO unexpected.

            // EDMAURER if the caller is supplying a name, then produce the merged namespace with
            // the new name even if only a single namespace was provided. This behavior was introduced
            // to support nice extern alias error reporting.

            Debug.Assert(namespacesToMerge.Length != 0);

            return (namespacesToMerge.Length == 1 && nameOpt == null)
                ? namespacesToMerge[0]
                : new MergedNamespaceSymbol(extent, containingNamespace, namespacesToMerge, nameOpt);
        }

        public override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => _namespacesToMerge.SelectMany(namespaceSymbol => namespaceSymbol.DeclaringSyntaxReferences).AsImmutable();

        public override ImmutableArray<Location> Locations => _namespacesToMerge.SelectMany(namespaceSymbol => namespaceSymbol.Locations).AsImmutable();

        protected override Compilation? Compute_ContainingCompilation(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return Extent.Compilation;
        }

        protected override ImmutableArray<NamespaceSymbol> Compute_ConstituentNamespaces(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _namespacesToMerge;
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                if (Extent.Kind == NamespaceKind.Module)
                {
                    return Extent.Module.ContainingAssembly;
                }
                else if (Extent.Kind == NamespaceKind.Assembly)
                {
                    return Extent.Assembly;
                }
                else
                {
                    return null;
                }
            }
        }

        public override ModuleSymbol ContainingModule
        {
            get
            {
                switch (Extent.Kind)
                {
                    case NamespaceKind.Module:
                        return Extent.Module;
                    case NamespaceKind.Assembly:
                        break;
                    case NamespaceKind.Compilation:
                        return Extent.Compilation.SourceModule;
                    default:
                        break;
                }
                return null;
            }
        }

        public override ImmutableArray<SingleDeclaration> GetSingleDeclarations(CancellationToken cancellationToken = default)
        {
            var result = ArrayBuilder<SingleDeclaration>.GetInstance();
            foreach (var n in _namespacesToMerge)
            {
                result.AddRange(n.GetSingleDeclarations(cancellationToken));
            }
            return result.ToImmutableAndFree();
        }

        internal NamespaceSymbol GetConstituentForCompilation(Compilation compilation)
        {
            foreach (var n in _namespacesToMerge)
            {
                if (n.IsFromCompilation(compilation)) return n;
            }
            return null;
        }

        protected override void ForceCompleteCore(CompletionPart completionPart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            foreach (var part in _namespacesToMerge)
            {
                cancellationToken.ThrowIfCancellationRequested();
                part.ForceComplete(completionPart, locationOpt, cancellationToken);
            }
            base.ForceCompleteCore(completionPart, locationOpt, cancellationToken);
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var memberNames = new HashSet<string>();
            // Accumulate all the contained namespace and type names.
            foreach (NamespaceSymbol namespaceSymbol in _namespacesToMerge)
            {
                memberNames.UnionWith(namespaceSymbol.MemberNames);
            }

            var containedSymbolsAdded = new HashSet<Symbol>();
            var containedSymbols = ArrayBuilder<Symbol>.GetInstance();
            foreach (var name in memberNames)
            {
                ArrayBuilder<NamespaceSymbol> namespaceSymbols = null;
                // Accumulate all the contained namespaces and types.
                foreach (NamespaceSymbol namespaceSymbol in _namespacesToMerge)
                {
                    foreach (var containedSymbol in namespaceSymbol.ContainedSymbols)
                    {
                        if (containedSymbol is NamespaceSymbol ns && ns.Name == name)
                        {
                            namespaceSymbols = namespaceSymbols ?? ArrayBuilder<NamespaceSymbol>.GetInstance();
                            namespaceSymbols.Add(ns);
                            containedSymbolsAdded.Add(ns);
                        }
                    }
                }

                if (namespaceSymbols != null)
                {
                    containedSymbols.Add(MergedNamespaceSymbol.Create(Extent, this, namespaceSymbols.ToImmutableAndFree()));
                }
            }
            foreach (NamespaceSymbol namespaceSymbol in _namespacesToMerge)
            {
                foreach (Symbol containedSymbol in namespaceSymbol.ContainedSymbols)
                {
                    if (!containedSymbolsAdded.Contains(containedSymbol))
                    {
                        containedSymbols.Add(containedSymbol);
                    }
                }
            }
            return containedSymbols.ToImmutableAndFree();
        }

        protected override ImmutableArray<DeclarationSymbol> Compute_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var memberNames = new HashSet<string>();
            // Accumulate all the child namespace and type names.
            foreach (NamespaceSymbol namespaceSymbol in _namespacesToMerge)
            {
                memberNames.UnionWith(namespaceSymbol.MemberNames);
            }

            var memberSymbols = ArrayBuilder<DeclarationSymbol>.GetInstance();

            foreach (var name in memberNames)
            {
                ArrayBuilder<NamespaceSymbol> namespaceSymbols = null;
                // Accumulate all the child namespaces and types.
                foreach (NamespaceSymbol namespaceSymbol in _namespacesToMerge)
                {
                    foreach (var memberSymbol in namespaceSymbol.Members)
                    {
                        if (memberSymbol.Name != name) continue;
                        if (memberSymbol is NamespaceSymbol ns)
                        {
                            namespaceSymbols = namespaceSymbols ?? ArrayBuilder<NamespaceSymbol>.GetInstance();
                            namespaceSymbols.Add(ns);
                        }
                        else
                        {
                            memberSymbols.Add(memberSymbol);
                        }
                    }
                }

                if (namespaceSymbols != null)
                {
                    memberSymbols.Add(MergedNamespaceSymbol.Create(Extent, this, namespaceSymbols.ToImmutableAndFree()));
                }
            }

            return memberSymbols.ToImmutableAndFree();
        }

    }
}
