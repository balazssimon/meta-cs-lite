using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class DeclarationSymbol : Symbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_Members = new CompletionPart(nameof(StartComputingProperty_Members));
            public static readonly CompletionPart FinishComputingProperty_Members = new CompletionPart(nameof(FinishComputingProperty_Members));
            public static readonly CompletionPart StartComputingProperty_TypeArguments = new CompletionPart(nameof(StartComputingProperty_TypeArguments));
            public static readonly CompletionPart FinishComputingProperty_TypeArguments = new CompletionPart(nameof(FinishComputingProperty_TypeArguments));
            public static readonly CompletionPart StartComputingProperty_Imports = new CompletionPart(nameof(StartComputingProperty_Imports));
            public static readonly CompletionPart FinishComputingProperty_Imports = new CompletionPart(nameof(FinishComputingProperty_Imports));
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_Members, FinishComputingProperty_Members,
                    StartComputingProperty_TypeArguments, FinishComputingProperty_TypeArguments,
                    StartComputingProperty_Imports, FinishComputingProperty_Imports,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private static MemberLookupCache EmptyMemberCache = new MemberLookupCache(ImmutableArray<DeclarationSymbol>.Empty);
        private static ConditionalWeakTable<DeclarationSymbol, object> s_typeArguments = new ConditionalWeakTable<DeclarationSymbol, object>();
        private static ConditionalWeakTable<DeclarationSymbol, object> s_imports = new ConditionalWeakTable<DeclarationSymbol, object>();
        private static ConditionalWeakTable<DeclarationSymbol, MemberLookupCache> s_members = new ConditionalWeakTable<DeclarationSymbol, MemberLookupCache>();

        protected DeclarationSymbol(Symbol container) 
            : base(container)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        /// <summary>
        /// The original definition of this symbol. If this symbol is constructed from another
        /// symbol by type substitution then OriginalDefinition gets the original symbol as it was defined in
        /// source or metadata.
        /// </summary>
        public virtual DeclarationSymbol OriginalDefinition => this;

        /// <summary>
        /// Returns true if this symbol can be referenced by its name in code. Examples of symbols
        /// that cannot be referenced by name are:
        ///    constructors, destructors, operators, explicit interface implementations,
        ///    accessor methods for properties and events, array types.
        /// </summary>
        public virtual bool CanBeReferencedByName => !string.IsNullOrEmpty(Name);

        /// <summary>
        /// Get this accessibility that was declared on this symbol. For symbols that do not have
        /// accessibility declared on them, returns <see cref="Accessibility.NotApplicable"/>.
        /// </summary>
        [ModelProperty]
        public virtual Accessibility DeclaredAccessibility => Accessibility.Public;

        /// <summary>
        /// Returns true if this symbol is "static"; i.e., declared with the <c>static</c> modifier or
        /// implicitly static.
        /// </summary>
        [ModelProperty]
        public virtual bool IsStatic { get; }

        /// <summary>
        /// Returns true if this symbol has external implementation; i.e., declared with the 
        /// <c>extern</c> modifier. 
        /// </summary>
        [ModelProperty]
        public virtual bool IsExtern => false;

        /// <summary>
        /// The type arguments specified for this symbol.
        /// </summary>
        /// <returns>An ImmutableArray containing all the type arguments of this symbol. If this symbol has no type arguments,
        /// returns an empty ImmutableArray. Never returns null.</returns>
        [ModelProperty]
        public ImmutableArray<TypeSymbol> TypeArguments
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_TypeArguments, null, default);
                if (s_typeArguments.TryGetValue(this, out var args)) return (ImmutableArray<TypeSymbol>)args;
                else return ImmutableArray<TypeSymbol>.Empty;
            }
        }

        /// <summary>
        /// The imported symbols by this symbol.
        /// </summary>
        /// <returns>An ImmutableArray containing all the imports of this symbol. If this symbol has no imports,
        /// returns an empty ImmutableArray. Never returns null.</returns>
        [ModelProperty]
        public ImmutableArray<ImportSymbol> Imports
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Imports, null, default);
                if (s_imports.TryGetValue(this, out var imports)) return (ImmutableArray<ImportSymbol>)imports;
                else return ImmutableArray<ImportSymbol>.Empty;
            }
        }

        /// <summary>
        /// The members declared in this symbol.
        /// </summary>
        /// <returns>An ImmutableArray containing all the members of this symbol. If this symbol has no members,
        /// returns an empty ImmutableArray. Never returns null.</returns>
        public ImmutableArray<DeclarationSymbol> Members
        {
            get
            {
                return GetMemberLookupCache().Members;
            }
        }

        public virtual IEnumerable<string> MemberNames => GetMemberLookupCache().GetMemberNames();

        /// <summary>
        /// Get all the members of this symbol. The members may not be in a particular order, and the order
        /// may not be stable from call-to-call.
        /// </summary>
        /// <returns>An ImmutableArray containing all the members of this symbol. If this symbol has no members,
        /// returns an empty ImmutableArray. Never returns null.</returns>
        internal ImmutableArray<DeclarationSymbol> GetMembersUnordered()
        {
            // Default implementation is to use ordered version. When performance indicates, we specialize to have
            // separate implementation.

            return Members.ConditionallyDeOrder();
        }

        /// <summary>
        /// Get all the members of this symbol that have a particular name.
        /// </summary>
        /// <returns>An ImmutableArray containing all the members of this symbol with the given name. If there are
        /// no members with this name, returns an empty ImmutableArray. Never returns null.</returns>
        public ImmutableArray<DeclarationSymbol> GetMembers(string name)
        {
            return GetMemberLookupCache().GetMembers(name);
        }

        /// <summary>
        /// Get all the members of this symbol that are types that have a particular name and metadata name
        /// </summary>
        /// <returns>An IEnumerable containing all the types that are members of this symbol with the given name and metadata name.
        /// If this symbol has no type members with this name and metadata name,
        /// returns an empty IEnumerable. Never returns null.</returns>
        public ImmutableArray<DeclarationSymbol> GetMembers(string name, string metadataName)
        {
            return GetMemberLookupCache().GetMembers(name, metadataName);
        }

        /// <summary>
        /// Get all the members of this symbol that are types. The members may not be in a particular order, and the order
        /// may not be stable from call-to-call.
        /// </summary>
        /// <returns>An ImmutableArray containing all the types that are members of this symbol. If this symbol has no type members,
        /// returns an empty ImmutableArray. Never returns null.</returns>
        internal virtual ImmutableArray<TypeSymbol> GetTypeMembersUnordered()
        {
            // Default implementation is to use ordered version. When performance indicates, we specialize to have
            // separate implementation.
            return GetTypeMembers().ConditionallyDeOrder();
        }

        /// <summary>
        /// Get all the members of this symbol that are types.
        /// </summary>
        /// <returns>An ImmutableArray containing all the types that are members of this symbol. If this symbol has no type members,
        /// returns an empty ImmutableArray. Never returns null.</returns>
        public ImmutableArray<TypeSymbol> GetTypeMembers()
        {
            return GetMemberLookupCache().GetTypeMembers();
        }

        /// <summary>
        /// Get all the members of this symbol that are types that have a particular name, of any metadata name.
        /// </summary>
        /// <returns>An ImmutableArray containing all the types that are members of this symbol with the given name.
        /// If this symbol has no type members with this name,
        /// returns an empty ImmutableArray. Never returns null.</returns>
        public ImmutableArray<TypeSymbol> GetTypeMembers(string name)
        {
            return GetMemberLookupCache().GetTypeMembers(name);
        }

        /// <summary>
        /// Get all the members of this symbol that are types that have a particular name and metadata name
        /// </summary>
        /// <returns>An IEnumerable containing all the types that are members of this symbol with the given name and metadata name.
        /// If this symbol has no type members with this name and metadata name,
        /// returns an empty IEnumerable. Never returns null.</returns>
        public ImmutableArray<TypeSymbol> GetTypeMembers(string name, string metadataName)
        {
            return GetMemberLookupCache().GetTypeMembers(name, metadataName);
        }

        private MemberLookupCache GetMemberLookupCache()
        {
            ForceComplete(CompletionParts.FinishComputingProperty_Members, null, default);
            if (s_members.TryGetValue(this, out var members)) return members;
            else return EmptyMemberCache;
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_TypeArguments || incompletePart == CompletionParts.FinishComputingProperty_TypeArguments)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_TypeArguments))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var typeArguments = CompleteProperty_TypeArguments(diagnostics, cancellationToken);
                    if (!typeArguments.IsDefaultOrEmpty)
                    {
                        s_typeArguments.Add(this, typeArguments);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_TypeArguments);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_Imports || incompletePart == CompletionParts.FinishComputingProperty_Imports)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Imports))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var imports = CompleteProperty_Imports(diagnostics, cancellationToken);
                    if (!imports.IsDefaultOrEmpty)
                    {
                        s_imports.Add(this, imports);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Imports);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_Members || incompletePart == CompletionParts.FinishComputingProperty_Members)
            {
                //ContainingDeclaration?.ForceComplete(CompletionParts.FinishComputingProperty_Members, null, cancellationToken);
                if (NotePartComplete(CompletionParts.StartComputingProperty_Members))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var members = CompleteProperty_Members(diagnostics, cancellationToken);
                    if (!members.IsDefaultOrEmpty)
                    {
                        s_members.Add(this, new MemberLookupCache(members));
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Members);
                }
                return true;
            }
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected virtual ImmutableArray<TypeSymbol> CompleteProperty_TypeArguments(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<TypeSymbol>.Empty;
        }

        protected virtual ImmutableArray<ImportSymbol> CompleteProperty_Imports(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<ImportSymbol>.Empty;
        }

        protected virtual ImmutableArray<DeclarationSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<DeclarationSymbol>.Empty;
        }

    }
}
