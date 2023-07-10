using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class MergeBinder : Binder
    {
        private bool _allow;

        public MergeBinder(bool allow = true)
        {
            _allow = allow;
        }

        public bool Allow => _allow;
    }
}
