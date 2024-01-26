#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Model
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

    internal interface ICompiler
    {
    }
    
    public sealed class Compiler : __MetaModel, ICompiler
    {
        // If there is an error at the following line, create a new class called 'CustomCompilerImplementation'
        // inheriting from the class 'CustomCompilerImplementationBase' and provide the custom implementation
        // for the derived properties and operations defined in the metamodel
        internal static readonly CustomCompilerImplementationBase __CustomImpl = new CustomCompilerImplementation();
    
        private static readonly Compiler _instance;
        public static Compiler MInstance => _instance;
    
        private static readonly __ModelProperty _Declaration_Name;
        private static readonly __ModelProperty _Declaration_Parent;
        private static readonly __ModelProperty _Declaration_Declarations;
        private static readonly __ModelProperty _Declaration_FullName;
        private static readonly __ModelProperty _Language_Namespace;
        private static readonly __ModelProperty _Language_Grammar;
        private static readonly __ModelProperty _Grammar_Language;
        private static readonly __ModelProperty _Grammar_GrammarRules;
        private static readonly __ModelProperty _Grammar_TokenKinds;
        private static readonly __ModelProperty _Grammar_Tokens;
        private static readonly __ModelProperty _Grammar_Rules;
        private static readonly __ModelProperty _Grammar_Blocks;
        private static readonly __ModelProperty _Grammar_DefaultWhitespace;
        private static readonly __ModelProperty _Grammar_DefaultEndOfLine;
        private static readonly __ModelProperty _Grammar_DefaultSeparator;
        private static readonly __ModelProperty _Grammar_DefaultIdentifier;
        private static readonly __ModelProperty _Grammar_MainRule;
        private static readonly __ModelProperty _Annotation_AttributeClass;
        private static readonly __ModelProperty _Annotation_Arguments;
        private static readonly __ModelProperty _AnnotationArgument_NamedParameter;
        private static readonly __ModelProperty _AnnotationArgument_Parameter;
        private static readonly __ModelProperty _AnnotationArgument_ParameterType;
        private static readonly __ModelProperty _AnnotationArgument_Value;
        private static readonly __ModelProperty _Binder_TypeName;
        private static readonly __ModelProperty _Binder_Arguments;
        private static readonly __ModelProperty _Binder_IsNegated;
        private static readonly __ModelProperty _Binder_ConstructorArguments;
        private static readonly __ModelProperty _BinderArgument_Name;
        private static readonly __ModelProperty _BinderArgument_TypeName;
        private static readonly __ModelProperty _BinderArgument_IsArray;
        private static readonly __ModelProperty _BinderArgument_Values;
        private static readonly __ModelProperty _CSharpElement_Annotations;
        private static readonly __ModelProperty _CSharpElement_CSharpName;
        private static readonly __ModelProperty _CSharpElement_AntlrName;
        private static readonly __ModelProperty _CSharpElement_Binders;
        private static readonly __ModelProperty _CSharpElement_ContainsBinders;
        private static readonly __ModelProperty _TokenKind_Name;
        private static readonly __ModelProperty _TokenKind_TypeName;
        private static readonly __ModelProperty _GrammarRule_Language;
        private static readonly __ModelProperty _GrammarRule_Grammar;
        private static readonly __ModelProperty _LexerRule_Alternatives;
        private static readonly __ModelProperty _LexerRule_IsFixed;
        private static readonly __ModelProperty _LexerRule_FixedText;
        private static readonly __ModelProperty _Token_ReturnType;
        private static readonly __ModelProperty _Token_IsTrivia;
        private static readonly __ModelProperty _Token_TokenKind;
        private static readonly __ModelProperty _LAlternative_IsFixed;
        private static readonly __ModelProperty _LAlternative_FixedText;
        private static readonly __ModelProperty _LAlternative_Elements;
        private static readonly __ModelProperty _LElement_IsFixed;
        private static readonly __ModelProperty _LElement_FixedText;
        private static readonly __ModelProperty _LElement_IsNegated;
        private static readonly __ModelProperty _LElement_Value;
        private static readonly __ModelProperty _LElement_Multiplicity;
        private static readonly __ModelProperty _LElementValue_IsFixed;
        private static readonly __ModelProperty _LElementValue_FixedText;
        private static readonly __ModelProperty _LReference_IsFixed;
        private static readonly __ModelProperty _LReference_FixedText;
        private static readonly __ModelProperty _LReference_Rule;
        private static readonly __ModelProperty _LFixed_IsFixed;
        private static readonly __ModelProperty _LFixed_FixedText;
        private static readonly __ModelProperty _LFixed_Text;
        private static readonly __ModelProperty _LWildCard_IsFixed;
        private static readonly __ModelProperty _LWildCard_FixedText;
        private static readonly __ModelProperty _LRange_IsFixed;
        private static readonly __ModelProperty _LRange_FixedText;
        private static readonly __ModelProperty _LRange_StartChar;
        private static readonly __ModelProperty _LRange_EndChar;
        private static readonly __ModelProperty _LSet_IsFixed;
        private static readonly __ModelProperty _LSet_FixedText;
        private static readonly __ModelProperty _LSet_Items;
        private static readonly __ModelProperty _LSetItem_IsFixed;
        private static readonly __ModelProperty _LSetItem_FixedText;
        private static readonly __ModelProperty _LSetChar_IsFixed;
        private static readonly __ModelProperty _LSetChar_FixedText;
        private static readonly __ModelProperty _LSetChar_Char;
        private static readonly __ModelProperty _LSetRange_IsFixed;
        private static readonly __ModelProperty _LSetRange_FixedText;
        private static readonly __ModelProperty _LSetRange_StartChar;
        private static readonly __ModelProperty _LSetRange_EndChar;
        private static readonly __ModelProperty _LBlock_IsFixed;
        private static readonly __ModelProperty _LBlock_FixedText;
        private static readonly __ModelProperty _LBlock_Alternatives;
        private static readonly __ModelProperty _Rule_ReturnType;
        private static readonly __ModelProperty _Rule_Alternatives;
        private static readonly __ModelProperty _Rule_BaseRule;
        private static readonly __ModelProperty _Rule_GreenName;
        private static readonly __ModelProperty _Rule_RedName;
        private static readonly __ModelProperty _Alternative_ReturnType;
        private static readonly __ModelProperty _Alternative_ReturnValue;
        private static readonly __ModelProperty _Alternative_Elements;
        private static readonly __ModelProperty _Alternative_GreenName;
        private static readonly __ModelProperty _Alternative_GreenConstructorParameters;
        private static readonly __ModelProperty _Alternative_GreenConstructorArguments;
        private static readonly __ModelProperty _Alternative_GreenUpdateParameters;
        private static readonly __ModelProperty _Alternative_GreenUpdateArguments;
        private static readonly __ModelProperty _Alternative_RedName;
        private static readonly __ModelProperty _Alternative_RedUpdateParameters;
        private static readonly __ModelProperty _Alternative_RedUpdateArguments;
        private static readonly __ModelProperty _Alternative_RedOptionalUpdateParameters;
        private static readonly __ModelProperty _Alternative_RedToGreenArgumentList;
        private static readonly __ModelProperty _Alternative_RedToGreenOptionalArgumentList;
        private static readonly __ModelProperty _Alternative_HasRedToGreenOptionalArguments;
        private static readonly __ModelProperty _Element_Name;
        private static readonly __ModelProperty _Element_Assignment;
        private static readonly __ModelProperty _Element_Value;
        private static readonly __ModelProperty _Element_IsToken;
        private static readonly __ModelProperty _Element_IsList;
        private static readonly __ModelProperty _Element_FieldName;
        private static readonly __ModelProperty _Element_ParameterName;
        private static readonly __ModelProperty _Element_PropertyName;
        private static readonly __ModelProperty _Element_GreenFieldType;
        private static readonly __ModelProperty _Element_GreenParameterValue;
        private static readonly __ModelProperty _Element_GreenPropertyType;
        private static readonly __ModelProperty _Element_GreenPropertyValue;
        private static readonly __ModelProperty _Element_GreenSyntaxNullCondition;
        private static readonly __ModelProperty _Element_GreenSyntaxCondition;
        private static readonly __ModelProperty _Element_IsOptionalUpdateParameter;
        private static readonly __ModelProperty _Element_RedFieldType;
        private static readonly __ModelProperty _Element_RedParameterValue;
        private static readonly __ModelProperty _Element_RedPropertyType;
        private static readonly __ModelProperty _Element_RedPropertyValue;
        private static readonly __ModelProperty _Element_RedToGreenArgument;
        private static readonly __ModelProperty _Element_RedToGreenOptionalArgument;
        private static readonly __ModelProperty _Element_RedSyntaxNullCondition;
        private static readonly __ModelProperty _Element_RedSyntaxCondition;
        private static readonly __ModelProperty _Element_VisitCall;
        private static readonly __ModelProperty _ElementValue_Multiplicity;
        private static readonly __ModelProperty _ElementValue_GreenType;
        private static readonly __ModelProperty _ElementValue_GreenSyntaxCondition;
        private static readonly __ModelProperty _ElementValue_RedType;
        private static readonly __ModelProperty _RuleRef_GrammarRule;
        private static readonly __ModelProperty _RuleRef_ReferencedTypes;
        private static readonly __ModelProperty _RuleRef_Token;
        private static readonly __ModelProperty _RuleRef_Rule;
        private static readonly __ModelProperty _RuleRef_GreenType;
        private static readonly __ModelProperty _RuleRef_GreenSyntaxCondition;
        private static readonly __ModelProperty _RuleRef_RedType;
        private static readonly __ModelProperty _Eof_GreenType;
        private static readonly __ModelProperty _Eof_GreenSyntaxCondition;
        private static readonly __ModelProperty _Eof_RedType;
        private static readonly __ModelProperty _Fixed_Text;
        private static readonly __ModelProperty _TokenAlts_Tokens;
        private static readonly __ModelProperty _TokenAlts_GreenType;
        private static readonly __ModelProperty _TokenAlts_GreenSyntaxCondition;
        private static readonly __ModelProperty _TokenAlts_RedType;
        private static readonly __ModelProperty _Block_Alternatives;
        private static readonly __ModelProperty _Block_GreenName;
        private static readonly __ModelProperty _Block_RedName;
        private static readonly __ModelProperty _Block_GreenType;
        private static readonly __ModelProperty _Block_GreenSyntaxCondition;
        private static readonly __ModelProperty _Block_RedType;
        private static readonly __ModelProperty _SeparatedList_SeparatorFirst;
        private static readonly __ModelProperty _SeparatedList_RepeatedSeparatorFirst;
        private static readonly __ModelProperty _SeparatedList_FirstItems;
        private static readonly __ModelProperty _SeparatedList_FirstSeparators;
        private static readonly __ModelProperty _SeparatedList_RepeatedBlock;
        private static readonly __ModelProperty _SeparatedList_RepeatedItem;
        private static readonly __ModelProperty _SeparatedList_RepeatedSeparator;
        private static readonly __ModelProperty _SeparatedList_LastItems;
        private static readonly __ModelProperty _SeparatedList_LastSeparators;
        private static readonly __ModelProperty _SeparatedList_GreenType;
        private static readonly __ModelProperty _SeparatedList_GreenSyntaxCondition;
        private static readonly __ModelProperty _SeparatedList_RedType;
        private static readonly __ModelProperty _Expression_Value;
        private static readonly __ModelProperty _ArrayExpression_Items;
    
        static Compiler()
        {
            _Annotation_Arguments = new __ModelProperty(typeof(Annotation), "Arguments", typeof(AnnotationArgument), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, "Arguments");
            _Annotation_AttributeClass = new __ModelProperty(typeof(Annotation), "AttributeClass", typeof(global::MetaDslx.CodeAnalysis.MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, "AttributeClass");
            _AnnotationArgument_NamedParameter = new __ModelProperty(typeof(AnnotationArgument), "NamedParameter", typeof(global::MetaDslx.CodeAnalysis.MetaSymbol), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection, "NamedParameter");
            _AnnotationArgument_Parameter = new __ModelProperty(typeof(AnnotationArgument), "Parameter", typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.Single, "Parameter");
            _AnnotationArgument_ParameterType = new __ModelProperty(typeof(AnnotationArgument), "ParameterType", typeof(global::MetaDslx.CodeAnalysis.MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _AnnotationArgument_Value = new __ModelProperty(typeof(AnnotationArgument), "Value", typeof(Expression), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single, "Value");
            _ArrayExpression_Items = new __ModelProperty(typeof(ArrayExpression), "Items", typeof(Expression), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
            _Binder_Arguments = new __ModelProperty(typeof(Binder), "Arguments", typeof(BinderArgument), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _Binder_ConstructorArguments = new __ModelProperty(typeof(Binder), "ConstructorArguments", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Binder_IsNegated = new __ModelProperty(typeof(Binder), "IsNegated", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Binder_TypeName = new __ModelProperty(typeof(Binder), "TypeName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _BinderArgument_IsArray = new __ModelProperty(typeof(BinderArgument), "IsArray", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _BinderArgument_Name = new __ModelProperty(typeof(BinderArgument), "Name", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _BinderArgument_TypeName = new __ModelProperty(typeof(BinderArgument), "TypeName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _BinderArgument_Values = new __ModelProperty(typeof(BinderArgument), "Values", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection, null);
            _CSharpElement_Annotations = new __ModelProperty(typeof(CSharpElement), "Annotations", typeof(Annotation), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _CSharpElement_AntlrName = new __ModelProperty(typeof(CSharpElement), "AntlrName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _CSharpElement_Binders = new __ModelProperty(typeof(CSharpElement), "Binders", typeof(Binder), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _CSharpElement_ContainsBinders = new __ModelProperty(typeof(CSharpElement), "ContainsBinders", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _CSharpElement_CSharpName = new __ModelProperty(typeof(CSharpElement), "CSharpName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Block_Alternatives = new __ModelProperty(typeof(Block), "Alternatives", typeof(Alternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, "Alternatives");
            _Block_GreenName = new __ModelProperty(typeof(Block), "GreenName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Block_GreenSyntaxCondition = new __ModelProperty(typeof(Block), "GreenSyntaxCondition", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Block_GreenType = new __ModelProperty(typeof(Block), "GreenType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Block_RedName = new __ModelProperty(typeof(Block), "RedName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Block_RedType = new __ModelProperty(typeof(Block), "RedType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Declaration_Declarations = new __ModelProperty(typeof(Declaration), "Declarations", typeof(Declaration), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _Declaration_FullName = new __ModelProperty(typeof(Declaration), "FullName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Declaration_Name = new __ModelProperty(typeof(Declaration), "Name", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.Name, "Name");
            _Declaration_Parent = new __ModelProperty(typeof(Declaration), "Parent", typeof(Declaration), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _Alternative_Elements = new __ModelProperty(typeof(Alternative), "Elements", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, "Elements");
            _Alternative_GreenConstructorArguments = new __ModelProperty(typeof(Alternative), "GreenConstructorArguments", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Alternative_GreenConstructorParameters = new __ModelProperty(typeof(Alternative), "GreenConstructorParameters", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Alternative_GreenName = new __ModelProperty(typeof(Alternative), "GreenName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Alternative_GreenUpdateArguments = new __ModelProperty(typeof(Alternative), "GreenUpdateArguments", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Alternative_GreenUpdateParameters = new __ModelProperty(typeof(Alternative), "GreenUpdateParameters", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Alternative_HasRedToGreenOptionalArguments = new __ModelProperty(typeof(Alternative), "HasRedToGreenOptionalArguments", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Alternative_RedName = new __ModelProperty(typeof(Alternative), "RedName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Alternative_RedOptionalUpdateParameters = new __ModelProperty(typeof(Alternative), "RedOptionalUpdateParameters", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Alternative_RedToGreenArgumentList = new __ModelProperty(typeof(Alternative), "RedToGreenArgumentList", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Alternative_RedToGreenOptionalArgumentList = new __ModelProperty(typeof(Alternative), "RedToGreenOptionalArgumentList", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Alternative_RedUpdateArguments = new __ModelProperty(typeof(Alternative), "RedUpdateArguments", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Alternative_RedUpdateParameters = new __ModelProperty(typeof(Alternative), "RedUpdateParameters", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Alternative_ReturnType = new __ModelProperty(typeof(Alternative), "ReturnType", typeof(global::MetaDslx.CodeAnalysis.MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, "ReturnType");
            _Alternative_ReturnValue = new __ModelProperty(typeof(Alternative), "ReturnValue", typeof(Expression), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single, "ReturnValue");
            _Element_Assignment = new __ModelProperty(typeof(Element), "Assignment", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.Single, "Assignment");
            _Element_FieldName = new __ModelProperty(typeof(Element), "FieldName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_GreenFieldType = new __ModelProperty(typeof(Element), "GreenFieldType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_GreenParameterValue = new __ModelProperty(typeof(Element), "GreenParameterValue", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_GreenPropertyType = new __ModelProperty(typeof(Element), "GreenPropertyType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_GreenPropertyValue = new __ModelProperty(typeof(Element), "GreenPropertyValue", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_GreenSyntaxCondition = new __ModelProperty(typeof(Element), "GreenSyntaxCondition", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_GreenSyntaxNullCondition = new __ModelProperty(typeof(Element), "GreenSyntaxNullCondition", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_IsList = new __ModelProperty(typeof(Element), "IsList", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_IsOptionalUpdateParameter = new __ModelProperty(typeof(Element), "IsOptionalUpdateParameter", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_IsToken = new __ModelProperty(typeof(Element), "IsToken", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_Name = new __ModelProperty(typeof(Element), "Name", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.Name, "Name");
            _Element_ParameterName = new __ModelProperty(typeof(Element), "ParameterName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_PropertyName = new __ModelProperty(typeof(Element), "PropertyName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_RedFieldType = new __ModelProperty(typeof(Element), "RedFieldType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_RedParameterValue = new __ModelProperty(typeof(Element), "RedParameterValue", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_RedPropertyType = new __ModelProperty(typeof(Element), "RedPropertyType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_RedPropertyValue = new __ModelProperty(typeof(Element), "RedPropertyValue", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_RedSyntaxCondition = new __ModelProperty(typeof(Element), "RedSyntaxCondition", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_RedSyntaxNullCondition = new __ModelProperty(typeof(Element), "RedSyntaxNullCondition", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_RedToGreenArgument = new __ModelProperty(typeof(Element), "RedToGreenArgument", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_RedToGreenOptionalArgument = new __ModelProperty(typeof(Element), "RedToGreenOptionalArgument", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Element_Value = new __ModelProperty(typeof(Element), "Value", typeof(ElementValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single, "Value");
            _Element_VisitCall = new __ModelProperty(typeof(Element), "VisitCall", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _ElementValue_GreenSyntaxCondition = new __ModelProperty(typeof(ElementValue), "GreenSyntaxCondition", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _ElementValue_GreenType = new __ModelProperty(typeof(ElementValue), "GreenType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _ElementValue_Multiplicity = new __ModelProperty(typeof(ElementValue), "Multiplicity", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.Single, null);
            _ElementValue_RedType = new __ModelProperty(typeof(ElementValue), "RedType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Eof_GreenSyntaxCondition = new __ModelProperty(typeof(Eof), "GreenSyntaxCondition", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Eof_GreenType = new __ModelProperty(typeof(Eof), "GreenType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Eof_RedType = new __ModelProperty(typeof(Eof), "RedType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Expression_Value = new __ModelProperty(typeof(Expression), "Value", typeof(global::MetaDslx.CodeAnalysis.MetaSymbol), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, "Value");
            _Fixed_Text = new __ModelProperty(typeof(Fixed), "Text", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _GrammarRule_Grammar = new __ModelProperty(typeof(GrammarRule), "Grammar", typeof(Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _GrammarRule_Language = new __ModelProperty(typeof(GrammarRule), "Language", typeof(Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Language_Grammar = new __ModelProperty(typeof(Language), "Grammar", typeof(Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single, null);
            _Language_Namespace = new __ModelProperty(typeof(Language), "Namespace", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LexerRule_Alternatives = new __ModelProperty(typeof(LexerRule), "Alternatives", typeof(LAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _LexerRule_FixedText = new __ModelProperty(typeof(LexerRule), "FixedText", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LexerRule_IsFixed = new __ModelProperty(typeof(LexerRule), "IsFixed", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Grammar_Blocks = new __ModelProperty(typeof(Grammar), "Blocks", typeof(Block), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
            _Grammar_DefaultEndOfLine = new __ModelProperty(typeof(Grammar), "DefaultEndOfLine", typeof(Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _Grammar_DefaultIdentifier = new __ModelProperty(typeof(Grammar), "DefaultIdentifier", typeof(Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _Grammar_DefaultSeparator = new __ModelProperty(typeof(Grammar), "DefaultSeparator", typeof(Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _Grammar_DefaultWhitespace = new __ModelProperty(typeof(Grammar), "DefaultWhitespace", typeof(Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _Grammar_GrammarRules = new __ModelProperty(typeof(Grammar), "GrammarRules", typeof(GrammarRule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _Grammar_Language = new __ModelProperty(typeof(Grammar), "Language", typeof(Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _Grammar_MainRule = new __ModelProperty(typeof(Grammar), "MainRule", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _Grammar_Rules = new __ModelProperty(typeof(Grammar), "Rules", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _Grammar_TokenKinds = new __ModelProperty(typeof(Grammar), "TokenKinds", typeof(TokenKind), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _Grammar_Tokens = new __ModelProperty(typeof(Grammar), "Tokens", typeof(Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _LAlternative_Elements = new __ModelProperty(typeof(LAlternative), "Elements", typeof(LElement), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _LAlternative_FixedText = new __ModelProperty(typeof(LAlternative), "FixedText", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LAlternative_IsFixed = new __ModelProperty(typeof(LAlternative), "IsFixed", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LElement_FixedText = new __ModelProperty(typeof(LElement), "FixedText", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LElement_IsFixed = new __ModelProperty(typeof(LElement), "IsFixed", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LElement_IsNegated = new __ModelProperty(typeof(LElement), "IsNegated", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _LElement_Multiplicity = new __ModelProperty(typeof(LElement), "Multiplicity", typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.EnumType | __ModelPropertyFlags.Single, null);
            _LElement_Value = new __ModelProperty(typeof(LElement), "Value", typeof(LElementValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single, null);
            _LElementValue_FixedText = new __ModelProperty(typeof(LElementValue), "FixedText", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LElementValue_IsFixed = new __ModelProperty(typeof(LElementValue), "IsFixed", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LBlock_Alternatives = new __ModelProperty(typeof(LBlock), "Alternatives", typeof(LAlternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _LBlock_FixedText = new __ModelProperty(typeof(LBlock), "FixedText", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LBlock_IsFixed = new __ModelProperty(typeof(LBlock), "IsFixed", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LFixed_FixedText = new __ModelProperty(typeof(LFixed), "FixedText", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LFixed_IsFixed = new __ModelProperty(typeof(LFixed), "IsFixed", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LFixed_Text = new __ModelProperty(typeof(LFixed), "Text", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _LRange_EndChar = new __ModelProperty(typeof(LRange), "EndChar", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _LRange_FixedText = new __ModelProperty(typeof(LRange), "FixedText", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LRange_IsFixed = new __ModelProperty(typeof(LRange), "IsFixed", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LRange_StartChar = new __ModelProperty(typeof(LRange), "StartChar", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _LReference_FixedText = new __ModelProperty(typeof(LReference), "FixedText", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LReference_IsFixed = new __ModelProperty(typeof(LReference), "IsFixed", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LReference_Rule = new __ModelProperty(typeof(LReference), "Rule", typeof(LexerRule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _LSet_FixedText = new __ModelProperty(typeof(LSet), "FixedText", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LSet_IsFixed = new __ModelProperty(typeof(LSet), "IsFixed", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LSet_Items = new __ModelProperty(typeof(LSet), "Items", typeof(LSetItem), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _LSetItem_FixedText = new __ModelProperty(typeof(LSetItem), "FixedText", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LSetItem_IsFixed = new __ModelProperty(typeof(LSetItem), "IsFixed", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LSetChar_Char = new __ModelProperty(typeof(LSetChar), "Char", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _LSetChar_FixedText = new __ModelProperty(typeof(LSetChar), "FixedText", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LSetChar_IsFixed = new __ModelProperty(typeof(LSetChar), "IsFixed", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LSetRange_EndChar = new __ModelProperty(typeof(LSetRange), "EndChar", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _LSetRange_FixedText = new __ModelProperty(typeof(LSetRange), "FixedText", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LSetRange_IsFixed = new __ModelProperty(typeof(LSetRange), "IsFixed", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LSetRange_StartChar = new __ModelProperty(typeof(LSetRange), "StartChar", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _LWildCard_FixedText = new __ModelProperty(typeof(LWildCard), "FixedText", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _LWildCard_IsFixed = new __ModelProperty(typeof(LWildCard), "IsFixed", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Rule_Alternatives = new __ModelProperty(typeof(Rule), "Alternatives", typeof(Alternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, "Alternatives");
            _Rule_BaseRule = new __ModelProperty(typeof(Rule), "BaseRule", typeof(Alternative), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _Rule_GreenName = new __ModelProperty(typeof(Rule), "GreenName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Rule_RedName = new __ModelProperty(typeof(Rule), "RedName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Rule_ReturnType = new __ModelProperty(typeof(Rule), "ReturnType", typeof(global::MetaDslx.CodeAnalysis.MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, "ReturnType");
            _RuleRef_GrammarRule = new __ModelProperty(typeof(RuleRef), "GrammarRule", typeof(GrammarRule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, "Rule");
            _RuleRef_GreenSyntaxCondition = new __ModelProperty(typeof(RuleRef), "GreenSyntaxCondition", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _RuleRef_GreenType = new __ModelProperty(typeof(RuleRef), "GreenType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _RuleRef_RedType = new __ModelProperty(typeof(RuleRef), "RedType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _RuleRef_ReferencedTypes = new __ModelProperty(typeof(RuleRef), "ReferencedTypes", typeof(global::MetaDslx.CodeAnalysis.MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection, "ReferencedTypes");
            _RuleRef_Rule = new __ModelProperty(typeof(RuleRef), "Rule", typeof(Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _RuleRef_Token = new __ModelProperty(typeof(RuleRef), "Token", typeof(Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _SeparatedList_FirstItems = new __ModelProperty(typeof(SeparatedList), "FirstItems", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _SeparatedList_FirstSeparators = new __ModelProperty(typeof(SeparatedList), "FirstSeparators", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _SeparatedList_GreenSyntaxCondition = new __ModelProperty(typeof(SeparatedList), "GreenSyntaxCondition", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _SeparatedList_GreenType = new __ModelProperty(typeof(SeparatedList), "GreenType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _SeparatedList_LastItems = new __ModelProperty(typeof(SeparatedList), "LastItems", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _SeparatedList_LastSeparators = new __ModelProperty(typeof(SeparatedList), "LastSeparators", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _SeparatedList_RedType = new __ModelProperty(typeof(SeparatedList), "RedType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _SeparatedList_RepeatedBlock = new __ModelProperty(typeof(SeparatedList), "RepeatedBlock", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single, null);
            _SeparatedList_RepeatedItem = new __ModelProperty(typeof(SeparatedList), "RepeatedItem", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _SeparatedList_RepeatedSeparator = new __ModelProperty(typeof(SeparatedList), "RepeatedSeparator", typeof(Element), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _SeparatedList_RepeatedSeparatorFirst = new __ModelProperty(typeof(SeparatedList), "RepeatedSeparatorFirst", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _SeparatedList_SeparatorFirst = new __ModelProperty(typeof(SeparatedList), "SeparatorFirst", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Token_IsTrivia = new __ModelProperty(typeof(Token), "IsTrivia", typeof(global::System.Boolean), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Token_ReturnType = new __ModelProperty(typeof(Token), "ReturnType", typeof(global::MetaDslx.CodeAnalysis.MetaType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, "ReturnType");
            _Token_TokenKind = new __ModelProperty(typeof(Token), "TokenKind", typeof(TokenKind), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _TokenAlts_GreenSyntaxCondition = new __ModelProperty(typeof(TokenAlts), "GreenSyntaxCondition", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _TokenAlts_GreenType = new __ModelProperty(typeof(TokenAlts), "GreenType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _TokenAlts_RedType = new __ModelProperty(typeof(TokenAlts), "RedType", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _TokenAlts_Tokens = new __ModelProperty(typeof(TokenAlts), "Tokens", typeof(RuleRef), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _TokenKind_Name = new __ModelProperty(typeof(TokenKind), "Name", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _TokenKind_TypeName = new __ModelProperty(typeof(TokenKind), "TypeName", typeof(global::System.String), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _instance = new Compiler();
        }
    
        private readonly __Model _model;
    
        private readonly global::System.Collections.Immutable.ImmutableArray<__MetaType> _enumTypes;
        private readonly global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo> _enumInfos;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelEnumInfo> _enumInfosByType;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelEnumInfo> _enumInfosByName;
    
        private readonly global::System.Collections.Immutable.ImmutableArray<__MetaType> _classTypes;
        private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _classInfos;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelClassInfo> _classInfosByType;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelClassInfo> _classInfosByName;
    
    
        private Compiler()
        {
            _enumTypes = __ImmutableArray.Create<__MetaType>(typeof(Assignment), typeof(Multiplicity));
            _enumInfos = __ImmutableArray.Create<__ModelEnumInfo>(AssignmentInfo, MultiplicityInfo);
            var enumInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelEnumInfo>();
            enumInfosByType.Add(typeof(Assignment), AssignmentInfo);
            enumInfosByType.Add(typeof(Multiplicity), MultiplicityInfo);
            _enumInfosByType = enumInfosByType.ToImmutable();
            var enumInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelEnumInfo>();
            enumInfosByName.Add("Assignment", AssignmentInfo);
            enumInfosByName.Add("Multiplicity", MultiplicityInfo);
            _enumInfosByName = enumInfosByName.ToImmutable();
    
            _classTypes = __ImmutableArray.Create<__MetaType>(typeof(Annotation), typeof(AnnotationArgument), typeof(ArrayExpression), typeof(Binder), typeof(BinderArgument), typeof(CSharpElement), typeof(Block), typeof(Declaration), typeof(Alternative), typeof(Element), typeof(ElementValue), typeof(Eof), typeof(Expression), typeof(Fixed), typeof(GrammarRule), typeof(Language), typeof(LexerRule), typeof(Fragment), typeof(Grammar), typeof(LAlternative), typeof(LElement), typeof(LElementValue), typeof(LBlock), typeof(LFixed), typeof(LRange), typeof(LReference), typeof(LSet), typeof(LSetItem), typeof(LSetChar), typeof(LSetRange), typeof(LWildCard), typeof(Namespace), typeof(Rule), typeof(RuleRef), typeof(SeparatedList), typeof(Token), typeof(TokenAlts), typeof(TokenKind));
            _classInfos = __ImmutableArray.Create<__ModelClassInfo>(AnnotationInfo, AnnotationArgumentInfo, ArrayExpressionInfo, BinderInfo, BinderArgumentInfo, CSharpElementInfo, BlockInfo, DeclarationInfo, AlternativeInfo, ElementInfo, ElementValueInfo, EofInfo, ExpressionInfo, FixedInfo, GrammarRuleInfo, LanguageInfo, LexerRuleInfo, FragmentInfo, GrammarInfo, LAlternativeInfo, LElementInfo, LElementValueInfo, LBlockInfo, LFixedInfo, LRangeInfo, LReferenceInfo, LSetInfo, LSetItemInfo, LSetCharInfo, LSetRangeInfo, LWildCardInfo, NamespaceInfo, RuleInfo, RuleRefInfo, SeparatedListInfo, TokenInfo, TokenAltsInfo, TokenKindInfo);
            var classInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelClassInfo>();
            classInfosByType.Add(typeof(Annotation), AnnotationInfo);
            classInfosByType.Add(typeof(AnnotationArgument), AnnotationArgumentInfo);
            classInfosByType.Add(typeof(ArrayExpression), ArrayExpressionInfo);
            classInfosByType.Add(typeof(Binder), BinderInfo);
            classInfosByType.Add(typeof(BinderArgument), BinderArgumentInfo);
            classInfosByType.Add(typeof(CSharpElement), CSharpElementInfo);
            classInfosByType.Add(typeof(Block), BlockInfo);
            classInfosByType.Add(typeof(Declaration), DeclarationInfo);
            classInfosByType.Add(typeof(Alternative), AlternativeInfo);
            classInfosByType.Add(typeof(Element), ElementInfo);
            classInfosByType.Add(typeof(ElementValue), ElementValueInfo);
            classInfosByType.Add(typeof(Eof), EofInfo);
            classInfosByType.Add(typeof(Expression), ExpressionInfo);
            classInfosByType.Add(typeof(Fixed), FixedInfo);
            classInfosByType.Add(typeof(GrammarRule), GrammarRuleInfo);
            classInfosByType.Add(typeof(Language), LanguageInfo);
            classInfosByType.Add(typeof(LexerRule), LexerRuleInfo);
            classInfosByType.Add(typeof(Fragment), FragmentInfo);
            classInfosByType.Add(typeof(Grammar), GrammarInfo);
            classInfosByType.Add(typeof(LAlternative), LAlternativeInfo);
            classInfosByType.Add(typeof(LElement), LElementInfo);
            classInfosByType.Add(typeof(LElementValue), LElementValueInfo);
            classInfosByType.Add(typeof(LBlock), LBlockInfo);
            classInfosByType.Add(typeof(LFixed), LFixedInfo);
            classInfosByType.Add(typeof(LRange), LRangeInfo);
            classInfosByType.Add(typeof(LReference), LReferenceInfo);
            classInfosByType.Add(typeof(LSet), LSetInfo);
            classInfosByType.Add(typeof(LSetItem), LSetItemInfo);
            classInfosByType.Add(typeof(LSetChar), LSetCharInfo);
            classInfosByType.Add(typeof(LSetRange), LSetRangeInfo);
            classInfosByType.Add(typeof(LWildCard), LWildCardInfo);
            classInfosByType.Add(typeof(Namespace), NamespaceInfo);
            classInfosByType.Add(typeof(Rule), RuleInfo);
            classInfosByType.Add(typeof(RuleRef), RuleRefInfo);
            classInfosByType.Add(typeof(SeparatedList), SeparatedListInfo);
            classInfosByType.Add(typeof(Token), TokenInfo);
            classInfosByType.Add(typeof(TokenAlts), TokenAltsInfo);
            classInfosByType.Add(typeof(TokenKind), TokenKindInfo);
            _classInfosByType = classInfosByType.ToImmutable();
            var classInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelClassInfo>();
            classInfosByName.Add("Annotation", AnnotationInfo);
            classInfosByName.Add("AnnotationArgument", AnnotationArgumentInfo);
            classInfosByName.Add("ArrayExpression", ArrayExpressionInfo);
            classInfosByName.Add("Binder", BinderInfo);
            classInfosByName.Add("BinderArgument", BinderArgumentInfo);
            classInfosByName.Add("CSharpElement", CSharpElementInfo);
            classInfosByName.Add("Block", BlockInfo);
            classInfosByName.Add("Declaration", DeclarationInfo);
            classInfosByName.Add("Alternative", AlternativeInfo);
            classInfosByName.Add("Element", ElementInfo);
            classInfosByName.Add("ElementValue", ElementValueInfo);
            classInfosByName.Add("Eof", EofInfo);
            classInfosByName.Add("Expression", ExpressionInfo);
            classInfosByName.Add("Fixed", FixedInfo);
            classInfosByName.Add("GrammarRule", GrammarRuleInfo);
            classInfosByName.Add("Language", LanguageInfo);
            classInfosByName.Add("LexerRule", LexerRuleInfo);
            classInfosByName.Add("Fragment", FragmentInfo);
            classInfosByName.Add("Grammar", GrammarInfo);
            classInfosByName.Add("LAlternative", LAlternativeInfo);
            classInfosByName.Add("LElement", LElementInfo);
            classInfosByName.Add("LElementValue", LElementValueInfo);
            classInfosByName.Add("LBlock", LBlockInfo);
            classInfosByName.Add("LFixed", LFixedInfo);
            classInfosByName.Add("LRange", LRangeInfo);
            classInfosByName.Add("LReference", LReferenceInfo);
            classInfosByName.Add("LSet", LSetInfo);
            classInfosByName.Add("LSetItem", LSetItemInfo);
            classInfosByName.Add("LSetChar", LSetCharInfo);
            classInfosByName.Add("LSetRange", LSetRangeInfo);
            classInfosByName.Add("LWildCard", LWildCardInfo);
            classInfosByName.Add("Namespace", NamespaceInfo);
            classInfosByName.Add("Rule", RuleInfo);
            classInfosByName.Add("RuleRef", RuleRefInfo);
            classInfosByName.Add("SeparatedList", SeparatedListInfo);
            classInfosByName.Add("Token", TokenInfo);
            classInfosByName.Add("TokenAlts", TokenAltsInfo);
            classInfosByName.Add("TokenKind", TokenKindInfo);
            _classInfosByName = classInfosByName.ToImmutable();
            _model = new __Model();
            var f = new __MetaModelFactory(_model);
            var obj1 = f.MetaNamespace();
            var obj2 = f.MetaNamespace();
            var obj3 = f.MetaNamespace();
            var obj4 = f.MetaNamespace();
            var obj5 = f.MetaModel();
            var obj6 = f.MetaClass();
            var obj7 = f.MetaClass();
            var obj8 = f.MetaClass();
            var obj9 = f.MetaClass();
            var obj10 = f.MetaClass();
            var obj11 = f.MetaClass();
            var obj12 = f.MetaClass();
            var obj13 = f.MetaClass();
            var obj14 = f.MetaClass();
            var obj15 = f.MetaClass();
            var obj16 = f.MetaEnum();
            var obj17 = f.MetaClass();
            var obj18 = f.MetaClass();
            var obj19 = f.MetaClass();
            var obj20 = f.MetaClass();
            var obj21 = f.MetaClass();
            var obj22 = f.MetaClass();
            var obj23 = f.MetaClass();
            var obj24 = f.MetaClass();
            var obj25 = f.MetaClass();
            var obj26 = f.MetaClass();
            var obj27 = f.MetaClass();
            var obj28 = f.MetaClass();
            var obj29 = f.MetaClass();
            var obj30 = f.MetaClass();
            var obj31 = f.MetaClass();
            var obj32 = f.MetaClass();
            var obj33 = f.MetaClass();
            var obj34 = f.MetaClass();
            var obj35 = f.MetaEnum();
            var obj36 = f.MetaClass();
            var obj37 = f.MetaClass();
            var obj38 = f.MetaClass();
            var obj39 = f.MetaClass();
            var obj40 = f.MetaClass();
            var obj41 = f.MetaClass();
            var obj42 = f.MetaClass();
            var obj43 = f.MetaClass();
            var obj44 = f.MetaClass();
            var obj45 = f.MetaClass();
            var obj46 = f.MetaProperty();
            var obj47 = f.MetaProperty();
            var obj48 = f.MetaProperty();
            var obj49 = f.MetaProperty();
            var obj50 = f.MetaNullableType();
            var obj51 = f.MetaNullableType();
            var obj52 = f.MetaArrayType();
            var obj53 = f.MetaNullableType();
            var obj54 = f.MetaProperty();
            var obj55 = f.MetaProperty();
            var obj56 = f.MetaProperty();
            var obj57 = f.MetaProperty();
            var obj58 = f.MetaProperty();
            var obj59 = f.MetaProperty();
            var obj60 = f.MetaProperty();
            var obj61 = f.MetaProperty();
            var obj62 = f.MetaProperty();
            var obj63 = f.MetaProperty();
            var obj64 = f.MetaProperty();
            var obj65 = f.MetaProperty();
            var obj66 = f.MetaProperty();
            var obj67 = f.MetaArrayType();
            var obj68 = f.MetaArrayType();
            var obj69 = f.MetaArrayType();
            var obj70 = f.MetaArrayType();
            var obj71 = f.MetaArrayType();
            var obj72 = f.MetaNullableType();
            var obj73 = f.MetaNullableType();
            var obj74 = f.MetaNullableType();
            var obj75 = f.MetaNullableType();
            var obj76 = f.MetaNullableType();
            var obj77 = f.MetaProperty();
            var obj78 = f.MetaProperty();
            var obj79 = f.MetaArrayType();
            var obj80 = f.MetaProperty();
            var obj81 = f.MetaProperty();
            var obj82 = f.MetaProperty();
            var obj83 = f.MetaProperty();
            var obj84 = f.MetaArrayType();
            var obj85 = f.MetaProperty();
            var obj86 = f.MetaProperty();
            var obj87 = f.MetaProperty();
            var obj88 = f.MetaProperty();
            var obj89 = f.MetaArrayType();
            var obj90 = f.MetaProperty();
            var obj91 = f.MetaProperty();
            var obj92 = f.MetaProperty();
            var obj93 = f.MetaProperty();
            var obj94 = f.MetaArrayType();
            var obj95 = f.MetaNullableType();
            var obj96 = f.MetaProperty();
            var obj97 = f.MetaProperty();
            var obj98 = f.MetaProperty();
            var obj99 = f.MetaProperty();
            var obj100 = f.MetaProperty();
            var obj101 = f.MetaArrayType();
            var obj102 = f.MetaArrayType();
            var obj103 = f.MetaProperty();
            var obj104 = f.MetaProperty();
            var obj105 = f.MetaEnumLiteral();
            var obj106 = f.MetaEnumLiteral();
            var obj107 = f.MetaEnumLiteral();
            var obj108 = f.MetaEnumLiteral();
            var obj109 = f.MetaEnumLiteral();
            var obj110 = f.MetaEnumLiteral();
            var obj111 = f.MetaEnumLiteral();
            var obj112 = f.MetaProperty();
            var obj113 = f.MetaProperty();
            var obj114 = f.MetaProperty();
            var obj115 = f.MetaProperty();
            var obj116 = f.MetaProperty();
            var obj117 = f.MetaArrayType();
            var obj118 = f.MetaNullableType();
            var obj119 = f.MetaProperty();
            var obj120 = f.MetaProperty();
            var obj121 = f.MetaProperty();
            var obj122 = f.MetaNullableType();
            var obj123 = f.MetaProperty();
            var obj124 = f.MetaProperty();
            var obj125 = f.MetaProperty();
            var obj126 = f.MetaNullableType();
            var obj127 = f.MetaArrayType();
            var obj128 = f.MetaProperty();
            var obj129 = f.MetaProperty();
            var obj130 = f.MetaProperty();
            var obj131 = f.MetaProperty();
            var obj132 = f.MetaProperty();
            var obj133 = f.MetaNullableType();
            var obj134 = f.MetaProperty();
            var obj135 = f.MetaProperty();
            var obj136 = f.MetaNullableType();
            var obj137 = f.MetaProperty();
            var obj138 = f.MetaProperty();
            var obj139 = f.MetaProperty();
            var obj140 = f.MetaNullableType();
            var obj141 = f.MetaProperty();
            var obj142 = f.MetaProperty();
            var obj143 = f.MetaProperty();
            var obj144 = f.MetaNullableType();
            var obj145 = f.MetaProperty();
            var obj146 = f.MetaProperty();
            var obj147 = f.MetaNullableType();
            var obj148 = f.MetaProperty();
            var obj149 = f.MetaProperty();
            var obj150 = f.MetaProperty();
            var obj151 = f.MetaProperty();
            var obj152 = f.MetaNullableType();
            var obj153 = f.MetaProperty();
            var obj154 = f.MetaProperty();
            var obj155 = f.MetaProperty();
            var obj156 = f.MetaNullableType();
            var obj157 = f.MetaArrayType();
            var obj158 = f.MetaProperty();
            var obj159 = f.MetaProperty();
            var obj160 = f.MetaNullableType();
            var obj161 = f.MetaProperty();
            var obj162 = f.MetaProperty();
            var obj163 = f.MetaProperty();
            var obj164 = f.MetaNullableType();
            var obj165 = f.MetaProperty();
            var obj166 = f.MetaProperty();
            var obj167 = f.MetaProperty();
            var obj168 = f.MetaProperty();
            var obj169 = f.MetaNullableType();
            var obj170 = f.MetaProperty();
            var obj171 = f.MetaProperty();
            var obj172 = f.MetaProperty();
            var obj173 = f.MetaNullableType();
            var obj174 = f.MetaArrayType();
            var obj175 = f.MetaProperty();
            var obj176 = f.MetaProperty();
            var obj177 = f.MetaProperty();
            var obj178 = f.MetaProperty();
            var obj179 = f.MetaProperty();
            var obj180 = f.MetaArrayType();
            var obj181 = f.MetaNullableType();
            var obj182 = f.MetaProperty();
            var obj183 = f.MetaProperty();
            var obj184 = f.MetaProperty();
            var obj185 = f.MetaProperty();
            var obj186 = f.MetaProperty();
            var obj187 = f.MetaProperty();
            var obj188 = f.MetaProperty();
            var obj189 = f.MetaProperty();
            var obj190 = f.MetaProperty();
            var obj191 = f.MetaProperty();
            var obj192 = f.MetaProperty();
            var obj193 = f.MetaProperty();
            var obj194 = f.MetaProperty();
            var obj195 = f.MetaProperty();
            var obj196 = f.MetaProperty();
            var obj197 = f.MetaArrayType();
            var obj198 = f.MetaEnumLiteral();
            var obj199 = f.MetaEnumLiteral();
            var obj200 = f.MetaEnumLiteral();
            var obj201 = f.MetaEnumLiteral();
            var obj202 = f.MetaProperty();
            var obj203 = f.MetaProperty();
            var obj204 = f.MetaProperty();
            var obj205 = f.MetaProperty();
            var obj206 = f.MetaProperty();
            var obj207 = f.MetaProperty();
            var obj208 = f.MetaProperty();
            var obj209 = f.MetaProperty();
            var obj210 = f.MetaProperty();
            var obj211 = f.MetaProperty();
            var obj212 = f.MetaProperty();
            var obj213 = f.MetaProperty();
            var obj214 = f.MetaProperty();
            var obj215 = f.MetaProperty();
            var obj216 = f.MetaProperty();
            var obj217 = f.MetaProperty();
            var obj218 = f.MetaProperty();
            var obj219 = f.MetaProperty();
            var obj220 = f.MetaProperty();
            var obj221 = f.MetaProperty();
            var obj222 = f.MetaProperty();
            var obj223 = f.MetaProperty();
            var obj224 = f.MetaProperty();
            var obj225 = f.MetaProperty();
            var obj226 = f.MetaNullableType();
            var obj227 = f.MetaNullableType();
            var obj228 = f.MetaNullableType();
            var obj229 = f.MetaNullableType();
            var obj230 = f.MetaNullableType();
            var obj231 = f.MetaNullableType();
            var obj232 = f.MetaProperty();
            var obj233 = f.MetaProperty();
            var obj234 = f.MetaProperty();
            var obj235 = f.MetaProperty();
            var obj236 = f.MetaNullableType();
            var obj237 = f.MetaProperty();
            var obj238 = f.MetaProperty();
            var obj239 = f.MetaProperty();
            var obj240 = f.MetaProperty();
            var obj241 = f.MetaProperty();
            var obj242 = f.MetaProperty();
            var obj243 = f.MetaProperty();
            var obj244 = f.MetaArrayType();
            var obj245 = f.MetaNullableType();
            var obj246 = f.MetaNullableType();
            var obj247 = f.MetaNullableType();
            var obj248 = f.MetaProperty();
            var obj249 = f.MetaProperty();
            var obj250 = f.MetaProperty();
            var obj251 = f.MetaNullableType();
            var obj252 = f.MetaProperty();
            var obj253 = f.MetaProperty();
            var obj254 = f.MetaProperty();
            var obj255 = f.MetaProperty();
            var obj256 = f.MetaProperty();
            var obj257 = f.MetaArrayType();
            var obj258 = f.MetaNullableType();
            var obj259 = f.MetaProperty();
            var obj260 = f.MetaProperty();
            var obj261 = f.MetaProperty();
            var obj262 = f.MetaProperty();
            var obj263 = f.MetaProperty();
            var obj264 = f.MetaProperty();
            var obj265 = f.MetaArrayType();
            var obj266 = f.MetaNullableType();
            var obj267 = f.MetaProperty();
            var obj268 = f.MetaProperty();
            var obj269 = f.MetaProperty();
            var obj270 = f.MetaProperty();
            var obj271 = f.MetaProperty();
            var obj272 = f.MetaProperty();
            var obj273 = f.MetaProperty();
            var obj274 = f.MetaProperty();
            var obj275 = f.MetaProperty();
            var obj276 = f.MetaProperty();
            var obj277 = f.MetaProperty();
            var obj278 = f.MetaProperty();
            var obj279 = f.MetaArrayType();
            var obj280 = f.MetaArrayType();
            var obj281 = f.MetaArrayType();
            var obj282 = f.MetaArrayType();
            var obj283 = f.MetaNullableType();
            var obj284 = f.MetaProperty();
            var obj285 = f.MetaProperty();
            var obj286 = f.MetaArrayType();
            __CustomImpl.Compiler(this);
            ((__IModelObject)obj1).MChildren.Add((__IModelObject)obj2);
            obj1.Declarations.Add(obj2);
            obj1.Name = "MetaDslx";
            ((__IModelObject)obj2).MChildren.Add((__IModelObject)obj3);
            obj2.Declarations.Add(obj3);
            obj2.Name = "Bootstrap";
            obj2.Parent = obj1;
            ((__IModelObject)obj3).MChildren.Add((__IModelObject)obj4);
            obj3.Declarations.Add(obj4);
            obj3.Name = "MetaCompiler";
            obj3.Parent = obj2;
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj5);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj6);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj7);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj8);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj9);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj10);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj11);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj12);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj13);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj14);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj15);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj16);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj17);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj18);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj19);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj20);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj21);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj22);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj23);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj24);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj25);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj26);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj27);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj28);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj29);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj30);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj31);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj32);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj33);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj34);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj35);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj36);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj37);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj38);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj39);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj40);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj41);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj42);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj43);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj44);
            ((__IModelObject)obj4).MChildren.Add((__IModelObject)obj45);
            obj4.Declarations.Add(obj5);
            obj4.Declarations.Add(obj6);
            obj4.Declarations.Add(obj7);
            obj4.Declarations.Add(obj8);
            obj4.Declarations.Add(obj9);
            obj4.Declarations.Add(obj10);
            obj4.Declarations.Add(obj11);
            obj4.Declarations.Add(obj12);
            obj4.Declarations.Add(obj13);
            obj4.Declarations.Add(obj14);
            obj4.Declarations.Add(obj15);
            obj4.Declarations.Add(obj16);
            obj4.Declarations.Add(obj17);
            obj4.Declarations.Add(obj18);
            obj4.Declarations.Add(obj19);
            obj4.Declarations.Add(obj20);
            obj4.Declarations.Add(obj21);
            obj4.Declarations.Add(obj22);
            obj4.Declarations.Add(obj23);
            obj4.Declarations.Add(obj24);
            obj4.Declarations.Add(obj25);
            obj4.Declarations.Add(obj26);
            obj4.Declarations.Add(obj27);
            obj4.Declarations.Add(obj28);
            obj4.Declarations.Add(obj29);
            obj4.Declarations.Add(obj30);
            obj4.Declarations.Add(obj31);
            obj4.Declarations.Add(obj32);
            obj4.Declarations.Add(obj33);
            obj4.Declarations.Add(obj34);
            obj4.Declarations.Add(obj35);
            obj4.Declarations.Add(obj36);
            obj4.Declarations.Add(obj37);
            obj4.Declarations.Add(obj38);
            obj4.Declarations.Add(obj39);
            obj4.Declarations.Add(obj40);
            obj4.Declarations.Add(obj41);
            obj4.Declarations.Add(obj42);
            obj4.Declarations.Add(obj43);
            obj4.Declarations.Add(obj44);
            obj4.Declarations.Add(obj45);
            obj4.Name = "Model";
            obj4.Parent = obj3;
            obj5.Name = "Compiler";
            obj5.Parent = obj4;
            ((__IModelObject)obj6).MChildren.Add((__IModelObject)obj46);
            ((__IModelObject)obj6).MChildren.Add((__IModelObject)obj47);
            ((__IModelObject)obj6).MChildren.Add((__IModelObject)obj48);
            ((__IModelObject)obj6).MChildren.Add((__IModelObject)obj49);
            obj6.IsAbstract = true;
            obj6.Properties.Add(obj46);
            obj6.Properties.Add(obj47);
            obj6.Properties.Add(obj48);
            obj6.Properties.Add(obj49);
            obj6.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            obj6.Declarations.Add(obj46);
            obj6.Declarations.Add(obj47);
            obj6.Declarations.Add(obj48);
            obj6.Declarations.Add(obj49);
            obj6.Name = "Declaration";
            obj6.Parent = obj4;
            obj7.BaseTypes.Add(obj6);
            obj7.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
            obj7.Name = "Namespace";
            obj7.Parent = obj4;
            ((__IModelObject)obj8).MChildren.Add((__IModelObject)obj54);
            ((__IModelObject)obj8).MChildren.Add((__IModelObject)obj55);
            obj8.BaseTypes.Add(obj6);
            obj8.Properties.Add(obj54);
            obj8.Properties.Add(obj55);
            obj8.Declarations.Add(obj54);
            obj8.Declarations.Add(obj55);
            obj8.Name = "Language";
            obj8.Parent = obj4;
            ((__IModelObject)obj9).MChildren.Add((__IModelObject)obj56);
            ((__IModelObject)obj9).MChildren.Add((__IModelObject)obj57);
            ((__IModelObject)obj9).MChildren.Add((__IModelObject)obj58);
            ((__IModelObject)obj9).MChildren.Add((__IModelObject)obj59);
            ((__IModelObject)obj9).MChildren.Add((__IModelObject)obj60);
            ((__IModelObject)obj9).MChildren.Add((__IModelObject)obj61);
            ((__IModelObject)obj9).MChildren.Add((__IModelObject)obj62);
            ((__IModelObject)obj9).MChildren.Add((__IModelObject)obj63);
            ((__IModelObject)obj9).MChildren.Add((__IModelObject)obj64);
            ((__IModelObject)obj9).MChildren.Add((__IModelObject)obj65);
            ((__IModelObject)obj9).MChildren.Add((__IModelObject)obj66);
            obj9.BaseTypes.Add(obj6);
            obj9.Properties.Add(obj56);
            obj9.Properties.Add(obj57);
            obj9.Properties.Add(obj58);
            obj9.Properties.Add(obj59);
            obj9.Properties.Add(obj60);
            obj9.Properties.Add(obj61);
            obj9.Properties.Add(obj62);
            obj9.Properties.Add(obj63);
            obj9.Properties.Add(obj64);
            obj9.Properties.Add(obj65);
            obj9.Properties.Add(obj66);
            obj9.Declarations.Add(obj56);
            obj9.Declarations.Add(obj57);
            obj9.Declarations.Add(obj58);
            obj9.Declarations.Add(obj59);
            obj9.Declarations.Add(obj60);
            obj9.Declarations.Add(obj61);
            obj9.Declarations.Add(obj62);
            obj9.Declarations.Add(obj63);
            obj9.Declarations.Add(obj64);
            obj9.Declarations.Add(obj65);
            obj9.Declarations.Add(obj66);
            obj9.Name = "Grammar";
            obj9.Parent = obj4;
            ((__IModelObject)obj10).MChildren.Add((__IModelObject)obj77);
            ((__IModelObject)obj10).MChildren.Add((__IModelObject)obj78);
            obj10.Properties.Add(obj77);
            obj10.Properties.Add(obj78);
            obj10.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.AnnotationSymbol);
            obj10.Declarations.Add(obj77);
            obj10.Declarations.Add(obj78);
            obj10.Name = "Annotation";
            obj10.Parent = obj4;
            ((__IModelObject)obj11).MChildren.Add((__IModelObject)obj80);
            ((__IModelObject)obj11).MChildren.Add((__IModelObject)obj81);
            ((__IModelObject)obj11).MChildren.Add((__IModelObject)obj82);
            ((__IModelObject)obj11).MChildren.Add((__IModelObject)obj83);
            obj11.Properties.Add(obj80);
            obj11.Properties.Add(obj81);
            obj11.Properties.Add(obj82);
            obj11.Properties.Add(obj83);
            obj11.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.AnnotationArgumentSymbol);
            obj11.Declarations.Add(obj80);
            obj11.Declarations.Add(obj81);
            obj11.Declarations.Add(obj82);
            obj11.Declarations.Add(obj83);
            obj11.Name = "AnnotationArgument";
            obj11.Parent = obj4;
            ((__IModelObject)obj12).MChildren.Add((__IModelObject)obj85);
            ((__IModelObject)obj12).MChildren.Add((__IModelObject)obj86);
            ((__IModelObject)obj12).MChildren.Add((__IModelObject)obj87);
            ((__IModelObject)obj12).MChildren.Add((__IModelObject)obj88);
            obj12.Properties.Add(obj85);
            obj12.Properties.Add(obj86);
            obj12.Properties.Add(obj87);
            obj12.Properties.Add(obj88);
            obj12.Declarations.Add(obj85);
            obj12.Declarations.Add(obj86);
            obj12.Declarations.Add(obj87);
            obj12.Declarations.Add(obj88);
            obj12.Name = "Binder";
            obj12.Parent = obj4;
            ((__IModelObject)obj13).MChildren.Add((__IModelObject)obj90);
            ((__IModelObject)obj13).MChildren.Add((__IModelObject)obj91);
            ((__IModelObject)obj13).MChildren.Add((__IModelObject)obj92);
            ((__IModelObject)obj13).MChildren.Add((__IModelObject)obj93);
            obj13.Properties.Add(obj90);
            obj13.Properties.Add(obj91);
            obj13.Properties.Add(obj92);
            obj13.Properties.Add(obj93);
            obj13.Declarations.Add(obj90);
            obj13.Declarations.Add(obj91);
            obj13.Declarations.Add(obj92);
            obj13.Declarations.Add(obj93);
            obj13.Name = "BinderArgument";
            obj13.Parent = obj4;
            ((__IModelObject)obj14).MChildren.Add((__IModelObject)obj96);
            ((__IModelObject)obj14).MChildren.Add((__IModelObject)obj97);
            ((__IModelObject)obj14).MChildren.Add((__IModelObject)obj98);
            ((__IModelObject)obj14).MChildren.Add((__IModelObject)obj99);
            ((__IModelObject)obj14).MChildren.Add((__IModelObject)obj100);
            obj14.Properties.Add(obj96);
            obj14.Properties.Add(obj97);
            obj14.Properties.Add(obj98);
            obj14.Properties.Add(obj99);
            obj14.Properties.Add(obj100);
            obj14.Declarations.Add(obj96);
            obj14.Declarations.Add(obj97);
            obj14.Declarations.Add(obj98);
            obj14.Declarations.Add(obj99);
            obj14.Declarations.Add(obj100);
            obj14.Name = "CSharpElement";
            obj14.Parent = obj4;
            ((__IModelObject)obj15).MChildren.Add((__IModelObject)obj103);
            ((__IModelObject)obj15).MChildren.Add((__IModelObject)obj104);
            obj15.Properties.Add(obj103);
            obj15.Properties.Add(obj104);
            obj15.Declarations.Add(obj103);
            obj15.Declarations.Add(obj104);
            obj15.Name = "TokenKind";
            obj15.Parent = obj4;
            ((__IModelObject)obj16).MChildren.Add((__IModelObject)obj105);
            ((__IModelObject)obj16).MChildren.Add((__IModelObject)obj106);
            ((__IModelObject)obj16).MChildren.Add((__IModelObject)obj107);
            ((__IModelObject)obj16).MChildren.Add((__IModelObject)obj108);
            ((__IModelObject)obj16).MChildren.Add((__IModelObject)obj109);
            ((__IModelObject)obj16).MChildren.Add((__IModelObject)obj110);
            ((__IModelObject)obj16).MChildren.Add((__IModelObject)obj111);
            obj16.Literals.Add(obj105);
            obj16.Literals.Add(obj106);
            obj16.Literals.Add(obj107);
            obj16.Literals.Add(obj108);
            obj16.Literals.Add(obj109);
            obj16.Literals.Add(obj110);
            obj16.Literals.Add(obj111);
            obj16.Declarations.Add(obj105);
            obj16.Declarations.Add(obj106);
            obj16.Declarations.Add(obj107);
            obj16.Declarations.Add(obj108);
            obj16.Declarations.Add(obj109);
            obj16.Declarations.Add(obj110);
            obj16.Declarations.Add(obj111);
            obj16.Name = "Multiplicity";
            obj16.Parent = obj4;
            ((__IModelObject)obj17).MChildren.Add((__IModelObject)obj112);
            ((__IModelObject)obj17).MChildren.Add((__IModelObject)obj113);
            obj17.BaseTypes.Add(obj6);
            obj17.BaseTypes.Add(obj14);
            obj17.IsAbstract = true;
            obj17.Properties.Add(obj112);
            obj17.Properties.Add(obj113);
            obj17.Declarations.Add(obj112);
            obj17.Declarations.Add(obj113);
            obj17.Name = "GrammarRule";
            obj17.Parent = obj4;
            ((__IModelObject)obj18).MChildren.Add((__IModelObject)obj114);
            ((__IModelObject)obj18).MChildren.Add((__IModelObject)obj115);
            ((__IModelObject)obj18).MChildren.Add((__IModelObject)obj116);
            obj18.BaseTypes.Add(obj17);
            obj18.IsAbstract = true;
            obj18.Properties.Add(obj114);
            obj18.Properties.Add(obj115);
            obj18.Properties.Add(obj116);
            obj18.Declarations.Add(obj114);
            obj18.Declarations.Add(obj115);
            obj18.Declarations.Add(obj116);
            obj18.Name = "LexerRule";
            obj18.Parent = obj4;
            ((__IModelObject)obj19).MChildren.Add((__IModelObject)obj119);
            ((__IModelObject)obj19).MChildren.Add((__IModelObject)obj120);
            ((__IModelObject)obj19).MChildren.Add((__IModelObject)obj121);
            obj19.BaseTypes.Add(obj18);
            obj19.Properties.Add(obj119);
            obj19.Properties.Add(obj120);
            obj19.Properties.Add(obj121);
            obj19.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.TokenSymbol);
            obj19.Declarations.Add(obj119);
            obj19.Declarations.Add(obj120);
            obj19.Declarations.Add(obj121);
            obj19.Name = "Token";
            obj19.Parent = obj4;
            obj20.BaseTypes.Add(obj18);
            obj20.Name = "Fragment";
            obj20.Parent = obj4;
            ((__IModelObject)obj21).MChildren.Add((__IModelObject)obj123);
            ((__IModelObject)obj21).MChildren.Add((__IModelObject)obj124);
            ((__IModelObject)obj21).MChildren.Add((__IModelObject)obj125);
            obj21.Properties.Add(obj123);
            obj21.Properties.Add(obj124);
            obj21.Properties.Add(obj125);
            obj21.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            obj21.Declarations.Add(obj123);
            obj21.Declarations.Add(obj124);
            obj21.Declarations.Add(obj125);
            obj21.Name = "LAlternative";
            obj21.Parent = obj4;
            ((__IModelObject)obj22).MChildren.Add((__IModelObject)obj128);
            ((__IModelObject)obj22).MChildren.Add((__IModelObject)obj129);
            ((__IModelObject)obj22).MChildren.Add((__IModelObject)obj130);
            ((__IModelObject)obj22).MChildren.Add((__IModelObject)obj131);
            ((__IModelObject)obj22).MChildren.Add((__IModelObject)obj132);
            obj22.Properties.Add(obj128);
            obj22.Properties.Add(obj129);
            obj22.Properties.Add(obj130);
            obj22.Properties.Add(obj131);
            obj22.Properties.Add(obj132);
            obj22.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            obj22.Declarations.Add(obj128);
            obj22.Declarations.Add(obj129);
            obj22.Declarations.Add(obj130);
            obj22.Declarations.Add(obj131);
            obj22.Declarations.Add(obj132);
            obj22.Name = "LElement";
            obj22.Parent = obj4;
            ((__IModelObject)obj23).MChildren.Add((__IModelObject)obj134);
            ((__IModelObject)obj23).MChildren.Add((__IModelObject)obj135);
            obj23.IsAbstract = true;
            obj23.Properties.Add(obj134);
            obj23.Properties.Add(obj135);
            obj23.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            obj23.Declarations.Add(obj134);
            obj23.Declarations.Add(obj135);
            obj23.Name = "LElementValue";
            obj23.Parent = obj4;
            ((__IModelObject)obj24).MChildren.Add((__IModelObject)obj137);
            ((__IModelObject)obj24).MChildren.Add((__IModelObject)obj138);
            ((__IModelObject)obj24).MChildren.Add((__IModelObject)obj139);
            obj24.BaseTypes.Add(obj23);
            obj24.Properties.Add(obj137);
            obj24.Properties.Add(obj138);
            obj24.Properties.Add(obj139);
            obj24.Declarations.Add(obj137);
            obj24.Declarations.Add(obj138);
            obj24.Declarations.Add(obj139);
            obj24.Name = "LReference";
            obj24.Parent = obj4;
            ((__IModelObject)obj25).MChildren.Add((__IModelObject)obj141);
            ((__IModelObject)obj25).MChildren.Add((__IModelObject)obj142);
            ((__IModelObject)obj25).MChildren.Add((__IModelObject)obj143);
            obj25.BaseTypes.Add(obj23);
            obj25.Properties.Add(obj141);
            obj25.Properties.Add(obj142);
            obj25.Properties.Add(obj143);
            obj25.Declarations.Add(obj141);
            obj25.Declarations.Add(obj142);
            obj25.Declarations.Add(obj143);
            obj25.Name = "LFixed";
            obj25.Parent = obj4;
            ((__IModelObject)obj26).MChildren.Add((__IModelObject)obj145);
            ((__IModelObject)obj26).MChildren.Add((__IModelObject)obj146);
            obj26.BaseTypes.Add(obj23);
            obj26.Properties.Add(obj145);
            obj26.Properties.Add(obj146);
            obj26.Declarations.Add(obj145);
            obj26.Declarations.Add(obj146);
            obj26.Name = "LWildCard";
            obj26.Parent = obj4;
            ((__IModelObject)obj27).MChildren.Add((__IModelObject)obj148);
            ((__IModelObject)obj27).MChildren.Add((__IModelObject)obj149);
            ((__IModelObject)obj27).MChildren.Add((__IModelObject)obj150);
            ((__IModelObject)obj27).MChildren.Add((__IModelObject)obj151);
            obj27.BaseTypes.Add(obj23);
            obj27.Properties.Add(obj148);
            obj27.Properties.Add(obj149);
            obj27.Properties.Add(obj150);
            obj27.Properties.Add(obj151);
            obj27.Declarations.Add(obj148);
            obj27.Declarations.Add(obj149);
            obj27.Declarations.Add(obj150);
            obj27.Declarations.Add(obj151);
            obj27.Name = "LRange";
            obj27.Parent = obj4;
            ((__IModelObject)obj28).MChildren.Add((__IModelObject)obj153);
            ((__IModelObject)obj28).MChildren.Add((__IModelObject)obj154);
            ((__IModelObject)obj28).MChildren.Add((__IModelObject)obj155);
            obj28.BaseTypes.Add(obj23);
            obj28.Properties.Add(obj153);
            obj28.Properties.Add(obj154);
            obj28.Properties.Add(obj155);
            obj28.Declarations.Add(obj153);
            obj28.Declarations.Add(obj154);
            obj28.Declarations.Add(obj155);
            obj28.Name = "LSet";
            obj28.Parent = obj4;
            ((__IModelObject)obj29).MChildren.Add((__IModelObject)obj158);
            ((__IModelObject)obj29).MChildren.Add((__IModelObject)obj159);
            obj29.IsAbstract = true;
            obj29.Properties.Add(obj158);
            obj29.Properties.Add(obj159);
            obj29.Declarations.Add(obj158);
            obj29.Declarations.Add(obj159);
            obj29.Name = "LSetItem";
            obj29.Parent = obj4;
            ((__IModelObject)obj30).MChildren.Add((__IModelObject)obj161);
            ((__IModelObject)obj30).MChildren.Add((__IModelObject)obj162);
            ((__IModelObject)obj30).MChildren.Add((__IModelObject)obj163);
            obj30.BaseTypes.Add(obj29);
            obj30.Properties.Add(obj161);
            obj30.Properties.Add(obj162);
            obj30.Properties.Add(obj163);
            obj30.Declarations.Add(obj161);
            obj30.Declarations.Add(obj162);
            obj30.Declarations.Add(obj163);
            obj30.Name = "LSetChar";
            obj30.Parent = obj4;
            ((__IModelObject)obj31).MChildren.Add((__IModelObject)obj165);
            ((__IModelObject)obj31).MChildren.Add((__IModelObject)obj166);
            ((__IModelObject)obj31).MChildren.Add((__IModelObject)obj167);
            ((__IModelObject)obj31).MChildren.Add((__IModelObject)obj168);
            obj31.BaseTypes.Add(obj29);
            obj31.Properties.Add(obj165);
            obj31.Properties.Add(obj166);
            obj31.Properties.Add(obj167);
            obj31.Properties.Add(obj168);
            obj31.Declarations.Add(obj165);
            obj31.Declarations.Add(obj166);
            obj31.Declarations.Add(obj167);
            obj31.Declarations.Add(obj168);
            obj31.Name = "LSetRange";
            obj31.Parent = obj4;
            ((__IModelObject)obj32).MChildren.Add((__IModelObject)obj170);
            ((__IModelObject)obj32).MChildren.Add((__IModelObject)obj171);
            ((__IModelObject)obj32).MChildren.Add((__IModelObject)obj172);
            obj32.BaseTypes.Add(obj23);
            obj32.Properties.Add(obj170);
            obj32.Properties.Add(obj171);
            obj32.Properties.Add(obj172);
            obj32.Declarations.Add(obj170);
            obj32.Declarations.Add(obj171);
            obj32.Declarations.Add(obj172);
            obj32.Name = "LBlock";
            obj32.Parent = obj4;
            ((__IModelObject)obj33).MChildren.Add((__IModelObject)obj175);
            ((__IModelObject)obj33).MChildren.Add((__IModelObject)obj176);
            ((__IModelObject)obj33).MChildren.Add((__IModelObject)obj177);
            ((__IModelObject)obj33).MChildren.Add((__IModelObject)obj178);
            ((__IModelObject)obj33).MChildren.Add((__IModelObject)obj179);
            obj33.BaseTypes.Add(obj17);
            obj33.Properties.Add(obj175);
            obj33.Properties.Add(obj176);
            obj33.Properties.Add(obj177);
            obj33.Properties.Add(obj178);
            obj33.Properties.Add(obj179);
            obj33.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ParserRuleSymbol);
            obj33.Declarations.Add(obj175);
            obj33.Declarations.Add(obj176);
            obj33.Declarations.Add(obj177);
            obj33.Declarations.Add(obj178);
            obj33.Declarations.Add(obj179);
            obj33.Name = "Rule";
            obj33.Parent = obj4;
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj182);
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj183);
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj184);
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj185);
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj186);
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj187);
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj188);
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj189);
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj190);
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj191);
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj192);
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj193);
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj194);
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj195);
            ((__IModelObject)obj34).MChildren.Add((__IModelObject)obj196);
            obj34.BaseTypes.Add(obj6);
            obj34.BaseTypes.Add(obj14);
            obj34.Properties.Add(obj182);
            obj34.Properties.Add(obj183);
            obj34.Properties.Add(obj184);
            obj34.Properties.Add(obj185);
            obj34.Properties.Add(obj186);
            obj34.Properties.Add(obj187);
            obj34.Properties.Add(obj188);
            obj34.Properties.Add(obj189);
            obj34.Properties.Add(obj190);
            obj34.Properties.Add(obj191);
            obj34.Properties.Add(obj192);
            obj34.Properties.Add(obj193);
            obj34.Properties.Add(obj194);
            obj34.Properties.Add(obj195);
            obj34.Properties.Add(obj196);
            obj34.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PAlternativeSymbol);
            obj34.Declarations.Add(obj182);
            obj34.Declarations.Add(obj183);
            obj34.Declarations.Add(obj184);
            obj34.Declarations.Add(obj185);
            obj34.Declarations.Add(obj186);
            obj34.Declarations.Add(obj187);
            obj34.Declarations.Add(obj188);
            obj34.Declarations.Add(obj189);
            obj34.Declarations.Add(obj190);
            obj34.Declarations.Add(obj191);
            obj34.Declarations.Add(obj192);
            obj34.Declarations.Add(obj193);
            obj34.Declarations.Add(obj194);
            obj34.Declarations.Add(obj195);
            obj34.Declarations.Add(obj196);
            obj34.Name = "Alternative";
            obj34.Parent = obj4;
            ((__IModelObject)obj35).MChildren.Add((__IModelObject)obj198);
            ((__IModelObject)obj35).MChildren.Add((__IModelObject)obj199);
            ((__IModelObject)obj35).MChildren.Add((__IModelObject)obj200);
            ((__IModelObject)obj35).MChildren.Add((__IModelObject)obj201);
            obj35.Literals.Add(obj198);
            obj35.Literals.Add(obj199);
            obj35.Literals.Add(obj200);
            obj35.Literals.Add(obj201);
            obj35.Declarations.Add(obj198);
            obj35.Declarations.Add(obj199);
            obj35.Declarations.Add(obj200);
            obj35.Declarations.Add(obj201);
            obj35.Name = "Assignment";
            obj35.Parent = obj4;
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj202);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj203);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj204);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj205);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj206);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj207);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj208);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj209);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj210);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj211);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj212);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj213);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj214);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj215);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj216);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj217);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj218);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj219);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj220);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj221);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj222);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj223);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj224);
            ((__IModelObject)obj36).MChildren.Add((__IModelObject)obj225);
            obj36.BaseTypes.Add(obj14);
            obj36.Properties.Add(obj202);
            obj36.Properties.Add(obj203);
            obj36.Properties.Add(obj204);
            obj36.Properties.Add(obj205);
            obj36.Properties.Add(obj206);
            obj36.Properties.Add(obj207);
            obj36.Properties.Add(obj208);
            obj36.Properties.Add(obj209);
            obj36.Properties.Add(obj210);
            obj36.Properties.Add(obj211);
            obj36.Properties.Add(obj212);
            obj36.Properties.Add(obj213);
            obj36.Properties.Add(obj214);
            obj36.Properties.Add(obj215);
            obj36.Properties.Add(obj216);
            obj36.Properties.Add(obj217);
            obj36.Properties.Add(obj218);
            obj36.Properties.Add(obj219);
            obj36.Properties.Add(obj220);
            obj36.Properties.Add(obj221);
            obj36.Properties.Add(obj222);
            obj36.Properties.Add(obj223);
            obj36.Properties.Add(obj224);
            obj36.Properties.Add(obj225);
            obj36.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PElementSymbol);
            obj36.Declarations.Add(obj202);
            obj36.Declarations.Add(obj203);
            obj36.Declarations.Add(obj204);
            obj36.Declarations.Add(obj205);
            obj36.Declarations.Add(obj206);
            obj36.Declarations.Add(obj207);
            obj36.Declarations.Add(obj208);
            obj36.Declarations.Add(obj209);
            obj36.Declarations.Add(obj210);
            obj36.Declarations.Add(obj211);
            obj36.Declarations.Add(obj212);
            obj36.Declarations.Add(obj213);
            obj36.Declarations.Add(obj214);
            obj36.Declarations.Add(obj215);
            obj36.Declarations.Add(obj216);
            obj36.Declarations.Add(obj217);
            obj36.Declarations.Add(obj218);
            obj36.Declarations.Add(obj219);
            obj36.Declarations.Add(obj220);
            obj36.Declarations.Add(obj221);
            obj36.Declarations.Add(obj222);
            obj36.Declarations.Add(obj223);
            obj36.Declarations.Add(obj224);
            obj36.Declarations.Add(obj225);
            obj36.Name = "Element";
            obj36.Parent = obj4;
            ((__IModelObject)obj37).MChildren.Add((__IModelObject)obj232);
            ((__IModelObject)obj37).MChildren.Add((__IModelObject)obj233);
            ((__IModelObject)obj37).MChildren.Add((__IModelObject)obj234);
            ((__IModelObject)obj37).MChildren.Add((__IModelObject)obj235);
            obj37.BaseTypes.Add(obj14);
            obj37.IsAbstract = true;
            obj37.Properties.Add(obj232);
            obj37.Properties.Add(obj233);
            obj37.Properties.Add(obj234);
            obj37.Properties.Add(obj235);
            obj37.SymbolType = typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            obj37.Declarations.Add(obj232);
            obj37.Declarations.Add(obj233);
            obj37.Declarations.Add(obj234);
            obj37.Declarations.Add(obj235);
            obj37.Name = "ElementValue";
            obj37.Parent = obj4;
            ((__IModelObject)obj38).MChildren.Add((__IModelObject)obj237);
            ((__IModelObject)obj38).MChildren.Add((__IModelObject)obj238);
            ((__IModelObject)obj38).MChildren.Add((__IModelObject)obj239);
            ((__IModelObject)obj38).MChildren.Add((__IModelObject)obj240);
            ((__IModelObject)obj38).MChildren.Add((__IModelObject)obj241);
            ((__IModelObject)obj38).MChildren.Add((__IModelObject)obj242);
            ((__IModelObject)obj38).MChildren.Add((__IModelObject)obj243);
            obj38.BaseTypes.Add(obj37);
            obj38.Properties.Add(obj237);
            obj38.Properties.Add(obj238);
            obj38.Properties.Add(obj239);
            obj38.Properties.Add(obj240);
            obj38.Properties.Add(obj241);
            obj38.Properties.Add(obj242);
            obj38.Properties.Add(obj243);
            obj38.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PReferenceSymbol);
            obj38.Declarations.Add(obj237);
            obj38.Declarations.Add(obj238);
            obj38.Declarations.Add(obj239);
            obj38.Declarations.Add(obj240);
            obj38.Declarations.Add(obj241);
            obj38.Declarations.Add(obj242);
            obj38.Declarations.Add(obj243);
            obj38.Name = "RuleRef";
            obj38.Parent = obj4;
            ((__IModelObject)obj39).MChildren.Add((__IModelObject)obj248);
            ((__IModelObject)obj39).MChildren.Add((__IModelObject)obj249);
            ((__IModelObject)obj39).MChildren.Add((__IModelObject)obj250);
            obj39.BaseTypes.Add(obj37);
            obj39.Properties.Add(obj248);
            obj39.Properties.Add(obj249);
            obj39.Properties.Add(obj250);
            obj39.Declarations.Add(obj248);
            obj39.Declarations.Add(obj249);
            obj39.Declarations.Add(obj250);
            obj39.Name = "Eof";
            obj39.Parent = obj4;
            ((__IModelObject)obj40).MChildren.Add((__IModelObject)obj252);
            obj40.BaseTypes.Add(obj37);
            obj40.Properties.Add(obj252);
            obj40.Declarations.Add(obj252);
            obj40.Name = "Fixed";
            obj40.Parent = obj4;
            ((__IModelObject)obj41).MChildren.Add((__IModelObject)obj253);
            ((__IModelObject)obj41).MChildren.Add((__IModelObject)obj254);
            ((__IModelObject)obj41).MChildren.Add((__IModelObject)obj255);
            ((__IModelObject)obj41).MChildren.Add((__IModelObject)obj256);
            obj41.BaseTypes.Add(obj37);
            obj41.Properties.Add(obj253);
            obj41.Properties.Add(obj254);
            obj41.Properties.Add(obj255);
            obj41.Properties.Add(obj256);
            obj41.Declarations.Add(obj253);
            obj41.Declarations.Add(obj254);
            obj41.Declarations.Add(obj255);
            obj41.Declarations.Add(obj256);
            obj41.Name = "TokenAlts";
            obj41.Parent = obj4;
            ((__IModelObject)obj42).MChildren.Add((__IModelObject)obj259);
            ((__IModelObject)obj42).MChildren.Add((__IModelObject)obj260);
            ((__IModelObject)obj42).MChildren.Add((__IModelObject)obj261);
            ((__IModelObject)obj42).MChildren.Add((__IModelObject)obj262);
            ((__IModelObject)obj42).MChildren.Add((__IModelObject)obj263);
            ((__IModelObject)obj42).MChildren.Add((__IModelObject)obj264);
            obj42.BaseTypes.Add(obj37);
            obj42.Properties.Add(obj259);
            obj42.Properties.Add(obj260);
            obj42.Properties.Add(obj261);
            obj42.Properties.Add(obj262);
            obj42.Properties.Add(obj263);
            obj42.Properties.Add(obj264);
            obj42.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PBlockSymbol);
            obj42.Declarations.Add(obj259);
            obj42.Declarations.Add(obj260);
            obj42.Declarations.Add(obj261);
            obj42.Declarations.Add(obj262);
            obj42.Declarations.Add(obj263);
            obj42.Declarations.Add(obj264);
            obj42.Name = "Block";
            obj42.Parent = obj4;
            ((__IModelObject)obj43).MChildren.Add((__IModelObject)obj267);
            ((__IModelObject)obj43).MChildren.Add((__IModelObject)obj268);
            ((__IModelObject)obj43).MChildren.Add((__IModelObject)obj269);
            ((__IModelObject)obj43).MChildren.Add((__IModelObject)obj270);
            ((__IModelObject)obj43).MChildren.Add((__IModelObject)obj271);
            ((__IModelObject)obj43).MChildren.Add((__IModelObject)obj272);
            ((__IModelObject)obj43).MChildren.Add((__IModelObject)obj273);
            ((__IModelObject)obj43).MChildren.Add((__IModelObject)obj274);
            ((__IModelObject)obj43).MChildren.Add((__IModelObject)obj275);
            ((__IModelObject)obj43).MChildren.Add((__IModelObject)obj276);
            ((__IModelObject)obj43).MChildren.Add((__IModelObject)obj277);
            ((__IModelObject)obj43).MChildren.Add((__IModelObject)obj278);
            obj43.BaseTypes.Add(obj37);
            obj43.Properties.Add(obj267);
            obj43.Properties.Add(obj268);
            obj43.Properties.Add(obj269);
            obj43.Properties.Add(obj270);
            obj43.Properties.Add(obj271);
            obj43.Properties.Add(obj272);
            obj43.Properties.Add(obj273);
            obj43.Properties.Add(obj274);
            obj43.Properties.Add(obj275);
            obj43.Properties.Add(obj276);
            obj43.Properties.Add(obj277);
            obj43.Properties.Add(obj278);
            obj43.Declarations.Add(obj267);
            obj43.Declarations.Add(obj268);
            obj43.Declarations.Add(obj269);
            obj43.Declarations.Add(obj270);
            obj43.Declarations.Add(obj271);
            obj43.Declarations.Add(obj272);
            obj43.Declarations.Add(obj273);
            obj43.Declarations.Add(obj274);
            obj43.Declarations.Add(obj275);
            obj43.Declarations.Add(obj276);
            obj43.Declarations.Add(obj277);
            obj43.Declarations.Add(obj278);
            obj43.Name = "SeparatedList";
            obj43.Parent = obj4;
            ((__IModelObject)obj44).MChildren.Add((__IModelObject)obj284);
            obj44.Properties.Add(obj284);
            obj44.SymbolType = typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ExpressionSymbol);
            obj44.Declarations.Add(obj284);
            obj44.Name = "Expression";
            obj44.Parent = obj4;
            ((__IModelObject)obj45).MChildren.Add((__IModelObject)obj285);
            obj45.BaseTypes.Add(obj44);
            obj45.Properties.Add(obj285);
            obj45.Declarations.Add(obj285);
            obj45.Name = "ArrayExpression";
            obj45.Parent = obj4;
            ((__IModelObject)obj46).MChildren.Add((__IModelObject)obj50);
            obj46.SymbolProperty = "Name";
            obj46.Type = __MetaType.FromModelObject((__IModelObject)obj50);
            obj46.Name = "Name";
            obj46.Parent = obj6;
            ((__IModelObject)obj47).MChildren.Add((__IModelObject)obj51);
            obj47.OppositeProperties.Add(obj48);
            obj47.Type = __MetaType.FromModelObject((__IModelObject)obj51);
            obj47.Name = "Parent";
            obj47.Parent = obj6;
            ((__IModelObject)obj48).MChildren.Add((__IModelObject)obj52);
            obj48.IsContainment = true;
            obj48.OppositeProperties.Add(obj47);
            obj48.Type = __MetaType.FromModelObject((__IModelObject)obj52);
            obj48.Name = "Declarations";
            obj48.Parent = obj6;
            ((__IModelObject)obj49).MChildren.Add((__IModelObject)obj53);
            obj49.IsDerived = true;
            obj49.Type = __MetaType.FromModelObject((__IModelObject)obj53);
            obj49.Name = "FullName";
            obj49.Parent = obj6;
            obj50.InnerType = typeof(global::System.String);
            obj51.InnerType = __MetaType.FromModelObject((__IModelObject)obj6);
            obj52.ItemType = __MetaType.FromModelObject((__IModelObject)obj6);
            obj53.InnerType = typeof(global::System.String);
            obj54.IsDerived = true;
            obj54.Type = typeof(global::System.String);
            obj54.Name = "Namespace";
            obj54.Parent = obj8;
            obj55.IsContainment = true;
            obj55.SubsettedProperties.Add(obj48);
            obj55.Type = __MetaType.FromModelObject((__IModelObject)obj9);
            obj55.Name = "Grammar";
            obj55.Parent = obj8;
            obj56.RedefinedProperties.Add(obj47);
            obj56.Type = __MetaType.FromModelObject((__IModelObject)obj8);
            obj56.Name = "Language";
            obj56.Parent = obj9;
            ((__IModelObject)obj57).MChildren.Add((__IModelObject)obj67);
            obj57.IsContainment = true;
            obj57.RedefinedProperties.Add(obj48);
            obj57.Type = __MetaType.FromModelObject((__IModelObject)obj67);
            obj57.Name = "GrammarRules";
            obj57.Parent = obj9;
            ((__IModelObject)obj58).MChildren.Add((__IModelObject)obj68);
            obj58.IsContainment = true;
            obj58.Type = __MetaType.FromModelObject((__IModelObject)obj68);
            obj58.Name = "TokenKinds";
            obj58.Parent = obj9;
            ((__IModelObject)obj59).MChildren.Add((__IModelObject)obj69);
            obj59.IsContainment = true;
            obj59.SubsettedProperties.Add(obj57);
            obj59.Type = __MetaType.FromModelObject((__IModelObject)obj69);
            obj59.Name = "Tokens";
            obj59.Parent = obj9;
            ((__IModelObject)obj60).MChildren.Add((__IModelObject)obj70);
            obj60.IsContainment = true;
            obj60.SubsettedProperties.Add(obj57);
            obj60.Type = __MetaType.FromModelObject((__IModelObject)obj70);
            obj60.Name = "Rules";
            obj60.Parent = obj9;
            ((__IModelObject)obj61).MChildren.Add((__IModelObject)obj71);
            obj61.Type = __MetaType.FromModelObject((__IModelObject)obj71);
            obj61.Name = "Blocks";
            obj61.Parent = obj9;
            ((__IModelObject)obj62).MChildren.Add((__IModelObject)obj72);
            obj62.Type = __MetaType.FromModelObject((__IModelObject)obj72);
            obj62.Name = "DefaultWhitespace";
            obj62.Parent = obj9;
            ((__IModelObject)obj63).MChildren.Add((__IModelObject)obj73);
            obj63.Type = __MetaType.FromModelObject((__IModelObject)obj73);
            obj63.Name = "DefaultEndOfLine";
            obj63.Parent = obj9;
            ((__IModelObject)obj64).MChildren.Add((__IModelObject)obj74);
            obj64.Type = __MetaType.FromModelObject((__IModelObject)obj74);
            obj64.Name = "DefaultSeparator";
            obj64.Parent = obj9;
            ((__IModelObject)obj65).MChildren.Add((__IModelObject)obj75);
            obj65.Type = __MetaType.FromModelObject((__IModelObject)obj75);
            obj65.Name = "DefaultIdentifier";
            obj65.Parent = obj9;
            ((__IModelObject)obj66).MChildren.Add((__IModelObject)obj76);
            obj66.Type = __MetaType.FromModelObject((__IModelObject)obj76);
            obj66.Name = "MainRule";
            obj66.Parent = obj9;
            obj67.ItemType = __MetaType.FromModelObject((__IModelObject)obj17);
            obj68.ItemType = __MetaType.FromModelObject((__IModelObject)obj15);
            obj69.ItemType = __MetaType.FromModelObject((__IModelObject)obj19);
            obj70.ItemType = __MetaType.FromModelObject((__IModelObject)obj33);
            obj71.ItemType = __MetaType.FromModelObject((__IModelObject)obj42);
            obj72.InnerType = __MetaType.FromModelObject((__IModelObject)obj19);
            obj73.InnerType = __MetaType.FromModelObject((__IModelObject)obj19);
            obj74.InnerType = __MetaType.FromModelObject((__IModelObject)obj19);
            obj75.InnerType = __MetaType.FromModelObject((__IModelObject)obj19);
            obj76.InnerType = __MetaType.FromModelObject((__IModelObject)obj33);
            obj77.SymbolProperty = "AttributeClass";
            obj77.Type = typeof(global::MetaDslx.CodeAnalysis.MetaType);
            obj77.Name = "AttributeClass";
            obj77.Parent = obj10;
            ((__IModelObject)obj78).MChildren.Add((__IModelObject)obj79);
            obj78.IsContainment = true;
            obj78.SymbolProperty = "Arguments";
            obj78.Type = __MetaType.FromModelObject((__IModelObject)obj79);
            obj78.Name = "Arguments";
            obj78.Parent = obj10;
            obj79.ItemType = __MetaType.FromModelObject((__IModelObject)obj11);
            ((__IModelObject)obj80).MChildren.Add((__IModelObject)obj84);
            obj80.SymbolProperty = "NamedParameter";
            obj80.Type = __MetaType.FromModelObject((__IModelObject)obj84);
            obj80.Name = "NamedParameter";
            obj80.Parent = obj11;
            obj81.SymbolProperty = "Parameter";
            obj81.Type = typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            obj81.Name = "Parameter";
            obj81.Parent = obj11;
            obj82.Type = typeof(global::MetaDslx.CodeAnalysis.MetaType);
            obj82.Name = "ParameterType";
            obj82.Parent = obj11;
            obj83.IsContainment = true;
            obj83.SymbolProperty = "Value";
            obj83.Type = __MetaType.FromModelObject((__IModelObject)obj44);
            obj83.Name = "Value";
            obj83.Parent = obj11;
            obj84.ItemType = typeof(global::MetaDslx.CodeAnalysis.MetaSymbol);
            obj85.Type = typeof(global::System.String);
            obj85.Name = "TypeName";
            obj85.Parent = obj12;
            ((__IModelObject)obj86).MChildren.Add((__IModelObject)obj89);
            obj86.IsContainment = true;
            obj86.Type = __MetaType.FromModelObject((__IModelObject)obj89);
            obj86.Name = "Arguments";
            obj86.Parent = obj12;
            obj87.Type = typeof(global::System.Boolean);
            obj87.Name = "IsNegated";
            obj87.Parent = obj12;
            obj88.IsDerived = true;
            obj88.Type = typeof(global::System.String);
            obj88.Name = "ConstructorArguments";
            obj88.Parent = obj12;
            obj89.ItemType = __MetaType.FromModelObject((__IModelObject)obj13);
            obj90.Type = typeof(global::System.String);
            obj90.Name = "Name";
            obj90.Parent = obj13;
            obj91.Type = typeof(global::System.String);
            obj91.Name = "TypeName";
            obj91.Parent = obj13;
            obj92.Type = typeof(global::System.Boolean);
            obj92.Name = "IsArray";
            obj92.Parent = obj13;
            ((__IModelObject)obj93).MChildren.Add((__IModelObject)obj94);
            obj93.Type = __MetaType.FromModelObject((__IModelObject)obj94);
            obj93.Name = "Values";
            obj93.Parent = obj13;
            ((__IModelObject)obj94).MChildren.Add((__IModelObject)obj95);
            obj94.ItemType = __MetaType.FromModelObject((__IModelObject)obj95);
            obj95.InnerType = typeof(global::System.String);
            ((__IModelObject)obj96).MChildren.Add((__IModelObject)obj101);
            obj96.IsContainment = true;
            obj96.Type = __MetaType.FromModelObject((__IModelObject)obj101);
            obj96.Name = "Annotations";
            obj96.Parent = obj14;
            obj97.Type = typeof(global::System.String);
            obj97.Name = "CSharpName";
            obj97.Parent = obj14;
            obj98.Type = typeof(global::System.String);
            obj98.Name = "AntlrName";
            obj98.Parent = obj14;
            ((__IModelObject)obj99).MChildren.Add((__IModelObject)obj102);
            obj99.IsContainment = true;
            obj99.Type = __MetaType.FromModelObject((__IModelObject)obj102);
            obj99.Name = "Binders";
            obj99.Parent = obj14;
            obj100.Type = typeof(global::System.Boolean);
            obj100.Name = "ContainsBinders";
            obj100.Parent = obj14;
            obj101.ItemType = __MetaType.FromModelObject((__IModelObject)obj10);
            obj102.ItemType = __MetaType.FromModelObject((__IModelObject)obj12);
            obj103.Type = typeof(global::System.String);
            obj103.Name = "Name";
            obj103.Parent = obj15;
            obj104.Type = typeof(global::System.String);
            obj104.Name = "TypeName";
            obj104.Parent = obj15;
            obj105.Name = "ExactlyOne";
            obj105.Parent = obj16;
            obj106.Name = "ZeroOrOne";
            obj106.Parent = obj16;
            obj107.Name = "ZeroOrMore";
            obj107.Parent = obj16;
            obj108.Name = "OneOrMore";
            obj108.Parent = obj16;
            obj109.Name = "NonGreedyZeroOrOne";
            obj109.Parent = obj16;
            obj110.Name = "NonGreedyZeroOrMore";
            obj110.Parent = obj16;
            obj111.Name = "NonGreedyOneOrMore";
            obj111.Parent = obj16;
            obj112.IsDerived = true;
            obj112.Type = __MetaType.FromModelObject((__IModelObject)obj8);
            obj112.Name = "Language";
            obj112.Parent = obj17;
            obj113.RedefinedProperties.Add(obj47);
            obj113.Type = __MetaType.FromModelObject((__IModelObject)obj9);
            obj113.Name = "Grammar";
            obj113.Parent = obj17;
            ((__IModelObject)obj114).MChildren.Add((__IModelObject)obj117);
            obj114.IsContainment = true;
            obj114.Type = __MetaType.FromModelObject((__IModelObject)obj117);
            obj114.Name = "Alternatives";
            obj114.Parent = obj18;
            obj115.IsDerived = true;
            obj115.Type = typeof(global::System.Boolean);
            obj115.Name = "IsFixed";
            obj115.Parent = obj18;
            ((__IModelObject)obj116).MChildren.Add((__IModelObject)obj118);
            obj116.IsDerived = true;
            obj116.Type = __MetaType.FromModelObject((__IModelObject)obj118);
            obj116.Name = "FixedText";
            obj116.Parent = obj18;
            obj117.ItemType = __MetaType.FromModelObject((__IModelObject)obj21);
            obj118.InnerType = typeof(global::System.String);
            obj119.SymbolProperty = "ReturnType";
            obj119.Type = typeof(global::MetaDslx.CodeAnalysis.MetaType);
            obj119.Name = "ReturnType";
            obj119.Parent = obj19;
            obj120.Type = typeof(global::System.Boolean);
            obj120.Name = "IsTrivia";
            obj120.Parent = obj19;
            ((__IModelObject)obj121).MChildren.Add((__IModelObject)obj122);
            obj121.Type = __MetaType.FromModelObject((__IModelObject)obj122);
            obj121.Name = "TokenKind";
            obj121.Parent = obj19;
            obj122.InnerType = __MetaType.FromModelObject((__IModelObject)obj15);
            obj123.IsDerived = true;
            obj123.Type = typeof(global::System.Boolean);
            obj123.Name = "IsFixed";
            obj123.Parent = obj21;
            ((__IModelObject)obj124).MChildren.Add((__IModelObject)obj126);
            obj124.IsDerived = true;
            obj124.Type = __MetaType.FromModelObject((__IModelObject)obj126);
            obj124.Name = "FixedText";
            obj124.Parent = obj21;
            ((__IModelObject)obj125).MChildren.Add((__IModelObject)obj127);
            obj125.IsContainment = true;
            obj125.Type = __MetaType.FromModelObject((__IModelObject)obj127);
            obj125.Name = "Elements";
            obj125.Parent = obj21;
            obj126.InnerType = typeof(global::System.String);
            obj127.ItemType = __MetaType.FromModelObject((__IModelObject)obj22);
            obj128.IsDerived = true;
            obj128.Type = typeof(global::System.Boolean);
            obj128.Name = "IsFixed";
            obj128.Parent = obj22;
            ((__IModelObject)obj129).MChildren.Add((__IModelObject)obj133);
            obj129.IsDerived = true;
            obj129.Type = __MetaType.FromModelObject((__IModelObject)obj133);
            obj129.Name = "FixedText";
            obj129.Parent = obj22;
            obj130.Type = typeof(global::System.Boolean);
            obj130.Name = "IsNegated";
            obj130.Parent = obj22;
            obj131.IsContainment = true;
            obj131.Type = __MetaType.FromModelObject((__IModelObject)obj23);
            obj131.Name = "Value";
            obj131.Parent = obj22;
            obj132.Type = __MetaType.FromModelObject((__IModelObject)obj16);
            obj132.Name = "Multiplicity";
            obj132.Parent = obj22;
            obj133.InnerType = typeof(global::System.String);
            obj134.IsDerived = true;
            obj134.Type = typeof(global::System.Boolean);
            obj134.Name = "IsFixed";
            obj134.Parent = obj23;
            ((__IModelObject)obj135).MChildren.Add((__IModelObject)obj136);
            obj135.IsDerived = true;
            obj135.Type = __MetaType.FromModelObject((__IModelObject)obj136);
            obj135.Name = "FixedText";
            obj135.Parent = obj23;
            obj136.InnerType = typeof(global::System.String);
            obj137.IsDerived = true;
            obj137.Type = typeof(global::System.Boolean);
            obj137.Name = "IsFixed";
            obj137.Parent = obj24;
            ((__IModelObject)obj138).MChildren.Add((__IModelObject)obj140);
            obj138.IsDerived = true;
            obj138.Type = __MetaType.FromModelObject((__IModelObject)obj140);
            obj138.Name = "FixedText";
            obj138.Parent = obj24;
            obj139.Type = __MetaType.FromModelObject((__IModelObject)obj18);
            obj139.Name = "Rule";
            obj139.Parent = obj24;
            obj140.InnerType = typeof(global::System.String);
            obj141.IsDerived = true;
            obj141.Type = typeof(global::System.Boolean);
            obj141.Name = "IsFixed";
            obj141.Parent = obj25;
            ((__IModelObject)obj142).MChildren.Add((__IModelObject)obj144);
            obj142.IsDerived = true;
            obj142.Type = __MetaType.FromModelObject((__IModelObject)obj144);
            obj142.Name = "FixedText";
            obj142.Parent = obj25;
            obj143.Type = typeof(global::System.String);
            obj143.Name = "Text";
            obj143.Parent = obj25;
            obj144.InnerType = typeof(global::System.String);
            obj145.IsDerived = true;
            obj145.Type = typeof(global::System.Boolean);
            obj145.Name = "IsFixed";
            obj145.Parent = obj26;
            ((__IModelObject)obj146).MChildren.Add((__IModelObject)obj147);
            obj146.IsDerived = true;
            obj146.Type = __MetaType.FromModelObject((__IModelObject)obj147);
            obj146.Name = "FixedText";
            obj146.Parent = obj26;
            obj147.InnerType = typeof(global::System.String);
            obj148.IsDerived = true;
            obj148.Type = typeof(global::System.Boolean);
            obj148.Name = "IsFixed";
            obj148.Parent = obj27;
            ((__IModelObject)obj149).MChildren.Add((__IModelObject)obj152);
            obj149.IsDerived = true;
            obj149.Type = __MetaType.FromModelObject((__IModelObject)obj152);
            obj149.Name = "FixedText";
            obj149.Parent = obj27;
            obj150.Type = typeof(global::System.String);
            obj150.Name = "StartChar";
            obj150.Parent = obj27;
            obj151.Type = typeof(global::System.String);
            obj151.Name = "EndChar";
            obj151.Parent = obj27;
            obj152.InnerType = typeof(global::System.String);
            obj153.IsDerived = true;
            obj153.Type = typeof(global::System.Boolean);
            obj153.Name = "IsFixed";
            obj153.Parent = obj28;
            ((__IModelObject)obj154).MChildren.Add((__IModelObject)obj156);
            obj154.IsDerived = true;
            obj154.Type = __MetaType.FromModelObject((__IModelObject)obj156);
            obj154.Name = "FixedText";
            obj154.Parent = obj28;
            ((__IModelObject)obj155).MChildren.Add((__IModelObject)obj157);
            obj155.IsContainment = true;
            obj155.Type = __MetaType.FromModelObject((__IModelObject)obj157);
            obj155.Name = "Items";
            obj155.Parent = obj28;
            obj156.InnerType = typeof(global::System.String);
            obj157.ItemType = __MetaType.FromModelObject((__IModelObject)obj29);
            obj158.IsDerived = true;
            obj158.Type = typeof(global::System.Boolean);
            obj158.Name = "IsFixed";
            obj158.Parent = obj29;
            ((__IModelObject)obj159).MChildren.Add((__IModelObject)obj160);
            obj159.IsDerived = true;
            obj159.Type = __MetaType.FromModelObject((__IModelObject)obj160);
            obj159.Name = "FixedText";
            obj159.Parent = obj29;
            obj160.InnerType = typeof(global::System.String);
            obj161.IsDerived = true;
            obj161.Type = typeof(global::System.Boolean);
            obj161.Name = "IsFixed";
            obj161.Parent = obj30;
            ((__IModelObject)obj162).MChildren.Add((__IModelObject)obj164);
            obj162.IsDerived = true;
            obj162.Type = __MetaType.FromModelObject((__IModelObject)obj164);
            obj162.Name = "FixedText";
            obj162.Parent = obj30;
            obj163.Type = typeof(global::System.String);
            obj163.Name = "Char";
            obj163.Parent = obj30;
            obj164.InnerType = typeof(global::System.String);
            obj165.IsDerived = true;
            obj165.Type = typeof(global::System.Boolean);
            obj165.Name = "IsFixed";
            obj165.Parent = obj31;
            ((__IModelObject)obj166).MChildren.Add((__IModelObject)obj169);
            obj166.IsDerived = true;
            obj166.Type = __MetaType.FromModelObject((__IModelObject)obj169);
            obj166.Name = "FixedText";
            obj166.Parent = obj31;
            obj167.Type = typeof(global::System.String);
            obj167.Name = "StartChar";
            obj167.Parent = obj31;
            obj168.Type = typeof(global::System.String);
            obj168.Name = "EndChar";
            obj168.Parent = obj31;
            obj169.InnerType = typeof(global::System.String);
            obj170.IsDerived = true;
            obj170.Type = typeof(global::System.Boolean);
            obj170.Name = "IsFixed";
            obj170.Parent = obj32;
            ((__IModelObject)obj171).MChildren.Add((__IModelObject)obj173);
            obj171.IsDerived = true;
            obj171.Type = __MetaType.FromModelObject((__IModelObject)obj173);
            obj171.Name = "FixedText";
            obj171.Parent = obj32;
            ((__IModelObject)obj172).MChildren.Add((__IModelObject)obj174);
            obj172.IsContainment = true;
            obj172.Type = __MetaType.FromModelObject((__IModelObject)obj174);
            obj172.Name = "Alternatives";
            obj172.Parent = obj32;
            obj173.InnerType = typeof(global::System.String);
            obj174.ItemType = __MetaType.FromModelObject((__IModelObject)obj21);
            obj175.SymbolProperty = "ReturnType";
            obj175.Type = typeof(global::MetaDslx.CodeAnalysis.MetaType);
            obj175.Name = "ReturnType";
            obj175.Parent = obj33;
            ((__IModelObject)obj176).MChildren.Add((__IModelObject)obj180);
            obj176.IsContainment = true;
            obj176.SymbolProperty = "Alternatives";
            obj176.Type = __MetaType.FromModelObject((__IModelObject)obj180);
            obj176.Name = "Alternatives";
            obj176.Parent = obj33;
            ((__IModelObject)obj177).MChildren.Add((__IModelObject)obj181);
            obj177.Type = __MetaType.FromModelObject((__IModelObject)obj181);
            obj177.Name = "BaseRule";
            obj177.Parent = obj33;
            obj178.IsDerived = true;
            obj178.Type = typeof(global::System.String);
            obj178.Name = "GreenName";
            obj178.Parent = obj33;
            obj179.IsDerived = true;
            obj179.Type = typeof(global::System.String);
            obj179.Name = "RedName";
            obj179.Parent = obj33;
            obj180.ItemType = __MetaType.FromModelObject((__IModelObject)obj34);
            obj181.InnerType = __MetaType.FromModelObject((__IModelObject)obj34);
            obj182.SymbolProperty = "ReturnType";
            obj182.Type = typeof(global::MetaDslx.CodeAnalysis.MetaType);
            obj182.Name = "ReturnType";
            obj182.Parent = obj34;
            obj183.IsContainment = true;
            obj183.SymbolProperty = "ReturnValue";
            obj183.Type = __MetaType.FromModelObject((__IModelObject)obj44);
            obj183.Name = "ReturnValue";
            obj183.Parent = obj34;
            ((__IModelObject)obj184).MChildren.Add((__IModelObject)obj197);
            obj184.IsContainment = true;
            obj184.SymbolProperty = "Elements";
            obj184.Type = __MetaType.FromModelObject((__IModelObject)obj197);
            obj184.Name = "Elements";
            obj184.Parent = obj34;
            obj185.IsDerived = true;
            obj185.Type = typeof(global::System.String);
            obj185.Name = "GreenName";
            obj185.Parent = obj34;
            obj186.IsDerived = true;
            obj186.Type = typeof(global::System.String);
            obj186.Name = "GreenConstructorParameters";
            obj186.Parent = obj34;
            obj187.IsDerived = true;
            obj187.Type = typeof(global::System.String);
            obj187.Name = "GreenConstructorArguments";
            obj187.Parent = obj34;
            obj188.IsDerived = true;
            obj188.Type = typeof(global::System.String);
            obj188.Name = "GreenUpdateParameters";
            obj188.Parent = obj34;
            obj189.IsDerived = true;
            obj189.Type = typeof(global::System.String);
            obj189.Name = "GreenUpdateArguments";
            obj189.Parent = obj34;
            obj190.IsDerived = true;
            obj190.Type = typeof(global::System.String);
            obj190.Name = "RedName";
            obj190.Parent = obj34;
            obj191.IsDerived = true;
            obj191.Type = typeof(global::System.String);
            obj191.Name = "RedUpdateParameters";
            obj191.Parent = obj34;
            obj192.IsDerived = true;
            obj192.Type = typeof(global::System.String);
            obj192.Name = "RedUpdateArguments";
            obj192.Parent = obj34;
            obj193.IsDerived = true;
            obj193.Type = typeof(global::System.String);
            obj193.Name = "RedOptionalUpdateParameters";
            obj193.Parent = obj34;
            obj194.IsDerived = true;
            obj194.Type = typeof(global::System.String);
            obj194.Name = "RedToGreenArgumentList";
            obj194.Parent = obj34;
            obj195.IsDerived = true;
            obj195.Type = typeof(global::System.String);
            obj195.Name = "RedToGreenOptionalArgumentList";
            obj195.Parent = obj34;
            obj196.IsDerived = true;
            obj196.Type = typeof(global::System.Boolean);
            obj196.Name = "HasRedToGreenOptionalArguments";
            obj196.Parent = obj34;
            obj197.ItemType = __MetaType.FromModelObject((__IModelObject)obj36);
            obj198.Name = "Assign";
            obj198.Parent = obj35;
            obj199.Name = "QuestionAssign";
            obj199.Parent = obj35;
            obj200.Name = "NegatedAssign";
            obj200.Parent = obj35;
            obj201.Name = "PlusAssign";
            obj201.Parent = obj35;
            ((__IModelObject)obj202).MChildren.Add((__IModelObject)obj226);
            obj202.SymbolProperty = "Name";
            obj202.Type = __MetaType.FromModelObject((__IModelObject)obj226);
            obj202.Name = "Name";
            obj202.Parent = obj36;
            obj203.SymbolProperty = "Assignment";
            obj203.Type = __MetaType.FromModelObject((__IModelObject)obj35);
            obj203.Name = "Assignment";
            obj203.Parent = obj36;
            obj204.IsContainment = true;
            obj204.SymbolProperty = "Value";
            obj204.Type = __MetaType.FromModelObject((__IModelObject)obj37);
            obj204.Name = "Value";
            obj204.Parent = obj36;
            obj205.IsDerived = true;
            obj205.Type = typeof(global::System.Boolean);
            obj205.Name = "IsToken";
            obj205.Parent = obj36;
            obj206.IsDerived = true;
            obj206.Type = typeof(global::System.Boolean);
            obj206.Name = "IsList";
            obj206.Parent = obj36;
            obj207.IsDerived = true;
            obj207.Type = typeof(global::System.String);
            obj207.Name = "FieldName";
            obj207.Parent = obj36;
            obj208.IsDerived = true;
            obj208.Type = typeof(global::System.String);
            obj208.Name = "ParameterName";
            obj208.Parent = obj36;
            obj209.IsDerived = true;
            obj209.Type = typeof(global::System.String);
            obj209.Name = "PropertyName";
            obj209.Parent = obj36;
            obj210.IsDerived = true;
            obj210.Type = typeof(global::System.String);
            obj210.Name = "GreenFieldType";
            obj210.Parent = obj36;
            obj211.IsDerived = true;
            obj211.Type = typeof(global::System.String);
            obj211.Name = "GreenParameterValue";
            obj211.Parent = obj36;
            obj212.IsDerived = true;
            obj212.Type = typeof(global::System.String);
            obj212.Name = "GreenPropertyType";
            obj212.Parent = obj36;
            obj213.IsDerived = true;
            obj213.Type = typeof(global::System.String);
            obj213.Name = "GreenPropertyValue";
            obj213.Parent = obj36;
            ((__IModelObject)obj214).MChildren.Add((__IModelObject)obj227);
            obj214.IsDerived = true;
            obj214.Type = __MetaType.FromModelObject((__IModelObject)obj227);
            obj214.Name = "GreenSyntaxNullCondition";
            obj214.Parent = obj36;
            ((__IModelObject)obj215).MChildren.Add((__IModelObject)obj228);
            obj215.IsDerived = true;
            obj215.Type = __MetaType.FromModelObject((__IModelObject)obj228);
            obj215.Name = "GreenSyntaxCondition";
            obj215.Parent = obj36;
            obj216.IsDerived = true;
            obj216.Type = typeof(global::System.Boolean);
            obj216.Name = "IsOptionalUpdateParameter";
            obj216.Parent = obj36;
            obj217.IsDerived = true;
            obj217.Type = typeof(global::System.String);
            obj217.Name = "RedFieldType";
            obj217.Parent = obj36;
            obj218.IsDerived = true;
            obj218.Type = typeof(global::System.String);
            obj218.Name = "RedParameterValue";
            obj218.Parent = obj36;
            obj219.IsDerived = true;
            obj219.Type = typeof(global::System.String);
            obj219.Name = "RedPropertyType";
            obj219.Parent = obj36;
            obj220.IsDerived = true;
            obj220.Type = typeof(global::System.String);
            obj220.Name = "RedPropertyValue";
            obj220.Parent = obj36;
            obj221.IsDerived = true;
            obj221.Type = typeof(global::System.String);
            obj221.Name = "RedToGreenArgument";
            obj221.Parent = obj36;
            obj222.IsDerived = true;
            obj222.Type = typeof(global::System.String);
            obj222.Name = "RedToGreenOptionalArgument";
            obj222.Parent = obj36;
            ((__IModelObject)obj223).MChildren.Add((__IModelObject)obj229);
            obj223.IsDerived = true;
            obj223.Type = __MetaType.FromModelObject((__IModelObject)obj229);
            obj223.Name = "RedSyntaxNullCondition";
            obj223.Parent = obj36;
            ((__IModelObject)obj224).MChildren.Add((__IModelObject)obj230);
            obj224.IsDerived = true;
            obj224.Type = __MetaType.FromModelObject((__IModelObject)obj230);
            obj224.Name = "RedSyntaxCondition";
            obj224.Parent = obj36;
            ((__IModelObject)obj225).MChildren.Add((__IModelObject)obj231);
            obj225.IsDerived = true;
            obj225.Type = __MetaType.FromModelObject((__IModelObject)obj231);
            obj225.Name = "VisitCall";
            obj225.Parent = obj36;
            obj226.InnerType = typeof(global::System.String);
            obj227.InnerType = typeof(global::System.String);
            obj228.InnerType = typeof(global::System.String);
            obj229.InnerType = typeof(global::System.String);
            obj230.InnerType = typeof(global::System.String);
            obj231.InnerType = typeof(global::System.String);
            obj232.Type = __MetaType.FromModelObject((__IModelObject)obj16);
            obj232.Name = "Multiplicity";
            obj232.Parent = obj37;
            obj233.IsDerived = true;
            obj233.Type = typeof(global::System.String);
            obj233.Name = "GreenType";
            obj233.Parent = obj37;
            ((__IModelObject)obj234).MChildren.Add((__IModelObject)obj236);
            obj234.IsDerived = true;
            obj234.Type = __MetaType.FromModelObject((__IModelObject)obj236);
            obj234.Name = "GreenSyntaxCondition";
            obj234.Parent = obj37;
            obj235.IsDerived = true;
            obj235.Type = typeof(global::System.String);
            obj235.Name = "RedType";
            obj235.Parent = obj37;
            obj236.InnerType = typeof(global::System.String);
            obj237.SymbolProperty = "Rule";
            obj237.Type = __MetaType.FromModelObject((__IModelObject)obj17);
            obj237.Name = "GrammarRule";
            obj237.Parent = obj38;
            ((__IModelObject)obj238).MChildren.Add((__IModelObject)obj244);
            obj238.SymbolProperty = "ReferencedTypes";
            obj238.Type = __MetaType.FromModelObject((__IModelObject)obj244);
            obj238.Name = "ReferencedTypes";
            obj238.Parent = obj38;
            ((__IModelObject)obj239).MChildren.Add((__IModelObject)obj245);
            obj239.IsDerived = true;
            obj239.Type = __MetaType.FromModelObject((__IModelObject)obj245);
            obj239.Name = "Token";
            obj239.Parent = obj38;
            ((__IModelObject)obj240).MChildren.Add((__IModelObject)obj246);
            obj240.IsDerived = true;
            obj240.Type = __MetaType.FromModelObject((__IModelObject)obj246);
            obj240.Name = "Rule";
            obj240.Parent = obj38;
            obj241.IsDerived = true;
            obj241.Type = typeof(global::System.String);
            obj241.Name = "GreenType";
            obj241.Parent = obj38;
            ((__IModelObject)obj242).MChildren.Add((__IModelObject)obj247);
            obj242.IsDerived = true;
            obj242.Type = __MetaType.FromModelObject((__IModelObject)obj247);
            obj242.Name = "GreenSyntaxCondition";
            obj242.Parent = obj38;
            obj243.IsDerived = true;
            obj243.Type = typeof(global::System.String);
            obj243.Name = "RedType";
            obj243.Parent = obj38;
            obj244.ItemType = typeof(global::MetaDslx.CodeAnalysis.MetaType);
            obj245.InnerType = __MetaType.FromModelObject((__IModelObject)obj19);
            obj246.InnerType = __MetaType.FromModelObject((__IModelObject)obj33);
            obj247.InnerType = typeof(global::System.String);
            obj248.IsDerived = true;
            obj248.Type = typeof(global::System.String);
            obj248.Name = "GreenType";
            obj248.Parent = obj39;
            ((__IModelObject)obj249).MChildren.Add((__IModelObject)obj251);
            obj249.IsDerived = true;
            obj249.Type = __MetaType.FromModelObject((__IModelObject)obj251);
            obj249.Name = "GreenSyntaxCondition";
            obj249.Parent = obj39;
            obj250.IsDerived = true;
            obj250.Type = typeof(global::System.String);
            obj250.Name = "RedType";
            obj250.Parent = obj39;
            obj251.InnerType = typeof(global::System.String);
            obj252.Type = typeof(global::System.String);
            obj252.Name = "Text";
            obj252.Parent = obj40;
            ((__IModelObject)obj253).MChildren.Add((__IModelObject)obj257);
            obj253.IsContainment = true;
            obj253.Type = __MetaType.FromModelObject((__IModelObject)obj257);
            obj253.Name = "Tokens";
            obj253.Parent = obj41;
            obj254.IsDerived = true;
            obj254.Type = typeof(global::System.String);
            obj254.Name = "GreenType";
            obj254.Parent = obj41;
            ((__IModelObject)obj255).MChildren.Add((__IModelObject)obj258);
            obj255.IsDerived = true;
            obj255.Type = __MetaType.FromModelObject((__IModelObject)obj258);
            obj255.Name = "GreenSyntaxCondition";
            obj255.Parent = obj41;
            obj256.IsDerived = true;
            obj256.Type = typeof(global::System.String);
            obj256.Name = "RedType";
            obj256.Parent = obj41;
            obj257.ItemType = __MetaType.FromModelObject((__IModelObject)obj38);
            obj258.InnerType = typeof(global::System.String);
            ((__IModelObject)obj259).MChildren.Add((__IModelObject)obj265);
            obj259.IsContainment = true;
            obj259.SymbolProperty = "Alternatives";
            obj259.Type = __MetaType.FromModelObject((__IModelObject)obj265);
            obj259.Name = "Alternatives";
            obj259.Parent = obj42;
            obj260.IsDerived = true;
            obj260.Type = typeof(global::System.String);
            obj260.Name = "GreenName";
            obj260.Parent = obj42;
            obj261.IsDerived = true;
            obj261.Type = typeof(global::System.String);
            obj261.Name = "RedName";
            obj261.Parent = obj42;
            obj262.IsDerived = true;
            obj262.Type = typeof(global::System.String);
            obj262.Name = "GreenType";
            obj262.Parent = obj42;
            ((__IModelObject)obj263).MChildren.Add((__IModelObject)obj266);
            obj263.IsDerived = true;
            obj263.Type = __MetaType.FromModelObject((__IModelObject)obj266);
            obj263.Name = "GreenSyntaxCondition";
            obj263.Parent = obj42;
            obj264.IsDerived = true;
            obj264.Type = typeof(global::System.String);
            obj264.Name = "RedType";
            obj264.Parent = obj42;
            obj265.ItemType = __MetaType.FromModelObject((__IModelObject)obj34);
            obj266.InnerType = typeof(global::System.String);
            obj267.Type = typeof(global::System.Boolean);
            obj267.Name = "SeparatorFirst";
            obj267.Parent = obj43;
            obj268.Type = typeof(global::System.Boolean);
            obj268.Name = "RepeatedSeparatorFirst";
            obj268.Parent = obj43;
            ((__IModelObject)obj269).MChildren.Add((__IModelObject)obj279);
            obj269.IsContainment = true;
            obj269.Type = __MetaType.FromModelObject((__IModelObject)obj279);
            obj269.Name = "FirstItems";
            obj269.Parent = obj43;
            ((__IModelObject)obj270).MChildren.Add((__IModelObject)obj280);
            obj270.IsContainment = true;
            obj270.Type = __MetaType.FromModelObject((__IModelObject)obj280);
            obj270.Name = "FirstSeparators";
            obj270.Parent = obj43;
            obj271.IsContainment = true;
            obj271.Type = __MetaType.FromModelObject((__IModelObject)obj36);
            obj271.Name = "RepeatedBlock";
            obj271.Parent = obj43;
            obj272.Type = __MetaType.FromModelObject((__IModelObject)obj36);
            obj272.Name = "RepeatedItem";
            obj272.Parent = obj43;
            obj273.Type = __MetaType.FromModelObject((__IModelObject)obj36);
            obj273.Name = "RepeatedSeparator";
            obj273.Parent = obj43;
            ((__IModelObject)obj274).MChildren.Add((__IModelObject)obj281);
            obj274.IsContainment = true;
            obj274.Type = __MetaType.FromModelObject((__IModelObject)obj281);
            obj274.Name = "LastItems";
            obj274.Parent = obj43;
            ((__IModelObject)obj275).MChildren.Add((__IModelObject)obj282);
            obj275.IsContainment = true;
            obj275.Type = __MetaType.FromModelObject((__IModelObject)obj282);
            obj275.Name = "LastSeparators";
            obj275.Parent = obj43;
            obj276.IsDerived = true;
            obj276.Type = typeof(global::System.String);
            obj276.Name = "GreenType";
            obj276.Parent = obj43;
            ((__IModelObject)obj277).MChildren.Add((__IModelObject)obj283);
            obj277.IsDerived = true;
            obj277.Type = __MetaType.FromModelObject((__IModelObject)obj283);
            obj277.Name = "GreenSyntaxCondition";
            obj277.Parent = obj43;
            obj278.IsDerived = true;
            obj278.Type = typeof(global::System.String);
            obj278.Name = "RedType";
            obj278.Parent = obj43;
            obj279.ItemType = __MetaType.FromModelObject((__IModelObject)obj36);
            obj280.ItemType = __MetaType.FromModelObject((__IModelObject)obj36);
            obj281.ItemType = __MetaType.FromModelObject((__IModelObject)obj36);
            obj282.ItemType = __MetaType.FromModelObject((__IModelObject)obj36);
            obj283.InnerType = typeof(global::System.String);
            obj284.SymbolProperty = "Value";
            obj284.Type = typeof(global::MetaDslx.CodeAnalysis.MetaSymbol);
            obj284.Name = "Value";
            obj284.Parent = obj44;
            ((__IModelObject)obj285).MChildren.Add((__IModelObject)obj286);
            obj285.Type = __MetaType.FromModelObject((__IModelObject)obj286);
            obj285.Name = "Items";
            obj285.Parent = obj45;
            obj286.ItemType = __MetaType.FromModelObject((__IModelObject)obj44);
            _model.IsSealed = true;
        }
    
        public override string MName => nameof(Compiler);
        public override string MNamespace => "MetaDslx.Bootstrap.MetaCompiler.Model";
        public override __ModelVersion MVersion => default;
        public override string MUri => "MetaDslx.Bootstrap.MetaCompiler.Model.Compiler";
        public override string MPrefix => "c";
        public override __Model MModel => _model;
    
        public override global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelEnumInfo> MEnumInfosByType => _enumInfosByType;
        public override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelEnumInfo> MEnumInfosByName => _enumInfosByName;
        public override global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelClassInfo> MClassInfosByType => _classInfosByType;
        public override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelClassInfo> MClassInfosByName => _classInfosByName;
    
        public override global::System.Collections.Immutable.ImmutableArray<__MetaType> MEnumTypes => _enumTypes;
        public override global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo> MEnumInfos => _enumInfos;
        public override global::System.Collections.Immutable.ImmutableArray<__MetaType> MClassTypes => _classTypes;
        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> MClassInfos => _classInfos;
    
    
    
        public static __ModelEnumInfo AssignmentInfo => __Impl.__Assignment_Info.Instance;
        public static __ModelEnumInfo MultiplicityInfo => __Impl.__Multiplicity_Info.Instance;
        public static __ModelClassInfo AnnotationInfo => __Impl.Annotation_Impl.__Info.Instance;
        public static __ModelProperty Annotation_AttributeClass => _Annotation_AttributeClass;
        public static __ModelProperty Annotation_Arguments => _Annotation_Arguments;
        public static __ModelClassInfo AnnotationArgumentInfo => __Impl.AnnotationArgument_Impl.__Info.Instance;
        public static __ModelProperty AnnotationArgument_NamedParameter => _AnnotationArgument_NamedParameter;
        public static __ModelProperty AnnotationArgument_Parameter => _AnnotationArgument_Parameter;
        public static __ModelProperty AnnotationArgument_ParameterType => _AnnotationArgument_ParameterType;
        public static __ModelProperty AnnotationArgument_Value => _AnnotationArgument_Value;
        public static __ModelClassInfo ArrayExpressionInfo => __Impl.ArrayExpression_Impl.__Info.Instance;
        public static __ModelProperty ArrayExpression_Items => _ArrayExpression_Items;
        public static __ModelClassInfo BinderInfo => __Impl.Binder_Impl.__Info.Instance;
        public static __ModelProperty Binder_TypeName => _Binder_TypeName;
        public static __ModelProperty Binder_Arguments => _Binder_Arguments;
        public static __ModelProperty Binder_IsNegated => _Binder_IsNegated;
        public static __ModelProperty Binder_ConstructorArguments => _Binder_ConstructorArguments;
        public static __ModelClassInfo BinderArgumentInfo => __Impl.BinderArgument_Impl.__Info.Instance;
        public static __ModelProperty BinderArgument_Name => _BinderArgument_Name;
        public static __ModelProperty BinderArgument_TypeName => _BinderArgument_TypeName;
        public static __ModelProperty BinderArgument_IsArray => _BinderArgument_IsArray;
        public static __ModelProperty BinderArgument_Values => _BinderArgument_Values;
        public static __ModelClassInfo CSharpElementInfo => __Impl.CSharpElement_Impl.__Info.Instance;
        public static __ModelProperty CSharpElement_Annotations => _CSharpElement_Annotations;
        public static __ModelProperty CSharpElement_CSharpName => _CSharpElement_CSharpName;
        public static __ModelProperty CSharpElement_AntlrName => _CSharpElement_AntlrName;
        public static __ModelProperty CSharpElement_Binders => _CSharpElement_Binders;
        public static __ModelProperty CSharpElement_ContainsBinders => _CSharpElement_ContainsBinders;
        public static __ModelClassInfo BlockInfo => __Impl.Block_Impl.__Info.Instance;
        public static __ModelProperty Block_Alternatives => _Block_Alternatives;
        public static __ModelProperty Block_GreenName => _Block_GreenName;
        public static __ModelProperty Block_RedName => _Block_RedName;
        public static __ModelProperty Block_GreenType => _Block_GreenType;
        public static __ModelProperty Block_GreenSyntaxCondition => _Block_GreenSyntaxCondition;
        public static __ModelProperty Block_RedType => _Block_RedType;
        public static __ModelClassInfo DeclarationInfo => __Impl.Declaration_Impl.__Info.Instance;
        public static __ModelProperty Declaration_Name => _Declaration_Name;
        public static __ModelProperty Declaration_Parent => _Declaration_Parent;
        public static __ModelProperty Declaration_Declarations => _Declaration_Declarations;
        public static __ModelProperty Declaration_FullName => _Declaration_FullName;
        public static __ModelClassInfo AlternativeInfo => __Impl.Alternative_Impl.__Info.Instance;
        public static __ModelProperty Alternative_ReturnType => _Alternative_ReturnType;
        public static __ModelProperty Alternative_ReturnValue => _Alternative_ReturnValue;
        public static __ModelProperty Alternative_Elements => _Alternative_Elements;
        public static __ModelProperty Alternative_GreenName => _Alternative_GreenName;
        public static __ModelProperty Alternative_GreenConstructorParameters => _Alternative_GreenConstructorParameters;
        public static __ModelProperty Alternative_GreenConstructorArguments => _Alternative_GreenConstructorArguments;
        public static __ModelProperty Alternative_GreenUpdateParameters => _Alternative_GreenUpdateParameters;
        public static __ModelProperty Alternative_GreenUpdateArguments => _Alternative_GreenUpdateArguments;
        public static __ModelProperty Alternative_RedName => _Alternative_RedName;
        public static __ModelProperty Alternative_RedUpdateParameters => _Alternative_RedUpdateParameters;
        public static __ModelProperty Alternative_RedUpdateArguments => _Alternative_RedUpdateArguments;
        public static __ModelProperty Alternative_RedOptionalUpdateParameters => _Alternative_RedOptionalUpdateParameters;
        public static __ModelProperty Alternative_RedToGreenArgumentList => _Alternative_RedToGreenArgumentList;
        public static __ModelProperty Alternative_RedToGreenOptionalArgumentList => _Alternative_RedToGreenOptionalArgumentList;
        public static __ModelProperty Alternative_HasRedToGreenOptionalArguments => _Alternative_HasRedToGreenOptionalArguments;
        public static __ModelClassInfo ElementInfo => __Impl.Element_Impl.__Info.Instance;
        public static __ModelProperty Element_Name => _Element_Name;
        public static __ModelProperty Element_Assignment => _Element_Assignment;
        public static __ModelProperty Element_Value => _Element_Value;
        public static __ModelProperty Element_IsToken => _Element_IsToken;
        public static __ModelProperty Element_IsList => _Element_IsList;
        public static __ModelProperty Element_FieldName => _Element_FieldName;
        public static __ModelProperty Element_ParameterName => _Element_ParameterName;
        public static __ModelProperty Element_PropertyName => _Element_PropertyName;
        public static __ModelProperty Element_GreenFieldType => _Element_GreenFieldType;
        public static __ModelProperty Element_GreenParameterValue => _Element_GreenParameterValue;
        public static __ModelProperty Element_GreenPropertyType => _Element_GreenPropertyType;
        public static __ModelProperty Element_GreenPropertyValue => _Element_GreenPropertyValue;
        public static __ModelProperty Element_GreenSyntaxNullCondition => _Element_GreenSyntaxNullCondition;
        public static __ModelProperty Element_GreenSyntaxCondition => _Element_GreenSyntaxCondition;
        public static __ModelProperty Element_IsOptionalUpdateParameter => _Element_IsOptionalUpdateParameter;
        public static __ModelProperty Element_RedFieldType => _Element_RedFieldType;
        public static __ModelProperty Element_RedParameterValue => _Element_RedParameterValue;
        public static __ModelProperty Element_RedPropertyType => _Element_RedPropertyType;
        public static __ModelProperty Element_RedPropertyValue => _Element_RedPropertyValue;
        public static __ModelProperty Element_RedToGreenArgument => _Element_RedToGreenArgument;
        public static __ModelProperty Element_RedToGreenOptionalArgument => _Element_RedToGreenOptionalArgument;
        public static __ModelProperty Element_RedSyntaxNullCondition => _Element_RedSyntaxNullCondition;
        public static __ModelProperty Element_RedSyntaxCondition => _Element_RedSyntaxCondition;
        public static __ModelProperty Element_VisitCall => _Element_VisitCall;
        public static __ModelClassInfo ElementValueInfo => __Impl.ElementValue_Impl.__Info.Instance;
        public static __ModelProperty ElementValue_Multiplicity => _ElementValue_Multiplicity;
        public static __ModelProperty ElementValue_GreenType => _ElementValue_GreenType;
        public static __ModelProperty ElementValue_GreenSyntaxCondition => _ElementValue_GreenSyntaxCondition;
        public static __ModelProperty ElementValue_RedType => _ElementValue_RedType;
        public static __ModelClassInfo EofInfo => __Impl.Eof_Impl.__Info.Instance;
        public static __ModelProperty Eof_GreenType => _Eof_GreenType;
        public static __ModelProperty Eof_GreenSyntaxCondition => _Eof_GreenSyntaxCondition;
        public static __ModelProperty Eof_RedType => _Eof_RedType;
        public static __ModelClassInfo ExpressionInfo => __Impl.Expression_Impl.__Info.Instance;
        public static __ModelProperty Expression_Value => _Expression_Value;
        public static __ModelClassInfo FixedInfo => __Impl.Fixed_Impl.__Info.Instance;
        public static __ModelProperty Fixed_Text => _Fixed_Text;
        public static __ModelClassInfo GrammarRuleInfo => __Impl.GrammarRule_Impl.__Info.Instance;
        public static __ModelProperty GrammarRule_Language => _GrammarRule_Language;
        public static __ModelProperty GrammarRule_Grammar => _GrammarRule_Grammar;
        public static __ModelClassInfo LanguageInfo => __Impl.Language_Impl.__Info.Instance;
        public static __ModelProperty Language_Namespace => _Language_Namespace;
        public static __ModelProperty Language_Grammar => _Language_Grammar;
        public static __ModelClassInfo LexerRuleInfo => __Impl.LexerRule_Impl.__Info.Instance;
        public static __ModelProperty LexerRule_Alternatives => _LexerRule_Alternatives;
        public static __ModelProperty LexerRule_IsFixed => _LexerRule_IsFixed;
        public static __ModelProperty LexerRule_FixedText => _LexerRule_FixedText;
        public static __ModelClassInfo FragmentInfo => __Impl.Fragment_Impl.__Info.Instance;
        public static __ModelClassInfo GrammarInfo => __Impl.Grammar_Impl.__Info.Instance;
        public static __ModelProperty Grammar_Language => _Grammar_Language;
        public static __ModelProperty Grammar_GrammarRules => _Grammar_GrammarRules;
        public static __ModelProperty Grammar_TokenKinds => _Grammar_TokenKinds;
        public static __ModelProperty Grammar_Tokens => _Grammar_Tokens;
        public static __ModelProperty Grammar_Rules => _Grammar_Rules;
        public static __ModelProperty Grammar_Blocks => _Grammar_Blocks;
        public static __ModelProperty Grammar_DefaultWhitespace => _Grammar_DefaultWhitespace;
        public static __ModelProperty Grammar_DefaultEndOfLine => _Grammar_DefaultEndOfLine;
        public static __ModelProperty Grammar_DefaultSeparator => _Grammar_DefaultSeparator;
        public static __ModelProperty Grammar_DefaultIdentifier => _Grammar_DefaultIdentifier;
        public static __ModelProperty Grammar_MainRule => _Grammar_MainRule;
        public static __ModelClassInfo LAlternativeInfo => __Impl.LAlternative_Impl.__Info.Instance;
        public static __ModelProperty LAlternative_IsFixed => _LAlternative_IsFixed;
        public static __ModelProperty LAlternative_FixedText => _LAlternative_FixedText;
        public static __ModelProperty LAlternative_Elements => _LAlternative_Elements;
        public static __ModelClassInfo LElementInfo => __Impl.LElement_Impl.__Info.Instance;
        public static __ModelProperty LElement_IsFixed => _LElement_IsFixed;
        public static __ModelProperty LElement_FixedText => _LElement_FixedText;
        public static __ModelProperty LElement_IsNegated => _LElement_IsNegated;
        public static __ModelProperty LElement_Value => _LElement_Value;
        public static __ModelProperty LElement_Multiplicity => _LElement_Multiplicity;
        public static __ModelClassInfo LElementValueInfo => __Impl.LElementValue_Impl.__Info.Instance;
        public static __ModelProperty LElementValue_IsFixed => _LElementValue_IsFixed;
        public static __ModelProperty LElementValue_FixedText => _LElementValue_FixedText;
        public static __ModelClassInfo LBlockInfo => __Impl.LBlock_Impl.__Info.Instance;
        public static __ModelProperty LBlock_IsFixed => _LBlock_IsFixed;
        public static __ModelProperty LBlock_FixedText => _LBlock_FixedText;
        public static __ModelProperty LBlock_Alternatives => _LBlock_Alternatives;
        public static __ModelClassInfo LFixedInfo => __Impl.LFixed_Impl.__Info.Instance;
        public static __ModelProperty LFixed_IsFixed => _LFixed_IsFixed;
        public static __ModelProperty LFixed_FixedText => _LFixed_FixedText;
        public static __ModelProperty LFixed_Text => _LFixed_Text;
        public static __ModelClassInfo LRangeInfo => __Impl.LRange_Impl.__Info.Instance;
        public static __ModelProperty LRange_IsFixed => _LRange_IsFixed;
        public static __ModelProperty LRange_FixedText => _LRange_FixedText;
        public static __ModelProperty LRange_StartChar => _LRange_StartChar;
        public static __ModelProperty LRange_EndChar => _LRange_EndChar;
        public static __ModelClassInfo LReferenceInfo => __Impl.LReference_Impl.__Info.Instance;
        public static __ModelProperty LReference_IsFixed => _LReference_IsFixed;
        public static __ModelProperty LReference_FixedText => _LReference_FixedText;
        public static __ModelProperty LReference_Rule => _LReference_Rule;
        public static __ModelClassInfo LSetInfo => __Impl.LSet_Impl.__Info.Instance;
        public static __ModelProperty LSet_IsFixed => _LSet_IsFixed;
        public static __ModelProperty LSet_FixedText => _LSet_FixedText;
        public static __ModelProperty LSet_Items => _LSet_Items;
        public static __ModelClassInfo LSetItemInfo => __Impl.LSetItem_Impl.__Info.Instance;
        public static __ModelProperty LSetItem_IsFixed => _LSetItem_IsFixed;
        public static __ModelProperty LSetItem_FixedText => _LSetItem_FixedText;
        public static __ModelClassInfo LSetCharInfo => __Impl.LSetChar_Impl.__Info.Instance;
        public static __ModelProperty LSetChar_IsFixed => _LSetChar_IsFixed;
        public static __ModelProperty LSetChar_FixedText => _LSetChar_FixedText;
        public static __ModelProperty LSetChar_Char => _LSetChar_Char;
        public static __ModelClassInfo LSetRangeInfo => __Impl.LSetRange_Impl.__Info.Instance;
        public static __ModelProperty LSetRange_IsFixed => _LSetRange_IsFixed;
        public static __ModelProperty LSetRange_FixedText => _LSetRange_FixedText;
        public static __ModelProperty LSetRange_StartChar => _LSetRange_StartChar;
        public static __ModelProperty LSetRange_EndChar => _LSetRange_EndChar;
        public static __ModelClassInfo LWildCardInfo => __Impl.LWildCard_Impl.__Info.Instance;
        public static __ModelProperty LWildCard_IsFixed => _LWildCard_IsFixed;
        public static __ModelProperty LWildCard_FixedText => _LWildCard_FixedText;
        public static __ModelClassInfo NamespaceInfo => __Impl.Namespace_Impl.__Info.Instance;
        public static __ModelClassInfo RuleInfo => __Impl.Rule_Impl.__Info.Instance;
        public static __ModelProperty Rule_ReturnType => _Rule_ReturnType;
        public static __ModelProperty Rule_Alternatives => _Rule_Alternatives;
        public static __ModelProperty Rule_BaseRule => _Rule_BaseRule;
        public static __ModelProperty Rule_GreenName => _Rule_GreenName;
        public static __ModelProperty Rule_RedName => _Rule_RedName;
        public static __ModelClassInfo RuleRefInfo => __Impl.RuleRef_Impl.__Info.Instance;
        public static __ModelProperty RuleRef_GrammarRule => _RuleRef_GrammarRule;
        public static __ModelProperty RuleRef_ReferencedTypes => _RuleRef_ReferencedTypes;
        public static __ModelProperty RuleRef_Token => _RuleRef_Token;
        public static __ModelProperty RuleRef_Rule => _RuleRef_Rule;
        public static __ModelProperty RuleRef_GreenType => _RuleRef_GreenType;
        public static __ModelProperty RuleRef_GreenSyntaxCondition => _RuleRef_GreenSyntaxCondition;
        public static __ModelProperty RuleRef_RedType => _RuleRef_RedType;
        public static __ModelClassInfo SeparatedListInfo => __Impl.SeparatedList_Impl.__Info.Instance;
        public static __ModelProperty SeparatedList_SeparatorFirst => _SeparatedList_SeparatorFirst;
        public static __ModelProperty SeparatedList_RepeatedSeparatorFirst => _SeparatedList_RepeatedSeparatorFirst;
        public static __ModelProperty SeparatedList_FirstItems => _SeparatedList_FirstItems;
        public static __ModelProperty SeparatedList_FirstSeparators => _SeparatedList_FirstSeparators;
        public static __ModelProperty SeparatedList_RepeatedBlock => _SeparatedList_RepeatedBlock;
        public static __ModelProperty SeparatedList_RepeatedItem => _SeparatedList_RepeatedItem;
        public static __ModelProperty SeparatedList_RepeatedSeparator => _SeparatedList_RepeatedSeparator;
        public static __ModelProperty SeparatedList_LastItems => _SeparatedList_LastItems;
        public static __ModelProperty SeparatedList_LastSeparators => _SeparatedList_LastSeparators;
        public static __ModelProperty SeparatedList_GreenType => _SeparatedList_GreenType;
        public static __ModelProperty SeparatedList_GreenSyntaxCondition => _SeparatedList_GreenSyntaxCondition;
        public static __ModelProperty SeparatedList_RedType => _SeparatedList_RedType;
        public static __ModelClassInfo TokenInfo => __Impl.Token_Impl.__Info.Instance;
        public static __ModelProperty Token_ReturnType => _Token_ReturnType;
        public static __ModelProperty Token_IsTrivia => _Token_IsTrivia;
        public static __ModelProperty Token_TokenKind => _Token_TokenKind;
        public static __ModelClassInfo TokenAltsInfo => __Impl.TokenAlts_Impl.__Info.Instance;
        public static __ModelProperty TokenAlts_Tokens => _TokenAlts_Tokens;
        public static __ModelProperty TokenAlts_GreenType => _TokenAlts_GreenType;
        public static __ModelProperty TokenAlts_GreenSyntaxCondition => _TokenAlts_GreenSyntaxCondition;
        public static __ModelProperty TokenAlts_RedType => _TokenAlts_RedType;
        public static __ModelClassInfo TokenKindInfo => __Impl.TokenKind_Impl.__Info.Instance;
        public static __ModelProperty TokenKind_Name => _TokenKind_Name;
        public static __ModelProperty TokenKind_TypeName => _TokenKind_TypeName;
    }

    public class CompilerModelFactory : __ModelFactory
    {
        public CompilerModelFactory(__Model model)
            : base(model, Compiler.MInstance)
        {
        }
    
        public Annotation Annotation(string? id = null)
        {
            return (Annotation)Compiler.AnnotationInfo.Create(Model, id)!;
        }
    
        public AnnotationArgument AnnotationArgument(string? id = null)
        {
            return (AnnotationArgument)Compiler.AnnotationArgumentInfo.Create(Model, id)!;
        }
    
        public ArrayExpression ArrayExpression(string? id = null)
        {
            return (ArrayExpression)Compiler.ArrayExpressionInfo.Create(Model, id)!;
        }
    
        public Binder Binder(string? id = null)
        {
            return (Binder)Compiler.BinderInfo.Create(Model, id)!;
        }
    
        public BinderArgument BinderArgument(string? id = null)
        {
            return (BinderArgument)Compiler.BinderArgumentInfo.Create(Model, id)!;
        }
    
        public CSharpElement CSharpElement(string? id = null)
        {
            return (CSharpElement)Compiler.CSharpElementInfo.Create(Model, id)!;
        }
    
        public Block Block(string? id = null)
        {
            return (Block)Compiler.BlockInfo.Create(Model, id)!;
        }
    
        public Alternative Alternative(string? id = null)
        {
            return (Alternative)Compiler.AlternativeInfo.Create(Model, id)!;
        }
    
        public Element Element(string? id = null)
        {
            return (Element)Compiler.ElementInfo.Create(Model, id)!;
        }
    
        public Eof Eof(string? id = null)
        {
            return (Eof)Compiler.EofInfo.Create(Model, id)!;
        }
    
        public Expression Expression(string? id = null)
        {
            return (Expression)Compiler.ExpressionInfo.Create(Model, id)!;
        }
    
        public Fixed Fixed(string? id = null)
        {
            return (Fixed)Compiler.FixedInfo.Create(Model, id)!;
        }
    
        public Language Language(string? id = null)
        {
            return (Language)Compiler.LanguageInfo.Create(Model, id)!;
        }
    
        public Fragment Fragment(string? id = null)
        {
            return (Fragment)Compiler.FragmentInfo.Create(Model, id)!;
        }
    
        public Grammar Grammar(string? id = null)
        {
            return (Grammar)Compiler.GrammarInfo.Create(Model, id)!;
        }
    
        public LAlternative LAlternative(string? id = null)
        {
            return (LAlternative)Compiler.LAlternativeInfo.Create(Model, id)!;
        }
    
        public LElement LElement(string? id = null)
        {
            return (LElement)Compiler.LElementInfo.Create(Model, id)!;
        }
    
        public LBlock LBlock(string? id = null)
        {
            return (LBlock)Compiler.LBlockInfo.Create(Model, id)!;
        }
    
        public LFixed LFixed(string? id = null)
        {
            return (LFixed)Compiler.LFixedInfo.Create(Model, id)!;
        }
    
        public LRange LRange(string? id = null)
        {
            return (LRange)Compiler.LRangeInfo.Create(Model, id)!;
        }
    
        public LReference LReference(string? id = null)
        {
            return (LReference)Compiler.LReferenceInfo.Create(Model, id)!;
        }
    
        public LSet LSet(string? id = null)
        {
            return (LSet)Compiler.LSetInfo.Create(Model, id)!;
        }
    
        public LSetChar LSetChar(string? id = null)
        {
            return (LSetChar)Compiler.LSetCharInfo.Create(Model, id)!;
        }
    
        public LSetRange LSetRange(string? id = null)
        {
            return (LSetRange)Compiler.LSetRangeInfo.Create(Model, id)!;
        }
    
        public LWildCard LWildCard(string? id = null)
        {
            return (LWildCard)Compiler.LWildCardInfo.Create(Model, id)!;
        }
    
        public Namespace Namespace(string? id = null)
        {
            return (Namespace)Compiler.NamespaceInfo.Create(Model, id)!;
        }
    
        public Rule Rule(string? id = null)
        {
            return (Rule)Compiler.RuleInfo.Create(Model, id)!;
        }
    
        public RuleRef RuleRef(string? id = null)
        {
            return (RuleRef)Compiler.RuleRefInfo.Create(Model, id)!;
        }
    
        public SeparatedList SeparatedList(string? id = null)
        {
            return (SeparatedList)Compiler.SeparatedListInfo.Create(Model, id)!;
        }
    
        public Token Token(string? id = null)
        {
            return (Token)Compiler.TokenInfo.Create(Model, id)!;
        }
    
        public TokenAlts TokenAlts(string? id = null)
        {
            return (TokenAlts)Compiler.TokenAltsInfo.Create(Model, id)!;
        }
    
        public TokenKind TokenKind(string? id = null)
        {
            return (TokenKind)Compiler.TokenKindInfo.Create(Model, id)!;
        }
    
    }
    
    public class CompilerModelMultiFactory : __MultiModelFactory
    {
        public CompilerModelMultiFactory()
            : base(new __MetaModel[] { Compiler.MInstance })
        {
        }
    
        public Annotation Annotation(__Model model, string? id = null)
        {
            return (Annotation)Compiler.AnnotationInfo.Create(model, id)!;
        }
    
        public AnnotationArgument AnnotationArgument(__Model model, string? id = null)
        {
            return (AnnotationArgument)Compiler.AnnotationArgumentInfo.Create(model, id)!;
        }
    
        public ArrayExpression ArrayExpression(__Model model, string? id = null)
        {
            return (ArrayExpression)Compiler.ArrayExpressionInfo.Create(model, id)!;
        }
    
        public Binder Binder(__Model model, string? id = null)
        {
            return (Binder)Compiler.BinderInfo.Create(model, id)!;
        }
    
        public BinderArgument BinderArgument(__Model model, string? id = null)
        {
            return (BinderArgument)Compiler.BinderArgumentInfo.Create(model, id)!;
        }
    
        public CSharpElement CSharpElement(__Model model, string? id = null)
        {
            return (CSharpElement)Compiler.CSharpElementInfo.Create(model, id)!;
        }
    
        public Block Block(__Model model, string? id = null)
        {
            return (Block)Compiler.BlockInfo.Create(model, id)!;
        }
    
        public Alternative Alternative(__Model model, string? id = null)
        {
            return (Alternative)Compiler.AlternativeInfo.Create(model, id)!;
        }
    
        public Element Element(__Model model, string? id = null)
        {
            return (Element)Compiler.ElementInfo.Create(model, id)!;
        }
    
        public Eof Eof(__Model model, string? id = null)
        {
            return (Eof)Compiler.EofInfo.Create(model, id)!;
        }
    
        public Expression Expression(__Model model, string? id = null)
        {
            return (Expression)Compiler.ExpressionInfo.Create(model, id)!;
        }
    
        public Fixed Fixed(__Model model, string? id = null)
        {
            return (Fixed)Compiler.FixedInfo.Create(model, id)!;
        }
    
        public Language Language(__Model model, string? id = null)
        {
            return (Language)Compiler.LanguageInfo.Create(model, id)!;
        }
    
        public Fragment Fragment(__Model model, string? id = null)
        {
            return (Fragment)Compiler.FragmentInfo.Create(model, id)!;
        }
    
        public Grammar Grammar(__Model model, string? id = null)
        {
            return (Grammar)Compiler.GrammarInfo.Create(model, id)!;
        }
    
        public LAlternative LAlternative(__Model model, string? id = null)
        {
            return (LAlternative)Compiler.LAlternativeInfo.Create(model, id)!;
        }
    
        public LElement LElement(__Model model, string? id = null)
        {
            return (LElement)Compiler.LElementInfo.Create(model, id)!;
        }
    
        public LBlock LBlock(__Model model, string? id = null)
        {
            return (LBlock)Compiler.LBlockInfo.Create(model, id)!;
        }
    
        public LFixed LFixed(__Model model, string? id = null)
        {
            return (LFixed)Compiler.LFixedInfo.Create(model, id)!;
        }
    
        public LRange LRange(__Model model, string? id = null)
        {
            return (LRange)Compiler.LRangeInfo.Create(model, id)!;
        }
    
        public LReference LReference(__Model model, string? id = null)
        {
            return (LReference)Compiler.LReferenceInfo.Create(model, id)!;
        }
    
        public LSet LSet(__Model model, string? id = null)
        {
            return (LSet)Compiler.LSetInfo.Create(model, id)!;
        }
    
        public LSetChar LSetChar(__Model model, string? id = null)
        {
            return (LSetChar)Compiler.LSetCharInfo.Create(model, id)!;
        }
    
        public LSetRange LSetRange(__Model model, string? id = null)
        {
            return (LSetRange)Compiler.LSetRangeInfo.Create(model, id)!;
        }
    
        public LWildCard LWildCard(__Model model, string? id = null)
        {
            return (LWildCard)Compiler.LWildCardInfo.Create(model, id)!;
        }
    
        public Namespace Namespace(__Model model, string? id = null)
        {
            return (Namespace)Compiler.NamespaceInfo.Create(model, id)!;
        }
    
        public Rule Rule(__Model model, string? id = null)
        {
            return (Rule)Compiler.RuleInfo.Create(model, id)!;
        }
    
        public RuleRef RuleRef(__Model model, string? id = null)
        {
            return (RuleRef)Compiler.RuleRefInfo.Create(model, id)!;
        }
    
        public SeparatedList SeparatedList(__Model model, string? id = null)
        {
            return (SeparatedList)Compiler.SeparatedListInfo.Create(model, id)!;
        }
    
        public Token Token(__Model model, string? id = null)
        {
            return (Token)Compiler.TokenInfo.Create(model, id)!;
        }
    
        public TokenAlts TokenAlts(__Model model, string? id = null)
        {
            return (TokenAlts)Compiler.TokenAltsInfo.Create(model, id)!;
        }
    
        public TokenKind TokenKind(__Model model, string? id = null)
        {
            return (TokenKind)Compiler.TokenKindInfo.Create(model, id)!;
        }
    
    }
    

    public enum Assignment
    {
        Assign,
        QuestionAssign,
        NegatedAssign,
        PlusAssign,
    }

    public enum Multiplicity
    {
        ExactlyOne,
        ZeroOrOne,
        ZeroOrMore,
        OneOrMore,
        NonGreedyZeroOrOne,
        NonGreedyZeroOrMore,
        NonGreedyOneOrMore,
    }


    public interface Annotation : __IModelObject
    {
        global::MetaDslx.Modeling.ICollectionSlot<AnnotationArgument> Arguments { get; }
        global::MetaDslx.CodeAnalysis.MetaType AttributeClass { get; set; }
    
    }

    public interface AnnotationArgument : __IModelObject
    {
        global::MetaDslx.Modeling.ICollectionSlot<global::MetaDslx.CodeAnalysis.MetaSymbol> NamedParameter { get; }
        global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol Parameter { get; set; }
        global::MetaDslx.CodeAnalysis.MetaType ParameterType { get; set; }
        Expression Value { get; set; }
    
    }

    public interface ArrayExpression : global::MetaDslx.Bootstrap.MetaCompiler.Model.Expression
    {
        global::MetaDslx.Modeling.ICollectionSlot<Expression> Items { get; }
    
    }

    public interface Binder : __IModelObject
    {
        global::MetaDslx.Modeling.ICollectionSlot<BinderArgument> Arguments { get; }
        global::System.String ConstructorArguments { get; }
        global::System.Boolean IsNegated { get; set; }
        global::System.String TypeName { get; set; }
    
    }

    public interface BinderArgument : __IModelObject
    {
        global::System.Boolean IsArray { get; set; }
        global::System.String Name { get; set; }
        global::System.String TypeName { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<global::System.String?> Values { get; }
    
    }

    public interface CSharpElement : __IModelObject
    {
        global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations { get; }
        global::System.String AntlrName { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders { get; }
        global::System.Boolean ContainsBinders { get; set; }
        global::System.String CSharpName { get; set; }
    
    }

    public interface Block : global::MetaDslx.Bootstrap.MetaCompiler.Model.ElementValue
    {
        global::MetaDslx.Modeling.ICollectionSlot<Alternative> Alternatives { get; }
        global::System.String GreenName { get; }
        new global::System.String? GreenSyntaxCondition { get; }
        new global::System.String GreenType { get; }
        global::System.String RedName { get; }
        new global::System.String RedType { get; }
    
    }

    public interface Declaration : __IModelObject
    {
        global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations { get; }
        global::System.String? FullName { get; }
        global::System.String? Name { get; set; }
        Declaration? Parent { get; set; }
    
    }

    public interface Alternative : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration, global::MetaDslx.Bootstrap.MetaCompiler.Model.CSharpElement
    {
        global::MetaDslx.Modeling.ICollectionSlot<Element> Elements { get; }
        global::System.String GreenConstructorArguments { get; }
        global::System.String GreenConstructorParameters { get; }
        global::System.String GreenName { get; }
        global::System.String GreenUpdateArguments { get; }
        global::System.String GreenUpdateParameters { get; }
        global::System.Boolean HasRedToGreenOptionalArguments { get; }
        global::System.String RedName { get; }
        global::System.String RedOptionalUpdateParameters { get; }
        global::System.String RedToGreenArgumentList { get; }
        global::System.String RedToGreenOptionalArgumentList { get; }
        global::System.String RedUpdateArguments { get; }
        global::System.String RedUpdateParameters { get; }
        global::MetaDslx.CodeAnalysis.MetaType ReturnType { get; set; }
        Expression ReturnValue { get; set; }
    
    }

    public interface Element : global::MetaDslx.Bootstrap.MetaCompiler.Model.CSharpElement
    {
        global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment { get; set; }
        global::System.String FieldName { get; }
        global::System.String GreenFieldType { get; }
        global::System.String GreenParameterValue { get; }
        global::System.String GreenPropertyType { get; }
        global::System.String GreenPropertyValue { get; }
        global::System.String? GreenSyntaxCondition { get; }
        global::System.String? GreenSyntaxNullCondition { get; }
        global::System.Boolean IsList { get; }
        global::System.Boolean IsOptionalUpdateParameter { get; }
        global::System.Boolean IsToken { get; }
        global::System.String? Name { get; set; }
        global::System.String ParameterName { get; }
        global::System.String PropertyName { get; }
        global::System.String RedFieldType { get; }
        global::System.String RedParameterValue { get; }
        global::System.String RedPropertyType { get; }
        global::System.String RedPropertyValue { get; }
        global::System.String? RedSyntaxCondition { get; }
        global::System.String? RedSyntaxNullCondition { get; }
        global::System.String RedToGreenArgument { get; }
        global::System.String RedToGreenOptionalArgument { get; }
        ElementValue Value { get; set; }
        global::System.String? VisitCall { get; }
    
    }

    public interface ElementValue : global::MetaDslx.Bootstrap.MetaCompiler.Model.CSharpElement
    {
        global::System.String? GreenSyntaxCondition { get; }
        global::System.String GreenType { get; }
        global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity { get; set; }
        global::System.String RedType { get; }
    
    }

    public interface Eof : global::MetaDslx.Bootstrap.MetaCompiler.Model.ElementValue
    {
        new global::System.String? GreenSyntaxCondition { get; }
        new global::System.String GreenType { get; }
        new global::System.String RedType { get; }
    
    }

    public interface Expression : __IModelObject
    {
        global::MetaDslx.CodeAnalysis.MetaSymbol Value { get; set; }
    
    }

    public interface Fixed : global::MetaDslx.Bootstrap.MetaCompiler.Model.ElementValue
    {
        global::System.String Text { get; set; }
    
    }

    public interface GrammarRule : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration, global::MetaDslx.Bootstrap.MetaCompiler.Model.CSharpElement
    {
        Grammar Grammar { get; set; }
        Language Language { get; }
    
    }

    public interface Language : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
    {
        Grammar Grammar { get; set; }
        global::System.String Namespace { get; }
    
    }

    public interface LexerRule : global::MetaDslx.Bootstrap.MetaCompiler.Model.GrammarRule
    {
        global::MetaDslx.Modeling.ICollectionSlot<LAlternative> Alternatives { get; }
        global::System.String? FixedText { get; }
        global::System.Boolean IsFixed { get; }
    
    }

    public interface Fragment : global::MetaDslx.Bootstrap.MetaCompiler.Model.LexerRule
    {
    
    }

    public interface Grammar : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
    {
        global::MetaDslx.Modeling.ICollectionSlot<Block> Blocks { get; }
        Token? DefaultEndOfLine { get; set; }
        Token? DefaultIdentifier { get; set; }
        Token? DefaultSeparator { get; set; }
        Token? DefaultWhitespace { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<GrammarRule> GrammarRules { get; }
        Language Language { get; set; }
        Rule? MainRule { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<Rule> Rules { get; }
        global::MetaDslx.Modeling.ICollectionSlot<TokenKind> TokenKinds { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Token> Tokens { get; }
    
    }

    public interface LAlternative : __IModelObject
    {
        global::MetaDslx.Modeling.ICollectionSlot<LElement> Elements { get; }
        global::System.String? FixedText { get; }
        global::System.Boolean IsFixed { get; }
    
    }

    public interface LElement : __IModelObject
    {
        global::System.String? FixedText { get; }
        global::System.Boolean IsFixed { get; }
        global::System.Boolean IsNegated { get; set; }
        global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity { get; set; }
        LElementValue Value { get; set; }
    
    }

    public interface LElementValue : __IModelObject
    {
        global::System.String? FixedText { get; }
        global::System.Boolean IsFixed { get; }
    
    }

    public interface LBlock : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
    {
        global::MetaDslx.Modeling.ICollectionSlot<LAlternative> Alternatives { get; }
        new global::System.String? FixedText { get; }
        new global::System.Boolean IsFixed { get; }
    
    }

    public interface LFixed : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
    {
        new global::System.String? FixedText { get; }
        new global::System.Boolean IsFixed { get; }
        global::System.String Text { get; set; }
    
    }

    public interface LRange : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
    {
        global::System.String EndChar { get; set; }
        new global::System.String? FixedText { get; }
        new global::System.Boolean IsFixed { get; }
        global::System.String StartChar { get; set; }
    
    }

    public interface LReference : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
    {
        new global::System.String? FixedText { get; }
        new global::System.Boolean IsFixed { get; }
        LexerRule Rule { get; set; }
    
    }

    public interface LSet : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
    {
        new global::System.String? FixedText { get; }
        new global::System.Boolean IsFixed { get; }
        global::MetaDslx.Modeling.ICollectionSlot<LSetItem> Items { get; }
    
    }

    public interface LSetItem : __IModelObject
    {
        global::System.String? FixedText { get; }
        global::System.Boolean IsFixed { get; }
    
    }

    public interface LSetChar : global::MetaDslx.Bootstrap.MetaCompiler.Model.LSetItem
    {
        global::System.String Char { get; set; }
        new global::System.String? FixedText { get; }
        new global::System.Boolean IsFixed { get; }
    
    }

    public interface LSetRange : global::MetaDslx.Bootstrap.MetaCompiler.Model.LSetItem
    {
        global::System.String EndChar { get; set; }
        new global::System.String? FixedText { get; }
        new global::System.Boolean IsFixed { get; }
        global::System.String StartChar { get; set; }
    
    }

    public interface LWildCard : global::MetaDslx.Bootstrap.MetaCompiler.Model.LElementValue
    {
        new global::System.String? FixedText { get; }
        new global::System.Boolean IsFixed { get; }
    
    }

    public interface Namespace : global::MetaDslx.Bootstrap.MetaCompiler.Model.Declaration
    {
    
    }

    public interface Rule : global::MetaDslx.Bootstrap.MetaCompiler.Model.GrammarRule
    {
        global::MetaDslx.Modeling.ICollectionSlot<Alternative> Alternatives { get; }
        Alternative? BaseRule { get; set; }
        global::System.String GreenName { get; }
        global::System.String RedName { get; }
        global::MetaDslx.CodeAnalysis.MetaType ReturnType { get; set; }
    
    }

    public interface RuleRef : global::MetaDslx.Bootstrap.MetaCompiler.Model.ElementValue
    {
        GrammarRule GrammarRule { get; set; }
        new global::System.String? GreenSyntaxCondition { get; }
        new global::System.String GreenType { get; }
        new global::System.String RedType { get; }
        global::MetaDslx.Modeling.ICollectionSlot<global::MetaDslx.CodeAnalysis.MetaType> ReferencedTypes { get; }
        Rule? Rule { get; }
        Token? Token { get; }
    
    }

    public interface SeparatedList : global::MetaDslx.Bootstrap.MetaCompiler.Model.ElementValue
    {
        global::MetaDslx.Modeling.ICollectionSlot<Element> FirstItems { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Element> FirstSeparators { get; }
        new global::System.String? GreenSyntaxCondition { get; }
        new global::System.String GreenType { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Element> LastItems { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Element> LastSeparators { get; }
        new global::System.String RedType { get; }
        Element RepeatedBlock { get; set; }
        Element RepeatedItem { get; set; }
        Element RepeatedSeparator { get; set; }
        global::System.Boolean RepeatedSeparatorFirst { get; set; }
        global::System.Boolean SeparatorFirst { get; set; }
    
    }

    public interface Token : global::MetaDslx.Bootstrap.MetaCompiler.Model.LexerRule
    {
        global::System.Boolean IsTrivia { get; set; }
        global::MetaDslx.CodeAnalysis.MetaType ReturnType { get; set; }
        TokenKind? TokenKind { get; set; }
    
    }

    public interface TokenAlts : global::MetaDslx.Bootstrap.MetaCompiler.Model.ElementValue
    {
        new global::System.String? GreenSyntaxCondition { get; }
        new global::System.String GreenType { get; }
        new global::System.String RedType { get; }
        global::MetaDslx.Modeling.ICollectionSlot<RuleRef> Tokens { get; }
    
    }

    public interface TokenKind : __IModelObject
    {
        global::System.String Name { get; set; }
        global::System.String TypeName { get; set; }
    
    }


    internal interface ICustomCompilerImplementation
    {
        /// <summary>
        /// Constructor for the meta model Compiler
        /// </summary>
        void Compiler(ICompiler _this);
    
        /// <summary>
        /// Constructor for the class Annotation
        /// </summary>
        void Annotation(Annotation _this);
    
        /// <summary>
        /// Constructor for the class AnnotationArgument
        /// </summary>
        void AnnotationArgument(AnnotationArgument _this);
    
        /// <summary>
        /// Constructor for the class ArrayExpression
        /// </summary>
        void ArrayExpression(ArrayExpression _this);
    
        /// <summary>
        /// Constructor for the class Binder
        /// </summary>
        void Binder(Binder _this);
    
        /// <summary>
        /// Constructor for the class BinderArgument
        /// </summary>
        void BinderArgument(BinderArgument _this);
    
        /// <summary>
        /// Constructor for the class CSharpElement
        /// </summary>
        void CSharpElement(CSharpElement _this);
    
        /// <summary>
        /// Constructor for the class Block
        /// </summary>
        void Block(Block _this);
    
        /// <summary>
        /// Constructor for the class Declaration
        /// </summary>
        void Declaration(Declaration _this);
    
        /// <summary>
        /// Constructor for the class Alternative
        /// </summary>
        void Alternative(Alternative _this);
    
        /// <summary>
        /// Constructor for the class Element
        /// </summary>
        void Element(Element _this);
    
        /// <summary>
        /// Constructor for the class ElementValue
        /// </summary>
        void ElementValue(ElementValue _this);
    
        /// <summary>
        /// Constructor for the class Eof
        /// </summary>
        void Eof(Eof _this);
    
        /// <summary>
        /// Constructor for the class Expression
        /// </summary>
        void Expression(Expression _this);
    
        /// <summary>
        /// Constructor for the class Fixed
        /// </summary>
        void Fixed(Fixed _this);
    
        /// <summary>
        /// Constructor for the class GrammarRule
        /// </summary>
        void GrammarRule(GrammarRule _this);
    
        /// <summary>
        /// Constructor for the class Language
        /// </summary>
        void Language(Language _this);
    
        /// <summary>
        /// Constructor for the class LexerRule
        /// </summary>
        void LexerRule(LexerRule _this);
    
        /// <summary>
        /// Constructor for the class Fragment
        /// </summary>
        void Fragment(Fragment _this);
    
        /// <summary>
        /// Constructor for the class Grammar
        /// </summary>
        void Grammar(Grammar _this);
    
        /// <summary>
        /// Constructor for the class LAlternative
        /// </summary>
        void LAlternative(LAlternative _this);
    
        /// <summary>
        /// Constructor for the class LElement
        /// </summary>
        void LElement(LElement _this);
    
        /// <summary>
        /// Constructor for the class LElementValue
        /// </summary>
        void LElementValue(LElementValue _this);
    
        /// <summary>
        /// Constructor for the class LBlock
        /// </summary>
        void LBlock(LBlock _this);
    
        /// <summary>
        /// Constructor for the class LFixed
        /// </summary>
        void LFixed(LFixed _this);
    
        /// <summary>
        /// Constructor for the class LRange
        /// </summary>
        void LRange(LRange _this);
    
        /// <summary>
        /// Constructor for the class LReference
        /// </summary>
        void LReference(LReference _this);
    
        /// <summary>
        /// Constructor for the class LSet
        /// </summary>
        void LSet(LSet _this);
    
        /// <summary>
        /// Constructor for the class LSetItem
        /// </summary>
        void LSetItem(LSetItem _this);
    
        /// <summary>
        /// Constructor for the class LSetChar
        /// </summary>
        void LSetChar(LSetChar _this);
    
        /// <summary>
        /// Constructor for the class LSetRange
        /// </summary>
        void LSetRange(LSetRange _this);
    
        /// <summary>
        /// Constructor for the class LWildCard
        /// </summary>
        void LWildCard(LWildCard _this);
    
        /// <summary>
        /// Constructor for the class Namespace
        /// </summary>
        void Namespace(Namespace _this);
    
        /// <summary>
        /// Constructor for the class Rule
        /// </summary>
        void Rule(Rule _this);
    
        /// <summary>
        /// Constructor for the class RuleRef
        /// </summary>
        void RuleRef(RuleRef _this);
    
        /// <summary>
        /// Constructor for the class SeparatedList
        /// </summary>
        void SeparatedList(SeparatedList _this);
    
        /// <summary>
        /// Constructor for the class Token
        /// </summary>
        void Token(Token _this);
    
        /// <summary>
        /// Constructor for the class TokenAlts
        /// </summary>
        void TokenAlts(TokenAlts _this);
    
        /// <summary>
        /// Constructor for the class TokenKind
        /// </summary>
        void TokenKind(TokenKind _this);
    
    
        /// <summary>
        /// Computation of the derived property Binder.ConstructorArguments
        /// </summary>
        global::System.String Binder_ConstructorArguments(Binder _this);
    
        /// <summary>
        /// Computation of the derived property Block.GreenName
        /// </summary>
        global::System.String Block_GreenName(Block _this);
    
        /// <summary>
        /// Computation of the derived property Block.RedName
        /// </summary>
        global::System.String Block_RedName(Block _this);
    
        /// <summary>
        /// Computation of the derived property Block.GreenType
        /// </summary>
        global::System.String Block_GreenType(Block _this);
    
        /// <summary>
        /// Computation of the derived property Block.GreenSyntaxCondition
        /// </summary>
        global::System.String? Block_GreenSyntaxCondition(Block _this);
    
        /// <summary>
        /// Computation of the derived property Block.RedType
        /// </summary>
        global::System.String Block_RedType(Block _this);
    
        /// <summary>
        /// Computation of the derived property Declaration.FullName
        /// </summary>
        global::System.String? Declaration_FullName(Declaration _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenName
        /// </summary>
        global::System.String Alternative_GreenName(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenConstructorParameters
        /// </summary>
        global::System.String Alternative_GreenConstructorParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenConstructorArguments
        /// </summary>
        global::System.String Alternative_GreenConstructorArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenUpdateParameters
        /// </summary>
        global::System.String Alternative_GreenUpdateParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenUpdateArguments
        /// </summary>
        global::System.String Alternative_GreenUpdateArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedName
        /// </summary>
        global::System.String Alternative_RedName(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedUpdateParameters
        /// </summary>
        global::System.String Alternative_RedUpdateParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedUpdateArguments
        /// </summary>
        global::System.String Alternative_RedUpdateArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedOptionalUpdateParameters
        /// </summary>
        global::System.String Alternative_RedOptionalUpdateParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedToGreenArgumentList
        /// </summary>
        global::System.String Alternative_RedToGreenArgumentList(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedToGreenOptionalArgumentList
        /// </summary>
        global::System.String Alternative_RedToGreenOptionalArgumentList(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.HasRedToGreenOptionalArguments
        /// </summary>
        global::System.Boolean Alternative_HasRedToGreenOptionalArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Element.IsToken
        /// </summary>
        global::System.Boolean Element_IsToken(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.IsList
        /// </summary>
        global::System.Boolean Element_IsList(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.FieldName
        /// </summary>
        global::System.String Element_FieldName(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.ParameterName
        /// </summary>
        global::System.String Element_ParameterName(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.PropertyName
        /// </summary>
        global::System.String Element_PropertyName(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenFieldType
        /// </summary>
        global::System.String Element_GreenFieldType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenParameterValue
        /// </summary>
        global::System.String Element_GreenParameterValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenPropertyType
        /// </summary>
        global::System.String Element_GreenPropertyType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenPropertyValue
        /// </summary>
        global::System.String Element_GreenPropertyValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenSyntaxNullCondition
        /// </summary>
        global::System.String? Element_GreenSyntaxNullCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenSyntaxCondition
        /// </summary>
        global::System.String? Element_GreenSyntaxCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.IsOptionalUpdateParameter
        /// </summary>
        global::System.Boolean Element_IsOptionalUpdateParameter(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedFieldType
        /// </summary>
        global::System.String Element_RedFieldType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedParameterValue
        /// </summary>
        global::System.String Element_RedParameterValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedPropertyType
        /// </summary>
        global::System.String Element_RedPropertyType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedPropertyValue
        /// </summary>
        global::System.String Element_RedPropertyValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedToGreenArgument
        /// </summary>
        global::System.String Element_RedToGreenArgument(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedToGreenOptionalArgument
        /// </summary>
        global::System.String Element_RedToGreenOptionalArgument(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedSyntaxNullCondition
        /// </summary>
        global::System.String? Element_RedSyntaxNullCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedSyntaxCondition
        /// </summary>
        global::System.String? Element_RedSyntaxCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.VisitCall
        /// </summary>
        global::System.String? Element_VisitCall(Element _this);
    
        /// <summary>
        /// Computation of the derived property ElementValue.GreenType
        /// </summary>
        global::System.String ElementValue_GreenType(ElementValue _this);
    
        /// <summary>
        /// Computation of the derived property ElementValue.GreenSyntaxCondition
        /// </summary>
        global::System.String? ElementValue_GreenSyntaxCondition(ElementValue _this);
    
        /// <summary>
        /// Computation of the derived property ElementValue.RedType
        /// </summary>
        global::System.String ElementValue_RedType(ElementValue _this);
    
        /// <summary>
        /// Computation of the derived property Eof.GreenType
        /// </summary>
        global::System.String Eof_GreenType(Eof _this);
    
        /// <summary>
        /// Computation of the derived property Eof.GreenSyntaxCondition
        /// </summary>
        global::System.String? Eof_GreenSyntaxCondition(Eof _this);
    
        /// <summary>
        /// Computation of the derived property Eof.RedType
        /// </summary>
        global::System.String Eof_RedType(Eof _this);
    
        /// <summary>
        /// Computation of the derived property GrammarRule.Language
        /// </summary>
        Language GrammarRule_Language(GrammarRule _this);
    
        /// <summary>
        /// Computation of the derived property Language.Namespace
        /// </summary>
        global::System.String Language_Namespace(Language _this);
    
        /// <summary>
        /// Computation of the derived property LexerRule.IsFixed
        /// </summary>
        global::System.Boolean LexerRule_IsFixed(LexerRule _this);
    
        /// <summary>
        /// Computation of the derived property LexerRule.FixedText
        /// </summary>
        global::System.String? LexerRule_FixedText(LexerRule _this);
    
        /// <summary>
        /// Computation of the derived property LAlternative.IsFixed
        /// </summary>
        global::System.Boolean LAlternative_IsFixed(LAlternative _this);
    
        /// <summary>
        /// Computation of the derived property LAlternative.FixedText
        /// </summary>
        global::System.String? LAlternative_FixedText(LAlternative _this);
    
        /// <summary>
        /// Computation of the derived property LElement.IsFixed
        /// </summary>
        global::System.Boolean LElement_IsFixed(LElement _this);
    
        /// <summary>
        /// Computation of the derived property LElement.FixedText
        /// </summary>
        global::System.String? LElement_FixedText(LElement _this);
    
        /// <summary>
        /// Computation of the derived property LElementValue.IsFixed
        /// </summary>
        global::System.Boolean LElementValue_IsFixed(LElementValue _this);
    
        /// <summary>
        /// Computation of the derived property LElementValue.FixedText
        /// </summary>
        global::System.String? LElementValue_FixedText(LElementValue _this);
    
        /// <summary>
        /// Computation of the derived property LBlock.IsFixed
        /// </summary>
        global::System.Boolean LBlock_IsFixed(LBlock _this);
    
        /// <summary>
        /// Computation of the derived property LBlock.FixedText
        /// </summary>
        global::System.String? LBlock_FixedText(LBlock _this);
    
        /// <summary>
        /// Computation of the derived property LFixed.IsFixed
        /// </summary>
        global::System.Boolean LFixed_IsFixed(LFixed _this);
    
        /// <summary>
        /// Computation of the derived property LFixed.FixedText
        /// </summary>
        global::System.String? LFixed_FixedText(LFixed _this);
    
        /// <summary>
        /// Computation of the derived property LRange.IsFixed
        /// </summary>
        global::System.Boolean LRange_IsFixed(LRange _this);
    
        /// <summary>
        /// Computation of the derived property LRange.FixedText
        /// </summary>
        global::System.String? LRange_FixedText(LRange _this);
    
        /// <summary>
        /// Computation of the derived property LReference.IsFixed
        /// </summary>
        global::System.Boolean LReference_IsFixed(LReference _this);
    
        /// <summary>
        /// Computation of the derived property LReference.FixedText
        /// </summary>
        global::System.String? LReference_FixedText(LReference _this);
    
        /// <summary>
        /// Computation of the derived property LSet.IsFixed
        /// </summary>
        global::System.Boolean LSet_IsFixed(LSet _this);
    
        /// <summary>
        /// Computation of the derived property LSet.FixedText
        /// </summary>
        global::System.String? LSet_FixedText(LSet _this);
    
        /// <summary>
        /// Computation of the derived property LSetItem.IsFixed
        /// </summary>
        global::System.Boolean LSetItem_IsFixed(LSetItem _this);
    
        /// <summary>
        /// Computation of the derived property LSetItem.FixedText
        /// </summary>
        global::System.String? LSetItem_FixedText(LSetItem _this);
    
        /// <summary>
        /// Computation of the derived property LSetChar.IsFixed
        /// </summary>
        global::System.Boolean LSetChar_IsFixed(LSetChar _this);
    
        /// <summary>
        /// Computation of the derived property LSetChar.FixedText
        /// </summary>
        global::System.String? LSetChar_FixedText(LSetChar _this);
    
        /// <summary>
        /// Computation of the derived property LSetRange.IsFixed
        /// </summary>
        global::System.Boolean LSetRange_IsFixed(LSetRange _this);
    
        /// <summary>
        /// Computation of the derived property LSetRange.FixedText
        /// </summary>
        global::System.String? LSetRange_FixedText(LSetRange _this);
    
        /// <summary>
        /// Computation of the derived property LWildCard.IsFixed
        /// </summary>
        global::System.Boolean LWildCard_IsFixed(LWildCard _this);
    
        /// <summary>
        /// Computation of the derived property LWildCard.FixedText
        /// </summary>
        global::System.String? LWildCard_FixedText(LWildCard _this);
    
        /// <summary>
        /// Computation of the derived property Rule.GreenName
        /// </summary>
        global::System.String Rule_GreenName(Rule _this);
    
        /// <summary>
        /// Computation of the derived property Rule.RedName
        /// </summary>
        global::System.String Rule_RedName(Rule _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.Token
        /// </summary>
        Token? RuleRef_Token(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.Rule
        /// </summary>
        Rule? RuleRef_Rule(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.GreenType
        /// </summary>
        global::System.String RuleRef_GreenType(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.GreenSyntaxCondition
        /// </summary>
        global::System.String? RuleRef_GreenSyntaxCondition(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.RedType
        /// </summary>
        global::System.String RuleRef_RedType(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property SeparatedList.GreenType
        /// </summary>
        global::System.String SeparatedList_GreenType(SeparatedList _this);
    
        /// <summary>
        /// Computation of the derived property SeparatedList.GreenSyntaxCondition
        /// </summary>
        global::System.String? SeparatedList_GreenSyntaxCondition(SeparatedList _this);
    
        /// <summary>
        /// Computation of the derived property SeparatedList.RedType
        /// </summary>
        global::System.String SeparatedList_RedType(SeparatedList _this);
    
        /// <summary>
        /// Computation of the derived property TokenAlts.GreenType
        /// </summary>
        global::System.String TokenAlts_GreenType(TokenAlts _this);
    
        /// <summary>
        /// Computation of the derived property TokenAlts.GreenSyntaxCondition
        /// </summary>
        global::System.String? TokenAlts_GreenSyntaxCondition(TokenAlts _this);
    
        /// <summary>
        /// Computation of the derived property TokenAlts.RedType
        /// </summary>
        global::System.String TokenAlts_RedType(TokenAlts _this);
    
    
    }
    
    internal abstract class CustomCompilerImplementationBase : ICustomCompilerImplementation
    {
        /// <summary>
        /// Constructor for the meta model Compiler
        /// </summary>
        public virtual void Compiler(ICompiler _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Annotation
        /// </summary>
        public virtual void Annotation(Annotation _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class AnnotationArgument
        /// </summary>
        public virtual void AnnotationArgument(AnnotationArgument _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ArrayExpression
        /// </summary>
        public virtual void ArrayExpression(ArrayExpression _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Binder
        /// </summary>
        public virtual void Binder(Binder _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class BinderArgument
        /// </summary>
        public virtual void BinderArgument(BinderArgument _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class CSharpElement
        /// </summary>
        public virtual void CSharpElement(CSharpElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Block
        /// </summary>
        public virtual void Block(Block _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Declaration
        /// </summary>
        public virtual void Declaration(Declaration _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Alternative
        /// </summary>
        public virtual void Alternative(Alternative _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Element
        /// </summary>
        public virtual void Element(Element _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class ElementValue
        /// </summary>
        public virtual void ElementValue(ElementValue _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Eof
        /// </summary>
        public virtual void Eof(Eof _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Expression
        /// </summary>
        public virtual void Expression(Expression _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Fixed
        /// </summary>
        public virtual void Fixed(Fixed _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class GrammarRule
        /// </summary>
        public virtual void GrammarRule(GrammarRule _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Language
        /// </summary>
        public virtual void Language(Language _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LexerRule
        /// </summary>
        public virtual void LexerRule(LexerRule _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Fragment
        /// </summary>
        public virtual void Fragment(Fragment _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Grammar
        /// </summary>
        public virtual void Grammar(Grammar _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LAlternative
        /// </summary>
        public virtual void LAlternative(LAlternative _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LElement
        /// </summary>
        public virtual void LElement(LElement _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LElementValue
        /// </summary>
        public virtual void LElementValue(LElementValue _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LBlock
        /// </summary>
        public virtual void LBlock(LBlock _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LFixed
        /// </summary>
        public virtual void LFixed(LFixed _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LRange
        /// </summary>
        public virtual void LRange(LRange _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LReference
        /// </summary>
        public virtual void LReference(LReference _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LSet
        /// </summary>
        public virtual void LSet(LSet _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LSetItem
        /// </summary>
        public virtual void LSetItem(LSetItem _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LSetChar
        /// </summary>
        public virtual void LSetChar(LSetChar _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LSetRange
        /// </summary>
        public virtual void LSetRange(LSetRange _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class LWildCard
        /// </summary>
        public virtual void LWildCard(LWildCard _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Namespace
        /// </summary>
        public virtual void Namespace(Namespace _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Rule
        /// </summary>
        public virtual void Rule(Rule _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class RuleRef
        /// </summary>
        public virtual void RuleRef(RuleRef _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class SeparatedList
        /// </summary>
        public virtual void SeparatedList(SeparatedList _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class Token
        /// </summary>
        public virtual void Token(Token _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TokenAlts
        /// </summary>
        public virtual void TokenAlts(TokenAlts _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class TokenKind
        /// </summary>
        public virtual void TokenKind(TokenKind _this)
        {
        }
    
    
        /// <summary>
        /// Computation of the derived property Binder.ConstructorArguments
        /// </summary>
        public abstract global::System.String Binder_ConstructorArguments(Binder _this);
    
        /// <summary>
        /// Computation of the derived property Block.GreenName
        /// </summary>
        public abstract global::System.String Block_GreenName(Block _this);
    
        /// <summary>
        /// Computation of the derived property Block.RedName
        /// </summary>
        public abstract global::System.String Block_RedName(Block _this);
    
        /// <summary>
        /// Computation of the derived property Block.GreenType
        /// </summary>
        public abstract global::System.String Block_GreenType(Block _this);
    
        /// <summary>
        /// Computation of the derived property Block.GreenSyntaxCondition
        /// </summary>
        public abstract global::System.String? Block_GreenSyntaxCondition(Block _this);
    
        /// <summary>
        /// Computation of the derived property Block.RedType
        /// </summary>
        public abstract global::System.String Block_RedType(Block _this);
    
        /// <summary>
        /// Computation of the derived property Declaration.FullName
        /// </summary>
        public abstract global::System.String? Declaration_FullName(Declaration _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenName
        /// </summary>
        public abstract global::System.String Alternative_GreenName(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenConstructorParameters
        /// </summary>
        public abstract global::System.String Alternative_GreenConstructorParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenConstructorArguments
        /// </summary>
        public abstract global::System.String Alternative_GreenConstructorArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenUpdateParameters
        /// </summary>
        public abstract global::System.String Alternative_GreenUpdateParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.GreenUpdateArguments
        /// </summary>
        public abstract global::System.String Alternative_GreenUpdateArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedName
        /// </summary>
        public abstract global::System.String Alternative_RedName(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedUpdateParameters
        /// </summary>
        public abstract global::System.String Alternative_RedUpdateParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedUpdateArguments
        /// </summary>
        public abstract global::System.String Alternative_RedUpdateArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedOptionalUpdateParameters
        /// </summary>
        public abstract global::System.String Alternative_RedOptionalUpdateParameters(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedToGreenArgumentList
        /// </summary>
        public abstract global::System.String Alternative_RedToGreenArgumentList(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.RedToGreenOptionalArgumentList
        /// </summary>
        public abstract global::System.String Alternative_RedToGreenOptionalArgumentList(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Alternative.HasRedToGreenOptionalArguments
        /// </summary>
        public abstract global::System.Boolean Alternative_HasRedToGreenOptionalArguments(Alternative _this);
    
        /// <summary>
        /// Computation of the derived property Element.IsToken
        /// </summary>
        public abstract global::System.Boolean Element_IsToken(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.IsList
        /// </summary>
        public abstract global::System.Boolean Element_IsList(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.FieldName
        /// </summary>
        public abstract global::System.String Element_FieldName(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.ParameterName
        /// </summary>
        public abstract global::System.String Element_ParameterName(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.PropertyName
        /// </summary>
        public abstract global::System.String Element_PropertyName(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenFieldType
        /// </summary>
        public abstract global::System.String Element_GreenFieldType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenParameterValue
        /// </summary>
        public abstract global::System.String Element_GreenParameterValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenPropertyType
        /// </summary>
        public abstract global::System.String Element_GreenPropertyType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenPropertyValue
        /// </summary>
        public abstract global::System.String Element_GreenPropertyValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenSyntaxNullCondition
        /// </summary>
        public abstract global::System.String? Element_GreenSyntaxNullCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.GreenSyntaxCondition
        /// </summary>
        public abstract global::System.String? Element_GreenSyntaxCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.IsOptionalUpdateParameter
        /// </summary>
        public abstract global::System.Boolean Element_IsOptionalUpdateParameter(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedFieldType
        /// </summary>
        public abstract global::System.String Element_RedFieldType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedParameterValue
        /// </summary>
        public abstract global::System.String Element_RedParameterValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedPropertyType
        /// </summary>
        public abstract global::System.String Element_RedPropertyType(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedPropertyValue
        /// </summary>
        public abstract global::System.String Element_RedPropertyValue(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedToGreenArgument
        /// </summary>
        public abstract global::System.String Element_RedToGreenArgument(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedToGreenOptionalArgument
        /// </summary>
        public abstract global::System.String Element_RedToGreenOptionalArgument(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedSyntaxNullCondition
        /// </summary>
        public abstract global::System.String? Element_RedSyntaxNullCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.RedSyntaxCondition
        /// </summary>
        public abstract global::System.String? Element_RedSyntaxCondition(Element _this);
    
        /// <summary>
        /// Computation of the derived property Element.VisitCall
        /// </summary>
        public abstract global::System.String? Element_VisitCall(Element _this);
    
        /// <summary>
        /// Computation of the derived property ElementValue.GreenType
        /// </summary>
        public abstract global::System.String ElementValue_GreenType(ElementValue _this);
    
        /// <summary>
        /// Computation of the derived property ElementValue.GreenSyntaxCondition
        /// </summary>
        public abstract global::System.String? ElementValue_GreenSyntaxCondition(ElementValue _this);
    
        /// <summary>
        /// Computation of the derived property ElementValue.RedType
        /// </summary>
        public abstract global::System.String ElementValue_RedType(ElementValue _this);
    
        /// <summary>
        /// Computation of the derived property Eof.GreenType
        /// </summary>
        public abstract global::System.String Eof_GreenType(Eof _this);
    
        /// <summary>
        /// Computation of the derived property Eof.GreenSyntaxCondition
        /// </summary>
        public abstract global::System.String? Eof_GreenSyntaxCondition(Eof _this);
    
        /// <summary>
        /// Computation of the derived property Eof.RedType
        /// </summary>
        public abstract global::System.String Eof_RedType(Eof _this);
    
        /// <summary>
        /// Computation of the derived property GrammarRule.Language
        /// </summary>
        public abstract Language GrammarRule_Language(GrammarRule _this);
    
        /// <summary>
        /// Computation of the derived property Language.Namespace
        /// </summary>
        public abstract global::System.String Language_Namespace(Language _this);
    
        /// <summary>
        /// Computation of the derived property LexerRule.IsFixed
        /// </summary>
        public abstract global::System.Boolean LexerRule_IsFixed(LexerRule _this);
    
        /// <summary>
        /// Computation of the derived property LexerRule.FixedText
        /// </summary>
        public abstract global::System.String? LexerRule_FixedText(LexerRule _this);
    
        /// <summary>
        /// Computation of the derived property LAlternative.IsFixed
        /// </summary>
        public abstract global::System.Boolean LAlternative_IsFixed(LAlternative _this);
    
        /// <summary>
        /// Computation of the derived property LAlternative.FixedText
        /// </summary>
        public abstract global::System.String? LAlternative_FixedText(LAlternative _this);
    
        /// <summary>
        /// Computation of the derived property LElement.IsFixed
        /// </summary>
        public abstract global::System.Boolean LElement_IsFixed(LElement _this);
    
        /// <summary>
        /// Computation of the derived property LElement.FixedText
        /// </summary>
        public abstract global::System.String? LElement_FixedText(LElement _this);
    
        /// <summary>
        /// Computation of the derived property LElementValue.IsFixed
        /// </summary>
        public abstract global::System.Boolean LElementValue_IsFixed(LElementValue _this);
    
        /// <summary>
        /// Computation of the derived property LElementValue.FixedText
        /// </summary>
        public abstract global::System.String? LElementValue_FixedText(LElementValue _this);
    
        /// <summary>
        /// Computation of the derived property LBlock.IsFixed
        /// </summary>
        public abstract global::System.Boolean LBlock_IsFixed(LBlock _this);
    
        /// <summary>
        /// Computation of the derived property LBlock.FixedText
        /// </summary>
        public abstract global::System.String? LBlock_FixedText(LBlock _this);
    
        /// <summary>
        /// Computation of the derived property LFixed.IsFixed
        /// </summary>
        public abstract global::System.Boolean LFixed_IsFixed(LFixed _this);
    
        /// <summary>
        /// Computation of the derived property LFixed.FixedText
        /// </summary>
        public abstract global::System.String? LFixed_FixedText(LFixed _this);
    
        /// <summary>
        /// Computation of the derived property LRange.IsFixed
        /// </summary>
        public abstract global::System.Boolean LRange_IsFixed(LRange _this);
    
        /// <summary>
        /// Computation of the derived property LRange.FixedText
        /// </summary>
        public abstract global::System.String? LRange_FixedText(LRange _this);
    
        /// <summary>
        /// Computation of the derived property LReference.IsFixed
        /// </summary>
        public abstract global::System.Boolean LReference_IsFixed(LReference _this);
    
        /// <summary>
        /// Computation of the derived property LReference.FixedText
        /// </summary>
        public abstract global::System.String? LReference_FixedText(LReference _this);
    
        /// <summary>
        /// Computation of the derived property LSet.IsFixed
        /// </summary>
        public abstract global::System.Boolean LSet_IsFixed(LSet _this);
    
        /// <summary>
        /// Computation of the derived property LSet.FixedText
        /// </summary>
        public abstract global::System.String? LSet_FixedText(LSet _this);
    
        /// <summary>
        /// Computation of the derived property LSetItem.IsFixed
        /// </summary>
        public abstract global::System.Boolean LSetItem_IsFixed(LSetItem _this);
    
        /// <summary>
        /// Computation of the derived property LSetItem.FixedText
        /// </summary>
        public abstract global::System.String? LSetItem_FixedText(LSetItem _this);
    
        /// <summary>
        /// Computation of the derived property LSetChar.IsFixed
        /// </summary>
        public abstract global::System.Boolean LSetChar_IsFixed(LSetChar _this);
    
        /// <summary>
        /// Computation of the derived property LSetChar.FixedText
        /// </summary>
        public abstract global::System.String? LSetChar_FixedText(LSetChar _this);
    
        /// <summary>
        /// Computation of the derived property LSetRange.IsFixed
        /// </summary>
        public abstract global::System.Boolean LSetRange_IsFixed(LSetRange _this);
    
        /// <summary>
        /// Computation of the derived property LSetRange.FixedText
        /// </summary>
        public abstract global::System.String? LSetRange_FixedText(LSetRange _this);
    
        /// <summary>
        /// Computation of the derived property LWildCard.IsFixed
        /// </summary>
        public abstract global::System.Boolean LWildCard_IsFixed(LWildCard _this);
    
        /// <summary>
        /// Computation of the derived property LWildCard.FixedText
        /// </summary>
        public abstract global::System.String? LWildCard_FixedText(LWildCard _this);
    
        /// <summary>
        /// Computation of the derived property Rule.GreenName
        /// </summary>
        public abstract global::System.String Rule_GreenName(Rule _this);
    
        /// <summary>
        /// Computation of the derived property Rule.RedName
        /// </summary>
        public abstract global::System.String Rule_RedName(Rule _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.Token
        /// </summary>
        public abstract Token? RuleRef_Token(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.Rule
        /// </summary>
        public abstract Rule? RuleRef_Rule(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.GreenType
        /// </summary>
        public abstract global::System.String RuleRef_GreenType(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.GreenSyntaxCondition
        /// </summary>
        public abstract global::System.String? RuleRef_GreenSyntaxCondition(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property RuleRef.RedType
        /// </summary>
        public abstract global::System.String RuleRef_RedType(RuleRef _this);
    
        /// <summary>
        /// Computation of the derived property SeparatedList.GreenType
        /// </summary>
        public abstract global::System.String SeparatedList_GreenType(SeparatedList _this);
    
        /// <summary>
        /// Computation of the derived property SeparatedList.GreenSyntaxCondition
        /// </summary>
        public abstract global::System.String? SeparatedList_GreenSyntaxCondition(SeparatedList _this);
    
        /// <summary>
        /// Computation of the derived property SeparatedList.RedType
        /// </summary>
        public abstract global::System.String SeparatedList_RedType(SeparatedList _this);
    
        /// <summary>
        /// Computation of the derived property TokenAlts.GreenType
        /// </summary>
        public abstract global::System.String TokenAlts_GreenType(TokenAlts _this);
    
        /// <summary>
        /// Computation of the derived property TokenAlts.GreenSyntaxCondition
        /// </summary>
        public abstract global::System.String? TokenAlts_GreenSyntaxCondition(TokenAlts _this);
    
        /// <summary>
        /// Computation of the derived property TokenAlts.RedType
        /// </summary>
        public abstract global::System.String TokenAlts_RedType(TokenAlts _this);
    
    
    }
}

namespace MetaDslx.Bootstrap.MetaCompiler.Model.__Impl
{
    using __Model = global::MetaDslx.Modeling.Model;
    using __MetaModel = global::MetaDslx.Modeling.MetaModel;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __MetaModelObject = global::MetaDslx.Modeling.MetaModelObject;
    using __ModelEnumInfo = global::MetaDslx.Modeling.ModelEnumInfo;
    using __ModelClassInfo = global::MetaDslx.Modeling.ModelClassInfo;
    using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
    using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
    using __ModelPropertyInfo = global::MetaDslx.Modeling.ModelPropertyInfo;
    using __ModelPropertySlot = global::MetaDslx.Modeling.ModelPropertySlot;
    using __ModelOperation = global::MetaDslx.Modeling.ModelOperation;
    using __ModelOperationInfo = global::MetaDslx.Modeling.ModelOperationInfo;
    using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
    using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
    using __MetaType = global::MetaDslx.CodeAnalysis.MetaType;
    using __MetaSymbol = global::MetaDslx.CodeAnalysis.MetaSymbol;
    using __Type = global::System.Type;
    using __Enum = global::System.Enum;

    internal class __Assignment_Info : __ModelEnumInfo
    {
        public static readonly __Assignment_Info Instance = new __Assignment_Info();
    
        private readonly global::System.Collections.Immutable.ImmutableArray<string> _literals;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> _literalsByName;
    
        private __Assignment_Info()
        {
            _literals = __ImmutableArray.Create<string>("Assign", "QuestionAssign", "NegatedAssign", "PlusAssign");
            var literalsByName = __ImmutableDictionary.CreateBuilder<string, __MetaSymbol>();
            literalsByName.Add("Assign", __MetaSymbol.FromValue(Assignment.Assign));
            literalsByName.Add("QuestionAssign", __MetaSymbol.FromValue(Assignment.QuestionAssign));
            literalsByName.Add("NegatedAssign", __MetaSymbol.FromValue(Assignment.NegatedAssign));
            literalsByName.Add("PlusAssign", __MetaSymbol.FromValue(Assignment.PlusAssign));
            _literalsByName = literalsByName.ToImmutable();
        }
    
        public override __MetaModel MetaModel => Compiler.MInstance;
        public override __MetaType MetaType => typeof(Assignment);
        public override global::System.Collections.Immutable.ImmutableArray<string> Literals => _literals;
        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> LiteralsByName => _literalsByName;
    }

    internal class __Multiplicity_Info : __ModelEnumInfo
    {
        public static readonly __Multiplicity_Info Instance = new __Multiplicity_Info();
    
        private readonly global::System.Collections.Immutable.ImmutableArray<string> _literals;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> _literalsByName;
    
        private __Multiplicity_Info()
        {
            _literals = __ImmutableArray.Create<string>("ExactlyOne", "ZeroOrOne", "ZeroOrMore", "OneOrMore", "NonGreedyZeroOrOne", "NonGreedyZeroOrMore", "NonGreedyOneOrMore");
            var literalsByName = __ImmutableDictionary.CreateBuilder<string, __MetaSymbol>();
            literalsByName.Add("ExactlyOne", __MetaSymbol.FromValue(Multiplicity.ExactlyOne));
            literalsByName.Add("ZeroOrOne", __MetaSymbol.FromValue(Multiplicity.ZeroOrOne));
            literalsByName.Add("ZeroOrMore", __MetaSymbol.FromValue(Multiplicity.ZeroOrMore));
            literalsByName.Add("OneOrMore", __MetaSymbol.FromValue(Multiplicity.OneOrMore));
            literalsByName.Add("NonGreedyZeroOrOne", __MetaSymbol.FromValue(Multiplicity.NonGreedyZeroOrOne));
            literalsByName.Add("NonGreedyZeroOrMore", __MetaSymbol.FromValue(Multiplicity.NonGreedyZeroOrMore));
            literalsByName.Add("NonGreedyOneOrMore", __MetaSymbol.FromValue(Multiplicity.NonGreedyOneOrMore));
            _literalsByName = literalsByName.ToImmutable();
        }
    
        public override __MetaModel MetaModel => Compiler.MInstance;
        public override __MetaType MetaType => typeof(Multiplicity);
        public override global::System.Collections.Immutable.ImmutableArray<string> Literals => _literals;
        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> LiteralsByName => _literalsByName;
    }


    internal class Annotation_Impl : __MetaModelObject, Annotation
    {
        private Annotation_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Annotation(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<AnnotationArgument> Arguments
        {
            get => MGetCollection<AnnotationArgument>(Compiler.Annotation_Arguments);
        }
    
        public global::MetaDslx.CodeAnalysis.MetaType AttributeClass
        {
            get => MGet<global::MetaDslx.CodeAnalysis.MetaType>(Compiler.Annotation_AttributeClass);
            set => MSet<global::MetaDslx.CodeAnalysis.MetaType>(Compiler.Annotation_AttributeClass, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_Arguments, Compiler.Annotation_AttributeClass);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_Arguments, Compiler.Annotation_AttributeClass);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_Arguments, Compiler.Annotation_AttributeClass);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Arguments", Compiler.Annotation_Arguments);
                publicPropertiesByName.Add("AttributeClass", Compiler.Annotation_AttributeClass);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Annotation_Arguments, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Annotation_Arguments, __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_Arguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Annotation_AttributeClass, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Annotation_AttributeClass, __ImmutableArray.Create<__ModelProperty>(Compiler.Annotation_AttributeClass), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Annotation);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.AnnotationSymbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Annotation_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.AnnotationInfo";
            }
        }
    }

    internal class AnnotationArgument_Impl : __MetaModelObject, AnnotationArgument
    {
        private AnnotationArgument_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.AnnotationArgument(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<global::MetaDslx.CodeAnalysis.MetaSymbol> NamedParameter
        {
            get => MGetCollection<global::MetaDslx.CodeAnalysis.MetaSymbol>(Compiler.AnnotationArgument_NamedParameter);
        }
    
        public global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol Parameter
        {
            get => MGet<global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol>(Compiler.AnnotationArgument_Parameter);
            set => MSet<global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol>(Compiler.AnnotationArgument_Parameter, value);
        }
    
        public global::MetaDslx.CodeAnalysis.MetaType ParameterType
        {
            get => MGet<global::MetaDslx.CodeAnalysis.MetaType>(Compiler.AnnotationArgument_ParameterType);
            set => MSet<global::MetaDslx.CodeAnalysis.MetaType>(Compiler.AnnotationArgument_ParameterType, value);
        }
    
        public Expression Value
        {
            get => MGet<Expression>(Compiler.AnnotationArgument_Value);
            set => MSet<Expression>(Compiler.AnnotationArgument_Value, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter, Compiler.AnnotationArgument_Parameter, Compiler.AnnotationArgument_ParameterType, Compiler.AnnotationArgument_Value);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter, Compiler.AnnotationArgument_Parameter, Compiler.AnnotationArgument_ParameterType, Compiler.AnnotationArgument_Value);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter, Compiler.AnnotationArgument_Parameter, Compiler.AnnotationArgument_ParameterType, Compiler.AnnotationArgument_Value);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("NamedParameter", Compiler.AnnotationArgument_NamedParameter);
                publicPropertiesByName.Add("Parameter", Compiler.AnnotationArgument_Parameter);
                publicPropertiesByName.Add("ParameterType", Compiler.AnnotationArgument_ParameterType);
                publicPropertiesByName.Add("Value", Compiler.AnnotationArgument_Value);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.AnnotationArgument_NamedParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_NamedParameter, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.AnnotationArgument_Parameter, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_Parameter, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Parameter), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.AnnotationArgument_ParameterType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_ParameterType, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_ParameterType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.AnnotationArgument_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(AnnotationArgument);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.AnnotationArgumentSymbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new AnnotationArgument_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.AnnotationArgumentInfo";
            }
        }
    }

    internal class ArrayExpression_Impl : __MetaModelObject, ArrayExpression
    {
        private ArrayExpression_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Expression(this);
            Compiler.__CustomImpl.ArrayExpression(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<Expression> Items
        {
            get => MGetCollection<Expression>(Compiler.ArrayExpression_Items);
        }
    
        public global::MetaDslx.CodeAnalysis.MetaSymbol Value
        {
            get => MGet<global::MetaDslx.CodeAnalysis.MetaSymbol>(Compiler.Expression_Value);
            set => MSet<global::MetaDslx.CodeAnalysis.MetaSymbol>(Compiler.Expression_Value, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ExpressionInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ExpressionInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ArrayExpression_Items);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ArrayExpression_Items, Compiler.Expression_Value);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ArrayExpression_Items, Compiler.Expression_Value);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Items", Compiler.ArrayExpression_Items);
                publicPropertiesByName.Add("Value", Compiler.Expression_Value);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.ArrayExpression_Items, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ArrayExpression_Items, __ImmutableArray.Create<__ModelProperty>(Compiler.ArrayExpression_Items), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Expression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Expression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(ArrayExpression);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ExpressionSymbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new ArrayExpression_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.ArrayExpressionInfo";
            }
        }
    }

    internal class Binder_Impl : __MetaModelObject, Binder
    {
        private Binder_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Binder(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<BinderArgument> Arguments
        {
            get => MGetCollection<BinderArgument>(Compiler.Binder_Arguments);
        }
    
        public global::System.String ConstructorArguments
        {
            get => Compiler.__CustomImpl.Binder_ConstructorArguments(this);
        }
    
        public global::System.Boolean IsNegated
        {
            get => MGet<global::System.Boolean>(Compiler.Binder_IsNegated);
            set => MSet<global::System.Boolean>(Compiler.Binder_IsNegated, value);
        }
    
        public global::System.String TypeName
        {
            get => MGet<global::System.String>(Compiler.Binder_TypeName);
            set => MSet<global::System.String>(Compiler.Binder_TypeName, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Binder_Arguments, Compiler.Binder_ConstructorArguments, Compiler.Binder_IsNegated, Compiler.Binder_TypeName);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Binder_Arguments, Compiler.Binder_ConstructorArguments, Compiler.Binder_IsNegated, Compiler.Binder_TypeName);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Binder_Arguments, Compiler.Binder_ConstructorArguments, Compiler.Binder_IsNegated, Compiler.Binder_TypeName);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Arguments", Compiler.Binder_Arguments);
                publicPropertiesByName.Add("ConstructorArguments", Compiler.Binder_ConstructorArguments);
                publicPropertiesByName.Add("IsNegated", Compiler.Binder_IsNegated);
                publicPropertiesByName.Add("TypeName", Compiler.Binder_TypeName);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Binder_Arguments, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Binder_Arguments, __ImmutableArray.Create<__ModelProperty>(Compiler.Binder_Arguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Binder_ConstructorArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Binder_ConstructorArguments, __ImmutableArray.Create<__ModelProperty>(Compiler.Binder_ConstructorArguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Binder_IsNegated, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Binder_IsNegated, __ImmutableArray.Create<__ModelProperty>(Compiler.Binder_IsNegated), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Binder_TypeName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Binder_TypeName, __ImmutableArray.Create<__ModelProperty>(Compiler.Binder_TypeName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Binder);
    
            public override __MetaType SymbolType => default;
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Binder_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.BinderInfo";
            }
        }
    }

    internal class BinderArgument_Impl : __MetaModelObject, BinderArgument
    {
        private BinderArgument_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.BinderArgument(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.Boolean IsArray
        {
            get => MGet<global::System.Boolean>(Compiler.BinderArgument_IsArray);
            set => MSet<global::System.Boolean>(Compiler.BinderArgument_IsArray, value);
        }
    
        public global::System.String Name
        {
            get => MGet<global::System.String>(Compiler.BinderArgument_Name);
            set => MSet<global::System.String>(Compiler.BinderArgument_Name, value);
        }
    
        public global::System.String TypeName
        {
            get => MGet<global::System.String>(Compiler.BinderArgument_TypeName);
            set => MSet<global::System.String>(Compiler.BinderArgument_TypeName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<global::System.String?> Values
        {
            get => MGetCollection<global::System.String>(Compiler.BinderArgument_Values);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.BinderArgument_IsArray, Compiler.BinderArgument_Name, Compiler.BinderArgument_TypeName, Compiler.BinderArgument_Values);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.BinderArgument_IsArray, Compiler.BinderArgument_Name, Compiler.BinderArgument_TypeName, Compiler.BinderArgument_Values);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.BinderArgument_IsArray, Compiler.BinderArgument_Name, Compiler.BinderArgument_TypeName, Compiler.BinderArgument_Values);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("IsArray", Compiler.BinderArgument_IsArray);
                publicPropertiesByName.Add("Name", Compiler.BinderArgument_Name);
                publicPropertiesByName.Add("TypeName", Compiler.BinderArgument_TypeName);
                publicPropertiesByName.Add("Values", Compiler.BinderArgument_Values);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.BinderArgument_IsArray, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.BinderArgument_IsArray, __ImmutableArray.Create<__ModelProperty>(Compiler.BinderArgument_IsArray), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.BinderArgument_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.BinderArgument_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.BinderArgument_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.BinderArgument_TypeName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.BinderArgument_TypeName, __ImmutableArray.Create<__ModelProperty>(Compiler.BinderArgument_TypeName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.BinderArgument_Values, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.BinderArgument_Values, __ImmutableArray.Create<__ModelProperty>(Compiler.BinderArgument_Values), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(BinderArgument);
    
            public override __MetaType SymbolType => default;
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new BinderArgument_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.BinderArgumentInfo";
            }
        }
    }

    internal class CSharpElement_Impl : __MetaModelObject, CSharpElement
    {
        private CSharpElement_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.CSharpElement(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(CSharpElement);
    
            public override __MetaType SymbolType => default;
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new CSharpElement_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.CSharpElementInfo";
            }
        }
    }

    internal class Block_Impl : __MetaModelObject, Block
    {
        private Block_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.ElementValue(this);
            Compiler.__CustomImpl.Block(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<Alternative> Alternatives
        {
            get => MGetCollection<Alternative>(Compiler.Block_Alternatives);
        }
    
        public global::System.String GreenName
        {
            get => Compiler.__CustomImpl.Block_GreenName(this);
        }
    
        public global::System.String? GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.Block_GreenSyntaxCondition(this);
        }
    
        public global::System.String GreenType
        {
            get => Compiler.__CustomImpl.Block_GreenType(this);
        }
    
        public global::System.String RedName
        {
            get => Compiler.__CustomImpl.Block_RedName(this);
        }
    
        public global::System.String RedType
        {
            get => Compiler.__CustomImpl.Block_RedType(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String? ElementValue.GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.Block_GreenSyntaxCondition(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String ElementValue.GreenType
        {
            get => Compiler.__CustomImpl.Block_GreenType(this);
        }
    
        public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
        {
            get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ElementValue_Multiplicity);
            set => MSet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ElementValue_Multiplicity, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String ElementValue.RedType
        {
            get => Compiler.__CustomImpl.Block_RedType(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ElementValueInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ElementValueInfo, Compiler.CSharpElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Block_Alternatives, Compiler.Block_GreenName, Compiler.Block_GreenSyntaxCondition, Compiler.Block_GreenType, Compiler.Block_RedName, Compiler.Block_RedType);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Block_Alternatives, Compiler.Block_GreenName, Compiler.Block_GreenSyntaxCondition, Compiler.Block_GreenType, Compiler.Block_RedName, Compiler.Block_RedType, Compiler.ElementValue_GreenSyntaxCondition, Compiler.ElementValue_GreenType, Compiler.ElementValue_Multiplicity, Compiler.ElementValue_RedType, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Block_Alternatives, Compiler.Block_GreenName, Compiler.Block_GreenSyntaxCondition, Compiler.Block_GreenType, Compiler.Block_RedName, Compiler.Block_RedType, Compiler.ElementValue_Multiplicity, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Alternatives", Compiler.Block_Alternatives);
                publicPropertiesByName.Add("GreenName", Compiler.Block_GreenName);
                publicPropertiesByName.Add("GreenSyntaxCondition", Compiler.Block_GreenSyntaxCondition);
                publicPropertiesByName.Add("GreenType", Compiler.Block_GreenType);
                publicPropertiesByName.Add("RedName", Compiler.Block_RedName);
                publicPropertiesByName.Add("RedType", Compiler.Block_RedType);
                publicPropertiesByName.Add("Multiplicity", Compiler.ElementValue_Multiplicity);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Block_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Block_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.Block_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Block_GreenName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Block_GreenName, __ImmutableArray.Create<__ModelProperty>(Compiler.Block_GreenName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Block_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Block_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.Block_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Block_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Block_GreenType, __ImmutableArray.Create<__ModelProperty>(Compiler.Block_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Block_RedName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Block_RedName, __ImmutableArray.Create<__ModelProperty>(Compiler.Block_RedName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Block_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Block_RedType, __ImmutableArray.Create<__ModelProperty>(Compiler.Block_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_RedType), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Block_GreenSyntaxCondition)));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Block_GreenType)));
                modelPropertyInfos.Add(Compiler.ElementValue_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_RedType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Block_RedType)));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Block);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PBlockSymbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Block_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.BlockInfo";
            }
        }
    }

    internal class Declaration_Impl : __MetaModelObject, Declaration
    {
        private Declaration_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Declaration(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
        {
            get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
        }
    
        public global::System.String? FullName
        {
            get => Compiler.__CustomImpl.Declaration_FullName(this);
        }
    
        public global::System.String? Name
        {
            get => MGet<global::System.String?>(Compiler.Declaration_Name);
            set => MSet<global::System.String?>(Compiler.Declaration_Name, value);
        }
    
        public Declaration? Parent
        {
            get => MGet<Declaration?>(Compiler.Declaration_Parent);
            set => MSet<Declaration?>(Compiler.Declaration_Parent, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
                publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
                publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
                publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Parent, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Declaration);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Declaration_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.DeclarationInfo";
            }
        }
    }

    internal class Alternative_Impl : __MetaModelObject, Alternative
    {
        private Alternative_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Declaration(this);
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.Alternative(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<Element> Elements
        {
            get => MGetCollection<Element>(Compiler.Alternative_Elements);
        }
    
        public global::System.String GreenConstructorArguments
        {
            get => Compiler.__CustomImpl.Alternative_GreenConstructorArguments(this);
        }
    
        public global::System.String GreenConstructorParameters
        {
            get => Compiler.__CustomImpl.Alternative_GreenConstructorParameters(this);
        }
    
        public global::System.String GreenName
        {
            get => Compiler.__CustomImpl.Alternative_GreenName(this);
        }
    
        public global::System.String GreenUpdateArguments
        {
            get => Compiler.__CustomImpl.Alternative_GreenUpdateArguments(this);
        }
    
        public global::System.String GreenUpdateParameters
        {
            get => Compiler.__CustomImpl.Alternative_GreenUpdateParameters(this);
        }
    
        public global::System.Boolean HasRedToGreenOptionalArguments
        {
            get => Compiler.__CustomImpl.Alternative_HasRedToGreenOptionalArguments(this);
        }
    
        public global::System.String RedName
        {
            get => Compiler.__CustomImpl.Alternative_RedName(this);
        }
    
        public global::System.String RedOptionalUpdateParameters
        {
            get => Compiler.__CustomImpl.Alternative_RedOptionalUpdateParameters(this);
        }
    
        public global::System.String RedToGreenArgumentList
        {
            get => Compiler.__CustomImpl.Alternative_RedToGreenArgumentList(this);
        }
    
        public global::System.String RedToGreenOptionalArgumentList
        {
            get => Compiler.__CustomImpl.Alternative_RedToGreenOptionalArgumentList(this);
        }
    
        public global::System.String RedUpdateArguments
        {
            get => Compiler.__CustomImpl.Alternative_RedUpdateArguments(this);
        }
    
        public global::System.String RedUpdateParameters
        {
            get => Compiler.__CustomImpl.Alternative_RedUpdateParameters(this);
        }
    
        public global::MetaDslx.CodeAnalysis.MetaType ReturnType
        {
            get => MGet<global::MetaDslx.CodeAnalysis.MetaType>(Compiler.Alternative_ReturnType);
            set => MSet<global::MetaDslx.CodeAnalysis.MetaType>(Compiler.Alternative_ReturnType, value);
        }
    
        public Expression ReturnValue
        {
            get => MGet<Expression>(Compiler.Alternative_ReturnValue);
            set => MSet<Expression>(Compiler.Alternative_ReturnValue, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
        {
            get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
        }
    
        public global::System.String? FullName
        {
            get => Compiler.__CustomImpl.Declaration_FullName(this);
        }
    
        public global::System.String? Name
        {
            get => MGet<global::System.String?>(Compiler.Declaration_Name);
            set => MSet<global::System.String?>(Compiler.Declaration_Name, value);
        }
    
        public Declaration? Parent
        {
            get => MGet<Declaration?>(Compiler.Declaration_Parent);
            set => MSet<Declaration?>(Compiler.Declaration_Parent, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.CSharpElementInfo, Compiler.DeclarationInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.CSharpElementInfo, Compiler.DeclarationInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_Elements, Compiler.Alternative_GreenConstructorArguments, Compiler.Alternative_GreenConstructorParameters, Compiler.Alternative_GreenName, Compiler.Alternative_GreenUpdateArguments, Compiler.Alternative_GreenUpdateParameters, Compiler.Alternative_HasRedToGreenOptionalArguments, Compiler.Alternative_RedName, Compiler.Alternative_RedOptionalUpdateParameters, Compiler.Alternative_RedToGreenArgumentList, Compiler.Alternative_RedToGreenOptionalArgumentList, Compiler.Alternative_RedUpdateArguments, Compiler.Alternative_RedUpdateParameters, Compiler.Alternative_ReturnType, Compiler.Alternative_ReturnValue);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_Elements, Compiler.Alternative_GreenConstructorArguments, Compiler.Alternative_GreenConstructorParameters, Compiler.Alternative_GreenName, Compiler.Alternative_GreenUpdateArguments, Compiler.Alternative_GreenUpdateParameters, Compiler.Alternative_HasRedToGreenOptionalArguments, Compiler.Alternative_RedName, Compiler.Alternative_RedOptionalUpdateParameters, Compiler.Alternative_RedToGreenArgumentList, Compiler.Alternative_RedToGreenOptionalArgumentList, Compiler.Alternative_RedUpdateArguments, Compiler.Alternative_RedUpdateParameters, Compiler.Alternative_ReturnType, Compiler.Alternative_ReturnValue, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_Elements, Compiler.Alternative_GreenConstructorArguments, Compiler.Alternative_GreenConstructorParameters, Compiler.Alternative_GreenName, Compiler.Alternative_GreenUpdateArguments, Compiler.Alternative_GreenUpdateParameters, Compiler.Alternative_HasRedToGreenOptionalArguments, Compiler.Alternative_RedName, Compiler.Alternative_RedOptionalUpdateParameters, Compiler.Alternative_RedToGreenArgumentList, Compiler.Alternative_RedToGreenOptionalArgumentList, Compiler.Alternative_RedUpdateArguments, Compiler.Alternative_RedUpdateParameters, Compiler.Alternative_ReturnType, Compiler.Alternative_ReturnValue, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Elements", Compiler.Alternative_Elements);
                publicPropertiesByName.Add("GreenConstructorArguments", Compiler.Alternative_GreenConstructorArguments);
                publicPropertiesByName.Add("GreenConstructorParameters", Compiler.Alternative_GreenConstructorParameters);
                publicPropertiesByName.Add("GreenName", Compiler.Alternative_GreenName);
                publicPropertiesByName.Add("GreenUpdateArguments", Compiler.Alternative_GreenUpdateArguments);
                publicPropertiesByName.Add("GreenUpdateParameters", Compiler.Alternative_GreenUpdateParameters);
                publicPropertiesByName.Add("HasRedToGreenOptionalArguments", Compiler.Alternative_HasRedToGreenOptionalArguments);
                publicPropertiesByName.Add("RedName", Compiler.Alternative_RedName);
                publicPropertiesByName.Add("RedOptionalUpdateParameters", Compiler.Alternative_RedOptionalUpdateParameters);
                publicPropertiesByName.Add("RedToGreenArgumentList", Compiler.Alternative_RedToGreenArgumentList);
                publicPropertiesByName.Add("RedToGreenOptionalArgumentList", Compiler.Alternative_RedToGreenOptionalArgumentList);
                publicPropertiesByName.Add("RedUpdateArguments", Compiler.Alternative_RedUpdateArguments);
                publicPropertiesByName.Add("RedUpdateParameters", Compiler.Alternative_RedUpdateParameters);
                publicPropertiesByName.Add("ReturnType", Compiler.Alternative_ReturnType);
                publicPropertiesByName.Add("ReturnValue", Compiler.Alternative_ReturnValue);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
                publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
                publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
                publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Alternative_Elements, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_Elements, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_Elements), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_GreenConstructorArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_GreenConstructorArguments, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_GreenConstructorArguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_GreenConstructorParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_GreenConstructorParameters, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_GreenConstructorParameters), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_GreenName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_GreenName, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_GreenName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_GreenUpdateArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_GreenUpdateArguments, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_GreenUpdateArguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_GreenUpdateParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_GreenUpdateParameters, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_GreenUpdateParameters), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_HasRedToGreenOptionalArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_HasRedToGreenOptionalArguments, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_HasRedToGreenOptionalArguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_RedName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_RedName, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_RedName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_RedOptionalUpdateParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_RedOptionalUpdateParameters, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_RedOptionalUpdateParameters), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_RedToGreenArgumentList, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_RedToGreenArgumentList, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_RedToGreenArgumentList), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_RedToGreenOptionalArgumentList, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_RedToGreenOptionalArgumentList, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_RedToGreenOptionalArgumentList), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_RedUpdateArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_RedUpdateArguments, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_RedUpdateArguments), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_RedUpdateParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_RedUpdateParameters, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_RedUpdateParameters), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_ReturnType, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_ReturnType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Alternative_ReturnValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Alternative_ReturnValue, __ImmutableArray.Create<__ModelProperty>(Compiler.Alternative_ReturnValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Parent, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Alternative);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PAlternativeSymbol);
            public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Alternative_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.AlternativeInfo";
            }
        }
    }

    internal class Element_Impl : __MetaModelObject, Element
    {
        private Element_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.Element(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment Assignment
        {
            get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment>(Compiler.Element_Assignment);
            set => MSet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment>(Compiler.Element_Assignment, value);
        }
    
        public global::System.String FieldName
        {
            get => Compiler.__CustomImpl.Element_FieldName(this);
        }
    
        public global::System.String GreenFieldType
        {
            get => Compiler.__CustomImpl.Element_GreenFieldType(this);
        }
    
        public global::System.String GreenParameterValue
        {
            get => Compiler.__CustomImpl.Element_GreenParameterValue(this);
        }
    
        public global::System.String GreenPropertyType
        {
            get => Compiler.__CustomImpl.Element_GreenPropertyType(this);
        }
    
        public global::System.String GreenPropertyValue
        {
            get => Compiler.__CustomImpl.Element_GreenPropertyValue(this);
        }
    
        public global::System.String? GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.Element_GreenSyntaxCondition(this);
        }
    
        public global::System.String? GreenSyntaxNullCondition
        {
            get => Compiler.__CustomImpl.Element_GreenSyntaxNullCondition(this);
        }
    
        public global::System.Boolean IsList
        {
            get => Compiler.__CustomImpl.Element_IsList(this);
        }
    
        public global::System.Boolean IsOptionalUpdateParameter
        {
            get => Compiler.__CustomImpl.Element_IsOptionalUpdateParameter(this);
        }
    
        public global::System.Boolean IsToken
        {
            get => Compiler.__CustomImpl.Element_IsToken(this);
        }
    
        public global::System.String? Name
        {
            get => MGet<global::System.String?>(Compiler.Element_Name);
            set => MSet<global::System.String?>(Compiler.Element_Name, value);
        }
    
        public global::System.String ParameterName
        {
            get => Compiler.__CustomImpl.Element_ParameterName(this);
        }
    
        public global::System.String PropertyName
        {
            get => Compiler.__CustomImpl.Element_PropertyName(this);
        }
    
        public global::System.String RedFieldType
        {
            get => Compiler.__CustomImpl.Element_RedFieldType(this);
        }
    
        public global::System.String RedParameterValue
        {
            get => Compiler.__CustomImpl.Element_RedParameterValue(this);
        }
    
        public global::System.String RedPropertyType
        {
            get => Compiler.__CustomImpl.Element_RedPropertyType(this);
        }
    
        public global::System.String RedPropertyValue
        {
            get => Compiler.__CustomImpl.Element_RedPropertyValue(this);
        }
    
        public global::System.String? RedSyntaxCondition
        {
            get => Compiler.__CustomImpl.Element_RedSyntaxCondition(this);
        }
    
        public global::System.String? RedSyntaxNullCondition
        {
            get => Compiler.__CustomImpl.Element_RedSyntaxNullCondition(this);
        }
    
        public global::System.String RedToGreenArgument
        {
            get => Compiler.__CustomImpl.Element_RedToGreenArgument(this);
        }
    
        public global::System.String RedToGreenOptionalArgument
        {
            get => Compiler.__CustomImpl.Element_RedToGreenOptionalArgument(this);
        }
    
        public ElementValue Value
        {
            get => MGet<ElementValue>(Compiler.Element_Value);
            set => MSet<ElementValue>(Compiler.Element_Value, value);
        }
    
        public global::System.String? VisitCall
        {
            get => Compiler.__CustomImpl.Element_VisitCall(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.CSharpElementInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.CSharpElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Element_Assignment, Compiler.Element_FieldName, Compiler.Element_GreenFieldType, Compiler.Element_GreenParameterValue, Compiler.Element_GreenPropertyType, Compiler.Element_GreenPropertyValue, Compiler.Element_GreenSyntaxCondition, Compiler.Element_GreenSyntaxNullCondition, Compiler.Element_IsList, Compiler.Element_IsOptionalUpdateParameter, Compiler.Element_IsToken, Compiler.Element_Name, Compiler.Element_ParameterName, Compiler.Element_PropertyName, Compiler.Element_RedFieldType, Compiler.Element_RedParameterValue, Compiler.Element_RedPropertyType, Compiler.Element_RedPropertyValue, Compiler.Element_RedSyntaxCondition, Compiler.Element_RedSyntaxNullCondition, Compiler.Element_RedToGreenArgument, Compiler.Element_RedToGreenOptionalArgument, Compiler.Element_Value, Compiler.Element_VisitCall);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Element_Assignment, Compiler.Element_FieldName, Compiler.Element_GreenFieldType, Compiler.Element_GreenParameterValue, Compiler.Element_GreenPropertyType, Compiler.Element_GreenPropertyValue, Compiler.Element_GreenSyntaxCondition, Compiler.Element_GreenSyntaxNullCondition, Compiler.Element_IsList, Compiler.Element_IsOptionalUpdateParameter, Compiler.Element_IsToken, Compiler.Element_Name, Compiler.Element_ParameterName, Compiler.Element_PropertyName, Compiler.Element_RedFieldType, Compiler.Element_RedParameterValue, Compiler.Element_RedPropertyType, Compiler.Element_RedPropertyValue, Compiler.Element_RedSyntaxCondition, Compiler.Element_RedSyntaxNullCondition, Compiler.Element_RedToGreenArgument, Compiler.Element_RedToGreenOptionalArgument, Compiler.Element_Value, Compiler.Element_VisitCall, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Element_Assignment, Compiler.Element_FieldName, Compiler.Element_GreenFieldType, Compiler.Element_GreenParameterValue, Compiler.Element_GreenPropertyType, Compiler.Element_GreenPropertyValue, Compiler.Element_GreenSyntaxCondition, Compiler.Element_GreenSyntaxNullCondition, Compiler.Element_IsList, Compiler.Element_IsOptionalUpdateParameter, Compiler.Element_IsToken, Compiler.Element_Name, Compiler.Element_ParameterName, Compiler.Element_PropertyName, Compiler.Element_RedFieldType, Compiler.Element_RedParameterValue, Compiler.Element_RedPropertyType, Compiler.Element_RedPropertyValue, Compiler.Element_RedSyntaxCondition, Compiler.Element_RedSyntaxNullCondition, Compiler.Element_RedToGreenArgument, Compiler.Element_RedToGreenOptionalArgument, Compiler.Element_Value, Compiler.Element_VisitCall, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Assignment", Compiler.Element_Assignment);
                publicPropertiesByName.Add("FieldName", Compiler.Element_FieldName);
                publicPropertiesByName.Add("GreenFieldType", Compiler.Element_GreenFieldType);
                publicPropertiesByName.Add("GreenParameterValue", Compiler.Element_GreenParameterValue);
                publicPropertiesByName.Add("GreenPropertyType", Compiler.Element_GreenPropertyType);
                publicPropertiesByName.Add("GreenPropertyValue", Compiler.Element_GreenPropertyValue);
                publicPropertiesByName.Add("GreenSyntaxCondition", Compiler.Element_GreenSyntaxCondition);
                publicPropertiesByName.Add("GreenSyntaxNullCondition", Compiler.Element_GreenSyntaxNullCondition);
                publicPropertiesByName.Add("IsList", Compiler.Element_IsList);
                publicPropertiesByName.Add("IsOptionalUpdateParameter", Compiler.Element_IsOptionalUpdateParameter);
                publicPropertiesByName.Add("IsToken", Compiler.Element_IsToken);
                publicPropertiesByName.Add("Name", Compiler.Element_Name);
                publicPropertiesByName.Add("ParameterName", Compiler.Element_ParameterName);
                publicPropertiesByName.Add("PropertyName", Compiler.Element_PropertyName);
                publicPropertiesByName.Add("RedFieldType", Compiler.Element_RedFieldType);
                publicPropertiesByName.Add("RedParameterValue", Compiler.Element_RedParameterValue);
                publicPropertiesByName.Add("RedPropertyType", Compiler.Element_RedPropertyType);
                publicPropertiesByName.Add("RedPropertyValue", Compiler.Element_RedPropertyValue);
                publicPropertiesByName.Add("RedSyntaxCondition", Compiler.Element_RedSyntaxCondition);
                publicPropertiesByName.Add("RedSyntaxNullCondition", Compiler.Element_RedSyntaxNullCondition);
                publicPropertiesByName.Add("RedToGreenArgument", Compiler.Element_RedToGreenArgument);
                publicPropertiesByName.Add("RedToGreenOptionalArgument", Compiler.Element_RedToGreenOptionalArgument);
                publicPropertiesByName.Add("Value", Compiler.Element_Value);
                publicPropertiesByName.Add("VisitCall", Compiler.Element_VisitCall);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Element_Assignment, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_Assignment, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_Assignment), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_FieldName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_FieldName, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_FieldName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_GreenFieldType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_GreenFieldType, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_GreenFieldType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_GreenParameterValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_GreenParameterValue, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_GreenParameterValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_GreenPropertyType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_GreenPropertyType, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_GreenPropertyType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_GreenPropertyValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_GreenPropertyValue, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_GreenPropertyValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_GreenSyntaxNullCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_GreenSyntaxNullCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_GreenSyntaxNullCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_IsList, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_IsList, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_IsList), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_IsOptionalUpdateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_IsOptionalUpdateParameter, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_IsOptionalUpdateParameter), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_IsToken, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_IsToken, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_IsToken), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_ParameterName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_ParameterName, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_ParameterName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_PropertyName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_PropertyName, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_PropertyName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedFieldType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedFieldType, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedFieldType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedParameterValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedParameterValue, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedParameterValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedPropertyType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedPropertyType, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedPropertyType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedPropertyValue, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedPropertyValue, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedPropertyValue), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedSyntaxNullCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedSyntaxNullCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedSyntaxNullCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedToGreenArgument, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedToGreenArgument, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedToGreenArgument), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_RedToGreenOptionalArgument, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_RedToGreenOptionalArgument, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_RedToGreenOptionalArgument), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Element_VisitCall, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Element_VisitCall, __ImmutableArray.Create<__ModelProperty>(Compiler.Element_VisitCall), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Element);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PElementSymbol);
            public override __ModelProperty? NameProperty => Compiler.Element_Name;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Element_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.ElementInfo";
            }
        }
    }

    internal class ElementValue_Impl : __MetaModelObject, ElementValue
    {
        private ElementValue_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.ElementValue(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String? GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.ElementValue_GreenSyntaxCondition(this);
        }
    
        public global::System.String GreenType
        {
            get => Compiler.__CustomImpl.ElementValue_GreenType(this);
        }
    
        public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
        {
            get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ElementValue_Multiplicity);
            set => MSet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ElementValue_Multiplicity, value);
        }
    
        public global::System.String RedType
        {
            get => Compiler.__CustomImpl.ElementValue_RedType(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.CSharpElementInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.CSharpElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition, Compiler.ElementValue_GreenType, Compiler.ElementValue_Multiplicity, Compiler.ElementValue_RedType);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition, Compiler.ElementValue_GreenType, Compiler.ElementValue_Multiplicity, Compiler.ElementValue_RedType, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition, Compiler.ElementValue_GreenType, Compiler.ElementValue_Multiplicity, Compiler.ElementValue_RedType, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("GreenSyntaxCondition", Compiler.ElementValue_GreenSyntaxCondition);
                publicPropertiesByName.Add("GreenType", Compiler.ElementValue_GreenType);
                publicPropertiesByName.Add("Multiplicity", Compiler.ElementValue_Multiplicity);
                publicPropertiesByName.Add("RedType", Compiler.ElementValue_RedType);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_RedType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(ElementValue);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new ElementValue_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.ElementValueInfo";
            }
        }
    }

    internal class Eof_Impl : __MetaModelObject, Eof
    {
        private Eof_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.ElementValue(this);
            Compiler.__CustomImpl.Eof(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String? GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.Eof_GreenSyntaxCondition(this);
        }
    
        public global::System.String GreenType
        {
            get => Compiler.__CustomImpl.Eof_GreenType(this);
        }
    
        public global::System.String RedType
        {
            get => Compiler.__CustomImpl.Eof_RedType(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String? ElementValue.GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.Eof_GreenSyntaxCondition(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String ElementValue.GreenType
        {
            get => Compiler.__CustomImpl.Eof_GreenType(this);
        }
    
        public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
        {
            get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ElementValue_Multiplicity);
            set => MSet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ElementValue_Multiplicity, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String ElementValue.RedType
        {
            get => Compiler.__CustomImpl.Eof_RedType(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ElementValueInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ElementValueInfo, Compiler.CSharpElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_GreenSyntaxCondition, Compiler.Eof_GreenType, Compiler.Eof_RedType);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_GreenSyntaxCondition, Compiler.Eof_GreenType, Compiler.Eof_RedType, Compiler.ElementValue_GreenSyntaxCondition, Compiler.ElementValue_GreenType, Compiler.ElementValue_Multiplicity, Compiler.ElementValue_RedType, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_GreenSyntaxCondition, Compiler.Eof_GreenType, Compiler.Eof_RedType, Compiler.ElementValue_Multiplicity, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("GreenSyntaxCondition", Compiler.Eof_GreenSyntaxCondition);
                publicPropertiesByName.Add("GreenType", Compiler.Eof_GreenType);
                publicPropertiesByName.Add("RedType", Compiler.Eof_RedType);
                publicPropertiesByName.Add("Multiplicity", Compiler.ElementValue_Multiplicity);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Eof_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Eof_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Eof_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Eof_GreenType, __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Eof_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Eof_RedType, __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_RedType), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_GreenSyntaxCondition)));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_GreenType)));
                modelPropertyInfos.Add(Compiler.ElementValue_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_RedType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_RedType)));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Eof);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Eof_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.EofInfo";
            }
        }
    }

    internal class Expression_Impl : __MetaModelObject, Expression
    {
        private Expression_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Expression(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.CodeAnalysis.MetaSymbol Value
        {
            get => MGet<global::MetaDslx.CodeAnalysis.MetaSymbol>(Compiler.Expression_Value);
            set => MSet<global::MetaDslx.CodeAnalysis.MetaSymbol>(Compiler.Expression_Value, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Value", Compiler.Expression_Value);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Expression_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Expression_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.Expression_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Expression);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ExpressionSymbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Expression_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.ExpressionInfo";
            }
        }
    }

    internal class Fixed_Impl : __MetaModelObject, Fixed
    {
        private Fixed_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.ElementValue(this);
            Compiler.__CustomImpl.Fixed(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String Text
        {
            get => MGet<global::System.String>(Compiler.Fixed_Text);
            set => MSet<global::System.String>(Compiler.Fixed_Text, value);
        }
    
        public global::System.String? GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.ElementValue_GreenSyntaxCondition(this);
        }
    
        public global::System.String GreenType
        {
            get => Compiler.__CustomImpl.ElementValue_GreenType(this);
        }
    
        public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
        {
            get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ElementValue_Multiplicity);
            set => MSet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ElementValue_Multiplicity, value);
        }
    
        public global::System.String RedType
        {
            get => Compiler.__CustomImpl.ElementValue_RedType(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ElementValueInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ElementValueInfo, Compiler.CSharpElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Fixed_Text);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Fixed_Text, Compiler.ElementValue_GreenSyntaxCondition, Compiler.ElementValue_GreenType, Compiler.ElementValue_Multiplicity, Compiler.ElementValue_RedType, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Fixed_Text, Compiler.ElementValue_GreenSyntaxCondition, Compiler.ElementValue_GreenType, Compiler.ElementValue_Multiplicity, Compiler.ElementValue_RedType, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Text", Compiler.Fixed_Text);
                publicPropertiesByName.Add("GreenSyntaxCondition", Compiler.ElementValue_GreenSyntaxCondition);
                publicPropertiesByName.Add("GreenType", Compiler.ElementValue_GreenType);
                publicPropertiesByName.Add("Multiplicity", Compiler.ElementValue_Multiplicity);
                publicPropertiesByName.Add("RedType", Compiler.ElementValue_RedType);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Fixed_Text, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Fixed_Text, __ImmutableArray.Create<__ModelProperty>(Compiler.Fixed_Text), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_RedType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Fixed);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Fixed_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.FixedInfo";
            }
        }
    }

    internal class GrammarRule_Impl : __MetaModelObject, GrammarRule
    {
        private GrammarRule_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Declaration(this);
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.GrammarRule(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public Grammar Grammar
        {
            get => MGet<Grammar>(Compiler.GrammarRule_Grammar);
            set => MSet<Grammar>(Compiler.GrammarRule_Grammar, value);
        }
    
        public Language Language
        {
            get => Compiler.__CustomImpl.GrammarRule_Language(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
        {
            get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
        }
    
        public global::System.String? FullName
        {
            get => Compiler.__CustomImpl.Declaration_FullName(this);
        }
    
        public global::System.String? Name
        {
            get => MGet<global::System.String?>(Compiler.Declaration_Name);
            set => MSet<global::System.String?>(Compiler.Declaration_Name, value);
        }
    
        public Declaration? Parent
        {
            get => MGet<Declaration?>(Compiler.Declaration_Parent);
            set => MSet<Declaration?>(Compiler.Declaration_Parent, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.CSharpElementInfo, Compiler.DeclarationInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.CSharpElementInfo, Compiler.DeclarationInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar, Compiler.GrammarRule_Language);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar, Compiler.GrammarRule_Language, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar, Compiler.GrammarRule_Language, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Grammar", Compiler.GrammarRule_Grammar);
                publicPropertiesByName.Add("Language", Compiler.GrammarRule_Language);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
                publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
                publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
                publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.GrammarRule_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.GrammarRule_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(GrammarRule);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new GrammarRule_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.GrammarRuleInfo";
            }
        }
    }

    internal class Language_Impl : __MetaModelObject, Language
    {
        private Language_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Declaration(this);
            Compiler.__CustomImpl.Language(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public Grammar Grammar
        {
            get => MGet<Grammar>(Compiler.Language_Grammar);
            set => MSet<Grammar>(Compiler.Language_Grammar, value);
        }
    
        public global::System.String Namespace
        {
            get => Compiler.__CustomImpl.Language_Namespace(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
        {
            get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
        }
    
        public global::System.String? FullName
        {
            get => Compiler.__CustomImpl.Declaration_FullName(this);
        }
    
        public global::System.String? Name
        {
            get => MGet<global::System.String?>(Compiler.Declaration_Name);
            set => MSet<global::System.String?>(Compiler.Declaration_Name, value);
        }
    
        public Declaration? Parent
        {
            get => MGet<Declaration?>(Compiler.Declaration_Parent);
            set => MSet<Declaration?>(Compiler.Declaration_Parent, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Language_Grammar, Compiler.Language_Namespace);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Language_Grammar, Compiler.Language_Namespace, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Language_Grammar, Compiler.Language_Namespace, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Grammar", Compiler.Language_Grammar);
                publicPropertiesByName.Add("Namespace", Compiler.Language_Namespace);
                publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
                publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
                publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
                publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Language_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Language_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.Language_Grammar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Language_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Language_Namespace, __ImmutableArray.Create<__ModelProperty>(Compiler.Language_Namespace), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Language_Grammar), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Parent, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Language);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Language_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LanguageInfo";
            }
        }
    }

    internal class LexerRule_Impl : __MetaModelObject, LexerRule
    {
        private LexerRule_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Declaration(this);
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.GrammarRule(this);
            Compiler.__CustomImpl.LexerRule(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<LAlternative> Alternatives
        {
            get => MGetCollection<LAlternative>(Compiler.LexerRule_Alternatives);
        }
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LexerRule_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LexerRule_IsFixed(this);
        }
    
        public Grammar Grammar
        {
            get => MGet<Grammar>(Compiler.GrammarRule_Grammar);
            set => MSet<Grammar>(Compiler.GrammarRule_Grammar, value);
        }
    
        public Language Language
        {
            get => Compiler.__CustomImpl.GrammarRule_Language(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
        {
            get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
        }
    
        public global::System.String? FullName
        {
            get => Compiler.__CustomImpl.Declaration_FullName(this);
        }
    
        public global::System.String? Name
        {
            get => MGet<global::System.String?>(Compiler.Declaration_Name);
            set => MSet<global::System.String?>(Compiler.Declaration_Name, value);
        }
    
        public Declaration? Parent
        {
            get => MGet<Declaration?>(Compiler.Declaration_Parent);
            set => MSet<Declaration?>(Compiler.Declaration_Parent, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.GrammarRuleInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.GrammarRuleInfo, Compiler.CSharpElementInfo, Compiler.DeclarationInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives, Compiler.LexerRule_FixedText, Compiler.LexerRule_IsFixed);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives, Compiler.LexerRule_FixedText, Compiler.LexerRule_IsFixed, Compiler.GrammarRule_Grammar, Compiler.GrammarRule_Language, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives, Compiler.LexerRule_FixedText, Compiler.LexerRule_IsFixed, Compiler.GrammarRule_Grammar, Compiler.GrammarRule_Language, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Alternatives", Compiler.LexerRule_Alternatives);
                publicPropertiesByName.Add("FixedText", Compiler.LexerRule_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LexerRule_IsFixed);
                publicPropertiesByName.Add("Grammar", Compiler.GrammarRule_Grammar);
                publicPropertiesByName.Add("Language", Compiler.GrammarRule_Language);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
                publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
                publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
                publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LexerRule_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LexerRule_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LexerRule_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.GrammarRule_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.GrammarRule_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(LexerRule);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new LexerRule_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LexerRuleInfo";
            }
        }
    }

    internal class Fragment_Impl : __MetaModelObject, Fragment
    {
        private Fragment_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Declaration(this);
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.GrammarRule(this);
            Compiler.__CustomImpl.LexerRule(this);
            Compiler.__CustomImpl.Fragment(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<LAlternative> Alternatives
        {
            get => MGetCollection<LAlternative>(Compiler.LexerRule_Alternatives);
        }
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LexerRule_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LexerRule_IsFixed(this);
        }
    
        public Grammar Grammar
        {
            get => MGet<Grammar>(Compiler.GrammarRule_Grammar);
            set => MSet<Grammar>(Compiler.GrammarRule_Grammar, value);
        }
    
        public Language Language
        {
            get => Compiler.__CustomImpl.GrammarRule_Language(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
        {
            get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
        }
    
        public global::System.String? FullName
        {
            get => Compiler.__CustomImpl.Declaration_FullName(this);
        }
    
        public global::System.String? Name
        {
            get => MGet<global::System.String?>(Compiler.Declaration_Name);
            set => MSet<global::System.String?>(Compiler.Declaration_Name, value);
        }
    
        public Declaration? Parent
        {
            get => MGet<Declaration?>(Compiler.Declaration_Parent);
            set => MSet<Declaration?>(Compiler.Declaration_Parent, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LexerRuleInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LexerRuleInfo, Compiler.GrammarRuleInfo, Compiler.CSharpElementInfo, Compiler.DeclarationInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>();
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives, Compiler.LexerRule_FixedText, Compiler.LexerRule_IsFixed, Compiler.GrammarRule_Grammar, Compiler.GrammarRule_Language, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives, Compiler.LexerRule_FixedText, Compiler.LexerRule_IsFixed, Compiler.GrammarRule_Grammar, Compiler.GrammarRule_Language, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Alternatives", Compiler.LexerRule_Alternatives);
                publicPropertiesByName.Add("FixedText", Compiler.LexerRule_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LexerRule_IsFixed);
                publicPropertiesByName.Add("Grammar", Compiler.GrammarRule_Grammar);
                publicPropertiesByName.Add("Language", Compiler.GrammarRule_Language);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
                publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
                publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
                publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LexerRule_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LexerRule_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LexerRule_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.GrammarRule_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.GrammarRule_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Fragment);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Fragment_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.FragmentInfo";
            }
        }
    }

    internal class Grammar_Impl : __MetaModelObject, Grammar
    {
        private Grammar_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Declaration(this);
            Compiler.__CustomImpl.Grammar(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<Block> Blocks
        {
            get => MGetCollection<Block>(Compiler.Grammar_Blocks);
        }
    
        public Token? DefaultEndOfLine
        {
            get => MGet<Token?>(Compiler.Grammar_DefaultEndOfLine);
            set => MSet<Token?>(Compiler.Grammar_DefaultEndOfLine, value);
        }
    
        public Token? DefaultIdentifier
        {
            get => MGet<Token?>(Compiler.Grammar_DefaultIdentifier);
            set => MSet<Token?>(Compiler.Grammar_DefaultIdentifier, value);
        }
    
        public Token? DefaultSeparator
        {
            get => MGet<Token?>(Compiler.Grammar_DefaultSeparator);
            set => MSet<Token?>(Compiler.Grammar_DefaultSeparator, value);
        }
    
        public Token? DefaultWhitespace
        {
            get => MGet<Token?>(Compiler.Grammar_DefaultWhitespace);
            set => MSet<Token?>(Compiler.Grammar_DefaultWhitespace, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<GrammarRule> GrammarRules
        {
            get => MGetCollection<GrammarRule>(Compiler.Grammar_GrammarRules);
        }
    
        public Language Language
        {
            get => MGet<Language>(Compiler.Grammar_Language);
            set => MSet<Language>(Compiler.Grammar_Language, value);
        }
    
        public Rule? MainRule
        {
            get => MGet<Rule?>(Compiler.Grammar_MainRule);
            set => MSet<Rule?>(Compiler.Grammar_MainRule, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Rule> Rules
        {
            get => MGetCollection<Rule>(Compiler.Grammar_Rules);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<TokenKind> TokenKinds
        {
            get => MGetCollection<TokenKind>(Compiler.Grammar_TokenKinds);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Token> Tokens
        {
            get => MGetCollection<Token>(Compiler.Grammar_Tokens);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
        {
            get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
        }
    
        public global::System.String? FullName
        {
            get => Compiler.__CustomImpl.Declaration_FullName(this);
        }
    
        public global::System.String? Name
        {
            get => MGet<global::System.String?>(Compiler.Declaration_Name);
            set => MSet<global::System.String?>(Compiler.Declaration_Name, value);
        }
    
        public Declaration? Parent
        {
            get => MGet<Declaration?>(Compiler.Declaration_Parent);
            set => MSet<Declaration?>(Compiler.Declaration_Parent, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Blocks, Compiler.Grammar_DefaultEndOfLine, Compiler.Grammar_DefaultIdentifier, Compiler.Grammar_DefaultSeparator, Compiler.Grammar_DefaultWhitespace, Compiler.Grammar_GrammarRules, Compiler.Grammar_Language, Compiler.Grammar_MainRule, Compiler.Grammar_Rules, Compiler.Grammar_TokenKinds, Compiler.Grammar_Tokens);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Blocks, Compiler.Grammar_DefaultEndOfLine, Compiler.Grammar_DefaultIdentifier, Compiler.Grammar_DefaultSeparator, Compiler.Grammar_DefaultWhitespace, Compiler.Grammar_GrammarRules, Compiler.Grammar_Language, Compiler.Grammar_MainRule, Compiler.Grammar_Rules, Compiler.Grammar_TokenKinds, Compiler.Grammar_Tokens, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Blocks, Compiler.Grammar_DefaultEndOfLine, Compiler.Grammar_DefaultIdentifier, Compiler.Grammar_DefaultSeparator, Compiler.Grammar_DefaultWhitespace, Compiler.Grammar_GrammarRules, Compiler.Grammar_Language, Compiler.Grammar_MainRule, Compiler.Grammar_Rules, Compiler.Grammar_TokenKinds, Compiler.Grammar_Tokens, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Blocks", Compiler.Grammar_Blocks);
                publicPropertiesByName.Add("DefaultEndOfLine", Compiler.Grammar_DefaultEndOfLine);
                publicPropertiesByName.Add("DefaultIdentifier", Compiler.Grammar_DefaultIdentifier);
                publicPropertiesByName.Add("DefaultSeparator", Compiler.Grammar_DefaultSeparator);
                publicPropertiesByName.Add("DefaultWhitespace", Compiler.Grammar_DefaultWhitespace);
                publicPropertiesByName.Add("GrammarRules", Compiler.Grammar_GrammarRules);
                publicPropertiesByName.Add("Language", Compiler.Grammar_Language);
                publicPropertiesByName.Add("MainRule", Compiler.Grammar_MainRule);
                publicPropertiesByName.Add("Rules", Compiler.Grammar_Rules);
                publicPropertiesByName.Add("TokenKinds", Compiler.Grammar_TokenKinds);
                publicPropertiesByName.Add("Tokens", Compiler.Grammar_Tokens);
                publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
                publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
                publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
                publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Grammar_Blocks, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_Blocks, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Blocks), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_DefaultEndOfLine, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_DefaultEndOfLine, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_DefaultEndOfLine), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_DefaultIdentifier, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_DefaultIdentifier, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_DefaultIdentifier), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_DefaultSeparator, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_DefaultSeparator, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_DefaultSeparator), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_DefaultWhitespace, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_DefaultWhitespace, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_DefaultWhitespace), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_GrammarRules, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_GrammarRules, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_GrammarRules, Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Rules, Compiler.Grammar_Tokens), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Language, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_MainRule, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_MainRule, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_MainRule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_Rules, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_Rules, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Rules), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_GrammarRules), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_TokenKinds, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_TokenKinds, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_TokenKinds), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Grammar_Tokens, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_Tokens, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Tokens), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_GrammarRules), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_GrammarRules, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_GrammarRules, Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_GrammarRules), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Grammar_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Language, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Grammar_Language), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Grammar);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Grammar_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.GrammarInfo";
            }
        }
    }

    internal class LAlternative_Impl : __MetaModelObject, LAlternative
    {
        private LAlternative_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.LAlternative(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<LElement> Elements
        {
            get => MGetCollection<LElement>(Compiler.LAlternative_Elements);
        }
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LAlternative_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LAlternative_IsFixed(this);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LAlternative_Elements, Compiler.LAlternative_FixedText, Compiler.LAlternative_IsFixed);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LAlternative_Elements, Compiler.LAlternative_FixedText, Compiler.LAlternative_IsFixed);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LAlternative_Elements, Compiler.LAlternative_FixedText, Compiler.LAlternative_IsFixed);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Elements", Compiler.LAlternative_Elements);
                publicPropertiesByName.Add("FixedText", Compiler.LAlternative_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LAlternative_IsFixed);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LAlternative_Elements, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LAlternative_Elements, __ImmutableArray.Create<__ModelProperty>(Compiler.LAlternative_Elements), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LAlternative_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LAlternative_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LAlternative_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LAlternative_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LAlternative_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LAlternative_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(LAlternative);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new LAlternative_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LAlternativeInfo";
            }
        }
    }

    internal class LElement_Impl : __MetaModelObject, LElement
    {
        private LElement_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.LElement(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LElement_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LElement_IsFixed(this);
        }
    
        public global::System.Boolean IsNegated
        {
            get => MGet<global::System.Boolean>(Compiler.LElement_IsNegated);
            set => MSet<global::System.Boolean>(Compiler.LElement_IsNegated, value);
        }
    
        public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
        {
            get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LElement_Multiplicity);
            set => MSet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.LElement_Multiplicity, value);
        }
    
        public LElementValue Value
        {
            get => MGet<LElementValue>(Compiler.LElement_Value);
            set => MSet<LElementValue>(Compiler.LElement_Value, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_FixedText, Compiler.LElement_IsFixed, Compiler.LElement_IsNegated, Compiler.LElement_Multiplicity, Compiler.LElement_Value);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_FixedText, Compiler.LElement_IsFixed, Compiler.LElement_IsNegated, Compiler.LElement_Multiplicity, Compiler.LElement_Value);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_FixedText, Compiler.LElement_IsFixed, Compiler.LElement_IsNegated, Compiler.LElement_Multiplicity, Compiler.LElement_Value);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("FixedText", Compiler.LElement_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LElement_IsFixed);
                publicPropertiesByName.Add("IsNegated", Compiler.LElement_IsNegated);
                publicPropertiesByName.Add("Multiplicity", Compiler.LElement_Multiplicity);
                publicPropertiesByName.Add("Value", Compiler.LElement_Value);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LElement_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LElement_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LElement_IsNegated, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_IsNegated, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_IsNegated), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LElement_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LElement_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElement_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.LElement_Value), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(LElement);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new LElement_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LElementInfo";
            }
        }
    }

    internal class LElementValue_Impl : __MetaModelObject, LElementValue
    {
        private LElementValue_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.LElementValue(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LElementValue_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LElementValue_IsFixed(this);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("FixedText", Compiler.LElementValue_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LElementValue_IsFixed);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(LElementValue);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new LElementValue_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LElementValueInfo";
            }
        }
    }

    internal class LBlock_Impl : __MetaModelObject, LBlock
    {
        private LBlock_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.LElementValue(this);
            Compiler.__CustomImpl.LBlock(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<LAlternative> Alternatives
        {
            get => MGetCollection<LAlternative>(Compiler.LBlock_Alternatives);
        }
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LBlock_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LBlock_IsFixed(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String? LElementValue.FixedText
        {
            get => Compiler.__CustomImpl.LBlock_FixedText(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.Boolean LElementValue.IsFixed
        {
            get => Compiler.__CustomImpl.LBlock_IsFixed(this);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_Alternatives, Compiler.LBlock_FixedText, Compiler.LBlock_IsFixed);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_Alternatives, Compiler.LBlock_FixedText, Compiler.LBlock_IsFixed, Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_Alternatives, Compiler.LBlock_FixedText, Compiler.LBlock_IsFixed);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Alternatives", Compiler.LBlock_Alternatives);
                publicPropertiesByName.Add("FixedText", Compiler.LBlock_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LBlock_IsFixed);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LBlock_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LBlock_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LBlock_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LBlock_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LBlock_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LBlock_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_FixedText)));
                modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LBlock_IsFixed)));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(LBlock);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new LBlock_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LBlockInfo";
            }
        }
    }

    internal class LFixed_Impl : __MetaModelObject, LFixed
    {
        private LFixed_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.LElementValue(this);
            Compiler.__CustomImpl.LFixed(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LFixed_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LFixed_IsFixed(this);
        }
    
        public global::System.String Text
        {
            get => MGet<global::System.String>(Compiler.LFixed_Text);
            set => MSet<global::System.String>(Compiler.LFixed_Text, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String? LElementValue.FixedText
        {
            get => Compiler.__CustomImpl.LFixed_FixedText(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.Boolean LElementValue.IsFixed
        {
            get => Compiler.__CustomImpl.LFixed_IsFixed(this);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_FixedText, Compiler.LFixed_IsFixed, Compiler.LFixed_Text);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_FixedText, Compiler.LFixed_IsFixed, Compiler.LFixed_Text, Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_FixedText, Compiler.LFixed_IsFixed, Compiler.LFixed_Text);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("FixedText", Compiler.LFixed_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LFixed_IsFixed);
                publicPropertiesByName.Add("Text", Compiler.LFixed_Text);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LFixed_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LFixed_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LFixed_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LFixed_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LFixed_Text, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LFixed_Text, __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_Text), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_FixedText)));
                modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LFixed_IsFixed)));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(LFixed);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new LFixed_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LFixedInfo";
            }
        }
    }

    internal class LRange_Impl : __MetaModelObject, LRange
    {
        private LRange_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.LElementValue(this);
            Compiler.__CustomImpl.LRange(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String EndChar
        {
            get => MGet<global::System.String>(Compiler.LRange_EndChar);
            set => MSet<global::System.String>(Compiler.LRange_EndChar, value);
        }
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LRange_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LRange_IsFixed(this);
        }
    
        public global::System.String StartChar
        {
            get => MGet<global::System.String>(Compiler.LRange_StartChar);
            set => MSet<global::System.String>(Compiler.LRange_StartChar, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String? LElementValue.FixedText
        {
            get => Compiler.__CustomImpl.LRange_FixedText(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.Boolean LElementValue.IsFixed
        {
            get => Compiler.__CustomImpl.LRange_IsFixed(this);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_EndChar, Compiler.LRange_FixedText, Compiler.LRange_IsFixed, Compiler.LRange_StartChar);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_EndChar, Compiler.LRange_FixedText, Compiler.LRange_IsFixed, Compiler.LRange_StartChar, Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_EndChar, Compiler.LRange_FixedText, Compiler.LRange_IsFixed, Compiler.LRange_StartChar);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("EndChar", Compiler.LRange_EndChar);
                publicPropertiesByName.Add("FixedText", Compiler.LRange_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LRange_IsFixed);
                publicPropertiesByName.Add("StartChar", Compiler.LRange_StartChar);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LRange_EndChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_EndChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_EndChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LRange_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LRange_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LRange_StartChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_StartChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_StartChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_FixedText)));
                modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_IsFixed)));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(LRange);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new LRange_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LRangeInfo";
            }
        }
    }

    internal class LReference_Impl : __MetaModelObject, LReference
    {
        private LReference_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.LElementValue(this);
            Compiler.__CustomImpl.LReference(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LReference_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LReference_IsFixed(this);
        }
    
        public LexerRule Rule
        {
            get => MGet<LexerRule>(Compiler.LReference_Rule);
            set => MSet<LexerRule>(Compiler.LReference_Rule, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String? LElementValue.FixedText
        {
            get => Compiler.__CustomImpl.LReference_FixedText(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.Boolean LElementValue.IsFixed
        {
            get => Compiler.__CustomImpl.LReference_IsFixed(this);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_FixedText, Compiler.LReference_IsFixed, Compiler.LReference_Rule);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_FixedText, Compiler.LReference_IsFixed, Compiler.LReference_Rule, Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_FixedText, Compiler.LReference_IsFixed, Compiler.LReference_Rule);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("FixedText", Compiler.LReference_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LReference_IsFixed);
                publicPropertiesByName.Add("Rule", Compiler.LReference_Rule);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LReference_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LReference_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LReference_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LReference_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LReference_Rule, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LReference_Rule, __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_FixedText)));
                modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LReference_IsFixed)));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(LReference);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new LReference_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LReferenceInfo";
            }
        }
    }

    internal class LSet_Impl : __MetaModelObject, LSet
    {
        private LSet_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.LElementValue(this);
            Compiler.__CustomImpl.LSet(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LSet_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LSet_IsFixed(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<LSetItem> Items
        {
            get => MGetCollection<LSetItem>(Compiler.LSet_Items);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String? LElementValue.FixedText
        {
            get => Compiler.__CustomImpl.LSet_FixedText(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.Boolean LElementValue.IsFixed
        {
            get => Compiler.__CustomImpl.LSet_IsFixed(this);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_FixedText, Compiler.LSet_IsFixed, Compiler.LSet_Items);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_FixedText, Compiler.LSet_IsFixed, Compiler.LSet_Items, Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_FixedText, Compiler.LSet_IsFixed, Compiler.LSet_Items);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("FixedText", Compiler.LSet_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LSet_IsFixed);
                publicPropertiesByName.Add("Items", Compiler.LSet_Items);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LSet_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSet_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LSet_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSet_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LSet_Items, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSet_Items, __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_Items), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_FixedText)));
                modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSet_IsFixed)));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(LSet);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new LSet_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LSetInfo";
            }
        }
    }

    internal class LSetItem_Impl : __MetaModelObject, LSetItem
    {
        private LSetItem_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.LSetItem(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LSetItem_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LSetItem_IsFixed(this);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText, Compiler.LSetItem_IsFixed);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText, Compiler.LSetItem_IsFixed);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText, Compiler.LSetItem_IsFixed);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("FixedText", Compiler.LSetItem_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LSetItem_IsFixed);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LSetItem_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LSetItem_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(LSetItem);
    
            public override __MetaType SymbolType => default;
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new LSetItem_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LSetItemInfo";
            }
        }
    }

    internal class LSetChar_Impl : __MetaModelObject, LSetChar
    {
        private LSetChar_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.LSetItem(this);
            Compiler.__CustomImpl.LSetChar(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String Char
        {
            get => MGet<global::System.String>(Compiler.LSetChar_Char);
            set => MSet<global::System.String>(Compiler.LSetChar_Char, value);
        }
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LSetChar_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LSetChar_IsFixed(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String? LSetItem.FixedText
        {
            get => Compiler.__CustomImpl.LSetChar_FixedText(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.Boolean LSetItem.IsFixed
        {
            get => Compiler.__CustomImpl.LSetChar_IsFixed(this);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LSetItemInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LSetItemInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_Char, Compiler.LSetChar_FixedText, Compiler.LSetChar_IsFixed);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_Char, Compiler.LSetChar_FixedText, Compiler.LSetChar_IsFixed, Compiler.LSetItem_FixedText, Compiler.LSetItem_IsFixed);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_Char, Compiler.LSetChar_FixedText, Compiler.LSetChar_IsFixed);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Char", Compiler.LSetChar_Char);
                publicPropertiesByName.Add("FixedText", Compiler.LSetChar_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LSetChar_IsFixed);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LSetChar_Char, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetChar_Char, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_Char), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LSetChar_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetChar_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LSetChar_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetChar_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LSetItem_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_FixedText)));
                modelPropertyInfos.Add(Compiler.LSetItem_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetChar_IsFixed)));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(LSetChar);
    
            public override __MetaType SymbolType => default;
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new LSetChar_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LSetCharInfo";
            }
        }
    }

    internal class LSetRange_Impl : __MetaModelObject, LSetRange
    {
        private LSetRange_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.LSetItem(this);
            Compiler.__CustomImpl.LSetRange(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String EndChar
        {
            get => MGet<global::System.String>(Compiler.LSetRange_EndChar);
            set => MSet<global::System.String>(Compiler.LSetRange_EndChar, value);
        }
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LSetRange_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LSetRange_IsFixed(this);
        }
    
        public global::System.String StartChar
        {
            get => MGet<global::System.String>(Compiler.LSetRange_StartChar);
            set => MSet<global::System.String>(Compiler.LSetRange_StartChar, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String? LSetItem.FixedText
        {
            get => Compiler.__CustomImpl.LSetRange_FixedText(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.Boolean LSetItem.IsFixed
        {
            get => Compiler.__CustomImpl.LSetRange_IsFixed(this);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LSetItemInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LSetItemInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_EndChar, Compiler.LSetRange_FixedText, Compiler.LSetRange_IsFixed, Compiler.LSetRange_StartChar);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_EndChar, Compiler.LSetRange_FixedText, Compiler.LSetRange_IsFixed, Compiler.LSetRange_StartChar, Compiler.LSetItem_FixedText, Compiler.LSetItem_IsFixed);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_EndChar, Compiler.LSetRange_FixedText, Compiler.LSetRange_IsFixed, Compiler.LSetRange_StartChar);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("EndChar", Compiler.LSetRange_EndChar);
                publicPropertiesByName.Add("FixedText", Compiler.LSetRange_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LSetRange_IsFixed);
                publicPropertiesByName.Add("StartChar", Compiler.LSetRange_StartChar);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LSetRange_EndChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetRange_EndChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_EndChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LSetRange_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetRange_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LSetRange_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetRange_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LSetRange_StartChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetRange_StartChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_StartChar), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LSetItem_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_FixedText)));
                modelPropertyInfos.Add(Compiler.LSetItem_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LSetItem_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LSetItem_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LSetRange_IsFixed)));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(LSetRange);
    
            public override __MetaType SymbolType => default;
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new LSetRange_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LSetRangeInfo";
            }
        }
    }

    internal class LWildCard_Impl : __MetaModelObject, LWildCard
    {
        private LWildCard_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.LElementValue(this);
            Compiler.__CustomImpl.LWildCard(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LWildCard_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LWildCard_IsFixed(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String? LElementValue.FixedText
        {
            get => Compiler.__CustomImpl.LWildCard_FixedText(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.Boolean LElementValue.IsFixed
        {
            get => Compiler.__CustomImpl.LWildCard_IsFixed(this);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_FixedText, Compiler.LWildCard_IsFixed);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_FixedText, Compiler.LWildCard_IsFixed, Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_FixedText, Compiler.LWildCard_IsFixed);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("FixedText", Compiler.LWildCard_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LWildCard_IsFixed);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LWildCard_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LWildCard_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LWildCard_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LWildCard_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_FixedText)));
                modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LWildCard_IsFixed)));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(LWildCard);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new LWildCard_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LWildCardInfo";
            }
        }
    }

    internal class Namespace_Impl : __MetaModelObject, Namespace
    {
        private Namespace_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Declaration(this);
            Compiler.__CustomImpl.Namespace(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
        {
            get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
        }
    
        public global::System.String? FullName
        {
            get => Compiler.__CustomImpl.Declaration_FullName(this);
        }
    
        public global::System.String? Name
        {
            get => MGet<global::System.String?>(Compiler.Declaration_Name);
            set => MSet<global::System.String?>(Compiler.Declaration_Name, value);
        }
    
        public Declaration? Parent
        {
            get => MGet<Declaration?>(Compiler.Declaration_Parent);
            set => MSet<Declaration?>(Compiler.Declaration_Parent, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.DeclarationInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>();
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
                publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
                publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
                publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Parent, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Namespace);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
            public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Namespace_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.NamespaceInfo";
            }
        }
    }

    internal class Rule_Impl : __MetaModelObject, Rule
    {
        private Rule_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Declaration(this);
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.GrammarRule(this);
            Compiler.__CustomImpl.Rule(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<Alternative> Alternatives
        {
            get => MGetCollection<Alternative>(Compiler.Rule_Alternatives);
        }
    
        public Alternative? BaseRule
        {
            get => MGet<Alternative?>(Compiler.Rule_BaseRule);
            set => MSet<Alternative?>(Compiler.Rule_BaseRule, value);
        }
    
        public global::System.String GreenName
        {
            get => Compiler.__CustomImpl.Rule_GreenName(this);
        }
    
        public global::System.String RedName
        {
            get => Compiler.__CustomImpl.Rule_RedName(this);
        }
    
        public global::MetaDslx.CodeAnalysis.MetaType ReturnType
        {
            get => MGet<global::MetaDslx.CodeAnalysis.MetaType>(Compiler.Rule_ReturnType);
            set => MSet<global::MetaDslx.CodeAnalysis.MetaType>(Compiler.Rule_ReturnType, value);
        }
    
        public Grammar Grammar
        {
            get => MGet<Grammar>(Compiler.GrammarRule_Grammar);
            set => MSet<Grammar>(Compiler.GrammarRule_Grammar, value);
        }
    
        public Language Language
        {
            get => Compiler.__CustomImpl.GrammarRule_Language(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
        {
            get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
        }
    
        public global::System.String? FullName
        {
            get => Compiler.__CustomImpl.Declaration_FullName(this);
        }
    
        public global::System.String? Name
        {
            get => MGet<global::System.String?>(Compiler.Declaration_Name);
            set => MSet<global::System.String?>(Compiler.Declaration_Name, value);
        }
    
        public Declaration? Parent
        {
            get => MGet<Declaration?>(Compiler.Declaration_Parent);
            set => MSet<Declaration?>(Compiler.Declaration_Parent, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.GrammarRuleInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.GrammarRuleInfo, Compiler.CSharpElementInfo, Compiler.DeclarationInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Alternatives, Compiler.Rule_BaseRule, Compiler.Rule_GreenName, Compiler.Rule_RedName, Compiler.Rule_ReturnType);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Alternatives, Compiler.Rule_BaseRule, Compiler.Rule_GreenName, Compiler.Rule_RedName, Compiler.Rule_ReturnType, Compiler.GrammarRule_Grammar, Compiler.GrammarRule_Language, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Alternatives, Compiler.Rule_BaseRule, Compiler.Rule_GreenName, Compiler.Rule_RedName, Compiler.Rule_ReturnType, Compiler.GrammarRule_Grammar, Compiler.GrammarRule_Language, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Alternatives", Compiler.Rule_Alternatives);
                publicPropertiesByName.Add("BaseRule", Compiler.Rule_BaseRule);
                publicPropertiesByName.Add("GreenName", Compiler.Rule_GreenName);
                publicPropertiesByName.Add("RedName", Compiler.Rule_RedName);
                publicPropertiesByName.Add("ReturnType", Compiler.Rule_ReturnType);
                publicPropertiesByName.Add("Grammar", Compiler.GrammarRule_Grammar);
                publicPropertiesByName.Add("Language", Compiler.GrammarRule_Language);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
                publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
                publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
                publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Rule_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Rule_BaseRule, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_BaseRule, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_BaseRule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Rule_GreenName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_GreenName, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_GreenName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Rule_RedName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_RedName, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_RedName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Rule_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Rule_ReturnType, __ImmutableArray.Create<__ModelProperty>(Compiler.Rule_ReturnType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.GrammarRule_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.GrammarRule_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Rule);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.ParserRuleSymbol);
            public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Rule_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.RuleInfo";
            }
        }
    }

    internal class RuleRef_Impl : __MetaModelObject, RuleRef
    {
        private RuleRef_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.ElementValue(this);
            Compiler.__CustomImpl.RuleRef(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public GrammarRule GrammarRule
        {
            get => MGet<GrammarRule>(Compiler.RuleRef_GrammarRule);
            set => MSet<GrammarRule>(Compiler.RuleRef_GrammarRule, value);
        }
    
        public global::System.String? GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.RuleRef_GreenSyntaxCondition(this);
        }
    
        public global::System.String GreenType
        {
            get => Compiler.__CustomImpl.RuleRef_GreenType(this);
        }
    
        public global::System.String RedType
        {
            get => Compiler.__CustomImpl.RuleRef_RedType(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<global::MetaDslx.CodeAnalysis.MetaType> ReferencedTypes
        {
            get => MGetCollection<global::MetaDslx.CodeAnalysis.MetaType>(Compiler.RuleRef_ReferencedTypes);
        }
    
        public Rule? Rule
        {
            get => Compiler.__CustomImpl.RuleRef_Rule(this);
        }
    
        public Token? Token
        {
            get => Compiler.__CustomImpl.RuleRef_Token(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String? ElementValue.GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.RuleRef_GreenSyntaxCondition(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String ElementValue.GreenType
        {
            get => Compiler.__CustomImpl.RuleRef_GreenType(this);
        }
    
        public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
        {
            get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ElementValue_Multiplicity);
            set => MSet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ElementValue_Multiplicity, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String ElementValue.RedType
        {
            get => Compiler.__CustomImpl.RuleRef_RedType(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ElementValueInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ElementValueInfo, Compiler.CSharpElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.RuleRef_GrammarRule, Compiler.RuleRef_GreenSyntaxCondition, Compiler.RuleRef_GreenType, Compiler.RuleRef_RedType, Compiler.RuleRef_ReferencedTypes, Compiler.RuleRef_Rule, Compiler.RuleRef_Token);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.RuleRef_GrammarRule, Compiler.RuleRef_GreenSyntaxCondition, Compiler.RuleRef_GreenType, Compiler.RuleRef_RedType, Compiler.RuleRef_ReferencedTypes, Compiler.RuleRef_Rule, Compiler.RuleRef_Token, Compiler.ElementValue_GreenSyntaxCondition, Compiler.ElementValue_GreenType, Compiler.ElementValue_Multiplicity, Compiler.ElementValue_RedType, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.RuleRef_GrammarRule, Compiler.RuleRef_GreenSyntaxCondition, Compiler.RuleRef_GreenType, Compiler.RuleRef_RedType, Compiler.RuleRef_ReferencedTypes, Compiler.RuleRef_Rule, Compiler.RuleRef_Token, Compiler.ElementValue_Multiplicity, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("GrammarRule", Compiler.RuleRef_GrammarRule);
                publicPropertiesByName.Add("GreenSyntaxCondition", Compiler.RuleRef_GreenSyntaxCondition);
                publicPropertiesByName.Add("GreenType", Compiler.RuleRef_GreenType);
                publicPropertiesByName.Add("RedType", Compiler.RuleRef_RedType);
                publicPropertiesByName.Add("ReferencedTypes", Compiler.RuleRef_ReferencedTypes);
                publicPropertiesByName.Add("Rule", Compiler.RuleRef_Rule);
                publicPropertiesByName.Add("Token", Compiler.RuleRef_Token);
                publicPropertiesByName.Add("Multiplicity", Compiler.ElementValue_Multiplicity);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.RuleRef_GrammarRule, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.RuleRef_GrammarRule, __ImmutableArray.Create<__ModelProperty>(Compiler.RuleRef_GrammarRule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.RuleRef_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.RuleRef_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.RuleRef_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.RuleRef_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.RuleRef_GreenType, __ImmutableArray.Create<__ModelProperty>(Compiler.RuleRef_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.RuleRef_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.RuleRef_RedType, __ImmutableArray.Create<__ModelProperty>(Compiler.RuleRef_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_RedType), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.RuleRef_ReferencedTypes, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.RuleRef_ReferencedTypes, __ImmutableArray.Create<__ModelProperty>(Compiler.RuleRef_ReferencedTypes), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.RuleRef_Rule, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.RuleRef_Rule, __ImmutableArray.Create<__ModelProperty>(Compiler.RuleRef_Rule), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.RuleRef_Token, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.RuleRef_Token, __ImmutableArray.Create<__ModelProperty>(Compiler.RuleRef_Token), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.RuleRef_GreenSyntaxCondition)));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.RuleRef_GreenType)));
                modelPropertyInfos.Add(Compiler.ElementValue_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_RedType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.RuleRef_RedType)));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(RuleRef);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.PReferenceSymbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new RuleRef_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.RuleRefInfo";
            }
        }
    }

    internal class SeparatedList_Impl : __MetaModelObject, SeparatedList
    {
        private SeparatedList_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.ElementValue(this);
            Compiler.__CustomImpl.SeparatedList(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<Element> FirstItems
        {
            get => MGetCollection<Element>(Compiler.SeparatedList_FirstItems);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Element> FirstSeparators
        {
            get => MGetCollection<Element>(Compiler.SeparatedList_FirstSeparators);
        }
    
        public global::System.String? GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.SeparatedList_GreenSyntaxCondition(this);
        }
    
        public global::System.String GreenType
        {
            get => Compiler.__CustomImpl.SeparatedList_GreenType(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Element> LastItems
        {
            get => MGetCollection<Element>(Compiler.SeparatedList_LastItems);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Element> LastSeparators
        {
            get => MGetCollection<Element>(Compiler.SeparatedList_LastSeparators);
        }
    
        public global::System.String RedType
        {
            get => Compiler.__CustomImpl.SeparatedList_RedType(this);
        }
    
        public Element RepeatedBlock
        {
            get => MGet<Element>(Compiler.SeparatedList_RepeatedBlock);
            set => MSet<Element>(Compiler.SeparatedList_RepeatedBlock, value);
        }
    
        public Element RepeatedItem
        {
            get => MGet<Element>(Compiler.SeparatedList_RepeatedItem);
            set => MSet<Element>(Compiler.SeparatedList_RepeatedItem, value);
        }
    
        public Element RepeatedSeparator
        {
            get => MGet<Element>(Compiler.SeparatedList_RepeatedSeparator);
            set => MSet<Element>(Compiler.SeparatedList_RepeatedSeparator, value);
        }
    
        public global::System.Boolean RepeatedSeparatorFirst
        {
            get => MGet<global::System.Boolean>(Compiler.SeparatedList_RepeatedSeparatorFirst);
            set => MSet<global::System.Boolean>(Compiler.SeparatedList_RepeatedSeparatorFirst, value);
        }
    
        public global::System.Boolean SeparatorFirst
        {
            get => MGet<global::System.Boolean>(Compiler.SeparatedList_SeparatorFirst);
            set => MSet<global::System.Boolean>(Compiler.SeparatedList_SeparatorFirst, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String? ElementValue.GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.SeparatedList_GreenSyntaxCondition(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String ElementValue.GreenType
        {
            get => Compiler.__CustomImpl.SeparatedList_GreenType(this);
        }
    
        public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
        {
            get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ElementValue_Multiplicity);
            set => MSet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ElementValue_Multiplicity, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String ElementValue.RedType
        {
            get => Compiler.__CustomImpl.SeparatedList_RedType(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ElementValueInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ElementValueInfo, Compiler.CSharpElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_FirstItems, Compiler.SeparatedList_FirstSeparators, Compiler.SeparatedList_GreenSyntaxCondition, Compiler.SeparatedList_GreenType, Compiler.SeparatedList_LastItems, Compiler.SeparatedList_LastSeparators, Compiler.SeparatedList_RedType, Compiler.SeparatedList_RepeatedBlock, Compiler.SeparatedList_RepeatedItem, Compiler.SeparatedList_RepeatedSeparator, Compiler.SeparatedList_RepeatedSeparatorFirst, Compiler.SeparatedList_SeparatorFirst);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_FirstItems, Compiler.SeparatedList_FirstSeparators, Compiler.SeparatedList_GreenSyntaxCondition, Compiler.SeparatedList_GreenType, Compiler.SeparatedList_LastItems, Compiler.SeparatedList_LastSeparators, Compiler.SeparatedList_RedType, Compiler.SeparatedList_RepeatedBlock, Compiler.SeparatedList_RepeatedItem, Compiler.SeparatedList_RepeatedSeparator, Compiler.SeparatedList_RepeatedSeparatorFirst, Compiler.SeparatedList_SeparatorFirst, Compiler.ElementValue_GreenSyntaxCondition, Compiler.ElementValue_GreenType, Compiler.ElementValue_Multiplicity, Compiler.ElementValue_RedType, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_FirstItems, Compiler.SeparatedList_FirstSeparators, Compiler.SeparatedList_GreenSyntaxCondition, Compiler.SeparatedList_GreenType, Compiler.SeparatedList_LastItems, Compiler.SeparatedList_LastSeparators, Compiler.SeparatedList_RedType, Compiler.SeparatedList_RepeatedBlock, Compiler.SeparatedList_RepeatedItem, Compiler.SeparatedList_RepeatedSeparator, Compiler.SeparatedList_RepeatedSeparatorFirst, Compiler.SeparatedList_SeparatorFirst, Compiler.ElementValue_Multiplicity, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("FirstItems", Compiler.SeparatedList_FirstItems);
                publicPropertiesByName.Add("FirstSeparators", Compiler.SeparatedList_FirstSeparators);
                publicPropertiesByName.Add("GreenSyntaxCondition", Compiler.SeparatedList_GreenSyntaxCondition);
                publicPropertiesByName.Add("GreenType", Compiler.SeparatedList_GreenType);
                publicPropertiesByName.Add("LastItems", Compiler.SeparatedList_LastItems);
                publicPropertiesByName.Add("LastSeparators", Compiler.SeparatedList_LastSeparators);
                publicPropertiesByName.Add("RedType", Compiler.SeparatedList_RedType);
                publicPropertiesByName.Add("RepeatedBlock", Compiler.SeparatedList_RepeatedBlock);
                publicPropertiesByName.Add("RepeatedItem", Compiler.SeparatedList_RepeatedItem);
                publicPropertiesByName.Add("RepeatedSeparator", Compiler.SeparatedList_RepeatedSeparator);
                publicPropertiesByName.Add("RepeatedSeparatorFirst", Compiler.SeparatedList_RepeatedSeparatorFirst);
                publicPropertiesByName.Add("SeparatorFirst", Compiler.SeparatedList_SeparatorFirst);
                publicPropertiesByName.Add("Multiplicity", Compiler.ElementValue_Multiplicity);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.SeparatedList_FirstItems, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.SeparatedList_FirstItems, __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_FirstItems), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.SeparatedList_FirstSeparators, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.SeparatedList_FirstSeparators, __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_FirstSeparators), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.SeparatedList_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.SeparatedList_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.SeparatedList_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.SeparatedList_GreenType, __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.SeparatedList_LastItems, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.SeparatedList_LastItems, __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_LastItems), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.SeparatedList_LastSeparators, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.SeparatedList_LastSeparators, __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_LastSeparators), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.SeparatedList_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.SeparatedList_RedType, __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_RedType), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.SeparatedList_RepeatedBlock, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.SeparatedList_RepeatedBlock, __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_RepeatedBlock), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.SeparatedList_RepeatedItem, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.SeparatedList_RepeatedItem, __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_RepeatedItem), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.SeparatedList_RepeatedSeparator, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.SeparatedList_RepeatedSeparator, __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_RepeatedSeparator), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.SeparatedList_RepeatedSeparatorFirst, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.SeparatedList_RepeatedSeparatorFirst, __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_RepeatedSeparatorFirst), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.SeparatedList_SeparatorFirst, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.SeparatedList_SeparatorFirst, __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_SeparatorFirst), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_GreenSyntaxCondition)));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_GreenType)));
                modelPropertyInfos.Add(Compiler.ElementValue_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_RedType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.SeparatedList_RedType)));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(SeparatedList);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new SeparatedList_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.SeparatedListInfo";
            }
        }
    }

    internal class Token_Impl : __MetaModelObject, Token
    {
        private Token_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.Declaration(this);
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.GrammarRule(this);
            Compiler.__CustomImpl.LexerRule(this);
            Compiler.__CustomImpl.Token(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.Boolean IsTrivia
        {
            get => MGet<global::System.Boolean>(Compiler.Token_IsTrivia);
            set => MSet<global::System.Boolean>(Compiler.Token_IsTrivia, value);
        }
    
        public global::MetaDslx.CodeAnalysis.MetaType ReturnType
        {
            get => MGet<global::MetaDslx.CodeAnalysis.MetaType>(Compiler.Token_ReturnType);
            set => MSet<global::MetaDslx.CodeAnalysis.MetaType>(Compiler.Token_ReturnType, value);
        }
    
        public TokenKind? TokenKind
        {
            get => MGet<TokenKind?>(Compiler.Token_TokenKind);
            set => MSet<TokenKind?>(Compiler.Token_TokenKind, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<LAlternative> Alternatives
        {
            get => MGetCollection<LAlternative>(Compiler.LexerRule_Alternatives);
        }
    
        public global::System.String? FixedText
        {
            get => Compiler.__CustomImpl.LexerRule_FixedText(this);
        }
    
        public global::System.Boolean IsFixed
        {
            get => Compiler.__CustomImpl.LexerRule_IsFixed(this);
        }
    
        public Grammar Grammar
        {
            get => MGet<Grammar>(Compiler.GrammarRule_Grammar);
            set => MSet<Grammar>(Compiler.GrammarRule_Grammar, value);
        }
    
        public Language Language
        {
            get => Compiler.__CustomImpl.GrammarRule_Language(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
        {
            get => MGetCollection<Declaration>(Compiler.Declaration_Declarations);
        }
    
        public global::System.String? FullName
        {
            get => Compiler.__CustomImpl.Declaration_FullName(this);
        }
    
        public global::System.String? Name
        {
            get => MGet<global::System.String?>(Compiler.Declaration_Name);
            set => MSet<global::System.String?>(Compiler.Declaration_Name, value);
        }
    
        public Declaration? Parent
        {
            get => MGet<Declaration?>(Compiler.Declaration_Parent);
            set => MSet<Declaration?>(Compiler.Declaration_Parent, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LexerRuleInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LexerRuleInfo, Compiler.GrammarRuleInfo, Compiler.CSharpElementInfo, Compiler.DeclarationInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Token_IsTrivia, Compiler.Token_ReturnType, Compiler.Token_TokenKind);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Token_IsTrivia, Compiler.Token_ReturnType, Compiler.Token_TokenKind, Compiler.LexerRule_Alternatives, Compiler.LexerRule_FixedText, Compiler.LexerRule_IsFixed, Compiler.GrammarRule_Grammar, Compiler.GrammarRule_Language, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Token_IsTrivia, Compiler.Token_ReturnType, Compiler.Token_TokenKind, Compiler.LexerRule_Alternatives, Compiler.LexerRule_FixedText, Compiler.LexerRule_IsFixed, Compiler.GrammarRule_Grammar, Compiler.GrammarRule_Language, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName, Compiler.Declaration_Declarations, Compiler.Declaration_FullName, Compiler.Declaration_Name, Compiler.Declaration_Parent);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("IsTrivia", Compiler.Token_IsTrivia);
                publicPropertiesByName.Add("ReturnType", Compiler.Token_ReturnType);
                publicPropertiesByName.Add("TokenKind", Compiler.Token_TokenKind);
                publicPropertiesByName.Add("Alternatives", Compiler.LexerRule_Alternatives);
                publicPropertiesByName.Add("FixedText", Compiler.LexerRule_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LexerRule_IsFixed);
                publicPropertiesByName.Add("Grammar", Compiler.GrammarRule_Grammar);
                publicPropertiesByName.Add("Language", Compiler.GrammarRule_Language);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                publicPropertiesByName.Add("Declarations", Compiler.Declaration_Declarations);
                publicPropertiesByName.Add("FullName", Compiler.Declaration_FullName);
                publicPropertiesByName.Add("Name", Compiler.Declaration_Name);
                publicPropertiesByName.Add("Parent", Compiler.Declaration_Parent);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Token_IsTrivia, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Token_IsTrivia, __ImmutableArray.Create<__ModelProperty>(Compiler.Token_IsTrivia), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Token_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Token_ReturnType, __ImmutableArray.Create<__ModelProperty>(Compiler.Token_ReturnType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Token_TokenKind, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Token_TokenKind, __ImmutableArray.Create<__ModelProperty>(Compiler.Token_TokenKind), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LexerRule_Alternatives, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_Alternatives, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_Alternatives), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LexerRule_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_FixedText), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LexerRule_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LexerRule_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LexerRule_IsFixed), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.GrammarRule_Grammar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.GrammarRule_Language, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Language, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Language), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Declarations, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_FullName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.GrammarRule_Grammar, __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar, Compiler.Declaration_Parent), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Compiler.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.GrammarRule_Grammar), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Token);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.Bootstrap.MetaCompiler.Symbols.TokenSymbol);
            public override __ModelProperty? NameProperty => Compiler.Declaration_Name;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Token_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.TokenInfo";
            }
        }
    }

    internal class TokenAlts_Impl : __MetaModelObject, TokenAlts
    {
        private TokenAlts_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.ElementValue(this);
            Compiler.__CustomImpl.TokenAlts(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String? GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.TokenAlts_GreenSyntaxCondition(this);
        }
    
        public global::System.String GreenType
        {
            get => Compiler.__CustomImpl.TokenAlts_GreenType(this);
        }
    
        public global::System.String RedType
        {
            get => Compiler.__CustomImpl.TokenAlts_RedType(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<RuleRef> Tokens
        {
            get => MGetCollection<RuleRef>(Compiler.TokenAlts_Tokens);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String? ElementValue.GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.TokenAlts_GreenSyntaxCondition(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String ElementValue.GreenType
        {
            get => Compiler.__CustomImpl.TokenAlts_GreenType(this);
        }
    
        public global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity Multiplicity
        {
            get => MGet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ElementValue_Multiplicity);
            set => MSet<global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity>(Compiler.ElementValue_Multiplicity, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::System.String ElementValue.RedType
        {
            get => Compiler.__CustomImpl.TokenAlts_RedType(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public global::System.String AntlrName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_AntlrName);
            set => MSet<global::System.String>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public global::System.Boolean ContainsBinders
        {
            get => MGet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<global::System.Boolean>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public global::System.String CSharpName
        {
            get => MGet<global::System.String>(Compiler.CSharpElement_CSharpName);
            set => MSet<global::System.String>(Compiler.CSharpElement_CSharpName, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ElementValueInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ElementValueInfo, Compiler.CSharpElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.TokenAlts_GreenSyntaxCondition, Compiler.TokenAlts_GreenType, Compiler.TokenAlts_RedType, Compiler.TokenAlts_Tokens);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.TokenAlts_GreenSyntaxCondition, Compiler.TokenAlts_GreenType, Compiler.TokenAlts_RedType, Compiler.TokenAlts_Tokens, Compiler.ElementValue_GreenSyntaxCondition, Compiler.ElementValue_GreenType, Compiler.ElementValue_Multiplicity, Compiler.ElementValue_RedType, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.TokenAlts_GreenSyntaxCondition, Compiler.TokenAlts_GreenType, Compiler.TokenAlts_RedType, Compiler.TokenAlts_Tokens, Compiler.ElementValue_Multiplicity, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("GreenSyntaxCondition", Compiler.TokenAlts_GreenSyntaxCondition);
                publicPropertiesByName.Add("GreenType", Compiler.TokenAlts_GreenType);
                publicPropertiesByName.Add("RedType", Compiler.TokenAlts_RedType);
                publicPropertiesByName.Add("Tokens", Compiler.TokenAlts_Tokens);
                publicPropertiesByName.Add("Multiplicity", Compiler.ElementValue_Multiplicity);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.TokenAlts_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.TokenAlts_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.TokenAlts_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.TokenAlts_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.TokenAlts_GreenType, __ImmutableArray.Create<__ModelProperty>(Compiler.TokenAlts_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.TokenAlts_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.TokenAlts_RedType, __ImmutableArray.Create<__ModelProperty>(Compiler.TokenAlts_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_RedType), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.TokenAlts_Tokens, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.TokenAlts_Tokens, __ImmutableArray.Create<__ModelProperty>(Compiler.TokenAlts_Tokens), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.TokenAlts_GreenSyntaxCondition)));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.TokenAlts_GreenType)));
                modelPropertyInfos.Add(Compiler.ElementValue_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_Multiplicity), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_RedType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_RedType), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.TokenAlts_RedType)));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(TokenAlts);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new TokenAlts_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.TokenAltsInfo";
            }
        }
    }

    internal class TokenKind_Impl : __MetaModelObject, TokenKind
    {
        private TokenKind_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.TokenKind(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::System.String Name
        {
            get => MGet<global::System.String>(Compiler.TokenKind_Name);
            set => MSet<global::System.String>(Compiler.TokenKind_Name, value);
        }
    
        public global::System.String TypeName
        {
            get => MGet<global::System.String>(Compiler.TokenKind_TypeName);
            set => MSet<global::System.String>(Compiler.TokenKind_TypeName, value);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.TokenKind_Name, Compiler.TokenKind_TypeName);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.TokenKind_Name, Compiler.TokenKind_TypeName);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.TokenKind_Name, Compiler.TokenKind_TypeName);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Name", Compiler.TokenKind_Name);
                publicPropertiesByName.Add("TypeName", Compiler.TokenKind_TypeName);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.TokenKind_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.TokenKind_Name, __ImmutableArray.Create<__ModelProperty>(Compiler.TokenKind_Name), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.TokenKind_TypeName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.TokenKind_TypeName, __ImmutableArray.Create<__ModelProperty>(Compiler.TokenKind_TypeName), null, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(TokenKind);
    
            public override __MetaType SymbolType => default;
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new TokenKind_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.TokenKindInfo";
            }
        }
    }

}
