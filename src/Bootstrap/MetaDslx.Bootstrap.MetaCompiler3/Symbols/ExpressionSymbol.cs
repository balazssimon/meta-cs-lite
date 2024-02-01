using MetaDslx.Bootstrap.MetaCompiler3.Compiler.Syntax;
using MetaDslx.Bootstrap.MetaCompiler3.Model;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler3.Symbols
{
    internal class ExpressionSymbol : SourceSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_ExpectedType = new CompletionPart(nameof(StartComputingProperty_ExpectedType));
            public static readonly CompletionPart FinishComputingProperty_ExpectedType = new CompletionPart(nameof(FinishComputingProperty_ExpectedType));
            public static readonly CompletionPart StartComputingProperty_Value = new CompletionPart(nameof(StartComputingProperty_Value));
            public static readonly CompletionPart FinishComputingProperty_Value = new CompletionPart(nameof(FinishComputingProperty_Value));
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_ExpectedType, FinishComputingProperty_ExpectedType,
                    StartComputingProperty_Value, FinishComputingProperty_Value,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private MetaType _expectedType;
        private ImmutableArray<MetaSymbol> _values;
        private MetaSymbol _value;
        private PAlternativeSymbol? _containingAlternative;
        private AnnotationArgumentSymbol? _containingAnnotationArgument;

        public ExpressionSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public PAlternativeSymbol? ContainingPAlternativeSymbol
        {
            get
            {
                ComputeContainingSymbol();
                return _containingAlternative;
            }
        }

        public AnnotationArgumentSymbol? ContainingAnnotationArgumentSymbol
        {
            get
            {
                ComputeContainingSymbol();
                return _containingAnnotationArgument;
            }
        }

        private void ComputeContainingSymbol()
        {
            if (_containingAlternative is not null || _containingAnnotationArgument is not null) return;
            var container = this.ContainingSymbol;
            while (container is not null)
            {
                if (container is PAlternativeSymbol pas)
                {
                    Interlocked.CompareExchange(ref _containingAlternative, pas, null);
                    break;
                }
                if (container is AnnotationArgumentSymbol aas)
                {
                    Interlocked.CompareExchange(ref _containingAnnotationArgument, aas, null);
                    break;
                }
                container = container.ContainingSymbol;
            }
        }

        public MetaType ExpectedType
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ExpectedType, null, default);
                return _expectedType;
            }
        }

        [ModelProperty]
        public MetaSymbol Value
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Value, null, default);
                return _value;
            }
        }

        public ImmutableArray<MetaSymbol> Values
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Value, null, default);
                return _values;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_ExpectedType || incompletePart == CompletionParts.FinishComputingProperty_ExpectedType)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_ExpectedType))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _expectedType = CompleteProperty_ExpectedType(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_ExpectedType);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_Value || incompletePart == CompletionParts.FinishComputingProperty_Value)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Value))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var result = CompleteProperty_Value(diagnostics, cancellationToken);
                    _value = result.Value;
                    _values = result.Values;
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

        protected virtual MetaType CompleteProperty_ExpectedType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var alt = this.ContainingPAlternativeSymbol;
            if (alt is not null)
            {
                return alt.ExpectedType;
            }
            var arg = this.ContainingAnnotationArgumentSymbol;
            if (arg is not null)
            {
                return arg.ParameterType;
            }
            return default;
        }

        protected virtual (MetaSymbol Value, ImmutableArray<MetaSymbol> Values) CompleteProperty_Value(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (this.ModelObjectType == typeof(ArrayExpression))
            {
                var results = ArrayBuilder<MetaSymbol>.GetInstance();
                foreach (var exprSymbol in this.ContainedSymbols.OfType<ExpressionSymbol>())
                {
                    foreach (var value in exprSymbol.Values)
                    {
                        results.Add(value);
                    }
                }
                var values = results.ToImmutableAndFree();
                return (values.FirstOrDefault(), values);
            }
            else
            {
                var values = SymbolFactory.GetSymbolPropertyValues<MetaSymbol>(this, nameof(Value), diagnostics, cancellationToken);
                return (values.FirstOrDefault(), values);
            }
        }

        protected override void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            base.CompletePart_Validate(diagnostics, cancellationToken);
            if (!this.Value.IsNull)
            {
                var valueType = this.Value.Type;
                if (!valueType.IsDefaultOrNull)
                {
                    var expectedType = this.ExpectedType;
                    if (expectedType.TryGetCoreType(out var coreType, diagnostics, cancellationToken))
                    {
                        if (!valueType.IsAssignableTo(coreType))
                        {
                            if (coreType.SpecialType == SpecialType.MetaDslx_Modeling_ModelProperty && valueType.IsAssignableTo(typeof(DeclarationSymbol)))
                            {
                                // nop
                            }
                            else
                            {
                                diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_IncompatibleExpressionType, this.Location, this.DeclaringSyntaxReference, valueType, coreType));
                            }
                        }
                    }
                }
                else
                {
                    diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, this.Location, $"Could not determine the type of the value '{this.DeclaringSyntaxReference}'"));
                }
            }
        }
    }
}
