using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    [Flags]
    public enum ModelPropertyFlags
    {
        None = 0,
        Untracked = 0x0001,
        ValueType = 0x0002,
        ReferenceType = 0x0004,
        NullableType = 0x0008,
        BuiltInType = 0x0010,
        MetaClassType = 0x0020,
        Containment = 0x0040,
        Collection = 0x0080,
        Unordered = 0x0100,
        NonUnique = 0x0200,
        Readonly = 0x0400,
        Derived = 0x0800,
        DerivedUnion = 0x1000
    }
}
