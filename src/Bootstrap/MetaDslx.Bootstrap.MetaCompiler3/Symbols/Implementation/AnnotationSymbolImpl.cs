using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.Bootstrap.MetaCompiler3.Symbols.Implementation
{
    using __Model = MetaDslx.Modeling.Model;
    using __IModelObject = MetaDslx.Modeling.IModelObject;
    using __ISymbol = Microsoft.CodeAnalysis.ISymbol;
    using INamedTypeSymbol = Microsoft.CodeAnalysis.INamedTypeSymbol;
    using IMethodSymbol = Microsoft.CodeAnalysis.IMethodSymbol;
    using IParameterSymbol = Microsoft.CodeAnalysis.IParameterSymbol;

    public class AnnotationSymbolImpl : AnnotationSymbol
    {
        public AnnotationSymbolImpl(Symbol? container, Compilation? compilation, MergedDeclaration? declaration, __IModelObject? modelObject, __ISymbol? csharpSymbol, ErrorSymbolInfo? errorInfo)
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
        }

        protected override ImmutableArray<DeclarationSymbol> Compute_Constructors(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var constructors = ArrayBuilder<DeclarationSymbol>.GetInstance();
            var csType = this.AttributeClass;
            var msType = csType?.CSharpSymbol as INamedTypeSymbol;
            if (msType is not null)
            {
                foreach (var msCtr in msType.InstanceConstructors)
                {
                    var csCtr = csType.ContainingModule.SymbolFactory.GetSymbol<DeclarationSymbol>(msCtr, diagnostics, default);
                    if (csCtr is not null) constructors.Add(csCtr);
                }
            }
            return constructors.ToImmutableAndFree();
        }

        protected override ImmutableArray<ImmutableArray<DeclarationSymbol>> Compute_Parameters(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var parameters = ArrayBuilder<ImmutableArray<DeclarationSymbol>>.GetInstance();
            var ctrParams = ArrayBuilder<DeclarationSymbol>.GetInstance();
            foreach (var ctr in this.Constructors)
            {
                ctrParams.Clear();
                var msCtr = ctr.CSharpSymbol as IMethodSymbol;
                if (msCtr is not null)
                {
                    foreach (var msParam in msCtr.Parameters)
                    {
                        var csParam = ctr.ContainingModule.SymbolFactory.GetSymbol<DeclarationSymbol>(msParam, diagnostics, default);
                        if (csParam is not null)
                        {
                            ctrParams.Add(csParam);
                        }
                    }
                }
                parameters.Add(ctrParams.ToImmutable());
            }
            ctrParams.Free();
            return parameters.ToImmutableAndFree();
        }

        protected override (DeclarationSymbol SelectedConstructor, ImmutableArray<DeclarationSymbol> SelectedParameters) Compute_SelectedConstructor(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var argParams = ArrayBuilder<DeclarationSymbol?>.GetInstance();
            if (Constructors.Length == 0)
            {
                for (int j = 0; j < Arguments.Length; ++j) argParams.Add(null);
                return (null, argParams.ToImmutableAndFree());
            }
            DeclarationSymbol? selectedConstructor = null;
            var selectedParameters = ImmutableArray<DeclarationSymbol>.Empty;
            for (int i = 0; i < Constructors.Length; ++i)
            {
                var valid = true;
                var ctr = Constructors[i];
                var parameters = Parameters[i];
                var indexing = true;
                for (int j = 0; j < Arguments.Length; ++j)
                {
                    var arg = Arguments[j];
                    if (arg.IsNamedArgument)
                    {
                        indexing = false;
                        valid = false;
                        foreach (var argParam in arg.NamedParameter)
                        {
                            if (argParam.OriginalSymbol?.ContainingSymbol == ctr)
                            {
                                valid = true;
                                break;
                            }
                        }
                    }
                    else if (indexing)
                    {
                        if (j >= parameters.Length) valid = false;
                    }
                    else
                    {
                        valid = false;
                        diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, arg.Location, "Unnamed arguments are not allowed after named arguments."));
                    }
                    if (!valid) break;
                }
                for (int j = Arguments.Length; j < parameters.Length; ++j)
                {
                    if (!(parameters[j].CSharpSymbol as IParameterSymbol).HasExplicitDefaultValue)
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid)
                {
                    selectedConstructor = ctr;
                    selectedParameters = parameters;
                    break;
                }
            }
            if (selectedConstructor is null)
            {
                selectedConstructor = Constructors[0];
                selectedParameters = Parameters[0];
            }
            for (int j = 0; j < Arguments.Length; ++j)
            {
                var arg = Arguments[j];
                if (arg.IsNamedArgument)
                {
                    var param = arg.NamedParameter.Where(p => p.OriginalSymbol?.ContainingSymbol == selectedConstructor).FirstOrDefault().OriginalSymbol as DeclarationSymbol;
                    argParams.Add(param);
                }
                else if (j < selectedParameters.Length)
                {
                    argParams.Add(selectedParameters[j]);
                }
                else
                {
                    argParams.Add(null);
                }
            }
            return (selectedConstructor, argParams.ToImmutableAndFree());
        }
    }
}
