﻿using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.MetaModelImport
{
    internal class ImportedMetaOperationInfo : MetaOperationInfo<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>
    {
        public ImportedMetaOperationInfo(ImmutableArray<MetaOperation<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> overridenOperations, ImmutableArray<MetaOperation<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> overridingOperations) 
            : base(overridenOperations, overridingOperations)
        {
        }
    }
}