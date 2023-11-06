﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Text;
using MetaDslx.Modeling.Meta;

namespace MetaDslx.Modeling.Reflection
{
    internal class ReflectionMetaClass : MetaClass<Type, PropertyInfo>
    {
        private string? _symbolType;

        public ReflectionMetaClass(Type underlyingType)
            : base(underlyingType)
        {
            var symbolAttr = UnderlyingType.GetCustomAttribute<SymbolAttribute>(true);
            _symbolType = symbolAttr?.SymbolType?.FullName;
        }

        public override string Name => UnderlyingType.Name;

        public override string? SymbolType
        {
            get => _symbolType;
            set => _symbolType = value;
        }

        public override ImmutableArray<Type> OriginalBaseTypes
        {
            get
            {
                return ImmutableArray.Create(UnderlyingType.BaseType);
            }
        }

        public override ImmutableArray<PropertyInfo> OriginalDeclaredProperties
        {
            get
            {
                return UnderlyingType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).ToImmutableArray();
            }
        }

        public override string ToString()
        {
            return UnderlyingType.Name;
        }
    }
}