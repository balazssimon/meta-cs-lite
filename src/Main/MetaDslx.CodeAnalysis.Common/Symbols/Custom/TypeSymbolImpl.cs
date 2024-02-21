using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.CodeAnalysis.Symbols.Impl
{
    using __Model = MetaDslx.Modeling.Model;
    using __IModelObject = MetaDslx.Modeling.IModelObject;
    using __ISymbol = Microsoft.CodeAnalysis.ISymbol;

    public class TypeSymbolImpl : TypeSymbol
    {
        public TypeSymbolImpl(Symbol? container, Compilation? compilation = null, MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, bool isReferenceType = default, bool isValueType = default, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes = default, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility = default, bool isStatic = default, bool isExtern = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments = default, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes, declaredAccessibility: declaredAccessibility, isStatic: isStatic, isExtern: isExtern, typeArguments: typeArguments, imports: imports)
        {
        }

        protected override ImmutableArray<TypeSymbol> Complete_AllBaseTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return BaseTypes; // TODO
        }

        public override bool IsDerivedFrom(TypeSymbol type, TypeEqualityComparer comparison)
        {
            Debug.Assert(type is not null);
            if (object.ReferenceEquals(this, type)) return false;
            return AllBaseTypes.Any(t => comparison.Equals(t, type));
        }

        public override bool IsEqualToOrDerivedFrom(TypeSymbol type, TypeEqualityComparer comparison)
        {
            return comparison.Equals(this, type) || this.IsDerivedFrom(type, comparison);
        }
    }
}
