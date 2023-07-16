using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Completion
{
    public abstract partial class CompletionNamespaceSymbol : NamespaceSymbol
    {
        private readonly Symbol _container;
        private readonly object? _modelObject;
        private readonly CompletionState _state;
        private ImmutableArray<Symbol> _containedSymbols;
        private string _name;
        private string _metadataName;
        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol> _attributes;
        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeParameterSymbol> _typeParameters;
        private Accessibility _declaredAccessibility;
        private bool _isExtern;
        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol> _members;

        public CompletionNamespaceSymbol(Symbol container, object? modelObject = null, bool isError = false)
        {
            _container = container;
            _modelObject = modelObject;
            _state = CompletionParts.CompletionGraph.CreateState();
        }

        public override NamespaceExtent Extent
        {
            get
            {
                if (_container is CompletionNamespaceSymbol containingNamespace) return containingNamespace.Extent;
                if (_container is ModuleSymbol containingModule) return new NamespaceExtent(containingModule);
                return new NamespaceExtent(_container.ContainingModule);
            }
        }

        public override Symbol ContainingSymbol => _container;

        public override ImmutableArray<Symbol> ContainedSymbols
        {
            get
            {
                this.ForceComplete(CompletionGraph.FinishCreatingChildren, null, default);
                return _containedSymbols;
            }
        }

        public override string Name
        {
            get
            {
                this.ForceComplete(CompletionGraph.FinishInitializing, null, default);
                return _name;
            }
        }

        public override string MetadataName
        {
            get
            {
                this.ForceComplete(CompletionGraph.FinishInitializing, null, default);
                return _metadataName;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol> Attributes
        {
            get
            {
                this.ForceComplete(CompletionParts.FinishComputingProperty_Attributes, null, default);
                return _attributes;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeParameterSymbol> TypeParameters
        {
            get
            {
                this.ForceComplete(CompletionParts.FinishComputingProperty_TypeParameters, null, default);
                return _typeParameters;
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                this.ForceComplete(CompletionParts.FinishComputingProperty_DeclaredAccessibility, null, default);
                return _declaredAccessibility;
            }
        }

        public override bool IsExtern
        {
            get
            {
                this.ForceComplete(CompletionParts.FinishComputingProperty_IsExtern, null, default);
                return _isExtern;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol> Members
        {
            get
            {
                this.ForceComplete(CompletionParts.FinishComputingProperty_Members, null, default);
                return _members;
            }
        }

        #region Completion

        public sealed override bool RequiresCompletion => true;

        public sealed override bool HasComplete(CompletionPart part)
        {
            return _state.HasComplete(part);
        }

        public override void ForceComplete(CompletionPart completionPart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (completionPart != null && _state.HasComplete(completionPart)) return;
            if (completionPart != null && !CompletionParts.All.Contains(completionPart)) throw new ArgumentException(nameof(completionPart));
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var incompletePart = _state.NextIncompletePart;
                if (incompletePart == CompletionGraph.StartInitializing || incompletePart == CompletionGraph.FinishInitializing)
                {
                    if (_state.NotePartComplete(CompletionGraph.StartInitializing))
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        _name = CompleteSymbolProperty_Name(diagnostics, cancellationToken);
                        _metadataName = CompleteSymbolProperty_MetadataName(diagnostics, cancellationToken);
                        CompleteInitializingSymbol(diagnostics, cancellationToken);
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                        _state.NotePartComplete(CompletionGraph.FinishInitializing);
                    }
                }
                else if (incompletePart == CompletionGraph.StartCreatingChildren || incompletePart == CompletionGraph.FinishCreatingChildren)
                {
                    if (_state.NotePartComplete(CompletionGraph.StartCreatingChildren))
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        _containedSymbols = CompleteCreatingChildSymbols(diagnostics, cancellationToken);
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                        _state.NotePartComplete(CompletionGraph.FinishCreatingChildren);
                    }
                }
                else if (incompletePart == CompletionParts.StartComputingProperty_Attributes || incompletePart == CompletionParts.FinishComputingProperty_Attributes)
                {
                    if (_state.NotePartComplete(CompletionParts.StartComputingProperty_Attributes))
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        _attributes = CompleteSymbolProperty_Attributes(diagnostics, cancellationToken);
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                        _state.NotePartComplete(CompletionParts.FinishComputingProperty_Attributes);
                    }
                }
                else if (incompletePart == CompletionParts.StartComputingProperty_TypeParameters || incompletePart == CompletionParts.FinishComputingProperty_TypeParameters)
                {
                    if (_state.NotePartComplete(CompletionParts.StartComputingProperty_TypeParameters))
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        _typeParameters = CompleteSymbolProperty_TypeParameters(diagnostics, cancellationToken);
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                        _state.NotePartComplete(CompletionParts.FinishComputingProperty_TypeParameters);
                    }
                }
                else if (incompletePart == CompletionParts.StartComputingProperty_DeclaredAccessibility || incompletePart == CompletionParts.FinishComputingProperty_DeclaredAccessibility)
                {
                    if (_state.NotePartComplete(CompletionParts.StartComputingProperty_DeclaredAccessibility))
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        _declaredAccessibility = CompleteSymbolProperty_DeclaredAccessibility(diagnostics, cancellationToken);
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                        _state.NotePartComplete(CompletionParts.FinishComputingProperty_DeclaredAccessibility);
                    }
                }
                else if (incompletePart == CompletionParts.StartComputingProperty_IsExtern || incompletePart == CompletionParts.FinishComputingProperty_IsExtern)
                {
                    if (_state.NotePartComplete(CompletionParts.StartComputingProperty_IsExtern))
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        _isExtern = CompleteSymbolProperty_IsExtern(diagnostics, cancellationToken);
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                        _state.NotePartComplete(CompletionParts.FinishComputingProperty_IsExtern);
                    }
                }
                else if (incompletePart == CompletionParts.StartComputingProperty_Members || incompletePart == CompletionParts.FinishComputingProperty_Members)
                {
                    if (_state.NotePartComplete(CompletionParts.StartComputingProperty_Members))
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        _members = CompleteSymbolProperty_Members(diagnostics, cancellationToken);
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                        _state.NotePartComplete(CompletionParts.FinishComputingProperty_Members);
                    }
                }
                else if (incompletePart == CompletionGraph.StartComputingNonSymbolProperties || incompletePart == CompletionGraph.FinishComputingNonSymbolProperties)
                {
                    if (_state.NotePartComplete(CompletionGraph.StartComputingNonSymbolProperties))
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        CompleteNonSymbolProperties(locationOpt, diagnostics, cancellationToken);
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                        _state.NotePartComplete(CompletionGraph.FinishComputingNonSymbolProperties);
                    }
                }
                else if (incompletePart == CompletionGraph.ChildrenCompleted)
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    CompleteImports(locationOpt, diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    bool allCompleted = true;
                    if (locationOpt == null)
                    {
                        foreach (var child in _containedSymbols)
                        {
                            cancellationToken.ThrowIfCancellationRequested();
                            child.ForceComplete(null, locationOpt, cancellationToken);
                        }
                    }
                    else
                    {
                        foreach (var child in _containedSymbols)
                        {
                            ForceCompleteChildByLocation(locationOpt, child, cancellationToken);
                            allCompleted = allCompleted && child.HasComplete(CompletionGraph.All);
                        }
                    }
                    if (!allCompleted)
                    {
                        // We did not complete all members, so just kick out now.
                        var allParts = CompletionParts.AllWithLocation;
                        _state.SpinWaitComplete(allParts, cancellationToken);
                        return;
                    }
                    // We've completed all members, proceed to the next iteration.
                    _state.NotePartComplete(CompletionGraph.ChildrenCompleted);
                }
                else if (incompletePart == CompletionGraph.StartValidatingSymbol || incompletePart == CompletionGraph.FinishValidatingSymbol)
                {
                    if (_state.NotePartComplete(CompletionGraph.StartValidatingSymbol))
                    {
                        var diagnostics = DiagnosticBag.GetInstance();
                        CompleteValidatingSymbol(diagnostics, cancellationToken);
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                        _state.NotePartComplete(CompletionGraph.FinishValidatingSymbol);
                    }
                }
                else if (incompletePart == null)
                {
                    return;
                }
                else
                {
                    // This assert will trigger if we forgot to handle any of the completion parts
                    Debug.Assert(!CompletionParts.All.Contains(incompletePart));
                    // any other values are completion parts intended for other kinds of symbols
                    _state.NotePartComplete(incompletePart);
                }
                if (completionPart != null && _state.HasComplete(completionPart)) return;
                _state.SpinWaitComplete(incompletePart, cancellationToken);
            }
            throw ExceptionUtilities.Unreachable;
        }


        protected virtual string CompleteSymbolProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolImplementation.AssignNameProperty(this, diagnostics);
        }

        protected virtual string CompleteSymbolProperty_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolImplementation.AssignMetadataNameProperty(this, diagnostics);
        }

        protected virtual void CompleteInitializingSymbol(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
        }

        protected virtual ImmutableArray<Symbol> CompleteCreatingChildSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolImplementation.MakeChildSymbols(this, nameof(ChildSymbols), diagnostics, cancellationToken);
        }

        protected virtual void CompleteImports(SourceLocation locationOpt, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            SymbolImplementation.CompleteImports(this, locationOpt, diagnostics, cancellationToken);
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol> CompleteSymbolProperty_Attributes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            SymbolImplementation.AssignSymbolPropertyValues<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>(this, nameof(Attributes), diagnostics, cancellationToken, out var result);
            return result;
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.TypeParameterSymbol> CompleteSymbolProperty_TypeParameters(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            SymbolImplementation.AssignSymbolPropertyValues<global::MetaDslx.CodeAnalysis.Symbols.TypeParameterSymbol>(this, nameof(TypeParameters), diagnostics, cancellationToken, out var result);
            return result;
        }

        protected virtual Accessibility CompleteSymbolProperty_DeclaredAccessibility(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            SymbolImplementation.AssignSymbolPropertyValue<Accessibility>(this, nameof(DeclaredAccessibility), diagnostics, cancellationToken, out var result);
            return result;
        }

        protected virtual bool CompleteSymbolProperty_IsExtern(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            SymbolImplementation.AssignSymbolPropertyValue<bool>(this, nameof(IsExtern), diagnostics, cancellationToken, out var result);
            return result;
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol> CompleteSymbolProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            SymbolImplementation.AssignSymbolPropertyValues<global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol>(this, nameof(Members), diagnostics, cancellationToken, out var result);
            return result;
        }

        protected virtual void CompleteNonSymbolProperties(SourceLocation locationOpt, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            SymbolImplementation.AssignNonSymbolProperties(this, diagnostics, cancellationToken);
        }
        #endregion

    }
}
