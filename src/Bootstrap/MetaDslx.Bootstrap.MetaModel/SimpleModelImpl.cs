using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaModel
{
    public partial interface SimpleModel
    {
    }

    public partial class SimpleModelFactory : global::MetaDslx.Modeling.ModelFactory
    {
        public SimpleModelFactory(Model model)
            : base(model)
        {
        }

        public Husband Husband()
        {
            var result = new HusbandImpl();
            ((IModel)Model).AddObject(result);
            return result;
        }

        public Wife Wife()
        {
            var result = new WifeImpl();
            ((IModel)Model).AddObject(result);
            return result;
        }

        public User User()
        {
            var result = new UserImpl();
            ((IModel)Model).AddObject(result);
            return result;
        }
    }

    public partial interface SimpleClass
    {
        public static readonly ModelProperty MProperty_Name = new ModelProperty(typeof(SimpleClass), nameof(Name), ModelPropertyKind.SingleValue, typeof(string), false);
        public static readonly ImmutableArray<ModelProperty> MProperties = ImmutableArray.Create(MProperty_Name);
    }

    public partial interface Husband
    {
        public static readonly ModelProperty MProperty_Wife = new ModelProperty(typeof(Husband), nameof(Wife), ModelPropertyKind.SingleValue, typeof(Wife), false);
        public static new readonly ImmutableArray<ModelProperty> MProperties = ImmutableArray.Create(MProperty_Name, MProperty_Wife);
    }

    public partial interface Wife
    {
        public static readonly ModelProperty MProperty_Husband = new ModelProperty(typeof(Wife), nameof(Husband), ModelPropertyKind.SingleValue, typeof(Husband), false);
        public static new readonly ImmutableArray<ModelProperty> MProperties = ImmutableArray.Create(MProperty_Name, MProperty_Husband);
    }

    public partial interface User
    {
        public static readonly ModelProperty MProperty_Roles = new ModelProperty(typeof(User), nameof(Roles), ModelPropertyKind.List, typeof(Role), false);
        public static new readonly ImmutableArray<ModelProperty> MProperties = ImmutableArray.Create(MProperty_Name, MProperty_Roles);
    }

    public partial interface Role
    {
        public static readonly ModelProperty MProperty_Users = new ModelProperty(typeof(Role), nameof(Users), ModelPropertyKind.List, typeof(User), false);
        public static new readonly ImmutableArray<ModelProperty> MProperties = ImmutableArray.Create(MProperty_Name, MProperty_Users);
    }

    internal class HusbandImpl : global::MetaDslx.Modeling.ModelObject, Husband
    {
        protected override ImmutableArray<ModelProperty> MProperties => Husband.MProperties;
        Wife? Husband.Wife { get => (Wife?)((IModelObject)this).MGet(Husband.MProperty_Wife); set => ((IModelObject)this).MSet(Husband.MProperty_Wife, value); }
        string? SimpleClass.Name { get => (string?)((IModelObject)this).MGet(SimpleClass.MProperty_Name); set => ((IModelObject)this).MSet(SimpleClass.MProperty_Name, value); }
    }

    internal class WifeImpl : global::MetaDslx.Modeling.ModelObject, Wife
    {
        protected override ImmutableArray<ModelProperty> MProperties => Wife.MProperties;
        Husband? Wife.Husband { get => (Husband?)((IModelObject)this).MGet(Wife.MProperty_Husband); set => ((IModelObject)this).MSet(Wife.MProperty_Husband, value); }
        string? SimpleClass.Name { get => (string?)((IModelObject)this).MGet(SimpleClass.MProperty_Name); set => ((IModelObject)this).MSet(SimpleClass.MProperty_Name, value); }
    }

    internal class UserImpl : global::MetaDslx.Modeling.ModelObject, User
    {
        public UserImpl()
        {
            ((IModelObject)this).MInit(User.MProperty_Roles, new ModelObjectList<Role>(this, User.MProperty_Roles));
        }

        protected override ImmutableArray<ModelProperty> MProperties => User.MProperties;
        IList<Role> User.Roles => (IList<Role>)((IModelObject)this).MGet(User.MProperty_Roles)!;
        string? SimpleClass.Name { get => (string?)((IModelObject)this).MGet(SimpleClass.MProperty_Name); set => ((IModelObject)this).MSet(SimpleClass.MProperty_Name, value); }
    }
}
