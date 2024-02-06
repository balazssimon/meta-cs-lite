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
    
        /// <summary>
        /// Constructor for the class Comment
        /// </summary>
        public virtual void Comment(Comment _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Element
        /// </summary>
        public virtual void Element(Element _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Association
        /// </summary>
        public virtual void Association(Association _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class AssociationInstance
        /// </summary>
        public virtual void AssociationInstance(AssociationInstance _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class BehavioralFeature
        /// </summary>
        public virtual void BehavioralFeature(BehavioralFeature _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Classifier
        /// </summary>
        public virtual void Classifier(Classifier _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Class
        /// </summary>
        public virtual void Class(Class _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ClassInstance
        /// </summary>
        public virtual void ClassInstance(ClassInstance _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Constraint
        /// </summary>
        public virtual void Constraint(Constraint _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DataType
        /// </summary>
        public virtual void DataType(DataType _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Relationship
        /// </summary>
        public virtual void Relationship(Relationship _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DirectedRelationship
        /// </summary>
        public virtual void DirectedRelationship(DirectedRelationship _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Extent
        /// </summary>
        public virtual void Extent(Extent _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ExtentImplementation
        /// </summary>
        public virtual void ExtentImplementation(ExtentImplementation _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Feature
        /// </summary>
        public virtual void Feature(Feature _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Generalization
        /// </summary>
        public virtual void Generalization(Generalization _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class IdentifierEntry
        /// </summary>
        public virtual void IdentifierEntry(IdentifierEntry _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LinkSlot
        /// </summary>
        public virtual void LinkSlot(LinkSlot _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MultiplicityElement
        /// </summary>
        public virtual void MultiplicityElement(MultiplicityElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class NamedElement
        /// </summary>
        public virtual void NamedElement(NamedElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Namespace
        /// </summary>
        public virtual void Namespace(Namespace _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Operation
        /// </summary>
        public virtual void Operation(Operation _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class PackageableElement
        /// </summary>
        public virtual void PackageableElement(PackageableElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Enumeration
        /// </summary>
        public virtual void Enumeration(Enumeration _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InstanceSpecification
        /// </summary>
        public virtual void InstanceSpecification(InstanceSpecification _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class EnumerationLiteral
        /// </summary>
        public virtual void EnumerationLiteral(EnumerationLiteral _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Instance
        /// </summary>
        public virtual void Instance(Instance _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ElementInstance
        /// </summary>
        public virtual void ElementInstance(ElementInstance _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ObjectInstance
        /// </summary>
        public virtual void ObjectInstance(ObjectInstance _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Package
        /// </summary>
        public virtual void Package(Package _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class PackageImport
        /// </summary>
        public virtual void PackageImport(PackageImport _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class PackageMerge
        /// </summary>
        public virtual void PackageMerge(PackageMerge _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Parameter
        /// </summary>
        public virtual void Parameter(Parameter _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class StructuralFeature
        /// </summary>
        public virtual void StructuralFeature(StructuralFeature _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Property
        /// </summary>
        public virtual void Property(Property _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Slot
        /// </summary>
        public virtual void Slot(Slot _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class StructureSlot
        /// </summary>
        public virtual void StructureSlot(StructureSlot _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Tag
        /// </summary>
        public virtual void Tag(Tag _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Type
        /// </summary>
        public virtual void Type(Type _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class PrimitiveType
        /// </summary>
        public virtual void PrimitiveType(PrimitiveType _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TypedElement
        /// </summary>
        public virtual void TypedElement(TypedElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ValueSpecification
        /// </summary>
        public virtual void ValueSpecification(ValueSpecification _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DataValue
        /// </summary>
        public virtual void DataValue(DataValue _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InstanceValue
        /// </summary>
        public virtual void InstanceValue(InstanceValue _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LiteralSpecification
        /// </summary>
        public virtual void LiteralSpecification(LiteralSpecification _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LiteralBoolean
        /// </summary>
        public virtual void LiteralBoolean(LiteralBoolean _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LiteralInteger
        /// </summary>
        public virtual void LiteralInteger(LiteralInteger _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LiteralNull
        /// </summary>
        public virtual void LiteralNull(LiteralNull _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LiteralReal
        /// </summary>
        public virtual void LiteralReal(LiteralReal _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LiteralString
        /// </summary>
        public virtual void LiteralString(LiteralString _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LiteralUnlimitedNatural
        /// </summary>
        public virtual void LiteralUnlimitedNatural(LiteralUnlimitedNatural _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class OpaqueExpression
        /// </summary>
        public virtual void OpaqueExpression(OpaqueExpression _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class PrimitiveDataValue
        /// </summary>
        public virtual void PrimitiveDataValue(PrimitiveDataValue _this)
        {
        }
    
    
        /// <summary>
        /// Computation of the derived property Class.SuperClass
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Class> Class_SuperClass(Class _this);
    
        /// <summary>
        /// Computation of the derived property Relationship.RelatedElement
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Element> Relationship_RelatedElement(Relationship _this);
    
        /// <summary>
        /// Computation of the derived property MultiplicityElement.Lower
        /// </summary>
        public abstract long MultiplicityElement_Lower(MultiplicityElement _this);
    
        /// <summary>
        /// Computation of the derived property MultiplicityElement.Upper
        /// </summary>
        public abstract long MultiplicityElement_Upper(MultiplicityElement _this);
    
        /// <summary>
        /// Computation of the derived property NamedElement.QualifiedName
        /// </summary>
        public abstract string NamedElement_QualifiedName(NamedElement _this);
    
        /// <summary>
        /// Computation of the derived property NamedElement.MemberNamespace
        /// </summary>
        public abstract Namespace NamedElement_MemberNamespace(NamedElement _this);
    
        /// <summary>
        /// Computation of the derived property Namespace.Member
        /// </summary>
        public abstract global::System.Collections.Generic.IList<NamedElement> Namespace_Member(Namespace _this);
    
        /// <summary>
        /// Computation of the derived property Operation.IsOrdered
        /// </summary>
        public abstract bool Operation_IsOrdered(Operation _this);
    
        /// <summary>
        /// Computation of the derived property Operation.IsUnique
        /// </summary>
        public abstract bool Operation_IsUnique(Operation _this);
    
        /// <summary>
        /// Computation of the derived property Operation.Lower
        /// </summary>
        public abstract long Operation_Lower(Operation _this);
    
        /// <summary>
        /// Computation of the derived property Operation.Upper
        /// </summary>
        public abstract long Operation_Upper(Operation _this);
    
        /// <summary>
        /// Computation of the derived property Property.Opposite
        /// </summary>
        public abstract Property Property_Opposite(Property _this);
    
        /// <summary>
        /// Computation of the derived property Property.Default
        /// </summary>
        public abstract string Property_Default(Property _this);
    
        /// <summary>
        /// Computation of the derived property Property.IsComposite
        /// </summary>
        public abstract bool Property_IsComposite(Property _this);
    
    
    }
}
