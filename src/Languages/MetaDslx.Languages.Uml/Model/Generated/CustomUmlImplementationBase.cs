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

    internal abstract class CustomUmlImplementationBase : ICustomUmlImplementation
    {
        /// <summary>
        /// Constructor for the meta model Uml
        /// </summary>
        public virtual void Uml(IUml _this)
        {
        }
    
        /// <summary>
        /// An Element is a constituent of a model. As such, it has the capability of owning other Elements.
        /// </summary>
        public virtual void Element(Element _this)
        {
        }
    
        /// <summary>
        /// A NamedElement is an Element in a model that may have a name. The name may be given directly and/or via the use of a StringExpression.
        /// </summary>
        public virtual void NamedElement(NamedElement _this)
        {
        }
    
        /// <summary>
        /// An Abstraction is a Relationship that relates two Elements or sets of Elements that represent the same concept at different levels of abstraction or from different viewpoints.
        /// </summary>
        public virtual void Abstraction(Abstraction _this)
        {
        }
    
        /// <summary>
        /// An Action is the fundamental unit of executable functionality. The execution of an Action represents some transformation or processing in the modeled system. Actions provide the ExecutableNodes within Activities and may also be used within Interactions.
        /// </summary>
        public virtual void Action(Action _this)
        {
        }
    
        /// <summary>
        /// An AcceptEventAction is an Action that waits for the occurrence of one or more specific Events.
        /// </summary>
        public virtual void AcceptEventAction(AcceptEventAction _this)
        {
        }
    
        /// <summary>
        /// An AcceptCallAction is an AcceptEventAction that handles the receipt of a synchronous call request. In addition to the values from the Operation input parameters, the Action produces an output that is needed later to supply the information to the ReplyAction necessary to return control to the caller. An AcceptCallAction is for synchronous calls. If it is used to handle an asynchronous call, execution of the subsequent ReplyAction will complete immediately with no effect.
        /// </summary>
        public virtual void AcceptCallAction(AcceptCallAction _this)
        {
        }
    
        /// <summary>
        /// An ActionExecutionSpecification is a kind of ExecutionSpecification representing the execution of an Action.
        /// </summary>
        public virtual void ActionExecutionSpecification(ActionExecutionSpecification _this)
        {
        }
    
        /// <summary>
        /// An ActionInputPin is a kind of InputPin that executes an Action to determine the values to input to another Action.
        /// </summary>
        public virtual void ActionInputPin(ActionInputPin _this)
        {
        }
    
        /// <summary>
        /// A Classifier represents a classification of instances according to their Features.
        /// </summary>
        public virtual void Classifier(Classifier _this)
        {
        }
    
        /// <summary>
        /// A BehavioredClassifier may have InterfaceRealizations, and owns a set of Behaviors one of which may specify the behavior of the BehavioredClassifier itself.
        /// </summary>
        public virtual void BehavioredClassifier(BehavioredClassifier _this)
        {
        }
    
        /// <summary>
        /// A Class classifies a set of objects and specifies the features that characterize the structure and behavior of those objects.  A Class may have an internal structure and Ports.
        /// </summary>
        public virtual void Class(Class _this)
        {
        }
    
        /// <summary>
        /// Behavior is a specification of how its context BehavioredClassifier changes state over time. This specification may be either a definition of possible behavior execution or emergent behavior, or a selective illustration of an interesting subset of possible executions. The latter form is typically used for capturing examples, such as a trace of a particular execution.
        /// </summary>
        public virtual void Behavior(Behavior _this)
        {
        }
    
        /// <summary>
        /// An Activity is the specification of parameterized Behavior as the coordinated sequencing of subordinate units.
        /// </summary>
        public virtual void Activity(Activity _this)
        {
        }
    
        /// <summary>
        /// An ActivityEdge is an abstract class for directed connections between two ActivityNodes.
        /// </summary>
        public virtual void ActivityEdge(ActivityEdge _this)
        {
        }
    
        /// <summary>
        /// ActivityNode is an abstract class for points in the flow of an Activity connected by ActivityEdges.
        /// </summary>
        public virtual void ActivityNode(ActivityNode _this)
        {
        }
    
        /// <summary>
        /// An ActivityFinalNode is a FinalNode that terminates the execution of its owning Activity or StructuredActivityNode.
        /// </summary>
        public virtual void ActivityFinalNode(ActivityFinalNode _this)
        {
        }
    
        /// <summary>
        /// ActivityGroup is an abstract class for defining sets of ActivityNodes and ActivityEdges in an Activity.
        /// </summary>
        public virtual void ActivityGroup(ActivityGroup _this)
        {
        }
    
        /// <summary>
        /// An ActivityParameterNode is an ObjectNode for accepting values from the input Parameters or providing values to the output Parameters of an Activity.
        /// </summary>
        public virtual void ActivityParameterNode(ActivityParameterNode _this)
        {
        }
    
        /// <summary>
        /// An ActivityPartition is a kind of ActivityGroup for identifying ActivityNodes that have some characteristic in common.
        /// </summary>
        public virtual void ActivityPartition(ActivityPartition _this)
        {
        }
    
        /// <summary>
        /// An Actor specifies a role played by a user or any other system that interacts with the subject.
        /// </summary>
        public virtual void Actor(Actor _this)
        {
        }
    
        /// <summary>
        /// An AddStructuralFeatureValueAction is a WriteStructuralFeatureAction for adding values to a StructuralFeature.
        /// </summary>
        public virtual void AddStructuralFeatureValueAction(AddStructuralFeatureValueAction _this)
        {
        }
    
        /// <summary>
        /// An AddVariableValueAction is a WriteVariableAction for adding values to a Variable.
        /// </summary>
        public virtual void AddVariableValueAction(AddVariableValueAction _this)
        {
        }
    
        /// <summary>
        /// A trigger for an AnyReceiveEvent is triggered by the receipt of any message that is not explicitly handled by any related trigger.
        /// </summary>
        public virtual void AnyReceiveEvent(AnyReceiveEvent _this)
        {
        }
    
        /// <summary>
        /// A link is a tuple of values that refer to typed objects.  An Association classifies a set of links, each of which is an instance of the Association.  Each value in the link refers to an instance of the type of the corresponding end of the Association.
        /// </summary>
        public virtual void Association(Association _this)
        {
        }
    
        /// <summary>
        /// A model element that has both Association and Class properties. An AssociationClass can be seen as an Association that also has Class properties, or as a Class that also has Association properties. It not only connects a set of Classifiers but also defines a set of Features that belong to the Association itself and not to any of the associated Classifiers.
        /// </summary>
        public virtual void AssociationClass(AssociationClass _this)
        {
        }
    
        /// <summary>
        /// A BehavioralFeature is a feature of a Classifier that specifies an aspect of the behavior of its instances.  A BehavioralFeature is implemented (realized) by a Behavior. A BehavioralFeature specifies that a Classifier will respond to a designated request by invoking its implementing method.
        /// </summary>
        public virtual void BehavioralFeature(BehavioralFeature _this)
        {
        }
    
        /// <summary>
        /// A BehaviorExecutionSpecification is a kind of ExecutionSpecification representing the execution of a Behavior.
        /// </summary>
        public virtual void BehaviorExecutionSpecification(BehaviorExecutionSpecification _this)
        {
        }
    
        /// <summary>
        /// A BroadcastSignalAction is an InvocationAction that transmits a Signal instance to all the potential target objects in the system. Values from the argument InputPins are used to provide values for the attributes of the Signal. The requestor continues execution immediately after the Signal instances are sent out and cannot receive reply values.
        /// </summary>
        public virtual void BroadcastSignalAction(BroadcastSignalAction _this)
        {
        }
    
        /// <summary>
        /// CallAction is an abstract class for Actions that invoke a Behavior with given argument values and (if the invocation is synchronous) receive reply values.
        /// </summary>
        public virtual void CallAction(CallAction _this)
        {
        }
    
        /// <summary>
        /// A CallBehaviorAction is a CallAction that invokes a Behavior directly. The argument values of the CallBehaviorAction are passed on the input Parameters of the invoked Behavior. If the call is synchronous, the execution of the CallBehaviorAction waits until the execution of the invoked Behavior completes and the values of output Parameters of the Behavior are placed on the result OutputPins. If the call is asynchronous, the CallBehaviorAction completes immediately and no results values can be provided.
        /// </summary>
        public virtual void CallBehaviorAction(CallBehaviorAction _this)
        {
        }
    
        /// <summary>
        /// A CallEvent models the receipt by an object of a message invoking a call of an Operation.
        /// </summary>
        public virtual void CallEvent(CallEvent _this)
        {
        }
    
        /// <summary>
        /// A CallOperationAction is a CallAction that transmits an Operation call request to the target object, where it may cause the invocation of associated Behavior. The argument values of the CallOperationAction are passed on the input Parameters of the Operation. If call is synchronous, the execution of the CallOperationAction waits until the execution of the invoked Operation completes and the values of output Parameters of the Operation are placed on the result OutputPins. If the call is asynchronous, the CallOperationAction completes immediately and no results values can be provided.
        /// </summary>
        public virtual void CallOperationAction(CallOperationAction _this)
        {
        }
    
        /// <summary>
        /// A CentralBufferNode is an ObjectNode for managing flows from multiple sources and targets.
        /// </summary>
        public virtual void CentralBufferNode(CentralBufferNode _this)
        {
        }
    
        /// <summary>
        /// A ChangeEvent models a change in the system configuration that makes a condition true.
        /// </summary>
        public virtual void ChangeEvent(ChangeEvent _this)
        {
        }
    
        /// <summary>
        /// A ClassifierTemplateParameter exposes a Classifier as a formal template parameter.
        /// </summary>
        public virtual void ClassifierTemplateParameter(ClassifierTemplateParameter _this)
        {
        }
    
        /// <summary>
        /// A Clause is an Element that represents a single branch of a ConditionalNode, including a test and a body section. The body section is executed only if (but not necessarily if) the test section evaluates to true.
        /// </summary>
        public virtual void Clause(Clause _this)
        {
        }
    
        /// <summary>
        /// A ClearAssociationAction is an Action that destroys all links of an Association in which a particular object participates.
        /// </summary>
        public virtual void ClearAssociationAction(ClearAssociationAction _this)
        {
        }
    
        /// <summary>
        /// A ClearStructuralFeatureAction is a StructuralFeatureAction that removes all values of a StructuralFeature.
        /// </summary>
        public virtual void ClearStructuralFeatureAction(ClearStructuralFeatureAction _this)
        {
        }
    
        /// <summary>
        /// A ClearVariableAction is a VariableAction that removes all values of a Variable.
        /// </summary>
        public virtual void ClearVariableAction(ClearVariableAction _this)
        {
        }
    
        /// <summary>
        /// A Collaboration describes a structure of collaborating elements (roles), each performing a specialized function, which collectively accomplish some desired functionality.
        /// </summary>
        public virtual void Collaboration(Collaboration _this)
        {
        }
    
        /// <summary>
        /// A CollaborationUse is used to specify the application of a pattern specified by a Collaboration to a specific situation.
        /// </summary>
        public virtual void CollaborationUse(CollaborationUse _this)
        {
        }
    
        /// <summary>
        /// A CombinedFragment defines an expression of InteractionFragments. A CombinedFragment is defined by an interaction operator and corresponding InteractionOperands. Through the use of CombinedFragments the user will be able to describe a number of traces in a compact and concise manner.
        /// </summary>
        public virtual void CombinedFragment(CombinedFragment _this)
        {
        }
    
        /// <summary>
        /// A Comment is a textual annotation that can be attached to a set of Elements.
        /// </summary>
        public virtual void Comment(Comment _this)
        {
        }
    
        /// <summary>
        /// A communication path is an association between two deployment targets, through which they are able to exchange signals and messages.
        /// </summary>
        public virtual void CommunicationPath(CommunicationPath _this)
        {
        }
    
        /// <summary>
        /// A Component represents a modular part of a system that encapsulates its contents and whose manifestation is replaceable within its environment.
        /// </summary>
        public virtual void Component(Component _this)
        {
        }
    
        /// <summary>
        /// Realization is specialized to (optionally) define the Classifiers that realize the contract offered by a Component in terms of its provided and required Interfaces. The Component forms an abstraction from these various Classifiers.
        /// </summary>
        public virtual void ComponentRealization(ComponentRealization _this)
        {
        }
    
        /// <summary>
        /// A ConditionalNode is a StructuredActivityNode that chooses one among some number of alternative collections of ExecutableNodes to execute.
        /// </summary>
        public virtual void ConditionalNode(ConditionalNode _this)
        {
        }
    
        /// <summary>
        /// ConnectableElement is an abstract metaclass representing a set of instances that play roles of a StructuredClassifier. ConnectableElements may be joined by attached Connectors and specify configurations of linked instances to be created within an instance of the containing StructuredClassifier.
        /// </summary>
        public virtual void ConnectableElement(ConnectableElement _this)
        {
        }
    
        /// <summary>
        /// A ConnectableElementTemplateParameter exposes a ConnectableElement as a formal parameter for a template.
        /// </summary>
        public virtual void ConnectableElementTemplateParameter(ConnectableElementTemplateParameter _this)
        {
        }
    
        /// <summary>
        /// A ConnectionPointReference represents a usage (as part of a submachine State) of an entry/exit point Pseudostate defined in the StateMachine referenced by the submachine State.
        /// </summary>
        public virtual void ConnectionPointReference(ConnectionPointReference _this)
        {
        }
    
        /// <summary>
        /// A Connector specifies links that enables communication between two or more instances. In contrast to Associations, which specify links between any instance of the associated Classifiers, Connectors specify links between instances playing the connected parts only.
        /// </summary>
        public virtual void Connector(Connector _this)
        {
        }
    
        /// <summary>
        /// A ConnectorEnd is an endpoint of a Connector, which attaches the Connector to a ConnectableElement.
        /// </summary>
        public virtual void ConnectorEnd(ConnectorEnd _this)
        {
        }
    
        /// <summary>
        /// A ConsiderIgnoreFragment is a kind of CombinedFragment that is used for the consider and ignore cases, which require lists of pertinent Messages to be specified.
        /// </summary>
        public virtual void ConsiderIgnoreFragment(ConsiderIgnoreFragment _this)
        {
        }
    
        /// <summary>
        /// A Constraint is a condition or restriction expressed in natural language text or in a machine readable language for the purpose of declaring some of the semantics of an Element or set of Elements.
        /// </summary>
        public virtual void Constraint(Constraint _this)
        {
        }
    
        /// <summary>
        /// A Continuation is a syntactic way to define continuations of different branches of an alternative CombinedFragment. Continuations are intuitively similar to labels representing intermediate points in a flow of control.
        /// </summary>
        public virtual void Continuation(Continuation _this)
        {
        }
    
        /// <summary>
        /// A ControlFlow is an ActivityEdge traversed by control tokens or object tokens of control type, which are use to control the execution of ExecutableNodes.
        /// </summary>
        public virtual void ControlFlow(ControlFlow _this)
        {
        }
    
        /// <summary>
        /// A ControlNode is an abstract ActivityNode that coordinates flows in an Activity.
        /// </summary>
        public virtual void ControlNode(ControlNode _this)
        {
        }
    
        /// <summary>
        /// A CreateLinkAction is a WriteLinkAction for creating links.
        /// </summary>
        public virtual void CreateLinkAction(CreateLinkAction _this)
        {
        }
    
        /// <summary>
        /// A CreateLinkObjectAction is a CreateLinkAction for creating link objects (AssociationClasse instances).
        /// </summary>
        public virtual void CreateLinkObjectAction(CreateLinkObjectAction _this)
        {
        }
    
        /// <summary>
        /// A CreateObjectAction is an Action that creates an instance of the specified Classifier.
        /// </summary>
        public virtual void CreateObjectAction(CreateObjectAction _this)
        {
        }
    
        /// <summary>
        /// A DataStoreNode is a CentralBufferNode for persistent data.
        /// </summary>
        public virtual void DataStoreNode(DataStoreNode _this)
        {
        }
    
        /// <summary>
        /// A DataType is a type whose instances are identified only by their value.
        /// </summary>
        public virtual void DataType(DataType _this)
        {
        }
    
        /// <summary>
        /// A DecisionNode is a ControlNode that chooses between outgoing ActivityEdges for the routing of tokens.
        /// </summary>
        public virtual void DecisionNode(DecisionNode _this)
        {
        }
    
        /// <summary>
        /// A Dependency is a Relationship that signifies that a single model Element or a set of model Elements requires other model Elements for their specification or implementation. This means that the complete semantics of the client Element(s) are either semantically or structurally dependent on the definition of the supplier Element(s).
        /// </summary>
        public virtual void Dependency(Dependency _this)
        {
        }
    
        /// <summary>
        /// A deployed artifact is an artifact or artifact instance that has been deployed to a deployment target.
        /// </summary>
        public virtual void DeployedArtifact(DeployedArtifact _this)
        {
        }
    
        /// <summary>
        /// A deployment target is the location for a deployed artifact.
        /// </summary>
        public virtual void DeploymentTarget(DeploymentTarget _this)
        {
        }
    
        /// <summary>
        /// A DestroyLinkAction is a WriteLinkAction that destroys links (including link objects).
        /// </summary>
        public virtual void DestroyLinkAction(DestroyLinkAction _this)
        {
        }
    
        /// <summary>
        /// A DestroyObjectAction is an Action that destroys objects.
        /// </summary>
        public virtual void DestroyObjectAction(DestroyObjectAction _this)
        {
        }
    
        /// <summary>
        /// A DestructionOccurenceSpecification models the destruction of an object.
        /// </summary>
        public virtual void DestructionOccurrenceSpecification(DestructionOccurrenceSpecification _this)
        {
        }
    
        /// <summary>
        /// A DirectedRelationship represents a relationship between a collection of source model Elements and a collection of target model Elements.
        /// </summary>
        public virtual void DirectedRelationship(DirectedRelationship _this)
        {
        }
    
        /// <summary>
        /// An ElementImport identifies a NamedElement in a Namespace other than the one that owns that NamedElement and allows the NamedElement to be referenced using an unqualified name in the Namespace owning the ElementImport.
        /// </summary>
        public virtual void ElementImport(ElementImport _this)
        {
        }
    
        /// <summary>
        /// An ExceptionHandler is an Element that specifies a handlerBody ExecutableNode to execute in case the specified exception occurs during the execution of the protected ExecutableNode.
        /// </summary>
        public virtual void ExceptionHandler(ExceptionHandler _this)
        {
        }
    
        /// <summary>
        /// An ExecutableNode is an abstract class for ActivityNodes whose execution may be controlled using ControlFlows and to which ExceptionHandlers may be attached.
        /// </summary>
        public virtual void ExecutableNode(ExecutableNode _this)
        {
        }
    
        /// <summary>
        /// An ExecutionOccurrenceSpecification represents moments in time at which Actions or Behaviors start or finish.
        /// </summary>
        public virtual void ExecutionOccurrenceSpecification(ExecutionOccurrenceSpecification _this)
        {
        }
    
        /// <summary>
        /// An ExecutionSpecification is a specification of the execution of a unit of Behavior or Action within the Lifeline. The duration of an ExecutionSpecification is represented by two OccurrenceSpecifications, the start OccurrenceSpecification and the finish OccurrenceSpecification.
        /// </summary>
        public virtual void ExecutionSpecification(ExecutionSpecification _this)
        {
        }
    
        /// <summary>
        /// An ExpansionNode is an ObjectNode used to indicate a collection input or output for an ExpansionRegion. A collection input of an ExpansionRegion contains a collection that is broken into its individual elements inside the region, whose content is executed once per element. A collection output of an ExpansionRegion combines individual elements produced by the execution of the region into a collection for use outside the region.
        /// </summary>
        public virtual void ExpansionNode(ExpansionNode _this)
        {
        }
    
        /// <summary>
        /// An ExpansionRegion is a StructuredActivityNode that executes its content multiple times corresponding to elements of input collection(s).
        /// </summary>
        public virtual void ExpansionRegion(ExpansionRegion _this)
        {
        }
    
        /// <summary>
        /// A relationship from an extending UseCase to an extended UseCase that specifies how and when the behavior defined in the extending UseCase can be inserted into the behavior defined in the extended UseCase.
        /// </summary>
        public virtual void Extend(Extend _this)
        {
        }
    
        /// <summary>
        /// An extension end is used to tie an extension to a stereotype when extending a metaclass.
        /// The default multiplicity of an extension end is 0..1.
        /// </summary>
        public virtual void ExtensionEnd(ExtensionEnd _this)
        {
        }
    
        /// <summary>
        /// An ExtensionPoint identifies a point in the behavior of a UseCase where that behavior can be extended by the behavior of some other (extending) UseCase, as specified by an Extend relationship.
        /// </summary>
        public virtual void ExtensionPoint(ExtensionPoint _this)
        {
        }
    
        /// <summary>
        /// A Feature declares a behavioral or structural characteristic of Classifiers.
        /// </summary>
        public virtual void Feature(Feature _this)
        {
        }
    
        /// <summary>
        /// A FinalNode is an abstract ControlNode at which a flow in an Activity stops.
        /// </summary>
        public virtual void FinalNode(FinalNode _this)
        {
        }
    
        /// <summary>
        /// A special kind of State, which, when entered, signifies that the enclosing Region has completed. If the enclosing Region is directly contained in a StateMachine and all other Regions in that StateMachine also are completed, then it means that the entire StateMachine behavior is completed.
        /// </summary>
        public virtual void FinalState(FinalState _this)
        {
        }
    
        /// <summary>
        /// A FlowFinalNode is a FinalNode that terminates a flow by consuming the tokens offered to it.
        /// </summary>
        public virtual void FlowFinalNode(FlowFinalNode _this)
        {
        }
    
        /// <summary>
        /// A ForkNode is a ControlNode that splits a flow into multiple concurrent flows.
        /// </summary>
        public virtual void ForkNode(ForkNode _this)
        {
        }
    
        /// <summary>
        /// A Gate is a MessageEnd which serves as a connection point for relating a Message which has a MessageEnd (sendEvent / receiveEvent) outside an InteractionFragment with another Message which has a MessageEnd (receiveEvent / sendEvent)  inside that InteractionFragment.
        /// </summary>
        public virtual void Gate(Gate _this)
        {
        }
    
        /// <summary>
        /// A Generalization is a taxonomic relationship between a more general Classifier and a more specific Classifier. Each instance of the specific Classifier is also an instance of the general Classifier. The specific Classifier inherits the features of the more general Classifier. A Generalization is owned by the specific Classifier.
        /// </summary>
        public virtual void Generalization(Generalization _this)
        {
        }
    
        /// <summary>
        /// A GeneralOrdering represents a binary relation between two OccurrenceSpecifications, to describe that one OccurrenceSpecification must occur before the other in a valid trace. This mechanism provides the ability to define partial orders of OccurrenceSpecifications that may otherwise not have a specified order.
        /// </summary>
        public virtual void GeneralOrdering(GeneralOrdering _this)
        {
        }
    
        /// <summary>
        /// Physical definition of a graphical image.
        /// </summary>
        public virtual void Image(Image _this)
        {
        }
    
        /// <summary>
        /// An Include relationship specifies that a UseCase contains the behavior defined in another UseCase.
        /// </summary>
        public virtual void Include(Include _this)
        {
        }
    
        /// <summary>
        /// An InitialNode is a ControlNode that offers a single control token when initially enabled.
        /// </summary>
        public virtual void InitialNode(InitialNode _this)
        {
        }
    
        /// <summary>
        /// An InputPin is a Pin that holds input values to be consumed by an Action.
        /// </summary>
        public virtual void InputPin(InputPin _this)
        {
        }
    
        /// <summary>
        /// A ParameterableElement is an Element that can be exposed as a formal TemplateParameter for a template, or specified as an actual parameter in a binding of a template.
        /// </summary>
        public virtual void ParameterableElement(ParameterableElement _this)
        {
        }
    
        /// <summary>
        /// A PackageableElement is a NamedElement that may be owned directly by a Package. A PackageableElement is also able to serve as the parameteredElement of a TemplateParameter.
        /// </summary>
        public virtual void PackageableElement(PackageableElement _this)
        {
        }
    
        /// <summary>
        /// An artifact is the specification of a physical piece of information that is used or produced by a software development process, or by deployment and operation of a system. Examples of artifacts include model files, source files, scripts, and binary executable files, a table in a database system, a development deliverable, or a word-processing document, a mail message.
        /// An artifact is the source of a deployment to a node.
        /// </summary>
        public virtual void Artifact(Artifact _this)
        {
        }
    
        /// <summary>
        /// A deployment is the allocation of an artifact or artifact instance to a deployment target.
        /// A component deployment is the deployment of one or more artifacts or artifact instances to a deployment target, optionally parameterized by a deployment specification. Examples are executables and configuration files.
        /// </summary>
        public virtual void Deployment(Deployment _this)
        {
        }
    
        /// <summary>
        /// A deployment specification specifies a set of properties that determine execution parameters of a component artifact that is deployed on a node. A deployment specification can be aimed at a specific type of container. An artifact that reifies or implements deployment specification properties is a deployment descriptor.
        /// </summary>
        public virtual void DeploymentSpecification(DeploymentSpecification _this)
        {
        }
    
        /// <summary>
        /// A Duration is a ValueSpecification that specifies the temporal distance between two time instants.
        /// </summary>
        public virtual void Duration(Duration _this)
        {
        }
    
        /// <summary>
        /// A DurationConstraint is a Constraint that refers to a DurationInterval.
        /// </summary>
        public virtual void DurationConstraint(DurationConstraint _this)
        {
        }
    
        /// <summary>
        /// A DurationInterval defines the range between two Durations.
        /// </summary>
        public virtual void DurationInterval(DurationInterval _this)
        {
        }
    
        /// <summary>
        /// A DurationObservation is a reference to a duration during an execution. It points out the NamedElement(s) in the model to observe and whether the observations are when this NamedElement is entered or when it is exited.
        /// </summary>
        public virtual void DurationObservation(DurationObservation _this)
        {
        }
    
        /// <summary>
        /// An EncapsulatedClassifier may own Ports to specify typed interaction points.
        /// </summary>
        public virtual void EncapsulatedClassifier(EncapsulatedClassifier _this)
        {
        }
    
        /// <summary>
        /// A device is a physical computational resource with processing capability upon which artifacts may be deployed for execution. Devices may be complex (i.e., they may consist of other devices).
        /// </summary>
        public virtual void Device(Device _this)
        {
        }
    
        /// <summary>
        /// An Enumeration is a DataType whose values are enumerated in the model as EnumerationLiterals.
        /// </summary>
        public virtual void Enumeration(Enumeration _this)
        {
        }
    
        /// <summary>
        /// An EnumerationLiteral is a user-defined data value for an Enumeration.
        /// </summary>
        public virtual void EnumerationLiteral(EnumerationLiteral _this)
        {
        }
    
        /// <summary>
        /// An Event is the specification of some occurrence that may potentially trigger effects by an object.
        /// </summary>
        public virtual void Event(Event _this)
        {
        }
    
        /// <summary>
        /// An execution environment is a node that offers an execution environment for specific types of components that are deployed on it in the form of executable artifacts.
        /// </summary>
        public virtual void ExecutionEnvironment(ExecutionEnvironment _this)
        {
        }
    
        /// <summary>
        /// An Expression represents a node in an expression tree, which may be non-terminal or terminal. It defines a symbol, and has a possibly empty sequence of operands that are ValueSpecifications. It denotes a (possibly empty) set of values when evaluated in a context.
        /// </summary>
        public virtual void Expression(Expression _this)
        {
        }
    
        /// <summary>
        /// An extension is used to indicate that the properties of a metaclass are extended through a stereotype, and gives the ability to flexibly add (and later remove) stereotypes to classes.
        /// </summary>
        public virtual void Extension(Extension _this)
        {
        }
    
        /// <summary>
        /// A FunctionBehavior is an OpaqueBehavior that does not access or modify any objects or other external data.
        /// </summary>
        public virtual void FunctionBehavior(FunctionBehavior _this)
        {
        }
    
        /// <summary>
        /// A GeneralizationSet is a PackageableElement whose instances represent sets of Generalization relationships.
        /// </summary>
        public virtual void GeneralizationSet(GeneralizationSet _this)
        {
        }
    
        /// <summary>
        /// InformationFlows describe circulation of information through a system in a general manner. They do not specify the nature of the information, mechanisms by which it is conveyed, sequences of exchange or any control conditions. During more detailed modeling, representation and realization links may be added to specify which model elements implement an InformationFlow and to show how information is conveyed.  InformationFlows require some kind of “information channel” for unidirectional transmission of information items from sources to targets.  They specify the information channel’s realizations, if any, and identify the information that flows along them.  Information moving along the information channel may be represented by abstract InformationItems and by concrete Classifiers.
        /// </summary>
        public virtual void InformationFlow(InformationFlow _this)
        {
        }
    
        /// <summary>
        /// InformationItems represent many kinds of information that can flow from sources to targets in very abstract ways.  They represent the kinds of information that may move within a system, but do not elaborate details of the transferred information.  Details of transferred information are the province of other Classifiers that may ultimately define InformationItems.  Consequently, InformationItems cannot be instantiated and do not themselves have features, generalizations, or associations. An important use of InformationItems is to represent information during early design stages, possibly before the detailed modeling decisions that will ultimately define them have been made. Another purpose of InformationItems is to abstract portions of complex models in less precise, but perhaps more general and communicable, ways.
        /// </summary>
        public virtual void InformationItem(InformationItem _this)
        {
        }
    
        /// <summary>
        /// An InstanceSpecification is a model element that represents an instance in a modeled system. An InstanceSpecification can act as a DeploymentTarget in a Deployment relationship, in the case that it represents an instance of a Node. It can also act as a DeployedArtifact, if it represents an instance of an Artifact.
        /// </summary>
        public virtual void InstanceSpecification(InstanceSpecification _this)
        {
        }
    
        /// <summary>
        /// A TypedElement is a NamedElement that may have a Type specified for it.
        /// </summary>
        public virtual void TypedElement(TypedElement _this)
        {
        }
    
        /// <summary>
        /// An InstanceValue is a ValueSpecification that identifies an instance.
        /// </summary>
        public virtual void InstanceValue(InstanceValue _this)
        {
        }
    
        /// <summary>
        /// An Interaction is a unit of Behavior that focuses on the observable exchange of information between connectable elements.
        /// </summary>
        public virtual void Interaction(Interaction _this)
        {
        }
    
        /// <summary>
        /// An InteractionConstraint is a Boolean expression that guards an operand in a CombinedFragment.
        /// </summary>
        public virtual void InteractionConstraint(InteractionConstraint _this)
        {
        }
    
        /// <summary>
        /// InteractionFragment is an abstract notion of the most general interaction unit. An InteractionFragment is a piece of an Interaction. Each InteractionFragment is conceptually like an Interaction by itself.
        /// </summary>
        public virtual void InteractionFragment(InteractionFragment _this)
        {
        }
    
        /// <summary>
        /// An InteractionOperand is contained in a CombinedFragment. An InteractionOperand represents one operand of the expression given by the enclosing CombinedFragment.
        /// </summary>
        public virtual void InteractionOperand(InteractionOperand _this)
        {
        }
    
        /// <summary>
        /// An InteractionUse refers to an Interaction. The InteractionUse is a shorthand for copying the contents of the referenced Interaction where the InteractionUse is. To be accurate the copying must take into account substituting parameters with arguments and connect the formal Gates with the actual ones.
        /// </summary>
        public virtual void InteractionUse(InteractionUse _this)
        {
        }
    
        /// <summary>
        /// Interfaces declare coherent services that are implemented by BehavioredClassifiers that implement the Interfaces via InterfaceRealizations.
        /// </summary>
        public virtual void Interface(Interface _this)
        {
        }
    
        /// <summary>
        /// An InterfaceRealization is a specialized realization relationship between a BehavioredClassifier and an Interface. This relationship signifies that the realizing BehavioredClassifier conforms to the contract specified by the Interface.
        /// </summary>
        public virtual void InterfaceRealization(InterfaceRealization _this)
        {
        }
    
        /// <summary>
        /// An InterruptibleActivityRegion is an ActivityGroup that supports the termination of tokens flowing in the portions of an activity within it.
        /// </summary>
        public virtual void InterruptibleActivityRegion(InterruptibleActivityRegion _this)
        {
        }
    
        /// <summary>
        /// An Interval defines the range between two ValueSpecifications.
        /// </summary>
        public virtual void Interval(Interval _this)
        {
        }
    
        /// <summary>
        /// An IntervalConstraint is a Constraint that is specified by an Interval.
        /// </summary>
        public virtual void IntervalConstraint(IntervalConstraint _this)
        {
        }
    
        /// <summary>
        /// InvocationAction is an abstract class for the various actions that request Behavior invocation.
        /// </summary>
        public virtual void InvocationAction(InvocationAction _this)
        {
        }
    
        /// <summary>
        /// A JoinNode is a ControlNode that synchronizes multiple flows.
        /// </summary>
        public virtual void JoinNode(JoinNode _this)
        {
        }
    
        /// <summary>
        /// A Lifeline represents an individual participant in the Interaction. While parts and structural features may have multiplicity greater than 1, Lifelines represent only one interacting entity.
        /// </summary>
        public virtual void Lifeline(Lifeline _this)
        {
        }
    
        /// <summary>
        /// LinkAction is an abstract class for all Actions that identify the links to be acted on using LinkEndData.
        /// </summary>
        public virtual void LinkAction(LinkAction _this)
        {
        }
    
        /// <summary>
        /// LinkEndData is an Element that identifies on end of a link to be read or written by a LinkAction. As a link (that is not a link object) cannot be passed as a runtime value to or from an Action, it is instead identified by its end objects and qualifier values, if any. A LinkEndData instance provides these values for a single Association end.
        /// </summary>
        public virtual void LinkEndData(LinkEndData _this)
        {
        }
    
        /// <summary>
        /// LinkEndCreationData is LinkEndData used to provide values for one end of a link to be created by a CreateLinkAction.
        /// </summary>
        public virtual void LinkEndCreationData(LinkEndCreationData _this)
        {
        }
    
        /// <summary>
        /// LinkEndDestructionData is LinkEndData used to provide values for one end of a link to be destroyed by a DestroyLinkAction.
        /// </summary>
        public virtual void LinkEndDestructionData(LinkEndDestructionData _this)
        {
        }
    
        /// <summary>
        /// A LiteralSpecification identifies a literal constant being modeled.
        /// </summary>
        public virtual void LiteralSpecification(LiteralSpecification _this)
        {
        }
    
        /// <summary>
        /// A LiteralBoolean is a specification of a Boolean value.
        /// </summary>
        public virtual void LiteralBoolean(LiteralBoolean _this)
        {
        }
    
        /// <summary>
        /// A LiteralInteger is a specification of an Integer value.
        /// </summary>
        public virtual void LiteralInteger(LiteralInteger _this)
        {
        }
    
        /// <summary>
        /// A LiteralNull specifies the lack of a value.
        /// </summary>
        public virtual void LiteralNull(LiteralNull _this)
        {
        }
    
        /// <summary>
        /// A LiteralReal is a specification of a Real value.
        /// </summary>
        public virtual void LiteralReal(LiteralReal _this)
        {
        }
    
        /// <summary>
        /// A LiteralString is a specification of a String value.
        /// </summary>
        public virtual void LiteralString(LiteralString _this)
        {
        }
    
        /// <summary>
        /// A LiteralUnlimitedNatural is a specification of an UnlimitedNatural number.
        /// </summary>
        public virtual void LiteralUnlimitedNatural(LiteralUnlimitedNatural _this)
        {
        }
    
        /// <summary>
        /// A LoopNode is a StructuredActivityNode that represents an iterative loop with setup, test, and body sections.
        /// </summary>
        public virtual void LoopNode(LoopNode _this)
        {
        }
    
        /// <summary>
        /// A manifestation is the concrete physical rendering of one or more model elements by an artifact.
        /// </summary>
        public virtual void Manifestation(Manifestation _this)
        {
        }
    
        /// <summary>
        /// A merge node is a control node that brings together multiple alternate flows. It is not used to synchronize concurrent flows but to accept one among several alternate flows.
        /// </summary>
        public virtual void MergeNode(MergeNode _this)
        {
        }
    
        /// <summary>
        /// A Message defines a particular communication between Lifelines of an Interaction.
        /// </summary>
        public virtual void Message(Message _this)
        {
        }
    
        /// <summary>
        /// MessageEnd is an abstract specialization of NamedElement that represents what can occur at the end of a Message.
        /// </summary>
        public virtual void MessageEnd(MessageEnd _this)
        {
        }
    
        /// <summary>
        /// A MessageEvent specifies the receipt by an object of either an Operation call or a Signal instance.
        /// </summary>
        public virtual void MessageEvent(MessageEvent _this)
        {
        }
    
        /// <summary>
        /// A model captures a view of a physical system. It is an abstraction of the physical system, with a certain purpose. This purpose determines what is to be included in the model and what is irrelevant. Thus the model completely describes those aspects of the physical system that are relevant to the purpose of the model, at the appropriate level of detail.
        /// </summary>
        public virtual void Model(Model _this)
        {
        }
    
        /// <summary>
        /// A multiplicity is a definition of an inclusive interval of non-negative integers beginning with a lower bound and ending with a (possibly infinite) upper bound. A MultiplicityElement embeds this information to specify the allowable cardinalities for an instantiation of the Element.
        /// </summary>
        public virtual void MultiplicityElement(MultiplicityElement _this)
        {
        }
    
        /// <summary>
        /// A Namespace is an Element in a model that owns and/or imports a set of NamedElements that can be identified by name.
        /// </summary>
        public virtual void Namespace(Namespace _this)
        {
        }
    
        /// <summary>
        /// A Node is computational resource upon which artifacts may be deployed for execution. Nodes can be interconnected through communication paths to define network structures.
        /// </summary>
        public virtual void Node(Node _this)
        {
        }
    
        /// <summary>
        /// An ObjectFlow is an ActivityEdge that is traversed by object tokens that may hold values. Object flows also support multicast/receive, token selection from object nodes, and transformation of tokens.
        /// </summary>
        public virtual void ObjectFlow(ObjectFlow _this)
        {
        }
    
        /// <summary>
        /// An ObjectNode is an abstract ActivityNode that may hold tokens within the object flow in an Activity. ObjectNodes also support token selection, limitation on the number of tokens held, specification of the state required for tokens being held, and carrying control values.
        /// </summary>
        public virtual void ObjectNode(ObjectNode _this)
        {
        }
    
        /// <summary>
        /// Observation specifies a value determined by observing an event or events that occur relative to other model Elements.
        /// </summary>
        public virtual void Observation(Observation _this)
        {
        }
    
        /// <summary>
        /// An OccurrenceSpecification is the basic semantic unit of Interactions. The sequences of occurrences specified by them are the meanings of Interactions.
        /// </summary>
        public virtual void OccurrenceSpecification(OccurrenceSpecification _this)
        {
        }
    
        /// <summary>
        /// A MessageOccurrenceSpecification specifies the occurrence of Message events, such as sending and receiving of Signals or invoking or receiving of Operation calls. A MessageOccurrenceSpecification is a kind of MessageEnd. Messages are generated either by synchronous Operation calls or asynchronous Signal sends. They are received by the execution of corresponding AcceptEventActions.
        /// </summary>
        public virtual void MessageOccurrenceSpecification(MessageOccurrenceSpecification _this)
        {
        }
    
        /// <summary>
        /// An OpaqueExpression is a ValueSpecification that specifies the computation of a collection of values either in terms of a UML Behavior or based on a textual statement in a language other than UML
        /// </summary>
        public virtual void OpaqueExpression(OpaqueExpression _this)
        {
        }
    
        /// <summary>
        /// An OperationTemplateParameter exposes an Operation as a formal parameter for a template.
        /// </summary>
        public virtual void OperationTemplateParameter(OperationTemplateParameter _this)
        {
        }
    
        /// <summary>
        /// A package can have one or more profile applications to indicate which profiles have been applied. Because a profile is a package, it is possible to apply a profile not only to packages, but also to profiles.
        /// Package specializes TemplateableElement and PackageableElement specializes ParameterableElement to specify that a package can be used as a template and a PackageableElement as a template parameter.
        /// A package is used to group elements, and provides a namespace for the grouped elements.
        /// </summary>
        public virtual void Package(Package _this)
        {
        }
    
        /// <summary>
        /// A PackageImport is a Relationship that imports all the non-private members of a Package into the Namespace owning the PackageImport, so that those Elements may be referred to by their unqualified names in the importingNamespace.
        /// </summary>
        public virtual void PackageImport(PackageImport _this)
        {
        }
    
        /// <summary>
        /// A package merge defines how the contents of one package are extended by the contents of another package.
        /// </summary>
        public virtual void PackageMerge(PackageMerge _this)
        {
        }
    
        /// <summary>
        /// A Parameter is a specification of an argument used to pass information into or out of an invocation of a BehavioralFeature.  Parameters can be treated as ConnectableElements within Collaborations.
        /// </summary>
        public virtual void Parameter(Parameter _this)
        {
        }
    
        /// <summary>
        /// A ParameterSet designates alternative sets of inputs or outputs that a Behavior may use.
        /// </summary>
        public virtual void ParameterSet(ParameterSet _this)
        {
        }
    
        /// <summary>
        /// A PartDecomposition is a description of the internal Interactions of one Lifeline relative to an Interaction.
        /// </summary>
        public virtual void PartDecomposition(PartDecomposition _this)
        {
        }
    
        /// <summary>
        /// A RedefinableElement is an element that, when defined in the context of a Classifier, can be redefined more specifically or differently in the context of another Classifier that specializes (directly or indirectly) the context Classifier.
        /// </summary>
        public virtual void RedefinableElement(RedefinableElement _this)
        {
        }
    
        /// <summary>
        /// An OpaqueAction is an Action whose functionality is not specified within UML.
        /// </summary>
        public virtual void OpaqueAction(OpaqueAction _this)
        {
        }
    
        /// <summary>
        /// An OpaqueBehavior is a Behavior whose specification is given in a textual language other than UML.
        /// </summary>
        public virtual void OpaqueBehavior(OpaqueBehavior _this)
        {
        }
    
        /// <summary>
        /// An Operation is a BehavioralFeature of a Classifier that specifies the name, type, parameters, and constraints for invoking an associated Behavior. An Operation may invoke both the execution of method behaviors as well as other behavioral responses. Operation specializes TemplateableElement in order to support specification of template operations and bound operations. Operation specializes ParameterableElement to specify that an operation can be exposed as a formal template parameter, and provided as an actual parameter in a binding of a template.
        /// </summary>
        public virtual void Operation(Operation _this)
        {
        }
    
        /// <summary>
        /// A Pin is an ObjectNode and MultiplicityElement that provides input values to an Action or accepts output values from an Action.
        /// </summary>
        public virtual void Pin(Pin _this)
        {
        }
    
        /// <summary>
        /// An OutputPin is a Pin that holds output values produced by an Action.
        /// </summary>
        public virtual void OutputPin(OutputPin _this)
        {
        }
    
        /// <summary>
        /// A StructuralFeature is a typed feature of a Classifier that specifies the structure of instances of the Classifier.
        /// </summary>
        public virtual void StructuralFeature(StructuralFeature _this)
        {
        }
    
        /// <summary>
        /// A Property is a StructuralFeature. A Property related by ownedAttribute to a Classifier (other than an association) represents an attribute and might also represent an association end. It relates an instance of the Classifier to a value or set of values of the type of the attribute. A Property related by memberEnd to an Association represents an end of the Association. The type of the Property is the type of the end of the Association. A Property has the capability of being a DeploymentTarget in a Deployment relationship. This enables modeling the deployment to hierarchical nodes that have Properties functioning as internal parts.  Property specializes ParameterableElement to specify that a Property can be exposed as a formal template parameter, and provided as an actual parameter in a binding of a template.
        /// </summary>
        public virtual void Property(Property _this)
        {
        }
    
        /// <summary>
        /// A Port is a property of an EncapsulatedClassifier that specifies a distinct interaction point between that EncapsulatedClassifier and its environment or between the (behavior of the) EncapsulatedClassifier and its internal parts. Ports are connected to Properties of the EncapsulatedClassifier by Connectors through which requests can be made to invoke BehavioralFeatures. A Port may specify the services an EncapsulatedClassifier provides (offers) to its environment as well as the services that an EncapsulatedClassifier expects (requires) of its environment.  A Port may have an associated ProtocolStateMachine.
        /// </summary>
        public virtual void Port(Port _this)
        {
        }
    
        /// <summary>
        /// A PrimitiveType defines a predefined DataType, without any substructure. A PrimitiveType may have an algebra and operations defined outside of UML, for example, mathematically.
        /// </summary>
        public virtual void PrimitiveType(PrimitiveType _this)
        {
        }
    
        /// <summary>
        /// A profile defines limited extensions to a reference metamodel with the purpose of adapting the metamodel to a specific platform or domain.
        /// </summary>
        public virtual void Profile(Profile _this)
        {
        }
    
        /// <summary>
        /// A profile application is used to show which profiles have been applied to a package.
        /// </summary>
        public virtual void ProfileApplication(ProfileApplication _this)
        {
        }
    
        /// <summary>
        /// A ProtocolStateMachine can be redefined into a more specific ProtocolStateMachine or into behavioral StateMachine. ProtocolConformance declares that the specific ProtocolStateMachine specifies a protocol that conforms to the general ProtocolStateMachine or that the specific behavioral StateMachine abides by the protocol of the general ProtocolStateMachine.
        /// </summary>
        public virtual void ProtocolConformance(ProtocolConformance _this)
        {
        }
    
        /// <summary>
        /// A ProtocolStateMachine is always defined in the context of a Classifier. It specifies which BehavioralFeatures of the Classifier can be called in which State and under which conditions, thus specifying the allowed invocation sequences on the Classifier&apos;s BehavioralFeatures. A ProtocolStateMachine specifies the possible and permitted Transitions on the instances of its context Classifier, together with the BehavioralFeatures that carry the Transitions. In this manner, an instance lifecycle can be specified for a Classifier, by defining the order in which the BehavioralFeatures can be activated and the States through which an instance progresses during its existence.
        /// </summary>
        public virtual void ProtocolStateMachine(ProtocolStateMachine _this)
        {
        }
    
        /// <summary>
        /// A ProtocolTransition specifies a legal Transition for an Operation. Transitions of ProtocolStateMachines have the following information: a pre-condition (guard), a Trigger, and a post-condition. Every ProtocolTransition is associated with at most one BehavioralFeature belonging to the context Classifier of the ProtocolStateMachine.
        /// </summary>
        public virtual void ProtocolTransition(ProtocolTransition _this)
        {
        }
    
        /// <summary>
        /// A Pseudostate is an abstraction that encompasses different types of transient Vertices in the StateMachine graph. A StateMachine instance never comes to rest in a Pseudostate, instead, it will exit and enter the Pseudostate within a single run-to-completion step.
        /// </summary>
        public virtual void Pseudostate(Pseudostate _this)
        {
        }
    
        /// <summary>
        /// A QualifierValue is an Element that is used as part of LinkEndData to provide the value for a single qualifier of the end given by the LinkEndData.
        /// </summary>
        public virtual void QualifierValue(QualifierValue _this)
        {
        }
    
        /// <summary>
        /// A RaiseExceptionAction is an Action that causes an exception to occur. The input value becomes the exception object.
        /// </summary>
        public virtual void RaiseExceptionAction(RaiseExceptionAction _this)
        {
        }
    
        /// <summary>
        /// A ReadExtentAction is an Action that retrieves the current instances of a Classifier.
        /// </summary>
        public virtual void ReadExtentAction(ReadExtentAction _this)
        {
        }
    
        /// <summary>
        /// A ReadIsClassifiedObjectAction is an Action that determines whether an object is classified by a given Classifier.
        /// </summary>
        public virtual void ReadIsClassifiedObjectAction(ReadIsClassifiedObjectAction _this)
        {
        }
    
        /// <summary>
        /// A ReadLinkAction is a LinkAction that navigates across an Association to retrieve the objects on one end.
        /// </summary>
        public virtual void ReadLinkAction(ReadLinkAction _this)
        {
        }
    
        /// <summary>
        /// A ReadLinkObjectEndAction is an Action that retrieves an end object from a link object.
        /// </summary>
        public virtual void ReadLinkObjectEndAction(ReadLinkObjectEndAction _this)
        {
        }
    
        /// <summary>
        /// A ReadLinkObjectEndQualifierAction is an Action that retrieves a qualifier end value from a link object.
        /// </summary>
        public virtual void ReadLinkObjectEndQualifierAction(ReadLinkObjectEndQualifierAction _this)
        {
        }
    
        /// <summary>
        /// A ReadSelfAction is an Action that retrieves the context object of the Behavior execution within which the ReadSelfAction execution is taking place.
        /// </summary>
        public virtual void ReadSelfAction(ReadSelfAction _this)
        {
        }
    
        /// <summary>
        /// A ReadStructuralFeatureAction is a StructuralFeatureAction that retrieves the values of a StructuralFeature.
        /// </summary>
        public virtual void ReadStructuralFeatureAction(ReadStructuralFeatureAction _this)
        {
        }
    
        /// <summary>
        /// A ReadVariableAction is a VariableAction that retrieves the values of a Variable.
        /// </summary>
        public virtual void ReadVariableAction(ReadVariableAction _this)
        {
        }
    
        /// <summary>
        /// Realization is a specialized Abstraction relationship between two sets of model Elements, one representing a specification (the supplier) and the other represents an implementation of the latter (the client). Realization can be used to model stepwise refinement, optimizations, transformations, templates, model synthesis, framework composition, etc.
        /// </summary>
        public virtual void Realization(Realization _this)
        {
        }
    
        /// <summary>
        /// A Reception is a declaration stating that a Classifier is prepared to react to the receipt of a Signal.
        /// </summary>
        public virtual void Reception(Reception _this)
        {
        }
    
        /// <summary>
        /// A ReclassifyObjectAction is an Action that changes the Classifiers that classify an object.
        /// </summary>
        public virtual void ReclassifyObjectAction(ReclassifyObjectAction _this)
        {
        }
    
        /// <summary>
        /// A RedefinableTemplateSignature supports the addition of formal template parameters in a specialization of a template classifier.
        /// </summary>
        public virtual void RedefinableTemplateSignature(RedefinableTemplateSignature _this)
        {
        }
    
        /// <summary>
        /// A ReduceAction is an Action that reduces a collection to a single value by repeatedly combining the elements of the collection using a reducer Behavior.
        /// </summary>
        public virtual void ReduceAction(ReduceAction _this)
        {
        }
    
        /// <summary>
        /// A Region is a top-level part of a StateMachine or a composite State, that serves as a container for the Vertices and Transitions of the StateMachine. A StateMachine or composite State may contain multiple Regions representing behaviors that may occur in parallel.
        /// </summary>
        public virtual void Region(Region _this)
        {
        }
    
        /// <summary>
        /// Relationship is an abstract concept that specifies some kind of relationship between Elements.
        /// </summary>
        public virtual void Relationship(Relationship _this)
        {
        }
    
        /// <summary>
        /// A RemoveStructuralFeatureValueAction is a WriteStructuralFeatureAction that removes values from a StructuralFeature.
        /// </summary>
        public virtual void RemoveStructuralFeatureValueAction(RemoveStructuralFeatureValueAction _this)
        {
        }
    
        /// <summary>
        /// A RemoveVariableValueAction is a WriteVariableAction that removes values from a Variables.
        /// </summary>
        public virtual void RemoveVariableValueAction(RemoveVariableValueAction _this)
        {
        }
    
        /// <summary>
        /// A ReplyAction is an Action that accepts a set of reply values and a value containing return information produced by a previous AcceptCallAction. The ReplyAction returns the values to the caller of the previous call, completing execution of the call.
        /// </summary>
        public virtual void ReplyAction(ReplyAction _this)
        {
        }
    
        /// <summary>
        /// A SendObjectAction is an InvocationAction that transmits an input object to the target object, which is handled as a request message by the target object. The requestor continues execution immediately after the object is sent out and cannot receive reply values.
        /// </summary>
        public virtual void SendObjectAction(SendObjectAction _this)
        {
        }
    
        /// <summary>
        /// A SendSignalAction is an InvocationAction that creates a Signal instance and transmits it to the target object. Values from the argument InputPins are used to provide values for the attributes of the Signal. The requestor continues execution immediately after the Signal instance is sent out and cannot receive reply values.
        /// </summary>
        public virtual void SendSignalAction(SendSignalAction _this)
        {
        }
    
        /// <summary>
        /// A SequenceNode is a StructuredActivityNode that executes a sequence of ExecutableNodes in order.
        /// </summary>
        public virtual void SequenceNode(SequenceNode _this)
        {
        }
    
        /// <summary>
        /// A Slot designates that an entity modeled by an InstanceSpecification has a value or values for a specific StructuralFeature.
        /// </summary>
        public virtual void Slot(Slot _this)
        {
        }
    
        /// <summary>
        /// A StartClassifierBehaviorAction is an Action that starts the classifierBehavior of the input object.
        /// </summary>
        public virtual void StartClassifierBehaviorAction(StartClassifierBehaviorAction _this)
        {
        }
    
        /// <summary>
        /// A StartObjectBehaviorAction is an InvocationAction that starts the execution either of a directly instantiated Behavior or of the classifierBehavior of an object. Argument values may be supplied for the input Parameters of the Behavior. If the Behavior is invoked synchronously, then output values may be obtained for output Parameters.
        /// </summary>
        public virtual void StartObjectBehaviorAction(StartObjectBehaviorAction _this)
        {
        }
    
        /// <summary>
        /// A StateInvariant is a runtime constraint on the participants of the Interaction. It may be used to specify a variety of different kinds of Constraints, such as values of Attributes or Variables, internal or external States, and so on. A StateInvariant is an InteractionFragment and it is placed on a Lifeline.
        /// </summary>
        public virtual void StateInvariant(StateInvariant _this)
        {
        }
    
        /// <summary>
        /// A TemplateableElement is an Element that can optionally be defined as a template and bound to other templates.
        /// </summary>
        public virtual void TemplateableElement(TemplateableElement _this)
        {
        }
    
        /// <summary>
        /// A Signal is a specification of a kind of communication between objects in which a reaction is asynchronously triggered in the receiver without a reply.
        /// </summary>
        public virtual void Signal(Signal _this)
        {
        }
    
        /// <summary>
        /// A SignalEvent represents the receipt of an asynchronous Signal instance.
        /// </summary>
        public virtual void SignalEvent(SignalEvent _this)
        {
        }
    
        /// <summary>
        /// A State models a situation during which some (usually implicit) invariant condition holds.
        /// </summary>
        public virtual void State(State _this)
        {
        }
    
        /// <summary>
        /// StructuredClassifiers may contain an internal structure of connected elements each of which plays a role in the overall Behavior modeled by the StructuredClassifier.
        /// </summary>
        public virtual void StructuredClassifier(StructuredClassifier _this)
        {
        }
    
        /// <summary>
        /// StateMachines can be used to express event-driven behaviors of parts of a system. Behavior is modeled as a traversal of a graph of Vertices interconnected by one or more joined Transition arcs that are triggered by the dispatching of successive Event occurrences. During this traversal, the StateMachine may execute a sequence of Behaviors associated with various elements of the StateMachine.
        /// </summary>
        public virtual void StateMachine(StateMachine _this)
        {
        }
    
        /// <summary>
        /// A stereotype defines how an existing metaclass may be extended, and enables the use of platform or domain specific terminology or notation in place of, or in addition to, the ones used for the extended metaclass.
        /// </summary>
        public virtual void Stereotype(Stereotype _this)
        {
        }
    
        /// <summary>
        /// A StringExpression is an Expression that specifies a String value that is derived by concatenating a sequence of operands with String values or a sequence of subExpressions, some of which might be template parameters.
        /// </summary>
        public virtual void StringExpression(StringExpression _this)
        {
        }
    
        /// <summary>
        /// StructuralFeatureAction is an abstract class for all Actions that operate on StructuralFeatures.
        /// </summary>
        public virtual void StructuralFeatureAction(StructuralFeatureAction _this)
        {
        }
    
        /// <summary>
        /// A StructuredActivityNode is an Action that is also an ActivityGroup and whose behavior is specified by the ActivityNodes and ActivityEdges it so contains. Unlike other kinds of ActivityGroup, a StructuredActivityNode owns the ActivityNodes and ActivityEdges it contains, and so a node or edge can only be directly contained in one StructuredActivityNode, though StructuredActivityNodes may be nested.
        /// </summary>
        public virtual void StructuredActivityNode(StructuredActivityNode _this)
        {
        }
    
        /// <summary>
        /// A substitution is a relationship between two classifiers signifying that the substituting classifier complies with the contract specified by the contract classifier. This implies that instances of the substituting classifier are runtime substitutable where instances of the contract classifier are expected.
        /// </summary>
        public virtual void Substitution(Substitution _this)
        {
        }
    
        /// <summary>
        /// A TemplateBinding is a DirectedRelationship between a TemplateableElement and a template. A TemplateBinding specifies the TemplateParameterSubstitutions of actual parameters for the formal parameters of the template.
        /// </summary>
        public virtual void TemplateBinding(TemplateBinding _this)
        {
        }
    
        /// <summary>
        /// A TemplateParameter exposes a ParameterableElement as a formal parameter of a template.
        /// </summary>
        public virtual void TemplateParameter(TemplateParameter _this)
        {
        }
    
        /// <summary>
        /// A TemplateParameterSubstitution relates the actual parameter to a formal TemplateParameter as part of a template binding.
        /// </summary>
        public virtual void TemplateParameterSubstitution(TemplateParameterSubstitution _this)
        {
        }
    
        /// <summary>
        /// A Template Signature bundles the set of formal TemplateParameters for a template.
        /// </summary>
        public virtual void TemplateSignature(TemplateSignature _this)
        {
        }
    
        /// <summary>
        /// A TestIdentityAction is an Action that tests if two values are identical objects.
        /// </summary>
        public virtual void TestIdentityAction(TestIdentityAction _this)
        {
        }
    
        /// <summary>
        /// A TimeConstraint is a Constraint that refers to a TimeInterval.
        /// </summary>
        public virtual void TimeConstraint(TimeConstraint _this)
        {
        }
    
        /// <summary>
        /// A TimeEvent is an Event that occurs at a specific point in time.
        /// </summary>
        public virtual void TimeEvent(TimeEvent _this)
        {
        }
    
        /// <summary>
        /// A TimeExpression is a ValueSpecification that represents a time value.
        /// </summary>
        public virtual void TimeExpression(TimeExpression _this)
        {
        }
    
        /// <summary>
        /// A TimeInterval defines the range between two TimeExpressions.
        /// </summary>
        public virtual void TimeInterval(TimeInterval _this)
        {
        }
    
        /// <summary>
        /// A TimeObservation is a reference to a time instant during an execution. It points out the NamedElement in the model to observe and whether the observation is when this NamedElement is entered or when it is exited.
        /// </summary>
        public virtual void TimeObservation(TimeObservation _this)
        {
        }
    
        /// <summary>
        /// A Transition represents an arc between exactly one source Vertex and exactly one Target vertex (the source and targets may be the same Vertex). It may form part of a compound transition, which takes the StateMachine from one steady State configuration to another, representing the full response of the StateMachine to an occurrence of an Event that triggered it.
        /// </summary>
        public virtual void Transition(Transition _this)
        {
        }
    
        /// <summary>
        /// A Trigger specifies a specific point  at which an Event occurrence may trigger an effect in a Behavior. A Trigger may be qualified by the Port on which the Event occurred.
        /// </summary>
        public virtual void Trigger(Trigger _this)
        {
        }
    
        /// <summary>
        /// A Type constrains the values represented by a TypedElement.
        /// </summary>
        public virtual void Type(Type _this)
        {
        }
    
        /// <summary>
        /// An UnmarshallAction is an Action that retrieves the values of the StructuralFeatures of an object and places them on OutputPins.
        /// </summary>
        public virtual void UnmarshallAction(UnmarshallAction _this)
        {
        }
    
        /// <summary>
        /// A Usage is a Dependency in which the client Element requires the supplier Element (or set of Elements) for its full implementation or operation.
        /// </summary>
        public virtual void Usage(Usage _this)
        {
        }
    
        /// <summary>
        /// A UseCase specifies a set of actions performed by its subjects, which yields an observable result that is of value for one or more Actors or other stakeholders of each subject.
        /// </summary>
        public virtual void UseCase(UseCase _this)
        {
        }
    
        /// <summary>
        /// A ValuePin is an InputPin that provides a value by evaluating a ValueSpecification.
        /// </summary>
        public virtual void ValuePin(ValuePin _this)
        {
        }
    
        /// <summary>
        /// A ValueSpecification is the specification of a (possibly empty) set of values. A ValueSpecification is a ParameterableElement that may be exposed as a formal TemplateParameter and provided as the actual parameter in the binding of a template.
        /// </summary>
        public virtual void ValueSpecification(ValueSpecification _this)
        {
        }
    
        /// <summary>
        /// A ValueSpecificationAction is an Action that evaluates a ValueSpecification and provides a result.
        /// </summary>
        public virtual void ValueSpecificationAction(ValueSpecificationAction _this)
        {
        }
    
        /// <summary>
        /// A Variable is a ConnectableElement that may store values during the execution of an Activity. Reading and writing the values of a Variable provides an alternative means for passing data than the use of ObjectFlows. A Variable may be owned directly by an Activity, in which case it is accessible from anywhere within that activity, or it may be owned by a StructuredActivityNode, in which case it is only accessible within that node.
        /// </summary>
        public virtual void Variable(Variable _this)
        {
        }
    
        /// <summary>
        /// VariableAction is an abstract class for Actions that operate on a specified Variable.
        /// </summary>
        public virtual void VariableAction(VariableAction _this)
        {
        }
    
        /// <summary>
        /// A Vertex is an abstraction of a node in a StateMachine graph. It can be the source or destination of any number of Transitions.
        /// </summary>
        public virtual void Vertex(Vertex _this)
        {
        }
    
        /// <summary>
        /// WriteLinkAction is an abstract class for LinkActions that create and destroy links.
        /// </summary>
        public virtual void WriteLinkAction(WriteLinkAction _this)
        {
        }
    
        /// <summary>
        /// WriteStructuralFeatureAction is an abstract class for StructuralFeatureActions that change StructuralFeature values.
        /// </summary>
        public virtual void WriteStructuralFeatureAction(WriteStructuralFeatureAction _this)
        {
        }
    
        /// <summary>
        /// WriteVariableAction is an abstract class for VariableActions that change Variable values.
        /// </summary>
        public virtual void WriteVariableAction(WriteVariableAction _this)
        {
        }
    
    
        /// <summary>
        /// Indicates the Dependencies that reference this NamedElement as a client.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Dependency> NamedElement_ClientDependency(NamedElement _this);
    
        /// <summary>
        /// A name that allows the NamedElement to be identified within a hierarchy of nested Namespaces. It is constructed from the names of the containing Namespaces starting at the root of the hierarchy and ending with the name of the NamedElement itself.
        /// </summary>
        public abstract string NamedElement_QualifiedName(NamedElement _this);
    
        /// <summary>
        /// The context Classifier of the Behavior that contains this Action, or the Behavior itself if it has no context.
        /// </summary>
        public abstract Classifier Action_Context(Action _this);
    
        /// <summary>
        /// The generalizing Classifiers for this Classifier.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Classifier> Classifier_General(Classifier _this);
    
        /// <summary>
        /// All elements inherited by this Classifier from its general Classifiers.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<NamedElement> Classifier_InheritedMember(Classifier _this);
    
        /// <summary>
        /// This property is used when the Class is acting as a metaclass. It references the Extensions that specify additional properties of the metaclass. The property is derived from the Extensions whose memberEnds are typed by the Class.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Extension> Class_Extension(Class _this);
    
        /// <summary>
        /// The superclasses of a Class, derived from its Generalizations.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Class> Class_SuperClass(Class _this);
    
        /// <summary>
        /// The BehavioredClassifier that is the context for the execution of the Behavior. A Behavior that is directly owned as a nestedClassifier does not have a context. Otherwise, to determine the context of a Behavior, find the first BehavioredClassifier reached by following the chain of owner relationships from the Behavior, if any. If there is such a BehavioredClassifier, then it is the context, unless it is itself a Behavior with a non-empty context, in which case that is also the context for the original Behavior. For example, following this algorithm, the context of an entry Behavior in a StateMachine is the BehavioredClassifier that owns the StateMachine. The features of the context BehavioredClassifier as well as the Elements visible to the context Classifier are visible to the Behavior.
        /// </summary>
        public abstract BehavioredClassifier Behavior_Context(Behavior _this);
    
        /// <summary>
        /// The Classifiers that are used as types of the ends of the Association.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Type> Association_EndType(Association _this);
    
        /// <summary>
        /// The Interfaces that the Component exposes to its environment. These Interfaces may be Realized by the Component or any of its realizingClassifiers, or they may be the Interfaces that are provided by its public Ports.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Interface> Component_Provided(Component _this);
    
        /// <summary>
        /// The Interfaces that the Component requires from other Components in its environment in order to be able to offer its full set of provided functionality. These Interfaces may be used by the Component or any of its realizingClassifiers, or they may be the Interfaces that are required by its public Ports.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Interface> Component_Required(Component _this);
    
        /// <summary>
        /// A set of ConnectorEnds that attach to this ConnectableElement.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<ConnectorEnd> ConnectableElement_End(ConnectableElement _this);
    
        /// <summary>
        /// Indicates the kind of Connector. This is derived: a Connector with one or more ends connected to a Port which is not on a Part and which is not a behavior port is a delegation; otherwise it is an assembly.
        /// </summary>
        public abstract global::MetaDslx.Languages.Uml.Model.ConnectorKind Connector_Kind(Connector _this);
    
        /// <summary>
        /// A derived property referencing the corresponding end on the Association which types the Connector owing this ConnectorEnd, if any. It is derived by selecting the end at the same place in the ordering of Association ends as this ConnectorEnd.
        /// </summary>
        public abstract Property ConnectorEnd_DefiningEnd(ConnectorEnd _this);
    
        /// <summary>
        /// The set of elements that are manifested in an Artifact that is involved in Deployment to a DeploymentTarget.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<PackageableElement> DeploymentTarget_DeployedElement(DeploymentTarget _this);
    
        /// <summary>
        /// This redefinition changes the default multiplicity of association ends, since model elements are usually extended by 0 or 1 instance of the extension stereotype.
        /// </summary>
        public abstract int ExtensionEnd_Lower(ExtensionEnd _this);
    
        /// <summary>
        /// The Ports owned by the EncapsulatedClassifier.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Port> EncapsulatedClassifier_OwnedPort(EncapsulatedClassifier _this);
    
        /// <summary>
        /// The classifier of this EnumerationLiteral derived to be equal to its Enumeration.
        /// </summary>
        public abstract Enumeration EnumerationLiteral_Classifier(EnumerationLiteral _this);
    
        /// <summary>
        /// Indicates whether an instance of the extending stereotype must be created when an instance of the extended class is created. The attribute value is derived from the value of the lower property of the ExtensionEnd referenced by Extension::ownedEnd; a lower value of 1 means that isRequired is true, but otherwise it is false. Since the default value of ExtensionEnd::lower is 0, the default value of isRequired is false.
        /// </summary>
        public abstract bool Extension_IsRequired(Extension _this);
    
        /// <summary>
        /// References the Class that is extended through an Extension. The property is derived from the type of the memberEnd that is not the ownedEnd.
        /// </summary>
        public abstract Class Extension_Metaclass(Extension _this);
    
        /// <summary>
        /// The lower bound of the multiplicity interval.
        /// </summary>
        public abstract int MultiplicityElement_Lower(MultiplicityElement _this);
    
        /// <summary>
        /// The upper bound of the multiplicity interval.
        /// </summary>
        public abstract int MultiplicityElement_Upper(MultiplicityElement _this);
    
        /// <summary>
        /// References the PackageableElements that are members of this Namespace as a result of either PackageImports or ElementImports.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<PackageableElement> Namespace_ImportedMember(Namespace _this);
    
        /// <summary>
        /// If an OpaqueExpression is specified using a UML Behavior, then this refers to the single required return Parameter of that Behavior. When the Behavior completes execution, the values on this Parameter give the result of evaluating the OpaqueExpression.
        /// </summary>
        public abstract Parameter OpaqueExpression_Result(OpaqueExpression _this);
    
        /// <summary>
        /// References the packaged elements that are Packages.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Package> Package_NestedPackage(Package _this);
    
        /// <summary>
        /// References the Stereotypes that are owned by the Package.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Stereotype> Package_OwnedStereotype(Package _this);
    
        /// <summary>
        /// References the packaged elements that are Types.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Type> Package_OwnedType(Package _this);
    
        /// <summary>
        /// A String that represents a value to be used when no argument is supplied for the Parameter.
        /// </summary>
        public abstract string Parameter_Default(Parameter _this);
    
        /// <summary>
        /// Specifies whether the return parameter is ordered or not, if present.  This information is derived from the return result for this Operation.
        /// </summary>
        public abstract bool Operation_IsOrdered(Operation _this);
    
        /// <summary>
        /// Specifies whether the return parameter is unique or not, if present. This information is derived from the return result for this Operation.
        /// </summary>
        public abstract bool Operation_IsUnique(Operation _this);
    
        /// <summary>
        /// Specifies the lower multiplicity of the return parameter, if present. This information is derived from the return result for this Operation.
        /// </summary>
        public abstract int Operation_Lower(Operation _this);
    
        /// <summary>
        /// The return type of the operation, if present. This information is derived from the return result for this Operation.
        /// </summary>
        public abstract Type Operation_Type(Operation _this);
    
        /// <summary>
        /// The upper multiplicity of the return parameter, if present. This information is derived from the return result for this Operation.
        /// </summary>
        public abstract int Operation_Upper(Operation _this);
    
        /// <summary>
        /// If isComposite is true, the object containing the attribute is a container for the object or value contained in the attribute. This is a derived value, indicating whether the aggregation of the Property is composite or not.
        /// </summary>
        public abstract bool Property_IsComposite(Property _this);
    
        /// <summary>
        /// In the case where the Property is one end of a binary association this gives the other end.
        /// </summary>
        public abstract Property Property_Opposite(Property _this);
    
        /// <summary>
        /// The Interfaces specifying the set of Operations and Receptions that the EncapsulatedCclassifier offers to its environment via this Port, and which it will handle either directly or by forwarding it to a part of its internal structure. This association is derived according to the value of isConjugated. If isConjugated is false, provided is derived as the union of the sets of Interfaces realized by the type of the port and its supertypes, or directly from the type of the Port if the Port is typed by an Interface. If isConjugated is true, it is derived as the union of the sets of Interfaces used by the type of the Port and its supertypes.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Interface> Port_Provided(Port _this);
    
        /// <summary>
        /// The Interfaces specifying the set of Operations and Receptions that the EncapsulatedCassifier expects its environment to handle via this port. This association is derived according to the value of isConjugated. If isConjugated is false, required is derived as the union of the sets of Interfaces used by the type of the Port and its supertypes. If isConjugated is true, it is derived as the union of the sets of Interfaces realized by the type of the Port and its supertypes, or directly from the type of the Port if the Port is typed by an Interface.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Interface> Port_Required(Port _this);
    
        /// <summary>
        /// This association refers to the associated Operation. It is derived from the Operation of the CallEvent Trigger when applicable.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Operation> ProtocolTransition_Referred(ProtocolTransition _this);
    
        /// <summary>
        /// The formal template parameters of the extended signatures.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<TemplateParameter> RedefinableTemplateSignature_InheritedParameter(RedefinableTemplateSignature _this);
    
        /// <summary>
        /// References the Classifier in which context this element may be redefined.
        /// </summary>
        public abstract Classifier Region_RedefinitionContext(Region _this);
    
        /// <summary>
        /// A state with isComposite=true is said to be a composite State. A composite State is a State that contains at least one Region.
        /// </summary>
        public abstract bool State_IsComposite(State _this);
    
        /// <summary>
        /// A State with isOrthogonal=true is said to be an orthogonal composite State An orthogonal composite State contains two or more Regions.
        /// </summary>
        public abstract bool State_IsOrthogonal(State _this);
    
        /// <summary>
        /// A State with isSimple=true is said to be a simple State A simple State does not have any Regions and it does not refer to any submachine StateMachine.
        /// </summary>
        public abstract bool State_IsSimple(State _this);
    
        /// <summary>
        /// A State with isSubmachineState=true is said to be a submachine State Such a State refers to another StateMachine(submachine).
        /// </summary>
        public abstract bool State_IsSubmachineState(State _this);
    
        /// <summary>
        /// The Properties specifying instances that the StructuredClassifier owns by composition. This collection is derived, selecting those owned Properties where isComposite is true.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Property> StructuredClassifier_Part(StructuredClassifier _this);
    
        /// <summary>
        /// The profile that directly or indirectly contains this stereotype.
        /// </summary>
        public abstract Profile Stereotype_Profile(Stereotype _this);
    
        /// <summary>
        /// References the Classifier in which context this element may be redefined.
        /// </summary>
        public abstract Classifier Transition_RedefinitionContext(Transition _this);
    
        /// <summary>
        /// Specifies the Transitions entering this Vertex.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Transition> Vertex_Incoming(Vertex _this);
    
        /// <summary>
        /// Specifies the Transitions departing from this Vertex.
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Transition> Vertex_Outgoing(Vertex _this);
    
        /// <summary>
        /// References the Classifier in which context this element may be redefined.
        /// </summary>
        public abstract Classifier Vertex_RedefinitionContext(Vertex _this);
    
    
        /// <summary>
        /// The query allOwnedElements() gives all of the direct and indirect ownedElements of an Element.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Element> Element_AllOwnedElements(Element _this);
    
        /// <summary>
        /// The query mustBeOwned() indicates whether Elements of this type must have an owner. Subclasses of Element that do not require an owner must override this operation.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool Element_MustBeOwned(Element _this);
    
        /// <summary>
        /// The query allNamespaces() gives the sequence of Namespaces in which the NamedElement is nested, working outwards.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Namespace> NamedElement_AllNamespaces(NamedElement _this);
    
        /// <summary>
        /// The query allOwningPackages() returns the set of all the enclosing Namespaces of this NamedElement, working outwards, that are Packages, up to but not including the first such Namespace that is not a Package.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Package> NamedElement_AllOwningPackages(NamedElement _this);
    
        /// <summary>
        /// The query isDistinguishableFrom() determines whether two NamedElements may logically co-exist within a Namespace. By default, two named elements are distinguishable if (a) they have types neither of which is a kind of the other or (b) they have different names.
        /// </summary>
        /// <param name="n">
        /// </param>
        /// <param name="ns">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool NamedElement_IsDistinguishableFrom(NamedElement _this, NamedElement n, Namespace ns);
    
        /// <summary>
        /// The query separator() gives the string that is used to separate names when constructing a qualifiedName.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract string NamedElement_Separator(NamedElement _this);
    
        /// <summary>
        /// Return this Action and all Actions contained directly or indirectly in it. By default only the Action itself is returned, but the operation is overridden for StructuredActivityNodes.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Action> Action_AllActions(Action _this);
    
        /// <summary>
        /// Returns all the ActivityNodes directly or indirectly owned by this Action. This includes at least all the Pins of the Action.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<ActivityNode> Action_AllOwnedNodes(Action _this);
    
        /// <returns>
        /// </returns>
        public abstract Behavior Action_ContainingBehavior(Action _this);
    
        /// <summary>
        /// The query allFeatures() gives all of the Features in the namespace of the Classifier. In general, through mechanisms such as inheritance, this will be a larger set than feature.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Feature> Classifier_AllFeatures(Classifier _this);
    
        /// <summary>
        /// The query allParents() gives all of the direct and indirect ancestors of a generalized Classifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Classifier> Classifier_AllParents(Classifier _this);
    
        /// <summary>
        /// The query conformsTo() gives true for a Classifier that defines a type that conforms to another. This is used, for example, in the specification of signature conformance for operations.
        /// </summary>
        /// <param name="other">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Classifier_ConformsTo(Classifier _this, Type other);
    
        /// <summary>
        /// The query hasVisibilityOf() determines whether a NamedElement is visible in the classifier. Non-private members are visible. It is only called when the argument is something owned by a parent.
        /// </summary>
        /// <param name="n">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Classifier_HasVisibilityOf(Classifier _this, NamedElement n);
    
        /// <summary>
        /// The query inherit() defines how to inherit a set of elements passed as its argument.  It excludes redefined elements from the result.
        /// </summary>
        /// <param name="inhs">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<NamedElement> Classifier_Inherit(Classifier _this, global::System.Collections.Generic.IList<NamedElement> inhs);
    
        /// <summary>
        /// The query inheritableMembers() gives all of the members of a Classifier that may be inherited in one of its descendants, subject to whatever visibility restrictions apply.
        /// </summary>
        /// <param name="c">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<NamedElement> Classifier_InheritableMembers(Classifier _this, Classifier c);
    
        /// <summary>
        /// The query isTemplate() returns whether this Classifier is actually a template.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool Classifier_IsTemplate(Classifier _this);
    
        /// <summary>
        /// The query maySpecializeType() determines whether this classifier may have a generalization relationship to classifiers of the specified type. By default a classifier may specialize classifiers of the same or a more general type. It is intended to be redefined by classifiers that have different specialization constraints.
        /// </summary>
        /// <param name="c">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Classifier_MaySpecializeType(Classifier _this, Classifier c);
    
        /// <summary>
        /// The query parents() gives all of the immediate ancestors of a generalized Classifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Classifier> Classifier_Parents(Classifier _this);
    
        /// <summary>
        /// The Interfaces directly realized by this Classifier
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Interface> Classifier_DirectlyRealizedInterfaces(Classifier _this);
    
        /// <summary>
        /// The Interfaces directly used by this Classifier
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Interface> Classifier_DirectlyUsedInterfaces(Classifier _this);
    
        /// <summary>
        /// The Interfaces realized by this Classifier and all of its generalizations
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Interface> Classifier_AllRealizedInterfaces(Classifier _this);
    
        /// <summary>
        /// The Interfaces used by this Classifier and all of its generalizations
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Interface> Classifier_AllUsedInterfaces(Classifier _this);
    
        /// <param name="contract">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Classifier_IsSubstitutableFor(Classifier _this, Classifier contract);
    
        /// <summary>
        /// The query allAttributes gives an ordered set of all owned and inherited attributes of the Classifier. All owned attributes appear before any inherited attributes, and the attributes inherited from any more specific parent Classifier appear before those of any more general parent Classifier. However, if the Classifier has multiple immediate parents, then the relative ordering of the sets of attributes from those parents is not defined.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Property> Classifier_AllAttributes(Classifier _this);
    
        /// <summary>
        /// All StructuralFeatures related to the Classifier that may have Slots, including direct attributes, inherited attributes, private attributes in generalizations, and memberEnds of Associations, but excluding redefined StructuralFeatures.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<StructuralFeature> Classifier_AllSlottableFeatures(Classifier _this);
    
        /// <summary>
        /// The first BehavioredClassifier reached by following the chain of owner relationships from the Behavior, if any.
        /// </summary>
        /// <param name="from">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract BehavioredClassifier Behavior_BehavioredClassifier(Behavior _this, Element from);
    
        /// <summary>
        /// The in and inout ownedParameters of the Behavior.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Parameter> Behavior_InputParameters(Behavior _this);
    
        /// <summary>
        /// The out, inout and return ownedParameters.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Parameter> Behavior_OutputParameters(Behavior _this);
    
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool ActivityEdge_IsConsistentWith(ActivityEdge _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// The Activity that directly or indirectly contains this ActivityNode.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract Activity ActivityNode_ContainingActivity(ActivityNode _this);
    
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool ActivityNode_IsConsistentWith(ActivityNode _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// The Activity that directly or indirectly contains this ActivityGroup.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract Activity ActivityGroup_ContainingActivity(ActivityGroup _this);
    
        /// <summary>
        /// The query isDistinguishableFrom() determines whether two BehavioralFeatures may coexist in the same Namespace. It specifies that they must have different signatures.
        /// </summary>
        /// <param name="n">
        /// </param>
        /// <param name="ns">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool BehavioralFeature_IsDistinguishableFrom(BehavioralFeature _this, NamedElement n, Namespace ns);
    
        /// <summary>
        /// The ownedParameters with direction in and inout.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Parameter> BehavioralFeature_InputParameters(BehavioralFeature _this);
    
        /// <summary>
        /// The ownedParameters with direction out, inout, or return.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Parameter> BehavioralFeature_OutputParameters(BehavioralFeature _this);
    
        /// <summary>
        /// Return the in and inout ownedParameters of the Behavior or Operation being called. (This operation is abstract and should be overridden by subclasses of CallAction.)
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Parameter> CallAction_InputParameters(CallAction _this);
    
        /// <summary>
        /// Return the inout, out and return ownedParameters of the Behavior or Operation being called. (This operation is abstract and should be overridden by subclasses of CallAction.)
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Parameter> CallAction_OutputParameters(CallAction _this);
    
        /// <summary>
        /// Return the inout, out and return ownedParameters of the Behavior being called.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Parameter> CallBehaviorAction_OutputParameters(CallBehaviorAction _this);
    
        /// <summary>
        /// Return the in and inout ownedParameters of the Behavior being called.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Parameter> CallBehaviorAction_InputParameters(CallBehaviorAction _this);
    
        /// <summary>
        /// Return the inout, out and return ownedParameters of the Operation being called.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Parameter> CallOperationAction_OutputParameters(CallOperationAction _this);
    
        /// <summary>
        /// Return the in and inout ownedParameters of the Operation being called.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Parameter> CallOperationAction_InputParameters(CallOperationAction _this);
    
        /// <summary>
        /// Return only this ConditionalNode. This prevents Actions within the ConditionalNode from having their OutputPins used as bodyOutputs or decider Pins in containing LoopNodes or ConditionalNodes.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Action> ConditionalNode_AllActions(ConditionalNode _this);
    
        /// <summary>
        /// The query isConsistentWith() specifies a ConnectionPointReference can only be redefined by a ConnectionPointReference.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool ConnectionPointReference_IsConsistentWith(ConnectionPointReference _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// The query getName() returns the name under which the imported PackageableElement will be known in the importing namespace.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract string ElementImport_GetName(ElementImport _this);
    
        /// <summary>
        /// The query lowerBound() returns the lower bound of the multiplicity as an Integer. This is a redefinition of the default lower bound, which normally, for MultiplicityElements, evaluates to 1 if empty.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract int ExtensionEnd_LowerBound(ExtensionEnd _this);
    
        /// <summary>
        /// The query isConsistentWith() specifies a FinalState can only be redefined by a FinalState.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool FinalState_IsConsistentWith(FinalState _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// This query returns true if this Gate is attached to the boundary of a CombinedFragment, and its other end (if present)  is outside of the same CombinedFragment.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool Gate_IsOutsideCF(Gate _this);
    
        /// <summary>
        /// This query returns true if this Gate is attached to the boundary of a CombinedFragment, and its other end (if present) is inside of an InteractionOperator of the same CombinedFragment.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool Gate_IsInsideCF(Gate _this);
    
        /// <summary>
        /// This query returns true value if this Gate is an actualGate of an InteractionUse.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool Gate_IsActual(Gate _this);
    
        /// <summary>
        /// This query returns true if this Gate is a formalGate of an Interaction.
        /// </summary>
        /// <returns>
        /// </returns>
        /// <para>
        /// &lt;p&gt;interaction-&amp;gt;notEmpty()&lt;/p&gt;
        /// </para>
        public abstract bool Gate_IsFormal(Gate _this);
    
        /// <summary>
        /// This query returns the name of the gate, either the explicit name (.name) or the constructed name (&apos;out_&quot; or &apos;in_&apos; concatenated in front of .message.name) if the explicit name is not present.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract string Gate_GetName(Gate _this);
    
        /// <summary>
        /// This query returns true if the name of this Gate matches the name of the in parameter Gate, and the messages for the two Gates correspond. The Message for one Gate (say A) corresponds to the Message for another Gate (say B) if (A and B have the same name value) and (if A is a sendEvent then B is a receiveEvent) and (if A is a receiveEvent then B is a sendEvent) and (A and B have the same messageSort value) and (A and B have the same signature value).
        /// </summary>
        /// <param name="gateToMatch">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Gate_Matches(Gate _this, Gate gateToMatch);
    
        /// <summary>
        /// The query isDistinguishableFrom() specifies that two Gates may coexist in the same Namespace, without an explicit name property. The association end formalGate subsets ownedElement, and since the Gate name attribute
        /// is optional, it is allowed to have two formal gates without an explicit name, but having derived names which are distinct.
        /// </summary>
        /// <param name="n">
        /// </param>
        /// <param name="ns">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Gate_IsDistinguishableFrom(Gate _this, NamedElement n, Namespace ns);
    
        /// <summary>
        /// If the Gate is an inside Combined Fragment Gate, this operation returns the InteractionOperand that the opposite end of this Gate is included within.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract InteractionOperand Gate_GetOperand(Gate _this);
    
        /// <summary>
        /// The query isCompatibleWith() determines if this ParameterableElement is compatible with the specified ParameterableElement. By default, this ParameterableElement is compatible with another ParameterableElement p if the kind of this ParameterableElement is the same as or a subtype of the kind of p. Subclasses of ParameterableElement should override this operation to specify different compatibility constraints.
        /// </summary>
        /// <param name="p">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool ParameterableElement_IsCompatibleWith(ParameterableElement _this, ParameterableElement p);
    
        /// <summary>
        /// The query isTemplateParameter() determines if this ParameterableElement is exposed as a formal TemplateParameter.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool ParameterableElement_IsTemplateParameter(ParameterableElement _this);
    
        /// <summary>
        /// The query metaclassEnd() returns the Property that is typed by a metaclass (as opposed to a stereotype).
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract Property Extension_MetaclassEnd(Extension _this);
    
        /// <summary>
        /// The hasAllDataTypeAttributes query tests whether the types of the attributes of the given DataType are all DataTypes, and similarly for all those DataTypes.
        /// </summary>
        /// <param name="d">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool FunctionBehavior_HasAllDataTypeAttributes(FunctionBehavior _this, DataType d);
    
        /// <summary>
        /// Returns the Association acted on by this LinkAction.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract Association LinkAction_Association(LinkAction _this);
    
        /// <summary>
        /// Returns all the InputPins referenced by this LinkEndData. By default this includes the value and qualifier InputPins, but subclasses may override the operation to add other InputPins.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<InputPin> LinkEndData_AllPins(LinkEndData _this);
    
        /// <summary>
        /// Adds the insertAt InputPin (if any) to the set of all Pins.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<InputPin> LinkEndCreationData_AllPins(LinkEndCreationData _this);
    
        /// <summary>
        /// Adds the destroyAt InputPin (if any) to the set of all Pins.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<InputPin> LinkEndDestructionData_AllPins(LinkEndDestructionData _this);
    
        /// <summary>
        /// The query booleanValue() gives the value.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool LiteralBoolean_BooleanValue(LiteralBoolean _this);
    
        /// <summary>
        /// The query isComputable() is redefined to be true.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool LiteralBoolean_IsComputable(LiteralBoolean _this);
    
        /// <summary>
        /// The query integerValue() gives the value.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract int LiteralInteger_IntegerValue(LiteralInteger _this);
    
        /// <summary>
        /// The query isComputable() is redefined to be true.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool LiteralInteger_IsComputable(LiteralInteger _this);
    
        /// <summary>
        /// The query isComputable() is redefined to be true.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool LiteralNull_IsComputable(LiteralNull _this);
    
        /// <summary>
        /// The query isNull() returns true.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool LiteralNull_IsNull(LiteralNull _this);
    
        /// <summary>
        /// The query isComputable() is redefined to be true.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool LiteralReal_IsComputable(LiteralReal _this);
    
        /// <summary>
        /// The query realValue() gives the value.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract double LiteralReal_RealValue(LiteralReal _this);
    
        /// <summary>
        /// The query isComputable() is redefined to be true.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool LiteralString_IsComputable(LiteralString _this);
    
        /// <summary>
        /// The query stringValue() gives the value.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract string LiteralString_StringValue(LiteralString _this);
    
        /// <summary>
        /// The query isComputable() is redefined to be true.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool LiteralUnlimitedNatural_IsComputable(LiteralUnlimitedNatural _this);
    
        /// <summary>
        /// The query unlimitedValue() gives the value.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract int LiteralUnlimitedNatural_UnlimitedValue(LiteralUnlimitedNatural _this);
    
        /// <summary>
        /// Return only this LoopNode. This prevents Actions within the LoopNode from having their OutputPins used as bodyOutputs or decider Pins in containing LoopNodes or ConditionalNodes.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Action> LoopNode_AllActions(LoopNode _this);
    
        /// <summary>
        /// Return the loopVariable OutputPins in addition to other source nodes for the LoopNode as a StructuredActivityNode.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<ActivityNode> LoopNode_SourceNodes(LoopNode _this);
    
        /// <summary>
        /// The query isDistinguishableFrom() specifies that any two Messages may coexist in the same Namespace, regardless of their names.
        /// </summary>
        /// <param name="n">
        /// </param>
        /// <param name="ns">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Message_IsDistinguishableFrom(Message _this, NamedElement n, Namespace ns);
    
        /// <summary>
        /// This query returns a set including the MessageEnd (if exists) at the opposite end of the Message for this MessageEnd.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<MessageEnd> MessageEnd_OppositeEnd(MessageEnd _this);
    
        /// <summary>
        /// This query returns value true if this MessageEnd is a sendEvent.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool MessageEnd_IsSend(MessageEnd _this);
    
        /// <summary>
        /// This query returns value true if this MessageEnd is a receiveEvent.
        /// </summary>
        /// <returns>
        /// </returns>
        /// <para>
        /// &lt;p&gt;message-&amp;gt;notEmpty()&lt;/p&gt;
        /// </para>
        public abstract bool MessageEnd_IsReceive(MessageEnd _this);
    
        /// <summary>
        /// This query returns a set including the enclosing InteractionFragment this MessageEnd is enclosed within.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<InteractionFragment> MessageEnd_EnclosingFragment(MessageEnd _this);
    
        /// <summary>
        /// The operation compatibleWith takes another multiplicity as input. It returns true if the other multiplicity is wider than, or the same as, self.
        /// </summary>
        /// <param name="other">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool MultiplicityElement_CompatibleWith(MultiplicityElement _this, MultiplicityElement other);
    
        /// <summary>
        /// The query includesMultiplicity() checks whether this multiplicity includes all the cardinalities allowed by the specified multiplicity.
        /// </summary>
        /// <param name="M">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool MultiplicityElement_IncludesMultiplicity(MultiplicityElement _this, MultiplicityElement M);
    
        /// <summary>
        /// The operation is determines if the upper and lower bound of the ranges are the ones given.
        /// </summary>
        /// <param name="lowerbound">
        /// </param>
        /// <param name="upperbound">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool MultiplicityElement_Is(MultiplicityElement _this, int lowerbound, int upperbound);
    
        /// <summary>
        /// The query isMultivalued() checks whether this multiplicity has an upper bound greater than one.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool MultiplicityElement_IsMultivalued(MultiplicityElement _this);
    
        /// <summary>
        /// The query lowerBound() returns the lower bound of the multiplicity as an integer, which is the integerValue of lowerValue, if this is given, and 1 otherwise.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract int MultiplicityElement_LowerBound(MultiplicityElement _this);
    
        /// <summary>
        /// The query upperBound() returns the upper bound of the multiplicity for a bounded multiplicity as an unlimited natural, which is the unlimitedNaturalValue of upperValue, if given, and 1, otherwise.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract int MultiplicityElement_UpperBound(MultiplicityElement _this);
    
        /// <summary>
        /// The query excludeCollisions() excludes from a set of PackageableElements any that would not be distinguishable from each other in this Namespace.
        /// </summary>
        /// <param name="imps">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<PackageableElement> Namespace_ExcludeCollisions(Namespace _this, global::System.Collections.Generic.IList<PackageableElement> imps);
    
        /// <summary>
        /// The query getNamesOfMember() gives a set of all of the names that a member would have in a Namespace, taking importing into account. In general a member can have multiple names in a Namespace if it is imported more than once with different aliases.
        /// </summary>
        /// <param name="element">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<string> Namespace_GetNamesOfMember(Namespace _this, NamedElement element);
    
        /// <summary>
        /// The query importMembers() defines which of a set of PackageableElements are actually imported into the Namespace. This excludes hidden ones, i.e., those which have names that conflict with names of ownedMembers, and it also excludes PackageableElements that would have the indistinguishable names when imported.
        /// </summary>
        /// <param name="imps">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<PackageableElement> Namespace_ImportMembers(Namespace _this, global::System.Collections.Generic.IList<PackageableElement> imps);
    
        /// <summary>
        /// The Boolean query membersAreDistinguishable() determines whether all of the Namespace&apos;s members are distinguishable within it.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool Namespace_MembersAreDistinguishable(Namespace _this);
    
        /// <summary>
        /// The query isIntegral() tells whether an expression is intended to produce an Integer.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool OpaqueExpression_IsIntegral(OpaqueExpression _this);
    
        /// <summary>
        /// The query isNonNegative() tells whether an integer expression has a non-negative value.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool OpaqueExpression_IsNonNegative(OpaqueExpression _this);
    
        /// <summary>
        /// The query isPositive() tells whether an integer expression has a positive value.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool OpaqueExpression_IsPositive(OpaqueExpression _this);
    
        /// <summary>
        /// The query value() gives an integer value for an expression intended to produce one.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract int OpaqueExpression_Value(OpaqueExpression _this);
    
        /// <summary>
        /// The query allApplicableStereotypes() returns all the directly or indirectly owned stereotypes, including stereotypes contained in sub-profiles.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Stereotype> Package_AllApplicableStereotypes(Package _this);
    
        /// <summary>
        /// The query containingProfile() returns the closest profile directly or indirectly containing this package (or this package itself, if it is a profile).
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract Profile Package_ContainingProfile(Package _this);
    
        /// <summary>
        /// The query makesVisible() defines whether a Package makes an element visible outside itself. Elements with no visibility and elements with public visibility are made visible.
        /// </summary>
        /// <param name="el">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Package_MakesVisible(Package _this, NamedElement el);
    
        /// <summary>
        /// The query mustBeOwned() indicates whether elements of this type must have an owner.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool Package_MustBeOwned(Package _this);
    
        /// <summary>
        /// The query visibleMembers() defines which members of a Package can be accessed outside it.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<PackageableElement> Package_VisibleMembers(Package _this);
    
        /// <summary>
        /// The query isConsistentWith() specifies, for any two RedefinableElements in a context in which redefinition is possible, whether redefinition would be logically consistent. By default, this is false; this operation must be overridden for subclasses of RedefinableElement to define the consistency conditions.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool RedefinableElement_IsConsistentWith(RedefinableElement _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// The query isRedefinitionContextValid() specifies whether the redefinition contexts of this RedefinableElement are properly related to the redefinition contexts of the specified RedefinableElement to allow this element to redefine the other. By default at least one of the redefinition contexts of this element must be a specialization of at least one of the redefinition contexts of the specified element.
        /// </summary>
        /// <param name="redefinedElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool RedefinableElement_IsRedefinitionContextValid(RedefinableElement _this, RedefinableElement redefinedElement);
    
        /// <summary>
        /// The query isConsistentWith() specifies, for any two Operations in a context in which redefinition is possible, whether redefinition would be consistent. A redefining operation is consistent with a redefined operation if
        /// it has the same number of owned parameters, and for each parameter the following holds:
        ///
        /// - Direction, ordering and uniqueness are the same.
        /// - The corresponding types are covariant, contravariant or invariant.
        /// - The multiplicities are compatible, depending on the parameter direction.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Operation_IsConsistentWith(Operation _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// The query returnResult() returns the set containing the return parameter of the Operation if one exists, otherwise, it returns an empty set
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Parameter> Operation_ReturnResult(Operation _this);
    
        /// <summary>
        /// The query isAttribute() is true if the Property is defined as an attribute of some Classifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool Property_IsAttribute(Property _this);
    
        /// <summary>
        /// The query isCompatibleWith() determines if this Property is compatible with the specified ParameterableElement. This Property is compatible with ParameterableElement p if the kind of this Property is thesame as or a subtype of the kind of p. Further, if p is a TypedElement, then the type of this Property must be conformant with the type of p.
        /// </summary>
        /// <param name="p">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Property_IsCompatibleWith(Property _this, ParameterableElement p);
    
        /// <summary>
        /// The query isConsistentWith() specifies, for any two Properties in a context in which redefinition is possible, whether redefinition would be logically consistent. A redefining Property is consistent with a redefined Property if the type of the redefining Property conforms to the type of the redefined Property, and the multiplicity of the redefining Property (if specified) is contained in the multiplicity of the redefined Property.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Property_IsConsistentWith(Property _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// The query isNavigable() indicates whether it is possible to navigate across the property.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool Property_IsNavigable(Property _this);
    
        /// <summary>
        /// The query subsettingContext() gives the context for subsetting a Property. It consists, in the case of an attribute, of the corresponding Classifier, and in the case of an association end, all of the Classifiers at the other ends.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Type> Property_SubsettingContext(Property _this);
    
        /// <summary>
        /// The union of the sets of Interfaces realized by the type of the Port and its supertypes, or directly the type of the Port if the Port is typed by an Interface.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Interface> Port_BasicProvided(Port _this);
    
        /// <summary>
        /// The union of the sets of Interfaces used by the type of the Port and its supertypes.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Interface> Port_BasicRequired(Port _this);
    
        /// <summary>
        /// The query isConsistentWith() specifies a Pseudostate can only be redefined by a Pseudostate of the same kind.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Pseudostate_IsConsistentWith(Pseudostate _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Returns the ends corresponding to endData with no value InputPin. (A well-formed ReadLinkAction is constrained to have only one of these.)
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Property> ReadLinkAction_OpenEnd(ReadLinkAction _this);
    
        /// <summary>
        /// The query isConsistentWith() specifies, for any two RedefinableTemplateSignatures in a context in which redefinition is possible, whether redefinition would be logically consistent. A redefining template signature is always consistent with a redefined template signature, as redefinition only adds new formal parameters.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool RedefinableTemplateSignature_IsConsistentWith(RedefinableTemplateSignature _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// The operation belongsToPSM () checks if the Region belongs to a ProtocolStateMachine.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool Region_BelongsToPSM(Region _this);
    
        /// <summary>
        /// The operation containingStateMachine() returns the StateMachine in which this Region is defined.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract StateMachine Region_ContainingStateMachine(Region _this);
    
        /// <summary>
        /// The query isConsistentWith specifies that a Region can be redefined by any Region for which the redefinition context is valid (see the isRedefinitionContextValid operation). Note that consistency requirements for the redefinition of Vertices and Transitions within a redefining Region are specified by the isConsistentWith and isRedefinitionContextValid operations for Vertex (and its subclasses) and Transition.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Region_IsConsistentWith(Region _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// The query isRedefinitionContextValid() specifies whether the redefinition contexts of a Region are properly related to the redefinition contexts of the specified Region to allow this element to redefine the other. The containing StateMachine or State of a redefining Region must Redefine the containing StateMachine or State of the redefined Region.
        /// </summary>
        /// <param name="redefinedElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Region_IsRedefinitionContextValid(Region _this, RedefinableElement redefinedElement);
    
        /// <summary>
        /// Return the inout, out and return ownedParameters of the Behavior being called.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Parameter> StartObjectBehaviorAction_OutputParameters(StartObjectBehaviorAction _this);
    
        /// <summary>
        /// Return the in and inout ownedParameters of the Behavior being called.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Parameter> StartObjectBehaviorAction_InputParameters(StartObjectBehaviorAction _this);
    
        /// <summary>
        /// If the type of the object InputPin is a Behavior, then that Behavior. Otherwise, if the type of the object InputPin is a BehavioredClassifier, then the classifierBehavior of that BehavioredClassifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract Behavior StartObjectBehaviorAction_Behavior(StartObjectBehaviorAction _this);
    
        /// <summary>
        /// The query isTemplate() returns whether this TemplateableElement is actually a template.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool TemplateableElement_IsTemplate(TemplateableElement _this);
    
        /// <summary>
        /// The query parameterableElements() returns the set of ParameterableElements that may be used as the parameteredElements for a TemplateParameter of this TemplateableElement. By default, this set includes all the ownedElements. Subclasses may override this operation if they choose to restrict the set of ParameterableElements.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<ParameterableElement> TemplateableElement_ParameterableElements(TemplateableElement _this);
    
        /// <summary>
        /// The query containingStateMachine() returns the StateMachine that contains the State either directly or transitively.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract StateMachine State_ContainingStateMachine(State _this);
    
        /// <summary>
        /// The query isConsistentWith specifies that a non-final State can only be redefined by a non-final State (this is overridden by FinalState to allow a FinalState to be redefined by a FinalState) and, if the redefined State is a submachine State, then the redefining State must be a submachine state whose submachine is a redefinition of the submachine of the redefined State. Note that consistency requirements for the redefinition of Regions and connectionPoint Pseudostates within a composite State and connection ConnectionPoints of a submachine State are specified by the isConsistentWith and isRedefinitionContextValid operations for Region and Vertex (and its subclasses, Pseudostate and ConnectionPointReference).
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool State_IsConsistentWith(State _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// All features of type ConnectableElement, equivalent to all direct and inherited roles.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<ConnectableElement> StructuredClassifier_AllRoles(StructuredClassifier _this);
    
        /// <summary>
        /// The operation LCA(s1,s2) returns the Region that is the least common ancestor of Vertices s1 and s2, based on the StateMachine containment hierarchy.
        /// </summary>
        /// <param name="s1">
        /// </param>
        /// <param name="s2">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract Region StateMachine_LCA(StateMachine _this, Vertex s1, Vertex s2);
    
        /// <summary>
        /// The query ancestor(s1, s2) checks whether Vertex s2 is an ancestor of Vertex s1.
        /// </summary>
        /// <param name="s1">
        /// </param>
        /// <param name="s2">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool StateMachine_Ancestor(StateMachine _this, Vertex s1, Vertex s2);
    
        /// <summary>
        /// The query isConsistentWith specifies that a StateMachine can be redefined by any other StateMachine for which the redefinition context is valid (see the isRedefinitionContextValid operation). Note that consistency requirements for the redefinition of Regions and connectionPoint Pseudostates owned by a StateMachine are specified by the isConsistentWith and isRedefinitionContextValid operations for Region and Vertex (and its subclass Pseudostate).
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool StateMachine_IsConsistentWith(StateMachine _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// The query isRedefinitionContextValid specifies whether the redefinition context of a StateMachine is properly related to the redefinition contexts of a StateMachine it redefines. The requirement is that the context BehavioredClassifier of a redefining StateMachine must specialize the context Classifier of the redefined StateMachine. If the redefining StateMachine does not have a context BehavioredClassifier, then then the redefining StateMachine also must not have a context BehavioredClassifier but must, instead, specialize the redefining StateMachine.
        /// </summary>
        /// <param name="redefinedElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool StateMachine_IsRedefinitionContextValid(StateMachine _this, RedefinableElement redefinedElement);
    
        /// <summary>
        /// This utility funciton is like the LCA, except that it returns the nearest composite State that contains both input Vertices.
        /// </summary>
        /// <param name="v1">
        /// </param>
        /// <param name="v2">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract State StateMachine_LCAState(StateMachine _this, Vertex v1, Vertex v2);
    
        /// <summary>
        /// The query containingProfile returns the closest profile directly or indirectly containing this stereotype.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract Profile Stereotype_ContainingProfile(Stereotype _this);
    
        /// <summary>
        /// The query stringValue() returns the String resulting from concatenating, in order, all the component String values of all the operands or subExpressions that are part of the StringExpression.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract string StringExpression_StringValue(StringExpression _this);
    
        /// <summary>
        /// Returns this StructuredActivityNode and all Actions contained in it.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<Action> StructuredActivityNode_AllActions(StructuredActivityNode _this);
    
        /// <summary>
        /// Returns all the ActivityNodes contained directly or indirectly within this StructuredActivityNode, in addition to the Pins of the StructuredActivityNode.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode_AllOwnedNodes(StructuredActivityNode _this);
    
        /// <summary>
        /// Return those ActivityNodes contained immediately within the StructuredActivityNode that may act as sources of edges owned by the StructuredActivityNode.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode_SourceNodes(StructuredActivityNode _this);
    
        /// <summary>
        /// Return those ActivityNodes contained immediately within the StructuredActivityNode that may act as targets of edges owned by the StructuredActivityNode.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode_TargetNodes(StructuredActivityNode _this);
    
        /// <summary>
        /// The Activity that directly or indirectly contains this StructuredActivityNode (considered as an Action).
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract Activity StructuredActivityNode_ContainingActivity(StructuredActivityNode _this);
    
        /// <summary>
        /// The query containingStateMachine() returns the StateMachine that contains the Transition either directly or transitively.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract StateMachine Transition_ContainingStateMachine(Transition _this);
    
        /// <summary>
        /// The query isConsistentWith specifies that a redefining Transition is consistent with a redefined Transition provided that the source Vertex of the redefining Transition redefines the source Vertex of the redefined Transition.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Transition_IsConsistentWith(Transition _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// The query conformsTo() gives true for a Type that conforms to another. By default, two Types do not conform to each other. This query is intended to be redefined for specific conformance situations.
        /// </summary>
        /// <param name="other">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Type_ConformsTo(Type _this, Type other);
    
        /// <summary>
        /// The query allIncludedUseCases() returns the transitive closure of all UseCases (directly or indirectly) included by this UseCase.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract global::System.Collections.Generic.IList<UseCase> UseCase_AllIncludedUseCases(UseCase _this);
    
        /// <summary>
        /// The query booleanValue() gives a single Boolean value when one can be computed.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool ValueSpecification_BooleanValue(ValueSpecification _this);
    
        /// <summary>
        /// The query integerValue() gives a single Integer value when one can be computed.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract int ValueSpecification_IntegerValue(ValueSpecification _this);
    
        /// <summary>
        /// The query isCompatibleWith() determines if this ValueSpecification is compatible with the specified ParameterableElement. This ValueSpecification is compatible with ParameterableElement p if the kind of this ValueSpecification is the same as or a subtype of the kind of p. Further, if p is a TypedElement, then the type of this ValueSpecification must be conformant with the type of p.
        /// </summary>
        /// <param name="p">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool ValueSpecification_IsCompatibleWith(ValueSpecification _this, ParameterableElement p);
    
        /// <summary>
        /// The query isComputable() determines whether a value specification can be computed in a model. This operation cannot be fully defined in OCL. A conforming implementation is expected to deliver true for this operation for all ValueSpecifications that it can compute, and to compute all of those for which the operation is true. A conforming implementation is expected to be able to compute at least the value of all LiteralSpecifications.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool ValueSpecification_IsComputable(ValueSpecification _this);
    
        /// <summary>
        /// The query isNull() returns true when it can be computed that the value is null.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract bool ValueSpecification_IsNull(ValueSpecification _this);
    
        /// <summary>
        /// The query realValue() gives a single Real value when one can be computed.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract double ValueSpecification_RealValue(ValueSpecification _this);
    
        /// <summary>
        /// The query stringValue() gives a single String value when one can be computed.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract string ValueSpecification_StringValue(ValueSpecification _this);
    
        /// <summary>
        /// The query unlimitedValue() gives a single UnlimitedNatural value when one can be computed.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract int ValueSpecification_UnlimitedValue(ValueSpecification _this);
    
        /// <summary>
        /// A Variable is accessible by Actions within its scope (the Activity or StructuredActivityNode that owns it).
        /// </summary>
        /// <param name="a">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Variable_IsAccessibleBy(Variable _this, Action a);
    
        /// <summary>
        /// The operation containingStateMachine() returns the StateMachine in which this Vertex is defined.
        /// </summary>
        /// <returns>
        /// </returns>
        public abstract StateMachine Vertex_ContainingStateMachine(Vertex _this);
    
        /// <summary>
        /// This utility operation returns true if the Vertex is contained in the State s (input argument).
        /// </summary>
        /// <param name="s">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Vertex_IsContainedInState(Vertex _this, State s);
    
        /// <summary>
        /// This utility query returns true if the Vertex is contained in the Region r (input argument).
        /// </summary>
        /// <param name="r">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Vertex_IsContainedInRegion(Vertex _this, Region r);
    
        /// <summary>
        /// The query isRedefinitionContextValid specifies that the redefinition context of a redefining Vertex is properly related to the redefinition context of the redefined Vertex if the owner of the redefining Vertex is a redefinition of the owner of the redefined Vertex. Note that the owner of a Vertex may be a Region, a StateMachine (for a connectionPoint Pseudostate), or a State (for a connectionPoint Pseudostate or a connection ConnectionPointReference), all of which are RedefinableElements.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        public abstract bool Vertex_IsConsistentWith(Vertex _this, RedefinableElement redefiningElement);
    
    }
}
