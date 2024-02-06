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

    internal interface ICustomMofImplementation
    {
        /// <summary>
        /// Constructor for the meta model Mof
        /// </summary>
        void Mof(IMof _this);
    
        /// <summary>
        /// Constructor for the class Comment
        /// </summary>
        void Comment(Comment _this);
    
        /// <summary>
        /// Constructor for the class Element
        /// </summary>
        void Element(Element _this);
    
        /// <summary>
        /// Constructor for the class Association
        /// </summary>
        void Association(Association _this);
    
        /// <summary>
        /// Constructor for the class AssociationInstance
        /// </summary>
        void AssociationInstance(AssociationInstance _this);
    
        /// <summary>
        /// Constructor for the class BehavioralFeature
        /// </summary>
        void BehavioralFeature(BehavioralFeature _this);
    
        /// <summary>
        /// Constructor for the class Classifier
        /// </summary>
        void Classifier(Classifier _this);
    
        /// <summary>
        /// Constructor for the class Class
        /// </summary>
        void Class(Class _this);
    
        /// <summary>
        /// Constructor for the class ClassInstance
        /// </summary>
        void ClassInstance(ClassInstance _this);
    
        /// <summary>
        /// Constructor for the class Constraint
        /// </summary>
        void Constraint(Constraint _this);
    
        /// <summary>
        /// Constructor for the class DataType
        /// </summary>
        void DataType(DataType _this);
    
        /// <summary>
        /// Constructor for the class Relationship
        /// </summary>
        void Relationship(Relationship _this);
    
        /// <summary>
        /// Constructor for the class DirectedRelationship
        /// </summary>
        void DirectedRelationship(DirectedRelationship _this);
    
        /// <summary>
        /// Constructor for the class Extent
        /// </summary>
        void Extent(Extent _this);
    
        /// <summary>
        /// Constructor for the class ExtentImplementation
        /// </summary>
        void ExtentImplementation(ExtentImplementation _this);
    
        /// <summary>
        /// Constructor for the class Feature
        /// </summary>
        void Feature(Feature _this);
    
        /// <summary>
        /// Constructor for the class Generalization
        /// </summary>
        void Generalization(Generalization _this);
    
        /// <summary>
        /// Constructor for the class IdentifierEntry
        /// </summary>
        void IdentifierEntry(IdentifierEntry _this);
    
        /// <summary>
        /// Constructor for the class LinkSlot
        /// </summary>
        void LinkSlot(LinkSlot _this);
    
        /// <summary>
        /// Constructor for the class MultiplicityElement
        /// </summary>
        void MultiplicityElement(MultiplicityElement _this);
    
        /// <summary>
        /// Constructor for the class NamedElement
        /// </summary>
        void NamedElement(NamedElement _this);
    
        /// <summary>
        /// Constructor for the class Namespace
        /// </summary>
        void Namespace(Namespace _this);
    
        /// <summary>
        /// Constructor for the class Operation
        /// </summary>
        void Operation(Operation _this);
    
        /// <summary>
        /// Constructor for the class PackageableElement
        /// </summary>
        void PackageableElement(PackageableElement _this);
    
        /// <summary>
        /// Constructor for the class Enumeration
        /// </summary>
        void Enumeration(Enumeration _this);
    
        /// <summary>
        /// Constructor for the class InstanceSpecification
        /// </summary>
        void InstanceSpecification(InstanceSpecification _this);
    
        /// <summary>
        /// Constructor for the class EnumerationLiteral
        /// </summary>
        void EnumerationLiteral(EnumerationLiteral _this);
    
        /// <summary>
        /// Constructor for the class Instance
        /// </summary>
        void Instance(Instance _this);
    
        /// <summary>
        /// Constructor for the class ElementInstance
        /// </summary>
        void ElementInstance(ElementInstance _this);
    
        /// <summary>
        /// Constructor for the class ObjectInstance
        /// </summary>
        void ObjectInstance(ObjectInstance _this);
    
        /// <summary>
        /// Constructor for the class Package
        /// </summary>
        void Package(Package _this);
    
        /// <summary>
        /// Constructor for the class PackageImport
        /// </summary>
        void PackageImport(PackageImport _this);
    
        /// <summary>
        /// Constructor for the class PackageMerge
        /// </summary>
        void PackageMerge(PackageMerge _this);
    
        /// <summary>
        /// Constructor for the class Parameter
        /// </summary>
        void Parameter(Parameter _this);
    
        /// <summary>
        /// Constructor for the class StructuralFeature
        /// </summary>
        void StructuralFeature(StructuralFeature _this);
    
        /// <summary>
        /// Constructor for the class Property
        /// </summary>
        void Property(Property _this);
    
        /// <summary>
        /// Constructor for the class Slot
        /// </summary>
        void Slot(Slot _this);
    
        /// <summary>
        /// Constructor for the class StructureSlot
        /// </summary>
        void StructureSlot(StructureSlot _this);
    
        /// <summary>
        /// Constructor for the class Tag
        /// </summary>
        void Tag(Tag _this);
    
        /// <summary>
        /// Constructor for the class Type
        /// </summary>
        void Type(Type _this);
    
        /// <summary>
        /// Constructor for the class PrimitiveType
        /// </summary>
        void PrimitiveType(PrimitiveType _this);
    
        /// <summary>
        /// Constructor for the class TypedElement
        /// </summary>
        void TypedElement(TypedElement _this);
    
        /// <summary>
        /// Constructor for the class ValueSpecification
        /// </summary>
        void ValueSpecification(ValueSpecification _this);
    
        /// <summary>
        /// Constructor for the class DataValue
        /// </summary>
        void DataValue(DataValue _this);
    
        /// <summary>
        /// Constructor for the class InstanceValue
        /// </summary>
        void InstanceValue(InstanceValue _this);
    
        /// <summary>
        /// Constructor for the class LiteralSpecification
        /// </summary>
        void LiteralSpecification(LiteralSpecification _this);
    
        /// <summary>
        /// Constructor for the class LiteralBoolean
        /// </summary>
        void LiteralBoolean(LiteralBoolean _this);
    
        /// <summary>
        /// Constructor for the class LiteralInteger
        /// </summary>
        void LiteralInteger(LiteralInteger _this);
    
        /// <summary>
        /// Constructor for the class LiteralNull
        /// </summary>
        void LiteralNull(LiteralNull _this);
    
        /// <summary>
        /// Constructor for the class LiteralReal
        /// </summary>
        void LiteralReal(LiteralReal _this);
    
        /// <summary>
        /// Constructor for the class LiteralString
        /// </summary>
        void LiteralString(LiteralString _this);
    
        /// <summary>
        /// Constructor for the class LiteralUnlimitedNatural
        /// </summary>
        void LiteralUnlimitedNatural(LiteralUnlimitedNatural _this);
    
        /// <summary>
        /// Constructor for the class OpaqueExpression
        /// </summary>
        void OpaqueExpression(OpaqueExpression _this);
    
        /// <summary>
        /// Constructor for the class PrimitiveDataValue
        /// </summary>
        void PrimitiveDataValue(PrimitiveDataValue _this);
    
    
        /// <summary>
        /// Computation of the derived property Class.SuperClass
        /// </summary>
        global::System.Collections.Generic.IList<Class> Class_SuperClass(Class _this);
    
        /// <summary>
        /// Computation of the derived property Relationship.RelatedElement
        /// </summary>
        global::System.Collections.Generic.IList<Element> Relationship_RelatedElement(Relationship _this);
    
        /// <summary>
        /// Computation of the derived property MultiplicityElement.Lower
        /// </summary>
        long MultiplicityElement_Lower(MultiplicityElement _this);
    
        /// <summary>
        /// Computation of the derived property MultiplicityElement.Upper
        /// </summary>
        long MultiplicityElement_Upper(MultiplicityElement _this);
    
        /// <summary>
        /// Computation of the derived property NamedElement.QualifiedName
        /// </summary>
        string NamedElement_QualifiedName(NamedElement _this);
    
        /// <summary>
        /// Computation of the derived property NamedElement.MemberNamespace
        /// </summary>
        Namespace NamedElement_MemberNamespace(NamedElement _this);
    
        /// <summary>
        /// Computation of the derived property Namespace.Member
        /// </summary>
        global::System.Collections.Generic.IList<NamedElement> Namespace_Member(Namespace _this);
    
        /// <summary>
        /// Computation of the derived property Operation.IsOrdered
        /// </summary>
        bool Operation_IsOrdered(Operation _this);
    
        /// <summary>
        /// Computation of the derived property Operation.IsUnique
        /// </summary>
        bool Operation_IsUnique(Operation _this);
    
        /// <summary>
        /// Computation of the derived property Operation.Lower
        /// </summary>
        long Operation_Lower(Operation _this);
    
        /// <summary>
        /// Computation of the derived property Operation.Upper
        /// </summary>
        long Operation_Upper(Operation _this);
    
        /// <summary>
        /// Computation of the derived property Property.Opposite
        /// </summary>
        Property Property_Opposite(Property _this);
    
        /// <summary>
        /// Computation of the derived property Property.Default
        /// </summary>
        string Property_Default(Property _this);
    
        /// <summary>
        /// Computation of the derived property Property.IsComposite
        /// </summary>
        bool Property_IsComposite(Property _this);
    
    
    }
}
