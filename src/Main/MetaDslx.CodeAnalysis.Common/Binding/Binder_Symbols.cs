using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public partial class Binder
    {
        public ImmutableArray<DeclaredSymbol> BindQualifiedName(LookupContext context, ImmutableArray<SyntaxNodeOrToken> qualifier)
        {
            if (qualifier.Length == 0) return ImmutableArray<DeclaredSymbol>.Empty;
            if (qualifier.Length == 1)
            {
                return ImmutableArray.Create(BindDeclaredOrAliasSymbolInternal(context, qualifier[0]));
            }
            else
            {
                var result = ArrayBuilder<DeclaredSymbol>.GetInstance();
                var qualifierContext = context.AllocateCopy();
                qualifierContext.ClearResult();
                qualifierContext.Validators.Clear();
                result.Add(BindDeclaredOrAliasSymbolInternal(qualifierContext, qualifier[0]));
                context.Diagnostics.AddRange(qualifierContext.Diagnostics);
                var last = result[0];
                for (int i = 1; i < qualifier.Length; i++)
                {
                    if (last is null || last.IsError) break;
                    var identifierContext = i + 1 < qualifier.Length ? qualifierContext : context;
                    identifierContext.Qualifier = last;
                    identifierContext.ClearResult();
                    result.Add(this.BindDeclaredOrAliasSymbolInternal(identifierContext, qualifier[i]));
                    context.Diagnostics.AddRange(identifierContext.Diagnostics);
                    last = result[i];
                }
                qualifierContext.Free();
                return result.ToImmutableAndFree();
            }
        }

        public ImmutableArray<DeclaredSymbol> BindQualifiedName(LookupContext context, ImmutableArray<string> qualifier)
        {
            if (qualifier.Length == 0) return ImmutableArray<DeclaredSymbol>.Empty;
            if (qualifier.Length == 1)
            {
                context.SetName(qualifier[0]);
                return ImmutableArray.Create(BindDeclaredOrAliasSymbolInternal(context));
            }
            else
            {
                var result = ArrayBuilder<DeclaredSymbol>.GetInstance();
                var qualifierContext = context.AllocateCopy();
                qualifierContext.Validators.Clear();
                qualifierContext.SetName(qualifier[0]);
                result.Add(BindDeclaredOrAliasSymbolInternal(qualifierContext));
                var last = result[0];
                for (int i = 0; i < qualifier.Length; i++)
                {
                    if (last is null) break;
                    var identifierContext = i + 1 < qualifier.Length ? qualifierContext : context;
                    identifierContext.Qualifier = last;
                    identifierContext.SetName(qualifier[i]);
                    result.Add(this.BindDeclaredOrAliasSymbolInternal(identifierContext));
                    last = result[i];
                }
                qualifierContext.Free();
                return result.ToImmutableAndFree();
            }
        }

        /// <summary>
        /// Bind the syntax into a declared symbol by also unwrapping alias symbols. 
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public DeclaredSymbol BindDeclaredSymbol(LookupContext context, SyntaxNodeOrToken identifierSyntax)
        {
            var result = BindDeclaredOrAliasSymbolInternal(context, identifierSyntax);
            return AliasSymbol.UnwrapAlias(context, result);
        }

        /// <summary>
        /// Bind the syntax into a declared symbol or an alias. 
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public DeclaredSymbol BindDeclaredOrAliasSymbol(LookupContext context, SyntaxNodeOrToken identifierSyntax)
        {
            var result = BindDeclaredOrAliasSymbolInternal(context, identifierSyntax);
            return result;
        }

        private DeclaredSymbol BindDeclaredOrAliasSymbolInternal(LookupContext context, SyntaxNodeOrToken identifierSyntax)
        {
            var syntaxFacts = identifierSyntax.Language.SyntaxFacts;
            var name = syntaxFacts.ExtractName(identifierSyntax);
            var metadataName = syntaxFacts.ExtractMetadataName(identifierSyntax);
            var binder = identifierSyntax.IsNull ? this : this.GetBinder(identifierSyntax);
            context.OriginalBinder = this;
            context.IsLookup = true;
            context.SetName(name, metadataName);
            context.Location = identifierSyntax.GetLocation() as SourceLocation;
            return binder.BindDeclaredOrAliasSymbolInternal(context);
        }

        private DeclaredSymbol BindDeclaredOrAliasSymbolInternal(LookupContext context)
        {
            var name = context.ViableNames.FirstOrDefault();
            if (string.IsNullOrWhiteSpace(name))
            {
                return context.ErrorSymbolFactory.CreateSymbol<NamedTypeSymbol>(Compilation.GlobalNamespace, new DiagnosticInfo(CommonErrorCode.ERR_SingleNameNotFound, name));
            }
            this.AdjustLookupContext(context);
            this.LookupSymbols(context);
            return context.GetResultSymbol();
        }
    }
}
