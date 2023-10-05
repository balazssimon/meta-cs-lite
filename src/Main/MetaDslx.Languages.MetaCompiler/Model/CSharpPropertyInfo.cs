using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    using CSharpCompilation = Microsoft.CodeAnalysis.CSharp.CSharpCompilation;
    using INamespaceSymbol = Microsoft.CodeAnalysis.INamespaceSymbol;
    using INamespaceOrTypeSymbol = Microsoft.CodeAnalysis.INamespaceOrTypeSymbol;
    using INamedTypeSymbol = Microsoft.CodeAnalysis.INamedTypeSymbol;
    using ITypeSymbol = Microsoft.CodeAnalysis.ITypeSymbol;
    using IArrayTypeSymbol = Microsoft.CodeAnalysis.IArrayTypeSymbol;
    using IMethodSymbol = Microsoft.CodeAnalysis.IMethodSymbol;
    using IParameterSymbol = Microsoft.CodeAnalysis.IParameterSymbol;
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;
    using SymbolDisplayFormat = Microsoft.CodeAnalysis.SymbolDisplayFormat;

    public class CSharpPropertyInfo
    {
        private readonly CSharpTypeInfo _modelObjectType;
        private readonly string _propertyName;
        private readonly CSharpTypeInfo _propertyType;
        private readonly bool _writable;

        public CSharpPropertyInfo(CSharpTypeInfo modelObjectType, string propertyName, ITypeSymbol propertyType, bool writable)
        {
            _modelObjectType = modelObjectType;
            _propertyName = propertyName;
            _propertyType = new CSharpTypeInfo(modelObjectType?.Language, propertyType);
            _writable = writable;
        }

        public CSharpTypeInfo ModelObjectType => _modelObjectType;
        public string PropertyName => _propertyName;
        public CSharpTypeInfo PropertyType => _propertyType;
        public bool IsWritable => _writable || _propertyType.TypeKind == TypeKind.GenericCollection;
        public bool IsCollection => _propertyType.TypeKind != TypeKind.Single;
        public bool IsBool => _propertyType.ItemTypeKind == ItemTypeKind.BoolType;
        public bool IsEnum => _propertyType.ItemTypeKind == ItemTypeKind.EnumType;
        public bool IsDefault => _propertyType.IsDefault;
    }
}
