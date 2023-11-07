using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public sealed class ModelOperation
    {
        private Type _declaringType;
        private readonly string _name;
        private readonly string _signature;

        public ModelOperation(Type declaringType, string name, string signature)
        {
            _declaringType = declaringType;
            _name = name;
            _signature = signature;
        }

        public Type DeclaringType => _declaringType;
        public string Name => _name;
        public string Signature => _signature;
    }
}
