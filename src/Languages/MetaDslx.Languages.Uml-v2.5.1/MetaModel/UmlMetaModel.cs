using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace MetaDslx.Languages.Uml.MetaModel
{
    [MetaModel(Uri="http://www.omg.org/spec/UML/", Prefix="uml")]
	public partial interface UmlMetaModel
	{
	}


    /// <summary>
    /// ObjectNodeOrderingKind is an enumeration indicating queuing order for offering the tokens held by an ObjectNode.
    /// </summary>
    public enum ObjectNodeOrderingKind
    {
        /// <summary>
        /// Indicates that tokens are unordered.
        /// </summary>
        Unordered,
        /// <summary>
        /// Indicates that tokens are ordered.
        /// </summary>
        Ordered,
        /// <summary>
        /// Indicates that tokens are queued in a last in, first out manner.
        /// </summary>
        LIFO,
        /// <summary>
        /// Indicates that tokens are queued in a first in, first out manner.
        /// </summary>
        FIFO
    }
    

    /// <summary>
    /// ConnectorKind is an enumeration that defines whether a Connector is an assembly or a delegation.
    /// </summary>
    public enum ConnectorKind
    {
        /// <summary>
        /// Indicates that the Connector is an assembly Connector.
        /// </summary>
        Assembly,
        /// <summary>
        /// Indicates that the Connector is a delegation Connector.
        /// </summary>
        Delegation
    }
    

    /// <summary>
    /// PseudostateKind is an Enumeration type that is used to differentiate various kinds of Pseudostates.
    /// </summary>
    public enum PseudostateKind
    {
        Initial,
        DeepHistory,
        ShallowHistory,
        Join,
        Fork,
        Junction,
        Choice,
        EntryPoint,
        ExitPoint,
        Terminate
    }
    

    /// <summary>
    /// TransitionKind is an Enumeration type used to differentiate the various kinds of Transitions.
    /// </summary>
    public enum TransitionKind
    {
        /// <summary>
        /// Implies that the Transition, if triggered, occurs without exiting or entering the source State (i.e., it does not cause a state change). This means that the entry or exit condition of the source State will not be invoked. An internal Transition can be taken even if the SateMachine is in one or more Regions nested within the associated State.
        /// </summary>
        Internal,
        /// <summary>
        /// Implies that the Transition, if triggered, will not exit the composite (source) State, but it will exit and re-enter any state within the composite State that is in the current state configuration.
        /// </summary>
        Local,
        /// <summary>
        /// Implies that the Transition, if triggered, will exit the composite (source) State.
        /// </summary>
        External
    }
    

    /// <summary>
    /// InteractionOperatorKind is an enumeration designating the different kinds of operators of CombinedFragments. The InteractionOperand defines the type of operator of a CombinedFragment.
    /// </summary>
    public enum InteractionOperatorKind
    {
        /// <summary>
        /// The InteractionOperatorKind seq designates that the CombinedFragment represents a weak sequencing between the behaviors of the operands.
        /// </summary>
        Seq,
        /// <summary>
        /// The InteractionOperatorKind alt designates that the CombinedFragment represents a choice of behavior. At most one of the operands will be chosen. The chosen operand must have an explicit or implicit guard expression that evaluates to true at this point in the interaction. An implicit true guard is implied if the operand has no guard.
        /// </summary>
        Alt,
        /// <summary>
        /// The InteractionOperatorKind opt designates that the CombinedFragment represents a choice of behavior where either the (sole) operand happens or nothing happens. An option is semantically equivalent to an alternative CombinedFragment where there is one operand with non-empty content and the second operand is empty.
        /// </summary>
        Opt,
        /// <summary>
        /// The InteractionOperatorKind break designates that the CombinedFragment represents a breaking scenario in the sense that the operand is a scenario that is performed instead of the remainder of the enclosing InteractionFragment. A break operator with a guard is chosen when the guard is true and the rest of the enclosing Interaction Fragment is ignored. When the guard of the break operand is false, the break operand is ignored and the rest of the enclosing InteractionFragment is chosen. The choice between a break operand without a guard and the rest of the enclosing InteractionFragment is done non-deterministically.
        /// </summary>
        Break,
        /// <summary>
        /// The InteractionOperatorKind par designates that the CombinedFragment represents a parallel merge between the behaviors of the operands. The OccurrenceSpecifications of the different operands can be interleaved in any way as long as the ordering imposed by each operand as such is preserved.
        /// </summary>
        Par,
        /// <summary>
        /// The InteractionOperatorKind strict designates that the CombinedFragment represents a strict sequencing between the behaviors of the operands. The semantics of strict sequencing defines a strict ordering of the operands on the first level within the CombinedFragment with interactionOperator strict. Therefore OccurrenceSpecifications within contained CombinedFragment will not directly be compared with other OccurrenceSpecifications of the enclosing CombinedFragment.
        /// </summary>
        Strict,
        /// <summary>
        /// The InteractionOperatorKind loop designates that the CombinedFragment represents a loop. The loop operand will be repeated a number of times.
        /// </summary>
        Loop,
        /// <summary>
        /// The InteractionOperatorKind critical designates that the CombinedFragment represents a critical region. A critical region means that the traces of the region cannot be interleaved by other OccurrenceSpecifications (on those Lifelines covered by the region). This means that the region is treated atomically by the enclosing fragment when determining the set of valid traces. Even though enclosing CombinedFragments may imply that some OccurrenceSpecifications may interleave into the region, such as with par-operator, this is prevented by defining a region.
        /// </summary>
        Critical,
        /// <summary>
        /// The InteractionOperatorKind neg designates that the CombinedFragment represents traces that are defined to be invalid.
        /// </summary>
        Neg,
        /// <summary>
        /// The InteractionOperatorKind assert designates that the CombinedFragment represents an assertion. The sequences of the operand of the assertion are the only valid continuations. All other continuations result in an invalid trace.
        /// </summary>
        Assert,
        /// <summary>
        /// The InteractionOperatorKind ignore designates that there are some message types that are not shown within this combined fragment. These message types can be considered insignificant and are implicitly ignored if they appear in a corresponding execution. Alternatively, one can understand ignore to mean that the message types that are ignored can appear anywhere in the traces.
        /// </summary>
        Ignore,
        /// <summary>
        /// The InteractionOperatorKind consider designates which messages should be considered within this combined fragment. This is equivalent to defining every other message to be ignored.
        /// </summary>
        Consider
    }
    

    /// <summary>
    /// This is an enumerated type that identifies the type of Message.
    /// </summary>
    public enum MessageKind
    {
        /// <summary>
        /// sendEvent and receiveEvent are present
        /// </summary>
        Complete,
        /// <summary>
        /// sendEvent present and receiveEvent absent
        /// </summary>
        Lost,
        /// <summary>
        /// sendEvent absent and receiveEvent present
        /// </summary>
        Found,
        /// <summary>
        /// sendEvent and receiveEvent absent (should not appear)
        /// </summary>
        Unknown
    }
    

    /// <summary>
    /// This is an enumerated type that identifies the type of communication action that was used to generate the Message.
    /// </summary>
    public enum MessageSort
    {
        /// <summary>
        /// The message was generated by a synchronous call to an operation.
        /// </summary>
        SynchCall,
        /// <summary>
        /// The message was generated by an asynchronous call to an operation; i.e., a CallAction with isSynchronous = false.
        /// </summary>
        AsynchCall,
        /// <summary>
        /// The message was generated by an asynchronous send action.
        /// </summary>
        AsynchSignal,
        /// <summary>
        /// The message designating the creation of another lifeline object.
        /// </summary>
        CreateMessage,
        /// <summary>
        /// The message designating the termination of another lifeline.
        /// </summary>
        DeleteMessage,
        /// <summary>
        /// The message is a reply message to an operation call.
        /// </summary>
        Reply
    }
    

    /// <summary>
    /// VisibilityKind is an enumeration type that defines literals to determine the visibility of Elements in a model.
    /// </summary>
    public enum VisibilityKind
    {
        /// <summary>
        /// A Named Element with public visibility is visible to all elements that can access the contents of the Namespace that owns it.
        /// </summary>
        Public,
        /// <summary>
        /// A NamedElement with private visibility is only visible inside the Namespace that owns it.
        /// </summary>
        Private,
        /// <summary>
        /// A NamedElement with protected visibility is visible to Elements that have a generalization relationship to the Namespace that owns it.
        /// </summary>
        Protected,
        /// <summary>
        /// A NamedElement with package visibility is visible to all Elements within the nearest enclosing Package (given that other owning Elements have proper visibility). Outside the nearest enclosing Package, a NamedElement marked as having package visibility is not visible.  Only NamedElements that are not owned by Packages can be marked as having package visibility. 
        /// </summary>
        Package
    }
    

    /// <summary>
    /// AggregationKind is an Enumeration for specifying the kind of aggregation of a Property.
    /// </summary>
    public enum AggregationKind
    {
        /// <summary>
        /// Indicates that the Property has no aggregation.
        /// </summary>
        None,
        /// <summary>
        /// Indicates that the Property has shared aggregation.
        /// </summary>
        Shared,
        /// <summary>
        /// Indicates that the Property is aggregated compositely, i.e., the composite object has responsibility for the existence and storage of the composed objects (parts).
        /// </summary>
        Composite
    }
    

    /// <summary>
    /// CallConcurrencyKind is an Enumeration used to specify the semantics of concurrent calls to a BehavioralFeature.
    /// </summary>
    public enum CallConcurrencyKind
    {
        /// <summary>
        /// No concurrency management mechanism is associated with the BehavioralFeature and, therefore, concurrency conflicts may occur. Instances that invoke a BehavioralFeature need to coordinate so that only one invocation to a target on any BehavioralFeature occurs at once.
        /// </summary>
        Sequential,
        /// <summary>
        /// Multiple invocations of a BehavioralFeature that overlap in time may occur to one instance, but only one is allowed to commence. The others are blocked until the performance of the currently executing BehavioralFeature is complete. It is the responsibility of the system designer to ensure that deadlocks do not occur due to simultaneous blocking.
        /// </summary>
        Guarded,
        /// <summary>
        /// Multiple invocations of a BehavioralFeature that overlap in time may occur to one instance and all of them may proceed concurrently.
        /// </summary>
        Concurrent
    }
    

    /// <summary>
    /// ParameterDirectionKind is an Enumeration that defines literals used to specify direction of parameters.
    /// </summary>
    public enum ParameterDirectionKind
    {
        /// <summary>
        /// Indicates that Parameter values are passed in by the caller. 
        /// </summary>
        In,
        /// <summary>
        /// Indicates that Parameter values are passed in by the caller and (possibly different) values passed out to the caller.
        /// </summary>
        Inout,
        /// <summary>
        /// Indicates that Parameter values are passed out to the caller.
        /// </summary>
        Out,
        /// <summary>
        /// Indicates that Parameter values are passed as return values back to the caller.
        /// </summary>
        Return
    }
    

    /// <summary>
    /// ParameterEffectKind is an Enumeration that indicates the effect of a Behavior on values passed in or out of its parameters.
    /// </summary>
    public enum ParameterEffectKind
    {
        /// <summary>
        /// Indicates that the behavior creates values.
        /// </summary>
        Create,
        /// <summary>
        /// Indicates objects that are values of the parameter have values of their properties, or links in which they participate, or their classifiers retrieved during executions of the behavior.
        /// </summary>
        Read,
        /// <summary>
        /// Indicates objects that are values of the parameter have values of their properties, or links in which they participate, or their classification changed during executions of the behavior.
        /// </summary>
        Update,
        /// <summary>
        /// Indicates objects that are values of the parameter do not exist after executions of the behavior are finished.
        /// </summary>
        Delete
    }
    

    /// <summary>
    /// ExpansionKind is an enumeration type used to specify how an ExpansionRegion executes its contents.
    /// </summary>
    public enum ExpansionKind
    {
        /// <summary>
        /// The content of the ExpansionRegion is executed concurrently for the elements of the input collections.
        /// </summary>
        Parallel,
        /// <summary>
        /// The content of the ExpansionRegion is executed iteratively for the elements of the input collections, in the order of the input elements, if the collections are ordered.
        /// </summary>
        Iterative,
        /// <summary>
        /// A stream of input collection elements flows into a single execution of the content of the ExpansionRegion, in the order of the collection elements if the input collections are ordered.
        /// </summary>
        Stream
    }
    

    /// <summary>
    /// An Activity is the specification of parameterized Behavior as the coordinated sequencing of subordinate units.
    /// </summary>
    [MetaClass]
    public partial interface Activity : Behavior
    {
    	/// <summary>
    	/// ActivityEdges expressing flow between the nodes of the Activity.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ActivityEdge), "Activity")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ActivityEdge> Edge { get; }
    	
    	/// <summary>
    	/// Top-level ActivityGroups in the Activity.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ActivityGroup), "InActivity")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ActivityGroup> Group { get; }
    	
    	/// <summary>
    	/// If true, this Activity must not make any changes to objects. The default is false (an Activity may make nonlocal changes). (This is an assertion, not an executable property. It may be used by an execution engine to optimize model execution. If the assertion is violated by the Activity, then the model is ill-formed.) 
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsReadOnly { get; set; }
    	
    	/// <summary>
    	/// If true, all invocations of the Activity are handled by the same execution.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsSingleExecution { get; set; }
    	
    	/// <summary>
    	/// ActivityNodes coordinated by the Activity.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ActivityNode), "Activity")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ActivityNode> Node { get; }
    	
    	/// <summary>
    	/// Top-level ActivityPartitions in the Activity.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ActivityPartition), "Activity")]
    	[Subsets(typeof(Activity), "Group")]
    	IList<ActivityPartition> Partition { get; }
    	
    	/// <summary>
    	/// Top-level StructuredActivityNodes in the Activity.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(StructuredActivityNode), "Activity")]
    	[Subsets(typeof(Activity), "Group")]
    	[Subsets(typeof(Activity), "Node")]
    	IList<StructuredActivityNode> StructuredNode { get; }
    	
    	/// <summary>
    	/// Top-level Variables defined by the Activity.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Variable), "ActivityScope")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Variable> Variable { get; }
    	
    }
    

    /// <summary>
    /// An ActivityEdge is an abstract class for directed connections between two ActivityNodes.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface ActivityEdge : RedefinableElement
    {
    	/// <summary>
    	/// The Activity containing the ActivityEdge, if it is directly owned by an Activity.
    	/// </summary>
    	[Opposite(typeof(Activity), "Edge")]
    	[Subsets(typeof(Element), "Owner")]
    	Activity? Activity { get; set; }
    	
    	/// <summary>
    	/// A ValueSpecification that is evaluated to determine if a token can traverse the ActivityEdge. If an ActivityEdge has no guard, then there is no restriction on tokens traversing the edge.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "ActivityEdge")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? Guard { get; set; }
    	
    	/// <summary>
    	/// ActivityGroups containing the ActivityEdge.
    	/// </summary>
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(ActivityGroup), "ContainedEdge")]
    	IList<ActivityGroup> InGroup { get; }
    	
    	/// <summary>
    	/// ActivityPartitions containing the ActivityEdge.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ActivityPartition), "Edge")]
    	[Subsets(typeof(ActivityEdge), "InGroup")]
    	IList<ActivityPartition> InPartition { get; }
    	
    	/// <summary>
    	/// The StructuredActivityNode containing the ActivityEdge, if it is owned by a StructuredActivityNode.
    	/// </summary>
    	[Opposite(typeof(StructuredActivityNode), "Edge")]
    	[Subsets(typeof(ActivityEdge), "InGroup")]
    	[Subsets(typeof(Element), "Owner")]
    	StructuredActivityNode? InStructuredNode { get; set; }
    	
    	/// <summary>
    	/// The InterruptibleActivityRegion for which this ActivityEdge is an interruptingEdge.
    	/// </summary>
    	[Opposite(typeof(InterruptibleActivityRegion), "InterruptingEdge")]
    	InterruptibleActivityRegion? Interrupts { get; set; }
    	
    	/// <summary>
    	/// ActivityEdges from a generalization of the Activity containing this ActivityEdge that are redefined by this ActivityEdge.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ActivityEdge), "ActivityEdge")]
    	[Subsets(typeof(RedefinableElement), "RedefinedElement")]
    	IList<ActivityEdge> RedefinedEdge { get; }
    	
    	/// <summary>
    	/// The ActivityNode from which tokens are taken when they traverse the ActivityEdge.
    	/// </summary>
    	[Opposite(typeof(ActivityNode), "Outgoing")]
    	ActivityNode Source { get; set; }
    	
    	/// <summary>
    	/// The ActivityNode to which tokens are put when they traverse the ActivityEdge.
    	/// </summary>
    	[Opposite(typeof(ActivityNode), "Incoming")]
    	ActivityNode Target { get; set; }
    	
    	/// <summary>
    	/// The minimum number of tokens that must traverse the ActivityEdge at the same time. If no weight is specified, this is equivalent to specifying a constant value of 1.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "ActivityEdge")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? Weight { get; set; }
    	
    	bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    }
    

    /// <summary>
    /// An ActivityFinalNode is a FinalNode that terminates the execution of its owning Activity or StructuredActivityNode.
    /// </summary>
    [MetaClass]
    public partial interface ActivityFinalNode : FinalNode
    {
    }
    

    /// <summary>
    /// ActivityGroup is an abstract class for defining sets of ActivityNodes and ActivityEdges in an Activity.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface ActivityGroup : NamedElement
    {
    	/// <summary>
    	/// ActivityEdges immediately contained in the ActivityGroup.
    	/// </summary>
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(ActivityEdge), "InGroup")]
    	IList<ActivityEdge> ContainedEdge { get; }
    	
    	/// <summary>
    	/// ActivityNodes immediately contained in the ActivityGroup.
    	/// </summary>
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(ActivityNode), "InGroup")]
    	IList<ActivityNode> ContainedNode { get; }
    	
    	/// <summary>
    	/// The Activity containing the ActivityGroup, if it is directly owned by an Activity.
    	/// </summary>
    	[Opposite(typeof(Activity), "Group")]
    	[Subsets(typeof(Element), "Owner")]
    	Activity? InActivity { get; set; }
    	
    	/// <summary>
    	/// Other ActivityGroups immediately contained in this ActivityGroup.
    	/// </summary>
    	[Containment]
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(ActivityGroup), "SuperGroup")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ActivityGroup> Subgroup { get; }
    	
    	/// <summary>
    	/// The ActivityGroup immediately containing this ActivityGroup, if it is directly owned by another ActivityGroup.
    	/// </summary>
    	[DerivedUnion]
    	[ReadOnly]
    	[Opposite(typeof(ActivityGroup), "Subgroup")]
    	[Subsets(typeof(Element), "Owner")]
    	ActivityGroup? SuperGroup { get; }
    	
    }
    

    /// <summary>
    /// ActivityNode is an abstract class for points in the flow of an Activity connected by ActivityEdges.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface ActivityNode : RedefinableElement
    {
    	/// <summary>
    	/// The Activity containing the ActivityNode, if it is directly owned by an Activity.
    	/// </summary>
    	[Opposite(typeof(Activity), "Node")]
    	[Subsets(typeof(Element), "Owner")]
    	Activity? Activity { get; set; }
    	
    	/// <summary>
    	/// ActivityGroups containing the ActivityNode.
    	/// </summary>
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(ActivityGroup), "ContainedNode")]
    	IList<ActivityGroup> InGroup { get; }
    	
    	/// <summary>
    	/// InterruptibleActivityRegions containing the ActivityNode.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(InterruptibleActivityRegion), "Node")]
    	[Subsets(typeof(ActivityNode), "InGroup")]
    	IList<InterruptibleActivityRegion> InInterruptibleRegion { get; }
    	
    	/// <summary>
    	/// ActivityPartitions containing the ActivityNode.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ActivityPartition), "Node")]
    	[Subsets(typeof(ActivityNode), "InGroup")]
    	IList<ActivityPartition> InPartition { get; }
    	
    	/// <summary>
    	/// The StructuredActivityNode containing the ActvityNode, if it is directly owned by a StructuredActivityNode.
    	/// </summary>
    	[Opposite(typeof(StructuredActivityNode), "Node")]
    	[Subsets(typeof(ActivityNode), "InGroup")]
    	[Subsets(typeof(Element), "Owner")]
    	StructuredActivityNode? InStructuredNode { get; set; }
    	
    	/// <summary>
    	/// ActivityEdges that have the ActivityNode as their target.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ActivityEdge), "Target")]
    	IList<ActivityEdge> Incoming { get; }
    	
    	/// <summary>
    	/// ActivityEdges that have the ActivityNode as their source.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ActivityEdge), "Source")]
    	IList<ActivityEdge> Outgoing { get; }
    	
    	/// <summary>
    	/// ActivityNodes from a generalization of the Activity containining this ActivityNode that are redefined by this ActivityNode.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ActivityNode), "ActivityNode")]
    	[Subsets(typeof(RedefinableElement), "RedefinedElement")]
    	IList<ActivityNode> RedefinedNode { get; }
    	
    	bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    }
    

    /// <summary>
    /// An ActivityParameterNode is an ObjectNode for accepting values from the input Parameters or providing values to the output Parameters of an Activity.
    /// </summary>
    [MetaClass]
    public partial interface ActivityParameterNode : ObjectNode
    {
    	/// <summary>
    	/// The Parameter for which the ActivityParameterNode will be accepting or providing values.
    	/// </summary>
    	[Opposite(typeof(Parameter), "ActivityParameterNode")]
    	Parameter Parameter { get; set; }
    	
    }
    

    /// <summary>
    /// An ActivityPartition is a kind of ActivityGroup for identifying ActivityNodes that have some characteristic in common.
    /// </summary>
    [MetaClass]
    public partial interface ActivityPartition : ActivityGroup
    {
    	/// <summary>
    	/// ActivityEdges immediately contained in the ActivityPartition.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ActivityEdge), "InPartition")]
    	[Subsets(typeof(ActivityGroup), "ContainedEdge")]
    	IList<ActivityEdge> Edge { get; }
    	
    	/// <summary>
    	/// Indicates whether the ActivityPartition groups other ActivityPartitions along a dimension.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsDimension { get; set; }
    	
    	/// <summary>
    	/// Indicates whether the ActivityPartition represents an entity to which the partitioning structure does not apply.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsExternal { get; set; }
    	
    	/// <summary>
    	/// ActivityNodes immediately contained in the ActivityPartition.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ActivityNode), "InPartition")]
    	[Subsets(typeof(ActivityGroup), "ContainedNode")]
    	IList<ActivityNode> Node { get; }
    	
    	/// <summary>
    	/// An Element represented by the functionality modeled within the ActivityPartition.
    	/// </summary>
    	[Opposite(typeof(Element), "ActivityPartition")]
    	Element? Represents { get; set; }
    	
    	/// <summary>
    	/// Other ActivityPartitions immediately contained in this ActivityPartition (as its subgroups).
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ActivityPartition), "SuperPartition")]
    	[Subsets(typeof(ActivityGroup), "Subgroup")]
    	IList<ActivityPartition> Subpartition { get; }
    	
    	/// <summary>
    	/// Other ActivityPartitions immediately containing this ActivityPartition (as its superGroups).
    	/// </summary>
    	[Opposite(typeof(ActivityPartition), "Subpartition")]
    	[Subsets(typeof(ActivityGroup), "SuperGroup")]
    	ActivityPartition? SuperPartition { get; set; }
    	
    }
    

    /// <summary>
    /// A CentralBufferNode is an ObjectNode for managing flows from multiple sources and targets.
    /// </summary>
    [MetaClass]
    public partial interface CentralBufferNode : ObjectNode
    {
    }
    

    /// <summary>
    /// A ControlFlow is an ActivityEdge traversed by control tokens or object tokens of control type, which are use to control the execution of ExecutableNodes.
    /// </summary>
    [MetaClass]
    public partial interface ControlFlow : ActivityEdge
    {
    }
    

    /// <summary>
    /// A ControlNode is an abstract ActivityNode that coordinates flows in an Activity.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface ControlNode : ActivityNode
    {
    }
    

    /// <summary>
    /// A DataStoreNode is a CentralBufferNode for persistent data.
    /// </summary>
    [MetaClass]
    public partial interface DataStoreNode : CentralBufferNode
    {
    }
    

    /// <summary>
    /// A DecisionNode is a ControlNode that chooses between outgoing ActivityEdges for the routing of tokens.
    /// </summary>
    [MetaClass]
    public partial interface DecisionNode : ControlNode
    {
    	/// <summary>
    	/// A Behavior that is executed to provide an input to guard ValueSpecifications on ActivityEdges outgoing from the DecisionNode.
    	/// </summary>
    	[Opposite(typeof(Behavior), "DecisionNode")]
    	Behavior? DecisionInput { get; set; }
    	
    	/// <summary>
    	/// An additional ActivityEdge incoming to the DecisionNode that provides a decision input value for the guards ValueSpecifications on ActivityEdges outgoing from the DecisionNode.
    	/// </summary>
    	[Opposite(typeof(ObjectFlow), "DecisionNode")]
    	ObjectFlow? DecisionInputFlow { get; set; }
    	
    }
    

    /// <summary>
    /// An ExceptionHandler is an Element that specifies a handlerBody ExecutableNode to execute in case the specified exception occurs during the execution of the protected ExecutableNode.
    /// </summary>
    [MetaClass]
    public partial interface ExceptionHandler : Element
    {
    	/// <summary>
    	/// An ObjectNode within the handlerBody. When the ExceptionHandler catches an exception, the exception token is placed on this ObjectNode, causing the handlerBody to execute.
    	/// </summary>
    	[Opposite(typeof(ObjectNode), "ExceptionHandler")]
    	ObjectNode ExceptionInput { get; set; }
    	
    	/// <summary>
    	/// The Classifiers whose instances the ExceptionHandler catches as exceptions. If an exception occurs whose type is any exceptionType, the ExceptionHandler catches the exception and executes the handlerBody.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Classifier), "ExceptionHandler")]
    	IList<Classifier> ExceptionType { get; }
    	
    	/// <summary>
    	/// An ExecutableNode that is executed if the ExceptionHandler catches an exception.
    	/// </summary>
    	[Opposite(typeof(ExecutableNode), "ExceptionHandler")]
    	ExecutableNode HandlerBody { get; set; }
    	
    	/// <summary>
    	/// The ExecutableNode protected by the ExceptionHandler. If an exception propagates out of the protectedNode and has a type matching one of the exceptionTypes, then it is caught by this ExceptionHandler.
    	/// </summary>
    	[Opposite(typeof(ExecutableNode), "Handler")]
    	[Subsets(typeof(Element), "Owner")]
    	ExecutableNode ProtectedNode { get; set; }
    	
    }
    

    /// <summary>
    /// An ExecutableNode is an abstract class for ActivityNodes whose execution may be controlled using ControlFlows and to which ExceptionHandlers may be attached.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface ExecutableNode : ActivityNode
    {
    	/// <summary>
    	/// A set of ExceptionHandlers that are examined if an exception propagates out of the ExceptionNode.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ExceptionHandler), "ProtectedNode")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ExceptionHandler> Handler { get; }
    	
    }
    

    /// <summary>
    /// A FinalNode is an abstract ControlNode at which a flow in an Activity stops.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface FinalNode : ControlNode
    {
    }
    

    /// <summary>
    /// A FlowFinalNode is a FinalNode that terminates a flow by consuming the tokens offered to it.
    /// </summary>
    [MetaClass]
    public partial interface FlowFinalNode : FinalNode
    {
    }
    

    /// <summary>
    /// A ForkNode is a ControlNode that splits a flow into multiple concurrent flows.
    /// </summary>
    [MetaClass]
    public partial interface ForkNode : ControlNode
    {
    }
    

    /// <summary>
    /// An InitialNode is a ControlNode that offers a single control token when initially enabled.
    /// </summary>
    [MetaClass]
    public partial interface InitialNode : ControlNode
    {
    }
    

    /// <summary>
    /// An InterruptibleActivityRegion is an ActivityGroup that supports the termination of tokens flowing in the portions of an activity within it.
    /// </summary>
    [MetaClass]
    public partial interface InterruptibleActivityRegion : ActivityGroup
    {
    	/// <summary>
    	/// The ActivityEdges leaving the InterruptibleActivityRegion on which a traversing token will result in the termination of other tokens flowing in the InterruptibleActivityRegion.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ActivityEdge), "Interrupts")]
    	IList<ActivityEdge> InterruptingEdge { get; }
    	
    	/// <summary>
    	/// ActivityNodes immediately contained in the InterruptibleActivityRegion.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ActivityNode), "InInterruptibleRegion")]
    	[Subsets(typeof(ActivityGroup), "ContainedNode")]
    	IList<ActivityNode> Node { get; }
    	
    }
    

    /// <summary>
    /// A JoinNode is a ControlNode that synchronizes multiple flows.
    /// </summary>
    [MetaClass]
    public partial interface JoinNode : ControlNode
    {
    	/// <summary>
    	/// Indicates whether incoming tokens having objects with the same identity are combined into one by the JoinNode.
    	/// </summary>
    	[DefaultValue(true)]
    	bool IsCombineDuplicate { get; set; }
    	
    	/// <summary>
    	/// A ValueSpecification giving the condition under which the JoinNode will offer a token on its outgoing ActivityEdge. If no joinSpec is specified, then the JoinNode will offer an outgoing token if tokens are offered on all of its incoming ActivityEdges (an &quot;and&quot; condition).
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "JoinNode")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? JoinSpec { get; set; }
    	
    }
    

    /// <summary>
    /// A merge node is a control node that brings together multiple alternate flows. It is not used to synchronize concurrent flows but to accept one among several alternate flows.
    /// </summary>
    [MetaClass]
    public partial interface MergeNode : ControlNode
    {
    }
    

    /// <summary>
    /// An ObjectFlow is an ActivityEdge that is traversed by object tokens that may hold values. Object flows also support multicast/receive, token selection from object nodes, and transformation of tokens.
    /// </summary>
    [MetaClass]
    public partial interface ObjectFlow : ActivityEdge
    {
    	/// <summary>
    	/// Indicates whether the objects in the ObjectFlow are passed by multicasting.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsMulticast { get; set; }
    	
    	/// <summary>
    	/// Indicates whether the objects in the ObjectFlow are gathered from respondents to multicasting.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsMultireceive { get; set; }
    	
    	/// <summary>
    	/// A Behavior used to select tokens from a source ObjectNode.
    	/// </summary>
    	[Opposite(typeof(Behavior), "ObjectFlow")]
    	Behavior? Selection { get; set; }
    	
    	/// <summary>
    	/// A Behavior used to change or replace object tokens flowing along the ObjectFlow.
    	/// </summary>
    	[Opposite(typeof(Behavior), "ObjectFlow")]
    	Behavior? Transformation { get; set; }
    	
    }
    

    /// <summary>
    /// An ObjectNode is an abstract ActivityNode that may hold tokens within the object flow in an Activity. ObjectNodes also support token selection, limitation on the number of tokens held, specification of the state required for tokens being held, and carrying control values.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface ObjectNode : TypedElement, ActivityNode
    {
    	/// <summary>
    	/// The States required to be associated with the values held by tokens on this ObjectNode.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(State), "ObjectNode")]
    	IList<State> InState { get; }
    	
    	/// <summary>
    	/// Indicates whether the type of the ObjectNode is to be treated as representing control values that may traverse ControlFlows.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsControlType { get; set; }
    	
    	/// <summary>
    	/// Indicates how the tokens held by the ObjectNode are ordered for selection to traverse ActivityEdges outgoing from the ObjectNode.
    	/// </summary>
    	[DefaultValue(ObjectNodeOrderingKind.FIFO)]
    	ObjectNodeOrderingKind Ordering { get; set; }
    	
    	/// <summary>
    	/// A Behavior used to select tokens to be offered on outgoing ActivityEdges.
    	/// </summary>
    	[Opposite(typeof(Behavior), "ObjectNode")]
    	Behavior? Selection { get; set; }
    	
    	/// <summary>
    	/// The maximum number of tokens that may be held by this ObjectNode. Tokens cannot flow into the ObjectNode if the upperBound is reached. If no upperBound is specified, then there is no limit on how many tokens the ObjectNode can hold.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "ObjectNode")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? UpperBound { get; set; }
    	
    }
    

    /// <summary>
    /// A Variable is a ConnectableElement that may store values during the execution of an Activity. Reading and writing the values of a Variable provides an alternative means for passing data than the use of ObjectFlows. A Variable may be owned directly by an Activity, in which case it is accessible from anywhere within that activity, or it may be owned by a StructuredActivityNode, in which case it is only accessible within that node.
    /// </summary>
    [MetaClass]
    public partial interface Variable : ConnectableElement, MultiplicityElement
    {
    	/// <summary>
    	/// An Activity that owns the Variable.
    	/// </summary>
    	[Opposite(typeof(Activity), "Variable")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	Activity? ActivityScope { get; set; }
    	
    	/// <summary>
    	/// A StructuredActivityNode that owns the Variable.
    	/// </summary>
    	[Opposite(typeof(StructuredActivityNode), "Variable")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	StructuredActivityNode? Scope { get; set; }
    	
    }
    

    /// <summary>
    /// A Duration is a ValueSpecification that specifies the temporal distance between two time instants.
    /// </summary>
    [MetaClass]
    public partial interface Duration : ValueSpecification
    {
    	/// <summary>
    	/// A ValueSpecification that evaluates to the value of the Duration.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "Duration")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? Expr { get; set; }
    	
    	/// <summary>
    	/// Refers to the Observations that are involved in the computation of the Duration value
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Observation), "Duration")]
    	IList<Observation> Observation { get; }
    	
    }
    

    /// <summary>
    /// A DurationConstraint is a Constraint that refers to a DurationInterval.
    /// </summary>
    [MetaClass]
    public partial interface DurationConstraint : IntervalConstraint
    {
    	/// <summary>
    	/// The value of firstEvent[i] is related to constrainedElement[i] (where i is 1 or 2). If firstEvent[i] is true, then the corresponding observation event is the first time instant the execution enters constrainedElement[i]. If firstEvent[i] is false, then the corresponding observation event is the last time instant the execution is within constrainedElement[i].
    	/// </summary>
    	[Unordered]
    	IList<bool> FirstEvent { get; }
    	
    	/// <summary>
    	/// The DurationInterval constraining the duration.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(DurationInterval), "DurationConstraint")]
    	[Redefines(typeof(IntervalConstraint), "Specification")]
    	new DurationInterval Specification { get; set; }
    	
    }
    

    /// <summary>
    /// A DurationInterval defines the range between two Durations.
    /// </summary>
    [MetaClass]
    public partial interface DurationInterval : Interval
    {
    	/// <summary>
    	/// Refers to the Duration denoting the maximum value of the range.
    	/// </summary>
    	[Opposite(typeof(Duration), "DurationInterval")]
    	[Redefines(typeof(Interval), "Max")]
    	new Duration Max { get; set; }
    	
    	/// <summary>
    	/// Refers to the Duration denoting the minimum value of the range.
    	/// </summary>
    	[Opposite(typeof(Duration), "DurationInterval")]
    	[Redefines(typeof(Interval), "Min")]
    	new Duration Min { get; set; }
    	
    }
    

    /// <summary>
    /// A DurationObservation is a reference to a duration during an execution. It points out the NamedElement(s) in the model to observe and whether the observations are when this NamedElement is entered or when it is exited.
    /// </summary>
    [MetaClass]
    public partial interface DurationObservation : Observation
    {
    	/// <summary>
    	/// The DurationObservation is determined as the duration between the entering or exiting of a single event Element during execution, or the entering/exiting of one event Element and the entering/exiting of a second.
    	/// </summary>
    	[Opposite(typeof(NamedElement), "DurationObservation")]
    	IList<NamedElement> Event { get; }
    	
    	/// <summary>
    	/// The value of firstEvent[i] is related to event[i] (where i is 1 or 2). If firstEvent[i] is true, then the corresponding observation event is the first time instant the execution enters event[i]. If firstEvent[i] is false, then the corresponding observation event is the time instant the execution exits event[i].
    	/// </summary>
    	[Unordered]
    	IList<bool> FirstEvent { get; }
    	
    }
    

    /// <summary>
    /// An Expression represents a node in an expression tree, which may be non-terminal or terminal. It defines a symbol, and has a possibly empty sequence of operands that are ValueSpecifications. It denotes a (possibly empty) set of values when evaluated in a context.
    /// </summary>
    [MetaClass]
    public partial interface Expression : ValueSpecification
    {
    	/// <summary>
    	/// Specifies a sequence of operand ValueSpecifications.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "Expression")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ValueSpecification> Operand { get; }
    	
    	/// <summary>
    	/// The symbol associated with this node in the expression tree.
    	/// </summary>
    	string Symbol { get; set; }
    	
    }
    

    /// <summary>
    /// An Interval defines the range between two ValueSpecifications.
    /// </summary>
    [MetaClass]
    public partial interface Interval : ValueSpecification
    {
    	/// <summary>
    	/// Refers to the ValueSpecification denoting the maximum value of the range.
    	/// </summary>
    	[Opposite(typeof(ValueSpecification), "Interval")]
    	ValueSpecification Max { get; set; }
    	
    	/// <summary>
    	/// Refers to the ValueSpecification denoting the minimum value of the range.
    	/// </summary>
    	[Opposite(typeof(ValueSpecification), "Interval")]
    	ValueSpecification Min { get; set; }
    	
    }
    

    /// <summary>
    /// An IntervalConstraint is a Constraint that is specified by an Interval.
    /// </summary>
    [MetaClass]
    public partial interface IntervalConstraint : Constraint
    {
    	/// <summary>
    	/// The Interval that specifies the condition of the IntervalConstraint.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Interval), "IntervalConstraint")]
    	[Redefines(typeof(Constraint), "Specification")]
    	new Interval Specification { get; set; }
    	
    }
    

    /// <summary>
    /// A LiteralBoolean is a specification of a Boolean value.
    /// </summary>
    [MetaClass]
    public partial interface LiteralBoolean : LiteralSpecification
    {
    	/// <summary>
    	/// The specified Boolean value.
    	/// </summary>
    	[DefaultValue(false)]
    	bool Value { get; set; }
    	
    	bool ValueSpecification.BooleanValue()
    	{
    		return this.BooleanValue();
    	}
    	
    	bool ValueSpecification.IsComputable()
    	{
    		return this.IsComputable();
    	}
    	
    }
    

    /// <summary>
    /// A LiteralInteger is a specification of an Integer value.
    /// </summary>
    [MetaClass]
    public partial interface LiteralInteger : LiteralSpecification
    {
    	/// <summary>
    	/// The specified Integer value.
    	/// </summary>
    	[DefaultValue(0)]
    	int Value { get; set; }
    	
    	int ValueSpecification.IntegerValue()
    	{
    		return this.IntegerValue();
    	}
    	
    	bool ValueSpecification.IsComputable()
    	{
    		return this.IsComputable();
    	}
    	
    }
    

    /// <summary>
    /// A LiteralNull specifies the lack of a value.
    /// </summary>
    [MetaClass]
    public partial interface LiteralNull : LiteralSpecification
    {
    	bool ValueSpecification.IsComputable()
    	{
    		return this.IsComputable();
    	}
    	
    	bool ValueSpecification.IsNull()
    	{
    		return this.IsNull();
    	}
    	
    }
    

    /// <summary>
    /// A LiteralReal is a specification of a Real value.
    /// </summary>
    [MetaClass]
    public partial interface LiteralReal : LiteralSpecification
    {
    	/// <summary>
    	/// The specified Real value.
    	/// </summary>
    	double Value { get; set; }
    	
    	bool ValueSpecification.IsComputable()
    	{
    		return this.IsComputable();
    	}
    	
    	double ValueSpecification.RealValue()
    	{
    		return this.RealValue();
    	}
    	
    }
    

    /// <summary>
    /// A LiteralSpecification identifies a literal constant being modeled.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface LiteralSpecification : ValueSpecification
    {
    }
    

    /// <summary>
    /// A LiteralString is a specification of a String value.
    /// </summary>
    [MetaClass]
    public partial interface LiteralString : LiteralSpecification
    {
    	/// <summary>
    	/// The specified String value.
    	/// </summary>
    	string Value { get; set; }
    	
    	bool ValueSpecification.IsComputable()
    	{
    		return this.IsComputable();
    	}
    	
    	string ValueSpecification.StringValue()
    	{
    		return this.StringValue();
    	}
    	
    }
    

    /// <summary>
    /// A LiteralUnlimitedNatural is a specification of an UnlimitedNatural number.
    /// </summary>
    [MetaClass]
    public partial interface LiteralUnlimitedNatural : LiteralSpecification
    {
    	/// <summary>
    	/// The specified UnlimitedNatural value.
    	/// </summary>
    	[DefaultValue(0)]
    	long Value { get; set; }
    	
    	bool ValueSpecification.IsComputable()
    	{
    		return this.IsComputable();
    	}
    	
    	long ValueSpecification.UnlimitedValue()
    	{
    		return this.UnlimitedValue();
    	}
    	
    }
    

    /// <summary>
    /// Observation specifies a value determined by observing an event or events that occur relative to other model Elements.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface Observation : PackageableElement
    {
    }
    

    /// <summary>
    /// An OpaqueExpression is a ValueSpecification that specifies the computation of a collection of values either in terms of a UML Behavior or based on a textual statement in a language other than UML
    /// </summary>
    [MetaClass]
    public partial interface OpaqueExpression : ValueSpecification
    {
    	/// <summary>
    	/// Specifies the behavior of the OpaqueExpression as a UML Behavior.
    	/// </summary>
    	[Opposite(typeof(Behavior), "OpaqueExpression")]
    	Behavior? Behavior { get; set; }
    	
    	/// <summary>
    	/// A textual definition of the behavior of the OpaqueExpression, possibly in multiple languages.
    	/// </summary>
    	[NonUnique]
    	IList<string> Body { get; }
    	
    	/// <summary>
    	/// Specifies the languages used to express the textual bodies of the OpaqueExpression.  Languages are matched to body Strings by order. The interpretation of the body depends on the languages. If the languages are unspecified, they may be implicit from the expression body or the context.
    	/// </summary>
    	IList<string> Language { get; }
    	
    }
    

    /// <summary>
    /// A StringExpression is an Expression that specifies a String value that is derived by concatenating a sequence of operands with String values or a sequence of subExpressions, some of which might be template parameters.
    /// </summary>
    [MetaClass]
    public partial interface StringExpression : TemplateableElement, Expression
    {
    	/// <summary>
    	/// The StringExpression of which this StringExpression is a subExpression.
    	/// </summary>
    	[Opposite(typeof(StringExpression), "SubExpression")]
    	[Subsets(typeof(Element), "Owner")]
    	StringExpression? OwningExpression { get; set; }
    	
    	/// <summary>
    	/// The StringExpressions that constitute this StringExpression.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(StringExpression), "OwningExpression")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<StringExpression> SubExpression { get; }
    	
    	string ValueSpecification.StringValue()
    	{
    		return this.StringValue();
    	}
    	
    }
    

    /// <summary>
    /// A TimeConstraint is a Constraint that refers to a TimeInterval.
    /// </summary>
    [MetaClass]
    public partial interface TimeConstraint : IntervalConstraint
    {
    	/// <summary>
    	/// The value of firstEvent is related to the constrainedElement. If firstEvent is true, then the corresponding observation event is the first time instant the execution enters the constrainedElement. If firstEvent is false, then the corresponding observation event is the last time instant the execution is within the constrainedElement.
    	/// </summary>
    	[DefaultValue(true)]
    	bool FirstEvent { get; set; }
    	
    	/// <summary>
    	/// TheTimeInterval constraining the duration.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(TimeInterval), "TimeConstraint")]
    	[Redefines(typeof(IntervalConstraint), "Specification")]
    	new TimeInterval Specification { get; set; }
    	
    }
    

    /// <summary>
    /// A TimeExpression is a ValueSpecification that represents a time value.
    /// </summary>
    [MetaClass]
    public partial interface TimeExpression : ValueSpecification
    {
    	/// <summary>
    	/// A ValueSpecification that evaluates to the value of the TimeExpression.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "TimeExpression")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? Expr { get; set; }
    	
    	/// <summary>
    	/// Refers to the Observations that are involved in the computation of the TimeExpression value.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Observation), "TimeExpression")]
    	IList<Observation> Observation { get; }
    	
    }
    

    /// <summary>
    /// A TimeInterval defines the range between two TimeExpressions.
    /// </summary>
    [MetaClass]
    public partial interface TimeInterval : Interval
    {
    	/// <summary>
    	/// Refers to the TimeExpression denoting the maximum value of the range.
    	/// </summary>
    	[Opposite(typeof(TimeExpression), "TimeInterval")]
    	[Redefines(typeof(Interval), "Max")]
    	new TimeExpression Max { get; set; }
    	
    	/// <summary>
    	/// Refers to the TimeExpression denoting the minimum value of the range.
    	/// </summary>
    	[Opposite(typeof(TimeExpression), "TimeInterval")]
    	[Redefines(typeof(Interval), "Min")]
    	new TimeExpression Min { get; set; }
    	
    }
    

    /// <summary>
    /// A TimeObservation is a reference to a time instant during an execution. It points out the NamedElement in the model to observe and whether the observation is when this NamedElement is entered or when it is exited.
    /// </summary>
    [MetaClass]
    public partial interface TimeObservation : Observation
    {
    	/// <summary>
    	/// The TimeObservation is determined by the entering or exiting of the event Element during execution.
    	/// </summary>
    	[Opposite(typeof(NamedElement), "TimeObservation")]
    	NamedElement Event { get; set; }
    	
    	/// <summary>
    	/// The value of firstEvent is related to the event. If firstEvent is true, then the corresponding observation event is the first time instant the execution enters the event Element. If firstEvent is false, then the corresponding observation event is the time instant the execution exits the event Element.
    	/// </summary>
    	[DefaultValue(true)]
    	bool FirstEvent { get; set; }
    	
    }
    

    /// <summary>
    /// A ValueSpecification is the specification of a (possibly empty) set of values. A ValueSpecification is a ParameterableElement that may be exposed as a formal TemplateParameter and provided as the actual parameter in the binding of a template.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface ValueSpecification : TypedElement, PackageableElement
    {
    	bool ParameterableElement.IsCompatibleWith(ParameterableElement p)
    	{
    		return this.IsCompatibleWith(p);
    	}
    	
    }
    

    /// <summary>
    /// An Actor specifies a role played by a user or any other system that interacts with the subject.
    /// </summary>
    [MetaClass]
    public partial interface Actor : BehavioredClassifier
    {
    }
    

    /// <summary>
    /// A relationship from an extending UseCase to an extended UseCase that specifies how and when the behavior defined in the extending UseCase can be inserted into the behavior defined in the extended UseCase.
    /// </summary>
    [MetaClass]
    public partial interface Extend : NamedElement, DirectedRelationship
    {
    	/// <summary>
    	/// References the condition that must hold when the first ExtensionPoint is reached for the extension to take place. If no constraint is associated with the Extend relationship, the extension is unconditional.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Constraint), "Extend")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	Constraint? Condition { get; set; }
    	
    	/// <summary>
    	/// The UseCase that is being extended.
    	/// </summary>
    	[Opposite(typeof(UseCase), "Extend")]
    	[Subsets(typeof(DirectedRelationship), "Target")]
    	UseCase ExtendedCase { get; set; }
    	
    	/// <summary>
    	/// The UseCase that represents the extension and owns the Extend relationship.
    	/// </summary>
    	[Opposite(typeof(UseCase), "Extend")]
    	[Subsets(typeof(DirectedRelationship), "Source")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	UseCase Extension { get; set; }
    	
    	/// <summary>
    	/// An ordered list of ExtensionPoints belonging to the extended UseCase, specifying where the respective behavioral fragments of the extending UseCase are to be inserted. The first fragment in the extending UseCase is associated with the first extension point in the list, the second fragment with the second point, and so on. Note that, in most practical cases, the extending UseCase has just a single behavior fragment, so that the list of ExtensionPoints is trivial.
    	/// </summary>
    	[Opposite(typeof(ExtensionPoint), "Extension")]
    	IList<ExtensionPoint> ExtensionLocation { get; }
    	
    }
    

    /// <summary>
    /// An ExtensionPoint identifies a point in the behavior of a UseCase where that behavior can be extended by the behavior of some other (extending) UseCase, as specified by an Extend relationship.
    /// </summary>
    [MetaClass]
    public partial interface ExtensionPoint : RedefinableElement
    {
    	/// <summary>
    	/// The UseCase that owns this ExtensionPoint.
    	/// </summary>
    	[Opposite(typeof(UseCase), "ExtensionPoint")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	UseCase UseCase { get; set; }
    	
    }
    

    /// <summary>
    /// An Include relationship specifies that a UseCase contains the behavior defined in another UseCase.
    /// </summary>
    [MetaClass]
    public partial interface Include : DirectedRelationship, NamedElement
    {
    	/// <summary>
    	/// The UseCase that is to be included.
    	/// </summary>
    	[Opposite(typeof(UseCase), "Include")]
    	[Subsets(typeof(DirectedRelationship), "Target")]
    	UseCase Addition { get; set; }
    	
    	/// <summary>
    	/// The UseCase which includes the addition and owns the Include relationship.
    	/// </summary>
    	[Opposite(typeof(UseCase), "Include")]
    	[Subsets(typeof(DirectedRelationship), "Source")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	UseCase IncludingCase { get; set; }
    	
    }
    

    /// <summary>
    /// A UseCase specifies a set of actions performed by its subjects, which yields an observable result that is of value for one or more Actors or other stakeholders of each subject.
    /// </summary>
    [MetaClass]
    public partial interface UseCase : BehavioredClassifier
    {
    	/// <summary>
    	/// The Extend relationships owned by this UseCase.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Extend), "Extension")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Extend> Extend { get; }
    	
    	/// <summary>
    	/// The ExtensionPoints owned by this UseCase.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ExtensionPoint), "UseCase")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<ExtensionPoint> ExtensionPoint { get; }
    	
    	/// <summary>
    	/// The Include relationships owned by this UseCase.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Include), "IncludingCase")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Include> Include { get; }
    	
    	/// <summary>
    	/// The subjects to which this UseCase applies. Each subject or its parts realize all the UseCases that apply to it.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Classifier), "UseCase")]
    	IList<Classifier> Subject { get; }
    	
    }
    

    /// <summary>
    /// A link is a tuple of values that refer to typed objects.  An Association classifies a set of links, each of which is an instance of the Association.  Each value in the link refers to an instance of the type of the corresponding end of the Association.
    /// </summary>
    [MetaClass]
    public partial interface Association : Relationship, Classifier
    {
    	/// <summary>
    	/// Specifies whether the Association is derived from other model elements such as other Associations.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsDerived { get; set; }
    	
    	/// <summary>
    	/// Each end represents participation of instances of the Classifier connected to the end in links of the Association.
    	/// </summary>
    	[Opposite(typeof(Property), "Association")]
    	[Subsets(typeof(Namespace), "Member")]
    	IList<Property> MemberEnd { get; }
    	
    	/// <summary>
    	/// The navigable ends that are owned by the Association itself.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Property), "Association")]
    	[Subsets(typeof(Association), "OwnedEnd")]
    	IList<Property> NavigableOwnedEnd { get; }
    	
    	/// <summary>
    	/// The ends that are owned by the Association itself.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Property), "OwningAssociation")]
    	[Subsets(typeof(Association), "MemberEnd")]
    	[Subsets(typeof(Classifier), "Feature")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Property> OwnedEnd { get; }
    	
    }
    

    /// <summary>
    /// A model element that has both Association and Class properties. An AssociationClass can be seen as an Association that also has Class properties, or as a Class that also has Association properties. It not only connects a set of Classifiers but also defines a set of Features that belong to the Association itself and not to any of the associated Classifiers.
    /// </summary>
    [MetaClass]
    public partial interface AssociationClass : Class, Association
    {
    }
    

    /// <summary>
    /// A Class classifies a set of objects and specifies the features that characterize the structure and behavior of those objects.  A Class may have an internal structure and Ports.
    /// </summary>
    [MetaClass]
    public partial interface Class : BehavioredClassifier, EncapsulatedClassifier
    {
    	/// <summary>
    	/// If true, the Class does not provide a complete declaration and cannot be instantiated. An abstract Class is typically used as a target of Associations or Generalizations.
    	/// </summary>
    	[Redefines(typeof(Classifier), "IsAbstract")]
    	[DefaultValue(false)]
    	new bool IsAbstract { get; set; }
    	
    	/// <summary>
    	/// Determines whether an object specified by this Class is active or not. If true, then the owning Class is referred to as an active Class. If false, then such a Class is referred to as a passive Class.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsActive { get; set; }
    	
    	/// <summary>
    	/// The Classifiers owned by the Class that are not ownedBehaviors.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Classifier), "NestingClass")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Classifier> NestedClassifier { get; }
    	
    	/// <summary>
    	/// The attributes (i.e., the Properties) owned by the Class.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Property), "Class")]
    	[Redefines(typeof(StructuredClassifier), "OwnedAttribute")]
    	[Subsets(typeof(Classifier), "Attribute")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	new IList<Property> OwnedAttribute { get; }
    	
    	/// <summary>
    	/// The Operations owned by the Class.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Operation), "Class")]
    	[Subsets(typeof(Classifier), "Feature")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Operation> OwnedOperation { get; }
    	
    	/// <summary>
    	/// The Receptions owned by the Class.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Reception), "Class")]
    	[Subsets(typeof(Classifier), "Feature")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Reception> OwnedReception { get; }
    	
    }
    

    /// <summary>
    /// A Collaboration describes a structure of collaborating elements (roles), each performing a specialized function, which collectively accomplish some desired functionality. 
    /// </summary>
    [MetaClass]
    public partial interface Collaboration : StructuredClassifier, BehavioredClassifier
    {
    	/// <summary>
    	/// Represents the participants in the Collaboration.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ConnectableElement), "Collaboration")]
    	[Subsets(typeof(StructuredClassifier), "Role")]
    	IList<ConnectableElement> CollaborationRole { get; }
    	
    }
    

    /// <summary>
    /// A CollaborationUse is used to specify the application of a pattern specified by a Collaboration to a specific situation.
    /// </summary>
    [MetaClass]
    public partial interface CollaborationUse : NamedElement
    {
    	/// <summary>
    	/// A mapping between features of the Collaboration and features of the owning Classifier. This mapping indicates which ConnectableElement of the Classifier plays which role(s) in the Collaboration. A ConnectableElement may be bound to multiple roles in the same CollaborationUse (that is, it may play multiple roles).
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Dependency), "CollaborationUse")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Dependency> RoleBinding { get; }
    	
    	/// <summary>
    	/// The Collaboration which is used in this CollaborationUse. The Collaboration defines the cooperation between its roles which are mapped to ConnectableElements relating to the Classifier owning the CollaborationUse.
    	/// </summary>
    	[Opposite(typeof(Collaboration), "CollaborationUse")]
    	Collaboration Type { get; set; }
    	
    }
    

    /// <summary>
    /// A Component represents a modular part of a system that encapsulates its contents and whose manifestation is replaceable within its environment.  
    /// </summary>
    [MetaClass]
    public partial interface Component : Class
    {
    	/// <summary>
    	/// If true, the Component is defined at design-time, but at run-time (or execution-time) an object specified by the Component does not exist, that is, the Component is instantiated indirectly, through the instantiation of its realizing Classifiers or parts.
    	/// </summary>
    	[DefaultValue(true)]
    	bool IsIndirectlyInstantiated { get; set; }
    	
    	/// <summary>
    	/// The set of PackageableElements that a Component owns. In the namespace of a Component, all model elements that are involved in or related to its definition may be owned or imported explicitly. These may include e.g., Classes, Interfaces, Components, Packages, UseCases, Dependencies (e.g., mappings), and Artifacts.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(PackageableElement), "Component")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<PackageableElement> PackagedElement { get; }
    	
    	/// <summary>
    	/// The set of Realizations owned by the Component. Realizations reference the Classifiers of which the Component is an abstraction; i.e., that realize its behavior.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ComponentRealization), "Abstraction")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ComponentRealization> Realization { get; }
    	
    }
    

    /// <summary>
    /// Realization is specialized to (optionally) define the Classifiers that realize the contract offered by a Component in terms of its provided and required Interfaces. The Component forms an abstraction from these various Classifiers.
    /// </summary>
    [MetaClass]
    public partial interface ComponentRealization : Realization
    {
    	/// <summary>
    	/// The Component that owns this ComponentRealization and which is implemented by its realizing Classifiers.
    	/// </summary>
    	[Opposite(typeof(Component), "Realization")]
    	[Subsets(typeof(Dependency), "Supplier")]
    	[Subsets(typeof(Element), "Owner")]
    	Component? Abstraction { get; set; }
    	
    	/// <summary>
    	/// The Classifiers that are involved in the implementation of the Component that owns this Realization.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Classifier), "ComponentRealization")]
    	[Subsets(typeof(Dependency), "Client")]
    	IList<Classifier> RealizingClassifier { get; }
    	
    }
    

    /// <summary>
    /// ConnectableElement is an abstract metaclass representing a set of instances that play roles of a StructuredClassifier. ConnectableElements may be joined by attached Connectors and specify configurations of linked instances to be created within an instance of the containing StructuredClassifier.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface ConnectableElement : TypedElement, ParameterableElement
    {
    	/// <summary>
    	/// The ConnectableElementTemplateParameter for this ConnectableElement parameter.
    	/// </summary>
    	[Opposite(typeof(ConnectableElementTemplateParameter), "ParameteredElement")]
    	[Redefines(typeof(ParameterableElement), "TemplateParameter")]
    	new ConnectableElementTemplateParameter? TemplateParameter { get; set; }
    	
    }
    

    /// <summary>
    /// A ConnectableElementTemplateParameter exposes a ConnectableElement as a formal parameter for a template.
    /// </summary>
    [MetaClass]
    public partial interface ConnectableElementTemplateParameter : TemplateParameter
    {
    	/// <summary>
    	/// The ConnectableElement for this ConnectableElementTemplateParameter.
    	/// </summary>
    	[Opposite(typeof(ConnectableElement), "TemplateParameter")]
    	[Redefines(typeof(TemplateParameter), "ParameteredElement")]
    	new ConnectableElement ParameteredElement { get; set; }
    	
    }
    

    /// <summary>
    /// A Connector specifies links that enables communication between two or more instances. In contrast to Associations, which specify links between any instance of the associated Classifiers, Connectors specify links between instances playing the connected parts only.
    /// </summary>
    [MetaClass]
    public partial interface Connector : Feature
    {
    	/// <summary>
    	/// The set of Behaviors that specify the valid interaction patterns across the Connector.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Behavior), "Connector")]
    	IList<Behavior> Contract { get; }
    	
    	/// <summary>
    	/// A Connector has at least two ConnectorEnds, each representing the participation of instances of the Classifiers typing the ConnectableElements attached to the end. The set of ConnectorEnds is ordered.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ConnectorEnd), "Connector")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ConnectorEnd> End { get; }
    	
    	/// <summary>
    	/// A Connector may be redefined when its containing Classifier is specialized. The redefining Connector may have a type that specializes the type of the redefined Connector. The types of the ConnectorEnds of the redefining Connector may specialize the types of the ConnectorEnds of the redefined Connector. The properties of the ConnectorEnds of the redefining Connector may be replaced.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Connector), "Connector")]
    	[Subsets(typeof(RedefinableElement), "RedefinedElement")]
    	IList<Connector> RedefinedConnector { get; }
    	
    	/// <summary>
    	/// An optional Association that classifies links corresponding to this Connector.
    	/// </summary>
    	[Opposite(typeof(Association), "Connector")]
    	Association? Type { get; set; }
    	
    }
    

    /// <summary>
    /// A ConnectorEnd is an endpoint of a Connector, which attaches the Connector to a ConnectableElement.
    /// </summary>
    [MetaClass]
    public partial interface ConnectorEnd : MultiplicityElement
    {
    	/// <summary>
    	/// Indicates the role of the internal structure of a Classifier with the Port to which the ConnectorEnd is attached.
    	/// </summary>
    	[Opposite(typeof(Property), "ConnectorEnd")]
    	Property? PartWithPort { get; set; }
    	
    	/// <summary>
    	/// The ConnectableElement attached at this ConnectorEnd. When an instance of the containing Classifier is created, a link may (depending on the multiplicities) be created to an instance of the Classifier that types this ConnectableElement.
    	/// </summary>
    	[Opposite(typeof(ConnectableElement), "End")]
    	ConnectableElement Role { get; set; }
    	
    }
    

    /// <summary>
    /// An EncapsulatedClassifier may own Ports to specify typed interaction points.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface EncapsulatedClassifier : StructuredClassifier
    {
    }
    

    /// <summary>
    /// A Port is a property of an EncapsulatedClassifier that specifies a distinct interaction point between that EncapsulatedClassifier and its environment or between the (behavior of the) EncapsulatedClassifier and its internal parts. Ports are connected to Properties of the EncapsulatedClassifier by Connectors through which requests can be made to invoke BehavioralFeatures. A Port may specify the services an EncapsulatedClassifier provides (offers) to its environment as well as the services that an EncapsulatedClassifier expects (requires) of its environment.  A Port may have an associated ProtocolStateMachine.
    /// </summary>
    [MetaClass]
    public partial interface Port : Property
    {
    	/// <summary>
    	/// Specifies whether requests arriving at this Port are sent to the classifier behavior of this EncapsulatedClassifier. Such a Port is referred to as a behavior Port. Any invocation of a BehavioralFeature targeted at a behavior Port will be handled by the instance of the owning EncapsulatedClassifier itself, rather than by any instances that it may contain.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsBehavior { get; set; }
    	
    	/// <summary>
    	/// Specifies the way that the provided and required Interfaces are derived from the Port’s Type.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsConjugated { get; set; }
    	
    	/// <summary>
    	/// If true, indicates that this Port is used to provide the published functionality of an EncapsulatedClassifier.  If false, this Port is used to implement the EncapsulatedClassifier but is not part of the essential externally-visible functionality of the EncapsulatedClassifier and can, therefore, be altered or deleted along with the internal implementation of the EncapsulatedClassifier and other properties that are considered part of its implementation.
    	/// </summary>
    	[DefaultValue(true)]
    	bool IsService { get; set; }
    	
    	/// <summary>
    	/// An optional ProtocolStateMachine which describes valid interactions at this interaction point.
    	/// </summary>
    	[Opposite(typeof(ProtocolStateMachine), "Port")]
    	ProtocolStateMachine? Protocol { get; set; }
    	
    	/// <summary>
    	/// A Port may be redefined when its containing EncapsulatedClassifier is specialized. The redefining Port may have additional Interfaces to those that are associated with the redefined Port or it may replace an Interface by one of its subtypes.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Port), "Port")]
    	[Subsets(typeof(Property), "RedefinedProperty")]
    	IList<Port> RedefinedPort { get; }
    	
    }
    

    /// <summary>
    /// StructuredClassifiers may contain an internal structure of connected elements each of which plays a role in the overall Behavior modeled by the StructuredClassifier.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface StructuredClassifier : Classifier
    {
    	/// <summary>
    	/// The Properties owned by the StructuredClassifier.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Property), "StructuredClassifier")]
    	[Subsets(typeof(Classifier), "Attribute")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	[Subsets(typeof(StructuredClassifier), "Role")]
    	IList<Property> OwnedAttribute { get; }
    	
    	/// <summary>
    	/// The connectors owned by the StructuredClassifier.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Connector), "StructuredClassifier")]
    	[Subsets(typeof(Classifier), "Feature")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Connector> OwnedConnector { get; }
    	
    	/// <summary>
    	/// The roles that instances may play in this StructuredClassifier.
    	/// </summary>
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(ConnectableElement), "StructuredClassifier")]
    	[Subsets(typeof(Namespace), "Member")]
    	IList<ConnectableElement> Role { get; }
    	
    }
    

    /// <summary>
    /// A ConnectionPointReference represents a usage (as part of a submachine State) of an entry/exit point Pseudostate defined in the StateMachine referenced by the submachine State.
    /// </summary>
    [MetaClass]
    public partial interface ConnectionPointReference : Vertex
    {
    	/// <summary>
    	/// The entryPoint Pseudostates corresponding to this connection point.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Pseudostate), "ConnectionPointReference")]
    	IList<Pseudostate> Entry { get; }
    	
    	/// <summary>
    	/// The exitPoints kind Pseudostates corresponding to this connection point.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Pseudostate), "ConnectionPointReference")]
    	IList<Pseudostate> Exit { get; }
    	
    	/// <summary>
    	/// The State in which the ConnectionPointReference is defined.
    	/// </summary>
    	[Opposite(typeof(State), "Connection")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	State? State { get; set; }
    	
    	bool Vertex.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    	bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    }
    

    /// <summary>
    /// A special kind of State, which, when entered, signifies that the enclosing Region has completed. If the enclosing Region is directly contained in a StateMachine and all other Regions in that StateMachine also are completed, then it means that the entire StateMachine behavior is completed.
    /// </summary>
    [MetaClass]
    public partial interface FinalState : State
    {
    	bool State.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    	bool Vertex.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    	bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    }
    

    /// <summary>
    /// A ProtocolStateMachine can be redefined into a more specific ProtocolStateMachine or into behavioral StateMachine. ProtocolConformance declares that the specific ProtocolStateMachine specifies a protocol that conforms to the general ProtocolStateMachine or that the specific behavioral StateMachine abides by the protocol of the general ProtocolStateMachine.
    /// </summary>
    [MetaClass]
    public partial interface ProtocolConformance : DirectedRelationship
    {
    	/// <summary>
    	/// Specifies the ProtocolStateMachine to which the specific ProtocolStateMachine conforms.
    	/// </summary>
    	[Opposite(typeof(ProtocolStateMachine), "ProtocolConformance")]
    	[Subsets(typeof(DirectedRelationship), "Target")]
    	ProtocolStateMachine GeneralMachine { get; set; }
    	
    	/// <summary>
    	/// Specifies the ProtocolStateMachine which conforms to the general ProtocolStateMachine.
    	/// </summary>
    	[Opposite(typeof(ProtocolStateMachine), "Conformance")]
    	[Subsets(typeof(DirectedRelationship), "Source")]
    	[Subsets(typeof(Element), "Owner")]
    	ProtocolStateMachine SpecificMachine { get; set; }
    	
    }
    

    /// <summary>
    /// A ProtocolStateMachine is always defined in the context of a Classifier. It specifies which BehavioralFeatures of the Classifier can be called in which State and under which conditions, thus specifying the allowed invocation sequences on the Classifier&apos;s BehavioralFeatures. A ProtocolStateMachine specifies the possible and permitted Transitions on the instances of its context Classifier, together with the BehavioralFeatures that carry the Transitions. In this manner, an instance lifecycle can be specified for a Classifier, by defining the order in which the BehavioralFeatures can be activated and the States through which an instance progresses during its existence.
    /// </summary>
    [MetaClass]
    public partial interface ProtocolStateMachine : StateMachine
    {
    	/// <summary>
    	/// Conformance between ProtocolStateMachine 
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ProtocolConformance), "SpecificMachine")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ProtocolConformance> Conformance { get; }
    	
    }
    

    /// <summary>
    /// A ProtocolTransition specifies a legal Transition for an Operation. Transitions of ProtocolStateMachines have the following information: a pre-condition (guard), a Trigger, and a post-condition. Every ProtocolTransition is associated with at most one BehavioralFeature belonging to the context Classifier of the ProtocolStateMachine.
    /// </summary>
    [MetaClass]
    public partial interface ProtocolTransition : Transition
    {
    	/// <summary>
    	/// Specifies the post condition of the Transition which is the Condition that should be obtained once the Transition is triggered. This post condition is part of the post condition of the Operation connected to the Transition.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Constraint), "OwningTransition")]
    	[Subsets(typeof(Namespace), "OwnedRule")]
    	Constraint? PostCondition { get; set; }
    	
    	/// <summary>
    	/// Specifies the precondition of the Transition. It specifies the Condition that should be verified before triggering the Transition. This guard condition added to the source State will be evaluated as part of the precondition of the Operation referred by the Transition if any.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Constraint), "ProtocolTransition")]
    	[Subsets(typeof(Transition), "Guard")]
    	Constraint? PreCondition { get; set; }
    	
    }
    

    /// <summary>
    /// A Pseudostate is an abstraction that encompasses different types of transient Vertices in the StateMachine graph. A StateMachine instance never comes to rest in a Pseudostate, instead, it will exit and enter the Pseudostate within a single run-to-completion step.
    /// </summary>
    [MetaClass]
    public partial interface Pseudostate : Vertex
    {
    	/// <summary>
    	/// Determines the precise type of the Pseudostate and can be one of: entryPoint, exitPoint, initial, deepHistory, shallowHistory, join, fork, junction, terminate or choice.
    	/// </summary>
    	[DefaultValue(PseudostateKind.Initial)]
    	PseudostateKind Kind { get; set; }
    	
    	/// <summary>
    	/// The State that owns this Pseudostate and in which it appears.
    	/// </summary>
    	[Opposite(typeof(State), "ConnectionPoint")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	State? State { get; set; }
    	
    	/// <summary>
    	/// The StateMachine in which this Pseudostate is defined. This only applies to Pseudostates of the kind entryPoint or exitPoint.
    	/// </summary>
    	[Opposite(typeof(StateMachine), "ConnectionPoint")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	StateMachine? StateMachine { get; set; }
    	
    	bool Vertex.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    	bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    }
    

    /// <summary>
    /// A Region is a top-level part of a StateMachine or a composite State, that serves as a container for the Vertices and Transitions of the StateMachine. A StateMachine or composite State may contain multiple Regions representing behaviors that may occur in parallel.
    /// </summary>
    [MetaClass]
    public partial interface Region : Namespace, RedefinableElement
    {
    	/// <summary>
    	/// The region of which this region is an extension.
    	/// </summary>
    	[Opposite(typeof(Region), "Region")]
    	[Subsets(typeof(RedefinableElement), "RedefinedElement")]
    	Region? ExtendedRegion { get; set; }
    	
    	/// <summary>
    	/// The State that owns the Region. If a Region is owned by a State, then it cannot also be owned by a StateMachine.
    	/// </summary>
    	[Opposite(typeof(State), "Region")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	State? State { get; set; }
    	
    	/// <summary>
    	/// The StateMachine that owns the Region. If a Region is owned by a StateMachine, then it cannot also be owned by a State.
    	/// </summary>
    	[Opposite(typeof(StateMachine), "Region")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	StateMachine? StateMachine { get; set; }
    	
    	/// <summary>
    	/// The set of Vertices that are owned by this Region.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Vertex), "Container")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Vertex> Subvertex { get; }
    	
    	/// <summary>
    	/// The set of Transitions owned by the Region.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Transition), "Container")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Transition> Transition { get; }
    	
    	bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    	bool RedefinableElement.IsRedefinitionContextValid(RedefinableElement redefinedElement)
    	{
    		return this.IsRedefinitionContextValid(redefinedElement);
    	}
    	
    }
    

    /// <summary>
    /// A State models a situation during which some (usually implicit) invariant condition holds.
    /// </summary>
    [MetaClass]
    public partial interface State : Namespace, Vertex
    {
    	/// <summary>
    	/// The entry and exit connection points used in conjunction with this (submachine) State, i.e., as targets and sources, respectively, in the Region with the submachine State. A connection point reference references the corresponding definition of a connection point Pseudostate in the StateMachine referenced by the submachine State.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ConnectionPointReference), "State")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<ConnectionPointReference> Connection { get; }
    	
    	/// <summary>
    	/// The entry and exit Pseudostates of a composite State. These can only be entry or exit Pseudostates, and they must have different names. They can only be defined for composite States.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Pseudostate), "State")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Pseudostate> ConnectionPoint { get; }
    	
    	/// <summary>
    	/// A list of Triggers that are candidates to be retained by the StateMachine if they trigger no Transitions out of the State (not consumed). A deferred Trigger is retained until the StateMachine reaches a State configuration where it is no longer deferred.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Trigger), "State")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Trigger> DeferrableTrigger { get; }
    	
    	/// <summary>
    	/// An optional Behavior that is executed while being in the State. The execution starts when this State is entered, and ceases either by itself when done, or when the State is exited, whichever comes first.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Behavior), "State")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	Behavior? DoActivity { get; set; }
    	
    	/// <summary>
    	/// An optional Behavior that is executed whenever this State is entered regardless of the Transition taken to reach the State. If defined, entry Behaviors are always executed to completion prior to any internal Behavior or Transitions performed within the State.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Behavior), "State")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	Behavior? Entry { get; set; }
    	
    	/// <summary>
    	/// An optional Behavior that is executed whenever this State is exited regardless of which Transition was taken out of the State. If defined, exit Behaviors are always executed to completion only after all internal and transition Behaviors have completed execution.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Behavior), "State")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	Behavior? Exit { get; set; }
    	
    	/// <summary>
    	/// The Regions owned directly by the State.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Region), "State")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Region> Region { get; }
    	
    	/// <summary>
    	/// Specifies conditions that are always true when this State is the current State. In ProtocolStateMachines state invariants are additional conditions to the preconditions of the outgoing Transitions, and to the postcondition of the incoming Transitions.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Constraint), "OwningState")]
    	[Subsets(typeof(Namespace), "OwnedRule")]
    	Constraint? StateInvariant { get; set; }
    	
    	/// <summary>
    	/// The StateMachine that is to be inserted in place of the (submachine) State.
    	/// </summary>
    	[Opposite(typeof(StateMachine), "SubmachineState")]
    	StateMachine? Submachine { get; set; }
    	
    	StateMachine Vertex.ContainingStateMachine()
    	{
    		return this.ContainingStateMachine();
    	}
    	
    	bool Vertex.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    	bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    }
    

    /// <summary>
    /// StateMachines can be used to express event-driven behaviors of parts of a system. Behavior is modeled as a traversal of a graph of Vertices interconnected by one or more joined Transition arcs that are triggered by the dispatching of successive Event occurrences. During this traversal, the StateMachine may execute a sequence of Behaviors associated with various elements of the StateMachine.
    /// </summary>
    [MetaClass]
    public partial interface StateMachine : Behavior
    {
    	/// <summary>
    	/// The connection points defined for this StateMachine. They represent the interface of the StateMachine when used as part of submachine State
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Pseudostate), "StateMachine")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Pseudostate> ConnectionPoint { get; }
    	
    	/// <summary>
    	/// The StateMachines of which this is an extension.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(StateMachine), "StateMachine")]
    	[Redefines(typeof(Behavior), "RedefinedBehavior")]
    	IList<StateMachine> ExtendedStateMachine { get; }
    	
    	/// <summary>
    	/// The Regions owned directly by the StateMachine.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Region), "StateMachine")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Region> Region { get; }
    	
    	/// <summary>
    	/// References the submachine(s) in case of a submachine State. Multiple machines are referenced in case of a concurrent State.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(State), "Submachine")]
    	IList<State> SubmachineState { get; }
    	
    	bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    	bool RedefinableElement.IsRedefinitionContextValid(RedefinableElement redefinedElement)
    	{
    		return this.IsRedefinitionContextValid(redefinedElement);
    	}
    	
    }
    

    /// <summary>
    /// A Transition represents an arc between exactly one source Vertex and exactly one Target vertex (the source and targets may be the same Vertex). It may form part of a compound transition, which takes the StateMachine from one steady State configuration to another, representing the full response of the StateMachine to an occurrence of an Event that triggered it.
    /// </summary>
    [MetaClass]
    public partial interface Transition : Namespace, RedefinableElement
    {
    	/// <summary>
    	/// Designates the Region that owns this Transition.
    	/// </summary>
    	[Opposite(typeof(Region), "Transition")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	Region Container { get; set; }
    	
    	/// <summary>
    	/// Specifies an optional behavior to be performed when the Transition fires.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Behavior), "Transition")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	Behavior? Effect { get; set; }
    	
    	/// <summary>
    	/// A guard is a Constraint that provides a fine-grained control over the firing of the Transition. The guard is evaluated when an Event occurrence is dispatched by the StateMachine. If the guard is true at that time, the Transition may be enabled, otherwise, it is disabled. Guards should be pure expressions without side effects. Guard expressions with side effects are ill formed.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Constraint), "Transition")]
    	[Subsets(typeof(Namespace), "OwnedRule")]
    	Constraint? Guard { get; set; }
    	
    	/// <summary>
    	/// Indicates the precise type of the Transition.
    	/// </summary>
    	[DefaultValue(TransitionKind.External)]
    	TransitionKind Kind { get; set; }
    	
    	/// <summary>
    	/// The Transition that is redefined by this Transition.
    	/// </summary>
    	[Opposite(typeof(Transition), "Transition")]
    	[Subsets(typeof(RedefinableElement), "RedefinedElement")]
    	Transition? RedefinedTransition { get; set; }
    	
    	/// <summary>
    	/// Designates the originating Vertex (State or Pseudostate) of the Transition.
    	/// </summary>
    	[Opposite(typeof(Vertex), "Outgoing")]
    	Vertex Source { get; set; }
    	
    	/// <summary>
    	/// Designates the target Vertex that is reached when the Transition is taken.
    	/// </summary>
    	[Opposite(typeof(Vertex), "Incoming")]
    	Vertex Target { get; set; }
    	
    	/// <summary>
    	/// Specifies the Triggers that may fire the transition.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Trigger), "Transition")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Trigger> Trigger { get; }
    	
    	bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    }
    

    /// <summary>
    /// A Vertex is an abstraction of a node in a StateMachine graph. It can be the source or destination of any number of Transitions.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface Vertex : NamedElement, RedefinableElement
    {
    	/// <summary>
    	/// The Region that contains this Vertex.
    	/// </summary>
    	[Opposite(typeof(Region), "Subvertex")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	Region? Container { get; set; }
    	
    	/// <summary>
    	/// The Vertex of which this Vertex is a redefinition.
    	/// </summary>
    	[Opposite(typeof(Vertex), "Vertex")]
    	[Subsets(typeof(RedefinableElement), "RedefinedElement")]
    	Vertex? RedefinedVertex { get; set; }
    	
    	bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    }
    

    /// <summary>
    /// A BehavioredClassifier may have InterfaceRealizations, and owns a set of Behaviors one of which may specify the behavior of the BehavioredClassifier itself.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface BehavioredClassifier : Classifier
    {
    	/// <summary>
    	/// A Behavior that specifies the behavior of the BehavioredClassifier itself.
    	/// </summary>
    	[Opposite(typeof(Behavior), "BehavioredClassifier")]
    	[Subsets(typeof(BehavioredClassifier), "OwnedBehavior")]
    	Behavior? ClassifierBehavior { get; set; }
    	
    	/// <summary>
    	/// The set of InterfaceRealizations owned by the BehavioredClassifier. Interface realizations reference the Interfaces of which the BehavioredClassifier is an implementation.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(InterfaceRealization), "ImplementingClassifier")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	[Subsets(typeof(NamedElement), "ClientDependency")]
    	IList<InterfaceRealization> InterfaceRealization { get; }
    	
    	/// <summary>
    	/// Behaviors owned by a BehavioredClassifier.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Behavior), "BehavioredClassifier")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Behavior> OwnedBehavior { get; }
    	
    }
    

    /// <summary>
    /// A DataType is a type whose instances are identified only by their value.
    /// </summary>
    [MetaClass]
    public partial interface DataType : Classifier
    {
    	/// <summary>
    	/// The attributes owned by the DataType.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Property), "Datatype")]
    	[Subsets(typeof(Classifier), "Attribute")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Property> OwnedAttribute { get; }
    	
    	/// <summary>
    	/// The Operations owned by the DataType.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Operation), "Datatype")]
    	[Subsets(typeof(Classifier), "Feature")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Operation> OwnedOperation { get; }
    	
    }
    

    /// <summary>
    /// An Enumeration is a DataType whose values are enumerated in the model as EnumerationLiterals.
    /// </summary>
    [MetaClass]
    public partial interface Enumeration : DataType
    {
    	/// <summary>
    	/// The ordered set of literals owned by this Enumeration.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(EnumerationLiteral), "Enumeration")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<EnumerationLiteral> OwnedLiteral { get; }
    	
    }
    

    /// <summary>
    /// An EnumerationLiteral is a user-defined data value for an Enumeration.
    /// </summary>
    [MetaClass]
    public partial interface EnumerationLiteral : InstanceSpecification
    {
    	/// <summary>
    	/// The Enumeration that this EnumerationLiteral is a member of.
    	/// </summary>
    	[Opposite(typeof(Enumeration), "OwnedLiteral")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	Enumeration Enumeration { get; set; }
    	
    }
    

    /// <summary>
    /// Interfaces declare coherent services that are implemented by BehavioredClassifiers that implement the Interfaces via InterfaceRealizations.
    /// </summary>
    [MetaClass]
    public partial interface Interface : Classifier
    {
    	/// <summary>
    	/// References all the Classifiers that are defined (nested) within the Interface.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Classifier), "Interface")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Classifier> NestedClassifier { get; }
    	
    	/// <summary>
    	/// The attributes (i.e., the Properties) owned by the Interface.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Property), "Interface")]
    	[Subsets(typeof(Classifier), "Attribute")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Property> OwnedAttribute { get; }
    	
    	/// <summary>
    	/// The Operations owned by the Interface.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Operation), "Interface")]
    	[Subsets(typeof(Classifier), "Feature")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Operation> OwnedOperation { get; }
    	
    	/// <summary>
    	/// Receptions that objects providing this Interface are willing to accept.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Reception), "Interface")]
    	[Subsets(typeof(Classifier), "Feature")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Reception> OwnedReception { get; }
    	
    	/// <summary>
    	/// References a ProtocolStateMachine specifying the legal sequences of the invocation of the BehavioralFeatures described in the Interface.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ProtocolStateMachine), "Interface")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	ProtocolStateMachine? Protocol { get; set; }
    	
    	/// <summary>
    	/// References all the Interfaces redefined by this Interface.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Interface), "Interface")]
    	[Subsets(typeof(Classifier), "RedefinedClassifier")]
    	IList<Interface> RedefinedInterface { get; }
    	
    }
    

    /// <summary>
    /// An InterfaceRealization is a specialized realization relationship between a BehavioredClassifier and an Interface. This relationship signifies that the realizing BehavioredClassifier conforms to the contract specified by the Interface.
    /// </summary>
    [MetaClass]
    public partial interface InterfaceRealization : Realization
    {
    	/// <summary>
    	/// References the Interface specifying the conformance contract.
    	/// </summary>
    	[Opposite(typeof(Interface), "InterfaceRealization")]
    	[Subsets(typeof(Dependency), "Supplier")]
    	Interface Contract { get; set; }
    	
    	/// <summary>
    	/// References the BehavioredClassifier that owns this InterfaceRealization, i.e., the BehavioredClassifier that realizes the Interface to which it refers.
    	/// </summary>
    	[Opposite(typeof(BehavioredClassifier), "InterfaceRealization")]
    	[Subsets(typeof(Dependency), "Client")]
    	[Subsets(typeof(Element), "Owner")]
    	BehavioredClassifier ImplementingClassifier { get; set; }
    	
    }
    

    /// <summary>
    /// A PrimitiveType defines a predefined DataType, without any substructure. A PrimitiveType may have an algebra and operations defined outside of UML, for example, mathematically.
    /// </summary>
    [MetaClass]
    public partial interface PrimitiveType : DataType
    {
    }
    

    /// <summary>
    /// A Reception is a declaration stating that a Classifier is prepared to react to the receipt of a Signal.
    /// </summary>
    [MetaClass]
    public partial interface Reception : BehavioralFeature
    {
    	/// <summary>
    	/// The Signal that this Reception handles.
    	/// </summary>
    	[Opposite(typeof(Signal), "Reception")]
    	Signal Signal { get; set; }
    	
    }
    

    /// <summary>
    /// A Signal is a specification of a kind of communication between objects in which a reaction is asynchronously triggered in the receiver without a reply.
    /// </summary>
    [MetaClass]
    public partial interface Signal : Classifier
    {
    	/// <summary>
    	/// The attributes owned by the Signal.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Property), "OwningSignal")]
    	[Subsets(typeof(Classifier), "Attribute")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Property> OwnedAttribute { get; }
    	
    }
    

    /// <summary>
    /// An extension is used to indicate that the properties of a metaclass are extended through a stereotype, and gives the ability to flexibly add (and later remove) stereotypes to classes.
    /// </summary>
    [MetaClass]
    public partial interface Extension : Association
    {
    	/// <summary>
    	/// References the end of the extension that is typed by a Stereotype.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ExtensionEnd), "Extension")]
    	[Redefines(typeof(Association), "OwnedEnd")]
    	new ExtensionEnd OwnedEnd { get; set; }
    	
    }
    

    /// <summary>
    /// An extension end is used to tie an extension to a stereotype when extending a metaclass.
    /// The default multiplicity of an extension end is 0..1.
    /// </summary>
    [MetaClass]
    public partial interface ExtensionEnd : Property
    {
    	int MultiplicityElement.Lower
    	{
    		get => this.Lower;
    	}
    	
    	/// <summary>
    	/// References the type of the ExtensionEnd. Note that this association restricts the possible types of an ExtensionEnd to only be Stereotypes.
    	/// </summary>
    	[Opposite(typeof(Stereotype), "ExtensionEnd")]
    	[Redefines(typeof(TypedElement), "Type")]
    	new Stereotype Type { get; set; }
    	
    	int MultiplicityElement.LowerBound()
    	{
    		return this.LowerBound();
    	}
    	
    }
    

    /// <summary>
    /// Physical definition of a graphical image.
    /// </summary>
    [MetaClass]
    public partial interface Image : Element
    {
    	/// <summary>
    	/// This contains the serialization of the image according to the format. The value could represent a bitmap, image such as a GIF file, or drawing &apos;instructions&apos; using a standard such as Scalable Vector Graphic (SVG) (which is XML based).
    	/// </summary>
    	string Content { get; set; }
    	
    	/// <summary>
    	/// This indicates the format of the content, which is how the string content should be interpreted. The following values are reserved: SVG, GIF, PNG, JPG, WMF, EMF, BMP. In addition the prefix &apos;MIME: &apos; is also reserved. This option can be used as an alternative to express the reserved values above, for example &quot;SVG&quot; could instead be expressed as &quot;MIME: image/svg+xml&quot;.
    	/// </summary>
    	string Format { get; set; }
    	
    	/// <summary>
    	/// This contains a location that can be used by a tool to locate the image as an alternative to embedding it in the stereotype.
    	/// </summary>
    	string Location { get; set; }
    	
    }
    

    /// <summary>
    /// A model captures a view of a physical system. It is an abstraction of the physical system, with a certain purpose. This purpose determines what is to be included in the model and what is irrelevant. Thus the model completely describes those aspects of the physical system that are relevant to the purpose of the model, at the appropriate level of detail.
    /// </summary>
    [MetaClass]
    public partial interface Model : Package
    {
    	/// <summary>
    	/// The name of the viewpoint that is expressed by a model (this name may refer to a profile definition).
    	/// </summary>
    	string Viewpoint { get; set; }
    	
    }
    

    /// <summary>
    /// A package can have one or more profile applications to indicate which profiles have been applied. Because a profile is a package, it is possible to apply a profile not only to packages, but also to profiles.
    /// Package specializes TemplateableElement and PackageableElement specializes ParameterableElement to specify that a package can be used as a template and a PackageableElement as a template parameter.
    /// A package is used to group elements, and provides a namespace for the grouped elements.
    /// </summary>
    [MetaClass]
    public partial interface Package : PackageableElement, TemplateableElement, Namespace
    {
    	/// <summary>
    	/// Provides an identifier for the package that can be used for many purposes. A URI is the universally unique identification of the package following the IETF URI specification, RFC 2396 http://www.ietf.org/rfc/rfc2396.txt and it must comply with those syntax rules.
    	/// </summary>
    	string URI { get; set; }
    	
    	/// <summary>
    	/// References the Package that owns this Package.
    	/// </summary>
    	[Opposite(typeof(Package), "NestedPackage")]
    	Package? NestingPackage { get; set; }
    	
    	/// <summary>
    	/// References the PackageMerges that are owned by this Package.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(PackageMerge), "ReceivingPackage")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<PackageMerge> PackageMerge { get; }
    	
    	/// <summary>
    	/// Specifies the packageable elements that are owned by this Package.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(PackageableElement), "OwningPackage")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<PackageableElement> PackagedElement { get; }
    	
    	/// <summary>
    	/// References the ProfileApplications that indicate which profiles have been applied to the Package.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ProfileApplication), "ApplyingPackage")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ProfileApplication> ProfileApplication { get; }
    	
    	bool Element.MustBeOwned()
    	{
    		return this.MustBeOwned();
    	}
    	
    }
    

    /// <summary>
    /// A package merge defines how the contents of one package are extended by the contents of another package.
    /// </summary>
    [MetaClass]
    public partial interface PackageMerge : DirectedRelationship
    {
    	/// <summary>
    	/// References the Package that is to be merged with the receiving package of the PackageMerge.
    	/// </summary>
    	[Opposite(typeof(Package), "PackageMerge")]
    	[Subsets(typeof(DirectedRelationship), "Target")]
    	Package MergedPackage { get; set; }
    	
    	/// <summary>
    	/// References the Package that is being extended with the contents of the merged package of the PackageMerge.
    	/// </summary>
    	[Opposite(typeof(Package), "PackageMerge")]
    	[Subsets(typeof(DirectedRelationship), "Source")]
    	[Subsets(typeof(Element), "Owner")]
    	Package ReceivingPackage { get; set; }
    	
    }
    

    /// <summary>
    /// A profile defines limited extensions to a reference metamodel with the purpose of adapting the metamodel to a specific platform or domain.
    /// </summary>
    [MetaClass]
    public partial interface Profile : Package
    {
    	/// <summary>
    	/// References a metaclass that may be extended.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ElementImport), "Profile")]
    	[Subsets(typeof(Namespace), "ElementImport")]
    	IList<ElementImport> MetaclassReference { get; }
    	
    	/// <summary>
    	/// References a package containing (directly or indirectly) metaclasses that may be extended.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(PackageImport), "Profile")]
    	[Subsets(typeof(Namespace), "PackageImport")]
    	IList<PackageImport> MetamodelReference { get; }
    	
    }
    

    /// <summary>
    /// A profile application is used to show which profiles have been applied to a package.
    /// </summary>
    [MetaClass]
    public partial interface ProfileApplication : DirectedRelationship
    {
    	/// <summary>
    	/// References the Profiles that are applied to a Package through this ProfileApplication.
    	/// </summary>
    	[Opposite(typeof(Profile), "ProfileApplication")]
    	[Subsets(typeof(DirectedRelationship), "Target")]
    	Profile AppliedProfile { get; set; }
    	
    	/// <summary>
    	/// The package that owns the profile application.
    	/// </summary>
    	[Opposite(typeof(Package), "ProfileApplication")]
    	[Subsets(typeof(DirectedRelationship), "Source")]
    	[Subsets(typeof(Element), "Owner")]
    	Package ApplyingPackage { get; set; }
    	
    	/// <summary>
    	/// Specifies that the Profile filtering rules for the metaclasses of the referenced metamodel shall be strictly applied.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsStrict { get; set; }
    	
    }
    

    /// <summary>
    /// A stereotype defines how an existing metaclass may be extended, and enables the use of platform or domain specific terminology or notation in place of, or in addition to, the ones used for the extended metaclass.
    /// </summary>
    [MetaClass]
    public partial interface Stereotype : Class
    {
    	/// <summary>
    	/// Stereotype can change the graphical appearance of the extended model element by using attached icons. When this association is not null, it references the location of the icon content to be displayed within diagrams presenting the extended model elements.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Image), "Stereotype")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Image> Icon { get; }
    	
    }
    

    /// <summary>
    /// An ActionExecutionSpecification is a kind of ExecutionSpecification representing the execution of an Action.
    /// </summary>
    [MetaClass]
    public partial interface ActionExecutionSpecification : ExecutionSpecification
    {
    	/// <summary>
    	/// Action whose execution is occurring.
    	/// </summary>
    	[Opposite(typeof(Action), "ActionExecutionSpecification")]
    	Action Action { get; set; }
    	
    }
    

    /// <summary>
    /// A BehaviorExecutionSpecification is a kind of ExecutionSpecification representing the execution of a Behavior.
    /// </summary>
    [MetaClass]
    public partial interface BehaviorExecutionSpecification : ExecutionSpecification
    {
    	/// <summary>
    	/// Behavior whose execution is occurring.
    	/// </summary>
    	[Opposite(typeof(Behavior), "BehaviorExecutionSpecification")]
    	Behavior? Behavior { get; set; }
    	
    }
    

    /// <summary>
    /// A CombinedFragment defines an expression of InteractionFragments. A CombinedFragment is defined by an interaction operator and corresponding InteractionOperands. Through the use of CombinedFragments the user will be able to describe a number of traces in a compact and concise manner.
    /// </summary>
    [MetaClass]
    public partial interface CombinedFragment : InteractionFragment
    {
    	/// <summary>
    	/// Specifies the gates that form the interface between this CombinedFragment and its surroundings
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Gate), "CombinedFragment")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Gate> CfragmentGate { get; }
    	
    	/// <summary>
    	/// Specifies the operation which defines the semantics of this combination of InteractionFragments.
    	/// </summary>
    	[DefaultValue(InteractionOperatorKind.Seq)]
    	InteractionOperatorKind InteractionOperator { get; set; }
    	
    	/// <summary>
    	/// The set of operands of the combined fragment.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InteractionOperand), "CombinedFragment")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<InteractionOperand> Operand { get; }
    	
    }
    

    /// <summary>
    /// A ConsiderIgnoreFragment is a kind of CombinedFragment that is used for the consider and ignore cases, which require lists of pertinent Messages to be specified.
    /// </summary>
    [MetaClass]
    public partial interface ConsiderIgnoreFragment : CombinedFragment
    {
    	/// <summary>
    	/// The set of messages that apply to this fragment.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(NamedElement), "ConsiderIgnoreFragment")]
    	IList<NamedElement> Message { get; }
    	
    }
    

    /// <summary>
    /// A Continuation is a syntactic way to define continuations of different branches of an alternative CombinedFragment. Continuations are intuitively similar to labels representing intermediate points in a flow of control.
    /// </summary>
    [MetaClass]
    public partial interface Continuation : InteractionFragment
    {
    	/// <summary>
    	/// True: when the Continuation is at the end of the enclosing InteractionFragment and False when it is in the beginning.
    	/// </summary>
    	[DefaultValue(true)]
    	bool Setting { get; set; }
    	
    }
    

    /// <summary>
    /// A DestructionOccurenceSpecification models the destruction of an object.
    /// </summary>
    [MetaClass]
    public partial interface DestructionOccurrenceSpecification : MessageOccurrenceSpecification
    {
    }
    

    /// <summary>
    /// An ExecutionOccurrenceSpecification represents moments in time at which Actions or Behaviors start or finish.
    /// </summary>
    [MetaClass]
    public partial interface ExecutionOccurrenceSpecification : OccurrenceSpecification
    {
    	/// <summary>
    	/// References the execution specification describing the execution that is started or finished at this execution event.
    	/// </summary>
    	[Opposite(typeof(ExecutionSpecification), "ExecutionOccurrenceSpecification")]
    	ExecutionSpecification Execution { get; set; }
    	
    }
    

    /// <summary>
    /// An ExecutionSpecification is a specification of the execution of a unit of Behavior or Action within the Lifeline. The duration of an ExecutionSpecification is represented by two OccurrenceSpecifications, the start OccurrenceSpecification and the finish OccurrenceSpecification.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface ExecutionSpecification : InteractionFragment
    {
    	/// <summary>
    	/// References the OccurrenceSpecification that designates the finish of the Action or Behavior.
    	/// </summary>
    	[Opposite(typeof(OccurrenceSpecification), "ExecutionSpecification")]
    	OccurrenceSpecification Finish { get; set; }
    	
    	/// <summary>
    	/// References the OccurrenceSpecification that designates the start of the Action or Behavior.
    	/// </summary>
    	[Opposite(typeof(OccurrenceSpecification), "ExecutionSpecification")]
    	OccurrenceSpecification Start { get; set; }
    	
    }
    

    /// <summary>
    /// A Gate is a MessageEnd which serves as a connection point for relating a Message which has a MessageEnd (sendEvent / receiveEvent) outside an InteractionFragment with another Message which has a MessageEnd (receiveEvent / sendEvent)  inside that InteractionFragment.
    /// </summary>
    [MetaClass]
    public partial interface Gate : MessageEnd
    {
    	bool NamedElement.IsDistinguishableFrom(NamedElement n, Namespace ns)
    	{
    		return this.IsDistinguishableFrom(n, ns);
    	}
    	
    }
    

    /// <summary>
    /// A GeneralOrdering represents a binary relation between two OccurrenceSpecifications, to describe that one OccurrenceSpecification must occur before the other in a valid trace. This mechanism provides the ability to define partial orders of OccurrenceSpecifications that may otherwise not have a specified order.
    /// </summary>
    [MetaClass]
    public partial interface GeneralOrdering : NamedElement
    {
    	/// <summary>
    	/// The OccurrenceSpecification referenced comes after the OccurrenceSpecification referenced by before.
    	/// </summary>
    	[Opposite(typeof(OccurrenceSpecification), "ToBefore")]
    	OccurrenceSpecification After { get; set; }
    	
    	/// <summary>
    	/// The OccurrenceSpecification referenced comes before the OccurrenceSpecification referenced by after.
    	/// </summary>
    	[Opposite(typeof(OccurrenceSpecification), "ToAfter")]
    	OccurrenceSpecification Before { get; set; }
    	
    }
    

    /// <summary>
    /// An Interaction is a unit of Behavior that focuses on the observable exchange of information between connectable elements.
    /// </summary>
    [MetaClass]
    public partial interface Interaction : InteractionFragment, Behavior
    {
    	/// <summary>
    	/// Actions owned by the Interaction.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Action), "Interaction")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Action> Action { get; }
    	
    	/// <summary>
    	/// Specifies the gates that form the message interface between this Interaction and any InteractionUses which reference it.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Gate), "Interaction")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Gate> FormalGate { get; }
    	
    	/// <summary>
    	/// The ordered set of fragments in the Interaction.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InteractionFragment), "EnclosingInteraction")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<InteractionFragment> Fragment { get; }
    	
    	/// <summary>
    	/// Specifies the participants in this Interaction.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Lifeline), "Interaction")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Lifeline> Lifeline { get; }
    	
    	/// <summary>
    	/// The Messages contained in this Interaction.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Message), "Interaction")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Message> Message { get; }
    	
    }
    

    /// <summary>
    /// An InteractionConstraint is a Boolean expression that guards an operand in a CombinedFragment.
    /// </summary>
    [MetaClass]
    public partial interface InteractionConstraint : Constraint
    {
    	/// <summary>
    	/// The maximum number of iterations of a loop
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "InteractionConstraint")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? Maxint { get; set; }
    	
    	/// <summary>
    	/// The minimum number of iterations of a loop
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "InteractionConstraint")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? Minint { get; set; }
    	
    }
    

    /// <summary>
    /// InteractionFragment is an abstract notion of the most general interaction unit. An InteractionFragment is a piece of an Interaction. Each InteractionFragment is conceptually like an Interaction by itself.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface InteractionFragment : NamedElement
    {
    	/// <summary>
    	/// References the Lifelines that the InteractionFragment involves.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Lifeline), "CoveredBy")]
    	IList<Lifeline> Covered { get; }
    	
    	/// <summary>
    	/// The Interaction enclosing this InteractionFragment.
    	/// </summary>
    	[Opposite(typeof(Interaction), "Fragment")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	Interaction? EnclosingInteraction { get; set; }
    	
    	/// <summary>
    	/// The operand enclosing this InteractionFragment (they may nest recursively).
    	/// </summary>
    	[Opposite(typeof(InteractionOperand), "Fragment")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	InteractionOperand? EnclosingOperand { get; set; }
    	
    	/// <summary>
    	/// The general ordering relationships contained in this fragment.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(GeneralOrdering), "InteractionFragment")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<GeneralOrdering> GeneralOrdering { get; }
    	
    }
    

    /// <summary>
    /// An InteractionOperand is contained in a CombinedFragment. An InteractionOperand represents one operand of the expression given by the enclosing CombinedFragment.
    /// </summary>
    [MetaClass]
    public partial interface InteractionOperand : InteractionFragment, Namespace
    {
    	/// <summary>
    	/// The fragments of the operand.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InteractionFragment), "EnclosingOperand")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<InteractionFragment> Fragment { get; }
    	
    	/// <summary>
    	/// Constraint of the operand.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InteractionConstraint), "InteractionOperand")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	InteractionConstraint? Guard { get; set; }
    	
    }
    

    /// <summary>
    /// An InteractionUse refers to an Interaction. The InteractionUse is a shorthand for copying the contents of the referenced Interaction where the InteractionUse is. To be accurate the copying must take into account substituting parameters with arguments and connect the formal Gates with the actual ones.
    /// </summary>
    [MetaClass]
    public partial interface InteractionUse : InteractionFragment
    {
    	/// <summary>
    	/// The actual gates of the InteractionUse.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Gate), "InteractionUse")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Gate> ActualGate { get; }
    	
    	/// <summary>
    	/// The actual arguments of the Interaction.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "InteractionUse")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ValueSpecification> Argument { get; }
    	
    	/// <summary>
    	/// Refers to the Interaction that defines its meaning.
    	/// </summary>
    	[Opposite(typeof(Interaction), "InteractionUse")]
    	Interaction RefersTo { get; set; }
    	
    	/// <summary>
    	/// The value of the executed Interaction.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "InteractionUse")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? ReturnValue { get; set; }
    	
    	/// <summary>
    	/// The recipient of the return value.
    	/// </summary>
    	[Opposite(typeof(Property), "InteractionUse")]
    	Property? ReturnValueRecipient { get; set; }
    	
    }
    

    /// <summary>
    /// A Lifeline represents an individual participant in the Interaction. While parts and structural features may have multiplicity greater than 1, Lifelines represent only one interacting entity.
    /// </summary>
    [MetaClass]
    public partial interface Lifeline : NamedElement
    {
    	/// <summary>
    	/// References the InteractionFragments in which this Lifeline takes part.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(InteractionFragment), "Covered")]
    	IList<InteractionFragment> CoveredBy { get; }
    	
    	/// <summary>
    	/// References the Interaction that represents the decomposition.
    	/// </summary>
    	[Opposite(typeof(PartDecomposition), "Lifeline")]
    	PartDecomposition? DecomposedAs { get; set; }
    	
    	/// <summary>
    	/// References the Interaction enclosing this Lifeline.
    	/// </summary>
    	[Opposite(typeof(Interaction), "Lifeline")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	Interaction Interaction { get; set; }
    	
    	/// <summary>
    	/// References the ConnectableElement within the classifier that contains the enclosing interaction.
    	/// </summary>
    	[Opposite(typeof(ConnectableElement), "Lifeline")]
    	ConnectableElement? Represents { get; set; }
    	
    	/// <summary>
    	/// If the referenced ConnectableElement is multivalued, then this specifies the specific individual part within that set.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "Lifeline")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? Selector { get; set; }
    	
    }
    

    /// <summary>
    /// A Message defines a particular communication between Lifelines of an Interaction.
    /// </summary>
    [MetaClass]
    public partial interface Message : NamedElement
    {
    	/// <summary>
    	/// The arguments of the Message.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "Message")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ValueSpecification> Argument { get; }
    	
    	/// <summary>
    	/// The Connector on which this Message is sent.
    	/// </summary>
    	[Opposite(typeof(Connector), "Message")]
    	Connector? Connector { get; set; }
    	
    	/// <summary>
    	/// The enclosing Interaction owning the Message.
    	/// </summary>
    	[Opposite(typeof(Interaction), "Message")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	Interaction Interaction { get; set; }
    	
    	/// <summary>
    	/// The sort of communication reflected by the Message.
    	/// </summary>
    	[DefaultValue(MessageSort.SynchCall)]
    	MessageSort MessageSort { get; set; }
    	
    	/// <summary>
    	/// References the Receiving of the Message.
    	/// </summary>
    	[Opposite(typeof(MessageEnd), "EndMessage")]
    	MessageEnd? ReceiveEvent { get; set; }
    	
    	/// <summary>
    	/// References the Sending of the Message.
    	/// </summary>
    	[Opposite(typeof(MessageEnd), "EndMessage")]
    	MessageEnd? SendEvent { get; set; }
    	
    	/// <summary>
    	/// The signature of the Message is the specification of its content. It refers either an Operation or a Signal.
    	/// </summary>
    	[Opposite(typeof(NamedElement), "Message")]
    	NamedElement? Signature { get; set; }
    	
    	bool NamedElement.IsDistinguishableFrom(NamedElement n, Namespace ns)
    	{
    		return this.IsDistinguishableFrom(n, ns);
    	}
    	
    }
    

    /// <summary>
    /// MessageEnd is an abstract specialization of NamedElement that represents what can occur at the end of a Message.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface MessageEnd : NamedElement
    {
    	/// <summary>
    	/// References a Message.
    	/// </summary>
    	[Opposite(typeof(Message), "MessageEnd")]
    	Message? Message { get; set; }
    	
    }
    

    /// <summary>
    /// A MessageOccurrenceSpecification specifies the occurrence of Message events, such as sending and receiving of Signals or invoking or receiving of Operation calls. A MessageOccurrenceSpecification is a kind of MessageEnd. Messages are generated either by synchronous Operation calls or asynchronous Signal sends. They are received by the execution of corresponding AcceptEventActions.
    /// </summary>
    [MetaClass]
    public partial interface MessageOccurrenceSpecification : MessageEnd, OccurrenceSpecification
    {
    }
    

    /// <summary>
    /// An OccurrenceSpecification is the basic semantic unit of Interactions. The sequences of occurrences specified by them are the meanings of Interactions.
    /// </summary>
    [MetaClass]
    public partial interface OccurrenceSpecification : InteractionFragment
    {
    	/// <summary>
    	/// References the Lifeline on which the OccurrenceSpecification appears.
    	/// </summary>
    	[Opposite(typeof(Lifeline), "Events")]
    	[Redefines(typeof(InteractionFragment), "Covered")]
    	new Lifeline Covered { get; set; }
    	
    	/// <summary>
    	/// References the GeneralOrderings that specify EventOcurrences that must occur after this OccurrenceSpecification.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(GeneralOrdering), "Before")]
    	IList<GeneralOrdering> ToAfter { get; }
    	
    	/// <summary>
    	/// References the GeneralOrderings that specify EventOcurrences that must occur before this OccurrenceSpecification.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(GeneralOrdering), "After")]
    	IList<GeneralOrdering> ToBefore { get; }
    	
    }
    

    /// <summary>
    /// A PartDecomposition is a description of the internal Interactions of one Lifeline relative to an Interaction.
    /// </summary>
    [MetaClass]
    public partial interface PartDecomposition : InteractionUse
    {
    }
    

    /// <summary>
    /// A StateInvariant is a runtime constraint on the participants of the Interaction. It may be used to specify a variety of different kinds of Constraints, such as values of Attributes or Variables, internal or external States, and so on. A StateInvariant is an InteractionFragment and it is placed on a Lifeline.
    /// </summary>
    [MetaClass]
    public partial interface StateInvariant : InteractionFragment
    {
    	/// <summary>
    	/// References the Lifeline on which the StateInvariant appears.
    	/// </summary>
    	[Opposite(typeof(Lifeline), "StateInvariant")]
    	[Redefines(typeof(InteractionFragment), "Covered")]
    	new Lifeline Covered { get; set; }
    	
    	/// <summary>
    	/// A Constraint that should hold at runtime for this StateInvariant.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Constraint), "StateInvariant")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	Constraint Invariant { get; set; }
    	
    }
    

    /// <summary>
    /// InformationFlows describe circulation of information through a system in a general manner. They do not specify the nature of the information, mechanisms by which it is conveyed, sequences of exchange or any control conditions. During more detailed modeling, representation and realization links may be added to specify which model elements implement an InformationFlow and to show how information is conveyed.  InformationFlows require some kind of “information channel” for unidirectional transmission of information items from sources to targets.  They specify the information channel’s realizations, if any, and identify the information that flows along them.  Information moving along the information channel may be represented by abstract InformationItems and by concrete Classifiers.
    /// </summary>
    [MetaClass]
    public partial interface InformationFlow : DirectedRelationship, PackageableElement
    {
    	/// <summary>
    	/// Specifies the information items that may circulate on this information flow.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Classifier), "ConveyingFlow")]
    	IList<Classifier> Conveyed { get; }
    	
    	/// <summary>
    	/// Defines from which source the conveyed InformationItems are initiated.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(NamedElement), "InformationFlow")]
    	[Subsets(typeof(DirectedRelationship), "Source")]
    	IList<NamedElement> InformationSource { get; }
    	
    	/// <summary>
    	/// Defines to which target the conveyed InformationItems are directed.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(NamedElement), "InformationFlow")]
    	[Subsets(typeof(DirectedRelationship), "Target")]
    	IList<NamedElement> InformationTarget { get; }
    	
    	/// <summary>
    	/// Determines which Relationship will realize the specified flow.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Relationship), "Abstraction")]
    	IList<Relationship> Realization { get; }
    	
    	/// <summary>
    	/// Determines which ActivityEdges will realize the specified flow.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ActivityEdge), "InformationFlow")]
    	IList<ActivityEdge> RealizingActivityEdge { get; }
    	
    	/// <summary>
    	/// Determines which Connectors will realize the specified flow.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Connector), "InformationFlow")]
    	IList<Connector> RealizingConnector { get; }
    	
    	/// <summary>
    	/// Determines which Messages will realize the specified flow.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Message), "InformationFlow")]
    	IList<Message> RealizingMessage { get; }
    	
    }
    

    /// <summary>
    /// InformationItems represent many kinds of information that can flow from sources to targets in very abstract ways.  They represent the kinds of information that may move within a system, but do not elaborate details of the transferred information.  Details of transferred information are the province of other Classifiers that may ultimately define InformationItems.  Consequently, InformationItems cannot be instantiated and do not themselves have features, generalizations, or associations. An important use of InformationItems is to represent information during early design stages, possibly before the detailed modeling decisions that will ultimately define them have been made. Another purpose of InformationItems is to abstract portions of complex models in less precise, but perhaps more general and communicable, ways. 
    /// </summary>
    [MetaClass]
    public partial interface InformationItem : Classifier
    {
    	/// <summary>
    	/// Determines the classifiers that will specify the structure and nature of the information. An information item represents all its represented classifiers.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Classifier), "Representation")]
    	IList<Classifier> Represented { get; }
    	
    }
    

    /// <summary>
    /// An artifact is the specification of a physical piece of information that is used or produced by a software development process, or by deployment and operation of a system. Examples of artifacts include model files, source files, scripts, and binary executable files, a table in a database system, a development deliverable, or a word-processing document, a mail message.
    /// An artifact is the source of a deployment to a node.
    /// </summary>
    [MetaClass]
    public partial interface Artifact : Classifier, DeployedArtifact
    {
    	/// <summary>
    	/// A concrete name that is used to refer to the Artifact in a physical context. Example: file system name, universal resource locator.
    	/// </summary>
    	string FileName { get; set; }
    	
    	/// <summary>
    	/// The set of model elements that are manifested in the Artifact. That is, these model elements are utilized in the construction (or generation) of the artifact.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Manifestation), "Artifact")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	[Subsets(typeof(NamedElement), "ClientDependency")]
    	IList<Manifestation> Manifestation { get; }
    	
    	/// <summary>
    	/// The Artifacts that are defined (nested) within the Artifact. The association is a specialization of the ownedMember association from Namespace to NamedElement.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Artifact), "Artifact")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Artifact> NestedArtifact { get; }
    	
    	/// <summary>
    	/// The attributes or association ends defined for the Artifact. The association is a specialization of the ownedMember association.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Property), "Artifact")]
    	[Subsets(typeof(Classifier), "Attribute")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Property> OwnedAttribute { get; }
    	
    	/// <summary>
    	/// The Operations defined for the Artifact. The association is a specialization of the ownedMember association.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Operation), "Artifact")]
    	[Subsets(typeof(Classifier), "Feature")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Operation> OwnedOperation { get; }
    	
    }
    

    /// <summary>
    /// A communication path is an association between two deployment targets, through which they are able to exchange signals and messages.
    /// </summary>
    [MetaClass]
    public partial interface CommunicationPath : Association
    {
    }
    

    /// <summary>
    /// A deployed artifact is an artifact or artifact instance that has been deployed to a deployment target.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface DeployedArtifact : NamedElement
    {
    }
    

    /// <summary>
    /// A deployment is the allocation of an artifact or artifact instance to a deployment target.
    /// A component deployment is the deployment of one or more artifacts or artifact instances to a deployment target, optionally parameterized by a deployment specification. Examples are executables and configuration files.
    /// </summary>
    [MetaClass]
    public partial interface Deployment : Dependency
    {
    	/// <summary>
    	/// The specification of properties that parameterize the deployment and execution of one or more Artifacts.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(DeploymentSpecification), "Deployment")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<DeploymentSpecification> Configuration { get; }
    	
    	/// <summary>
    	/// The Artifacts that are deployed onto a Node. This association specializes the supplier association.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(DeployedArtifact), "DeploymentForArtifact")]
    	[Subsets(typeof(Dependency), "Supplier")]
    	IList<DeployedArtifact> DeployedArtifact { get; }
    	
    	/// <summary>
    	/// The DeployedTarget which is the target of a Deployment.
    	/// </summary>
    	[Opposite(typeof(DeploymentTarget), "Deployment")]
    	[Subsets(typeof(Dependency), "Client")]
    	[Subsets(typeof(Element), "Owner")]
    	DeploymentTarget Location { get; set; }
    	
    }
    

    /// <summary>
    /// A deployment specification specifies a set of properties that determine execution parameters of a component artifact that is deployed on a node. A deployment specification can be aimed at a specific type of container. An artifact that reifies or implements deployment specification properties is a deployment descriptor.
    /// </summary>
    [MetaClass]
    public partial interface DeploymentSpecification : Artifact
    {
    	/// <summary>
    	/// The deployment with which the DeploymentSpecification is associated.
    	/// </summary>
    	[Opposite(typeof(Deployment), "Configuration")]
    	[Subsets(typeof(Element), "Owner")]
    	Deployment? Deployment { get; set; }
    	
    	/// <summary>
    	/// The location where an Artifact is deployed onto a Node. This is typically a &apos;directory&apos; or &apos;memory address.&apos;
    	/// </summary>
    	string DeploymentLocation { get; set; }
    	
    	/// <summary>
    	/// The location where a component Artifact executes. This may be a local or remote location.
    	/// </summary>
    	string ExecutionLocation { get; set; }
    	
    }
    

    /// <summary>
    /// A deployment target is the location for a deployed artifact.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface DeploymentTarget : NamedElement
    {
    	/// <summary>
    	/// The set of Deployments for a DeploymentTarget.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Deployment), "Location")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	[Subsets(typeof(NamedElement), "ClientDependency")]
    	IList<Deployment> Deployment { get; }
    	
    }
    

    /// <summary>
    /// A device is a physical computational resource with processing capability upon which artifacts may be deployed for execution. Devices may be complex (i.e., they may consist of other devices).
    /// </summary>
    [MetaClass]
    public partial interface Device : Node
    {
    }
    

    /// <summary>
    /// An execution environment is a node that offers an execution environment for specific types of components that are deployed on it in the form of executable artifacts.
    /// </summary>
    [MetaClass]
    public partial interface ExecutionEnvironment : Node
    {
    }
    

    /// <summary>
    /// A manifestation is the concrete physical rendering of one or more model elements by an artifact.
    /// </summary>
    [MetaClass]
    public partial interface Manifestation : Abstraction
    {
    	/// <summary>
    	/// The model element that is utilized in the manifestation in an Artifact.
    	/// </summary>
    	[Opposite(typeof(PackageableElement), "Manifestation")]
    	[Subsets(typeof(Dependency), "Supplier")]
    	PackageableElement UtilizedElement { get; set; }
    	
    }
    

    /// <summary>
    /// A Node is computational resource upon which artifacts may be deployed for execution. Nodes can be interconnected through communication paths to define network structures.
    /// </summary>
    [MetaClass]
    public partial interface Node : Class, DeploymentTarget
    {
    	/// <summary>
    	/// The Nodes that are defined (nested) within the Node.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Node), "Node")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Node> NestedNode { get; }
    	
    }
    

    /// <summary>
    /// An Abstraction is a Relationship that relates two Elements or sets of Elements that represent the same concept at different levels of abstraction or from different viewpoints.
    /// </summary>
    [MetaClass]
    public partial interface Abstraction : Dependency
    {
    	/// <summary>
    	/// An OpaqueExpression that states the abstraction relationship between the supplier(s) and the client(s). In some cases, such as derivation, it is usually formal and unidirectional; in other cases, such as trace, it is usually informal and bidirectional. The mapping expression is optional and may be omitted if the precise relationship between the Elements is not specified.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OpaqueExpression), "Abstraction")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	OpaqueExpression? Mapping { get; set; }
    	
    }
    

    /// <summary>
    /// A Comment is a textual annotation that can be attached to a set of Elements.
    /// </summary>
    [MetaClass]
    public partial interface Comment : Element
    {
    	/// <summary>
    	/// References the Element(s) being commented.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Element), "Comment")]
    	IList<Element> AnnotatedElement { get; }
    	
    	/// <summary>
    	/// Specifies a string that is the comment.
    	/// </summary>
    	string Body { get; set; }
    	
    }
    

    /// <summary>
    /// A Constraint is a condition or restriction expressed in natural language text or in a machine readable language for the purpose of declaring some of the semantics of an Element or set of Elements.
    /// </summary>
    [MetaClass]
    public partial interface Constraint : PackageableElement
    {
    	/// <summary>
    	/// The ordered set of Elements referenced by this Constraint.
    	/// </summary>
    	[Opposite(typeof(Element), "Constraint")]
    	IList<Element> ConstrainedElement { get; }
    	
    	/// <summary>
    	/// Specifies the Namespace that owns the Constraint.
    	/// </summary>
    	[Opposite(typeof(Namespace), "OwnedRule")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	Namespace? Context { get; set; }
    	
    	/// <summary>
    	/// A condition that must be true when evaluated in order for the Constraint to be satisfied.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "OwningConstraint")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification Specification { get; set; }
    	
    }
    

    /// <summary>
    /// A Dependency is a Relationship that signifies that a single model Element or a set of model Elements requires other model Elements for their specification or implementation. This means that the complete semantics of the client Element(s) are either semantically or structurally dependent on the definition of the supplier Element(s).
    /// </summary>
    [MetaClass]
    public partial interface Dependency : DirectedRelationship, PackageableElement
    {
    	/// <summary>
    	/// The Element(s) dependent on the supplier Element(s). In some cases (such as a trace Abstraction) the assignment of direction (that is, the designation of the client Element) is at the discretion of the modeler and is a stipulation.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(NamedElement), "ClientDependency")]
    	[Subsets(typeof(DirectedRelationship), "Source")]
    	IList<NamedElement> Client { get; }
    	
    	/// <summary>
    	/// The Element(s) on which the client Element(s) depend in some respect. The modeler may stipulate a sense of Dependency direction suitable for their domain.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(NamedElement), "SupplierDependency")]
    	[Subsets(typeof(DirectedRelationship), "Target")]
    	IList<NamedElement> Supplier { get; }
    	
    }
    

    /// <summary>
    /// A DirectedRelationship represents a relationship between a collection of source model Elements and a collection of target model Elements.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface DirectedRelationship : Relationship
    {
    	/// <summary>
    	/// Specifies the source Element(s) of the DirectedRelationship.
    	/// </summary>
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Element), "DirectedRelationship")]
    	[Subsets(typeof(Relationship), "RelatedElement")]
    	IList<Element> Source { get; }
    	
    	/// <summary>
    	/// Specifies the target Element(s) of the DirectedRelationship.
    	/// </summary>
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Element), "DirectedRelationship")]
    	[Subsets(typeof(Relationship), "RelatedElement")]
    	IList<Element> Target { get; }
    	
    }
    

    /// <summary>
    /// An Element is a constituent of a model. As such, it has the capability of owning other Elements.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface Element
    {
    	/// <summary>
    	/// The Comments owned by this Element.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Comment), "OwningElement")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Comment> OwnedComment { get; }
    	
    	/// <summary>
    	/// The Elements owned by this Element.
    	/// </summary>
    	[Containment]
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Element), "Owner")]
    	IList<Element> OwnedElement { get; }
    	
    	/// <summary>
    	/// The Element that owns this Element.
    	/// </summary>
    	[DerivedUnion]
    	[ReadOnly]
    	[Opposite(typeof(Element), "OwnedElement")]
    	Element? Owner { get; }
    	
    }
    

    /// <summary>
    /// An ElementImport identifies a NamedElement in a Namespace other than the one that owns that NamedElement and allows the NamedElement to be referenced using an unqualified name in the Namespace owning the ElementImport.
    /// </summary>
    [MetaClass]
    public partial interface ElementImport : DirectedRelationship
    {
    	/// <summary>
    	/// Specifies the name that should be added to the importing Namespace in lieu of the name of the imported PackagableElement. The alias must not clash with any other member in the importing Namespace. By default, no alias is used.
    	/// </summary>
    	string Alias { get; set; }
    	
    	/// <summary>
    	/// Specifies the PackageableElement whose name is to be added to a Namespace.
    	/// </summary>
    	[Opposite(typeof(PackageableElement), "Import")]
    	[Subsets(typeof(DirectedRelationship), "Target")]
    	PackageableElement ImportedElement { get; set; }
    	
    	/// <summary>
    	/// Specifies the Namespace that imports a PackageableElement from another Namespace.
    	/// </summary>
    	[Opposite(typeof(Namespace), "ElementImport")]
    	[Subsets(typeof(DirectedRelationship), "Source")]
    	[Subsets(typeof(Element), "Owner")]
    	Namespace ImportingNamespace { get; set; }
    	
    	/// <summary>
    	/// Specifies the visibility of the imported PackageableElement within the importingNamespace, i.e., whether the  importedElement will in turn be visible to other Namespaces. If the ElementImport is public, the importedElement will be visible outside the importingNamespace while, if the ElementImport is private, it will not.
    	/// </summary>
    	[DefaultValue(VisibilityKind.Public)]
    	VisibilityKind Visibility { get; set; }
    	
    }
    

    /// <summary>
    /// A multiplicity is a definition of an inclusive interval of non-negative integers beginning with a lower bound and ending with a (possibly infinite) upper bound. A MultiplicityElement embeds this information to specify the allowable cardinalities for an instantiation of the Element.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface MultiplicityElement : Element
    {
    	/// <summary>
    	/// For a multivalued multiplicity, this attribute specifies whether the values in an instantiation of this MultiplicityElement are sequentially ordered.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsOrdered { get; set; }
    	
    	/// <summary>
    	/// For a multivalued multiplicity, this attributes specifies whether the values in an instantiation of this MultiplicityElement are unique.
    	/// </summary>
    	[DefaultValue(true)]
    	bool IsUnique { get; set; }
    	
    	/// <summary>
    	/// The specification of the lower bound for this multiplicity.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "OwningLower")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? LowerValue { get; set; }
    	
    	/// <summary>
    	/// The specification of the upper bound for this multiplicity.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "OwningUpper")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? UpperValue { get; set; }
    	
    }
    

    /// <summary>
    /// A NamedElement is an Element in a model that may have a name. The name may be given directly and/or via the use of a StringExpression.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface NamedElement : Element
    {
    	/// <summary>
    	/// The name of the NamedElement.
    	/// </summary>
    	string Name { get; set; }
    	
    	/// <summary>
    	/// The StringExpression used to define the name of this NamedElement.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(StringExpression), "NamedElement")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	StringExpression? NameExpression { get; set; }
    	
    	/// <summary>
    	/// Specifies the Namespace that owns the NamedElement.
    	/// </summary>
    	[DerivedUnion]
    	[ReadOnly]
    	[Opposite(typeof(Namespace), "OwnedMember")]
    	[Subsets(typeof(Element), "Owner")]
    	Namespace? Namespace { get; }
    	
    	/// <summary>
    	/// Determines whether and how the NamedElement is visible outside its owning Namespace.
    	/// </summary>
    	VisibilityKind? Visibility { get; set; }
    	
    }
    

    /// <summary>
    /// A Namespace is an Element in a model that owns and/or imports a set of NamedElements that can be identified by name.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface Namespace : NamedElement
    {
    	/// <summary>
    	/// References the ElementImports owned by the Namespace.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ElementImport), "ImportingNamespace")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ElementImport> ElementImport { get; }
    	
    	/// <summary>
    	/// A collection of NamedElements identifiable within the Namespace, either by being owned or by being introduced by importing or inheritance.
    	/// </summary>
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(NamedElement), "MemberNamespace")]
    	IList<NamedElement> Member { get; }
    	
    	/// <summary>
    	/// A collection of NamedElements owned by the Namespace.
    	/// </summary>
    	[Containment]
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(NamedElement), "Namespace")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	[Subsets(typeof(Namespace), "Member")]
    	IList<NamedElement> OwnedMember { get; }
    	
    	/// <summary>
    	/// Specifies a set of Constraints owned by this Namespace.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Constraint), "Context")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Constraint> OwnedRule { get; }
    	
    	/// <summary>
    	/// References the PackageImports owned by the Namespace.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(PackageImport), "ImportingNamespace")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<PackageImport> PackageImport { get; }
    	
    }
    

    /// <summary>
    /// A PackageableElement is a NamedElement that may be owned directly by a Package. A PackageableElement is also able to serve as the parameteredElement of a TemplateParameter.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface PackageableElement : ParameterableElement, NamedElement
    {
    	/// <summary>
    	/// A PackageableElement must have a visibility specified if it is owned by a Namespace. The default visibility is public.
    	/// </summary>
    	[Redefines(typeof(NamedElement), "Visibility")]
    	[DefaultValue(VisibilityKind.Public)]
    	new VisibilityKind? Visibility { get; set; }
    	
    }
    

    /// <summary>
    /// A PackageImport is a Relationship that imports all the non-private members of a Package into the Namespace owning the PackageImport, so that those Elements may be referred to by their unqualified names in the importingNamespace.
    /// </summary>
    [MetaClass]
    public partial interface PackageImport : DirectedRelationship
    {
    	/// <summary>
    	/// Specifies the Package whose members are imported into a Namespace.
    	/// </summary>
    	[Opposite(typeof(Package), "PackageImport")]
    	[Subsets(typeof(DirectedRelationship), "Target")]
    	Package ImportedPackage { get; set; }
    	
    	/// <summary>
    	/// Specifies the Namespace that imports the members from a Package.
    	/// </summary>
    	[Opposite(typeof(Namespace), "PackageImport")]
    	[Subsets(typeof(DirectedRelationship), "Source")]
    	[Subsets(typeof(Element), "Owner")]
    	Namespace ImportingNamespace { get; set; }
    	
    	/// <summary>
    	/// Specifies the visibility of the imported PackageableElements within the importingNamespace, i.e., whether imported Elements will in turn be visible to other Namespaces. If the PackageImport is public, the imported Elements will be visible outside the importingNamespace, while, if the PackageImport is private, they will not.
    	/// </summary>
    	[DefaultValue(VisibilityKind.Public)]
    	VisibilityKind Visibility { get; set; }
    	
    }
    

    /// <summary>
    /// A ParameterableElement is an Element that can be exposed as a formal TemplateParameter for a template, or specified as an actual parameter in a binding of a template.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface ParameterableElement : Element
    {
    	/// <summary>
    	/// The formal TemplateParameter that owns this ParameterableElement.
    	/// </summary>
    	[Opposite(typeof(TemplateParameter), "OwnedParameteredElement")]
    	[Subsets(typeof(Element), "Owner")]
    	[Subsets(typeof(ParameterableElement), "TemplateParameter")]
    	TemplateParameter? OwningTemplateParameter { get; set; }
    	
    	/// <summary>
    	/// The TemplateParameter that exposes this ParameterableElement as a formal parameter.
    	/// </summary>
    	[Opposite(typeof(TemplateParameter), "ParameteredElement")]
    	TemplateParameter? TemplateParameter { get; set; }
    	
    }
    

    /// <summary>
    /// Realization is a specialized Abstraction relationship between two sets of model Elements, one representing a specification (the supplier) and the other represents an implementation of the latter (the client). Realization can be used to model stepwise refinement, optimizations, transformations, templates, model synthesis, framework composition, etc.
    /// </summary>
    [MetaClass]
    public partial interface Realization : Abstraction
    {
    }
    

    /// <summary>
    /// Relationship is an abstract concept that specifies some kind of relationship between Elements.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface Relationship : Element
    {
    	/// <summary>
    	/// Specifies the elements related by the Relationship.
    	/// </summary>
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Element), "Relationship")]
    	IList<Element> RelatedElement { get; }
    	
    }
    

    /// <summary>
    /// A TemplateableElement is an Element that can optionally be defined as a template and bound to other templates.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface TemplateableElement : Element
    {
    	/// <summary>
    	/// The optional TemplateSignature specifying the formal TemplateParameters for this TemplateableElement. If a TemplateableElement has a TemplateSignature, then it is a template.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(TemplateSignature), "Template")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	TemplateSignature? OwnedTemplateSignature { get; set; }
    	
    	/// <summary>
    	/// The optional TemplateBindings from this TemplateableElement to one or more templates.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(TemplateBinding), "BoundElement")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<TemplateBinding> TemplateBinding { get; }
    	
    }
    

    /// <summary>
    /// A TemplateBinding is a DirectedRelationship between a TemplateableElement and a template. A TemplateBinding specifies the TemplateParameterSubstitutions of actual parameters for the formal parameters of the template.
    /// </summary>
    [MetaClass]
    public partial interface TemplateBinding : DirectedRelationship
    {
    	/// <summary>
    	/// The TemplateableElement that is bound by this TemplateBinding.
    	/// </summary>
    	[Opposite(typeof(TemplateableElement), "TemplateBinding")]
    	[Subsets(typeof(DirectedRelationship), "Source")]
    	[Subsets(typeof(Element), "Owner")]
    	TemplateableElement BoundElement { get; set; }
    	
    	/// <summary>
    	/// The TemplateParameterSubstitutions owned by this TemplateBinding.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(TemplateParameterSubstitution), "TemplateBinding")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<TemplateParameterSubstitution> ParameterSubstitution { get; }
    	
    	/// <summary>
    	/// The TemplateSignature for the template that is the target of this TemplateBinding.
    	/// </summary>
    	[Opposite(typeof(TemplateSignature), "TemplateBinding")]
    	[Subsets(typeof(DirectedRelationship), "Target")]
    	TemplateSignature Signature { get; set; }
    	
    }
    

    /// <summary>
    /// A TemplateParameter exposes a ParameterableElement as a formal parameter of a template.
    /// </summary>
    [MetaClass]
    public partial interface TemplateParameter : Element
    {
    	/// <summary>
    	/// The ParameterableElement that is the default for this formal TemplateParameter.
    	/// </summary>
    	[Opposite(typeof(ParameterableElement), "TemplateParameter")]
    	ParameterableElement? Default { get; set; }
    	
    	/// <summary>
    	/// The ParameterableElement that is owned by this TemplateParameter for the purpose of providing a default.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ParameterableElement), "TemplateParameter")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	[Subsets(typeof(TemplateParameter), "Default")]
    	ParameterableElement? OwnedDefault { get; set; }
    	
    	/// <summary>
    	/// The ParameterableElement that is owned by this TemplateParameter for the purpose of exposing it as the parameteredElement.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ParameterableElement), "OwningTemplateParameter")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	[Subsets(typeof(TemplateParameter), "ParameteredElement")]
    	ParameterableElement? OwnedParameteredElement { get; set; }
    	
    	/// <summary>
    	/// The ParameterableElement exposed by this TemplateParameter.
    	/// </summary>
    	[Opposite(typeof(ParameterableElement), "TemplateParameter")]
    	ParameterableElement ParameteredElement { get; set; }
    	
    	/// <summary>
    	/// The TemplateSignature that owns this TemplateParameter.
    	/// </summary>
    	[Opposite(typeof(TemplateSignature), "OwnedParameter")]
    	[Subsets(typeof(Element), "Owner")]
    	TemplateSignature Signature { get; set; }
    	
    }
    

    /// <summary>
    /// A TemplateParameterSubstitution relates the actual parameter to a formal TemplateParameter as part of a template binding.
    /// </summary>
    [MetaClass]
    public partial interface TemplateParameterSubstitution : Element
    {
    	/// <summary>
    	/// The ParameterableElement that is the actual parameter for this TemplateParameterSubstitution.
    	/// </summary>
    	[Opposite(typeof(ParameterableElement), "TemplateParameterSubstitution")]
    	ParameterableElement Actual { get; set; }
    	
    	/// <summary>
    	/// The formal TemplateParameter that is associated with this TemplateParameterSubstitution.
    	/// </summary>
    	[Opposite(typeof(TemplateParameter), "TemplateParameterSubstitution")]
    	TemplateParameter Formal { get; set; }
    	
    	/// <summary>
    	/// The ParameterableElement that is owned by this TemplateParameterSubstitution as its actual parameter.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ParameterableElement), "OwningTemplateParameterSubstitution")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	[Subsets(typeof(TemplateParameterSubstitution), "Actual")]
    	ParameterableElement? OwnedActual { get; set; }
    	
    	/// <summary>
    	/// The TemplateBinding that owns this TemplateParameterSubstitution.
    	/// </summary>
    	[Opposite(typeof(TemplateBinding), "ParameterSubstitution")]
    	[Subsets(typeof(Element), "Owner")]
    	TemplateBinding TemplateBinding { get; set; }
    	
    }
    

    /// <summary>
    /// A Template Signature bundles the set of formal TemplateParameters for a template.
    /// </summary>
    [MetaClass]
    public partial interface TemplateSignature : Element
    {
    	/// <summary>
    	/// The formal parameters that are owned by this TemplateSignature.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(TemplateParameter), "Signature")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	[Subsets(typeof(TemplateSignature), "Parameter")]
    	IList<TemplateParameter> OwnedParameter { get; }
    	
    	/// <summary>
    	/// The ordered set of all formal TemplateParameters for this TemplateSignature.
    	/// </summary>
    	[Opposite(typeof(TemplateParameter), "TemplateSignature")]
    	IList<TemplateParameter> Parameter { get; }
    	
    	/// <summary>
    	/// The TemplateableElement that owns this TemplateSignature.
    	/// </summary>
    	[Opposite(typeof(TemplateableElement), "OwnedTemplateSignature")]
    	[Subsets(typeof(Element), "Owner")]
    	TemplateableElement Template { get; set; }
    	
    }
    

    /// <summary>
    /// A Type constrains the values represented by a TypedElement.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface Type : PackageableElement
    {
    	/// <summary>
    	/// Specifies the owning Package of this Type, if any.
    	/// </summary>
    	[Opposite(typeof(Package), "OwnedType")]
    	Package? Package { get; set; }
    	
    }
    

    /// <summary>
    /// A TypedElement is a NamedElement that may have a Type specified for it.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface TypedElement : NamedElement
    {
    	/// <summary>
    	/// The type of the TypedElement.
    	/// </summary>
    	[Opposite(typeof(Type), "TypedElement")]
    	Type? Type { get; set; }
    	
    }
    

    /// <summary>
    /// A Usage is a Dependency in which the client Element requires the supplier Element (or set of Elements) for its full implementation or operation.
    /// </summary>
    [MetaClass]
    public partial interface Usage : Dependency
    {
    }
    

    /// <summary>
    /// A trigger for an AnyReceiveEvent is triggered by the receipt of any message that is not explicitly handled by any related trigger.
    /// </summary>
    [MetaClass]
    public partial interface AnyReceiveEvent : MessageEvent
    {
    }
    

    /// <summary>
    /// Behavior is a specification of how its context BehavioredClassifier changes state over time. This specification may be either a definition of possible behavior execution or emergent behavior, or a selective illustration of an interesting subset of possible executions. The latter form is typically used for capturing examples, such as a trace of a particular execution.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface Behavior : Class
    {
    	/// <summary>
    	/// Tells whether the Behavior can be invoked while it is still executing from a previous invocation.
    	/// </summary>
    	[DefaultValue(true)]
    	bool IsReentrant { get; set; }
    	
    	/// <summary>
    	/// References a list of Parameters to the Behavior which describes the order and type of arguments that can be given when the Behavior is invoked and of the values which will be returned when the Behavior completes its execution.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Parameter), "Behavior")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Parameter> OwnedParameter { get; }
    	
    	/// <summary>
    	/// The ParameterSets owned by this Behavior.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ParameterSet), "Behavior")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<ParameterSet> OwnedParameterSet { get; }
    	
    	/// <summary>
    	/// An optional set of Constraints specifying what is fulfilled after the execution of the Behavior is completed, if its precondition was fulfilled before its invocation.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Constraint), "Behavior")]
    	[Subsets(typeof(Namespace), "OwnedRule")]
    	IList<Constraint> Postcondition { get; }
    	
    	/// <summary>
    	/// An optional set of Constraints specifying what must be fulfilled before the Behavior is invoked.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Constraint), "Behavior")]
    	[Subsets(typeof(Namespace), "OwnedRule")]
    	IList<Constraint> Precondition { get; }
    	
    	/// <summary>
    	/// Designates a BehavioralFeature that the Behavior implements. The BehavioralFeature must be owned by the BehavioredClassifier that owns the Behavior or be inherited by it. The Parameters of the BehavioralFeature and the implementing Behavior must match. A Behavior does not need to have a specification, in which case it either is the classifierBehavior of a BehavioredClassifier or it can only be invoked by another Behavior of the Classifier.
    	/// </summary>
    	[Opposite(typeof(BehavioralFeature), "Method")]
    	BehavioralFeature? Specification { get; set; }
    	
    	/// <summary>
    	/// References the Behavior that this Behavior redefines. A subtype of Behavior may redefine any other subtype of Behavior. If the Behavior implements a BehavioralFeature, it replaces the redefined Behavior. If the Behavior is a classifierBehavior, it extends the redefined Behavior.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Behavior), "Behavior")]
    	[Subsets(typeof(Classifier), "RedefinedClassifier")]
    	IList<Behavior> RedefinedBehavior { get; }
    	
    }
    

    /// <summary>
    /// A CallEvent models the receipt by an object of a message invoking a call of an Operation.
    /// </summary>
    [MetaClass]
    public partial interface CallEvent : MessageEvent
    {
    	/// <summary>
    	/// Designates the Operation whose invocation raised the CalEvent.
    	/// </summary>
    	[Opposite(typeof(Operation), "CallEvent")]
    	Operation Operation { get; set; }
    	
    }
    

    /// <summary>
    /// A ChangeEvent models a change in the system configuration that makes a condition true.
    /// </summary>
    [MetaClass]
    public partial interface ChangeEvent : Event
    {
    	/// <summary>
    	/// A Boolean-valued ValueSpecification that will result in a ChangeEvent whenever its value changes from false to true.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "ChangeEvent")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification ChangeExpression { get; set; }
    	
    }
    

    /// <summary>
    /// An Event is the specification of some occurrence that may potentially trigger effects by an object.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface Event : PackageableElement
    {
    }
    

    /// <summary>
    /// A FunctionBehavior is an OpaqueBehavior that does not access or modify any objects or other external data.
    /// </summary>
    [MetaClass]
    public partial interface FunctionBehavior : OpaqueBehavior
    {
    }
    

    /// <summary>
    /// A MessageEvent specifies the receipt by an object of either an Operation call or a Signal instance.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface MessageEvent : Event
    {
    }
    

    /// <summary>
    /// An OpaqueBehavior is a Behavior whose specification is given in a textual language other than UML.
    /// </summary>
    [MetaClass]
    public partial interface OpaqueBehavior : Behavior
    {
    	/// <summary>
    	/// Specifies the behavior in one or more languages.
    	/// </summary>
    	[NonUnique]
    	IList<string> Body { get; }
    	
    	/// <summary>
    	/// Languages the body strings use in the same order as the body strings.
    	/// </summary>
    	IList<string> Language { get; }
    	
    }
    

    /// <summary>
    /// A SignalEvent represents the receipt of an asynchronous Signal instance.
    /// </summary>
    [MetaClass]
    public partial interface SignalEvent : MessageEvent
    {
    	/// <summary>
    	/// The specific Signal that is associated with this SignalEvent.
    	/// </summary>
    	[Opposite(typeof(Signal), "SignalEvent")]
    	Signal Signal { get; set; }
    	
    }
    

    /// <summary>
    /// A TimeEvent is an Event that occurs at a specific point in time.
    /// </summary>
    [MetaClass]
    public partial interface TimeEvent : Event
    {
    	/// <summary>
    	/// Specifies whether the TimeEvent is specified as an absolute or relative time.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsRelative { get; set; }
    	
    	/// <summary>
    	/// Specifies the time of the TimeEvent.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(TimeExpression), "TimeEvent")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	TimeExpression When { get; set; }
    	
    }
    

    /// <summary>
    /// A Trigger specifies a specific point  at which an Event occurrence may trigger an effect in a Behavior. A Trigger may be qualified by the Port on which the Event occurred.
    /// </summary>
    [MetaClass]
    public partial interface Trigger : NamedElement
    {
    	/// <summary>
    	/// The Event that detected by the Trigger.
    	/// </summary>
    	[Opposite(typeof(Event), "Trigger")]
    	Event Event { get; set; }
    	
    	/// <summary>
    	/// A optional Port of through which the given effect is detected.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Port), "Trigger")]
    	IList<Port> Port { get; }
    	
    }
    

    /// <summary>
    /// A substitution is a relationship between two classifiers signifying that the substituting classifier complies with the contract specified by the contract classifier. This implies that instances of the substituting classifier are runtime substitutable where instances of the contract classifier are expected.
    /// </summary>
    [MetaClass]
    public partial interface Substitution : Realization
    {
    	/// <summary>
    	/// The contract with which the substituting classifier complies.
    	/// </summary>
    	[Opposite(typeof(Classifier), "Substitution")]
    	[Subsets(typeof(Dependency), "Supplier")]
    	Classifier Contract { get; set; }
    	
    	/// <summary>
    	/// Instances of the substituting classifier are runtime substitutable where instances of the contract classifier are expected.
    	/// </summary>
    	[Opposite(typeof(Classifier), "Substitution")]
    	[Subsets(typeof(Dependency), "Client")]
    	[Subsets(typeof(Element), "Owner")]
    	Classifier SubstitutingClassifier { get; set; }
    	
    }
    

    /// <summary>
    /// A BehavioralFeature is a feature of a Classifier that specifies an aspect of the behavior of its instances.  A BehavioralFeature is implemented (realized) by a Behavior. A BehavioralFeature specifies that a Classifier will respond to a designated request by invoking its implementing method.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface BehavioralFeature : Feature, Namespace
    {
    	/// <summary>
    	/// Specifies the semantics of concurrent calls to the same passive instance (i.e., an instance originating from a Class with isActive being false). Active instances control access to their own BehavioralFeatures.
    	/// </summary>
    	[DefaultValue(CallConcurrencyKind.Sequential)]
    	CallConcurrencyKind Concurrency { get; set; }
    	
    	/// <summary>
    	/// If true, then the BehavioralFeature does not have an implementation, and one must be supplied by a more specific Classifier. If false, the BehavioralFeature must have an implementation in the Classifier or one must be inherited.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsAbstract { get; set; }
    	
    	/// <summary>
    	/// A Behavior that implements the BehavioralFeature. There may be at most one Behavior for a particular pairing of a Classifier (as owner of the Behavior) and a BehavioralFeature (as specification of the Behavior).
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Behavior), "Specification")]
    	IList<Behavior> Method { get; }
    	
    	/// <summary>
    	/// The ordered set of formal Parameters of this BehavioralFeature.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Parameter), "OwnerFormalParam")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Parameter> OwnedParameter { get; }
    	
    	/// <summary>
    	/// The ParameterSets owned by this BehavioralFeature.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ParameterSet), "BehavioralFeature")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<ParameterSet> OwnedParameterSet { get; }
    	
    	/// <summary>
    	/// The Types representing exceptions that may be raised during an invocation of this BehavioralFeature.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Type), "BehavioralFeature")]
    	IList<Type> RaisedException { get; }
    	
    	bool NamedElement.IsDistinguishableFrom(NamedElement n, Namespace ns)
    	{
    		return this.IsDistinguishableFrom(n, ns);
    	}
    	
    }
    

    /// <summary>
    /// A Classifier represents a classification of instances according to their Features.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface Classifier : Namespace, Type, TemplateableElement, RedefinableElement
    {
    	/// <summary>
    	/// All of the Properties that are direct (i.e., not inherited or imported) attributes of the Classifier.
    	/// </summary>
    	[DerivedUnion]
    	[ReadOnly]
    	[Opposite(typeof(Property), "Classifier")]
    	[Subsets(typeof(Classifier), "Feature")]
    	IList<Property> Attribute { get; }
    	
    	/// <summary>
    	/// The CollaborationUses owned by the Classifier.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(CollaborationUse), "Classifier")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<CollaborationUse> CollaborationUse { get; }
    	
    	/// <summary>
    	/// Specifies each Feature directly defined in the classifier. Note that there may be members of the Classifier that are of the type Feature but are not included, e.g., inherited features.
    	/// </summary>
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Feature), "FeaturingClassifier")]
    	[Subsets(typeof(Namespace), "Member")]
    	IList<Feature> Feature { get; }
    	
    	/// <summary>
    	/// The Generalization relationships for this Classifier. These Generalizations navigate to more general Classifiers in the generalization hierarchy.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Generalization), "Specific")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Generalization> Generalization { get; }
    	
    	/// <summary>
    	/// If true, the Classifier can only be instantiated by instantiating one of its specializations. An abstract Classifier is intended to be used by other Classifiers e.g., as the target of Associations or Generalizations.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsAbstract { get; set; }
    	
    	/// <summary>
    	/// If true, the Classifier cannot be specialized.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsFinalSpecialization { get; set; }
    	
    	/// <summary>
    	/// The optional RedefinableTemplateSignature specifying the formal template parameters.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(RedefinableTemplateSignature), "Classifier")]
    	[Redefines(typeof(TemplateableElement), "OwnedTemplateSignature")]
    	new RedefinableTemplateSignature? OwnedTemplateSignature { get; set; }
    	
    	/// <summary>
    	/// The UseCases owned by this classifier.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(UseCase), "Classifier")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<UseCase> OwnedUseCase { get; }
    	
    	/// <summary>
    	/// The GeneralizationSet of which this Classifier is a power type.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(GeneralizationSet), "Powertype")]
    	IList<GeneralizationSet> PowertypeExtent { get; }
    	
    	/// <summary>
    	/// The Classifiers redefined by this Classifier.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Classifier), "Classifier")]
    	[Subsets(typeof(RedefinableElement), "RedefinedElement")]
    	IList<Classifier> RedefinedClassifier { get; }
    	
    	/// <summary>
    	/// A CollaborationUse which indicates the Collaboration that represents this Classifier.
    	/// </summary>
    	[Opposite(typeof(CollaborationUse), "Classifier")]
    	[Subsets(typeof(Classifier), "CollaborationUse")]
    	CollaborationUse? Representation { get; set; }
    	
    	/// <summary>
    	/// The Substitutions owned by this Classifier.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Substitution), "SubstitutingClassifier")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	[Subsets(typeof(NamedElement), "ClientDependency")]
    	IList<Substitution> Substitution { get; }
    	
    	/// <summary>
    	/// TheClassifierTemplateParameter that exposes this element as a formal parameter.
    	/// </summary>
    	[Opposite(typeof(ClassifierTemplateParameter), "ParameteredElement")]
    	[Redefines(typeof(ParameterableElement), "TemplateParameter")]
    	new ClassifierTemplateParameter? TemplateParameter { get; set; }
    	
    	/// <summary>
    	/// The set of UseCases for which this Classifier is the subject.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(UseCase), "Subject")]
    	IList<UseCase> UseCase { get; }
    	
    	bool Type.ConformsTo(Type other)
    	{
    		return this.ConformsTo(other);
    	}
    	
    	bool TemplateableElement.IsTemplate()
    	{
    		return this.IsTemplate();
    	}
    	
    }
    

    /// <summary>
    /// A ClassifierTemplateParameter exposes a Classifier as a formal template parameter.
    /// </summary>
    [MetaClass]
    public partial interface ClassifierTemplateParameter : TemplateParameter
    {
    	/// <summary>
    	/// Constrains the required relationship between an actual parameter and the parameteredElement for this formal parameter.
    	/// </summary>
    	[DefaultValue(true)]
    	bool AllowSubstitutable { get; set; }
    	
    	/// <summary>
    	/// The classifiers that constrain the argument that can be used for the parameter. If the allowSubstitutable attribute is true, then any Classifier that is compatible with this constraining Classifier can be substituted; otherwise, it must be either this Classifier or one of its specializations. If this property is empty, there are no constraints on the Classifier that can be used as an argument.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Classifier), "ClassifierTemplateParameter")]
    	IList<Classifier> ConstrainingClassifier { get; }
    	
    	/// <summary>
    	/// The Classifier exposed by this ClassifierTemplateParameter.
    	/// </summary>
    	[Opposite(typeof(Classifier), "TemplateParameter")]
    	[Redefines(typeof(TemplateParameter), "ParameteredElement")]
    	new Classifier ParameteredElement { get; set; }
    	
    }
    

    /// <summary>
    /// A Feature declares a behavioral or structural characteristic of Classifiers.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface Feature : RedefinableElement
    {
    	/// <summary>
    	/// The Classifiers that have this Feature as a feature.
    	/// </summary>
    	[DerivedUnion]
    	[ReadOnly]
    	[Opposite(typeof(Classifier), "Feature")]
    	Classifier? FeaturingClassifier { get; }
    	
    	/// <summary>
    	/// Specifies whether this Feature characterizes individual instances classified by the Classifier (false) or the Classifier itself (true).
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsStatic { get; set; }
    	
    }
    

    /// <summary>
    /// A Generalization is a taxonomic relationship between a more general Classifier and a more specific Classifier. Each instance of the specific Classifier is also an instance of the general Classifier. The specific Classifier inherits the features of the more general Classifier. A Generalization is owned by the specific Classifier.
    /// </summary>
    [MetaClass]
    public partial interface Generalization : DirectedRelationship
    {
    	/// <summary>
    	/// The general classifier in the Generalization relationship.
    	/// </summary>
    	[Opposite(typeof(Classifier), "Generalization")]
    	[Subsets(typeof(DirectedRelationship), "Target")]
    	Classifier General { get; set; }
    	
    	/// <summary>
    	/// Represents a set of instances of Generalization.  A Generalization may appear in many GeneralizationSets.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(GeneralizationSet), "Generalization")]
    	IList<GeneralizationSet> GeneralizationSet { get; }
    	
    	/// <summary>
    	/// Indicates whether the specific Classifier can be used wherever the general Classifier can be used. If true, the execution traces of the specific Classifier shall be a superset of the execution traces of the general Classifier. If false, there is no such constraint on execution traces. If unset, the modeler has not stated whether there is such a constraint or not.
    	/// </summary>
    	[DefaultValue(true)]
    	bool IsSubstitutable { get; set; }
    	
    	/// <summary>
    	/// The specializing Classifier in the Generalization relationship.
    	/// </summary>
    	[Opposite(typeof(Classifier), "Generalization")]
    	[Subsets(typeof(DirectedRelationship), "Source")]
    	[Subsets(typeof(Element), "Owner")]
    	Classifier Specific { get; set; }
    	
    }
    

    /// <summary>
    /// A GeneralizationSet is a PackageableElement whose instances represent sets of Generalization relationships.
    /// </summary>
    [MetaClass]
    public partial interface GeneralizationSet : PackageableElement
    {
    	/// <summary>
    	/// Designates the instances of Generalization that are members of this GeneralizationSet.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Generalization), "GeneralizationSet")]
    	IList<Generalization> Generalization { get; }
    	
    	/// <summary>
    	/// Indicates (via the associated Generalizations) whether or not the set of specific Classifiers are covering for a particular general classifier. When isCovering is true, every instance of a particular general Classifier is also an instance of at least one of its specific Classifiers for the GeneralizationSet. When isCovering is false, there are one or more instances of the particular general Classifier that are not instances of at least one of its specific Classifiers defined for the GeneralizationSet.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsCovering { get; set; }
    	
    	/// <summary>
    	/// Indicates whether or not the set of specific Classifiers in a Generalization relationship have instance in common. If isDisjoint is true, the specific Classifiers for a particular GeneralizationSet have no members in common; that is, their intersection is empty. If isDisjoint is false, the specific Classifiers in a particular GeneralizationSet have one or more members in common; that is, their intersection is not empty.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsDisjoint { get; set; }
    	
    	/// <summary>
    	/// Designates the Classifier that is defined as the power type for the associated GeneralizationSet, if there is one.
    	/// </summary>
    	[Opposite(typeof(Classifier), "PowertypeExtent")]
    	Classifier? Powertype { get; set; }
    	
    }
    

    /// <summary>
    /// An InstanceSpecification is a model element that represents an instance in a modeled system. An InstanceSpecification can act as a DeploymentTarget in a Deployment relationship, in the case that it represents an instance of a Node. It can also act as a DeployedArtifact, if it represents an instance of an Artifact.
    /// </summary>
    [MetaClass]
    public partial interface InstanceSpecification : DeploymentTarget, PackageableElement, DeployedArtifact
    {
    	/// <summary>
    	/// The Classifier or Classifiers of the represented instance. If multiple Classifiers are specified, the instance is classified by all of them.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Classifier), "InstanceSpecification")]
    	IList<Classifier> Classifier { get; }
    	
    	/// <summary>
    	/// A Slot giving the value or values of a StructuralFeature of the instance. An InstanceSpecification can have one Slot per StructuralFeature of its Classifiers, including inherited features. It is not necessary to model a Slot for every StructuralFeature, in which case the InstanceSpecification is a partial description.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Slot), "OwningInstance")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Slot> Slot { get; }
    	
    	/// <summary>
    	/// A specification of how to compute, derive, or construct the instance.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "OwningInstanceSpec")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? Specification { get; set; }
    	
    }
    

    /// <summary>
    /// An InstanceValue is a ValueSpecification that identifies an instance.
    /// </summary>
    [MetaClass]
    public partial interface InstanceValue : ValueSpecification
    {
    	/// <summary>
    	/// The InstanceSpecification that represents the specified value.
    	/// </summary>
    	[Opposite(typeof(InstanceSpecification), "InstanceValue")]
    	InstanceSpecification Instance { get; set; }
    	
    }
    

    /// <summary>
    /// An Operation is a BehavioralFeature of a Classifier that specifies the name, type, parameters, and constraints for invoking an associated Behavior. An Operation may invoke both the execution of method behaviors as well as other behavioral responses. Operation specializes TemplateableElement in order to support specification of template operations and bound operations. Operation specializes ParameterableElement to specify that an operation can be exposed as a formal template parameter, and provided as an actual parameter in a binding of a template.
    /// </summary>
    [MetaClass]
    public partial interface Operation : TemplateableElement, ParameterableElement, BehavioralFeature
    {
    	/// <summary>
    	/// An optional Constraint on the result values of an invocation of this Operation.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Constraint), "BodyContext")]
    	[Subsets(typeof(Namespace), "OwnedRule")]
    	Constraint? BodyCondition { get; set; }
    	
    	/// <summary>
    	/// The Class that owns this operation, if any.
    	/// </summary>
    	[Opposite(typeof(Class), "OwnedOperation")]
    	[Subsets(typeof(Feature), "FeaturingClassifier")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	[Subsets(typeof(RedefinableElement), "RedefinitionContext")]
    	Class? Class { get; set; }
    	
    	/// <summary>
    	/// The DataType that owns this Operation, if any.
    	/// </summary>
    	[Opposite(typeof(DataType), "OwnedOperation")]
    	[Subsets(typeof(Feature), "FeaturingClassifier")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	[Subsets(typeof(RedefinableElement), "RedefinitionContext")]
    	DataType? Datatype { get; set; }
    	
    	/// <summary>
    	/// The Interface that owns this Operation, if any.
    	/// </summary>
    	[Opposite(typeof(Interface), "OwnedOperation")]
    	[Subsets(typeof(Feature), "FeaturingClassifier")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	[Subsets(typeof(RedefinableElement), "RedefinitionContext")]
    	Interface? Interface { get; set; }
    	
    	/// <summary>
    	/// Specifies whether an execution of the BehavioralFeature leaves the state of the system unchanged (isQuery=true) or whether side effects may occur (isQuery=false).
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsQuery { get; set; }
    	
    	/// <summary>
    	/// The parameters owned by this Operation.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Parameter), "Operation")]
    	[Redefines(typeof(BehavioralFeature), "OwnedParameter")]
    	new IList<Parameter> OwnedParameter { get; }
    	
    	/// <summary>
    	/// An optional set of Constraints specifying the state of the system when the Operation is completed.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Constraint), "PostContext")]
    	[Subsets(typeof(Namespace), "OwnedRule")]
    	IList<Constraint> Postcondition { get; }
    	
    	/// <summary>
    	/// An optional set of Constraints on the state of the system when the Operation is invoked.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Constraint), "PreContext")]
    	[Subsets(typeof(Namespace), "OwnedRule")]
    	IList<Constraint> Precondition { get; }
    	
    	/// <summary>
    	/// The Types representing exceptions that may be raised during an invocation of this operation.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Type), "Operation")]
    	[Redefines(typeof(BehavioralFeature), "RaisedException")]
    	new IList<Type> RaisedException { get; }
    	
    	/// <summary>
    	/// The Operations that are redefined by this Operation.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Operation), "Operation")]
    	[Subsets(typeof(RedefinableElement), "RedefinedElement")]
    	IList<Operation> RedefinedOperation { get; }
    	
    	/// <summary>
    	/// The OperationTemplateParameter that exposes this element as a formal parameter.
    	/// </summary>
    	[Opposite(typeof(OperationTemplateParameter), "ParameteredElement")]
    	[Redefines(typeof(ParameterableElement), "TemplateParameter")]
    	new OperationTemplateParameter? TemplateParameter { get; set; }
    	
    	bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    }
    

    /// <summary>
    /// An OperationTemplateParameter exposes an Operation as a formal parameter for a template.
    /// </summary>
    [MetaClass]
    public partial interface OperationTemplateParameter : TemplateParameter
    {
    	/// <summary>
    	/// The Operation exposed by this OperationTemplateParameter.
    	/// </summary>
    	[Opposite(typeof(Operation), "TemplateParameter")]
    	[Redefines(typeof(TemplateParameter), "ParameteredElement")]
    	new Operation ParameteredElement { get; set; }
    	
    }
    

    /// <summary>
    /// A Parameter is a specification of an argument used to pass information into or out of an invocation of a BehavioralFeature.  Parameters can be treated as ConnectableElements within Collaborations.
    /// </summary>
    [MetaClass]
    public partial interface Parameter : MultiplicityElement, ConnectableElement
    {
    	/// <summary>
    	/// Specifies a ValueSpecification that represents a value to be used when no argument is supplied for the Parameter.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "OwningParameter")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? DefaultValue { get; set; }
    	
    	/// <summary>
    	/// Indicates whether a parameter is being sent into or out of a behavioral element.
    	/// </summary>
    	[DefaultValue(ParameterDirectionKind.In)]
    	ParameterDirectionKind Direction { get; set; }
    	
    	/// <summary>
    	/// Specifies the effect that executions of the owner of the Parameter have on objects passed in or out of the parameter.
    	/// </summary>
    	ParameterEffectKind? Effect { get; set; }
    	
    	/// <summary>
    	/// Tells whether an output parameter may emit a value to the exclusion of the other outputs.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsException { get; set; }
    	
    	/// <summary>
    	/// Tells whether an input parameter may accept values while its behavior is executing, or whether an output parameter may post values while the behavior is executing.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsStream { get; set; }
    	
    	/// <summary>
    	/// The Operation owning this parameter.
    	/// </summary>
    	[Opposite(typeof(Operation), "OwnedParameter")]
    	Operation? Operation { get; set; }
    	
    	/// <summary>
    	/// The ParameterSets containing the parameter. See ParameterSet.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ParameterSet), "Parameter")]
    	IList<ParameterSet> ParameterSet { get; }
    	
    }
    

    /// <summary>
    /// A ParameterSet designates alternative sets of inputs or outputs that a Behavior may use.
    /// </summary>
    [MetaClass]
    public partial interface ParameterSet : NamedElement
    {
    	/// <summary>
    	/// A constraint that should be satisfied for the owner of the Parameters in an input ParameterSet to start execution using the values provided for those Parameters, or the owner of the Parameters in an output ParameterSet to end execution providing the values for those Parameters, if all preconditions and conditions on input ParameterSets were satisfied.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Constraint), "ParameterSet")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Constraint> Condition { get; }
    	
    	/// <summary>
    	/// Parameters in the ParameterSet.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Parameter), "ParameterSet")]
    	IList<Parameter> Parameter { get; }
    	
    }
    

    /// <summary>
    /// A Property is a StructuralFeature. A Property related by ownedAttribute to a Classifier (other than an association) represents an attribute and might also represent an association end. It relates an instance of the Classifier to a value or set of values of the type of the attribute. A Property related by memberEnd to an Association represents an end of the Association. The type of the Property is the type of the end of the Association. A Property has the capability of being a DeploymentTarget in a Deployment relationship. This enables modeling the deployment to hierarchical nodes that have Properties functioning as internal parts.  Property specializes ParameterableElement to specify that a Property can be exposed as a formal template parameter, and provided as an actual parameter in a binding of a template.
    /// </summary>
    [MetaClass]
    public partial interface Property : ConnectableElement, DeploymentTarget, StructuralFeature
    {
    	/// <summary>
    	/// Specifies the kind of aggregation that applies to the Property.
    	/// </summary>
    	[DefaultValue(AggregationKind.None)]
    	AggregationKind Aggregation { get; set; }
    	
    	/// <summary>
    	/// The Association of which this Property is a member, if any.
    	/// </summary>
    	[Opposite(typeof(Association), "MemberEnd")]
    	Association? Association { get; set; }
    	
    	/// <summary>
    	/// Designates the optional association end that owns a qualifier attribute.
    	/// </summary>
    	[Opposite(typeof(Property), "Qualifier")]
    	[Subsets(typeof(Element), "Owner")]
    	Property? AssociationEnd { get; set; }
    	
    	/// <summary>
    	/// The Class that owns this Property, if any.
    	/// </summary>
    	[Opposite(typeof(Class), "OwnedAttribute")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	Class? Class { get; set; }
    	
    	/// <summary>
    	/// The DataType that owns this Property, if any.
    	/// </summary>
    	[Opposite(typeof(DataType), "OwnedAttribute")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	DataType? Datatype { get; set; }
    	
    	/// <summary>
    	/// A ValueSpecification that is evaluated to give a default value for the Property when an instance of the owning Classifier is instantiated.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "OwningProperty")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification? DefaultValue { get; set; }
    	
    	/// <summary>
    	/// The Interface that owns this Property, if any.
    	/// </summary>
    	[Opposite(typeof(Interface), "OwnedAttribute")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	Interface? Interface { get; set; }
    	
    	/// <summary>
    	/// Specifies whether the Property is derived, i.e., whether its value or values can be computed from other information.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsDerived { get; set; }
    	
    	/// <summary>
    	/// Specifies whether the property is derived as the union of all of the Properties that are constrained to subset it.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsDerivedUnion { get; set; }
    	
    	/// <summary>
    	/// True indicates this property can be used to uniquely identify an instance of the containing Class.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsID { get; set; }
    	
    	/// <summary>
    	/// The owning association of this property, if any.
    	/// </summary>
    	[Opposite(typeof(Association), "OwnedEnd")]
    	[Subsets(typeof(Feature), "FeaturingClassifier")]
    	[Subsets(typeof(NamedElement), "Namespace")]
    	[Subsets(typeof(Property), "Association")]
    	[Subsets(typeof(RedefinableElement), "RedefinitionContext")]
    	Association? OwningAssociation { get; set; }
    	
    	/// <summary>
    	/// An optional list of ordered qualifier attributes for the end.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Property), "AssociationEnd")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Property> Qualifier { get; }
    	
    	/// <summary>
    	/// The properties that are redefined by this property, if any.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Property), "Property")]
    	[Subsets(typeof(RedefinableElement), "RedefinedElement")]
    	IList<Property> RedefinedProperty { get; }
    	
    	/// <summary>
    	/// The properties of which this Property is constrained to be a subset, if any.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Property), "Property")]
    	IList<Property> SubsettedProperty { get; }
    	
    	bool ParameterableElement.IsCompatibleWith(ParameterableElement p)
    	{
    		return this.IsCompatibleWith(p);
    	}
    	
    	bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    }
    

    /// <summary>
    /// A RedefinableElement is an element that, when defined in the context of a Classifier, can be redefined more specifically or differently in the context of another Classifier that specializes (directly or indirectly) the context Classifier.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface RedefinableElement : NamedElement
    {
    	/// <summary>
    	/// Indicates whether it is possible to further redefine a RedefinableElement. If the value is true, then it is not possible to further redefine the RedefinableElement.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsLeaf { get; set; }
    	
    	/// <summary>
    	/// The RedefinableElement that is being redefined by this element.
    	/// </summary>
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(RedefinableElement), "RedefinableElement")]
    	IList<RedefinableElement> RedefinedElement { get; }
    	
    	/// <summary>
    	/// The contexts that this element may be redefined from.
    	/// </summary>
    	[DerivedUnion]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Classifier), "RedefinableElement")]
    	IList<Classifier> RedefinitionContext { get; }
    	
    }
    

    /// <summary>
    /// A RedefinableTemplateSignature supports the addition of formal template parameters in a specialization of a template classifier.
    /// </summary>
    [MetaClass]
    public partial interface RedefinableTemplateSignature : RedefinableElement, TemplateSignature
    {
    	/// <summary>
    	/// The Classifier that owns this RedefinableTemplateSignature.
    	/// </summary>
    	[Opposite(typeof(Classifier), "OwnedTemplateSignature")]
    	[Redefines(typeof(TemplateSignature), "Template")]
    	[Subsets(typeof(RedefinableElement), "RedefinitionContext")]
    	Classifier Classifier { get; set; }
    	
    	/// <summary>
    	/// The signatures extended by this RedefinableTemplateSignature.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(RedefinableTemplateSignature), "RedefinableTemplateSignature")]
    	[Subsets(typeof(RedefinableElement), "RedefinedElement")]
    	IList<RedefinableTemplateSignature> ExtendedSignature { get; }
    	
    	bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return this.IsConsistentWith(redefiningElement);
    	}
    	
    }
    

    /// <summary>
    /// A Slot designates that an entity modeled by an InstanceSpecification has a value or values for a specific StructuralFeature.
    /// </summary>
    [MetaClass]
    public partial interface Slot : Element
    {
    	/// <summary>
    	/// The StructuralFeature that specifies the values that may be held by the Slot.
    	/// </summary>
    	[Opposite(typeof(StructuralFeature), "Slot")]
    	StructuralFeature DefiningFeature { get; set; }
    	
    	/// <summary>
    	/// The InstanceSpecification that owns this Slot.
    	/// </summary>
    	[Opposite(typeof(InstanceSpecification), "Slot")]
    	[Subsets(typeof(Element), "Owner")]
    	InstanceSpecification OwningInstance { get; set; }
    	
    	/// <summary>
    	/// The value or values held by the Slot.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "OwningSlot")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ValueSpecification> Value { get; }
    	
    }
    

    /// <summary>
    /// A StructuralFeature is a typed feature of a Classifier that specifies the structure of instances of the Classifier.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface StructuralFeature : MultiplicityElement, TypedElement, Feature
    {
    	/// <summary>
    	/// If isReadOnly is true, the StructuralFeature may not be written to after initialization.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsReadOnly { get; set; }
    	
    }
    

    /// <summary>
    /// A ValueSpecificationAction is an Action that evaluates a ValueSpecification and provides a result.
    /// </summary>
    [MetaClass]
    public partial interface ValueSpecificationAction : Action
    {
    	/// <summary>
    	/// The OutputPin on which the result value is placed.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "ValueSpecificationAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin Result { get; set; }
    	
    	/// <summary>
    	/// The ValueSpecification to be evaluated.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "ValueSpecificationAction")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification Value { get; set; }
    	
    }
    

    /// <summary>
    /// VariableAction is an abstract class for Actions that operate on a specified Variable.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface VariableAction : Action
    {
    	/// <summary>
    	/// The Variable to be read or written.
    	/// </summary>
    	[Opposite(typeof(Variable), "VariableAction")]
    	Variable Variable { get; set; }
    	
    }
    

    /// <summary>
    /// WriteLinkAction is an abstract class for LinkActions that create and destroy links.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface WriteLinkAction : LinkAction
    {
    }
    

    /// <summary>
    /// WriteStructuralFeatureAction is an abstract class for StructuralFeatureActions that change StructuralFeature values.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface WriteStructuralFeatureAction : StructuralFeatureAction
    {
    	/// <summary>
    	/// The OutputPin on which is put the input object as modified by the WriteStructuralFeatureAction.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "WriteStructuralFeatureAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin? Result { get; set; }
    	
    	/// <summary>
    	/// The InputPin that provides the value to be added or removed from the StructuralFeature.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "WriteStructuralFeatureAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin? Value { get; set; }
    	
    }
    

    /// <summary>
    /// WriteVariableAction is an abstract class for VariableActions that change Variable values.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface WriteVariableAction : VariableAction
    {
    	/// <summary>
    	/// The InputPin that gives the value to be added or removed from the Variable.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "WriteVariableAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin? Value { get; set; }
    	
    }
    

    /// <summary>
    /// An AcceptCallAction is an AcceptEventAction that handles the receipt of a synchronous call request. In addition to the values from the Operation input parameters, the Action produces an output that is needed later to supply the information to the ReplyAction necessary to return control to the caller. An AcceptCallAction is for synchronous calls. If it is used to handle an asynchronous call, execution of the subsequent ReplyAction will complete immediately with no effect.
    /// </summary>
    [MetaClass]
    public partial interface AcceptCallAction : AcceptEventAction
    {
    	/// <summary>
    	/// An OutputPin where a value is placed containing sufficient information to perform a subsequent ReplyAction and return control to the caller. The contents of this value are opaque. It can be passed and copied but it cannot be manipulated by the model.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "AcceptCallAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin ReturnInformation { get; set; }
    	
    }
    

    /// <summary>
    /// An AcceptEventAction is an Action that waits for the occurrence of one or more specific Events.
    /// </summary>
    [MetaClass]
    public partial interface AcceptEventAction : Action
    {
    	/// <summary>
    	/// Indicates whether there is a single OutputPin for a SignalEvent occurrence, or multiple OutputPins for attribute values of the instance of the Signal associated with a SignalEvent occurrence.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsUnmarshall { get; set; }
    	
    	/// <summary>
    	/// OutputPins holding the values received from an Event occurrence.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "AcceptEventAction")]
    	[Subsets(typeof(Action), "Output")]
    	IList<OutputPin> Result { get; }
    	
    	/// <summary>
    	/// The Triggers specifying the Events of which the AcceptEventAction waits for occurrences.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Trigger), "AcceptEventAction")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Trigger> Trigger { get; }
    	
    }
    

    /// <summary>
    /// An Action is the fundamental unit of executable functionality. The execution of an Action represents some transformation or processing in the modeled system. Actions provide the ExecutableNodes within Activities and may also be used within Interactions.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface Action : ExecutableNode
    {
    	/// <summary>
    	/// The ordered set of InputPins representing the inputs to the Action.
    	/// </summary>
    	[Containment]
    	[DerivedUnion]
    	[ReadOnly]
    	[Opposite(typeof(InputPin), "Action")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<InputPin> Input { get; }
    	
    	/// <summary>
    	/// If true, the Action can begin a new, concurrent execution, even if there is already another execution of the Action ongoing. If false, the Action cannot begin a new execution until any previous execution has completed.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsLocallyReentrant { get; set; }
    	
    	/// <summary>
    	/// A Constraint that must be satisfied when execution of the Action is completed.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Constraint), "Action")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Constraint> LocalPostcondition { get; }
    	
    	/// <summary>
    	/// A Constraint that must be satisfied when execution of the Action is started.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Constraint), "Action")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Constraint> LocalPrecondition { get; }
    	
    	/// <summary>
    	/// The ordered set of OutputPins representing outputs from the Action.
    	/// </summary>
    	[Containment]
    	[DerivedUnion]
    	[ReadOnly]
    	[Opposite(typeof(OutputPin), "Action")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<OutputPin> Output { get; }
    	
    }
    

    /// <summary>
    /// An ActionInputPin is a kind of InputPin that executes an Action to determine the values to input to another Action.
    /// </summary>
    [MetaClass]
    public partial interface ActionInputPin : InputPin
    {
    	/// <summary>
    	/// The Action used to provide the values of the ActionInputPin.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(Action), "ActionInputPin")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	Action FromAction { get; set; }
    	
    }
    

    /// <summary>
    /// An AddStructuralFeatureValueAction is a WriteStructuralFeatureAction for adding values to a StructuralFeature.
    /// </summary>
    [MetaClass]
    public partial interface AddStructuralFeatureValueAction : WriteStructuralFeatureAction
    {
    	/// <summary>
    	/// The InputPin that gives the position at which to insert the value in an ordered StructuralFeature. The type of the insertAt InputPin is UnlimitedNatural, but the value cannot be zero. It is omitted for unordered StructuralFeatures.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "AddStructuralFeatureValueAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin? InsertAt { get; set; }
    	
    	/// <summary>
    	/// Specifies whether existing values of the StructuralFeature should be removed before adding the new value.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsReplaceAll { get; set; }
    	
    }
    

    /// <summary>
    /// An AddVariableValueAction is a WriteVariableAction for adding values to a Variable.
    /// </summary>
    [MetaClass]
    public partial interface AddVariableValueAction : WriteVariableAction
    {
    	/// <summary>
    	/// The InputPin that gives the position at which to insert a new value or move an existing value in ordered Variables. The type of the insertAt InputPin is UnlimitedNatural, but the value cannot be zero. It is omitted for unordered Variables.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "AddVariableValueAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin? InsertAt { get; set; }
    	
    	/// <summary>
    	/// Specifies whether existing values of the Variable should be removed before adding the new value.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsReplaceAll { get; set; }
    	
    }
    

    /// <summary>
    /// A BroadcastSignalAction is an InvocationAction that transmits a Signal instance to all the potential target objects in the system. Values from the argument InputPins are used to provide values for the attributes of the Signal. The requestor continues execution immediately after the Signal instances are sent out and cannot receive reply values.
    /// </summary>
    [MetaClass]
    public partial interface BroadcastSignalAction : InvocationAction
    {
    	/// <summary>
    	/// The Signal whose instances are to be sent.
    	/// </summary>
    	[Opposite(typeof(Signal), "BroadcastSignalAction")]
    	Signal Signal { get; set; }
    	
    }
    

    /// <summary>
    /// CallAction is an abstract class for Actions that invoke a Behavior with given argument values and (if the invocation is synchronous) receive reply values.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface CallAction : InvocationAction
    {
    	/// <summary>
    	/// If true, the call is synchronous and the caller waits for completion of the invoked Behavior. If false, the call is asynchronous and the caller proceeds immediately and cannot receive return values.
    	/// </summary>
    	[DefaultValue(true)]
    	bool IsSynchronous { get; set; }
    	
    	/// <summary>
    	/// The OutputPins on which the reply values from the invocation are placed (if the call is synchronous).
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "CallAction")]
    	[Subsets(typeof(Action), "Output")]
    	IList<OutputPin> Result { get; }
    	
    }
    

    /// <summary>
    /// A CallBehaviorAction is a CallAction that invokes a Behavior directly. The argument values of the CallBehaviorAction are passed on the input Parameters of the invoked Behavior. If the call is synchronous, the execution of the CallBehaviorAction waits until the execution of the invoked Behavior completes and the values of output Parameters of the Behavior are placed on the result OutputPins. If the call is asynchronous, the CallBehaviorAction completes immediately and no results values can be provided.
    /// </summary>
    [MetaClass]
    public partial interface CallBehaviorAction : CallAction
    {
    	/// <summary>
    	/// The Behavior being invoked.
    	/// </summary>
    	[Opposite(typeof(Behavior), "CallBehaviorAction")]
    	Behavior Behavior { get; set; }
    	
    	IList<Parameter> CallAction.OutputParameters()
    	{
    		return this.OutputParameters();
    	}
    	
    	IList<Parameter> CallAction.InputParameters()
    	{
    		return this.InputParameters();
    	}
    	
    }
    

    /// <summary>
    /// A CallOperationAction is a CallAction that transmits an Operation call request to the target object, where it may cause the invocation of associated Behavior. The argument values of the CallOperationAction are passed on the input Parameters of the Operation. If call is synchronous, the execution of the CallOperationAction waits until the execution of the invoked Operation completes and the values of output Parameters of the Operation are placed on the result OutputPins. If the call is asynchronous, the CallOperationAction completes immediately and no results values can be provided.
    /// </summary>
    [MetaClass]
    public partial interface CallOperationAction : CallAction
    {
    	/// <summary>
    	/// The Operation being invoked.
    	/// </summary>
    	[Opposite(typeof(Operation), "CallOperationAction")]
    	Operation Operation { get; set; }
    	
    	/// <summary>
    	/// The InputPin that provides the target object to which the Operation call request is sent.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "CallOperationAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Target { get; set; }
    	
    	IList<Parameter> CallAction.OutputParameters()
    	{
    		return this.OutputParameters();
    	}
    	
    	IList<Parameter> CallAction.InputParameters()
    	{
    		return this.InputParameters();
    	}
    	
    }
    

    /// <summary>
    /// A Clause is an Element that represents a single branch of a ConditionalNode, including a test and a body section. The body section is executed only if (but not necessarily if) the test section evaluates to true.
    /// </summary>
    [MetaClass]
    public partial interface Clause : Element
    {
    	/// <summary>
    	/// The set of ExecutableNodes that are executed if the test evaluates to true and the Clause is chosen over other Clauses within the ConditionalNode that also have tests that evaluate to true.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ExecutableNode), "Clause")]
    	IList<ExecutableNode> Body { get; }
    	
    	/// <summary>
    	/// The OutputPins on Actions within the body section whose values are moved to the result OutputPins of the containing ConditionalNode after execution of the body.
    	/// </summary>
    	[Opposite(typeof(OutputPin), "Clause")]
    	IList<OutputPin> BodyOutput { get; }
    	
    	/// <summary>
    	/// An OutputPin on an Action in the test section whose Boolean value determines the result of the test.
    	/// </summary>
    	[Opposite(typeof(OutputPin), "Clause")]
    	OutputPin Decider { get; set; }
    	
    	/// <summary>
    	/// A set of Clauses whose tests must all evaluate to false before this Clause can evaluate its test.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Clause), "SuccessorClause")]
    	IList<Clause> PredecessorClause { get; }
    	
    	/// <summary>
    	/// A set of Clauses that may not evaluate their tests unless the test for this Clause evaluates to false.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Clause), "PredecessorClause")]
    	IList<Clause> SuccessorClause { get; }
    	
    	/// <summary>
    	/// The set of ExecutableNodes that are executed in order to provide a test result for the Clause.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ExecutableNode), "Clause")]
    	IList<ExecutableNode> Test { get; }
    	
    }
    

    /// <summary>
    /// A ClearAssociationAction is an Action that destroys all links of an Association in which a particular object participates.
    /// </summary>
    [MetaClass]
    public partial interface ClearAssociationAction : Action
    {
    	/// <summary>
    	/// The Association to be cleared.
    	/// </summary>
    	[Opposite(typeof(Association), "ClearAssociationAction")]
    	Association Association { get; set; }
    	
    	/// <summary>
    	/// The InputPin that gives the object whose participation in the Association is to be cleared.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "ClearAssociationAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Object { get; set; }
    	
    }
    

    /// <summary>
    /// A ClearStructuralFeatureAction is a StructuralFeatureAction that removes all values of a StructuralFeature.
    /// </summary>
    [MetaClass]
    public partial interface ClearStructuralFeatureAction : StructuralFeatureAction
    {
    	/// <summary>
    	/// The OutputPin on which is put the input object as modified by the ClearStructuralFeatureAction.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "ClearStructuralFeatureAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin? Result { get; set; }
    	
    }
    

    /// <summary>
    /// A ClearVariableAction is a VariableAction that removes all values of a Variable.
    /// </summary>
    [MetaClass]
    public partial interface ClearVariableAction : VariableAction
    {
    }
    

    /// <summary>
    /// A ConditionalNode is a StructuredActivityNode that chooses one among some number of alternative collections of ExecutableNodes to execute.
    /// </summary>
    [MetaClass]
    public partial interface ConditionalNode : StructuredActivityNode
    {
    	/// <summary>
    	/// The set of Clauses composing the ConditionalNode.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Clause), "ConditionalNode")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<Clause> Clause { get; }
    	
    	/// <summary>
    	/// If true, the modeler asserts that the test for at least one Clause of the ConditionalNode will succeed.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsAssured { get; set; }
    	
    	/// <summary>
    	/// If true, the modeler asserts that the test for at most one Clause of the ConditionalNode will succeed.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsDeterminate { get; set; }
    	
    	/// <summary>
    	/// The OutputPins that onto which are moved values from the bodyOutputs of the Clause selected for execution.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "ConditionalNode")]
    	[Redefines(typeof(StructuredActivityNode), "StructuredNodeOutput")]
    	IList<OutputPin> Result { get; }
    	
    	IList<Action> StructuredActivityNode.AllActions()
    	{
    		return this.AllActions();
    	}
    	
    	IList<Action> Action.AllActions()
    	{
    		return this.AllActions();
    	}
    	
    }
    

    /// <summary>
    /// A CreateLinkAction is a WriteLinkAction for creating links.
    /// </summary>
    [MetaClass]
    public partial interface CreateLinkAction : WriteLinkAction
    {
    	/// <summary>
    	/// The LinkEndData that specifies the values to be placed on the Association ends for the new link.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(LinkEndCreationData), "CreateLinkAction")]
    	[Redefines(typeof(LinkAction), "EndData")]
    	new IList<LinkEndCreationData> EndData { get; }
    	
    }
    

    /// <summary>
    /// A CreateLinkObjectAction is a CreateLinkAction for creating link objects (AssociationClasse instances).
    /// </summary>
    [MetaClass]
    public partial interface CreateLinkObjectAction : CreateLinkAction
    {
    	/// <summary>
    	/// The output pin on which the newly created link object is placed.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "CreateLinkObjectAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin Result { get; set; }
    	
    }
    

    /// <summary>
    /// A CreateObjectAction is an Action that creates an instance of the specified Classifier.
    /// </summary>
    [MetaClass]
    public partial interface CreateObjectAction : Action
    {
    	/// <summary>
    	/// The Classifier to be instantiated.
    	/// </summary>
    	[Opposite(typeof(Classifier), "CreateObjectAction")]
    	Classifier Classifier { get; set; }
    	
    	/// <summary>
    	/// The OutputPin on which the newly created object is placed.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "CreateObjectAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin Result { get; set; }
    	
    }
    

    /// <summary>
    /// A DestroyLinkAction is a WriteLinkAction that destroys links (including link objects).
    /// </summary>
    [MetaClass]
    public partial interface DestroyLinkAction : WriteLinkAction
    {
    	/// <summary>
    	/// The LinkEndData that the values of the Association ends for the links to be destroyed.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(LinkEndDestructionData), "DestroyLinkAction")]
    	[Redefines(typeof(LinkAction), "EndData")]
    	new IList<LinkEndDestructionData> EndData { get; }
    	
    }
    

    /// <summary>
    /// A DestroyObjectAction is an Action that destroys objects.
    /// </summary>
    [MetaClass]
    public partial interface DestroyObjectAction : Action
    {
    	/// <summary>
    	/// Specifies whether links in which the object participates are destroyed along with the object.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsDestroyLinks { get; set; }
    	
    	/// <summary>
    	/// Specifies whether objects owned by the object (via composition) are destroyed along with the object.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsDestroyOwnedObjects { get; set; }
    	
    	/// <summary>
    	/// The InputPin providing the object to be destroyed.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "DestroyObjectAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Target { get; set; }
    	
    }
    

    /// <summary>
    /// An ExpansionNode is an ObjectNode used to indicate a collection input or output for an ExpansionRegion. A collection input of an ExpansionRegion contains a collection that is broken into its individual elements inside the region, whose content is executed once per element. A collection output of an ExpansionRegion combines individual elements produced by the execution of the region into a collection for use outside the region.
    /// </summary>
    [MetaClass]
    public partial interface ExpansionNode : ObjectNode
    {
    	/// <summary>
    	/// The ExpansionRegion for which the ExpansionNode is an input.
    	/// </summary>
    	[Opposite(typeof(ExpansionRegion), "InputElement")]
    	ExpansionRegion? RegionAsInput { get; set; }
    	
    	/// <summary>
    	/// The ExpansionRegion for which the ExpansionNode is an output.
    	/// </summary>
    	[Opposite(typeof(ExpansionRegion), "OutputElement")]
    	ExpansionRegion? RegionAsOutput { get; set; }
    	
    }
    

    /// <summary>
    /// An ExpansionRegion is a StructuredActivityNode that executes its content multiple times corresponding to elements of input collection(s).
    /// </summary>
    [MetaClass]
    public partial interface ExpansionRegion : StructuredActivityNode
    {
    	/// <summary>
    	/// The ExpansionNodes that hold the input collections for the ExpansionRegion.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ExpansionNode), "RegionAsInput")]
    	IList<ExpansionNode> InputElement { get; }
    	
    	/// <summary>
    	/// The mode in which the ExpansionRegion executes its contents. If parallel, executions are concurrent. If iterative, executions are sequential. If stream, a stream of values flows into a single execution.
    	/// </summary>
    	[DefaultValue(ExpansionKind.Iterative)]
    	ExpansionKind Mode { get; set; }
    	
    	/// <summary>
    	/// The ExpansionNodes that form the output collections of the ExpansionRegion.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ExpansionNode), "RegionAsOutput")]
    	IList<ExpansionNode> OutputElement { get; }
    	
    }
    

    /// <summary>
    /// An InputPin is a Pin that holds input values to be consumed by an Action.
    /// </summary>
    [MetaClass]
    public partial interface InputPin : Pin
    {
    }
    

    /// <summary>
    /// InvocationAction is an abstract class for the various actions that request Behavior invocation.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface InvocationAction : Action
    {
    	/// <summary>
    	/// The InputPins that provide the argument values passed in the invocation request.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "InvocationAction")]
    	[Subsets(typeof(Action), "Input")]
    	IList<InputPin> Argument { get; }
    	
    	/// <summary>
    	/// For CallOperationActions, SendSignalActions, and SendObjectActions, an optional Port of the target object through which the invocation request is sent.
    	/// </summary>
    	[Opposite(typeof(Port), "InvocationAction")]
    	Port? OnPort { get; set; }
    	
    }
    

    /// <summary>
    /// LinkAction is an abstract class for all Actions that identify the links to be acted on using LinkEndData.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface LinkAction : Action
    {
    	/// <summary>
    	/// The LinkEndData identifying the values on the ends of the links acting on by this LinkAction.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(LinkEndData), "LinkAction")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<LinkEndData> EndData { get; }
    	
    	/// <summary>
    	/// InputPins used by the LinkEndData of the LinkAction.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(InputPin), "LinkAction")]
    	[Subsets(typeof(Action), "Input")]
    	IList<InputPin> InputValue { get; }
    	
    }
    

    /// <summary>
    /// LinkEndCreationData is LinkEndData used to provide values for one end of a link to be created by a CreateLinkAction.
    /// </summary>
    [MetaClass]
    public partial interface LinkEndCreationData : LinkEndData
    {
    	/// <summary>
    	/// For ordered Association ends, the InputPin that provides the position where the new link should be inserted or where an existing link should be moved to. The type of the insertAt InputPin is UnlimitedNatural, but the input cannot be zero. It is omitted for Association ends that are not ordered.
    	/// </summary>
    	[Opposite(typeof(InputPin), "LinkEndCreationData")]
    	InputPin? InsertAt { get; set; }
    	
    	/// <summary>
    	/// Specifies whether the existing links emanating from the object on this end should be destroyed before creating a new link.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsReplaceAll { get; set; }
    	
    	IList<InputPin> LinkEndData.AllPins()
    	{
    		return this.AllPins();
    	}
    	
    }
    

    /// <summary>
    /// LinkEndData is an Element that identifies on end of a link to be read or written by a LinkAction. As a link (that is not a link object) cannot be passed as a runtime value to or from an Action, it is instead identified by its end objects and qualifier values, if any. A LinkEndData instance provides these values for a single Association end.
    /// </summary>
    [MetaClass]
    public partial interface LinkEndData : Element
    {
    	/// <summary>
    	/// The Association end for which this LinkEndData specifies values.
    	/// </summary>
    	[Opposite(typeof(Property), "LinkEndData")]
    	Property End { get; set; }
    	
    	/// <summary>
    	/// A set of QualifierValues used to provide values for the qualifiers of the end.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(QualifierValue), "LinkEndData")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<QualifierValue> Qualifier { get; }
    	
    	/// <summary>
    	/// The InputPin that provides the specified value for the given end. This InputPin is omitted if the LinkEndData specifies the &quot;open&quot; end for a ReadLinkAction.
    	/// </summary>
    	[Opposite(typeof(InputPin), "LinkEndData")]
    	InputPin? Value { get; set; }
    	
    }
    

    /// <summary>
    /// LinkEndDestructionData is LinkEndData used to provide values for one end of a link to be destroyed by a DestroyLinkAction.
    /// </summary>
    [MetaClass]
    public partial interface LinkEndDestructionData : LinkEndData
    {
    	/// <summary>
    	/// The InputPin that provides the position of an existing link to be destroyed in an ordered, nonunique Association end. The type of the destroyAt InputPin is UnlimitedNatural, but the value cannot be zero or unlimited.
    	/// </summary>
    	[Opposite(typeof(InputPin), "LinkEndDestructionData")]
    	InputPin? DestroyAt { get; set; }
    	
    	/// <summary>
    	/// Specifies whether to destroy duplicates of the value in nonunique Association ends.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsDestroyDuplicates { get; set; }
    	
    	IList<InputPin> LinkEndData.AllPins()
    	{
    		return this.AllPins();
    	}
    	
    }
    

    /// <summary>
    /// A LoopNode is a StructuredActivityNode that represents an iterative loop with setup, test, and body sections.
    /// </summary>
    [MetaClass]
    public partial interface LoopNode : StructuredActivityNode
    {
    	/// <summary>
    	/// The OutputPins on Actions within the bodyPart, the values of which are moved to the loopVariable OutputPins after the completion of each execution of the bodyPart, before the next iteration of the loop begins or before the loop exits.
    	/// </summary>
    	[Opposite(typeof(OutputPin), "LoopNode")]
    	IList<OutputPin> BodyOutput { get; }
    	
    	/// <summary>
    	/// The set of ExecutableNodes that perform the repetitive computations of the loop. The bodyPart is executed as long as the test section produces a true value.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ExecutableNode), "LoopNode")]
    	IList<ExecutableNode> BodyPart { get; }
    	
    	/// <summary>
    	/// An OutputPin on an Action in the test section whose Boolean value determines whether to continue executing the loop bodyPart.
    	/// </summary>
    	[Opposite(typeof(OutputPin), "LoopNode")]
    	OutputPin Decider { get; set; }
    	
    	/// <summary>
    	/// If true, the test is performed before the first execution of the bodyPart. If false, the bodyPart is executed once before the test is performed.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsTestedFirst { get; set; }
    	
    	/// <summary>
    	/// A list of OutputPins that hold the values of the loop variables during an execution of the loop. When the test fails, the values are moved to the result OutputPins of the loop.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "LoopNode")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<OutputPin> LoopVariable { get; }
    	
    	/// <summary>
    	/// A list of InputPins whose values are moved into the loopVariable Pins before the first iteration of the loop.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "LoopNode")]
    	[Redefines(typeof(StructuredActivityNode), "StructuredNodeInput")]
    	IList<InputPin> LoopVariableInput { get; }
    	
    	/// <summary>
    	/// A list of OutputPins that receive the loopVariable values after the last iteration of the loop and constitute the output of the LoopNode.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "LoopNode")]
    	[Redefines(typeof(StructuredActivityNode), "StructuredNodeOutput")]
    	IList<OutputPin> Result { get; }
    	
    	/// <summary>
    	/// The set of ExecutableNodes executed before the first iteration of the loop, in order to initialize values or perform other setup computations.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ExecutableNode), "LoopNode")]
    	IList<ExecutableNode> SetupPart { get; }
    	
    	/// <summary>
    	/// The set of ExecutableNodes executed in order to provide the test result for the loop.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(ExecutableNode), "LoopNode")]
    	IList<ExecutableNode> Test { get; }
    	
    	IList<Action> StructuredActivityNode.AllActions()
    	{
    		return this.AllActions();
    	}
    	
    	IList<Action> Action.AllActions()
    	{
    		return this.AllActions();
    	}
    	
    	IList<ActivityNode> StructuredActivityNode.SourceNodes()
    	{
    		return this.SourceNodes();
    	}
    	
    }
    

    /// <summary>
    /// An OpaqueAction is an Action whose functionality is not specified within UML.
    /// </summary>
    [MetaClass]
    public partial interface OpaqueAction : Action
    {
    	/// <summary>
    	/// Provides a textual specification of the functionality of the Action, in one or more languages other than UML.
    	/// </summary>
    	[NonUnique]
    	IList<string> Body { get; }
    	
    	/// <summary>
    	/// The InputPins providing inputs to the OpaqueAction.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(InputPin), "OpaqueAction")]
    	[Subsets(typeof(Action), "Input")]
    	IList<InputPin> InputValue { get; }
    	
    	/// <summary>
    	/// If provided, a specification of the language used for each of the body Strings.
    	/// </summary>
    	IList<string> Language { get; }
    	
    	/// <summary>
    	/// The OutputPins on which the OpaqueAction provides outputs.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(OutputPin), "OpaqueAction")]
    	[Subsets(typeof(Action), "Output")]
    	IList<OutputPin> OutputValue { get; }
    	
    }
    

    /// <summary>
    /// An OutputPin is a Pin that holds output values produced by an Action.
    /// </summary>
    [MetaClass]
    public partial interface OutputPin : Pin
    {
    }
    

    /// <summary>
    /// A Pin is an ObjectNode and MultiplicityElement that provides input values to an Action or accepts output values from an Action.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface Pin : ObjectNode, MultiplicityElement
    {
    	/// <summary>
    	/// Indicates whether the Pin provides data to the Action or just controls how the Action executes.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsControl { get; set; }
    	
    }
    

    /// <summary>
    /// A QualifierValue is an Element that is used as part of LinkEndData to provide the value for a single qualifier of the end given by the LinkEndData.
    /// </summary>
    [MetaClass]
    public partial interface QualifierValue : Element
    {
    	/// <summary>
    	/// The qualifier Property for which the value is to be specified.
    	/// </summary>
    	[Opposite(typeof(Property), "QualifierValue")]
    	Property Qualifier { get; set; }
    	
    	/// <summary>
    	/// The InputPin from which the specified value for the qualifier is taken.
    	/// </summary>
    	[Opposite(typeof(InputPin), "QualifierValue")]
    	InputPin Value { get; set; }
    	
    }
    

    /// <summary>
    /// A RaiseExceptionAction is an Action that causes an exception to occur. The input value becomes the exception object.
    /// </summary>
    [MetaClass]
    public partial interface RaiseExceptionAction : Action
    {
    	/// <summary>
    	/// An InputPin whose value becomes the exception object.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "RaiseExceptionAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Exception { get; set; }
    	
    }
    

    /// <summary>
    /// A ReadExtentAction is an Action that retrieves the current instances of a Classifier.
    /// </summary>
    [MetaClass]
    public partial interface ReadExtentAction : Action
    {
    	/// <summary>
    	/// The Classifier whose instances are to be retrieved.
    	/// </summary>
    	[Opposite(typeof(Classifier), "ReadExtentAction")]
    	Classifier Classifier { get; set; }
    	
    	/// <summary>
    	/// The OutputPin on which the Classifier instances are placed.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "ReadExtentAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin Result { get; set; }
    	
    }
    

    /// <summary>
    /// A ReadIsClassifiedObjectAction is an Action that determines whether an object is classified by a given Classifier.
    /// </summary>
    [MetaClass]
    public partial interface ReadIsClassifiedObjectAction : Action
    {
    	/// <summary>
    	/// The Classifier against which the classification of the input object is tested.
    	/// </summary>
    	[Opposite(typeof(Classifier), "ReadIsClassifiedObjectAction")]
    	Classifier Classifier { get; set; }
    	
    	/// <summary>
    	/// Indicates whether the input object must be directly classified by the given Classifier or whether it may also be an instance of a specialization of the given Classifier.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsDirect { get; set; }
    	
    	/// <summary>
    	/// The InputPin that holds the object whose classification is to be tested.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "ReadIsClassifiedObjectAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Object { get; set; }
    	
    	/// <summary>
    	/// The OutputPin that holds the Boolean result of the test.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "ReadIsClassifiedObjectAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin Result { get; set; }
    	
    }
    

    /// <summary>
    /// A ReadLinkAction is a LinkAction that navigates across an Association to retrieve the objects on one end.
    /// </summary>
    [MetaClass]
    public partial interface ReadLinkAction : LinkAction
    {
    	/// <summary>
    	/// The OutputPin on which the objects retrieved from the &quot;open&quot; end of those links whose values on other ends are given by the endData.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "ReadLinkAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin Result { get; set; }
    	
    }
    

    /// <summary>
    /// A ReadLinkObjectEndAction is an Action that retrieves an end object from a link object.
    /// </summary>
    [MetaClass]
    public partial interface ReadLinkObjectEndAction : Action
    {
    	/// <summary>
    	/// The Association end to be read.
    	/// </summary>
    	[Opposite(typeof(Property), "ReadLinkObjectEndAction")]
    	Property End { get; set; }
    	
    	/// <summary>
    	/// The input pin from which the link object is obtained.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "ReadLinkObjectEndAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Object { get; set; }
    	
    	/// <summary>
    	/// The OutputPin where the result value is placed.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "ReadLinkObjectEndAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin Result { get; set; }
    	
    }
    

    /// <summary>
    /// A ReadLinkObjectEndQualifierAction is an Action that retrieves a qualifier end value from a link object.
    /// </summary>
    [MetaClass]
    public partial interface ReadLinkObjectEndQualifierAction : Action
    {
    	/// <summary>
    	/// The InputPin from which the link object is obtained.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "ReadLinkObjectEndQualifierAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Object { get; set; }
    	
    	/// <summary>
    	/// The qualifier Property to be read.
    	/// </summary>
    	[Opposite(typeof(Property), "ReadLinkObjectEndQualifierAction")]
    	Property Qualifier { get; set; }
    	
    	/// <summary>
    	/// The OutputPin where the result value is placed.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "ReadLinkObjectEndQualifierAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin Result { get; set; }
    	
    }
    

    /// <summary>
    /// A ReadSelfAction is an Action that retrieves the context object of the Behavior execution within which the ReadSelfAction execution is taking place.
    /// </summary>
    [MetaClass]
    public partial interface ReadSelfAction : Action
    {
    	/// <summary>
    	/// The OutputPin on which the context object is placed.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "ReadSelfAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin Result { get; set; }
    	
    }
    

    /// <summary>
    /// A ReadStructuralFeatureAction is a StructuralFeatureAction that retrieves the values of a StructuralFeature.
    /// </summary>
    [MetaClass]
    public partial interface ReadStructuralFeatureAction : StructuralFeatureAction
    {
    	/// <summary>
    	/// The OutputPin on which the result values are placed.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "ReadStructuralFeatureAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin Result { get; set; }
    	
    }
    

    /// <summary>
    /// A ReadVariableAction is a VariableAction that retrieves the values of a Variable.
    /// </summary>
    [MetaClass]
    public partial interface ReadVariableAction : VariableAction
    {
    	/// <summary>
    	/// The OutputPin on which the result values are placed.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "ReadVariableAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin Result { get; set; }
    	
    }
    

    /// <summary>
    /// A ReclassifyObjectAction is an Action that changes the Classifiers that classify an object.
    /// </summary>
    [MetaClass]
    public partial interface ReclassifyObjectAction : Action
    {
    	/// <summary>
    	/// Specifies whether existing Classifiers should be removed before adding the new Classifiers.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsReplaceAll { get; set; }
    	
    	/// <summary>
    	/// A set of Classifiers to be added to the Classifiers of the given object.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Classifier), "ReclassifyObjectAction")]
    	IList<Classifier> NewClassifier { get; }
    	
    	/// <summary>
    	/// The InputPin that holds the object to be reclassified.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "ReclassifyObjectAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Object { get; set; }
    	
    	/// <summary>
    	/// A set of Classifiers to be removed from the Classifiers of the given object.
    	/// </summary>
    	[Unordered]
    	[Opposite(typeof(Classifier), "ReclassifyObjectAction")]
    	IList<Classifier> OldClassifier { get; }
    	
    }
    

    /// <summary>
    /// A ReduceAction is an Action that reduces a collection to a single value by repeatedly combining the elements of the collection using a reducer Behavior.
    /// </summary>
    [MetaClass]
    public partial interface ReduceAction : Action
    {
    	/// <summary>
    	/// The InputPin that provides the collection to be reduced.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "ReduceAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Collection { get; set; }
    	
    	/// <summary>
    	/// Indicates whether the order of the input collection should determine the order in which the reducer Behavior is applied to its elements.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsOrdered { get; set; }
    	
    	/// <summary>
    	/// A Behavior that is repreatedly applied to two elements of the input collection to produce a value that is of the same type as elements of the collection.
    	/// </summary>
    	[Opposite(typeof(Behavior), "ReduceAction")]
    	Behavior Reducer { get; set; }
    	
    	/// <summary>
    	/// The output pin on which the result value is placed.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "ReduceAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin Result { get; set; }
    	
    }
    

    /// <summary>
    /// A RemoveStructuralFeatureValueAction is a WriteStructuralFeatureAction that removes values from a StructuralFeature.
    /// </summary>
    [MetaClass]
    public partial interface RemoveStructuralFeatureValueAction : WriteStructuralFeatureAction
    {
    	/// <summary>
    	/// Specifies whether to remove duplicates of the value in nonunique StructuralFeatures.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsRemoveDuplicates { get; set; }
    	
    	/// <summary>
    	/// An InputPin that provides the position of an existing value to remove in ordered, nonunique structural features. The type of the removeAt InputPin is UnlimitedNatural, but the value cannot be zero or unlimited.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "RemoveStructuralFeatureValueAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin? RemoveAt { get; set; }
    	
    }
    

    /// <summary>
    /// A RemoveVariableValueAction is a WriteVariableAction that removes values from a Variables.
    /// </summary>
    [MetaClass]
    public partial interface RemoveVariableValueAction : WriteVariableAction
    {
    	/// <summary>
    	/// Specifies whether to remove duplicates of the value in nonunique Variables.
    	/// </summary>
    	[DefaultValue(false)]
    	bool IsRemoveDuplicates { get; set; }
    	
    	/// <summary>
    	/// An InputPin that provides the position of an existing value to remove in ordered, nonunique Variables. The type of the removeAt InputPin is UnlimitedNatural, but the value cannot be zero or unlimited.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "RemoveVariableValueAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin? RemoveAt { get; set; }
    	
    }
    

    /// <summary>
    /// A ReplyAction is an Action that accepts a set of reply values and a value containing return information produced by a previous AcceptCallAction. The ReplyAction returns the values to the caller of the previous call, completing execution of the call.
    /// </summary>
    [MetaClass]
    public partial interface ReplyAction : Action
    {
    	/// <summary>
    	/// The Trigger specifying the Operation whose call is being replied to.
    	/// </summary>
    	[Opposite(typeof(Trigger), "ReplyAction")]
    	Trigger ReplyToCall { get; set; }
    	
    	/// <summary>
    	/// A list of InputPins providing the values for the output (inout, out, and return) Parameters of the Operation. These values are returned to the caller.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "ReplyAction")]
    	[Subsets(typeof(Action), "Input")]
    	IList<InputPin> ReplyValue { get; }
    	
    	/// <summary>
    	/// An InputPin that holds the return information value produced by an earlier AcceptCallAction.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "ReplyAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin ReturnInformation { get; set; }
    	
    }
    

    /// <summary>
    /// A SendObjectAction is an InvocationAction that transmits an input object to the target object, which is handled as a request message by the target object. The requestor continues execution immediately after the object is sent out and cannot receive reply values.
    /// </summary>
    [MetaClass]
    public partial interface SendObjectAction : InvocationAction
    {
    	/// <summary>
    	/// The request object, which is transmitted to the target object. The object may be copied in transmission, so identity might not be preserved.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "SendObjectAction")]
    	[Redefines(typeof(InvocationAction), "Argument")]
    	InputPin Request { get; set; }
    	
    	/// <summary>
    	/// The target object to which the object is sent.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "SendObjectAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Target { get; set; }
    	
    }
    

    /// <summary>
    /// A SendSignalAction is an InvocationAction that creates a Signal instance and transmits it to the target object. Values from the argument InputPins are used to provide values for the attributes of the Signal. The requestor continues execution immediately after the Signal instance is sent out and cannot receive reply values.
    /// </summary>
    [MetaClass]
    public partial interface SendSignalAction : InvocationAction
    {
    	/// <summary>
    	/// The Signal whose instance is transmitted to the target.
    	/// </summary>
    	[Opposite(typeof(Signal), "SendSignalAction")]
    	Signal Signal { get; set; }
    	
    	/// <summary>
    	/// The InputPin that provides the target object to which the Signal instance is sent.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "SendSignalAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Target { get; set; }
    	
    }
    

    /// <summary>
    /// A SequenceNode is a StructuredActivityNode that executes a sequence of ExecutableNodes in order.
    /// </summary>
    [MetaClass]
    public partial interface SequenceNode : StructuredActivityNode
    {
    	/// <summary>
    	/// The ordered set of ExecutableNodes to be sequenced.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ExecutableNode), "SequenceNode")]
    	[Redefines(typeof(StructuredActivityNode), "Node")]
    	IList<ExecutableNode> ExecutableNode { get; }
    	
    }
    

    /// <summary>
    /// A StartClassifierBehaviorAction is an Action that starts the classifierBehavior of the input object.
    /// </summary>
    [MetaClass]
    public partial interface StartClassifierBehaviorAction : Action
    {
    	/// <summary>
    	/// The InputPin that holds the object whose classifierBehavior is to be started.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "StartClassifierBehaviorAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Object { get; set; }
    	
    }
    

    /// <summary>
    /// A StartObjectBehaviorAction is an InvocationAction that starts the execution either of a directly instantiated Behavior or of the classifierBehavior of an object. Argument values may be supplied for the input Parameters of the Behavior. If the Behavior is invoked synchronously, then output values may be obtained for output Parameters.
    /// </summary>
    [MetaClass]
    public partial interface StartObjectBehaviorAction : CallAction
    {
    	/// <summary>
    	/// An InputPin that holds the object that is either a Behavior to be started or has a classifierBehavior to be started.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "StartObjectBehaviorAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Object { get; set; }
    	
    	IList<Parameter> CallAction.OutputParameters()
    	{
    		return this.OutputParameters();
    	}
    	
    	IList<Parameter> CallAction.InputParameters()
    	{
    		return this.InputParameters();
    	}
    	
    }
    

    /// <summary>
    /// StructuralFeatureAction is an abstract class for all Actions that operate on StructuralFeatures.
    /// </summary>
    [MetaClass(IsAbstract = true)]
    public partial interface StructuralFeatureAction : Action
    {
    	/// <summary>
    	/// The InputPin from which the object whose StructuralFeature is to be read or written is obtained.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "StructuralFeatureAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Object { get; set; }
    	
    	/// <summary>
    	/// The StructuralFeature to be read or written.
    	/// </summary>
    	[Opposite(typeof(StructuralFeature), "StructuralFeatureAction")]
    	StructuralFeature StructuralFeature { get; set; }
    	
    }
    

    /// <summary>
    /// A StructuredActivityNode is an Action that is also an ActivityGroup and whose behavior is specified by the ActivityNodes and ActivityEdges it so contains. Unlike other kinds of ActivityGroup, a StructuredActivityNode owns the ActivityNodes and ActivityEdges it contains, and so a node or edge can only be directly contained in one StructuredActivityNode, though StructuredActivityNodes may be nested.
    /// </summary>
    [MetaClass]
    public partial interface StructuredActivityNode : Namespace, ActivityGroup, Action
    {
    	/// <summary>
    	/// The Activity immediately containing the StructuredActivityNode, if it is not contained in another StructuredActivityNode.
    	/// </summary>
    	[Opposite(typeof(Activity), "StructuredNode")]
    	[Redefines(typeof(ActivityGroup), "InActivity")]
    	[Redefines(typeof(ActivityNode), "Activity")]
    	new Activity? Activity { get; set; }
    	
    	/// <summary>
    	/// The ActivityEdges immediately contained in the StructuredActivityNode.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ActivityEdge), "InStructuredNode")]
    	[Subsets(typeof(ActivityGroup), "ContainedEdge")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ActivityEdge> Edge { get; }
    	
    	/// <summary>
    	/// If true, then any object used by an Action within the StructuredActivityNode cannot be accessed by any Action outside the node until the StructuredActivityNode as a whole completes. Any concurrent Actions that would result in accessing such objects are required to have their execution deferred until the completion of the StructuredActivityNode.
    	/// </summary>
    	[DefaultValue(false)]
    	bool MustIsolate { get; set; }
    	
    	/// <summary>
    	/// The ActivityNodes immediately contained in the StructuredActivityNode.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(ActivityNode), "InStructuredNode")]
    	[Subsets(typeof(ActivityGroup), "ContainedNode")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	IList<ActivityNode> Node { get; }
    	
    	/// <summary>
    	/// The InputPins owned by the StructuredActivityNode.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(InputPin), "StructuredActivityNode")]
    	[Subsets(typeof(Action), "Input")]
    	IList<InputPin> StructuredNodeInput { get; }
    	
    	/// <summary>
    	/// The OutputPins owned by the StructuredActivityNode.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(OutputPin), "StructuredActivityNode")]
    	[Subsets(typeof(Action), "Output")]
    	IList<OutputPin> StructuredNodeOutput { get; }
    	
    	/// <summary>
    	/// The Variables defined in the scope of the StructuredActivityNode.
    	/// </summary>
    	[Containment]
    	[Unordered]
    	[Opposite(typeof(Variable), "Scope")]
    	[Subsets(typeof(Namespace), "OwnedMember")]
    	IList<Variable> Variable { get; }
    	
    	IList<Action> Action.AllActions()
    	{
    		return this.AllActions();
    	}
    	
    	IList<ActivityNode> Action.AllOwnedNodes()
    	{
    		return this.AllOwnedNodes();
    	}
    	
    	Activity? ActivityGroup.ContainingActivity()
    	{
    		return this.ContainingActivity();
    	}
    	
    	Activity? ActivityNode.ContainingActivity()
    	{
    		return this.ContainingActivity();
    	}
    	
    }
    

    /// <summary>
    /// A TestIdentityAction is an Action that tests if two values are identical objects.
    /// </summary>
    [MetaClass]
    public partial interface TestIdentityAction : Action
    {
    	/// <summary>
    	/// The InputPin on which the first input object is placed.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "TestIdentityAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin First { get; set; }
    	
    	/// <summary>
    	/// The OutputPin whose Boolean value indicates whether the two input objects are identical.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "TestIdentityAction")]
    	[Subsets(typeof(Action), "Output")]
    	OutputPin Result { get; set; }
    	
    	/// <summary>
    	/// The OutputPin on which the second input object is placed.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "TestIdentityAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Second { get; set; }
    	
    }
    

    /// <summary>
    /// An UnmarshallAction is an Action that retrieves the values of the StructuralFeatures of an object and places them on OutputPins. 
    /// </summary>
    [MetaClass]
    public partial interface UnmarshallAction : Action
    {
    	/// <summary>
    	/// The InputPin that gives the object to be unmarshalled.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(InputPin), "UnmarshallAction")]
    	[Subsets(typeof(Action), "Input")]
    	InputPin Object { get; set; }
    	
    	/// <summary>
    	/// The OutputPins on which are placed the values of the StructuralFeatures of the input object.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(OutputPin), "UnmarshallAction")]
    	[Subsets(typeof(Action), "Output")]
    	IList<OutputPin> Result { get; }
    	
    	/// <summary>
    	/// The type of the object to be unmarshalled.
    	/// </summary>
    	[Opposite(typeof(Classifier), "UnmarshallAction")]
    	Classifier UnmarshallType { get; set; }
    	
    }
    

    /// <summary>
    /// A ValuePin is an InputPin that provides a value by evaluating a ValueSpecification.
    /// </summary>
    [MetaClass]
    public partial interface ValuePin : InputPin
    {
    	/// <summary>
    	/// The ValueSpecification that is evaluated to obtain the value that the ValuePin will provide.
    	/// </summary>
    	[Containment]
    	[Opposite(typeof(ValueSpecification), "ValuePin")]
    	[Subsets(typeof(Element), "OwnedElement")]
    	ValueSpecification Value { get; set; }
    	
    }
    
}
