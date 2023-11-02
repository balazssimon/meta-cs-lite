using System;
using System.Collections.Immutable;
using MetaDslx.CodeAnalysis;
using System;
using MetaDslx.CodeAnalysis.Annotations;
using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Bootstrap.MetaModel.Core;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler.Binding
{
    using MetaDslx.Bootstrap.MetaModel.Compiler.Syntax;

    public class MetaCoreBinderFactoryVisitor : MetaDslx.CodeAnalysis.Binding.BinderFactoryVisitor, IMetaCoreSyntaxVisitor
    {
        internal MetaCoreBinderFactoryVisitor(MetaDslx.CodeAnalysis.Binding.BinderFactory binderFactory)
            : base(binderFactory)
        {
        }


        public virtual void VisitMain(MainSyntax node)
        {
            if (this.IsRoot)
            {
                var __rootAnnot = new global::MetaDslx.CodeAnalysis.Binding.RootBinder(type: typeof(global::MetaDslx.Bootstrap.MetaModel.Core.MetaNamespace));
                this.Begin(__rootAnnot, node);
                try
                {
                    var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaModel.Core.MetaNamespace));
                    this.Begin(__annot2, node);
                    try
                    {
                        var __annot1 = new NameBinder(qualifierProperty: "Declarations");
                        this.Begin(__annot1, node.Name);
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
            	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaModel.Core.MetaNamespace));
            	this.Begin(__annot2, node);
            	try
            	{
            	    var __annot1 = new NameBinder(qualifierProperty: "Declarations");
            	    this.Begin(__annot1, node.Name);
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
        	var __annot1 = new ScopeBinder();
        	this.Begin(__annot1, node);
        	try
        	{
        	    var declarationsList = node.Declarations;
        	    for (var declarationsIndex = 0; declarationsIndex < declarationsList.Count; ++declarationsIndex)
        	    {
        	        var __annot0 = new PropertyBinder(name: "Declarations");
        	        this.Begin(__annot0, node.Declarations[declarationsIndex]);
        	        try
        	        {
        	            this.Visit(node.Declarations[declarationsIndex]);
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

        public virtual void VisitMetaModel(MetaModelSyntax node)
        {
        	var __annot1 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaModel.Core.MetaModel));
        	this.Begin(__annot1, node);
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
        	        
        	}
        	finally
        	{
        	    this.End(__annot1);
        	}
        }

        public virtual void VisitMetaEnumType(MetaEnumTypeSyntax node)
        {
        	var __annot1 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaModel.Core.MetaEnumType));
        	this.Begin(__annot1, node);
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
        	    this.Visit(node.EnumBody);
        	        
        	}
        	finally
        	{
        	    this.End(__annot1);
        	}
        }

        public virtual void VisitMetaClass(MetaClassSyntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaModel.Core.MetaClass));
        	this.Begin(__annot2, node);
        	try
        	{
        	    if (node.IsAbstract.GetMetaCoreKind() != MetaCoreSyntaxKind.None)
        	    {
        	        var __annot0 = new PropertyBinder(name: "IsAbstract", value: true);
        	        this.Begin(__annot0, node.IsAbstract);
        	        try
        	        {
        	            // this.VisitToken(node.IsAbstract);
        	        }
        	        finally
        	        {
        	            this.End(__annot0);
        	        }
        	    }
        	    else
        	    {
        	        // this.VisitToken(node.IsAbstract);
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
        	    this.Visit(node.BaseClasses);
        	    this.Visit(node.ClassBody);
        	        
        	}
        	finally
        	{
        	    this.End(__annot2);
        	}
        }

        public virtual void VisitEnumBody(EnumBodySyntax node)
        {
        	var __annot0 = new ScopeBinder();
        	this.Begin(__annot0, node);
        	try
        	{
        	    this.Visit(node.EnumLiterals);
        	        
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        }

        public virtual void VisitEnumLiterals(EnumLiteralsSyntax node)
        {
        	var metaEnumLiteralListList = node.MetaEnumLiteralList;
        	for (var metaEnumLiteralListIndex = 0; metaEnumLiteralListIndex < metaEnumLiteralListList.Count; ++metaEnumLiteralListIndex)
        	{
        	    if (metaEnumLiteralListIndex == 0)
        	    {
        	        this.Visit(node.MetaEnumLiteralList[metaEnumLiteralListIndex]);
        	    }
        	    else
        	    {
        	        var __annot0 = new PropertyBinder(name: "Literals");
        	        this.Begin(__annot0, node.MetaEnumLiteralList[metaEnumLiteralListIndex]);
        	        try
        	        {
        	            this.Visit(node.MetaEnumLiteralList[metaEnumLiteralListIndex]);
        	        }
        	        finally
        	        {
        	            this.End(__annot0);
        	        }
        	        // this.VisitToken(node.MetaEnumLiteralList.GetSeparator(metaEnumLiteralListIndex));
        	    }
        	}
        	    
        }

        public virtual void VisitMetaEnumLiteral(MetaEnumLiteralSyntax node)
        {
        	var __annot1 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaModel.Core.MetaEnumLiteral));
        	this.Begin(__annot1, node);
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
        	        
        	}
        	finally
        	{
        	    this.End(__annot1);
        	}
        }

        public virtual void VisitBaseClasses(BaseClassesSyntax node)
        {
        	this.Visit(node.BaseClassesBlock1);
        	    
        }

        public virtual void VisitClassBody(ClassBodySyntax node)
        {
        	var __annot1 = new ScopeBinder();
        	this.Begin(__annot1, node);
        	try
        	{
        	    var propertiesList = node.Properties;
        	    for (var propertiesIndex = 0; propertiesIndex < propertiesList.Count; ++propertiesIndex)
        	    {
        	        var __annot0 = new PropertyBinder(name: "Properties");
        	        this.Begin(__annot0, node.Properties[propertiesIndex]);
        	        try
        	        {
        	            this.Visit(node.Properties[propertiesIndex]);
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

        public virtual void VisitMetaProperty(MetaPropertySyntax node)
        {
        	var __annot3 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaModel.Core.MetaProperty));
        	this.Begin(__annot3, node);
        	try
        	{
        	    if (node.IsContainment.GetMetaCoreKind() != MetaCoreSyntaxKind.None)
        	    {
        	        var __annot0 = new PropertyBinder(name: "IsContainment", value: true);
        	        this.Begin(__annot0, node.IsContainment);
        	        try
        	        {
        	            // this.VisitToken(node.IsContainment);
        	        }
        	        finally
        	        {
        	            this.End(__annot0);
        	        }
        	    }
        	    else
        	    {
        	        // this.VisitToken(node.IsContainment);
        	    }
        	    var __annot1 = new PropertyBinder(name: "Type");
        	    this.Begin(__annot1, node.Type);
        	    try
        	    {
        	        this.Visit(node.Type);
        	    }
        	    finally
        	    {
        	        this.End(__annot1);
        	    }
        	    var __annot2 = new PropertyBinder(name: "Name");
        	    this.Begin(__annot2, node.Name);
        	    try
        	    {
        	        this.Visit(node.Name);
        	    }
        	    finally
        	    {
        	        this.End(__annot2);
        	    }
        	    this.Visit(node.PropertyOpposite);
        	        
        	}
        	finally
        	{
        	    this.End(__annot3);
        	}
        }

        public virtual void VisitPropertyOpposite(PropertyOppositeSyntax node)
        {
        	var __annot1 = new PropertyBinder(name: "Opposite");
        	this.Begin(__annot1, node.Opposite);
        	try
        	{
        	    var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Bootstrap.MetaModel.Core.MetaProperty)}.ToImmutableArray());
        	    this.Begin(__annot0, node.Opposite);
        	    try
        	    {
        	        this.Visit(node.Opposite);
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

        public virtual void VisitMetaArrayType(MetaArrayTypeSyntax node)
        {
        	var __annot1 = new DefineBinder(type: typeof(global::MetaDslx.Bootstrap.MetaModel.Core.MetaArrayType));
        	this.Begin(__annot1, node);
        	try
        	{
        	    var __annot0 = new PropertyBinder(name: "ItemType");
        	    this.Begin(__annot0, node.ItemType);
        	    try
        	    {
        	        this.Visit(node.ItemType);
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

        public virtual void VisitTypeReferenceAlt3(TypeReferenceAlt3Syntax node)
        {
        	var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Bootstrap.MetaModel.Core.MetaType)}.ToImmutableArray());
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

        public virtual void VisitTypeReferenceTokens(TypeReferenceTokensSyntax node)
        {
        	switch (node.Tokens.GetMetaCoreKind())
        	{
        	case MetaCoreSyntaxKind.KBool:
        	    var __annot0 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaModel.Core.MetaModel.Bool);
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
        	case MetaCoreSyntaxKind.KInt:
        	    var __annot1 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaModel.Core.MetaModel.Int);
        	    this.Begin(__annot1, node.Tokens);
        	    try
        	    {
        	        // this.VisitToken(node.Tokens);
        	    }
        	    finally
        	    {
        	        this.End(__annot1);
        	    }
        	    break;
        	case MetaCoreSyntaxKind.KString:
        	    var __annot2 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaModel.Core.MetaModel.String);
        	    this.Begin(__annot2, node.Tokens);
        	    try
        	    {
        	        // this.VisitToken(node.Tokens);
        	    }
        	    finally
        	    {
        	        this.End(__annot2);
        	    }
        	    break;
        	case MetaCoreSyntaxKind.KType:
        	    var __annot3 = new ConstantBinder(value: global::MetaDslx.Bootstrap.MetaModel.Core.MetaModel.Type);
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

        public virtual void VisitEnumLiteralsBlock1(EnumLiteralsBlock1Syntax node)
        {
        	if (node.TComma.GetMetaCoreKind() != MetaCoreSyntaxKind.None)
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	else
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	var __annot0 = new PropertyBinder(name: "Literals");
        	this.Begin(__annot0, node.Literals);
        	try
        	{
        	    this.Visit(node.Literals);
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        	    
        }

        public virtual void VisitBaseClassesBlock1(BaseClassesBlock1Syntax node)
        {
        	var __annot1 = new PropertyBinder(name: "BaseTypes");
        	this.Begin(__annot1, node.BaseTypes);
        	try
        	{
        	    var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Bootstrap.MetaModel.Core.MetaClass)}.ToImmutableArray());
        	    this.Begin(__annot0, node.BaseTypes);
        	    try
        	    {
        	        this.Visit(node.BaseTypes);
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

        public virtual void VisitQualifierBlock1(QualifierBlock1Syntax node)
        {
        	if (node.TDot.GetMetaCoreKind() != MetaCoreSyntaxKind.None)
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
        	if (node.TComma.GetMetaCoreKind() != MetaCoreSyntaxKind.None)
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	else
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	this.Visit(node.Qualifier);
        	    
        }

		public virtual void VisitSkippedTokensTrivia(MetaCoreSkippedTokensTriviaSyntax node)
		{
		}
    }
}
