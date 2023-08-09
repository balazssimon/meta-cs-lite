using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Errors
{
    public class ErrorNamespaceSymbol : NamespaceSymbol, IErrorSymbol
    {
        private readonly ModuleSymbol _module;
        private DiagnosticInfo _errorInfo;

        public ErrorNamespaceSymbol(Symbol container, DiagnosticInfo errorInfo) 
            : base(container)
        {
            _module = container is ModuleSymbol moduleSymbol ? moduleSymbol : container.ContainingModule;
            _errorInfo = errorInfo;
        }

        public override NamespaceExtent Extent => new NamespaceExtent(_module);

        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;

        public DiagnosticInfo ErrorInfo => _errorInfo;
    }
}
