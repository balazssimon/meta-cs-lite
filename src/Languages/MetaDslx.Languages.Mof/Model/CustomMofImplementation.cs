using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.Mof.Model
{
    internal class CustomMofImplementation : CustomMofImplementationBase
    {
        public override void Mof(IMof _this)
        {
            base.Mof(_this);
            _this.Boolean.Name = "Boolean";
            _this.Integer.Name = "Integer";
            _this.Real.Name = "Real";
            _this.String.Name = "String";
            _this.UnlimitedNatural.Name = "UnlimitedNatural";
        }

        public override IList<Class> Class_SuperClass(Class _this)
        {
            throw new NotImplementedException();
        }

        public override long MultiplicityElement_Lower(MultiplicityElement _this)
        {
            throw new NotImplementedException();
        }

        public override long MultiplicityElement_Upper(MultiplicityElement _this)
        {
            throw new NotImplementedException();
        }

        public override Namespace NamedElement_MemberNamespace(NamedElement _this)
        {
            throw new NotImplementedException();
        }

        public override string NamedElement_QualifiedName(NamedElement _this)
        {
            throw new NotImplementedException();
        }

        public override IList<NamedElement> Namespace_Member(Namespace _this)
        {
            throw new NotImplementedException();
        }

        public override bool Operation_IsOrdered(Operation _this)
        {
            throw new NotImplementedException();
        }

        public override bool Operation_IsUnique(Operation _this)
        {
            throw new NotImplementedException();
        }

        public override long Operation_Lower(Operation _this)
        {
            throw new NotImplementedException();
        }

        public override long Operation_Upper(Operation _this)
        {
            throw new NotImplementedException();
        }

        public override string Property_Default(Property _this)
        {
            throw new NotImplementedException();
        }

        public override bool Property_IsComposite(Property _this)
        {
            throw new NotImplementedException();
        }

        public override Property Property_Opposite(Property _this)
        {
            throw new NotImplementedException();
        }

        public override IList<Element> Relationship_RelatedElement(Relationship _this)
        {
            throw new NotImplementedException();
        }
    }
}
