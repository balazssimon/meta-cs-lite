using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Languages.MetaCompiler.Compiler.Syntax;
using MetaDslx.Languages.MetaCompiler.Model;
using Roslyn.Utilities;

namespace MetaDslx.Languages.MetaCompiler.Symbols.Implementation
{
    using __Model = MetaDslx.Modeling.Model;
    using __IModelObject = MetaDslx.Modeling.IModelObject;
    using __ISymbol = Microsoft.CodeAnalysis.ISymbol;
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;
    using MetaProperty = MetaDslx.Languages.MetaModel.Model.MetaProperty;

    public class PElementSymbolImpl : PElementSymbol
    {
        public PElementSymbolImpl(Symbol? container, Compilation? compilation, MergedDeclaration? declaration, __IModelObject? modelObject, __ISymbol? csharpSymbol, ErrorSymbolInfo? errorInfo)
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
        }
        
        public ElementSyntax? Syntax => this.DeclaringSyntaxReference.AsNode() as ElementSyntax;

        protected override PAlternativeSymbol? Compute_ContainingPAlternativeSymbol(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.ContainingSymbol as PAlternativeSymbol;
        }

        protected override (MetaType ExpectedType, ExpectedTypeKind ExpectedKind) Compute_ExpectedType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (this.DeclaringCompilation is null) return default;
            var qualifierOpt = this.GetOutermostContainingSymbol<PAlternativeSymbol>()?.ReturnType;
            if (!qualifierOpt.HasValue) return default;
            var qualifier = qualifierOpt.Value;
            if (qualifier.IsDefaultOrNull) return default;
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
                var prop = qualifierType.GetAllProperties(Name, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.IgnoreCase);
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
                if (prop.IsCSharpSymbol)
                {
                    var msProp = prop.CSharpSymbol as IPropertySymbol;
                    var msType = msProp?.Type;
                    var csType = msType is null ? null : prop.ContainingModule.SymbolFactory.GetSymbol<TypeSymbol>(msType, diagnostics, cancellationToken);
                    result = MetaType.FromTypeSymbol(csType);
                }
                else if (prop.ModelObject is MetaProperty mProp)
                {
                    result = mProp.Type;
                }
            }
            var kind = ExpectedTypeKind.None;
            if (result.IsNullable) result.TryExtractNullableType(out result, diagnostics, cancellationToken);
            if (result.IsCollection) kind = ExpectedTypeKind.Collection;
            else if (result.SpecialType == SpecialType.System_Boolean) kind = ExpectedTypeKind.Bool;
            else if (!result.IsDefaultOrNull) kind = ExpectedTypeKind.Simple;
            if (result.TryGetCoreType(out var coreType, diagnostics, cancellationToken) && !coreType.IsDefaultOrNull)
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

        protected override bool Compute_IsNamedElement(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return Syntax?.Block is not null;
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
                if (!expType.IsDefaultOrNull)
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
                                        // TODO:MetaDslx
                                        // Replace non-void check with smarter type inference for Binder return types
                                        if (!pr.ReturnType.IsAssignableTo(coreType) && pr.ReturnType.SpecialType != SpecialType.System_Void)
                                        {
                                            diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_ValueTypeMismatch, pref.Location, pr.ReturnType, coreType));
                                        }
                                    }
                                    else if (prefRule.OriginalSymbol is TokenSymbol lr)
                                    {
                                        // TODO:MetaDslx
                                        // Replace non-void check with smarter type inference for Binder return types
                                        if (!lr.ReturnType.IsAssignableTo(coreType) && lr.ReturnType.SpecialType != SpecialType.System_Void)
                                        {
                                            diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_ValueTypeMismatch, pref.Location, lr.ReturnType, coreType));
                                        }
                                    }
                                }
                                else
                                {
                                    foreach (var prefType in pref.ReferencedTypes)
                                    {
                                        if (!prefType.IsAssignableTo(coreType))
                                        {
                                            diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_ValueTypeMismatch, pref.Location, prefType, coreType));
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
                if (Value.OriginalSymbol is PReferenceSymbol pref && alt.Elements.Length != 1)
                {
                    var prefRule = pref.Rule;
                    if (pref.ReferencedTypes.Length == 0)
                    {
                        if (prefRule.OriginalSymbol is ParserRuleSymbol pr)
                        {
                            // TODO:MetaDslx
                            // Replace non-void check with smarter type inference for Binder return types
                            if (!pr.ReturnType.IsDefaultOrNull && pr.ReturnType.SpecialType != SpecialType.System_Void)
                            {
                                diagnostics.Add(Diagnostic.Create(CompilerErrorCode.WRN_RuleWithTypeMissingAssignment, pref.Location, pr.Name, pr.ReturnType));
                            }
                        }
                        else if (prefRule.OriginalSymbol is TokenSymbol lr)
                        {
                            // TODO:MetaDslx
                            // Replace non-void check with smarter type inference for Binder return types
                            if (!lr.ReturnType.IsDefaultOrNull && lr.ReturnType.SpecialType != SpecialType.System_Void)
                            {
                                diagnostics.Add(Diagnostic.Create(CompilerErrorCode.WRN_RuleWithTypeMissingAssignment, pref.Location, lr.Name, lr.ReturnType));
                            }
                        }
                    }
                    else
                    {
                        diagnostics.Add(Diagnostic.Create(CompilerErrorCode.WRN_RuleWithTypeMissingAssignment, pref.Location, prefRule.Name, string.Join(", ", pref.ReferencedTypes)));
                    }
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
