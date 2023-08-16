using MetaDslx.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public partial class DeclaredSymbol
    {
        private class MemberLookupCache
        {
            private HashSet<string> _memberNames;
            private ImmutableArray<DeclaredSymbol> _members;
            private ImmutableArray<TypeSymbol> _typeMembers;
            private CachingDictionary<string, DeclaredSymbol> _membersByName;
            private CachingDictionary<string, TypeSymbol> _typeMembersByName;
            private CachingDictionary<string, DeclaredSymbol> _membersByMetadataName;
            private CachingDictionary<string, TypeSymbol> _typeMembersByMetadataName;

            public MemberLookupCache(ImmutableArray<DeclaredSymbol> members)
            {
                _members = members;
            }

            public ImmutableArray<DeclaredSymbol> Members => _members;

            public HashSet<string> GetMemberNames()
            {
                if (_memberNames == null)
                {
                    Interlocked.CompareExchange(ref _memberNames, new HashSet<string>(_members.Select(m => m.Name)), null);
                }
                return _memberNames;
            }

            public ImmutableArray<DeclaredSymbol> GetMembers(string name)
            {
                if (name == null || !GetMemberNames().Contains(name)) return ImmutableArray<DeclaredSymbol>.Empty;
                if (_members.IsEmpty) return ImmutableArray<DeclaredSymbol>.Empty;
                if (_membersByName is null)
                {
                    Interlocked.CompareExchange(ref _membersByName, new CachingDictionary<string, DeclaredSymbol>(cachedName => _members.WhereAsArray(m => m.Name == cachedName), SlowGetMemberNames, EqualityComparer<string>.Default), null);
                }
                return _membersByName[name];
            }

            public ImmutableArray<DeclaredSymbol> GetMembers(string name, string metadataName)
            {
                if (name == null || !GetMemberNames().Contains(name)) return ImmutableArray<DeclaredSymbol>.Empty;
                if (_members.IsEmpty) return ImmutableArray<DeclaredSymbol>.Empty;
                if (_membersByMetadataName is null)
                {
                    Interlocked.CompareExchange(ref _membersByMetadataName, new CachingDictionary<string, DeclaredSymbol>(cachedName => _members.WhereAsArray(m => m.MetadataName == cachedName), SlowGetMemberMetadataNames, EqualityComparer<string>.Default), null);
                }
                return _membersByMetadataName[metadataName];
            }

            public ImmutableArray<TypeSymbol> GetTypeMembers()
            {
                if (_typeMembers.IsDefault)
                {
                    ImmutableInterlocked.InterlockedInitialize(ref _typeMembers, _members.OfType<TypeSymbol>().ToImmutableArray());
                }
                return _typeMembers;
            }

            public ImmutableArray<TypeSymbol> GetTypeMembers(string name)
            {
                if (name == null || !GetMemberNames().Contains(name)) return ImmutableArray<TypeSymbol>.Empty;
                var members = this.GetTypeMembers();
                if (members.IsEmpty) return ImmutableArray<TypeSymbol>.Empty;
                if (_typeMembersByName is null)
                {
                    Interlocked.CompareExchange(ref _typeMembersByName, new CachingDictionary<string, TypeSymbol>(cachedName => this.GetTypeMembers().WhereAsArray(m => m.Name == cachedName), SlowGetTypeMemberNames, EqualityComparer<string>.Default), null);
                }
                return _typeMembersByName[name];
            }

            public ImmutableArray<TypeSymbol> GetTypeMembers(string name, string metadataName)
            {
                if (name == null || !GetMemberNames().Contains(name)) return ImmutableArray<TypeSymbol>.Empty;
                var members = this.GetTypeMembers();
                if (members.IsEmpty) return ImmutableArray<TypeSymbol>.Empty;
                if (_typeMembersByMetadataName is null)
                {
                    Interlocked.CompareExchange(ref _typeMembersByMetadataName, new CachingDictionary<string, TypeSymbol>(cachedName => this.GetTypeMembers().WhereAsArray(m => m.MetadataName == cachedName), SlowGetTypeMemberMetadataNames, EqualityComparer<string>.Default), null);
                }
                return _typeMembersByMetadataName[metadataName];
            }

            private HashSet<string> SlowGetMemberNames(IEqualityComparer<string> comparer)
            {
                var names = new HashSet<string>(comparer);
                names.UnionWith(_members.Select(m => m.Name));
                return names;
            }

            private HashSet<string> SlowGetTypeMemberNames(IEqualityComparer<string> comparer)
            {
                var names = new HashSet<string>(comparer);
                names.UnionWith(this.GetTypeMembers().Select(m => m.Name));
                return names;
            }

            private HashSet<string> SlowGetMemberMetadataNames(IEqualityComparer<string> comparer)
            {
                var names = new HashSet<string>(comparer);
                names.UnionWith(_members.Select(m => m.MetadataName));
                return names;
            }

            private HashSet<string> SlowGetTypeMemberMetadataNames(IEqualityComparer<string> comparer)
            {
                var names = new HashSet<string>(comparer);
                names.UnionWith(this.GetTypeMembers().Select(m => m.MetadataName));
                return names;
            }
        }

    }
}
