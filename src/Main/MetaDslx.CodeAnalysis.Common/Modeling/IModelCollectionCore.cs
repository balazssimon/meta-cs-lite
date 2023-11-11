using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    internal interface IModelCollectionCore
    {
        void AddCore(object? item, bool fromOpposite);
        void RemoveCore(object? item, bool fromOpposite);
    }
}
