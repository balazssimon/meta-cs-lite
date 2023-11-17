using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling.Meta;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.MetaModelImport
{
    internal class ImportedMetaOperation : MetaOperation<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>
    {
        public ImportedMetaOperation(MetaClass<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> declaringType, CSharpDeclaredSymbol underlyingOperation) 
            : base(declaringType, underlyingOperation)
        {
        }

        public IMethodSymbol CSharpOperation => (IMethodSymbol)UnderlyingOperation.CSharpSymbol;

        public override string Name => CSharpOperation.Name;

        public override string Signature => $"{CSharpOperation.Name}({CSharpOperation.Parameters.Length})";
    }
}
