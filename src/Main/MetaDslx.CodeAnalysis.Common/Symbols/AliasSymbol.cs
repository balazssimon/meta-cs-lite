using MetaDslx.CodeAnalysis.Binding;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    /// <summary>
    /// Symbol representing a using alias appearing in a compilation unit or within a namespace
    /// declaration. Generally speaking, these symbols do not appear in the set of symbols reachable
    /// from the unnamed namespace declaration.  In other words, when a using alias is used in a
    /// program, it acts as a transparent alias, and the symbol to which it is an alias is used in
    /// the symbol table.  For example, in the source code
    /// <pre>
    /// namespace NS
    /// {
    ///     using o = System.Object;
    ///     partial class C : o {}
    ///     partial class C : object {}
    ///     partial class C : System.Object {}
    /// }
    /// </pre>
    /// all three declarations for class C are equivalent and result in the same symbol table object
    /// for C. However, these using alias symbols do appear in the results of certain SemanticModel
    /// APIs. Specifically, for the base clause of the first of C's class declarations, the
    /// following APIs may produce a result that contains an AliasSymbol:
    /// <pre>
    ///     SemanticInfo SemanticModel.GetSemanticInfo(ExpressionSyntax expression);
    ///     SemanticInfo SemanticModel.BindExpression(CSharpSyntaxNode location, ExpressionSyntax expression);
    ///     SemanticInfo SemanticModel.BindType(CSharpSyntaxNode location, ExpressionSyntax type);
    ///     SemanticInfo SemanticModel.BindNamespaceOrType(CSharpSyntaxNode location, ExpressionSyntax type);
    /// </pre>
    /// Also, the following are affected if container==null (and, for the latter, when arity==null
    /// or arity==0):
    /// <pre>
    ///     IList&lt;string&gt; SemanticModel.LookupNames(CSharpSyntaxNode location, NamespaceOrTypeSymbol container = null, LookupOptions options = LookupOptions.Default, List&lt;string> result = null);
    ///     IList&lt;Symbol&gt; SemanticModel.LookupSymbols(CSharpSyntaxNode location, NamespaceOrTypeSymbol container = null, string name = null, int? arity = null, LookupOptions options = LookupOptions.Default, List&lt;Symbol> results = null);
    /// </pre>
    /// </summary>
    public sealed class AliasSymbol : Symbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_Name = new CompletionPart(nameof(StartComputingProperty_Name));
            public static readonly CompletionPart FinishComputingProperty_Name = new CompletionPart(nameof(FinishComputingProperty_Name));
            public static readonly CompletionPart StartComputingProperty_Target = new CompletionPart(nameof(StartComputingProperty_Target));
            public static readonly CompletionPart FinishComputingProperty_Target = new CompletionPart(nameof(FinishComputingProperty_Target));
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    CompletionGraph.StartInitializing, CompletionGraph.FinishInitializing,
                    CompletionGraph.StartCreatingContainedSymbols, CompletionGraph.FinishCreatingContainedSymbols,
                    StartComputingProperty_Name, FinishComputingProperty_Name,
                    StartComputingProperty_Target, FinishComputingProperty_Target,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes,
                    CompletionGraph.StartComputingNonSymbolProperties, CompletionGraph.FinishComputingNonSymbolProperties,
                    CompletionGraph.ContainedSymbolsCompleted,
                    CompletionGraph.StartValidatingSymbol, CompletionGraph.FinishValidatingSymbol);
        }

        private string _name;
        private Symbol _target;

        private AliasSymbol(Symbol container) 
            : base(container)
        {
        }

        private AliasSymbol(Symbol container, string name, Symbol target)
            : base(container)
        {
            _name = name;
            _target = target;
        }

        public override ImmutableArray<Location> Locations => throw new NotImplementedException();

        public Symbol GetAliasTarget(LookupContext context)
        {
            ForceComplete(CompletionParts.FinishComputingProperty_Target, null, context.CancellationToken);
            return _target;
        }

        public static Symbol UnwrapAlias(LookupContext context, Symbol symbol)
        {
            if (symbol is AliasSymbol aliasSymbol) return aliasSymbol.GetAliasTarget(context);
            else return symbol;
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_Target || incompletePart == CompletionParts.FinishComputingProperty_Target)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Target))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var target = CompleteProperty_Target(diagnostics, cancellationToken);
                    _target = target;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Target);
                }
                return true;
            }
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected override string CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _name;
        }

        private Symbol CompleteProperty_Target(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _target;
        }

    }
}
