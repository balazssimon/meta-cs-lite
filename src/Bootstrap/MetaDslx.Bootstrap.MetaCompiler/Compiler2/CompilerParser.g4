parser grammar CompilerParser;

options
{
    tokenVocab = CompilerLexer; 
} 

pr_Main
    :  e_KNamespace=LR_KNamespace  e_Name=pr_Qualifier  e_TSemicolon=LR_TSemicolon  e_UsingList+=pr_Using*  e_Declarations=pr_Declarations  e_EndOfFileToken=EOF
    ;
pr_Using
    :  e_KUsing=LR_KUsing  e_Namespaces=pr_Qualifier  e_TSemicolon=LR_TSemicolon #pr_UsingAlt1
 |  e_KUsing1=LR_KUsing  e_KMetamodel=LR_KMetamodel  e_Symbols=pr_Qualifier  e_TSemicolon1=LR_TSemicolon #pr_UsingMetaModel
 |  e_KUsing2=LR_KUsing  e_KSymbols=LR_KSymbols  e_Namespaces1=pr_Qualifier  e_TSemicolon2=LR_TSemicolon #pr_UsingSymbols
    ;
pr_Declarations
    :  e_Declarations=pr_LanguageDeclaration  e_Declarations1+=pr_Rule*
    ;
pr_LanguageDeclaration
    :  e_KLanguage=LR_KLanguage  e_Name=pr_Name  e_TSemicolon=LR_TSemicolon  e_Grammar=pr_Grammar
    ;
pr_Grammar
    :  e_GrammarRules+=pr_GrammarRule*
    ;
pr_GrammarRule
    :  e_Rule=pr_Rule #pr_GrammarRuleAlt1
 |  e_Annotations+=pr_ParserAnnotation*  e_KBlock=LR_KBlock  e_Name=pr_Name  e_Block=pr_BlockBlock1?  e_TColon=LR_TColon         e_Alternatives1=pr_Alternative         (e_TBar1+=LR_TBar e_Alternatives2+=pr_Alternative)*              e_TSemicolon=LR_TSemicolon #pr_Block
 |  e_Annotations1+=pr_LexerAnnotation*  e_Block1=pr_TokenBlock1  e_TColon1=LR_TColon         e_Alternatives3=pr_LAlternative         (e_TBar2+=LR_TBar e_Alternatives4+=pr_LAlternative)*              e_TSemicolon1=LR_TSemicolon #pr_Token
 |  e_KFragment=LR_KFragment  e_Name1=pr_Name  e_TColon2=LR_TColon         e_Alternatives5=pr_LAlternative         (e_TBar3+=LR_TBar e_Alternatives6+=pr_LAlternative)*              e_TSemicolon2=LR_TSemicolon #pr_Fragment
    ;
pr_Rule
    :  e_Annotations+=pr_ParserAnnotation*  e_Block=pr_RuleBlock1  e_TColon=LR_TColon         e_Alternatives1=pr_Alternative         (e_TBar1+=LR_TBar e_Alternatives2+=pr_Alternative)*              e_TSemicolon=LR_TSemicolon
    ;
pr_Alternative
    :  e_Block=pr_AlternativeBlock1?  e_Elements+=pr_Element+  e_Block1=pr_AlternativeBlock2?
    ;
pr_Element
    :  e_Block=pr_ElementBlock1?  e_ValueAnnotations+=pr_ParserAnnotation*  e_Value=pr_ElementValue  e_Multiplicity=(LR_TQuestion | LR_TAsterisk | LR_TPlus | LR_TQuestionQuestion | LR_TAsteriskQuestion | LR_TPlusQuestion)?
    ;
pr_ElementValue
    :  e_Token=(LR_KEof | LR_TString) #pr_ElementValueTokens
 |  e_TLParen=LR_TLParen         e_Alternatives1=pr_Alternative         (e_TBar1+=LR_TBar e_Alternatives2+=pr_Alternative)*              e_TRParen=LR_TRParen #pr_BlockInline
 |  e_Rule=(LR_TIdentifier | LR_TVerbatimIdentifier) #pr_RuleRefAlt1
 |  e_THash=LR_THash  e_ReferencedTypes=pr_ReturnTypeQualifier #pr_RuleRefAlt2
 |  e_THashLBrace=LR_THashLBrace         e_ReferencedTypes1=pr_ReturnTypeQualifier         (e_TComma1+=LR_TComma e_ReferencedTypes2+=pr_ReturnTypeQualifier)*              e_TRBrace=LR_TRBrace #pr_RuleRefAlt3
    ;
pr_LAlternative
    :  e_Elements+=pr_LElement*
    ;
pr_LElement
    :  e_IsNegated=LR_TTilde?  e_Value=pr_LElementValue  e_Multiplicity=(LR_TQuestion | LR_TAsterisk | LR_TPlus | LR_TQuestionQuestion | LR_TAsteriskQuestion | LR_TPlusQuestion)?
    ;
pr_LElementValue
    :  e_Token=(LR_TString | LR_TDot) #pr_LElementValueTokens
 |  e_TLParen=LR_TLParen         e_Alternatives1=pr_LAlternative         (e_TBar1+=LR_TBar e_Alternatives2+=pr_LAlternative)*              e_TRParen=LR_TRParen #pr_LBlock
 |  e_StartChar=LR_TString  e_TDotDot=LR_TDotDot  e_EndChar=LR_TString #pr_LRange
 |  e_Rule=(LR_TIdentifier | LR_TVerbatimIdentifier) #pr_LReference
    ;
pr_Expression
    :  e_SingleExpression=pr_SingleExpression #pr_ExpressionAlt1
 |  e_TLBrace=LR_TLBrace         e_Items1=pr_SingleExpression         (e_TComma1+=LR_TComma e_Items2+=pr_SingleExpression)*              e_TRBrace=LR_TRBrace #pr_ArrayExpression
    ;
pr_SingleExpression
    :  e_Value=pr_SingleExpressionBlock1
    ;
pr_ParserAnnotation
    :  e_TLBracket=LR_TLBracket  e_AttributeClass=pr_Qualifier  e_AnnotationArguments=pr_AnnotationArguments?  e_TRBracket=LR_TRBracket
    ;
pr_LexerAnnotation
    :  e_TLBracket=LR_TLBracket  e_AttributeClass=pr_Qualifier  e_AnnotationArguments=pr_AnnotationArguments?  e_TRBracket=LR_TRBracket
    ;
pr_AnnotationArguments
    :  e_TLParen=LR_TLParen         e_Arguments1=pr_AnnotationArgument         (e_TComma1+=LR_TComma e_Arguments2+=pr_AnnotationArgument)*              e_TRParen=LR_TRParen
    ;
pr_AnnotationArgument
    :  e_Block=pr_AnnotationArgumentBlock1?  e_Value=pr_Expression
    ;
pr_ReturnTypeIdentifier
    :  e_TPrimitiveType=LR_TPrimitiveType #pr_ReturnTypeIdentifierAlt1
 |  e_Tokens=(LR_TIdentifier | LR_TVerbatimIdentifier) #pr_ReturnTypeIdentifierAlt2
    ;
pr_ReturnTypeQualifier
    :  e_TPrimitiveType=LR_TPrimitiveType #pr_ReturnTypeQualifierAlt1
 |  e_Qualifier=pr_Qualifier #pr_ReturnTypeQualifierAlt2
    ;
pr_Name
    :  e_Tokens=(LR_TIdentifier | LR_TVerbatimIdentifier)
    ;
pr_Qualifier
    :  e_Tokens=(LR_TIdentifier | LR_TVerbatimIdentifier)  e_Block+=pr_QualifierBlock1*
    ;
pr_SimpleIdentifier
    :  e_TIdentifier=LR_TIdentifier
    ;
pr_RuleBlock1
    :  e_ReturnType=pr_ReturnTypeIdentifier #pr_RuleBlock1Alt1
 |  e_Tokens=(LR_TIdentifier | LR_TVerbatimIdentifier)  e_KReturns=LR_KReturns  e_ReturnType1=pr_ReturnTypeQualifier #pr_RuleBlock1Alt2
    ;
pr_RuleAlternativesBlock
    :  e_TBar1=LR_TBar  e_Alternatives2=pr_Alternative
    ;
pr_BlockBlock1
    :  e_KReturns=LR_KReturns  e_ReturnType=pr_ReturnTypeQualifier
    ;
pr_BlockAlternativesBlock
    :  e_TBar1=LR_TBar  e_Alternatives2=pr_Alternative
    ;
pr_BlockInlineAlternativesBlock
    :  e_TBar1=LR_TBar  e_Alternatives2=pr_Alternative
    ;
pr_AlternativeBlock1
    :  e_Annotations+=pr_ParserAnnotation*  e_KAlt=LR_KAlt  e_Name=pr_Name  e_Block=pr_AlternativeBlock1Block1?  e_TColon=LR_TColon
    ;
pr_AlternativeBlock1Block1
    :  e_KReturns=LR_KReturns  e_ReturnType=pr_ReturnTypeQualifier
    ;
pr_AlternativeBlock2
    :  e_TEqGt=LR_TEqGt  e_ReturnValue=pr_Expression
    ;
pr_ElementBlock1
    :  e_NameAnnotations+=pr_ParserAnnotation*  e_SymbolProperty=(LR_TIdentifier | LR_TVerbatimIdentifier)  e_Assignment=(LR_TEq | LR_TQuestionEq | LR_TExclEq | LR_TPlusEq)
    ;
pr_RuleRefAlt3ReferencedTypesBlock
    :  e_TComma1=LR_TComma  e_ReferencedTypes2=pr_ReturnTypeQualifier
    ;
pr_TokenBlock1
    :  e_KToken=LR_KToken  e_Name=pr_Name  e_Block=pr_TokenBlock1Alt1Block1? #pr_TokenBlock1Alt1
 |  e_IsTrivia=LR_KHidden  e_Name1=pr_Name #pr_TokenBlock1Alt2
    ;
pr_TokenBlock1Alt1Block1
    :  e_KReturns=LR_KReturns  e_ReturnType=pr_ReturnTypeQualifier
    ;
pr_TokenAlternativesBlock
    :  e_TBar2=LR_TBar  e_Alternatives4=pr_LAlternative
    ;
pr_FragmentAlternativesBlock
    :  e_TBar3=LR_TBar  e_Alternatives6=pr_LAlternative
    ;
pr_LBlockAlternativesBlock
    :  e_TBar1=LR_TBar  e_Alternatives2=pr_LAlternative
    ;
pr_SingleExpressionBlock1
    :  e_Token=(LR_KNull | LR_KTrue | LR_KFalse | LR_TInteger | LR_TString) #pr_Tokens
 |  e_SimpleIdentifier=pr_SimpleIdentifier              (e_TDot1+=LR_TDot e_SimpleIdentifier1+=pr_SimpleIdentifier)*             #pr_SimpleQualifier
    ;
pr_ArrayExpressionItemsBlock
    :  e_TComma1=LR_TComma  e_Items2=pr_SingleExpression
    ;
pr_AnnotationArgumentsArgumentsBlock
    :  e_TComma1=LR_TComma  e_Arguments2=pr_AnnotationArgument
    ;
pr_AnnotationArgumentBlock1
    :  e_NamedParameter=(LR_TIdentifier | LR_TVerbatimIdentifier)  e_TColon=LR_TColon
    ;
pr_QualifierBlock1
    :  e_TDot=LR_TDot  e_Tokens=(LR_TIdentifier | LR_TVerbatimIdentifier)
    ;
pr_SimpleQualifierSimpleIdentifierBlock1
    :  e_TDot1=LR_TDot  e_SimpleIdentifier1=pr_SimpleIdentifier
    ;
