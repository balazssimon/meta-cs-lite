parser grammar SoalParser;

options
{
    tokenVocab = SoalLexer; 
} 

pr_Main
    :  E_KNamespace=LR_KNamespace  E_Qualifier=pr_Qualifier  E_TSemicolon=LR_TSemicolon  E_UsingList+=pr_Using*  E_Block=pr_MainBlock1  E_EndOfFileToken=EOF
    ;
pr_Using
    :  E_KUsing=LR_KUsing  E_namespaces=pr_Qualifier  E_TSemicolon=LR_TSemicolon
    ;
pr_Declaration
    :  E_EnumType=pr_EnumType #pr_DeclarationAlt1
    |  E_StructType=pr_StructType #pr_DeclarationAlt2
    |  E_Interface=pr_Interface #pr_DeclarationAlt3
    |  E_Service=pr_Service #pr_DeclarationAlt4
    ;
pr_EnumType
    :  E_KEnum=LR_KEnum  E_Name=pr_Name  E_TLBrace=LR_TLBrace  E_Block=pr_EnumTypeBlock1?  E_TRBrace=LR_TRBrace
    ;
pr_EnumLiteral
    :  E_Name=pr_Name
    ;
pr_StructType
    :  E_KStruct=LR_KStruct  E_Name=pr_Name  E_Block=pr_StructTypeBlock1?  E_TLBrace=LR_TLBrace  E_fields+=pr_Property*  E_TRBrace=LR_TRBrace
    ;
pr_Property
    :  E_type=pr_TypeReference  E_Name=pr_Name  E_TSemicolon=LR_TSemicolon
    ;
pr_Interface
    :  E_KInterface=LR_KInterface  E_Name=pr_Name  E_TLBrace=LR_TLBrace  E_resources+=pr_Resource*  E_operations+=pr_Operation*  E_TRBrace=LR_TRBrace
    ;
pr_Resource
    :  E_isReadOnly=LR_KReadonly?  E_KResource=LR_KResource  E_entity=pr_Qualifier  E_Block=pr_ResourceBlock1?  E_TSemicolon=LR_TSemicolon
    ;
pr_Operation
    :  E_isAsync=LR_KAsync?  E_responseParameters=pr_OutputParameterList  E_Name=pr_Name  E_requestParameters=pr_InputParameterList  E_Block=pr_OperationBlock1?  E_TSemicolon=LR_TSemicolon
    ;
pr_InputParameterList
    :  E_TLParen=LR_TLParen  E_Block=pr_InputParameterListBlock1?  E_TRParen=LR_TRParen
    ;
pr_OutputParameterList
    :  E_KVoid=LR_KVoid #pr_OutputParameterListAlt1
    |  E_parameters=pr_SingleReturnParameter #pr_OutputParameterListAlt2
    |  E_TLParen=LR_TLParen   E_parameters1=pr_Parameter(E_TComma1+=LR_TComma E_parameters2+=pr_Parameter)*  E_TRParen=LR_TRParen #pr_OutputParameterListAlt3
    ;
pr_Parameter
    :  E_type=pr_TypeReference  E_Name=pr_Name
    ;
pr_SingleReturnParameter
    :  E_type=pr_TypeReference
    ;
pr_Service
    :  E_KService=LR_KService  E_Name=pr_Name  E_TColon=LR_TColon  E_interface=pr_Qualifier  E_TLBrace=LR_TLBrace  E_KBinding=LR_KBinding  E_binding=pr_BindingKind  E_TSemicolon=LR_TSemicolon  E_TRBrace=LR_TRBrace
    ;
pr_BindingKind
    :  E_Token=(LR_KREST | LR_KSOAP)
    ;
pr_TypeReference
    :  E_type=pr_SimpleType  E_isNullable=LR_TQuestion?  E_isArray=pr_TypeReferenceBlock1?
    ;
pr_SimpleType
    :  E_KObject=LR_KObject #pr_SimpleTypeAlt1
    |  E_KBinary=LR_KBinary #pr_SimpleTypeAlt2
    |  E_KBool=LR_KBool #pr_SimpleTypeAlt3
    |  E_KString=LR_KString #pr_SimpleTypeAlt4
    |  E_KInt=LR_KInt #pr_SimpleTypeAlt5
    |  E_KLong=LR_KLong #pr_SimpleTypeAlt6
    |  E_KFloat=LR_KFloat #pr_SimpleTypeAlt7
    |  E_KDouble=LR_KDouble #pr_SimpleTypeAlt8
    |  E_KDate=LR_KDate #pr_SimpleTypeAlt9
    |  E_KTime=LR_KTime #pr_SimpleTypeAlt10
    |  E_KDatetime=LR_KDatetime #pr_SimpleTypeAlt11
    |  E_KDuration=LR_KDuration #pr_SimpleTypeAlt12
    |  E_Qualifier=pr_Qualifier #pr_SimpleTypeAlt13
    ;
pr_Name
    :  E_Identifier=pr_Identifier
    ;
pr_Qualifier
    :   E_Identifier1=pr_Identifier(E_TDot1+=LR_TDot E_Identifier2+=pr_Identifier)*
    ;
pr_Identifier
    :  E_Token=(LR_TIdentifier | LR_TVerbatimIdentifier)
    ;
pr_MainBlock1
    :  E_DeclarationList+=pr_Declaration*
    ;
pr_EnumTypeBlock1
    :   E_literals1=pr_EnumLiteral(E_TComma1+=LR_TComma E_literals2+=pr_EnumLiteral)*
    ;
pr_EnumTypeBlock1literalsBlock
    :  E_TComma1=LR_TComma  E_literals2=pr_EnumLiteral
    ;
pr_StructTypeBlock1
    :  E_TColon=LR_TColon  E_baseType=pr_Qualifier
    ;
pr_ResourceBlock1
    :  E_KThrows=LR_KThrows   E_exceptions1=pr_Qualifier(E_TComma1+=LR_TComma E_exceptions2+=pr_Qualifier)*
    ;
pr_ResourceBlock1exceptionsBlock
    :  E_TComma1=LR_TComma  E_exceptions2=pr_Qualifier
    ;
pr_OperationBlock1
    :  E_KThrows=LR_KThrows   E_exceptions1=pr_Qualifier(E_TComma1+=LR_TComma E_exceptions2+=pr_Qualifier)*
    ;
pr_OperationBlock1exceptionsBlock
    :  E_TComma1=LR_TComma  E_exceptions2=pr_Qualifier
    ;
pr_InputParameterListBlock1
    :   E_parameters1=pr_Parameter(E_TComma1+=LR_TComma E_parameters2+=pr_Parameter)*
    ;
pr_InputParameterListBlock1parametersBlock
    :  E_TComma1=LR_TComma  E_parameters2=pr_Parameter
    ;
pr_OutputParameterListAlt3parametersBlock
    :  E_TComma1=LR_TComma  E_parameters2=pr_Parameter
    ;
pr_TypeReferenceBlock1
    :  E_TLBracket=LR_TLBracket  E_TRBracket=LR_TRBracket
    ;
pr_QualifierIdentifierBlock
    :  E_TDot1=LR_TDot  E_Identifier2=pr_Identifier
    ;
