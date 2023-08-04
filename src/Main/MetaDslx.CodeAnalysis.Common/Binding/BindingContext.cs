using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public struct BindingContext
    {
        public static BindingContext Default => new BindingContext();

        private readonly DiagnosticBag? _diagnostics;
        private readonly CancellationToken _cancellationToken;

        public BindingContext(DiagnosticBag? diagnostics, CancellationToken cancellationToken)
        {
            _diagnostics = diagnostics;
            _cancellationToken = cancellationToken;
        }

        public bool IsDefault => _diagnostics is null;
        public DiagnosticBag? Diagnostics => _diagnostics;
        public CancellationToken CancellationToken => _cancellationToken;

        public static BindingContext GetInstance(CancellationToken cancellationToken = default)
        {
            return new BindingContext(DiagnosticBag.GetInstance(), cancellationToken);
        }

        public void Free()
        {
            if (_diagnostics is not null) _diagnostics.Free();
        }

        public ImmutableArray<Diagnostic> ToDiagnostics()
        {
            if (_diagnostics is not null) return _diagnostics.ToReadOnly();
            else return ImmutableArray<Diagnostic>.Empty;
        }

        public ImmutableArray<Diagnostic> ToDiagnosticsAndFree()
        {
            if (_diagnostics is not null) return _diagnostics.ToReadOnlyAndFree();
            else return ImmutableArray<Diagnostic>.Empty;
        }

        public void AddDiagnostic(Diagnostic diagnostic)
        {
            if (_diagnostics is not null) _diagnostics.Add(diagnostic);
        }

        public void AddDiagnostics(BindingContext context)
        {
            if (_diagnostics is not null && context.Diagnostics is not null) _diagnostics.AddRange(context.Diagnostics);
        }

        public void AddDiagnostics(DiagnosticBag diagnostic)
        {
            if (_diagnostics is not null) _diagnostics.AddRange(diagnostic);
        }

        public void AddDiagnostics(IEnumerable<Diagnostic> diagnostic)
        {
            if (_diagnostics is not null) _diagnostics.AddRange(diagnostic);
        }
    }
}
