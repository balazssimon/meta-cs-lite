using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Fixed
{
    internal class FixedAliasSymbol : AliasSymbol
    {
        private string _name;
        private Symbol _target;
        private ImmutableArray<Location> _locations;

        public FixedAliasSymbol(Symbol container, string name, Symbol target, Location? location = null)
            : base(container)
        {
            _name = name;
            _target = target;
            if (location is not null) _locations = ImmutableArray.Create(location);
            else _locations = ImmutableArray<Location>.Empty;
        }

        public FixedAliasSymbol(Symbol container, string name, Symbol target, ImmutableArray<Location> locations)
            : base(container)
        {
            _name = name;
            _target = target;
            _locations = locations;
        }

        public override ImmutableArray<Location> Locations => _locations;

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _name;
        }

        protected override Symbol CompleteProperty_Target(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _target;
        }
    }
}
