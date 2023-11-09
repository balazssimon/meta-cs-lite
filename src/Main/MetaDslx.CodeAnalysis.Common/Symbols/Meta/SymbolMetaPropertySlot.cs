using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Meta
{
    internal class SymbolMetaPropertySlot : MetaPropertySlot<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>
    {
        public SymbolMetaPropertySlot(MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> slotProperty, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> slotProperties, object? defaultValue, ModelPropertyFlags flags) 
            : base(slotProperty, slotProperties, defaultValue, flags)
        {
        }
    }
}
