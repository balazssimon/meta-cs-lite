using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling.Reflection
{
    internal class ReflectionSingleSlot : SingleSlot
    {
        public ReflectionSingleSlot(ModelObject owner, ModelPropertySlot property)
            : base(owner, property)
        {
        }
    }
}
