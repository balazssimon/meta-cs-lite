using System;
using System.Collections.Immutable;
using MetaDslx.CodeAnalysis;

#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Compiler.Binding
{
    using global::MetaDslx.Languages.MetaSymbols.Compiler.Syntax;

    public class SymbolBinderFactoryVisitor : MetaDslx.CodeAnalysis.Binding.BinderFactoryVisitor, ISymbolSyntaxVisitor
    {
        internal SymbolBinderFactoryVisitor(MetaDslx.CodeAnalysis.Binding.BinderFactory binderFactory)
            : base(binderFactory)
        {
        }


        public virtual void VisitMain(MainSyntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaSymbols.Model.Namespace));
            this.Begin(__annot2, node);
            try
            {
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.NameBinder(qualifierProperty: MetaDslx.Languages.MetaSymbols.Model.Symbols.Declaration_Declarations);
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

        public virtual void VisitSymbol(SymbolSyntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaSymbols.Model.Symbol));
            this.Begin(__annot2, node);
            try
            {
                if (node.IsAbstract.GetSymbolKind() != SymbolSyntaxKind.None)
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
                this.Visit(node.Name);
                if (node.Block1 != null)
                {
                    this.Visit(node.Block1);
                }
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.ScopeBinder();
                this.Begin(__annot1, node.Block2);
                try
                {
                    this.Visit(node.Block2);
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

        public virtual void VisitProperty(PropertySyntax node)
        {
            var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaSymbols.Model.Property));
            this.Begin(__annot3, node);
            try
            {
                if (node.IsWeak.GetSymbolKind() != SymbolSyntaxKind.None)
                {
                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsWeak", values: ImmutableArray.Create<object?>(true));
                    this.Begin(__annot0, node.IsWeak);
                    try
                    {
                        //this.VisitToken(node.IsWeak);
                    }
                    finally
                    {
                        this.End(__annot0);
                    }
                }
                if (node.IsDerived.GetSymbolKind() != SymbolSyntaxKind.None)
                {
                    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsDerived", values: ImmutableArray.Create<object?>(true));
                    this.Begin(__annot1, node.IsDerived);
                    try
                    {
                        //this.VisitToken(node.IsDerived);
                    }
                    finally
                    {
                        this.End(__annot1);
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
                this.Visit(node.Name);
                if (node.Block1 != null)
                {
                    this.Visit(node.Block1);
                }
                if (node.Block2 != null)
                {
                    this.Visit(node.Block2);
                }
            }
            finally
            {
                this.End(__annot3);
            }
        }

        public virtual void VisitOperationAlt1(OperationAlt1Syntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaSymbols.Model.Operation));
            this.Begin(__annot1, node);
            try
            {
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsPhase", values: ImmutableArray.Create<object?>(true));
                this.Begin(__annot0, node.IsPhase);
                try
                {
                    //this.VisitToken(node.IsPhase);
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

        public virtual void VisitOperationAlt2(OperationAlt2Syntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaSymbols.Model.Operation));
            this.Begin(__annot2, node);
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
                if (node.Block1 != null)
                {
                    this.Visit(node.Block1);
                }
                if (node.CacheResult.GetSymbolKind() != SymbolSyntaxKind.None)
                {
                    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "CacheResult", values: ImmutableArray.Create<object?>(true));
                    this.Begin(__annot1, node.CacheResult);
                    try
                    {
                        //this.VisitToken(node.CacheResult);
                    }
                    finally
                    {
                        this.End(__annot1);
                    }
                }
                if (node.Block2 != null)
                {
                    this.Visit(node.Block2);
                }
            }
            finally
            {
                this.End(__annot2);
            }
        }

        public virtual void VisitParameter(ParameterSyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaSymbols.Model.Parameter));
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

        public virtual void VisitTypeReference(TypeReferenceSyntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaSymbols.Model.TypeReference));
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
                if (node.Block != null)
                {
                    this.Visit(node.Block);
                }
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Dimensions");
                this.Begin(__annot1, node.Dimensions);
                try
                {
                    this.Visit(node.Dimensions);
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

        public virtual void VisitArrayDimensions(ArrayDimensionsSyntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(int));
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSimpleTypeReferenceAlt1(SimpleTypeReferenceAlt1Syntax node)
        {
            this.Visit(node.PrimitiveType);
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

        public virtual void VisitPrimitiveType(PrimitiveTypeSyntax node)
        {
            if (node.Token.GetSymbolKind() != SymbolSyntaxKind.None)
            {
                switch (node.Token.GetSymbolKind())
                {
                    case SymbolSyntaxKind.KObject:
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
                    case SymbolSyntaxKind.KBool:
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
                    case SymbolSyntaxKind.KChar:
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
                    case SymbolSyntaxKind.KString:
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
                    case SymbolSyntaxKind.KByte:
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
                    case SymbolSyntaxKind.KSbyte:
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
                    case SymbolSyntaxKind.KShort:
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
                    case SymbolSyntaxKind.KUshort:
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
                    case SymbolSyntaxKind.KInt:
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
                    case SymbolSyntaxKind.KUint:
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
                    case SymbolSyntaxKind.KLong:
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
                    case SymbolSyntaxKind.KUlong:
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
                    case SymbolSyntaxKind.KFloat:
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
                    case SymbolSyntaxKind.KDouble:
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
                    case SymbolSyntaxKind.KDecimal:
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
                    case SymbolSyntaxKind.KType:
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
                    case SymbolSyntaxKind.KSymbol:
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
                    case SymbolSyntaxKind.KVoid:
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

        public virtual void VisitValueAlt1(ValueAlt1Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaSymbol));
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitValueAlt2(ValueAlt2Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaSymbol));
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitValueAlt3(ValueAlt3Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaSymbol));
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitValueAlt4(ValueAlt4Syntax node)
        {
            this.Visit(node.TBoolean);
        }

        public virtual void VisitValueAlt5(ValueAlt5Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(MetaDslx.CodeAnalysis.MetaSymbol));
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitValueAlt6(ValueAlt6Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol)));
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

        public virtual void VisitTBoolean(TBooleanSyntax node)
        {
            if (node.Token.GetSymbolKind() != SymbolSyntaxKind.None)
            {
                switch (node.Token.GetSymbolKind())
                {
                    case SymbolSyntaxKind.KTrue:
                        var __annot1 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(bool));
                        this.Begin(__annot1, node.Token);
                        try
                        {
                            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(bool));
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
                    case SymbolSyntaxKind.KFalse:
                        var __annot3 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(bool));
                        this.Begin(__annot3, node.Token);
                        try
                        {
                            var __annot2 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(bool));
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
                    default:
                        break;
                }
            }
            else
            {
                // default
            }
        }

        public virtual void VisitMainBlock1(MainBlock1Syntax node)
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

        public virtual void VisitSymbolBlock1(SymbolBlock1Syntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "BaseTypes");
            this.Begin(__annot1, node.BaseTypes);
            try
            {
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaSymbols.Model.Symbol)));
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

        public virtual void VisitSymbolBlock2(SymbolBlock2Syntax node)
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

        public virtual void VisitSymbolBlock2Block1Alt1(SymbolBlock2Block1Alt1Syntax node)
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

        public virtual void VisitSymbolBlock2Block1Alt2(SymbolBlock2Block1Alt2Syntax node)
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

        public virtual void VisitPropertyBlock1(PropertyBlock1Syntax node)
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

        public virtual void VisitPropertyBlock2(PropertyBlock2Syntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Phase");
            this.Begin(__annot1, node.Phase);
            try
            {
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaSymbols.Model.Property)));
                this.Begin(__annot0, node.Phase);
                try
                {
                    this.Visit(node.Phase);
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

        public virtual void VisitOperationAlt2Block1(OperationAlt2Block1Syntax node)
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

        public virtual void VisitOperationAlt2Block1parametersBlock(OperationAlt2Block1parametersBlockSyntax node)
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

        public virtual void VisitOperationAlt2Block2(OperationAlt2Block2Syntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "CacheCondition");
            this.Begin(__annot1, node.CacheCondition);
            try
            {
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(string));
                this.Begin(__annot0, node.CacheCondition);
                try
                {
                    //this.VisitToken(node.CacheCondition);
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

        public virtual void VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsNullable", values: ImmutableArray.Create<object?>(true));
            this.Begin(__annot0, node.IsNullable);
            try
            {
                //this.VisitToken(node.IsNullable);
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitArrayDimensionsBlock1(ArrayDimensionsBlock1Syntax node)
        {
        }

        public virtual void VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            this.Visit(node.Identifier);
        }

        public virtual void VisitSkippedTokensTrivia(SymbolSkippedTokensTriviaSyntax node)
        {
        }
    }
}
