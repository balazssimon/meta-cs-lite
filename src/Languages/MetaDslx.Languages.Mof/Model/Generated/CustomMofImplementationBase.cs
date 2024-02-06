#nullable enable

namespace MetaDslx.Languages.Mof.Model
{
    using __MetaMetaModel = global::MetaDslx.Languages.MetaModel.Model.Meta;
    using __MetaModelFactory = global::MetaDslx.Languages.MetaModel.Model.MetaModelFactory;
    using __Model = global::MetaDslx.Modeling.Model;
    using __MetaModel = global::MetaDslx.Modeling.MetaModel;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __ModelFactory = global::MetaDslx.Modeling.ModelFactory;
    using __MultiModelFactory = global::MetaDslx.Modeling.MultiModelFactory;
    using __ModelVersion = global::MetaDslx.Modeling.ModelVersion;
    using __ModelEnumInfo = global::MetaDslx.Modeling.ModelEnumInfo;
    using __ModelClassInfo = global::MetaDslx.Modeling.ModelClassInfo;
    using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
    using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
    using __ModelOperation = global::MetaDslx.Modeling.ModelOperation;
    using __ModelOperationInfo = global::MetaDslx.Modeling.ModelOperationInfo;
    using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
    using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
    using __MetaType = global::MetaDslx.CodeAnalysis.MetaType;
    using __MetaSymbol = global::MetaDslx.CodeAnalysis.MetaSymbol;
    using __Type = global::System.Type;
    using __Enum = global::System.Enum;

    internal abstract class CustomMofImplementationBase : ICustomMofImplementation
    {
        /// <summary>
        /// Constructor for the meta model Mof
        /// </summary>
        public virtual void Mof(IMof _this)
        {
        }
    
        public virtual void Comment(Comment _this)
        {
        }
    
        public virtual void Element(Element _this)
        {
        }
    
        public virtual void Association(Association _this)
        {
        }
    
        public virtual void AssociationInstance(AssociationInstance _this)
        {
        }
    
        public virtual void BehavioralFeature(BehavioralFeature _this)
        {
        }
    
        public virtual void Classifier(Classifier _this)
        {
        }
    
        public virtual void Class(Class _this)
        {
        }
    
        public virtual void ClassInstance(ClassInstance _this)
        {
        }
    
        public virtual void Constraint(Constraint _this)
        {
        }
    
        public virtual void DataType(DataType _this)
        {
        }
    
        public virtual void Relationship(Relationship _this)
        {
        }
    
        public virtual void DirectedRelationship(DirectedRelationship _this)
        {
        }
    
        public virtual void Extent(Extent _this)
        {
        }
    
        public virtual void ExtentImplementation(ExtentImplementation _this)
        {
        }
    
        public virtual void Feature(Feature _this)
        {
        }
    
        public virtual void Generalization(Generalization _this)
        {
        }
    
        public virtual void IdentifierEntry(IdentifierEntry _this)
        {
        }
    
        public virtual void LinkSlot(LinkSlot _this)
        {
        }
    
        public virtual void MultiplicityElement(MultiplicityElement _this)
        {
        }
    
        public virtual void NamedElement(NamedElement _this)
        {
        }
    
        public virtual void Namespace(Namespace _this)
        {
        }
    
        public virtual void Operation(Operation _this)
        {
        }
    
        public virtual void PackageableElement(PackageableElement _this)
        {
        }
    
        public virtual void Enumeration(Enumeration _this)
        {
        }
    
        public virtual void InstanceSpecification(InstanceSpecification _this)
        {
        }
    
        public virtual void EnumerationLiteral(EnumerationLiteral _this)
        {
        }
    
        public virtual void Instance(Instance _this)
        {
        }
    
        public virtual void ElementInstance(ElementInstance _this)
        {
        }
    
        public virtual void ObjectInstance(ObjectInstance _this)
        {
        }
    
        public virtual void Package(Package _this)
        {
        }
    
        public virtual void PackageImport(PackageImport _this)
        {
        }
    
        public virtual void PackageMerge(PackageMerge _this)
        {
        }
    
        public virtual void Parameter(Parameter _this)
        {
        }
    
        public virtual void StructuralFeature(StructuralFeature _this)
        {
        }
    
        public virtual void Property(Property _this)
        {
        }
    
        public virtual void Slot(Slot _this)
        {
        }
    
        public virtual void StructureSlot(StructureSlot _this)
        {
        }
    
        public virtual void Tag(Tag _this)
        {
        }
    
        public virtual void Type(Type _this)
        {
        }
    
        public virtual void PrimitiveType(PrimitiveType _this)
        {
        }
    
        public virtual void TypedElement(TypedElement _this)
        {
        }
    
        public virtual void ValueSpecification(ValueSpecification _this)
        {
        }
    
        public virtual void DataValue(DataValue _this)
        {
        }
    
        public virtual void InstanceValue(InstanceValue _this)
        {
        }
    
        public virtual void LiteralSpecification(LiteralSpecification _this)
        {
        }
    
        public virtual void LiteralBoolean(LiteralBoolean _this)
        {
        }
    
        public virtual void LiteralInteger(LiteralInteger _this)
        {
        }
    
        public virtual void LiteralNull(LiteralNull _this)
        {
        }
    
        public virtual void LiteralReal(LiteralReal _this)
        {
        }
    
        public virtual void LiteralString(LiteralString _this)
        {
        }
    
        public virtual void LiteralUnlimitedNatural(LiteralUnlimitedNatural _this)
        {
        }
    
        public virtual void OpaqueExpression(OpaqueExpression _this)
        {
        }
    
        public virtual void PrimitiveDataValue(PrimitiveDataValue _this)
        {
        }
    
    
        public abstract global::System.Collections.Generic.IList<Class> Class_SuperClass(Class _this);
    
        public abstract global::System.Collections.Generic.IList<Element> Relationship_RelatedElement(Relationship _this);
    
        public abstract long MultiplicityElement_Lower(MultiplicityElement _this);
    
        public abstract long MultiplicityElement_Upper(MultiplicityElement _this);
    
        public abstract string NamedElement_QualifiedName(NamedElement _this);
    
        public abstract Namespace NamedElement_MemberNamespace(NamedElement _this);
    
        public abstract global::System.Collections.Generic.IList<NamedElement> Namespace_Member(Namespace _this);
    
        public abstract bool Operation_IsOrdered(Operation _this);
    
        public abstract bool Operation_IsUnique(Operation _this);
    
        public abstract long Operation_Lower(Operation _this);
    
        public abstract long Operation_Upper(Operation _this);
    
        public abstract Property Property_Opposite(Property _this);
    
        public abstract string Property_Default(Property _this);
    
        public abstract bool Property_IsComposite(Property _this);
    
    
    }
}
