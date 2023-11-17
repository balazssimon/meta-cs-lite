using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.MetaModelImport
{
    internal class ImportedMetaPropertyInfo : MetaPropertyInfo<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>
    {
        public ImportedMetaPropertyInfo(MetaPropertySlot<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> slot, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> oppositeProperties = default, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> subsettedProperties = default, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> subsettingProperties = default, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> redefinedProperties = default, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> redefiningProperties = default, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> hiddenProperties = default, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> hidingProperties = default) 
            : base(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties, hiddenProperties, hidingProperties)
        {
        }
    }
}
