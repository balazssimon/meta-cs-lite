parser grammar CompilerParser;

options
{
    tokenVocab = CompilerLexer; 
} 

pr_Main
    :  E_KNamespace=LR_KNamespace  E_Qualifier=pr_Qualifier  E_TSemicolon=LR_TSemicolon  E_Block+=pr_MainBlock1*  E_Block1=pr_MainBlock2  E_EndOfFileToken=EOF
    ;
pr_Using
    :  E_KMetamodel=LR_KMetamodel  E_metaModelSymbols=pr_Qualifier #pr_UsingMetaModel
    |  E_namespaces=pr_Qualifier #pr_UsingAlt2
    ;
pr_LanguageDeclaration
    :  E_KLanguage=LR_KLanguage  E_Name=pr_Name  E_Block=pr_LanguageDeclarationBlock1?  E_TSemicolon=LR_TSemicolon  E_grammar=pr_Grammar
    ;
pr_Grammar
    :  E_Block=pr_GrammarBlock1
    ;
pr_GrammarRule
    :  E_Rule=pr_Rule #pr_GrammarRuleAlt1
    |  E_LexerRule=pr_LexerRule #pr_GrammarRuleAlt2
    ;
pr_Rule
    :  E_annotations+=pr_ParserAnnotation*  E_Block=pr_RuleBlock1  E_TColon=LR_TColon   E_alternatives1=pr_Alternative(E_TBar1+=LR_TBar E_alternatives2+=pr_Alternative)*  E_TSemicolon=LR_TSemicolon
    ;
pr_Alternative
    :  E_Block=pr_AlternativeBlock1?  E_elements+=pr_Element+  E_Block1=pr_AlternativeBlock2?
    ;
pr_Element
    :  E_Block=pr_ElementBlock1?  E_value=pr_ElementValue
    ;
pr_ElementValue
    :  E_Block=pr_Block #pr_ElementValueAlt1
    |  E_Eof1=pr_Eof1 #pr_ElementValueAlt2
    |  E_Fixed=pr_Fixed #pr_ElementValueAlt3
    |  E_RuleRef=pr_RuleRef #pr_ElementValueAlt4
    ;
pr_Block
    :  E_annotations+=pr_ParserAnnotation*  E_TLParen=LR_TLParen   E_alternatives1=pr_BlockAlternative(E_TBar1+=LR_TBar E_alternatives2+=pr_BlockAlternative)*  E_TRParen=LR_TRParen  E_multiplicity=pr_Multiplicity?
    ;
pr_BlockAlternative
    :  E_elements+=pr_Element+  E_Block=pr_BlockAlternativeBlock1?
    ;
pr_RuleRef
    :  E_annotations+=pr_ParserAnnotation*  E_grammarRule=pr_Identifier  E_multiplicity=pr_Multiplicity? #pr_RuleRefAlt1
    |  E_annotations1+=pr_ParserAnnotation*  E_THash=LR_THash  E_referencedTypes=pr_TypeReference  E_multiplicity1=pr_Multiplicity? #pr_RuleRefAlt2
    |  E_annotations2+=pr_ParserAnnotation*  E_THashLBrace=LR_THashLBrace   E_referencedTypes1=pr_TypeReference(E_TComma1+=LR_TComma E_referencedTypes2+=pr_TypeReference)*  E_Block=pr_RuleRefAlt3Block1?  E_TRBrace=LR_TRBrace  E_multiplicity2=pr_Multiplicity? #pr_RuleRefAlt3
    ;
pr_Eof1
    :  E_KEof=LR_KEof
    ;
pr_Fixed
    :  E_annotations+=pr_ParserAnnotation*  E_text=LR_TString  E_multiplicity=pr_Multiplicity?
    ;
pr_LexerRule
    :  E_Token=pr_Token #pr_LexerRuleAlt1
    |  E_Fragment=pr_Fragment #pr_LexerRuleAlt2
    ;
pr_Token
    :  E_annotations+=pr_LexerAnnotation*  E_Block=pr_TokenBlock1  E_TColon=LR_TColon   E_alternatives1=pr_LAlternative(E_TBar1+=LR_TBar E_alternatives2+=pr_LAlternative)*  E_TSemicolon=LR_TSemicolon
    ;
pr_Fragment
    :  E_KFragment=LR_KFragment  E_Name=pr_Name  E_TColon=LR_TColon   E_alternatives1=pr_LAlternative(E_TBar1+=LR_TBar E_alternatives2+=pr_LAlternative)*  E_TSemicolon=LR_TSemicolon
    ;
pr_LAlternative
    :  E_elements+=pr_LElement*
    ;
pr_LElement
    :  E_isNegated=LR_TTilde?  E_value=pr_LElementValue  E_multiplicity=pr_Multiplicity?
    ;
pr_LElementValue
    :  E_LBlock=pr_LBlock #pr_LElementValueAlt1
    |  E_LFixed=pr_LFixed #pr_LElementValueAlt2
    |  E_LWildCard=pr_LWildCard #pr_LElementValueAlt3
    |  E_LRange=pr_LRange #pr_LElementValueAlt4
    |  E_LReference=pr_LReference #pr_LElementValueAlt5
    ;
pr_LReference
    :  E_rule=pr_Identifier
    ;
pr_LFixed
    :  E_text=LR_TString
    ;
pr_LWildCard
    :  E_TDot=LR_TDot
    ;
pr_LRange
    :  E_startChar=LR_TString  E_TDotDot=LR_TDotDot  E_endChar=LR_TString
    ;
pr_LBlock
    :  E_TLParen=LR_TLParen   E_alternatives1=pr_LAlternative(E_TBar1+=LR_TBar E_alternatives2+=pr_LAlternative)*  E_TRParen=LR_TRParen
    ;
pr_Expression
    :  E_SingleExpression=pr_SingleExpression #pr_ExpressionAlt1
    |  E_ArrayExpression=pr_ArrayExpression #pr_ExpressionAlt2
    ;
pr_SingleExpression
    :  E_value=pr_SingleExpressionAlt1Block1 #pr_SingleExpressionAlt1
    |  E_value1=pr_Qualifier #pr_SingleExpressionAlt2
    ;
pr_ArrayExpression
    :  E_TLBrace=LR_TLBrace  E_Block=pr_ArrayExpressionBlock1?  E_TRBrace=LR_TRBrace
    ;
pr_ParserAnnotation
    :  E_TLBracket=LR_TLBracket  E_attributeClass=pr_Qualifier  E_Block=pr_ParserAnnotationBlock1?  E_TRBracket=LR_TRBracket
    ;
pr_LexerAnnotation
    :  E_TLBracket=LR_TLBracket  E_attributeClass=pr_Qualifier  E_Block=pr_LexerAnnotationBlock1?  E_TRBracket=LR_TRBracket
    ;
pr_AnnotationArgument
    :  E_Block=pr_AnnotationArgumentBlock1?  E_value=pr_Expression
    ;
pr_Assignment
    :  E_Token=(LR_TEq | LR_TQuestionEq | LR_TExclEq | LR_TPlusEq)
    ;
pr_Multiplicity
    :  E_Token=(LR_TQuestion | LR_TAsterisk | LR_TPlus | LR_TQuestionQuestion | LR_TAsteriskQuestion | LR_TPlusQuestion)
    ;
pr_TypeReferenceIdentifier
    :  E_PrimitiveType=pr_PrimitiveType #pr_TypeReferenceIdentifierAlt1
    |  E_Identifier=pr_Identifier #pr_TypeReferenceIdentifierAlt2
    ;
pr_TypeReference
    :  E_PrimitiveType=pr_PrimitiveType #pr_TypeReferenceAlt1
    |  E_Qualifier=pr_Qualifier #pr_TypeReferenceAlt2
    ;
pr_PrimitiveType
    :  E_Token=(LR_KObject | LR_KBool | LR_KChar | LR_KString | LR_KByte | LR_KSbyte | LR_KShort | LR_KUshort | LR_KInt | LR_KUint | LR_KLong | LR_KUlong | LR_KFloat | LR_KDouble | LR_KDecimal | LR_KType | LR_KSymbol | LR_KVoid)
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
    :  E_KUsing=LR_KUsing  E_Using=pr_Using  E_TSemicolon=LR_TSemicolon
    ;
pr_MainBlock2
    :  E_LanguageDeclaration=pr_LanguageDeclaration
    ;
pr_LanguageDeclarationBlock1
    :  E_TColon=LR_TColon   E_baseLanguages1=pr_Qualifier(E_TComma1+=LR_TComma E_baseLanguages2+=pr_Qualifier)*
    ;
pr_LanguageDeclarationBlock1baseLanguagesBlock
    :  E_TComma1=LR_TComma  E_baseLanguages2=pr_Qualifier
    ;
pr_GrammarBlock1
    :  E_grammarRules+=pr_GrammarRule*
    ;
pr_RuleBlock1
    :  E_returnType=pr_TypeReferenceIdentifier #pr_RuleBlock1Alt1
    |  E_Identifier=pr_Identifier  E_KReturns=LR_KReturns  E_returnType1=pr_TypeReference #pr_RuleBlock1Alt2
    ;
pr_RulealternativesBlock
    :  E_TBar1=LR_TBar  E_alternatives2=pr_Alternative
    ;
pr_AlternativeBlock1
    :  E_annotations+=pr_ParserAnnotation*  E_KAlt=LR_KAlt  E_Block=pr_AlternativeBlock1Block1  E_TColon=LR_TColon
    ;
pr_AlternativeBlock1Block1
    :  E_returnType=pr_TypeReferenceIdentifier #pr_AlternativeBlock1Block1Alt1
    |  E_Identifier=pr_Identifier  E_KReturns=LR_KReturns  E_returnType1=pr_TypeReference #pr_AlternativeBlock1Block1Alt2
    ;
pr_AlternativeBlock2
    :  E_TEqGt=LR_TEqGt  E_returnValue=pr_Expression
    ;
pr_ElementBlock1
    :  E_annotations+=pr_ParserAnnotation*  E_Name=pr_Name  E_assignment=pr_Assignment
    ;
pr_BlockalternativesBlock
    :  E_TBar1=LR_TBar  E_alternatives2=pr_BlockAlternative
    ;
pr_BlockAlternativeBlock1
    :  E_TEqGt=LR_TEqGt  E_returnValue=pr_Expression
    ;
pr_RuleRefAlt3referencedTypesBlock
    :  E_TComma1=LR_TComma  E_referencedTypes2=pr_TypeReference
    ;
pr_RuleRefAlt3Block1
    :  E_TBar=LR_TBar  E_grammarRule=pr_Identifier
    ;
pr_TokenBlock1
    :  E_KToken=LR_KToken  E_Name=pr_Name  E_Block=pr_TokenBlock1Alt1Block1? #pr_TokenBlock1Alt1
    |  E_isTrivia=LR_KHidden  E_Name1=pr_Name #pr_TokenBlock1Alt2
    ;
pr_TokenBlock1Alt1Block1
    :  E_KReturns=LR_KReturns  E_returnType=pr_TypeReference
    ;
pr_TokenalternativesBlock
    :  E_TBar1=LR_TBar  E_alternatives2=pr_LAlternative
    ;
pr_FragmentalternativesBlock
    :  E_TBar1=LR_TBar  E_alternatives2=pr_LAlternative
    ;
pr_LBlockalternativesBlock
    :  E_TBar1=LR_TBar  E_alternatives2=pr_LAlternative
    ;
pr_SingleExpressionAlt1Block1
    :  E_KNull=LR_KNull #pr_SingleExpressionAlt1Block1Alt1
    |  E_KTrue=LR_KTrue #pr_SingleExpressionAlt1Block1Alt2
    |  E_KFalse=LR_KFalse #pr_SingleExpressionAlt1Block1Alt3
    |  E_TString=LR_TString #pr_SingleExpressionAlt1Block1Alt4
    |  E_TInteger=LR_TInteger #pr_SingleExpressionAlt1Block1Alt5
    |  E_TDecimal=LR_TDecimal #pr_SingleExpressionAlt1Block1Alt6
    |  E_PrimitiveType=pr_PrimitiveType #pr_SingleExpressionAlt1Block1Alt7
    ;
pr_ArrayExpressionBlock1
    :   E_items1=pr_SingleExpression(E_TComma1+=LR_TComma E_items2+=pr_SingleExpression)*
    ;
pr_ArrayExpressionBlock1itemsBlock
    :  E_TComma1=LR_TComma  E_items2=pr_SingleExpression
    ;
pr_ParserAnnotationBlock1
    :  E_TLParen=LR_TLParen   E_arguments1=pr_AnnotationArgument(E_TComma1+=LR_TComma E_arguments2+=pr_AnnotationArgument)*  E_TRParen=LR_TRParen
    ;
pr_ParserAnnotationBlock1argumentsBlock
    :  E_TComma1=LR_TComma  E_arguments2=pr_AnnotationArgument
    ;
pr_LexerAnnotationBlock1
    :  E_TLParen=LR_TLParen   E_arguments1=pr_AnnotationArgument(E_TComma1+=LR_TComma E_arguments2+=pr_AnnotationArgument)*  E_TRParen=LR_TRParen
    ;
pr_LexerAnnotationBlock1argumentsBlock
    :  E_TComma1=LR_TComma  E_arguments2=pr_AnnotationArgument
    ;
pr_AnnotationArgumentBlock1
    :  E_namedParameter=pr_Identifier  E_TColon=LR_TColon
    ;
pr_QualifierIdentifierBlock
    :  E_TDot1=LR_TDot  E_Identifier2=pr_Identifier
    ;
