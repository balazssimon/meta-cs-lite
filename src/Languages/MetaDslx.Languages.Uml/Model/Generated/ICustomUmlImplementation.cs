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
    
        /// <summary>
        /// Constructor for the class Element
        /// </summary>
        void Element(Element _this);
    
        /// <summary>
        /// Constructor for the class NamedElement
        /// </summary>
        void NamedElement(NamedElement _this);
    
        /// <summary>
        /// Constructor for the class Abstraction
        /// </summary>
        void Abstraction(Abstraction _this);
    
        /// <summary>
        /// Constructor for the class Action
        /// </summary>
        void Action(Action _this);
    
        /// <summary>
        /// Constructor for the class AcceptEventAction
        /// </summary>
        void AcceptEventAction(AcceptEventAction _this);
    
        /// <summary>
        /// Constructor for the class AcceptCallAction
        /// </summary>
        void AcceptCallAction(AcceptCallAction _this);
    
        /// <summary>
        /// Constructor for the class ActionExecutionSpecification
        /// </summary>
        void ActionExecutionSpecification(ActionExecutionSpecification _this);
    
        /// <summary>
        /// Constructor for the class ActionInputPin
        /// </summary>
        void ActionInputPin(ActionInputPin _this);
    
        /// <summary>
        /// Constructor for the class Classifier
        /// </summary>
        void Classifier(Classifier _this);
    
        /// <summary>
        /// Constructor for the class BehavioredClassifier
        /// </summary>
        void BehavioredClassifier(BehavioredClassifier _this);
    
        /// <summary>
        /// Constructor for the class Class
        /// </summary>
        void Class(Class _this);
    
        /// <summary>
        /// Constructor for the class Behavior
        /// </summary>
        void Behavior(Behavior _this);
    
        /// <summary>
        /// Constructor for the class Activity
        /// </summary>
        void Activity(Activity _this);
    
        /// <summary>
        /// Constructor for the class ActivityEdge
        /// </summary>
        void ActivityEdge(ActivityEdge _this);
    
        /// <summary>
        /// Constructor for the class ActivityNode
        /// </summary>
        void ActivityNode(ActivityNode _this);
    
        /// <summary>
        /// Constructor for the class ActivityFinalNode
        /// </summary>
        void ActivityFinalNode(ActivityFinalNode _this);
    
        /// <summary>
        /// Constructor for the class ActivityGroup
        /// </summary>
        void ActivityGroup(ActivityGroup _this);
    
        /// <summary>
        /// Constructor for the class ActivityParameterNode
        /// </summary>
        void ActivityParameterNode(ActivityParameterNode _this);
    
        /// <summary>
        /// Constructor for the class ActivityPartition
        /// </summary>
        void ActivityPartition(ActivityPartition _this);
    
        /// <summary>
        /// Constructor for the class Actor
        /// </summary>
        void Actor(Actor _this);
    
        /// <summary>
        /// Constructor for the class AddStructuralFeatureValueAction
        /// </summary>
        void AddStructuralFeatureValueAction(AddStructuralFeatureValueAction _this);
    
        /// <summary>
        /// Constructor for the class AddVariableValueAction
        /// </summary>
        void AddVariableValueAction(AddVariableValueAction _this);
    
        /// <summary>
        /// Constructor for the class AnyReceiveEvent
        /// </summary>
        void AnyReceiveEvent(AnyReceiveEvent _this);
    
        /// <summary>
        /// Constructor for the class Association
        /// </summary>
        void Association(Association _this);
    
        /// <summary>
        /// Constructor for the class AssociationClass
        /// </summary>
        void AssociationClass(AssociationClass _this);
    
        /// <summary>
        /// Constructor for the class BehavioralFeature
        /// </summary>
        void BehavioralFeature(BehavioralFeature _this);
    
        /// <summary>
        /// Constructor for the class BehaviorExecutionSpecification
        /// </summary>
        void BehaviorExecutionSpecification(BehaviorExecutionSpecification _this);
    
        /// <summary>
        /// Constructor for the class BroadcastSignalAction
        /// </summary>
        void BroadcastSignalAction(BroadcastSignalAction _this);
    
        /// <summary>
        /// Constructor for the class CallAction
        /// </summary>
        void CallAction(CallAction _this);
    
        /// <summary>
        /// Constructor for the class CallBehaviorAction
        /// </summary>
        void CallBehaviorAction(CallBehaviorAction _this);
    
        /// <summary>
        /// Constructor for the class CallEvent
        /// </summary>
        void CallEvent(CallEvent _this);
    
        /// <summary>
        /// Constructor for the class CallOperationAction
        /// </summary>
        void CallOperationAction(CallOperationAction _this);
    
        /// <summary>
        /// Constructor for the class CentralBufferNode
        /// </summary>
        void CentralBufferNode(CentralBufferNode _this);
    
        /// <summary>
        /// Constructor for the class ChangeEvent
        /// </summary>
        void ChangeEvent(ChangeEvent _this);
    
        /// <summary>
        /// Constructor for the class ClassifierTemplateParameter
        /// </summary>
        void ClassifierTemplateParameter(ClassifierTemplateParameter _this);
    
        /// <summary>
        /// Constructor for the class Clause
        /// </summary>
        void Clause(Clause _this);
    
        /// <summary>
        /// Constructor for the class ClearAssociationAction
        /// </summary>
        void ClearAssociationAction(ClearAssociationAction _this);
    
        /// <summary>
        /// Constructor for the class ClearStructuralFeatureAction
        /// </summary>
        void ClearStructuralFeatureAction(ClearStructuralFeatureAction _this);
    
        /// <summary>
        /// Constructor for the class ClearVariableAction
        /// </summary>
        void ClearVariableAction(ClearVariableAction _this);
    
        /// <summary>
        /// Constructor for the class Collaboration
        /// </summary>
        void Collaboration(Collaboration _this);
    
        /// <summary>
        /// Constructor for the class CollaborationUse
        /// </summary>
        void CollaborationUse(CollaborationUse _this);
    
        /// <summary>
        /// Constructor for the class CombinedFragment
        /// </summary>
        void CombinedFragment(CombinedFragment _this);
    
        /// <summary>
        /// Constructor for the class Comment
        /// </summary>
        void Comment(Comment _this);
    
        /// <summary>
        /// Constructor for the class CommunicationPath
        /// </summary>
        void CommunicationPath(CommunicationPath _this);
    
        /// <summary>
        /// Constructor for the class Component
        /// </summary>
        void Component(Component _this);
    
        /// <summary>
        /// Constructor for the class ComponentRealization
        /// </summary>
        void ComponentRealization(ComponentRealization _this);
    
        /// <summary>
        /// Constructor for the class ConditionalNode
        /// </summary>
        void ConditionalNode(ConditionalNode _this);
    
        /// <summary>
        /// Constructor for the class ConnectableElement
        /// </summary>
        void ConnectableElement(ConnectableElement _this);
    
        /// <summary>
        /// Constructor for the class ConnectableElementTemplateParameter
        /// </summary>
        void ConnectableElementTemplateParameter(ConnectableElementTemplateParameter _this);
    
        /// <summary>
        /// Constructor for the class ConnectionPointReference
        /// </summary>
        void ConnectionPointReference(ConnectionPointReference _this);
    
        /// <summary>
        /// Constructor for the class Connector
        /// </summary>
        void Connector(Connector _this);
    
        /// <summary>
        /// Constructor for the class ConnectorEnd
        /// </summary>
        void ConnectorEnd(ConnectorEnd _this);
    
        /// <summary>
        /// Constructor for the class ConsiderIgnoreFragment
        /// </summary>
        void ConsiderIgnoreFragment(ConsiderIgnoreFragment _this);
    
        /// <summary>
        /// Constructor for the class Constraint
        /// </summary>
        void Constraint(Constraint _this);
    
        /// <summary>
        /// Constructor for the class Continuation
        /// </summary>
        void Continuation(Continuation _this);
    
        /// <summary>
        /// Constructor for the class ControlFlow
        /// </summary>
        void ControlFlow(ControlFlow _this);
    
        /// <summary>
        /// Constructor for the class ControlNode
        /// </summary>
        void ControlNode(ControlNode _this);
    
        /// <summary>
        /// Constructor for the class CreateLinkAction
        /// </summary>
        void CreateLinkAction(CreateLinkAction _this);
    
        /// <summary>
        /// Constructor for the class CreateLinkObjectAction
        /// </summary>
        void CreateLinkObjectAction(CreateLinkObjectAction _this);
    
        /// <summary>
        /// Constructor for the class CreateObjectAction
        /// </summary>
        void CreateObjectAction(CreateObjectAction _this);
    
        /// <summary>
        /// Constructor for the class DataStoreNode
        /// </summary>
        void DataStoreNode(DataStoreNode _this);
    
        /// <summary>
        /// Constructor for the class DataType
        /// </summary>
        void DataType(DataType _this);
    
        /// <summary>
        /// Constructor for the class DecisionNode
        /// </summary>
        void DecisionNode(DecisionNode _this);
    
        /// <summary>
        /// Constructor for the class Dependency
        /// </summary>
        void Dependency(Dependency _this);
    
        /// <summary>
        /// Constructor for the class DeployedArtifact
        /// </summary>
        void DeployedArtifact(DeployedArtifact _this);
    
        /// <summary>
        /// Constructor for the class DeploymentTarget
        /// </summary>
        void DeploymentTarget(DeploymentTarget _this);
    
        /// <summary>
        /// Constructor for the class DestroyLinkAction
        /// </summary>
        void DestroyLinkAction(DestroyLinkAction _this);
    
        /// <summary>
        /// Constructor for the class DestroyObjectAction
        /// </summary>
        void DestroyObjectAction(DestroyObjectAction _this);
    
        /// <summary>
        /// Constructor for the class DestructionOccurrenceSpecification
        /// </summary>
        void DestructionOccurrenceSpecification(DestructionOccurrenceSpecification _this);
    
        /// <summary>
        /// Constructor for the class DirectedRelationship
        /// </summary>
        void DirectedRelationship(DirectedRelationship _this);
    
        /// <summary>
        /// Constructor for the class ElementImport
        /// </summary>
        void ElementImport(ElementImport _this);
    
        /// <summary>
        /// Constructor for the class ExceptionHandler
        /// </summary>
        void ExceptionHandler(ExceptionHandler _this);
    
        /// <summary>
        /// Constructor for the class ExecutableNode
        /// </summary>
        void ExecutableNode(ExecutableNode _this);
    
        /// <summary>
        /// Constructor for the class ExecutionOccurrenceSpecification
        /// </summary>
        void ExecutionOccurrenceSpecification(ExecutionOccurrenceSpecification _this);
    
        /// <summary>
        /// Constructor for the class ExecutionSpecification
        /// </summary>
        void ExecutionSpecification(ExecutionSpecification _this);
    
        /// <summary>
        /// Constructor for the class ExpansionNode
        /// </summary>
        void ExpansionNode(ExpansionNode _this);
    
        /// <summary>
        /// Constructor for the class ExpansionRegion
        /// </summary>
        void ExpansionRegion(ExpansionRegion _this);
    
        /// <summary>
        /// Constructor for the class Extend
        /// </summary>
        void Extend(Extend _this);
    
        /// <summary>
        /// Constructor for the class ExtensionEnd
        /// </summary>
        void ExtensionEnd(ExtensionEnd _this);
    
        /// <summary>
        /// Constructor for the class ExtensionPoint
        /// </summary>
        void ExtensionPoint(ExtensionPoint _this);
    
        /// <summary>
        /// Constructor for the class Feature
        /// </summary>
        void Feature(Feature _this);
    
        /// <summary>
        /// Constructor for the class FinalNode
        /// </summary>
        void FinalNode(FinalNode _this);
    
        /// <summary>
        /// Constructor for the class FinalState
        /// </summary>
        void FinalState(FinalState _this);
    
        /// <summary>
        /// Constructor for the class FlowFinalNode
        /// </summary>
        void FlowFinalNode(FlowFinalNode _this);
    
        /// <summary>
        /// Constructor for the class ForkNode
        /// </summary>
        void ForkNode(ForkNode _this);
    
        /// <summary>
        /// Constructor for the class Gate
        /// </summary>
        void Gate(Gate _this);
    
        /// <summary>
        /// Constructor for the class Generalization
        /// </summary>
        void Generalization(Generalization _this);
    
        /// <summary>
        /// Constructor for the class GeneralOrdering
        /// </summary>
        void GeneralOrdering(GeneralOrdering _this);
    
        /// <summary>
        /// Constructor for the class Image
        /// </summary>
        void Image(Image _this);
    
        /// <summary>
        /// Constructor for the class Include
        /// </summary>
        void Include(Include _this);
    
        /// <summary>
        /// Constructor for the class InitialNode
        /// </summary>
        void InitialNode(InitialNode _this);
    
        /// <summary>
        /// Constructor for the class InputPin
        /// </summary>
        void InputPin(InputPin _this);
    
        /// <summary>
        /// Constructor for the class ParameterableElement
        /// </summary>
        void ParameterableElement(ParameterableElement _this);
    
        /// <summary>
        /// Constructor for the class PackageableElement
        /// </summary>
        void PackageableElement(PackageableElement _this);
    
        /// <summary>
        /// Constructor for the class Artifact
        /// </summary>
        void Artifact(Artifact _this);
    
        /// <summary>
        /// Constructor for the class Deployment
        /// </summary>
        void Deployment(Deployment _this);
    
        /// <summary>
        /// Constructor for the class DeploymentSpecification
        /// </summary>
        void DeploymentSpecification(DeploymentSpecification _this);
    
        /// <summary>
        /// Constructor for the class Duration
        /// </summary>
        void Duration(Duration _this);
    
        /// <summary>
        /// Constructor for the class DurationConstraint
        /// </summary>
        void DurationConstraint(DurationConstraint _this);
    
        /// <summary>
        /// Constructor for the class DurationInterval
        /// </summary>
        void DurationInterval(DurationInterval _this);
    
        /// <summary>
        /// Constructor for the class DurationObservation
        /// </summary>
        void DurationObservation(DurationObservation _this);
    
        /// <summary>
        /// Constructor for the class EncapsulatedClassifier
        /// </summary>
        void EncapsulatedClassifier(EncapsulatedClassifier _this);
    
        /// <summary>
        /// Constructor for the class Device
        /// </summary>
        void Device(Device _this);
    
        /// <summary>
        /// Constructor for the class Enumeration
        /// </summary>
        void Enumeration(Enumeration _this);
    
        /// <summary>
        /// Constructor for the class EnumerationLiteral
        /// </summary>
        void EnumerationLiteral(EnumerationLiteral _this);
    
        /// <summary>
        /// Constructor for the class Event
        /// </summary>
        void Event(Event _this);
    
        /// <summary>
        /// Constructor for the class ExecutionEnvironment
        /// </summary>
        void ExecutionEnvironment(ExecutionEnvironment _this);
    
        /// <summary>
        /// Constructor for the class Expression
        /// </summary>
        void Expression(Expression _this);
    
        /// <summary>
        /// Constructor for the class Extension
        /// </summary>
        void Extension(Extension _this);
    
        /// <summary>
        /// Constructor for the class FunctionBehavior
        /// </summary>
        void FunctionBehavior(FunctionBehavior _this);
    
        /// <summary>
        /// Constructor for the class GeneralizationSet
        /// </summary>
        void GeneralizationSet(GeneralizationSet _this);
    
        /// <summary>
        /// Constructor for the class InformationFlow
        /// </summary>
        void InformationFlow(InformationFlow _this);
    
        /// <summary>
        /// Constructor for the class InformationItem
        /// </summary>
        void InformationItem(InformationItem _this);
    
        /// <summary>
        /// Constructor for the class InstanceSpecification
        /// </summary>
        void InstanceSpecification(InstanceSpecification _this);
    
        /// <summary>
        /// Constructor for the class TypedElement
        /// </summary>
        void TypedElement(TypedElement _this);
    
        /// <summary>
        /// Constructor for the class InstanceValue
        /// </summary>
        void InstanceValue(InstanceValue _this);
    
        /// <summary>
        /// Constructor for the class Interaction
        /// </summary>
        void Interaction(Interaction _this);
    
        /// <summary>
        /// Constructor for the class InteractionConstraint
        /// </summary>
        void InteractionConstraint(InteractionConstraint _this);
    
        /// <summary>
        /// Constructor for the class InteractionFragment
        /// </summary>
        void InteractionFragment(InteractionFragment _this);
    
        /// <summary>
        /// Constructor for the class InteractionOperand
        /// </summary>
        void InteractionOperand(InteractionOperand _this);
    
        /// <summary>
        /// Constructor for the class InteractionUse
        /// </summary>
        void InteractionUse(InteractionUse _this);
    
        /// <summary>
        /// Constructor for the class Interface
        /// </summary>
        void Interface(Interface _this);
    
        /// <summary>
        /// Constructor for the class InterfaceRealization
        /// </summary>
        void InterfaceRealization(InterfaceRealization _this);
    
        /// <summary>
        /// Constructor for the class InterruptibleActivityRegion
        /// </summary>
        void InterruptibleActivityRegion(InterruptibleActivityRegion _this);
    
        /// <summary>
        /// Constructor for the class Interval
        /// </summary>
        void Interval(Interval _this);
    
        /// <summary>
        /// Constructor for the class IntervalConstraint
        /// </summary>
        void IntervalConstraint(IntervalConstraint _this);
    
        /// <summary>
        /// Constructor for the class InvocationAction
        /// </summary>
        void InvocationAction(InvocationAction _this);
    
        /// <summary>
        /// Constructor for the class JoinNode
        /// </summary>
        void JoinNode(JoinNode _this);
    
        /// <summary>
        /// Constructor for the class Lifeline
        /// </summary>
        void Lifeline(Lifeline _this);
    
        /// <summary>
        /// Constructor for the class LinkAction
        /// </summary>
        void LinkAction(LinkAction _this);
    
        /// <summary>
        /// Constructor for the class LinkEndData
        /// </summary>
        void LinkEndData(LinkEndData _this);
    
        /// <summary>
        /// Constructor for the class LinkEndCreationData
        /// </summary>
        void LinkEndCreationData(LinkEndCreationData _this);
    
        /// <summary>
        /// Constructor for the class LinkEndDestructionData
        /// </summary>
        void LinkEndDestructionData(LinkEndDestructionData _this);
    
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
        /// Constructor for the class LoopNode
        /// </summary>
        void LoopNode(LoopNode _this);
    
        /// <summary>
        /// Constructor for the class Manifestation
        /// </summary>
        void Manifestation(Manifestation _this);
    
        /// <summary>
        /// Constructor for the class MergeNode
        /// </summary>
        void MergeNode(MergeNode _this);
    
        /// <summary>
        /// Constructor for the class Message
        /// </summary>
        void Message(Message _this);
    
        /// <summary>
        /// Constructor for the class MessageEnd
        /// </summary>
        void MessageEnd(MessageEnd _this);
    
        /// <summary>
        /// Constructor for the class MessageEvent
        /// </summary>
        void MessageEvent(MessageEvent _this);
    
        /// <summary>
        /// Constructor for the class Model
        /// </summary>
        void Model(Model _this);
    
        /// <summary>
        /// Constructor for the class MultiplicityElement
        /// </summary>
        void MultiplicityElement(MultiplicityElement _this);
    
        /// <summary>
        /// Constructor for the class Namespace
        /// </summary>
        void Namespace(Namespace _this);
    
        /// <summary>
        /// Constructor for the class Node
        /// </summary>
        void Node(Node _this);
    
        /// <summary>
        /// Constructor for the class ObjectFlow
        /// </summary>
        void ObjectFlow(ObjectFlow _this);
    
        /// <summary>
        /// Constructor for the class ObjectNode
        /// </summary>
        void ObjectNode(ObjectNode _this);
    
        /// <summary>
        /// Constructor for the class Observation
        /// </summary>
        void Observation(Observation _this);
    
        /// <summary>
        /// Constructor for the class OccurrenceSpecification
        /// </summary>
        void OccurrenceSpecification(OccurrenceSpecification _this);
    
        /// <summary>
        /// Constructor for the class MessageOccurrenceSpecification
        /// </summary>
        void MessageOccurrenceSpecification(MessageOccurrenceSpecification _this);
    
        /// <summary>
        /// Constructor for the class OpaqueExpression
        /// </summary>
        void OpaqueExpression(OpaqueExpression _this);
    
        /// <summary>
        /// Constructor for the class OperationTemplateParameter
        /// </summary>
        void OperationTemplateParameter(OperationTemplateParameter _this);
    
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
        /// Constructor for the class ParameterSet
        /// </summary>
        void ParameterSet(ParameterSet _this);
    
        /// <summary>
        /// Constructor for the class PartDecomposition
        /// </summary>
        void PartDecomposition(PartDecomposition _this);
    
        /// <summary>
        /// Constructor for the class RedefinableElement
        /// </summary>
        void RedefinableElement(RedefinableElement _this);
    
        /// <summary>
        /// Constructor for the class OpaqueAction
        /// </summary>
        void OpaqueAction(OpaqueAction _this);
    
        /// <summary>
        /// Constructor for the class OpaqueBehavior
        /// </summary>
        void OpaqueBehavior(OpaqueBehavior _this);
    
        /// <summary>
        /// Constructor for the class Operation
        /// </summary>
        void Operation(Operation _this);
    
        /// <summary>
        /// Constructor for the class Pin
        /// </summary>
        void Pin(Pin _this);
    
        /// <summary>
        /// Constructor for the class OutputPin
        /// </summary>
        void OutputPin(OutputPin _this);
    
        /// <summary>
        /// Constructor for the class StructuralFeature
        /// </summary>
        void StructuralFeature(StructuralFeature _this);
    
        /// <summary>
        /// Constructor for the class Property
        /// </summary>
        void Property(Property _this);
    
        /// <summary>
        /// Constructor for the class Port
        /// </summary>
        void Port(Port _this);
    
        /// <summary>
        /// Constructor for the class PrimitiveType
        /// </summary>
        void PrimitiveType(PrimitiveType _this);
    
        /// <summary>
        /// Constructor for the class Profile
        /// </summary>
        void Profile(Profile _this);
    
        /// <summary>
        /// Constructor for the class ProfileApplication
        /// </summary>
        void ProfileApplication(ProfileApplication _this);
    
        /// <summary>
        /// Constructor for the class ProtocolConformance
        /// </summary>
        void ProtocolConformance(ProtocolConformance _this);
    
        /// <summary>
        /// Constructor for the class ProtocolStateMachine
        /// </summary>
        void ProtocolStateMachine(ProtocolStateMachine _this);
    
        /// <summary>
        /// Constructor for the class ProtocolTransition
        /// </summary>
        void ProtocolTransition(ProtocolTransition _this);
    
        /// <summary>
        /// Constructor for the class Pseudostate
        /// </summary>
        void Pseudostate(Pseudostate _this);
    
        /// <summary>
        /// Constructor for the class QualifierValue
        /// </summary>
        void QualifierValue(QualifierValue _this);
    
        /// <summary>
        /// Constructor for the class RaiseExceptionAction
        /// </summary>
        void RaiseExceptionAction(RaiseExceptionAction _this);
    
        /// <summary>
        /// Constructor for the class ReadExtentAction
        /// </summary>
        void ReadExtentAction(ReadExtentAction _this);
    
        /// <summary>
        /// Constructor for the class ReadIsClassifiedObjectAction
        /// </summary>
        void ReadIsClassifiedObjectAction(ReadIsClassifiedObjectAction _this);
    
        /// <summary>
        /// Constructor for the class ReadLinkAction
        /// </summary>
        void ReadLinkAction(ReadLinkAction _this);
    
        /// <summary>
        /// Constructor for the class ReadLinkObjectEndAction
        /// </summary>
        void ReadLinkObjectEndAction(ReadLinkObjectEndAction _this);
    
        /// <summary>
        /// Constructor for the class ReadLinkObjectEndQualifierAction
        /// </summary>
        void ReadLinkObjectEndQualifierAction(ReadLinkObjectEndQualifierAction _this);
    
        /// <summary>
        /// Constructor for the class ReadSelfAction
        /// </summary>
        void ReadSelfAction(ReadSelfAction _this);
    
        /// <summary>
        /// Constructor for the class ReadStructuralFeatureAction
        /// </summary>
        void ReadStructuralFeatureAction(ReadStructuralFeatureAction _this);
    
        /// <summary>
        /// Constructor for the class ReadVariableAction
        /// </summary>
        void ReadVariableAction(ReadVariableAction _this);
    
        /// <summary>
        /// Constructor for the class Realization
        /// </summary>
        void Realization(Realization _this);
    
        /// <summary>
        /// Constructor for the class Reception
        /// </summary>
        void Reception(Reception _this);
    
        /// <summary>
        /// Constructor for the class ReclassifyObjectAction
        /// </summary>
        void ReclassifyObjectAction(ReclassifyObjectAction _this);
    
        /// <summary>
        /// Constructor for the class RedefinableTemplateSignature
        /// </summary>
        void RedefinableTemplateSignature(RedefinableTemplateSignature _this);
    
        /// <summary>
        /// Constructor for the class ReduceAction
        /// </summary>
        void ReduceAction(ReduceAction _this);
    
        /// <summary>
        /// Constructor for the class Region
        /// </summary>
        void Region(Region _this);
    
        /// <summary>
        /// Constructor for the class Relationship
        /// </summary>
        void Relationship(Relationship _this);
    
        /// <summary>
        /// Constructor for the class RemoveStructuralFeatureValueAction
        /// </summary>
        void RemoveStructuralFeatureValueAction(RemoveStructuralFeatureValueAction _this);
    
        /// <summary>
        /// Constructor for the class RemoveVariableValueAction
        /// </summary>
        void RemoveVariableValueAction(RemoveVariableValueAction _this);
    
        /// <summary>
        /// Constructor for the class ReplyAction
        /// </summary>
        void ReplyAction(ReplyAction _this);
    
        /// <summary>
        /// Constructor for the class SendObjectAction
        /// </summary>
        void SendObjectAction(SendObjectAction _this);
    
        /// <summary>
        /// Constructor for the class SendSignalAction
        /// </summary>
        void SendSignalAction(SendSignalAction _this);
    
        /// <summary>
        /// Constructor for the class SequenceNode
        /// </summary>
        void SequenceNode(SequenceNode _this);
    
        /// <summary>
        /// Constructor for the class Slot
        /// </summary>
        void Slot(Slot _this);
    
        /// <summary>
        /// Constructor for the class StartClassifierBehaviorAction
        /// </summary>
        void StartClassifierBehaviorAction(StartClassifierBehaviorAction _this);
    
        /// <summary>
        /// Constructor for the class StartObjectBehaviorAction
        /// </summary>
        void StartObjectBehaviorAction(StartObjectBehaviorAction _this);
    
        /// <summary>
        /// Constructor for the class StateInvariant
        /// </summary>
        void StateInvariant(StateInvariant _this);
    
        /// <summary>
        /// Constructor for the class TemplateableElement
        /// </summary>
        void TemplateableElement(TemplateableElement _this);
    
        /// <summary>
        /// Constructor for the class Signal
        /// </summary>
        void Signal(Signal _this);
    
        /// <summary>
        /// Constructor for the class SignalEvent
        /// </summary>
        void SignalEvent(SignalEvent _this);
    
        /// <summary>
        /// Constructor for the class State
        /// </summary>
        void State(State _this);
    
        /// <summary>
        /// Constructor for the class StructuredClassifier
        /// </summary>
        void StructuredClassifier(StructuredClassifier _this);
    
        /// <summary>
        /// Constructor for the class StateMachine
        /// </summary>
        void StateMachine(StateMachine _this);
    
        /// <summary>
        /// Constructor for the class Stereotype
        /// </summary>
        void Stereotype(Stereotype _this);
    
        /// <summary>
        /// Constructor for the class StringExpression
        /// </summary>
        void StringExpression(StringExpression _this);
    
        /// <summary>
        /// Constructor for the class StructuralFeatureAction
        /// </summary>
        void StructuralFeatureAction(StructuralFeatureAction _this);
    
        /// <summary>
        /// Constructor for the class StructuredActivityNode
        /// </summary>
        void StructuredActivityNode(StructuredActivityNode _this);
    
        /// <summary>
        /// Constructor for the class Substitution
        /// </summary>
        void Substitution(Substitution _this);
    
        /// <summary>
        /// Constructor for the class TemplateBinding
        /// </summary>
        void TemplateBinding(TemplateBinding _this);
    
        /// <summary>
        /// Constructor for the class TemplateParameter
        /// </summary>
        void TemplateParameter(TemplateParameter _this);
    
        /// <summary>
        /// Constructor for the class TemplateParameterSubstitution
        /// </summary>
        void TemplateParameterSubstitution(TemplateParameterSubstitution _this);
    
        /// <summary>
        /// Constructor for the class TemplateSignature
        /// </summary>
        void TemplateSignature(TemplateSignature _this);
    
        /// <summary>
        /// Constructor for the class TestIdentityAction
        /// </summary>
        void TestIdentityAction(TestIdentityAction _this);
    
        /// <summary>
        /// Constructor for the class TimeConstraint
        /// </summary>
        void TimeConstraint(TimeConstraint _this);
    
        /// <summary>
        /// Constructor for the class TimeEvent
        /// </summary>
        void TimeEvent(TimeEvent _this);
    
        /// <summary>
        /// Constructor for the class TimeExpression
        /// </summary>
        void TimeExpression(TimeExpression _this);
    
        /// <summary>
        /// Constructor for the class TimeInterval
        /// </summary>
        void TimeInterval(TimeInterval _this);
    
        /// <summary>
        /// Constructor for the class TimeObservation
        /// </summary>
        void TimeObservation(TimeObservation _this);
    
        /// <summary>
        /// Constructor for the class Transition
        /// </summary>
        void Transition(Transition _this);
    
        /// <summary>
        /// Constructor for the class Trigger
        /// </summary>
        void Trigger(Trigger _this);
    
        /// <summary>
        /// Constructor for the class Type
        /// </summary>
        void Type(Type _this);
    
        /// <summary>
        /// Constructor for the class UnmarshallAction
        /// </summary>
        void UnmarshallAction(UnmarshallAction _this);
    
        /// <summary>
        /// Constructor for the class Usage
        /// </summary>
        void Usage(Usage _this);
    
        /// <summary>
        /// Constructor for the class UseCase
        /// </summary>
        void UseCase(UseCase _this);
    
        /// <summary>
        /// Constructor for the class ValuePin
        /// </summary>
        void ValuePin(ValuePin _this);
    
        /// <summary>
        /// Constructor for the class ValueSpecification
        /// </summary>
        void ValueSpecification(ValueSpecification _this);
    
        /// <summary>
        /// Constructor for the class ValueSpecificationAction
        /// </summary>
        void ValueSpecificationAction(ValueSpecificationAction _this);
    
        /// <summary>
        /// Constructor for the class Variable
        /// </summary>
        void Variable(Variable _this);
    
        /// <summary>
        /// Constructor for the class VariableAction
        /// </summary>
        void VariableAction(VariableAction _this);
    
        /// <summary>
        /// Constructor for the class Vertex
        /// </summary>
        void Vertex(Vertex _this);
    
        /// <summary>
        /// Constructor for the class WriteLinkAction
        /// </summary>
        void WriteLinkAction(WriteLinkAction _this);
    
        /// <summary>
        /// Constructor for the class WriteStructuralFeatureAction
        /// </summary>
        void WriteStructuralFeatureAction(WriteStructuralFeatureAction _this);
    
        /// <summary>
        /// Constructor for the class WriteVariableAction
        /// </summary>
        void WriteVariableAction(WriteVariableAction _this);
    
    
        /// <summary>
        /// Computation of the derived property NamedElement.ClientDependency
        /// </summary>
        global::System.Collections.Generic.IList<Dependency> NamedElement_ClientDependency(NamedElement _this);
    
        /// <summary>
        /// Computation of the derived property NamedElement.QualifiedName
        /// </summary>
        string NamedElement_QualifiedName(NamedElement _this);
    
        /// <summary>
        /// Computation of the derived property Action.Context
        /// </summary>
        Classifier Action_Context(Action _this);
    
        /// <summary>
        /// Computation of the derived property Classifier.General
        /// </summary>
        global::System.Collections.Generic.IList<Classifier> Classifier_General(Classifier _this);
    
        /// <summary>
        /// Computation of the derived property Classifier.InheritedMember
        /// </summary>
        global::System.Collections.Generic.IList<NamedElement> Classifier_InheritedMember(Classifier _this);
    
        /// <summary>
        /// Computation of the derived property Class.Extension
        /// </summary>
        global::System.Collections.Generic.IList<Extension> Class_Extension(Class _this);
    
        /// <summary>
        /// Computation of the derived property Class.SuperClass
        /// </summary>
        global::System.Collections.Generic.IList<Class> Class_SuperClass(Class _this);
    
        /// <summary>
        /// Computation of the derived property Behavior.Context
        /// </summary>
        BehavioredClassifier Behavior_Context(Behavior _this);
    
        /// <summary>
        /// Computation of the derived property Association.EndType
        /// </summary>
        global::System.Collections.Generic.IList<Type> Association_EndType(Association _this);
    
        /// <summary>
        /// Computation of the derived property Component.Provided
        /// </summary>
        global::System.Collections.Generic.IList<Interface> Component_Provided(Component _this);
    
        /// <summary>
        /// Computation of the derived property Component.Required
        /// </summary>
        global::System.Collections.Generic.IList<Interface> Component_Required(Component _this);
    
        /// <summary>
        /// Computation of the derived property ConnectableElement.End
        /// </summary>
        global::System.Collections.Generic.IList<ConnectorEnd> ConnectableElement_End(ConnectableElement _this);
    
        /// <summary>
        /// Computation of the derived property Connector.Kind
        /// </summary>
        global::MetaDslx.Languages.Uml.Model.ConnectorKind Connector_Kind(Connector _this);
    
        /// <summary>
        /// Computation of the derived property ConnectorEnd.DefiningEnd
        /// </summary>
        Property ConnectorEnd_DefiningEnd(ConnectorEnd _this);
    
        /// <summary>
        /// Computation of the derived property DeploymentTarget.DeployedElement
        /// </summary>
        global::System.Collections.Generic.IList<PackageableElement> DeploymentTarget_DeployedElement(DeploymentTarget _this);
    
        /// <summary>
        /// Computation of the derived property ExtensionEnd.Lower
        /// </summary>
        int ExtensionEnd_Lower(ExtensionEnd _this);
    
        /// <summary>
        /// Computation of the derived property EnumerationLiteral.Classifier
        /// </summary>
        Enumeration EnumerationLiteral_Classifier(EnumerationLiteral _this);
    
        /// <summary>
        /// Computation of the derived property Extension.IsRequired
        /// </summary>
        bool Extension_IsRequired(Extension _this);
    
        /// <summary>
        /// Computation of the derived property Extension.Metaclass
        /// </summary>
        Class Extension_Metaclass(Extension _this);
    
        /// <summary>
        /// Computation of the derived property MultiplicityElement.Lower
        /// </summary>
        int MultiplicityElement_Lower(MultiplicityElement _this);
    
        /// <summary>
        /// Computation of the derived property MultiplicityElement.Upper
        /// </summary>
        int MultiplicityElement_Upper(MultiplicityElement _this);
    
        /// <summary>
        /// Computation of the derived property Namespace.ImportedMember
        /// </summary>
        global::System.Collections.Generic.IList<PackageableElement> Namespace_ImportedMember(Namespace _this);
    
        /// <summary>
        /// Computation of the derived property OpaqueExpression.Result
        /// </summary>
        Parameter OpaqueExpression_Result(OpaqueExpression _this);
    
        /// <summary>
        /// Computation of the derived property Parameter.Default
        /// </summary>
        string Parameter_Default(Parameter _this);
    
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
        int Operation_Lower(Operation _this);
    
        /// <summary>
        /// Computation of the derived property Operation.Type
        /// </summary>
        Type Operation_Type(Operation _this);
    
        /// <summary>
        /// Computation of the derived property Operation.Upper
        /// </summary>
        int Operation_Upper(Operation _this);
    
        /// <summary>
        /// Computation of the derived property Property.IsComposite
        /// </summary>
        bool Property_IsComposite(Property _this);
    
        /// <summary>
        /// Computation of the derived property Property.Opposite
        /// </summary>
        Property Property_Opposite(Property _this);
    
        /// <summary>
        /// Computation of the derived property Port.Provided
        /// </summary>
        global::System.Collections.Generic.IList<Interface> Port_Provided(Port _this);
    
        /// <summary>
        /// Computation of the derived property Port.Required
        /// </summary>
        global::System.Collections.Generic.IList<Interface> Port_Required(Port _this);
    
        /// <summary>
        /// Computation of the derived property ProtocolTransition.Referred
        /// </summary>
        global::System.Collections.Generic.IList<Operation> ProtocolTransition_Referred(ProtocolTransition _this);
    
        /// <summary>
        /// Computation of the derived property RedefinableTemplateSignature.InheritedParameter
        /// </summary>
        global::System.Collections.Generic.IList<TemplateParameter> RedefinableTemplateSignature_InheritedParameter(RedefinableTemplateSignature _this);
    
        /// <summary>
        /// Computation of the derived property Region.RedefinitionContext
        /// </summary>
        Classifier Region_RedefinitionContext(Region _this);
    
        /// <summary>
        /// Computation of the derived property State.IsComposite
        /// </summary>
        bool State_IsComposite(State _this);
    
        /// <summary>
        /// Computation of the derived property State.IsOrthogonal
        /// </summary>
        bool State_IsOrthogonal(State _this);
    
        /// <summary>
        /// Computation of the derived property State.IsSimple
        /// </summary>
        bool State_IsSimple(State _this);
    
        /// <summary>
        /// Computation of the derived property State.IsSubmachineState
        /// </summary>
        bool State_IsSubmachineState(State _this);
    
        /// <summary>
        /// Computation of the derived property StructuredClassifier.Part
        /// </summary>
        global::System.Collections.Generic.IList<Property> StructuredClassifier_Part(StructuredClassifier _this);
    
        /// <summary>
        /// Computation of the derived property Stereotype.Profile
        /// </summary>
        Profile Stereotype_Profile(Stereotype _this);
    
        /// <summary>
        /// Computation of the derived property Transition.RedefinitionContext
        /// </summary>
        Classifier Transition_RedefinitionContext(Transition _this);
    
        /// <summary>
        /// Computation of the derived property Vertex.Incoming
        /// </summary>
        global::System.Collections.Generic.IList<Transition> Vertex_Incoming(Vertex _this);
    
        /// <summary>
        /// Computation of the derived property Vertex.Outgoing
        /// </summary>
        global::System.Collections.Generic.IList<Transition> Vertex_Outgoing(Vertex _this);
    
        /// <summary>
        /// Computation of the derived property Vertex.RedefinitionContext
        /// </summary>
        Classifier Vertex_RedefinitionContext(Vertex _this);
    
    
        /// <summary>
        /// Implementation of the operation Element.AllOwnedElements
        /// </summary>
        global::System.Collections.Generic.IList<Element> Element_AllOwnedElements(Element _this);
    
        /// <summary>
        /// Implementation of the operation Element.MustBeOwned
        /// </summary>
        bool Element_MustBeOwned(Element _this);
    
        /// <summary>
        /// Implementation of the operation NamedElement.AllNamespaces
        /// </summary>
        global::System.Collections.Generic.IList<Namespace> NamedElement_AllNamespaces(NamedElement _this);
    
        /// <summary>
        /// Implementation of the operation NamedElement.AllOwningPackages
        /// </summary>
        global::System.Collections.Generic.IList<Package> NamedElement_AllOwningPackages(NamedElement _this);
    
        /// <summary>
        /// Implementation of the operation NamedElement.IsDistinguishableFrom
        /// </summary>
        bool NamedElement_IsDistinguishableFrom(NamedElement _this, NamedElement n, Namespace ns);
    
        /// <summary>
        /// Implementation of the operation NamedElement.Separator
        /// </summary>
        string NamedElement_Separator(NamedElement _this);
    
        /// <summary>
        /// Implementation of the operation Action.AllActions
        /// </summary>
        global::System.Collections.Generic.IList<Action> Action_AllActions(Action _this);
    
        /// <summary>
        /// Implementation of the operation Action.AllOwnedNodes
        /// </summary>
        global::System.Collections.Generic.IList<ActivityNode> Action_AllOwnedNodes(Action _this);
    
        /// <summary>
        /// Implementation of the operation Action.ContainingBehavior
        /// </summary>
        Behavior Action_ContainingBehavior(Action _this);
    
        /// <summary>
        /// Implementation of the operation Classifier.AllFeatures
        /// </summary>
        global::System.Collections.Generic.IList<Feature> Classifier_AllFeatures(Classifier _this);
    
        /// <summary>
        /// Implementation of the operation Classifier.AllParents
        /// </summary>
        global::System.Collections.Generic.IList<Classifier> Classifier_AllParents(Classifier _this);
    
        /// <summary>
        /// Implementation of the operation Classifier.ConformsTo
        /// </summary>
        bool Classifier_ConformsTo(Classifier _this, Type other);
    
        /// <summary>
        /// Implementation of the operation Classifier.HasVisibilityOf
        /// </summary>
        bool Classifier_HasVisibilityOf(Classifier _this, NamedElement n);
    
        /// <summary>
        /// Implementation of the operation Classifier.Inherit
        /// </summary>
        global::System.Collections.Generic.IList<NamedElement> Classifier_Inherit(Classifier _this, global::System.Collections.Generic.IList<NamedElement> inhs);
    
        /// <summary>
        /// Implementation of the operation Classifier.InheritableMembers
        /// </summary>
        global::System.Collections.Generic.IList<NamedElement> Classifier_InheritableMembers(Classifier _this, Classifier c);
    
        /// <summary>
        /// Implementation of the operation Classifier.IsTemplate
        /// </summary>
        bool Classifier_IsTemplate(Classifier _this);
    
        /// <summary>
        /// Implementation of the operation Classifier.MaySpecializeType
        /// </summary>
        bool Classifier_MaySpecializeType(Classifier _this, Classifier c);
    
        /// <summary>
        /// Implementation of the operation Classifier.Parents
        /// </summary>
        global::System.Collections.Generic.IList<Classifier> Classifier_Parents(Classifier _this);
    
        /// <summary>
        /// Implementation of the operation Classifier.DirectlyRealizedInterfaces
        /// </summary>
        global::System.Collections.Generic.IList<Interface> Classifier_DirectlyRealizedInterfaces(Classifier _this);
    
        /// <summary>
        /// Implementation of the operation Classifier.DirectlyUsedInterfaces
        /// </summary>
        global::System.Collections.Generic.IList<Interface> Classifier_DirectlyUsedInterfaces(Classifier _this);
    
        /// <summary>
        /// Implementation of the operation Classifier.AllRealizedInterfaces
        /// </summary>
        global::System.Collections.Generic.IList<Interface> Classifier_AllRealizedInterfaces(Classifier _this);
    
        /// <summary>
        /// Implementation of the operation Classifier.AllUsedInterfaces
        /// </summary>
        global::System.Collections.Generic.IList<Interface> Classifier_AllUsedInterfaces(Classifier _this);
    
        /// <summary>
        /// Implementation of the operation Classifier.IsSubstitutableFor
        /// </summary>
        bool Classifier_IsSubstitutableFor(Classifier _this, Classifier contract);
    
        /// <summary>
        /// Implementation of the operation Classifier.AllAttributes
        /// </summary>
        global::System.Collections.Generic.IList<Property> Classifier_AllAttributes(Classifier _this);
    
        /// <summary>
        /// Implementation of the operation Classifier.AllSlottableFeatures
        /// </summary>
        global::System.Collections.Generic.IList<StructuralFeature> Classifier_AllSlottableFeatures(Classifier _this);
    
        /// <summary>
        /// Implementation of the operation Behavior.BehavioredClassifier
        /// </summary>
        BehavioredClassifier Behavior_BehavioredClassifier(Behavior _this, Element from);
    
        /// <summary>
        /// Implementation of the operation Behavior.InputParameters
        /// </summary>
        global::System.Collections.Generic.IList<Parameter> Behavior_InputParameters(Behavior _this);
    
        /// <summary>
        /// Implementation of the operation Behavior.OutputParameters
        /// </summary>
        global::System.Collections.Generic.IList<Parameter> Behavior_OutputParameters(Behavior _this);
    
        /// <summary>
        /// Implementation of the operation ActivityEdge.IsConsistentWith
        /// </summary>
        bool ActivityEdge_IsConsistentWith(ActivityEdge _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation ActivityNode.ContainingActivity
        /// </summary>
        Activity ActivityNode_ContainingActivity(ActivityNode _this);
    
        /// <summary>
        /// Implementation of the operation ActivityNode.IsConsistentWith
        /// </summary>
        bool ActivityNode_IsConsistentWith(ActivityNode _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation ActivityGroup.ContainingActivity
        /// </summary>
        Activity ActivityGroup_ContainingActivity(ActivityGroup _this);
    
        /// <summary>
        /// Implementation of the operation BehavioralFeature.IsDistinguishableFrom
        /// </summary>
        bool BehavioralFeature_IsDistinguishableFrom(BehavioralFeature _this, NamedElement n, Namespace ns);
    
        /// <summary>
        /// Implementation of the operation BehavioralFeature.InputParameters
        /// </summary>
        global::System.Collections.Generic.IList<Parameter> BehavioralFeature_InputParameters(BehavioralFeature _this);
    
        /// <summary>
        /// Implementation of the operation BehavioralFeature.OutputParameters
        /// </summary>
        global::System.Collections.Generic.IList<Parameter> BehavioralFeature_OutputParameters(BehavioralFeature _this);
    
        /// <summary>
        /// Implementation of the operation CallAction.InputParameters
        /// </summary>
        global::System.Collections.Generic.IList<Parameter> CallAction_InputParameters(CallAction _this);
    
        /// <summary>
        /// Implementation of the operation CallAction.OutputParameters
        /// </summary>
        global::System.Collections.Generic.IList<Parameter> CallAction_OutputParameters(CallAction _this);
    
        /// <summary>
        /// Implementation of the operation CallBehaviorAction.OutputParameters
        /// </summary>
        global::System.Collections.Generic.IList<Parameter> CallBehaviorAction_OutputParameters(CallBehaviorAction _this);
    
        /// <summary>
        /// Implementation of the operation CallBehaviorAction.InputParameters
        /// </summary>
        global::System.Collections.Generic.IList<Parameter> CallBehaviorAction_InputParameters(CallBehaviorAction _this);
    
        /// <summary>
        /// Implementation of the operation CallOperationAction.OutputParameters
        /// </summary>
        global::System.Collections.Generic.IList<Parameter> CallOperationAction_OutputParameters(CallOperationAction _this);
    
        /// <summary>
        /// Implementation of the operation CallOperationAction.InputParameters
        /// </summary>
        global::System.Collections.Generic.IList<Parameter> CallOperationAction_InputParameters(CallOperationAction _this);
    
        /// <summary>
        /// Implementation of the operation ConditionalNode.AllActions
        /// </summary>
        global::System.Collections.Generic.IList<Action> ConditionalNode_AllActions(ConditionalNode _this);
    
        /// <summary>
        /// Implementation of the operation ConnectionPointReference.IsConsistentWith
        /// </summary>
        bool ConnectionPointReference_IsConsistentWith(ConnectionPointReference _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation ElementImport.GetName
        /// </summary>
        string ElementImport_GetName(ElementImport _this);
    
        /// <summary>
        /// Implementation of the operation ExtensionEnd.LowerBound
        /// </summary>
        int ExtensionEnd_LowerBound(ExtensionEnd _this);
    
        /// <summary>
        /// Implementation of the operation FinalState.IsConsistentWith
        /// </summary>
        bool FinalState_IsConsistentWith(FinalState _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation Gate.IsOutsideCF
        /// </summary>
        bool Gate_IsOutsideCF(Gate _this);
    
        /// <summary>
        /// Implementation of the operation Gate.IsInsideCF
        /// </summary>
        bool Gate_IsInsideCF(Gate _this);
    
        /// <summary>
        /// Implementation of the operation Gate.IsActual
        /// </summary>
        bool Gate_IsActual(Gate _this);
    
        /// <summary>
        /// Implementation of the operation Gate.IsFormal
        /// </summary>
        bool Gate_IsFormal(Gate _this);
    
        /// <summary>
        /// Implementation of the operation Gate.GetName
        /// </summary>
        string Gate_GetName(Gate _this);
    
        /// <summary>
        /// Implementation of the operation Gate.Matches
        /// </summary>
        bool Gate_Matches(Gate _this, Gate gateToMatch);
    
        /// <summary>
        /// Implementation of the operation Gate.IsDistinguishableFrom
        /// </summary>
        bool Gate_IsDistinguishableFrom(Gate _this, NamedElement n, Namespace ns);
    
        /// <summary>
        /// Implementation of the operation Gate.GetOperand
        /// </summary>
        InteractionOperand Gate_GetOperand(Gate _this);
    
        /// <summary>
        /// Implementation of the operation ParameterableElement.IsCompatibleWith
        /// </summary>
        bool ParameterableElement_IsCompatibleWith(ParameterableElement _this, ParameterableElement p);
    
        /// <summary>
        /// Implementation of the operation ParameterableElement.IsTemplateParameter
        /// </summary>
        bool ParameterableElement_IsTemplateParameter(ParameterableElement _this);
    
        /// <summary>
        /// Implementation of the operation Extension.MetaclassEnd
        /// </summary>
        Property Extension_MetaclassEnd(Extension _this);
    
        /// <summary>
        /// Implementation of the operation FunctionBehavior.HasAllDataTypeAttributes
        /// </summary>
        bool FunctionBehavior_HasAllDataTypeAttributes(FunctionBehavior _this, DataType d);
    
        /// <summary>
        /// Implementation of the operation LinkAction.Association
        /// </summary>
        Association LinkAction_Association(LinkAction _this);
    
        /// <summary>
        /// Implementation of the operation LinkEndData.AllPins
        /// </summary>
        global::System.Collections.Generic.IList<InputPin> LinkEndData_AllPins(LinkEndData _this);
    
        /// <summary>
        /// Implementation of the operation LinkEndCreationData.AllPins
        /// </summary>
        global::System.Collections.Generic.IList<InputPin> LinkEndCreationData_AllPins(LinkEndCreationData _this);
    
        /// <summary>
        /// Implementation of the operation LinkEndDestructionData.AllPins
        /// </summary>
        global::System.Collections.Generic.IList<InputPin> LinkEndDestructionData_AllPins(LinkEndDestructionData _this);
    
        /// <summary>
        /// Implementation of the operation LiteralBoolean.BooleanValue
        /// </summary>
        bool LiteralBoolean_BooleanValue(LiteralBoolean _this);
    
        /// <summary>
        /// Implementation of the operation LiteralBoolean.IsComputable
        /// </summary>
        bool LiteralBoolean_IsComputable(LiteralBoolean _this);
    
        /// <summary>
        /// Implementation of the operation LiteralInteger.IntegerValue
        /// </summary>
        int LiteralInteger_IntegerValue(LiteralInteger _this);
    
        /// <summary>
        /// Implementation of the operation LiteralInteger.IsComputable
        /// </summary>
        bool LiteralInteger_IsComputable(LiteralInteger _this);
    
        /// <summary>
        /// Implementation of the operation LiteralNull.IsComputable
        /// </summary>
        bool LiteralNull_IsComputable(LiteralNull _this);
    
        /// <summary>
        /// Implementation of the operation LiteralNull.IsNull
        /// </summary>
        bool LiteralNull_IsNull(LiteralNull _this);
    
        /// <summary>
        /// Implementation of the operation LiteralReal.IsComputable
        /// </summary>
        bool LiteralReal_IsComputable(LiteralReal _this);
    
        /// <summary>
        /// Implementation of the operation LiteralReal.RealValue
        /// </summary>
        double LiteralReal_RealValue(LiteralReal _this);
    
        /// <summary>
        /// Implementation of the operation LiteralString.IsComputable
        /// </summary>
        bool LiteralString_IsComputable(LiteralString _this);
    
        /// <summary>
        /// Implementation of the operation LiteralString.StringValue
        /// </summary>
        string LiteralString_StringValue(LiteralString _this);
    
        /// <summary>
        /// Implementation of the operation LiteralUnlimitedNatural.IsComputable
        /// </summary>
        bool LiteralUnlimitedNatural_IsComputable(LiteralUnlimitedNatural _this);
    
        /// <summary>
        /// Implementation of the operation LiteralUnlimitedNatural.UnlimitedValue
        /// </summary>
        int LiteralUnlimitedNatural_UnlimitedValue(LiteralUnlimitedNatural _this);
    
        /// <summary>
        /// Implementation of the operation LoopNode.AllActions
        /// </summary>
        global::System.Collections.Generic.IList<Action> LoopNode_AllActions(LoopNode _this);
    
        /// <summary>
        /// Implementation of the operation LoopNode.SourceNodes
        /// </summary>
        global::System.Collections.Generic.IList<ActivityNode> LoopNode_SourceNodes(LoopNode _this);
    
        /// <summary>
        /// Implementation of the operation Message.IsDistinguishableFrom
        /// </summary>
        bool Message_IsDistinguishableFrom(Message _this, NamedElement n, Namespace ns);
    
        /// <summary>
        /// Implementation of the operation MessageEnd.OppositeEnd
        /// </summary>
        global::System.Collections.Generic.IList<MessageEnd> MessageEnd_OppositeEnd(MessageEnd _this);
    
        /// <summary>
        /// Implementation of the operation MessageEnd.IsSend
        /// </summary>
        bool MessageEnd_IsSend(MessageEnd _this);
    
        /// <summary>
        /// Implementation of the operation MessageEnd.IsReceive
        /// </summary>
        bool MessageEnd_IsReceive(MessageEnd _this);
    
        /// <summary>
        /// Implementation of the operation MessageEnd.EnclosingFragment
        /// </summary>
        global::System.Collections.Generic.IList<InteractionFragment> MessageEnd_EnclosingFragment(MessageEnd _this);
    
        /// <summary>
        /// Implementation of the operation MultiplicityElement.CompatibleWith
        /// </summary>
        bool MultiplicityElement_CompatibleWith(MultiplicityElement _this, MultiplicityElement other);
    
        /// <summary>
        /// Implementation of the operation MultiplicityElement.IncludesMultiplicity
        /// </summary>
        bool MultiplicityElement_IncludesMultiplicity(MultiplicityElement _this, MultiplicityElement M);
    
        /// <summary>
        /// Implementation of the operation MultiplicityElement.Is
        /// </summary>
        bool MultiplicityElement_Is(MultiplicityElement _this, int lowerbound, int upperbound);
    
        /// <summary>
        /// Implementation of the operation MultiplicityElement.IsMultivalued
        /// </summary>
        bool MultiplicityElement_IsMultivalued(MultiplicityElement _this);
    
        /// <summary>
        /// Implementation of the operation MultiplicityElement.LowerBound
        /// </summary>
        int MultiplicityElement_LowerBound(MultiplicityElement _this);
    
        /// <summary>
        /// Implementation of the operation MultiplicityElement.UpperBound
        /// </summary>
        int MultiplicityElement_UpperBound(MultiplicityElement _this);
    
        /// <summary>
        /// Implementation of the operation Namespace.ExcludeCollisions
        /// </summary>
        global::System.Collections.Generic.IList<PackageableElement> Namespace_ExcludeCollisions(Namespace _this, global::System.Collections.Generic.IList<PackageableElement> imps);
    
        /// <summary>
        /// Implementation of the operation Namespace.GetNamesOfMember
        /// </summary>
        global::System.Collections.Generic.IList<string> Namespace_GetNamesOfMember(Namespace _this, NamedElement element);
    
        /// <summary>
        /// Implementation of the operation Namespace.ImportMembers
        /// </summary>
        global::System.Collections.Generic.IList<PackageableElement> Namespace_ImportMembers(Namespace _this, global::System.Collections.Generic.IList<PackageableElement> imps);
    
        /// <summary>
        /// Implementation of the operation Namespace.MembersAreDistinguishable
        /// </summary>
        bool Namespace_MembersAreDistinguishable(Namespace _this);
    
        /// <summary>
        /// Implementation of the operation OpaqueExpression.IsIntegral
        /// </summary>
        bool OpaqueExpression_IsIntegral(OpaqueExpression _this);
    
        /// <summary>
        /// Implementation of the operation OpaqueExpression.IsNonNegative
        /// </summary>
        bool OpaqueExpression_IsNonNegative(OpaqueExpression _this);
    
        /// <summary>
        /// Implementation of the operation OpaqueExpression.IsPositive
        /// </summary>
        bool OpaqueExpression_IsPositive(OpaqueExpression _this);
    
        /// <summary>
        /// Implementation of the operation OpaqueExpression.Value
        /// </summary>
        int OpaqueExpression_Value(OpaqueExpression _this);
    
        /// <summary>
        /// Implementation of the operation Package.AllApplicableStereotypes
        /// </summary>
        global::System.Collections.Generic.IList<Stereotype> Package_AllApplicableStereotypes(Package _this);
    
        /// <summary>
        /// Implementation of the operation Package.ContainingProfile
        /// </summary>
        Profile Package_ContainingProfile(Package _this);
    
        /// <summary>
        /// Implementation of the operation Package.MakesVisible
        /// </summary>
        bool Package_MakesVisible(Package _this, NamedElement el);
    
        /// <summary>
        /// Implementation of the operation Package.MustBeOwned
        /// </summary>
        bool Package_MustBeOwned(Package _this);
    
        /// <summary>
        /// Implementation of the operation Package.VisibleMembers
        /// </summary>
        global::System.Collections.Generic.IList<PackageableElement> Package_VisibleMembers(Package _this);
    
        /// <summary>
        /// Implementation of the operation RedefinableElement.IsConsistentWith
        /// </summary>
        bool RedefinableElement_IsConsistentWith(RedefinableElement _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation RedefinableElement.IsRedefinitionContextValid
        /// </summary>
        bool RedefinableElement_IsRedefinitionContextValid(RedefinableElement _this, RedefinableElement redefinedElement);
    
        /// <summary>
        /// Implementation of the operation Operation.IsConsistentWith
        /// </summary>
        bool Operation_IsConsistentWith(Operation _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation Operation.ReturnResult
        /// </summary>
        global::System.Collections.Generic.IList<Parameter> Operation_ReturnResult(Operation _this);
    
        /// <summary>
        /// Implementation of the operation Property.IsAttribute
        /// </summary>
        bool Property_IsAttribute(Property _this);
    
        /// <summary>
        /// Implementation of the operation Property.IsCompatibleWith
        /// </summary>
        bool Property_IsCompatibleWith(Property _this, ParameterableElement p);
    
        /// <summary>
        /// Implementation of the operation Property.IsConsistentWith
        /// </summary>
        bool Property_IsConsistentWith(Property _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation Property.IsNavigable
        /// </summary>
        bool Property_IsNavigable(Property _this);
    
        /// <summary>
        /// Implementation of the operation Property.SubsettingContext
        /// </summary>
        global::System.Collections.Generic.IList<Type> Property_SubsettingContext(Property _this);
    
        /// <summary>
        /// Implementation of the operation Port.BasicProvided
        /// </summary>
        global::System.Collections.Generic.IList<Interface> Port_BasicProvided(Port _this);
    
        /// <summary>
        /// Implementation of the operation Port.BasicRequired
        /// </summary>
        global::System.Collections.Generic.IList<Interface> Port_BasicRequired(Port _this);
    
        /// <summary>
        /// Implementation of the operation Pseudostate.IsConsistentWith
        /// </summary>
        bool Pseudostate_IsConsistentWith(Pseudostate _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation ReadLinkAction.OpenEnd
        /// </summary>
        global::System.Collections.Generic.IList<Property> ReadLinkAction_OpenEnd(ReadLinkAction _this);
    
        /// <summary>
        /// Implementation of the operation RedefinableTemplateSignature.IsConsistentWith
        /// </summary>
        bool RedefinableTemplateSignature_IsConsistentWith(RedefinableTemplateSignature _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation Region.BelongsToPSM
        /// </summary>
        bool Region_BelongsToPSM(Region _this);
    
        /// <summary>
        /// Implementation of the operation Region.ContainingStateMachine
        /// </summary>
        StateMachine Region_ContainingStateMachine(Region _this);
    
        /// <summary>
        /// Implementation of the operation Region.IsConsistentWith
        /// </summary>
        bool Region_IsConsistentWith(Region _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation Region.IsRedefinitionContextValid
        /// </summary>
        bool Region_IsRedefinitionContextValid(Region _this, RedefinableElement redefinedElement);
    
        /// <summary>
        /// Implementation of the operation StartObjectBehaviorAction.OutputParameters
        /// </summary>
        global::System.Collections.Generic.IList<Parameter> StartObjectBehaviorAction_OutputParameters(StartObjectBehaviorAction _this);
    
        /// <summary>
        /// Implementation of the operation StartObjectBehaviorAction.InputParameters
        /// </summary>
        global::System.Collections.Generic.IList<Parameter> StartObjectBehaviorAction_InputParameters(StartObjectBehaviorAction _this);
    
        /// <summary>
        /// Implementation of the operation StartObjectBehaviorAction.Behavior
        /// </summary>
        Behavior StartObjectBehaviorAction_Behavior(StartObjectBehaviorAction _this);
    
        /// <summary>
        /// Implementation of the operation TemplateableElement.IsTemplate
        /// </summary>
        bool TemplateableElement_IsTemplate(TemplateableElement _this);
    
        /// <summary>
        /// Implementation of the operation TemplateableElement.ParameterableElements
        /// </summary>
        global::System.Collections.Generic.IList<ParameterableElement> TemplateableElement_ParameterableElements(TemplateableElement _this);
    
        /// <summary>
        /// Implementation of the operation State.ContainingStateMachine
        /// </summary>
        StateMachine State_ContainingStateMachine(State _this);
    
        /// <summary>
        /// Implementation of the operation State.IsConsistentWith
        /// </summary>
        bool State_IsConsistentWith(State _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation StructuredClassifier.AllRoles
        /// </summary>
        global::System.Collections.Generic.IList<ConnectableElement> StructuredClassifier_AllRoles(StructuredClassifier _this);
    
        /// <summary>
        /// Implementation of the operation StateMachine.LCA
        /// </summary>
        Region StateMachine_LCA(StateMachine _this, Vertex s1, Vertex s2);
    
        /// <summary>
        /// Implementation of the operation StateMachine.Ancestor
        /// </summary>
        bool StateMachine_Ancestor(StateMachine _this, Vertex s1, Vertex s2);
    
        /// <summary>
        /// Implementation of the operation StateMachine.IsConsistentWith
        /// </summary>
        bool StateMachine_IsConsistentWith(StateMachine _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation StateMachine.IsRedefinitionContextValid
        /// </summary>
        bool StateMachine_IsRedefinitionContextValid(StateMachine _this, RedefinableElement redefinedElement);
    
        /// <summary>
        /// Implementation of the operation StateMachine.LCAState
        /// </summary>
        State StateMachine_LCAState(StateMachine _this, Vertex v1, Vertex v2);
    
        /// <summary>
        /// Implementation of the operation Stereotype.ContainingProfile
        /// </summary>
        Profile Stereotype_ContainingProfile(Stereotype _this);
    
        /// <summary>
        /// Implementation of the operation StringExpression.StringValue
        /// </summary>
        string StringExpression_StringValue(StringExpression _this);
    
        /// <summary>
        /// Implementation of the operation StructuredActivityNode.AllActions
        /// </summary>
        global::System.Collections.Generic.IList<Action> StructuredActivityNode_AllActions(StructuredActivityNode _this);
    
        /// <summary>
        /// Implementation of the operation StructuredActivityNode.AllOwnedNodes
        /// </summary>
        global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode_AllOwnedNodes(StructuredActivityNode _this);
    
        /// <summary>
        /// Implementation of the operation StructuredActivityNode.SourceNodes
        /// </summary>
        global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode_SourceNodes(StructuredActivityNode _this);
    
        /// <summary>
        /// Implementation of the operation StructuredActivityNode.TargetNodes
        /// </summary>
        global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode_TargetNodes(StructuredActivityNode _this);
    
        /// <summary>
        /// Implementation of the operation StructuredActivityNode.ContainingActivity
        /// </summary>
        Activity StructuredActivityNode_ContainingActivity(StructuredActivityNode _this);
    
        /// <summary>
        /// Implementation of the operation Transition.ContainingStateMachine
        /// </summary>
        StateMachine Transition_ContainingStateMachine(Transition _this);
    
        /// <summary>
        /// Implementation of the operation Transition.IsConsistentWith
        /// </summary>
        bool Transition_IsConsistentWith(Transition _this, RedefinableElement redefiningElement);
    
        /// <summary>
        /// Implementation of the operation Type.ConformsTo
        /// </summary>
        bool Type_ConformsTo(Type _this, Type other);
    
        /// <summary>
        /// Implementation of the operation UseCase.AllIncludedUseCases
        /// </summary>
        global::System.Collections.Generic.IList<UseCase> UseCase_AllIncludedUseCases(UseCase _this);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.BooleanValue
        /// </summary>
        bool ValueSpecification_BooleanValue(ValueSpecification _this);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.IntegerValue
        /// </summary>
        int ValueSpecification_IntegerValue(ValueSpecification _this);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.IsCompatibleWith
        /// </summary>
        bool ValueSpecification_IsCompatibleWith(ValueSpecification _this, ParameterableElement p);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.IsComputable
        /// </summary>
        bool ValueSpecification_IsComputable(ValueSpecification _this);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.IsNull
        /// </summary>
        bool ValueSpecification_IsNull(ValueSpecification _this);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.RealValue
        /// </summary>
        double ValueSpecification_RealValue(ValueSpecification _this);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.StringValue
        /// </summary>
        string ValueSpecification_StringValue(ValueSpecification _this);
    
        /// <summary>
        /// Implementation of the operation ValueSpecification.UnlimitedValue
        /// </summary>
        int ValueSpecification_UnlimitedValue(ValueSpecification _this);
    
        /// <summary>
        /// Implementation of the operation Variable.IsAccessibleBy
        /// </summary>
        bool Variable_IsAccessibleBy(Variable _this, Action a);
    
        /// <summary>
        /// Implementation of the operation Vertex.ContainingStateMachine
        /// </summary>
        StateMachine Vertex_ContainingStateMachine(Vertex _this);
    
        /// <summary>
        /// Implementation of the operation Vertex.IsContainedInState
        /// </summary>
        bool Vertex_IsContainedInState(Vertex _this, State s);
    
        /// <summary>
        /// Implementation of the operation Vertex.IsContainedInRegion
        /// </summary>
        bool Vertex_IsContainedInRegion(Vertex _this, Region r);
    
        /// <summary>
        /// Implementation of the operation Vertex.IsConsistentWith
        /// </summary>
        bool Vertex_IsConsistentWith(Vertex _this, RedefinableElement redefiningElement);
    
    }
}
