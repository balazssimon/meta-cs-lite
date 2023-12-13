using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    internal class DefaultBox : Box
    {
        private ValueInfo? _valueInfo;

        public DefaultBox(ISlot slot)
            : base(slot)
        {
        }

        public override ValueInfo? Info
        {
            get
            {
                if (_valueInfo is null)
                {
                    _valueInfo = Model.CreateValueInfo(this);
                }
                return _valueInfo;
            }
        }
    }
}
