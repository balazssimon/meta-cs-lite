using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaDslx.CodeAnalysis.Symbols.Source;
using System.Collections.Immutable;
using MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Languages.MetaModel.Compiler.Syntax;
using MetaDslx.Bootstrap.MetaCompiler.Model;
using System.ComponentModel;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;

    internal class PElementSymbol : SourceDeclaredSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_SymbolProperty = new CompletionPart(nameof(StartComputingProperty_SymbolProperty));
            public static readonly CompletionPart FinishComputingProperty_SymbolProperty = new CompletionPart(nameof(FinishComputingProperty_SymbolProperty));
            public static readonly CompletionPart StartComputingProperty_ExpectedTypes = new CompletionPart(nameof(StartComputingProperty_ExpectedTypes));
            public static readonly CompletionPart FinishComputingProperty_ExpectedTypes = new CompletionPart(nameof(FinishComputingProperty_ExpectedTypes));
            public static readonly CompletionPart StartComputingProperty_Value = new CompletionPart(nameof(StartComputingProperty_Value));
            public static readonly CompletionPart FinishComputingProperty_Value = new CompletionPart(nameof(FinishComputingProperty_Value));
            public static readonly CompletionPart StartComputingProperty_Members = DeclaredSymbol.CompletionParts.StartComputingProperty_Members;
            public static readonly CompletionPart FinishComputingProperty_Members = DeclaredSymbol.CompletionParts.FinishComputingProperty_Members;
            public static readonly CompletionPart StartComputingProperty_TypeArguments = DeclaredSymbol.CompletionParts.StartComputingProperty_TypeArguments;
            public static readonly CompletionPart FinishComputingProperty_TypeArguments = DeclaredSymbol.CompletionParts.FinishComputingProperty_TypeArguments;
            public static readonly CompletionPart StartComputingProperty_Imports = DeclaredSymbol.CompletionParts.StartComputingProperty_Imports;
            public static readonly CompletionPart FinishComputingProperty_Imports = DeclaredSymbol.CompletionParts.FinishComputingProperty_Imports;
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_Value, FinishComputingProperty_Value,
                    StartComputingProperty_SymbolProperty, FinishComputingProperty_SymbolProperty,
                    StartComputingProperty_ExpectedTypes, FinishComputingProperty_ExpectedTypes,
                    StartComputingProperty_Members, FinishComputingProperty_Members,
                    StartComputingProperty_TypeArguments, FinishComputingProperty_TypeArguments,
                    StartComputingProperty_Imports, FinishComputingProperty_Imports,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private enum ExpectedTypeKind
        {
            None,
            Bool,
            Collection
        }

        private ImmutableArray<MetaSymbol> _symbolProperty;
        private ImmutableArray<MetaType> _expectedTypes;
        private ExpectedTypeKind _expectedTypeKind;
        private MetaSymbol _value;

        public PElementSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public PElementSyntax? Syntax => this.DeclaringSyntaxReference.AsNode() as PElementSyntax;

        public bool IsNamedElement => Syntax?.PElementBlock1 is not null;

        public GrammarSymbol? ContainingGrammarSymbol => this.GetOutermostContainingSymbol<GrammarSymbol>();

        public PAlternativeSymbol? ContainingPAlternativeSymbol => this.ContainingSymbol as PAlternativeSymbol;

        [ModelProperty]
        public MetaSymbol Value
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Value, null, default);
                return _value;
            }
        }

        [ModelProperty]
        public ImmutableArray<MetaSymbol> SymbolProperty
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_SymbolProperty, null, default);
                return _symbolProperty;
            }
        }

        public ImmutableArray<MetaType> ExpectedTypes
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ExpectedTypes, null, default);
                return _expectedTypes;
            }
        }

        private ExpectedTypeKind ExpectedKind
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ExpectedTypes, null, default);
                return _expectedTypeKind;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_Value || incompletePart == CompletionParts.FinishComputingProperty_Value)
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
            else if (incompletePart == CompletionParts.StartComputingProperty_SymbolProperty || incompletePart == CompletionParts.FinishComputingProperty_SymbolProperty)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_SymbolProperty))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _symbolProperty = CompleteProperty_SymbolProperty(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_SymbolProperty);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_ExpectedTypes || incompletePart == CompletionParts.FinishComputingProperty_ExpectedTypes)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_ExpectedTypes))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var expectedTypes = CompleteProperty_ExpectedTypes(diagnostics, cancellationToken);
                    _expectedTypes = expectedTypes.ExpectedTypes;
                    _expectedTypeKind = expectedTypes.ExpectedTypeKind;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_ExpectedTypes);
                }
                return true;
            }
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var nameSyntax = this.Syntax?.PElementBlock1?.SymbolProperty;
            return Declaration.Language.SyntaxFacts.ExtractName(nameSyntax);
        }

        protected virtual ImmutableArray<MetaSymbol> CompleteProperty_SymbolProperty(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<MetaSymbol>(this, nameof(SymbolProperty), diagnostics, cancellationToken);
        }

        private (ImmutableArray<MetaType> ExpectedTypes, ExpectedTypeKind ExpectedTypeKind) CompleteProperty_ExpectedTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (this.IsNamedElement)
            {
                var kind = ExpectedTypeKind.None;
                var result = ArrayBuilder<MetaType>.GetInstance();
                foreach (var prop in SymbolProperty)
                {
                    var csProp = prop.OriginalSymbol as ICSharpSymbol;
                    var msProp = csProp?.CSharpSymbol as IPropertySymbol;
                    var msType = msProp?.Type;
                    var csType = msType is null ? null : csProp?.SymbolFactory.GetSymbol<TypeSymbol>(msType, diagnostics, cancellationToken);
                    var mtType = MetaType.FromTypeSymbol(csType);
                    if (mtType.IsNullable) mtType.TryExtractNullableType(out mtType, diagnostics, cancellationToken);
                    if (mtType.IsCollection) kind = ExpectedTypeKind.Collection;
                    else if (mtType.SpecialType == SpecialType.System_Boolean) kind = ExpectedTypeKind.Bool;
                    if (mtType.TryGetCoreType(out var coreType, diagnostics, cancellationToken) && !coreType.IsNull)
                    {
                        if (!result.Contains(mtType)) result.Add(mtType);
                    }
                    else
                    {
                        diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, this.Location, $"Could not determine the type of the property '{prop.Name}'"));
                    }
                }
                return (result.ToImmutableAndFree(), kind);
            }
            else
            {
                var alt = this.ContainingPAlternativeSymbol;
                if (alt is not null && alt.Elements.Length == 1)
                {
                    return (alt.ExpectedTypes, ExpectedTypeKind.None);
                }
            }
            return (ImmutableArray<MetaType>.Empty, ExpectedTypeKind.None);
        }

        protected virtual MetaSymbol CompleteProperty_Value(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<MetaSymbol>(this, nameof(Value), diagnostics, cancellationToken);
        }

        protected override void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            base.CompletePart_Validate(diagnostics, cancellationToken);
            var mobj = this.ModelObject as PElement;
            if (mobj is not null)
            {
                if (ExpectedKind == ExpectedTypeKind.Collection && mobj.Assignment != Assignment.PlusAssign)
                {
                    diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_CollectionPropertyWrongAssignment, this.Location, this.Name));
                }
                else if (ExpectedKind != ExpectedTypeKind.Collection && mobj.Assignment == Assignment.PlusAssign)
                {
                    diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_NonCollectionPropertyWrongAssignment, this.Location, this.Name));
                }
                else if (mobj.Assignment == Assignment.QuestionAssign && ExpectedKind != ExpectedTypeKind.Bool)
                {
                    diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_NonBooleanPropertyWrongAssignment, this.Location, this.Name, "?="));
                }
                else if (mobj.Assignment == Assignment.NegatedAssign && ExpectedKind != ExpectedTypeKind.Bool)
                {
                    diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_NonBooleanPropertyWrongAssignment, this.Location, this.Name, "!="));
                }
            }
            var value = this.Value.AsModelObject();
            if (value is PReference pref)
            {
                var mustHaveExpectedTypes = this.IsNamedElement;
                if (!mustHaveExpectedTypes)
                {
                    var alt = this.ContainingPAlternativeSymbol;
                    if (alt is not null && alt.Elements.Length == 1)
                    {
                        mustHaveExpectedTypes = true;
                    }
                }
                if (mustHaveExpectedTypes && this.ExpectedTypes.IsDefaultOrEmpty)
                {
                    diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, this.Location, $"There are no expected types for the element '{this.Name}'"));
                }
                foreach (var expType in this.ExpectedTypes)
                {
                    if (expType.TryGetCoreType(out var coreType, diagnostics, cancellationToken))
                    {
                        if (pref.ReferencedTypes.Count == 0)
                        {
                            var rule = pref.Rule;
                            if (rule is ParserRule pr)
                            {
                                if (!pr.ReturnType.IsAssignableTo(coreType))
                                {
                                    var trace = string.Join(", ", ResolveExpectedTypeTrace(coreType));
                                    diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_ValueTypeMismatch, this.Location, pr.ReturnType, coreType, trace));
                                }
                            }
                            else if (rule is LexerRule lr)
                            {
                                if (!lr.ReturnType.IsAssignableTo(coreType))
                                {
                                    var trace = string.Join(", ", ResolveExpectedTypeTrace(coreType));
                                    diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_ValueTypeMismatch, this.Location, lr.ReturnType, coreType, trace));
                                }
                            }
                        }
                        else
                        {
                            foreach (var prefType in pref.ReferencedTypes)
                            {
                                if (!prefType.IsAssignableTo(coreType))
                                {
                                    var trace = string.Join(", ", ResolveExpectedTypeTrace(coreType));
                                    diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_ValueTypeMismatch, this.Location, prefType, coreType, trace));
                                }
                            }
                        }
                    }
                    else
                    {
                        diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, this.Location, $"Could not determine the core type of {expType} in element '{this.Name}'"));
                    }
                }
            }
        }

        private ImmutableArray<string> ResolveExpectedTypeTrace(MetaType expectedType)
        {
            var alt = this.ContainingPAlternativeSymbol;
            var rule = alt.GetOutermostContainingSymbol<PBlockSymbol>();
            var grammar = alt.GetOutermostContainingSymbol<GrammarSymbol>();
            if (grammar is null || rule is null) return ImmutableArray<string>.Empty;
            var result = ArrayBuilder<string>.GetInstance();
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            var visited = PooledHashSet<DeclaredSymbol>.GetInstance();
            var stack = ArrayBuilder<DeclaredSymbol>.GetInstance();
            stack.Add(rule);
            visited.Add(rule);
            while (stack.Count > 0)
            {
                var currentRule = stack[stack.Count - 1];
                if (currentRule is PBlockSymbol currentBlock)
                {
                    bool added = false;
                    var refElems = grammar.BlockReferences[currentBlock];
                    foreach (var refElem in refElems)
                    {
                        var refAlt = refElem.ContainingPAlternativeSymbol;
                        var refRule = refElem.GetOutermostContainingSymbol<ParserRuleSymbol>();
                        if (refRule is not null)
                        {
                            if (refAlt.ExpectedTypes.Contains(expectedType))
                            {
                                sb.Clear();
                                sb.Append(refRule.Name);
                                for (int i = stack.Count - 1; i >= 0; --i)
                                {
                                    sb.Append("/");
                                    sb.Append(stack[i].Name);
                                }
                                var trace = sb.ToString();
                                if (!result.Contains(trace)) result.Add(trace);
                            }
                        }
                        else
                        {
                            var refBlock = refElem.GetOutermostContainingSymbol<PBlockSymbol>();
                            if (refBlock is not null && !visited.Contains(refBlock))
                            {
                                visited.Add(refBlock);
                                stack.Add(refBlock);
                                added = true;
                                break;
                            }
                        }
                    }
                    if (!added) stack.RemoveAt(stack.Count - 1);
                }
            }
            stack.Free();
            visited.Free();
            builder.Free();
            return result.ToImmutableAndFree();
        }

    }
}
