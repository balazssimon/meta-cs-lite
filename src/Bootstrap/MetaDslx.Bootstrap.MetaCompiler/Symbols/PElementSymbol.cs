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
using Roslyn.Utilities;
using MetaDslx.CodeAnalysis.Binding;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;

    internal class PElementSymbol : SourceDeclarationSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_Value = new CompletionPart(nameof(StartComputingProperty_Value));
            public static readonly CompletionPart FinishComputingProperty_Value = new CompletionPart(nameof(FinishComputingProperty_Value));
            public static readonly CompletionPart StartComputingProperty_Assignment = new CompletionPart(nameof(StartComputingProperty_Assignment));
            public static readonly CompletionPart FinishComputingProperty_Assignment = new CompletionPart(nameof(FinishComputingProperty_Assignment));
            public static readonly CompletionPart StartComputingProperty_ExpectedType = new CompletionPart(nameof(StartComputingProperty_ExpectedType));
            public static readonly CompletionPart FinishComputingProperty_ExpectedType = new CompletionPart(nameof(FinishComputingProperty_ExpectedType));
            public static readonly CompletionPart StartComputingProperty_Members = DeclarationSymbol.CompletionParts.StartComputingProperty_Members;
            public static readonly CompletionPart FinishComputingProperty_Members = DeclarationSymbol.CompletionParts.FinishComputingProperty_Members;
            public static readonly CompletionPart StartComputingProperty_TypeArguments = DeclarationSymbol.CompletionParts.StartComputingProperty_TypeArguments;
            public static readonly CompletionPart FinishComputingProperty_TypeArguments = DeclarationSymbol.CompletionParts.FinishComputingProperty_TypeArguments;
            public static readonly CompletionPart StartComputingProperty_Imports = DeclarationSymbol.CompletionParts.StartComputingProperty_Imports;
            public static readonly CompletionPart FinishComputingProperty_Imports = DeclarationSymbol.CompletionParts.FinishComputingProperty_Imports;
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_Value, FinishComputingProperty_Value,
                    StartComputingProperty_Assignment, FinishComputingProperty_Assignment,
                    StartComputingProperty_ExpectedType, FinishComputingProperty_ExpectedType,
                    StartComputingProperty_Members, FinishComputingProperty_Members,
                    StartComputingProperty_TypeArguments, FinishComputingProperty_TypeArguments,
                    StartComputingProperty_Imports, FinishComputingProperty_Imports,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private enum ExpectedTypeKind
        {
            None,
            Simple,
            Bool,
            Collection
        }

        private MetaSymbol _value;
        private Assignment _assignment;
        private MetaType _expectedType;
        private ExpectedTypeKind _expectedTypeKind;

        public PElementSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public ElementSyntax? Syntax => this.DeclaringSyntaxReference.AsNode() as ElementSyntax;

        public bool IsNamedElement => Syntax?.Block is not null;

        public bool IsBlock => Value.OriginalSymbol is PBlockSymbol;

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
        public Assignment Assignment
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Assignment, null, default);
                return _assignment;
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

        private ExpectedTypeKind ExpectedKind
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ExpectedType, null, default);
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
            else if (incompletePart == CompletionParts.StartComputingProperty_Assignment || incompletePart == CompletionParts.FinishComputingProperty_Assignment)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Assignment))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _assignment = CompleteProperty_Assignment(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Assignment);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_ExpectedType || incompletePart == CompletionParts.FinishComputingProperty_ExpectedType)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_ExpectedType))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var expectedType = CompleteProperty_ExpectedType(diagnostics, cancellationToken);
                    _expectedType = expectedType.ExpectedType;
                    _expectedTypeKind = expectedType.ExpectedTypeKind;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_ExpectedType);
                }
                return true;
            }
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected virtual MetaSymbol CompleteProperty_Value(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<MetaSymbol>(this, nameof(Value), diagnostics, cancellationToken);
        }

        protected virtual Assignment CompleteProperty_Assignment(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<Assignment>(this, nameof(Assignment), diagnostics, cancellationToken);
        }

        private (MetaType ExpectedType, ExpectedTypeKind ExpectedTypeKind) CompleteProperty_ExpectedType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (this.DeclaringCompilation is null) return default;
            var qualifierOpt = this.GetOutermostContainingSymbol<PAlternativeSymbol>()?.ReturnType;
            if (!qualifierOpt.HasValue) return default;
            var qualifier = qualifierOpt.Value;
            if (qualifier.IsNull) return default;
            var nameBlock = this.Syntax?.Block;
            if (nameBlock is null) return default;
            var nameSyntax = nameBlock.Name;
            if (nameSyntax is null) return default;
            MetaType result = default;
            if (qualifier.IsName)
            {
                diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_DottedNameNotFoundInAgg, Location, Name, qualifier));
                return default;
            }
            else if (qualifier.IsType)
            {
                var qualifierType = qualifier.OriginalType!;
                var prop = qualifierType.GetProperty(Name, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.IgnoreCase);
                if (prop is null)
                {
                    diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_DottedNameNotFoundInAgg, Location, Name, qualifier));
                    return default;
                }
                result = MetaType.FromType(prop.PropertyType);
            }
            else if (qualifier.IsTypeSymbol)
            {
                var nameBinder = this.DeclaringCompilation.GetBinder(nameSyntax);
                var ctx = nameBinder.AllocateLookupContext(name: Name, qualifier: qualifier.OriginalTypeSymbol, diagnose: true, isLookup: true, isCaseSensitive: false);
                var prop = nameBinder.BindDeclarationSymbol(ctx, nameSyntax);
                diagnostics.AddRange(ctx.Diagnostics);
                ctx.Free();
                if (prop is null) return default;
                var csProp = prop as ICSharpSymbol;
                var msProp = csProp?.CSharpSymbol as IPropertySymbol;
                var msType = msProp?.Type;
                var csType = msType is null ? null : csProp?.SymbolFactory.GetSymbol<TypeSymbol>(msType, diagnostics, cancellationToken);
                result = MetaType.FromTypeSymbol(csType);
            }
            var kind = ExpectedTypeKind.None;
            if (result.IsNullable) result.TryExtractNullableType(out result, diagnostics, cancellationToken);
            if (result.IsCollection) kind = ExpectedTypeKind.Collection;
            else if (result.SpecialType == SpecialType.System_Boolean) kind = ExpectedTypeKind.Bool;
            else if (!result.IsNull) kind = ExpectedTypeKind.Simple;
            if (result.TryGetCoreType(out var coreType, diagnostics, cancellationToken) && !coreType.IsNull)
            {
                result = coreType;
            }
            else
            {
                diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, this.Location, $"Could not determine the type of the property '{Name}' in type '{qualifier}'"));
                return default;
            }
            return (result, kind);
        }

        protected override void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            base.CompletePart_Validate(diagnostics, cancellationToken);
            if (this.Assignment != Assignment.PlusAssign && ExpectedKind == ExpectedTypeKind.Collection)
            {
                diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_CollectionPropertyWrongAssignment, this.Location, this.Name));
            }
            else if (this.Assignment == Assignment.PlusAssign && ExpectedKind != ExpectedTypeKind.None && ExpectedKind != ExpectedTypeKind.Collection)
            {
                diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_NonCollectionPropertyWrongAssignment, this.Location, this.Name));
            }
            else if (this.Assignment == Assignment.QuestionAssign && ExpectedKind != ExpectedTypeKind.None && ExpectedKind != ExpectedTypeKind.Bool)
            {
                diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_NonBooleanPropertyWrongAssignment, this.Location, this.Name, "?="));
            }
            else if (this.Assignment == Assignment.NegatedAssign && ExpectedKind != ExpectedTypeKind.None && ExpectedKind != ExpectedTypeKind.Bool)
            {
                diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_NonBooleanPropertyWrongAssignment, this.Location, this.Name, "!="));
            }
            if (Value.IsNull) return;
            var alt = this.ContainingPAlternativeSymbol;
            if (alt is null) return;
            if (IsNamedElement)
            {
                var expType = this.ExpectedType;
                if (!expType.IsNull)
                {
                    if (expType.TryGetCoreType(out var coreType, diagnostics, cancellationToken))
                    {
                        if (coreType.SpecialType != SpecialType.MetaDslx_CodeAnalysis_MetaSymbol)
                        {
                            var pref = Value.OriginalSymbol as PReferenceSymbol;
                            if (pref != null)
                            {
                                if (pref.ReferencedTypes.Length == 0)
                                {
                                    var prefRule = pref.Rule;
                                    if (prefRule.OriginalSymbol is ParserRuleSymbol pr)
                                    {
                                        if (!pr.ReturnType.IsAssignableTo(coreType))
                                        {
                                            diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_ValueTypeMismatch, this.Location, pr.ReturnType, coreType));
                                        }
                                    }
                                    else if (prefRule.OriginalSymbol is TokenSymbol lr)
                                    {
                                        if (!lr.ReturnType.IsAssignableTo(coreType))
                                        {
                                            diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_ValueTypeMismatch, this.Location, lr.ReturnType, coreType));
                                        }
                                    }
                                }
                                else
                                {
                                    foreach (var prefType in pref.ReferencedTypes)
                                    {
                                        if (!prefType.IsAssignableTo(coreType))
                                        {
                                            diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_ValueTypeMismatch, this.Location, prefType, coreType));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (Value.OriginalSymbol is ParserRuleSymbol pr && alt.Elements.Length != 1)
                {
                    diagnostics.Add(Diagnostic.Create(CompilerErrorCode.WRN_RuleWithTypeMissingAssignment, this.Location, pr.Name, pr.ReturnType));
                }
            }
        }

        public override string ToString()
        {
            var elemName = this.Name;
            if (this.Value.OriginalSymbol is PReferenceSymbol pref)
            {
                if (string.IsNullOrEmpty(elemName)) elemName = pref.Name;
            }
            var alt = this.ContainingPAlternativeSymbol;
            var block = alt?.ContainingPBlockSymbol;
            while (block is not null && string.IsNullOrEmpty(block.Name))
            {
                var blockElem = block?.ContainingElementSymbol;
                if (!string.IsNullOrEmpty(blockElem?.Name)) break;
                alt = blockElem?.ContainingPAlternativeSymbol;
                var next = alt?.ContainingPBlockSymbol;
                if (next is null)
                {
                    break;
                }
                else
                {
                    block = next;
                }
            }
            if (block is not null && !string.IsNullOrEmpty(block.Name))
            {
                if (!string.IsNullOrEmpty(elemName)) return $"{block.Name}.{elemName}";
                else return block.Name;
            }
            var rule = alt?.ContainingParserRuleSymbol;
            if (rule is not null)
            {
                if (!string.IsNullOrEmpty(elemName)) return $"{rule.Name}.{elemName}";
                else return rule.Name;
            }
            return elemName;
        }
    }
}
