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

    public class MofModelFactory : __ModelFactory
    {
        public MofModelFactory(__Model model)
            : base(model, Mof.MInstance)
        {
        }
    
        internal MofModelFactory(__Model model, Mof metaModel)
            : base(model, metaModel)
        {
        }
    
        public Comment Comment(string? id = null)
        {
            return (Comment)Mof.CommentInfo.Create(Model, id)!;
        }
    
        public Association Association(string? id = null)
        {
            return (Association)Mof.AssociationInfo.Create(Model, id)!;
        }
    
        public AssociationInstance AssociationInstance(string? id = null)
        {
            return (AssociationInstance)Mof.AssociationInstanceInfo.Create(Model, id)!;
        }
    
        public Class Class(string? id = null)
        {
            return (Class)Mof.ClassInfo.Create(Model, id)!;
        }
    
        public ClassInstance ClassInstance(string? id = null)
        {
            return (ClassInstance)Mof.ClassInstanceInfo.Create(Model, id)!;
        }
    
        public Constraint Constraint(string? id = null)
        {
            return (Constraint)Mof.ConstraintInfo.Create(Model, id)!;
        }
    
        public DataType DataType(string? id = null)
        {
            return (DataType)Mof.DataTypeInfo.Create(Model, id)!;
        }
    
        public Extent Extent(string? id = null)
        {
            return (Extent)Mof.ExtentInfo.Create(Model, id)!;
        }
    
        public ExtentImplementation ExtentImplementation(string? id = null)
        {
            return (ExtentImplementation)Mof.ExtentImplementationInfo.Create(Model, id)!;
        }
    
        public Generalization Generalization(string? id = null)
        {
            return (Generalization)Mof.GeneralizationInfo.Create(Model, id)!;
        }
    
        public IdentifierEntry IdentifierEntry(string? id = null)
        {
            return (IdentifierEntry)Mof.IdentifierEntryInfo.Create(Model, id)!;
        }
    
        public LinkSlot LinkSlot(string? id = null)
        {
            return (LinkSlot)Mof.LinkSlotInfo.Create(Model, id)!;
        }
    
        public Operation Operation(string? id = null)
        {
            return (Operation)Mof.OperationInfo.Create(Model, id)!;
        }
    
        public Enumeration Enumeration(string? id = null)
        {
            return (Enumeration)Mof.EnumerationInfo.Create(Model, id)!;
        }
    
        public InstanceSpecification InstanceSpecification(string? id = null)
        {
            return (InstanceSpecification)Mof.InstanceSpecificationInfo.Create(Model, id)!;
        }
    
        public EnumerationLiteral EnumerationLiteral(string? id = null)
        {
            return (EnumerationLiteral)Mof.EnumerationLiteralInfo.Create(Model, id)!;
        }
    
        public Instance Instance(string? id = null)
        {
            return (Instance)Mof.InstanceInfo.Create(Model, id)!;
        }
    
        public ElementInstance ElementInstance(string? id = null)
        {
            return (ElementInstance)Mof.ElementInstanceInfo.Create(Model, id)!;
        }
    
        public ObjectInstance ObjectInstance(string? id = null)
        {
            return (ObjectInstance)Mof.ObjectInstanceInfo.Create(Model, id)!;
        }
    
        public Package Package(string? id = null)
        {
            return (Package)Mof.PackageInfo.Create(Model, id)!;
        }
    
        public PackageImport PackageImport(string? id = null)
        {
            return (PackageImport)Mof.PackageImportInfo.Create(Model, id)!;
        }
    
        public PackageMerge PackageMerge(string? id = null)
        {
            return (PackageMerge)Mof.PackageMergeInfo.Create(Model, id)!;
        }
    
        public Parameter Parameter(string? id = null)
        {
            return (Parameter)Mof.ParameterInfo.Create(Model, id)!;
        }
    
        public Property Property(string? id = null)
        {
            return (Property)Mof.PropertyInfo.Create(Model, id)!;
        }
    
        public Slot Slot(string? id = null)
        {
            return (Slot)Mof.SlotInfo.Create(Model, id)!;
        }
    
        public StructureSlot StructureSlot(string? id = null)
        {
            return (StructureSlot)Mof.StructureSlotInfo.Create(Model, id)!;
        }
    
        public Tag Tag(string? id = null)
        {
            return (Tag)Mof.TagInfo.Create(Model, id)!;
        }
    
        public PrimitiveType PrimitiveType(string? id = null)
        {
            return (PrimitiveType)Mof.PrimitiveTypeInfo.Create(Model, id)!;
        }
    
        public DataValue DataValue(string? id = null)
        {
            return (DataValue)Mof.DataValueInfo.Create(Model, id)!;
        }
    
        public InstanceValue InstanceValue(string? id = null)
        {
            return (InstanceValue)Mof.InstanceValueInfo.Create(Model, id)!;
        }
    
        public LiteralSpecification LiteralSpecification(string? id = null)
        {
            return (LiteralSpecification)Mof.LiteralSpecificationInfo.Create(Model, id)!;
        }
    
        public LiteralBoolean LiteralBoolean(string? id = null)
        {
            return (LiteralBoolean)Mof.LiteralBooleanInfo.Create(Model, id)!;
        }
    
        public LiteralInteger LiteralInteger(string? id = null)
        {
            return (LiteralInteger)Mof.LiteralIntegerInfo.Create(Model, id)!;
        }
    
        public LiteralNull LiteralNull(string? id = null)
        {
            return (LiteralNull)Mof.LiteralNullInfo.Create(Model, id)!;
        }
    
        public LiteralReal LiteralReal(string? id = null)
        {
            return (LiteralReal)Mof.LiteralRealInfo.Create(Model, id)!;
        }
    
        public LiteralString LiteralString(string? id = null)
        {
            return (LiteralString)Mof.LiteralStringInfo.Create(Model, id)!;
        }
    
        public LiteralUnlimitedNatural LiteralUnlimitedNatural(string? id = null)
        {
            return (LiteralUnlimitedNatural)Mof.LiteralUnlimitedNaturalInfo.Create(Model, id)!;
        }
    
        public OpaqueExpression OpaqueExpression(string? id = null)
        {
            return (OpaqueExpression)Mof.OpaqueExpressionInfo.Create(Model, id)!;
        }
    
        public PrimitiveDataValue PrimitiveDataValue(string? id = null)
        {
            return (PrimitiveDataValue)Mof.PrimitiveDataValueInfo.Create(Model, id)!;
        }
    
    }
    
    public class MofModelMultiFactory : __MultiModelFactory
    {
        public MofModelMultiFactory()
            : base(new __MetaModel[] { Mof.MInstance })
        {
        }
    
        public Comment Comment(__Model model, string? id = null)
        {
            return (Comment)Mof.CommentInfo.Create(model, id)!;
        }
    
        public Association Association(__Model model, string? id = null)
        {
            return (Association)Mof.AssociationInfo.Create(model, id)!;
        }
    
        public AssociationInstance AssociationInstance(__Model model, string? id = null)
        {
            return (AssociationInstance)Mof.AssociationInstanceInfo.Create(model, id)!;
        }
    
        public Class Class(__Model model, string? id = null)
        {
            return (Class)Mof.ClassInfo.Create(model, id)!;
        }
    
        public ClassInstance ClassInstance(__Model model, string? id = null)
        {
            return (ClassInstance)Mof.ClassInstanceInfo.Create(model, id)!;
        }
    
        public Constraint Constraint(__Model model, string? id = null)
        {
            return (Constraint)Mof.ConstraintInfo.Create(model, id)!;
        }
    
        public DataType DataType(__Model model, string? id = null)
        {
            return (DataType)Mof.DataTypeInfo.Create(model, id)!;
        }
    
        public Extent Extent(__Model model, string? id = null)
        {
            return (Extent)Mof.ExtentInfo.Create(model, id)!;
        }
    
        public ExtentImplementation ExtentImplementation(__Model model, string? id = null)
        {
            return (ExtentImplementation)Mof.ExtentImplementationInfo.Create(model, id)!;
        }
    
        public Generalization Generalization(__Model model, string? id = null)
        {
            return (Generalization)Mof.GeneralizationInfo.Create(model, id)!;
        }
    
        public IdentifierEntry IdentifierEntry(__Model model, string? id = null)
        {
            return (IdentifierEntry)Mof.IdentifierEntryInfo.Create(model, id)!;
        }
    
        public LinkSlot LinkSlot(__Model model, string? id = null)
        {
            return (LinkSlot)Mof.LinkSlotInfo.Create(model, id)!;
        }
    
        public Operation Operation(__Model model, string? id = null)
        {
            return (Operation)Mof.OperationInfo.Create(model, id)!;
        }
    
        public Enumeration Enumeration(__Model model, string? id = null)
        {
            return (Enumeration)Mof.EnumerationInfo.Create(model, id)!;
        }
    
        public InstanceSpecification InstanceSpecification(__Model model, string? id = null)
        {
            return (InstanceSpecification)Mof.InstanceSpecificationInfo.Create(model, id)!;
        }
    
        public EnumerationLiteral EnumerationLiteral(__Model model, string? id = null)
        {
            return (EnumerationLiteral)Mof.EnumerationLiteralInfo.Create(model, id)!;
        }
    
        public Instance Instance(__Model model, string? id = null)
        {
            return (Instance)Mof.InstanceInfo.Create(model, id)!;
        }
    
        public ElementInstance ElementInstance(__Model model, string? id = null)
        {
            return (ElementInstance)Mof.ElementInstanceInfo.Create(model, id)!;
        }
    
        public ObjectInstance ObjectInstance(__Model model, string? id = null)
        {
            return (ObjectInstance)Mof.ObjectInstanceInfo.Create(model, id)!;
        }
    
        public Package Package(__Model model, string? id = null)
        {
            return (Package)Mof.PackageInfo.Create(model, id)!;
        }
    
        public PackageImport PackageImport(__Model model, string? id = null)
        {
            return (PackageImport)Mof.PackageImportInfo.Create(model, id)!;
        }
    
        public PackageMerge PackageMerge(__Model model, string? id = null)
        {
            return (PackageMerge)Mof.PackageMergeInfo.Create(model, id)!;
        }
    
        public Parameter Parameter(__Model model, string? id = null)
        {
            return (Parameter)Mof.ParameterInfo.Create(model, id)!;
        }
    
        public Property Property(__Model model, string? id = null)
        {
            return (Property)Mof.PropertyInfo.Create(model, id)!;
        }
    
        public Slot Slot(__Model model, string? id = null)
        {
            return (Slot)Mof.SlotInfo.Create(model, id)!;
        }
    
        public StructureSlot StructureSlot(__Model model, string? id = null)
        {
            return (StructureSlot)Mof.StructureSlotInfo.Create(model, id)!;
        }
    
        public Tag Tag(__Model model, string? id = null)
        {
            return (Tag)Mof.TagInfo.Create(model, id)!;
        }
    
        public PrimitiveType PrimitiveType(__Model model, string? id = null)
        {
            return (PrimitiveType)Mof.PrimitiveTypeInfo.Create(model, id)!;
        }
    
        public DataValue DataValue(__Model model, string? id = null)
        {
            return (DataValue)Mof.DataValueInfo.Create(model, id)!;
        }
    
        public InstanceValue InstanceValue(__Model model, string? id = null)
        {
            return (InstanceValue)Mof.InstanceValueInfo.Create(model, id)!;
        }
    
        public LiteralSpecification LiteralSpecification(__Model model, string? id = null)
        {
            return (LiteralSpecification)Mof.LiteralSpecificationInfo.Create(model, id)!;
        }
    
        public LiteralBoolean LiteralBoolean(__Model model, string? id = null)
        {
            return (LiteralBoolean)Mof.LiteralBooleanInfo.Create(model, id)!;
        }
    
        public LiteralInteger LiteralInteger(__Model model, string? id = null)
        {
            return (LiteralInteger)Mof.LiteralIntegerInfo.Create(model, id)!;
        }
    
        public LiteralNull LiteralNull(__Model model, string? id = null)
        {
            return (LiteralNull)Mof.LiteralNullInfo.Create(model, id)!;
        }
    
        public LiteralReal LiteralReal(__Model model, string? id = null)
        {
            return (LiteralReal)Mof.LiteralRealInfo.Create(model, id)!;
        }
    
        public LiteralString LiteralString(__Model model, string? id = null)
        {
            return (LiteralString)Mof.LiteralStringInfo.Create(model, id)!;
        }
    
        public LiteralUnlimitedNatural LiteralUnlimitedNatural(__Model model, string? id = null)
        {
            return (LiteralUnlimitedNatural)Mof.LiteralUnlimitedNaturalInfo.Create(model, id)!;
        }
    
        public OpaqueExpression OpaqueExpression(__Model model, string? id = null)
        {
            return (OpaqueExpression)Mof.OpaqueExpressionInfo.Create(model, id)!;
        }
    
        public PrimitiveDataValue PrimitiveDataValue(__Model model, string? id = null)
        {
            return (PrimitiveDataValue)Mof.PrimitiveDataValueInfo.Create(model, id)!;
        }
    
    }
}
