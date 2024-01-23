parser grammar MetaParser;

options
{
    tokenVocab = MetaLexer; 
} 

pr_Main
    : e_KNamespace=LR_KNamespace e_Name=pr_Qualifier e_TSemicolon=LR_TSemicolon e_UsingList+=pr_Using* e_Declarations=pr_Declarations e_EndOfFileToken=EOF
    ;
pr_Using
    : e_KUsing=LR_KUsing e_Namespaces=pr_Qualifier e_TSemicolon=LR_TSemicolon
    ;
pr_Declarations
    : e_Declarations+=pr_MetaDeclaration*
    ;
pr_MetaDeclaration
    : e_KMetamodel=LR_KMetamodel e_Name=pr_Name e_TSemicolon=LR_TSemicolon #pr_MetaModel
    | e_KConst=LR_KConst e_Type=pr_TypeReference e_Name1=pr_Name e_TSemicolon1=LR_TSemicolon #pr_MetaConstant
    | e_KEnum=LR_KEnum e_Name2=pr_Name e_EnumBody=pr_EnumBody #pr_MetaEnum
    | e_IsAbstract=LR_KAbstract? e_KClass=LR_KClass e_ClassName=pr_ClassName e_BaseClasses=pr_BaseClasses? e_ClassBody=pr_ClassBody #pr_MetaClass
    ;
pr_EnumBody
    : e_TLBrace=LR_TLBrace e_Literals1=pr_MetaEnumLiteral(e_TComma1+=LR_TComma e_Literals2+=pr_MetaEnumLiteral)* e_TRBrace=LR_TRBrace
    ;
pr_MetaEnumLiteral
    : e_Name=pr_Name
    ;
pr_ClassName
    : e_Identifier=pr_Identifier? e_TDollar=LR_TDollar e_SymbolType=pr_Identifier #pr_ClassNameAlt1
    | e_Identifier1=pr_Identifier #pr_ClassNameAlt2
    ;
pr_BaseClasses
    : e_TColon=LR_TColon e_BaseTypes1=pr_Qualifier(e_TComma1+=LR_TComma e_BaseTypes2+=pr_Qualifier)*
    ;
pr_ClassBody
    : e_TLBrace=LR_TLBrace e_ClassMemberList+=pr_ClassMember* e_TRBrace=LR_TRBrace
    ;
pr_ClassMember
    : e_Properties=pr_MetaProperty #pr_ClassMemberAlt1
    | e_Operations=pr_MetaOperation #pr_ClassMemberAlt2
    ;
pr_MetaProperty
    : e_Tokens=(LR_KContains | LR_KDerived)? e_Type=pr_TypeReference e_PropertyName=pr_PropertyName e_Block+=pr_MetaPropertyBlock1* e_TSemicolon=LR_TSemicolon
    ;
pr_PropertyName
    : e_Identifier=pr_Identifier? e_TDollar=LR_TDollar e_SymbolProperty=pr_Identifier #pr_PropertyNameAlt1
    | e_Identifier1=pr_Identifier #pr_PropertyNameAlt2
    ;
pr_MetaOperation
    : e_ReturnType=pr_TypeReference e_Name=pr_Name e_TLParen=LR_TLParen e_Parameters1=pr_MetaParameter(e_TComma1+=LR_TComma e_Parameters2+=pr_MetaParameter)* e_TRParen=LR_TRParen e_TSemicolon=LR_TSemicolon
    ;
pr_MetaParameter
    : e_Type=pr_TypeReference e_Name=pr_Name
    ;
pr_TypeReference
    : e_Token=(LR_KBool | LR_KInt | LR_KString | LR_KType | LR_KSymbol | LR_KObject | LR_KVoid) #pr_TypeReferenceTokens
    | e_Qualifier=pr_Qualifier #pr_SimpleTypeReferenceAlt2
    | e_ItemType=pr_TypeReference e_TLBracket=LR_TLBracket e_TRBracket=LR_TRBracket #pr_MetaArrayType
    | e_InnerType=pr_TypeReference e_TQuestion=LR_TQuestion #pr_MetaNullableType
    ;
pr_Name
    : e_Identifier=pr_Identifier
    ;
pr_Qualifier
    : e_Identifier1=pr_Identifier(e_TDot1+=LR_TDot e_Identifier2+=pr_Identifier)*
    ;
pr_Identifier
    : e_Token=(LR_TIdentifier | LR_TVerbatimIdentifier)
    ;
pr_EnumBodyEnumLiteralsBlock
    : e_TComma1=LR_TComma e_Literals2=pr_MetaEnumLiteral
    ;
pr_BaseClassesBaseTypesBlock
    : e_TComma1=LR_TComma e_BaseTypes2=pr_Qualifier
    ;
pr_MetaPropertyBlock1
    : e_KOpposite=LR_KOpposite e_OppositeProperties1=pr_Qualifier(e_TComma1+=LR_TComma e_OppositeProperties2+=pr_Qualifier)* #pr_PropertyOpposite
    | e_KSubsets=LR_KSubsets e_SubsettedProperties1=pr_Qualifier(e_TComma2+=LR_TComma e_SubsettedProperties2+=pr_Qualifier)* #pr_PropertySubsets
    | e_KRedefines=LR_KRedefines e_RedefinedProperties1=pr_Qualifier(e_TComma3+=LR_TComma e_RedefinedProperties2+=pr_Qualifier)* #pr_PropertyRedefines
    ;
pr_PropertyOppositeOppositePropertiesBlock1
    : e_TComma1=LR_TComma e_OppositeProperties2=pr_Qualifier
    ;
pr_PropertySubsetsSubsettedPropertiesBlock1
    : e_TComma2=LR_TComma e_SubsettedProperties2=pr_Qualifier
    ;
pr_PropertyRedefinesRedefinedPropertiesBlock1
    : e_TComma3=LR_TComma e_RedefinedProperties2=pr_Qualifier
    ;
pr_MetaOperationParameterListBlock
    : e_TComma1=LR_TComma e_Parameters2=pr_MetaParameter
    ;
pr_QualifierQualifierBlock
    : e_TDot1=LR_TDot e_Identifier2=pr_Identifier
    ;
