using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class ModelPropertyAttribute : Attribute
    {
        public ModelPropertyAttribute()
        {
            CompleteMethodParameters = CompleteMethodParameters.All;
        }

        public CompleteMethodParameters CompleteMethodParameters { get; set; }
    }
}
