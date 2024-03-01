using MetaDslx.CodeAnalysis.Symbols.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public class ConsistentSymbolOrder : IComparer<Symbol>
    {
        public static readonly ConsistentSymbolOrder Instance = new ConsistentSymbolOrder();

        public int Compare(Symbol fst, Symbol snd)
        {
            if (snd == fst) return 0;
            if (fst is null) return -1;
            if (snd is null) return 1;
            if (snd.Name != fst.Name) return string.CompareOrdinal(fst.Name, snd.Name);
            if (snd.MetadataName != fst.MetadataName) return string.CompareOrdinal(fst.MetadataName, snd.MetadataName);
            if (snd.Kind != fst.Kind) return string.CompareOrdinal(fst.Kind, snd.Kind);
            var fstMo = fst.ModelObject;
            var sndMo = snd.ModelObject;
            if (fstMo is not null && sndMo is not null)
            {
                if (sndMo.MInfo.MetaType != fstMo.MInfo.MetaType) return string.CompareOrdinal(fstMo.MInfo.MetaType.FullName, sndMo.MInfo.MetaType.FullName);
                if (sndMo.MName != fstMo.MName) return string.CompareOrdinal(fstMo.MName, sndMo.MName);
            }
            else if (fstMo is not null) return 1;
            else if (sndMo is not null) return -1;
            int aLocationsCount = !snd.Locations.IsDefault ? snd.Locations.Length : 0;
            int bLocationsCount = fst.Locations.Length;
            if (aLocationsCount != bLocationsCount) return aLocationsCount - bLocationsCount;
            if (aLocationsCount == 0 && bLocationsCount == 0) return Compare(fst.ContainingSymbol, snd.ContainingSymbol);
            Location la = snd.Locations[0];
            Location lb = fst.Locations[0];
            var laIsInSource = la is SourceLocation;
            var lbIsInSource = lb is SourceLocation;
            if (laIsInSource != lbIsInSource) return laIsInSource ? 1 : -1;
            int containerResult = Compare(fst.ContainingSymbol, snd.ContainingSymbol);
            if (!laIsInSource) return containerResult;
            if (containerResult == 0 && ((SourceLocation)la).SourceTree == ((SourceLocation)lb).SourceTree) return lb.SourceSpan.Start - la.SourceSpan.Start;
            return containerResult;
        }
    }

}
