using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Meta;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.MetaModelImport
{
    internal class ImportedMetaGraph : MetaGraph<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>
    {
        private readonly ImportedMetaModel _metaModel;
        private CSharpSymbolFactory _factory;

        public ImportedMetaGraph(ImportedMetaModel metaModel, IEnumerable<MetaType> classTypes, CSharpSymbolFactory factory) 
            : base(classTypes)
        {
            _metaModel = metaModel;
            _factory = factory;
        }

        protected override bool IsCollectionType(MetaType type, out MetaType itemType, out ModelPropertyFlags collectionFlags)
        {
            var cstype = CSharpType(type) as INamedTypeSymbol;
            if (cstype is not null && cstype.IsGenericType && cstype.TypeArguments.Length == 1)
            {
                // TODO: check valid collection type names
                var diagnostics = DiagnosticBag.GetInstance();
                itemType = _factory.GetSymbol<TypeSymbol>(cstype.TypeArguments[0], diagnostics, default);
                collectionFlags = default;
                diagnostics.Free();
                return true;
            }
            itemType = default;
            collectionFlags = default;
            return false;
        }

        protected override bool IsEnumType(MetaType type)
        {
            var cstype = CSharpType(type);
            if (cstype is not null)
            {
                return cstype.TypeKind == TypeKind.Enum;
            }
            return false;
        }

        protected override bool IsNullableType(MetaType type, out MetaType innerType)
        {
            var cstype = CSharpType(type);
            if (cstype is not null && cstype.NullableAnnotation == NullableAnnotation.Annotated)
            {
                if (cstype.TypeKind == TypeKind.Struct && cstype is INamedTypeSymbol nts && nts.Name == "Nullable" && nts.TypeArguments.Length == 1)
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    innerType = _factory.GetSymbol<TypeSymbol>(nts.TypeArguments[0], diagnostics, default);
                    diagnostics.Free();
                    return true;
                }
            }
            innerType = default;
            return false;
        }

        protected override bool IsPrimitiveType(MetaType type)
        {
            return type.MetaKeyword is not null;
        }

        protected override bool IsValueType(MetaType type)
        {
            if (IsPrimitiveType(type) || IsEnumType(type)) return true;
            var cstype = CSharpType(type);
            return cstype?.IsValueType ?? false;
        }

        private ITypeSymbol? CSharpType(MetaType type)
        {
            if (type.OriginalTypeSymbol is CSharpTypeSymbol cstype)
            {
                return cstype.CSharpSymbol;
            }
            return null;
        }

        protected override MetaClass<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> MakeClass(MetaType classType)
        {
            return new ImportedMetaClass(_metaModel, classType);
        }

        protected override MetaOperation<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> MakeOperation(MetaClass<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> declaringType, CSharpDeclaredSymbol operation)
        {
            return new ImportedMetaOperation(declaringType, operation);
        }

        protected override MetaOperationInfo<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> MakeOperationInfo(ImmutableArray<MetaOperation<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> overridenOperations, ImmutableArray<MetaOperation<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> overridingOperations)
        {
            return new ImportedMetaOperationInfo(overridenOperations, overridingOperations);
        }

        protected override MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> MakeProperty(MetaClass<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> declaringType, CSharpDeclaredSymbol property)
        {
            return new ImportedMetaProperty(declaringType, property);
        }

        protected override MetaPropertyInfo<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> MakePropertyInfo(MetaPropertySlot<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> slot, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> oppositeProperties, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> subsettedProperties, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> subsettingProperties, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> redefinedProperties, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> redefiningProperties, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> hiddenProperties, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> hidingProperties)
        {
            return new ImportedMetaPropertyInfo(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties, hiddenProperties, hidingProperties);
        }

        protected override MetaPropertySlot<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> MakePropertySlot(MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> slotProperty, ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> slotProperties, MetaSymbol defaultValue, ModelPropertyFlags flags)
        {
            return new ImportedMetaPropertySlot(slotProperty, slotProperties, defaultValue, flags);
        }
    }
}
