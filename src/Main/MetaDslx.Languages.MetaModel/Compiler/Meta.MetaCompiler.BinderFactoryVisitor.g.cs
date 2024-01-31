using System;
using System.Collections.Immutable;
using MetaDslx.CodeAnalysis;

#nullable enable

namespace MetaDslx.Languages.MetaModel.Compiler.Binding
{
    using global::MetaDslx.Languages.MetaModel.Compiler.Syntax;

    public class MetaBinderFactoryVisitor : MetaDslx.CodeAnalysis.Binding.BinderFactoryVisitor, IMetaSyntaxVisitor
    {
        internal MetaBinderFactoryVisitor(MetaDslx.CodeAnalysis.Binding.BinderFactory binderFactory)
            : base(binderFactory)
        {
        }


public virtual void VisitMain(MainSyntax node)
{
    /*if (this.IsRoot)
    {
        var __rootAnnot = new global::MetaDslx.CodeAnalysis.Binding.RootBinder(node.SyntaxTree);
        this.Begin(__rootAnnot, node);
        try
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaNamespace));
            this.Begin(__annot2, node);
            try
            {
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Name");
                this.Begin(__annot1, node.Name);
                try
                {
                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.NameBinder(qualifierProperty: MetaDslx.Languages.MetaModel.Model.Meta.MetaDeclaration_Declarations);
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
                var usingListList = node.UsingList;
                for (var usingListIndex = 0; usingListIndex < usingListList.Count; ++usingListIndex)
                {
                    this.Visit(node.UsingList[usingListIndex]);
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
    {*/
    	var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaNamespace));
    	this.Begin(__annot2, node);
    	try
    	{
    	    //var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Name");
    	    //this.Begin(__annot1, node.Name);
    	    //try
    	    //{
    	        var __annot0 = new MetaDslx.CodeAnalysis.Binding.NameBinder(qualifierProperty: MetaDslx.Languages.MetaModel.Model.Meta.MetaDeclaration_Declarations);
    	        this.Begin(__annot0, node.Name);
    	        try
    	        {
    	            this.Visit(node.Name);
    	        }
    	        finally
    	        {
    	            this.End(__annot0);
    	        }
    	    //}
    	    //finally
    	    //{
    	    //    this.End(__annot1);
    	    //}
    	    var usingListList = node.UsingList;
    	    for (var usingListIndex = 0; usingListIndex < usingListList.Count; ++usingListIndex)
    	    {
    	        this.Visit(node.UsingList[usingListIndex]);
    	    }
    	    this.Visit(node.Declarations);
    	        
    	}
    	finally
    	{
    	    this.End(__annot2);
    	}
    //}
}

public virtual void VisitUsing(UsingSyntax node)
{
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.CodeAnalysis.Symbols.ImportSymbol));
	this.Begin(__annot2, node);
	try
	{
	    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Namespaces");
	    this.Begin(__annot1, node.Namespaces);
	    try
	    {
	        var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol)));
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
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.ScopeBinder();
	this.Begin(__annot1, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Declarations");
	    this.Begin(__annot0, node.Declarations.Node);
	    try
	    {
	        var declarationsList = node.Declarations;
	        for (var declarationsIndex = 0; declarationsIndex < declarationsList.Count; ++declarationsIndex)
	        {
	            this.Visit(node.Declarations[declarationsIndex]);
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

public virtual void VisitMetaModel(MetaModelSyntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaModel));
	this.Begin(__annot1, node);
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
	        
	}
	finally
	{
	    this.End(__annot1);
	}
}

public virtual void VisitMetaConstant(MetaConstantSyntax node)
{
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaConstant));
	this.Begin(__annot2, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Type");
	    this.Begin(__annot0, node.Type);
	    try
	    {
	        this.Visit(node.Type);
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
	finally
	{
	    this.End(__annot2);
	}
}

public virtual void VisitMetaEnum(MetaEnumSyntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaEnum));
	this.Begin(__annot1, node);
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
	    this.Visit(node.EnumBody);
	        
	}
	finally
	{
	    this.End(__annot1);
	}
}

public virtual void VisitMetaClass(MetaClassSyntax node)
{
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaClass));
	this.Begin(__annot2, node);
	try
	{
	    if (node.IsAbstract.GetMetaKind() != MetaSyntaxKind.None)
	    {
	        var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsAbstract", valuesOpt: ImmutableArray.Create<object?>(true));
	        this.Begin(__annot0, node.IsAbstract);
	        try
	        {
	            //this.VisitToken(node.IsAbstract);
	        }
	        finally
	        {
	            this.End(__annot0);
	        }
	    }
	    var __annot1 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
	    this.Begin(__annot1, node.ClassName);
	    try
	    {
	        this.Visit(node.ClassName);
	    }
	    finally
	    {
	        this.End(__annot1);
	    }
	    if (node.BaseClasses != null)
	    {
	        this.Visit(node.BaseClasses);
	    }
	    this.Visit(node.ClassBody);
	        
	}
	finally
	{
	    this.End(__annot2);
	}
}

public virtual void VisitEnumBody(EnumBodySyntax node)
{
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.ScopeBinder();
	this.Begin(__annot2, node);
	try
	{
	    var enumLiteralsList = node.EnumLiterals;
	    for (var enumLiteralsIndex = 0; enumLiteralsIndex < enumLiteralsList.Count; ++enumLiteralsIndex)
	    {
	        bool __itemHandled = false;
	        bool __sepHandled = false;
	        if (enumLiteralsIndex == 0)
	        {
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Literals");
	            this.Begin(__annot0, node.EnumLiterals[enumLiteralsIndex]);
	            try
	            {
	                this.Visit(node.EnumLiterals[enumLiteralsIndex]);
	            }
	            finally
	            {
	                this.End(__annot0);
	            }
	            __itemHandled = true;
	        }
	        if (!__itemHandled && enumLiteralsIndex < node.EnumLiterals.Count)
	        {
	            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Literals");
	            this.Begin(__annot1, node.EnumLiterals[enumLiteralsIndex]);
	            try
	            {
	                this.Visit(node.EnumLiterals[enumLiteralsIndex]);
	            }
	            finally
	            {
	                this.End(__annot1);
	            }
	        }
	        if (!__sepHandled && enumLiteralsIndex < node.EnumLiterals.SeparatorCount)
	        {
	            //this.VisitToken(node.EnumLiterals.GetSeparator(enumLiteralsIndex));
	        }
	    }
	        
	}
	finally
	{
	    this.End(__annot2);
	}
}

public virtual void VisitMetaEnumLiteral(MetaEnumLiteralSyntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaEnumLiteral));
	this.Begin(__annot1, node);
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
	        
	}
	finally
	{
	    this.End(__annot1);
	}
}

public virtual void VisitClassNameAlt1(ClassNameAlt1Syntax node)
{
	var __annot3 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
	this.Begin(__annot3, node);
	try
	{
	    var __annot2 = new MetaDslx.CodeAnalysis.Binding.IdentifierBinder();
	    this.Begin(__annot2, node);
	    try
	    {
	        if (node.Identifier != null)
	        {
	            this.Visit(node.Identifier);
	        }
	        var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "SymbolType");
	        this.Begin(__annot1, node.SymbolType);
	        try
	        {
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.Symbols.Symbol)), suffixes: ImmutableArray.Create<System.String>("Symbol"));
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
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
	this.Begin(__annot1, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.IdentifierBinder();
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
	finally
	{
	    this.End(__annot1);
	}
}

public virtual void VisitBaseClasses(BaseClassesSyntax node)
{
	var baseTypesList = node.BaseTypes;
	for (var baseTypesIndex = 0; baseTypesIndex < baseTypesList.Count; ++baseTypesIndex)
	{
	    bool __itemHandled = false;
	    bool __sepHandled = false;
	    if (baseTypesIndex == 0)
	    {
	        var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "BaseTypes");
	        this.Begin(__annot1, node.BaseTypes[baseTypesIndex]);
	        try
	        {
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaModel.Model.MetaClass)));
	            this.Begin(__annot0, node.BaseTypes[baseTypesIndex]);
	            try
	            {
	                this.Visit(node.BaseTypes[baseTypesIndex]);
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
	        __itemHandled = true;
	    }
	    if (!__itemHandled && baseTypesIndex < node.BaseTypes.Count)
	    {
	        var __annot3 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "BaseTypes");
	        this.Begin(__annot3, node.BaseTypes[baseTypesIndex]);
	        try
	        {
	            var __annot2 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaModel.Model.MetaClass)));
	            this.Begin(__annot2, node.BaseTypes[baseTypesIndex]);
	            try
	            {
	                this.Visit(node.BaseTypes[baseTypesIndex]);
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
	    if (!__sepHandled && baseTypesIndex < node.BaseTypes.SeparatorCount)
	    {
	        //this.VisitToken(node.BaseTypes.GetSeparator(baseTypesIndex));
	    }
	}
	    
}

public virtual void VisitClassBody(ClassBodySyntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.ScopeBinder();
	this.Begin(__annot0, node);
	try
	{
	    var classMemberListList = node.ClassMemberList;
	    for (var classMemberListIndex = 0; classMemberListIndex < classMemberListList.Count; ++classMemberListIndex)
	    {
	        this.Visit(node.ClassMemberList[classMemberListIndex]);
	    }
	        
	}
	finally
	{
	    this.End(__annot0);
	}
}

public virtual void VisitClassMemberAlt1(ClassMemberAlt1Syntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Properties");
	this.Begin(__annot0, node.Properties);
	try
	{
	    this.Visit(node.Properties);
	}
	finally
	{
	    this.End(__annot0);
	}
	    
}

public virtual void VisitClassMemberAlt2(ClassMemberAlt2Syntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Operations");
	this.Begin(__annot0, node.Operations);
	try
	{
	    this.Visit(node.Operations);
	}
	finally
	{
	    this.End(__annot0);
	}
	    
}

public virtual void VisitMetaProperty(MetaPropertySyntax node)
{
	var __annot4 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaProperty));
	this.Begin(__annot4, node);
	try
	{
	    if (node.Tokens.GetMetaKind() != MetaSyntaxKind.None)
	    {
	        if (node.Tokens.GetMetaKind() != MetaSyntaxKind.None)
	        {
	            switch (node.Tokens.GetMetaKind())
	            {
	                case MetaSyntaxKind.KContains:
	                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsContainment", valuesOpt: ImmutableArray.Create<object?>(true));
	                    this.Begin(__annot0, node.Tokens);
	                    try
	                    {
	                        //this.VisitToken(node.Tokens);
	                    }
	                    finally
	                    {
	                        this.End(__annot0);
	                    }
	                    break;
	                case MetaSyntaxKind.KDerived:
	                    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsDerived", valuesOpt: ImmutableArray.Create<object?>(true));
	                    this.Begin(__annot1, node.Tokens);
	                    try
	                    {
	                        //this.VisitToken(node.Tokens);
	                    }
	                    finally
	                    {
	                        this.End(__annot1);
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
	    var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Type");
	    this.Begin(__annot2, node.Type);
	    try
	    {
	        this.Visit(node.Type);
	    }
	    finally
	    {
	        this.End(__annot2);
	    }
	    var __annot3 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
	    this.Begin(__annot3, node.PropertyName);
	    try
	    {
	        this.Visit(node.PropertyName);
	    }
	    finally
	    {
	        this.End(__annot3);
	    }
	    var blockList = node.Block;
	    for (var blockIndex = 0; blockIndex < blockList.Count; ++blockIndex)
	    {
	        this.Visit(node.Block[blockIndex]);
	    }
	        
	}
	finally
	{
	    this.End(__annot4);
	}
}

public virtual void VisitPropertyNameAlt1(PropertyNameAlt1Syntax node)
{
	var __annot3 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
	this.Begin(__annot3, node);
	try
	{
	    var __annot2 = new MetaDslx.CodeAnalysis.Binding.IdentifierBinder();
	    this.Begin(__annot2, node);
	    try
	    {
	        if (node.Identifier != null)
	        {
	            this.Visit(node.Identifier);
	        }
	        var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "SymbolProperty");
	        this.Begin(__annot1, node.SymbolProperty);
	        try
	        {
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(System.String));
	            this.Begin(__annot0, node.SymbolProperty);
	            try
	            {
	                this.Visit(node.SymbolProperty);
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

public virtual void VisitPropertyNameAlt2(PropertyNameAlt2Syntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
	this.Begin(__annot1, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.IdentifierBinder();
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
	finally
	{
	    this.End(__annot1);
	}
}

public virtual void VisitMetaOperation(MetaOperationSyntax node)
{
	var __annot4 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaOperation));
	this.Begin(__annot4, node);
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
	    var parameterListList = node.ParameterList;
	    for (var parameterListIndex = 0; parameterListIndex < parameterListList.Count; ++parameterListIndex)
	    {
	        bool __itemHandled = false;
	        bool __sepHandled = false;
	        if (parameterListIndex == 0)
	        {
	            var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Parameters");
	            this.Begin(__annot2, node.ParameterList[parameterListIndex]);
	            try
	            {
	                this.Visit(node.ParameterList[parameterListIndex]);
	            }
	            finally
	            {
	                this.End(__annot2);
	            }
	            __itemHandled = true;
	        }
	        if (!__itemHandled && parameterListIndex < node.ParameterList.Count)
	        {
	            var __annot3 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Parameters");
	            this.Begin(__annot3, node.ParameterList[parameterListIndex]);
	            try
	            {
	                this.Visit(node.ParameterList[parameterListIndex]);
	            }
	            finally
	            {
	                this.End(__annot3);
	            }
	        }
	        if (!__sepHandled && parameterListIndex < node.ParameterList.SeparatorCount)
	        {
	            //this.VisitToken(node.ParameterList.GetSeparator(parameterListIndex));
	        }
	    }
	        
	}
	finally
	{
	    this.End(__annot4);
	}
}

public virtual void VisitMetaParameter(MetaParameterSyntax node)
{
	var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaParameter));
	this.Begin(__annot2, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Type");
	    this.Begin(__annot0, node.Type);
	    try
	    {
	        this.Visit(node.Type);
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
	finally
	{
	    this.End(__annot2);
	}
}

public virtual void VisitTypeReferenceTokens(TypeReferenceTokensSyntax node)
{

			if (node.Token.GetMetaKind() != MetaSyntaxKind.None)
			{
				//switch!!!
				var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
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
			else
			{
				// default
			}
	    
}

public virtual void VisitSimpleTypeReferenceAlt2(SimpleTypeReferenceAlt2Syntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.MetaType)));
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

public virtual void VisitMetaArrayType(MetaArrayTypeSyntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaArrayType));
	this.Begin(__annot1, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ItemType");
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

public virtual void VisitMetaNullableType(MetaNullableTypeSyntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaNullableType));
	this.Begin(__annot1, node);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "InnerType");
	    this.Begin(__annot0, node.InnerType);
	    try
	    {
	        this.Visit(node.InnerType);
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

public virtual void VisitQualifier(QualifierSyntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.QualifierBinder();
	this.Begin(__annot0, node);
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

public virtual void VisitEnumBodyEnumLiteralsBlock(EnumBodyEnumLiteralsBlockSyntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Literals");
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

public virtual void VisitBaseClassesBaseTypesBlock(BaseClassesBaseTypesBlockSyntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "BaseTypes");
	this.Begin(__annot1, node.BaseTypes);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaModel.Model.MetaClass)));
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

public virtual void VisitPropertyOpposite(PropertyOppositeSyntax node)
{
	var oppositePropertiesList = node.OppositeProperties;
	for (var oppositePropertiesIndex = 0; oppositePropertiesIndex < oppositePropertiesList.Count; ++oppositePropertiesIndex)
	{
	    bool __itemHandled = false;
	    bool __sepHandled = false;
	    if (oppositePropertiesIndex == 0)
	    {
	        var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "OppositeProperties");
	        this.Begin(__annot1, node.OppositeProperties[oppositePropertiesIndex]);
	        try
	        {
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaModel.Model.MetaProperty)));
	            this.Begin(__annot0, node.OppositeProperties[oppositePropertiesIndex]);
	            try
	            {
	                this.Visit(node.OppositeProperties[oppositePropertiesIndex]);
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
	        __itemHandled = true;
	    }
	    if (!__itemHandled && oppositePropertiesIndex < node.OppositeProperties.Count)
	    {
	        var __annot3 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "OppositeProperties");
	        this.Begin(__annot3, node.OppositeProperties[oppositePropertiesIndex]);
	        try
	        {
	            var __annot2 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaModel.Model.MetaProperty)));
	            this.Begin(__annot2, node.OppositeProperties[oppositePropertiesIndex]);
	            try
	            {
	                this.Visit(node.OppositeProperties[oppositePropertiesIndex]);
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
	    if (!__sepHandled && oppositePropertiesIndex < node.OppositeProperties.SeparatorCount)
	    {
	        //this.VisitToken(node.OppositeProperties.GetSeparator(oppositePropertiesIndex));
	    }
	}
	    
}

public virtual void VisitPropertySubsets(PropertySubsetsSyntax node)
{
	var subsettedPropertiesList = node.SubsettedProperties;
	for (var subsettedPropertiesIndex = 0; subsettedPropertiesIndex < subsettedPropertiesList.Count; ++subsettedPropertiesIndex)
	{
	    bool __itemHandled = false;
	    bool __sepHandled = false;
	    if (subsettedPropertiesIndex == 0)
	    {
	        var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "SubsettedProperties");
	        this.Begin(__annot1, node.SubsettedProperties[subsettedPropertiesIndex]);
	        try
	        {
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaModel.Model.MetaProperty)));
	            this.Begin(__annot0, node.SubsettedProperties[subsettedPropertiesIndex]);
	            try
	            {
	                this.Visit(node.SubsettedProperties[subsettedPropertiesIndex]);
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
	        __itemHandled = true;
	    }
	    if (!__itemHandled && subsettedPropertiesIndex < node.SubsettedProperties.Count)
	    {
	        var __annot3 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "SubsettedProperties");
	        this.Begin(__annot3, node.SubsettedProperties[subsettedPropertiesIndex]);
	        try
	        {
	            var __annot2 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaModel.Model.MetaProperty)));
	            this.Begin(__annot2, node.SubsettedProperties[subsettedPropertiesIndex]);
	            try
	            {
	                this.Visit(node.SubsettedProperties[subsettedPropertiesIndex]);
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
	    if (!__sepHandled && subsettedPropertiesIndex < node.SubsettedProperties.SeparatorCount)
	    {
	        //this.VisitToken(node.SubsettedProperties.GetSeparator(subsettedPropertiesIndex));
	    }
	}
	    
}

public virtual void VisitPropertyRedefines(PropertyRedefinesSyntax node)
{
	var redefinedPropertiesList = node.RedefinedProperties;
	for (var redefinedPropertiesIndex = 0; redefinedPropertiesIndex < redefinedPropertiesList.Count; ++redefinedPropertiesIndex)
	{
	    bool __itemHandled = false;
	    bool __sepHandled = false;
	    if (redefinedPropertiesIndex == 0)
	    {
	        var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "RedefinedProperties");
	        this.Begin(__annot1, node.RedefinedProperties[redefinedPropertiesIndex]);
	        try
	        {
	            var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaModel.Model.MetaProperty)));
	            this.Begin(__annot0, node.RedefinedProperties[redefinedPropertiesIndex]);
	            try
	            {
	                this.Visit(node.RedefinedProperties[redefinedPropertiesIndex]);
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
	        __itemHandled = true;
	    }
	    if (!__itemHandled && redefinedPropertiesIndex < node.RedefinedProperties.Count)
	    {
	        var __annot3 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "RedefinedProperties");
	        this.Begin(__annot3, node.RedefinedProperties[redefinedPropertiesIndex]);
	        try
	        {
	            var __annot2 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaModel.Model.MetaProperty)));
	            this.Begin(__annot2, node.RedefinedProperties[redefinedPropertiesIndex]);
	            try
	            {
	                this.Visit(node.RedefinedProperties[redefinedPropertiesIndex]);
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
	    if (!__sepHandled && redefinedPropertiesIndex < node.RedefinedProperties.SeparatorCount)
	    {
	        //this.VisitToken(node.RedefinedProperties.GetSeparator(redefinedPropertiesIndex));
	    }
	}
	    
}

public virtual void VisitPropertyOppositeOppositePropertiesBlock(PropertyOppositeOppositePropertiesBlockSyntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "OppositeProperties");
	this.Begin(__annot1, node.OppositeProperties);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaModel.Model.MetaProperty)));
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

public virtual void VisitPropertySubsetsSubsettedPropertiesBlock(PropertySubsetsSubsettedPropertiesBlockSyntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "SubsettedProperties");
	this.Begin(__annot1, node.SubsettedProperties);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaModel.Model.MetaProperty)));
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

public virtual void VisitPropertyRedefinesRedefinedPropertiesBlock(PropertyRedefinesRedefinedPropertiesBlockSyntax node)
{
	var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "RedefinedProperties");
	this.Begin(__annot1, node.RedefinedProperties);
	try
	{
	    var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaModel.Model.MetaProperty)));
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

public virtual void VisitMetaOperationParameterListBlock(MetaOperationParameterListBlockSyntax node)
{
	var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Parameters");
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

public virtual void VisitQualifierQualifierBlock(QualifierQualifierBlockSyntax node)
{
	this.Visit(node.Identifier);
	    
}

public virtual void VisitSkippedTokensTrivia(MetaSkippedTokensTriviaSyntax node)
{
}
    }
}
