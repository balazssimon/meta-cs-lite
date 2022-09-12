lexer grammar SandyLexer;

options
{
	                      
                            
}

// Whitespace
                             
NEWLINE            : ('\r\n' | 'r' | '\n');
                              
WS                 : [\t ]+ -> channel(HIDDEN);

// Keywords
VAR                : 'var' ;
PRINT              : 'print';
AS                 : 'as';
INT                : 'Int';
DECIMAL            : 'Decimal';

// Literals
INTLIT             : '0'|[1-9][0-9]* ;
DECLIT             : '0'|[1-9][0-9]* '.' [0-9]+ ;

// Operators
PLUS               : '+' ;
MINUS              : '-' ;
ASTERISK           : '*' ;
DIVISION           : '/' ;
ASSIGN             : '=' ;
LPAREN             : '(' ;
RPAREN             : ')' ;
                             
COMMA              : ',' ;

// Identifiers
                              
ID                 : [_]*[a-z][A-Za-z0-9_]* ;

