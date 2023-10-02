using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
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

    public enum UsingKind
    {
        None,
        Language
    }

    public class Using
    {
        private readonly Language _language;
        private bool _resolved;
        private INamespaceOrTypeSymbol? _csharpSymbol;

        public Using(Language language)
        {
            _language = language;
        }

        public UsingKind Kind { get; set; }
        public string? Alias { get; set; }
        public Location AliasLocation { get; set; }
        public ImmutableArray<string> Reference { get; set; }
        public string QualifiedReference => string.Join(".", Reference);
        public Location ReferenceLocation { get; set; }
        public INamespaceOrTypeSymbol? CSharpSymbol
        {
            get
            {
                Resolve();
                return _csharpSymbol;
            }
        }

        private void Resolve()
        {
            if (_resolved) return;
            _resolved = true;
            if (Reference.IsDefaultOrEmpty)
            {
                _language.Error(ReferenceLocation, "Namespace name is missing.");
                return;
            }
            INamespaceOrTypeSymbol? csharpSymbol = _language.Compilation.GlobalNamespace;
            if (csharpSymbol is null) return;
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            foreach (var name in Reference)
            {
                if (sb.Length > 0) sb.Append(".");
                csharpSymbol = csharpSymbol.GetMembers().Where(ns => ns.Name == name).OfType<INamespaceOrTypeSymbol>().FirstOrDefault();
                if (csharpSymbol is null)
                {
                    if (sb.Length > 0) _language.Error(ReferenceLocation, $"The type or namespace '{name}' does not exist in '{sb}' (are you missing an assembly reference?).");
                    else _language.Error(ReferenceLocation, $"The type or namespace '{name}' could not be found (are you missing an assembly reference?).");
                    break;
                }
                sb.Append(name);
            }
            builder.Free();
            _csharpSymbol = csharpSymbol;
        }
    }
}
