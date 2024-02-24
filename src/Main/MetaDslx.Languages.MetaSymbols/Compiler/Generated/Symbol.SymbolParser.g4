parser grammar SymbolParser;

options
{
    tokenVocab = SymbolLexer; 
} 

pr_Main
    :  E_KNamespace=LR_KNamespace  E_Qualifier=pr_Qualifier  E_UsingList+=pr_Using*  E_Block=pr_MainBlock1  E_EndOfFileToken=EOF
    ;
pr_Using
    :  E_KUsing=LR_KUsing  E_namespaces=pr_Qualifier
    ;
pr_Symbol
    :  E_isAbstract=LR_KAbstract?  E_KSymbol=LR_KSymbol  E_Name=pr_Name  E_Block=pr_SymbolBlock1?  E_Block1=pr_SymbolBlock2
    ;
pr_Property
    :  E_Block=pr_PropertyBlock1?  E_type=pr_TypeReference  E_Name=pr_Name  E_Block1=pr_PropertyBlock2?  E_Block2=pr_PropertyBlock3?
    ;
pr_Operation
    :  E_isPhase=LR_KPhase  E_Name=pr_Name  E_TLParen=LR_TLParen  E_TRParen=LR_TRParen #pr_OperationAlt1
    |  E_isCached=LR_KCached?  E_returnType=pr_TypeReference  E_Name1=pr_Name  E_TLParen1=LR_TLParen  E_Block=pr_OperationAlt2Block1?  E_TRParen1=LR_TRParen  E_Block1=pr_OperationAlt2Block2? #pr_OperationAlt2
    ;
pr_Parameter
    :  E_type=pr_TypeReference  E_Name=pr_Name
    ;
pr_TypeReference
    :  E_type=pr_SimpleTypeReference  E_Block=pr_TypeReferenceBlock1?  E_dimensions=pr_ArrayDimensions
    ;
pr_ArrayDimensions
    :  E_Block+=pr_ArrayDimensionsBlock1*
    ;
pr_SimpleTypeReference
    :  E_PrimitiveType=pr_PrimitiveType #pr_SimpleTypeReferenceAlt1
    |  E_Qualifier=pr_Qualifier #pr_SimpleTypeReferenceAlt2
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
    |  E_Qualifier=pr_Qualifier #pr_ValueAlt6
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
    :  E_declarations+=pr_Symbol*
    ;
pr_SymbolBlock1
    :  E_TColon=LR_TColon  E_baseTypes=pr_Qualifier
    ;
pr_SymbolBlock2
    :  E_TLBrace=LR_TLBrace  E_Block+=pr_SymbolBlock2Block1*  E_TRBrace=LR_TRBrace
    ;
pr_SymbolBlock2Block1
    :  E_properties=pr_Property #pr_SymbolBlock2Block1Alt1
    |  E_operations=pr_Operation #pr_SymbolBlock2Block1Alt2
    ;
pr_PropertyBlock1
    :  E_isPlain=LR_KPlain  E_Block=pr_PropertyBlock1Alt1Block1? #pr_PropertyBlock1Alt1
    |  E_isDerived=LR_KDerived  E_isCached=LR_KCached?  E_isWeak=LR_KWeak? #pr_PropertyBlock1Alt2
    |  E_isWeak1=LR_KWeak #pr_PropertyBlock1Alt3
    ;
pr_PropertyBlock1Alt1Block1
    :  E_isAbstract=LR_KAbstract #pr_PropertyBlock1Alt1Block1Alt1
    |  E_isWeak=LR_KWeak #pr_PropertyBlock1Alt1Block1Alt2
    ;
pr_PropertyBlock2
    :  E_TEq=LR_TEq  E_defaultValue=pr_Value
    ;
pr_PropertyBlock3
    :  E_KPhase=LR_KPhase  E_phase=pr_Identifier
    ;
pr_OperationAlt2Block1
    :   E_parameters1=pr_Parameter(E_TComma1+=LR_TComma E_parameters2+=pr_Parameter)*
    ;
pr_OperationAlt2Block1parametersBlock
    :  E_TComma1=LR_TComma  E_parameters2=pr_Parameter
    ;
pr_OperationAlt2Block2
    :  E_KIf=LR_KIf  E_cacheCondition=LR_TString
    ;
pr_TypeReferenceBlock1
    :  E_isNullable=LR_TQuestion
    ;
pr_ArrayDimensionsBlock1
    :  E_TLBracket=LR_TLBracket  E_TRBracket=LR_TRBracket
    ;
pr_QualifierIdentifierBlock
    :  E_TDot1=LR_TDot  E_Identifier2=pr_Identifier
    ;
