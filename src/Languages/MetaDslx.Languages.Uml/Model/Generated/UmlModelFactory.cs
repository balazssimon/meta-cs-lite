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
    
        /// <summary>
        /// An Abstraction is a Relationship that relates two Elements or sets of Elements that represent the same concept at different levels of abstraction or from different viewpoints.
        /// </summary>
        public Abstraction Abstraction(string? id = null)
        {
            return (Abstraction)Uml.AbstractionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An AcceptEventAction is an Action that waits for the occurrence of one or more specific Events.
        /// </summary>
        public AcceptEventAction AcceptEventAction(string? id = null)
        {
            return (AcceptEventAction)Uml.AcceptEventActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An AcceptCallAction is an AcceptEventAction that handles the receipt of a synchronous call request. In addition to the values from the Operation input parameters, the Action produces an output that is needed later to supply the information to the ReplyAction necessary to return control to the caller. An AcceptCallAction is for synchronous calls. If it is used to handle an asynchronous call, execution of the subsequent ReplyAction will complete immediately with no effect.
        /// </summary>
        public AcceptCallAction AcceptCallAction(string? id = null)
        {
            return (AcceptCallAction)Uml.AcceptCallActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An ActionExecutionSpecification is a kind of ExecutionSpecification representing the execution of an Action.
        /// </summary>
        public ActionExecutionSpecification ActionExecutionSpecification(string? id = null)
        {
            return (ActionExecutionSpecification)Uml.ActionExecutionSpecificationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An ActionInputPin is a kind of InputPin that executes an Action to determine the values to input to another Action.
        /// </summary>
        public ActionInputPin ActionInputPin(string? id = null)
        {
            return (ActionInputPin)Uml.ActionInputPinInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Class classifies a set of objects and specifies the features that characterize the structure and behavior of those objects.  A Class may have an internal structure and Ports.
        /// </summary>
        public Class Class(string? id = null)
        {
            return (Class)Uml.ClassInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An Activity is the specification of parameterized Behavior as the coordinated sequencing of subordinate units.
        /// </summary>
        public Activity Activity(string? id = null)
        {
            return (Activity)Uml.ActivityInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An ActivityFinalNode is a FinalNode that terminates the execution of its owning Activity or StructuredActivityNode.
        /// </summary>
        public ActivityFinalNode ActivityFinalNode(string? id = null)
        {
            return (ActivityFinalNode)Uml.ActivityFinalNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An ActivityParameterNode is an ObjectNode for accepting values from the input Parameters or providing values to the output Parameters of an Activity.
        /// </summary>
        public ActivityParameterNode ActivityParameterNode(string? id = null)
        {
            return (ActivityParameterNode)Uml.ActivityParameterNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An ActivityPartition is a kind of ActivityGroup for identifying ActivityNodes that have some characteristic in common.
        /// </summary>
        public ActivityPartition ActivityPartition(string? id = null)
        {
            return (ActivityPartition)Uml.ActivityPartitionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An Actor specifies a role played by a user or any other system that interacts with the subject.
        /// </summary>
        public Actor Actor(string? id = null)
        {
            return (Actor)Uml.ActorInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An AddStructuralFeatureValueAction is a WriteStructuralFeatureAction for adding values to a StructuralFeature.
        /// </summary>
        public AddStructuralFeatureValueAction AddStructuralFeatureValueAction(string? id = null)
        {
            return (AddStructuralFeatureValueAction)Uml.AddStructuralFeatureValueActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An AddVariableValueAction is a WriteVariableAction for adding values to a Variable.
        /// </summary>
        public AddVariableValueAction AddVariableValueAction(string? id = null)
        {
            return (AddVariableValueAction)Uml.AddVariableValueActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A trigger for an AnyReceiveEvent is triggered by the receipt of any message that is not explicitly handled by any related trigger.
        /// </summary>
        public AnyReceiveEvent AnyReceiveEvent(string? id = null)
        {
            return (AnyReceiveEvent)Uml.AnyReceiveEventInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A link is a tuple of values that refer to typed objects.  An Association classifies a set of links, each of which is an instance of the Association.  Each value in the link refers to an instance of the type of the corresponding end of the Association.
        /// </summary>
        public Association Association(string? id = null)
        {
            return (Association)Uml.AssociationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A model element that has both Association and Class properties. An AssociationClass can be seen as an Association that also has Class properties, or as a Class that also has Association properties. It not only connects a set of Classifiers but also defines a set of Features that belong to the Association itself and not to any of the associated Classifiers.
        /// </summary>
        public AssociationClass AssociationClass(string? id = null)
        {
            return (AssociationClass)Uml.AssociationClassInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A BehaviorExecutionSpecification is a kind of ExecutionSpecification representing the execution of a Behavior.
        /// </summary>
        public BehaviorExecutionSpecification BehaviorExecutionSpecification(string? id = null)
        {
            return (BehaviorExecutionSpecification)Uml.BehaviorExecutionSpecificationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A BroadcastSignalAction is an InvocationAction that transmits a Signal instance to all the potential target objects in the system. Values from the argument InputPins are used to provide values for the attributes of the Signal. The requestor continues execution immediately after the Signal instances are sent out and cannot receive reply values.
        /// </summary>
        public BroadcastSignalAction BroadcastSignalAction(string? id = null)
        {
            return (BroadcastSignalAction)Uml.BroadcastSignalActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A CallBehaviorAction is a CallAction that invokes a Behavior directly. The argument values of the CallBehaviorAction are passed on the input Parameters of the invoked Behavior. If the call is synchronous, the execution of the CallBehaviorAction waits until the execution of the invoked Behavior completes and the values of output Parameters of the Behavior are placed on the result OutputPins. If the call is asynchronous, the CallBehaviorAction completes immediately and no results values can be provided.
        /// </summary>
        public CallBehaviorAction CallBehaviorAction(string? id = null)
        {
            return (CallBehaviorAction)Uml.CallBehaviorActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A CallEvent models the receipt by an object of a message invoking a call of an Operation.
        /// </summary>
        public CallEvent CallEvent(string? id = null)
        {
            return (CallEvent)Uml.CallEventInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A CallOperationAction is a CallAction that transmits an Operation call request to the target object, where it may cause the invocation of associated Behavior. The argument values of the CallOperationAction are passed on the input Parameters of the Operation. If call is synchronous, the execution of the CallOperationAction waits until the execution of the invoked Operation completes and the values of output Parameters of the Operation are placed on the result OutputPins. If the call is asynchronous, the CallOperationAction completes immediately and no results values can be provided.
        /// </summary>
        public CallOperationAction CallOperationAction(string? id = null)
        {
            return (CallOperationAction)Uml.CallOperationActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A CentralBufferNode is an ObjectNode for managing flows from multiple sources and targets.
        /// </summary>
        public CentralBufferNode CentralBufferNode(string? id = null)
        {
            return (CentralBufferNode)Uml.CentralBufferNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ChangeEvent models a change in the system configuration that makes a condition true.
        /// </summary>
        public ChangeEvent ChangeEvent(string? id = null)
        {
            return (ChangeEvent)Uml.ChangeEventInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ClassifierTemplateParameter exposes a Classifier as a formal template parameter.
        /// </summary>
        public ClassifierTemplateParameter ClassifierTemplateParameter(string? id = null)
        {
            return (ClassifierTemplateParameter)Uml.ClassifierTemplateParameterInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Clause is an Element that represents a single branch of a ConditionalNode, including a test and a body section. The body section is executed only if (but not necessarily if) the test section evaluates to true.
        /// </summary>
        public Clause Clause(string? id = null)
        {
            return (Clause)Uml.ClauseInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ClearAssociationAction is an Action that destroys all links of an Association in which a particular object participates.
        /// </summary>
        public ClearAssociationAction ClearAssociationAction(string? id = null)
        {
            return (ClearAssociationAction)Uml.ClearAssociationActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ClearStructuralFeatureAction is a StructuralFeatureAction that removes all values of a StructuralFeature.
        /// </summary>
        public ClearStructuralFeatureAction ClearStructuralFeatureAction(string? id = null)
        {
            return (ClearStructuralFeatureAction)Uml.ClearStructuralFeatureActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ClearVariableAction is a VariableAction that removes all values of a Variable.
        /// </summary>
        public ClearVariableAction ClearVariableAction(string? id = null)
        {
            return (ClearVariableAction)Uml.ClearVariableActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Collaboration describes a structure of collaborating elements (roles), each performing a specialized function, which collectively accomplish some desired functionality.
        /// </summary>
        public Collaboration Collaboration(string? id = null)
        {
            return (Collaboration)Uml.CollaborationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A CollaborationUse is used to specify the application of a pattern specified by a Collaboration to a specific situation.
        /// </summary>
        public CollaborationUse CollaborationUse(string? id = null)
        {
            return (CollaborationUse)Uml.CollaborationUseInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A CombinedFragment defines an expression of InteractionFragments. A CombinedFragment is defined by an interaction operator and corresponding InteractionOperands. Through the use of CombinedFragments the user will be able to describe a number of traces in a compact and concise manner.
        /// </summary>
        public CombinedFragment CombinedFragment(string? id = null)
        {
            return (CombinedFragment)Uml.CombinedFragmentInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Comment is a textual annotation that can be attached to a set of Elements.
        /// </summary>
        public Comment Comment(string? id = null)
        {
            return (Comment)Uml.CommentInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A communication path is an association between two deployment targets, through which they are able to exchange signals and messages.
        /// </summary>
        public CommunicationPath CommunicationPath(string? id = null)
        {
            return (CommunicationPath)Uml.CommunicationPathInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Component represents a modular part of a system that encapsulates its contents and whose manifestation is replaceable within its environment.
        /// </summary>
        public Component Component(string? id = null)
        {
            return (Component)Uml.ComponentInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// Realization is specialized to (optionally) define the Classifiers that realize the contract offered by a Component in terms of its provided and required Interfaces. The Component forms an abstraction from these various Classifiers.
        /// </summary>
        public ComponentRealization ComponentRealization(string? id = null)
        {
            return (ComponentRealization)Uml.ComponentRealizationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ConditionalNode is a StructuredActivityNode that chooses one among some number of alternative collections of ExecutableNodes to execute.
        /// </summary>
        public ConditionalNode ConditionalNode(string? id = null)
        {
            return (ConditionalNode)Uml.ConditionalNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ConnectableElementTemplateParameter exposes a ConnectableElement as a formal parameter for a template.
        /// </summary>
        public ConnectableElementTemplateParameter ConnectableElementTemplateParameter(string? id = null)
        {
            return (ConnectableElementTemplateParameter)Uml.ConnectableElementTemplateParameterInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ConnectionPointReference represents a usage (as part of a submachine State) of an entry/exit point Pseudostate defined in the StateMachine referenced by the submachine State.
        /// </summary>
        public ConnectionPointReference ConnectionPointReference(string? id = null)
        {
            return (ConnectionPointReference)Uml.ConnectionPointReferenceInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Connector specifies links that enables communication between two or more instances. In contrast to Associations, which specify links between any instance of the associated Classifiers, Connectors specify links between instances playing the connected parts only.
        /// </summary>
        public Connector Connector(string? id = null)
        {
            return (Connector)Uml.ConnectorInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ConnectorEnd is an endpoint of a Connector, which attaches the Connector to a ConnectableElement.
        /// </summary>
        public ConnectorEnd ConnectorEnd(string? id = null)
        {
            return (ConnectorEnd)Uml.ConnectorEndInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ConsiderIgnoreFragment is a kind of CombinedFragment that is used for the consider and ignore cases, which require lists of pertinent Messages to be specified.
        /// </summary>
        public ConsiderIgnoreFragment ConsiderIgnoreFragment(string? id = null)
        {
            return (ConsiderIgnoreFragment)Uml.ConsiderIgnoreFragmentInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Constraint is a condition or restriction expressed in natural language text or in a machine readable language for the purpose of declaring some of the semantics of an Element or set of Elements.
        /// </summary>
        public Constraint Constraint(string? id = null)
        {
            return (Constraint)Uml.ConstraintInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Continuation is a syntactic way to define continuations of different branches of an alternative CombinedFragment. Continuations are intuitively similar to labels representing intermediate points in a flow of control.
        /// </summary>
        public Continuation Continuation(string? id = null)
        {
            return (Continuation)Uml.ContinuationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ControlFlow is an ActivityEdge traversed by control tokens or object tokens of control type, which are use to control the execution of ExecutableNodes.
        /// </summary>
        public ControlFlow ControlFlow(string? id = null)
        {
            return (ControlFlow)Uml.ControlFlowInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A CreateLinkAction is a WriteLinkAction for creating links.
        /// </summary>
        public CreateLinkAction CreateLinkAction(string? id = null)
        {
            return (CreateLinkAction)Uml.CreateLinkActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A CreateLinkObjectAction is a CreateLinkAction for creating link objects (AssociationClasse instances).
        /// </summary>
        public CreateLinkObjectAction CreateLinkObjectAction(string? id = null)
        {
            return (CreateLinkObjectAction)Uml.CreateLinkObjectActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A CreateObjectAction is an Action that creates an instance of the specified Classifier.
        /// </summary>
        public CreateObjectAction CreateObjectAction(string? id = null)
        {
            return (CreateObjectAction)Uml.CreateObjectActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A DataStoreNode is a CentralBufferNode for persistent data.
        /// </summary>
        public DataStoreNode DataStoreNode(string? id = null)
        {
            return (DataStoreNode)Uml.DataStoreNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A DataType is a type whose instances are identified only by their value.
        /// </summary>
        public DataType DataType(string? id = null)
        {
            return (DataType)Uml.DataTypeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A DecisionNode is a ControlNode that chooses between outgoing ActivityEdges for the routing of tokens.
        /// </summary>
        public DecisionNode DecisionNode(string? id = null)
        {
            return (DecisionNode)Uml.DecisionNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Dependency is a Relationship that signifies that a single model Element or a set of model Elements requires other model Elements for their specification or implementation. This means that the complete semantics of the client Element(s) are either semantically or structurally dependent on the definition of the supplier Element(s).
        /// </summary>
        public Dependency Dependency(string? id = null)
        {
            return (Dependency)Uml.DependencyInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A DestroyLinkAction is a WriteLinkAction that destroys links (including link objects).
        /// </summary>
        public DestroyLinkAction DestroyLinkAction(string? id = null)
        {
            return (DestroyLinkAction)Uml.DestroyLinkActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A DestroyObjectAction is an Action that destroys objects.
        /// </summary>
        public DestroyObjectAction DestroyObjectAction(string? id = null)
        {
            return (DestroyObjectAction)Uml.DestroyObjectActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A DestructionOccurenceSpecification models the destruction of an object.
        /// </summary>
        public DestructionOccurrenceSpecification DestructionOccurrenceSpecification(string? id = null)
        {
            return (DestructionOccurrenceSpecification)Uml.DestructionOccurrenceSpecificationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An ElementImport identifies a NamedElement in a Namespace other than the one that owns that NamedElement and allows the NamedElement to be referenced using an unqualified name in the Namespace owning the ElementImport.
        /// </summary>
        public ElementImport ElementImport(string? id = null)
        {
            return (ElementImport)Uml.ElementImportInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An ExceptionHandler is an Element that specifies a handlerBody ExecutableNode to execute in case the specified exception occurs during the execution of the protected ExecutableNode.
        /// </summary>
        public ExceptionHandler ExceptionHandler(string? id = null)
        {
            return (ExceptionHandler)Uml.ExceptionHandlerInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An ExecutionOccurrenceSpecification represents moments in time at which Actions or Behaviors start or finish.
        /// </summary>
        public ExecutionOccurrenceSpecification ExecutionOccurrenceSpecification(string? id = null)
        {
            return (ExecutionOccurrenceSpecification)Uml.ExecutionOccurrenceSpecificationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An ExpansionNode is an ObjectNode used to indicate a collection input or output for an ExpansionRegion. A collection input of an ExpansionRegion contains a collection that is broken into its individual elements inside the region, whose content is executed once per element. A collection output of an ExpansionRegion combines individual elements produced by the execution of the region into a collection for use outside the region.
        /// </summary>
        public ExpansionNode ExpansionNode(string? id = null)
        {
            return (ExpansionNode)Uml.ExpansionNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An ExpansionRegion is a StructuredActivityNode that executes its content multiple times corresponding to elements of input collection(s).
        /// </summary>
        public ExpansionRegion ExpansionRegion(string? id = null)
        {
            return (ExpansionRegion)Uml.ExpansionRegionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A relationship from an extending UseCase to an extended UseCase that specifies how and when the behavior defined in the extending UseCase can be inserted into the behavior defined in the extended UseCase.
        /// </summary>
        public Extend Extend(string? id = null)
        {
            return (Extend)Uml.ExtendInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An extension end is used to tie an extension to a stereotype when extending a metaclass.
        /// The default multiplicity of an extension end is 0..1.
        /// </summary>
        public ExtensionEnd ExtensionEnd(string? id = null)
        {
            return (ExtensionEnd)Uml.ExtensionEndInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An ExtensionPoint identifies a point in the behavior of a UseCase where that behavior can be extended by the behavior of some other (extending) UseCase, as specified by an Extend relationship.
        /// </summary>
        public ExtensionPoint ExtensionPoint(string? id = null)
        {
            return (ExtensionPoint)Uml.ExtensionPointInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A special kind of State, which, when entered, signifies that the enclosing Region has completed. If the enclosing Region is directly contained in a StateMachine and all other Regions in that StateMachine also are completed, then it means that the entire StateMachine behavior is completed.
        /// </summary>
        public FinalState FinalState(string? id = null)
        {
            return (FinalState)Uml.FinalStateInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A FlowFinalNode is a FinalNode that terminates a flow by consuming the tokens offered to it.
        /// </summary>
        public FlowFinalNode FlowFinalNode(string? id = null)
        {
            return (FlowFinalNode)Uml.FlowFinalNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ForkNode is a ControlNode that splits a flow into multiple concurrent flows.
        /// </summary>
        public ForkNode ForkNode(string? id = null)
        {
            return (ForkNode)Uml.ForkNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Gate is a MessageEnd which serves as a connection point for relating a Message which has a MessageEnd (sendEvent / receiveEvent) outside an InteractionFragment with another Message which has a MessageEnd (receiveEvent / sendEvent)  inside that InteractionFragment.
        /// </summary>
        public Gate Gate(string? id = null)
        {
            return (Gate)Uml.GateInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Generalization is a taxonomic relationship between a more general Classifier and a more specific Classifier. Each instance of the specific Classifier is also an instance of the general Classifier. The specific Classifier inherits the features of the more general Classifier. A Generalization is owned by the specific Classifier.
        /// </summary>
        public Generalization Generalization(string? id = null)
        {
            return (Generalization)Uml.GeneralizationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A GeneralOrdering represents a binary relation between two OccurrenceSpecifications, to describe that one OccurrenceSpecification must occur before the other in a valid trace. This mechanism provides the ability to define partial orders of OccurrenceSpecifications that may otherwise not have a specified order.
        /// </summary>
        public GeneralOrdering GeneralOrdering(string? id = null)
        {
            return (GeneralOrdering)Uml.GeneralOrderingInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// Physical definition of a graphical image.
        /// </summary>
        public Image Image(string? id = null)
        {
            return (Image)Uml.ImageInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An Include relationship specifies that a UseCase contains the behavior defined in another UseCase.
        /// </summary>
        public Include Include(string? id = null)
        {
            return (Include)Uml.IncludeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An InitialNode is a ControlNode that offers a single control token when initially enabled.
        /// </summary>
        public InitialNode InitialNode(string? id = null)
        {
            return (InitialNode)Uml.InitialNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An InputPin is a Pin that holds input values to be consumed by an Action.
        /// </summary>
        public InputPin InputPin(string? id = null)
        {
            return (InputPin)Uml.InputPinInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An artifact is the specification of a physical piece of information that is used or produced by a software development process, or by deployment and operation of a system. Examples of artifacts include model files, source files, scripts, and binary executable files, a table in a database system, a development deliverable, or a word-processing document, a mail message.
        /// An artifact is the source of a deployment to a node.
        /// </summary>
        public Artifact Artifact(string? id = null)
        {
            return (Artifact)Uml.ArtifactInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A deployment is the allocation of an artifact or artifact instance to a deployment target.
        /// A component deployment is the deployment of one or more artifacts or artifact instances to a deployment target, optionally parameterized by a deployment specification. Examples are executables and configuration files.
        /// </summary>
        public Deployment Deployment(string? id = null)
        {
            return (Deployment)Uml.DeploymentInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A deployment specification specifies a set of properties that determine execution parameters of a component artifact that is deployed on a node. A deployment specification can be aimed at a specific type of container. An artifact that reifies or implements deployment specification properties is a deployment descriptor.
        /// </summary>
        public DeploymentSpecification DeploymentSpecification(string? id = null)
        {
            return (DeploymentSpecification)Uml.DeploymentSpecificationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Duration is a ValueSpecification that specifies the temporal distance between two time instants.
        /// </summary>
        public Duration Duration(string? id = null)
        {
            return (Duration)Uml.DurationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A DurationConstraint is a Constraint that refers to a DurationInterval.
        /// </summary>
        public DurationConstraint DurationConstraint(string? id = null)
        {
            return (DurationConstraint)Uml.DurationConstraintInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A DurationInterval defines the range between two Durations.
        /// </summary>
        public DurationInterval DurationInterval(string? id = null)
        {
            return (DurationInterval)Uml.DurationIntervalInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A DurationObservation is a reference to a duration during an execution. It points out the NamedElement(s) in the model to observe and whether the observations are when this NamedElement is entered or when it is exited.
        /// </summary>
        public DurationObservation DurationObservation(string? id = null)
        {
            return (DurationObservation)Uml.DurationObservationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A device is a physical computational resource with processing capability upon which artifacts may be deployed for execution. Devices may be complex (i.e., they may consist of other devices).
        /// </summary>
        public Device Device(string? id = null)
        {
            return (Device)Uml.DeviceInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An Enumeration is a DataType whose values are enumerated in the model as EnumerationLiterals.
        /// </summary>
        public Enumeration Enumeration(string? id = null)
        {
            return (Enumeration)Uml.EnumerationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An EnumerationLiteral is a user-defined data value for an Enumeration.
        /// </summary>
        public EnumerationLiteral EnumerationLiteral(string? id = null)
        {
            return (EnumerationLiteral)Uml.EnumerationLiteralInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An execution environment is a node that offers an execution environment for specific types of components that are deployed on it in the form of executable artifacts.
        /// </summary>
        public ExecutionEnvironment ExecutionEnvironment(string? id = null)
        {
            return (ExecutionEnvironment)Uml.ExecutionEnvironmentInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An Expression represents a node in an expression tree, which may be non-terminal or terminal. It defines a symbol, and has a possibly empty sequence of operands that are ValueSpecifications. It denotes a (possibly empty) set of values when evaluated in a context.
        /// </summary>
        public Expression Expression(string? id = null)
        {
            return (Expression)Uml.ExpressionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An extension is used to indicate that the properties of a metaclass are extended through a stereotype, and gives the ability to flexibly add (and later remove) stereotypes to classes.
        /// </summary>
        public Extension Extension(string? id = null)
        {
            return (Extension)Uml.ExtensionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A FunctionBehavior is an OpaqueBehavior that does not access or modify any objects or other external data.
        /// </summary>
        public FunctionBehavior FunctionBehavior(string? id = null)
        {
            return (FunctionBehavior)Uml.FunctionBehaviorInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A GeneralizationSet is a PackageableElement whose instances represent sets of Generalization relationships.
        /// </summary>
        public GeneralizationSet GeneralizationSet(string? id = null)
        {
            return (GeneralizationSet)Uml.GeneralizationSetInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// InformationFlows describe circulation of information through a system in a general manner. They do not specify the nature of the information, mechanisms by which it is conveyed, sequences of exchange or any control conditions. During more detailed modeling, representation and realization links may be added to specify which model elements implement an InformationFlow and to show how information is conveyed.  InformationFlows require some kind of “information channel” for unidirectional transmission of information items from sources to targets.  They specify the information channel’s realizations, if any, and identify the information that flows along them.  Information moving along the information channel may be represented by abstract InformationItems and by concrete Classifiers.
        /// </summary>
        public InformationFlow InformationFlow(string? id = null)
        {
            return (InformationFlow)Uml.InformationFlowInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// InformationItems represent many kinds of information that can flow from sources to targets in very abstract ways.  They represent the kinds of information that may move within a system, but do not elaborate details of the transferred information.  Details of transferred information are the province of other Classifiers that may ultimately define InformationItems.  Consequently, InformationItems cannot be instantiated and do not themselves have features, generalizations, or associations. An important use of InformationItems is to represent information during early design stages, possibly before the detailed modeling decisions that will ultimately define them have been made. Another purpose of InformationItems is to abstract portions of complex models in less precise, but perhaps more general and communicable, ways.
        /// </summary>
        public InformationItem InformationItem(string? id = null)
        {
            return (InformationItem)Uml.InformationItemInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An InstanceSpecification is a model element that represents an instance in a modeled system. An InstanceSpecification can act as a DeploymentTarget in a Deployment relationship, in the case that it represents an instance of a Node. It can also act as a DeployedArtifact, if it represents an instance of an Artifact.
        /// </summary>
        public InstanceSpecification InstanceSpecification(string? id = null)
        {
            return (InstanceSpecification)Uml.InstanceSpecificationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An InstanceValue is a ValueSpecification that identifies an instance.
        /// </summary>
        public InstanceValue InstanceValue(string? id = null)
        {
            return (InstanceValue)Uml.InstanceValueInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An Interaction is a unit of Behavior that focuses on the observable exchange of information between connectable elements.
        /// </summary>
        public Interaction Interaction(string? id = null)
        {
            return (Interaction)Uml.InteractionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An InteractionConstraint is a Boolean expression that guards an operand in a CombinedFragment.
        /// </summary>
        public InteractionConstraint InteractionConstraint(string? id = null)
        {
            return (InteractionConstraint)Uml.InteractionConstraintInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An InteractionOperand is contained in a CombinedFragment. An InteractionOperand represents one operand of the expression given by the enclosing CombinedFragment.
        /// </summary>
        public InteractionOperand InteractionOperand(string? id = null)
        {
            return (InteractionOperand)Uml.InteractionOperandInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An InteractionUse refers to an Interaction. The InteractionUse is a shorthand for copying the contents of the referenced Interaction where the InteractionUse is. To be accurate the copying must take into account substituting parameters with arguments and connect the formal Gates with the actual ones.
        /// </summary>
        public InteractionUse InteractionUse(string? id = null)
        {
            return (InteractionUse)Uml.InteractionUseInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// Interfaces declare coherent services that are implemented by BehavioredClassifiers that implement the Interfaces via InterfaceRealizations.
        /// </summary>
        public Interface Interface(string? id = null)
        {
            return (Interface)Uml.InterfaceInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An InterfaceRealization is a specialized realization relationship between a BehavioredClassifier and an Interface. This relationship signifies that the realizing BehavioredClassifier conforms to the contract specified by the Interface.
        /// </summary>
        public InterfaceRealization InterfaceRealization(string? id = null)
        {
            return (InterfaceRealization)Uml.InterfaceRealizationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An InterruptibleActivityRegion is an ActivityGroup that supports the termination of tokens flowing in the portions of an activity within it.
        /// </summary>
        public InterruptibleActivityRegion InterruptibleActivityRegion(string? id = null)
        {
            return (InterruptibleActivityRegion)Uml.InterruptibleActivityRegionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An Interval defines the range between two ValueSpecifications.
        /// </summary>
        public Interval Interval(string? id = null)
        {
            return (Interval)Uml.IntervalInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An IntervalConstraint is a Constraint that is specified by an Interval.
        /// </summary>
        public IntervalConstraint IntervalConstraint(string? id = null)
        {
            return (IntervalConstraint)Uml.IntervalConstraintInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A JoinNode is a ControlNode that synchronizes multiple flows.
        /// </summary>
        public JoinNode JoinNode(string? id = null)
        {
            return (JoinNode)Uml.JoinNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Lifeline represents an individual participant in the Interaction. While parts and structural features may have multiplicity greater than 1, Lifelines represent only one interacting entity.
        /// </summary>
        public Lifeline Lifeline(string? id = null)
        {
            return (Lifeline)Uml.LifelineInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// LinkEndData is an Element that identifies on end of a link to be read or written by a LinkAction. As a link (that is not a link object) cannot be passed as a runtime value to or from an Action, it is instead identified by its end objects and qualifier values, if any. A LinkEndData instance provides these values for a single Association end.
        /// </summary>
        public LinkEndData LinkEndData(string? id = null)
        {
            return (LinkEndData)Uml.LinkEndDataInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// LinkEndCreationData is LinkEndData used to provide values for one end of a link to be created by a CreateLinkAction.
        /// </summary>
        public LinkEndCreationData LinkEndCreationData(string? id = null)
        {
            return (LinkEndCreationData)Uml.LinkEndCreationDataInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// LinkEndDestructionData is LinkEndData used to provide values for one end of a link to be destroyed by a DestroyLinkAction.
        /// </summary>
        public LinkEndDestructionData LinkEndDestructionData(string? id = null)
        {
            return (LinkEndDestructionData)Uml.LinkEndDestructionDataInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A LiteralBoolean is a specification of a Boolean value.
        /// </summary>
        public LiteralBoolean LiteralBoolean(string? id = null)
        {
            return (LiteralBoolean)Uml.LiteralBooleanInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A LiteralInteger is a specification of an Integer value.
        /// </summary>
        public LiteralInteger LiteralInteger(string? id = null)
        {
            return (LiteralInteger)Uml.LiteralIntegerInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A LiteralNull specifies the lack of a value.
        /// </summary>
        public LiteralNull LiteralNull(string? id = null)
        {
            return (LiteralNull)Uml.LiteralNullInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A LiteralReal is a specification of a Real value.
        /// </summary>
        public LiteralReal LiteralReal(string? id = null)
        {
            return (LiteralReal)Uml.LiteralRealInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A LiteralString is a specification of a String value.
        /// </summary>
        public LiteralString LiteralString(string? id = null)
        {
            return (LiteralString)Uml.LiteralStringInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A LiteralUnlimitedNatural is a specification of an UnlimitedNatural number.
        /// </summary>
        public LiteralUnlimitedNatural LiteralUnlimitedNatural(string? id = null)
        {
            return (LiteralUnlimitedNatural)Uml.LiteralUnlimitedNaturalInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A LoopNode is a StructuredActivityNode that represents an iterative loop with setup, test, and body sections.
        /// </summary>
        public LoopNode LoopNode(string? id = null)
        {
            return (LoopNode)Uml.LoopNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A manifestation is the concrete physical rendering of one or more model elements by an artifact.
        /// </summary>
        public Manifestation Manifestation(string? id = null)
        {
            return (Manifestation)Uml.ManifestationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A merge node is a control node that brings together multiple alternate flows. It is not used to synchronize concurrent flows but to accept one among several alternate flows.
        /// </summary>
        public MergeNode MergeNode(string? id = null)
        {
            return (MergeNode)Uml.MergeNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Message defines a particular communication between Lifelines of an Interaction.
        /// </summary>
        public Message Message(string? id = null)
        {
            return (Message)Uml.MessageInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A model captures a view of a physical system. It is an abstraction of the physical system, with a certain purpose. This purpose determines what is to be included in the model and what is irrelevant. Thus the model completely describes those aspects of the physical system that are relevant to the purpose of the model, at the appropriate level of detail.
        /// </summary>
        public Model Model(string? id = null)
        {
            return (Model)Uml.ModelInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Node is computational resource upon which artifacts may be deployed for execution. Nodes can be interconnected through communication paths to define network structures.
        /// </summary>
        public Node Node(string? id = null)
        {
            return (Node)Uml.NodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An ObjectFlow is an ActivityEdge that is traversed by object tokens that may hold values. Object flows also support multicast/receive, token selection from object nodes, and transformation of tokens.
        /// </summary>
        public ObjectFlow ObjectFlow(string? id = null)
        {
            return (ObjectFlow)Uml.ObjectFlowInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An OccurrenceSpecification is the basic semantic unit of Interactions. The sequences of occurrences specified by them are the meanings of Interactions.
        /// </summary>
        public OccurrenceSpecification OccurrenceSpecification(string? id = null)
        {
            return (OccurrenceSpecification)Uml.OccurrenceSpecificationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A MessageOccurrenceSpecification specifies the occurrence of Message events, such as sending and receiving of Signals or invoking or receiving of Operation calls. A MessageOccurrenceSpecification is a kind of MessageEnd. Messages are generated either by synchronous Operation calls or asynchronous Signal sends. They are received by the execution of corresponding AcceptEventActions.
        /// </summary>
        public MessageOccurrenceSpecification MessageOccurrenceSpecification(string? id = null)
        {
            return (MessageOccurrenceSpecification)Uml.MessageOccurrenceSpecificationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An OpaqueExpression is a ValueSpecification that specifies the computation of a collection of values either in terms of a UML Behavior or based on a textual statement in a language other than UML
        /// </summary>
        public OpaqueExpression OpaqueExpression(string? id = null)
        {
            return (OpaqueExpression)Uml.OpaqueExpressionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An OperationTemplateParameter exposes an Operation as a formal parameter for a template.
        /// </summary>
        public OperationTemplateParameter OperationTemplateParameter(string? id = null)
        {
            return (OperationTemplateParameter)Uml.OperationTemplateParameterInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A package can have one or more profile applications to indicate which profiles have been applied. Because a profile is a package, it is possible to apply a profile not only to packages, but also to profiles.
        /// Package specializes TemplateableElement and PackageableElement specializes ParameterableElement to specify that a package can be used as a template and a PackageableElement as a template parameter.
        /// A package is used to group elements, and provides a namespace for the grouped elements.
        /// </summary>
        public Package Package(string? id = null)
        {
            return (Package)Uml.PackageInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A PackageImport is a Relationship that imports all the non-private members of a Package into the Namespace owning the PackageImport, so that those Elements may be referred to by their unqualified names in the importingNamespace.
        /// </summary>
        public PackageImport PackageImport(string? id = null)
        {
            return (PackageImport)Uml.PackageImportInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A package merge defines how the contents of one package are extended by the contents of another package.
        /// </summary>
        public PackageMerge PackageMerge(string? id = null)
        {
            return (PackageMerge)Uml.PackageMergeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Parameter is a specification of an argument used to pass information into or out of an invocation of a BehavioralFeature.  Parameters can be treated as ConnectableElements within Collaborations.
        /// </summary>
        public Parameter Parameter(string? id = null)
        {
            return (Parameter)Uml.ParameterInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ParameterSet designates alternative sets of inputs or outputs that a Behavior may use.
        /// </summary>
        public ParameterSet ParameterSet(string? id = null)
        {
            return (ParameterSet)Uml.ParameterSetInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A PartDecomposition is a description of the internal Interactions of one Lifeline relative to an Interaction.
        /// </summary>
        public PartDecomposition PartDecomposition(string? id = null)
        {
            return (PartDecomposition)Uml.PartDecompositionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An OpaqueAction is an Action whose functionality is not specified within UML.
        /// </summary>
        public OpaqueAction OpaqueAction(string? id = null)
        {
            return (OpaqueAction)Uml.OpaqueActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An OpaqueBehavior is a Behavior whose specification is given in a textual language other than UML.
        /// </summary>
        public OpaqueBehavior OpaqueBehavior(string? id = null)
        {
            return (OpaqueBehavior)Uml.OpaqueBehaviorInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An Operation is a BehavioralFeature of a Classifier that specifies the name, type, parameters, and constraints for invoking an associated Behavior. An Operation may invoke both the execution of method behaviors as well as other behavioral responses. Operation specializes TemplateableElement in order to support specification of template operations and bound operations. Operation specializes ParameterableElement to specify that an operation can be exposed as a formal template parameter, and provided as an actual parameter in a binding of a template.
        /// </summary>
        public Operation Operation(string? id = null)
        {
            return (Operation)Uml.OperationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An OutputPin is a Pin that holds output values produced by an Action.
        /// </summary>
        public OutputPin OutputPin(string? id = null)
        {
            return (OutputPin)Uml.OutputPinInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Property is a StructuralFeature. A Property related by ownedAttribute to a Classifier (other than an association) represents an attribute and might also represent an association end. It relates an instance of the Classifier to a value or set of values of the type of the attribute. A Property related by memberEnd to an Association represents an end of the Association. The type of the Property is the type of the end of the Association. A Property has the capability of being a DeploymentTarget in a Deployment relationship. This enables modeling the deployment to hierarchical nodes that have Properties functioning as internal parts.  Property specializes ParameterableElement to specify that a Property can be exposed as a formal template parameter, and provided as an actual parameter in a binding of a template.
        /// </summary>
        public Property Property(string? id = null)
        {
            return (Property)Uml.PropertyInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Port is a property of an EncapsulatedClassifier that specifies a distinct interaction point between that EncapsulatedClassifier and its environment or between the (behavior of the) EncapsulatedClassifier and its internal parts. Ports are connected to Properties of the EncapsulatedClassifier by Connectors through which requests can be made to invoke BehavioralFeatures. A Port may specify the services an EncapsulatedClassifier provides (offers) to its environment as well as the services that an EncapsulatedClassifier expects (requires) of its environment.  A Port may have an associated ProtocolStateMachine.
        /// </summary>
        public Port Port(string? id = null)
        {
            return (Port)Uml.PortInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A PrimitiveType defines a predefined DataType, without any substructure. A PrimitiveType may have an algebra and operations defined outside of UML, for example, mathematically.
        /// </summary>
        public PrimitiveType PrimitiveType(string? id = null)
        {
            return (PrimitiveType)Uml.PrimitiveTypeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A profile defines limited extensions to a reference metamodel with the purpose of adapting the metamodel to a specific platform or domain.
        /// </summary>
        public Profile Profile(string? id = null)
        {
            return (Profile)Uml.ProfileInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A profile application is used to show which profiles have been applied to a package.
        /// </summary>
        public ProfileApplication ProfileApplication(string? id = null)
        {
            return (ProfileApplication)Uml.ProfileApplicationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ProtocolStateMachine can be redefined into a more specific ProtocolStateMachine or into behavioral StateMachine. ProtocolConformance declares that the specific ProtocolStateMachine specifies a protocol that conforms to the general ProtocolStateMachine or that the specific behavioral StateMachine abides by the protocol of the general ProtocolStateMachine.
        /// </summary>
        public ProtocolConformance ProtocolConformance(string? id = null)
        {
            return (ProtocolConformance)Uml.ProtocolConformanceInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ProtocolStateMachine is always defined in the context of a Classifier. It specifies which BehavioralFeatures of the Classifier can be called in which State and under which conditions, thus specifying the allowed invocation sequences on the Classifier&apos;s BehavioralFeatures. A ProtocolStateMachine specifies the possible and permitted Transitions on the instances of its context Classifier, together with the BehavioralFeatures that carry the Transitions. In this manner, an instance lifecycle can be specified for a Classifier, by defining the order in which the BehavioralFeatures can be activated and the States through which an instance progresses during its existence.
        /// </summary>
        public ProtocolStateMachine ProtocolStateMachine(string? id = null)
        {
            return (ProtocolStateMachine)Uml.ProtocolStateMachineInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ProtocolTransition specifies a legal Transition for an Operation. Transitions of ProtocolStateMachines have the following information: a pre-condition (guard), a Trigger, and a post-condition. Every ProtocolTransition is associated with at most one BehavioralFeature belonging to the context Classifier of the ProtocolStateMachine.
        /// </summary>
        public ProtocolTransition ProtocolTransition(string? id = null)
        {
            return (ProtocolTransition)Uml.ProtocolTransitionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Pseudostate is an abstraction that encompasses different types of transient Vertices in the StateMachine graph. A StateMachine instance never comes to rest in a Pseudostate, instead, it will exit and enter the Pseudostate within a single run-to-completion step.
        /// </summary>
        public Pseudostate Pseudostate(string? id = null)
        {
            return (Pseudostate)Uml.PseudostateInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A QualifierValue is an Element that is used as part of LinkEndData to provide the value for a single qualifier of the end given by the LinkEndData.
        /// </summary>
        public QualifierValue QualifierValue(string? id = null)
        {
            return (QualifierValue)Uml.QualifierValueInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A RaiseExceptionAction is an Action that causes an exception to occur. The input value becomes the exception object.
        /// </summary>
        public RaiseExceptionAction RaiseExceptionAction(string? id = null)
        {
            return (RaiseExceptionAction)Uml.RaiseExceptionActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ReadExtentAction is an Action that retrieves the current instances of a Classifier.
        /// </summary>
        public ReadExtentAction ReadExtentAction(string? id = null)
        {
            return (ReadExtentAction)Uml.ReadExtentActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ReadIsClassifiedObjectAction is an Action that determines whether an object is classified by a given Classifier.
        /// </summary>
        public ReadIsClassifiedObjectAction ReadIsClassifiedObjectAction(string? id = null)
        {
            return (ReadIsClassifiedObjectAction)Uml.ReadIsClassifiedObjectActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ReadLinkAction is a LinkAction that navigates across an Association to retrieve the objects on one end.
        /// </summary>
        public ReadLinkAction ReadLinkAction(string? id = null)
        {
            return (ReadLinkAction)Uml.ReadLinkActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ReadLinkObjectEndAction is an Action that retrieves an end object from a link object.
        /// </summary>
        public ReadLinkObjectEndAction ReadLinkObjectEndAction(string? id = null)
        {
            return (ReadLinkObjectEndAction)Uml.ReadLinkObjectEndActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ReadLinkObjectEndQualifierAction is an Action that retrieves a qualifier end value from a link object.
        /// </summary>
        public ReadLinkObjectEndQualifierAction ReadLinkObjectEndQualifierAction(string? id = null)
        {
            return (ReadLinkObjectEndQualifierAction)Uml.ReadLinkObjectEndQualifierActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ReadSelfAction is an Action that retrieves the context object of the Behavior execution within which the ReadSelfAction execution is taking place.
        /// </summary>
        public ReadSelfAction ReadSelfAction(string? id = null)
        {
            return (ReadSelfAction)Uml.ReadSelfActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ReadStructuralFeatureAction is a StructuralFeatureAction that retrieves the values of a StructuralFeature.
        /// </summary>
        public ReadStructuralFeatureAction ReadStructuralFeatureAction(string? id = null)
        {
            return (ReadStructuralFeatureAction)Uml.ReadStructuralFeatureActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ReadVariableAction is a VariableAction that retrieves the values of a Variable.
        /// </summary>
        public ReadVariableAction ReadVariableAction(string? id = null)
        {
            return (ReadVariableAction)Uml.ReadVariableActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// Realization is a specialized Abstraction relationship between two sets of model Elements, one representing a specification (the supplier) and the other represents an implementation of the latter (the client). Realization can be used to model stepwise refinement, optimizations, transformations, templates, model synthesis, framework composition, etc.
        /// </summary>
        public Realization Realization(string? id = null)
        {
            return (Realization)Uml.RealizationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Reception is a declaration stating that a Classifier is prepared to react to the receipt of a Signal.
        /// </summary>
        public Reception Reception(string? id = null)
        {
            return (Reception)Uml.ReceptionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ReclassifyObjectAction is an Action that changes the Classifiers that classify an object.
        /// </summary>
        public ReclassifyObjectAction ReclassifyObjectAction(string? id = null)
        {
            return (ReclassifyObjectAction)Uml.ReclassifyObjectActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A RedefinableTemplateSignature supports the addition of formal template parameters in a specialization of a template classifier.
        /// </summary>
        public RedefinableTemplateSignature RedefinableTemplateSignature(string? id = null)
        {
            return (RedefinableTemplateSignature)Uml.RedefinableTemplateSignatureInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ReduceAction is an Action that reduces a collection to a single value by repeatedly combining the elements of the collection using a reducer Behavior.
        /// </summary>
        public ReduceAction ReduceAction(string? id = null)
        {
            return (ReduceAction)Uml.ReduceActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Region is a top-level part of a StateMachine or a composite State, that serves as a container for the Vertices and Transitions of the StateMachine. A StateMachine or composite State may contain multiple Regions representing behaviors that may occur in parallel.
        /// </summary>
        public Region Region(string? id = null)
        {
            return (Region)Uml.RegionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A RemoveStructuralFeatureValueAction is a WriteStructuralFeatureAction that removes values from a StructuralFeature.
        /// </summary>
        public RemoveStructuralFeatureValueAction RemoveStructuralFeatureValueAction(string? id = null)
        {
            return (RemoveStructuralFeatureValueAction)Uml.RemoveStructuralFeatureValueActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A RemoveVariableValueAction is a WriteVariableAction that removes values from a Variables.
        /// </summary>
        public RemoveVariableValueAction RemoveVariableValueAction(string? id = null)
        {
            return (RemoveVariableValueAction)Uml.RemoveVariableValueActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ReplyAction is an Action that accepts a set of reply values and a value containing return information produced by a previous AcceptCallAction. The ReplyAction returns the values to the caller of the previous call, completing execution of the call.
        /// </summary>
        public ReplyAction ReplyAction(string? id = null)
        {
            return (ReplyAction)Uml.ReplyActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A SendObjectAction is an InvocationAction that transmits an input object to the target object, which is handled as a request message by the target object. The requestor continues execution immediately after the object is sent out and cannot receive reply values.
        /// </summary>
        public SendObjectAction SendObjectAction(string? id = null)
        {
            return (SendObjectAction)Uml.SendObjectActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A SendSignalAction is an InvocationAction that creates a Signal instance and transmits it to the target object. Values from the argument InputPins are used to provide values for the attributes of the Signal. The requestor continues execution immediately after the Signal instance is sent out and cannot receive reply values.
        /// </summary>
        public SendSignalAction SendSignalAction(string? id = null)
        {
            return (SendSignalAction)Uml.SendSignalActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A SequenceNode is a StructuredActivityNode that executes a sequence of ExecutableNodes in order.
        /// </summary>
        public SequenceNode SequenceNode(string? id = null)
        {
            return (SequenceNode)Uml.SequenceNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Slot designates that an entity modeled by an InstanceSpecification has a value or values for a specific StructuralFeature.
        /// </summary>
        public Slot Slot(string? id = null)
        {
            return (Slot)Uml.SlotInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A StartClassifierBehaviorAction is an Action that starts the classifierBehavior of the input object.
        /// </summary>
        public StartClassifierBehaviorAction StartClassifierBehaviorAction(string? id = null)
        {
            return (StartClassifierBehaviorAction)Uml.StartClassifierBehaviorActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A StartObjectBehaviorAction is an InvocationAction that starts the execution either of a directly instantiated Behavior or of the classifierBehavior of an object. Argument values may be supplied for the input Parameters of the Behavior. If the Behavior is invoked synchronously, then output values may be obtained for output Parameters.
        /// </summary>
        public StartObjectBehaviorAction StartObjectBehaviorAction(string? id = null)
        {
            return (StartObjectBehaviorAction)Uml.StartObjectBehaviorActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A StateInvariant is a runtime constraint on the participants of the Interaction. It may be used to specify a variety of different kinds of Constraints, such as values of Attributes or Variables, internal or external States, and so on. A StateInvariant is an InteractionFragment and it is placed on a Lifeline.
        /// </summary>
        public StateInvariant StateInvariant(string? id = null)
        {
            return (StateInvariant)Uml.StateInvariantInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Signal is a specification of a kind of communication between objects in which a reaction is asynchronously triggered in the receiver without a reply.
        /// </summary>
        public Signal Signal(string? id = null)
        {
            return (Signal)Uml.SignalInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A SignalEvent represents the receipt of an asynchronous Signal instance.
        /// </summary>
        public SignalEvent SignalEvent(string? id = null)
        {
            return (SignalEvent)Uml.SignalEventInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A State models a situation during which some (usually implicit) invariant condition holds.
        /// </summary>
        public State State(string? id = null)
        {
            return (State)Uml.StateInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// StateMachines can be used to express event-driven behaviors of parts of a system. Behavior is modeled as a traversal of a graph of Vertices interconnected by one or more joined Transition arcs that are triggered by the dispatching of successive Event occurrences. During this traversal, the StateMachine may execute a sequence of Behaviors associated with various elements of the StateMachine.
        /// </summary>
        public StateMachine StateMachine(string? id = null)
        {
            return (StateMachine)Uml.StateMachineInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A stereotype defines how an existing metaclass may be extended, and enables the use of platform or domain specific terminology or notation in place of, or in addition to, the ones used for the extended metaclass.
        /// </summary>
        public Stereotype Stereotype(string? id = null)
        {
            return (Stereotype)Uml.StereotypeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A StringExpression is an Expression that specifies a String value that is derived by concatenating a sequence of operands with String values or a sequence of subExpressions, some of which might be template parameters.
        /// </summary>
        public StringExpression StringExpression(string? id = null)
        {
            return (StringExpression)Uml.StringExpressionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A StructuredActivityNode is an Action that is also an ActivityGroup and whose behavior is specified by the ActivityNodes and ActivityEdges it so contains. Unlike other kinds of ActivityGroup, a StructuredActivityNode owns the ActivityNodes and ActivityEdges it contains, and so a node or edge can only be directly contained in one StructuredActivityNode, though StructuredActivityNodes may be nested.
        /// </summary>
        public StructuredActivityNode StructuredActivityNode(string? id = null)
        {
            return (StructuredActivityNode)Uml.StructuredActivityNodeInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A substitution is a relationship between two classifiers signifying that the substituting classifier complies with the contract specified by the contract classifier. This implies that instances of the substituting classifier are runtime substitutable where instances of the contract classifier are expected.
        /// </summary>
        public Substitution Substitution(string? id = null)
        {
            return (Substitution)Uml.SubstitutionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A TemplateBinding is a DirectedRelationship between a TemplateableElement and a template. A TemplateBinding specifies the TemplateParameterSubstitutions of actual parameters for the formal parameters of the template.
        /// </summary>
        public TemplateBinding TemplateBinding(string? id = null)
        {
            return (TemplateBinding)Uml.TemplateBindingInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A TemplateParameter exposes a ParameterableElement as a formal parameter of a template.
        /// </summary>
        public TemplateParameter TemplateParameter(string? id = null)
        {
            return (TemplateParameter)Uml.TemplateParameterInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A TemplateParameterSubstitution relates the actual parameter to a formal TemplateParameter as part of a template binding.
        /// </summary>
        public TemplateParameterSubstitution TemplateParameterSubstitution(string? id = null)
        {
            return (TemplateParameterSubstitution)Uml.TemplateParameterSubstitutionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Template Signature bundles the set of formal TemplateParameters for a template.
        /// </summary>
        public TemplateSignature TemplateSignature(string? id = null)
        {
            return (TemplateSignature)Uml.TemplateSignatureInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A TestIdentityAction is an Action that tests if two values are identical objects.
        /// </summary>
        public TestIdentityAction TestIdentityAction(string? id = null)
        {
            return (TestIdentityAction)Uml.TestIdentityActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A TimeConstraint is a Constraint that refers to a TimeInterval.
        /// </summary>
        public TimeConstraint TimeConstraint(string? id = null)
        {
            return (TimeConstraint)Uml.TimeConstraintInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A TimeEvent is an Event that occurs at a specific point in time.
        /// </summary>
        public TimeEvent TimeEvent(string? id = null)
        {
            return (TimeEvent)Uml.TimeEventInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A TimeExpression is a ValueSpecification that represents a time value.
        /// </summary>
        public TimeExpression TimeExpression(string? id = null)
        {
            return (TimeExpression)Uml.TimeExpressionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A TimeInterval defines the range between two TimeExpressions.
        /// </summary>
        public TimeInterval TimeInterval(string? id = null)
        {
            return (TimeInterval)Uml.TimeIntervalInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A TimeObservation is a reference to a time instant during an execution. It points out the NamedElement in the model to observe and whether the observation is when this NamedElement is entered or when it is exited.
        /// </summary>
        public TimeObservation TimeObservation(string? id = null)
        {
            return (TimeObservation)Uml.TimeObservationInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Transition represents an arc between exactly one source Vertex and exactly one Target vertex (the source and targets may be the same Vertex). It may form part of a compound transition, which takes the StateMachine from one steady State configuration to another, representing the full response of the StateMachine to an occurrence of an Event that triggered it.
        /// </summary>
        public Transition Transition(string? id = null)
        {
            return (Transition)Uml.TransitionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Trigger specifies a specific point  at which an Event occurrence may trigger an effect in a Behavior. A Trigger may be qualified by the Port on which the Event occurred.
        /// </summary>
        public Trigger Trigger(string? id = null)
        {
            return (Trigger)Uml.TriggerInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// An UnmarshallAction is an Action that retrieves the values of the StructuralFeatures of an object and places them on OutputPins.
        /// </summary>
        public UnmarshallAction UnmarshallAction(string? id = null)
        {
            return (UnmarshallAction)Uml.UnmarshallActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Usage is a Dependency in which the client Element requires the supplier Element (or set of Elements) for its full implementation or operation.
        /// </summary>
        public Usage Usage(string? id = null)
        {
            return (Usage)Uml.UsageInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A UseCase specifies a set of actions performed by its subjects, which yields an observable result that is of value for one or more Actors or other stakeholders of each subject.
        /// </summary>
        public UseCase UseCase(string? id = null)
        {
            return (UseCase)Uml.UseCaseInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ValuePin is an InputPin that provides a value by evaluating a ValueSpecification.
        /// </summary>
        public ValuePin ValuePin(string? id = null)
        {
            return (ValuePin)Uml.ValuePinInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A ValueSpecificationAction is an Action that evaluates a ValueSpecification and provides a result.
        /// </summary>
        public ValueSpecificationAction ValueSpecificationAction(string? id = null)
        {
            return (ValueSpecificationAction)Uml.ValueSpecificationActionInfo.Create(base.Model, id)!;
        }
    
        /// <summary>
        /// A Variable is a ConnectableElement that may store values during the execution of an Activity. Reading and writing the values of a Variable provides an alternative means for passing data than the use of ObjectFlows. A Variable may be owned directly by an Activity, in which case it is accessible from anywhere within that activity, or it may be owned by a StructuredActivityNode, in which case it is only accessible within that node.
        /// </summary>
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
    
        /// <summary>
        /// An Abstraction is a Relationship that relates two Elements or sets of Elements that represent the same concept at different levels of abstraction or from different viewpoints.
        /// </summary>
        public Abstraction Abstraction(__Model model, string? id = null)
        {
            return (Abstraction)Uml.AbstractionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An AcceptEventAction is an Action that waits for the occurrence of one or more specific Events.
        /// </summary>
        public AcceptEventAction AcceptEventAction(__Model model, string? id = null)
        {
            return (AcceptEventAction)Uml.AcceptEventActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An AcceptCallAction is an AcceptEventAction that handles the receipt of a synchronous call request. In addition to the values from the Operation input parameters, the Action produces an output that is needed later to supply the information to the ReplyAction necessary to return control to the caller. An AcceptCallAction is for synchronous calls. If it is used to handle an asynchronous call, execution of the subsequent ReplyAction will complete immediately with no effect.
        /// </summary>
        public AcceptCallAction AcceptCallAction(__Model model, string? id = null)
        {
            return (AcceptCallAction)Uml.AcceptCallActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An ActionExecutionSpecification is a kind of ExecutionSpecification representing the execution of an Action.
        /// </summary>
        public ActionExecutionSpecification ActionExecutionSpecification(__Model model, string? id = null)
        {
            return (ActionExecutionSpecification)Uml.ActionExecutionSpecificationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An ActionInputPin is a kind of InputPin that executes an Action to determine the values to input to another Action.
        /// </summary>
        public ActionInputPin ActionInputPin(__Model model, string? id = null)
        {
            return (ActionInputPin)Uml.ActionInputPinInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Class classifies a set of objects and specifies the features that characterize the structure and behavior of those objects.  A Class may have an internal structure and Ports.
        /// </summary>
        public Class Class(__Model model, string? id = null)
        {
            return (Class)Uml.ClassInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An Activity is the specification of parameterized Behavior as the coordinated sequencing of subordinate units.
        /// </summary>
        public Activity Activity(__Model model, string? id = null)
        {
            return (Activity)Uml.ActivityInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An ActivityFinalNode is a FinalNode that terminates the execution of its owning Activity or StructuredActivityNode.
        /// </summary>
        public ActivityFinalNode ActivityFinalNode(__Model model, string? id = null)
        {
            return (ActivityFinalNode)Uml.ActivityFinalNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An ActivityParameterNode is an ObjectNode for accepting values from the input Parameters or providing values to the output Parameters of an Activity.
        /// </summary>
        public ActivityParameterNode ActivityParameterNode(__Model model, string? id = null)
        {
            return (ActivityParameterNode)Uml.ActivityParameterNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An ActivityPartition is a kind of ActivityGroup for identifying ActivityNodes that have some characteristic in common.
        /// </summary>
        public ActivityPartition ActivityPartition(__Model model, string? id = null)
        {
            return (ActivityPartition)Uml.ActivityPartitionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An Actor specifies a role played by a user or any other system that interacts with the subject.
        /// </summary>
        public Actor Actor(__Model model, string? id = null)
        {
            return (Actor)Uml.ActorInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An AddStructuralFeatureValueAction is a WriteStructuralFeatureAction for adding values to a StructuralFeature.
        /// </summary>
        public AddStructuralFeatureValueAction AddStructuralFeatureValueAction(__Model model, string? id = null)
        {
            return (AddStructuralFeatureValueAction)Uml.AddStructuralFeatureValueActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An AddVariableValueAction is a WriteVariableAction for adding values to a Variable.
        /// </summary>
        public AddVariableValueAction AddVariableValueAction(__Model model, string? id = null)
        {
            return (AddVariableValueAction)Uml.AddVariableValueActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A trigger for an AnyReceiveEvent is triggered by the receipt of any message that is not explicitly handled by any related trigger.
        /// </summary>
        public AnyReceiveEvent AnyReceiveEvent(__Model model, string? id = null)
        {
            return (AnyReceiveEvent)Uml.AnyReceiveEventInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A link is a tuple of values that refer to typed objects.  An Association classifies a set of links, each of which is an instance of the Association.  Each value in the link refers to an instance of the type of the corresponding end of the Association.
        /// </summary>
        public Association Association(__Model model, string? id = null)
        {
            return (Association)Uml.AssociationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A model element that has both Association and Class properties. An AssociationClass can be seen as an Association that also has Class properties, or as a Class that also has Association properties. It not only connects a set of Classifiers but also defines a set of Features that belong to the Association itself and not to any of the associated Classifiers.
        /// </summary>
        public AssociationClass AssociationClass(__Model model, string? id = null)
        {
            return (AssociationClass)Uml.AssociationClassInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A BehaviorExecutionSpecification is a kind of ExecutionSpecification representing the execution of a Behavior.
        /// </summary>
        public BehaviorExecutionSpecification BehaviorExecutionSpecification(__Model model, string? id = null)
        {
            return (BehaviorExecutionSpecification)Uml.BehaviorExecutionSpecificationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A BroadcastSignalAction is an InvocationAction that transmits a Signal instance to all the potential target objects in the system. Values from the argument InputPins are used to provide values for the attributes of the Signal. The requestor continues execution immediately after the Signal instances are sent out and cannot receive reply values.
        /// </summary>
        public BroadcastSignalAction BroadcastSignalAction(__Model model, string? id = null)
        {
            return (BroadcastSignalAction)Uml.BroadcastSignalActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A CallBehaviorAction is a CallAction that invokes a Behavior directly. The argument values of the CallBehaviorAction are passed on the input Parameters of the invoked Behavior. If the call is synchronous, the execution of the CallBehaviorAction waits until the execution of the invoked Behavior completes and the values of output Parameters of the Behavior are placed on the result OutputPins. If the call is asynchronous, the CallBehaviorAction completes immediately and no results values can be provided.
        /// </summary>
        public CallBehaviorAction CallBehaviorAction(__Model model, string? id = null)
        {
            return (CallBehaviorAction)Uml.CallBehaviorActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A CallEvent models the receipt by an object of a message invoking a call of an Operation.
        /// </summary>
        public CallEvent CallEvent(__Model model, string? id = null)
        {
            return (CallEvent)Uml.CallEventInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A CallOperationAction is a CallAction that transmits an Operation call request to the target object, where it may cause the invocation of associated Behavior. The argument values of the CallOperationAction are passed on the input Parameters of the Operation. If call is synchronous, the execution of the CallOperationAction waits until the execution of the invoked Operation completes and the values of output Parameters of the Operation are placed on the result OutputPins. If the call is asynchronous, the CallOperationAction completes immediately and no results values can be provided.
        /// </summary>
        public CallOperationAction CallOperationAction(__Model model, string? id = null)
        {
            return (CallOperationAction)Uml.CallOperationActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A CentralBufferNode is an ObjectNode for managing flows from multiple sources and targets.
        /// </summary>
        public CentralBufferNode CentralBufferNode(__Model model, string? id = null)
        {
            return (CentralBufferNode)Uml.CentralBufferNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ChangeEvent models a change in the system configuration that makes a condition true.
        /// </summary>
        public ChangeEvent ChangeEvent(__Model model, string? id = null)
        {
            return (ChangeEvent)Uml.ChangeEventInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ClassifierTemplateParameter exposes a Classifier as a formal template parameter.
        /// </summary>
        public ClassifierTemplateParameter ClassifierTemplateParameter(__Model model, string? id = null)
        {
            return (ClassifierTemplateParameter)Uml.ClassifierTemplateParameterInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Clause is an Element that represents a single branch of a ConditionalNode, including a test and a body section. The body section is executed only if (but not necessarily if) the test section evaluates to true.
        /// </summary>
        public Clause Clause(__Model model, string? id = null)
        {
            return (Clause)Uml.ClauseInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ClearAssociationAction is an Action that destroys all links of an Association in which a particular object participates.
        /// </summary>
        public ClearAssociationAction ClearAssociationAction(__Model model, string? id = null)
        {
            return (ClearAssociationAction)Uml.ClearAssociationActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ClearStructuralFeatureAction is a StructuralFeatureAction that removes all values of a StructuralFeature.
        /// </summary>
        public ClearStructuralFeatureAction ClearStructuralFeatureAction(__Model model, string? id = null)
        {
            return (ClearStructuralFeatureAction)Uml.ClearStructuralFeatureActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ClearVariableAction is a VariableAction that removes all values of a Variable.
        /// </summary>
        public ClearVariableAction ClearVariableAction(__Model model, string? id = null)
        {
            return (ClearVariableAction)Uml.ClearVariableActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Collaboration describes a structure of collaborating elements (roles), each performing a specialized function, which collectively accomplish some desired functionality.
        /// </summary>
        public Collaboration Collaboration(__Model model, string? id = null)
        {
            return (Collaboration)Uml.CollaborationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A CollaborationUse is used to specify the application of a pattern specified by a Collaboration to a specific situation.
        /// </summary>
        public CollaborationUse CollaborationUse(__Model model, string? id = null)
        {
            return (CollaborationUse)Uml.CollaborationUseInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A CombinedFragment defines an expression of InteractionFragments. A CombinedFragment is defined by an interaction operator and corresponding InteractionOperands. Through the use of CombinedFragments the user will be able to describe a number of traces in a compact and concise manner.
        /// </summary>
        public CombinedFragment CombinedFragment(__Model model, string? id = null)
        {
            return (CombinedFragment)Uml.CombinedFragmentInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Comment is a textual annotation that can be attached to a set of Elements.
        /// </summary>
        public Comment Comment(__Model model, string? id = null)
        {
            return (Comment)Uml.CommentInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A communication path is an association between two deployment targets, through which they are able to exchange signals and messages.
        /// </summary>
        public CommunicationPath CommunicationPath(__Model model, string? id = null)
        {
            return (CommunicationPath)Uml.CommunicationPathInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Component represents a modular part of a system that encapsulates its contents and whose manifestation is replaceable within its environment.
        /// </summary>
        public Component Component(__Model model, string? id = null)
        {
            return (Component)Uml.ComponentInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// Realization is specialized to (optionally) define the Classifiers that realize the contract offered by a Component in terms of its provided and required Interfaces. The Component forms an abstraction from these various Classifiers.
        /// </summary>
        public ComponentRealization ComponentRealization(__Model model, string? id = null)
        {
            return (ComponentRealization)Uml.ComponentRealizationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ConditionalNode is a StructuredActivityNode that chooses one among some number of alternative collections of ExecutableNodes to execute.
        /// </summary>
        public ConditionalNode ConditionalNode(__Model model, string? id = null)
        {
            return (ConditionalNode)Uml.ConditionalNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ConnectableElementTemplateParameter exposes a ConnectableElement as a formal parameter for a template.
        /// </summary>
        public ConnectableElementTemplateParameter ConnectableElementTemplateParameter(__Model model, string? id = null)
        {
            return (ConnectableElementTemplateParameter)Uml.ConnectableElementTemplateParameterInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ConnectionPointReference represents a usage (as part of a submachine State) of an entry/exit point Pseudostate defined in the StateMachine referenced by the submachine State.
        /// </summary>
        public ConnectionPointReference ConnectionPointReference(__Model model, string? id = null)
        {
            return (ConnectionPointReference)Uml.ConnectionPointReferenceInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Connector specifies links that enables communication between two or more instances. In contrast to Associations, which specify links between any instance of the associated Classifiers, Connectors specify links between instances playing the connected parts only.
        /// </summary>
        public Connector Connector(__Model model, string? id = null)
        {
            return (Connector)Uml.ConnectorInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ConnectorEnd is an endpoint of a Connector, which attaches the Connector to a ConnectableElement.
        /// </summary>
        public ConnectorEnd ConnectorEnd(__Model model, string? id = null)
        {
            return (ConnectorEnd)Uml.ConnectorEndInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ConsiderIgnoreFragment is a kind of CombinedFragment that is used for the consider and ignore cases, which require lists of pertinent Messages to be specified.
        /// </summary>
        public ConsiderIgnoreFragment ConsiderIgnoreFragment(__Model model, string? id = null)
        {
            return (ConsiderIgnoreFragment)Uml.ConsiderIgnoreFragmentInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Constraint is a condition or restriction expressed in natural language text or in a machine readable language for the purpose of declaring some of the semantics of an Element or set of Elements.
        /// </summary>
        public Constraint Constraint(__Model model, string? id = null)
        {
            return (Constraint)Uml.ConstraintInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Continuation is a syntactic way to define continuations of different branches of an alternative CombinedFragment. Continuations are intuitively similar to labels representing intermediate points in a flow of control.
        /// </summary>
        public Continuation Continuation(__Model model, string? id = null)
        {
            return (Continuation)Uml.ContinuationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ControlFlow is an ActivityEdge traversed by control tokens or object tokens of control type, which are use to control the execution of ExecutableNodes.
        /// </summary>
        public ControlFlow ControlFlow(__Model model, string? id = null)
        {
            return (ControlFlow)Uml.ControlFlowInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A CreateLinkAction is a WriteLinkAction for creating links.
        /// </summary>
        public CreateLinkAction CreateLinkAction(__Model model, string? id = null)
        {
            return (CreateLinkAction)Uml.CreateLinkActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A CreateLinkObjectAction is a CreateLinkAction for creating link objects (AssociationClasse instances).
        /// </summary>
        public CreateLinkObjectAction CreateLinkObjectAction(__Model model, string? id = null)
        {
            return (CreateLinkObjectAction)Uml.CreateLinkObjectActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A CreateObjectAction is an Action that creates an instance of the specified Classifier.
        /// </summary>
        public CreateObjectAction CreateObjectAction(__Model model, string? id = null)
        {
            return (CreateObjectAction)Uml.CreateObjectActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A DataStoreNode is a CentralBufferNode for persistent data.
        /// </summary>
        public DataStoreNode DataStoreNode(__Model model, string? id = null)
        {
            return (DataStoreNode)Uml.DataStoreNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A DataType is a type whose instances are identified only by their value.
        /// </summary>
        public DataType DataType(__Model model, string? id = null)
        {
            return (DataType)Uml.DataTypeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A DecisionNode is a ControlNode that chooses between outgoing ActivityEdges for the routing of tokens.
        /// </summary>
        public DecisionNode DecisionNode(__Model model, string? id = null)
        {
            return (DecisionNode)Uml.DecisionNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Dependency is a Relationship that signifies that a single model Element or a set of model Elements requires other model Elements for their specification or implementation. This means that the complete semantics of the client Element(s) are either semantically or structurally dependent on the definition of the supplier Element(s).
        /// </summary>
        public Dependency Dependency(__Model model, string? id = null)
        {
            return (Dependency)Uml.DependencyInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A DestroyLinkAction is a WriteLinkAction that destroys links (including link objects).
        /// </summary>
        public DestroyLinkAction DestroyLinkAction(__Model model, string? id = null)
        {
            return (DestroyLinkAction)Uml.DestroyLinkActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A DestroyObjectAction is an Action that destroys objects.
        /// </summary>
        public DestroyObjectAction DestroyObjectAction(__Model model, string? id = null)
        {
            return (DestroyObjectAction)Uml.DestroyObjectActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A DestructionOccurenceSpecification models the destruction of an object.
        /// </summary>
        public DestructionOccurrenceSpecification DestructionOccurrenceSpecification(__Model model, string? id = null)
        {
            return (DestructionOccurrenceSpecification)Uml.DestructionOccurrenceSpecificationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An ElementImport identifies a NamedElement in a Namespace other than the one that owns that NamedElement and allows the NamedElement to be referenced using an unqualified name in the Namespace owning the ElementImport.
        /// </summary>
        public ElementImport ElementImport(__Model model, string? id = null)
        {
            return (ElementImport)Uml.ElementImportInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An ExceptionHandler is an Element that specifies a handlerBody ExecutableNode to execute in case the specified exception occurs during the execution of the protected ExecutableNode.
        /// </summary>
        public ExceptionHandler ExceptionHandler(__Model model, string? id = null)
        {
            return (ExceptionHandler)Uml.ExceptionHandlerInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An ExecutionOccurrenceSpecification represents moments in time at which Actions or Behaviors start or finish.
        /// </summary>
        public ExecutionOccurrenceSpecification ExecutionOccurrenceSpecification(__Model model, string? id = null)
        {
            return (ExecutionOccurrenceSpecification)Uml.ExecutionOccurrenceSpecificationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An ExpansionNode is an ObjectNode used to indicate a collection input or output for an ExpansionRegion. A collection input of an ExpansionRegion contains a collection that is broken into its individual elements inside the region, whose content is executed once per element. A collection output of an ExpansionRegion combines individual elements produced by the execution of the region into a collection for use outside the region.
        /// </summary>
        public ExpansionNode ExpansionNode(__Model model, string? id = null)
        {
            return (ExpansionNode)Uml.ExpansionNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An ExpansionRegion is a StructuredActivityNode that executes its content multiple times corresponding to elements of input collection(s).
        /// </summary>
        public ExpansionRegion ExpansionRegion(__Model model, string? id = null)
        {
            return (ExpansionRegion)Uml.ExpansionRegionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A relationship from an extending UseCase to an extended UseCase that specifies how and when the behavior defined in the extending UseCase can be inserted into the behavior defined in the extended UseCase.
        /// </summary>
        public Extend Extend(__Model model, string? id = null)
        {
            return (Extend)Uml.ExtendInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An extension end is used to tie an extension to a stereotype when extending a metaclass.
        /// The default multiplicity of an extension end is 0..1.
        /// </summary>
        public ExtensionEnd ExtensionEnd(__Model model, string? id = null)
        {
            return (ExtensionEnd)Uml.ExtensionEndInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An ExtensionPoint identifies a point in the behavior of a UseCase where that behavior can be extended by the behavior of some other (extending) UseCase, as specified by an Extend relationship.
        /// </summary>
        public ExtensionPoint ExtensionPoint(__Model model, string? id = null)
        {
            return (ExtensionPoint)Uml.ExtensionPointInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A special kind of State, which, when entered, signifies that the enclosing Region has completed. If the enclosing Region is directly contained in a StateMachine and all other Regions in that StateMachine also are completed, then it means that the entire StateMachine behavior is completed.
        /// </summary>
        public FinalState FinalState(__Model model, string? id = null)
        {
            return (FinalState)Uml.FinalStateInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A FlowFinalNode is a FinalNode that terminates a flow by consuming the tokens offered to it.
        /// </summary>
        public FlowFinalNode FlowFinalNode(__Model model, string? id = null)
        {
            return (FlowFinalNode)Uml.FlowFinalNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ForkNode is a ControlNode that splits a flow into multiple concurrent flows.
        /// </summary>
        public ForkNode ForkNode(__Model model, string? id = null)
        {
            return (ForkNode)Uml.ForkNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Gate is a MessageEnd which serves as a connection point for relating a Message which has a MessageEnd (sendEvent / receiveEvent) outside an InteractionFragment with another Message which has a MessageEnd (receiveEvent / sendEvent)  inside that InteractionFragment.
        /// </summary>
        public Gate Gate(__Model model, string? id = null)
        {
            return (Gate)Uml.GateInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Generalization is a taxonomic relationship between a more general Classifier and a more specific Classifier. Each instance of the specific Classifier is also an instance of the general Classifier. The specific Classifier inherits the features of the more general Classifier. A Generalization is owned by the specific Classifier.
        /// </summary>
        public Generalization Generalization(__Model model, string? id = null)
        {
            return (Generalization)Uml.GeneralizationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A GeneralOrdering represents a binary relation between two OccurrenceSpecifications, to describe that one OccurrenceSpecification must occur before the other in a valid trace. This mechanism provides the ability to define partial orders of OccurrenceSpecifications that may otherwise not have a specified order.
        /// </summary>
        public GeneralOrdering GeneralOrdering(__Model model, string? id = null)
        {
            return (GeneralOrdering)Uml.GeneralOrderingInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// Physical definition of a graphical image.
        /// </summary>
        public Image Image(__Model model, string? id = null)
        {
            return (Image)Uml.ImageInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An Include relationship specifies that a UseCase contains the behavior defined in another UseCase.
        /// </summary>
        public Include Include(__Model model, string? id = null)
        {
            return (Include)Uml.IncludeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An InitialNode is a ControlNode that offers a single control token when initially enabled.
        /// </summary>
        public InitialNode InitialNode(__Model model, string? id = null)
        {
            return (InitialNode)Uml.InitialNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An InputPin is a Pin that holds input values to be consumed by an Action.
        /// </summary>
        public InputPin InputPin(__Model model, string? id = null)
        {
            return (InputPin)Uml.InputPinInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An artifact is the specification of a physical piece of information that is used or produced by a software development process, or by deployment and operation of a system. Examples of artifacts include model files, source files, scripts, and binary executable files, a table in a database system, a development deliverable, or a word-processing document, a mail message.
        /// An artifact is the source of a deployment to a node.
        /// </summary>
        public Artifact Artifact(__Model model, string? id = null)
        {
            return (Artifact)Uml.ArtifactInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A deployment is the allocation of an artifact or artifact instance to a deployment target.
        /// A component deployment is the deployment of one or more artifacts or artifact instances to a deployment target, optionally parameterized by a deployment specification. Examples are executables and configuration files.
        /// </summary>
        public Deployment Deployment(__Model model, string? id = null)
        {
            return (Deployment)Uml.DeploymentInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A deployment specification specifies a set of properties that determine execution parameters of a component artifact that is deployed on a node. A deployment specification can be aimed at a specific type of container. An artifact that reifies or implements deployment specification properties is a deployment descriptor.
        /// </summary>
        public DeploymentSpecification DeploymentSpecification(__Model model, string? id = null)
        {
            return (DeploymentSpecification)Uml.DeploymentSpecificationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Duration is a ValueSpecification that specifies the temporal distance between two time instants.
        /// </summary>
        public Duration Duration(__Model model, string? id = null)
        {
            return (Duration)Uml.DurationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A DurationConstraint is a Constraint that refers to a DurationInterval.
        /// </summary>
        public DurationConstraint DurationConstraint(__Model model, string? id = null)
        {
            return (DurationConstraint)Uml.DurationConstraintInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A DurationInterval defines the range between two Durations.
        /// </summary>
        public DurationInterval DurationInterval(__Model model, string? id = null)
        {
            return (DurationInterval)Uml.DurationIntervalInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A DurationObservation is a reference to a duration during an execution. It points out the NamedElement(s) in the model to observe and whether the observations are when this NamedElement is entered or when it is exited.
        /// </summary>
        public DurationObservation DurationObservation(__Model model, string? id = null)
        {
            return (DurationObservation)Uml.DurationObservationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A device is a physical computational resource with processing capability upon which artifacts may be deployed for execution. Devices may be complex (i.e., they may consist of other devices).
        /// </summary>
        public Device Device(__Model model, string? id = null)
        {
            return (Device)Uml.DeviceInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An Enumeration is a DataType whose values are enumerated in the model as EnumerationLiterals.
        /// </summary>
        public Enumeration Enumeration(__Model model, string? id = null)
        {
            return (Enumeration)Uml.EnumerationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An EnumerationLiteral is a user-defined data value for an Enumeration.
        /// </summary>
        public EnumerationLiteral EnumerationLiteral(__Model model, string? id = null)
        {
            return (EnumerationLiteral)Uml.EnumerationLiteralInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An execution environment is a node that offers an execution environment for specific types of components that are deployed on it in the form of executable artifacts.
        /// </summary>
        public ExecutionEnvironment ExecutionEnvironment(__Model model, string? id = null)
        {
            return (ExecutionEnvironment)Uml.ExecutionEnvironmentInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An Expression represents a node in an expression tree, which may be non-terminal or terminal. It defines a symbol, and has a possibly empty sequence of operands that are ValueSpecifications. It denotes a (possibly empty) set of values when evaluated in a context.
        /// </summary>
        public Expression Expression(__Model model, string? id = null)
        {
            return (Expression)Uml.ExpressionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An extension is used to indicate that the properties of a metaclass are extended through a stereotype, and gives the ability to flexibly add (and later remove) stereotypes to classes.
        /// </summary>
        public Extension Extension(__Model model, string? id = null)
        {
            return (Extension)Uml.ExtensionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A FunctionBehavior is an OpaqueBehavior that does not access or modify any objects or other external data.
        /// </summary>
        public FunctionBehavior FunctionBehavior(__Model model, string? id = null)
        {
            return (FunctionBehavior)Uml.FunctionBehaviorInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A GeneralizationSet is a PackageableElement whose instances represent sets of Generalization relationships.
        /// </summary>
        public GeneralizationSet GeneralizationSet(__Model model, string? id = null)
        {
            return (GeneralizationSet)Uml.GeneralizationSetInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// InformationFlows describe circulation of information through a system in a general manner. They do not specify the nature of the information, mechanisms by which it is conveyed, sequences of exchange or any control conditions. During more detailed modeling, representation and realization links may be added to specify which model elements implement an InformationFlow and to show how information is conveyed.  InformationFlows require some kind of “information channel” for unidirectional transmission of information items from sources to targets.  They specify the information channel’s realizations, if any, and identify the information that flows along them.  Information moving along the information channel may be represented by abstract InformationItems and by concrete Classifiers.
        /// </summary>
        public InformationFlow InformationFlow(__Model model, string? id = null)
        {
            return (InformationFlow)Uml.InformationFlowInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// InformationItems represent many kinds of information that can flow from sources to targets in very abstract ways.  They represent the kinds of information that may move within a system, but do not elaborate details of the transferred information.  Details of transferred information are the province of other Classifiers that may ultimately define InformationItems.  Consequently, InformationItems cannot be instantiated and do not themselves have features, generalizations, or associations. An important use of InformationItems is to represent information during early design stages, possibly before the detailed modeling decisions that will ultimately define them have been made. Another purpose of InformationItems is to abstract portions of complex models in less precise, but perhaps more general and communicable, ways.
        /// </summary>
        public InformationItem InformationItem(__Model model, string? id = null)
        {
            return (InformationItem)Uml.InformationItemInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An InstanceSpecification is a model element that represents an instance in a modeled system. An InstanceSpecification can act as a DeploymentTarget in a Deployment relationship, in the case that it represents an instance of a Node. It can also act as a DeployedArtifact, if it represents an instance of an Artifact.
        /// </summary>
        public InstanceSpecification InstanceSpecification(__Model model, string? id = null)
        {
            return (InstanceSpecification)Uml.InstanceSpecificationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An InstanceValue is a ValueSpecification that identifies an instance.
        /// </summary>
        public InstanceValue InstanceValue(__Model model, string? id = null)
        {
            return (InstanceValue)Uml.InstanceValueInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An Interaction is a unit of Behavior that focuses on the observable exchange of information between connectable elements.
        /// </summary>
        public Interaction Interaction(__Model model, string? id = null)
        {
            return (Interaction)Uml.InteractionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An InteractionConstraint is a Boolean expression that guards an operand in a CombinedFragment.
        /// </summary>
        public InteractionConstraint InteractionConstraint(__Model model, string? id = null)
        {
            return (InteractionConstraint)Uml.InteractionConstraintInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An InteractionOperand is contained in a CombinedFragment. An InteractionOperand represents one operand of the expression given by the enclosing CombinedFragment.
        /// </summary>
        public InteractionOperand InteractionOperand(__Model model, string? id = null)
        {
            return (InteractionOperand)Uml.InteractionOperandInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An InteractionUse refers to an Interaction. The InteractionUse is a shorthand for copying the contents of the referenced Interaction where the InteractionUse is. To be accurate the copying must take into account substituting parameters with arguments and connect the formal Gates with the actual ones.
        /// </summary>
        public InteractionUse InteractionUse(__Model model, string? id = null)
        {
            return (InteractionUse)Uml.InteractionUseInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// Interfaces declare coherent services that are implemented by BehavioredClassifiers that implement the Interfaces via InterfaceRealizations.
        /// </summary>
        public Interface Interface(__Model model, string? id = null)
        {
            return (Interface)Uml.InterfaceInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An InterfaceRealization is a specialized realization relationship between a BehavioredClassifier and an Interface. This relationship signifies that the realizing BehavioredClassifier conforms to the contract specified by the Interface.
        /// </summary>
        public InterfaceRealization InterfaceRealization(__Model model, string? id = null)
        {
            return (InterfaceRealization)Uml.InterfaceRealizationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An InterruptibleActivityRegion is an ActivityGroup that supports the termination of tokens flowing in the portions of an activity within it.
        /// </summary>
        public InterruptibleActivityRegion InterruptibleActivityRegion(__Model model, string? id = null)
        {
            return (InterruptibleActivityRegion)Uml.InterruptibleActivityRegionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An Interval defines the range between two ValueSpecifications.
        /// </summary>
        public Interval Interval(__Model model, string? id = null)
        {
            return (Interval)Uml.IntervalInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An IntervalConstraint is a Constraint that is specified by an Interval.
        /// </summary>
        public IntervalConstraint IntervalConstraint(__Model model, string? id = null)
        {
            return (IntervalConstraint)Uml.IntervalConstraintInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A JoinNode is a ControlNode that synchronizes multiple flows.
        /// </summary>
        public JoinNode JoinNode(__Model model, string? id = null)
        {
            return (JoinNode)Uml.JoinNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Lifeline represents an individual participant in the Interaction. While parts and structural features may have multiplicity greater than 1, Lifelines represent only one interacting entity.
        /// </summary>
        public Lifeline Lifeline(__Model model, string? id = null)
        {
            return (Lifeline)Uml.LifelineInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// LinkEndData is an Element that identifies on end of a link to be read or written by a LinkAction. As a link (that is not a link object) cannot be passed as a runtime value to or from an Action, it is instead identified by its end objects and qualifier values, if any. A LinkEndData instance provides these values for a single Association end.
        /// </summary>
        public LinkEndData LinkEndData(__Model model, string? id = null)
        {
            return (LinkEndData)Uml.LinkEndDataInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// LinkEndCreationData is LinkEndData used to provide values for one end of a link to be created by a CreateLinkAction.
        /// </summary>
        public LinkEndCreationData LinkEndCreationData(__Model model, string? id = null)
        {
            return (LinkEndCreationData)Uml.LinkEndCreationDataInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// LinkEndDestructionData is LinkEndData used to provide values for one end of a link to be destroyed by a DestroyLinkAction.
        /// </summary>
        public LinkEndDestructionData LinkEndDestructionData(__Model model, string? id = null)
        {
            return (LinkEndDestructionData)Uml.LinkEndDestructionDataInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A LiteralBoolean is a specification of a Boolean value.
        /// </summary>
        public LiteralBoolean LiteralBoolean(__Model model, string? id = null)
        {
            return (LiteralBoolean)Uml.LiteralBooleanInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A LiteralInteger is a specification of an Integer value.
        /// </summary>
        public LiteralInteger LiteralInteger(__Model model, string? id = null)
        {
            return (LiteralInteger)Uml.LiteralIntegerInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A LiteralNull specifies the lack of a value.
        /// </summary>
        public LiteralNull LiteralNull(__Model model, string? id = null)
        {
            return (LiteralNull)Uml.LiteralNullInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A LiteralReal is a specification of a Real value.
        /// </summary>
        public LiteralReal LiteralReal(__Model model, string? id = null)
        {
            return (LiteralReal)Uml.LiteralRealInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A LiteralString is a specification of a String value.
        /// </summary>
        public LiteralString LiteralString(__Model model, string? id = null)
        {
            return (LiteralString)Uml.LiteralStringInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A LiteralUnlimitedNatural is a specification of an UnlimitedNatural number.
        /// </summary>
        public LiteralUnlimitedNatural LiteralUnlimitedNatural(__Model model, string? id = null)
        {
            return (LiteralUnlimitedNatural)Uml.LiteralUnlimitedNaturalInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A LoopNode is a StructuredActivityNode that represents an iterative loop with setup, test, and body sections.
        /// </summary>
        public LoopNode LoopNode(__Model model, string? id = null)
        {
            return (LoopNode)Uml.LoopNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A manifestation is the concrete physical rendering of one or more model elements by an artifact.
        /// </summary>
        public Manifestation Manifestation(__Model model, string? id = null)
        {
            return (Manifestation)Uml.ManifestationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A merge node is a control node that brings together multiple alternate flows. It is not used to synchronize concurrent flows but to accept one among several alternate flows.
        /// </summary>
        public MergeNode MergeNode(__Model model, string? id = null)
        {
            return (MergeNode)Uml.MergeNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Message defines a particular communication between Lifelines of an Interaction.
        /// </summary>
        public Message Message(__Model model, string? id = null)
        {
            return (Message)Uml.MessageInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A model captures a view of a physical system. It is an abstraction of the physical system, with a certain purpose. This purpose determines what is to be included in the model and what is irrelevant. Thus the model completely describes those aspects of the physical system that are relevant to the purpose of the model, at the appropriate level of detail.
        /// </summary>
        public Model Model(__Model model, string? id = null)
        {
            return (Model)Uml.ModelInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Node is computational resource upon which artifacts may be deployed for execution. Nodes can be interconnected through communication paths to define network structures.
        /// </summary>
        public Node Node(__Model model, string? id = null)
        {
            return (Node)Uml.NodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An ObjectFlow is an ActivityEdge that is traversed by object tokens that may hold values. Object flows also support multicast/receive, token selection from object nodes, and transformation of tokens.
        /// </summary>
        public ObjectFlow ObjectFlow(__Model model, string? id = null)
        {
            return (ObjectFlow)Uml.ObjectFlowInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An OccurrenceSpecification is the basic semantic unit of Interactions. The sequences of occurrences specified by them are the meanings of Interactions.
        /// </summary>
        public OccurrenceSpecification OccurrenceSpecification(__Model model, string? id = null)
        {
            return (OccurrenceSpecification)Uml.OccurrenceSpecificationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A MessageOccurrenceSpecification specifies the occurrence of Message events, such as sending and receiving of Signals or invoking or receiving of Operation calls. A MessageOccurrenceSpecification is a kind of MessageEnd. Messages are generated either by synchronous Operation calls or asynchronous Signal sends. They are received by the execution of corresponding AcceptEventActions.
        /// </summary>
        public MessageOccurrenceSpecification MessageOccurrenceSpecification(__Model model, string? id = null)
        {
            return (MessageOccurrenceSpecification)Uml.MessageOccurrenceSpecificationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An OpaqueExpression is a ValueSpecification that specifies the computation of a collection of values either in terms of a UML Behavior or based on a textual statement in a language other than UML
        /// </summary>
        public OpaqueExpression OpaqueExpression(__Model model, string? id = null)
        {
            return (OpaqueExpression)Uml.OpaqueExpressionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An OperationTemplateParameter exposes an Operation as a formal parameter for a template.
        /// </summary>
        public OperationTemplateParameter OperationTemplateParameter(__Model model, string? id = null)
        {
            return (OperationTemplateParameter)Uml.OperationTemplateParameterInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A package can have one or more profile applications to indicate which profiles have been applied. Because a profile is a package, it is possible to apply a profile not only to packages, but also to profiles.
        /// Package specializes TemplateableElement and PackageableElement specializes ParameterableElement to specify that a package can be used as a template and a PackageableElement as a template parameter.
        /// A package is used to group elements, and provides a namespace for the grouped elements.
        /// </summary>
        public Package Package(__Model model, string? id = null)
        {
            return (Package)Uml.PackageInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A PackageImport is a Relationship that imports all the non-private members of a Package into the Namespace owning the PackageImport, so that those Elements may be referred to by their unqualified names in the importingNamespace.
        /// </summary>
        public PackageImport PackageImport(__Model model, string? id = null)
        {
            return (PackageImport)Uml.PackageImportInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A package merge defines how the contents of one package are extended by the contents of another package.
        /// </summary>
        public PackageMerge PackageMerge(__Model model, string? id = null)
        {
            return (PackageMerge)Uml.PackageMergeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Parameter is a specification of an argument used to pass information into or out of an invocation of a BehavioralFeature.  Parameters can be treated as ConnectableElements within Collaborations.
        /// </summary>
        public Parameter Parameter(__Model model, string? id = null)
        {
            return (Parameter)Uml.ParameterInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ParameterSet designates alternative sets of inputs or outputs that a Behavior may use.
        /// </summary>
        public ParameterSet ParameterSet(__Model model, string? id = null)
        {
            return (ParameterSet)Uml.ParameterSetInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A PartDecomposition is a description of the internal Interactions of one Lifeline relative to an Interaction.
        /// </summary>
        public PartDecomposition PartDecomposition(__Model model, string? id = null)
        {
            return (PartDecomposition)Uml.PartDecompositionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An OpaqueAction is an Action whose functionality is not specified within UML.
        /// </summary>
        public OpaqueAction OpaqueAction(__Model model, string? id = null)
        {
            return (OpaqueAction)Uml.OpaqueActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An OpaqueBehavior is a Behavior whose specification is given in a textual language other than UML.
        /// </summary>
        public OpaqueBehavior OpaqueBehavior(__Model model, string? id = null)
        {
            return (OpaqueBehavior)Uml.OpaqueBehaviorInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An Operation is a BehavioralFeature of a Classifier that specifies the name, type, parameters, and constraints for invoking an associated Behavior. An Operation may invoke both the execution of method behaviors as well as other behavioral responses. Operation specializes TemplateableElement in order to support specification of template operations and bound operations. Operation specializes ParameterableElement to specify that an operation can be exposed as a formal template parameter, and provided as an actual parameter in a binding of a template.
        /// </summary>
        public Operation Operation(__Model model, string? id = null)
        {
            return (Operation)Uml.OperationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An OutputPin is a Pin that holds output values produced by an Action.
        /// </summary>
        public OutputPin OutputPin(__Model model, string? id = null)
        {
            return (OutputPin)Uml.OutputPinInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Property is a StructuralFeature. A Property related by ownedAttribute to a Classifier (other than an association) represents an attribute and might also represent an association end. It relates an instance of the Classifier to a value or set of values of the type of the attribute. A Property related by memberEnd to an Association represents an end of the Association. The type of the Property is the type of the end of the Association. A Property has the capability of being a DeploymentTarget in a Deployment relationship. This enables modeling the deployment to hierarchical nodes that have Properties functioning as internal parts.  Property specializes ParameterableElement to specify that a Property can be exposed as a formal template parameter, and provided as an actual parameter in a binding of a template.
        /// </summary>
        public Property Property(__Model model, string? id = null)
        {
            return (Property)Uml.PropertyInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Port is a property of an EncapsulatedClassifier that specifies a distinct interaction point between that EncapsulatedClassifier and its environment or between the (behavior of the) EncapsulatedClassifier and its internal parts. Ports are connected to Properties of the EncapsulatedClassifier by Connectors through which requests can be made to invoke BehavioralFeatures. A Port may specify the services an EncapsulatedClassifier provides (offers) to its environment as well as the services that an EncapsulatedClassifier expects (requires) of its environment.  A Port may have an associated ProtocolStateMachine.
        /// </summary>
        public Port Port(__Model model, string? id = null)
        {
            return (Port)Uml.PortInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A PrimitiveType defines a predefined DataType, without any substructure. A PrimitiveType may have an algebra and operations defined outside of UML, for example, mathematically.
        /// </summary>
        public PrimitiveType PrimitiveType(__Model model, string? id = null)
        {
            return (PrimitiveType)Uml.PrimitiveTypeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A profile defines limited extensions to a reference metamodel with the purpose of adapting the metamodel to a specific platform or domain.
        /// </summary>
        public Profile Profile(__Model model, string? id = null)
        {
            return (Profile)Uml.ProfileInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A profile application is used to show which profiles have been applied to a package.
        /// </summary>
        public ProfileApplication ProfileApplication(__Model model, string? id = null)
        {
            return (ProfileApplication)Uml.ProfileApplicationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ProtocolStateMachine can be redefined into a more specific ProtocolStateMachine or into behavioral StateMachine. ProtocolConformance declares that the specific ProtocolStateMachine specifies a protocol that conforms to the general ProtocolStateMachine or that the specific behavioral StateMachine abides by the protocol of the general ProtocolStateMachine.
        /// </summary>
        public ProtocolConformance ProtocolConformance(__Model model, string? id = null)
        {
            return (ProtocolConformance)Uml.ProtocolConformanceInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ProtocolStateMachine is always defined in the context of a Classifier. It specifies which BehavioralFeatures of the Classifier can be called in which State and under which conditions, thus specifying the allowed invocation sequences on the Classifier&apos;s BehavioralFeatures. A ProtocolStateMachine specifies the possible and permitted Transitions on the instances of its context Classifier, together with the BehavioralFeatures that carry the Transitions. In this manner, an instance lifecycle can be specified for a Classifier, by defining the order in which the BehavioralFeatures can be activated and the States through which an instance progresses during its existence.
        /// </summary>
        public ProtocolStateMachine ProtocolStateMachine(__Model model, string? id = null)
        {
            return (ProtocolStateMachine)Uml.ProtocolStateMachineInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ProtocolTransition specifies a legal Transition for an Operation. Transitions of ProtocolStateMachines have the following information: a pre-condition (guard), a Trigger, and a post-condition. Every ProtocolTransition is associated with at most one BehavioralFeature belonging to the context Classifier of the ProtocolStateMachine.
        /// </summary>
        public ProtocolTransition ProtocolTransition(__Model model, string? id = null)
        {
            return (ProtocolTransition)Uml.ProtocolTransitionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Pseudostate is an abstraction that encompasses different types of transient Vertices in the StateMachine graph. A StateMachine instance never comes to rest in a Pseudostate, instead, it will exit and enter the Pseudostate within a single run-to-completion step.
        /// </summary>
        public Pseudostate Pseudostate(__Model model, string? id = null)
        {
            return (Pseudostate)Uml.PseudostateInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A QualifierValue is an Element that is used as part of LinkEndData to provide the value for a single qualifier of the end given by the LinkEndData.
        /// </summary>
        public QualifierValue QualifierValue(__Model model, string? id = null)
        {
            return (QualifierValue)Uml.QualifierValueInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A RaiseExceptionAction is an Action that causes an exception to occur. The input value becomes the exception object.
        /// </summary>
        public RaiseExceptionAction RaiseExceptionAction(__Model model, string? id = null)
        {
            return (RaiseExceptionAction)Uml.RaiseExceptionActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ReadExtentAction is an Action that retrieves the current instances of a Classifier.
        /// </summary>
        public ReadExtentAction ReadExtentAction(__Model model, string? id = null)
        {
            return (ReadExtentAction)Uml.ReadExtentActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ReadIsClassifiedObjectAction is an Action that determines whether an object is classified by a given Classifier.
        /// </summary>
        public ReadIsClassifiedObjectAction ReadIsClassifiedObjectAction(__Model model, string? id = null)
        {
            return (ReadIsClassifiedObjectAction)Uml.ReadIsClassifiedObjectActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ReadLinkAction is a LinkAction that navigates across an Association to retrieve the objects on one end.
        /// </summary>
        public ReadLinkAction ReadLinkAction(__Model model, string? id = null)
        {
            return (ReadLinkAction)Uml.ReadLinkActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ReadLinkObjectEndAction is an Action that retrieves an end object from a link object.
        /// </summary>
        public ReadLinkObjectEndAction ReadLinkObjectEndAction(__Model model, string? id = null)
        {
            return (ReadLinkObjectEndAction)Uml.ReadLinkObjectEndActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ReadLinkObjectEndQualifierAction is an Action that retrieves a qualifier end value from a link object.
        /// </summary>
        public ReadLinkObjectEndQualifierAction ReadLinkObjectEndQualifierAction(__Model model, string? id = null)
        {
            return (ReadLinkObjectEndQualifierAction)Uml.ReadLinkObjectEndQualifierActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ReadSelfAction is an Action that retrieves the context object of the Behavior execution within which the ReadSelfAction execution is taking place.
        /// </summary>
        public ReadSelfAction ReadSelfAction(__Model model, string? id = null)
        {
            return (ReadSelfAction)Uml.ReadSelfActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ReadStructuralFeatureAction is a StructuralFeatureAction that retrieves the values of a StructuralFeature.
        /// </summary>
        public ReadStructuralFeatureAction ReadStructuralFeatureAction(__Model model, string? id = null)
        {
            return (ReadStructuralFeatureAction)Uml.ReadStructuralFeatureActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ReadVariableAction is a VariableAction that retrieves the values of a Variable.
        /// </summary>
        public ReadVariableAction ReadVariableAction(__Model model, string? id = null)
        {
            return (ReadVariableAction)Uml.ReadVariableActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// Realization is a specialized Abstraction relationship between two sets of model Elements, one representing a specification (the supplier) and the other represents an implementation of the latter (the client). Realization can be used to model stepwise refinement, optimizations, transformations, templates, model synthesis, framework composition, etc.
        /// </summary>
        public Realization Realization(__Model model, string? id = null)
        {
            return (Realization)Uml.RealizationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Reception is a declaration stating that a Classifier is prepared to react to the receipt of a Signal.
        /// </summary>
        public Reception Reception(__Model model, string? id = null)
        {
            return (Reception)Uml.ReceptionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ReclassifyObjectAction is an Action that changes the Classifiers that classify an object.
        /// </summary>
        public ReclassifyObjectAction ReclassifyObjectAction(__Model model, string? id = null)
        {
            return (ReclassifyObjectAction)Uml.ReclassifyObjectActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A RedefinableTemplateSignature supports the addition of formal template parameters in a specialization of a template classifier.
        /// </summary>
        public RedefinableTemplateSignature RedefinableTemplateSignature(__Model model, string? id = null)
        {
            return (RedefinableTemplateSignature)Uml.RedefinableTemplateSignatureInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ReduceAction is an Action that reduces a collection to a single value by repeatedly combining the elements of the collection using a reducer Behavior.
        /// </summary>
        public ReduceAction ReduceAction(__Model model, string? id = null)
        {
            return (ReduceAction)Uml.ReduceActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Region is a top-level part of a StateMachine or a composite State, that serves as a container for the Vertices and Transitions of the StateMachine. A StateMachine or composite State may contain multiple Regions representing behaviors that may occur in parallel.
        /// </summary>
        public Region Region(__Model model, string? id = null)
        {
            return (Region)Uml.RegionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A RemoveStructuralFeatureValueAction is a WriteStructuralFeatureAction that removes values from a StructuralFeature.
        /// </summary>
        public RemoveStructuralFeatureValueAction RemoveStructuralFeatureValueAction(__Model model, string? id = null)
        {
            return (RemoveStructuralFeatureValueAction)Uml.RemoveStructuralFeatureValueActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A RemoveVariableValueAction is a WriteVariableAction that removes values from a Variables.
        /// </summary>
        public RemoveVariableValueAction RemoveVariableValueAction(__Model model, string? id = null)
        {
            return (RemoveVariableValueAction)Uml.RemoveVariableValueActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ReplyAction is an Action that accepts a set of reply values and a value containing return information produced by a previous AcceptCallAction. The ReplyAction returns the values to the caller of the previous call, completing execution of the call.
        /// </summary>
        public ReplyAction ReplyAction(__Model model, string? id = null)
        {
            return (ReplyAction)Uml.ReplyActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A SendObjectAction is an InvocationAction that transmits an input object to the target object, which is handled as a request message by the target object. The requestor continues execution immediately after the object is sent out and cannot receive reply values.
        /// </summary>
        public SendObjectAction SendObjectAction(__Model model, string? id = null)
        {
            return (SendObjectAction)Uml.SendObjectActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A SendSignalAction is an InvocationAction that creates a Signal instance and transmits it to the target object. Values from the argument InputPins are used to provide values for the attributes of the Signal. The requestor continues execution immediately after the Signal instance is sent out and cannot receive reply values.
        /// </summary>
        public SendSignalAction SendSignalAction(__Model model, string? id = null)
        {
            return (SendSignalAction)Uml.SendSignalActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A SequenceNode is a StructuredActivityNode that executes a sequence of ExecutableNodes in order.
        /// </summary>
        public SequenceNode SequenceNode(__Model model, string? id = null)
        {
            return (SequenceNode)Uml.SequenceNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Slot designates that an entity modeled by an InstanceSpecification has a value or values for a specific StructuralFeature.
        /// </summary>
        public Slot Slot(__Model model, string? id = null)
        {
            return (Slot)Uml.SlotInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A StartClassifierBehaviorAction is an Action that starts the classifierBehavior of the input object.
        /// </summary>
        public StartClassifierBehaviorAction StartClassifierBehaviorAction(__Model model, string? id = null)
        {
            return (StartClassifierBehaviorAction)Uml.StartClassifierBehaviorActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A StartObjectBehaviorAction is an InvocationAction that starts the execution either of a directly instantiated Behavior or of the classifierBehavior of an object. Argument values may be supplied for the input Parameters of the Behavior. If the Behavior is invoked synchronously, then output values may be obtained for output Parameters.
        /// </summary>
        public StartObjectBehaviorAction StartObjectBehaviorAction(__Model model, string? id = null)
        {
            return (StartObjectBehaviorAction)Uml.StartObjectBehaviorActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A StateInvariant is a runtime constraint on the participants of the Interaction. It may be used to specify a variety of different kinds of Constraints, such as values of Attributes or Variables, internal or external States, and so on. A StateInvariant is an InteractionFragment and it is placed on a Lifeline.
        /// </summary>
        public StateInvariant StateInvariant(__Model model, string? id = null)
        {
            return (StateInvariant)Uml.StateInvariantInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Signal is a specification of a kind of communication between objects in which a reaction is asynchronously triggered in the receiver without a reply.
        /// </summary>
        public Signal Signal(__Model model, string? id = null)
        {
            return (Signal)Uml.SignalInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A SignalEvent represents the receipt of an asynchronous Signal instance.
        /// </summary>
        public SignalEvent SignalEvent(__Model model, string? id = null)
        {
            return (SignalEvent)Uml.SignalEventInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A State models a situation during which some (usually implicit) invariant condition holds.
        /// </summary>
        public State State(__Model model, string? id = null)
        {
            return (State)Uml.StateInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// StateMachines can be used to express event-driven behaviors of parts of a system. Behavior is modeled as a traversal of a graph of Vertices interconnected by one or more joined Transition arcs that are triggered by the dispatching of successive Event occurrences. During this traversal, the StateMachine may execute a sequence of Behaviors associated with various elements of the StateMachine.
        /// </summary>
        public StateMachine StateMachine(__Model model, string? id = null)
        {
            return (StateMachine)Uml.StateMachineInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A stereotype defines how an existing metaclass may be extended, and enables the use of platform or domain specific terminology or notation in place of, or in addition to, the ones used for the extended metaclass.
        /// </summary>
        public Stereotype Stereotype(__Model model, string? id = null)
        {
            return (Stereotype)Uml.StereotypeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A StringExpression is an Expression that specifies a String value that is derived by concatenating a sequence of operands with String values or a sequence of subExpressions, some of which might be template parameters.
        /// </summary>
        public StringExpression StringExpression(__Model model, string? id = null)
        {
            return (StringExpression)Uml.StringExpressionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A StructuredActivityNode is an Action that is also an ActivityGroup and whose behavior is specified by the ActivityNodes and ActivityEdges it so contains. Unlike other kinds of ActivityGroup, a StructuredActivityNode owns the ActivityNodes and ActivityEdges it contains, and so a node or edge can only be directly contained in one StructuredActivityNode, though StructuredActivityNodes may be nested.
        /// </summary>
        public StructuredActivityNode StructuredActivityNode(__Model model, string? id = null)
        {
            return (StructuredActivityNode)Uml.StructuredActivityNodeInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A substitution is a relationship between two classifiers signifying that the substituting classifier complies with the contract specified by the contract classifier. This implies that instances of the substituting classifier are runtime substitutable where instances of the contract classifier are expected.
        /// </summary>
        public Substitution Substitution(__Model model, string? id = null)
        {
            return (Substitution)Uml.SubstitutionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A TemplateBinding is a DirectedRelationship between a TemplateableElement and a template. A TemplateBinding specifies the TemplateParameterSubstitutions of actual parameters for the formal parameters of the template.
        /// </summary>
        public TemplateBinding TemplateBinding(__Model model, string? id = null)
        {
            return (TemplateBinding)Uml.TemplateBindingInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A TemplateParameter exposes a ParameterableElement as a formal parameter of a template.
        /// </summary>
        public TemplateParameter TemplateParameter(__Model model, string? id = null)
        {
            return (TemplateParameter)Uml.TemplateParameterInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A TemplateParameterSubstitution relates the actual parameter to a formal TemplateParameter as part of a template binding.
        /// </summary>
        public TemplateParameterSubstitution TemplateParameterSubstitution(__Model model, string? id = null)
        {
            return (TemplateParameterSubstitution)Uml.TemplateParameterSubstitutionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Template Signature bundles the set of formal TemplateParameters for a template.
        /// </summary>
        public TemplateSignature TemplateSignature(__Model model, string? id = null)
        {
            return (TemplateSignature)Uml.TemplateSignatureInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A TestIdentityAction is an Action that tests if two values are identical objects.
        /// </summary>
        public TestIdentityAction TestIdentityAction(__Model model, string? id = null)
        {
            return (TestIdentityAction)Uml.TestIdentityActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A TimeConstraint is a Constraint that refers to a TimeInterval.
        /// </summary>
        public TimeConstraint TimeConstraint(__Model model, string? id = null)
        {
            return (TimeConstraint)Uml.TimeConstraintInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A TimeEvent is an Event that occurs at a specific point in time.
        /// </summary>
        public TimeEvent TimeEvent(__Model model, string? id = null)
        {
            return (TimeEvent)Uml.TimeEventInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A TimeExpression is a ValueSpecification that represents a time value.
        /// </summary>
        public TimeExpression TimeExpression(__Model model, string? id = null)
        {
            return (TimeExpression)Uml.TimeExpressionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A TimeInterval defines the range between two TimeExpressions.
        /// </summary>
        public TimeInterval TimeInterval(__Model model, string? id = null)
        {
            return (TimeInterval)Uml.TimeIntervalInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A TimeObservation is a reference to a time instant during an execution. It points out the NamedElement in the model to observe and whether the observation is when this NamedElement is entered or when it is exited.
        /// </summary>
        public TimeObservation TimeObservation(__Model model, string? id = null)
        {
            return (TimeObservation)Uml.TimeObservationInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Transition represents an arc between exactly one source Vertex and exactly one Target vertex (the source and targets may be the same Vertex). It may form part of a compound transition, which takes the StateMachine from one steady State configuration to another, representing the full response of the StateMachine to an occurrence of an Event that triggered it.
        /// </summary>
        public Transition Transition(__Model model, string? id = null)
        {
            return (Transition)Uml.TransitionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Trigger specifies a specific point  at which an Event occurrence may trigger an effect in a Behavior. A Trigger may be qualified by the Port on which the Event occurred.
        /// </summary>
        public Trigger Trigger(__Model model, string? id = null)
        {
            return (Trigger)Uml.TriggerInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// An UnmarshallAction is an Action that retrieves the values of the StructuralFeatures of an object and places them on OutputPins.
        /// </summary>
        public UnmarshallAction UnmarshallAction(__Model model, string? id = null)
        {
            return (UnmarshallAction)Uml.UnmarshallActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Usage is a Dependency in which the client Element requires the supplier Element (or set of Elements) for its full implementation or operation.
        /// </summary>
        public Usage Usage(__Model model, string? id = null)
        {
            return (Usage)Uml.UsageInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A UseCase specifies a set of actions performed by its subjects, which yields an observable result that is of value for one or more Actors or other stakeholders of each subject.
        /// </summary>
        public UseCase UseCase(__Model model, string? id = null)
        {
            return (UseCase)Uml.UseCaseInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ValuePin is an InputPin that provides a value by evaluating a ValueSpecification.
        /// </summary>
        public ValuePin ValuePin(__Model model, string? id = null)
        {
            return (ValuePin)Uml.ValuePinInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A ValueSpecificationAction is an Action that evaluates a ValueSpecification and provides a result.
        /// </summary>
        public ValueSpecificationAction ValueSpecificationAction(__Model model, string? id = null)
        {
            return (ValueSpecificationAction)Uml.ValueSpecificationActionInfo.Create(model, id)!;
        }
    
        /// <summary>
        /// A Variable is a ConnectableElement that may store values during the execution of an Activity. Reading and writing the values of a Variable provides an alternative means for passing data than the use of ObjectFlows. A Variable may be owned directly by an Activity, in which case it is accessible from anywhere within that activity, or it may be owned by a StructuredActivityNode, in which case it is only accessible within that node.
        /// </summary>
        public Variable Variable(__Model model, string? id = null)
        {
            return (Variable)Uml.VariableInfo.Create(model, id)!;
        }
    
    }
}
