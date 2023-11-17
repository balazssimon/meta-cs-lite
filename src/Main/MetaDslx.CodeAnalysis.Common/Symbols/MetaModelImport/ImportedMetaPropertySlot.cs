using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.MetaModelImport
{
    internal class ImportedMetaPropertySlot : MetaPropertySlot<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>
    {
        public ImportedMetaPropertySlot(MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> slotProperty, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> slotProperties, MetaSymbol defaultValue, ModelPropertyFlags flags) 
            : base(slotProperty, slotProperties, defaultValue, flags)
        {
        }
    }
}
