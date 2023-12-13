using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling.Reflection
{
    internal class ReflectionCollectionSlot : CollectionSlot
    {
        public ReflectionCollectionSlot(IModelObject owner, ModelPropertySlot property) 
            : base(owner, property)
        {
        }
    }
}
