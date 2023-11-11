﻿using System;
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
        EnumType = 0x0020,
        ModelObjectType = 0x0040,
        Containment = 0x0080,
        SingleItem = 0x0100,
        Collection = 0x0200,
        Unordered = 0x0400,
        NonUnique = 0x0800,
        ReadOnly = 0x1000,
        Derived = 0x2000,
        DerivedUnion = 0x4000,
        Name = 0x8000,
        Type = 0x10000
    }
}
