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
using MetaDslx.Bootstrap.MetaCompiler2.Model;
using MetaDslx.Bootstrap.MetaCompiler2.Compiler.Syntax;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using Antlr4.Runtime.Misc;

namespace MetaDslx.Bootstrap.MetaCompiler2.Symbols
{
    using IParameterSymbol = Microsoft.CodeAnalysis.IParameterSymbol;

    internal class AnnotationArgumentSymbol : SourceSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_NamedParameter = new CompletionPart(nameof(StartComputingProperty_NamedParameter));
            public static readonly CompletionPart FinishComputingProperty_NamedParameter = new CompletionPart(nameof(FinishComputingProperty_NamedParameter));
            public static readonly CompletionPart StartComputingProperty_Parameter = new CompletionPart(nameof(StartComputingProperty_Parameter));
            public static readonly CompletionPart FinishComputingProperty_Parameter = new CompletionPart(nameof(FinishComputingProperty_Parameter));
            public static readonly CompletionPart StartComputingProperty_Value = new CompletionPart(nameof(StartComputingProperty_Value));
            public static readonly CompletionPart FinishComputingProperty_Value = new CompletionPart(nameof(FinishComputingProperty_Value));
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_NamedParameter, FinishComputingProperty_NamedParameter,
                    StartComputingProperty_Parameter, FinishComputingProperty_Parameter,
                    StartComputingProperty_Value, FinishComputingProperty_Value,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private ImmutableArray<MetaSymbol> _namedParameter;
        private DeclarationSymbol? _parameter;
        private MetaType _parameterType;
        private ExpressionSymbol _value;

        public AnnotationArgumentSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public AnnotationSymbol? AnnotationSymbol => (AnnotationSymbol)this.ContainingSymbol;

        public AnnotationArgumentSyntax? Syntax => this.DeclaringSyntaxReference.AsNode() as AnnotationArgumentSyntax;

        public bool IsNamedArgument => Syntax?.Block is not null;

        [ModelProperty]
        public ImmutableArray<MetaSymbol> NamedParameter
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_NamedParameter, null, default);
                return _namedParameter;
            }
        }

        [ModelProperty]
        public DeclarationSymbol? Parameter
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Parameter, null, default);
                return _parameter;
            }
        }

        public MetaType ParameterType
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Parameter, null, default);
                return _parameterType;
            }
        }

        [ModelProperty]
        public ExpressionSymbol Value
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Value, null, default);
                return _value;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_NamedParameter || incompletePart == CompletionParts.FinishComputingProperty_NamedParameter)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_NamedParameter))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _namedParameter = CompleteProperty_NamedParameter(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_NamedParameter);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_Parameter || incompletePart == CompletionParts.FinishComputingProperty_Parameter)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Parameter))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var param = CompleteProperty_Parameter(diagnostics, cancellationToken);
                    _parameter = param.Parameter;
                    _parameterType = param.ParameterType;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Parameter);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_Value || incompletePart == CompletionParts.FinishComputingProperty_Value)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Value))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _value = CompleteProperty_Value(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Value);
                }
                return true;
            }
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected virtual ImmutableArray<MetaSymbol> CompleteProperty_NamedParameter(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<MetaSymbol>(this, nameof(NamedParameter), diagnostics, cancellationToken);
        }

        protected virtual (DeclarationSymbol? Parameter, MetaType ParameterType) CompleteProperty_Parameter(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var index = AnnotationSymbol?.Arguments.IndexOf(this) ?? -1;
            if (index < 0) return default;
            var param = AnnotationSymbol?.SelectedParameters[index];
            if (param is null)
            {
                diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, this.Location, "Could not resolve the parameter corresponding to this argument"));
                return default;
            }
            var slot = ModelObject.MGetSlot(MetaDslx.Bootstrap.MetaCompiler2.Model.Compiler.AnnotationArgument_Parameter);
            slot?.Add(param);
            var csParam = param as ICSharpSymbol;
            var msProp = csParam?.CSharpSymbol as IParameterSymbol;
            var msType = msProp?.Type;
            var csType = msType is null ? null : csParam?.SymbolFactory.GetSymbol<TypeSymbol>(msType, diagnostics, cancellationToken);
            var mtType = MetaType.FromTypeSymbol(csType);
            if (mtType.IsNullable) mtType.TryExtractNullableType(out mtType, diagnostics, cancellationToken);
            if (mtType.TryGetCoreType(out var coreType, diagnostics, cancellationToken) && !coreType.IsDefaultOrNull)
            {
                var typeSlot = ModelObject.MGetSlot(MetaDslx.Bootstrap.MetaCompiler2.Model.Compiler.AnnotationArgument_ParameterType);
                typeSlot?.Add(mtType);
            }
            else
            {
                diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, this.Location, $"Could not determine the type of the parameter '{Syntax?.Block?.NamedParameter}'"));
                return default;
            }
            return (param, mtType);
        }

        protected virtual ExpressionSymbol CompleteProperty_Value(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<ExpressionSymbol>(this, nameof(Value), diagnostics, cancellationToken);
        }

    }
}
