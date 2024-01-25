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
            if (_identifiers is null) _identifiers = ArrayBuilder<IdentifierBuilder>.GetInstance();
            _identifiers.Add(new IdentifierBuilder(name, metadataName, nameLocation, type, qualifierProperty));
        }

        public SingleDeclaration ToImmutableAndFree(SingleDeclarationBuilder declaration)
        {
            if (_identifiers is null)
            {
                return SingleDeclaration.Create(declaration.Syntax, declaration.Type, null, null, null, canMerge: declaration.CanMerge, isNesting: false, null, declaration.GetChildren(), declaration.GetDiagnostics());
            }
            else
            {
                SingleDeclaration? result = null;
                for (int i = _identifiers.Count - 1; i >= 0; --i)
                {
                    var identifier = _identifiers[i];
                    if (i == _identifiers.Count - 1)
                    {
                        result = SingleDeclaration.Create(declaration.Syntax, declaration.Type, identifier.Name, identifier.MetadataName, identifier.NameLocation,
                           declaration.CanMerge, isNesting: false, qualifierProperty: identifier.QualifierProperty, declaration.GetChildren(), declaration.GetDiagnostics());
                    }
                    else
                    {
                        result = SingleDeclaration.Create(declaration.Syntax, identifier.QualifierType ?? declaration.Type, identifier.Name, identifier.MetadataName, identifier.NameLocation,
                            canMerge: true, isNesting: true, qualifierProperty: identifier.QualifierProperty, ImmutableArray.Create(result), ImmutableArray<Diagnostic>.Empty);
                    }
                }
                _identifiers.Free();
                return result;
            }
        }
    }
}
