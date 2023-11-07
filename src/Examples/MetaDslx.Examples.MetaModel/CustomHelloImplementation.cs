using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Examples.MetaModel.Model
{
    internal class CustomHelloImplementation : CustomHelloImplementationBase
    {
        public override string HelloType_SayHello(HelloType _this, string name)
        {
            return $"{_this.Message}: {name}";
        }
    }
}
