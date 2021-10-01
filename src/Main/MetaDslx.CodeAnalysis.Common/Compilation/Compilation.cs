using MetaDslx.CodeAnalysis.Declarations;
using System;

namespace MetaDslx.CodeAnalysis
{
    public abstract class Compilation
    {
        public DeclarationTable Declarations { get; }

        internal int CompareSourceLocations(Location location1, Location location2)
        {
            throw new NotImplementedException();
        }

        internal int CompareSourceLocations(SyntaxReference location1, SyntaxReference location2)
        {
            throw new NotImplementedException();
        }
    }
}