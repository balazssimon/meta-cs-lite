using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public abstract class CommonLanguage : Language
    {
        public const string Rules = @"
[Name]
Name returns void: Identifier;

[DefaultReference]
[Qualifier]
Qualifier returns void: Identifier ('.' Identifier)*;

[Identifier]
Identifier returns void: TIdentifier | TVerbatimIdentifier;

[Number]
token TInteger returns int: '0'| '1'..'9' ('0'..'9')* ;

[Number]
token TDecimal returns string: ('0'|'1'..'9' ('0'..'9')*) '.' ('0'..'9')+ ;

[DefaultIdentifier]
token TIdentifier: ('_'|'a'..'z'|'A'..'Z')+('_'|'a'..'z'|'A'..'Z'|'0'..'9')*;
[Identifier]
token TVerbatimIdentifier: '@'('_'|'a'..'z'|'A'..'Z')+('_'|'a'..'z'|'A'..'Z'|'0'..'9')*;

[DefaultSeparator]
token TComma: ',' ;

[String]
token TString returns string
    : '""' DoubleQuoteTextCharacter* '""'
    | '\'' SingleQuoteTextCharacter* '\'';

fragment DoubleQuoteTextCharacter : DoubleQuoteTextSimple | CharacterEscapeSimple | CharacterEscapeUnicode;
fragment DoubleQuoteTextSimple : ~('""' | '\\' | '\u000A' | '\u000D' | '\u0085' | '\u2028' | '\u2029');
fragment SingleQuoteTextCharacter : SingleQuoteTextSimple | CharacterEscapeSimple | CharacterEscapeUnicode;
fragment SingleQuoteTextSimple : ~('\'' | '\\' | '\u000A' | '\u000D' | '\u0085' | '\u2028' | '\u2029');
fragment CharacterEscapeSimple : '\\' CharacterEscapeSimpleCharacter;
fragment CharacterEscapeSimpleCharacter : '\'' | '""' | '\\' | '0' | 'a' | 'b' | 'f' | 'n' | 'r' | 't' | 'v'; 
fragment CharacterEscapeUnicode
    : '\\u' HexDigit HexDigit HexDigit HexDigit
    | '\\U' HexDigit HexDigit HexDigit HexDigit HexDigit HexDigit HexDigit HexDigit;
fragment HexDigit : ('0'..'9' | 'a'..'f' | 'A'..'F');

[Whitespace]
hidden TUtf8Bom: '\u00EF' '\u00BB' '\u00BF';

[DefaultWhitespace]
hidden TWhitespace: ('\t'|' ') +;

[DefaultEndOfLine]
hidden TLineEnd: ('\r\n' | '\r' | '\n');

[SingleLineComment]
hidden TSingleLineComment: '//' ~('\r' | '\n')*;

[MultiLineComment]
hidden TMultiLineComment: '/*' .*? '*/';

hidden TInvalidToken: .;
";
    }
}
