using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Roslyn.Utilities
{
    public static class ReflectionUtilities
    {
        public static PropertyInfo? GetAllProperties(this Type type, string name)
        {
            var propInfo = type.GetProperty(name, BindingFlags.Public | BindingFlags.Instance);
            if (propInfo is not null) return propInfo;
            if (type.IsInterface)
            {
                foreach (var intf in type.GetInterfaces())
                {
                    propInfo = intf.GetProperty(name, BindingFlags.Public | BindingFlags.Instance);
                    if (propInfo is not null) return propInfo;
                }
            }
            return null;
        }

        public static PropertyInfo? GetAllProperties(this Type type, string name, BindingFlags flags)
        {
            var propInfo = type.GetProperty(name, flags);
            if (propInfo is not null) return propInfo;
            if (type.IsInterface)
            {
                foreach (var intf in type.GetInterfaces())
                {
                    propInfo = intf.GetProperty(name, flags);
                    if (propInfo is not null) return propInfo;
                }
            }
            return null;
        }
    }
}
