using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaModel
{
    public partial interface SimpleModel
    {
        ISet<Husband> Husbands { get; }
        ISet<Wife> Wifes { get; }
        ISet<User> Users { get; }
        ISet<Role> Roles { get; }
    }

    internal class SimpleModelImpl : SimpleModel
    {
    }
}
