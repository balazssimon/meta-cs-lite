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
    public abstract partial class DeclaredSymbol : Symbol
    {
        public static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionPart StartComputingProperty_Members = new CompletionPart(nameof(StartComputingProperty_Members));
            public static readonly CompletionPart FinishComputingProperty_Members = new CompletionPart(nameof(FinishComputingProperty_Members));
            public static readonly CompletionGraph CompletionGraph = CompletionGraph.CreateFromParts(CompletionGraph.StartInitializing, CompletionGraph.FinishInitializing, CompletionGraph.StartCreatingContainedSymbols, CompletionGraph.FinishCreatingContainedSymbols, StartComputingProperty_Attributes, FinishComputingProperty_Attributes, StartComputingProperty_Members, FinishComputingProperty_Members, CompletionGraph.StartComputingNonSymbolProperties, CompletionGraph.FinishComputingNonSymbolProperties, CompletionGraph.ContainedSymbolsCompleted, CompletionGraph.StartValidatingSymbol, CompletionGraph.FinishValidatingSymbol);
        }

        private static MemberLookupCache EmptyMemberCache = new MemberLookupCache(ImmutableArray<DeclaredSymbol>.Empty);
        private static ConditionalWeakTable<DeclaredSymbol, object> s_members = new ConditionalWeakTable<DeclaredSymbol, object>();
        private static ConditionalWeakTable<DeclaredSymbol, MemberLookupCache> s_memberLookup = new ConditionalWeakTable<DeclaredSymbol, MemberLookupCache>();

        protected DeclaredSymbol(Symbol container) 
            : base(container)
        {
        }

        /// <summary>
        /// Returns true if this symbol can be referenced by its name in code. Examples of symbols
        /// that cannot be referenced by name are:
        ///    constructors, destructors, operators, explicit interface implementations,
        ///    accessor methods for properties and events, array types.
        /// </summary>
        public virtual bool CanBeReferencedByName => !string.IsNullOrEmpty(Name);

        /// <summary>
        /// Returns true if this symbol is "static"; i.e., declared with the <c>static</c> modifier or
        /// implicitly static.
        /// </summary>
        public abstract bool IsStatic { get; }

        /// <summary>
        /// Returns true if this symbol has external implementation; i.e., declared with the 
        /// <c>extern</c> modifier. 
        /// </summary>
        public virtual bool IsExtern => false;

        /// <summary>
        /// All the members of this symbol.
        /// </summary>
        /// <returns>An ImmutableArray containing all the members of this symbol. If this symbol has no members,
        /// returns an empty ImmutableArray. Never returns null.</returns>
        [ModelProperty]
        public ImmutableArray<DeclaredSymbol> Members
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
        internal ImmutableArray<DeclaredSymbol> GetMembersUnordered()
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
        public ImmutableArray<DeclaredSymbol> GetMembers(string name)
        {
            return GetMemberLookupCache().GetMembers(name);
        }

        /// <summary>
        /// Get all the members of this symbol that are types that have a particular name and metadata name
        /// </summary>
        /// <returns>An IEnumerable containing all the types that are members of this symbol with the given name and metadata name.
        /// If this symbol has no type members with this name and metadata name,
        /// returns an empty IEnumerable. Never returns null.</returns>
        public ImmutableArray<DeclaredSymbol> GetMembers(string name, string metadataName)
        {
            return GetMemberLookupCache().GetMembers(name, metadataName);
        }

        /// <summary>
        /// Get all the members of this symbol that are types. The members may not be in a particular order, and the order
        /// may not be stable from call-to-call.
        /// </summary>
        /// <returns>An ImmutableArray containing all the types that are members of this symbol. If this symbol has no type members,
        /// returns an empty ImmutableArray. Never returns null.</returns>
        internal virtual ImmutableArray<NamedTypeSymbol> GetTypeMembersUnordered()
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
        public ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            return GetMemberLookupCache().GetTypeMembers();
        }

        /// <summary>
        /// Get all the members of this symbol that are types that have a particular name, of any metadata name.
        /// </summary>
        /// <returns>An ImmutableArray containing all the types that are members of this symbol with the given name.
        /// If this symbol has no type members with this name,
        /// returns an empty ImmutableArray. Never returns null.</returns>
        public ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            return GetMemberLookupCache().GetTypeMembers(name);
        }

        /// <summary>
        /// Get all the members of this symbol that are types that have a particular name and metadata name
        /// </summary>
        /// <returns>An IEnumerable containing all the types that are members of this symbol with the given name and metadata name.
        /// If this symbol has no type members with this name and metadata name,
        /// returns an empty IEnumerable. Never returns null.</returns>
        public ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, string metadataName)
        {
            return GetMemberLookupCache().GetTypeMembers(name, metadataName);
        }

        private MemberLookupCache GetMemberLookupCache()
        {
            ForceComplete(CompletionParts.FinishComputingProperty_Members, null, default);
            if (s_memberLookup.TryGetValue(this, out var members)) return members;
            else return EmptyMemberCache;
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_Members || incompletePart == CompletionParts.FinishComputingProperty_Members)
            {
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
            }
            return false;
        }

        protected virtual ImmutableArray<DeclaredSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<DeclaredSymbol>.Empty;
        }

    }
}
