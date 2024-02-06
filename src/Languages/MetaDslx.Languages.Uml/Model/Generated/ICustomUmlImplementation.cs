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

    internal interface ICustomUmlImplementation
    {
        /// <summary>
        /// Constructor for the meta model Uml
        /// </summary>
        void Uml(IUml _this);
    
        void Element(Element _this);
    
        void NamedElement(NamedElement _this);
    
        void Abstraction(Abstraction _this);
    
        void Action(Action _this);
    
        void AcceptEventAction(AcceptEventAction _this);
    
        void AcceptCallAction(AcceptCallAction _this);
    
        void ActionExecutionSpecification(ActionExecutionSpecification _this);
    
        void ActionInputPin(ActionInputPin _this);
    
        void Classifier(Classifier _this);
    
        void BehavioredClassifier(BehavioredClassifier _this);
    
        void Class(Class _this);
    
        void Behavior(Behavior _this);
    
        void Activity(Activity _this);
    
        void ActivityEdge(ActivityEdge _this);
    
        void ActivityNode(ActivityNode _this);
    
        void ActivityFinalNode(ActivityFinalNode _this);
    
        void ActivityGroup(ActivityGroup _this);
    
        void ActivityParameterNode(ActivityParameterNode _this);
    
        void ActivityPartition(ActivityPartition _this);
    
        void Actor(Actor _this);
    
        void AddStructuralFeatureValueAction(AddStructuralFeatureValueAction _this);
    
        void AddVariableValueAction(AddVariableValueAction _this);
    
        void AnyReceiveEvent(AnyReceiveEvent _this);
    
        void Association(Association _this);
    
        void AssociationClass(AssociationClass _this);
    
        void BehavioralFeature(BehavioralFeature _this);
    
        void BehaviorExecutionSpecification(BehaviorExecutionSpecification _this);
    
        void BroadcastSignalAction(BroadcastSignalAction _this);
    
        void CallAction(CallAction _this);
    
        void CallBehaviorAction(CallBehaviorAction _this);
    
        void CallEvent(CallEvent _this);
    
        void CallOperationAction(CallOperationAction _this);
    
        void CentralBufferNode(CentralBufferNode _this);
    
        void ChangeEvent(ChangeEvent _this);
    
        void ClassifierTemplateParameter(ClassifierTemplateParameter _this);
    
        void Clause(Clause _this);
    
        void ClearAssociationAction(ClearAssociationAction _this);
    
        void ClearStructuralFeatureAction(ClearStructuralFeatureAction _this);
    
        void ClearVariableAction(ClearVariableAction _this);
    
        void Collaboration(Collaboration _this);
    
        void CollaborationUse(CollaborationUse _this);
    
        void CombinedFragment(CombinedFragment _this);
    
        void Comment(Comment _this);
    
        void CommunicationPath(CommunicationPath _this);
    
        void Component(Component _this);
    
        void ComponentRealization(ComponentRealization _this);
    
        void ConditionalNode(ConditionalNode _this);
    
        void ConnectableElement(ConnectableElement _this);
    
        void ConnectableElementTemplateParameter(ConnectableElementTemplateParameter _this);
    
        void ConnectionPointReference(ConnectionPointReference _this);
    
        void Connector(Connector _this);
    
        void ConnectorEnd(ConnectorEnd _this);
    
        void ConsiderIgnoreFragment(ConsiderIgnoreFragment _this);
    
        void Constraint(Constraint _this);
    
        void Continuation(Continuation _this);
    
        void ControlFlow(ControlFlow _this);
    
        void ControlNode(ControlNode _this);
    
        void CreateLinkAction(CreateLinkAction _this);
    
        void CreateLinkObjectAction(CreateLinkObjectAction _this);
    
        void CreateObjectAction(CreateObjectAction _this);
    
        void DataStoreNode(DataStoreNode _this);
    
        void DataType(DataType _this);
    
        void DecisionNode(DecisionNode _this);
    
        void Dependency(Dependency _this);
    
        void DeployedArtifact(DeployedArtifact _this);
    
        void DeploymentTarget(DeploymentTarget _this);
    
        void DestroyLinkAction(DestroyLinkAction _this);
    
        void DestroyObjectAction(DestroyObjectAction _this);
    
        void DestructionOccurrenceSpecification(DestructionOccurrenceSpecification _this);
    
        void DirectedRelationship(DirectedRelationship _this);
    
        void ElementImport(ElementImport _this);
    
        void ExceptionHandler(ExceptionHandler _this);
    
        void ExecutableNode(ExecutableNode _this);
    
        void ExecutionOccurrenceSpecification(ExecutionOccurrenceSpecification _this);
    
        void ExecutionSpecification(ExecutionSpecification _this);
    
        void ExpansionNode(ExpansionNode _this);
    
        void ExpansionRegion(ExpansionRegion _this);
    
        void Extend(Extend _this);
    
        void ExtensionEnd(ExtensionEnd _this);
    
        void ExtensionPoint(ExtensionPoint _this);
    
        void Feature(Feature _this);
    
        void FinalNode(FinalNode _this);
    
        void FinalState(FinalState _this);
    
        void FlowFinalNode(FlowFinalNode _this);
    
        void ForkNode(ForkNode _this);
    
        void Gate(Gate _this);
    
        void Generalization(Generalization _this);
    
        void GeneralOrdering(GeneralOrdering _this);
    
        void Image(Image _this);
    
        void Include(Include _this);
    
        void InitialNode(InitialNode _this);
    
        void InputPin(InputPin _this);
    
        void ParameterableElement(ParameterableElement _this);
    
        void PackageableElement(PackageableElement _this);
    
        void Artifact(Artifact _this);
    
        void Deployment(Deployment _this);
    
        void DeploymentSpecification(DeploymentSpecification _this);
    
        void Duration(Duration _this);
    
        void DurationConstraint(DurationConstraint _this);
    
        void DurationInterval(DurationInterval _this);
    
        void DurationObservation(DurationObservation _this);
    
        void EncapsulatedClassifier(EncapsulatedClassifier _this);
    
        void Device(Device _this);
    
        void Enumeration(Enumeration _this);
    
        void EnumerationLiteral(EnumerationLiteral _this);
    
        void Event(Event _this);
    
        void ExecutionEnvironment(ExecutionEnvironment _this);
    
        void Expression(Expression _this);
    
        void Extension(Extension _this);
    
        void FunctionBehavior(FunctionBehavior _this);
    
        void GeneralizationSet(GeneralizationSet _this);
    
        void InformationFlow(InformationFlow _this);
    
        void InformationItem(InformationItem _this);
    
        void InstanceSpecification(InstanceSpecification _this);
    
        void TypedElement(TypedElement _this);
    
        void InstanceValue(InstanceValue _this);
    
        void Interaction(Interaction _this);
    
        void InteractionConstraint(InteractionConstraint _this);
    
        void InteractionFragment(InteractionFragment _this);
    
        void InteractionOperand(InteractionOperand _this);
    
        void InteractionUse(InteractionUse _this);
    
        void Interface(Interface _this);
    
        void InterfaceRealization(InterfaceRealization _this);
    
        void InterruptibleActivityRegion(InterruptibleActivityRegion _this);
    
        void Interval(Interval _this);
    
        void IntervalConstraint(IntervalConstraint _this);
    
        void InvocationAction(InvocationAction _this);
    
        void JoinNode(JoinNode _this);
    
        void Lifeline(Lifeline _this);
    
        void LinkAction(LinkAction _this);
    
        void LinkEndData(LinkEndData _this);
    
        void LinkEndCreationData(LinkEndCreationData _this);
    
        void LinkEndDestructionData(LinkEndDestructionData _this);
    
        void LiteralSpecification(LiteralSpecification _this);
    
        void LiteralBoolean(LiteralBoolean _this);
    
        void LiteralInteger(LiteralInteger _this);
    
        void LiteralNull(LiteralNull _this);
    
        void LiteralReal(LiteralReal _this);
    
        void LiteralString(LiteralString _this);
    
        void LiteralUnlimitedNatural(LiteralUnlimitedNatural _this);
    
        void LoopNode(LoopNode _this);
    
        void Manifestation(Manifestation _this);
    
        void MergeNode(MergeNode _this);
    
        void Message(Message _this);
    
        void MessageEnd(MessageEnd _this);
    
        void MessageEvent(MessageEvent _this);
    
        void Model(Model _this);
    
        void MultiplicityElement(MultiplicityElement _this);
    
        void Namespace(Namespace _this);
    
        void Node(Node _this);
    
        void ObjectFlow(ObjectFlow _this);
    
        void ObjectNode(ObjectNode _this);
    
        void Observation(Observation _this);
    
        void OccurrenceSpecification(OccurrenceSpecification _this);
    
        void MessageOccurrenceSpecification(MessageOccurrenceSpecification _this);
    
        void OpaqueExpression(OpaqueExpression _this);
    
        void OperationTemplateParameter(OperationTemplateParameter _this);
    
        void Package(Package _this);
    
        void PackageImport(PackageImport _this);
    
        void PackageMerge(PackageMerge _this);
    
        void Parameter(Parameter _this);
    
        void ParameterSet(ParameterSet _this);
    
        void PartDecomposition(PartDecomposition _this);
    
        void RedefinableElement(RedefinableElement _this);
    
        void OpaqueAction(OpaqueAction _this);
    
        void OpaqueBehavior(OpaqueBehavior _this);
    
        void Operation(Operation _this);
    
        void Pin(Pin _this);
    
        void OutputPin(OutputPin _this);
    
        void StructuralFeature(StructuralFeature _this);
    
        void Property(Property _this);
    
        void Port(Port _this);
    
        void PrimitiveType(PrimitiveType _this);
    
        void Profile(Profile _this);
    
        void ProfileApplication(ProfileApplication _this);
    
        void ProtocolConformance(ProtocolConformance _this);
    
        void ProtocolStateMachine(ProtocolStateMachine _this);
    
        void ProtocolTransition(ProtocolTransition _this);
    
        void Pseudostate(Pseudostate _this);
    
        void QualifierValue(QualifierValue _this);
    
        void RaiseExceptionAction(RaiseExceptionAction _this);
    
        void ReadExtentAction(ReadExtentAction _this);
    
        void ReadIsClassifiedObjectAction(ReadIsClassifiedObjectAction _this);
    
        void ReadLinkAction(ReadLinkAction _this);
    
        void ReadLinkObjectEndAction(ReadLinkObjectEndAction _this);
    
        void ReadLinkObjectEndQualifierAction(ReadLinkObjectEndQualifierAction _this);
    
        void ReadSelfAction(ReadSelfAction _this);
    
        void ReadStructuralFeatureAction(ReadStructuralFeatureAction _this);
    
        void ReadVariableAction(ReadVariableAction _this);
    
        void Realization(Realization _this);
    
        void Reception(Reception _this);
    
        void ReclassifyObjectAction(ReclassifyObjectAction _this);
    
        void RedefinableTemplateSignature(RedefinableTemplateSignature _this);
    
        void ReduceAction(ReduceAction _this);
    
        void Region(Region _this);
    
        void Relationship(Relationship _this);
    
        void RemoveStructuralFeatureValueAction(RemoveStructuralFeatureValueAction _this);
    
        void RemoveVariableValueAction(RemoveVariableValueAction _this);
    
        void ReplyAction(ReplyAction _this);
    
        void SendObjectAction(SendObjectAction _this);
    
        void SendSignalAction(SendSignalAction _this);
    
        void SequenceNode(SequenceNode _this);
    
        void Slot(Slot _this);
    
        void StartClassifierBehaviorAction(StartClassifierBehaviorAction _this);
    
        void StartObjectBehaviorAction(StartObjectBehaviorAction _this);
    
        void StateInvariant(StateInvariant _this);
    
        void TemplateableElement(TemplateableElement _this);
    
        void Signal(Signal _this);
    
        void SignalEvent(SignalEvent _this);
    
        void State(State _this);
    
        void StructuredClassifier(StructuredClassifier _this);
    
        void StateMachine(StateMachine _this);
    
        void Stereotype(Stereotype _this);
    
        void StringExpression(StringExpression _this);
    
        void StructuralFeatureAction(StructuralFeatureAction _this);
    
        void StructuredActivityNode(StructuredActivityNode _this);
    
        void Substitution(Substitution _this);
    
        void TemplateBinding(TemplateBinding _this);
    
        void TemplateParameter(TemplateParameter _this);
    
        void TemplateParameterSubstitution(TemplateParameterSubstitution _this);
    
        void TemplateSignature(TemplateSignature _this);
    
        void TestIdentityAction(TestIdentityAction _this);
    
        void TimeConstraint(TimeConstraint _this);
    
        void TimeEvent(TimeEvent _this);
    
        void TimeExpression(TimeExpression _this);
    
        void TimeInterval(TimeInterval _this);
    
        void TimeObservation(TimeObservation _this);
    
        void Transition(Transition _this);
    
        void Trigger(Trigger _this);
    
        void Type(Type _this);
    
        void UnmarshallAction(UnmarshallAction _this);
    
        void Usage(Usage _this);
    
        void UseCase(UseCase _this);
    
        void ValuePin(ValuePin _this);
    
        void ValueSpecification(ValueSpecification _this);
    
        void ValueSpecificationAction(ValueSpecificationAction _this);
    
        void Variable(Variable _this);
    
        void VariableAction(VariableAction _this);
    
        void Vertex(Vertex _this);
    
        void WriteLinkAction(WriteLinkAction _this);
    
        void WriteStructuralFeatureAction(WriteStructuralFeatureAction _this);
    
        void WriteVariableAction(WriteVariableAction _this);
    
    
        global::System.Collections.Generic.IList<Dependency> NamedElement_ClientDependency(NamedElement _this);
    
        string NamedElement_QualifiedName(NamedElement _this);
    
        Classifier Action_Context(Action _this);
    
        global::System.Collections.Generic.IList<Classifier> Classifier_General(Classifier _this);
    
        global::System.Collections.Generic.IList<NamedElement> Classifier_InheritedMember(Classifier _this);
    
        global::System.Collections.Generic.IList<Extension> Class_Extension(Class _this);
    
        global::System.Collections.Generic.IList<Class> Class_SuperClass(Class _this);
    
        BehavioredClassifier Behavior_Context(Behavior _this);
    
        global::System.Collections.Generic.IList<Type> Association_EndType(Association _this);
    
        global::System.Collections.Generic.IList<Interface> Component_Provided(Component _this);
    
        global::System.Collections.Generic.IList<Interface> Component_Required(Component _this);
    
        global::System.Collections.Generic.IList<ConnectorEnd> ConnectableElement_End(ConnectableElement _this);
    
        global::MetaDslx.Languages.Uml.Model.ConnectorKind Connector_Kind(Connector _this);
    
        Property ConnectorEnd_DefiningEnd(ConnectorEnd _this);
    
        global::System.Collections.Generic.IList<PackageableElement> DeploymentTarget_DeployedElement(DeploymentTarget _this);
    
        int ExtensionEnd_Lower(ExtensionEnd _this);
    
        global::System.Collections.Generic.IList<Port> EncapsulatedClassifier_OwnedPort(EncapsulatedClassifier _this);
    
        Enumeration EnumerationLiteral_Classifier(EnumerationLiteral _this);
    
        bool Extension_IsRequired(Extension _this);
    
        Class Extension_Metaclass(Extension _this);
    
        global::MetaDslx.Languages.Uml.Model.MessageKind Message_MessageKind(Message _this);
    
        int MultiplicityElement_Lower(MultiplicityElement _this);
    
        int MultiplicityElement_Upper(MultiplicityElement _this);
    
        global::System.Collections.Generic.IList<PackageableElement> Namespace_ImportedMember(Namespace _this);
    
        Parameter OpaqueExpression_Result(OpaqueExpression _this);
    
        global::System.Collections.Generic.IList<Package> Package_NestedPackage(Package _this);
    
        global::System.Collections.Generic.IList<Stereotype> Package_OwnedStereotype(Package _this);
    
        global::System.Collections.Generic.IList<Type> Package_OwnedType(Package _this);
    
        string Parameter_Default(Parameter _this);
    
        bool Operation_IsOrdered(Operation _this);
    
        bool Operation_IsUnique(Operation _this);
    
        int Operation_Lower(Operation _this);
    
        Type Operation_Type(Operation _this);
    
        int Operation_Upper(Operation _this);
    
        bool Property_IsComposite(Property _this);
    
        Property Property_Opposite(Property _this);
    
        global::System.Collections.Generic.IList<Interface> Port_Provided(Port _this);
    
        global::System.Collections.Generic.IList<Interface> Port_Required(Port _this);
    
        global::System.Collections.Generic.IList<Operation> ProtocolTransition_Referred(ProtocolTransition _this);
    
        global::System.Collections.Generic.IList<TemplateParameter> RedefinableTemplateSignature_InheritedParameter(RedefinableTemplateSignature _this);
    
        Classifier Region_RedefinitionContext(Region _this);
    
        bool State_IsComposite(State _this);
    
        bool State_IsOrthogonal(State _this);
    
        bool State_IsSimple(State _this);
    
        bool State_IsSubmachineState(State _this);
    
        global::System.Collections.Generic.IList<Property> StructuredClassifier_Part(StructuredClassifier _this);
    
        Profile Stereotype_Profile(Stereotype _this);
    
        Classifier Transition_RedefinitionContext(Transition _this);
    
        global::System.Collections.Generic.IList<Transition> Vertex_Incoming(Vertex _this);
    
        global::System.Collections.Generic.IList<Transition> Vertex_Outgoing(Vertex _this);
    
        Classifier Vertex_RedefinitionContext(Vertex _this);
    
    
        global::System.Collections.Generic.IList<Element> Element_AllOwnedElements(Element _this);
    
        bool Element_MustBeOwned(Element _this);
    
        global::System.Collections.Generic.IList<Namespace> NamedElement_AllNamespaces(NamedElement _this);
    
        global::System.Collections.Generic.IList<Package> NamedElement_AllOwningPackages(NamedElement _this);
    
        bool NamedElement_IsDistinguishableFrom(NamedElement _this, NamedElement n, Namespace ns);
    
        string NamedElement_Separator(NamedElement _this);
    
        global::System.Collections.Generic.IList<Action> Action_AllActions(Action _this);
    
        global::System.Collections.Generic.IList<ActivityNode> Action_AllOwnedNodes(Action _this);
    
        Behavior Action_ContainingBehavior(Action _this);
    
        global::System.Collections.Generic.IList<Feature> Classifier_AllFeatures(Classifier _this);
    
        global::System.Collections.Generic.IList<Classifier> Classifier_AllParents(Classifier _this);
    
        bool Classifier_ConformsTo(Classifier _this, Type other);
    
        bool Classifier_HasVisibilityOf(Classifier _this, NamedElement n);
    
        global::System.Collections.Generic.IList<NamedElement> Classifier_Inherit(Classifier _this, global::System.Collections.Generic.IList<NamedElement> inhs);
    
        global::System.Collections.Generic.IList<NamedElement> Classifier_InheritableMembers(Classifier _this, Classifier c);
    
        bool Classifier_IsTemplate(Classifier _this);
    
        bool Classifier_MaySpecializeType(Classifier _this, Classifier c);
    
        global::System.Collections.Generic.IList<Classifier> Classifier_Parents(Classifier _this);
    
        global::System.Collections.Generic.IList<Interface> Classifier_DirectlyRealizedInterfaces(Classifier _this);
    
        global::System.Collections.Generic.IList<Interface> Classifier_DirectlyUsedInterfaces(Classifier _this);
    
        global::System.Collections.Generic.IList<Interface> Classifier_AllRealizedInterfaces(Classifier _this);
    
        global::System.Collections.Generic.IList<Interface> Classifier_AllUsedInterfaces(Classifier _this);
    
        bool Classifier_IsSubstitutableFor(Classifier _this, Classifier contract);
    
        global::System.Collections.Generic.IList<Property> Classifier_AllAttributes(Classifier _this);
    
        global::System.Collections.Generic.IList<StructuralFeature> Classifier_AllSlottableFeatures(Classifier _this);
    
        BehavioredClassifier Behavior_BehavioredClassifier(Behavior _this, Element from);
    
        global::System.Collections.Generic.IList<Parameter> Behavior_InputParameters(Behavior _this);
    
        global::System.Collections.Generic.IList<Parameter> Behavior_OutputParameters(Behavior _this);
    
        bool ActivityEdge_IsConsistentWith(ActivityEdge _this, RedefinableElement redefiningElement);
    
        Activity ActivityNode_ContainingActivity(ActivityNode _this);
    
        bool ActivityNode_IsConsistentWith(ActivityNode _this, RedefinableElement redefiningElement);
    
        Activity ActivityGroup_ContainingActivity(ActivityGroup _this);
    
        bool BehavioralFeature_IsDistinguishableFrom(BehavioralFeature _this, NamedElement n, Namespace ns);
    
        global::System.Collections.Generic.IList<Parameter> BehavioralFeature_InputParameters(BehavioralFeature _this);
    
        global::System.Collections.Generic.IList<Parameter> BehavioralFeature_OutputParameters(BehavioralFeature _this);
    
        global::System.Collections.Generic.IList<Parameter> CallAction_InputParameters(CallAction _this);
    
        global::System.Collections.Generic.IList<Parameter> CallAction_OutputParameters(CallAction _this);
    
        global::System.Collections.Generic.IList<Parameter> CallBehaviorAction_OutputParameters(CallBehaviorAction _this);
    
        global::System.Collections.Generic.IList<Parameter> CallBehaviorAction_InputParameters(CallBehaviorAction _this);
    
        global::System.Collections.Generic.IList<Parameter> CallOperationAction_OutputParameters(CallOperationAction _this);
    
        global::System.Collections.Generic.IList<Parameter> CallOperationAction_InputParameters(CallOperationAction _this);
    
        global::System.Collections.Generic.IList<Action> ConditionalNode_AllActions(ConditionalNode _this);
    
        bool ConnectionPointReference_IsConsistentWith(ConnectionPointReference _this, RedefinableElement redefiningElement);
    
        string ElementImport_GetName(ElementImport _this);
    
        int ExtensionEnd_LowerBound(ExtensionEnd _this);
    
        bool FinalState_IsConsistentWith(FinalState _this, RedefinableElement redefiningElement);
    
        bool Gate_IsOutsideCF(Gate _this);
    
        bool Gate_IsInsideCF(Gate _this);
    
        bool Gate_IsActual(Gate _this);
    
        bool Gate_IsFormal(Gate _this);
    
        string Gate_GetName(Gate _this);
    
        bool Gate_Matches(Gate _this, Gate gateToMatch);
    
        bool Gate_IsDistinguishableFrom(Gate _this, NamedElement n, Namespace ns);
    
        InteractionOperand Gate_GetOperand(Gate _this);
    
        bool ParameterableElement_IsCompatibleWith(ParameterableElement _this, ParameterableElement p);
    
        bool ParameterableElement_IsTemplateParameter(ParameterableElement _this);
    
        Property Extension_MetaclassEnd(Extension _this);
    
        bool FunctionBehavior_HasAllDataTypeAttributes(FunctionBehavior _this, DataType d);
    
        Association LinkAction_Association(LinkAction _this);
    
        global::System.Collections.Generic.IList<InputPin> LinkEndData_AllPins(LinkEndData _this);
    
        global::System.Collections.Generic.IList<InputPin> LinkEndCreationData_AllPins(LinkEndCreationData _this);
    
        global::System.Collections.Generic.IList<InputPin> LinkEndDestructionData_AllPins(LinkEndDestructionData _this);
    
        bool LiteralBoolean_BooleanValue(LiteralBoolean _this);
    
        bool LiteralBoolean_IsComputable(LiteralBoolean _this);
    
        int LiteralInteger_IntegerValue(LiteralInteger _this);
    
        bool LiteralInteger_IsComputable(LiteralInteger _this);
    
        bool LiteralNull_IsComputable(LiteralNull _this);
    
        bool LiteralNull_IsNull(LiteralNull _this);
    
        bool LiteralReal_IsComputable(LiteralReal _this);
    
        double LiteralReal_RealValue(LiteralReal _this);
    
        bool LiteralString_IsComputable(LiteralString _this);
    
        string LiteralString_StringValue(LiteralString _this);
    
        bool LiteralUnlimitedNatural_IsComputable(LiteralUnlimitedNatural _this);
    
        int LiteralUnlimitedNatural_UnlimitedValue(LiteralUnlimitedNatural _this);
    
        global::System.Collections.Generic.IList<Action> LoopNode_AllActions(LoopNode _this);
    
        global::System.Collections.Generic.IList<ActivityNode> LoopNode_SourceNodes(LoopNode _this);
    
        bool Message_IsDistinguishableFrom(Message _this, NamedElement n, Namespace ns);
    
        global::System.Collections.Generic.IList<MessageEnd> MessageEnd_OppositeEnd(MessageEnd _this);
    
        bool MessageEnd_IsSend(MessageEnd _this);
    
        bool MessageEnd_IsReceive(MessageEnd _this);
    
        global::System.Collections.Generic.IList<InteractionFragment> MessageEnd_EnclosingFragment(MessageEnd _this);
    
        bool MultiplicityElement_CompatibleWith(MultiplicityElement _this, MultiplicityElement other);
    
        bool MultiplicityElement_IncludesMultiplicity(MultiplicityElement _this, MultiplicityElement M);
    
        bool MultiplicityElement_Is(MultiplicityElement _this, int lowerbound, int upperbound);
    
        bool MultiplicityElement_IsMultivalued(MultiplicityElement _this);
    
        int MultiplicityElement_LowerBound(MultiplicityElement _this);
    
        int MultiplicityElement_UpperBound(MultiplicityElement _this);
    
        global::System.Collections.Generic.IList<PackageableElement> Namespace_ExcludeCollisions(Namespace _this, global::System.Collections.Generic.IList<PackageableElement> imps);
    
        global::System.Collections.Generic.IList<string> Namespace_GetNamesOfMember(Namespace _this, NamedElement element);
    
        global::System.Collections.Generic.IList<PackageableElement> Namespace_ImportMembers(Namespace _this, global::System.Collections.Generic.IList<PackageableElement> imps);
    
        bool Namespace_MembersAreDistinguishable(Namespace _this);
    
        bool OpaqueExpression_IsIntegral(OpaqueExpression _this);
    
        bool OpaqueExpression_IsNonNegative(OpaqueExpression _this);
    
        bool OpaqueExpression_IsPositive(OpaqueExpression _this);
    
        int OpaqueExpression_Value(OpaqueExpression _this);
    
        global::System.Collections.Generic.IList<Stereotype> Package_AllApplicableStereotypes(Package _this);
    
        Profile Package_ContainingProfile(Package _this);
    
        bool Package_MakesVisible(Package _this, NamedElement el);
    
        bool Package_MustBeOwned(Package _this);
    
        global::System.Collections.Generic.IList<PackageableElement> Package_VisibleMembers(Package _this);
    
        bool RedefinableElement_IsConsistentWith(RedefinableElement _this, RedefinableElement redefiningElement);
    
        bool RedefinableElement_IsRedefinitionContextValid(RedefinableElement _this, RedefinableElement redefinedElement);
    
        bool Operation_IsConsistentWith(Operation _this, RedefinableElement redefiningElement);
    
        global::System.Collections.Generic.IList<Parameter> Operation_ReturnResult(Operation _this);
    
        bool Property_IsAttribute(Property _this);
    
        bool Property_IsCompatibleWith(Property _this, ParameterableElement p);
    
        bool Property_IsConsistentWith(Property _this, RedefinableElement redefiningElement);
    
        bool Property_IsNavigable(Property _this);
    
        global::System.Collections.Generic.IList<Type> Property_SubsettingContext(Property _this);
    
        global::System.Collections.Generic.IList<Interface> Port_BasicProvided(Port _this);
    
        global::System.Collections.Generic.IList<Interface> Port_BasicRequired(Port _this);
    
        bool Pseudostate_IsConsistentWith(Pseudostate _this, RedefinableElement redefiningElement);
    
        global::System.Collections.Generic.IList<Property> ReadLinkAction_OpenEnd(ReadLinkAction _this);
    
        bool RedefinableTemplateSignature_IsConsistentWith(RedefinableTemplateSignature _this, RedefinableElement redefiningElement);
    
        bool Region_BelongsToPSM(Region _this);
    
        StateMachine Region_ContainingStateMachine(Region _this);
    
        bool Region_IsConsistentWith(Region _this, RedefinableElement redefiningElement);
    
        bool Region_IsRedefinitionContextValid(Region _this, RedefinableElement redefinedElement);
    
        global::System.Collections.Generic.IList<Parameter> StartObjectBehaviorAction_OutputParameters(StartObjectBehaviorAction _this);
    
        global::System.Collections.Generic.IList<Parameter> StartObjectBehaviorAction_InputParameters(StartObjectBehaviorAction _this);
    
        Behavior StartObjectBehaviorAction_Behavior(StartObjectBehaviorAction _this);
    
        bool TemplateableElement_IsTemplate(TemplateableElement _this);
    
        global::System.Collections.Generic.IList<ParameterableElement> TemplateableElement_ParameterableElements(TemplateableElement _this);
    
        StateMachine State_ContainingStateMachine(State _this);
    
        bool State_IsConsistentWith(State _this, RedefinableElement redefiningElement);
    
        global::System.Collections.Generic.IList<ConnectableElement> StructuredClassifier_AllRoles(StructuredClassifier _this);
    
        Region StateMachine_LCA(StateMachine _this, Vertex s1, Vertex s2);
    
        bool StateMachine_Ancestor(StateMachine _this, Vertex s1, Vertex s2);
    
        bool StateMachine_IsConsistentWith(StateMachine _this, RedefinableElement redefiningElement);
    
        bool StateMachine_IsRedefinitionContextValid(StateMachine _this, RedefinableElement redefinedElement);
    
        State StateMachine_LCAState(StateMachine _this, Vertex v1, Vertex v2);
    
        Profile Stereotype_ContainingProfile(Stereotype _this);
    
        string StringExpression_StringValue(StringExpression _this);
    
        global::System.Collections.Generic.IList<Action> StructuredActivityNode_AllActions(StructuredActivityNode _this);
    
        global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode_AllOwnedNodes(StructuredActivityNode _this);
    
        global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode_SourceNodes(StructuredActivityNode _this);
    
        global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode_TargetNodes(StructuredActivityNode _this);
    
        Activity StructuredActivityNode_ContainingActivity(StructuredActivityNode _this);
    
        StateMachine Transition_ContainingStateMachine(Transition _this);
    
        bool Transition_IsConsistentWith(Transition _this, RedefinableElement redefiningElement);
    
        bool Type_ConformsTo(Type _this, Type other);
    
        global::System.Collections.Generic.IList<UseCase> UseCase_AllIncludedUseCases(UseCase _this);
    
        bool ValueSpecification_BooleanValue(ValueSpecification _this);
    
        int ValueSpecification_IntegerValue(ValueSpecification _this);
    
        bool ValueSpecification_IsCompatibleWith(ValueSpecification _this, ParameterableElement p);
    
        bool ValueSpecification_IsComputable(ValueSpecification _this);
    
        bool ValueSpecification_IsNull(ValueSpecification _this);
    
        double ValueSpecification_RealValue(ValueSpecification _this);
    
        string ValueSpecification_StringValue(ValueSpecification _this);
    
        int ValueSpecification_UnlimitedValue(ValueSpecification _this);
    
        bool Variable_IsAccessibleBy(Variable _this, Action a);
    
        StateMachine Vertex_ContainingStateMachine(Vertex _this);
    
        bool Vertex_IsContainedInState(Vertex _this, State s);
    
        bool Vertex_IsContainedInRegion(Vertex _this, Region r);
    
        bool Vertex_IsConsistentWith(Vertex _this, RedefinableElement redefiningElement);
    
    }
}
