using System;
using System.Collections.Immutable;
using MetaDslx.CodeAnalysis;
using System;
using MetaDslx.CodeAnalysis.Annotations;
using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Bootstrap.MetaCompiler.Model;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler.Compiler.Binding
{
    using MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax;

    public class CompilerBinderFactoryVisitor : MetaDslx.CodeAnalysis.Binding.BinderFactoryVisitor, ICompilerSyntaxVisitor
    {
        internal CompilerBinderFactoryVisitor(MetaDslx.CodeAnalysis.Binding.BinderFactory binderFactory)
            : base(binderFactory)
        {
        }


        public virtual void VisitMain(MainSyntax node)
        {
            if (this.IsRoot)
            {
                var __rootAnnot = new global::MetaDslx.CodeAnalysis.Binding.RootBinder(node.SyntaxTree, type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Namespace));
                this.Begin(__rootAnnot, node);
                try
                {
                    var __annot1 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Namespace));
                    this.Begin(__annot1, node);
                    try
                    {
                        var __annot0 = new NameBinder(qualifierProperty: "Declarations");
                        this.Begin(__annot0, node.Qualifier);
                        try
                        {
                            this.Visit(node.Qualifier);
                        }
                        finally
                        {
                            this.End(__annot0);
                        }
                        var @usingList = node.Using;
                        for (var @usingIndex = 0; @usingIndex < @usingList.Count; ++@usingIndex)
                        {
                            this.Visit(node.Using[@usingIndex]);
                        }
                        this.Visit(node.Declarations);
                            
                    }
                    finally
                    {
                        this.End(__annot1);
                    }
                }
                finally
                {
                    this.End(__rootAnnot);
                }
            }
            else
            {
            	var __annot1 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Namespace));
            	this.Begin(__annot1, node);
            	try
            	{
            	    var __annot0 = new NameBinder(qualifierProperty: "Declarations");
            	    this.Begin(__annot0, node.Qualifier);
            	    try
            	    {
            	        this.Visit(node.Qualifier);
            	    }
            	    finally
            	    {
            	        this.End(__annot0);
            	    }
            	    var @usingList = node.Using;
            	    for (var @usingIndex = 0; @usingIndex < @usingList.Count; ++@usingIndex)
            	    {
            	        this.Visit(node.Using[@usingIndex]);
            	    }
            	    this.Visit(node.Declarations);
            	        
            	}
            	finally
            	{
            	    this.End(__annot1);
            	}
            }
        }

        public virtual void VisitUsing(UsingSyntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.CodeAnalysis.Symbols.ImportSymbol));
        	this.Begin(__annot2, node);
        	try
        	{
        	    var __annot1 = new PropertyBinder(name: "Namespaces");
        	    this.Begin(__annot1, node.Namespaces);
        	    try
        	    {
        	        var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol)}.ToImmutableArray());
        	        this.Begin(__annot0, node.Namespaces);
        	        try
        	        {
        	            this.Visit(node.Namespaces);
        	        }
        	        finally
        	        {
        	            this.End(__annot0);
        	        }
        	    }
        	    finally
        	    {
        	        this.End(__annot1);
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot2);
        	}
        }

        public virtual void VisitDeclarations(DeclarationsSyntax node)
        {
        	var __annot0 = new PropertyBinder(name: "Declarations");
        	this.Begin(__annot0, node.Declarations);
        	try
        	{
        	    this.Visit(node.Declarations);
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        	var declarations1List = node.Declarations1;
        	for (var declarations1Index = 0; declarations1Index < declarations1List.Count; ++declarations1Index)
        	{
        	    var __annot1 = new PropertyBinder(name: "Declarations");
        	    this.Begin(__annot1, node.Declarations1[declarations1Index]);
        	    try
        	    {
        	        this.Visit(node.Declarations1[declarations1Index]);
        	    }
        	    finally
        	    {
        	        this.End(__annot1);
        	    }
        	}
        	    
        }

        public virtual void VisitLanguageDeclaration(LanguageDeclarationSyntax node)
        {
        	var __annot0 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Language));
        	this.Begin(__annot0, node);
        	try
        	{
        	    this.Visit(node.Name);
        	        
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        }

        public virtual void VisitParserRule(ParserRuleSyntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.ParserRule));
        	this.Begin(__annot2, node);
        	try
        	{
        	    this.Visit(node.Name);
        	    this.Visit(node.ParserRuleBlock1);
        	    var parserRuleAlternativeListList = node.ParserRuleAlternativeList;
        	    for (var parserRuleAlternativeListIndex = 0; parserRuleAlternativeListIndex < parserRuleAlternativeListList.Count; ++parserRuleAlternativeListIndex)
        	    {
        	        if (parserRuleAlternativeListIndex == 0)
        	        {
        	            var __annot0 = new PropertyBinder(name: "Alternatives");
        	            this.Begin(__annot0, node.ParserRuleAlternativeList[parserRuleAlternativeListIndex]);
        	            try
        	            {
        	                this.Visit(node.ParserRuleAlternativeList[parserRuleAlternativeListIndex]);
        	            }
        	            finally
        	            {
        	                this.End(__annot0);
        	            }
        	        }
        	        else
        	        {
        	            var __annot1 = new PropertyBinder(name: "Alternatives");
        	            this.Begin(__annot1, node.ParserRuleAlternativeList[parserRuleAlternativeListIndex]);
        	            try
        	            {
        	                this.Visit(node.ParserRuleAlternativeList[parserRuleAlternativeListIndex]);
        	            }
        	            finally
        	            {
        	                this.End(__annot1);
        	            }
        	            // this.VisitToken(node.ParserRuleAlternativeList.GetSeparator(parserRuleAlternativeListIndex));
        	        }
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot2);
        	}
        }

        public virtual void VisitBlockRule(BlockRuleSyntax node)
        {
        	var __annot3 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.ParserRule));
        	this.Begin(__annot3, node);
        	try
        	{
        	    if (node.IsBlock.GetCompilerKind() != CompilerSyntaxKind.None)
        	    {
        	        var __annot0 = new PropertyBinder(name: "IsBlock", value: true);
        	        this.Begin(__annot0, node.IsBlock);
        	        try
        	        {
        	            // this.VisitToken(node.IsBlock);
        	        }
        	        finally
        	        {
        	            this.End(__annot0);
        	        }
        	    }
        	    else
        	    {
        	        // this.VisitToken(node.IsBlock);
        	    }
        	    this.Visit(node.Name);
        	    var parserRuleAlternativeListList = node.ParserRuleAlternativeList;
        	    for (var parserRuleAlternativeListIndex = 0; parserRuleAlternativeListIndex < parserRuleAlternativeListList.Count; ++parserRuleAlternativeListIndex)
        	    {
        	        if (parserRuleAlternativeListIndex == 0)
        	        {
        	            var __annot1 = new PropertyBinder(name: "Alternatives");
        	            this.Begin(__annot1, node.ParserRuleAlternativeList[parserRuleAlternativeListIndex]);
        	            try
        	            {
        	                this.Visit(node.ParserRuleAlternativeList[parserRuleAlternativeListIndex]);
        	            }
        	            finally
        	            {
        	                this.End(__annot1);
        	            }
        	        }
        	        else
        	        {
        	            var __annot2 = new PropertyBinder(name: "Alternatives");
        	            this.Begin(__annot2, node.ParserRuleAlternativeList[parserRuleAlternativeListIndex]);
        	            try
        	            {
        	                this.Visit(node.ParserRuleAlternativeList[parserRuleAlternativeListIndex]);
        	            }
        	            finally
        	            {
        	                this.End(__annot2);
        	            }
        	            // this.VisitToken(node.ParserRuleAlternativeList.GetSeparator(parserRuleAlternativeListIndex));
        	        }
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot3);
        	}
        }

        public virtual void VisitParserRuleAlternative(ParserRuleAlternativeSyntax node)
        {
        	var __annot1 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.ParserRuleAlternative));
        	this.Begin(__annot1, node);
        	try
        	{
        	    this.Visit(node.ParserRuleAlternativeBlock1);
        	    var elementsList = node.Elements;
        	    for (var elementsIndex = 0; elementsIndex < elementsList.Count; ++elementsIndex)
        	    {
        	        var __annot0 = new PropertyBinder(name: "Elements");
        	        this.Begin(__annot0, node.Elements[elementsIndex]);
        	        try
        	        {
        	            this.Visit(node.Elements[elementsIndex]);
        	        }
        	        finally
        	        {
        	            this.End(__annot0);
        	        }
        	    }
        	    this.Visit(node.ParserRuleAlternativeBlock2);
        	        
        	}
        	finally
        	{
        	    this.End(__annot1);
        	}
        }

        public virtual void VisitParserRuleElement(ParserRuleElementSyntax node)
        {
        	var __annot0 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.ParserRuleElement));
        	this.Begin(__annot0, node);
        	try
        	{
        	    this.Visit(node.Name);
        	        
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        }

        public virtual void VisitIntExpression(IntExpressionSyntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.IntExpression));
        	this.Begin(__annot2, node);
        	try
        	{
        	    if (node.IntValue.GetCompilerKind() != CompilerSyntaxKind.None)
        	    {
        	        var __annot1 = new PropertyBinder(name: "IntValue");
        	        this.Begin(__annot1, node.IntValue);
        	        try
        	        {
        	            var __annot0 = new ValueBinder(type: typeof(int));
        	            this.Begin(__annot0, node.IntValue);
        	            try
        	            {
        	                // this.VisitToken(node.IntValue);
        	            }
        	            finally
        	            {
        	                this.End(__annot0);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot1);
        	        }
        	    }
        	    else
        	    {
        	        // this.VisitToken(node.IntValue);
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot2);
        	}
        }

        public virtual void VisitStringExpression(StringExpressionSyntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.StringExpression));
        	this.Begin(__annot2, node);
        	try
        	{
        	    if (node.StringValue.GetCompilerKind() != CompilerSyntaxKind.None)
        	    {
        	        var __annot1 = new PropertyBinder(name: "StringValue");
        	        this.Begin(__annot1, node.StringValue);
        	        try
        	        {
        	            var __annot0 = new ValueBinder(type: typeof(string));
        	            this.Begin(__annot0, node.StringValue);
        	            try
        	            {
        	                // this.VisitToken(node.StringValue);
        	            }
        	            finally
        	            {
        	                this.End(__annot0);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot1);
        	        }
        	    }
        	    else
        	    {
        	        // this.VisitToken(node.StringValue);
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot2);
        	}
        }

        public virtual void VisitReferenceExpression(ReferenceExpressionSyntax node)
        {
        	var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.CodeAnalysis.MetaSymbol)}.ToImmutableArray());
        	this.Begin(__annot0, node.Qualifier);
        	try
        	{
        	    this.Visit(node.Qualifier);
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        	    
        }

        public virtual void VisitExpressionTokens(ExpressionTokensSyntax node)
        {
        	switch (node.Tokens.GetCompilerKind())
        	{
        	case CompilerSyntaxKind.KNull:
        	    var __annot0 = new ValueBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.NullExpression));
        	    this.Begin(__annot0, node.Tokens);
        	    try
        	    {
        	        // this.VisitToken(node.Tokens);
        	    }
        	    finally
        	    {
        	        this.End(__annot0);
        	    }
        	    break;
        	case CompilerSyntaxKind.KTrue:
        	    var __annot2 = new PropertyBinder(name: "BoolValue", value: true);
        	    this.Begin(__annot2, node.Tokens);
        	    try
        	    {
        	        var __annot1 = new ValueBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.BoolExpression));
        	        this.Begin(__annot1, node.Tokens);
        	        try
        	        {
        	            // this.VisitToken(node.Tokens);
        	        }
        	        finally
        	        {
        	            this.End(__annot1);
        	        }
        	    }
        	    finally
        	    {
        	        this.End(__annot2);
        	    }
        	    break;
        	case CompilerSyntaxKind.KFalse:
        	    var __annot3 = new ValueBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.BoolExpression));
        	    this.Begin(__annot3, node.Tokens);
        	    try
        	    {
        	        // this.VisitToken(node.Tokens);
        	    }
        	    finally
        	    {
        	        this.End(__annot3);
        	    }
        	    break;
        	default:
        	    // this.VisitToken(node.Tokens);
        	    break;
        	}
        	    
        }

        public virtual void VisitName(NameSyntax node)
        {
        	var __annot0 = new NameBinder();
        	this.Begin(__annot0, node);
        	try
        	{
        	    this.Visit(node.Identifier);
        	        
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        }

        public virtual void VisitQualifier(QualifierSyntax node)
        {
        	var __annot0 = new QualifierBinder();
        	this.Begin(__annot0, node);
        	try
        	{
        	    var identifierListList = node.IdentifierList;
        	    for (var identifierListIndex = 0; identifierListIndex < identifierListList.Count; ++identifierListIndex)
        	    {
        	        if (identifierListIndex == 0)
        	        {
        	            this.Visit(node.IdentifierList[identifierListIndex]);
        	        }
        	        else
        	        {
        	            this.Visit(node.IdentifierList[identifierListIndex]);
        	            // this.VisitToken(node.IdentifierList.GetSeparator(identifierListIndex));
        	        }
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        }

        public virtual void VisitQualifierList(QualifierListSyntax node)
        {
        	var qualifierListList = node.QualifierList;
        	for (var qualifierListIndex = 0; qualifierListIndex < qualifierListList.Count; ++qualifierListIndex)
        	{
        	    if (qualifierListIndex == 0)
        	    {
        	        this.Visit(node.QualifierList[qualifierListIndex]);
        	    }
        	    else
        	    {
        	        this.Visit(node.QualifierList[qualifierListIndex]);
        	        // this.VisitToken(node.QualifierList.GetSeparator(qualifierListIndex));
        	    }
        	}
        	    
        }

        public virtual void VisitIdentifier(IdentifierSyntax node)
        {
        	var __annot0 = new IdentifierBinder();
        	this.Begin(__annot0, node);
        	try
        	{
        	        
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        }

        public virtual void VisitParserRuleBlock1(ParserRuleBlock1Syntax node)
        {
        	var __annot1 = new PropertyBinder(name: "ReturnType");
        	this.Begin(__annot1, node.ReturnType);
        	try
        	{
        	    var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.CodeAnalysis.MetaType)}.ToImmutableArray());
        	    this.Begin(__annot0, node.ReturnType);
        	    try
        	    {
        	        this.Visit(node.ReturnType);
        	    }
        	    finally
        	    {
        	        this.End(__annot0);
        	    }
        	}
        	finally
        	{
        	    this.End(__annot1);
        	}
        	    
        }

        public virtual void VisitParserRuleBlock2(ParserRuleBlock2Syntax node)
        {
        	if (node.TBar.GetCompilerKind() != CompilerSyntaxKind.None)
        	{
        	    // this.VisitToken(node.TBar);
        	}
        	else
        	{
        	    // this.VisitToken(node.TBar);
        	}
        	var __annot0 = new PropertyBinder(name: "Alternatives");
        	this.Begin(__annot0, node.Alternatives);
        	try
        	{
        	    this.Visit(node.Alternatives);
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        	    
        }

        public virtual void VisitBlockRuleBlock1(BlockRuleBlock1Syntax node)
        {
        	if (node.TBar.GetCompilerKind() != CompilerSyntaxKind.None)
        	{
        	    // this.VisitToken(node.TBar);
        	}
        	else
        	{
        	    // this.VisitToken(node.TBar);
        	}
        	var __annot0 = new PropertyBinder(name: "Alternatives");
        	this.Begin(__annot0, node.Alternatives);
        	try
        	{
        	    this.Visit(node.Alternatives);
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        	    
        }

        public virtual void VisitParserRuleAlternativeBlock1(ParserRuleAlternativeBlock1Syntax node)
        {
        	var __annot1 = new PropertyBinder(name: "ReturnType");
        	this.Begin(__annot1, node.ReturnType);
        	try
        	{
        	    var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.CodeAnalysis.MetaType)}.ToImmutableArray());
        	    this.Begin(__annot0, node.ReturnType);
        	    try
        	    {
        	        this.Visit(node.ReturnType);
        	    }
        	    finally
        	    {
        	        this.End(__annot0);
        	    }
        	}
        	finally
        	{
        	    this.End(__annot1);
        	}
        	    
        }

        public virtual void VisitParserRuleAlternativeBlock2(ParserRuleAlternativeBlock2Syntax node)
        {
        	var __annot0 = new PropertyBinder(name: "ReturnValue");
        	this.Begin(__annot0, node.ReturnValue);
        	try
        	{
        	    this.Visit(node.ReturnValue);
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        	    
        }

        public virtual void VisitQualifierBlock1(QualifierBlock1Syntax node)
        {
        	if (node.TDot.GetCompilerKind() != CompilerSyntaxKind.None)
        	{
        	    // this.VisitToken(node.TDot);
        	}
        	else
        	{
        	    // this.VisitToken(node.TDot);
        	}
        	this.Visit(node.Identifier);
        	    
        }

        public virtual void VisitQualifierListBlock1(QualifierListBlock1Syntax node)
        {
        	if (node.TComma.GetCompilerKind() != CompilerSyntaxKind.None)
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	else
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	this.Visit(node.Qualifier);
        	    
        }

		public virtual void VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node)
		{
		}
    }
}
