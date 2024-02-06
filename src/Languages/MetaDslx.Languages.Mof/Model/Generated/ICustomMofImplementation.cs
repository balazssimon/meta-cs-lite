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
    
        void Comment(Comment _this);
    
        void Element(Element _this);
    
        void Association(Association _this);
    
        void AssociationInstance(AssociationInstance _this);
    
        void BehavioralFeature(BehavioralFeature _this);
    
        void Classifier(Classifier _this);
    
        void Class(Class _this);
    
        void ClassInstance(ClassInstance _this);
    
        void Constraint(Constraint _this);
    
        void DataType(DataType _this);
    
        void Relationship(Relationship _this);
    
        void DirectedRelationship(DirectedRelationship _this);
    
        void Extent(Extent _this);
    
        void ExtentImplementation(ExtentImplementation _this);
    
        void Feature(Feature _this);
    
        void Generalization(Generalization _this);
    
        void IdentifierEntry(IdentifierEntry _this);
    
        void LinkSlot(LinkSlot _this);
    
        void MultiplicityElement(MultiplicityElement _this);
    
        void NamedElement(NamedElement _this);
    
        void Namespace(Namespace _this);
    
        void Operation(Operation _this);
    
        void PackageableElement(PackageableElement _this);
    
        void Enumeration(Enumeration _this);
    
        void InstanceSpecification(InstanceSpecification _this);
    
        void EnumerationLiteral(EnumerationLiteral _this);
    
        void Instance(Instance _this);
    
        void ElementInstance(ElementInstance _this);
    
        void ObjectInstance(ObjectInstance _this);
    
        void Package(Package _this);
    
        void PackageImport(PackageImport _this);
    
        void PackageMerge(PackageMerge _this);
    
        void Parameter(Parameter _this);
    
        void StructuralFeature(StructuralFeature _this);
    
        void Property(Property _this);
    
        void Slot(Slot _this);
    
        void StructureSlot(StructureSlot _this);
    
        void Tag(Tag _this);
    
        void Type(Type _this);
    
        void PrimitiveType(PrimitiveType _this);
    
        void TypedElement(TypedElement _this);
    
        void ValueSpecification(ValueSpecification _this);
    
        void DataValue(DataValue _this);
    
        void InstanceValue(InstanceValue _this);
    
        void LiteralSpecification(LiteralSpecification _this);
    
        void LiteralBoolean(LiteralBoolean _this);
    
        void LiteralInteger(LiteralInteger _this);
    
        void LiteralNull(LiteralNull _this);
    
        void LiteralReal(LiteralReal _this);
    
        void LiteralString(LiteralString _this);
    
        void LiteralUnlimitedNatural(LiteralUnlimitedNatural _this);
    
        void OpaqueExpression(OpaqueExpression _this);
    
        void PrimitiveDataValue(PrimitiveDataValue _this);
    
    
        global::System.Collections.Generic.IList<Class> Class_SuperClass(Class _this);
    
        global::System.Collections.Generic.IList<Element> Relationship_RelatedElement(Relationship _this);
    
        long MultiplicityElement_Lower(MultiplicityElement _this);
    
        long MultiplicityElement_Upper(MultiplicityElement _this);
    
        string NamedElement_QualifiedName(NamedElement _this);
    
        Namespace NamedElement_MemberNamespace(NamedElement _this);
    
        global::System.Collections.Generic.IList<NamedElement> Namespace_Member(Namespace _this);
    
        bool Operation_IsOrdered(Operation _this);
    
        bool Operation_IsUnique(Operation _this);
    
        long Operation_Lower(Operation _this);
    
        long Operation_Upper(Operation _this);
    
        Property Property_Opposite(Property _this);
    
        string Property_Default(Property _this);
    
        bool Property_IsComposite(Property _this);
    
    
    }
}
