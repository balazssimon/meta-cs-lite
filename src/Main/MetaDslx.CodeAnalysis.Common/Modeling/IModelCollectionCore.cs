using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    internal interface IModelCollectionCore
    {
        void AddCore(object? item);
        void RemoveCore(object? item);
    }
}
