using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Declarations
{
    public class QualifierBuilder
    {
        private ArrayBuilder<IdentifierBuilder>? _identifiers;
        
        public QualifierBuilder() 
        { 
        }

        public void AddIdentifier(string name, string metadataName, SourceLocation nameLocation, Type? type, string? qualifierProperty)
        {
            if (_identifiers == null) _identifiers = ArrayBuilder<IdentifierBuilder>.GetInstance();
            _identifiers.Add(new IdentifierBuilder(name, metadataName, nameLocation, type, qualifierProperty));
        }

        public SingleDeclaration ToImmutableAndFree(SingleDeclarationBuilder declaration)
        {
            SingleDeclaration? result = null;
            for (int i = _identifiers.Count - 1; i >= 0; --i)
            {
                var identifier = _identifiers[i];
                if (i == _identifiers.Count - 1)
                {
                    result = SingleDeclaration.Create(declaration.Syntax, declaration.Type, identifier.Name, identifier.MetadataName, identifier.NameLocation,
                       declaration.CanMerge, isNesting: false, declaration.GetChildren(), declaration.GetDiagnostics());
                }
                else
                {
                    result = SingleDeclaration.Create(declaration.Syntax, identifier.QualifierType ?? declaration.Type, identifier.Name, identifier.MetadataName, identifier.NameLocation, 
                        canMerge: true, isNesting: true, ImmutableArray.Create(result), ImmutableArray<Diagnostic>.Empty);
                }
            }
            return result;
        }
    }
}
