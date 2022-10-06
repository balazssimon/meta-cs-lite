using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModelCollection
    {
        void MAdd(object? item);
        void MRemove(object? item);
        bool MContains(object? item);
        int MCount { get; }
        object? MSingleItem { get; set; }
    }
}
