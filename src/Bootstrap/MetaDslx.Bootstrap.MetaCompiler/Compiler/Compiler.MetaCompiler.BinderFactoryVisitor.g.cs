using System;
using System.Collections.Immutable;
using MetaDslx.CodeAnalysis;
using System;
using MetaDslx.CodeAnalysis.Annotations;
using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Syntax;
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
                    var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Namespace));
                    this.Begin(__annot2, node);
                    try
                    {
                        var __annot1 = new PropertyBinder(name: "Name");
                        this.Begin(__annot1, node.Name);
                        try
                        {
                            var __annot0 = new NameBinder(qualifierProperty: "Declarations");
                            this.Begin(__annot0, node.Name);
                            try
                            {
                                this.Visit(node.Name);
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
                        var @usingList = node.Using;
                        for (var @usingIndex = 0; @usingIndex < @usingList.Count; ++@usingIndex)
                        {
                            this.Visit(node.Using[@usingIndex]);
                        }
                            
                    }
                    finally
                    {
                        this.End(__annot2);
                    }
                }
                finally
                {
                    this.End(__rootAnnot);
                }
            }
            else
            {
            	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Namespace));
            	this.Begin(__annot2, node);
            	try
            	{
            	    var __annot1 = new PropertyBinder(name: "Name");
            	    this.Begin(__annot1, node.Name);
            	    try
            	    {
            	        var __annot0 = new NameBinder(qualifierProperty: "Declarations");
            	        this.Begin(__annot0, node.Name);
            	        try
            	        {
            	            this.Visit(node.Name);
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
            	    var @usingList = node.Using;
            	    for (var @usingIndex = 0; @usingIndex < @usingList.Count; ++@usingIndex)
            	    {
            	        this.Visit(node.Using[@usingIndex]);
            	    }
            	        
            	}
            	finally
            	{
            	    this.End(__annot2);
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
