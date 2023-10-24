using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    using CSharpCompilation = Microsoft.CodeAnalysis.CSharp.CSharpCompilation;
    using ISymbol = Microsoft.CodeAnalysis.ISymbol;
    using INamespaceSymbol = Microsoft.CodeAnalysis.INamespaceSymbol;
    using INamespaceOrTypeSymbol = Microsoft.CodeAnalysis.INamespaceOrTypeSymbol;
    using INamedTypeSymbol = Microsoft.CodeAnalysis.INamedTypeSymbol;
    using ITypeSymbol = Microsoft.CodeAnalysis.ITypeSymbol;
    using IArrayTypeSymbol = Microsoft.CodeAnalysis.IArrayTypeSymbol;
    using IMethodSymbol = Microsoft.CodeAnalysis.IMethodSymbol;
    using IParameterSymbol = Microsoft.CodeAnalysis.IParameterSymbol;
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;
    using SymbolDisplayFormat = Microsoft.CodeAnalysis.SymbolDisplayFormat;

    public class Expression
    {
        public Location Location { get; set; }
        public string ValueText { get; set; }
        public object Value { get; set; }
        public ImmutableArray<string> Qualifier { get; set; }
        public Type Type { get; set; }
        public CSharpTypeInfo CSharpType { get; set; }

        public string ToCSharpValue()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            if (Value is null)
            {
                if (CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.Nullable)) sb.Append("null");
                else sb.Append("default");
            }
            else if (CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.SystemType))
            {
                sb.Append("typeof(");
                var nts = Value as INamedTypeSymbol;
                if (nts != null)
                {
                    sb.Append(nts.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat));
                }
                sb.Append(")");
            }
            else if (CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.EnumType))
            {
                var literal = Value.ToString();
                if (!literal.Contains("."))
                {
                    sb.Append(CSharpType.CoreType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat));
                    sb.Append(".");
                }
                sb.Append(literal);
            }
            else if (CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.BoolType))
            {
                if (Value is bool boolValue && boolValue) sb.Append("true");
                else sb.Append("false");
            }
            else if (CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.CharType))
            {
                if (Value is char charValue) sb.Append(StringUtilities.EncodeChar(charValue));
                else sb.Append("'\\0'");
            }
            else if (CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.StringType))
            {
                if (Value is string stringValue) sb.Append(StringUtilities.EncodeString(stringValue));
                else sb.Append("\"\"");
            }
            else if (CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.ByteType) ||
                CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.SByteType) ||
                CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.ShortType) ||
                CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.UShortType) ||
                CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.IntType) ||
                CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.UIntType) ||
                CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.LongType) ||
                CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.ULongType) ||
                CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.FloatType) ||
                CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.DoubleType) ||
                CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.DecimalType))
            {
                sb.Append(Value.ToString());
            }
            else if (CSharpType.ItemTypeKind.HasFlag(ItemTypeKind.ObjectType))
            {
                sb.Append(Value.ToString());
            }
            else
            {
                if (Value is ISymbol symbol)
                {
                    return symbol.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                }
                else
                {
                    Debug.Assert(false);
                }
            }
            return builder.ToStringAndFree();
        }
    }
}
