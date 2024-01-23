parser grammar CompilerParser;

options
{
    tokenVocab = CompilerLexer; 
} 

pr_Main
    :  kNamespace=LR_KNamespace  nameAntlr1=pr_Qualifier  tSemicolon=LR_TSemicolon  usingAntlr1+=pr_Using*  declarationsAntlr1=pr_Declarations  eof=EOF
    ;
pr_Using
    :  kUsing=LR_KUsing  namespacesAntlr1=pr_Qualifier  tSemicolon=LR_TSemicolon
    ;
pr_Declarations
    :  declarationsAntlr1=pr_LanguageDeclaration  declarations1Antlr1+=pr_Rule*
    ;
pr_LanguageDeclaration
    :  kLanguage=LR_KLanguage  nameAntlr1=pr_Name  tSemicolon=LR_TSemicolon  grammarAntlr1=pr_Grammar
    ;
pr_Grammar
    :  grammarBlock1Antlr1=pr_GrammarBlock1
    ;
pr_Rule
    :  parserRuleBlock1Antlr1=pr_ParserRuleBlock1  tColon=LR_TColon   alternativesAntlr1=pr_PAlternative parserRuleBlock2Antlr1+=pr_ParserRuleBlock2*  tSemicolon=LR_TSemicolon #pr_ParserRule
    |  annotations1Antlr1+=pr_LexerAnnotation*  lexerRuleBlock1Antlr1=pr_LexerRuleBlock1  tColon=LR_TColon   alternativesAntlr1=pr_LAlternative lexerRuleBlock2Antlr1+=pr_LexerRuleBlock2*  tSemicolon=LR_TSemicolon #pr_LexerRule
    ;
pr_PAlternative
    :  pAlternativeBlock1Antlr1=pr_PAlternativeBlock1?  elementsAntlr1+=pr_PElement*  pAlternativeBlock2Antlr1=pr_PAlternativeBlock2?
    ;
pr_PElement
    :  pElementBlock1Antlr1=pr_PElementBlock1?  valueAntlr1=pr_PElementValue  ( tQuestion=LR_TQuestion |  tAsterisk=LR_TAsterisk |  tPlus=LR_TPlus |  tQuestionQuestion=LR_TQuestionQuestion |  tAsteriskQuestion=LR_TAsteriskQuestion |  tPlusQuestion=LR_TPlusQuestion)?
    ;
pr_PElementValue
    :  tLParen=LR_TLParen   alternativesAntlr1=pr_PAlternative pBlockBlock1Antlr1+=pr_PBlockBlock1*  tRParen=LR_TRParen #pr_PBlock
    |  kEof=LR_KEof #pr_PEof
    |  textAntlr1=LR_TString #pr_PKeyword
    |  ruleAntlr1=pr_Identifier #pr_PReferenceAlt1
    |  tHash=LR_THash  referencedTypesAntlr1=pr_Qualifier #pr_PReferenceAlt2
    |  tHashLBrace=LR_THashLBrace   referencedTypesAntlr1=pr_Qualifier pReferenceAlt3Block1Antlr1+=pr_PReferenceAlt3Block1*  tRBrace=LR_TRBrace #pr_PReferenceAlt3
    ;
pr_LAlternative
    :  elementsAntlr1+=pr_LElement*
    ;
pr_LElement
    :  isNegated=LR_TTilde?  valueAntlr1=pr_LElementValue  ( tQuestion=LR_TQuestion |  tAsterisk=LR_TAsterisk |  tPlus=LR_TPlus |  tQuestionQuestion=LR_TQuestionQuestion |  tAsteriskQuestion=LR_TAsteriskQuestion |  tPlusQuestion=LR_TPlusQuestion)?
    ;
pr_LElementValue
    :  tLParen=LR_TLParen   alternativesAntlr1=pr_LAlternative lBlockBlock1Antlr1+=pr_LBlockBlock1*  tRParen=LR_TRParen #pr_LBlock
    |  textAntlr1=LR_TString #pr_LFixed
    |  tDot=LR_TDot #pr_LWildCard
    |  StartCharAntlr1=LR_TString  tDotDot=LR_TDotDot  EndCharAntlr1=LR_TString #pr_LRange
    |  ruleAntlr1=pr_Identifier #pr_LReference
    ;
pr_Expression
    :  intValueAntlr1=LR_TInteger #pr_IntExpression
    |  stringValueAntlr1=LR_TString #pr_StringExpression
    |  symbolValueAntlr1=pr_Qualifier #pr_ReferenceExpression
    |  ( kNull=LR_KNull |  boolValue=LR_KTrue |  kFalse=LR_KFalse) #pr_ExpressionTokens
    ;
pr_LexerAnnotation
    :  tLBracket=LR_TLBracket  typeAntlr1=pr_Qualifier  annotationArgumentsAntlr1=pr_AnnotationArguments?  tRBracket=LR_TRBracket
    ;
pr_AnnotationArguments
    :  tLParen=LR_TLParen   argumentsAntlr1=pr_AnnotationArgument annotationArgumentsBlock1Antlr1+=pr_AnnotationArgumentsBlock1*  tRParen=LR_TRParen
    ;
pr_AnnotationArgument
    :  annotationArgumentBlock1Antlr1=pr_AnnotationArgumentBlock1?  valueAntlr1=pr_Expression
    ;
pr_Name
    :  identifierAntlr1=pr_Identifier
    ;
pr_Qualifier
    :   identifierAntlr1=pr_Identifier qualifierBlock1Antlr1+=pr_QualifierBlock1*
    ;
pr_QualifierList
    :   qualifierAntlr1=pr_Qualifier qualifierListBlock1Antlr1+=pr_QualifierListBlock1*
    ;
pr_Identifier
    :  tIdentifierAntlr1=LR_TIdentifier
    ;
pr_GrammarBlock1
    :  rulesAntlr1+=pr_Rule*
    ;
pr_ParserRuleBlock1
    :  isBlock=LR_KBlock  nameAntlr1=pr_Name #pr_ParserRuleBlock1Alt1
    |  returnTypeAntlr1=pr_Identifier #pr_ParserRuleBlock1Alt2
    |  nameAntlr1=pr_Name  kReturns=LR_KReturns  returnTypeAntlr1=pr_Qualifier #pr_ParserRuleBlock1Alt3
    ;
pr_ParserRuleBlock2
    :  tBar=LR_TBar  alternativesAntlr1=pr_PAlternative
    ;
pr_PAlternativeBlock1
    :  tExclLBrace=LR_TExclLBrace  returnTypeAntlr1=pr_Qualifier  tRBrace=LR_TRBrace
    ;
pr_PAlternativeBlock2
    :  tEqGt=LR_TEqGt  returnValueAntlr1=pr_Expression
    ;
pr_PElementBlock1
    :  identifierAntlr1=pr_Identifier  ( tEq=LR_TEq |  tQuestionEq=LR_TQuestionEq |  tExclEq=LR_TExclEq |  tPlusEq=LR_TPlusEq)
    ;
pr_PReferenceAlt3Block1
    :  tComma=LR_TComma  referencedTypesAntlr1=pr_Qualifier
    ;
pr_PBlockBlock1
    :  tBar=LR_TBar  alternativesAntlr1=pr_PAlternative
    ;
pr_LexerRuleBlock1
    :  kToken=LR_KToken  nameAntlr1=pr_Name  lexerRuleBlock1Alt1Block1Antlr1=pr_LexerRuleBlock1Alt1Block1? #pr_LexerRuleBlock1Alt1
    |  isHidden=LR_KHidden  nameAntlr1=pr_Name #pr_LexerRuleBlock1Alt2
    |  isFragment=LR_KFragment  nameAntlr1=pr_Name #pr_LexerRuleBlock1Alt3
    ;
pr_LexerRuleBlock2
    :  tBar=LR_TBar  alternativesAntlr1=pr_LAlternative
    ;
pr_LBlockBlock1
    :  tBar=LR_TBar  alternativesAntlr1=pr_LAlternative
    ;
pr_AnnotationArgumentsBlock1
    :  tComma=LR_TComma  argumentsAntlr1=pr_AnnotationArgument
    ;
pr_AnnotationArgumentBlock1
    :  nameAntlr1=pr_Identifier  tColon=LR_TColon
    ;
pr_QualifierBlock1
    :  tDot=LR_TDot  identifierAntlr1=pr_Identifier
    ;
pr_QualifierListBlock1
    :  tComma=LR_TComma  qualifierAntlr1=pr_Qualifier
    ;
pr_LexerRuleBlock1Alt1Block1
    :  kReturns=LR_KReturns  returnTypeAntlr1=pr_Qualifier
    ;
