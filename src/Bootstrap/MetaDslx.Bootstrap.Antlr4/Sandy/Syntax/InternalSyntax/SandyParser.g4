parser grammar SandyParser;

options 
{
    tokenVocab=SandyLexer;
                          
                            
}

main : line* EOF;

line      : statement NEWLINE;

statement : varDeclaration
          | assignment    
          | print         
          ;

print : PRINT LPAREN expression RPAREN ;

varDeclaration : VAR assignment ;

assignment : ID ASSIGN expression ;

expression : left=expression op=(DIVISION|ASTERISK) right=expression # binaryMulOperation
           | left=expression op=(PLUS|MINUS) right=expression        # binaryAddOperation
           | value=expression AS targetType=type                           # typeConversion
           | LPAREN expression RPAREN                                      # parenExpression
           | ID                                                            # varReference
           | MINUS expression                                              # minusExpression
           | INTLIT                                                        # intLiteral
           | DECLIT                                                        # decimalLiteral ;
           
type : INT     
     | DECIMAL ;

