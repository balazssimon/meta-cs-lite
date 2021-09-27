using System;

namespace Microsoft.CodeAnalysis
{
    public abstract class Compilation
    {
        internal int CompareSourceLocations(Location location1, Location location2)
        {
            throw new NotImplementedException();
        }
    }
}