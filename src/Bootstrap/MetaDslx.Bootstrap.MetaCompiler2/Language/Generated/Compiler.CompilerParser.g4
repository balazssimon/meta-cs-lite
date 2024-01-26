parser grammar CompilerParser;

options
{
    tokenVocab = CompilerLexer; 
} 

pr_Main
    :  e_KNamespace=LR_KNamespace  e_Qualifier=pr_Qualifier  e_TSemicolon=LR_TSemicolon  e_UsingList+=pr_Using*  e_Block=pr_MainBlock1  e_EndOfFileToken=EOF
    ;
pr_Using
    :  e_KUsing=LR_KUsing  e_namespaces=pr_Qualifier  e_TSemicolon=LR_TSemicolon
    ;
pr_LanguageDeclaration
    :  e_KLanguage=LR_KLanguage  e_Name=pr_Name  e_TSemicolon=LR_TSemicolon  e_grammar=pr_Grammar
    ;
pr_Grammar
    :  e_Block=pr_GrammarBlock1
    ;
pr_GrammarRule
    :  e_Rule=pr_Rule #pr_GrammarRuleAlt1
    |  e_LexerRule=pr_LexerRule #pr_GrammarRuleAlt2
    ;
pr_Rule
    :  e_annotations+=pr_ParserAnnotation*  e_Block=pr_RuleBlock1  e_TColon=LR_TColon   e_alternatives1=pr_Alternative(e_TBar1+=LR_TBar e_alternatives2+=pr_Alternative)*  e_TSemicolon=LR_TSemicolon
    ;
pr_Alternative
    :  e_Block=pr_AlternativeBlock1?  e_elements+=pr_Element+  e_Block1=pr_AlternativeBlock2?
    ;
pr_Element
    :  e_Block=pr_ElementBlock1?  e_value=pr_ElementValue
    ;
pr_ElementValue
    :  e_Block=pr_Block #pr_ElementValueAlt1
    |  e_Eof1=pr_Eof1 #pr_ElementValueAlt2
    |  e_Fixed=pr_Fixed #pr_ElementValueAlt3
    |  e_RuleRef=pr_RuleRef #pr_ElementValueAlt4
    ;
pr_Block
    :  e_annotations+=pr_ParserAnnotation*  e_TLParen=LR_TLParen   e_alternatives1=pr_BlockAlternative(e_TBar1+=LR_TBar e_alternatives2+=pr_BlockAlternative)*  e_TRParen=LR_TRParen  e_multiplicity=pr_Multiplicity?
    ;
pr_BlockAlternative
    :  e_elements+=pr_Element+  e_Block=pr_BlockAlternativeBlock1?
    ;
pr_RuleRef
    :  e_annotations+=pr_ParserAnnotation*  e_grammarRule=pr_Identifier  e_multiplicity=pr_Multiplicity? #pr_RuleRefAlt1
    |  e_annotations1+=pr_ParserAnnotation*  e_THash=LR_THash  e_referencedTypes=pr_TypeReference  e_multiplicity1=pr_Multiplicity? #pr_RuleRefAlt2
    |  e_annotations2+=pr_ParserAnnotation*  e_THashLBrace=LR_THashLBrace   e_referencedTypes1=pr_TypeReference(e_TComma1+=LR_TComma e_referencedTypes2+=pr_TypeReference)*  e_Block=pr_RuleRefAlt3Block1?  e_TRBrace=LR_TRBrace  e_multiplicity2=pr_Multiplicity? #pr_RuleRefAlt3
    ;
pr_Eof1
    :  e_KEof=LR_KEof
    ;
pr_Fixed
    :  e_annotations+=pr_ParserAnnotation*  e_text=LR_TString  e_multiplicity=pr_Multiplicity?
    ;
pr_LexerRule
    :  e_Token=pr_Token #pr_LexerRuleAlt1
    |  e_Fragment=pr_Fragment #pr_LexerRuleAlt2
    ;
pr_Token
    :  e_annotations+=pr_LexerAnnotation*  e_Block=pr_TokenBlock1  e_TColon=LR_TColon   e_alternatives1=pr_LAlternative(e_TBar1+=LR_TBar e_alternatives2+=pr_LAlternative)*  e_TSemicolon=LR_TSemicolon
    ;
pr_Fragment
    :  e_KFragment=LR_KFragment  e_Name=pr_Name  e_TColon=LR_TColon   e_alternatives1=pr_LAlternative(e_TBar1+=LR_TBar e_alternatives2+=pr_LAlternative)*  e_TSemicolon=LR_TSemicolon
    ;
pr_LAlternative
    :  e_elements+=pr_LElement*
    ;
pr_LElement
    :  e_isNegated=LR_TTilde  e_value=pr_LElementValue  e_multiplicity=pr_Multiplicity?
    ;
pr_LElementValue
    :  e_LBlock=pr_LBlock #pr_LElementValueAlt1
    |  e_LFixed=pr_LFixed #pr_LElementValueAlt2
    |  e_LWildCard=pr_LWildCard #pr_LElementValueAlt3
    |  e_LRange=pr_LRange #pr_LElementValueAlt4
    |  e_LReference=pr_LReference #pr_LElementValueAlt5
    ;
pr_LReference
    :  e_rule=pr_Identifier
    ;
pr_LFixed
    :  e_text=LR_TString
    ;
pr_LWildCard
    :  e_TDot=LR_TDot
    ;
pr_LRange
    :  e_startChar=LR_TString  e_TDotDot=LR_TDotDot  e_endChar=LR_TString
    ;
pr_LBlock
    :  e_TLParen=LR_TLParen   e_alternatives1=pr_LAlternative(e_TBar1+=LR_TBar e_alternatives2+=pr_LAlternative)*  e_TRParen=LR_TRParen
    ;
pr_Expression
    :  e_SingleExpression=pr_SingleExpression #pr_ExpressionAlt1
    |  e_ArrayExpression=pr_ArrayExpression #pr_ExpressionAlt2
    ;
pr_SingleExpression
    :  e_value=pr_SingleExpressionAlt1Block1 #pr_SingleExpressionAlt1
    |  e_value1=pr_Qualifier #pr_SingleExpressionAlt2
    ;
pr_ArrayExpression
    :  e_TLBrace=LR_TLBrace  e_Block=pr_ArrayExpressionBlock1?  e_TRBrace=LR_TRBrace
    ;
pr_ParserAnnotation
    :  e_TLBracket=LR_TLBracket  e_attributeClass=pr_Qualifier  e_Block=pr_ParserAnnotationBlock1?  e_TRBracket=LR_TRBracket
    ;
pr_LexerAnnotation
    :  e_TLBracket=LR_TLBracket  e_attributeClass=pr_Qualifier  e_Block=pr_LexerAnnotationBlock1?  e_TRBracket=LR_TRBracket
    ;
pr_AnnotationArgument
    :  e_Block=pr_AnnotationArgumentBlock1?  e_value=pr_Expression
    ;
pr_Assignment
    :  e_Token=(LR_TEq | LR_TQuestionEq | LR_TExclEq | LR_TPlusEq)
    ;
pr_Multiplicity
    :  e_Token=(LR_TQuestion | LR_TAsterisk | LR_TPlus | LR_TQuestionQuestion | LR_TAsteriskQuestion | LR_TPlusQuestion)
    ;
pr_TypeReferenceIdentifier
    :  e_PrimitiveType=pr_PrimitiveType #pr_TypeReferenceIdentifierAlt1
    |  e_Identifier=pr_Identifier #pr_TypeReferenceIdentifierAlt2
    ;
pr_TypeReference
    :  e_PrimitiveType=pr_PrimitiveType #pr_TypeReferenceAlt1
    |  e_Qualifier=pr_Qualifier #pr_TypeReferenceAlt2
    ;
pr_PrimitiveType
    :  e_Token=(LR_KBool | LR_KInt | LR_KDouble | LR_KString | LR_KType | LR_KSymbol | LR_KObject | LR_KVoid)
    ;
pr_Name
    :  e_Identifier=pr_Identifier
    ;
pr_Qualifier
    :   e_Identifier1=pr_Identifier(e_TDot1+=LR_TDot e_Identifier2+=pr_Identifier)*
    ;
pr_Identifier
    :  e_Token=(LR_TIdentifier | LR_TVerbatimIdentifier)
    ;
pr_MainBlock1
    :  e_declarations=pr_LanguageDeclaration
    ;
pr_GrammarBlock1
    :  e_grammarRules+=pr_GrammarRule*
    ;
pr_RuleBlock1
    :  e_returnType=pr_TypeReferenceIdentifier #pr_RuleBlock1Alt1
    |  e_Identifier=pr_Identifier  e_KReturns=LR_KReturns  e_returnType1=pr_TypeReference #pr_RuleBlock1Alt2
    ;
pr_RulealternativesBlock
    :  e_TBar1=LR_TBar  e_alternatives2=pr_Alternative
    ;
pr_AlternativeBlock1
    :  e_annotations+=pr_ParserAnnotation*  e_KAlt=LR_KAlt  e_Name=pr_Name  e_Block=pr_AlternativeBlock1Block1?  e_TColon=LR_TColon
    ;
pr_AlternativeBlock1Block1
    :  e_KReturns=LR_KReturns  e_returnType=pr_TypeReference
    ;
pr_AlternativeBlock2
    :  e_TEqGt=LR_TEqGt  e_returnValue=pr_Expression
    ;
pr_ElementBlock1
    :  e_annotations+=pr_ParserAnnotation*  e_Name=pr_Name  e_assignment=pr_Assignment
    ;
pr_BlockalternativesBlock
    :  e_TBar1=LR_TBar  e_alternatives2=pr_BlockAlternative
    ;
pr_BlockAlternativeBlock1
    :  e_TEqGt=LR_TEqGt  e_returnValue=pr_Expression
    ;
pr_RuleRefAlt3referencedTypesBlock
    :  e_TComma1=LR_TComma  e_referencedTypes2=pr_TypeReference
    ;
pr_RuleRefAlt3Block1
    :  e_TBar=LR_TBar  e_grammarRule=pr_Identifier
    ;
pr_TokenBlock1
    :  e_KToken=LR_KToken  e_Name=pr_Name  e_Block=pr_TokenBlock1Alt1Block1? #pr_TokenBlock1Alt1
    |  e_isTrivia=LR_KHidden  e_Name1=pr_Name #pr_TokenBlock1Alt2
    ;
pr_TokenBlock1Alt1Block1
    :  e_KReturns=LR_KReturns  e_returnType=pr_TypeReference
    ;
pr_TokenalternativesBlock
    :  e_TBar1=LR_TBar  e_alternatives2=pr_LAlternative
    ;
pr_FragmentalternativesBlock
    :  e_TBar1=LR_TBar  e_alternatives2=pr_LAlternative
    ;
pr_LBlockalternativesBlock
    :  e_TBar1=LR_TBar  e_alternatives2=pr_LAlternative
    ;
pr_SingleExpressionAlt1Block1
    :  e_KNull=LR_KNull #pr_SingleExpressionAlt1Block1Alt1
    |  e_KTrue=LR_KTrue #pr_SingleExpressionAlt1Block1Alt2
    |  e_KFalse=LR_KFalse #pr_SingleExpressionAlt1Block1Alt3
    |  e_TString=LR_TString #pr_SingleExpressionAlt1Block1Alt4
    |  e_TInteger=LR_TInteger #pr_SingleExpressionAlt1Block1Alt5
    |  e_TDecimal=LR_TDecimal #pr_SingleExpressionAlt1Block1Alt6
    |  e_PrimitiveType=pr_PrimitiveType #pr_SingleExpressionAlt1Block1Alt7
    ;
pr_ArrayExpressionBlock1
    :   e_items1=pr_SingleExpression(e_TComma1+=LR_TComma e_items2+=pr_SingleExpression)*
    ;
pr_ArrayExpressionBlock1itemsBlock
    :  e_TComma1=LR_TComma  e_items2=pr_SingleExpression
    ;
pr_ParserAnnotationBlock1
    :  e_TLParen=LR_TLParen   e_arguments1=pr_AnnotationArgument(e_TComma1+=LR_TComma e_arguments2+=pr_AnnotationArgument)*  e_TRParen=LR_TRParen
    ;
pr_ParserAnnotationBlock1argumentsBlock
    :  e_TComma1=LR_TComma  e_arguments2=pr_AnnotationArgument
    ;
pr_LexerAnnotationBlock1
    :  e_TLParen=LR_TLParen   e_arguments1=pr_AnnotationArgument(e_TComma1+=LR_TComma e_arguments2+=pr_AnnotationArgument)*  e_TRParen=LR_TRParen
    ;
pr_LexerAnnotationBlock1argumentsBlock
    :  e_TComma1=LR_TComma  e_arguments2=pr_AnnotationArgument
    ;
pr_AnnotationArgumentBlock1
    :  e_namedParameter=pr_Identifier  e_TColon=LR_TColon
    ;
pr_QualifierIdentifierBlock
    :  e_TDot1=LR_TDot  e_Identifier2=pr_Identifier
    ;
