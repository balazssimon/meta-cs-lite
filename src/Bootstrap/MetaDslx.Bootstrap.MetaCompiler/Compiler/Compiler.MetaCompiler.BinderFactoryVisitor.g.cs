using System;
using System.Collections.Immutable;
using MetaDslx.CodeAnalysis;
using System;
using MetaDslx.CodeAnalysis.Annotations;
using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling;
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
                        this.Visit(node.Declarations);
                            
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
            	    this.Visit(node.Declarations);
            	        
            	}
            	finally
            	{
            	    this.End(__annot2);
            	}
            }
        }

        public virtual void VisitUsing(UsingSyntax node)
        {
        	var __annot0 = new DefineBinder(type: typeof(global::MetaDslx.CodeAnalysis.Symbols.ImportSymbol));
        	this.Begin(__annot0, node);
        	try
        	{
        	    this.Visit(node.UsingBlock1);
        	        
        	}
        	finally
        	{
        	    this.End(__annot0);
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
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Language));
        	this.Begin(__annot2, node);
        	try
        	{
        	    var __annot0 = new PropertyBinder(name: "Name");
        	    this.Begin(__annot0, node.Name);
        	    try
        	    {
        	        this.Visit(node.Name);
        	    }
        	    finally
        	    {
        	        this.End(__annot0);
        	    }
        	    var __annot1 = new PropertyBinder(name: "Grammar");
        	    this.Begin(__annot1, node.Grammar);
        	    try
        	    {
        	        this.Visit(node.Grammar);
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

        public virtual void VisitGrammar(GrammarSyntax node)
        {
        	var __annot0 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Grammar));
        	this.Begin(__annot0, node);
        	try
        	{
        	    this.Visit(node.GrammarBlock1);
        	        
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        }

        public virtual void VisitParserRule(ParserRuleSyntax node)
        {
        	var __annot3 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.ParserRule));
        	this.Begin(__annot3, node);
        	try
        	{
        	    var annotations1List = node.Annotations1;
        	    for (var annotations1Index = 0; annotations1Index < annotations1List.Count; ++annotations1Index)
        	    {
        	        var __annot0 = new PropertyBinder(name: "Annotations");
        	        this.Begin(__annot0, node.Annotations1[annotations1Index]);
        	        try
        	        {
        	            this.Visit(node.Annotations1[annotations1Index]);
        	        }
        	        finally
        	        {
        	            this.End(__annot0);
        	        }
        	    }
        	    this.Visit(node.ParserRuleBlock1);
        	    var pAlternativeListList = node.PAlternativeList;
        	    for (var pAlternativeListIndex = 0; pAlternativeListIndex < pAlternativeListList.Count; ++pAlternativeListIndex)
        	    {
        	        if (pAlternativeListIndex == 0)
        	        {
        	            var __annot1 = new PropertyBinder(name: "Alternatives");
        	            this.Begin(__annot1, node.PAlternativeList[pAlternativeListIndex]);
        	            try
        	            {
        	                this.Visit(node.PAlternativeList[pAlternativeListIndex]);
        	            }
        	            finally
        	            {
        	                this.End(__annot1);
        	            }
        	        }
        	        else
        	        {
        	            var __annot2 = new PropertyBinder(name: "Alternatives");
        	            this.Begin(__annot2, node.PAlternativeList[pAlternativeListIndex]);
        	            try
        	            {
        	                this.Visit(node.PAlternativeList[pAlternativeListIndex]);
        	            }
        	            finally
        	            {
        	                this.End(__annot2);
        	            }
        	            // this.VisitToken(node.PAlternativeList.GetSeparator(pAlternativeListIndex));
        	        }
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot3);
        	}
        }

        public virtual void VisitLexerRule(LexerRuleSyntax node)
        {
        	var __annot3 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.LexerRule));
        	this.Begin(__annot3, node);
        	try
        	{
        	    var annotations1List = node.Annotations1;
        	    for (var annotations1Index = 0; annotations1Index < annotations1List.Count; ++annotations1Index)
        	    {
        	        var __annot0 = new PropertyBinder(name: "Annotations");
        	        this.Begin(__annot0, node.Annotations1[annotations1Index]);
        	        try
        	        {
        	            this.Visit(node.Annotations1[annotations1Index]);
        	        }
        	        finally
        	        {
        	            this.End(__annot0);
        	        }
        	    }
        	    this.Visit(node.LexerRuleBlock1);
        	    var lAlternativeListList = node.LAlternativeList;
        	    for (var lAlternativeListIndex = 0; lAlternativeListIndex < lAlternativeListList.Count; ++lAlternativeListIndex)
        	    {
        	        if (lAlternativeListIndex == 0)
        	        {
        	            var __annot1 = new PropertyBinder(name: "Alternatives");
        	            this.Begin(__annot1, node.LAlternativeList[lAlternativeListIndex]);
        	            try
        	            {
        	                this.Visit(node.LAlternativeList[lAlternativeListIndex]);
        	            }
        	            finally
        	            {
        	                this.End(__annot1);
        	            }
        	        }
        	        else
        	        {
        	            var __annot2 = new PropertyBinder(name: "Alternatives");
        	            this.Begin(__annot2, node.LAlternativeList[lAlternativeListIndex]);
        	            try
        	            {
        	                this.Visit(node.LAlternativeList[lAlternativeListIndex]);
        	            }
        	            finally
        	            {
        	                this.End(__annot2);
        	            }
        	            // this.VisitToken(node.LAlternativeList.GetSeparator(lAlternativeListIndex));
        	        }
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot3);
        	}
        }

        public virtual void VisitPAlternative(PAlternativeSyntax node)
        {
        	var __annot1 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.PAlternative));
        	this.Begin(__annot1, node);
        	try
        	{
        	    this.Visit(node.PAlternativeBlock1);
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
        	    this.Visit(node.PAlternativeBlock2);
        	        
        	}
        	finally
        	{
        	    this.End(__annot1);
        	}
        }

        public virtual void VisitPElement(PElementSyntax node)
        {
        	var __annot14 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.PElement));
        	this.Begin(__annot14, node);
        	try
        	{
        	    this.Visit(node.PElementBlock1);
        	    var valueAnnotationsList = node.ValueAnnotations;
        	    for (var valueAnnotationsIndex = 0; valueAnnotationsIndex < valueAnnotationsList.Count; ++valueAnnotationsIndex)
        	    {
        	        var __annot0 = new PropertyBinder(name: "ValueAnnotations");
        	        this.Begin(__annot0, node.ValueAnnotations[valueAnnotationsIndex]);
        	        try
        	        {
        	            this.Visit(node.ValueAnnotations[valueAnnotationsIndex]);
        	        }
        	        finally
        	        {
        	            this.End(__annot0);
        	        }
        	    }
        	    var __annot1 = new PropertyBinder(name: "Value");
        	    this.Begin(__annot1, node.Value);
        	    try
        	    {
        	        this.Visit(node.Value);
        	    }
        	    finally
        	    {
        	        this.End(__annot1);
        	    }
        	    switch (node.Multiplicity.GetCompilerKind())
        	    {
        	    case CompilerSyntaxKind.TQuestion:
        	        var __annot3 = new PropertyBinder(name: "Multiplicity");
        	        this.Begin(__annot3, node.Multiplicity);
        	        try
        	        {
        	            var __annot2 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity.ZeroOrOne);
        	            this.Begin(__annot2, node.Multiplicity);
        	            try
        	            {
        	                // this.VisitToken(node.Multiplicity);
        	            }
        	            finally
        	            {
        	                this.End(__annot2);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot3);
        	        }
        	        break;
        	    case CompilerSyntaxKind.TAsterisk:
        	        var __annot5 = new PropertyBinder(name: "Multiplicity");
        	        this.Begin(__annot5, node.Multiplicity);
        	        try
        	        {
        	            var __annot4 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity.ZeroOrMore);
        	            this.Begin(__annot4, node.Multiplicity);
        	            try
        	            {
        	                // this.VisitToken(node.Multiplicity);
        	            }
        	            finally
        	            {
        	                this.End(__annot4);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot5);
        	        }
        	        break;
        	    case CompilerSyntaxKind.TPlus:
        	        var __annot7 = new PropertyBinder(name: "Multiplicity");
        	        this.Begin(__annot7, node.Multiplicity);
        	        try
        	        {
        	            var __annot6 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity.OneOrMore);
        	            this.Begin(__annot6, node.Multiplicity);
        	            try
        	            {
        	                // this.VisitToken(node.Multiplicity);
        	            }
        	            finally
        	            {
        	                this.End(__annot6);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot7);
        	        }
        	        break;
        	    case CompilerSyntaxKind.TQuestionQuestion:
        	        var __annot9 = new PropertyBinder(name: "Multiplicity");
        	        this.Begin(__annot9, node.Multiplicity);
        	        try
        	        {
        	            var __annot8 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity.NonGreedyZeroOrOne);
        	            this.Begin(__annot8, node.Multiplicity);
        	            try
        	            {
        	                // this.VisitToken(node.Multiplicity);
        	            }
        	            finally
        	            {
        	                this.End(__annot8);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot9);
        	        }
        	        break;
        	    case CompilerSyntaxKind.TAsteriskQuestion:
        	        var __annot11 = new PropertyBinder(name: "Multiplicity");
        	        this.Begin(__annot11, node.Multiplicity);
        	        try
        	        {
        	            var __annot10 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity.NonGreedyZeroOrMore);
        	            this.Begin(__annot10, node.Multiplicity);
        	            try
        	            {
        	                // this.VisitToken(node.Multiplicity);
        	            }
        	            finally
        	            {
        	                this.End(__annot10);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot11);
        	        }
        	        break;
        	    case CompilerSyntaxKind.TPlusQuestion:
        	        var __annot13 = new PropertyBinder(name: "Multiplicity");
        	        this.Begin(__annot13, node.Multiplicity);
        	        try
        	        {
        	            var __annot12 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity.NonGreedyOneOrMore);
        	            this.Begin(__annot12, node.Multiplicity);
        	            try
        	            {
        	                // this.VisitToken(node.Multiplicity);
        	            }
        	            finally
        	            {
        	                this.End(__annot12);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot13);
        	        }
        	        break;
        	    default:
        	        // this.VisitToken(node.Multiplicity);
        	        break;
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot14);
        	}
        }

        public virtual void VisitPReferenceAlt1(PReferenceAlt1Syntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.PReference));
        	this.Begin(__annot2, node);
        	try
        	{
        	    var __annot1 = new PropertyBinder(name: "Rule");
        	    this.Begin(__annot1, node.Rule);
        	    try
        	    {
        	        var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.Rule)}.ToImmutableArray());
        	        this.Begin(__annot0, node.Rule);
        	        try
        	        {
        	            this.Visit(node.Rule);
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

        public virtual void VisitPReferenceAlt2(PReferenceAlt2Syntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.PReference));
        	this.Begin(__annot2, node);
        	try
        	{
        	    var __annot1 = new PropertyBinder(name: "ReferencedTypes");
        	    this.Begin(__annot1, node.ReferencedTypes);
        	    try
        	    {
        	        var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.CodeAnalysis.MetaType)}.ToImmutableArray());
        	        this.Begin(__annot0, node.ReferencedTypes);
        	        try
        	        {
        	            this.Visit(node.ReferencedTypes);
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

        public virtual void VisitPReferenceAlt3(PReferenceAlt3Syntax node)
        {
        	var __annot4 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.PReference));
        	this.Begin(__annot4, node);
        	try
        	{
        	    var qualifierListList = node.QualifierList;
        	    for (var qualifierListIndex = 0; qualifierListIndex < qualifierListList.Count; ++qualifierListIndex)
        	    {
        	        if (qualifierListIndex == 0)
        	        {
        	            var __annot1 = new PropertyBinder(name: "ReferencedTypes");
        	            this.Begin(__annot1, node.QualifierList[qualifierListIndex]);
        	            try
        	            {
        	                var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.CodeAnalysis.MetaType)}.ToImmutableArray());
        	                this.Begin(__annot0, node.QualifierList[qualifierListIndex]);
        	                try
        	                {
        	                    this.Visit(node.QualifierList[qualifierListIndex]);
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
        	            var __annot3 = new PropertyBinder(name: "ReferencedTypes");
        	            this.Begin(__annot3, node.QualifierList[qualifierListIndex]);
        	            try
        	            {
        	                var __annot2 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.CodeAnalysis.MetaType)}.ToImmutableArray());
        	                this.Begin(__annot2, node.QualifierList[qualifierListIndex]);
        	                try
        	                {
        	                    this.Visit(node.QualifierList[qualifierListIndex]);
        	                }
        	                finally
        	                {
        	                    this.End(__annot2);
        	                }
        	            }
        	            finally
        	            {
        	                this.End(__annot3);
        	            }
        	            // this.VisitToken(node.QualifierList.GetSeparator(qualifierListIndex));
        	        }
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot4);
        	}
        }

        public virtual void VisitPEof(PEofSyntax node)
        {
        	var __annot0 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.PEof));
        	this.Begin(__annot0, node);
        	try
        	{
        	        
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        }

        public virtual void VisitPKeyword(PKeywordSyntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.PKeyword));
        	this.Begin(__annot2, node);
        	try
        	{
        	    if (node.Text.GetCompilerKind() != CompilerSyntaxKind.None)
        	    {
        	        var __annot1 = new PropertyBinder(name: "Text");
        	        this.Begin(__annot1, node.Text);
        	        try
        	        {
        	            var __annot0 = new ValueBinder(type: typeof(string));
        	            this.Begin(__annot0, node.Text);
        	            try
        	            {
        	                // this.VisitToken(node.Text);
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
        	        // this.VisitToken(node.Text);
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot2);
        	}
        }

        public virtual void VisitPBlock(PBlockSyntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.PBlock));
        	this.Begin(__annot2, node);
        	try
        	{
        	    var pAlternativeListList = node.PAlternativeList;
        	    for (var pAlternativeListIndex = 0; pAlternativeListIndex < pAlternativeListList.Count; ++pAlternativeListIndex)
        	    {
        	        if (pAlternativeListIndex == 0)
        	        {
        	            var __annot0 = new PropertyBinder(name: "Alternatives");
        	            this.Begin(__annot0, node.PAlternativeList[pAlternativeListIndex]);
        	            try
        	            {
        	                this.Visit(node.PAlternativeList[pAlternativeListIndex]);
        	            }
        	            finally
        	            {
        	                this.End(__annot0);
        	            }
        	        }
        	        else
        	        {
        	            var __annot1 = new PropertyBinder(name: "Alternatives");
        	            this.Begin(__annot1, node.PAlternativeList[pAlternativeListIndex]);
        	            try
        	            {
        	                this.Visit(node.PAlternativeList[pAlternativeListIndex]);
        	            }
        	            finally
        	            {
        	                this.End(__annot1);
        	            }
        	            // this.VisitToken(node.PAlternativeList.GetSeparator(pAlternativeListIndex));
        	        }
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot2);
        	}
        }

        public virtual void VisitLAlternative(LAlternativeSyntax node)
        {
        	var __annot1 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.LAlternative));
        	this.Begin(__annot1, node);
        	try
        	{
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
        	        
        	}
        	finally
        	{
        	    this.End(__annot1);
        	}
        }

        public virtual void VisitLElement(LElementSyntax node)
        {
        	var __annot14 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.LElement));
        	this.Begin(__annot14, node);
        	try
        	{
        	    if (node.IsNegated.GetCompilerKind() != CompilerSyntaxKind.None)
        	    {
        	        var __annot0 = new PropertyBinder(name: "IsNegated", value: true);
        	        this.Begin(__annot0, node.IsNegated);
        	        try
        	        {
        	            // this.VisitToken(node.IsNegated);
        	        }
        	        finally
        	        {
        	            this.End(__annot0);
        	        }
        	    }
        	    else
        	    {
        	        // this.VisitToken(node.IsNegated);
        	    }
        	    var __annot1 = new PropertyBinder(name: "Value");
        	    this.Begin(__annot1, node.Value);
        	    try
        	    {
        	        this.Visit(node.Value);
        	    }
        	    finally
        	    {
        	        this.End(__annot1);
        	    }
        	    switch (node.Multiplicity.GetCompilerKind())
        	    {
        	    case CompilerSyntaxKind.TQuestion:
        	        var __annot3 = new PropertyBinder(name: "Multiplicity");
        	        this.Begin(__annot3, node.Multiplicity);
        	        try
        	        {
        	            var __annot2 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity.ZeroOrOne);
        	            this.Begin(__annot2, node.Multiplicity);
        	            try
        	            {
        	                // this.VisitToken(node.Multiplicity);
        	            }
        	            finally
        	            {
        	                this.End(__annot2);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot3);
        	        }
        	        break;
        	    case CompilerSyntaxKind.TAsterisk:
        	        var __annot5 = new PropertyBinder(name: "Multiplicity");
        	        this.Begin(__annot5, node.Multiplicity);
        	        try
        	        {
        	            var __annot4 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity.ZeroOrMore);
        	            this.Begin(__annot4, node.Multiplicity);
        	            try
        	            {
        	                // this.VisitToken(node.Multiplicity);
        	            }
        	            finally
        	            {
        	                this.End(__annot4);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot5);
        	        }
        	        break;
        	    case CompilerSyntaxKind.TPlus:
        	        var __annot7 = new PropertyBinder(name: "Multiplicity");
        	        this.Begin(__annot7, node.Multiplicity);
        	        try
        	        {
        	            var __annot6 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity.OneOrMore);
        	            this.Begin(__annot6, node.Multiplicity);
        	            try
        	            {
        	                // this.VisitToken(node.Multiplicity);
        	            }
        	            finally
        	            {
        	                this.End(__annot6);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot7);
        	        }
        	        break;
        	    case CompilerSyntaxKind.TQuestionQuestion:
        	        var __annot9 = new PropertyBinder(name: "Multiplicity");
        	        this.Begin(__annot9, node.Multiplicity);
        	        try
        	        {
        	            var __annot8 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity.NonGreedyZeroOrOne);
        	            this.Begin(__annot8, node.Multiplicity);
        	            try
        	            {
        	                // this.VisitToken(node.Multiplicity);
        	            }
        	            finally
        	            {
        	                this.End(__annot8);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot9);
        	        }
        	        break;
        	    case CompilerSyntaxKind.TAsteriskQuestion:
        	        var __annot11 = new PropertyBinder(name: "Multiplicity");
        	        this.Begin(__annot11, node.Multiplicity);
        	        try
        	        {
        	            var __annot10 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity.NonGreedyZeroOrMore);
        	            this.Begin(__annot10, node.Multiplicity);
        	            try
        	            {
        	                // this.VisitToken(node.Multiplicity);
        	            }
        	            finally
        	            {
        	                this.End(__annot10);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot11);
        	        }
        	        break;
        	    case CompilerSyntaxKind.TPlusQuestion:
        	        var __annot13 = new PropertyBinder(name: "Multiplicity");
        	        this.Begin(__annot13, node.Multiplicity);
        	        try
        	        {
        	            var __annot12 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Multiplicity.NonGreedyOneOrMore);
        	            this.Begin(__annot12, node.Multiplicity);
        	            try
        	            {
        	                // this.VisitToken(node.Multiplicity);
        	            }
        	            finally
        	            {
        	                this.End(__annot12);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot13);
        	        }
        	        break;
        	    default:
        	        // this.VisitToken(node.Multiplicity);
        	        break;
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot14);
        	}
        }

        public virtual void VisitLReference(LReferenceSyntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.LReference));
        	this.Begin(__annot2, node);
        	try
        	{
        	    var __annot1 = new PropertyBinder(name: "Rule");
        	    this.Begin(__annot1, node.Rule);
        	    try
        	    {
        	        var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.LexerRule)}.ToImmutableArray());
        	        this.Begin(__annot0, node.Rule);
        	        try
        	        {
        	            this.Visit(node.Rule);
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

        public virtual void VisitLFixed(LFixedSyntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.LFixed));
        	this.Begin(__annot2, node);
        	try
        	{
        	    if (node.Text.GetCompilerKind() != CompilerSyntaxKind.None)
        	    {
        	        var __annot1 = new PropertyBinder(name: "Text");
        	        this.Begin(__annot1, node.Text);
        	        try
        	        {
        	            var __annot0 = new ValueBinder(type: typeof(string));
        	            this.Begin(__annot0, node.Text);
        	            try
        	            {
        	                // this.VisitToken(node.Text);
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
        	        // this.VisitToken(node.Text);
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot2);
        	}
        }

        public virtual void VisitLWildCard(LWildCardSyntax node)
        {
        	var __annot0 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.LWildCard));
        	this.Begin(__annot0, node);
        	try
        	{
        	        
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        }

        public virtual void VisitLRange(LRangeSyntax node)
        {
        	var __annot4 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.LRange));
        	this.Begin(__annot4, node);
        	try
        	{
        	    if (node.StartChar.GetCompilerKind() != CompilerSyntaxKind.None)
        	    {
        	        var __annot1 = new PropertyBinder(name: "StartChar");
        	        this.Begin(__annot1, node.StartChar);
        	        try
        	        {
        	            var __annot0 = new ValueBinder(type: typeof(string));
        	            this.Begin(__annot0, node.StartChar);
        	            try
        	            {
        	                // this.VisitToken(node.StartChar);
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
        	        // this.VisitToken(node.StartChar);
        	    }
        	    if (node.EndChar.GetCompilerKind() != CompilerSyntaxKind.None)
        	    {
        	        var __annot3 = new PropertyBinder(name: "EndChar");
        	        this.Begin(__annot3, node.EndChar);
        	        try
        	        {
        	            var __annot2 = new ValueBinder(type: typeof(string));
        	            this.Begin(__annot2, node.EndChar);
        	            try
        	            {
        	                // this.VisitToken(node.EndChar);
        	            }
        	            finally
        	            {
        	                this.End(__annot2);
        	            }
        	        }
        	        finally
        	        {
        	            this.End(__annot3);
        	        }
        	    }
        	    else
        	    {
        	        // this.VisitToken(node.EndChar);
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot4);
        	}
        }

        public virtual void VisitLBlock(LBlockSyntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.LBlock));
        	this.Begin(__annot2, node);
        	try
        	{
        	    var lAlternativeListList = node.LAlternativeList;
        	    for (var lAlternativeListIndex = 0; lAlternativeListIndex < lAlternativeListList.Count; ++lAlternativeListIndex)
        	    {
        	        if (lAlternativeListIndex == 0)
        	        {
        	            var __annot0 = new PropertyBinder(name: "Alternatives");
        	            this.Begin(__annot0, node.LAlternativeList[lAlternativeListIndex]);
        	            try
        	            {
        	                this.Visit(node.LAlternativeList[lAlternativeListIndex]);
        	            }
        	            finally
        	            {
        	                this.End(__annot0);
        	            }
        	        }
        	        else
        	        {
        	            var __annot1 = new PropertyBinder(name: "Alternatives");
        	            this.Begin(__annot1, node.LAlternativeList[lAlternativeListIndex]);
        	            try
        	            {
        	                this.Visit(node.LAlternativeList[lAlternativeListIndex]);
        	            }
        	            finally
        	            {
        	                this.End(__annot1);
        	            }
        	            // this.VisitToken(node.LAlternativeList.GetSeparator(lAlternativeListIndex));
        	        }
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot2);
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

        public virtual void VisitAnnotation(AnnotationSyntax node)
        {
        	var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.CodeAnalysis.Binding.Binder), typeof(global::MetaDslx.CodeAnalysis.Syntax.TokenKind)}.ToImmutableArray(), suffixes: new string[] {"Binder", "TokenKind"}.ToImmutableArray());
        	this.Begin(__annot0, node.Type);
        	try
        	{
        	    this.Visit(node.Type);
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        	this.Visit(node.AnnotationArguments);
        	    
        }

        public virtual void VisitAnnotationArguments(AnnotationArgumentsSyntax node)
        {
        	var annotationArgumentListList = node.AnnotationArgumentList;
        	for (var annotationArgumentListIndex = 0; annotationArgumentListIndex < annotationArgumentListList.Count; ++annotationArgumentListIndex)
        	{
        	    if (annotationArgumentListIndex == 0)
        	    {
        	        this.Visit(node.AnnotationArgumentList[annotationArgumentListIndex]);
        	    }
        	    else
        	    {
        	        this.Visit(node.AnnotationArgumentList[annotationArgumentListIndex]);
        	        // this.VisitToken(node.AnnotationArgumentList.GetSeparator(annotationArgumentListIndex));
        	    }
        	}
        	    
        }

        public virtual void VisitAnnotationArgument(AnnotationArgumentSyntax node)
        {
        	var __annot1 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaCompiler.Model.AnnotationArgument));
        	this.Begin(__annot1, node);
        	try
        	{
        	    this.Visit(node.AnnotationArgumentBlock1);
        	    var __annot0 = new PropertyBinder(name: "Value");
        	    this.Begin(__annot0, node.Value);
        	    try
        	    {
        	        this.Visit(node.Value);
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

        public virtual void VisitUsingBlock1Alt1(UsingBlock1Alt1Syntax node)
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

        public virtual void VisitUsingBlock1Alt2(UsingBlock1Alt2Syntax node)
        {
        	var __annot1 = new PropertyBinder(name: "MetaModelSymbols");
        	this.Begin(__annot1, node.MetaModelSymbols);
        	try
        	{
        	    var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclaredSymbol)}.ToImmutableArray());
        	    this.Begin(__annot0, node.MetaModelSymbols);
        	    try
        	    {
        	        this.Visit(node.MetaModelSymbols);
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

        public virtual void VisitGrammarBlock1(GrammarBlock1Syntax node)
        {
        	var __annot1 = new ScopeBinder();
        	this.Begin(__annot1, node);
        	try
        	{
        	    var rulesList = node.Rules;
        	    for (var rulesIndex = 0; rulesIndex < rulesList.Count; ++rulesIndex)
        	    {
        	        var __annot0 = new PropertyBinder(name: "Rules");
        	        this.Begin(__annot0, node.Rules[rulesIndex]);
        	        try
        	        {
        	            this.Visit(node.Rules[rulesIndex]);
        	        }
        	        finally
        	        {
        	            this.End(__annot0);
        	        }
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot1);
        	}
        }

        public virtual void VisitParserRuleBlock1Alt1(ParserRuleBlock1Alt1Syntax node)
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
        	var __annot1 = new PropertyBinder(name: "Name");
        	this.Begin(__annot1, node.Name);
        	try
        	{
        	    this.Visit(node.Name);
        	}
        	finally
        	{
        	    this.End(__annot1);
        	}
        	    
        }

        public virtual void VisitParserRuleBlock1Alt2(ParserRuleBlock1Alt2Syntax node)
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

        public virtual void VisitParserRuleBlock1Alt3(ParserRuleBlock1Alt3Syntax node)
        {
        	var __annot0 = new PropertyBinder(name: "Name");
        	this.Begin(__annot0, node.Name);
        	try
        	{
        	    this.Visit(node.Name);
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        	var __annot2 = new PropertyBinder(name: "ReturnType");
        	this.Begin(__annot2, node.ReturnType);
        	try
        	{
        	    var __annot1 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.CodeAnalysis.MetaType)}.ToImmutableArray());
        	    this.Begin(__annot1, node.ReturnType);
        	    try
        	    {
        	        this.Visit(node.ReturnType);
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

        public virtual void VisitPAlternativeBlock1(PAlternativeBlock1Syntax node)
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

        public virtual void VisitPAlternativeBlock2(PAlternativeBlock2Syntax node)
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

        public virtual void VisitPElementBlock1(PElementBlock1Syntax node)
        {
        	var nameAnnotationsList = node.NameAnnotations;
        	for (var nameAnnotationsIndex = 0; nameAnnotationsIndex < nameAnnotationsList.Count; ++nameAnnotationsIndex)
        	{
        	    var __annot0 = new PropertyBinder(name: "NameAnnotations");
        	    this.Begin(__annot0, node.NameAnnotations[nameAnnotationsIndex]);
        	    try
        	    {
        	        this.Visit(node.NameAnnotations[nameAnnotationsIndex]);
        	    }
        	    finally
        	    {
        	        this.End(__annot0);
        	    }
        	}
        	var __annot1 = new PropertyBinder(name: "Name");
        	this.Begin(__annot1, node.Name);
        	try
        	{
        	    this.Visit(node.Name);
        	}
        	finally
        	{
        	    this.End(__annot1);
        	}
        	switch (node.Assignment.GetCompilerKind())
        	{
        	case CompilerSyntaxKind.TEq:
        	    var __annot3 = new PropertyBinder(name: "Assignment");
        	    this.Begin(__annot3, node.Assignment);
        	    try
        	    {
        	        var __annot2 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment.Assign);
        	        this.Begin(__annot2, node.Assignment);
        	        try
        	        {
        	            // this.VisitToken(node.Assignment);
        	        }
        	        finally
        	        {
        	            this.End(__annot2);
        	        }
        	    }
        	    finally
        	    {
        	        this.End(__annot3);
        	    }
        	    break;
        	case CompilerSyntaxKind.TQuestionEq:
        	    var __annot5 = new PropertyBinder(name: "Assignment");
        	    this.Begin(__annot5, node.Assignment);
        	    try
        	    {
        	        var __annot4 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment.QuestionAssign);
        	        this.Begin(__annot4, node.Assignment);
        	        try
        	        {
        	            // this.VisitToken(node.Assignment);
        	        }
        	        finally
        	        {
        	            this.End(__annot4);
        	        }
        	    }
        	    finally
        	    {
        	        this.End(__annot5);
        	    }
        	    break;
        	case CompilerSyntaxKind.TExclEq:
        	    var __annot7 = new PropertyBinder(name: "Assignment");
        	    this.Begin(__annot7, node.Assignment);
        	    try
        	    {
        	        var __annot6 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment.NegatedAssign);
        	        this.Begin(__annot6, node.Assignment);
        	        try
        	        {
        	            // this.VisitToken(node.Assignment);
        	        }
        	        finally
        	        {
        	            this.End(__annot6);
        	        }
        	    }
        	    finally
        	    {
        	        this.End(__annot7);
        	    }
        	    break;
        	case CompilerSyntaxKind.TPlusEq:
        	    var __annot9 = new PropertyBinder(name: "Assignment");
        	    this.Begin(__annot9, node.Assignment);
        	    try
        	    {
        	        var __annot8 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaCompiler.Model.Assignment.PlusAssign);
        	        this.Begin(__annot8, node.Assignment);
        	        try
        	        {
        	            // this.VisitToken(node.Assignment);
        	        }
        	        finally
        	        {
        	            this.End(__annot8);
        	        }
        	    }
        	    finally
        	    {
        	        this.End(__annot9);
        	    }
        	    break;
        	default:
        	    // this.VisitToken(node.Assignment);
        	    break;
        	}
        	    
        }

        public virtual void VisitPReferenceAlt3Block1(PReferenceAlt3Block1Syntax node)
        {
        	if (node.TComma.GetCompilerKind() != CompilerSyntaxKind.None)
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	else
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	var __annot1 = new PropertyBinder(name: "ReferencedTypes");
        	this.Begin(__annot1, node.ReferencedTypes);
        	try
        	{
        	    var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.CodeAnalysis.MetaType)}.ToImmutableArray());
        	    this.Begin(__annot0, node.ReferencedTypes);
        	    try
        	    {
        	        this.Visit(node.ReferencedTypes);
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

        public virtual void VisitPBlockBlock1(PBlockBlock1Syntax node)
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

        public virtual void VisitLexerRuleBlock1Alt1(LexerRuleBlock1Alt1Syntax node)
        {
        	var __annot0 = new PropertyBinder(name: "Name");
        	this.Begin(__annot0, node.Name);
        	try
        	{
        	    this.Visit(node.Name);
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        	this.Visit(node.LexerRuleBlock1Alt1Block1);
        	    
        }

        public virtual void VisitLexerRuleBlock1Alt2(LexerRuleBlock1Alt2Syntax node)
        {
        	if (node.IsHidden.GetCompilerKind() != CompilerSyntaxKind.None)
        	{
        	    var __annot0 = new PropertyBinder(name: "IsHidden", value: true);
        	    this.Begin(__annot0, node.IsHidden);
        	    try
        	    {
        	        // this.VisitToken(node.IsHidden);
        	    }
        	    finally
        	    {
        	        this.End(__annot0);
        	    }
        	}
        	else
        	{
        	    // this.VisitToken(node.IsHidden);
        	}
        	var __annot1 = new PropertyBinder(name: "Name");
        	this.Begin(__annot1, node.Name);
        	try
        	{
        	    this.Visit(node.Name);
        	}
        	finally
        	{
        	    this.End(__annot1);
        	}
        	    
        }

        public virtual void VisitLexerRuleBlock1Alt3(LexerRuleBlock1Alt3Syntax node)
        {
        	if (node.IsFragment.GetCompilerKind() != CompilerSyntaxKind.None)
        	{
        	    var __annot0 = new PropertyBinder(name: "IsFragment", value: true);
        	    this.Begin(__annot0, node.IsFragment);
        	    try
        	    {
        	        // this.VisitToken(node.IsFragment);
        	    }
        	    finally
        	    {
        	        this.End(__annot0);
        	    }
        	}
        	else
        	{
        	    // this.VisitToken(node.IsFragment);
        	}
        	var __annot1 = new PropertyBinder(name: "Name");
        	this.Begin(__annot1, node.Name);
        	try
        	{
        	    this.Visit(node.Name);
        	}
        	finally
        	{
        	    this.End(__annot1);
        	}
        	    
        }

        public virtual void VisitLexerRuleBlock2(LexerRuleBlock2Syntax node)
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

        public virtual void VisitLBlockBlock1(LBlockBlock1Syntax node)
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

        public virtual void VisitAnnotationArgumentsBlock1(AnnotationArgumentsBlock1Syntax node)
        {
        	if (node.TComma.GetCompilerKind() != CompilerSyntaxKind.None)
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	else
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	this.Visit(node.Arguments);
        	    
        }

        public virtual void VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node)
        {
        	var __annot0 = new PropertyBinder(name: "Name");
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

        public virtual void VisitLexerRuleBlock1Alt1Block1(LexerRuleBlock1Alt1Block1Syntax node)
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

		public virtual void VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node)
		{
		}
    }
}
