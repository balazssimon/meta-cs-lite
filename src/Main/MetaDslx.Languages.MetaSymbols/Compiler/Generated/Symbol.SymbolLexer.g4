lexer grammar SymbolLexer;

LR_KNull: 'null';
LR_KTrue: 'true';
LR_KFalse: 'false';
LR_TComma: ',';
LR_TUtf8Bom: '\u00ef' '\u00bb' '\u00bf' -> channel(HIDDEN);
LR_KNamespace: 'namespace';
LR_KUsing: 'using';
LR_KAbstract: 'abstract';
LR_KSymbol: 'symbol';
LR_KPlain: 'plain';
LR_KWeak: 'weak';
LR_KPhase: 'phase';
LR_TLParen: '(';
LR_TRParen: ')';
LR_KCached: 'cached';
LR_KObject: 'object';
LR_KBool: 'bool';
LR_KChar: 'char';
LR_KString: 'string';
LR_KByte: 'byte';
LR_KSbyte: 'sbyte';
LR_KShort: 'short';
LR_KUshort: 'ushort';
LR_KInt: 'int';
LR_KUint: 'uint';
LR_KLong: 'long';
LR_KUlong: 'ulong';
LR_KFloat: 'float';
LR_KDouble: 'double';
LR_KDecimal: 'decimal';
LR_KType: 'type';
LR_KVoid: 'void';
LR_TColon: ':';
LR_TLBrace: '{';
LR_TRBrace: '}';
LR_KDerived: 'derived';
LR_TEq: '=';
LR_KIf: 'if';
LR_TQuestion: '?';
LR_TLBracket: '[';
LR_TRBracket: ']';
LR_TDot: '.';
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
