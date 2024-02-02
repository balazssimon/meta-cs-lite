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
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaNamespace));
            this.Begin(__annot2, node);
            try
            {
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.NameBinder(qualifierProperty: MetaDslx.Languages.MetaModel.Model.Meta.MetaDeclaration_Declarations);
                this.Begin(__annot0, node.Qualifier);
                try
                {
                    this.Visit(node.Qualifier);
                }
                finally
                {
                    this.End(__annot0);
                }
                var usingListList = node.UsingList;
                for (var usingListIndex = 0; usingListIndex < usingListList.Count; ++usingListIndex)
                {
                    this.Visit(node.UsingList[usingListIndex]);
                }
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.ScopeBinder();
                this.Begin(__annot1, node.Block);
                try
                {
                    this.Visit(node.Block);
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

        public virtual void VisitMetaModel(MetaModelSyntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaModel));
            this.Begin(__annot0, node);
            try
            {
                this.Visit(node.Name);
                if (node.Block != null)
                {
                    this.Visit(node.Block);
                }
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitMetaDeclarationAlt1(MetaDeclarationAlt1Syntax node)
        {
            this.Visit(node.MetaConstant);
        }

        public virtual void VisitMetaDeclarationAlt2(MetaDeclarationAlt2Syntax node)
        {
            this.Visit(node.MetaEnum);
        }

        public virtual void VisitMetaDeclarationAlt3(MetaDeclarationAlt3Syntax node)
        {
            this.Visit(node.MetaClass);
        }

        public virtual void VisitMetaConstant(MetaConstantSyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaConstant));
            this.Begin(__annot1, node);
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
                this.Visit(node.Name);
            }
            finally
            {
                this.End(__annot1);
            }
        }

        public virtual void VisitMetaEnum(MetaEnumSyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaEnum));
            this.Begin(__annot1, node);
            try
            {
                this.Visit(node.Name);
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.ScopeBinder();
                this.Begin(__annot0, node.Block);
                try
                {
                    this.Visit(node.Block);
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

        public virtual void VisitMetaEnumLiteral(MetaEnumLiteralSyntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaEnumLiteral));
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

        public virtual void VisitMetaClass(MetaClassSyntax node)
        {
            var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaClass));
            this.Begin(__annot3, node);
            try
            {
                if (node.IsAbstract.GetMetaKind() != MetaSyntaxKind.None)
                {
                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsAbstract", values: ImmutableArray.Create<object?>(true));
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
                this.Begin(__annot1, node.Block1);
                try
                {
                    this.Visit(node.Block1);
                }
                finally
                {
                    this.End(__annot1);
                }
                if (node.Block2 != null)
                {
                    this.Visit(node.Block2);
                }
                var __annot2 = new MetaDslx.CodeAnalysis.Binding.ScopeBinder();
                this.Begin(__annot2, node.Block3);
                try
                {
                    this.Visit(node.Block3);
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

        public virtual void VisitMetaProperty(MetaPropertySyntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaProperty));
            this.Begin(__annot2, node);
            try
            {
                if (node.Block1 != null)
                {
                    this.Visit(node.Block1);
                }
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
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
                this.Begin(__annot1, node.Block2);
                try
                {
                    this.Visit(node.Block2);
                }
                finally
                {
                    this.End(__annot1);
                }
                if (node.Block3 != null)
                {
                    this.Visit(node.Block3);
                }
                var block4List = node.Block4;
                for (var block4Index = 0; block4Index < block4List.Count; ++block4Index)
                {
                    this.Visit(node.Block4[block4Index]);
                }
            }
            finally
            {
                this.End(__annot2);
            }
        }

        public virtual void VisitMetaOperation(MetaOperationSyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaOperation));
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
                this.Visit(node.Name);
                if (node.Block != null)
                {
                    this.Visit(node.Block);
                }
            }
            finally
            {
                this.End(__annot1);
            }
        }

        public virtual void VisitMetaParameter(MetaParameterSyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaModel.Model.MetaParameter));
            this.Begin(__annot1, node);
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
                this.Visit(node.Name);
            }
            finally
            {
                this.End(__annot1);
            }
        }

        public virtual void VisitSimpleTypeReference(SimpleTypeReferenceSyntax node)
        {
            this.Visit(node.TypeReference);
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

        public virtual void VisitTypeReferenceAlt1(TypeReferenceAlt1Syntax node)
        {
            this.Visit(node.PrimitiveType);
        }

        public virtual void VisitTypeReferenceAlt2(TypeReferenceAlt2Syntax node)
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

        public virtual void VisitPrimitiveType(PrimitiveTypeSyntax node)
        {
            if (node.Token.GetMetaKind() != MetaSyntaxKind.None)
            {
                switch (node.Token.GetMetaKind())
                {
                    case MetaSyntaxKind.KObject:
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
                        break;
                    case MetaSyntaxKind.KBool:
                        var __annot1 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot1, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot1);
                        }
                        break;
                    case MetaSyntaxKind.KChar:
                        var __annot2 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot2, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot2);
                        }
                        break;
                    case MetaSyntaxKind.KString:
                        var __annot3 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
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
                    case MetaSyntaxKind.KByte:
                        var __annot4 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot4, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot4);
                        }
                        break;
                    case MetaSyntaxKind.KSbyte:
                        var __annot5 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot5, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot5);
                        }
                        break;
                    case MetaSyntaxKind.KShort:
                        var __annot6 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot6, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot6);
                        }
                        break;
                    case MetaSyntaxKind.KUshort:
                        var __annot7 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot7, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot7);
                        }
                        break;
                    case MetaSyntaxKind.KInt:
                        var __annot8 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot8, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot8);
                        }
                        break;
                    case MetaSyntaxKind.KUint:
                        var __annot9 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot9, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot9);
                        }
                        break;
                    case MetaSyntaxKind.KLong:
                        var __annot10 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot10, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot10);
                        }
                        break;
                    case MetaSyntaxKind.KUlong:
                        var __annot11 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot11, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot11);
                        }
                        break;
                    case MetaSyntaxKind.KFloat:
                        var __annot12 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot12, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot12);
                        }
                        break;
                    case MetaSyntaxKind.KDouble:
                        var __annot13 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot13, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot13);
                        }
                        break;
                    case MetaSyntaxKind.KDecimal:
                        var __annot14 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot14, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot14);
                        }
                        break;
                    case MetaSyntaxKind.KType:
                        var __annot15 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot15, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot15);
                        }
                        break;
                    case MetaSyntaxKind.KSymbol:
                        var __annot16 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot16, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot16);
                        }
                        break;
                    case MetaSyntaxKind.KVoid:
                        var __annot17 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaType));
                        this.Begin(__annot17, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot17);
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

        public virtual void VisitValue(ValueSyntax node)
        {
            if (node.Token.GetMetaKind() != MetaSyntaxKind.None)
            {
                switch (node.Token.GetMetaKind())
                {
                    case MetaSyntaxKind.TString:
                        var __annot1 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaSymbol));
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
                        break;
                    case MetaSyntaxKind.TInteger:
                        var __annot3 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaSymbol));
                        this.Begin(__annot3, node.Token);
                        try
                        {
                            var __annot2 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(int));
                            this.Begin(__annot2, node.Token);
                            try
                            {
                                //this.VisitToken(node.Token);
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
                    case MetaSyntaxKind.TDecimal:
                        var __annot5 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaSymbol));
                        this.Begin(__annot5, node.Token);
                        try
                        {
                            var __annot4 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(string));
                            this.Begin(__annot4, node.Token);
                            try
                            {
                                //this.VisitToken(node.Token);
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
                    case MetaSyntaxKind.KTrue:
                        var __annot7 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaSymbol));
                        this.Begin(__annot7, node.Token);
                        try
                        {
                            var __annot6 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(bool));
                            this.Begin(__annot6, node.Token);
                            try
                            {
                                //this.VisitToken(node.Token);
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
                    case MetaSyntaxKind.KFalse:
                        var __annot9 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaSymbol));
                        this.Begin(__annot9, node.Token);
                        try
                        {
                            var __annot8 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(bool));
                            this.Begin(__annot8, node.Token);
                            try
                            {
                                //this.VisitToken(node.Token);
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
                    case MetaSyntaxKind.KNull:
                        var __annot10 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaSymbol));
                        this.Begin(__annot10, node.Token);
                        try
                        {
                            //this.VisitToken(node.Token);
                        }
                        finally
                        {
                            this.End(__annot10);
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
                var identifierList = node.Identifier;
                for (var identifierIndex = 0; identifierIndex < identifierList.Count; ++identifierIndex)
                {
                    bool __itemHandled = false;
                    bool __sepHandled = false;
                    if (identifierIndex == 0)
                    {
                        this.Visit(node.Identifier[identifierIndex]);
                        __itemHandled = true;
                    }
                    if (!__itemHandled && identifierIndex < node.Identifier.Count)
                    {
                        this.Visit(node.Identifier[identifierIndex]);
                    }
                    if (!__sepHandled && identifierIndex < node.Identifier.SeparatorCount)
                    {
                        //this.VisitToken(node.Identifier.GetSeparator(identifierIndex));
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

        public virtual void VisitMainBlock1(MainBlock1Syntax node)
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

        public virtual void VisitMetaModelBlock1(MetaModelBlock1Syntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Uri");
            this.Begin(__annot1, node.Uri);
            try
            {
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(string));
                this.Begin(__annot0, node.Uri);
                try
                {
                    //this.VisitToken(node.Uri);
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

        public virtual void VisitMetaEnumBlock1(MetaEnumBlock1Syntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.ScopeBinder();
            this.Begin(__annot2, node);
            try
            {
                var literalsList = node.Literals;
                for (var literalsIndex = 0; literalsIndex < literalsList.Count; ++literalsIndex)
                {
                    bool __itemHandled = false;
                    bool __sepHandled = false;
                    if (literalsIndex == 0)
                    {
                        var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Literals");
                        this.Begin(__annot0, node.Literals[literalsIndex]);
                        try
                        {
                            this.Visit(node.Literals[literalsIndex]);
                        }
                        finally
                        {
                            this.End(__annot0);
                        }
                        __itemHandled = true;
                    }
                    if (!__itemHandled && literalsIndex < node.Literals.Count)
                    {
                        var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Literals");
                        this.Begin(__annot1, node.Literals[literalsIndex]);
                        try
                        {
                            this.Visit(node.Literals[literalsIndex]);
                        }
                        finally
                        {
                            this.End(__annot1);
                        }
                    }
                    if (!__sepHandled && literalsIndex < node.Literals.SeparatorCount)
                    {
                        //this.VisitToken(node.Literals.GetSeparator(literalsIndex));
                    }
                }
            }
            finally
            {
                this.End(__annot2);
            }
        }

        public virtual void VisitMetaEnumBlock1literalsBlock(MetaEnumBlock1literalsBlockSyntax node)
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

        public virtual void VisitMetaClassBlock1Alt1(MetaClassBlock1Alt1Syntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
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
                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.Symbols.Symbol)), suffixes: ImmutableArray.Create<string>("Symbol"));
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

        public virtual void VisitMetaClassBlock1Alt2(MetaClassBlock1Alt2Syntax node)
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

        public virtual void VisitMetaClassBlock2(MetaClassBlock2Syntax node)
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

        public virtual void VisitMetaClassBlock2baseTypesBlock(MetaClassBlock2baseTypesBlockSyntax node)
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

        public virtual void VisitMetaClassBlock3(MetaClassBlock3Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ScopeBinder();
            this.Begin(__annot0, node);
            try
            {
                var blockList = node.Block;
                for (var blockIndex = 0; blockIndex < blockList.Count; ++blockIndex)
                {
                    this.Visit(node.Block[blockIndex]);
                }
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitMetaClassBlock3Block1Alt1(MetaClassBlock3Block1Alt1Syntax node)
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

        public virtual void VisitMetaClassBlock3Block1Alt2(MetaClassBlock3Block1Alt2Syntax node)
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

        public virtual void VisitMetaPropertyBlock1Alt1(MetaPropertyBlock1Alt1Syntax node)
        {
            if (node.IsReadOnly.GetMetaKind() != MetaSyntaxKind.None)
            {
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsReadOnly", values: ImmutableArray.Create<object?>(true));
                this.Begin(__annot0, node.IsReadOnly);
                try
                {
                    //this.VisitToken(node.IsReadOnly);
                }
                finally
                {
                    this.End(__annot0);
                }
            }
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsContainment", values: ImmutableArray.Create<object?>(true));
            this.Begin(__annot1, node.IsContainment);
            try
            {
                //this.VisitToken(node.IsContainment);
            }
            finally
            {
                this.End(__annot1);
            }
        }

        public virtual void VisitMetaPropertyBlock1Alt2(MetaPropertyBlock1Alt2Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsDerived", values: ImmutableArray.Create<object?>(true));
            this.Begin(__annot0, node.IsDerived);
            try
            {
                //this.VisitToken(node.IsDerived);
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitMetaPropertyBlock1Alt3(MetaPropertyBlock1Alt3Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsReadOnly", values: ImmutableArray.Create<object?>(true));
            this.Begin(__annot0, node.IsReadOnly);
            try
            {
                //this.VisitToken(node.IsReadOnly);
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitMetaPropertyBlock2Alt1(MetaPropertyBlock2Alt1Syntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
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
                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(string));
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

        public virtual void VisitMetaPropertyBlock2Alt2(MetaPropertyBlock2Alt2Syntax node)
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

        public virtual void VisitMetaPropertyBlock3(MetaPropertyBlock3Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "DefaultValue");
            this.Begin(__annot0, node.DefaultValue);
            try
            {
                this.Visit(node.DefaultValue);
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitMetaPropertyBlock4Alt1(MetaPropertyBlock4Alt1Syntax node)
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

        public virtual void VisitMetaPropertyBlock4Alt2(MetaPropertyBlock4Alt2Syntax node)
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

        public virtual void VisitMetaPropertyBlock4Alt3(MetaPropertyBlock4Alt3Syntax node)
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

        public virtual void VisitMetaPropertyBlock4Alt1oppositePropertiesBlock(MetaPropertyBlock4Alt1oppositePropertiesBlockSyntax node)
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

        public virtual void VisitMetaPropertyBlock4Alt2subsettedPropertiesBlock(MetaPropertyBlock4Alt2subsettedPropertiesBlockSyntax node)
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

        public virtual void VisitMetaPropertyBlock4Alt3redefinedPropertiesBlock(MetaPropertyBlock4Alt3redefinedPropertiesBlockSyntax node)
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

        public virtual void VisitMetaOperationBlock1(MetaOperationBlock1Syntax node)
        {
            var parametersList = node.Parameters;
            for (var parametersIndex = 0; parametersIndex < parametersList.Count; ++parametersIndex)
            {
                bool __itemHandled = false;
                bool __sepHandled = false;
                if (parametersIndex == 0)
                {
                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Parameters");
                    this.Begin(__annot0, node.Parameters[parametersIndex]);
                    try
                    {
                        this.Visit(node.Parameters[parametersIndex]);
                    }
                    finally
                    {
                        this.End(__annot0);
                    }
                    __itemHandled = true;
                }
                if (!__itemHandled && parametersIndex < node.Parameters.Count)
                {
                    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Parameters");
                    this.Begin(__annot1, node.Parameters[parametersIndex]);
                    try
                    {
                        this.Visit(node.Parameters[parametersIndex]);
                    }
                    finally
                    {
                        this.End(__annot1);
                    }
                }
                if (!__sepHandled && parametersIndex < node.Parameters.SeparatorCount)
                {
                    //this.VisitToken(node.Parameters.GetSeparator(parametersIndex));
                }
            }
        }

        public virtual void VisitMetaOperationBlock1parametersBlock(MetaOperationBlock1parametersBlockSyntax node)
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

        public virtual void VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            this.Visit(node.Identifier);
        }

        public virtual void VisitSkippedTokensTrivia(MetaSkippedTokensTriviaSyntax node)
        {
        }
    }
}
