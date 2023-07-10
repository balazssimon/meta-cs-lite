using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class ScopeBinder : Binder, IScopeBinder
    {
        private bool _local;

        public ScopeBinder(bool local = false)
        {
            _local = local;
        }

        public bool IsLocal => _local;
    }
}
