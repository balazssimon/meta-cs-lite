using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace MetaDslx.Modeling
{
    public sealed class Box
    {
        private static readonly ConditionalWeakTable<Box, ValueInfo> s_valueInfos = new ConditionalWeakTable<Box, ValueInfo>();
        private static readonly object DefaultValue = new object();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ISlot _slot;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private object? _value;

        public Box(ISlot slot)
        {
            _slot = slot;
            _value = DefaultValue;
        }

        public Model Model => _slot.Owner.MModel;
        public ISlot Slot => _slot;
        public IModelObject Owner => _slot.Owner;
        public ModelPropertySlot Property => _slot.Property;

        public bool IsDefault => _value == DefaultValue;

        public object? Value
        {
            get => IsDefault ? _slot.Property.DefaultValue : _value;
            internal set => _value = value;
        }

        public bool HasValue(object? value)
        {
            if (IsDefault) return value == _slot.Property.DefaultValue;
            else return _value == value;
        }

        internal void Clear()
        {
            _value = DefaultValue;
        }

        public Location? Location
        {
            get => TryGetValueInfo()?.Location ?? Location.None;
            set
            {
                var info = TryGetValueInfo();
                if (info is not null) info.Location = value;
                else if (value is not null && value != Location.None && value != SourceLocation.None) GetValueInfo().Location = value;
                // TODO: update subsetted properties
            }
        }

        public SourceLocation? SourceLocation
        {
            get => TryGetValueInfo()?.SourceLocation ?? SourceLocation.None;
            set
            {
                var info = TryGetValueInfo();
                if (info is not null) info.SourceLocation = value;
                else if (value is not null && value != SourceLocation.None) GetValueInfo().SourceLocation = value;
                // TODO: update subsetted properties
            }
        }

        public Symbol? Symbol
        {
            get => TryGetValueInfo()?.Symbol;
            set
            {
                var info = TryGetValueInfo();
                if (info is not null) info.Symbol = value;
                else if (value is not null) GetValueInfo().Symbol = value;
                // TODO: update subsetted properties
            }
        }

        public SyntaxNodeOrToken Syntax
        {
            get => TryGetValueInfo()?.Syntax ?? default;
            set 
            {
                var info = TryGetValueInfo();
                if (info is not null) info.Syntax = value;
                else if (!value.IsNull) GetValueInfo().Syntax = value;
                // TODO: update subsetted properties
            }
        }

        public Microsoft.CodeAnalysis.ISymbol? CSharpSymbol
        {
            get => TryGetValueInfo()?.CSharpSymbol;
        }

        public object? Tag
        {
            get => TryGetValueInfo()?.Tag;
            set
            {
                var info = TryGetValueInfo();
                if (info is not null) info.Tag = value;
                else if (value is not null) GetValueInfo().Tag = value;
                // TODO: update subsetted properties
            }
        }

        private ValueInfo? TryGetValueInfo()
        {
            if (s_valueInfos.TryGetValue(this, out var valueInfo)) return valueInfo;
            else return null;
        }

        private ValueInfo GetValueInfo()
        {
            return s_valueInfos.GetValue(this, mobj => Model?.CreateValueInfo(mobj));
        }

        public override int GetHashCode()
        {
            return Hash.Combine(Hash.Combine(_slot?.Property?.GetHashCode() ?? 0, _slot?.Owner?.GetHashCode() ?? 0), _value?.GetHashCode() ?? 0);
        }

        public override string ToString()
        {
            return $"{Owner}.{Property}={_value}";
        }
    }
}
