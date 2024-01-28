lexer grammar CompilerLexer;

LR_TComma: ',';
LR_TUtf8Bom: '\u00ef' '\u00bb' '\u00bf' -> channel(HIDDEN);
LR_KNamespace: 'namespace';
LR_TSemicolon: ';';
LR_KMetamodel: 'metamodel';
LR_KLanguage: 'language';
LR_TColon: ':';
LR_TLParen: '(';
LR_TRParen: ')';
LR_THash: '#';
LR_THashLBrace: '#{';
LR_TRBrace: '}';
LR_KEof: 'eof';
LR_KFragment: 'fragment';
LR_TTilde: '~';
LR_TDot: '.';
LR_TDotDot: '..';
LR_TLBrace: '{';
LR_TLBracket: '[';
LR_TRBracket: ']';
LR_TEq: '=';
LR_TQuestionEq: '?=';
LR_TExclEq: '!=';
LR_TPlusEq: '+=';
LR_TQuestion: '?';
LR_TAsterisk: '*';
LR_TPlus: '+';
LR_TQuestionQuestion: '??';
LR_TAsteriskQuestion: '*?';
LR_TPlusQuestion: '+?';
LR_KBool: 'bool';
LR_KInt: 'int';
LR_KDouble: 'double';
LR_KString: 'string';
LR_KType: 'type';
LR_KSymbol: 'symbol';
LR_KObject: 'object';
LR_KVoid: 'void';
LR_KUsing: 'using';
LR_KReturns: 'returns';
LR_TBar: '|';
LR_KAlt: 'alt';
LR_TEqGt: '=>';
LR_KToken: 'token';
LR_KHidden: 'hidden';
LR_KNull: 'null';
LR_KTrue: 'true';
LR_KFalse: 'false';
LR_TInteger: '0' | '1'..'9' ('0'..'9')*;
LR_TDecimal: ('0' | '1'..'9' ('0'..'9')*) '.' ('0'..'9')+;
LR_TIdentifier: ('_' | 'a'..'z' | 'A'..'Z')+ ('_' | 'a'..'z' | 'A'..'Z' | '0'..'9')*;
LR_TVerbatimIdentifier: '@' ('_' | 'a'..'z' | 'A'..'Z')+ ('_' | 'a'..'z' | 'A'..'Z' | '0'..'9')*;
LR_TString: '"' FR_DoubleQuoteTextCharacter* '"' | '\'' FR_SingleQuoteTextCharacter* '\'';
LR_TWhitespace: ('\t' | ' ')+ -> channel(HIDDEN);
LR_TLineEnd: ('\r\n' | '\r' | '\n') -> channel(HIDDEN);
LR_TSingleLineComment: '//' ~('\r' | '\n')* -> channel(HIDDEN);
LR_TMultiLineComment: '/*' .*? '*/' -> channel(HIDDEN);
LR_TInvalidToken: . -> channel(HIDDEN);
fragment FR_DoubleQuoteTextCharacter: FR_DoubleQuoteTextSimple | FR_CharacterEscapeSimple | FR_CharacterEscapeUnicode;
fragment FR_DoubleQuoteTextSimple: ~('"' | '\\' | '\n' | '\r' | '\u0085' | '\u2028' | '\u2029');
fragment FR_SingleQuoteTextCharacter: FR_SingleQuoteTextSimple | FR_CharacterEscapeSimple | FR_CharacterEscapeUnicode;
fragment FR_SingleQuoteTextSimple: ~('\'' | '\\' | '\n' | '\r' | '\u0085' | '\u2028' | '\u2029');
fragment FR_CharacterEscapeSimple: '\\' FR_CharacterEscapeSimpleCharacter;
fragment FR_CharacterEscapeSimpleCharacter: '\'' | '"' | '\\' | '0' | 'a' | 'b' | 'f' | 'n' | 'r' | 't' | 'v';
fragment FR_CharacterEscapeUnicode: '\\u' FR_HexDigit FR_HexDigit FR_HexDigit FR_HexDigit | '\\U' FR_HexDigit FR_HexDigit FR_HexDigit FR_HexDigit FR_HexDigit FR_HexDigit FR_HexDigit FR_HexDigit;
fragment FR_HexDigit: ('0'..'9' | 'a'..'f' | 'A'..'F');
