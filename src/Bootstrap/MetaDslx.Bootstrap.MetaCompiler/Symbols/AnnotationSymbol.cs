using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using System.Threading;
using MetaDslx.CodeAnalysis.PooledObjects;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    using INamedTypeSymbol = Microsoft.CodeAnalysis.INamedTypeSymbol;
    using IMethodSymbol = Microsoft.CodeAnalysis.IMethodSymbol;
    using IParameterSymbol = Microsoft.CodeAnalysis.IParameterSymbol;

    internal class AnnotationSymbol : SourceAttributeSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_AttributeClass = AttributeSymbol.CompletionParts.StartComputingProperty_AttributeClass;
            public static readonly CompletionPart FinishComputingProperty_AttributeClass = AttributeSymbol.CompletionParts.FinishComputingProperty_AttributeClass;
            public static readonly CompletionPart StartComputingProperty_Arguments = new CompletionPart(nameof(StartComputingProperty_Arguments));
            public static readonly CompletionPart FinishComputingProperty_Arguments = new CompletionPart(nameof(FinishComputingProperty_Arguments));
            public static readonly CompletionPart StartComputingProperty_ArgumentParameters = new CompletionPart(nameof(StartComputingProperty_ArgumentParameters));
            public static readonly CompletionPart FinishComputingProperty_ArgumentParameters = new CompletionPart(nameof(FinishComputingProperty_ArgumentParameters));
            public static readonly CompletionPart StartComputingProperty_SelectedParameters = new CompletionPart(nameof(StartComputingProperty_SelectedParameters));
            public static readonly CompletionPart FinishComputingProperty_SelectedParameters = new CompletionPart(nameof(FinishComputingProperty_SelectedParameters));
            public static readonly CompletionPart StartComputingProperty_Attributes = AttributeSymbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = AttributeSymbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_AttributeClass, FinishComputingProperty_AttributeClass,
                    StartComputingProperty_Arguments, FinishComputingProperty_Arguments,
                    StartComputingProperty_ArgumentParameters, FinishComputingProperty_ArgumentParameters,
                    StartComputingProperty_SelectedParameters, FinishComputingProperty_SelectedParameters,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private ImmutableArray<AnnotationArgumentSymbol> _arguments;
        private ImmutableArray<DeclaredSymbol> _constructors;
        private ImmutableArray<ImmutableArray<DeclaredSymbol>> _parameters;
        private ImmutableArray<ImmutableArray<DeclaredSymbol>> _argumentParameters;
        private DeclaredSymbol? _selectedConstructor;
        private ImmutableArray<DeclaredSymbol> _selectedParameters;

        public AnnotationSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [ModelProperty]
        public ImmutableArray<AnnotationArgumentSymbol> Arguments
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Arguments, null, default);
                return _arguments;
            }
        }

        public ImmutableArray<DeclaredSymbol> Constructors
        {
            get
            {
                if (_constructors.IsDefault)
                {
                    var constructors = ArrayBuilder<DeclaredSymbol>.GetInstance();
                    var csType = this.AttributeClass as ICSharpSymbol;
                    var msType = csType?.CSharpSymbol as INamedTypeSymbol;
                    if (msType is not null)
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        foreach (var msCtr in msType.InstanceConstructors)
                        {
                            var csCtr = csType.SymbolFactory.GetSymbol<DeclaredSymbol>(msCtr, diagnostics, default);
                            if (csCtr is not null) constructors.Add(csCtr);
                        }
                        this.AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                    }
                    ImmutableInterlocked.InterlockedInitialize(ref _constructors, constructors.ToImmutableAndFree());
                }
                return _constructors;
            }
        }

        public ImmutableArray<ImmutableArray<DeclaredSymbol>> Parameters
        {
            get
            {
                if (_parameters.IsDefault)
                {
                    var parameters = ArrayBuilder<ImmutableArray<DeclaredSymbol>>.GetInstance();
                    var ctrParams = ArrayBuilder<DeclaredSymbol>.GetInstance();
                    var diagnostics = DiagnosticBag.GetInstance();
                    foreach (var ctr in this.Constructors)
                    {
                        ctrParams.Clear();
                        var csCtr = ctr as ICSharpSymbol;
                        var msCtr = csCtr.CSharpSymbol as IMethodSymbol;
                        if (msCtr is not null)
                        {
                            foreach (var msParam in msCtr.Parameters)
                            {
                                var csParam = csCtr.SymbolFactory.GetSymbol<DeclaredSymbol>(msParam, diagnostics, default);
                                if (csParam is not null)
                                {
                                    ctrParams.Add(csParam);
                                }
                            }
                        }
                        parameters.Add(ctrParams.ToImmutable());
                    }
                    this.AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    ctrParams.Free();
                    ImmutableInterlocked.InterlockedInitialize(ref _parameters, parameters.ToImmutableAndFree());
                }
                return _parameters;
            }
        }

        public ImmutableArray<ImmutableArray<DeclaredSymbol>> ArgumentParameters
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ArgumentParameters, null, default);
                return _argumentParameters;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_Arguments || incompletePart == CompletionParts.FinishComputingProperty_Arguments)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Arguments))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _arguments = CompleteProperty_Arguments(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Arguments);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_ArgumentParameters || incompletePart == CompletionParts.FinishComputingProperty_ArgumentParameters)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_ArgumentParameters))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _argumentParameters = CompleteProperty_ArgumentParameters(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_ArgumentParameters);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_SelectedParameters || incompletePart == CompletionParts.FinishComputingProperty_SelectedParameters)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_SelectedParameters))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var selected = CompleteProperty_SelectedParameters(diagnostics, cancellationToken);
                    _selectedConstructor = selected.Constructor;
                    _selectedParameters = selected.Parameters;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_SelectedParameters);
                }
                return true;
            }
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected virtual MetaType CompleteProperty_Type(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<MetaType>(this, nameof(Type), diagnostics, cancellationToken);
        }

        protected virtual ImmutableArray<AnnotationArgumentSymbol> CompleteProperty_Arguments(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<AnnotationArgumentSymbol>(this, nameof(Arguments), diagnostics, cancellationToken);
        }

        private ImmutableArray<ImmutableArray<DeclaredSymbol>> CompleteProperty_ArgumentParameters(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var valid = new bool[Constructors.Length];
            for (int i = 0; i < valid.Length; ++i)
            {
                valid[i] = true;
                var ctr = Constructors[i];
                var parameters = Parameters[i];
                var indexing = true;
                for (int j = 0; j < Arguments.Length; ++j)
                {
                    var arg = Arguments[j];
                    if (arg.IsNamedArgument)
                    {
                        indexing = false;
                        valid[i] = false;
                        foreach (var argParam in arg.NamedParameter)
                        {
                            if (argParam.OriginalSymbol?.ContainingSymbol == ctr)
                            {
                                valid[i] = true;
                                break;
                            }
                        }
                    }
                    else if (indexing)
                    {
                        if (j >= parameters.Length) valid[i] = false;
                    }
                    else
                    {
                        valid[i] = false;
                        diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, arg.Location, "Unnamed arguments are not allowed after named arguments."));
                    }
                    if (!valid[i]) break;
                }
            }
            var argumentParameters = ArrayBuilder<ImmutableArray<DeclaredSymbol>>.GetInstance();
            var argParams = ArrayBuilder<DeclaredSymbol>.GetInstance();
            for (int j = 0; j < Arguments.Length; ++j)
            {
                var arg = Arguments[j];
                argParams.Clear();
                for (int i = 0; i < valid.Length; ++i)
                {
                    if (valid[i])
                    {
                        if (arg.IsNamedArgument)
                        {
                            var param = arg.NamedParameter.Where(p => p.OriginalSymbol?.ContainingSymbol == Constructors[i]).FirstOrDefault().OriginalSymbol as DeclaredSymbol;
                            if (param is not null)
                            {
                                argParams.Add(param);
                            }
                        }
                        else
                        {
                            argParams.Add(Parameters[i][j]);
                        }
                    }
                }
                argumentParameters.Add(argParams.ToImmutable());
            }
            argParams.Free();
            return argumentParameters.ToImmutableAndFree();
        }

        private (DeclaredSymbol? Constructor, ImmutableArray<DeclaredSymbol> Parameters) CompleteProperty_SelectedParameters(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var valid = new bool[Constructors.Length];
            for (int i = 0; i < valid.Length; ++i)
            {
                valid[i] = true;
                var ctr = Constructors[i];
                var parameters = Parameters[i];
                for (int j = 0; j < Arguments.Length; ++j)
                {
                    var arg = Arguments[j];
                    var argParams = ArgumentParameters[j];
                    var argParam = argParams.FirstOrDefault(p => parameters.Contains(p));
                    if (argParam is not null)
                    {

                    }
                    else
                    {
                        valid[i] = false;
                    }
                }
            }
            return default;
        }
    }
}
