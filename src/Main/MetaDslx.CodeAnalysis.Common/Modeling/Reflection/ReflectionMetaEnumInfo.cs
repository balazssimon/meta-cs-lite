﻿using MetaDslx.Modeling.Reflection;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Modeling.Reflection
{
    internal sealed class ReflectionMetaEnumInfo : ModelEnumInfo
    {
        private readonly ReflectionMetaModel _metaModel;
        private readonly Type _metaType;
        private readonly ImmutableArray<string> _literals;
        private readonly ImmutableDictionary<string, MetaSymbol> _literalsByName;

        public ReflectionMetaEnumInfo(
            ReflectionMetaModel metaModel,
            Type metaType,
            ImmutableArray<string> literals,
            ImmutableDictionary<string, MetaSymbol> literalsByName)
        {
            _metaModel = metaModel;
            _metaType = metaType;
            _literals = literals;
            _literalsByName = literalsByName;
        }

        public override MetaModel MetaModel => _metaModel;

        public override MetaType MetaType => _metaType;

        public override ImmutableArray<string> Literals => _literals;

        protected override ImmutableDictionary<string, MetaSymbol> LiteralsByName => _literalsByName;
    }
}
