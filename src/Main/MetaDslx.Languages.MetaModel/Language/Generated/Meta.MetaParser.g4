parser grammar MetaParser;

options
{
    tokenVocab = MetaLexer; 
} 

pr_Main
    :  E_KNamespace=LR_KNamespace  E_Qualifier=pr_Qualifier  E_TSemicolon=LR_TSemicolon  E_UsingList+=pr_Using*  E_Block=pr_MainBlock1  E_EndOfFileToken=EOF
    ;
pr_Using
    :  E_KUsing=LR_KUsing  E_namespaces=pr_Qualifier  E_TSemicolon=LR_TSemicolon
    ;
pr_MetaModel
    :  E_KMetamodel=LR_KMetamodel  E_Name=pr_Name  E_Block=pr_MetaModelBlock1?  E_TSemicolon=LR_TSemicolon
    ;
pr_MetaDeclaration
    :  E_MetaConstant=pr_MetaConstant #pr_MetaDeclarationAlt1
    |  E_MetaEnum=pr_MetaEnum #pr_MetaDeclarationAlt2
    |  E_MetaClass=pr_MetaClass #pr_MetaDeclarationAlt3
    ;
pr_MetaConstant
    :  E_KConst=LR_KConst  E_type=pr_MetaTypeReference  E_Name=pr_Name  E_TSemicolon=LR_TSemicolon
    ;
pr_MetaEnum
    :  E_KEnum=LR_KEnum  E_Name=pr_Name  E_Block=pr_MetaEnumBlock1
    ;
pr_MetaEnumLiteral
    :  E_Name=pr_Name
    ;
pr_MetaClass
    :  E_isAbstract=LR_KAbstract?  E_KClass=LR_KClass  E_Block=pr_MetaClassBlock1  E_Block1=pr_MetaClassBlock2?  E_Block2=pr_MetaClassBlock3
    ;
pr_MetaProperty
    :  E_Block=pr_MetaPropertyBlock1?  E_type=pr_MetaTypeReference  E_Block1=pr_MetaPropertyBlock2  E_Block2=pr_MetaPropertyBlock3?  E_Block3+=pr_MetaPropertyBlock4*  E_TSemicolon=LR_TSemicolon
    ;
pr_MetaOperation
    :  E_returnType=pr_MetaTypeReference  E_Name=pr_Name  E_TLParen=LR_TLParen  E_Block=pr_MetaOperationBlock1?  E_TRParen=LR_TRParen  E_TSemicolon=LR_TSemicolon
    ;
pr_MetaParameter
    :  E_type=pr_MetaTypeReference  E_Name=pr_Name
    ;
pr_MetaTypeReference
    :  E_TypeReference=pr_TypeReference #pr_SimpleTypeReference
    |  E_itemType=pr_MetaTypeReference  E_TLBracket=LR_TLBracket  E_TRBracket=LR_TRBracket #pr_MetaArrayType
    |  E_innerType=pr_MetaTypeReference  E_TQuestion=LR_TQuestion #pr_MetaNullableType
    ;
pr_TypeReference
    :  E_PrimitiveType=pr_PrimitiveType #pr_TypeReferenceAlt1
    |  E_Qualifier=pr_Qualifier #pr_TypeReferenceAlt2
    ;
pr_PrimitiveType
    :  E_Token=(LR_KObject | LR_KBool | LR_KChar | LR_KString | LR_KByte | LR_KSbyte | LR_KShort | LR_KUshort | LR_KInt | LR_KUint | LR_KLong | LR_KUlong | LR_KFloat | LR_KDouble | LR_KDecimal | LR_KType | LR_KSymbol | LR_KVoid)
    ;
pr_Value
    :  E_TString=LR_TString #pr_ValueAlt1
    |  E_TInteger=LR_TInteger #pr_ValueAlt2
    |  E_TDecimal=LR_TDecimal #pr_ValueAlt3
    |  E_TBoolean=pr_TBoolean #pr_ValueAlt4
    |  E_KNull=LR_KNull #pr_ValueAlt5
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
pr_TBoolean
    :  E_Token=(LR_KTrue | LR_KFalse)
    ;
pr_MainBlock1
    :  E_declarations=pr_MetaModel  E_declarations1+=pr_MetaDeclaration*
    ;
pr_MetaModelBlock1
    :  E_TEq=LR_TEq  E_uri=LR_TString
    ;
pr_MetaEnumBlock1
    :  E_TLBrace=LR_TLBrace   E_literals1=pr_MetaEnumLiteral(E_TComma1+=LR_TComma E_literals2+=pr_MetaEnumLiteral)*  E_TRBrace=LR_TRBrace
    ;
pr_MetaEnumBlock1literalsBlock
    :  E_TComma1=LR_TComma  E_literals2=pr_MetaEnumLiteral
    ;
pr_MetaClassBlock1
    :  E_Identifier=pr_Identifier?  E_TDollar=LR_TDollar  E_symbolType=pr_Identifier #pr_MetaClassBlock1Alt1
    |  E_Identifier1=pr_Identifier #pr_MetaClassBlock1Alt2
    ;
pr_MetaClassBlock2
    :  E_TColon=LR_TColon   E_baseTypes1=pr_Qualifier(E_TComma1+=LR_TComma E_baseTypes2+=pr_Qualifier)*
    ;
pr_MetaClassBlock2baseTypesBlock
    :  E_TComma1=LR_TComma  E_baseTypes2=pr_Qualifier
    ;
pr_MetaClassBlock3
    :  E_TLBrace=LR_TLBrace  E_Block+=pr_MetaClassBlock3Block1*  E_TRBrace=LR_TRBrace
    ;
pr_MetaClassBlock3Block1
    :  E_properties=pr_MetaProperty #pr_MetaClassBlock3Block1Alt1
    |  E_operations=pr_MetaOperation #pr_MetaClassBlock3Block1Alt2
    ;
pr_MetaPropertyBlock1
    :  E_isContainment=LR_KContains #pr_MetaPropertyBlock1Alt1
    |  E_isDerived=LR_KDerived #pr_MetaPropertyBlock1Alt2
    |  E_isUnion=LR_KUnion #pr_MetaPropertyBlock1Alt3
    |  E_isReadOnly=LR_KReadonly #pr_MetaPropertyBlock1Alt4
    ;
pr_MetaPropertyBlock2
    :  E_Identifier=pr_Identifier?  E_TDollar=LR_TDollar  E_symbolProperty=pr_Identifier #pr_MetaPropertyBlock2Alt1
    |  E_Identifier1=pr_Identifier #pr_MetaPropertyBlock2Alt2
    ;
pr_MetaPropertyBlock3
    :  E_TEq=LR_TEq  E_defaultValue=pr_Value
    ;
pr_MetaPropertyBlock4
    :  E_KOpposite=LR_KOpposite   E_oppositeProperties1=pr_Qualifier(E_TComma1+=LR_TComma E_oppositeProperties2+=pr_Qualifier)* #pr_MetaPropertyBlock4Alt1
    |  E_KSubsets=LR_KSubsets   E_subsettedProperties1=pr_Qualifier(E_TComma2+=LR_TComma E_subsettedProperties2+=pr_Qualifier)* #pr_MetaPropertyBlock4Alt2
    |  E_KRedefines=LR_KRedefines   E_redefinedProperties1=pr_Qualifier(E_TComma3+=LR_TComma E_redefinedProperties2+=pr_Qualifier)* #pr_MetaPropertyBlock4Alt3
    ;
pr_MetaPropertyBlock4Alt1oppositePropertiesBlock
    :  E_TComma1=LR_TComma  E_oppositeProperties2=pr_Qualifier
    ;
pr_MetaPropertyBlock4Alt2subsettedPropertiesBlock
    :  E_TComma2=LR_TComma  E_subsettedProperties2=pr_Qualifier
    ;
pr_MetaPropertyBlock4Alt3redefinedPropertiesBlock
    :  E_TComma3=LR_TComma  E_redefinedProperties2=pr_Qualifier
    ;
pr_MetaOperationBlock1
    :   E_parameters1=pr_MetaParameter(E_TComma1+=LR_TComma E_parameters2+=pr_MetaParameter)*
    ;
pr_MetaOperationBlock1parametersBlock
    :  E_TComma1=LR_TComma  E_parameters2=pr_MetaParameter
    ;
pr_QualifierIdentifierBlock
    :  E_TDot1=LR_TDot  E_Identifier2=pr_Identifier
    ;
