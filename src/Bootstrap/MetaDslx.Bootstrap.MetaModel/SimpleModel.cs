using MetaDslx.Bootstrap.MetaModel.Internal;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaModel
{
    [MetaModel(MajorVersion = 1, MinorVersion = 2, Prefix = "sm", Uri = "http://metadslx/SimpleModel")]
    public partial interface SimpleModel 
    {
        public static readonly Husband Husband1;

        static SimpleModel()
        {
            var f = new SimpleModelFactory(new Model());
            Husband1 = f.Husband();
            Husband1.Name = "a";
        }
    }

    [MetaClass(IsAbstract = true)]
    public partial interface SimpleClass
    {
        [Name]
        [DefaultValue("Hello")]
        public string? Name { get; set; } 

        public virtual bool IsHusband()
        {
            return false;
        }
    }

    public partial interface Husband : SimpleClass
    {
        [Opposite(typeof(Wife), "Husband")]
        Wife? Wife { get; set; }

        public new bool IsHusband()
        {
            return true;
        }
    }

    public partial interface Wife : SimpleClass
    {
        [Opposite(typeof(Husband), "Wife")]
        Husband? Husband { get; set; }
    }

    public partial interface Node : SimpleClass
    {
        [Opposite(typeof(Composite), "Children")]
        Composite Parent { get; set; }
    }

    public partial interface Composite : Node
    {
        [Containment]
        [Opposite(typeof(Node), "Parent")]
        IList<Node> Children { get; }
    }

    public partial interface User : SimpleClass
    {
        [Opposite(typeof(Role), "Users")]
        IList<Role> Roles { get; }
    }

    public partial interface Role : SimpleClass
    {
        [Opposite(typeof(User), "Roles")]
        IList<User> Users { get; }
    }

    public partial interface User2 : User
    {
        [Subsets(typeof(User), "Roles")]
        IList<Role> Roles2 { get; }
        [Redefines(typeof(User), "Roles")]
        IList<Role> Roles3 { get; }
        [Redefines(typeof(Role), "Users")]
        IList<Role> Roles4 { get; }
        [Redefines(typeof(User), "Roles")]
        Role Roles5 { get; set; }
    }
}
