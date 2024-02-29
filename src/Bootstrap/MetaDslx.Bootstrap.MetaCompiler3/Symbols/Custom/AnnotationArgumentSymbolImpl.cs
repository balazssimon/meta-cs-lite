using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Bootstrap.MetaCompiler3.Compiler.Syntax;

namespace MetaDslx.Bootstrap.MetaCompiler3.Symbols.Impl
{
    using __Model = MetaDslx.Modeling.Model;
    using __IModelObject = MetaDslx.Modeling.IModelObject;
    using __ISymbol = Microsoft.CodeAnalysis.ISymbol;
    using IParameterSymbol = Microsoft.CodeAnalysis.IParameterSymbol;

    public class AnnotationArgumentSymbolImpl : AnnotationArgumentSymbol
    {
        public AnnotationArgumentSymbolImpl(Symbol? container, Compilation? compilation = null, MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, ErrorSymbolInfo? errorInfo = null) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo)
        {
        }
        
        public AnnotationArgumentSyntax? Syntax => this.DeclaringSyntaxReference.AsNode() as AnnotationArgumentSyntax;

        protected override AnnotationSymbol? Compute_AnnotationSymbol(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return (AnnotationSymbol)this.ContainingSymbol;
        }

        protected override bool Compute_IsNamedArgument(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return Syntax?.Block is not null;
        }

        protected override (DeclarationSymbol Parameter, MetaType ParameterType) Compute_Parameter(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var index = AnnotationSymbol?.Arguments.IndexOf(this) ?? -1;
            if (index < 0) return default;
            var param = AnnotationSymbol?.SelectedParameters[index];
            if (param is null)
            {
                diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, this.Location, "Could not resolve the parameter corresponding to this argument"));
                return default;
            }
            var slot = ModelObject.MGetSlot(MetaDslx.Bootstrap.MetaCompiler3.Model.Compiler.AnnotationArgument_Parameter);
            slot?.Add(param);
            var msProp = param.CSharpSymbol as IParameterSymbol;
            var msType = msProp?.Type;
            var csType = msType is null ? null : param.ContainingModule?.SymbolFactory.GetSymbol<TypeSymbol>(msType, diagnostics, cancellationToken);
            var mtType = MetaType.FromTypeSymbol(csType);
            if (mtType.IsNullable) mtType.TryExtractNullableType(out mtType, diagnostics, cancellationToken);
            if (mtType.TryGetCoreType(out var coreType, diagnostics, cancellationToken) && !coreType.IsDefaultOrNull)
            {
                var typeSlot = ModelObject.MGetSlot(MetaDslx.Bootstrap.MetaCompiler3.Model.Compiler.AnnotationArgument_ParameterType);
                typeSlot?.Add(mtType);
            }
            else
            {
                diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, this.Location, $"Could not determine the type of the parameter '{Syntax?.Block?.NamedParameter}'"));
                return default;
            }
            return (param, mtType);

        }
    }
}
