using System;
using System.Collections.Immutable;
using MetaDslx.CodeAnalysis;
using System;
using MetaDslx.CodeAnalysis.Annotations;
using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Languages.MetaModel.Model;

#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Binding
{
    using MetaDslx.Languages.MetaModel.Compiler.Syntax;

    public class MetaBinderFactoryVisitor : MetaDslx.CodeAnalysis.Binding.BinderFactoryVisitor, IMetaSyntaxVisitor
    {
        internal MetaBinderFactoryVisitor(MetaDslx.CodeAnalysis.Binding.BinderFactory binderFactory)
            : base(binderFactory)
        {
        }


        public virtual void VisitMain(MainSyntax node)
        {
            if (this.IsRoot)
            {
                var __rootAnnot = new global::MetaDslx.CodeAnalysis.Binding.RootBinder(node.SyntaxTree, type: typeof(global::MetaDslx.Languages.MetaModel.Model.MetaNamespace));
                this.Begin(__rootAnnot, node);
                try
                {
                    var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Languages.MetaModel.Model.MetaNamespace));
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
            	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Languages.MetaModel.Model.MetaNamespace));
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
        	var __annot1 = new DefineBinder(type: typeof(global::MetaDslx.Languages.MetaModel.Model.MetaModel));
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

        public virtual void VisitMetaConstant(MetaConstantSyntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Languages.MetaModel.Model.MetaConstant));
        	this.Begin(__annot2, node);
        	try
        	{
        	    var __annot0 = new PropertyBinder(name: "Type");
        	    this.Begin(__annot0, node.Type);
        	    try
        	    {
        	        this.Visit(node.Type);
        	    }
        	    finally
        	    {
        	        this.End(__annot0);
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
        	finally
        	{
        	    this.End(__annot2);
        	}
        }

        public virtual void VisitMetaEnumType(MetaEnumTypeSyntax node)
        {
        	var __annot1 = new DefineBinder(type: typeof(global::MetaDslx.Languages.MetaModel.Model.MetaEnumType));
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
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Languages.MetaModel.Model.MetaClass));
        	this.Begin(__annot2, node);
        	try
        	{
        	    if (node.IsAbstract.GetMetaKind() != MetaSyntaxKind.None)
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
        	    }
        	    else
        	    {
        	        var __annot1 = new PropertyBinder(name: "Literals");
        	        this.Begin(__annot1, node.MetaEnumLiteralList[metaEnumLiteralListIndex]);
        	        try
        	        {
        	            this.Visit(node.MetaEnumLiteralList[metaEnumLiteralListIndex]);
        	        }
        	        finally
        	        {
        	            this.End(__annot1);
        	        }
        	        // this.VisitToken(node.MetaEnumLiteralList.GetSeparator(metaEnumLiteralListIndex));
        	    }
        	}
        	    
        }

        public virtual void VisitMetaEnumLiteral(MetaEnumLiteralSyntax node)
        {
        	var __annot1 = new DefineBinder(type: typeof(global::MetaDslx.Languages.MetaModel.Model.MetaEnumLiteral));
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

        public virtual void VisitClassNameAlt1(ClassNameAlt1Syntax node)
        {
        	var __annot3 = new NameBinder();
        	this.Begin(__annot3, node);
        	try
        	{
        	    var __annot2 = new IdentifierBinder();
        	    this.Begin(__annot2, node);
        	    try
        	    {
        	        var __annot1 = new PropertyBinder(name: "SymbolType");
        	        this.Begin(__annot1, node.SymbolType);
        	        try
        	        {
        	            var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol)}.ToImmutableArray(), suffixes: new string[] {"Symbol"}.ToImmutableArray());
        	            this.Begin(__annot0, node.SymbolType);
        	            try
        	            {
        	                this.Visit(node.SymbolType);
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

        public virtual void VisitClassNameAlt2(ClassNameAlt2Syntax node)
        {
        	var __annot1 = new NameBinder();
        	this.Begin(__annot1, node);
        	try
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
        	var __annot4 = new DefineBinder(type: typeof(global::MetaDslx.Languages.MetaModel.Model.MetaProperty));
        	this.Begin(__annot4, node);
        	try
        	{
        	    switch (node.Element.GetMetaKind())
        	    {
        	    case MetaSyntaxKind.KContains:
        	        var __annot0 = new PropertyBinder(name: "IsContainment", value: true);
        	        this.Begin(__annot0, node.Element);
        	        try
        	        {
        	            // this.VisitToken(node.Element);
        	        }
        	        finally
        	        {
        	            this.End(__annot0);
        	        }
        	        break;
        	    case MetaSyntaxKind.KDerived:
        	        var __annot1 = new PropertyBinder(name: "IsDerived", value: true);
        	        this.Begin(__annot1, node.Element);
        	        try
        	        {
        	            // this.VisitToken(node.Element);
        	        }
        	        finally
        	        {
        	            this.End(__annot1);
        	        }
        	        break;
        	    default:
        	        // this.VisitToken(node.Element);
        	        break;
        	    }
        	    var __annot2 = new PropertyBinder(name: "Type");
        	    this.Begin(__annot2, node.Type);
        	    try
        	    {
        	        this.Visit(node.Type);
        	    }
        	    finally
        	    {
        	        this.End(__annot2);
        	    }
        	    var __annot3 = new PropertyBinder(name: "Name");
        	    this.Begin(__annot3, node.Name);
        	    try
        	    {
        	        this.Visit(node.Name);
        	    }
        	    finally
        	    {
        	        this.End(__annot3);
        	    }
        	    var metaPropertyBlock2List = node.MetaPropertyBlock2;
        	    for (var metaPropertyBlock2Index = 0; metaPropertyBlock2Index < metaPropertyBlock2List.Count; ++metaPropertyBlock2Index)
        	    {
        	        this.Visit(node.MetaPropertyBlock2[metaPropertyBlock2Index]);
        	    }
        	        
        	}
        	finally
        	{
        	    this.End(__annot4);
        	}
        }

        public virtual void VisitPropertyNameAlt1(PropertyNameAlt1Syntax node)
        {
        	var __annot3 = new NameBinder();
        	this.Begin(__annot3, node);
        	try
        	{
        	    var __annot2 = new IdentifierBinder();
        	    this.Begin(__annot2, node);
        	    try
        	    {
        	        if (node.SymbolProperty.GetMetaKind() != MetaSyntaxKind.None)
        	        {
        	            var __annot1 = new PropertyBinder(name: "SymbolProperty");
        	            this.Begin(__annot1, node.SymbolProperty);
        	            try
        	            {
        	                var __annot0 = new ValueBinder(type: typeof(string));
        	                this.Begin(__annot0, node.SymbolProperty);
        	                try
        	                {
        	                    // this.VisitToken(node.SymbolProperty);
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
        	            // this.VisitToken(node.SymbolProperty);
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

        public virtual void VisitPropertyNameAlt2(PropertyNameAlt2Syntax node)
        {
        	var __annot1 = new NameBinder();
        	this.Begin(__annot1, node);
        	try
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
        	finally
        	{
        	    this.End(__annot1);
        	}
        }

        public virtual void VisitPropertyOpposite(PropertyOppositeSyntax node)
        {
        	var qualifierListList = node.QualifierList;
        	for (var qualifierListIndex = 0; qualifierListIndex < qualifierListList.Count; ++qualifierListIndex)
        	{
        	    if (qualifierListIndex == 0)
        	    {
        	        var __annot1 = new PropertyBinder(name: "OppositeProperties");
        	        this.Begin(__annot1, node.QualifierList[qualifierListIndex]);
        	        try
        	        {
        	            var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Languages.MetaModel.Model.MetaProperty)}.ToImmutableArray());
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
        	        var __annot3 = new PropertyBinder(name: "OppositeProperties");
        	        this.Begin(__annot3, node.QualifierList[qualifierListIndex]);
        	        try
        	        {
        	            var __annot2 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Languages.MetaModel.Model.MetaProperty)}.ToImmutableArray());
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

        public virtual void VisitPropertySubsets(PropertySubsetsSyntax node)
        {
        	var qualifierListList = node.QualifierList;
        	for (var qualifierListIndex = 0; qualifierListIndex < qualifierListList.Count; ++qualifierListIndex)
        	{
        	    if (qualifierListIndex == 0)
        	    {
        	        var __annot1 = new PropertyBinder(name: "SubsettedProperties");
        	        this.Begin(__annot1, node.QualifierList[qualifierListIndex]);
        	        try
        	        {
        	            var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Languages.MetaModel.Model.MetaProperty)}.ToImmutableArray());
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
        	        var __annot3 = new PropertyBinder(name: "SubsettedProperties");
        	        this.Begin(__annot3, node.QualifierList[qualifierListIndex]);
        	        try
        	        {
        	            var __annot2 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Languages.MetaModel.Model.MetaProperty)}.ToImmutableArray());
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

        public virtual void VisitPropertyRedefines(PropertyRedefinesSyntax node)
        {
        	var qualifierListList = node.QualifierList;
        	for (var qualifierListIndex = 0; qualifierListIndex < qualifierListList.Count; ++qualifierListIndex)
        	{
        	    if (qualifierListIndex == 0)
        	    {
        	        var __annot1 = new PropertyBinder(name: "RedefinedProperties");
        	        this.Begin(__annot1, node.QualifierList[qualifierListIndex]);
        	        try
        	        {
        	            var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Languages.MetaModel.Model.MetaProperty)}.ToImmutableArray());
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
        	        var __annot3 = new PropertyBinder(name: "RedefinedProperties");
        	        this.Begin(__annot3, node.QualifierList[qualifierListIndex]);
        	        try
        	        {
        	            var __annot2 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Languages.MetaModel.Model.MetaProperty)}.ToImmutableArray());
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

        public virtual void VisitMetaOperation(MetaOperationSyntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Languages.MetaModel.Model.MetaOperation));
        	this.Begin(__annot2, node);
        	try
        	{
        	    var __annot0 = new PropertyBinder(name: "ReturnType");
        	    this.Begin(__annot0, node.ReturnType);
        	    try
        	    {
        	        this.Visit(node.ReturnType);
        	    }
        	    finally
        	    {
        	        this.End(__annot0);
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
        	    this.Visit(node.ParameterList);
        	        
        	}
        	finally
        	{
        	    this.End(__annot2);
        	}
        }

        public virtual void VisitParameterList(ParameterListSyntax node)
        {
        	var metaParameterListList = node.MetaParameterList;
        	for (var metaParameterListIndex = 0; metaParameterListIndex < metaParameterListList.Count; ++metaParameterListIndex)
        	{
        	    if (metaParameterListIndex == 0)
        	    {
        	        var __annot0 = new PropertyBinder(name: "Parameters");
        	        this.Begin(__annot0, node.MetaParameterList[metaParameterListIndex]);
        	        try
        	        {
        	            this.Visit(node.MetaParameterList[metaParameterListIndex]);
        	        }
        	        finally
        	        {
        	            this.End(__annot0);
        	        }
        	    }
        	    else
        	    {
        	        var __annot1 = new PropertyBinder(name: "Parameters");
        	        this.Begin(__annot1, node.MetaParameterList[metaParameterListIndex]);
        	        try
        	        {
        	            this.Visit(node.MetaParameterList[metaParameterListIndex]);
        	        }
        	        finally
        	        {
        	            this.End(__annot1);
        	        }
        	        // this.VisitToken(node.MetaParameterList.GetSeparator(metaParameterListIndex));
        	    }
        	}
        	    
        }

        public virtual void VisitMetaParameter(MetaParameterSyntax node)
        {
        	var __annot2 = new DefineBinder(type: typeof(global::MetaDslx.Languages.MetaModel.Model.MetaParameter));
        	this.Begin(__annot2, node);
        	try
        	{
        	    var __annot0 = new PropertyBinder(name: "Type");
        	    this.Begin(__annot0, node.Type);
        	    try
        	    {
        	        this.Visit(node.Type);
        	    }
        	    finally
        	    {
        	        this.End(__annot0);
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
        	finally
        	{
        	    this.End(__annot2);
        	}
        }

        public virtual void VisitMetaArrayType(MetaArrayTypeSyntax node)
        {
        	var __annot1 = new DefineBinder(type: typeof(global::MetaDslx.Languages.MetaModel.Model.MetaArrayType));
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
        	var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Languages.MetaModel.Model.MetaType)}.ToImmutableArray());
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
        	switch (node.Tokens.GetMetaKind())
        	{
        	case MetaSyntaxKind.KBool:
        	    var __annot0 = new ConstantBinder(value: global::MetaDslx.Languages.MetaModel.Model.Meta.BoolType);
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
        	case MetaSyntaxKind.KInt:
        	    var __annot1 = new ConstantBinder(value: global::MetaDslx.Languages.MetaModel.Model.Meta.IntType);
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
        	case MetaSyntaxKind.KString:
        	    var __annot2 = new ConstantBinder(value: global::MetaDslx.Languages.MetaModel.Model.Meta.StringType);
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
        	case MetaSyntaxKind.KType:
        	    var __annot3 = new ConstantBinder(value: global::MetaDslx.Languages.MetaModel.Model.Meta.TypeType);
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
        	case MetaSyntaxKind.KVoid:
        	    var __annot4 = new ConstantBinder(value: global::MetaDslx.Languages.MetaModel.Model.Meta.VoidType);
        	    this.Begin(__annot4, node.Tokens);
        	    try
        	    {
        	        // this.VisitToken(node.Tokens);
        	    }
        	    finally
        	    {
        	        this.End(__annot4);
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
        	if (node.TComma.GetMetaKind() != MetaSyntaxKind.None)
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
        	    var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Languages.MetaModel.Model.MetaClass)}.ToImmutableArray());
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

        public virtual void VisitMetaPropertyBlock2Alt1(MetaPropertyBlock2Alt1Syntax node)
        {
        	this.Visit(node.PropertyOpposite);
        	    
        }

        public virtual void VisitMetaPropertyBlock2Alt2(MetaPropertyBlock2Alt2Syntax node)
        {
        	this.Visit(node.PropertySubsets);
        	    
        }

        public virtual void VisitMetaPropertyBlock2Alt3(MetaPropertyBlock2Alt3Syntax node)
        {
        	this.Visit(node.PropertyRedefines);
        	    
        }

        public virtual void VisitPropertyOppositeBlock1(PropertyOppositeBlock1Syntax node)
        {
        	if (node.TComma.GetMetaKind() != MetaSyntaxKind.None)
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	else
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	var __annot1 = new PropertyBinder(name: "OppositeProperties");
        	this.Begin(__annot1, node.OppositeProperties);
        	try
        	{
        	    var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Languages.MetaModel.Model.MetaProperty)}.ToImmutableArray());
        	    this.Begin(__annot0, node.OppositeProperties);
        	    try
        	    {
        	        this.Visit(node.OppositeProperties);
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

        public virtual void VisitPropertySubsetsBlock1(PropertySubsetsBlock1Syntax node)
        {
        	if (node.TComma.GetMetaKind() != MetaSyntaxKind.None)
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	else
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	var __annot1 = new PropertyBinder(name: "SubsettedProperties");
        	this.Begin(__annot1, node.SubsettedProperties);
        	try
        	{
        	    var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Languages.MetaModel.Model.MetaProperty)}.ToImmutableArray());
        	    this.Begin(__annot0, node.SubsettedProperties);
        	    try
        	    {
        	        this.Visit(node.SubsettedProperties);
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

        public virtual void VisitPropertyRedefinesBlock1(PropertyRedefinesBlock1Syntax node)
        {
        	if (node.TComma.GetMetaKind() != MetaSyntaxKind.None)
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	else
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	var __annot1 = new PropertyBinder(name: "RedefinedProperties");
        	this.Begin(__annot1, node.RedefinedProperties);
        	try
        	{
        	    var __annot0 = new UseBinder(types: new global::System.Type[] {typeof(global::MetaDslx.Languages.MetaModel.Model.MetaProperty)}.ToImmutableArray());
        	    this.Begin(__annot0, node.RedefinedProperties);
        	    try
        	    {
        	        this.Visit(node.RedefinedProperties);
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

        public virtual void VisitParameterListBlock1(ParameterListBlock1Syntax node)
        {
        	if (node.TComma.GetMetaKind() != MetaSyntaxKind.None)
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	else
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	var __annot0 = new PropertyBinder(name: "Parameters");
        	this.Begin(__annot0, node.Parameters);
        	try
        	{
        	    this.Visit(node.Parameters);
        	}
        	finally
        	{
        	    this.End(__annot0);
        	}
        	    
        }

        public virtual void VisitQualifierBlock1(QualifierBlock1Syntax node)
        {
        	if (node.TDot.GetMetaKind() != MetaSyntaxKind.None)
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
        	if (node.TComma.GetMetaKind() != MetaSyntaxKind.None)
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	else
        	{
        	    // this.VisitToken(node.TComma);
        	}
        	this.Visit(node.Qualifier);
        	    
        }

		public virtual void VisitSkippedTokensTrivia(MetaSkippedTokensTriviaSyntax node)
		{
		}
    }
}
