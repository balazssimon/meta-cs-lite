using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
namespace MetaDslx.Languages.Uml.MetaModel
{
    public partial interface Activity
    {
    }
    
    public partial interface ActivityEdge
    {
    	// spec:
    	//     result = (redefiningElement.oclIsKindOf(ActivityEdge))
    	public new bool IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		return redefiningElement is ActivityEdge;
    	}
    	
    }
    
    public partial interface ActivityFinalNode
    {
    }
    
    public partial interface ActivityGroup
    {
    	/// <summary>
    	/// The Activity that directly or indirectly contains this ActivityGroup.
    	/// </summary>
    	// spec:
    	//     result = (if superGroup<>null then superGroup.containingActivity()
    	//     else inActivity
    	//     endif)
    	public Activity? ContainingActivity()
    	{
            if (SuperGroup is not null) return SuperGroup.ContainingActivity();
            else return InActivity;
    	}
    	
    }
    
    public partial interface ActivityNode
    {
    	/// <summary>
    	/// The Activity that directly or indirectly contains this ActivityNode.
    	/// </summary>
    	// spec:
    	//     result = (if inStructuredNode<>null then inStructuredNode.containingActivity()
    	//     else activity
    	//     endif)
    	public Activity? ContainingActivity()
    	{
            if (InStructuredNode is not null) return InStructuredNode.ContainingActivity();
            else return Activity;
    	}
    	
    	// spec:
    	//     result = (redefiningElement.oclIsKindOf(ActivityNode))
    	public new bool IsConsistentWith(RedefinableElement redefiningElement)
    	{
            return redefiningElement is ActivityNode;
    	}
    	
    }
    
    public partial interface ActivityParameterNode
    {
    }
    
    public partial interface ActivityPartition
    {
    }
    
    public partial interface CentralBufferNode
    {
    }
    
    public partial interface ControlFlow
    {
    }
    
    public partial interface ControlNode
    {
    }
    
    public partial interface DataStoreNode
    {
    }
    
    public partial interface DecisionNode
    {
    }
    
    public partial interface ExceptionHandler
    {
    }
    
    public partial interface ExecutableNode
    {
    }
    
    public partial interface FinalNode
    {
    }
    
    public partial interface FlowFinalNode
    {
    }
    
    public partial interface ForkNode
    {
    }
    
    public partial interface InitialNode
    {
    }
    
    public partial interface InterruptibleActivityRegion
    {
    }
    
    public partial interface JoinNode
    {
    }
    
    public partial interface MergeNode
    {
    }
    
    public partial interface ObjectFlow
    {
    }
    
    public partial interface ObjectNode
    {
    }
    
    public partial interface Variable
    {
    	/// <summary>
    	/// A Variable is accessible by Actions within its scope (the Activity or StructuredActivityNode that owns it).
    	/// </summary>
    	// spec:
    	//     result = (if scope<>null then scope.allOwnedNodes()->includes(a)
    	//     else a.containingActivity()=activityScope
    	//     endif)
    	public bool IsAccessibleBy(Action a)
    	{
            if (Scope is not null) return Scope.AllOwnedNodes().Contains(a);
            else return a.ContainingActivity() == ActivityScope;
    	}
    	
    }
    
    public partial interface Duration
    {
    }
    
    public partial interface DurationConstraint
    {
    }
    
    public partial interface DurationInterval
    {
    }
    
    public partial interface DurationObservation
    {
    }
    
    public partial interface Expression
    {
    }
    
    public partial interface Interval
    {
    }
    
    public partial interface IntervalConstraint
    {
    }
    
    public partial interface LiteralBoolean
    {
    	/// <summary>
    	/// The query booleanValue() gives the value.
    	/// </summary>
    	// spec:
    	//     result = (value)
    	public new bool BooleanValue()
    	{
            return Value;
    	}
    	
    	/// <summary>
    	/// The query isComputable() is redefined to be true.
    	/// </summary>
    	// spec:
    	//     result = (true)
    	public new bool IsComputable()
    	{
            return true;
    	}
    	
    }
    
    public partial interface LiteralInteger
    {
    	/// <summary>
    	/// The query integerValue() gives the value.
    	/// </summary>
    	// spec:
    	//     result = (value)
    	public new int IntegerValue()
    	{
            return Value;
    	}
    	
    	/// <summary>
    	/// The query isComputable() is redefined to be true.
    	/// </summary>
    	// spec:
    	//     result = (true)
    	public new bool IsComputable()
    	{
            return true;
    	}
    	
    }
    
    public partial interface LiteralNull
    {
    	/// <summary>
    	/// The query isComputable() is redefined to be true.
    	/// </summary>
    	// spec:
    	//     result = (true)
    	public new bool IsComputable()
    	{
            return true;
    	}
    	
    	/// <summary>
    	/// The query isNull() returns true.
    	/// </summary>
    	// spec:
    	//     result = (true)
    	public new bool IsNull()
    	{
            return true;
    	}
    	
    }
    
    public partial interface LiteralReal
    {
    	/// <summary>
    	/// The query isComputable() is redefined to be true.
    	/// </summary>
    	// spec:
    	//     result = (true)
    	public new bool IsComputable()
    	{
            return true;
    	}
    	
    	/// <summary>
    	/// The query realValue() gives the value.
    	/// </summary>
    	// spec:
    	//     result = (value)
    	public new double RealValue()
    	{
            return Value;
    	}
    	
    }
    
    public partial interface LiteralSpecification
    {
    }
    
    public partial interface LiteralString
    {
    	/// <summary>
    	/// The query isComputable() is redefined to be true.
    	/// </summary>
    	// spec:
    	//     result = (true)
    	public new bool IsComputable()
    	{
            return true;
    	}
    	
    	/// <summary>
    	/// The query stringValue() gives the value.
    	/// </summary>
    	// spec:
    	//     result = (value)
    	public new string StringValue()
    	{
            return Value;
    	}
    	
    }
    
    public partial interface LiteralUnlimitedNatural
    {
    	/// <summary>
    	/// The query isComputable() is redefined to be true.
    	/// </summary>
    	// spec:
    	//     result = (true)
    	public new bool IsComputable()
    	{
            return true;
    	}
    	
    	/// <summary>
    	/// The query unlimitedValue() gives the value.
    	/// </summary>
    	// spec:
    	//     result = (value)
    	public new long UnlimitedValue()
    	{
            return Value;
    	}
    	
    }
    
    public partial interface Observation
    {
    }
    
    public partial interface OpaqueExpression
    {
    	/// <summary>
    	/// If an OpaqueExpression is specified using a UML Behavior, then this refers to the single required return Parameter of that Behavior. When the Behavior completes execution, the values on this Parameter give the result of evaluating the OpaqueExpression.
    	/// </summary>
    	// spec:
    	//     result = (if behavior = null then
    	//     	null
    	//     else
    	//     	behavior.ownedParameter->first()
    	//     endif)
    	[Derived]
    	[ReadOnly]
    	[Opposite(typeof(Parameter), "OpaqueExpression")]
    	public Parameter? Result
    	{ 
    		get
    		{
                return Behavior?.OwnedParameter.FirstOrDefault();
    		}
    	}
    	
    	/// <summary>
    	/// The query isIntegral() tells whether an expression is intended to produce an Integer.
    	/// </summary>
    	// spec:
    	//     result = (false)
    	public bool IsIntegral()
    	{
            return false;
    	}
    	
    	/// <summary>
    	/// The query isNonNegative() tells whether an integer expression has a non-negative value.
    	/// </summary>
    	// pre:
    	//     self.isIntegral()
    	// spec:
    	//     result = (false)
    	public bool IsNonNegative()
    	{
            //if (!this.IsIntegral()) throw new InvalidOperationException("Pre-condition is violated: self.isIntegral()");
            return false;
    	}
    	
    	/// <summary>
    	/// The query isPositive() tells whether an integer expression has a positive value.
    	/// </summary>
    	// spec:
    	//     result = (false)
    	// pre:
    	//     self.isIntegral()
    	public bool IsPositive()
    	{
            //if (!this.IsIntegral()) throw new InvalidOperationException("Pre-condition is violated: self.isIntegral()");
            return false;
    	}
    	
    	/// <summary>
    	/// The query value() gives an integer value for an expression intended to produce one.
    	/// </summary>
    	// pre:
    	//     self.isIntegral()
    	// spec:
    	//     result = (0)
    	public int Value()
    	{
            //if (!this.IsIntegral()) throw new InvalidOperationException("Pre-condition is violated: self.isIntegral()");
            return 0;
    	}
    	
    }
    
    public partial interface StringExpression
    {
    	/// <summary>
    	/// The query stringValue() returns the String resulting from concatenating, in order, all the component String values of all the operands or subExpressions that are part of the StringExpression.
    	/// </summary>
    	// spec:
    	//     result = (if subExpression->notEmpty()
    	//     then subExpression->iterate(se; stringValue: String = '' | stringValue.concat(se.stringValue()))
    	//     else operand->iterate(op; stringValue: String = '' | stringValue.concat(op.stringValue()))
    	//     endif)
    	public new string StringValue()
    	{
            var sb = new StringBuilder();
            if (SubExpression.Count > 0)
            {
                foreach (var se in SubExpression)
                {
                    sb.Append(se.StringValue());
                }
            }
            else
            {
                foreach (var op in Operand)
                {
                    sb.Append(op.StringValue());
                }
            }
            return sb.ToString();
    	}
    	
    }
    
    public partial interface TimeConstraint
    {
    }
    
    public partial interface TimeExpression
    {
    }
    
    public partial interface TimeInterval
    {
    }
    
    public partial interface TimeObservation
    {
    }
    
    public partial interface ValueSpecification
    {
    	/// <summary>
    	/// The query booleanValue() gives a single Boolean value when one can be computed.
    	/// </summary>
    	// spec:
    	//     result = (null)
    	public bool BooleanValue()
    	{
            return default;
    	}
    	
    	/// <summary>
    	/// The query integerValue() gives a single Integer value when one can be computed.
    	/// </summary>
    	// spec:
    	//     result = (null)
    	public int IntegerValue()
    	{
            return default;
        }
    	
    	/// <summary>
    	/// The query isCompatibleWith() determines if this ValueSpecification is compatible with the specified ParameterableElement. This ValueSpecification is compatible with ParameterableElement p if the kind of this ValueSpecification is the same as or a subtype of the kind of p. Further, if p is a TypedElement, then the type of this ValueSpecification must be conformant with the type of p.
    	/// </summary>
    	// spec:
    	//     result = (self.oclIsKindOf(p.oclType()) and (p.oclIsKindOf(TypedElement) implies 
    	//     self.type.conformsTo(p.oclAsType(TypedElement).type)))
    	public new bool IsCompatibleWith(ParameterableElement p)
    	{
            return p.GetType().IsAssignableFrom(this.GetType()) && (!(p is TypedElement te) || this.Type is not null && te.Type is not null && this.Type.ConformsTo(te.Type));
    	}
    	
    	/// <summary>
    	/// The query isComputable() determines whether a value specification can be computed in a model. This operation cannot be fully defined in OCL. A conforming implementation is expected to deliver true for this operation for all ValueSpecifications that it can compute, and to compute all of those for which the operation is true. A conforming implementation is expected to be able to compute at least the value of all LiteralSpecifications.
    	/// </summary>
    	// spec:
    	//     result = (false)
    	public bool IsComputable()
    	{
            return false;
    	}
    	
    	/// <summary>
    	/// The query isNull() returns true when it can be computed that the value is null.
    	/// </summary>
    	// spec:
    	//     result = (false)
    	public bool IsNull()
    	{
            return false;
    	}
    	
    	/// <summary>
    	/// The query realValue() gives a single Real value when one can be computed.
    	/// </summary>
    	// spec:
    	//     result = (null)
    	public double RealValue()
    	{
            return default;
        }
    	
    	/// <summary>
    	/// The query stringValue() gives a single String value when one can be computed.
    	/// </summary>
    	// spec:
    	//     result = (null)
    	public string StringValue()
    	{
            return String.Empty;
        }
    	
    	/// <summary>
    	/// The query unlimitedValue() gives a single UnlimitedNatural value when one can be computed.
    	/// </summary>
    	// spec:
    	//     result = (null)
    	public long UnlimitedValue()
    	{
            return default;
        }
    	
    }
    
    public partial interface Actor
    {
    }
    
    public partial interface Extend
    {
    }
    
    public partial interface ExtensionPoint
    {
    }
    
    public partial interface Include
    {
    }
    
    public partial interface UseCase
    {
    	/// <summary>
    	/// The query allIncludedUseCases() returns the transitive closure of all UseCases (directly or indirectly) included by this UseCase.
    	/// </summary>
    	// spec:
    	//     result = (self.include.addition->union(self.include.addition->collect(uc | uc.allIncludedUseCases()))->asSet())
    	public IList<UseCase> AllIncludedUseCases()
    	{
    		var result = new List<UseCase>();
            var additions = this.Include.Select(inc => inc.Addition);
            result.UnionWith(additions);
            foreach (var uc in additions)
            {
                result.UnionWith(uc.AllIncludedUseCases());
            }
            return result;
    	}
    	
    }
    
    public partial interface Association
    {
    	/// <summary>
    	/// The Classifiers that are used as types of the ends of the Association.
    	/// </summary>
    	// spec:
    	//     result = (memberEnd->collect(type)->asSet())
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Type), "Association")]
    	[Subsets(typeof(Relationship), "RelatedElement")]
    	public IList<Type> EndType
    	{ 
    		get
    		{
                var result = new List<Type>();
                result.UnionWith(MemberEnd.Where(me => me.Type is not null).Select(me => me.Type!));
                return result;
    		}
    	}
    	
    }
    
    public partial interface AssociationClass
    {
    }
    
    public partial interface Class
    {
    	/// <summary>
    	/// This property is used when the Class is acting as a metaclass. It references the Extensions that specify additional properties of the metaclass. The property is derived from the Extensions whose memberEnds are typed by the Class.
    	/// </summary>
    	// spec:
    	//     result = (Extension.allInstances()->select(ext | 
    	//       let endTypes : Sequence(Classifier) = ext.memberEnd->collect(type.oclAsType(Classifier)) in
    	//       endTypes->includes(self) or endTypes.allParents()->includes(self) ))
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Extension), "Metaclass")]
    	public IList<Extension> Extension
    	{ 
    		get
    		{
                var result = new List<Extension>();
                foreach (var ext in this.AllInstances<Extension>())
                {
                    var endTypes = ext.MemberEnd.OfType<Classifier>();
                    if (endTypes.Contains(this) || endTypes.Any(et => et.AllParents().Contains(this)))
                    {
                        result.Include(ext);
                    }
                }
                return result;
    		}
    	}
    	
    	/// <summary>
    	/// The superclasses of a Class, derived from its Generalizations.
    	/// </summary>
    	// spec:
    	//     result = (self.general()->select(oclIsKindOf(Class))->collect(oclAsType(Class))->asSet())
    	[Derived]
    	[Unordered]
    	[Opposite(typeof(Class), "Class")]
    	[Redefines(typeof(Classifier), "General")]
    	public IList<Class> SuperClass
    	{ 
    		get
    		{
                return this.General.OfType<Class>().AsListSet();
    		}
    	}
    	
    }
    
    public partial interface Collaboration
    {
    }
    
    public partial interface CollaborationUse
    {
    }
    
    public partial interface Component
    {
    	/// <summary>
    	/// The Interfaces that the Component exposes to its environment. These Interfaces may be Realized by the Component or any of its realizingClassifiers, or they may be the Interfaces that are provided by its public Ports.
    	/// </summary>
    	// spec:
    	//     result = (let 	ris : Set(Interface) = allRealizedInterfaces(),
    	//             realizingClassifiers : Set(Classifier) =  self.realization.realizingClassifier->union(self.allParents()->collect(realization.realizingClassifier))->asSet(),
    	//             allRealizingClassifiers : Set(Classifier) = realizingClassifiers->union(realizingClassifiers.allParents())->asSet(),
    	//             realizingClassifierInterfaces : Set(Interface) = allRealizingClassifiers->iterate(c; rci : Set(Interface) = Set{} | rci->union(c.allRealizedInterfaces())),
    	//             ports : Set(Port) = self.ownedPort->union(allParents()->collect(ownedPort))->asSet(),
    	//             providedByPorts : Set(Interface) = ports.provided->asSet()
    	//     in     ris->union(realizingClassifierInterfaces) ->union(providedByPorts)->asSet())
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Interface), "Component")]
    	public IList<Interface> Provided
    	{ 
    		get
    		{
                var ris = AllRealizedInterfaces();
                var realizingClassifiers = this.Realization.SelectMany(r => r.RealizingClassifier).AsListSet().UnionWith(this.AllParents().OfType<Component>().SelectMany(p => p.Realization.SelectMany(r => r.RealizingClassifier)));
                var allRealizingClassifiers = realizingClassifiers.UnionWith(realizingClassifiers.SelectMany(rc => rc.AllParents()));
                var realizingClassifierInterfaces = allRealizingClassifiers.SelectMany(c => c.AllRealizedInterfaces()).AsListSet();
                var ports = this.OwnedPort.AsListSet().UnionWith(this.AllParents().OfType<Component>().SelectMany(p => p.OwnedPort));
                var providedByPorts = ports.SelectMany(p => p.Provided).AsListSet();
                var result = new List<Interface>();
                result.UnionWith(ris);
                result.UnionWith(realizingClassifierInterfaces);
                result.UnionWith(providedByPorts);
                return result;
            }
        }
    	
    	/// <summary>
    	/// The Interfaces that the Component requires from other Components in its environment in order to be able to offer its full set of provided functionality. These Interfaces may be used by the Component or any of its realizingClassifiers, or they may be the Interfaces that are required by its public Ports.
    	/// </summary>
    	// spec:
    	//     result = (let 	uis : Set(Interface) = allUsedInterfaces(),
    	//             realizingClassifiers : Set(Classifier) = self.realization.realizingClassifier->union(self.allParents()->collect(realization.realizingClassifier))->asSet(),
    	//             allRealizingClassifiers : Set(Classifier) = realizingClassifiers->union(realizingClassifiers.allParents())->asSet(),
    	//             realizingClassifierInterfaces : Set(Interface) = allRealizingClassifiers->iterate(c; rci : Set(Interface) = Set{} | rci->union(c.allUsedInterfaces())),
    	//             ports : Set(Port) = self.ownedPort->union(allParents()->collect(ownedPort))->asSet(),
    	//             usedByPorts : Set(Interface) = ports.required->asSet()
    	//     in	    uis->union(realizingClassifierInterfaces)->union(usedByPorts)->asSet()
    	//     )
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Interface), "Component")]
    	public IList<Interface> Required
    	{ 
    		get
    		{
                var uis = AllUsedInterfaces();
                var realizingClassifiers = this.Realization.SelectMany(r => r.RealizingClassifier).AsListSet().UnionWith(this.AllParents().OfType<Component>().SelectMany(p => p.Realization.SelectMany(r => r.RealizingClassifier)));
                var allRealizingClassifiers = realizingClassifiers.UnionWith(realizingClassifiers.SelectMany(rc => rc.AllParents()));
                var realizingClassifierInterfaces = allRealizingClassifiers.SelectMany(c => c.AllUsedInterfaces()).AsListSet();
                var ports = this.OwnedPort.AsListSet().UnionWith(this.AllParents().OfType<Component>().SelectMany(p => p.OwnedPort));
                var usedByPorts = ports.SelectMany(p => p.Required).AsListSet();
                var result = new List<Interface>();
                result.UnionWith(uis);
                result.UnionWith(realizingClassifierInterfaces);
                result.UnionWith(usedByPorts);
                return result;
            }
    	}
    	
    }
    
    public partial interface ComponentRealization
    {
    }
    
    public partial interface ConnectableElement
    {
    	/// <summary>
    	/// A set of ConnectorEnds that attach to this ConnectableElement.
    	/// </summary>
    	// spec:
    	//     result = (ConnectorEnd.allInstances()->select(role = self))
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(ConnectorEnd), "Role")]
    	public IList<ConnectorEnd> End
    	{ 
    		get
    		{
                return this.AllInstances<ConnectorEnd>().Where(ce => ce.Role == this).AsListSet();
    		}
    	}
    	
    }
    
    public partial interface ConnectableElementTemplateParameter
    {
    }
    
    public partial interface Connector
    {
    	/// <summary>
    	/// Indicates the kind of Connector. This is derived: a Connector with one or more ends connected to a Port which is not on a Part and which is not a behavior port is a delegation; otherwise it is an assembly.
    	/// </summary>
    	// spec:
    	//     result = (if end->exists(
    	//     		role.oclIsKindOf(Port) 
    	//     		and partWithPort->isEmpty()
    	//     		and not role.oclAsType(Port).isBehavior)
    	//     then ConnectorKind::delegation 
    	//     else ConnectorKind::assembly 
    	//     endif)
    	[Derived]
    	[ReadOnly]
    	public ConnectorKind Kind
    	{ 
    		get
    		{
                if (End.Any(e => e.Role is Port port && e.PartWithPort is null && !port.IsBehavior)) return ConnectorKind.Delegation;
                else return ConnectorKind.Assembly;
    		}
    	}
    	
    }
    
    public partial interface ConnectorEnd
    {
    	/// <summary>
    	/// A derived property referencing the corresponding end on the Association which types the Connector owing this ConnectorEnd, if any. It is derived by selecting the end at the same place in the ordering of Association ends as this ConnectorEnd.
    	/// </summary>
    	// spec:
    	//     result = (if connector.type = null 
    	//     then
    	//       null 
    	//     else
    	//       let index : Integer = connector.end->indexOf(self) in
    	//         connector.type.memberEnd->at(index)
    	//     endif)
    	[Derived]
    	[ReadOnly]
    	[Opposite(typeof(Property), "ConnectorEnd")]
    	public Property? DefiningEnd
    	{ 
    		get
    		{
                if (Connector?.Type is null) return null;
                var index = Connector.End.IndexOf(this);
                return Connector.Type.MemberEnd[index];
    		}
    	}

        // MetaDslx: added manually, since it was missing from the UML standard
        [Opposite(typeof(Connector), "End")]
        [Subsets(typeof(Element), "Owner")]
        Connector? Connector { get; set; }
    }
    
    public partial interface EncapsulatedClassifier
    {
    	/// <summary>
    	/// The Ports owned by the EncapsulatedClassifier.
    	/// </summary>
    	// spec:
    	//     result = (ownedAttribute->select(oclIsKindOf(Port))->collect(oclAsType(Port))->asOrderedSet())
    	[Containment]
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Port), "EncapsulatedClassifier")]
    	[Subsets(typeof(StructuredClassifier), "OwnedAttribute")]
    	public IList<Port> OwnedPort
    	{ 
    		get
    		{
                return OwnedAttribute.OfType<Port>().AsListSet();
    		}
    	}
    	
    }
    
    public partial interface Port
    {
    	/// <summary>
    	/// The Interfaces specifying the set of Operations and Receptions that the EncapsulatedCclassifier offers to its environment via this Port, and which it will handle either directly or by forwarding it to a part of its internal structure. This association is derived according to the value of isConjugated. If isConjugated is false, provided is derived as the union of the sets of Interfaces realized by the type of the port and its supertypes, or directly from the type of the Port if the Port is typed by an Interface. If isConjugated is true, it is derived as the union of the sets of Interfaces used by the type of the Port and its supertypes.
    	/// </summary>
    	// spec:
    	//     result = (if isConjugated then basicRequired() else basicProvided() endif)
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Interface), "Port")]
    	public IList<Interface> Provided
    	{ 
    		get
    		{
                if (IsConjugated) return BasicRequired();
                else return BasicProvided();
    		}
    	}
    	
    	/// <summary>
    	/// The Interfaces specifying the set of Operations and Receptions that the EncapsulatedCassifier expects its environment to handle via this port. This association is derived according to the value of isConjugated. If isConjugated is false, required is derived as the union of the sets of Interfaces used by the type of the Port and its supertypes. If isConjugated is true, it is derived as the union of the sets of Interfaces realized by the type of the Port and its supertypes, or directly from the type of the Port if the Port is typed by an Interface.
    	/// </summary>
    	// spec:
    	//     result = (if isConjugated then basicProvided() else basicRequired() endif)
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Interface), "Port")]
    	public IList<Interface> Required
    	{ 
    		get
    		{
                if (IsConjugated) return BasicProvided();
                else return BasicRequired();
    		}
    	}
    	
    	/// <summary>
    	/// The union of the sets of Interfaces realized by the type of the Port and its supertypes, or directly the type of the Port if the Port is typed by an Interface.
    	/// </summary>
    	// spec:
    	//     result = (if type.oclIsKindOf(Interface) 
    	//     then type.oclAsType(Interface)->asSet() 
    	//     else type.oclAsType(Classifier).allRealizedInterfaces() 
    	//     endif)
    	public IList<Interface> BasicProvided()
    	{
            if (Type is Interface intf) return UmlUtils.SingleItemList(intf);
            else if (Type is Classifier cls) return cls.AllRealizedInterfaces();
            else return UmlUtils.EmptyList<Interface>();
    	}
    	
    	/// <summary>
    	/// The union of the sets of Interfaces used by the type of the Port and its supertypes.
    	/// </summary>
    	// spec:
    	//     result = ( type.oclAsType(Classifier).allUsedInterfaces() )
    	public IList<Interface> BasicRequired()
    	{
            return (Type as Classifier)?.AllUsedInterfaces() ?? UmlUtils.EmptyList<Interface>();
    	}
    	
    }
    
    public partial interface StructuredClassifier
    {
    	/// <summary>
    	/// The Properties specifying instances that the StructuredClassifier owns by composition. This collection is derived, selecting those owned Properties where isComposite is true.
    	/// </summary>
    	// spec:
    	//     result = (ownedAttribute->select(isComposite))
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Property), "StructuredClassifier")]
    	public IList<Property> Part
    	{ 
    		get
    		{
                return OwnedAttribute.Where(attr => attr.IsComposite).AsListSet();
    		}
    	}
    	
    	/// <summary>
    	/// All features of type ConnectableElement, equivalent to all direct and inherited roles.
    	/// </summary>
    	// spec:
    	//     result = (allFeatures()->select(oclIsKindOf(ConnectableElement))->collect(oclAsType(ConnectableElement))->asSet())
    	public IList<ConnectableElement> AllRoles()
    	{
            return AllFeatures().OfType<ConnectableElement>().AsListSet();
    	}
    	
    }
    
    public partial interface ConnectionPointReference
    {
    	/// <summary>
    	/// The query isConsistentWith() specifies a ConnectionPointReference can only be redefined by a ConnectionPointReference.
    	/// </summary>
    	// pre:
    	//     redefiningElement.isRedefinitionContextValid(self)
    	// spec:
    	//     result = redefiningElement.oclIsKindOf(ConnectionPointReference)
    	public new bool IsConsistentWith(RedefinableElement redefiningElement)
    	{
            //if (!redefiningElement.IsRedefinitionContextValid(this)) throw new InvalidOperationException("Pre-condition is violated: redefiningElement.isRedefinitionContextValid(self)");
            return redefiningElement is ConnectionPointReference;
    	}
    	
    }
    
    public partial interface FinalState
    {
    	/// <summary>
    	/// The query isConsistentWith() specifies a FinalState can only be redefined by a FinalState.
    	/// </summary>
    	// pre:
    	//     redefiningElement.isRedefinitionContextValid(self)
    	// spec:
    	//     result = redefiningElement.oclIsKindOf(FinalState)
    	public new bool IsConsistentWith(RedefinableElement redefiningElement)
    	{
            //if (!redefiningElement.IsRedefinitionContextValid(this)) throw new InvalidOperationException("Pre-condition is violated: redefiningElement.isRedefinitionContextValid(self)");
            return redefiningElement is FinalState;
    	}
    	
    }
    
    public partial interface ProtocolConformance
    {
    }
    
    public partial interface ProtocolStateMachine
    {
    }
    
    public partial interface ProtocolTransition
    {
    	/// <summary>
    	/// This association refers to the associated Operation. It is derived from the Operation of the CallEvent Trigger when applicable.
    	/// </summary>
    	// spec:
    	//     result = (trigger->collect(event)->select(oclIsKindOf(CallEvent))->collect(oclAsType(CallEvent).operation)->asSet())
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Operation), "ProtocolTransition")]
    	public IList<Operation> Referred
    	{ 
    		get
    		{
                return Trigger.Select(tr => tr.Event).OfType<CallEvent>().Select(ev => ev.Operation).AsListSet();
    		}
    	}
    	
    }
    
    public partial interface Pseudostate
    {
    	/// <summary>
    	/// The query isConsistentWith() specifies a Pseudostate can only be redefined by a Pseudostate of the same kind.
    	/// </summary>
    	// pre:
    	//     redefiningElement.isRedefinitionContextValid(self)
    	// spec:
    	//     result = (redefiningElement.oclIsKindOf(Pseudostate) and
    	//     redefiningElement.oclAsType(Pseudostate).kind = kind)
    	public new bool IsConsistentWith(RedefinableElement redefiningElement)
    	{
            //if (!redefiningElement.IsRedefinitionContextValid(this)) throw new InvalidOperationException("Pre-condition is violated: redefiningElement.isRedefinitionContextValid(self)");
            return redefiningElement is Pseudostate ps && ps.Kind == Kind;
    	}
    	
    }
    
    public partial interface Region
    {
    	/// <summary>
    	/// References the Classifier in which context this element may be redefined.
    	/// </summary>
    	// spec:
    	//     result = containingStateMachine()
    	[Derived]
    	[ReadOnly]
    	[Opposite(typeof(Classifier), "Region")]
    	[Redefines(typeof(RedefinableElement), "RedefinitionContext")]
    	public new Classifier RedefinitionContext
    	{ 
    		get
    		{
                return ContainingStateMachine();
    		}
    	}
    	
    	/// <summary>
    	/// The operation belongsToPSM () checks if the Region belongs to a ProtocolStateMachine.
    	/// </summary>
    	// spec:
    	//     result = (if  stateMachine <> null 
    	//     then
    	//       stateMachine.oclIsKindOf(ProtocolStateMachine)
    	//     else 
    	//       state <> null  implies  state.container.belongsToPSM()
    	//     endif )
    	public bool BelongsToPSM()
    	{
            if (StateMachine is not null) return StateMachine is ProtocolStateMachine;
            else return State is null || (State.Container?.BelongsToPSM() ?? false);
    	}
    	
    	/// <summary>
    	/// The operation containingStateMachine() returns the StateMachine in which this Region is defined.
    	/// </summary>
    	// spec:
    	//     result = (if stateMachine = null 
    	//     then
    	//       state.containingStateMachine()
    	//     else
    	//       stateMachine
    	//     endif)
    	public StateMachine? ContainingStateMachine()
    	{
            if (StateMachine is null) return State?.ContainingStateMachine();
            else return StateMachine;
    	}
    	
    	/// <summary>
    	/// The query isConsistentWith specifies that a Region can be redefined by any Region for which the redefinition context is valid (see the isRedefinitionContextValid operation). Note that consistency requirements for the redefinition of Vertices and Transitions within a redefining Region are specified by the isConsistentWith and isRedefinitionContextValid operations for Vertex (and its subclasses) and Transition.
    	/// </summary>
    	// spec:
    	//     result = true
    	// pre:
    	//     redefiningElement.isRedefinitionContextValid(self)
    	public new bool IsConsistentWith(RedefinableElement redefiningElement)
    	{
            //if (!redefiningElement.IsRedefinitionContextValid(this)) throw new InvalidOperationException("Pre-condition is violated: redefiningElement.isRedefinitionContextValid(self)");
            return true;
    	}
    	
    	/// <summary>
    	/// The query isRedefinitionContextValid() specifies whether the redefinition contexts of a Region are properly related to the redefinition contexts of the specified Region to allow this element to redefine the other. The containing StateMachine or State of a redefining Region must Redefine the containing StateMachine or State of the redefined Region.
    	/// </summary>
    	// spec:
    	//     result = (if redefinedElement.oclIsKindOf(Region) then
    	//       let redefinedRegion : Region = redefinedElement.oclAsType(Region) in
    	//         if stateMachine->isEmpty() then
    	//         -- the Region is owned by a State
    	//           (state.redefinedState->notEmpty() and state.redefinedState.region->includes(redefinedRegion))
    	//         else -- the region is owned by a StateMachine
    	//           (stateMachine.extendedStateMachine->notEmpty() and
    	//             stateMachine.extendedStateMachine->exists(sm : StateMachine |
    	//               sm.region->includes(redefinedRegion)))
    	//         endif
    	//     else
    	//       false
    	//     endif)
    	public new bool IsRedefinitionContextValid(RedefinableElement redefinedElement)
    	{
    		if (redefinedElement is Region redefinedRegion)
            {
                if (StateMachine is null) // the Region is owned by a State
                {
                    var redefinedState = State?.RedefinedVertex as State;
                    return redefinedState is not null && redefinedState.Region.Contains(redefinedRegion);
                }
                else // the region is owned by a StateMachine
                {
                    return StateMachine.ExtendedStateMachine.Count > 0 && StateMachine.ExtendedStateMachine.Any(sm => sm.Region.Contains(redefinedRegion));
                }
            }
            return false;
    	}
    	
    }
    
    public partial interface State
    {
    	/// <summary>
    	/// A state with isComposite=true is said to be a composite State. A composite State is a State that contains at least one Region.
    	/// </summary>
    	// spec:
    	//     result = (region->notEmpty())
    	[Derived]
    	[ReadOnly]
    	public bool IsComposite
    	{ 
    		get
    		{
                return Region.Count > 0;
    		}
    	}
    	
    	/// <summary>
    	/// A State with isOrthogonal=true is said to be an orthogonal composite State An orthogonal composite State contains two or more Regions.
    	/// </summary>
    	// spec:
    	//     result = (region->size () > 1)
    	[Derived]
    	[ReadOnly]
    	public bool IsOrthogonal
    	{ 
    		get
    		{
                return Region.Count > 1;
    		}
    	}
    	
    	/// <summary>
    	/// A State with isSimple=true is said to be a simple State A simple State does not have any Regions and it does not refer to any submachine StateMachine.
    	/// </summary>
    	// spec:
    	//     result = ((region->isEmpty()) and not isSubmachineState())
    	[Derived]
    	[ReadOnly]
    	public bool IsSimple
    	{ 
    		get
    		{
                return Region.Count == 0 && !IsSubmachineState;
    		}
    	}
    	
    	/// <summary>
    	/// A State with isSubmachineState=true is said to be a submachine State Such a State refers to another StateMachine(submachine).
    	/// </summary>
    	// spec:
    	//     result = (submachine <> null)
    	[Derived]
    	[ReadOnly]
    	public bool IsSubmachineState
    	{ 
    		get
    		{
                return Submachine is not null;
    		}
    	}
    	
    	/// <summary>
    	/// The query containingStateMachine() returns the StateMachine that contains the State either directly or transitively.
    	/// </summary>
    	// spec:
    	//     result = (container.containingStateMachine())
    	public new StateMachine? ContainingStateMachine()
    	{
            return Container?.ContainingStateMachine();
    	}
    	
    	/// <summary>
    	/// The query isConsistentWith specifies that a non-final State can only be redefined by a non-final State (this is overridden by FinalState to allow a FinalState to be redefined by a FinalState) and, if the redefined State is a submachine State, then the redefining State must be a submachine state whose submachine is a redefinition of the submachine of the redefined State. Note that consistency requirements for the redefinition of Regions and connectionPoint Pseudostates within a composite State and connection ConnectionPoints of a submachine State are specified by the isConsistentWith and isRedefinitionContextValid operations for Region and Vertex (and its subclasses, Pseudostate and ConnectionPointReference).
    	/// </summary>
    	// spec:
    	//     result = (redefiningElement.oclIsTypeOf(State) and 
    	//       let redefiningState : State = redefiningElement.oclAsType(State) in
    	//         submachine <> null implies (redefiningState.submachine <> null and
    	//           redefiningState.submachine.extendedStateMachine->includes(submachine)))
    	// pre:
    	//     redefiningElement.isRedefinitionContextValid(self)
    	public new bool IsConsistentWith(RedefinableElement redefiningElement)
    	{
            //if (!redefiningElement.IsRedefinitionContextValid(this)) throw new InvalidOperationException("Pre-condition is violated: redefiningElement.isRedefinitionContextValid(self)");
            var redefiningState = redefiningElement as State;
            if (redefiningState is null) return false;
            return Submachine is null || (redefiningState.Submachine is not null && redefiningState.Submachine.ExtendedStateMachine.Contains(Submachine));
        }
    	
    }
    
    public partial interface StateMachine
    {
    	/// <summary>
    	/// The operation LCA(s1,s2) returns the Region that is the least common ancestor of Vertices s1 and s2, based on the StateMachine containment hierarchy.
    	/// </summary>
    	// spec:
    	//     result = (if ancestor(s1, s2) then 
    	//         s2.container
    	//     else
    	//     	if ancestor(s2, s1) then
    	//     	    s1.container 
    	//     	else 
    	//     	    LCA(s1.container.state, s2.container.state)
    	//     	endif
    	//     endif)
    	public Region? LCA(Vertex? s1, Vertex? s2)
    	{
            if (Ancestor(s1, s2)) return s2?.Container;
            else if (Ancestor(s2, s1)) return s1?.Container;
            else return LCA(s1?.Container?.State, s2?.Container?.State);
    	}
    	
    	/// <summary>
    	/// The query ancestor(s1, s2) checks whether Vertex s2 is an ancestor of Vertex s1.
    	/// </summary>
    	// spec:
    	//     result = (if (s2 = s1) then 
    	//     	true 
    	//     else 
    	//     	if s1.container.stateMachine->notEmpty() then 
    	//     	    true
    	//     	else 
    	//     	    if s2.container.stateMachine->notEmpty() then 
    	//     	        false
    	//     	    else
    	//     	        ancestor(s1, s2.container.state)
    	//     	     endif
    	//     	 endif
    	//     endif  )
    	public bool Ancestor(Vertex? s1, Vertex? s2)
    	{
            if (s1 is null || s2 is null) return false;
            if (s2 == s1) return true;
            else if (s1.Container?.StateMachine is not null) return true;
            else if (s2.Container?.StateMachine is not null) return false;
            else return Ancestor(s1, s2.Container?.State);
    	}

        /// <summary>
        /// The query isConsistentWith specifies that a StateMachine can be redefined by any other StateMachine for which the redefinition context is valid (see the isRedefinitionContextValid operation). Note that consistency requirements for the redefinition of Regions and connectionPoint Pseudostates owned by a StateMachine are specified by the isConsistentWith and isRedefinitionContextValid operations for Region and Vertex (and its subclass Pseudostate).
        /// </summary>
        // pre:
        //     redefiningElement.isRedefinitionContextValid(self)
        // spec:
        //     result = true
        public new bool IsConsistentWith(RedefinableElement redefiningElement)
    	{
            //if (!redefiningElement.IsRedefinitionContextValid(this)) throw new InvalidOperationException("Pre-condition is violated: redefiningElement.isRedefinitionContextValid(self)");
            return true;
    	}
    	
    	/// <summary>
    	/// The query isRedefinitionContextValid specifies whether the redefinition context of a StateMachine is properly related to the redefinition contexts of a StateMachine it redefines. The requirement is that the context BehavioredClassifier of a redefining StateMachine must specialize the context Classifier of the redefined StateMachine. If the redefining StateMachine does not have a context BehavioredClassifier, then then the redefining StateMachine also must not have a context BehavioredClassifier but must, instead, specialize the redefining StateMachine.
    	/// </summary>
    	// spec:
    	//     result = (redefinedElement.oclIsKindOf(StateMachine) and
    	//       let parentContext : BehavioredClassifier =
    	//         redefinedElement.oclAsType(StateMachine).context in
    	//       if context = null then
    	//         parentContext = null and self.allParents()→includes(redefinedElement)
    	//       else
    	//         parentContext <> null and context.allParents()->includes(parentContext)
    	//       endif)
    	public new bool IsRedefinitionContextValid(RedefinableElement redefinedElement)
    	{
            var parentContext = (redefinedElement as StateMachine)?.Context;
            if (Context is null) return parentContext is null && this.AllParents().Contains(redefinedElement);
            else return parentContext is not null && Context.AllParents().Contains(parentContext);
    	}
    	
    	/// <summary>
    	/// This utility funciton is like the LCA, except that it returns the nearest composite State that contains both input Vertices.
    	/// </summary>
    	// spec:
    	//     result = (if v2.oclIsTypeOf(State) and ancestor(v1, v2) then
    	//     	v2.oclAsType(State)
    	//     else if v1.oclIsTypeOf(State) and ancestor(v2, v1) then
    	//     	v1.oclAsType(State)
    	//     else if (v1.container.state->isEmpty() or v2.container.state->isEmpty()) then 
    	//     	null.oclAsType(State)
    	//     else LCAState(v1.container.state, v2.container.state)
    	//     endif endif endif)
    	public State? LCAState(Vertex? v1, Vertex? v2)
    	{
            var s1 = v1 as State;
            var s2 = v2 as State;
            if (s1 is null && s2 is null) return null;
            else if (s2 is not null && Ancestor(s1, s2)) return s2;
            else if (s1 is not null && Ancestor(s2, s1)) return s1;
            else return LCAState(s1?.Container?.State, s2?.Container?.State);
        }

    }
    
    public partial interface Transition
    {
    	/// <summary>
    	/// References the Classifier in which context this element may be redefined.
    	/// </summary>
    	// spec:
    	//     result = containingStateMachine()
    	[Derived]
    	[ReadOnly]
    	[Opposite(typeof(Classifier), "Transition")]
    	[Redefines(typeof(RedefinableElement), "RedefinitionContext")]
    	public new Classifier RedefinitionContext
    	{ 
    		get
    		{
                return ContainingStateMachine();
    		}
    	}
    	
    	/// <summary>
    	/// The query containingStateMachine() returns the StateMachine that contains the Transition either directly or transitively.
    	/// </summary>
    	// spec:
    	//     result = (container.containingStateMachine())
    	public StateMachine? ContainingStateMachine()
    	{
            return Container?.ContainingStateMachine();
    	}
    	
    	/// <summary>
    	/// The query isConsistentWith specifies that a redefining Transition is consistent with a redefined Transition provided that the source Vertex of the redefining Transition redefines the source Vertex of the redefined Transition.
    	/// </summary>
    	// spec:
    	//     result = (redefiningElement.oclIsKindOf(Transition) and
    	//       redefiningElement.oclAsType(Transition).source.redefinedVertex = source)
    	// pre:
    	//     redefiningElement.isRedefinitionContextValid(self)
    	public new bool IsConsistentWith(RedefinableElement redefiningElement)
    	{
            //if (!redefiningElement.IsRedefinitionContextValid(this)) throw new InvalidOperationException("Pre-condition is violated: redefiningElement.isRedefinitionContextValid(self)");
            return redefiningElement is Transition transition && transition.Source.RedefinedVertex == Source;
    	}
    	
    }
    
    public partial interface Vertex
    {
    	/// <summary>
    	/// Specifies the Transitions entering this Vertex.
    	/// </summary>
    	// spec:
    	//     result = (Transition.allInstances()->select(target=self))
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Transition), "Target")]
    	public IList<Transition> Incoming
    	{ 
    		get
    		{
                return this.AllInstances<Transition>().Where(tr => tr.Target == this).AsListSet();
    		}
    	}
    	
    	/// <summary>
    	/// Specifies the Transitions departing from this Vertex.
    	/// </summary>
    	// spec:
    	//     result = (Transition.allInstances()->select(source=self))
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Transition), "Source")]
    	public IList<Transition> Outgoing
    	{ 
    		get
    		{
                return this.AllInstances<Transition>().Where(tr => tr.Source == this).AsListSet();
            }
    	}
    	
    	/// <summary>
    	/// References the Classifier in which context this element may be redefined.
    	/// </summary>
    	// spec:
    	//     result = containingStateMachine()
    	[Derived]
    	[ReadOnly]
    	[Opposite(typeof(Classifier), "Vertex")]
    	[Redefines(typeof(RedefinableElement), "RedefinitionContext")]
    	public new Classifier RedefinitionContext
    	{ 
    		get
    		{
                return ContainingStateMachine();
    		}
    	}
    	
    	/// <summary>
    	/// The operation containingStateMachine() returns the StateMachine in which this Vertex is defined.
    	/// </summary>
    	// spec:
    	//     result = (if container <> null
    	//     then
    	//     -- the container is a region
    	//        container.containingStateMachine()
    	//     else 
    	//        if (self.oclIsKindOf(Pseudostate)) and ((self.oclAsType(Pseudostate).kind = PseudostateKind::entryPoint) or (self.oclAsType(Pseudostate).kind = PseudostateKind::exitPoint)) then
    	//           self.oclAsType(Pseudostate).stateMachine
    	//        else 
    	//           if (self.oclIsKindOf(ConnectionPointReference)) then
    	//               self.oclAsType(ConnectionPointReference).state.containingStateMachine() -- no other valid cases possible
    	//           else 
    	//               null
    	//           endif
    	//        endif
    	//     endif
    	//     )
    	public StateMachine? ContainingStateMachine()
    	{
    		if (Container is not null)
            {
                return Container.ContainingStateMachine();
            }
            else
            {
                if (this is Pseudostate pstate && (pstate.Kind == PseudostateKind.EntryPoint || pstate.Kind == PseudostateKind.ExitPoint)) return pstate.StateMachine;
                else if (this is ConnectionPointReference cpr) return cpr.State?.ContainingStateMachine();
                else return null;
            }
    	}
    	
    	/// <summary>
    	/// This utility operation returns true if the Vertex is contained in the State s (input argument).
    	/// </summary>
    	// spec:
    	//     result = (if not s.isComposite() or container->isEmpty() then
    	//     	false
    	//     else
    	//     	if container.state = s then 
    	//     		true
    	//     	else
    	//     		container.state.isContainedInState(s)
    	//     	endif
    	//     endif)
    	public bool IsContainedInState(State s)
    	{
            if (!s.IsComposite || Container?.State is null) return false;
            if (Container.State == s) return true;
            else return Container.State.IsContainedInState(s);
    	}
    	
    	/// <summary>
    	/// This utility query returns true if the Vertex is contained in the Region r (input argument).
    	/// </summary>
    	// spec:
    	//     result = (if (container = r) then
    	//     	true
    	//     else
    	//     	if (r.state->isEmpty()) then
    	//     		false
    	//     	else
    	//     		container.state.isContainedInRegion(r)
    	//     	endif
    	//     endif)
    	public bool IsContainedInRegion(Region r)
    	{
            if (Container == r) return true;
            else if (r.State is null) return false;
            else return Container?.State?.IsContainedInRegion(r) ?? false;
    	}
    	
    	/// <summary>
    	/// The query isRedefinitionContextValid specifies that the redefinition context of a redefining Vertex is properly related to the redefinition context of the redefined Vertex if the owner of the redefining Vertex is a redefinition of the owner of the redefined Vertex. Note that the owner of a Vertex may be a Region, a StateMachine (for a connectionPoint Pseudostate), or a State (for a connectionPoint Pseudostate or a connection ConnectionPointReference), all of which are RedefinableElements.
    	/// </summary>
    	// pre:
    	//     redefiningElement.isRedefinitionContextValid(self)
    	// spec:
    	//     result = (redefinedElement.oclIsKindOf(Vertex) and
    	//       owner.oclAsType(RedefinableElement).redefinedElement->includes(redefinedElement.owner))
    	public new bool IsConsistentWith(RedefinableElement redefiningElement)
    	{
            //if (!redefiningElement.IsRedefinitionContextValid(this)) throw new InvalidOperationException("Pre-condition is violated: redefiningElement.isRedefinitionContextValid(self)");
            var vertex = redefiningElement as Vertex;
            var redefinedElement = (Owner as RedefinableElement)?.RedefinedElement;
            return vertex is not null && redefinedElement is not null && redefinedElement.Contains(redefiningElement.Owner);
    	}
    	
    }
    
    public partial interface BehavioredClassifier
    {
    }
    
    public partial interface DataType
    {
    }
    
    public partial interface Enumeration
    {
    }
    
    public partial interface EnumerationLiteral
    {
    	/// <summary>
    	/// The classifier of this EnumerationLiteral derived to be equal to its Enumeration.
    	/// </summary>
    	// spec:
    	//     result = (enumeration)
    	[Derived]
    	[ReadOnly]
    	[Opposite(typeof(Enumeration), "EnumerationLiteral")]
    	[Redefines(typeof(InstanceSpecification), "Classifier")]
    	public new Enumeration Classifier
    	{ 
    		get
    		{
                return Enumeration;
    		}
    	}
    	
    }
    
    public partial interface Interface
    {
    }
    
    public partial interface InterfaceRealization
    {
    }
    
    public partial interface PrimitiveType
    {
    }
    
    public partial interface Reception
    {
    }
    
    public partial interface Signal
    {
    }
    
    public partial interface Extension
    {
    	/// <summary>
    	/// Indicates whether an instance of the extending stereotype must be created when an instance of the extended class is created. The attribute value is derived from the value of the lower property of the ExtensionEnd referenced by Extension::ownedEnd; a lower value of 1 means that isRequired is true, but otherwise it is false. Since the default value of ExtensionEnd::lower is 0, the default value of isRequired is false.
    	/// </summary>
    	// spec:
    	//     result = (ownedEnd.lowerBound() = 1)
    	[Derived]
    	[ReadOnly]
    	public bool IsRequired
    	{ 
    		get
    		{
                return OwnedEnd.LowerBound() == 1;
    		}
    	}
    	
    	/// <summary>
    	/// References the Class that is extended through an Extension. The property is derived from the type of the memberEnd that is not the ownedEnd.
    	/// </summary>
    	// spec:
    	//     result = (metaclassEnd().type.oclAsType(Class))
    	[Derived]
    	[ReadOnly]
    	[Opposite(typeof(Class), "Extension")]
    	public Class? Metaclass
    	{ 
    		get
    		{
                return MetaclassEnd()?.Type as Class;
    		}
    	}
    	
    	/// <summary>
    	/// The query metaclassEnd() returns the Property that is typed by a metaclass (as opposed to a stereotype).
    	/// </summary>
    	// spec:
    	//     result = (memberEnd->reject(p | ownedEnd->includes(p.oclAsType(ExtensionEnd)))->any(true))
    	public Property? MetaclassEnd()
    	{
            foreach (var p in MemberEnd)
            {
                if (OwnedEnd == p) continue;
                return p;
            }
            return null;
    	}
    	
    }
    
    public partial interface ExtensionEnd
    {
    	/// <summary>
    	/// This redefinition changes the default multiplicity of association ends, since model elements are usually extended by 0 or 1 instance of the extension stereotype.
    	/// </summary>
    	[Derived]
    	[Redefines(typeof(MultiplicityElement), "Lower")]
    	public new int Lower
    	{ 
    		get
    		{
                return LowerBound();
            }
    	}
    	
    	/// <summary>
    	/// The query lowerBound() returns the lower bound of the multiplicity as an Integer. This is a redefinition of the default lower bound, which normally, for MultiplicityElements, evaluates to 1 if empty.
    	/// </summary>
    	// spec:
    	//     result = (if lowerValue=null then 0 else lowerValue.integerValue() endif)
    	public new int LowerBound()
    	{
            return LowerValue?.IntegerValue() ?? 0;
    	}
    	
    }
    
    public partial interface Image
    {
    }
    
    public partial interface Model
    {
    }
    
    public partial interface Package
    {
    	/// <summary>
    	/// References the packaged elements that are Packages.
    	/// </summary>
    	// spec:
    	//     result = (packagedElement->select(oclIsKindOf(Package))->collect(oclAsType(Package))->asSet())
    	[Containment]
    	[Derived]
    	[Unordered]
    	[Opposite(typeof(Package), "NestingPackage")]
    	[Subsets(typeof(Package), "PackagedElement")]
    	public IList<Package> NestedPackage
    	{ 
    		get
    		{
                return PackagedElement.OfType<Package>().AsListSet();
    		}
    	}
    	
    	/// <summary>
    	/// References the Stereotypes that are owned by the Package.
    	/// </summary>
    	// spec:
    	//     result = (packagedElement->select(oclIsKindOf(Stereotype))->collect(oclAsType(Stereotype))->asSet())
    	[Containment]
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(Stereotype), "OwningPackage")]
    	[Subsets(typeof(Package), "PackagedElement")]
    	public IList<Stereotype> OwnedStereotype
    	{ 
    		get
    		{
                return PackagedElement.OfType<Stereotype>().AsListSet();
            }
    	}
    	
    	/// <summary>
    	/// References the packaged elements that are Types.
    	/// </summary>
    	// spec:
    	//     result = (packagedElement->select(oclIsKindOf(Type))->collect(oclAsType(Type))->asSet())
    	[Containment]
    	[Derived]
    	[Unordered]
    	[Opposite(typeof(Type), "Package")]
    	[Subsets(typeof(Package), "PackagedElement")]
    	public IList<Type> OwnedType
    	{ 
    		get
    		{
                return PackagedElement.OfType<Type>().AsListSet();
            }
    	}
    	
    	/// <summary>
    	/// The query allApplicableStereotypes() returns all the directly or indirectly owned stereotypes, including stereotypes contained in sub-profiles.
    	/// </summary>
    	// spec:
    	//     result = (let ownedPackages : Bag(Package) = ownedMember->select(oclIsKindOf(Package))->collect(oclAsType(Package)) in
    	//      ownedStereotype->union(ownedPackages.allApplicableStereotypes())->flatten()->asSet()
    	//     )
    	public IList<Stereotype> AllApplicableStereotypes()
    	{
    		var ownedPackages = OwnedMember.OfType<Package>();
            var result = new List<Stereotype>();
            result.UnionWith(OwnedStereotype);
            result.UnionWith(ownedPackages.SelectMany(pkg => pkg.AllApplicableStereotypes()));
            return result;
        }
    	
    	/// <summary>
    	/// The query containingProfile() returns the closest profile directly or indirectly containing this package (or this package itself, if it is a profile).
    	/// </summary>
    	// spec:
    	//     result = (if self.oclIsKindOf(Profile) then 
    	//     	self.oclAsType(Profile)
    	//     else
    	//     	self.namespace.oclAsType(Package).containingProfile()
    	//     endif)
    	public Profile? ContainingProfile()
    	{
            if (this is Profile profile) return profile;
            else return (Namespace as Package)?.ContainingProfile();
    	}
    	
    	/// <summary>
    	/// The query makesVisible() defines whether a Package makes an element visible outside itself. Elements with no visibility and elements with public visibility are made visible.
    	/// </summary>
    	// pre:
    	//     member->includes(el)
    	// spec:
    	//     result = (ownedMember->includes(el) or
    	//     (elementImport->select(ei|ei.importedElement = VisibilityKind::public)->collect(importedElement.oclAsType(NamedElement))->includes(el)) or
    	//     (packageImport->select(visibility = VisibilityKind::public)->collect(importedPackage.member->includes(el))->notEmpty()))
    	public bool MakesVisible(NamedElement el)
    	{
            //if (!Member.Contains(el)) throw new InvalidOperationException("Pre-condition is violated: member->includes(el)");
            if (OwnedMember.Contains(el)) return true;
            if (ElementImport.Where(ei => ei.ImportedElement.Visibility == VisibilityKind.Public).OfType<NamedElement>().Any(ne => ne == el)) return true;
            if (PackageImport.Where(pi => pi.Visibility == VisibilityKind.Public).Any(pi => pi.ImportedPackage.Member.Contains(el))) return true;
            return false;
        }

        /// <summary>
        /// The query mustBeOwned() indicates whether elements of this type must have an owner.
        /// </summary>
        // spec:
        //     result = (false)
        public new bool MustBeOwned()
    	{
            return false;
    	}
    	
    	/// <summary>
    	/// The query visibleMembers() defines which members of a Package can be accessed outside it.
    	/// </summary>
    	// spec:
    	//     result = (member->select( m | m.oclIsKindOf(PackageableElement) and self.makesVisible(m))->collect(oclAsType(PackageableElement))->asSet())
    	public IList<PackageableElement> VisibleMembers()
    	{
            return Member.OfType<PackageableElement>().Where(m => MakesVisible(m)).AsListSet();
    	}
    	
    }
    
    public partial interface PackageMerge
    {
    }
    
    public partial interface Profile
    {
    }
    
    public partial interface ProfileApplication
    {
    }
    
    public partial interface Stereotype
    {
    	/// <summary>
    	/// The profile that directly or indirectly contains this stereotype.
    	/// </summary>
    	// spec:
    	//     result = (self.containingProfile())
    	[Derived]
    	[ReadOnly]
    	[Opposite(typeof(Profile), "Stereotype")]
    	public Profile Profile
    	{ 
    		get
    		{
                return ContainingProfile();
    		}
    	}
    	
    	/// <summary>
    	/// The query containingProfile returns the closest profile directly or indirectly containing this stereotype.
    	/// </summary>
    	// spec:
    	//     result = (self.namespace.oclAsType(Package).containingProfile())
    	public Profile? ContainingProfile()
    	{
            return (Namespace as Package)?.ContainingProfile();
    	}
    	
    }
    
    public partial interface ActionExecutionSpecification
    {
    }
    
    public partial interface BehaviorExecutionSpecification
    {
    }
    
    public partial interface CombinedFragment
    {
    }
    
    public partial interface ConsiderIgnoreFragment
    {
    }
    
    public partial interface Continuation
    {
    }
    
    public partial interface DestructionOccurrenceSpecification
    {
    }
    
    public partial interface ExecutionOccurrenceSpecification
    {
    }
    
    public partial interface ExecutionSpecification
    {
    }
    
    public partial interface Gate
    {
    	/// <summary>
    	/// This query returns true if this Gate is attached to the boundary of a CombinedFragment, and its other end (if present)  is outside of the same CombinedFragment.
    	/// </summary>
    	// spec:
    	//     result = (self.oppositeEnd()-> notEmpty() and combinedFragment->notEmpty() implies
    	//     let oppEnd : MessageEnd = self.oppositeEnd()->asOrderedSet()->first() in
    	//     if oppEnd.oclIsKindOf(MessageOccurrenceSpecification) 
    	//     then let oppMOS : MessageOccurrenceSpecification = oppEnd.oclAsType(MessageOccurrenceSpecification)
    	//     in  self.combinedFragment.enclosingInteraction.oclAsType(InteractionFragment)->asSet()->
    	//          union(self.combinedFragment.enclosingOperand.oclAsType(InteractionFragment)->asSet()) =
    	//          oppMOS.enclosingInteraction.oclAsType(InteractionFragment)->asSet()->
    	//          union(oppMOS.enclosingOperand.oclAsType(InteractionFragment)->asSet())
    	//     else let oppGate : Gate = oppEnd.oclAsType(Gate) 
    	//     in self.combinedFragment.enclosingInteraction.oclAsType(InteractionFragment)->asSet()->
    	//          union(self.combinedFragment.enclosingOperand.oclAsType(InteractionFragment)->asSet()) =
    	//          oppGate.combinedFragment.enclosingInteraction.oclAsType(InteractionFragment)->asSet()->
    	//          union(oppGate.combinedFragment.enclosingOperand.oclAsType(InteractionFragment)->asSet())
    	//     endif)
    	public bool IsOutsideCF()
    	{
            if (CombinedFragment is null) return true;
            var oppEnd = OppositeEnd().FirstOrDefault();
            if (oppEnd is null) return true;
            var teif = CombinedFragment.EnclosingInteraction as InteractionFragment;
            var toif = CombinedFragment.EnclosingOperand as InteractionFragment;
            InteractionFragment? oeif = null;
            InteractionFragment? ooif = null;
            if (oppEnd is MessageOccurrenceSpecification oppMOS)
            {
                oeif = oppMOS.EnclosingInteraction;
                ooif = oppMOS.EnclosingOperand;
            }
            else if (oppEnd is Gate oppGate)
            {
                oeif = oppGate.CombinedFragment?.EnclosingInteraction;
                ooif = oppGate.CombinedFragment?.EnclosingOperand;
            }
            if (teif == toif) toif = null;
            if (oeif == ooif) ooif = null;
            var tcount = (teif is not null ? 1 : 0) + (toif is not null ? 1 : 0);
            var ocount = 0;
            if (teif == oeif) ++ocount;
            if (teif == ooif) ++ocount;
            if (toif == oeif) ++ocount;
            if (toif == ooif) ++ocount;
            return tcount == ocount;
        }

        /// <summary>
        /// This query returns true if this Gate is attached to the boundary of a CombinedFragment, and its other end (if present) is inside of an InteractionOperator of the same CombinedFragment.
        /// </summary>
        // spec:
        //     result = (self.oppositeEnd()-> notEmpty() and combinedFragment->notEmpty() implies
        //     let oppEnd : MessageEnd = self.oppositeEnd()->asOrderedSet()->first() in
        //     if oppEnd.oclIsKindOf(MessageOccurrenceSpecification)
        //     then let oppMOS : MessageOccurrenceSpecification
        //     = oppEnd.oclAsType(MessageOccurrenceSpecification)
        //     in combinedFragment = oppMOS.enclosingOperand.combinedFragment
        //     else let oppGate : Gate = oppEnd.oclAsType(Gate)
        //     in combinedFragment = oppGate.combinedFragment.enclosingOperand.combinedFragment
        //     endif)
        public bool IsInsideCF()
    	{
            if (CombinedFragment is null) return true;
            var oppEnd = OppositeEnd().FirstOrDefault();
            if (oppEnd is null) return true;
            if (oppEnd is MessageOccurrenceSpecification oppMOS) return CombinedFragment == oppMOS.EnclosingOperand?.CombinedFragment;
            else if (oppEnd is Gate oppGate) return CombinedFragment == oppGate.CombinedFragment?.EnclosingOperand?.CombinedFragment;
            else return false;
        }
    	
    	/// <summary>
    	/// This query returns true value if this Gate is an actualGate of an InteractionUse.
    	/// </summary>
    	// spec:
    	//     result = (interactionUse->notEmpty())
    	public bool IsActual()
    	{
            return InteractionUse is not null;
    	}
    	
    	/// <summary>
    	/// This query returns true if this Gate is a formalGate of an Interaction.
    	/// </summary>
    	/// <para>
    	/// &lt;p&gt;interaction-&amp;gt;notEmpty()&lt;/p&gt;
    	/// </para>
    	// spec:
    	//     result = (interaction->notEmpty())
    	public bool IsFormal()
    	{
            return Interaction is not null;
    	}
    	
    	/// <summary>
    	/// This query returns the name of the gate, either the explicit name (.name) or the constructed name (&apos;out_&quot; or &apos;in_&apos; concatenated in front of .message.name) if the explicit name is not present.
    	/// </summary>
    	// spec:
    	//     result = (if name->notEmpty() then name->asOrderedSet()->first()
    	//     else  if isActual() or isOutsideCF() 
    	//       then if isSend() 
    	//         then 'out_'.concat(self.message.name->asOrderedSet()->first())
    	//         else 'in_'.concat(self.message.name->asOrderedSet()->first())
    	//         endif
    	//       else if isSend()
    	//         then 'in_'.concat(self.message.name->asOrderedSet()->first())
    	//         else 'out_'.concat(self.message.name->asOrderedSet()->first())
    	//         endif
    	//       endif
    	//     endif)
    	public string GetName()
    	{
            if (Name is not null) return Name;
            else if (IsActual() && IsOutsideCF())
            {
                if (IsSend()) return $"out_{this.Message?.Name}";
                else return $"in_{this.Message?.Name}";
            }
            else
            {
                if (IsSend()) return $"in_{this.Message?.Name}";
                else return $"out_{this.Message?.Name}";
            }
        }
    	
    	/// <summary>
    	/// This query returns true if the name of this Gate matches the name of the in parameter Gate, and the messages for the two Gates correspond. The Message for one Gate (say A) corresponds to the Message for another Gate (say B) if (A and B have the same name value) and (if A is a sendEvent then B is a receiveEvent) and (if A is a receiveEvent then B is a sendEvent) and (A and B have the same messageSort value) and (A and B have the same signature value).
    	/// </summary>
    	// spec:
    	//     result = (self.getName() = gateToMatch.getName() and 
    	//     self.message.messageSort = gateToMatch.message.messageSort and
    	//     self.message.name = gateToMatch.message.name and
    	//     self.message.sendEvent->includes(self) implies gateToMatch.message.receiveEvent->includes(gateToMatch)  and
    	//     self.message.receiveEvent->includes(self) implies gateToMatch.message.sendEvent->includes(gateToMatch) and
    	//     self.message.signature = gateToMatch.message.signature)
    	public bool Matches(Gate gateToMatch)
    	{
            if (this.GetName() != gateToMatch.GetName()) return false;
            if (this.Message is null || gateToMatch.Message is null) return false;
            if (this.Message.MessageSort != gateToMatch.Message.MessageSort) return false;
            if (this.Message.SendEvent == this && gateToMatch.Message.ReceiveEvent != gateToMatch) return false;
            if (this.Message.ReceiveEvent == this && gateToMatch.Message.SendEvent != gateToMatch) return false;
            if (this.Message.Signature != gateToMatch.Message.Signature) return false;
            return true;
        }

        /// <summary>
        /// The query isDistinguishableFrom() specifies that two Gates may coexist in the same Namespace, without an explicit name property. The association end formalGate subsets ownedElement, and since the Gate name attribute
        /// is optional, it is allowed to have two formal gates without an explicit name, but having derived names which are distinct.
        /// </summary>
        // spec:
        //     result = (true)
        public new bool IsDistinguishableFrom(NamedElement n, Namespace ns)
    	{
            return true;
    	}
    	
    	/// <summary>
    	/// If the Gate is an inside Combined Fragment Gate, this operation returns the InteractionOperand that the opposite end of this Gate is included within.
    	/// </summary>
    	// spec:
    	//     result = (if isInsideCF() then
    	//       let oppEnd : MessageEnd = self.oppositeEnd()->asOrderedSet()->first() in
    	//         if oppEnd.oclIsKindOf(MessageOccurrenceSpecification)
    	//         then let oppMOS : MessageOccurrenceSpecification = oppEnd.oclAsType(MessageOccurrenceSpecification)
    	//             in oppMOS.enclosingOperand->asOrderedSet()->first()
    	//         else let oppGate : Gate = oppEnd.oclAsType(Gate)
    	//             in oppGate.combinedFragment.enclosingOperand->asOrderedSet()->first()
    	//         endif
    	//       else null
    	//     endif)
    	public InteractionOperand? GetOperand()
    	{
    		if (IsInsideCF())
            {
                var oppEnd = this.OppositeEnd().FirstOrDefault();
                if (oppEnd is MessageOccurrenceSpecification oppMOS) return oppMOS.EnclosingOperand;
                else if (oppEnd is Gate oppGate) return oppGate.CombinedFragment.EnclosingOperand;
            }
            return null;
        }

        [ReadOnly]
        [Opposite(typeof(CombinedFragment), "CfragmentGate")]
        [Subsets(typeof(Element), "Owner")]
        CombinedFragment? CombinedFragment { get; }

        [ReadOnly]
        [Opposite(typeof(InteractionUse), "ActualGate")]
        [Subsets(typeof(Element), "Owner")]
        InteractionUse? InteractionUse { get; }

        [ReadOnly]
        [Opposite(typeof(Interaction), "FormalGate")]
        [Subsets(typeof(NamedElement), "Namespace")]
        Interaction? Interaction { get; }
    }
    
    public partial interface GeneralOrdering
    {
    }
    
    public partial interface Interaction
    {
    }
    
    public partial interface InteractionConstraint
    {
    }
    
    public partial interface InteractionFragment
    {
    }
    
    public partial interface InteractionOperand
    {
        [Opposite(typeof(CombinedFragment), "Operand")]
        [Subsets(typeof(Element), "Owner")]
        CombinedFragment CombinedFragment { get; set; }
    }
    
    public partial interface InteractionUse
    {
    }
    
    public partial interface Lifeline
    {
    }
    
    public partial interface Message
    {
    	/// <summary>
    	/// The kind of the Message (complete, lost, found, or unknown).
    	/// </summary>
    	public MessageKind MessageKind { get; set; }
    	
    	/// <summary>
    	/// The query isDistinguishableFrom() specifies that any two Messages may coexist in the same Namespace, regardless of their names.
    	/// </summary>
    	// spec:
    	//     result = (true)
    	public new bool IsDistinguishableFrom(NamedElement n, Namespace ns)
    	{
            return true;
    	}

        // MetaDslx: added manually, since it was missing from the UML standard
        [DerivedUnion]
        [Unordered]
        [Opposite(typeof(MessageEnd), "Message")]
        IList<MessageEnd> MessageEnd { get; }

    }

    public partial interface MessageEnd
    {
    	/// <summary>
    	/// This query returns a set including the MessageEnd (if exists) at the opposite end of the Message for this MessageEnd.
    	/// </summary>
    	// spec:
    	//     result = (message->asSet().messageEnd->asSet()->excluding(self))
    	// pre:
    	//     message->notEmpty()
    	public IList<MessageEnd> OppositeEnd()
    	{
            //if (Message is null) throw new InvalidOperationException("Pre-condition is violated: message->notEmpty()");
            if (Message is null) return UmlUtils.EmptyList<MessageEnd>();
            return Message.MessageEnd.Where(me => me != this).AsListSet();
    	}
    	
    	/// <summary>
    	/// This query returns value true if this MessageEnd is a sendEvent.
    	/// </summary>
    	// pre:
    	//     message->notEmpty()
    	// spec:
    	//     result = (message.sendEvent->asSet()->includes(self))
    	public bool IsSend()
    	{
            //if (Message is null) throw new InvalidOperationException("Pre-condition is violated: message->notEmpty()");
            if (Message is null) return false;
            return Message.SendEvent == this;
    	}
    	
    	/// <summary>
    	/// This query returns value true if this MessageEnd is a receiveEvent.
    	/// </summary>
    	/// <para>
    	/// &lt;p&gt;message-&amp;gt;notEmpty()&lt;/p&gt;
    	/// </para>
    	// pre:
    	//     message->notEmpty()
    	// spec:
    	//     result = (message.receiveEvent->asSet()->includes(self))
    	public bool IsReceive()
    	{
            //if (Message is null) throw new InvalidOperationException("Pre-condition is violated: message->notEmpty()");
            if (Message is null) return false;
            return Message.ReceiveEvent == this;
    	}
    	
    	/// <summary>
    	/// This query returns a set including the enclosing InteractionFragment this MessageEnd is enclosed within.
    	/// </summary>
    	// spec:
    	//     result = (if self->select(oclIsKindOf(Gate))->notEmpty() 
    	//     then -- it is a Gate
    	//     let endGate : Gate = 
    	//       self->select(oclIsKindOf(Gate)).oclAsType(Gate)->asOrderedSet()->first()
    	//       in
    	//       if endGate.isOutsideCF() 
    	//       then endGate.combinedFragment.enclosingInteraction.oclAsType(InteractionFragment)->asSet()->
    	//          union(endGate.combinedFragment.enclosingOperand.oclAsType(InteractionFragment)->asSet())
    	//       else if endGate.isInsideCF() 
    	//         then endGate.combinedFragment.oclAsType(InteractionFragment)->asSet()
    	//         else if endGate.isFormal() 
    	//           then endGate.interaction.oclAsType(InteractionFragment)->asSet()
    	//           else if endGate.isActual() 
    	//             then endGate.interactionUse.enclosingInteraction.oclAsType(InteractionFragment)->asSet()->
    	//          union(endGate.interactionUse.enclosingOperand.oclAsType(InteractionFragment)->asSet())
    	//             else null
    	//             endif
    	//           endif
    	//         endif
    	//       endif
    	//     else -- it is a MessageOccurrenceSpecification
    	//     let endMOS : MessageOccurrenceSpecification  = 
    	//       self->select(oclIsKindOf(MessageOccurrenceSpecification)).oclAsType(MessageOccurrenceSpecification)->asOrderedSet()->first() 
    	//       in
    	//       if endMOS.enclosingInteraction->notEmpty() 
    	//       then endMOS.enclosingInteraction.oclAsType(InteractionFragment)->asSet()
    	//       else endMOS.enclosingOperand.oclAsType(InteractionFragment)->asSet()
    	//       endif
    	//     endif)
    	public IList<InteractionFragment> EnclosingFragment()
    	{
            var result = new List<InteractionFragment>();
            if (this is MessageOccurrenceSpecification endMOS)
            {
                if (endMOS.EnclosingInteraction is not null) return result.Include(endMOS.EnclosingInteraction);
                else result.Include(endMOS.EnclosingOperand);
            }
    		else if (this is Gate endGate)
            {
                if (endGate.IsOutsideCF())
                {
                    result.Include(endGate.CombinedFragment?.EnclosingInteraction as InteractionFragment);
                    result.Include(endGate.CombinedFragment?.EnclosingOperand as InteractionFragment);
                }
                else if (endGate.IsInsideCF())
                {
                    result.Include(endGate.CombinedFragment as InteractionFragment);
                }
                else if (endGate.IsFormal())
                {
                    result.Include(endGate.Interaction as InteractionFragment);
                }
                else if (endGate.IsActual())
                {
                    result.Include(endGate.InteractionUse?.EnclosingInteraction as InteractionFragment);
                    result.Include(endGate.InteractionUse?.EnclosingOperand as InteractionFragment);
                }
            }
            return result;
    	}

    }

    public partial interface MessageOccurrenceSpecification
    {
    }
    
    public partial interface OccurrenceSpecification
    {
    }
    
    public partial interface PartDecomposition
    {
    }
    
    public partial interface StateInvariant
    {
    }
    
    public partial interface InformationFlow
    {
    }
    
    public partial interface InformationItem
    {
    }
    
    public partial interface Artifact
    {
    }
    
    public partial interface CommunicationPath
    {
    }
    
    public partial interface DeployedArtifact
    {
    }
    
    public partial interface Deployment
    {
    }
    
    public partial interface DeploymentSpecification
    {
    }
    
    public partial interface DeploymentTarget
    {
    	/// <summary>
    	/// The set of elements that are manifested in an Artifact that is involved in Deployment to a DeploymentTarget.
    	/// </summary>
    	// spec:
    	//     result = (deployment.deployedArtifact->select(oclIsKindOf(Artifact))->collect(oclAsType(Artifact).manifestation)->collect(utilizedElement)->asSet())
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(PackageableElement), "DeploymentTarget")]
    	public IList<PackageableElement> DeployedElement
    	{ 
    		get
    		{
                return Deployment.SelectMany(d => d.DeployedArtifact.OfType<Artifact>().SelectMany(a => a.Manifestation)).Select(m => m.UtilizedElement).AsListSet();
    		}
    	}
    	
    }
    
    public partial interface Device
    {
    }
    
    public partial interface ExecutionEnvironment
    {
    }
    
    public partial interface Manifestation
    {
    }
    
    public partial interface Node
    {
    }
    
    public partial interface Abstraction
    {
    }
    
    public partial interface Comment
    {
    }
    
    public partial interface Constraint
    {
    }
    
    public partial interface Dependency
    {
    }
    
    public partial interface DirectedRelationship
    {
    }
    
    public partial interface Element
    {
    	/// <summary>
    	/// The query allOwnedElements() gives all of the direct and indirect ownedElements of an Element.
    	/// </summary>
    	// spec:
    	//     result = (ownedElement->union(ownedElement->collect(e | e.allOwnedElements()))->asSet())
    	public IList<Element> AllOwnedElements()
    	{
            var result = new List<Element>();
            result.UnionWith(OwnedElement);
            foreach (var e in OwnedElement)
            {
                result.UnionWith(e.AllOwnedElements());
            }
            return result;
    	}
    	
    	/// <summary>
    	/// The query mustBeOwned() indicates whether Elements of this type must have an owner. Subclasses of Element that do not require an owner must override this operation.
    	/// </summary>
    	// spec:
    	//     result = (true)
    	public bool MustBeOwned()
    	{
            return true;
    	}
    	
    }
    
    public partial interface ElementImport
    {
    	/// <summary>
    	/// The query getName() returns the name under which the imported PackageableElement will be known in the importing namespace.
    	/// </summary>
    	// spec:
    	//     result = (if alias->notEmpty() then
    	//       alias
    	//     else
    	//       importedElement.name
    	//     endif)
    	public string GetName()
    	{
            return Alias is not null ? Alias : ImportedElement.Name;
    	}
    	
    }
    
    public partial interface MultiplicityElement
    {
    	/// <summary>
    	/// The lower bound of the multiplicity interval.
    	/// </summary>
    	// spec:
    	//     result = (lowerBound())
    	[Derived]
    	public int Lower
    	{ 
    		get
    		{
                return LowerBound();
    		}
    	}
    	
    	/// <summary>
    	/// The upper bound of the multiplicity interval.
    	/// </summary>
    	// spec:
    	//     result = (upperBound())
    	[Derived]
    	public long Upper
    	{ 
    		get
    		{
                return UpperBound();
    		}
    	}
    	
    	/// <summary>
    	/// The operation compatibleWith takes another multiplicity as input. It returns true if the other multiplicity is wider than, or the same as, self.
    	/// </summary>
    	// spec:
    	//     result = ((other.lowerBound() <= self.lowerBound()) and ((other.upperBound() = *) or (self.upperBound() <= other.upperBound())))
    	public bool CompatibleWith(MultiplicityElement other)
    	{
            return other.LowerBound() <= this.LowerBound() && (other.UpperBound() < 0 || this.UpperBound() >= 0 && this.UpperBound() <= other.UpperBound());
    	}
    	
    	/// <summary>
    	/// The query includesMultiplicity() checks whether this multiplicity includes all the cardinalities allowed by the specified multiplicity.
    	/// </summary>
    	// pre:
    	//     self.upperBound()->notEmpty() and self.lowerBound()->notEmpty() and M.upperBound()->notEmpty() and M.lowerBound()->notEmpty()
    	// spec:
    	//     result = ((self.lowerBound() <= M.lowerBound()) and (self.upperBound() >= M.upperBound()))
    	public bool IncludesMultiplicity(MultiplicityElement M)
    	{
            return this.LowerBound() <= M.LowerBound() && (this.UpperBound() < 0 || M.UpperBound() >= 0 && M.UpperBound() <= this.UpperBound());
            //return this.LowerBound() <= M.LowerBound() && this.UpperBound() >= M.UpperBound();
    	}
    	
    	/// <summary>
    	/// The operation is determines if the upper and lower bound of the ranges are the ones given.
    	/// </summary>
    	// spec:
    	//     result = (lowerbound = self.lowerBound() and upperbound = self.upperBound())
    	public bool Is(int lowerbound, long upperbound)
    	{
            return lowerbound == this.LowerBound() && upperbound == this.UpperBound();
    	}
    	
    	/// <summary>
    	/// The query isMultivalued() checks whether this multiplicity has an upper bound greater than one.
    	/// </summary>
    	// pre:
    	//     upperBound()->notEmpty()
    	// spec:
    	//     result = (upperBound() > 1)
    	public bool IsMultivalued()
    	{
            return UpperBound() > 1 || UpperBound() < 0;
    	}
    	
    	/// <summary>
    	/// The query lowerBound() returns the lower bound of the multiplicity as an integer, which is the integerValue of lowerValue, if this is given, and 1 otherwise.
    	/// </summary>
    	// spec:
    	//     result = (if (lowerValue=null or lowerValue.integerValue()=null) then 1 else lowerValue.integerValue() endif)
    	public int LowerBound()
    	{
            return LowerValue?.IntegerValue() ?? 1;
    	}
    	
    	/// <summary>
    	/// The query upperBound() returns the upper bound of the multiplicity for a bounded multiplicity as an unlimited natural, which is the unlimitedNaturalValue of upperValue, if given, and 1, otherwise.
    	/// </summary>
    	// spec:
    	//     result = (if (upperValue=null or upperValue.unlimitedValue()=null) then 1 else upperValue.unlimitedValue() endif)
    	public long UpperBound()
    	{
            return UpperValue?.UnlimitedValue() ?? 1;
        }

    }
    
    public partial interface NamedElement
    {
    	/// <summary>
    	/// A name that allows the NamedElement to be identified within a hierarchy of nested Namespaces. It is constructed from the names of the containing Namespaces starting at the root of the hierarchy and ending with the name of the NamedElement itself.
    	/// </summary>
    	// spec:
    	//     result = (if self.name <> null and self.allNamespaces()->select( ns | ns.name=null )->isEmpty()
    	//     then 
    	//         self.allNamespaces()->iterate( ns : Namespace; agg: String = self.name | ns.name.concat(self.separator()).concat(agg))
    	//     else
    	//        null
    	//     endif)
    	[Derived]
    	[ReadOnly]
    	public string? QualifiedName
    	{ 
    		get
    		{
                var allNamespaces = AllNamespaces();
                if (Name is null || allNamespaces.Any(ns => ns.Name is null)) return null;
                var sb = new StringBuilder();
                foreach (var ns in allNamespaces)
                {
                    sb.Append(ns.Name);
                    sb.Append(this.Separator());
                }
                sb.Append(this.Name);
                return sb.ToString();
    		}
    	}
    	
    	/// <summary>
    	/// The query allNamespaces() gives the sequence of Namespaces in which the NamedElement is nested, working outwards.
    	/// </summary>
    	// spec:
    	//     result = (if owner.oclIsKindOf(TemplateParameter) and
    	//       owner.oclAsType(TemplateParameter).signature.template.oclIsKindOf(Namespace) then
    	//         let enclosingNamespace : Namespace =
    	//           owner.oclAsType(TemplateParameter).signature.template.oclAsType(Namespace) in
    	//             enclosingNamespace.allNamespaces()->prepend(enclosingNamespace)
    	//     else
    	//       if namespace->isEmpty()
    	//         then OrderedSet{}
    	//       else
    	//         namespace.allNamespaces()->prepend(namespace)
    	//       endif
    	//     endif)
    	public IList<Namespace> AllNamespaces()
    	{
    		if (Owner is TemplateParameter tp && tp.Signature.Template is Namespace enclosingNamespace)
            {
                var result = enclosingNamespace.AllNamespaces();
                result.Insert(0, enclosingNamespace);
                return result;
            }
            else if (Namespace is null)
            {
                return UmlUtils.EmptyList<Namespace>();
            }
            else
            {
                var result = Namespace.AllNamespaces();
                result.Insert(0, Namespace);
                return result;
            }
    	}
    	
    	/// <summary>
    	/// The query allOwningPackages() returns the set of all the enclosing Namespaces of this NamedElement, working outwards, that are Packages, up to but not including the first such Namespace that is not a Package.
    	/// </summary>
    	// spec:
    	//     result = (if namespace.oclIsKindOf(Package)
    	//     then
    	//       let owningPackage : Package = namespace.oclAsType(Package) in
    	//         owningPackage->union(owningPackage.allOwningPackages())
    	//     else
    	//       null
    	//     endif)
    	public IList<Package> AllOwningPackages()
    	{
    		if (Namespace is Package owningPackage)
            {
                var result = owningPackage.AllOwningPackages();
                result.Insert(0, owningPackage);
                return result;
            }
            return UmlUtils.EmptyList<Package>();
    	}
    	
    	/// <summary>
    	/// The query isDistinguishableFrom() determines whether two NamedElements may logically co-exist within a Namespace. By default, two named elements are distinguishable if (a) they have types neither of which is a kind of the other or (b) they have different names.
    	/// </summary>
    	// spec:
    	//     result = ((self.oclIsKindOf(n.oclType()) or n.oclIsKindOf(self.oclType())) implies
    	//         ns.getNamesOfMember(self)->intersection(ns.getNamesOfMember(n))->isEmpty()
    	//     )
    	public bool IsDistinguishableFrom(NamedElement n, Namespace ns)
    	{
            if (!n.GetType().IsAssignableFrom(this.GetType()) && !this.GetType().IsAssignableFrom(ns.GetType())) return true;
            var thisNames = ns.GetNamesOfMember(this);
            var nNames = ns.GetNamesOfMember(n);
            return !thisNames.Any(tn => nNames.Contains(tn));
    	}
    	
    	/// <summary>
    	/// The query separator() gives the string that is used to separate names when constructing a qualifiedName.
    	/// </summary>
    	// spec:
    	//     result = ('::')
    	public string Separator()
    	{
            return "::";
    	}

        /// <summary>
        /// Indicates the Dependencies that reference this NamedElement as a client.
        /// </summary>
        [ReadOnly]
        [Unordered]
        [Opposite(typeof(Dependency), "Client")]
        public IList<Dependency> ClientDependency { get; }

        /// <summary>
        /// Indicates the dependencies that reference the supplier.
        /// </summary>
        [ReadOnly]
        [Unordered]
        [Opposite(typeof(Dependency), "Supplier")]
        IList<Dependency> SupplierDependency { get; }
    }
    
    public partial interface Namespace
    {
    	/// <summary>
    	/// References the PackageableElements that are members of this Namespace as a result of either PackageImports or ElementImports.
    	/// </summary>
    	// spec:
    	//     result = (self.importMembers(elementImport.importedElement->asSet()->union(packageImport.importedPackage->collect(p | p.visibleMembers()))->asSet()))
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(PackageableElement), "Namespace")]
    	[Subsets(typeof(Namespace), "Member")]
    	public IList<PackageableElement> ImportedMember
    	{ 
    		get
    		{
                var result = new List<ParameterableElement>();
                var imps = ElementImport.Select(ei => ei.ImportedElement).AsListSet();
                imps.AddRange(PackageImport.SelectMany(pi => pi.ImportedPackage.VisibleMembers()));
                return ImportMembers(imps);
    		}
    	}
    	
    	/// <summary>
    	/// The query excludeCollisions() excludes from a set of PackageableElements any that would not be distinguishable from each other in this Namespace.
    	/// </summary>
    	// spec:
    	//     result = (imps->reject(imp1  | imps->exists(imp2 | not imp1.isDistinguishableFrom(imp2, self))))
    	public IList<PackageableElement> ExcludeCollisions(IList<PackageableElement> imps)
    	{
            var result = new List<PackageableElement>();
            foreach (var imp1 in imps)
            {
                if (!imps.Any(imp2 => !imp1.IsDistinguishableFrom(imp2, this)))
                {
                    result.Add(imp1);
                }
            }
            return result;
    	}
    	
    	/// <summary>
    	/// The query getNamesOfMember() gives a set of all of the names that a member would have in a Namespace, taking importing into account. In general a member can have multiple names in a Namespace if it is imported more than once with different aliases.
    	/// </summary>
    	// spec:
    	//     result = (if self.ownedMember ->includes(element)
    	//     then Set{element.name}
    	//     else let elementImports : Set(ElementImport) = self.elementImport->select(ei | ei.importedElement = element) in
    	//       if elementImports->notEmpty()
    	//       then
    	//          elementImports->collect(el | el.getName())->asSet()
    	//       else 
    	//          self.packageImport->select(pi | pi.importedPackage.visibleMembers().oclAsType(NamedElement)->includes(element))-> collect(pi | pi.importedPackage.getNamesOfMember(element))->asSet()
    	//       endif
    	//     endif)
    	public IList<string> GetNamesOfMember(NamedElement element)
    	{
            if (OwnedMember.Contains(element))
            {
                return UmlUtils.SingleItemList(element.Name);
            }
            else
            {
                var elementImports = ElementImport.Where(ei => ei.ImportedElement == element);
                if (elementImports.Any()) return elementImports.Select(ei => ei.GetName()).AsListSet();
                else return PackageImport.Where(pi => pi.ImportedPackage.VisibleMembers().OfType<NamedElement>().Contains(element)).SelectMany(pi => pi.ImportedPackage.GetNamesOfMember(element)).AsListSet();
            }
    	}
    	
    	/// <summary>
    	/// The query importMembers() defines which of a set of PackageableElements are actually imported into the Namespace. This excludes hidden ones, i.e., those which have names that conflict with names of ownedMembers, and it also excludes PackageableElements that would have the indistinguishable names when imported.
    	/// </summary>
    	// spec:
    	//     result = (self.excludeCollisions(imps)->select(imp | self.ownedMember->forAll(mem | imp.isDistinguishableFrom(mem, self))))
    	public IList<PackageableElement> ImportMembers(IList<PackageableElement> imps)
    	{
            return ExcludeCollisions(imps).Where(imp => this.OwnedMember.All(mem => imp.IsDistinguishableFrom(mem, this))).AsListSet();
    	}
    	
    	/// <summary>
    	/// The Boolean query membersAreDistinguishable() determines whether all of the Namespace&apos;s members are distinguishable within it.
    	/// </summary>
    	// spec:
    	//     result = (member->forAll( memb |
    	//        member->excluding(memb)->forAll(other |
    	//            memb.isDistinguishableFrom(other, self))))
    	public bool MembersAreDistinguishable()
    	{
            foreach (var memb in Member)
            {
                foreach (var other in Member)
                {
                    if (other != memb)
                    {
                        if (!memb.IsDistinguishableFrom(other, this)) return false;
                    }
                }
            }
            return true;
    	}
    	
    }
    
    public partial interface PackageableElement
    {
    }
    
    public partial interface PackageImport
    {
    }
    
    public partial interface ParameterableElement
    {
    	/// <summary>
    	/// The query isCompatibleWith() determines if this ParameterableElement is compatible with the specified ParameterableElement. By default, this ParameterableElement is compatible with another ParameterableElement p if the kind of this ParameterableElement is the same as or a subtype of the kind of p. Subclasses of ParameterableElement should override this operation to specify different compatibility constraints.
    	/// </summary>
    	// spec:
    	//     result = (self.oclIsKindOf(p.oclType()))
    	public bool IsCompatibleWith(ParameterableElement p)
    	{
            return p.GetType().IsAssignableFrom(this.GetType());
    	}
    	
    	/// <summary>
    	/// The query isTemplateParameter() determines if this ParameterableElement is exposed as a formal TemplateParameter.
    	/// </summary>
    	// spec:
    	//     result = (templateParameter->notEmpty())
    	public bool IsTemplateParameter()
    	{
            return TemplateParameter is not null;
    	}
    	
    }
    
    public partial interface Realization
    {
    }
    
    public partial interface Relationship
    {
    }
    
    public partial interface TemplateableElement
    {
    	/// <summary>
    	/// The query isTemplate() returns whether this TemplateableElement is actually a template.
    	/// </summary>
    	// spec:
    	//     result = (ownedTemplateSignature <> null)
    	public bool IsTemplate()
    	{
    		return OwnedTemplateSignature is not null;
    	}
    	
    	/// <summary>
    	/// The query parameterableElements() returns the set of ParameterableElements that may be used as the parameteredElements for a TemplateParameter of this TemplateableElement. By default, this set includes all the ownedElements. Subclasses may override this operation if they choose to restrict the set of ParameterableElements.
    	/// </summary>
    	// spec:
    	//     result = (self.allOwnedElements()->select(oclIsKindOf(ParameterableElement)).oclAsType(ParameterableElement)->asSet())
    	public IList<ParameterableElement> ParameterableElements()
    	{
            return this.AllOwnedElements().OfType<ParameterableElement>().AsListSet();
    	}
    	
    }
    
    public partial interface TemplateBinding
    {
    }
    
    public partial interface TemplateParameter
    {
    }
    
    public partial interface TemplateParameterSubstitution
    {
    }
    
    public partial interface TemplateSignature
    {
    }
    
    public partial interface Type
    {
    	/// <summary>
    	/// The query conformsTo() gives true for a Type that conforms to another. By default, two Types do not conform to each other. This query is intended to be redefined for specific conformance situations.
    	/// </summary>
    	// spec:
    	//     result = (false)
    	public bool ConformsTo(Type other)
    	{
            return false;
    	}
    	
    }
    
    public partial interface TypedElement
    {
    }
    
    public partial interface Usage
    {
    }
    
    public partial interface AnyReceiveEvent
    {
    }
    
    public partial interface Behavior
    {
    	/// <summary>
    	/// The BehavioredClassifier that is the context for the execution of the Behavior. A Behavior that is directly owned as a nestedClassifier does not have a context. Otherwise, to determine the context of a Behavior, find the first BehavioredClassifier reached by following the chain of owner relationships from the Behavior, if any. If there is such a BehavioredClassifier, then it is the context, unless it is itself a Behavior with a non-empty context, in which case that is also the context for the original Behavior. For example, following this algorithm, the context of an entry Behavior in a StateMachine is the BehavioredClassifier that owns the StateMachine. The features of the context BehavioredClassifier as well as the Elements visible to the context Classifier are visible to the Behavior.
    	/// </summary>
    	// spec:
    	//     result = (if nestingClass <> null then
    	//         null
    	//     else
    	//         let b:BehavioredClassifier = self.behavioredClassifier(self.owner) in
    	//         if b.oclIsKindOf(Behavior) and b.oclAsType(Behavior)._'context' <> null then 
    	//             b.oclAsType(Behavior)._'context'
    	//         else 
    	//             b 
    	//         endif
    	//     endif
    	//             )
    	[Derived]
    	[ReadOnly]
    	[Opposite(typeof(BehavioredClassifier), "Behavior")]
    	[Subsets(typeof(RedefinableElement), "RedefinitionContext")]
    	public BehavioredClassifier? Context
    	{ 
    		get
    		{
                if (NestingClass is not null)
                {
                    return null;
                }
                else
                {
                    var b = this.BehavioredClassifier(this.Owner);
                    if (b is Behavior beh && beh.Context is not null) return beh.Context;
                    else return b;
                }
    		}
    	}
    	
    	/// <summary>
    	/// The first BehavioredClassifier reached by following the chain of owner relationships from the Behavior, if any.
    	/// </summary>
    	// spec:
    	//     if from.oclIsKindOf(BehavioredClassifier) then
    	//         from.oclAsType(BehavioredClassifier)
    	//     else if from.owner = null then
    	//         null
    	//     else
    	//         self.behavioredClassifier(from.owner)
    	//     endif
    	//     endif
    	//         
    	public BehavioredClassifier? BehavioredClassifier(Element from)
    	{
            if (from is BehavioredClassifier bc) return bc;
            else if (from.Owner is null) return null;
            else return this.BehavioredClassifier(from.Owner);
    	}
    	
    	/// <summary>
    	/// The in and inout ownedParameters of the Behavior.
    	/// </summary>
    	// spec:
    	//     result = (ownedParameter->select(direction=ParameterDirectionKind::_'in' or direction=ParameterDirectionKind::inout))
    	public IList<Parameter> InputParameters()
    	{
            return OwnedParameter.Where(p => p.Direction == ParameterDirectionKind.In || p.Direction == ParameterDirectionKind.Inout).AsListSet();
    	}
    	
    	/// <summary>
    	/// The out, inout and return ownedParameters.
    	/// </summary>
    	// spec:
    	//     result = (ownedParameter->select(direction=ParameterDirectionKind::out or direction=ParameterDirectionKind::inout or direction=ParameterDirectionKind::return))
    	public IList<Parameter> OutputParameters()
    	{
            return OwnedParameter.Where(p => p.Direction == ParameterDirectionKind.Out || p.Direction == ParameterDirectionKind.Inout || p.Direction == ParameterDirectionKind.Return).AsListSet();
        }

    }
    
    public partial interface CallEvent
    {
    }
    
    public partial interface ChangeEvent
    {
    }
    
    public partial interface Event
    {
    }
    
    public partial interface FunctionBehavior
    {
    	/// <summary>
    	/// The hasAllDataTypeAttributes query tests whether the types of the attributes of the given DataType are all DataTypes, and similarly for all those DataTypes.
    	/// </summary>
    	// spec:
    	//     result = (d.ownedAttribute->forAll(a |
    	//         a.type.oclIsKindOf(DataType) and
    	//           hasAllDataTypeAttributes(a.type.oclAsType(DataType))))
    	public bool HasAllDataTypeAttributes(DataType d)
    	{
            return d.OwnedAttribute.All(a => a.Type is DataType adt && HasAllDataTypeAttributes(adt));
    	}
    	
    }
    
    public partial interface MessageEvent
    {
    }
    
    public partial interface OpaqueBehavior
    {
    }
    
    public partial interface SignalEvent
    {
    }
    
    public partial interface TimeEvent
    {
    }
    
    public partial interface Trigger
    {
    }
    
    public partial interface Substitution
    {
    }
    
    public partial interface BehavioralFeature
    {
    	/// <summary>
    	/// The query isDistinguishableFrom() determines whether two BehavioralFeatures may coexist in the same Namespace. It specifies that they must have different signatures.
    	/// </summary>
    	// spec:
    	//     result = ((n.oclIsKindOf(BehavioralFeature) and ns.getNamesOfMember(self)->intersection(ns.getNamesOfMember(n))->notEmpty()) implies
    	//       Set{self}->including(n.oclAsType(BehavioralFeature))->isUnique(ownedParameter->collect(p|
    	//       Tuple { name=p.name, type=p.type,effect=p.effect,direction=p.direction,isException=p.isException,
    	//                   isStream=p.isStream,isOrdered=p.isOrdered,isUnique=p.isUnique,lower=p.lower, upper=p.upper }))
    	//       )
    	public new bool IsDistinguishableFrom(NamedElement n, Namespace ns)
    	{
            if (n is not BehavioralFeature bf) return true;
            var thisNames = ns.GetNamesOfMember(this);
            var otherNames = ns.GetNamesOfMember(n);
            if (!thisNames.Any(tn => otherNames.Contains(tn))) return true;
            if (this.OwnedParameter.Count != bf.OwnedParameter.Count) return true;
            for (int i = 0; i < this.OwnedParameter.Count; i++)
            {
                var p = this.OwnedParameter[i];
                var otherParam = bf.OwnedParameter.FirstOrDefault(
                    op => op.Name == p.Name && op.Type == p.Type && op.Effect == p.Effect && op.Direction == p.Direction &&
                        op.IsException == p.IsException && op.IsStream == p.IsStream && op.IsOrdered == p.IsOrdered &&
                        op.IsUnique == p.IsUnique && op.Lower == p.Lower && op.Upper == p.Upper);
                if (otherParam is not null) return false;
            }
            return true;
    	}
    	
    	/// <summary>
    	/// The ownedParameters with direction in and inout.
    	/// </summary>
    	// spec:
    	//     result = (ownedParameter->select(direction=ParameterDirectionKind::_'in' or direction=ParameterDirectionKind::inout))
    	public IList<Parameter> InputParameters()
    	{
            return OwnedParameter.Where(p => p.Direction == ParameterDirectionKind.In || p.Direction == ParameterDirectionKind.Inout).AsListSet();
        }
    	
    	/// <summary>
    	/// The ownedParameters with direction out, inout, or return.
    	/// </summary>
    	// spec:
    	//     result = (ownedParameter->select(direction=ParameterDirectionKind::out or direction=ParameterDirectionKind::inout or direction=ParameterDirectionKind::return))
    	public IList<Parameter> OutputParameters()
    	{
            return OwnedParameter.Where(p => p.Direction == ParameterDirectionKind.Out || p.Direction == ParameterDirectionKind.Inout || p.Direction == ParameterDirectionKind.Return).AsListSet();
        }
    	
    }
    
    public partial interface Classifier
    {
    	/// <summary>
    	/// The generalizing Classifiers for this Classifier.
    	/// </summary>
    	// spec:
    	//     result = (parents())
    	[Derived]
    	[Unordered]
    	[Opposite(typeof(Classifier), "Classifier")]
    	public IList<Classifier> General
    	{ 
    		get
    		{
                return Parents();
    		}
    	}
    	
    	/// <summary>
    	/// All elements inherited by this Classifier from its general Classifiers.
    	/// </summary>
    	// spec:
    	//     result = (inherit(parents()->collect(inheritableMembers(self))->asSet()))
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(NamedElement), "InheritingClassifier")]
    	[Subsets(typeof(Namespace), "Member")]
    	public IList<NamedElement> InheritedMember
    	{ 
    		get
    		{
                return Inherit(Parents().SelectMany(p => p.InheritableMembers(this)));
    		}
    	}
    	
    	/// <summary>
    	/// The query allFeatures() gives all of the Features in the namespace of the Classifier. In general, through mechanisms such as inheritance, this will be a larger set than feature.
    	/// </summary>
    	// spec:
    	//     result = (member->select(oclIsKindOf(Feature))->collect(oclAsType(Feature))->asSet())
    	public IList<Feature> AllFeatures()
    	{
            return Member.OfType<Feature>().AsListSet();
    	}
    	
    	/// <summary>
    	/// The query allParents() gives all of the direct and indirect ancestors of a generalized Classifier.
    	/// </summary>
    	// spec:
    	//     result = (parents()->union(parents()->collect(allParents())->asSet()))
    	public IList<Classifier> AllParents()
    	{
            var result = new List<Classifier>();
            var parents = Parents();
            result.UnionWith(parents);
            result.UnionWith(parents.SelectMany(p => p.AllParents()));
            return result;
    	}
    	
    	/// <summary>
    	/// The query conformsTo() gives true for a Classifier that defines a type that conforms to another. This is used, for example, in the specification of signature conformance for operations.
    	/// </summary>
    	// spec:
    	//     result = (if other.oclIsKindOf(Classifier) then
    	//       let otherClassifier : Classifier = other.oclAsType(Classifier) in
    	//         self = otherClassifier or allParents()->includes(otherClassifier)
    	//     else
    	//       false
    	//     endif)
    	public new bool ConformsTo(Type other)
    	{
            if (other is Classifier otherClassifier) return this == otherClassifier || AllParents().Contains(otherClassifier);
            else return false;
    	}
    	
    	/// <summary>
    	/// The query hasVisibilityOf() determines whether a NamedElement is visible in the classifier. Non-private members are visible. It is only called when the argument is something owned by a parent.
    	/// </summary>
    	// pre:
    	//     allParents()->including(self)->collect(member)->includes(n)
    	// spec:
    	//     result = (n.visibility <> VisibilityKind::private)
    	public bool HasVisibilityOf(NamedElement n)
    	{
            return n.Visibility != VisibilityKind.Private;
    	}
    	
    	/// <summary>
    	/// The query inherit() defines how to inherit a set of elements passed as its argument.  It excludes redefined elements from the result.
    	/// </summary>
    	// spec:
    	//     result = (inhs->reject(inh |
    	//       inh.oclIsKindOf(RedefinableElement) and
    	//       ownedMember->select(oclIsKindOf(RedefinableElement))->
    	//         select(redefinedElement->includes(inh.oclAsType(RedefinableElement)))
    	//            ->notEmpty()))
    	public IList<NamedElement> Inherit(IEnumerable<NamedElement> inhs)
    	{
            var result = new List<NamedElement>();
            foreach (var inh in inhs)
            {
                if (inh is RedefinableElement re && OwnedMember.OfType<RedefinableElement>().Where(ore => ore.RedefinedElement.Contains(re)).Any()) continue;
                result.Include(inh);
            }
            return result;
    	}
    	
    	/// <summary>
    	/// The query inheritableMembers() gives all of the members of a Classifier that may be inherited in one of its descendants, subject to whatever visibility restrictions apply.
    	/// </summary>
    	// pre:
    	//     c.allParents()->includes(self)
    	// spec:
    	//     result = (member->select(m | c.hasVisibilityOf(m)))
    	public IList<NamedElement> InheritableMembers(Classifier c)
    	{
            return Member.Where(m => c.HasVisibilityOf(m)).AsListSet();
    	}
    	
    	/// <summary>
    	/// The query isTemplate() returns whether this Classifier is actually a template.
    	/// </summary>
    	// spec:
    	//     result = (ownedTemplateSignature <> null or general->exists(g | g.isTemplate()))
    	public new bool IsTemplate()
    	{
            return OwnedTemplateSignature is not null || General.Any(g => g.IsTemplate());
    	}
    	
    	/// <summary>
    	/// The query maySpecializeType() determines whether this classifier may have a generalization relationship to classifiers of the specified type. By default a classifier may specialize classifiers of the same or a more general type. It is intended to be redefined by classifiers that have different specialization constraints.
    	/// </summary>
    	// spec:
    	//     result = (self.oclIsKindOf(c.oclType()))
    	public bool MaySpecializeType(Classifier c)
    	{
            return c.GetType().IsAssignableFrom(this.GetType());
    	}
    	
    	/// <summary>
    	/// The query parents() gives all of the immediate ancestors of a generalized Classifier.
    	/// </summary>
    	// spec:
    	//     result = (generalization.general->asSet())
    	public IList<Classifier> Parents()
    	{
            return Generalization.Select(g => g.General).AsListSet();
    	}
    	
    	/// <summary>
    	/// The Interfaces directly realized by this Classifier
    	/// </summary>
    	// spec:
    	//     result = ((clientDependency->
    	//       select(oclIsKindOf(Realization) and supplier->forAll(oclIsKindOf(Interface))))->
    	//           collect(supplier.oclAsType(Interface))->asSet())
    	public IList<Interface> DirectlyRealizedInterfaces()
    	{
            return ClientDependency.OfType<Realization>().Where(r => r.Supplier.All(s => s is Interface)).SelectMany(r => r.Supplier.OfType<Interface>()).AsListSet();
    	}
    	
    	/// <summary>
    	/// The Interfaces directly used by this Classifier
    	/// </summary>
    	// spec:
    	//     result = ((supplierDependency->
    	//       select(oclIsKindOf(Usage) and client->forAll(oclIsKindOf(Interface))))->
    	//         collect(client.oclAsType(Interface))->asSet())
    	public IList<Interface> DirectlyUsedInterfaces()
    	{
            return SupplierDependency.OfType<Realization>().Where(r => r.Client.All(s => s is Interface)).SelectMany(r => r.Client.OfType<Interface>()).AsListSet();
        }

        /// <summary>
        /// The Interfaces realized by this Classifier and all of its generalizations
        /// </summary>
        // spec:
        //     result = (directlyRealizedInterfaces()->union(self.allParents()->collect(directlyRealizedInterfaces()))->asSet())
        public IList<Interface> AllRealizedInterfaces()
    	{
            var result = new List<Interface>();
            result.UnionWith(DirectlyRealizedInterfaces());
            foreach (var parent in AllParents())
            {
                result.UnionWith(parent.DirectlyRealizedInterfaces());
            }
            return result;
    	}
    	
    	/// <summary>
    	/// The Interfaces used by this Classifier and all of its generalizations
    	/// </summary>
    	// spec:
    	//     result = (directlyUsedInterfaces()->union(self.allParents()->collect(directlyUsedInterfaces()))->asSet())
    	public IList<Interface> AllUsedInterfaces()
    	{
            var result = new List<Interface>();
            result.UnionWith(DirectlyUsedInterfaces());
            foreach (var parent in AllParents())
            {
                result.UnionWith(parent.DirectlyUsedInterfaces());
            }
            return result;
        }
    	
    	// spec:
    	//     result = (substitution.contract->includes(contract))
    	public bool IsSubstitutableFor(Classifier contract)
    	{
            return Substitution.Any(s => s.Contract == this);
    	}
    	
    	/// <summary>
    	/// The query allAttributes gives an ordered set of all owned and inherited attributes of the Classifier. All owned attributes appear before any inherited attributes, and the attributes inherited from any more specific parent Classifier appear before those of any more general parent Classifier. However, if the Classifier has multiple immediate parents, then the relative ordering of the sets of attributes from those parents is not defined.
    	/// </summary>
    	// spec:
    	//     result = (attribute->asSequence()->union(parents()->asSequence().allAttributes())->select(p | member->includes(p))->asOrderedSet())
    	public IList<Property> AllAttributes()
    	{
            var result = new List<Property>();
            result.UnionWith(Attribute);
            foreach (var parent in Parents())
            {
                foreach (var p in parent.AllAttributes())
                {
                    if (Member.Contains(p)) result.Include(p);
                }
            }
            return result;
    	}
    	
    	/// <summary>
    	/// All StructuralFeatures related to the Classifier that may have Slots, including direct attributes, inherited attributes, private attributes in generalizations, and memberEnds of Associations, but excluding redefined StructuralFeatures.
    	/// </summary>
    	// spec:
    	//     result = (member->select(oclIsKindOf(StructuralFeature))->
    	//       collect(oclAsType(StructuralFeature))->
    	//        union(self.inherit(self.allParents()->collect(p | p.attribute)->asSet())->
    	//          collect(oclAsType(StructuralFeature)))->asSet())
    	public IList<StructuralFeature> AllSlottableFeatures()
    	{
            var result = new List<StructuralFeature>();
            result.UnionWith(Member.OfType<StructuralFeature>());
            result.UnionWith(this.Inherit(this.AllParents().SelectMany(p => p.Attribute)).OfType<StructuralFeature>());
            return result;
    	}

        [ReadOnly]
        [Opposite(typeof(Class), "NestedClassifier")]
        [Subsets(typeof(NamedElement), "Namespace")]
        [Subsets(typeof(RedefinableElement), "RedefinitionContext")]
        Class? NestingClass { get; }
    }
    
    public partial interface ClassifierTemplateParameter
    {
    }
    
    public partial interface Feature
    {
    }
    
    public partial interface Generalization
    {
    }
    
    public partial interface GeneralizationSet
    {
    }
    
    public partial interface InstanceSpecification
    {
    }
    
    public partial interface InstanceValue
    {
    }
    
    public partial interface Operation
    {
    	/// <summary>
    	/// Specifies whether the return parameter is ordered or not, if present.  This information is derived from the return result for this Operation.
    	/// </summary>
    	// spec:
    	//     result = (if returnResult()->notEmpty() then returnResult()-> exists(isOrdered) else false endif)
    	[Derived]
    	[ReadOnly]
    	public bool IsOrdered
    	{ 
    		get
    		{
                var returnResult = ReturnResult();
                if (returnResult.Count > 0) return returnResult.Any(rr => rr.IsOrdered);
                else return false;
            }
    	}
    	
    	/// <summary>
    	/// Specifies whether the return parameter is unique or not, if present. This information is derived from the return result for this Operation.
    	/// </summary>
    	// spec:
    	//     result = (if returnResult()->notEmpty() then returnResult()->exists(isUnique) else true endif)
    	[Derived]
    	[ReadOnly]
    	public bool IsUnique
    	{ 
    		get
    		{
                var returnResult = ReturnResult();
                if (returnResult.Count > 0) return returnResult.Any(rr => rr.IsUnique);
                else return true;
            }
    	}
    	
    	/// <summary>
    	/// Specifies the lower multiplicity of the return parameter, if present. This information is derived from the return result for this Operation.
    	/// </summary>
    	// spec:
    	//     result = (if returnResult()->notEmpty() then returnResult()->any(true).lower else null endif)
    	[Derived]
    	[ReadOnly]
    	public int? Lower
    	{ 
    		get
    		{
                return ReturnResult().FirstOrDefault()?.Lower;
    		}
    	}
    	
    	/// <summary>
    	/// The return type of the operation, if present. This information is derived from the return result for this Operation.
    	/// </summary>
    	// spec:
    	//     result = (if returnResult()->notEmpty() then returnResult()->any(true).type else null endif)
    	[Derived]
    	[ReadOnly]
    	[Opposite(typeof(Type), "Operation")]
    	public Type? Type
    	{ 
    		get
    		{
                return ReturnResult().FirstOrDefault()?.Type;
            }
    	}
    	
    	/// <summary>
    	/// The upper multiplicity of the return parameter, if present. This information is derived from the return result for this Operation.
    	/// </summary>
    	// spec:
    	//     result = (if returnResult()->notEmpty() then returnResult()->any(true).upper else null endif)
    	[Derived]
    	[ReadOnly]
    	public long? Upper
    	{ 
    		get
    		{
                return ReturnResult().FirstOrDefault()?.Upper;
            }
    	}
    	
    	/// <summary>
    	/// The query isConsistentWith() specifies, for any two Operations in a context in which redefinition is possible, whether redefinition would be consistent. A redefining operation is consistent with a redefined operation if
    	/// it has the same number of owned parameters, and for each parameter the following holds:
    	/// - Direction, ordering and uniqueness are the same.
    	/// - The corresponding types are covariant, contravariant or invariant.
    	/// - The multiplicities are compatible, depending on the parameter direction.
    	/// </summary>
    	// spec:
    	//     result = (redefiningElement.oclIsKindOf(Operation) and
    	//     let op : Operation = redefiningElement.oclAsType(Operation) in
    	//     	self.ownedParameter->size() = op.ownedParameter->size() and
    	//     	Sequence{1..self.ownedParameter->size()}->
    	//     		forAll(i |  
    	//     		  let redefiningParam : Parameter = op.ownedParameter->at(i),
    	//                    redefinedParam : Parameter = self.ownedParameter->at(i) in
    	//                      (redefiningParam.isUnique = redefinedParam.isUnique) and
    	//                      (redefiningParam.isOrdered = redefinedParam. isOrdered) and
    	//                      (redefiningParam.direction = redefinedParam.direction) and
    	//                      (redefiningParam.type.conformsTo(redefinedParam.type) or
    	//                          redefinedParam.type.conformsTo(redefiningParam.type)) and
    	//                      (redefiningParam.direction = ParameterDirectionKind::inout implies
    	//                              (redefinedParam.compatibleWith(redefiningParam) and
    	//                              redefiningParam.compatibleWith(redefinedParam))) and
    	//                      (redefiningParam.direction = ParameterDirectionKind::_'in' implies
    	//                              redefinedParam.compatibleWith(redefiningParam)) and
    	//                      ((redefiningParam.direction = ParameterDirectionKind::out or
    	//                           redefiningParam.direction = ParameterDirectionKind::return) implies
    	//                              redefiningParam.compatibleWith(redefinedParam))
    	//     		))
    	// pre:
    	//     redefiningElement.isRedefinitionContextValid(self)
    	public new bool IsConsistentWith(RedefinableElement redefiningElement)
    	{
            var op = redefiningElement as Operation;
            if (op is null) return false;
            if (this.OwnedParameter.Count != op.OwnedParameter.Count) return false;
            for (int i = 0; i < this.OwnedParameter.Count; i++)
            {
                var redefinedParam = this.OwnedParameter[i];
                var redefiningParam = op.OwnedParameter[i];
                if (redefiningParam.IsUnique != redefinedParam.IsUnique) return false;
                if (redefiningParam.IsOrdered != redefinedParam.IsOrdered) return false;
                if (redefiningParam.Direction != redefinedParam.Direction) return false;
                if (redefiningParam.Type is null || redefinedParam.Type is null || !redefiningParam.Type.ConformsTo(redefinedParam.Type) && !redefinedParam.Type.ConformsTo(redefiningParam.Type)) return false;
                if (redefinedParam.Direction == ParameterDirectionKind.Inout && (!redefiningParam.CompatibleWith(redefinedParam) || !redefinedParam.CompatibleWith(redefiningParam))) return false;
                if (redefinedParam.Direction == ParameterDirectionKind.In && !redefinedParam.CompatibleWith(redefiningParam)) return false;
                if ((redefinedParam.Direction == ParameterDirectionKind.Out || redefinedParam.Direction == ParameterDirectionKind.Return) && !redefiningParam.CompatibleWith(redefinedParam)) return false;
                return true;
            }
            return false;
        }
    	
    	/// <summary>
    	/// The query returnResult() returns the set containing the return parameter of the Operation if one exists, otherwise, it returns an empty set
    	/// </summary>
    	// spec:
    	//     result = (ownedParameter->select (direction = ParameterDirectionKind::return))
    	public IList<Parameter> ReturnResult()
    	{
            return OwnedParameter.Where(p => p.Direction == ParameterDirectionKind.Return).AsListSet();
    	}
    	
    }
    
    public partial interface OperationTemplateParameter
    {
    }
    
    public partial interface Parameter
    {
    	/// <summary>
    	/// A String that represents a value to be used when no argument is supplied for the Parameter.
    	/// </summary>
    	// spec:
    	//     result = (if self.type = String then defaultValue.stringValue() else null endif)
    	[Derived]
    	public string? Default
    	{ 
    		get
    		{
                if (this.Type is PrimitiveType pt && pt.Name == "String") return DefaultValue?.StringValue();
                else return null;
    		}
    	}
    	
    }
    
    public partial interface ParameterSet
    {
    }
    
    public partial interface Property
    {
    	/// <summary>
    	/// If isComposite is true, the object containing the attribute is a container for the object or value contained in the attribute. This is a derived value, indicating whether the aggregation of the Property is composite or not.
    	/// </summary>
    	// spec:
    	//     result = (aggregation = AggregationKind::composite)
    	[Derived]
    	[DefaultValue()]
    	public bool IsComposite
    	{ 
    		get
    		{
                return Aggregation == AggregationKind.Composite;
    		}
    	}
    	
    	/// <summary>
    	/// In the case where the Property is one end of a binary association this gives the other end.
    	/// </summary>
    	// spec:
    	//     result = (if association <> null and association.memberEnd->size() = 2
    	//     then
    	//         association.memberEnd->any(e | e <> self)
    	//     else
    	//         null
    	//     endif)
    	[Derived]
    	[Opposite(typeof(Property), "Property")]
    	public Property? Opposite
    	{ 
    		get
    		{
    			if (Association is not null && Association.MemberEnd.Count == 2)
                {
                    if (Association.MemberEnd[0] == this) return Association.MemberEnd[1];
                    if (Association.MemberEnd[1] == this) return Association.MemberEnd[0];
                }
                return null;
    		}
    	}
    	
    	/// <summary>
    	/// The query isAttribute() is true if the Property is defined as an attribute of some Classifier.
    	/// </summary>
    	// spec:
    	//     result = (not classifier->isEmpty())
    	public bool IsAttribute()
    	{
            return Classifier is not null;
    	}
    	
    	/// <summary>
    	/// The query isCompatibleWith() determines if this Property is compatible with the specified ParameterableElement. This Property is compatible with ParameterableElement p if the kind of this Property is thesame as or a subtype of the kind of p. Further, if p is a TypedElement, then the type of this Property must be conformant with the type of p.
    	/// </summary>
    	// spec:
    	//     result = (self.oclIsKindOf(p.oclType()) and (p.oclIsKindOf(TypeElement) implies
    	//     self.type.conformsTo(p.oclAsType(TypedElement).type)))
    	public new bool IsCompatibleWith(ParameterableElement p)
    	{
            return p.GetType().IsAssignableFrom(this.GetType()) && (!(p is TypedElement te) || this.Type is not null && te.Type is not null && this.Type.ConformsTo(te.Type));
    	}
    	
    	/// <summary>
    	/// The query isConsistentWith() specifies, for any two Properties in a context in which redefinition is possible, whether redefinition would be logically consistent. A redefining Property is consistent with a redefined Property if the type of the redefining Property conforms to the type of the redefined Property, and the multiplicity of the redefining Property (if specified) is contained in the multiplicity of the redefined Property.
    	/// </summary>
    	// pre:
    	//     redefiningElement.isRedefinitionContextValid(self)
    	// spec:
    	//     result = (redefiningElement.oclIsKindOf(Property) and 
    	//       let prop : Property = redefiningElement.oclAsType(Property) in 
    	//       (prop.type.conformsTo(self.type) and 
    	//       ((prop.lowerBound()->notEmpty() and self.lowerBound()->notEmpty()) implies prop.lowerBound() >= self.lowerBound()) and 
    	//       ((prop.upperBound()->notEmpty() and self.upperBound()->notEmpty()) implies prop.lowerBound() <= self.lowerBound()) and 
    	//       (self.isComposite implies prop.isComposite)))
    	public new bool IsConsistentWith(RedefinableElement redefiningElement)
    	{
    		if (redefiningElement is Property prop)
            {
                if (this.Type is null || prop.Type is null || !prop.Type.ConformsTo(this.Type)) return false;
                return this.IncludesMultiplicity(prop);
            }
            return false;
    	}
    	
    	/// <summary>
    	/// The query isNavigable() indicates whether it is possible to navigate across the property.
    	/// </summary>
    	// spec:
    	//     result = (not classifier->isEmpty() or association.navigableOwnedEnd->includes(self))
    	public bool IsNavigable()
    	{
            return Classifier is not null || Association is not null && Association.NavigableOwnedEnd.Contains(this);
    	}
    	
    	/// <summary>
    	/// The query subsettingContext() gives the context for subsetting a Property. It consists, in the case of an attribute, of the corresponding Classifier, and in the case of an association end, all of the Classifiers at the other ends.
    	/// </summary>
    	// spec:
    	//     result = (if association <> null
    	//     then association.memberEnd->excluding(self)->collect(type)->asSet()
    	//     else 
    	//       if classifier<>null
    	//       then classifier->asSet()
    	//       else Set{} 
    	//       endif
    	//     endif)
    	public IList<Type> SubsettingContext()
    	{
            if (Association is not null) return Association.MemberEnd.Where(me => me != this && me.Type is not null).Select(me => me.Type!).AsListSet();
            else if (Classifier is not null) return UmlUtils.SingleItemList<Type>(Classifier);
            else return UmlUtils.EmptyList<Type>();
    	}

        [DerivedUnion]
        [ReadOnly]
        [Opposite(typeof(Classifier), "Attribute")]
        [Subsets(typeof(Feature), "FeaturingClassifier")]
        [Subsets(typeof(RedefinableElement), "RedefinitionContext")]
        Classifier? Classifier { get; }

    }

    public partial interface RedefinableElement
    {
    	/// <summary>
    	/// The query isConsistentWith() specifies, for any two RedefinableElements in a context in which redefinition is possible, whether redefinition would be logically consistent. By default, this is false; this operation must be overridden for subclasses of RedefinableElement to define the consistency conditions.
    	/// </summary>
    	// spec:
    	//     result = (false)
    	// pre:
    	//     redefiningElement.isRedefinitionContextValid(self)
    	public bool IsConsistentWith(RedefinableElement redefiningElement)
    	{
            return false;
    	}
    	
    	/// <summary>
    	/// The query isRedefinitionContextValid() specifies whether the redefinition contexts of this RedefinableElement are properly related to the redefinition contexts of the specified RedefinableElement to allow this element to redefine the other. By default at least one of the redefinition contexts of this element must be a specialization of at least one of the redefinition contexts of the specified element.
    	/// </summary>
    	// spec:
    	//     result = (redefinitionContext->exists(c | c.allParents()->includesAll(redefinedElement.redefinitionContext)))
    	public bool IsRedefinitionContextValid(RedefinableElement redefinedElement)
    	{
            foreach (var c in RedefinitionContext)
            {
                var allParents = c.AllParents();
                if (redefinedElement.RedefinitionContext.All(rc => allParents.Contains(rc))) return true;
            }
            return false;
    	}
    	
    }
    
    public partial interface RedefinableTemplateSignature
    {
    	/// <summary>
    	/// The formal template parameters of the extended signatures.
    	/// </summary>
    	// spec:
    	//     result = (if extendedSignature->isEmpty() then Set{} else extendedSignature.parameter->asSet() endif)
    	[Derived]
    	[Unordered]
    	[ReadOnly]
    	[Opposite(typeof(TemplateParameter), "RedefinableTemplateSignature")]
    	[Subsets(typeof(TemplateSignature), "Parameter")]
    	public IList<TemplateParameter> InheritedParameter
    	{ 
    		get
    		{
                if (ExtendedSignature is null) return UmlUtils.EmptyList<TemplateParameter>();
                else return ExtendedSignature.SelectMany(es => es.Parameter).AsListSet();
    		}
    	}
    	
    	/// <summary>
    	/// The query isConsistentWith() specifies, for any two RedefinableTemplateSignatures in a context in which redefinition is possible, whether redefinition would be logically consistent. A redefining template signature is always consistent with a redefined template signature, as redefinition only adds new formal parameters.
    	/// </summary>
    	// spec:
    	//     result = (redefiningElement.oclIsKindOf(RedefinableTemplateSignature))
    	// pre:
    	//     redefiningElement.isRedefinitionContextValid(self)
    	public new bool IsConsistentWith(RedefinableElement redefiningElement)
    	{
            return redefiningElement is RedefinableTemplateSignature;
    	}
    	
    }
    
    public partial interface Slot
    {
    }
    
    public partial interface StructuralFeature
    {
    }
    
    public partial interface ValueSpecificationAction
    {
    }
    
    public partial interface VariableAction
    {
    }
    
    public partial interface WriteLinkAction
    {
    }
    
    public partial interface WriteStructuralFeatureAction
    {
    }
    
    public partial interface WriteVariableAction
    {
    }
    
    public partial interface AcceptCallAction
    {
    }
    
    public partial interface AcceptEventAction
    {
    }
    
    public partial interface Action
    {
    	/// <summary>
    	/// The context Classifier of the Behavior that contains this Action, or the Behavior itself if it has no context.
    	/// </summary>
    	// spec:
    	//     result = (let behavior: Behavior = self.containingBehavior() in
    	//     if behavior=null then null
    	//     else if behavior._'context' = null then behavior
    	//     else behavior._'context'
    	//     endif
    	//     endif)
    	[Derived]
    	[ReadOnly]
    	[Opposite(typeof(Classifier), "Action")]
    	public Classifier? Context
    	{ 
    		get
    		{
                var behavior = this.ContainingBehavior();
                return behavior?.Context ?? behavior;
    		}
    	}
    	
    	/// <summary>
    	/// Return this Action and all Actions contained directly or indirectly in it. By default only the Action itself is returned, but the operation is overridden for StructuredActivityNodes.
    	/// </summary>
    	// spec:
    	//     result = (self->asSet())
    	public IList<Action> AllActions()
    	{
            return UmlUtils.SingleItemList(this);
    	}
    	
    	/// <summary>
    	/// Returns all the ActivityNodes directly or indirectly owned by this Action. This includes at least all the Pins of the Action.
    	/// </summary>
    	// spec:
    	//     result = (input.oclAsType(Pin)->asSet()->union(output->asSet()))
    	public IList<ActivityNode> AllOwnedNodes()
    	{
            var result = Input.AsListSet<ActivityNode>();
            result.UnionWith(Output);
            return result;
    	}
    	
    	// spec:
    	//     result = (if inStructuredNode<>null then inStructuredNode.containingBehavior() 
    	//     else if activity<>null then activity
    	//     else interaction 
    	//     endif
    	//     endif
    	//     )
    	public Behavior? ContainingBehavior()
    	{
            if (InStructuredNode is not null) return InStructuredNode.ContainingBehavior();
            else if (Activity is not null) return Activity;
            else return Interaction;
    	}

        [ReadOnly]
        [Opposite(typeof(Interaction), "Action")]
        [Subsets(typeof(Element), "Owner")]
        Interaction? Interaction { get; }
    }
    
    public partial interface ActionInputPin
    {
    }
    
    public partial interface AddStructuralFeatureValueAction
    {
    }
    
    public partial interface AddVariableValueAction
    {
    }
    
    public partial interface BroadcastSignalAction
    {
    }
    
    public partial interface CallAction
    {
    	/// <summary>
    	/// Return the in and inout ownedParameters of the Behavior or Operation being called. (This operation is abstract and should be overridden by subclasses of CallAction.)
    	/// </summary>
    	public IList<Parameter> InputParameters()
    	{
    		throw new NotImplementedException("This operation is abstract and should be overridden by subclasses of CallAction.");
    	}
    	
    	/// <summary>
    	/// Return the inout, out and return ownedParameters of the Behavior or Operation being called. (This operation is abstract and should be overridden by subclasses of CallAction.)
    	/// </summary>
    	public IList<Parameter> OutputParameters()
    	{
    		throw new NotImplementedException("This operation is abstract and should be overridden by subclasses of CallAction.");
    	}
    	
    }
    
    public partial interface CallBehaviorAction
    {
    	/// <summary>
    	/// Return the inout, out and return ownedParameters of the Behavior being called.
    	/// </summary>
    	// spec:
    	//     result = (behavior.outputParameters())
    	public new IList<Parameter> OutputParameters()
    	{
            return Behavior.OutputParameters();
    	}
    	
    	/// <summary>
    	/// Return the in and inout ownedParameters of the Behavior being called.
    	/// </summary>
    	// spec:
    	//     result = (behavior.inputParameters())
    	public new IList<Parameter> InputParameters()
    	{
            return Behavior.InputParameters();
    	}
    	
    }
    
    public partial interface CallOperationAction
    {
    	/// <summary>
    	/// Return the inout, out and return ownedParameters of the Operation being called.
    	/// </summary>
    	// spec:
    	//     result = (operation.outputParameters())
    	public new IList<Parameter> OutputParameters()
    	{
            return Operation.OutputParameters();
    	}
    	
    	/// <summary>
    	/// Return the in and inout ownedParameters of the Operation being called.
    	/// </summary>
    	// spec:
    	//     result = (operation.inputParameters())
    	public new IList<Parameter> InputParameters()
    	{
            return Operation.InputParameters();
    	}
    	
    }
    
    public partial interface Clause
    {
    }
    
    public partial interface ClearAssociationAction
    {
    }
    
    public partial interface ClearStructuralFeatureAction
    {
    }
    
    public partial interface ClearVariableAction
    {
    }
    
    public partial interface ConditionalNode
    {
    	/// <summary>
    	/// Return only this ConditionalNode. This prevents Actions within the ConditionalNode from having their OutputPins used as bodyOutputs or decider Pins in containing LoopNodes or ConditionalNodes.
    	/// </summary>
    	// spec:
    	//     result = (self->asSet())
    	public new IList<Action> AllActions()
    	{
            return UmlUtils.SingleItemList<Action>(this);
    	}
    	
    }
    
    public partial interface CreateLinkAction
    {
    }
    
    public partial interface CreateLinkObjectAction
    {
    }
    
    public partial interface CreateObjectAction
    {
    }
    
    public partial interface DestroyLinkAction
    {
    }
    
    public partial interface DestroyObjectAction
    {
    }
    
    public partial interface ExpansionNode
    {
    }
    
    public partial interface ExpansionRegion
    {
    }
    
    public partial interface InputPin
    {
    }
    
    public partial interface InvocationAction
    {
    }
    
    public partial interface LinkAction
    {
    	/// <summary>
    	/// Returns the Association acted on by this LinkAction.
    	/// </summary>
    	// spec:
    	//     result = (endData->asSequence()->first().end.association)
    	public Association? Association()
    	{
            return EndData.FirstOrDefault()?.End?.Association;
    	}
    	
    }
    
    public partial interface LinkEndCreationData
    {
    	/// <summary>
    	/// Adds the insertAt InputPin (if any) to the set of all Pins.
    	/// </summary>
    	// spec:
    	//     result = (self.LinkEndData::allPins()->including(insertAt))
    	public new IList<InputPin> AllPins()
    	{
            var result = new List<InputPin>();
            if (Value is not null) result.Include(Value);
            result.UnionWith(Qualifier.Select(q => q.Value));
            if (InsertAt is not null) result.Include(InsertAt);
            return result;
    	}
    	
    }
    
    public partial interface LinkEndData
    {
    	/// <summary>
    	/// Returns all the InputPins referenced by this LinkEndData. By default this includes the value and qualifier InputPins, but subclasses may override the operation to add other InputPins.
    	/// </summary>
    	// spec:
    	//     result = (value->asBag()->union(qualifier.value))
    	public IList<InputPin> AllPins()
    	{
            var result = new List<InputPin>();
            if (Value is not null) result.Include(Value);
            result.UnionWith(Qualifier.Select(q => q.Value));
            return result;
    	}
    	
    }
    
    public partial interface LinkEndDestructionData
    {
    	/// <summary>
    	/// Adds the destroyAt InputPin (if any) to the set of all Pins.
    	/// </summary>
    	// spec:
    	//     result = (self.LinkEndData::allPins()->including(destroyAt))
    	public new IList<InputPin> AllPins()
    	{
            var result = new List<InputPin>();
            if (Value is not null) result.Include(Value);
            result.UnionWith(Qualifier.Select(q => q.Value));
            if (DestroyAt is not null) result.Include(DestroyAt);
            return result;
        }
    	
    }
    
    public partial interface LoopNode
    {
    	/// <summary>
    	/// Return only this LoopNode. This prevents Actions within the LoopNode from having their OutputPins used as bodyOutputs or decider Pins in containing LoopNodes or ConditionalNodes.
    	/// </summary>
    	// spec:
    	//     result = (self->asSet())
    	public new IList<Action> AllActions()
    	{
            return UmlUtils.SingleItemList<Action>(this);
    	}
    	
    	/// <summary>
    	/// Return the loopVariable OutputPins in addition to other source nodes for the LoopNode as a StructuredActivityNode.
    	/// </summary>
    	// spec:
    	//     result = (self.StructuredActivityNode::sourceNodes()->union(loopVariable))
    	public new IList<ActivityNode> SourceNodes()
    	{
            var result = new List<ActivityNode>();
            result.UnionWith(Node);
            result.UnionWith(Input.OfType<ActivityNode>());
            result.UnionWith(Node.OfType<Action>().SelectMany(a => a.Output));
            result.UnionWith(LoopVariable);
            return result;
        }
    	
    }
    
    public partial interface OpaqueAction
    {
    }
    
    public partial interface OutputPin
    {
    }
    
    public partial interface Pin
    {
    }
    
    public partial interface QualifierValue
    {
    }
    
    public partial interface RaiseExceptionAction
    {
    }
    
    public partial interface ReadExtentAction
    {
    }
    
    public partial interface ReadIsClassifiedObjectAction
    {
    }
    
    public partial interface ReadLinkAction
    {
    	/// <summary>
    	/// Returns the ends corresponding to endData with no value InputPin. (A well-formed ReadLinkAction is constrained to have only one of these.)
    	/// </summary>
    	// spec:
    	//     result = (endData->select(value=null).end->asOrderedSet())
    	public IList<Property> OpenEnd()
    	{
            return EndData.Where(d => d.Value is null).Select(d => d.End).AsListSet();
    	}
    	
    }
    
    public partial interface ReadLinkObjectEndAction
    {
    }
    
    public partial interface ReadLinkObjectEndQualifierAction
    {
    }
    
    public partial interface ReadSelfAction
    {
    }
    
    public partial interface ReadStructuralFeatureAction
    {
    }
    
    public partial interface ReadVariableAction
    {
    }
    
    public partial interface ReclassifyObjectAction
    {
    }
    
    public partial interface ReduceAction
    {
    }
    
    public partial interface RemoveStructuralFeatureValueAction
    {
    }
    
    public partial interface RemoveVariableValueAction
    {
    }
    
    public partial interface ReplyAction
    {
    }
    
    public partial interface SendObjectAction
    {
    }
    
    public partial interface SendSignalAction
    {
    }
    
    public partial interface SequenceNode
    {
    }
    
    public partial interface StartClassifierBehaviorAction
    {
    }
    
    public partial interface StartObjectBehaviorAction
    {
    	/// <summary>
    	/// Return the inout, out and return ownedParameters of the Behavior being called.
    	/// </summary>
    	// spec:
    	//     result = (self.behavior().outputParameters())
    	public new IList<Parameter> OutputParameters()
    	{
            return Behavior()?.OutputParameters() ?? UmlUtils.EmptyList<Parameter>();
    	}
    	
    	/// <summary>
    	/// Return the in and inout ownedParameters of the Behavior being called.
    	/// </summary>
    	// spec:
    	//     result = (self.behavior().inputParameters())
    	public new IList<Parameter> InputParameters()
    	{
            return Behavior()?.InputParameters() ?? UmlUtils.EmptyList<Parameter>();
        }

        /// <summary>
        /// If the type of the object InputPin is a Behavior, then that Behavior. Otherwise, if the type of the object InputPin is a BehavioredClassifier, then the classifierBehavior of that BehavioredClassifier.
        /// </summary>
        // spec:
        //     result = (if object.type.oclIsKindOf(Behavior) then
        //       object.type.oclAsType(Behavior)
        //     else if object.type.oclIsKindOf(BehavioredClassifier) then
        //       object.type.oclAsType(BehavioredClassifier).classifierBehavior
        //     else
        //       null
        //     endif
        //     endif)
        public Behavior? Behavior()
    	{
            if (Object.Type is Behavior ob) return ob;
            else if (Object.Type is BehavioredClassifier bc) return bc.ClassifierBehavior;
            else return null;
    	}
    	
    }
    
    public partial interface StructuralFeatureAction
    {
    }
    
    public partial interface StructuredActivityNode
    {
    	/// <summary>
    	/// Returns this StructuredActivityNode and all Actions contained in it.
    	/// </summary>
    	// spec:
    	//     result = (node->select(oclIsKindOf(Action)).oclAsType(Action).allActions()->including(self)->asSet())
    	public new IList<Action> AllActions()
    	{
            return Node.OfType<Action>().SelectMany(a => a.AllActions()).AsListSet().Include(this);
    	}
    	
    	/// <summary>
    	/// Returns all the ActivityNodes contained directly or indirectly within this StructuredActivityNode, in addition to the Pins of the StructuredActivityNode.
    	/// </summary>
    	// spec:
    	//     result = (self.Action::allOwnedNodes()->union(node)->union(node->select(oclIsKindOf(Action)).oclAsType(Action).allOwnedNodes())->asSet())
    	public new IList<ActivityNode> AllOwnedNodes()
    	{
            var result = Input.AsListSet<ActivityNode>();
            result.UnionWith(Output);
            result.UnionWith(Node);
            result.UnionWith(Node.OfType<Action>().SelectMany(a => a.AllOwnedNodes()));
            return result;
        }
    	
    	/// <summary>
    	/// Return those ActivityNodes contained immediately within the StructuredActivityNode that may act as sources of edges owned by the StructuredActivityNode.
    	/// </summary>
    	// spec:
    	//     result = (node->union(input.oclAsType(ActivityNode)->asSet())->
    	//       union(node->select(oclIsKindOf(Action)).oclAsType(Action).output)->asSet())
    	public IList<ActivityNode> SourceNodes()
    	{
            var result = new List<ActivityNode>();
            result.UnionWith(Node);
            result.UnionWith(Input.OfType<ActivityNode>());
            result.UnionWith(Node.OfType<Action>().SelectMany(a => a.Output));
            return result;
        }
    	
    	/// <summary>
    	/// Return those ActivityNodes contained immediately within the StructuredActivityNode that may act as targets of edges owned by the StructuredActivityNode.
    	/// </summary>
    	// spec:
    	//     result = (node->union(output.oclAsType(ActivityNode)->asSet())->
    	//       union(node->select(oclIsKindOf(Action)).oclAsType(Action).input)->asSet())
    	public IList<ActivityNode> TargetNodes()
    	{
            var result = new List<ActivityNode>();
            result.UnionWith(Node);
            result.UnionWith(Output.OfType<ActivityNode>());
            result.UnionWith(Node.OfType<Action>().SelectMany(a => a.Input));
            return result;
        }

        /// <summary>
        /// The Activity that directly or indirectly contains this StructuredActivityNode (considered as an Action).
        /// </summary>
        // spec:
        //     result = (self.ActivityNode::containingActivity())
        public new Activity? ContainingActivity()
    	{
            if (InStructuredNode is not null) return InStructuredNode.ContainingActivity();
            else return Activity;
        }
    	
    }
    
    public partial interface TestIdentityAction
    {
    }
    
    public partial interface UnmarshallAction
    {
    }
    
    public partial interface ValuePin
    {
    }
    
}
