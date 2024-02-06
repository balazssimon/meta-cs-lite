#nullable enable

namespace MetaDslx.Languages.Uml.Model
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

    public class UmlModelFactory : __ModelFactory
    {
        public UmlModelFactory(__Model model)
            : base(model, Uml.MInstance)
        {
        }
    
        internal UmlModelFactory(__Model model, Uml metaModel)
            : base(model, metaModel)
        {
        }
    
        public Abstraction Abstraction(string? id = null)
        {
            return (Abstraction)Uml.AbstractionInfo.Create(base.Model, id)!;
        }
    
        public AcceptEventAction AcceptEventAction(string? id = null)
        {
            return (AcceptEventAction)Uml.AcceptEventActionInfo.Create(base.Model, id)!;
        }
    
        public AcceptCallAction AcceptCallAction(string? id = null)
        {
            return (AcceptCallAction)Uml.AcceptCallActionInfo.Create(base.Model, id)!;
        }
    
        public ActionExecutionSpecification ActionExecutionSpecification(string? id = null)
        {
            return (ActionExecutionSpecification)Uml.ActionExecutionSpecificationInfo.Create(base.Model, id)!;
        }
    
        public ActionInputPin ActionInputPin(string? id = null)
        {
            return (ActionInputPin)Uml.ActionInputPinInfo.Create(base.Model, id)!;
        }
    
        public Class Class(string? id = null)
        {
            return (Class)Uml.ClassInfo.Create(base.Model, id)!;
        }
    
        public Activity Activity(string? id = null)
        {
            return (Activity)Uml.ActivityInfo.Create(base.Model, id)!;
        }
    
        public ActivityFinalNode ActivityFinalNode(string? id = null)
        {
            return (ActivityFinalNode)Uml.ActivityFinalNodeInfo.Create(base.Model, id)!;
        }
    
        public ActivityParameterNode ActivityParameterNode(string? id = null)
        {
            return (ActivityParameterNode)Uml.ActivityParameterNodeInfo.Create(base.Model, id)!;
        }
    
        public ActivityPartition ActivityPartition(string? id = null)
        {
            return (ActivityPartition)Uml.ActivityPartitionInfo.Create(base.Model, id)!;
        }
    
        public Actor Actor(string? id = null)
        {
            return (Actor)Uml.ActorInfo.Create(base.Model, id)!;
        }
    
        public AddStructuralFeatureValueAction AddStructuralFeatureValueAction(string? id = null)
        {
            return (AddStructuralFeatureValueAction)Uml.AddStructuralFeatureValueActionInfo.Create(base.Model, id)!;
        }
    
        public AddVariableValueAction AddVariableValueAction(string? id = null)
        {
            return (AddVariableValueAction)Uml.AddVariableValueActionInfo.Create(base.Model, id)!;
        }
    
        public AnyReceiveEvent AnyReceiveEvent(string? id = null)
        {
            return (AnyReceiveEvent)Uml.AnyReceiveEventInfo.Create(base.Model, id)!;
        }
    
        public Association Association(string? id = null)
        {
            return (Association)Uml.AssociationInfo.Create(base.Model, id)!;
        }
    
        public AssociationClass AssociationClass(string? id = null)
        {
            return (AssociationClass)Uml.AssociationClassInfo.Create(base.Model, id)!;
        }
    
        public BehaviorExecutionSpecification BehaviorExecutionSpecification(string? id = null)
        {
            return (BehaviorExecutionSpecification)Uml.BehaviorExecutionSpecificationInfo.Create(base.Model, id)!;
        }
    
        public BroadcastSignalAction BroadcastSignalAction(string? id = null)
        {
            return (BroadcastSignalAction)Uml.BroadcastSignalActionInfo.Create(base.Model, id)!;
        }
    
        public CallBehaviorAction CallBehaviorAction(string? id = null)
        {
            return (CallBehaviorAction)Uml.CallBehaviorActionInfo.Create(base.Model, id)!;
        }
    
        public CallEvent CallEvent(string? id = null)
        {
            return (CallEvent)Uml.CallEventInfo.Create(base.Model, id)!;
        }
    
        public CallOperationAction CallOperationAction(string? id = null)
        {
            return (CallOperationAction)Uml.CallOperationActionInfo.Create(base.Model, id)!;
        }
    
        public CentralBufferNode CentralBufferNode(string? id = null)
        {
            return (CentralBufferNode)Uml.CentralBufferNodeInfo.Create(base.Model, id)!;
        }
    
        public ChangeEvent ChangeEvent(string? id = null)
        {
            return (ChangeEvent)Uml.ChangeEventInfo.Create(base.Model, id)!;
        }
    
        public ClassifierTemplateParameter ClassifierTemplateParameter(string? id = null)
        {
            return (ClassifierTemplateParameter)Uml.ClassifierTemplateParameterInfo.Create(base.Model, id)!;
        }
    
        public Clause Clause(string? id = null)
        {
            return (Clause)Uml.ClauseInfo.Create(base.Model, id)!;
        }
    
        public ClearAssociationAction ClearAssociationAction(string? id = null)
        {
            return (ClearAssociationAction)Uml.ClearAssociationActionInfo.Create(base.Model, id)!;
        }
    
        public ClearStructuralFeatureAction ClearStructuralFeatureAction(string? id = null)
        {
            return (ClearStructuralFeatureAction)Uml.ClearStructuralFeatureActionInfo.Create(base.Model, id)!;
        }
    
        public ClearVariableAction ClearVariableAction(string? id = null)
        {
            return (ClearVariableAction)Uml.ClearVariableActionInfo.Create(base.Model, id)!;
        }
    
        public Collaboration Collaboration(string? id = null)
        {
            return (Collaboration)Uml.CollaborationInfo.Create(base.Model, id)!;
        }
    
        public CollaborationUse CollaborationUse(string? id = null)
        {
            return (CollaborationUse)Uml.CollaborationUseInfo.Create(base.Model, id)!;
        }
    
        public CombinedFragment CombinedFragment(string? id = null)
        {
            return (CombinedFragment)Uml.CombinedFragmentInfo.Create(base.Model, id)!;
        }
    
        public Comment Comment(string? id = null)
        {
            return (Comment)Uml.CommentInfo.Create(base.Model, id)!;
        }
    
        public CommunicationPath CommunicationPath(string? id = null)
        {
            return (CommunicationPath)Uml.CommunicationPathInfo.Create(base.Model, id)!;
        }
    
        public Component Component(string? id = null)
        {
            return (Component)Uml.ComponentInfo.Create(base.Model, id)!;
        }
    
        public ComponentRealization ComponentRealization(string? id = null)
        {
            return (ComponentRealization)Uml.ComponentRealizationInfo.Create(base.Model, id)!;
        }
    
        public ConditionalNode ConditionalNode(string? id = null)
        {
            return (ConditionalNode)Uml.ConditionalNodeInfo.Create(base.Model, id)!;
        }
    
        public ConnectableElementTemplateParameter ConnectableElementTemplateParameter(string? id = null)
        {
            return (ConnectableElementTemplateParameter)Uml.ConnectableElementTemplateParameterInfo.Create(base.Model, id)!;
        }
    
        public ConnectionPointReference ConnectionPointReference(string? id = null)
        {
            return (ConnectionPointReference)Uml.ConnectionPointReferenceInfo.Create(base.Model, id)!;
        }
    
        public Connector Connector(string? id = null)
        {
            return (Connector)Uml.ConnectorInfo.Create(base.Model, id)!;
        }
    
        public ConnectorEnd ConnectorEnd(string? id = null)
        {
            return (ConnectorEnd)Uml.ConnectorEndInfo.Create(base.Model, id)!;
        }
    
        public ConsiderIgnoreFragment ConsiderIgnoreFragment(string? id = null)
        {
            return (ConsiderIgnoreFragment)Uml.ConsiderIgnoreFragmentInfo.Create(base.Model, id)!;
        }
    
        public Constraint Constraint(string? id = null)
        {
            return (Constraint)Uml.ConstraintInfo.Create(base.Model, id)!;
        }
    
        public Continuation Continuation(string? id = null)
        {
            return (Continuation)Uml.ContinuationInfo.Create(base.Model, id)!;
        }
    
        public ControlFlow ControlFlow(string? id = null)
        {
            return (ControlFlow)Uml.ControlFlowInfo.Create(base.Model, id)!;
        }
    
        public CreateLinkAction CreateLinkAction(string? id = null)
        {
            return (CreateLinkAction)Uml.CreateLinkActionInfo.Create(base.Model, id)!;
        }
    
        public CreateLinkObjectAction CreateLinkObjectAction(string? id = null)
        {
            return (CreateLinkObjectAction)Uml.CreateLinkObjectActionInfo.Create(base.Model, id)!;
        }
    
        public CreateObjectAction CreateObjectAction(string? id = null)
        {
            return (CreateObjectAction)Uml.CreateObjectActionInfo.Create(base.Model, id)!;
        }
    
        public DataStoreNode DataStoreNode(string? id = null)
        {
            return (DataStoreNode)Uml.DataStoreNodeInfo.Create(base.Model, id)!;
        }
    
        public DataType DataType(string? id = null)
        {
            return (DataType)Uml.DataTypeInfo.Create(base.Model, id)!;
        }
    
        public DecisionNode DecisionNode(string? id = null)
        {
            return (DecisionNode)Uml.DecisionNodeInfo.Create(base.Model, id)!;
        }
    
        public Dependency Dependency(string? id = null)
        {
            return (Dependency)Uml.DependencyInfo.Create(base.Model, id)!;
        }
    
        public DestroyLinkAction DestroyLinkAction(string? id = null)
        {
            return (DestroyLinkAction)Uml.DestroyLinkActionInfo.Create(base.Model, id)!;
        }
    
        public DestroyObjectAction DestroyObjectAction(string? id = null)
        {
            return (DestroyObjectAction)Uml.DestroyObjectActionInfo.Create(base.Model, id)!;
        }
    
        public DestructionOccurrenceSpecification DestructionOccurrenceSpecification(string? id = null)
        {
            return (DestructionOccurrenceSpecification)Uml.DestructionOccurrenceSpecificationInfo.Create(base.Model, id)!;
        }
    
        public ElementImport ElementImport(string? id = null)
        {
            return (ElementImport)Uml.ElementImportInfo.Create(base.Model, id)!;
        }
    
        public ExceptionHandler ExceptionHandler(string? id = null)
        {
            return (ExceptionHandler)Uml.ExceptionHandlerInfo.Create(base.Model, id)!;
        }
    
        public ExecutionOccurrenceSpecification ExecutionOccurrenceSpecification(string? id = null)
        {
            return (ExecutionOccurrenceSpecification)Uml.ExecutionOccurrenceSpecificationInfo.Create(base.Model, id)!;
        }
    
        public ExpansionNode ExpansionNode(string? id = null)
        {
            return (ExpansionNode)Uml.ExpansionNodeInfo.Create(base.Model, id)!;
        }
    
        public ExpansionRegion ExpansionRegion(string? id = null)
        {
            return (ExpansionRegion)Uml.ExpansionRegionInfo.Create(base.Model, id)!;
        }
    
        public Extend Extend(string? id = null)
        {
            return (Extend)Uml.ExtendInfo.Create(base.Model, id)!;
        }
    
        public ExtensionEnd ExtensionEnd(string? id = null)
        {
            return (ExtensionEnd)Uml.ExtensionEndInfo.Create(base.Model, id)!;
        }
    
        public ExtensionPoint ExtensionPoint(string? id = null)
        {
            return (ExtensionPoint)Uml.ExtensionPointInfo.Create(base.Model, id)!;
        }
    
        public FinalState FinalState(string? id = null)
        {
            return (FinalState)Uml.FinalStateInfo.Create(base.Model, id)!;
        }
    
        public FlowFinalNode FlowFinalNode(string? id = null)
        {
            return (FlowFinalNode)Uml.FlowFinalNodeInfo.Create(base.Model, id)!;
        }
    
        public ForkNode ForkNode(string? id = null)
        {
            return (ForkNode)Uml.ForkNodeInfo.Create(base.Model, id)!;
        }
    
        public Gate Gate(string? id = null)
        {
            return (Gate)Uml.GateInfo.Create(base.Model, id)!;
        }
    
        public Generalization Generalization(string? id = null)
        {
            return (Generalization)Uml.GeneralizationInfo.Create(base.Model, id)!;
        }
    
        public GeneralOrdering GeneralOrdering(string? id = null)
        {
            return (GeneralOrdering)Uml.GeneralOrderingInfo.Create(base.Model, id)!;
        }
    
        public Image Image(string? id = null)
        {
            return (Image)Uml.ImageInfo.Create(base.Model, id)!;
        }
    
        public Include Include(string? id = null)
        {
            return (Include)Uml.IncludeInfo.Create(base.Model, id)!;
        }
    
        public InitialNode InitialNode(string? id = null)
        {
            return (InitialNode)Uml.InitialNodeInfo.Create(base.Model, id)!;
        }
    
        public InputPin InputPin(string? id = null)
        {
            return (InputPin)Uml.InputPinInfo.Create(base.Model, id)!;
        }
    
        public Artifact Artifact(string? id = null)
        {
            return (Artifact)Uml.ArtifactInfo.Create(base.Model, id)!;
        }
    
        public Deployment Deployment(string? id = null)
        {
            return (Deployment)Uml.DeploymentInfo.Create(base.Model, id)!;
        }
    
        public DeploymentSpecification DeploymentSpecification(string? id = null)
        {
            return (DeploymentSpecification)Uml.DeploymentSpecificationInfo.Create(base.Model, id)!;
        }
    
        public Duration Duration(string? id = null)
        {
            return (Duration)Uml.DurationInfo.Create(base.Model, id)!;
        }
    
        public DurationConstraint DurationConstraint(string? id = null)
        {
            return (DurationConstraint)Uml.DurationConstraintInfo.Create(base.Model, id)!;
        }
    
        public DurationInterval DurationInterval(string? id = null)
        {
            return (DurationInterval)Uml.DurationIntervalInfo.Create(base.Model, id)!;
        }
    
        public DurationObservation DurationObservation(string? id = null)
        {
            return (DurationObservation)Uml.DurationObservationInfo.Create(base.Model, id)!;
        }
    
        public Device Device(string? id = null)
        {
            return (Device)Uml.DeviceInfo.Create(base.Model, id)!;
        }
    
        public Enumeration Enumeration(string? id = null)
        {
            return (Enumeration)Uml.EnumerationInfo.Create(base.Model, id)!;
        }
    
        public EnumerationLiteral EnumerationLiteral(string? id = null)
        {
            return (EnumerationLiteral)Uml.EnumerationLiteralInfo.Create(base.Model, id)!;
        }
    
        public ExecutionEnvironment ExecutionEnvironment(string? id = null)
        {
            return (ExecutionEnvironment)Uml.ExecutionEnvironmentInfo.Create(base.Model, id)!;
        }
    
        public Expression Expression(string? id = null)
        {
            return (Expression)Uml.ExpressionInfo.Create(base.Model, id)!;
        }
    
        public Extension Extension(string? id = null)
        {
            return (Extension)Uml.ExtensionInfo.Create(base.Model, id)!;
        }
    
        public FunctionBehavior FunctionBehavior(string? id = null)
        {
            return (FunctionBehavior)Uml.FunctionBehaviorInfo.Create(base.Model, id)!;
        }
    
        public GeneralizationSet GeneralizationSet(string? id = null)
        {
            return (GeneralizationSet)Uml.GeneralizationSetInfo.Create(base.Model, id)!;
        }
    
        public InformationFlow InformationFlow(string? id = null)
        {
            return (InformationFlow)Uml.InformationFlowInfo.Create(base.Model, id)!;
        }
    
        public InformationItem InformationItem(string? id = null)
        {
            return (InformationItem)Uml.InformationItemInfo.Create(base.Model, id)!;
        }
    
        public InstanceSpecification InstanceSpecification(string? id = null)
        {
            return (InstanceSpecification)Uml.InstanceSpecificationInfo.Create(base.Model, id)!;
        }
    
        public InstanceValue InstanceValue(string? id = null)
        {
            return (InstanceValue)Uml.InstanceValueInfo.Create(base.Model, id)!;
        }
    
        public Interaction Interaction(string? id = null)
        {
            return (Interaction)Uml.InteractionInfo.Create(base.Model, id)!;
        }
    
        public InteractionConstraint InteractionConstraint(string? id = null)
        {
            return (InteractionConstraint)Uml.InteractionConstraintInfo.Create(base.Model, id)!;
        }
    
        public InteractionOperand InteractionOperand(string? id = null)
        {
            return (InteractionOperand)Uml.InteractionOperandInfo.Create(base.Model, id)!;
        }
    
        public InteractionUse InteractionUse(string? id = null)
        {
            return (InteractionUse)Uml.InteractionUseInfo.Create(base.Model, id)!;
        }
    
        public Interface Interface(string? id = null)
        {
            return (Interface)Uml.InterfaceInfo.Create(base.Model, id)!;
        }
    
        public InterfaceRealization InterfaceRealization(string? id = null)
        {
            return (InterfaceRealization)Uml.InterfaceRealizationInfo.Create(base.Model, id)!;
        }
    
        public InterruptibleActivityRegion InterruptibleActivityRegion(string? id = null)
        {
            return (InterruptibleActivityRegion)Uml.InterruptibleActivityRegionInfo.Create(base.Model, id)!;
        }
    
        public Interval Interval(string? id = null)
        {
            return (Interval)Uml.IntervalInfo.Create(base.Model, id)!;
        }
    
        public IntervalConstraint IntervalConstraint(string? id = null)
        {
            return (IntervalConstraint)Uml.IntervalConstraintInfo.Create(base.Model, id)!;
        }
    
        public JoinNode JoinNode(string? id = null)
        {
            return (JoinNode)Uml.JoinNodeInfo.Create(base.Model, id)!;
        }
    
        public Lifeline Lifeline(string? id = null)
        {
            return (Lifeline)Uml.LifelineInfo.Create(base.Model, id)!;
        }
    
        public LinkEndData LinkEndData(string? id = null)
        {
            return (LinkEndData)Uml.LinkEndDataInfo.Create(base.Model, id)!;
        }
    
        public LinkEndCreationData LinkEndCreationData(string? id = null)
        {
            return (LinkEndCreationData)Uml.LinkEndCreationDataInfo.Create(base.Model, id)!;
        }
    
        public LinkEndDestructionData LinkEndDestructionData(string? id = null)
        {
            return (LinkEndDestructionData)Uml.LinkEndDestructionDataInfo.Create(base.Model, id)!;
        }
    
        public LiteralBoolean LiteralBoolean(string? id = null)
        {
            return (LiteralBoolean)Uml.LiteralBooleanInfo.Create(base.Model, id)!;
        }
    
        public LiteralInteger LiteralInteger(string? id = null)
        {
            return (LiteralInteger)Uml.LiteralIntegerInfo.Create(base.Model, id)!;
        }
    
        public LiteralNull LiteralNull(string? id = null)
        {
            return (LiteralNull)Uml.LiteralNullInfo.Create(base.Model, id)!;
        }
    
        public LiteralReal LiteralReal(string? id = null)
        {
            return (LiteralReal)Uml.LiteralRealInfo.Create(base.Model, id)!;
        }
    
        public LiteralString LiteralString(string? id = null)
        {
            return (LiteralString)Uml.LiteralStringInfo.Create(base.Model, id)!;
        }
    
        public LiteralUnlimitedNatural LiteralUnlimitedNatural(string? id = null)
        {
            return (LiteralUnlimitedNatural)Uml.LiteralUnlimitedNaturalInfo.Create(base.Model, id)!;
        }
    
        public LoopNode LoopNode(string? id = null)
        {
            return (LoopNode)Uml.LoopNodeInfo.Create(base.Model, id)!;
        }
    
        public Manifestation Manifestation(string? id = null)
        {
            return (Manifestation)Uml.ManifestationInfo.Create(base.Model, id)!;
        }
    
        public MergeNode MergeNode(string? id = null)
        {
            return (MergeNode)Uml.MergeNodeInfo.Create(base.Model, id)!;
        }
    
        public Message Message(string? id = null)
        {
            return (Message)Uml.MessageInfo.Create(base.Model, id)!;
        }
    
        public Model Model(string? id = null)
        {
            return (Model)Uml.ModelInfo.Create(base.Model, id)!;
        }
    
        public Node Node(string? id = null)
        {
            return (Node)Uml.NodeInfo.Create(base.Model, id)!;
        }
    
        public ObjectFlow ObjectFlow(string? id = null)
        {
            return (ObjectFlow)Uml.ObjectFlowInfo.Create(base.Model, id)!;
        }
    
        public OccurrenceSpecification OccurrenceSpecification(string? id = null)
        {
            return (OccurrenceSpecification)Uml.OccurrenceSpecificationInfo.Create(base.Model, id)!;
        }
    
        public MessageOccurrenceSpecification MessageOccurrenceSpecification(string? id = null)
        {
            return (MessageOccurrenceSpecification)Uml.MessageOccurrenceSpecificationInfo.Create(base.Model, id)!;
        }
    
        public OpaqueExpression OpaqueExpression(string? id = null)
        {
            return (OpaqueExpression)Uml.OpaqueExpressionInfo.Create(base.Model, id)!;
        }
    
        public OperationTemplateParameter OperationTemplateParameter(string? id = null)
        {
            return (OperationTemplateParameter)Uml.OperationTemplateParameterInfo.Create(base.Model, id)!;
        }
    
        public Package Package(string? id = null)
        {
            return (Package)Uml.PackageInfo.Create(base.Model, id)!;
        }
    
        public PackageImport PackageImport(string? id = null)
        {
            return (PackageImport)Uml.PackageImportInfo.Create(base.Model, id)!;
        }
    
        public PackageMerge PackageMerge(string? id = null)
        {
            return (PackageMerge)Uml.PackageMergeInfo.Create(base.Model, id)!;
        }
    
        public Parameter Parameter(string? id = null)
        {
            return (Parameter)Uml.ParameterInfo.Create(base.Model, id)!;
        }
    
        public ParameterSet ParameterSet(string? id = null)
        {
            return (ParameterSet)Uml.ParameterSetInfo.Create(base.Model, id)!;
        }
    
        public PartDecomposition PartDecomposition(string? id = null)
        {
            return (PartDecomposition)Uml.PartDecompositionInfo.Create(base.Model, id)!;
        }
    
        public OpaqueAction OpaqueAction(string? id = null)
        {
            return (OpaqueAction)Uml.OpaqueActionInfo.Create(base.Model, id)!;
        }
    
        public OpaqueBehavior OpaqueBehavior(string? id = null)
        {
            return (OpaqueBehavior)Uml.OpaqueBehaviorInfo.Create(base.Model, id)!;
        }
    
        public Operation Operation(string? id = null)
        {
            return (Operation)Uml.OperationInfo.Create(base.Model, id)!;
        }
    
        public OutputPin OutputPin(string? id = null)
        {
            return (OutputPin)Uml.OutputPinInfo.Create(base.Model, id)!;
        }
    
        public Property Property(string? id = null)
        {
            return (Property)Uml.PropertyInfo.Create(base.Model, id)!;
        }
    
        public Port Port(string? id = null)
        {
            return (Port)Uml.PortInfo.Create(base.Model, id)!;
        }
    
        public PrimitiveType PrimitiveType(string? id = null)
        {
            return (PrimitiveType)Uml.PrimitiveTypeInfo.Create(base.Model, id)!;
        }
    
        public Profile Profile(string? id = null)
        {
            return (Profile)Uml.ProfileInfo.Create(base.Model, id)!;
        }
    
        public ProfileApplication ProfileApplication(string? id = null)
        {
            return (ProfileApplication)Uml.ProfileApplicationInfo.Create(base.Model, id)!;
        }
    
        public ProtocolConformance ProtocolConformance(string? id = null)
        {
            return (ProtocolConformance)Uml.ProtocolConformanceInfo.Create(base.Model, id)!;
        }
    
        public ProtocolStateMachine ProtocolStateMachine(string? id = null)
        {
            return (ProtocolStateMachine)Uml.ProtocolStateMachineInfo.Create(base.Model, id)!;
        }
    
        public ProtocolTransition ProtocolTransition(string? id = null)
        {
            return (ProtocolTransition)Uml.ProtocolTransitionInfo.Create(base.Model, id)!;
        }
    
        public Pseudostate Pseudostate(string? id = null)
        {
            return (Pseudostate)Uml.PseudostateInfo.Create(base.Model, id)!;
        }
    
        public QualifierValue QualifierValue(string? id = null)
        {
            return (QualifierValue)Uml.QualifierValueInfo.Create(base.Model, id)!;
        }
    
        public RaiseExceptionAction RaiseExceptionAction(string? id = null)
        {
            return (RaiseExceptionAction)Uml.RaiseExceptionActionInfo.Create(base.Model, id)!;
        }
    
        public ReadExtentAction ReadExtentAction(string? id = null)
        {
            return (ReadExtentAction)Uml.ReadExtentActionInfo.Create(base.Model, id)!;
        }
    
        public ReadIsClassifiedObjectAction ReadIsClassifiedObjectAction(string? id = null)
        {
            return (ReadIsClassifiedObjectAction)Uml.ReadIsClassifiedObjectActionInfo.Create(base.Model, id)!;
        }
    
        public ReadLinkAction ReadLinkAction(string? id = null)
        {
            return (ReadLinkAction)Uml.ReadLinkActionInfo.Create(base.Model, id)!;
        }
    
        public ReadLinkObjectEndAction ReadLinkObjectEndAction(string? id = null)
        {
            return (ReadLinkObjectEndAction)Uml.ReadLinkObjectEndActionInfo.Create(base.Model, id)!;
        }
    
        public ReadLinkObjectEndQualifierAction ReadLinkObjectEndQualifierAction(string? id = null)
        {
            return (ReadLinkObjectEndQualifierAction)Uml.ReadLinkObjectEndQualifierActionInfo.Create(base.Model, id)!;
        }
    
        public ReadSelfAction ReadSelfAction(string? id = null)
        {
            return (ReadSelfAction)Uml.ReadSelfActionInfo.Create(base.Model, id)!;
        }
    
        public ReadStructuralFeatureAction ReadStructuralFeatureAction(string? id = null)
        {
            return (ReadStructuralFeatureAction)Uml.ReadStructuralFeatureActionInfo.Create(base.Model, id)!;
        }
    
        public ReadVariableAction ReadVariableAction(string? id = null)
        {
            return (ReadVariableAction)Uml.ReadVariableActionInfo.Create(base.Model, id)!;
        }
    
        public Realization Realization(string? id = null)
        {
            return (Realization)Uml.RealizationInfo.Create(base.Model, id)!;
        }
    
        public Reception Reception(string? id = null)
        {
            return (Reception)Uml.ReceptionInfo.Create(base.Model, id)!;
        }
    
        public ReclassifyObjectAction ReclassifyObjectAction(string? id = null)
        {
            return (ReclassifyObjectAction)Uml.ReclassifyObjectActionInfo.Create(base.Model, id)!;
        }
    
        public RedefinableTemplateSignature RedefinableTemplateSignature(string? id = null)
        {
            return (RedefinableTemplateSignature)Uml.RedefinableTemplateSignatureInfo.Create(base.Model, id)!;
        }
    
        public ReduceAction ReduceAction(string? id = null)
        {
            return (ReduceAction)Uml.ReduceActionInfo.Create(base.Model, id)!;
        }
    
        public Region Region(string? id = null)
        {
            return (Region)Uml.RegionInfo.Create(base.Model, id)!;
        }
    
        public RemoveStructuralFeatureValueAction RemoveStructuralFeatureValueAction(string? id = null)
        {
            return (RemoveStructuralFeatureValueAction)Uml.RemoveStructuralFeatureValueActionInfo.Create(base.Model, id)!;
        }
    
        public RemoveVariableValueAction RemoveVariableValueAction(string? id = null)
        {
            return (RemoveVariableValueAction)Uml.RemoveVariableValueActionInfo.Create(base.Model, id)!;
        }
    
        public ReplyAction ReplyAction(string? id = null)
        {
            return (ReplyAction)Uml.ReplyActionInfo.Create(base.Model, id)!;
        }
    
        public SendObjectAction SendObjectAction(string? id = null)
        {
            return (SendObjectAction)Uml.SendObjectActionInfo.Create(base.Model, id)!;
        }
    
        public SendSignalAction SendSignalAction(string? id = null)
        {
            return (SendSignalAction)Uml.SendSignalActionInfo.Create(base.Model, id)!;
        }
    
        public SequenceNode SequenceNode(string? id = null)
        {
            return (SequenceNode)Uml.SequenceNodeInfo.Create(base.Model, id)!;
        }
    
        public Slot Slot(string? id = null)
        {
            return (Slot)Uml.SlotInfo.Create(base.Model, id)!;
        }
    
        public StartClassifierBehaviorAction StartClassifierBehaviorAction(string? id = null)
        {
            return (StartClassifierBehaviorAction)Uml.StartClassifierBehaviorActionInfo.Create(base.Model, id)!;
        }
    
        public StartObjectBehaviorAction StartObjectBehaviorAction(string? id = null)
        {
            return (StartObjectBehaviorAction)Uml.StartObjectBehaviorActionInfo.Create(base.Model, id)!;
        }
    
        public StateInvariant StateInvariant(string? id = null)
        {
            return (StateInvariant)Uml.StateInvariantInfo.Create(base.Model, id)!;
        }
    
        public Signal Signal(string? id = null)
        {
            return (Signal)Uml.SignalInfo.Create(base.Model, id)!;
        }
    
        public SignalEvent SignalEvent(string? id = null)
        {
            return (SignalEvent)Uml.SignalEventInfo.Create(base.Model, id)!;
        }
    
        public State State(string? id = null)
        {
            return (State)Uml.StateInfo.Create(base.Model, id)!;
        }
    
        public StateMachine StateMachine(string? id = null)
        {
            return (StateMachine)Uml.StateMachineInfo.Create(base.Model, id)!;
        }
    
        public Stereotype Stereotype(string? id = null)
        {
            return (Stereotype)Uml.StereotypeInfo.Create(base.Model, id)!;
        }
    
        public StringExpression StringExpression(string? id = null)
        {
            return (StringExpression)Uml.StringExpressionInfo.Create(base.Model, id)!;
        }
    
        public StructuredActivityNode StructuredActivityNode(string? id = null)
        {
            return (StructuredActivityNode)Uml.StructuredActivityNodeInfo.Create(base.Model, id)!;
        }
    
        public Substitution Substitution(string? id = null)
        {
            return (Substitution)Uml.SubstitutionInfo.Create(base.Model, id)!;
        }
    
        public TemplateBinding TemplateBinding(string? id = null)
        {
            return (TemplateBinding)Uml.TemplateBindingInfo.Create(base.Model, id)!;
        }
    
        public TemplateParameter TemplateParameter(string? id = null)
        {
            return (TemplateParameter)Uml.TemplateParameterInfo.Create(base.Model, id)!;
        }
    
        public TemplateParameterSubstitution TemplateParameterSubstitution(string? id = null)
        {
            return (TemplateParameterSubstitution)Uml.TemplateParameterSubstitutionInfo.Create(base.Model, id)!;
        }
    
        public TemplateSignature TemplateSignature(string? id = null)
        {
            return (TemplateSignature)Uml.TemplateSignatureInfo.Create(base.Model, id)!;
        }
    
        public TestIdentityAction TestIdentityAction(string? id = null)
        {
            return (TestIdentityAction)Uml.TestIdentityActionInfo.Create(base.Model, id)!;
        }
    
        public TimeConstraint TimeConstraint(string? id = null)
        {
            return (TimeConstraint)Uml.TimeConstraintInfo.Create(base.Model, id)!;
        }
    
        public TimeEvent TimeEvent(string? id = null)
        {
            return (TimeEvent)Uml.TimeEventInfo.Create(base.Model, id)!;
        }
    
        public TimeExpression TimeExpression(string? id = null)
        {
            return (TimeExpression)Uml.TimeExpressionInfo.Create(base.Model, id)!;
        }
    
        public TimeInterval TimeInterval(string? id = null)
        {
            return (TimeInterval)Uml.TimeIntervalInfo.Create(base.Model, id)!;
        }
    
        public TimeObservation TimeObservation(string? id = null)
        {
            return (TimeObservation)Uml.TimeObservationInfo.Create(base.Model, id)!;
        }
    
        public Transition Transition(string? id = null)
        {
            return (Transition)Uml.TransitionInfo.Create(base.Model, id)!;
        }
    
        public Trigger Trigger(string? id = null)
        {
            return (Trigger)Uml.TriggerInfo.Create(base.Model, id)!;
        }
    
        public UnmarshallAction UnmarshallAction(string? id = null)
        {
            return (UnmarshallAction)Uml.UnmarshallActionInfo.Create(base.Model, id)!;
        }
    
        public Usage Usage(string? id = null)
        {
            return (Usage)Uml.UsageInfo.Create(base.Model, id)!;
        }
    
        public UseCase UseCase(string? id = null)
        {
            return (UseCase)Uml.UseCaseInfo.Create(base.Model, id)!;
        }
    
        public ValuePin ValuePin(string? id = null)
        {
            return (ValuePin)Uml.ValuePinInfo.Create(base.Model, id)!;
        }
    
        public ValueSpecificationAction ValueSpecificationAction(string? id = null)
        {
            return (ValueSpecificationAction)Uml.ValueSpecificationActionInfo.Create(base.Model, id)!;
        }
    
        public Variable Variable(string? id = null)
        {
            return (Variable)Uml.VariableInfo.Create(base.Model, id)!;
        }
    
    }
    
    public class UmlModelMultiFactory : __MultiModelFactory
    {
        public UmlModelMultiFactory()
            : base(new __MetaModel[] { Uml.MInstance })
        {
        }
    
        public Abstraction Abstraction(__Model model, string? id = null)
        {
            return (Abstraction)Uml.AbstractionInfo.Create(model, id)!;
        }
    
        public AcceptEventAction AcceptEventAction(__Model model, string? id = null)
        {
            return (AcceptEventAction)Uml.AcceptEventActionInfo.Create(model, id)!;
        }
    
        public AcceptCallAction AcceptCallAction(__Model model, string? id = null)
        {
            return (AcceptCallAction)Uml.AcceptCallActionInfo.Create(model, id)!;
        }
    
        public ActionExecutionSpecification ActionExecutionSpecification(__Model model, string? id = null)
        {
            return (ActionExecutionSpecification)Uml.ActionExecutionSpecificationInfo.Create(model, id)!;
        }
    
        public ActionInputPin ActionInputPin(__Model model, string? id = null)
        {
            return (ActionInputPin)Uml.ActionInputPinInfo.Create(model, id)!;
        }
    
        public Class Class(__Model model, string? id = null)
        {
            return (Class)Uml.ClassInfo.Create(model, id)!;
        }
    
        public Activity Activity(__Model model, string? id = null)
        {
            return (Activity)Uml.ActivityInfo.Create(model, id)!;
        }
    
        public ActivityFinalNode ActivityFinalNode(__Model model, string? id = null)
        {
            return (ActivityFinalNode)Uml.ActivityFinalNodeInfo.Create(model, id)!;
        }
    
        public ActivityParameterNode ActivityParameterNode(__Model model, string? id = null)
        {
            return (ActivityParameterNode)Uml.ActivityParameterNodeInfo.Create(model, id)!;
        }
    
        public ActivityPartition ActivityPartition(__Model model, string? id = null)
        {
            return (ActivityPartition)Uml.ActivityPartitionInfo.Create(model, id)!;
        }
    
        public Actor Actor(__Model model, string? id = null)
        {
            return (Actor)Uml.ActorInfo.Create(model, id)!;
        }
    
        public AddStructuralFeatureValueAction AddStructuralFeatureValueAction(__Model model, string? id = null)
        {
            return (AddStructuralFeatureValueAction)Uml.AddStructuralFeatureValueActionInfo.Create(model, id)!;
        }
    
        public AddVariableValueAction AddVariableValueAction(__Model model, string? id = null)
        {
            return (AddVariableValueAction)Uml.AddVariableValueActionInfo.Create(model, id)!;
        }
    
        public AnyReceiveEvent AnyReceiveEvent(__Model model, string? id = null)
        {
            return (AnyReceiveEvent)Uml.AnyReceiveEventInfo.Create(model, id)!;
        }
    
        public Association Association(__Model model, string? id = null)
        {
            return (Association)Uml.AssociationInfo.Create(model, id)!;
        }
    
        public AssociationClass AssociationClass(__Model model, string? id = null)
        {
            return (AssociationClass)Uml.AssociationClassInfo.Create(model, id)!;
        }
    
        public BehaviorExecutionSpecification BehaviorExecutionSpecification(__Model model, string? id = null)
        {
            return (BehaviorExecutionSpecification)Uml.BehaviorExecutionSpecificationInfo.Create(model, id)!;
        }
    
        public BroadcastSignalAction BroadcastSignalAction(__Model model, string? id = null)
        {
            return (BroadcastSignalAction)Uml.BroadcastSignalActionInfo.Create(model, id)!;
        }
    
        public CallBehaviorAction CallBehaviorAction(__Model model, string? id = null)
        {
            return (CallBehaviorAction)Uml.CallBehaviorActionInfo.Create(model, id)!;
        }
    
        public CallEvent CallEvent(__Model model, string? id = null)
        {
            return (CallEvent)Uml.CallEventInfo.Create(model, id)!;
        }
    
        public CallOperationAction CallOperationAction(__Model model, string? id = null)
        {
            return (CallOperationAction)Uml.CallOperationActionInfo.Create(model, id)!;
        }
    
        public CentralBufferNode CentralBufferNode(__Model model, string? id = null)
        {
            return (CentralBufferNode)Uml.CentralBufferNodeInfo.Create(model, id)!;
        }
    
        public ChangeEvent ChangeEvent(__Model model, string? id = null)
        {
            return (ChangeEvent)Uml.ChangeEventInfo.Create(model, id)!;
        }
    
        public ClassifierTemplateParameter ClassifierTemplateParameter(__Model model, string? id = null)
        {
            return (ClassifierTemplateParameter)Uml.ClassifierTemplateParameterInfo.Create(model, id)!;
        }
    
        public Clause Clause(__Model model, string? id = null)
        {
            return (Clause)Uml.ClauseInfo.Create(model, id)!;
        }
    
        public ClearAssociationAction ClearAssociationAction(__Model model, string? id = null)
        {
            return (ClearAssociationAction)Uml.ClearAssociationActionInfo.Create(model, id)!;
        }
    
        public ClearStructuralFeatureAction ClearStructuralFeatureAction(__Model model, string? id = null)
        {
            return (ClearStructuralFeatureAction)Uml.ClearStructuralFeatureActionInfo.Create(model, id)!;
        }
    
        public ClearVariableAction ClearVariableAction(__Model model, string? id = null)
        {
            return (ClearVariableAction)Uml.ClearVariableActionInfo.Create(model, id)!;
        }
    
        public Collaboration Collaboration(__Model model, string? id = null)
        {
            return (Collaboration)Uml.CollaborationInfo.Create(model, id)!;
        }
    
        public CollaborationUse CollaborationUse(__Model model, string? id = null)
        {
            return (CollaborationUse)Uml.CollaborationUseInfo.Create(model, id)!;
        }
    
        public CombinedFragment CombinedFragment(__Model model, string? id = null)
        {
            return (CombinedFragment)Uml.CombinedFragmentInfo.Create(model, id)!;
        }
    
        public Comment Comment(__Model model, string? id = null)
        {
            return (Comment)Uml.CommentInfo.Create(model, id)!;
        }
    
        public CommunicationPath CommunicationPath(__Model model, string? id = null)
        {
            return (CommunicationPath)Uml.CommunicationPathInfo.Create(model, id)!;
        }
    
        public Component Component(__Model model, string? id = null)
        {
            return (Component)Uml.ComponentInfo.Create(model, id)!;
        }
    
        public ComponentRealization ComponentRealization(__Model model, string? id = null)
        {
            return (ComponentRealization)Uml.ComponentRealizationInfo.Create(model, id)!;
        }
    
        public ConditionalNode ConditionalNode(__Model model, string? id = null)
        {
            return (ConditionalNode)Uml.ConditionalNodeInfo.Create(model, id)!;
        }
    
        public ConnectableElementTemplateParameter ConnectableElementTemplateParameter(__Model model, string? id = null)
        {
            return (ConnectableElementTemplateParameter)Uml.ConnectableElementTemplateParameterInfo.Create(model, id)!;
        }
    
        public ConnectionPointReference ConnectionPointReference(__Model model, string? id = null)
        {
            return (ConnectionPointReference)Uml.ConnectionPointReferenceInfo.Create(model, id)!;
        }
    
        public Connector Connector(__Model model, string? id = null)
        {
            return (Connector)Uml.ConnectorInfo.Create(model, id)!;
        }
    
        public ConnectorEnd ConnectorEnd(__Model model, string? id = null)
        {
            return (ConnectorEnd)Uml.ConnectorEndInfo.Create(model, id)!;
        }
    
        public ConsiderIgnoreFragment ConsiderIgnoreFragment(__Model model, string? id = null)
        {
            return (ConsiderIgnoreFragment)Uml.ConsiderIgnoreFragmentInfo.Create(model, id)!;
        }
    
        public Constraint Constraint(__Model model, string? id = null)
        {
            return (Constraint)Uml.ConstraintInfo.Create(model, id)!;
        }
    
        public Continuation Continuation(__Model model, string? id = null)
        {
            return (Continuation)Uml.ContinuationInfo.Create(model, id)!;
        }
    
        public ControlFlow ControlFlow(__Model model, string? id = null)
        {
            return (ControlFlow)Uml.ControlFlowInfo.Create(model, id)!;
        }
    
        public CreateLinkAction CreateLinkAction(__Model model, string? id = null)
        {
            return (CreateLinkAction)Uml.CreateLinkActionInfo.Create(model, id)!;
        }
    
        public CreateLinkObjectAction CreateLinkObjectAction(__Model model, string? id = null)
        {
            return (CreateLinkObjectAction)Uml.CreateLinkObjectActionInfo.Create(model, id)!;
        }
    
        public CreateObjectAction CreateObjectAction(__Model model, string? id = null)
        {
            return (CreateObjectAction)Uml.CreateObjectActionInfo.Create(model, id)!;
        }
    
        public DataStoreNode DataStoreNode(__Model model, string? id = null)
        {
            return (DataStoreNode)Uml.DataStoreNodeInfo.Create(model, id)!;
        }
    
        public DataType DataType(__Model model, string? id = null)
        {
            return (DataType)Uml.DataTypeInfo.Create(model, id)!;
        }
    
        public DecisionNode DecisionNode(__Model model, string? id = null)
        {
            return (DecisionNode)Uml.DecisionNodeInfo.Create(model, id)!;
        }
    
        public Dependency Dependency(__Model model, string? id = null)
        {
            return (Dependency)Uml.DependencyInfo.Create(model, id)!;
        }
    
        public DestroyLinkAction DestroyLinkAction(__Model model, string? id = null)
        {
            return (DestroyLinkAction)Uml.DestroyLinkActionInfo.Create(model, id)!;
        }
    
        public DestroyObjectAction DestroyObjectAction(__Model model, string? id = null)
        {
            return (DestroyObjectAction)Uml.DestroyObjectActionInfo.Create(model, id)!;
        }
    
        public DestructionOccurrenceSpecification DestructionOccurrenceSpecification(__Model model, string? id = null)
        {
            return (DestructionOccurrenceSpecification)Uml.DestructionOccurrenceSpecificationInfo.Create(model, id)!;
        }
    
        public ElementImport ElementImport(__Model model, string? id = null)
        {
            return (ElementImport)Uml.ElementImportInfo.Create(model, id)!;
        }
    
        public ExceptionHandler ExceptionHandler(__Model model, string? id = null)
        {
            return (ExceptionHandler)Uml.ExceptionHandlerInfo.Create(model, id)!;
        }
    
        public ExecutionOccurrenceSpecification ExecutionOccurrenceSpecification(__Model model, string? id = null)
        {
            return (ExecutionOccurrenceSpecification)Uml.ExecutionOccurrenceSpecificationInfo.Create(model, id)!;
        }
    
        public ExpansionNode ExpansionNode(__Model model, string? id = null)
        {
            return (ExpansionNode)Uml.ExpansionNodeInfo.Create(model, id)!;
        }
    
        public ExpansionRegion ExpansionRegion(__Model model, string? id = null)
        {
            return (ExpansionRegion)Uml.ExpansionRegionInfo.Create(model, id)!;
        }
    
        public Extend Extend(__Model model, string? id = null)
        {
            return (Extend)Uml.ExtendInfo.Create(model, id)!;
        }
    
        public ExtensionEnd ExtensionEnd(__Model model, string? id = null)
        {
            return (ExtensionEnd)Uml.ExtensionEndInfo.Create(model, id)!;
        }
    
        public ExtensionPoint ExtensionPoint(__Model model, string? id = null)
        {
            return (ExtensionPoint)Uml.ExtensionPointInfo.Create(model, id)!;
        }
    
        public FinalState FinalState(__Model model, string? id = null)
        {
            return (FinalState)Uml.FinalStateInfo.Create(model, id)!;
        }
    
        public FlowFinalNode FlowFinalNode(__Model model, string? id = null)
        {
            return (FlowFinalNode)Uml.FlowFinalNodeInfo.Create(model, id)!;
        }
    
        public ForkNode ForkNode(__Model model, string? id = null)
        {
            return (ForkNode)Uml.ForkNodeInfo.Create(model, id)!;
        }
    
        public Gate Gate(__Model model, string? id = null)
        {
            return (Gate)Uml.GateInfo.Create(model, id)!;
        }
    
        public Generalization Generalization(__Model model, string? id = null)
        {
            return (Generalization)Uml.GeneralizationInfo.Create(model, id)!;
        }
    
        public GeneralOrdering GeneralOrdering(__Model model, string? id = null)
        {
            return (GeneralOrdering)Uml.GeneralOrderingInfo.Create(model, id)!;
        }
    
        public Image Image(__Model model, string? id = null)
        {
            return (Image)Uml.ImageInfo.Create(model, id)!;
        }
    
        public Include Include(__Model model, string? id = null)
        {
            return (Include)Uml.IncludeInfo.Create(model, id)!;
        }
    
        public InitialNode InitialNode(__Model model, string? id = null)
        {
            return (InitialNode)Uml.InitialNodeInfo.Create(model, id)!;
        }
    
        public InputPin InputPin(__Model model, string? id = null)
        {
            return (InputPin)Uml.InputPinInfo.Create(model, id)!;
        }
    
        public Artifact Artifact(__Model model, string? id = null)
        {
            return (Artifact)Uml.ArtifactInfo.Create(model, id)!;
        }
    
        public Deployment Deployment(__Model model, string? id = null)
        {
            return (Deployment)Uml.DeploymentInfo.Create(model, id)!;
        }
    
        public DeploymentSpecification DeploymentSpecification(__Model model, string? id = null)
        {
            return (DeploymentSpecification)Uml.DeploymentSpecificationInfo.Create(model, id)!;
        }
    
        public Duration Duration(__Model model, string? id = null)
        {
            return (Duration)Uml.DurationInfo.Create(model, id)!;
        }
    
        public DurationConstraint DurationConstraint(__Model model, string? id = null)
        {
            return (DurationConstraint)Uml.DurationConstraintInfo.Create(model, id)!;
        }
    
        public DurationInterval DurationInterval(__Model model, string? id = null)
        {
            return (DurationInterval)Uml.DurationIntervalInfo.Create(model, id)!;
        }
    
        public DurationObservation DurationObservation(__Model model, string? id = null)
        {
            return (DurationObservation)Uml.DurationObservationInfo.Create(model, id)!;
        }
    
        public Device Device(__Model model, string? id = null)
        {
            return (Device)Uml.DeviceInfo.Create(model, id)!;
        }
    
        public Enumeration Enumeration(__Model model, string? id = null)
        {
            return (Enumeration)Uml.EnumerationInfo.Create(model, id)!;
        }
    
        public EnumerationLiteral EnumerationLiteral(__Model model, string? id = null)
        {
            return (EnumerationLiteral)Uml.EnumerationLiteralInfo.Create(model, id)!;
        }
    
        public ExecutionEnvironment ExecutionEnvironment(__Model model, string? id = null)
        {
            return (ExecutionEnvironment)Uml.ExecutionEnvironmentInfo.Create(model, id)!;
        }
    
        public Expression Expression(__Model model, string? id = null)
        {
            return (Expression)Uml.ExpressionInfo.Create(model, id)!;
        }
    
        public Extension Extension(__Model model, string? id = null)
        {
            return (Extension)Uml.ExtensionInfo.Create(model, id)!;
        }
    
        public FunctionBehavior FunctionBehavior(__Model model, string? id = null)
        {
            return (FunctionBehavior)Uml.FunctionBehaviorInfo.Create(model, id)!;
        }
    
        public GeneralizationSet GeneralizationSet(__Model model, string? id = null)
        {
            return (GeneralizationSet)Uml.GeneralizationSetInfo.Create(model, id)!;
        }
    
        public InformationFlow InformationFlow(__Model model, string? id = null)
        {
            return (InformationFlow)Uml.InformationFlowInfo.Create(model, id)!;
        }
    
        public InformationItem InformationItem(__Model model, string? id = null)
        {
            return (InformationItem)Uml.InformationItemInfo.Create(model, id)!;
        }
    
        public InstanceSpecification InstanceSpecification(__Model model, string? id = null)
        {
            return (InstanceSpecification)Uml.InstanceSpecificationInfo.Create(model, id)!;
        }
    
        public InstanceValue InstanceValue(__Model model, string? id = null)
        {
            return (InstanceValue)Uml.InstanceValueInfo.Create(model, id)!;
        }
    
        public Interaction Interaction(__Model model, string? id = null)
        {
            return (Interaction)Uml.InteractionInfo.Create(model, id)!;
        }
    
        public InteractionConstraint InteractionConstraint(__Model model, string? id = null)
        {
            return (InteractionConstraint)Uml.InteractionConstraintInfo.Create(model, id)!;
        }
    
        public InteractionOperand InteractionOperand(__Model model, string? id = null)
        {
            return (InteractionOperand)Uml.InteractionOperandInfo.Create(model, id)!;
        }
    
        public InteractionUse InteractionUse(__Model model, string? id = null)
        {
            return (InteractionUse)Uml.InteractionUseInfo.Create(model, id)!;
        }
    
        public Interface Interface(__Model model, string? id = null)
        {
            return (Interface)Uml.InterfaceInfo.Create(model, id)!;
        }
    
        public InterfaceRealization InterfaceRealization(__Model model, string? id = null)
        {
            return (InterfaceRealization)Uml.InterfaceRealizationInfo.Create(model, id)!;
        }
    
        public InterruptibleActivityRegion InterruptibleActivityRegion(__Model model, string? id = null)
        {
            return (InterruptibleActivityRegion)Uml.InterruptibleActivityRegionInfo.Create(model, id)!;
        }
    
        public Interval Interval(__Model model, string? id = null)
        {
            return (Interval)Uml.IntervalInfo.Create(model, id)!;
        }
    
        public IntervalConstraint IntervalConstraint(__Model model, string? id = null)
        {
            return (IntervalConstraint)Uml.IntervalConstraintInfo.Create(model, id)!;
        }
    
        public JoinNode JoinNode(__Model model, string? id = null)
        {
            return (JoinNode)Uml.JoinNodeInfo.Create(model, id)!;
        }
    
        public Lifeline Lifeline(__Model model, string? id = null)
        {
            return (Lifeline)Uml.LifelineInfo.Create(model, id)!;
        }
    
        public LinkEndData LinkEndData(__Model model, string? id = null)
        {
            return (LinkEndData)Uml.LinkEndDataInfo.Create(model, id)!;
        }
    
        public LinkEndCreationData LinkEndCreationData(__Model model, string? id = null)
        {
            return (LinkEndCreationData)Uml.LinkEndCreationDataInfo.Create(model, id)!;
        }
    
        public LinkEndDestructionData LinkEndDestructionData(__Model model, string? id = null)
        {
            return (LinkEndDestructionData)Uml.LinkEndDestructionDataInfo.Create(model, id)!;
        }
    
        public LiteralBoolean LiteralBoolean(__Model model, string? id = null)
        {
            return (LiteralBoolean)Uml.LiteralBooleanInfo.Create(model, id)!;
        }
    
        public LiteralInteger LiteralInteger(__Model model, string? id = null)
        {
            return (LiteralInteger)Uml.LiteralIntegerInfo.Create(model, id)!;
        }
    
        public LiteralNull LiteralNull(__Model model, string? id = null)
        {
            return (LiteralNull)Uml.LiteralNullInfo.Create(model, id)!;
        }
    
        public LiteralReal LiteralReal(__Model model, string? id = null)
        {
            return (LiteralReal)Uml.LiteralRealInfo.Create(model, id)!;
        }
    
        public LiteralString LiteralString(__Model model, string? id = null)
        {
            return (LiteralString)Uml.LiteralStringInfo.Create(model, id)!;
        }
    
        public LiteralUnlimitedNatural LiteralUnlimitedNatural(__Model model, string? id = null)
        {
            return (LiteralUnlimitedNatural)Uml.LiteralUnlimitedNaturalInfo.Create(model, id)!;
        }
    
        public LoopNode LoopNode(__Model model, string? id = null)
        {
            return (LoopNode)Uml.LoopNodeInfo.Create(model, id)!;
        }
    
        public Manifestation Manifestation(__Model model, string? id = null)
        {
            return (Manifestation)Uml.ManifestationInfo.Create(model, id)!;
        }
    
        public MergeNode MergeNode(__Model model, string? id = null)
        {
            return (MergeNode)Uml.MergeNodeInfo.Create(model, id)!;
        }
    
        public Message Message(__Model model, string? id = null)
        {
            return (Message)Uml.MessageInfo.Create(model, id)!;
        }
    
        public Model Model(__Model model, string? id = null)
        {
            return (Model)Uml.ModelInfo.Create(model, id)!;
        }
    
        public Node Node(__Model model, string? id = null)
        {
            return (Node)Uml.NodeInfo.Create(model, id)!;
        }
    
        public ObjectFlow ObjectFlow(__Model model, string? id = null)
        {
            return (ObjectFlow)Uml.ObjectFlowInfo.Create(model, id)!;
        }
    
        public OccurrenceSpecification OccurrenceSpecification(__Model model, string? id = null)
        {
            return (OccurrenceSpecification)Uml.OccurrenceSpecificationInfo.Create(model, id)!;
        }
    
        public MessageOccurrenceSpecification MessageOccurrenceSpecification(__Model model, string? id = null)
        {
            return (MessageOccurrenceSpecification)Uml.MessageOccurrenceSpecificationInfo.Create(model, id)!;
        }
    
        public OpaqueExpression OpaqueExpression(__Model model, string? id = null)
        {
            return (OpaqueExpression)Uml.OpaqueExpressionInfo.Create(model, id)!;
        }
    
        public OperationTemplateParameter OperationTemplateParameter(__Model model, string? id = null)
        {
            return (OperationTemplateParameter)Uml.OperationTemplateParameterInfo.Create(model, id)!;
        }
    
        public Package Package(__Model model, string? id = null)
        {
            return (Package)Uml.PackageInfo.Create(model, id)!;
        }
    
        public PackageImport PackageImport(__Model model, string? id = null)
        {
            return (PackageImport)Uml.PackageImportInfo.Create(model, id)!;
        }
    
        public PackageMerge PackageMerge(__Model model, string? id = null)
        {
            return (PackageMerge)Uml.PackageMergeInfo.Create(model, id)!;
        }
    
        public Parameter Parameter(__Model model, string? id = null)
        {
            return (Parameter)Uml.ParameterInfo.Create(model, id)!;
        }
    
        public ParameterSet ParameterSet(__Model model, string? id = null)
        {
            return (ParameterSet)Uml.ParameterSetInfo.Create(model, id)!;
        }
    
        public PartDecomposition PartDecomposition(__Model model, string? id = null)
        {
            return (PartDecomposition)Uml.PartDecompositionInfo.Create(model, id)!;
        }
    
        public OpaqueAction OpaqueAction(__Model model, string? id = null)
        {
            return (OpaqueAction)Uml.OpaqueActionInfo.Create(model, id)!;
        }
    
        public OpaqueBehavior OpaqueBehavior(__Model model, string? id = null)
        {
            return (OpaqueBehavior)Uml.OpaqueBehaviorInfo.Create(model, id)!;
        }
    
        public Operation Operation(__Model model, string? id = null)
        {
            return (Operation)Uml.OperationInfo.Create(model, id)!;
        }
    
        public OutputPin OutputPin(__Model model, string? id = null)
        {
            return (OutputPin)Uml.OutputPinInfo.Create(model, id)!;
        }
    
        public Property Property(__Model model, string? id = null)
        {
            return (Property)Uml.PropertyInfo.Create(model, id)!;
        }
    
        public Port Port(__Model model, string? id = null)
        {
            return (Port)Uml.PortInfo.Create(model, id)!;
        }
    
        public PrimitiveType PrimitiveType(__Model model, string? id = null)
        {
            return (PrimitiveType)Uml.PrimitiveTypeInfo.Create(model, id)!;
        }
    
        public Profile Profile(__Model model, string? id = null)
        {
            return (Profile)Uml.ProfileInfo.Create(model, id)!;
        }
    
        public ProfileApplication ProfileApplication(__Model model, string? id = null)
        {
            return (ProfileApplication)Uml.ProfileApplicationInfo.Create(model, id)!;
        }
    
        public ProtocolConformance ProtocolConformance(__Model model, string? id = null)
        {
            return (ProtocolConformance)Uml.ProtocolConformanceInfo.Create(model, id)!;
        }
    
        public ProtocolStateMachine ProtocolStateMachine(__Model model, string? id = null)
        {
            return (ProtocolStateMachine)Uml.ProtocolStateMachineInfo.Create(model, id)!;
        }
    
        public ProtocolTransition ProtocolTransition(__Model model, string? id = null)
        {
            return (ProtocolTransition)Uml.ProtocolTransitionInfo.Create(model, id)!;
        }
    
        public Pseudostate Pseudostate(__Model model, string? id = null)
        {
            return (Pseudostate)Uml.PseudostateInfo.Create(model, id)!;
        }
    
        public QualifierValue QualifierValue(__Model model, string? id = null)
        {
            return (QualifierValue)Uml.QualifierValueInfo.Create(model, id)!;
        }
    
        public RaiseExceptionAction RaiseExceptionAction(__Model model, string? id = null)
        {
            return (RaiseExceptionAction)Uml.RaiseExceptionActionInfo.Create(model, id)!;
        }
    
        public ReadExtentAction ReadExtentAction(__Model model, string? id = null)
        {
            return (ReadExtentAction)Uml.ReadExtentActionInfo.Create(model, id)!;
        }
    
        public ReadIsClassifiedObjectAction ReadIsClassifiedObjectAction(__Model model, string? id = null)
        {
            return (ReadIsClassifiedObjectAction)Uml.ReadIsClassifiedObjectActionInfo.Create(model, id)!;
        }
    
        public ReadLinkAction ReadLinkAction(__Model model, string? id = null)
        {
            return (ReadLinkAction)Uml.ReadLinkActionInfo.Create(model, id)!;
        }
    
        public ReadLinkObjectEndAction ReadLinkObjectEndAction(__Model model, string? id = null)
        {
            return (ReadLinkObjectEndAction)Uml.ReadLinkObjectEndActionInfo.Create(model, id)!;
        }
    
        public ReadLinkObjectEndQualifierAction ReadLinkObjectEndQualifierAction(__Model model, string? id = null)
        {
            return (ReadLinkObjectEndQualifierAction)Uml.ReadLinkObjectEndQualifierActionInfo.Create(model, id)!;
        }
    
        public ReadSelfAction ReadSelfAction(__Model model, string? id = null)
        {
            return (ReadSelfAction)Uml.ReadSelfActionInfo.Create(model, id)!;
        }
    
        public ReadStructuralFeatureAction ReadStructuralFeatureAction(__Model model, string? id = null)
        {
            return (ReadStructuralFeatureAction)Uml.ReadStructuralFeatureActionInfo.Create(model, id)!;
        }
    
        public ReadVariableAction ReadVariableAction(__Model model, string? id = null)
        {
            return (ReadVariableAction)Uml.ReadVariableActionInfo.Create(model, id)!;
        }
    
        public Realization Realization(__Model model, string? id = null)
        {
            return (Realization)Uml.RealizationInfo.Create(model, id)!;
        }
    
        public Reception Reception(__Model model, string? id = null)
        {
            return (Reception)Uml.ReceptionInfo.Create(model, id)!;
        }
    
        public ReclassifyObjectAction ReclassifyObjectAction(__Model model, string? id = null)
        {
            return (ReclassifyObjectAction)Uml.ReclassifyObjectActionInfo.Create(model, id)!;
        }
    
        public RedefinableTemplateSignature RedefinableTemplateSignature(__Model model, string? id = null)
        {
            return (RedefinableTemplateSignature)Uml.RedefinableTemplateSignatureInfo.Create(model, id)!;
        }
    
        public ReduceAction ReduceAction(__Model model, string? id = null)
        {
            return (ReduceAction)Uml.ReduceActionInfo.Create(model, id)!;
        }
    
        public Region Region(__Model model, string? id = null)
        {
            return (Region)Uml.RegionInfo.Create(model, id)!;
        }
    
        public RemoveStructuralFeatureValueAction RemoveStructuralFeatureValueAction(__Model model, string? id = null)
        {
            return (RemoveStructuralFeatureValueAction)Uml.RemoveStructuralFeatureValueActionInfo.Create(model, id)!;
        }
    
        public RemoveVariableValueAction RemoveVariableValueAction(__Model model, string? id = null)
        {
            return (RemoveVariableValueAction)Uml.RemoveVariableValueActionInfo.Create(model, id)!;
        }
    
        public ReplyAction ReplyAction(__Model model, string? id = null)
        {
            return (ReplyAction)Uml.ReplyActionInfo.Create(model, id)!;
        }
    
        public SendObjectAction SendObjectAction(__Model model, string? id = null)
        {
            return (SendObjectAction)Uml.SendObjectActionInfo.Create(model, id)!;
        }
    
        public SendSignalAction SendSignalAction(__Model model, string? id = null)
        {
            return (SendSignalAction)Uml.SendSignalActionInfo.Create(model, id)!;
        }
    
        public SequenceNode SequenceNode(__Model model, string? id = null)
        {
            return (SequenceNode)Uml.SequenceNodeInfo.Create(model, id)!;
        }
    
        public Slot Slot(__Model model, string? id = null)
        {
            return (Slot)Uml.SlotInfo.Create(model, id)!;
        }
    
        public StartClassifierBehaviorAction StartClassifierBehaviorAction(__Model model, string? id = null)
        {
            return (StartClassifierBehaviorAction)Uml.StartClassifierBehaviorActionInfo.Create(model, id)!;
        }
    
        public StartObjectBehaviorAction StartObjectBehaviorAction(__Model model, string? id = null)
        {
            return (StartObjectBehaviorAction)Uml.StartObjectBehaviorActionInfo.Create(model, id)!;
        }
    
        public StateInvariant StateInvariant(__Model model, string? id = null)
        {
            return (StateInvariant)Uml.StateInvariantInfo.Create(model, id)!;
        }
    
        public Signal Signal(__Model model, string? id = null)
        {
            return (Signal)Uml.SignalInfo.Create(model, id)!;
        }
    
        public SignalEvent SignalEvent(__Model model, string? id = null)
        {
            return (SignalEvent)Uml.SignalEventInfo.Create(model, id)!;
        }
    
        public State State(__Model model, string? id = null)
        {
            return (State)Uml.StateInfo.Create(model, id)!;
        }
    
        public StateMachine StateMachine(__Model model, string? id = null)
        {
            return (StateMachine)Uml.StateMachineInfo.Create(model, id)!;
        }
    
        public Stereotype Stereotype(__Model model, string? id = null)
        {
            return (Stereotype)Uml.StereotypeInfo.Create(model, id)!;
        }
    
        public StringExpression StringExpression(__Model model, string? id = null)
        {
            return (StringExpression)Uml.StringExpressionInfo.Create(model, id)!;
        }
    
        public StructuredActivityNode StructuredActivityNode(__Model model, string? id = null)
        {
            return (StructuredActivityNode)Uml.StructuredActivityNodeInfo.Create(model, id)!;
        }
    
        public Substitution Substitution(__Model model, string? id = null)
        {
            return (Substitution)Uml.SubstitutionInfo.Create(model, id)!;
        }
    
        public TemplateBinding TemplateBinding(__Model model, string? id = null)
        {
            return (TemplateBinding)Uml.TemplateBindingInfo.Create(model, id)!;
        }
    
        public TemplateParameter TemplateParameter(__Model model, string? id = null)
        {
            return (TemplateParameter)Uml.TemplateParameterInfo.Create(model, id)!;
        }
    
        public TemplateParameterSubstitution TemplateParameterSubstitution(__Model model, string? id = null)
        {
            return (TemplateParameterSubstitution)Uml.TemplateParameterSubstitutionInfo.Create(model, id)!;
        }
    
        public TemplateSignature TemplateSignature(__Model model, string? id = null)
        {
            return (TemplateSignature)Uml.TemplateSignatureInfo.Create(model, id)!;
        }
    
        public TestIdentityAction TestIdentityAction(__Model model, string? id = null)
        {
            return (TestIdentityAction)Uml.TestIdentityActionInfo.Create(model, id)!;
        }
    
        public TimeConstraint TimeConstraint(__Model model, string? id = null)
        {
            return (TimeConstraint)Uml.TimeConstraintInfo.Create(model, id)!;
        }
    
        public TimeEvent TimeEvent(__Model model, string? id = null)
        {
            return (TimeEvent)Uml.TimeEventInfo.Create(model, id)!;
        }
    
        public TimeExpression TimeExpression(__Model model, string? id = null)
        {
            return (TimeExpression)Uml.TimeExpressionInfo.Create(model, id)!;
        }
    
        public TimeInterval TimeInterval(__Model model, string? id = null)
        {
            return (TimeInterval)Uml.TimeIntervalInfo.Create(model, id)!;
        }
    
        public TimeObservation TimeObservation(__Model model, string? id = null)
        {
            return (TimeObservation)Uml.TimeObservationInfo.Create(model, id)!;
        }
    
        public Transition Transition(__Model model, string? id = null)
        {
            return (Transition)Uml.TransitionInfo.Create(model, id)!;
        }
    
        public Trigger Trigger(__Model model, string? id = null)
        {
            return (Trigger)Uml.TriggerInfo.Create(model, id)!;
        }
    
        public UnmarshallAction UnmarshallAction(__Model model, string? id = null)
        {
            return (UnmarshallAction)Uml.UnmarshallActionInfo.Create(model, id)!;
        }
    
        public Usage Usage(__Model model, string? id = null)
        {
            return (Usage)Uml.UsageInfo.Create(model, id)!;
        }
    
        public UseCase UseCase(__Model model, string? id = null)
        {
            return (UseCase)Uml.UseCaseInfo.Create(model, id)!;
        }
    
        public ValuePin ValuePin(__Model model, string? id = null)
        {
            return (ValuePin)Uml.ValuePinInfo.Create(model, id)!;
        }
    
        public ValueSpecificationAction ValueSpecificationAction(__Model model, string? id = null)
        {
            return (ValueSpecificationAction)Uml.ValueSpecificationActionInfo.Create(model, id)!;
        }
    
        public Variable Variable(__Model model, string? id = null)
        {
            return (Variable)Uml.VariableInfo.Create(model, id)!;
        }
    
    }
}
