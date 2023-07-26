using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class NamespaceSymbol : DeclaredSymbol
    {
        protected NamespaceSymbol(Symbol container) 
            : base(container)
        {
        }

        /// <summary>
        /// Returns whether this namespace is the unnamed, global namespace that is 
        /// at the root of all namespaces.
        /// </summary>
        public virtual bool IsGlobalNamespace => ContainingNamespace is null;

        public abstract NamespaceExtent Extent { get; }

        /// <summary>
        /// The kind of namespace: Module, Assembly or Compilation.
        /// Module namespaces contain only members from the containing module that share the same namespace name.
        /// Assembly namespaces contain members for all modules in the containing assembly that share the same namespace name.
        /// Compilation namespaces contain all members, from source or referenced metadata (assemblies and modules) that share the same namespace name.
        /// </summary>
        public NamespaceKind NamespaceKind => this.Extent.Kind;

        /// <summary>
        /// The containing compilation for compilation namespaces.
        /// </summary>
        public Compilation? ContainingCompilation
        {
            get { return this.NamespaceKind == NamespaceKind.Compilation ? this.Extent.Compilation : null; }
        }

        /// <summary>
        /// If a namespace has Assembly or Compilation extent, it may be composed of multiple
        /// namespaces that are merged together. If so, ConstituentNamespaces returns
        /// all the namespaces that were merged. If this namespace was not merged, returns
        /// an array containing only this namespace.
        /// </summary>
        public virtual ImmutableArray<NamespaceSymbol> ConstituentNamespaces => ImmutableArray.Create(this);

        public override ModuleSymbol ContainingModule
        {
            get
            {
                var extent = this.Extent;
                if (extent.Kind == NamespaceKind.Module)
                {
                    return extent.Module;
                }

                return null;
            }
        }

        public override bool IsImplicitlyDeclared => this.IsGlobalNamespace;

        /// <summary>
        /// Get this accessibility that was declared on this symbol. For symbols that do not have
        /// accessibility declared on them, returns NotApplicable.
        /// </summary>
        public override Accessibility DeclaredAccessibility => Accessibility.Public;

        /// <summary>
        /// Returns true if this symbol is "static"; i.e., declared with the "static" modifier or
        /// implicitly static.
        /// </summary>
        public override bool IsStatic => true;

        /// <summary>
        /// Lookup a nested namespace.
        /// </summary>
        /// <param name="names">
        /// Sequence of names for nested child namespaces.
        /// </param>
        /// <returns>
        /// Symbol for the most nested namespace, if found. Nothing 
        /// if namespace or any part of it can not be found.
        /// </returns>
        public NamespaceSymbol? LookupNestedNamespace(ImmutableArray<string> names)
        {
            NamespaceSymbol scope = this;
            foreach (string name in names)
            {
                NamespaceSymbol nextScope = null;
                foreach (var symbol in scope.GetMembers(name))
                {
                    var ns = symbol as NamespaceSymbol;
                    if (ns is not null)
                    {
                        if (nextScope is not null)
                        {
                            Debug.Assert(false, "Why did we run into an unmerged namespace?");
                            nextScope = null;
                            break;
                        }
                        nextScope = ns;
                    }
                }
                scope = nextScope;
                if (scope is null) break;
            }
            return scope;
        }

        public NamespaceSymbol? GetNestedNamespace(string name)
        {
            return GetMembers(name).OfType<NamespaceSymbol>().FirstOrDefault();
        }

        /// <summary>
        /// Get all the members of this symbol that are namespaces.
        /// </summary>
        /// <returns>An IEnumerable containing all the namespaces that are members of this symbol.
        /// If this symbol has no namespace members, returns an empty IEnumerable. Never returns
        /// null.</returns>
        public IEnumerable<NamespaceSymbol> GetNamespaceMembers()
        {
            return this.Members.OfType<NamespaceSymbol>();
        }

    }
}
