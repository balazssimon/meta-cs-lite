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
        /// Constructor for the class Element
        /// </summary>
        public virtual void Element(Element _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class NamedElement
        /// </summary>
        public virtual void NamedElement(NamedElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Abstraction
        /// </summary>
        public virtual void Abstraction(Abstraction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Action
        /// </summary>
        public virtual void Action(Action _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class AcceptEventAction
        /// </summary>
        public virtual void AcceptEventAction(AcceptEventAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class AcceptCallAction
        /// </summary>
        public virtual void AcceptCallAction(AcceptCallAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ActionExecutionSpecification
        /// </summary>
        public virtual void ActionExecutionSpecification(ActionExecutionSpecification _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ActionInputPin
        /// </summary>
        public virtual void ActionInputPin(ActionInputPin _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Classifier
        /// </summary>
        public virtual void Classifier(Classifier _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class BehavioredClassifier
        /// </summary>
        public virtual void BehavioredClassifier(BehavioredClassifier _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Class
        /// </summary>
        public virtual void Class(Class _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Behavior
        /// </summary>
        public virtual void Behavior(Behavior _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Activity
        /// </summary>
        public virtual void Activity(Activity _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ActivityEdge
        /// </summary>
        public virtual void ActivityEdge(ActivityEdge _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ActivityNode
        /// </summary>
        public virtual void ActivityNode(ActivityNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ActivityFinalNode
        /// </summary>
        public virtual void ActivityFinalNode(ActivityFinalNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ActivityGroup
        /// </summary>
        public virtual void ActivityGroup(ActivityGroup _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ActivityParameterNode
        /// </summary>
        public virtual void ActivityParameterNode(ActivityParameterNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ActivityPartition
        /// </summary>
        public virtual void ActivityPartition(ActivityPartition _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Actor
        /// </summary>
        public virtual void Actor(Actor _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class AddStructuralFeatureValueAction
        /// </summary>
        public virtual void AddStructuralFeatureValueAction(AddStructuralFeatureValueAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class AddVariableValueAction
        /// </summary>
        public virtual void AddVariableValueAction(AddVariableValueAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class AnyReceiveEvent
        /// </summary>
        public virtual void AnyReceiveEvent(AnyReceiveEvent _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Association
        /// </summary>
        public virtual void Association(Association _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class AssociationClass
        /// </summary>
        public virtual void AssociationClass(AssociationClass _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class BehavioralFeature
        /// </summary>
        public virtual void BehavioralFeature(BehavioralFeature _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class BehaviorExecutionSpecification
        /// </summary>
        public virtual void BehaviorExecutionSpecification(BehaviorExecutionSpecification _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class BroadcastSignalAction
        /// </summary>
        public virtual void BroadcastSignalAction(BroadcastSignalAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class CallAction
        /// </summary>
        public virtual void CallAction(CallAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class CallBehaviorAction
        /// </summary>
        public virtual void CallBehaviorAction(CallBehaviorAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class CallEvent
        /// </summary>
        public virtual void CallEvent(CallEvent _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class CallOperationAction
        /// </summary>
        public virtual void CallOperationAction(CallOperationAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class CentralBufferNode
        /// </summary>
        public virtual void CentralBufferNode(CentralBufferNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ChangeEvent
        /// </summary>
        public virtual void ChangeEvent(ChangeEvent _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ClassifierTemplateParameter
        /// </summary>
        public virtual void ClassifierTemplateParameter(ClassifierTemplateParameter _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Clause
        /// </summary>
        public virtual void Clause(Clause _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ClearAssociationAction
        /// </summary>
        public virtual void ClearAssociationAction(ClearAssociationAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ClearStructuralFeatureAction
        /// </summary>
        public virtual void ClearStructuralFeatureAction(ClearStructuralFeatureAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ClearVariableAction
        /// </summary>
        public virtual void ClearVariableAction(ClearVariableAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Collaboration
        /// </summary>
        public virtual void Collaboration(Collaboration _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class CollaborationUse
        /// </summary>
        public virtual void CollaborationUse(CollaborationUse _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class CombinedFragment
        /// </summary>
        public virtual void CombinedFragment(CombinedFragment _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Comment
        /// </summary>
        public virtual void Comment(Comment _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class CommunicationPath
        /// </summary>
        public virtual void CommunicationPath(CommunicationPath _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Component
        /// </summary>
        public virtual void Component(Component _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ComponentRealization
        /// </summary>
        public virtual void ComponentRealization(ComponentRealization _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ConditionalNode
        /// </summary>
        public virtual void ConditionalNode(ConditionalNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ConnectableElement
        /// </summary>
        public virtual void ConnectableElement(ConnectableElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ConnectableElementTemplateParameter
        /// </summary>
        public virtual void ConnectableElementTemplateParameter(ConnectableElementTemplateParameter _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ConnectionPointReference
        /// </summary>
        public virtual void ConnectionPointReference(ConnectionPointReference _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Connector
        /// </summary>
        public virtual void Connector(Connector _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ConnectorEnd
        /// </summary>
        public virtual void ConnectorEnd(ConnectorEnd _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ConsiderIgnoreFragment
        /// </summary>
        public virtual void ConsiderIgnoreFragment(ConsiderIgnoreFragment _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Constraint
        /// </summary>
        public virtual void Constraint(Constraint _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Continuation
        /// </summary>
        public virtual void Continuation(Continuation _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ControlFlow
        /// </summary>
        public virtual void ControlFlow(ControlFlow _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ControlNode
        /// </summary>
        public virtual void ControlNode(ControlNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class CreateLinkAction
        /// </summary>
        public virtual void CreateLinkAction(CreateLinkAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class CreateLinkObjectAction
        /// </summary>
        public virtual void CreateLinkObjectAction(CreateLinkObjectAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class CreateObjectAction
        /// </summary>
        public virtual void CreateObjectAction(CreateObjectAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DataStoreNode
        /// </summary>
        public virtual void DataStoreNode(DataStoreNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DataType
        /// </summary>
        public virtual void DataType(DataType _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DecisionNode
        /// </summary>
        public virtual void DecisionNode(DecisionNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Dependency
        /// </summary>
        public virtual void Dependency(Dependency _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DeployedArtifact
        /// </summary>
        public virtual void DeployedArtifact(DeployedArtifact _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DeploymentTarget
        /// </summary>
        public virtual void DeploymentTarget(DeploymentTarget _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DestroyLinkAction
        /// </summary>
        public virtual void DestroyLinkAction(DestroyLinkAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DestroyObjectAction
        /// </summary>
        public virtual void DestroyObjectAction(DestroyObjectAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DestructionOccurrenceSpecification
        /// </summary>
        public virtual void DestructionOccurrenceSpecification(DestructionOccurrenceSpecification _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DirectedRelationship
        /// </summary>
        public virtual void DirectedRelationship(DirectedRelationship _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ElementImport
        /// </summary>
        public virtual void ElementImport(ElementImport _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ExceptionHandler
        /// </summary>
        public virtual void ExceptionHandler(ExceptionHandler _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ExecutableNode
        /// </summary>
        public virtual void ExecutableNode(ExecutableNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ExecutionOccurrenceSpecification
        /// </summary>
        public virtual void ExecutionOccurrenceSpecification(ExecutionOccurrenceSpecification _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ExecutionSpecification
        /// </summary>
        public virtual void ExecutionSpecification(ExecutionSpecification _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ExpansionNode
        /// </summary>
        public virtual void ExpansionNode(ExpansionNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ExpansionRegion
        /// </summary>
        public virtual void ExpansionRegion(ExpansionRegion _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Extend
        /// </summary>
        public virtual void Extend(Extend _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ExtensionEnd
        /// </summary>
        public virtual void ExtensionEnd(ExtensionEnd _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ExtensionPoint
        /// </summary>
        public virtual void ExtensionPoint(ExtensionPoint _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Feature
        /// </summary>
        public virtual void Feature(Feature _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class FinalNode
        /// </summary>
        public virtual void FinalNode(FinalNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class FinalState
        /// </summary>
        public virtual void FinalState(FinalState _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class FlowFinalNode
        /// </summary>
        public virtual void FlowFinalNode(FlowFinalNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ForkNode
        /// </summary>
        public virtual void ForkNode(ForkNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Gate
        /// </summary>
        public virtual void Gate(Gate _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Generalization
        /// </summary>
        public virtual void Generalization(Generalization _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class GeneralOrdering
        /// </summary>
        public virtual void GeneralOrdering(GeneralOrdering _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Image
        /// </summary>
        public virtual void Image(Image _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Include
        /// </summary>
        public virtual void Include(Include _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InitialNode
        /// </summary>
        public virtual void InitialNode(InitialNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InputPin
        /// </summary>
        public virtual void InputPin(InputPin _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ParameterableElement
        /// </summary>
        public virtual void ParameterableElement(ParameterableElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class PackageableElement
        /// </summary>
        public virtual void PackageableElement(PackageableElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Artifact
        /// </summary>
        public virtual void Artifact(Artifact _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Deployment
        /// </summary>
        public virtual void Deployment(Deployment _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DeploymentSpecification
        /// </summary>
        public virtual void DeploymentSpecification(DeploymentSpecification _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Duration
        /// </summary>
        public virtual void Duration(Duration _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DurationConstraint
        /// </summary>
        public virtual void DurationConstraint(DurationConstraint _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DurationInterval
        /// </summary>
        public virtual void DurationInterval(DurationInterval _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class DurationObservation
        /// </summary>
        public virtual void DurationObservation(DurationObservation _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class EncapsulatedClassifier
        /// </summary>
        public virtual void EncapsulatedClassifier(EncapsulatedClassifier _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Device
        /// </summary>
        public virtual void Device(Device _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Enumeration
        /// </summary>
        public virtual void Enumeration(Enumeration _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class EnumerationLiteral
        /// </summary>
        public virtual void EnumerationLiteral(EnumerationLiteral _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Event
        /// </summary>
        public virtual void Event(Event _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ExecutionEnvironment
        /// </summary>
        public virtual void ExecutionEnvironment(ExecutionEnvironment _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Expression
        /// </summary>
        public virtual void Expression(Expression _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Extension
        /// </summary>
        public virtual void Extension(Extension _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class FunctionBehavior
        /// </summary>
        public virtual void FunctionBehavior(FunctionBehavior _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class GeneralizationSet
        /// </summary>
        public virtual void GeneralizationSet(GeneralizationSet _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InformationFlow
        /// </summary>
        public virtual void InformationFlow(InformationFlow _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InformationItem
        /// </summary>
        public virtual void InformationItem(InformationItem _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InstanceSpecification
        /// </summary>
        public virtual void InstanceSpecification(InstanceSpecification _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TypedElement
        /// </summary>
        public virtual void TypedElement(TypedElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InstanceValue
        /// </summary>
        public virtual void InstanceValue(InstanceValue _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Interaction
        /// </summary>
        public virtual void Interaction(Interaction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InteractionConstraint
        /// </summary>
        public virtual void InteractionConstraint(InteractionConstraint _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InteractionFragment
        /// </summary>
        public virtual void InteractionFragment(InteractionFragment _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InteractionOperand
        /// </summary>
        public virtual void InteractionOperand(InteractionOperand _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InteractionUse
        /// </summary>
        public virtual void InteractionUse(InteractionUse _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Interface
        /// </summary>
        public virtual void Interface(Interface _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InterfaceRealization
        /// </summary>
        public virtual void InterfaceRealization(InterfaceRealization _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InterruptibleActivityRegion
        /// </summary>
        public virtual void InterruptibleActivityRegion(InterruptibleActivityRegion _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Interval
        /// </summary>
        public virtual void Interval(Interval _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class IntervalConstraint
        /// </summary>
        public virtual void IntervalConstraint(IntervalConstraint _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class InvocationAction
        /// </summary>
        public virtual void InvocationAction(InvocationAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class JoinNode
        /// </summary>
        public virtual void JoinNode(JoinNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Lifeline
        /// </summary>
        public virtual void Lifeline(Lifeline _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LinkAction
        /// </summary>
        public virtual void LinkAction(LinkAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LinkEndData
        /// </summary>
        public virtual void LinkEndData(LinkEndData _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LinkEndCreationData
        /// </summary>
        public virtual void LinkEndCreationData(LinkEndCreationData _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LinkEndDestructionData
        /// </summary>
        public virtual void LinkEndDestructionData(LinkEndDestructionData _this)
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
        /// Constructor for the class LoopNode
        /// </summary>
        public virtual void LoopNode(LoopNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Manifestation
        /// </summary>
        public virtual void Manifestation(Manifestation _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MergeNode
        /// </summary>
        public virtual void MergeNode(MergeNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Message
        /// </summary>
        public virtual void Message(Message _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MessageEnd
        /// </summary>
        public virtual void MessageEnd(MessageEnd _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MessageEvent
        /// </summary>
        public virtual void MessageEvent(MessageEvent _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Model
        /// </summary>
        public virtual void Model(Model _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MultiplicityElement
        /// </summary>
        public virtual void MultiplicityElement(MultiplicityElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Namespace
        /// </summary>
        public virtual void Namespace(Namespace _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Node
        /// </summary>
        public virtual void Node(Node _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ObjectFlow
        /// </summary>
        public virtual void ObjectFlow(ObjectFlow _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ObjectNode
        /// </summary>
        public virtual void ObjectNode(ObjectNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Observation
        /// </summary>
        public virtual void Observation(Observation _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class OccurrenceSpecification
        /// </summary>
        public virtual void OccurrenceSpecification(OccurrenceSpecification _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MessageOccurrenceSpecification
        /// </summary>
        public virtual void MessageOccurrenceSpecification(MessageOccurrenceSpecification _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class OpaqueExpression
        /// </summary>
        public virtual void OpaqueExpression(OpaqueExpression _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class OperationTemplateParameter
        /// </summary>
        public virtual void OperationTemplateParameter(OperationTemplateParameter _this)
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
        /// Constructor for the class ParameterSet
        /// </summary>
        public virtual void ParameterSet(ParameterSet _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class PartDecomposition
        /// </summary>
        public virtual void PartDecomposition(PartDecomposition _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class RedefinableElement
        /// </summary>
        public virtual void RedefinableElement(RedefinableElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class OpaqueAction
        /// </summary>
        public virtual void OpaqueAction(OpaqueAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class OpaqueBehavior
        /// </summary>
        public virtual void OpaqueBehavior(OpaqueBehavior _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Operation
        /// </summary>
        public virtual void Operation(Operation _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Pin
        /// </summary>
        public virtual void Pin(Pin _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class OutputPin
        /// </summary>
        public virtual void OutputPin(OutputPin _this)
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
        /// Constructor for the class Port
        /// </summary>
        public virtual void Port(Port _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class PrimitiveType
        /// </summary>
        public virtual void PrimitiveType(PrimitiveType _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Profile
        /// </summary>
        public virtual void Profile(Profile _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ProfileApplication
        /// </summary>
        public virtual void ProfileApplication(ProfileApplication _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ProtocolConformance
        /// </summary>
        public virtual void ProtocolConformance(ProtocolConformance _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ProtocolStateMachine
        /// </summary>
        public virtual void ProtocolStateMachine(ProtocolStateMachine _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ProtocolTransition
        /// </summary>
        public virtual void ProtocolTransition(ProtocolTransition _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Pseudostate
        /// </summary>
        public virtual void Pseudostate(Pseudostate _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class QualifierValue
        /// </summary>
        public virtual void QualifierValue(QualifierValue _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class RaiseExceptionAction
        /// </summary>
        public virtual void RaiseExceptionAction(RaiseExceptionAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ReadExtentAction
        /// </summary>
        public virtual void ReadExtentAction(ReadExtentAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ReadIsClassifiedObjectAction
        /// </summary>
        public virtual void ReadIsClassifiedObjectAction(ReadIsClassifiedObjectAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ReadLinkAction
        /// </summary>
        public virtual void ReadLinkAction(ReadLinkAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ReadLinkObjectEndAction
        /// </summary>
        public virtual void ReadLinkObjectEndAction(ReadLinkObjectEndAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ReadLinkObjectEndQualifierAction
        /// </summary>
        public virtual void ReadLinkObjectEndQualifierAction(ReadLinkObjectEndQualifierAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ReadSelfAction
        /// </summary>
        public virtual void ReadSelfAction(ReadSelfAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ReadStructuralFeatureAction
        /// </summary>
        public virtual void ReadStructuralFeatureAction(ReadStructuralFeatureAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ReadVariableAction
        /// </summary>
        public virtual void ReadVariableAction(ReadVariableAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Realization
        /// </summary>
        public virtual void Realization(Realization _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Reception
        /// </summary>
        public virtual void Reception(Reception _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ReclassifyObjectAction
        /// </summary>
        public virtual void ReclassifyObjectAction(ReclassifyObjectAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class RedefinableTemplateSignature
        /// </summary>
        public virtual void RedefinableTemplateSignature(RedefinableTemplateSignature _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ReduceAction
        /// </summary>
        public virtual void ReduceAction(ReduceAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Region
        /// </summary>
        public virtual void Region(Region _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Relationship
        /// </summary>
        public virtual void Relationship(Relationship _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class RemoveStructuralFeatureValueAction
        /// </summary>
        public virtual void RemoveStructuralFeatureValueAction(RemoveStructuralFeatureValueAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class RemoveVariableValueAction
        /// </summary>
        public virtual void RemoveVariableValueAction(RemoveVariableValueAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ReplyAction
        /// </summary>
        public virtual void ReplyAction(ReplyAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class SendObjectAction
        /// </summary>
        public virtual void SendObjectAction(SendObjectAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class SendSignalAction
        /// </summary>
        public virtual void SendSignalAction(SendSignalAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class SequenceNode
        /// </summary>
        public virtual void SequenceNode(SequenceNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Slot
        /// </summary>
        public virtual void Slot(Slot _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class StartClassifierBehaviorAction
        /// </summary>
        public virtual void StartClassifierBehaviorAction(StartClassifierBehaviorAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class StartObjectBehaviorAction
        /// </summary>
        public virtual void StartObjectBehaviorAction(StartObjectBehaviorAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class StateInvariant
        /// </summary>
        public virtual void StateInvariant(StateInvariant _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TemplateableElement
        /// </summary>
        public virtual void TemplateableElement(TemplateableElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Signal
        /// </summary>
        public virtual void Signal(Signal _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class SignalEvent
        /// </summary>
        public virtual void SignalEvent(SignalEvent _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class State
        /// </summary>
        public virtual void State(State _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class StructuredClassifier
        /// </summary>
        public virtual void StructuredClassifier(StructuredClassifier _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class StateMachine
        /// </summary>
        public virtual void StateMachine(StateMachine _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Stereotype
        /// </summary>
        public virtual void Stereotype(Stereotype _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class StringExpression
        /// </summary>
        public virtual void StringExpression(StringExpression _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class StructuralFeatureAction
        /// </summary>
        public virtual void StructuralFeatureAction(StructuralFeatureAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class StructuredActivityNode
        /// </summary>
        public virtual void StructuredActivityNode(StructuredActivityNode _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Substitution
        /// </summary>
        public virtual void Substitution(Substitution _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TemplateBinding
        /// </summary>
        public virtual void TemplateBinding(TemplateBinding _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TemplateParameter
        /// </summary>
        public virtual void TemplateParameter(TemplateParameter _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TemplateParameterSubstitution
        /// </summary>
        public virtual void TemplateParameterSubstitution(TemplateParameterSubstitution _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TemplateSignature
        /// </summary>
        public virtual void TemplateSignature(TemplateSignature _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TestIdentityAction
        /// </summary>
        public virtual void TestIdentityAction(TestIdentityAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TimeConstraint
        /// </summary>
        public virtual void TimeConstraint(TimeConstraint _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TimeEvent
        /// </summary>
        public virtual void TimeEvent(TimeEvent _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TimeExpression
        /// </summary>
        public virtual void TimeExpression(TimeExpression _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TimeInterval
        /// </summary>
        public virtual void TimeInterval(TimeInterval _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TimeObservation
        /// </summary>
        public virtual void TimeObservation(TimeObservation _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Transition
        /// </summary>
        public virtual void Transition(Transition _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Trigger
        /// </summary>
        public virtual void Trigger(Trigger _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Type
        /// </summary>
        public virtual void Type(Type _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class UnmarshallAction
        /// </summary>
        public virtual void UnmarshallAction(UnmarshallAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Usage
        /// </summary>
        public virtual void Usage(Usage _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class UseCase
        /// </summary>
        public virtual void UseCase(UseCase _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ValuePin
        /// </summary>
        public virtual void ValuePin(ValuePin _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ValueSpecification
        /// </summary>
        public virtual void ValueSpecification(ValueSpecification _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ValueSpecificationAction
        /// </summary>
        public virtual void ValueSpecificationAction(ValueSpecificationAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Variable
        /// </summary>
        public virtual void Variable(Variable _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class VariableAction
        /// </summary>
        public virtual void VariableAction(VariableAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Vertex
        /// </summary>
        public virtual void Vertex(Vertex _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class WriteLinkAction
        /// </summary>
        public virtual void WriteLinkAction(WriteLinkAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class WriteStructuralFeatureAction
        /// </summary>
        public virtual void WriteStructuralFeatureAction(WriteStructuralFeatureAction _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class WriteVariableAction
        /// </summary>
        public virtual void WriteVariableAction(WriteVariableAction _this)
        {
        }
    
    
        /// <summary>
        /// Computation of the derived property NamedElement.ClientDependency
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Dependency> NamedElement_ClientDependency(NamedElement _this);
    
        /// <summary>
        /// Computation of the derived property NamedElement.QualifiedName
        /// </summary>
        public abstract string NamedElement_QualifiedName(NamedElement _this);
    
        /// <summary>
        /// Computation of the derived property Action.Context
        /// </summary>
        public abstract Classifier Action_Context(Action _this);
    
        /// <summary>
        /// Computation of the derived property Classifier.General
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Classifier> Classifier_General(Classifier _this);
    
        /// <summary>
        /// Computation of the derived property Classifier.InheritedMember
        /// </summary>
        public abstract global::System.Collections.Generic.IList<NamedElement> Classifier_InheritedMember(Classifier _this);
    
        /// <summary>
        /// Computation of the derived property Class.Extension
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Extension> Class_Extension(Class _this);
    
        /// <summary>
        /// Computation of the derived property Class.SuperClass
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Class> Class_SuperClass(Class _this);
    
        /// <summary>
        /// Computation of the derived property Behavior.Context
        /// </summary>
        public abstract BehavioredClassifier Behavior_Context(Behavior _this);
    
        /// <summary>
        /// Computation of the derived property Association.EndType
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Type> Association_EndType(Association _this);
    
        /// <summary>
        /// Computation of the derived property Component.Provided
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Interface> Component_Provided(Component _this);
    
        /// <summary>
        /// Computation of the derived property Component.Required
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Interface> Component_Required(Component _this);
    
        /// <summary>
        /// Computation of the derived property ConnectableElement.End
        /// </summary>
        public abstract global::System.Collections.Generic.IList<ConnectorEnd> ConnectableElement_End(ConnectableElement _this);
    
        /// <summary>
        /// Computation of the derived property Connector.Kind
        /// </summary>
        public abstract global::MetaDslx.Languages.Uml.Model.ConnectorKind Connector_Kind(Connector _this);
    
        /// <summary>
        /// Computation of the derived property ConnectorEnd.DefiningEnd
        /// </summary>
        public abstract Property ConnectorEnd_DefiningEnd(ConnectorEnd _this);
    
        /// <summary>
        /// Computation of the derived property DeploymentTarget.DeployedElement
        /// </summary>
        public abstract global::System.Collections.Generic.IList<PackageableElement> DeploymentTarget_DeployedElement(DeploymentTarget _this);
    
        /// <summary>
        /// Computation of the derived property ExtensionEnd.Lower
        /// </summary>
        public abstract int ExtensionEnd_Lower(ExtensionEnd _this);
    
        /// <summary>
        /// Computation of the derived property EnumerationLiteral.Classifier
        /// </summary>
        public abstract Enumeration EnumerationLiteral_Classifier(EnumerationLiteral _this);
    
        /// <summary>
        /// Computation of the derived property Extension.IsRequired
        /// </summary>
        public abstract bool Extension_IsRequired(Extension _this);
    
        /// <summary>
        /// Computation of the derived property Extension.Metaclass
        /// </summary>
        public abstract Class Extension_Metaclass(Extension _this);
    
        /// <summary>
        /// Computation of the derived property Message.MessageKind
        /// </summary>
        public abstract global::MetaDslx.Languages.Uml.Model.MessageKind Message_MessageKind(Message _this);
    
        /// <summary>
        /// Computation of the derived property MultiplicityElement.Lower
        /// </summary>
        public abstract int MultiplicityElement_Lower(MultiplicityElement _this);
    
        /// <summary>
        /// Computation of the derived property MultiplicityElement.Upper
        /// </summary>
        public abstract int MultiplicityElement_Upper(MultiplicityElement _this);
    
        /// <summary>
        /// Computation of the derived property Namespace.ImportedMember
        /// </summary>
        public abstract global::System.Collections.Generic.IList<PackageableElement> Namespace_ImportedMember(Namespace _this);
    
        /// <summary>
        /// Computation of the derived property OpaqueExpression.Result
        /// </summary>
        public abstract Parameter OpaqueExpression_Result(OpaqueExpression _this);
    
        /// <summary>
        /// Computation of the derived property Parameter.Default
        /// </summary>
        public abstract string Parameter_Default(Parameter _this);
    
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
        public abstract int Operation_Lower(Operation _this);
    
        /// <summary>
        /// Computation of the derived property Operation.Type
        /// </summary>
        public abstract Type Operation_Type(Operation _this);
    
        /// <summary>
        /// Computation of the derived property Operation.Upper
        /// </summary>
        public abstract int Operation_Upper(Operation _this);
    
        /// <summary>
        /// Computation of the derived property Property.IsComposite
        /// </summary>
        public abstract bool Property_IsComposite(Property _this);
    
        /// <summary>
        /// Computation of the derived property Property.Opposite
        /// </summary>
        public abstract Property Property_Opposite(Property _this);
    
        /// <summary>
        /// Computation of the derived property Port.Provided
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Interface> Port_Provided(Port _this);
    
        /// <summary>
        /// Computation of the derived property Port.Required
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Interface> Port_Required(Port _this);
    
        /// <summary>
        /// Computation of the derived property ProtocolTransition.Referred
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Operation> ProtocolTransition_Referred(ProtocolTransition _this);
    
        /// <summary>
        /// Computation of the derived property RedefinableTemplateSignature.InheritedParameter
        /// </summary>
        public abstract global::System.Collections.Generic.IList<TemplateParameter> RedefinableTemplateSignature_InheritedParameter(RedefinableTemplateSignature _this);
    
        /// <summary>
        /// Computation of the derived property Region.RedefinitionContext
        /// </summary>
        public abstract Classifier Region_RedefinitionContext(Region _this);
    
        /// <summary>
        /// Computation of the derived property State.IsComposite
        /// </summary>
        public abstract bool State_IsComposite(State _this);
    
        /// <summary>
        /// Computation of the derived property State.IsOrthogonal
        /// </summary>
        public abstract bool State_IsOrthogonal(State _this);
    
        /// <summary>
        /// Computation of the derived property State.IsSimple
        /// </summary>
        public abstract bool State_IsSimple(State _this);
    
        /// <summary>
        /// Computation of the derived property State.IsSubmachineState
        /// </summary>
        public abstract bool State_IsSubmachineState(State _this);
    
        /// <summary>
        /// Computation of the derived property StructuredClassifier.Part
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Property> StructuredClassifier_Part(StructuredClassifier _this);
    
        /// <summary>
        /// Computation of the derived property Stereotype.Profile
        /// </summary>
        public abstract Profile Stereotype_Profile(Stereotype _this);
    
        /// <summary>
        /// Computation of the derived property Transition.RedefinitionContext
        /// </summary>
        public abstract Classifier Transition_RedefinitionContext(Transition _this);
    
        /// <summary>
        /// Computation of the derived property Vertex.Incoming
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Transition> Vertex_Incoming(Vertex _this);
    
        /// <summary>
        /// Computation of the derived property Vertex.Outgoing
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Transition> Vertex_Outgoing(Vertex _this);
    
        /// <summary>
        /// Computation of the derived property Vertex.RedefinitionContext
        /// </summary>
        public abstract Classifier Vertex_RedefinitionContext(Vertex _this);
    
    
        /// <summary>
        /// Implementation of the operation Element.AllOwnedElements
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Element> Element_AllOwnedElements(Element _this, global::System.Collections.Generic.IList<Element> result);
    
        /// <summary>
        /// Implementation of the operation Element.MustBeOwned
        /// </summary>
        public abstract bool Element_MustBeOwned(Element _this, bool result);
    
        /// <summary>
        /// Implementation of the operation NamedElement.AllNamespaces
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Namespace> NamedElement_AllNamespaces(NamedElement _this, global::System.Collections.Generic.IList<Namespace> result);
    
        /// <summary>
        /// Implementation of the operation NamedElement.AllOwningPackages
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Package> NamedElement_AllOwningPackages(NamedElement _this, global::System.Collections.Generic.IList<Package> result);
    
        /// <summary>
        /// Implementation of the operation NamedElement.IsDistinguishableFrom
        /// </summary>
        public abstract bool NamedElement_IsDistinguishableFrom(NamedElement _this, bool result, NamedElement n, Namespace ns);
    
        /// <summary>
        /// Implementation of the operation NamedElement.Separator
        /// </summary>
        public abstract string NamedElement_Separator(NamedElement _this, string result);
    
        /// <summary>
        /// Implementation of the operation Action.AllActions
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Action> Action_AllActions(Action _this, global::System.Collections.Generic.IList<Action> result);
    
        /// <summary>
        /// Implementation of the operation Action.AllOwnedNodes
        /// </summary>
        public abstract global::System.Collections.Generic.IList<ActivityNode> Action_AllOwnedNodes(Action _this, global::System.Collections.Generic.IList<ActivityNode> result);
    
        /// <summary>
        /// Implementation of the operation Action.ContainingBehavior
        /// </summary>
        public abstract Behavior Action_ContainingBehavior(Action _this, Behavior result);
    
        /// <summary>
        /// Implementation of the operation Classifier.AllFeatures
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Feature> Classifier_AllFeatures(Classifier _this, global::System.Collections.Generic.IList<Feature> result);
    
        /// <summary>
        /// Implementation of the operation Classifier.AllParents
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Classifier> Classifier_AllParents(Classifier _this, global::System.Collections.Generic.IList<Classifier> result);
    
        /// <summary>
        /// Implementation of the operation Classifier.ConformsTo
        /// </summary>
        public abstract bool Classifier_ConformsTo(Classifier _this, bool result, Type other);
    
        /// <summary>
        /// Implementation of the operation Classifier.HasVisibilityOf
        /// </summary>
        public abstract bool Classifier_HasVisibilityOf(Classifier _this, bool result, NamedElement n);
    
        /// <summary>
        /// Implementation of the operation Classifier.Inherit
        /// </summary>
        public abstract global::System.Collections.Generic.IList<NamedElement> Classifier_Inherit(Classifier _this, global::System.Collections.Generic.IList<NamedElement> result, global::System.Collections.Generic.IList<NamedElement> inhs);
    
        /// <summary>
        /// Implementation of the operation Classifier.InheritableMembers
        /// </summary>
        public abstract global::System.Collections.Generic.IList<NamedElement> Classifier_InheritableMembers(Classifier _this, global::System.Collections.Generic.IList<NamedElement> result, Classifier c);
    
        /// <summary>
        /// Implementation of the operation Classifier.IsTemplate
        /// </summary>
        public abstract bool Classifier_IsTemplate(Classifier _this, bool result);
    
        /// <summary>
        /// Implementation of the operation Classifier.MaySpecializeType
        /// </summary>
        public abstract bool Classifier_MaySpecializeType(Classifier _this, bool result, Classifier c);
    
        /// <summary>
        /// Implementation of the operation Classifier.Parents
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Classifier> Classifier_Parents(Classifier _this, global::System.Collections.Generic.IList<Classifier> result);
    
        /// <summary>
        /// Implementation of the operation Classifier.DirectlyRealizedInterfaces
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Interface> Classifier_DirectlyRealizedInterfaces(Classifier _this, global::System.Collections.Generic.IList<Interface> result);
    
        /// <summary>
        /// Implementation of the operation Classifier.DirectlyUsedInterfaces
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Interface> Classifier_DirectlyUsedInterfaces(Classifier _this, global::System.Collections.Generic.IList<Interface> result);
    
        /// <summary>
        /// Implementation of the operation Classifier.AllRealizedInterfaces
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Interface> Classifier_AllRealizedInterfaces(Classifier _this, global::System.Collections.Generic.IList<Interface> result);
    
        /// <summary>
        /// Implementation of the operation Classifier.AllUsedInterfaces
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Interface> Classifier_AllUsedInterfaces(Classifier _this, global::System.Collections.Generic.IList<Interface> result);
    
        /// <summary>
        /// Implementation of the operation Classifier.IsSubstitutableFor
        /// </summary>
        public abstract bool Classifier_IsSubstitutableFor(Classifier _this, Classifier contract, bool result);
    
        /// <summary>
        /// Implementation of the operation Classifier.AllAttributes
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Property> Classifier_AllAttributes(Classifier _this, global::System.Collections.Generic.IList<Property> result);
    
        /// <summary>
        /// Implementation of the operation Classifier.AllSlottableFeatures
        /// </summary>
        public abstract global::System.Collections.Generic.IList<StructuralFeature> Classifier_AllSlottableFeatures(Classifier _this, global::System.Collections.Generic.IList<StructuralFeature> result);
    
        /// <summary>
        /// Implementation of the operation Behavior.BehavioredClassifier
        /// </summary>
        public abstract BehavioredClassifier Behavior_BehavioredClassifier(Behavior _this, Element from, BehavioredClassifier result);
    
        /// <summary>
        /// Implementation of the operation Behavior.InputParameters
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Parameter> Behavior_InputParameters(Behavior _this, global::System.Collections.Generic.IList<Parameter> result);
    
        /// <summary>
        /// Implementation of the operation Behavior.OutputParameters
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Parameter> Behavior_OutputParameters(Behavior _this, global::System.Collections.Generic.IList<Parameter> result);
    
        /// <summary>
        /// Implementation of the operation ActivityEdge.IsConsistentWith
        /// </summary>
        public abstract bool ActivityEdge_IsConsistentWith(ActivityEdge _this, bool result, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation ActivityNode.ContainingActivity
        /// </summary>
        public abstract Activity ActivityNode_ContainingActivity(ActivityNode _this, Activity result);
    
        /// <summary>
        /// Implementation of the operation ActivityNode.IsConsistentWith
        /// </summary>
        public abstract bool ActivityNode_IsConsistentWith(ActivityNode _this, bool result, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation ActivityGroup.ContainingActivity
        /// </summary>
        public abstract Activity ActivityGroup_ContainingActivity(ActivityGroup _this, Activity result);
    
        /// <summary>
        /// Implementation of the operation BehavioralFeature.IsDistinguishableFrom
        /// </summary>
        public abstract bool BehavioralFeature_IsDistinguishableFrom(BehavioralFeature _this, bool result, NamedElement n, Namespace ns);
    
        /// <summary>
        /// Implementation of the operation BehavioralFeature.InputParameters
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Parameter> BehavioralFeature_InputParameters(BehavioralFeature _this, global::System.Collections.Generic.IList<Parameter> result);
    
        /// <summary>
        /// Implementation of the operation BehavioralFeature.OutputParameters
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Parameter> BehavioralFeature_OutputParameters(BehavioralFeature _this, global::System.Collections.Generic.IList<Parameter> result);
    
        /// <summary>
        /// Implementation of the operation CallAction.InputParameters
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Parameter> CallAction_InputParameters(CallAction _this, global::System.Collections.Generic.IList<Parameter> result);
    
        /// <summary>
        /// Implementation of the operation CallAction.OutputParameters
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Parameter> CallAction_OutputParameters(CallAction _this, global::System.Collections.Generic.IList<Parameter> result);
    
        /// <summary>
        /// Implementation of the operation CallBehaviorAction.OutputParameters
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Parameter> CallBehaviorAction_OutputParameters(CallBehaviorAction _this, global::System.Collections.Generic.IList<Parameter> result);
    
        /// <summary>
        /// Implementation of the operation CallBehaviorAction.InputParameters
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Parameter> CallBehaviorAction_InputParameters(CallBehaviorAction _this, global::System.Collections.Generic.IList<Parameter> result);
    
        /// <summary>
        /// Implementation of the operation CallOperationAction.OutputParameters
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Parameter> CallOperationAction_OutputParameters(CallOperationAction _this, global::System.Collections.Generic.IList<Parameter> result);
    
        /// <summary>
        /// Implementation of the operation CallOperationAction.InputParameters
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Parameter> CallOperationAction_InputParameters(CallOperationAction _this, global::System.Collections.Generic.IList<Parameter> result);
    
        /// <summary>
        /// Implementation of the operation ConditionalNode.AllActions
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Action> ConditionalNode_AllActions(ConditionalNode _this, global::System.Collections.Generic.IList<Action> result);
    
        /// <summary>
        /// Implementation of the operation ConnectionPointReference.IsConsistentWith
        /// </summary>
        public abstract bool ConnectionPointReference_IsConsistentWith(ConnectionPointReference _this, RedefinableElement redefiningElement, bool result);
    
        /// <summary>
        /// Implementation of the operation ElementImport.GetName
        /// </summary>
        public abstract string ElementImport_GetName(ElementImport _this, string result);
    
        /// <summary>
        /// Implementation of the operation ExtensionEnd.LowerBound
        /// </summary>
        public abstract int ExtensionEnd_LowerBound(ExtensionEnd _this, int result);
    
        /// <summary>
        /// Implementation of the operation FinalState.IsConsistentWith
        /// </summary>
        public abstract bool FinalState_IsConsistentWith(FinalState _this, RedefinableElement redefiningElement, bool result);
    
        /// <summary>
        /// Implementation of the operation Gate.IsOutsideCF
        /// </summary>
        public abstract bool Gate_IsOutsideCF(Gate _this, bool result);
    
        /// <summary>
        /// Implementation of the operation Gate.IsInsideCF
        /// </summary>
        public abstract bool Gate_IsInsideCF(Gate _this, bool result);
    
        /// <summary>
        /// Implementation of the operation Gate.IsActual
        /// </summary>
        public abstract bool Gate_IsActual(Gate _this, bool result);
    
        /// <summary>
        /// Implementation of the operation Gate.IsFormal
        /// </summary>
        public abstract bool Gate_IsFormal(Gate _this, bool result);
    
        /// <summary>
        /// Implementation of the operation Gate.GetName
        /// </summary>
        public abstract string Gate_GetName(Gate _this, string result);
    
        /// <summary>
        /// Implementation of the operation Gate.Matches
        /// </summary>
        public abstract bool Gate_Matches(Gate _this, bool result, Gate gateToMatch);
    
        /// <summary>
        /// Implementation of the operation Gate.IsDistinguishableFrom
        /// </summary>
        public abstract bool Gate_IsDistinguishableFrom(Gate _this, bool result, NamedElement n, Namespace ns);
    
        /// <summary>
        /// Implementation of the operation Gate.GetOperand
        /// </summary>
        public abstract InteractionOperand Gate_GetOperand(Gate _this, InteractionOperand result);
    
        /// <summary>
        /// Implementation of the operation ParameterableElement.IsCompatibleWith
        /// </summary>
        public abstract bool ParameterableElement_IsCompatibleWith(ParameterableElement _this, bool result, ParameterableElement p);
    
        /// <summary>
        /// Implementation of the operation ParameterableElement.IsTemplateParameter
        /// </summary>
        public abstract bool ParameterableElement_IsTemplateParameter(ParameterableElement _this, bool result);
    
        /// <summary>
        /// Implementation of the operation Extension.MetaclassEnd
        /// </summary>
        public abstract Property Extension_MetaclassEnd(Extension _this, Property result);
    
        /// <summary>
        /// Implementation of the operation FunctionBehavior.HasAllDataTypeAttributes
        /// </summary>
        public abstract bool FunctionBehavior_HasAllDataTypeAttributes(FunctionBehavior _this, bool result, DataType d);
    
        /// <summary>
        /// Implementation of the operation LinkAction.Association
        /// </summary>
        public abstract Association LinkAction_Association(LinkAction _this, Association result);
    
        /// <summary>
        /// Implementation of the operation LinkEndData.AllPins
        /// </summary>
        public abstract global::System.Collections.Generic.IList<InputPin> LinkEndData_AllPins(LinkEndData _this, global::System.Collections.Generic.IList<InputPin> result);
    
        /// <summary>
        /// Implementation of the operation LinkEndCreationData.AllPins
        /// </summary>
        public abstract global::System.Collections.Generic.IList<InputPin> LinkEndCreationData_AllPins(LinkEndCreationData _this, global::System.Collections.Generic.IList<InputPin> result);
    
        /// <summary>
        /// Implementation of the operation LinkEndDestructionData.AllPins
        /// </summary>
        public abstract global::System.Collections.Generic.IList<InputPin> LinkEndDestructionData_AllPins(LinkEndDestructionData _this, global::System.Collections.Generic.IList<InputPin> result);
    
        /// <summary>
        /// Implementation of the operation LiteralBoolean.BooleanValue
        /// </summary>
        public abstract bool LiteralBoolean_BooleanValue(LiteralBoolean _this, bool result);
    
        /// <summary>
        /// Implementation of the operation LiteralBoolean.IsComputable
        /// </summary>
        public abstract bool LiteralBoolean_IsComputable(LiteralBoolean _this, bool result);
    
        /// <summary>
        /// Implementation of the operation LiteralInteger.IntegerValue
        /// </summary>
        public abstract int LiteralInteger_IntegerValue(LiteralInteger _this, int result);
    
        /// <summary>
        /// Implementation of the operation LiteralInteger.IsComputable
        /// </summary>
        public abstract bool LiteralInteger_IsComputable(LiteralInteger _this, bool result);
    
        /// <summary>
        /// Implementation of the operation LiteralNull.IsComputable
        /// </summary>
        public abstract bool LiteralNull_IsComputable(LiteralNull _this, bool result);
    
        /// <summary>
        /// Implementation of the operation LiteralNull.IsNull
        /// </summary>
        public abstract bool LiteralNull_IsNull(LiteralNull _this, bool result);
    
        /// <summary>
        /// Implementation of the operation LiteralReal.IsComputable
        /// </summary>
        public abstract bool LiteralReal_IsComputable(LiteralReal _this, bool result);
    
        /// <summary>
        /// Implementation of the operation LiteralReal.RealValue
        /// </summary>
        public abstract double LiteralReal_RealValue(LiteralReal _this, double result);
    
        /// <summary>
        /// Implementation of the operation LiteralString.IsComputable
        /// </summary>
        public abstract bool LiteralString_IsComputable(LiteralString _this, bool result);
    
        /// <summary>
        /// Implementation of the operation LiteralString.StringValue
        /// </summary>
        public abstract string LiteralString_StringValue(LiteralString _this, string result);
    
        /// <summary>
        /// Implementation of the operation LiteralUnlimitedNatural.IsComputable
        /// </summary>
        public abstract bool LiteralUnlimitedNatural_IsComputable(LiteralUnlimitedNatural _this, bool result);
    
        /// <summary>
        /// Implementation of the operation LiteralUnlimitedNatural.UnlimitedValue
        /// </summary>
        public abstract int LiteralUnlimitedNatural_UnlimitedValue(LiteralUnlimitedNatural _this, int result);
    
        /// <summary>
        /// Implementation of the operation LoopNode.AllActions
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Action> LoopNode_AllActions(LoopNode _this, global::System.Collections.Generic.IList<Action> result);
    
        /// <summary>
        /// Implementation of the operation LoopNode.SourceNodes
        /// </summary>
        public abstract global::System.Collections.Generic.IList<ActivityNode> LoopNode_SourceNodes(LoopNode _this, global::System.Collections.Generic.IList<ActivityNode> result);
    
        /// <summary>
        /// Implementation of the operation Message.IsDistinguishableFrom
        /// </summary>
        public abstract bool Message_IsDistinguishableFrom(Message _this, bool result, NamedElement n, Namespace ns);
    
        /// <summary>
        /// Implementation of the operation MessageEnd.OppositeEnd
        /// </summary>
        public abstract global::System.Collections.Generic.IList<MessageEnd> MessageEnd_OppositeEnd(MessageEnd _this, global::System.Collections.Generic.IList<MessageEnd> result);
    
        /// <summary>
        /// Implementation of the operation MessageEnd.IsSend
        /// </summary>
        public abstract bool MessageEnd_IsSend(MessageEnd _this, bool result);
    
        /// <summary>
        /// Implementation of the operation MessageEnd.IsReceive
        /// </summary>
        public abstract bool MessageEnd_IsReceive(MessageEnd _this, bool result);
    
        /// <summary>
        /// Implementation of the operation MessageEnd.EnclosingFragment
        /// </summary>
        public abstract global::System.Collections.Generic.IList<InteractionFragment> MessageEnd_EnclosingFragment(MessageEnd _this, global::System.Collections.Generic.IList<InteractionFragment> result);
    
        /// <summary>
        /// Implementation of the operation MultiplicityElement.CompatibleWith
        /// </summary>
        public abstract bool MultiplicityElement_CompatibleWith(MultiplicityElement _this, bool result, MultiplicityElement other);
    
        /// <summary>
        /// Implementation of the operation MultiplicityElement.IncludesMultiplicity
        /// </summary>
        public abstract bool MultiplicityElement_IncludesMultiplicity(MultiplicityElement _this, bool result, MultiplicityElement M);
    
        /// <summary>
        /// Implementation of the operation MultiplicityElement.Is
        /// </summary>
        public abstract bool MultiplicityElement_Is(MultiplicityElement _this, bool result, int lowerbound, int upperbound);
    
        /// <summary>
        /// Implementation of the operation MultiplicityElement.IsMultivalued
        /// </summary>
        public abstract bool MultiplicityElement_IsMultivalued(MultiplicityElement _this, bool result);
    
        /// <summary>
        /// Implementation of the operation MultiplicityElement.LowerBound
        /// </summary>
        public abstract int MultiplicityElement_LowerBound(MultiplicityElement _this, int result);
    
        /// <summary>
        /// Implementation of the operation MultiplicityElement.UpperBound
        /// </summary>
        public abstract int MultiplicityElement_UpperBound(MultiplicityElement _this, int result);
    
        /// <summary>
        /// Implementation of the operation Namespace.ExcludeCollisions
        /// </summary>
        public abstract global::System.Collections.Generic.IList<PackageableElement> Namespace_ExcludeCollisions(Namespace _this, global::System.Collections.Generic.IList<PackageableElement> result, global::System.Collections.Generic.IList<PackageableElement> imps);
    
        /// <summary>
        /// Implementation of the operation Namespace.GetNamesOfMember
        /// </summary>
        public abstract global::System.Collections.Generic.IList<string> Namespace_GetNamesOfMember(Namespace _this, global::System.Collections.Generic.IList<string> result, NamedElement element);
    
        /// <summary>
        /// Implementation of the operation Namespace.ImportMembers
        /// </summary>
        public abstract global::System.Collections.Generic.IList<PackageableElement> Namespace_ImportMembers(Namespace _this, global::System.Collections.Generic.IList<PackageableElement> result, global::System.Collections.Generic.IList<PackageableElement> imps);
    
        /// <summary>
        /// Implementation of the operation Namespace.MembersAreDistinguishable
        /// </summary>
        public abstract bool Namespace_MembersAreDistinguishable(Namespace _this, bool result);
    
        /// <summary>
        /// Implementation of the operation OpaqueExpression.IsIntegral
        /// </summary>
        public abstract bool OpaqueExpression_IsIntegral(OpaqueExpression _this, bool result);
    
        /// <summary>
        /// Implementation of the operation OpaqueExpression.IsNonNegative
        /// </summary>
        public abstract bool OpaqueExpression_IsNonNegative(OpaqueExpression _this, bool result);
    
        /// <summary>
        /// Implementation of the operation OpaqueExpression.IsPositive
        /// </summary>
        public abstract bool OpaqueExpression_IsPositive(OpaqueExpression _this, bool result);
    
        /// <summary>
        /// Implementation of the operation OpaqueExpression.Value
        /// </summary>
        public abstract int OpaqueExpression_Value(OpaqueExpression _this, int result);
    
        /// <summary>
        /// Implementation of the operation Package.AllApplicableStereotypes
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Stereotype> Package_AllApplicableStereotypes(Package _this, global::System.Collections.Generic.IList<Stereotype> result);
    
        /// <summary>
        /// Implementation of the operation Package.ContainingProfile
        /// </summary>
        public abstract Profile Package_ContainingProfile(Package _this, Profile result);
    
        /// <summary>
        /// Implementation of the operation Package.MakesVisible
        /// </summary>
        public abstract bool Package_MakesVisible(Package _this, bool result, NamedElement el);
    
        /// <summary>
        /// Implementation of the operation Package.MustBeOwned
        /// </summary>
        public abstract bool Package_MustBeOwned(Package _this, bool result);
    
        /// <summary>
        /// Implementation of the operation Package.VisibleMembers
        /// </summary>
        public abstract global::System.Collections.Generic.IList<PackageableElement> Package_VisibleMembers(Package _this, global::System.Collections.Generic.IList<PackageableElement> result);
    
        /// <summary>
        /// Implementation of the operation RedefinableElement.IsConsistentWith
        /// </summary>
        public abstract bool RedefinableElement_IsConsistentWith(RedefinableElement _this, bool result, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation RedefinableElement.IsRedefinitionContextValid
        /// </summary>
        public abstract bool RedefinableElement_IsRedefinitionContextValid(RedefinableElement _this, bool result, RedefinableElement redefinedElement);
    
        /// <summary>
        /// Implementation of the operation Operation.IsConsistentWith
        /// </summary>
        public abstract bool Operation_IsConsistentWith(Operation _this, bool result, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation Operation.ReturnResult
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Parameter> Operation_ReturnResult(Operation _this, global::System.Collections.Generic.IList<Parameter> result);
    
        /// <summary>
        /// Implementation of the operation Property.IsAttribute
        /// </summary>
        public abstract bool Property_IsAttribute(Property _this, bool result);
    
        /// <summary>
        /// Implementation of the operation Property.IsCompatibleWith
        /// </summary>
        public abstract bool Property_IsCompatibleWith(Property _this, bool result, ParameterableElement p);
    
        /// <summary>
        /// Implementation of the operation Property.IsConsistentWith
        /// </summary>
        public abstract bool Property_IsConsistentWith(Property _this, bool result, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation Property.IsNavigable
        /// </summary>
        public abstract bool Property_IsNavigable(Property _this, bool result);
    
        /// <summary>
        /// Implementation of the operation Property.SubsettingContext
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Type> Property_SubsettingContext(Property _this, global::System.Collections.Generic.IList<Type> result);
    
        /// <summary>
        /// Implementation of the operation Port.BasicProvided
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Interface> Port_BasicProvided(Port _this, global::System.Collections.Generic.IList<Interface> result);
    
        /// <summary>
        /// Implementation of the operation Port.BasicRequired
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Interface> Port_BasicRequired(Port _this, global::System.Collections.Generic.IList<Interface> result);
    
        /// <summary>
        /// Implementation of the operation Pseudostate.IsConsistentWith
        /// </summary>
        public abstract bool Pseudostate_IsConsistentWith(Pseudostate _this, RedefinableElement redefiningElement, bool result);
    
        /// <summary>
        /// Implementation of the operation ReadLinkAction.OpenEnd
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Property> ReadLinkAction_OpenEnd(ReadLinkAction _this, global::System.Collections.Generic.IList<Property> result);
    
        /// <summary>
        /// Implementation of the operation RedefinableTemplateSignature.IsConsistentWith
        /// </summary>
        public abstract bool RedefinableTemplateSignature_IsConsistentWith(RedefinableTemplateSignature _this, bool result, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation Region.BelongsToPSM
        /// </summary>
        public abstract bool Region_BelongsToPSM(Region _this, bool result);
    
        /// <summary>
        /// Implementation of the operation Region.ContainingStateMachine
        /// </summary>
        public abstract StateMachine Region_ContainingStateMachine(Region _this, StateMachine result);
    
        /// <summary>
        /// Implementation of the operation Region.IsConsistentWith
        /// </summary>
        public abstract bool Region_IsConsistentWith(Region _this, bool result, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation Region.IsRedefinitionContextValid
        /// </summary>
        public abstract bool Region_IsRedefinitionContextValid(Region _this, bool result, RedefinableElement redefinedElement);
    
        /// <summary>
        /// Implementation of the operation StartObjectBehaviorAction.OutputParameters
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Parameter> StartObjectBehaviorAction_OutputParameters(StartObjectBehaviorAction _this, global::System.Collections.Generic.IList<Parameter> result);
    
        /// <summary>
        /// Implementation of the operation StartObjectBehaviorAction.InputParameters
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Parameter> StartObjectBehaviorAction_InputParameters(StartObjectBehaviorAction _this, global::System.Collections.Generic.IList<Parameter> result);
    
        /// <summary>
        /// Implementation of the operation StartObjectBehaviorAction.Behavior
        /// </summary>
        public abstract Behavior StartObjectBehaviorAction_Behavior(StartObjectBehaviorAction _this, Behavior result);
    
        /// <summary>
        /// Implementation of the operation TemplateableElement.IsTemplate
        /// </summary>
        public abstract bool TemplateableElement_IsTemplate(TemplateableElement _this, bool result);
    
        /// <summary>
        /// Implementation of the operation TemplateableElement.ParameterableElements
        /// </summary>
        public abstract global::System.Collections.Generic.IList<ParameterableElement> TemplateableElement_ParameterableElements(TemplateableElement _this, global::System.Collections.Generic.IList<ParameterableElement> result);
    
        /// <summary>
        /// Implementation of the operation State.ContainingStateMachine
        /// </summary>
        public abstract StateMachine State_ContainingStateMachine(State _this, StateMachine result);
    
        /// <summary>
        /// Implementation of the operation State.IsConsistentWith
        /// </summary>
        public abstract bool State_IsConsistentWith(State _this, bool result, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation StructuredClassifier.AllRoles
        /// </summary>
        public abstract global::System.Collections.Generic.IList<ConnectableElement> StructuredClassifier_AllRoles(StructuredClassifier _this, global::System.Collections.Generic.IList<ConnectableElement> result);
    
        /// <summary>
        /// Implementation of the operation StateMachine.LCA
        /// </summary>
        public abstract Region StateMachine_LCA(StateMachine _this, Region result, Vertex s1, Vertex s2);
    
        /// <summary>
        /// Implementation of the operation StateMachine.Ancestor
        /// </summary>
        public abstract bool StateMachine_Ancestor(StateMachine _this, bool result, Vertex s1, Vertex s2);
    
        /// <summary>
        /// Implementation of the operation StateMachine.IsConsistentWith
        /// </summary>
        public abstract bool StateMachine_IsConsistentWith(StateMachine _this, bool result, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation StateMachine.IsRedefinitionContextValid
        /// </summary>
        public abstract bool StateMachine_IsRedefinitionContextValid(StateMachine _this, bool result, RedefinableElement redefinedElement);
    
        /// <summary>
        /// Implementation of the operation StateMachine.LCAState
        /// </summary>
        public abstract State StateMachine_LCAState(StateMachine _this, State result, Vertex v1, Vertex v2);
    
        /// <summary>
        /// Implementation of the operation Stereotype.ContainingProfile
        /// </summary>
        public abstract Profile Stereotype_ContainingProfile(Stereotype _this, Profile result);
    
        /// <summary>
        /// Implementation of the operation StringExpression.StringValue
        /// </summary>
        public abstract string StringExpression_StringValue(StringExpression _this, string result);
    
        /// <summary>
        /// Implementation of the operation StructuredActivityNode.AllActions
        /// </summary>
        public abstract global::System.Collections.Generic.IList<Action> StructuredActivityNode_AllActions(StructuredActivityNode _this, global::System.Collections.Generic.IList<Action> result);
    
        /// <summary>
        /// Implementation of the operation StructuredActivityNode.AllOwnedNodes
        /// </summary>
        public abstract global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode_AllOwnedNodes(StructuredActivityNode _this, global::System.Collections.Generic.IList<ActivityNode> result);
    
        /// <summary>
        /// Implementation of the operation StructuredActivityNode.SourceNodes
        /// </summary>
        public abstract global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode_SourceNodes(StructuredActivityNode _this, global::System.Collections.Generic.IList<ActivityNode> result);
    
        /// <summary>
        /// Implementation of the operation StructuredActivityNode.TargetNodes
        /// </summary>
        public abstract global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode_TargetNodes(StructuredActivityNode _this, global::System.Collections.Generic.IList<ActivityNode> result);
    
        /// <summary>
        /// Implementation of the operation StructuredActivityNode.ContainingActivity
        /// </summary>
        public abstract Activity StructuredActivityNode_ContainingActivity(StructuredActivityNode _this, Activity result);
    
        /// <summary>
        /// Implementation of the operation Transition.ContainingStateMachine
        /// </summary>
        public abstract StateMachine Transition_ContainingStateMachine(Transition _this, StateMachine result);
    
        /// <summary>
        /// Implementation of the operation Transition.IsConsistentWith
        /// </summary>
        public abstract bool Transition_IsConsistentWith(Transition _this, bool result, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation Type.ConformsTo
        /// </summary>
        public abstract bool Type_ConformsTo(Type _this, bool result, Type other);
    
        /// <summary>
        /// Implementation of the operation UseCase.AllIncludedUseCases
        /// </summary>
        public abstract global::System.Collections.Generic.IList<UseCase> UseCase_AllIncludedUseCases(UseCase _this, global::System.Collections.Generic.IList<UseCase> result);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.BooleanValue
        /// </summary>
        public abstract bool ValueSpecification_BooleanValue(ValueSpecification _this, bool result);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.IntegerValue
        /// </summary>
        public abstract int ValueSpecification_IntegerValue(ValueSpecification _this, int result);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.IsCompatibleWith
        /// </summary>
        public abstract bool ValueSpecification_IsCompatibleWith(ValueSpecification _this, bool result, ParameterableElement p);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.IsComputable
        /// </summary>
        public abstract bool ValueSpecification_IsComputable(ValueSpecification _this, bool result);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.IsNull
        /// </summary>
        public abstract bool ValueSpecification_IsNull(ValueSpecification _this, bool result);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.RealValue
        /// </summary>
        public abstract double ValueSpecification_RealValue(ValueSpecification _this, double result);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.StringValue
        /// </summary>
        public abstract string ValueSpecification_StringValue(ValueSpecification _this, string result);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.UnlimitedValue
        /// </summary>
        public abstract int ValueSpecification_UnlimitedValue(ValueSpecification _this, int result);
    
        /// <summary>
        /// Implementation of the operation Variable.IsAccessibleBy
        /// </summary>
        public abstract bool Variable_IsAccessibleBy(Variable _this, bool result, Action a);
    
        /// <summary>
        /// Implementation of the operation Vertex.ContainingStateMachine
        /// </summary>
        public abstract StateMachine Vertex_ContainingStateMachine(Vertex _this, StateMachine result);
    
        /// <summary>
        /// Implementation of the operation Vertex.IsContainedInState
        /// </summary>
        public abstract bool Vertex_IsContainedInState(Vertex _this, bool result, State s);
    
        /// <summary>
        /// Implementation of the operation Vertex.IsContainedInRegion
        /// </summary>
        public abstract bool Vertex_IsContainedInRegion(Vertex _this, bool result, Region r);
    
        /// <summary>
        /// Implementation of the operation Vertex.IsConsistentWith
        /// </summary>
        public abstract bool Vertex_IsConsistentWith(Vertex _this, bool result, RedefinableElement redefiningElement);
    
    }
}
