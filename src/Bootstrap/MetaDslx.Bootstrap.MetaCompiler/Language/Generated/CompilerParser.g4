parser grammar CompilerParser;

options
{
    tokenVocab = CompilerLexer; 
} 

pr_Main
    : e_KNamespace=LR_KNamespace e_Identifiers1=pr_Identifier(e_TDot1+=LR_TDot e_Identifiers2+=pr_Identifier)* e_TSemicolon=LR_TSemicolon e_UsingList+=pr_Using* e_Block=pr_MainBlock1 e_EndOfFileToken=EOF
    ;
pr_Using
    : e_KUsing=LR_KUsing e_Identifiers1=pr_Identifier(e_TDot1+=LR_TDot e_Identifiers2+=pr_Identifier)* e_TSemicolon=LR_TSemicolon
    ;
pr_LanguageDeclaration
    : e_KLanguage=LR_KLanguage e_Name=pr_Name e_TSemicolon=LR_TSemicolon e_Grammar=pr_Grammar
    ;
pr_Grammar
    : e_GrammarRules+=pr_GrammarRule*
    ;
pr_GrammarRule
    : e_Annotations+=pr_ParserAnnotation* e_Block=pr_RuleBlock1 e_TColon=LR_TColon e_Alternatives1=pr_Alternative(e_TBar1+=LR_TBar e_Alternatives2+=pr_Alternative)* e_TSemicolon=LR_TSemicolon #pr_Rule
    | e_Annotations1+=pr_LexerAnnotation* e_Block1=pr_TokenBlock1 e_TColon1=LR_TColon e_Alternatives3=pr_LAlternative(e_TBar2+=LR_TBar e_Alternatives4+=pr_LAlternative)* e_TSemicolon1=LR_TSemicolon #pr_Token
    | e_KFragment=LR_KFragment e_Name=pr_Name e_TColon2=LR_TColon e_Alternatives5=pr_LAlternative(e_TBar3+=LR_TBar e_Alternatives6+=pr_LAlternative)* e_TSemicolon2=LR_TSemicolon #pr_Fragment
    ;
pr_Alternative
    : e_Block=pr_AlternativeBlock1? e_Elements+=pr_Element+ e_Block1=pr_AlternativeBlock2?
    ;
pr_Element
    : e_Block=pr_ElementBlock1? e_Value=pr_ElementValue e_Multiplicity=(LR_TQuestion | LR_TAsterisk | LR_TPlus | LR_TQuestionQuestion | LR_TAsteriskQuestion | LR_TPlusQuestion)?
    ;
pr_ElementValue
    : e_Annotations+=pr_ParserAnnotation* e_TLParen=LR_TLParen e_Alternatives1=pr_BlockAlternative(e_TBar1+=LR_TBar e_Alternatives2+=pr_BlockAlternative)* e_TRParen=LR_TRParen #pr_Block
    | e_KEof=LR_KEof #pr_Eof1
    | e_Annotations1+=pr_ParserAnnotation* e_Text=LR_TString #pr_Fixed
    | e_Annotations2+=pr_ParserAnnotation* e_GrammarRule=pr_Identifier #pr_RuleRefAlt1
    | e_Annotations3+=pr_ParserAnnotation* e_THash=LR_THash e_ReferencedTypes=pr_TypeReference #pr_RuleRefAlt2
    | e_Annotations4+=pr_ParserAnnotation* e_THashLBrace=LR_THashLBrace e_ReferencedTypes1=pr_TypeReference(e_TComma1+=LR_TComma e_ReferencedTypes2+=pr_TypeReference)* e_Block=pr_RuleRefAlt3Block1? e_TRBrace=LR_TRBrace #pr_RuleRefAlt3
    ;
pr_BlockAlternative
    : e_Elements+=pr_Element+ e_Block=pr_BlockAlternativeBlock1?
    ;
pr_LAlternative
    : e_Elements+=pr_LElement*
    ;
pr_LElement
    : e_IsNegated=LR_TTilde? e_Value=pr_LElementValue e_Multiplicity=(LR_TQuestion | LR_TAsterisk | LR_TPlus | LR_TQuestionQuestion | LR_TAsteriskQuestion | LR_TPlusQuestion)?
    ;
pr_LElementValue
    : e_Token=(LR_TString | LR_TDot) #pr_LElementValueTokens
    | e_TLParen=LR_TLParen e_Alternatives1=pr_LAlternative(e_TBar1+=LR_TBar e_Alternatives2+=pr_LAlternative)* e_TRParen=LR_TRParen #pr_LBlock
    | e_StartChar=LR_TString e_TDotDot=LR_TDotDot e_EndChar=LR_TString #pr_LRange
    | e_Rule=pr_Identifier #pr_LReference
    ;
pr_Expression
    : e_SingleExpression=pr_SingleExpression #pr_ExpressionAlt1
    | e_TLBrace=LR_TLBrace e_Items1=pr_SingleExpression(e_TComma1+=LR_TComma e_Items2+=pr_SingleExpression)* e_TRBrace=LR_TRBrace #pr_ArrayExpression
    ;
pr_SingleExpression
    : e_Value=pr_SingleExpressionBlock1
    ;
pr_ParserAnnotation
    : e_TLBracket=LR_TLBracket e_Identifiers1=pr_Identifier(e_TDot1+=LR_TDot e_Identifiers2+=pr_Identifier)* e_TLParen=LR_TLParen e_Arguments1=pr_AnnotationArgument(e_TComma1+=LR_TComma e_Arguments2+=pr_AnnotationArgument)* e_TRParen=LR_TRParen? e_TRBracket=LR_TRBracket
    ;
pr_LexerAnnotation
    : e_TLBracket=LR_TLBracket e_Identifiers1=pr_Identifier(e_TDot1+=LR_TDot e_Identifiers2+=pr_Identifier)* e_TLParen=LR_TLParen e_Arguments1=pr_AnnotationArgument(e_TComma1+=LR_TComma e_Arguments2+=pr_AnnotationArgument)* e_TRParen=LR_TRParen? e_TRBracket=LR_TRBracket
    ;
pr_AnnotationArgument
    : e_Block=pr_AnnotationArgumentBlock1? e_Value=pr_Expression
    ;
pr_TypeReferenceIdentifier
    : e_Tokens=(LR_KBool | LR_KInt | LR_KString | LR_KType | LR_KSymbol | LR_KObject | LR_KVoid) #pr_TypeReferenceIdentifierAlt1
    | e_Identifier=pr_Identifier #pr_TypeReferenceIdentifierAlt2
    ;
pr_TypeReference
    : e_Tokens=(LR_KBool | LR_KInt | LR_KString | LR_KType | LR_KSymbol | LR_KObject | LR_KVoid) #pr_TypeReferenceAlt1
    | e_Identifiers1=pr_Identifier(e_TDot1+=LR_TDot e_Identifiers2+=pr_Identifier)* #pr_TypeReferenceAlt2
    ;
pr_Name
    : e_Identifier=pr_Identifier
    ;
pr_Identifier
    : e_Token=(LR_TIdentifier | LR_TVerbatimIdentifier)
    ;
pr_MainBlock1
    : e_Declarations=pr_LanguageDeclaration
    ;
pr_RuleBlock1
    : e_ReturnType=pr_TypeReferenceIdentifier #pr_RuleBlock1Alt1
    | e_Identifier=pr_Identifier e_KReturns=LR_KReturns e_ReturnType1=pr_TypeReference #pr_RuleBlock1Alt2
    ;
pr_RuleAlternativesBlock
    : e_TBar1=LR_TBar e_Alternatives2=pr_Alternative
    ;
pr_AlternativeBlock1
    : e_Annotations+=pr_ParserAnnotation* e_KAlt=LR_KAlt e_Name=pr_Name e_Block=pr_AlternativeBlock1Block1? e_TColon=LR_TColon
    ;
pr_AlternativeBlock2
    : e_TEqGt=LR_TEqGt e_ReturnValue=pr_Expression
    ;
pr_ElementBlock1
    : e_Annotations+=pr_ParserAnnotation* e_Name=pr_Name e_Assignment=(LR_TEq | LR_TQuestionEq | LR_TExclEq | LR_TPlusEq)
    ;
pr_BlockAlternativesBlock
    : e_TBar1=LR_TBar e_Alternatives2=pr_BlockAlternative
    ;
pr_BlockAlternativeBlock1
    : e_TEqGt=LR_TEqGt e_ReturnValue=pr_Expression
    ;
pr_RuleRefAlt3ReferencedTypesBlock
    : e_TComma1=LR_TComma e_ReferencedTypes2=pr_TypeReference
    ;
pr_RuleRefAlt3Block1
    : e_TBar=LR_TBar e_GrammarRule=pr_Identifier
    ;
pr_TokenBlock1
    : e_KToken=LR_KToken e_Name=pr_Name e_Block=pr_TokenBlock1Alt1Block1? #pr_TokenBlock1Alt1
    | e_IsTrivia=LR_KHidden e_Name1=pr_Name #pr_TokenBlock1Alt2
    ;
pr_TokenAlternativesBlock
    : e_TBar2=LR_TBar e_Alternatives4=pr_LAlternative
    ;
pr_FragmentAlternativesBlock
    : e_TBar3=LR_TBar e_Alternatives6=pr_LAlternative
    ;
pr_LBlockAlternativesBlock
    : e_TBar1=LR_TBar e_Alternatives2=pr_LAlternative
    ;
pr_SingleExpressionBlock1
    : e_Token=(LR_KNull | LR_KTrue | LR_KFalse | LR_TString | LR_TInteger | LR_TDecimal) #pr_Tokens
    | e_Tokens=(LR_KBool | LR_KInt | LR_KString | LR_KType | LR_KSymbol | LR_KObject | LR_KVoid) #pr_SingleExpressionBlock1Alt2
    | e_Identifiers1=pr_Identifier(e_TDot1+=LR_TDot e_Identifiers2+=pr_Identifier)* #pr_SingleExpressionBlock1Alt3
    ;
pr_ParserAnnotationArgumentsBlock
    : e_TComma1=LR_TComma e_Arguments2=pr_AnnotationArgument
    ;
pr_LexerAnnotationArgumentsBlock
    : e_TComma1=LR_TComma e_Arguments2=pr_AnnotationArgument
    ;
pr_AnnotationArgumentBlock1
    : e_NamedParameter=pr_Identifier e_TColon=LR_TColon
    ;
pr_MainQualifierBlock6
    : e_TDot1=LR_TDot e_Identifiers2=pr_Identifier
    ;
pr_AlternativeBlock1Block1
    : e_KReturns=LR_KReturns e_ReturnType=pr_TypeReference
    ;
pr_TokenBlock1Alt1Block1
    : e_KReturns=LR_KReturns e_ReturnType=pr_TypeReference
    ;
pr_ArrayExpressionItemsBlock
    : e_TComma1=LR_TComma e_Items2=pr_SingleExpression
    ;