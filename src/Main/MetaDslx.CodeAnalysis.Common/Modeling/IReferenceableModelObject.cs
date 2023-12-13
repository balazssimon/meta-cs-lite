using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IReferenceableModelObject
    {
        void AddReference(Box box);
        void RemoveReference(Box box);
    }
}
