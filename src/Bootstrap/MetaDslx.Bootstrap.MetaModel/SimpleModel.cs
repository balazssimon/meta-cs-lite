using MetaDslx.CodeAnalysis.Modeling;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaModel
{
    [MetaModel]
    public partial interface SimpleModel
    {
    }

    [MetaClass(IsAbstract = true)]
    public interface SimpleClass
    {
        public string Name { get; set; }
    }

    public interface Husband : SimpleClass
    {
        [Opposite(typeof(Wife), "Husband")]
        Wife Wife { get; set; }
    }

    public interface Wife : SimpleClass
    {
        [Opposite(typeof(Husband), "Wife")]
        Husband Husband { get; set; }
    }

    public interface User : SimpleClass
    {
        [Opposite(typeof(Role), "Users")]
        IList<Role> Roles { get; }
    }

    public interface Role : SimpleClass
    {
        [Opposite(typeof(User), "Roles")]
        IList<User> Users { get; }
    }
}
