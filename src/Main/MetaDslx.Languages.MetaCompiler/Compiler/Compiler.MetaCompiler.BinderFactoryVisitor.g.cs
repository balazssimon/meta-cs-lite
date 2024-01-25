using System;
using System.Collections.Immutable;
using MetaDslx.CodeAnalysis;

#nullable enable

namespace MetaDslx.Languages.MetaCompiler.Compiler.Binding
{
    using global::MetaDslx.Languages.MetaCompiler.Compiler.Syntax;

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
        var __rootAnnot = new global::MetaDslx.CodeAnalysis.Binding.RootBinder(node.SyntaxTree, type: typeof(MetaDslx.Languages.MetaCompiler.Model.Namespace));
        this.Begin(__rootAnnot, node);
        try
        {
            var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Namespace));
            this.Begin(__annot3, node);
            try
            {
                var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Name");
                this.Begin(__annot2, node.Qualifier.Node);
                try
                {
                    var __annot1 = new MetaDslx.CodeAnalysis.Binding.NameBinder(qualifierProperty: "Declarations");
                    this.Begin(__annot1, node.Qualifier.Node);
                    try
                    {
                        var __annot0 = new MetaDslx.CodeAnalysis.Binding.QualifierBinder();
                        this.Begin(__annot0, node.Qualifier.Node);
                        try
                        {
                            var qualifierList = node.Qualifier;
                            for (var qualifierIndex = 0; qualifierIndex < qualifierList.Count; ++qualifierIndex)
                            {
                                bool __itemHandled = false;
                                bool __sepHandled = false;
                                if (qualifierIndex == 0)
                                {
                                    this.Visit(node.Qualifier[qualifierIndex]);
                                    __itemHandled = true;
                                }
                                if (!__itemHandled && qualifierIndex < node.Qualifier.Count)
                                {
                                    this.Visit(node.Qualifier[qualifierIndex]);
                                }
                                if (!__sepHandled && qualifierIndex < node.Qualifier.SeparatorCount)
                                {
                                    //this.VisitToken(node.Qualifier.GetSeparator(qualifierIndex));
                                }
                            }
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
                var usingListList = node.UsingList;
                for (var usingListIndex = 0; usingListIndex < usingListList.Count; ++usingListIndex)
                {
                    this.Visit(node.UsingList[usingListIndex]);
                }
                this.Visit(node.Declarations);
                    
            }
            finally
            {
                this.End(__annot3);
            }
        }
        finally
        {
            this.End(__rootAnnot);
        }
    }
    else
    {
    	var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Namespace));
    	this.Begin(__annot3, node);
    	try
    	{
    	    var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Name");
    	    this.Begin(__annot2, node.Qualifier.Node);
    	    try
    	    {
    	        var __annot1 = new MetaDslx.CodeAnalysis.Binding.NameBinder(qualifierProperty: "Declarations");
    	        this.Begin(__annot1, node.Qualifier.Node);
    	        try
    	        {
    	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.QualifierBinder();
    	            this.Begin(__annot0, node.Qualifier.Node);
    	            try
    	            {
    	                var qualifierList = node.Qualifier;
    	                for (var qualifierIndex = 0; qualifierIndex < qualifierList.Count; ++qualifierIndex)
    	                {
    	                    bool __itemHandled = false;
    	                    bool __sepHandled = false;
    	                    if (qualifierIndex == 0)
    	                    {
    	                        this.Visit(node.Qualifier[qualifierIndex]);
    	                        __itemHandled = true;
    	                    }
    	                    if (!__itemHandled && qualifierIndex < node.Qualifier.Count)
    	                    {
    	                        this.Visit(node.Qualifier[qualifierIndex]);
    	                    }
    	                    if (!__sepHandled && qualifierIndex < node.Qualifier.SeparatorCount)
    	                    {
    	                        //this.VisitToken(node.Qualifier.GetSeparator(qualifierIndex));
    	                    }
    	                }
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
    	    var usingListList = node.UsingList;
    	    for (var usingListIndex = 0; usingListIndex < usingListList.Count; ++usingListIndex)
    	    {
    	        this.Visit(node.UsingList[usingListIndex]);
    	    }
    	    this.Visit(node.Declarations);
    	        
    	}
    	finally
    	{
    	    this.End(__annot3);
    	}
    }
}

public virtual void VisitUsing(UsingSyntax node)
{
	var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.CodeAnalysis.Symbols.ImportSymbol));
	this.Begin(__annot3, node);
	try
	{
	    var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Namespaces");
	    this.Begin(__annot2, node.Qualifier.Node);
	    try
	    {
	        var __annot1 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol)));
	        this.Begin(__annot1, node.Qualifier.Node);
	        try
	        {
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.QualifierBinder();
	            this.Begin(__annot0, node.Qualifier.Node);
	            try
	            {
	                var qualifierList = node.Qualifier;
	                for (var qualifierIndex = 0; qualifierIndex < qualifierList.Count; ++qualifierIndex)
	                {
	                    bool __itemHandled = false;
	                    bool __sepHandled = false;
	                    if (qualifierIndex == 0)
	                    {
	                        this.Visit(node.Qualifier[qualifierIndex]);
	                        __itemHandled = true;
	                    }
	                    if (!__itemHandled && qualifierIndex < node.Qualifier.Count)
	                    {
	                        this.Visit(node.Qualifier[qualifierIndex]);
	                    }
	                    if (!__sepHandled && qualifierIndex < node.Qualifier.SeparatorCount)
	                    {
	                        //this.VisitToken(node.Qualifier.GetSeparator(qualifierIndex));
	                    }
	                }
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
	finally
	{
	    this.End(__annot3);
	}
}

public virtual void VisitDeclarations(DeclarationsSyntax node)
{
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.ScopeBinder();
	this.Begin(__annot2, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Declarations");
	    this.Begin(__annot0, node.Declarations1);
	    try
	    {
	        this.Visit(node.Declarations1);
	    }
	    finally
	    {
	        this.End(__annot0);
	    }
	    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Declarations");
	    this.Begin(__annot1, node.Declarations2.Node);
	    try
	    {
	        var declarations2List = node.Declarations2;
	        for (var declarations2Index = 0; declarations2Index < declarations2List.Count; ++declarations2Index)
	        {
	            this.Visit(node.Declarations2[declarations2Index]);
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

public virtual void VisitLanguageDeclaration(LanguageDeclarationSyntax node)
{
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Language));
	this.Begin(__annot2, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Name");
	    this.Begin(__annot0, node.Name);
	    try
	    {
	        this.Visit(node.Name);
	    }
	    finally
	    {
	        this.End(__annot0);
	    }
	    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Grammar");
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
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Grammar));
	this.Begin(__annot2, node);
	try
	{
	    var __annot1 = new MetaDslx.CodeAnalysis.Binding.ScopeBinder();
	    this.Begin(__annot1, node);
	    try
	    {
	        var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "GrammarRules");
	        this.Begin(__annot0, node.GrammarRules.Node);
	        try
	        {
	            var grammarRulesList = node.GrammarRules;
	            for (var grammarRulesIndex = 0; grammarRulesIndex < grammarRulesList.Count; ++grammarRulesIndex)
	            {
	                this.Visit(node.GrammarRules[grammarRulesIndex]);
	            }
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

public virtual void VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node)
{
	this.Visit(node.Rule);
	    
}

public virtual void VisitBlock(BlockSyntax node)
{
	var __annot4 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Block));
	this.Begin(__annot4, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Annotations");
	    this.Begin(__annot0, node.Annotations1.Node);
	    try
	    {
	        var annotations1List = node.Annotations1;
	        for (var annotations1Index = 0; annotations1Index < annotations1List.Count; ++annotations1Index)
	        {
	            this.Visit(node.Annotations1[annotations1Index]);
	        }
	    }
	    finally
	    {
	        this.End(__annot0);
	    }
	    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Name");
	    this.Begin(__annot1, node.Name);
	    try
	    {
	        this.Visit(node.Name);
	    }
	    finally
	    {
	        this.End(__annot1);
	    }
	    if (node.Block != null)
	    {
	        this.Visit(node.Block);
	    }
	    var alternativesList = node.Alternatives;
	    for (var alternativesIndex = 0; alternativesIndex < alternativesList.Count; ++alternativesIndex)
	    {
	        bool __itemHandled = false;
	        bool __sepHandled = false;
	        if (alternativesIndex == 0)
	        {
	            var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
	            this.Begin(__annot2, node.Alternatives[alternativesIndex]);
	            try
	            {
	                this.Visit(node.Alternatives[alternativesIndex]);
	            }
	            finally
	            {
	                this.End(__annot2);
	            }
	            __itemHandled = true;
	        }
	        if (!__itemHandled && alternativesIndex < node.Alternatives.Count)
	        {
	            var __annot3 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
	            this.Begin(__annot3, node.Alternatives[alternativesIndex]);
	            try
	            {
	                this.Visit(node.Alternatives[alternativesIndex]);
	            }
	            finally
	            {
	                this.End(__annot3);
	            }
	        }
	        if (!__sepHandled && alternativesIndex < node.Alternatives.SeparatorCount)
	        {
	            //this.VisitToken(node.Alternatives.GetSeparator(alternativesIndex));
	        }
	    }
	        
	}
	finally
	{
	    this.End(__annot4);
	}
}

public virtual void VisitToken(TokenSyntax node)
{
	var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Token));
	this.Begin(__annot3, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Annotations");
	    this.Begin(__annot0, node.Annotations1.Node);
	    try
	    {
	        var annotations1List = node.Annotations1;
	        for (var annotations1Index = 0; annotations1Index < annotations1List.Count; ++annotations1Index)
	        {
	            this.Visit(node.Annotations1[annotations1Index]);
	        }
	    }
	    finally
	    {
	        this.End(__annot0);
	    }
	    this.Visit(node.Block);
	    var alternativesList = node.Alternatives;
	    for (var alternativesIndex = 0; alternativesIndex < alternativesList.Count; ++alternativesIndex)
	    {
	        bool __itemHandled = false;
	        bool __sepHandled = false;
	        if (alternativesIndex == 0)
	        {
	            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
	            this.Begin(__annot1, node.Alternatives[alternativesIndex]);
	            try
	            {
	                this.Visit(node.Alternatives[alternativesIndex]);
	            }
	            finally
	            {
	                this.End(__annot1);
	            }
	            __itemHandled = true;
	        }
	        if (!__itemHandled && alternativesIndex < node.Alternatives.Count)
	        {
	            var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
	            this.Begin(__annot2, node.Alternatives[alternativesIndex]);
	            try
	            {
	                this.Visit(node.Alternatives[alternativesIndex]);
	            }
	            finally
	            {
	                this.End(__annot2);
	            }
	        }
	        if (!__sepHandled && alternativesIndex < node.Alternatives.SeparatorCount)
	        {
	            //this.VisitToken(node.Alternatives.GetSeparator(alternativesIndex));
	        }
	    }
	        
	}
	finally
	{
	    this.End(__annot3);
	}
}

public virtual void VisitFragment(FragmentSyntax node)
{
	var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Fragment));
	this.Begin(__annot3, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Name");
	    this.Begin(__annot0, node.Name);
	    try
	    {
	        this.Visit(node.Name);
	    }
	    finally
	    {
	        this.End(__annot0);
	    }
	    var alternativesList = node.Alternatives;
	    for (var alternativesIndex = 0; alternativesIndex < alternativesList.Count; ++alternativesIndex)
	    {
	        bool __itemHandled = false;
	        bool __sepHandled = false;
	        if (alternativesIndex == 0)
	        {
	            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
	            this.Begin(__annot1, node.Alternatives[alternativesIndex]);
	            try
	            {
	                this.Visit(node.Alternatives[alternativesIndex]);
	            }
	            finally
	            {
	                this.End(__annot1);
	            }
	            __itemHandled = true;
	        }
	        if (!__itemHandled && alternativesIndex < node.Alternatives.Count)
	        {
	            var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
	            this.Begin(__annot2, node.Alternatives[alternativesIndex]);
	            try
	            {
	                this.Visit(node.Alternatives[alternativesIndex]);
	            }
	            finally
	            {
	                this.End(__annot2);
	            }
	        }
	        if (!__sepHandled && alternativesIndex < node.Alternatives.SeparatorCount)
	        {
	            //this.VisitToken(node.Alternatives.GetSeparator(alternativesIndex));
	        }
	    }
	        
	}
	finally
	{
	    this.End(__annot3);
	}
}

public virtual void VisitRule(RuleSyntax node)
{
	var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Rule));
	this.Begin(__annot3, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Annotations");
	    this.Begin(__annot0, node.Annotations1.Node);
	    try
	    {
	        var annotations1List = node.Annotations1;
	        for (var annotations1Index = 0; annotations1Index < annotations1List.Count; ++annotations1Index)
	        {
	            this.Visit(node.Annotations1[annotations1Index]);
	        }
	    }
	    finally
	    {
	        this.End(__annot0);
	    }
	    this.Visit(node.Block);
	    var alternativesList = node.Alternatives;
	    for (var alternativesIndex = 0; alternativesIndex < alternativesList.Count; ++alternativesIndex)
	    {
	        bool __itemHandled = false;
	        bool __sepHandled = false;
	        if (alternativesIndex == 0)
	        {
	            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
	            this.Begin(__annot1, node.Alternatives[alternativesIndex]);
	            try
	            {
	                this.Visit(node.Alternatives[alternativesIndex]);
	            }
	            finally
	            {
	                this.End(__annot1);
	            }
	            __itemHandled = true;
	        }
	        if (!__itemHandled && alternativesIndex < node.Alternatives.Count)
	        {
	            var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
	            this.Begin(__annot2, node.Alternatives[alternativesIndex]);
	            try
	            {
	                this.Visit(node.Alternatives[alternativesIndex]);
	            }
	            finally
	            {
	                this.End(__annot2);
	            }
	        }
	        if (!__sepHandled && alternativesIndex < node.Alternatives.SeparatorCount)
	        {
	            //this.VisitToken(node.Alternatives.GetSeparator(alternativesIndex));
	        }
	    }
	        
	}
	finally
	{
	    this.End(__annot3);
	}
}

public virtual void VisitAlternative(AlternativeSyntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Alternative));
	this.Begin(__annot1, node);
	try
	{
	    if (node.Block1 != null)
	    {
	        this.Visit(node.Block1);
	    }
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Elements");
	    this.Begin(__annot0, node.Elements.Node);
	    try
	    {
	        var elementsList = node.Elements;
	        for (var elementsIndex = 0; elementsIndex < elementsList.Count; ++elementsIndex)
	        {
	            this.Visit(node.Elements[elementsIndex]);
	        }
	    }
	    finally
	    {
	        this.End(__annot0);
	    }
	    if (node.Block2 != null)
	    {
	        this.Visit(node.Block2);
	    }
	        
	}
	finally
	{
	    this.End(__annot1);
	}
}

public virtual void VisitElement(ElementSyntax node)
{
	var __annot9 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Element));
	this.Begin(__annot9, node);
	try
	{
	    if (node.Block != null)
	    {
	        this.Visit(node.Block);
	    }
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ValueAnnotations");
	    this.Begin(__annot0, node.ValueAnnotations.Node);
	    try
	    {
	        var valueAnnotationsList = node.ValueAnnotations;
	        for (var valueAnnotationsIndex = 0; valueAnnotationsIndex < valueAnnotationsList.Count; ++valueAnnotationsIndex)
	        {
	            this.Visit(node.ValueAnnotations[valueAnnotationsIndex]);
	        }
	    }
	    finally
	    {
	        this.End(__annot0);
	    }
	    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Value");
	    this.Begin(__annot1, node.Value);
	    try
	    {
	        this.Visit(node.Value);
	    }
	    finally
	    {
	        this.End(__annot1);
	    }
	    if (node.Multiplicity.GetCompilerKind() != CompilerSyntaxKind.None)
	    {
	        if (node.Multiplicity.GetCompilerKind() != CompilerSyntaxKind.None)
	        {
	            var __annot8 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Multiplicity");
	            this.Begin(__annot8, node.Multiplicity);
	            try
	            {
	                switch (node.Multiplicity.GetCompilerKind())
	                {
	                    case CompilerSyntaxKind.TQuestion:
	                        var __annot2 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.ZeroOrOne);
	                        this.Begin(__annot2, node.Multiplicity);
	                        try
	                        {
	                            //this.VisitToken(node.Multiplicity);
	                        }
	                        finally
	                        {
	                            this.End(__annot2);
	                        }
	                        break;
	                    case CompilerSyntaxKind.TAsterisk:
	                        var __annot3 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.ZeroOrMore);
	                        this.Begin(__annot3, node.Multiplicity);
	                        try
	                        {
	                            //this.VisitToken(node.Multiplicity);
	                        }
	                        finally
	                        {
	                            this.End(__annot3);
	                        }
	                        break;
	                    case CompilerSyntaxKind.TPlus:
	                        var __annot4 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.OneOrMore);
	                        this.Begin(__annot4, node.Multiplicity);
	                        try
	                        {
	                            //this.VisitToken(node.Multiplicity);
	                        }
	                        finally
	                        {
	                            this.End(__annot4);
	                        }
	                        break;
	                    case CompilerSyntaxKind.TQuestionQuestion:
	                        var __annot5 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.NonGreedyZeroOrOne);
	                        this.Begin(__annot5, node.Multiplicity);
	                        try
	                        {
	                            //this.VisitToken(node.Multiplicity);
	                        }
	                        finally
	                        {
	                            this.End(__annot5);
	                        }
	                        break;
	                    case CompilerSyntaxKind.TAsteriskQuestion:
	                        var __annot6 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.NonGreedyZeroOrMore);
	                        this.Begin(__annot6, node.Multiplicity);
	                        try
	                        {
	                            //this.VisitToken(node.Multiplicity);
	                        }
	                        finally
	                        {
	                            this.End(__annot6);
	                        }
	                        break;
	                    case CompilerSyntaxKind.TPlusQuestion:
	                        var __annot7 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.NonGreedyOneOrMore);
	                        this.Begin(__annot7, node.Multiplicity);
	                        try
	                        {
	                            //this.VisitToken(node.Multiplicity);
	                        }
	                        finally
	                        {
	                            this.End(__annot7);
	                        }
	                        break;
	                    default:
	                        break;
	                }
	            }
	            finally
	            {
	                this.End(__annot8);
	            }
	        }
	        else
	        {
	            // default
	        }
	    }
	        
	}
	finally
	{
	    this.End(__annot9);
	}
}

public virtual void VisitElementValueTokens(ElementValueTokensSyntax node)
{
	if (node.Token.GetCompilerKind() != CompilerSyntaxKind.None)
	{
	    switch (node.Token.GetCompilerKind())
	    {
	        case CompilerSyntaxKind.KEof:
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Eof));
	            this.Begin(__annot0, node.Token);
	            try
	            {
	                //this.VisitToken(node.Token);
	            }
	            finally
	            {
	                this.End(__annot0);
	            }
	            break;
	        case CompilerSyntaxKind.TString:
	            var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Keyword));
	            this.Begin(__annot3, node.Token);
	            try
	            {
	                var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Text");
	                this.Begin(__annot2, node.Token);
	                try
	                {
	                    var __annot1 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(string));
	                    this.Begin(__annot1, node.Token);
	                    try
	                    {
	                        //this.VisitToken(node.Token);
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
	            finally
	            {
	                this.End(__annot3);
	            }
	            break;
	        default:
	            break;
	    }
	}
	else
	{
	    // default
	}
	    
}

public virtual void VisitBlockInline(BlockInlineSyntax node)
{
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Block));
	this.Begin(__annot2, node);
	try
	{
	    var alternativesList = node.Alternatives;
	    for (var alternativesIndex = 0; alternativesIndex < alternativesList.Count; ++alternativesIndex)
	    {
	        bool __itemHandled = false;
	        bool __sepHandled = false;
	        if (alternativesIndex == 0)
	        {
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
	            this.Begin(__annot0, node.Alternatives[alternativesIndex]);
	            try
	            {
	                this.Visit(node.Alternatives[alternativesIndex]);
	            }
	            finally
	            {
	                this.End(__annot0);
	            }
	            __itemHandled = true;
	        }
	        if (!__itemHandled && alternativesIndex < node.Alternatives.Count)
	        {
	            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
	            this.Begin(__annot1, node.Alternatives[alternativesIndex]);
	            try
	            {
	                this.Visit(node.Alternatives[alternativesIndex]);
	            }
	            finally
	            {
	                this.End(__annot1);
	            }
	        }
	        if (!__sepHandled && alternativesIndex < node.Alternatives.SeparatorCount)
	        {
	            //this.VisitToken(node.Alternatives.GetSeparator(alternativesIndex));
	        }
	    }
	        
	}
	finally
	{
	    this.End(__annot2);
	}
}

public virtual void VisitRuleRefAlt1(RuleRefAlt1Syntax node)
{
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.RuleRef));
	this.Begin(__annot2, node);
	try
	{
	    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "GrammarRule");
	    this.Begin(__annot1, node.GrammarRule);
	    try
	    {
	        var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaCompiler.Model.GrammarRule)));
	        this.Begin(__annot0, node.GrammarRule);
	        try
	        {
	            this.Visit(node.GrammarRule);
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

public virtual void VisitRuleRefAlt2(RuleRefAlt2Syntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.RuleRef));
	this.Begin(__annot1, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ReferencedTypes");
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

public virtual void VisitRuleRefAlt3(RuleRefAlt3Syntax node)
{
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.RuleRef));
	this.Begin(__annot2, node);
	try
	{
	    var referencedTypesList = node.ReferencedTypes;
	    for (var referencedTypesIndex = 0; referencedTypesIndex < referencedTypesList.Count; ++referencedTypesIndex)
	    {
	        bool __itemHandled = false;
	        bool __sepHandled = false;
	        if (referencedTypesIndex == 0)
	        {
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ReferencedTypes");
	            this.Begin(__annot0, node.ReferencedTypes[referencedTypesIndex]);
	            try
	            {
	                this.Visit(node.ReferencedTypes[referencedTypesIndex]);
	            }
	            finally
	            {
	                this.End(__annot0);
	            }
	            __itemHandled = true;
	        }
	        if (!__itemHandled && referencedTypesIndex < node.ReferencedTypes.Count)
	        {
	            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ReferencedTypes");
	            this.Begin(__annot1, node.ReferencedTypes[referencedTypesIndex]);
	            try
	            {
	                this.Visit(node.ReferencedTypes[referencedTypesIndex]);
	            }
	            finally
	            {
	                this.End(__annot1);
	            }
	        }
	        if (!__sepHandled && referencedTypesIndex < node.ReferencedTypes.SeparatorCount)
	        {
	            //this.VisitToken(node.ReferencedTypes.GetSeparator(referencedTypesIndex));
	        }
	    }
	    if (node.Block != null)
	    {
	        this.Visit(node.Block);
	    }
	        
	}
	finally
	{
	    this.End(__annot2);
	}
}

public virtual void VisitLAlternative(LAlternativeSyntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.LAlternative));
	this.Begin(__annot1, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Elements");
	    this.Begin(__annot0, node.Elements.Node);
	    try
	    {
	        var elementsList = node.Elements;
	        for (var elementsIndex = 0; elementsIndex < elementsList.Count; ++elementsIndex)
	        {
	            this.Visit(node.Elements[elementsIndex]);
	        }
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

public virtual void VisitLElement(LElementSyntax node)
{
	var __annot9 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.LElement));
	this.Begin(__annot9, node);
	try
	{
	    if (node.IsNegated.GetCompilerKind() != CompilerSyntaxKind.None)
	    {
	        var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsNegated", value: true);
	        this.Begin(__annot0, node.IsNegated);
	        try
	        {
	            //this.VisitToken(node.IsNegated);
	        }
	        finally
	        {
	            this.End(__annot0);
	        }
	    }
	    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Value");
	    this.Begin(__annot1, node.Value);
	    try
	    {
	        this.Visit(node.Value);
	    }
	    finally
	    {
	        this.End(__annot1);
	    }
	    if (node.Multiplicity.GetCompilerKind() != CompilerSyntaxKind.None)
	    {
	        if (node.Multiplicity.GetCompilerKind() != CompilerSyntaxKind.None)
	        {
	            var __annot8 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Multiplicity");
	            this.Begin(__annot8, node.Multiplicity);
	            try
	            {
	                switch (node.Multiplicity.GetCompilerKind())
	                {
	                    case CompilerSyntaxKind.TQuestion:
	                        var __annot2 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.ZeroOrOne);
	                        this.Begin(__annot2, node.Multiplicity);
	                        try
	                        {
	                            //this.VisitToken(node.Multiplicity);
	                        }
	                        finally
	                        {
	                            this.End(__annot2);
	                        }
	                        break;
	                    case CompilerSyntaxKind.TAsterisk:
	                        var __annot3 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.ZeroOrMore);
	                        this.Begin(__annot3, node.Multiplicity);
	                        try
	                        {
	                            //this.VisitToken(node.Multiplicity);
	                        }
	                        finally
	                        {
	                            this.End(__annot3);
	                        }
	                        break;
	                    case CompilerSyntaxKind.TPlus:
	                        var __annot4 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.OneOrMore);
	                        this.Begin(__annot4, node.Multiplicity);
	                        try
	                        {
	                            //this.VisitToken(node.Multiplicity);
	                        }
	                        finally
	                        {
	                            this.End(__annot4);
	                        }
	                        break;
	                    case CompilerSyntaxKind.TQuestionQuestion:
	                        var __annot5 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.NonGreedyZeroOrOne);
	                        this.Begin(__annot5, node.Multiplicity);
	                        try
	                        {
	                            //this.VisitToken(node.Multiplicity);
	                        }
	                        finally
	                        {
	                            this.End(__annot5);
	                        }
	                        break;
	                    case CompilerSyntaxKind.TAsteriskQuestion:
	                        var __annot6 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.NonGreedyZeroOrMore);
	                        this.Begin(__annot6, node.Multiplicity);
	                        try
	                        {
	                            //this.VisitToken(node.Multiplicity);
	                        }
	                        finally
	                        {
	                            this.End(__annot6);
	                        }
	                        break;
	                    case CompilerSyntaxKind.TPlusQuestion:
	                        var __annot7 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.NonGreedyOneOrMore);
	                        this.Begin(__annot7, node.Multiplicity);
	                        try
	                        {
	                            //this.VisitToken(node.Multiplicity);
	                        }
	                        finally
	                        {
	                            this.End(__annot7);
	                        }
	                        break;
	                    default:
	                        break;
	                }
	            }
	            finally
	            {
	                this.End(__annot8);
	            }
	        }
	        else
	        {
	            // default
	        }
	    }
	        
	}
	finally
	{
	    this.End(__annot9);
	}
}

public virtual void VisitLElementValueTokens(LElementValueTokensSyntax node)
{
	if (node.Token.GetCompilerKind() != CompilerSyntaxKind.None)
	{
	    switch (node.Token.GetCompilerKind())
	    {
	        case CompilerSyntaxKind.TString:
	            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.LFixed));
	            this.Begin(__annot2, node.Token);
	            try
	            {
	                var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Text");
	                this.Begin(__annot1, node.Token);
	                try
	                {
	                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(string));
	                    this.Begin(__annot0, node.Token);
	                    try
	                    {
	                        //this.VisitToken(node.Token);
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
	            break;
	        case CompilerSyntaxKind.TDot:
	            var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.LWildCard));
	            this.Begin(__annot3, node.Token);
	            try
	            {
	                //this.VisitToken(node.Token);
	            }
	            finally
	            {
	                this.End(__annot3);
	            }
	            break;
	        default:
	            break;
	    }
	}
	else
	{
	    // default
	}
	    
}

public virtual void VisitLBlock(LBlockSyntax node)
{
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.LBlock));
	this.Begin(__annot2, node);
	try
	{
	    var alternativesList = node.Alternatives;
	    for (var alternativesIndex = 0; alternativesIndex < alternativesList.Count; ++alternativesIndex)
	    {
	        bool __itemHandled = false;
	        bool __sepHandled = false;
	        if (alternativesIndex == 0)
	        {
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
	            this.Begin(__annot0, node.Alternatives[alternativesIndex]);
	            try
	            {
	                this.Visit(node.Alternatives[alternativesIndex]);
	            }
	            finally
	            {
	                this.End(__annot0);
	            }
	            __itemHandled = true;
	        }
	        if (!__itemHandled && alternativesIndex < node.Alternatives.Count)
	        {
	            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
	            this.Begin(__annot1, node.Alternatives[alternativesIndex]);
	            try
	            {
	                this.Visit(node.Alternatives[alternativesIndex]);
	            }
	            finally
	            {
	                this.End(__annot1);
	            }
	        }
	        if (!__sepHandled && alternativesIndex < node.Alternatives.SeparatorCount)
	        {
	            //this.VisitToken(node.Alternatives.GetSeparator(alternativesIndex));
	        }
	    }
	        
	}
	finally
	{
	    this.End(__annot2);
	}
}

public virtual void VisitLRange(LRangeSyntax node)
{
	var __annot4 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.LRange));
	this.Begin(__annot4, node);
	try
	{
	    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "StartChar");
	    this.Begin(__annot1, node.StartChar);
	    try
	    {
	        var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(string));
	        this.Begin(__annot0, node.StartChar);
	        try
	        {
	            //this.VisitToken(node.StartChar);
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
	    var __annot3 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "EndChar");
	    this.Begin(__annot3, node.EndChar);
	    try
	    {
	        var __annot2 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(string));
	        this.Begin(__annot2, node.EndChar);
	        try
	        {
	            //this.VisitToken(node.EndChar);
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
	finally
	{
	    this.End(__annot4);
	}
}

public virtual void VisitLReference(LReferenceSyntax node)
{
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.LReference));
	this.Begin(__annot2, node);
	try
	{
	    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Rule");
	    this.Begin(__annot1, node.Rule);
	    try
	    {
	        var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaCompiler.Model.LexerRule)));
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

public virtual void VisitExpressionAlt1(ExpressionAlt1Syntax node)
{
	this.Visit(node.SingleExpression);
	    
}

public virtual void VisitArrayExpression(ArrayExpressionSyntax node)
{
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.ArrayExpression));
	this.Begin(__annot2, node);
	try
	{
	    var itemsList = node.Items;
	    for (var itemsIndex = 0; itemsIndex < itemsList.Count; ++itemsIndex)
	    {
	        bool __itemHandled = false;
	        bool __sepHandled = false;
	        if (itemsIndex == 0)
	        {
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Items");
	            this.Begin(__annot0, node.Items[itemsIndex]);
	            try
	            {
	                this.Visit(node.Items[itemsIndex]);
	            }
	            finally
	            {
	                this.End(__annot0);
	            }
	            __itemHandled = true;
	        }
	        if (!__itemHandled && itemsIndex < node.Items.Count)
	        {
	            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Items");
	            this.Begin(__annot1, node.Items[itemsIndex]);
	            try
	            {
	                this.Visit(node.Items[itemsIndex]);
	            }
	            finally
	            {
	                this.End(__annot1);
	            }
	        }
	        if (!__sepHandled && itemsIndex < node.Items.SeparatorCount)
	        {
	            //this.VisitToken(node.Items.GetSeparator(itemsIndex));
	        }
	    }
	        
	}
	finally
	{
	    this.End(__annot2);
	}
}

public virtual void VisitSingleExpression(SingleExpressionSyntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Expression));
	this.Begin(__annot1, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Value");
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

public virtual void VisitParserAnnotation(ParserAnnotationSyntax node)
{
	var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Annotation));
	this.Begin(__annot3, node);
	try
	{
	    var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "AttributeClass");
	    this.Begin(__annot2, node.Qualifier.Node);
	    try
	    {
	        var __annot1 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.Binding.Binder), typeof(MetaDslx.CodeAnalysis.Annotations.Annotation)), suffixes: ImmutableArray.Create<System.String>("Binder", "Annotation"));
	        this.Begin(__annot1, node.Qualifier.Node);
	        try
	        {
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.QualifierBinder();
	            this.Begin(__annot0, node.Qualifier.Node);
	            try
	            {
	                var qualifierList = node.Qualifier;
	                for (var qualifierIndex = 0; qualifierIndex < qualifierList.Count; ++qualifierIndex)
	                {
	                    bool __itemHandled = false;
	                    bool __sepHandled = false;
	                    if (qualifierIndex == 0)
	                    {
	                        this.Visit(node.Qualifier[qualifierIndex]);
	                        __itemHandled = true;
	                    }
	                    if (!__itemHandled && qualifierIndex < node.Qualifier.Count)
	                    {
	                        this.Visit(node.Qualifier[qualifierIndex]);
	                    }
	                    if (!__sepHandled && qualifierIndex < node.Qualifier.SeparatorCount)
	                    {
	                        //this.VisitToken(node.Qualifier.GetSeparator(qualifierIndex));
	                    }
	                }
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
	    if (node.AnnotationArguments != null)
	    {
	        this.Visit(node.AnnotationArguments);
	    }
	        
	}
	finally
	{
	    this.End(__annot3);
	}
}

public virtual void VisitLexerAnnotation(LexerAnnotationSyntax node)
{
	var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Annotation));
	this.Begin(__annot3, node);
	try
	{
	    var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "AttributeClass");
	    this.Begin(__annot2, node.Qualifier.Node);
	    try
	    {
	        var __annot1 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.Syntax.TokenKind), typeof(MetaDslx.CodeAnalysis.Annotations.Annotation)), suffixes: ImmutableArray.Create<System.String>("TokenKind", "Annotation"));
	        this.Begin(__annot1, node.Qualifier.Node);
	        try
	        {
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.QualifierBinder();
	            this.Begin(__annot0, node.Qualifier.Node);
	            try
	            {
	                var qualifierList = node.Qualifier;
	                for (var qualifierIndex = 0; qualifierIndex < qualifierList.Count; ++qualifierIndex)
	                {
	                    bool __itemHandled = false;
	                    bool __sepHandled = false;
	                    if (qualifierIndex == 0)
	                    {
	                        this.Visit(node.Qualifier[qualifierIndex]);
	                        __itemHandled = true;
	                    }
	                    if (!__itemHandled && qualifierIndex < node.Qualifier.Count)
	                    {
	                        this.Visit(node.Qualifier[qualifierIndex]);
	                    }
	                    if (!__sepHandled && qualifierIndex < node.Qualifier.SeparatorCount)
	                    {
	                        //this.VisitToken(node.Qualifier.GetSeparator(qualifierIndex));
	                    }
	                }
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
	    if (node.AnnotationArguments != null)
	    {
	        this.Visit(node.AnnotationArguments);
	    }
	        
	}
	finally
	{
	    this.End(__annot3);
	}
}

public virtual void VisitAnnotationArguments(AnnotationArgumentsSyntax node)
{
	var argumentsList = node.Arguments;
	for (var argumentsIndex = 0; argumentsIndex < argumentsList.Count; ++argumentsIndex)
	{
	    bool __itemHandled = false;
	    bool __sepHandled = false;
	    if (argumentsIndex == 0)
	    {
	        var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Arguments");
	        this.Begin(__annot0, node.Arguments[argumentsIndex]);
	        try
	        {
	            this.Visit(node.Arguments[argumentsIndex]);
	        }
	        finally
	        {
	            this.End(__annot0);
	        }
	        __itemHandled = true;
	    }
	    if (!__itemHandled && argumentsIndex < node.Arguments.Count)
	    {
	        var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Arguments");
	        this.Begin(__annot1, node.Arguments[argumentsIndex]);
	        try
	        {
	            this.Visit(node.Arguments[argumentsIndex]);
	        }
	        finally
	        {
	            this.End(__annot1);
	        }
	    }
	    if (!__sepHandled && argumentsIndex < node.Arguments.SeparatorCount)
	    {
	        //this.VisitToken(node.Arguments.GetSeparator(argumentsIndex));
	    }
	}
	    
}

public virtual void VisitAnnotationArgument(AnnotationArgumentSyntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.AnnotationArgument));
	this.Begin(__annot1, node);
	try
	{
	    if (node.Block != null)
	    {
	        this.Visit(node.Block);
	    }
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Value");
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

public virtual void VisitReturnTypeIdentifierAlt1(ReturnTypeIdentifierAlt1Syntax node)
{
	if (node.Tokens.GetCompilerKind() != CompilerSyntaxKind.None)
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
	    this.Begin(__annot0, node.Tokens);
	    try
	    {
	        switch (node.Tokens.GetCompilerKind())
	        {
	            case CompilerSyntaxKind.KBool:
	                //this.VisitToken(node.Tokens);
	                break;
	            case CompilerSyntaxKind.KInt:
	                //this.VisitToken(node.Tokens);
	                break;
	            case CompilerSyntaxKind.KString:
	                //this.VisitToken(node.Tokens);
	                break;
	            case CompilerSyntaxKind.KType:
	                //this.VisitToken(node.Tokens);
	                break;
	            case CompilerSyntaxKind.KSymbol:
	                //this.VisitToken(node.Tokens);
	                break;
	            case CompilerSyntaxKind.KObject:
	                //this.VisitToken(node.Tokens);
	                break;
	            case CompilerSyntaxKind.KVoid:
	                //this.VisitToken(node.Tokens);
	                break;
	            default:
	                break;
	        }
	    }
	    finally
	    {
	        this.End(__annot0);
	    }
	}
	else
	{
	    // default
	}
	    
}

public virtual void VisitReturnTypeIdentifierAlt2(ReturnTypeIdentifierAlt2Syntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.MetaType)));
	this.Begin(__annot0, node.Identifier);
	try
	{
	    this.Visit(node.Identifier);
	}
	finally
	{
	    this.End(__annot0);
	}
	    
}

public virtual void VisitReturnTypeQualifierAlt1(ReturnTypeQualifierAlt1Syntax node)
{
	if (node.Tokens.GetCompilerKind() != CompilerSyntaxKind.None)
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
	    this.Begin(__annot0, node.Tokens);
	    try
	    {
	        switch (node.Tokens.GetCompilerKind())
	        {
	            case CompilerSyntaxKind.KBool:
	                //this.VisitToken(node.Tokens);
	                break;
	            case CompilerSyntaxKind.KInt:
	                //this.VisitToken(node.Tokens);
	                break;
	            case CompilerSyntaxKind.KString:
	                //this.VisitToken(node.Tokens);
	                break;
	            case CompilerSyntaxKind.KType:
	                //this.VisitToken(node.Tokens);
	                break;
	            case CompilerSyntaxKind.KSymbol:
	                //this.VisitToken(node.Tokens);
	                break;
	            case CompilerSyntaxKind.KObject:
	                //this.VisitToken(node.Tokens);
	                break;
	            case CompilerSyntaxKind.KVoid:
	                //this.VisitToken(node.Tokens);
	                break;
	            default:
	                break;
	        }
	    }
	    finally
	    {
	        this.End(__annot0);
	    }
	}
	else
	{
	    // default
	}
	    
}

public virtual void VisitReturnTypeQualifierAlt2(ReturnTypeQualifierAlt2Syntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.MetaType)));
	this.Begin(__annot1, node.Qualifier.Node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.QualifierBinder();
	    this.Begin(__annot0, node.Qualifier.Node);
	    try
	    {
	        var qualifierList = node.Qualifier;
	        for (var qualifierIndex = 0; qualifierIndex < qualifierList.Count; ++qualifierIndex)
	        {
	            bool __itemHandled = false;
	            bool __sepHandled = false;
	            if (qualifierIndex == 0)
	            {
	                this.Visit(node.Qualifier[qualifierIndex]);
	                __itemHandled = true;
	            }
	            if (!__itemHandled && qualifierIndex < node.Qualifier.Count)
	            {
	                this.Visit(node.Qualifier[qualifierIndex]);
	            }
	            if (!__sepHandled && qualifierIndex < node.Qualifier.SeparatorCount)
	            {
	                //this.VisitToken(node.Qualifier.GetSeparator(qualifierIndex));
	            }
	        }
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
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
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

public virtual void VisitIdentifier(IdentifierSyntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.IdentifierBinder();
	this.Begin(__annot0, node);
	try
	{
	        
	}
	finally
	{
	    this.End(__annot0);
	}
}

public virtual void VisitSimpleIdentifier(SimpleIdentifierSyntax node)
{
	    
}

public virtual void VisitRuleBlock1Alt1(RuleBlock1Alt1Syntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
	this.Begin(__annot1, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ReturnType");
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

public virtual void VisitRuleBlock1Alt2(RuleBlock1Alt2Syntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
	this.Begin(__annot1, node);
	try
	{
	    this.Visit(node.Identifier);
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ReturnType");
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

public virtual void VisitRuleAlternativesBlock(RuleAlternativesBlockSyntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
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

public virtual void VisitBlockBlock1(BlockBlock1Syntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ReturnType");
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

public virtual void VisitBlockAlternativesBlock(BlockAlternativesBlockSyntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
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

public virtual void VisitBlockInlineAlternativesBlock(BlockInlineAlternativesBlockSyntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
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

public virtual void VisitAlternativeBlock1(AlternativeBlock1Syntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Annotations");
	this.Begin(__annot0, node.Annotations1.Node);
	try
	{
	    var annotations1List = node.Annotations1;
	    for (var annotations1Index = 0; annotations1Index < annotations1List.Count; ++annotations1Index)
	    {
	        this.Visit(node.Annotations1[annotations1Index]);
	    }
	}
	finally
	{
	    this.End(__annot0);
	}
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Name");
	this.Begin(__annot1, node.Name);
	try
	{
	    this.Visit(node.Name);
	}
	finally
	{
	    this.End(__annot1);
	}
	if (node.Block != null)
	{
	    this.Visit(node.Block);
	}
	    
}

public virtual void VisitAlternativeBlock1Block1(AlternativeBlock1Block1Syntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ReturnType");
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

public virtual void VisitAlternativeBlock2(AlternativeBlock2Syntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ReturnValue");
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

public virtual void VisitElementBlock1(ElementBlock1Syntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "NameAnnotations");
	this.Begin(__annot0, node.NameAnnotations.Node);
	try
	{
	    var nameAnnotationsList = node.NameAnnotations;
	    for (var nameAnnotationsIndex = 0; nameAnnotationsIndex < nameAnnotationsList.Count; ++nameAnnotationsIndex)
	    {
	        this.Visit(node.NameAnnotations[nameAnnotationsIndex]);
	    }
	}
	finally
	{
	    this.End(__annot0);
	}
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "SymbolProperty");
	this.Begin(__annot2, node.SymbolProperty);
	try
	{
	    var __annot1 = new MetaDslx.Languages.MetaCompiler.Symbols.SymbolPropertyBinder();
	    this.Begin(__annot1, node.SymbolProperty);
	    try
	    {
	        this.Visit(node.SymbolProperty);
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
	if (node.Assignment.GetCompilerKind() != CompilerSyntaxKind.None)
	{
	    var __annot7 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Assignment");
	    this.Begin(__annot7, node.Assignment);
	    try
	    {
	        switch (node.Assignment.GetCompilerKind())
	        {
	            case CompilerSyntaxKind.TEq:
	                var __annot3 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Assignment.Assign);
	                this.Begin(__annot3, node.Assignment);
	                try
	                {
	                    //this.VisitToken(node.Assignment);
	                }
	                finally
	                {
	                    this.End(__annot3);
	                }
	                break;
	            case CompilerSyntaxKind.TQuestionEq:
	                var __annot4 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Assignment.QuestionAssign);
	                this.Begin(__annot4, node.Assignment);
	                try
	                {
	                    //this.VisitToken(node.Assignment);
	                }
	                finally
	                {
	                    this.End(__annot4);
	                }
	                break;
	            case CompilerSyntaxKind.TExclEq:
	                var __annot5 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Assignment.NegatedAssign);
	                this.Begin(__annot5, node.Assignment);
	                try
	                {
	                    //this.VisitToken(node.Assignment);
	                }
	                finally
	                {
	                    this.End(__annot5);
	                }
	                break;
	            case CompilerSyntaxKind.TPlusEq:
	                var __annot6 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Assignment.PlusAssign);
	                this.Begin(__annot6, node.Assignment);
	                try
	                {
	                    //this.VisitToken(node.Assignment);
	                }
	                finally
	                {
	                    this.End(__annot6);
	                }
	                break;
	            default:
	                break;
	        }
	    }
	    finally
	    {
	        this.End(__annot7);
	    }
	}
	else
	{
	    // default
	}
	    
}

public virtual void VisitRuleRefAlt3ReferencedTypesBlock(RuleRefAlt3ReferencedTypesBlockSyntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ReferencedTypes");
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

public virtual void VisitRuleRefAlt3Block1(RuleRefAlt3Block1Syntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "GrammarRule");
	this.Begin(__annot1, node.GrammarRule);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaCompiler.Model.GrammarRule)));
	    this.Begin(__annot0, node.GrammarRule);
	    try
	    {
	        this.Visit(node.GrammarRule);
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

public virtual void VisitTokenBlock1Alt1(TokenBlock1Alt1Syntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Name");
	this.Begin(__annot0, node.Name);
	try
	{
	    this.Visit(node.Name);
	}
	finally
	{
	    this.End(__annot0);
	}
	if (node.Block != null)
	{
	    this.Visit(node.Block);
	}
	    
}

public virtual void VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsTrivia", value: true);
	this.Begin(__annot0, node.IsTrivia);
	try
	{
	    //this.VisitToken(node.IsTrivia);
	}
	finally
	{
	    this.End(__annot0);
	}
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Name");
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

public virtual void VisitTokenBlock1Alt1Block1(TokenBlock1Alt1Block1Syntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ReturnType");
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

public virtual void VisitTokenAlternativesBlock(TokenAlternativesBlockSyntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
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

public virtual void VisitFragmentAlternativesBlock(FragmentAlternativesBlockSyntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
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

public virtual void VisitLBlockAlternativesBlock(LBlockAlternativesBlockSyntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Alternatives");
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

public virtual void VisitTokens(TokensSyntax node)
{
	var __annot0 = new MetaDslx.Languages.MetaCompiler.Symbols.ExpressionValueBinder();
	this.Begin(__annot0, node);
	try
	{
	        
	}
	finally
	{
	    this.End(__annot0);
	}
}

public virtual void VisitSingleExpressionBlock1Alt2(SingleExpressionBlock1Alt2Syntax node)
{
	var __annot1 = new MetaDslx.Languages.MetaCompiler.Symbols.ExpressionValueBinder();
	this.Begin(__annot1, node);
	try
	{
	    if (node.Tokens.GetCompilerKind() != CompilerSyntaxKind.None)
	    {
	        var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
	        this.Begin(__annot0, node.Tokens);
	        try
	        {
	            switch (node.Tokens.GetCompilerKind())
	            {
	                case CompilerSyntaxKind.KBool:
	                    //this.VisitToken(node.Tokens);
	                    break;
	                case CompilerSyntaxKind.KInt:
	                    //this.VisitToken(node.Tokens);
	                    break;
	                case CompilerSyntaxKind.KString:
	                    //this.VisitToken(node.Tokens);
	                    break;
	                case CompilerSyntaxKind.KType:
	                    //this.VisitToken(node.Tokens);
	                    break;
	                case CompilerSyntaxKind.KSymbol:
	                    //this.VisitToken(node.Tokens);
	                    break;
	                case CompilerSyntaxKind.KObject:
	                    //this.VisitToken(node.Tokens);
	                    break;
	                case CompilerSyntaxKind.KVoid:
	                    //this.VisitToken(node.Tokens);
	                    break;
	                default:
	                    break;
	            }
	        }
	        finally
	        {
	            this.End(__annot0);
	        }
	    }
	    else
	    {
	        // default
	    }
	        
	}
	finally
	{
	    this.End(__annot1);
	}
}

public virtual void VisitSingleExpressionBlock1Alt3(SingleExpressionBlock1Alt3Syntax node)
{
	var __annot0 = new MetaDslx.Languages.MetaCompiler.Symbols.ExpressionValueBinder();
	this.Begin(__annot0, node);
	try
	{
	        
	}
	finally
	{
	    this.End(__annot0);
	}
}

public virtual void VisitArrayExpressionItemsBlock(ArrayExpressionItemsBlockSyntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Items");
	this.Begin(__annot0, node.Items);
	try
	{
	    this.Visit(node.Items);
	}
	finally
	{
	    this.End(__annot0);
	}
	    
}

public virtual void VisitAnnotationArgumentsArgumentsBlock(AnnotationArgumentsArgumentsBlockSyntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Arguments");
	this.Begin(__annot0, node.Arguments);
	try
	{
	    this.Visit(node.Arguments);
	}
	finally
	{
	    this.End(__annot0);
	}
	    
}

public virtual void VisitAnnotationArgumentBlock1(AnnotationArgumentBlock1Syntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "NamedParameter");
	this.Begin(__annot1, node.NamedParameter);
	try
	{
	    var __annot0 = new MetaDslx.Languages.MetaCompiler.Symbols.AnnotationArgumentBinder();
	    this.Begin(__annot0, node.NamedParameter);
	    try
	    {
	        this.Visit(node.NamedParameter);
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

public virtual void VisitMainQualifierBlock(MainQualifierBlockSyntax node)
{
	this.Visit(node.Identifier);
	    
}

public virtual void VisitSingleExpressionBlock1Alt3SimpleQualifierBlock(SingleExpressionBlock1Alt3SimpleQualifierBlockSyntax node)
{
	    
}

public virtual void VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node)
{
}
    }
}