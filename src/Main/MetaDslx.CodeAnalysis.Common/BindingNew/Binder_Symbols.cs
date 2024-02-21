using MetaDslx.CodeAnalysis.Binding.Lookup;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Errors;
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
        public ImmutableArray<DeclarationSymbol> BindQualifiedName(LookupContext context, ImmutableArray<SyntaxNodeOrToken> qualifier)
        {
            if (qualifier.Length == 0) return ImmutableArray<DeclarationSymbol>.Empty;
            this.AdjustInitialLookupContext(context);
            if (qualifier.Length == 1)
            {
                this.AdjustFinalLookupContext(context);
                return ImmutableArray.Create(BindDeclarationOrAliasSymbolInternal(context, qualifier[0]));
            }
            else
            {
                var result = ArrayBuilder<DeclarationSymbol>.GetInstance();
                var qualifierContext = context.AllocateCopy();
                qualifierContext.ClearResult();
                qualifierContext.Validators.Clear();
                qualifierContext.Validators.Add(LookupValidators.NamespaceOrTypeOnly);
                result.Add(BindDeclarationOrAliasSymbolInternal(qualifierContext, qualifier[0]));
                context.Diagnostics.AddRange(qualifierContext.Diagnostics);
                var previous = result[0];
                for (int i = 1; i < qualifier.Length; i++)
                {
                    if (previous is null || previous.IsErrorSymbol) break;
                    var isFinal = i == qualifier.Length - 1;
                    var identifierContext = qualifierContext;
                    if (isFinal) identifierContext = context;
                    else identifierContext.ClearResult();
                    identifierContext.Qualifier = previous;
                    if (isFinal) this.AdjustFinalLookupContext(identifierContext);
                    result.Add(this.BindDeclarationOrAliasSymbolInternal(identifierContext, qualifier[i]));
                    context.Diagnostics.AddRange(qualifierContext.Diagnostics); // intentionally qualifierContext, diagnostics for the last identifier are collected in the original context
                    previous = result[i];
                }
                qualifierContext.Free();
                return result.ToImmutableAndFree();
            }
        }

        public ImmutableArray<DeclarationSymbol> BindQualifiedName(LookupContext context, ImmutableArray<string> qualifier)
        {
            if (qualifier.Length == 0) return ImmutableArray<DeclarationSymbol>.Empty;
            this.AdjustInitialLookupContext(context);
            if (qualifier.Length == 1)
            {
                context.SetName(qualifier[0]);
                this.AdjustFinalLookupContext(context);
                return ImmutableArray.Create(BindDeclarationOrAliasSymbolInternal(context));
            }
            else
            {
                var result = ArrayBuilder<DeclarationSymbol>.GetInstance();
                var qualifierContext = context.AllocateCopy();
                qualifierContext.ClearResult();
                qualifierContext.Validators.Clear();
                qualifierContext.Validators.Add(LookupValidators.NamespaceOrTypeOnly);
                qualifierContext.SetName(qualifier[0]);
                result.Add(BindDeclarationOrAliasSymbolInternal(qualifierContext));
                context.Diagnostics.AddRange(qualifierContext.Diagnostics);
                var previous = result[0];
                for (int i = 1; i < qualifier.Length; i++)
                {
                    if (previous is null || previous.IsErrorSymbol) break;
                    var isFinal = i == qualifier.Length - 1;
                    var identifierContext = qualifierContext;
                    if (isFinal) identifierContext = context;
                    else identifierContext.ClearResult();
                    identifierContext.Qualifier = previous;
                    identifierContext.SetName(qualifier[i]);
                    if (isFinal) this.AdjustFinalLookupContext(identifierContext);
                    result.Add(this.BindDeclarationOrAliasSymbolInternal(identifierContext));
                    context.Diagnostics.AddRange(qualifierContext.Diagnostics); // intentionally qualifierContext, diagnostics for the last identifier are collected in the original context
                    previous = result[i];
                }
                qualifierContext.Free();
                return result.ToImmutableAndFree();
            }
        }

        /// <summary>
        /// Bind the syntax into a declaration symbol by also unwrapping alias symbols. 
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public DeclarationSymbol BindDeclarationSymbol(LookupContext context, SyntaxNodeOrToken identifierSyntax)
        {
            this.AdjustInitialLookupContext(context);
            this.AdjustFinalLookupContext(context);
            var result = BindDeclarationOrAliasSymbolInternal(context, identifierSyntax);
            return UnwrapAlias(result) as DeclarationSymbol;
        }

        /// <summary>
        /// Bind the syntax into a declaration symbol or an alias. 
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public DeclarationSymbol BindDeclarationOrAliasSymbol(LookupContext context, SyntaxNodeOrToken identifierSyntax)
        {
            this.AdjustInitialLookupContext(context);
            this.AdjustFinalLookupContext(context);
            var result = BindDeclarationOrAliasSymbolInternal(context, identifierSyntax);
            return result;
        }

        private DeclarationSymbol BindDeclarationOrAliasSymbolInternal(LookupContext context, SyntaxNodeOrToken identifierSyntax)
        {
            var syntaxFacts = identifierSyntax.Language.SyntaxFacts;
            var name = syntaxFacts.ExtractName(identifierSyntax);
            var metadataName = syntaxFacts.ExtractMetadataName(identifierSyntax);
            var binder = (identifierSyntax.IsNull ? this : this.GetBinder(identifierSyntax)) ?? this;
            context.OriginalBinder = this;
            context.CurrentBinder = binder;
            context.IsLookup = true;
            context.SetName(name, metadataName);
            context.Location = identifierSyntax.GetLocation() as SourceLocation;
            return binder.BindDeclarationOrAliasSymbolInternal(context);
        }

        private DeclarationSymbol BindDeclarationOrAliasSymbolInternal(LookupContext context)
        {
            var name = context.ViableNames.FirstOrDefault();
            if (string.IsNullOrWhiteSpace(name))
            {
                var errorInfo = new ErrorSymbolInfo(string.Empty, string.Empty, ImmutableArray<Symbol>.Empty, Diagnostic.Create(CommonErrorCode.ERR_SingleNameNotFound, context.Location, name));
                context.AddDiagnostic(errorInfo.Diagnostic);
                return context.ErrorSymbolFactory.CreateSymbol<TypeSymbol>(Compilation.GlobalNamespace, errorInfo, null, default);
            }
            this.LookupSymbols(context);
            return context.GetResultSymbol();
        }
    }
}
