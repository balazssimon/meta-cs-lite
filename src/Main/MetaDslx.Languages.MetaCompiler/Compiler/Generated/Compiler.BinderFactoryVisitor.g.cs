using System;
using System.Collections.Immutable;
using MetaDslx.CodeAnalysis;

#pragma warning disable CS8669

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
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol));
            this.Begin(__annot2, node);
            try
            {
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
                this.Begin(__annot0, node.Qualifier);
                try
                {
                    this.Visit(node.Qualifier);
                }
                finally
                {
                    this.End(__annot0);
                }
                var block1List = node.Block1;
                for (var block1Index = 0; block1Index < block1List.Count; ++block1Index)
                {
                    this.Visit(node.Block1[block1Index]);
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

        public virtual void VisitUsingMetaModel(UsingMetaModelSyntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.CodeAnalysis.Symbols.ImportMetaModelSymbol));
            this.Begin(__annot2, node);
            try
            {
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "MetaModelSymbols");
                this.Begin(__annot1, node.MetaModelSymbols);
                try
                {
                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Modeling.MetaModel), typeof(MetaDslx.Languages.MetaModel.Model.MetaModel)));
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
            finally
            {
                this.End(__annot2);
            }
        }

        public virtual void VisitUsingAlt2(UsingAlt2Syntax node)
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

        public virtual void VisitLanguageDeclaration(LanguageDeclarationSyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Language));
            this.Begin(__annot1, node);
            try
            {
                this.Visit(node.Name);
                if (node.Block != null)
                {
                    this.Visit(node.Block);
                }
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Grammar");
                this.Begin(__annot0, node.Grammar);
                try
                {
                    this.Visit(node.Grammar);
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

        public virtual void VisitGrammar(GrammarSyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Grammar));
            this.Begin(__annot1, node);
            try
            {
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

        public virtual void VisitGrammarRuleAlt1(GrammarRuleAlt1Syntax node)
        {
            this.Visit(node.Rule);
        }

        public virtual void VisitGrammarRuleAlt2(GrammarRuleAlt2Syntax node)
        {
            this.Visit(node.LexerRule);
        }

        public virtual void VisitRule(RuleSyntax node)
        {
            var __annot4 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Rule));
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
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
                this.Begin(__annot1, node.Block);
                try
                {
                    this.Visit(node.Block);
                }
                finally
                {
                    this.End(__annot1);
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
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Element));
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

        public virtual void VisitElementValueAlt1(ElementValueAlt1Syntax node)
        {
            this.Visit(node.Block);
        }

        public virtual void VisitElementValueAlt2(ElementValueAlt2Syntax node)
        {
            this.Visit(node.Eof1);
        }

        public virtual void VisitElementValueAlt3(ElementValueAlt3Syntax node)
        {
            this.Visit(node.Fixed);
        }

        public virtual void VisitElementValueAlt4(ElementValueAlt4Syntax node)
        {
            this.Visit(node.RuleRef);
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
                if (node.Multiplicity != null)
                {
                    var __annot3 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Multiplicity");
                    this.Begin(__annot3, node.Multiplicity);
                    try
                    {
                        this.Visit(node.Multiplicity);
                    }
                    finally
                    {
                        this.End(__annot3);
                    }
                }
            }
            finally
            {
                this.End(__annot4);
            }
        }

        public virtual void VisitBlockAlternative(BlockAlternativeSyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Alternative));
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

        public virtual void VisitRuleRefAlt1(RuleRefAlt1Syntax node)
        {
            var __annot4 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.RuleRef));
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
                var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "GrammarRule");
                this.Begin(__annot2, node.GrammarRule);
                try
                {
                    var __annot1 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Languages.MetaCompiler.Model.GrammarRule)));
                    this.Begin(__annot1, node.GrammarRule);
                    try
                    {
                        this.Visit(node.GrammarRule);
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
                if (node.Multiplicity != null)
                {
                    var __annot3 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Multiplicity");
                    this.Begin(__annot3, node.Multiplicity);
                    try
                    {
                        this.Visit(node.Multiplicity);
                    }
                    finally
                    {
                        this.End(__annot3);
                    }
                }
            }
            finally
            {
                this.End(__annot4);
            }
        }

        public virtual void VisitRuleRefAlt2(RuleRefAlt2Syntax node)
        {
            var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.RuleRef));
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
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ReferencedTypes");
                this.Begin(__annot1, node.ReferencedTypes);
                try
                {
                    this.Visit(node.ReferencedTypes);
                }
                finally
                {
                    this.End(__annot1);
                }
                if (node.Multiplicity != null)
                {
                    var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Multiplicity");
                    this.Begin(__annot2, node.Multiplicity);
                    try
                    {
                        this.Visit(node.Multiplicity);
                    }
                    finally
                    {
                        this.End(__annot2);
                    }
                }
            }
            finally
            {
                this.End(__annot3);
            }
        }

        public virtual void VisitRuleRefAlt3(RuleRefAlt3Syntax node)
        {
            var __annot4 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.RuleRef));
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
                var referencedTypesList = node.ReferencedTypes;
                for (var referencedTypesIndex = 0; referencedTypesIndex < referencedTypesList.Count; ++referencedTypesIndex)
                {
                    bool __itemHandled = false;
                    bool __sepHandled = false;
                    if (referencedTypesIndex == 0)
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
                        __itemHandled = true;
                    }
                    if (!__itemHandled && referencedTypesIndex < node.ReferencedTypes.Count)
                    {
                        var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ReferencedTypes");
                        this.Begin(__annot2, node.ReferencedTypes[referencedTypesIndex]);
                        try
                        {
                            this.Visit(node.ReferencedTypes[referencedTypesIndex]);
                        }
                        finally
                        {
                            this.End(__annot2);
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
                if (node.Multiplicity != null)
                {
                    var __annot3 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Multiplicity");
                    this.Begin(__annot3, node.Multiplicity);
                    try
                    {
                        this.Visit(node.Multiplicity);
                    }
                    finally
                    {
                        this.End(__annot3);
                    }
                }
            }
            finally
            {
                this.End(__annot4);
            }
        }

        public virtual void VisitEof1(Eof1Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Eof));
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitFixed(FixedSyntax node)
        {
            var __annot4 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Fixed));
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
                var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Text");
                this.Begin(__annot2, node.Text);
                try
                {
                    var __annot1 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(string));
                    this.Begin(__annot1, node.Text);
                    try
                    {
                        //this.VisitToken(node.Text);
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
                if (node.Multiplicity != null)
                {
                    var __annot3 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Multiplicity");
                    this.Begin(__annot3, node.Multiplicity);
                    try
                    {
                        this.Visit(node.Multiplicity);
                    }
                    finally
                    {
                        this.End(__annot3);
                    }
                }
            }
            finally
            {
                this.End(__annot4);
            }
        }

        public virtual void VisitLexerRuleAlt1(LexerRuleAlt1Syntax node)
        {
            this.Visit(node.Token);
        }

        public virtual void VisitLexerRuleAlt2(LexerRuleAlt2Syntax node)
        {
            this.Visit(node.Fragment);
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
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Fragment));
            this.Begin(__annot2, node);
            try
            {
                this.Visit(node.Name);
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
            var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.LElement));
            this.Begin(__annot3, node);
            try
            {
                if (node.IsNegated.GetCompilerKind() != CompilerSyntaxKind.None)
                {
                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsNegated", values: ImmutableArray.Create<object?>(true));
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
                if (node.Multiplicity != null)
                {
                    var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Multiplicity");
                    this.Begin(__annot2, node.Multiplicity);
                    try
                    {
                        this.Visit(node.Multiplicity);
                    }
                    finally
                    {
                        this.End(__annot2);
                    }
                }
            }
            finally
            {
                this.End(__annot3);
            }
        }

        public virtual void VisitLElementValueAlt1(LElementValueAlt1Syntax node)
        {
            this.Visit(node.LBlock);
        }

        public virtual void VisitLElementValueAlt2(LElementValueAlt2Syntax node)
        {
            this.Visit(node.LFixed);
        }

        public virtual void VisitLElementValueAlt3(LElementValueAlt3Syntax node)
        {
            this.Visit(node.LWildCard);
        }

        public virtual void VisitLElementValueAlt4(LElementValueAlt4Syntax node)
        {
            this.Visit(node.LRange);
        }

        public virtual void VisitLElementValueAlt5(LElementValueAlt5Syntax node)
        {
            this.Visit(node.LReference);
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

        public virtual void VisitLFixed(LFixedSyntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.LFixed));
            this.Begin(__annot2, node);
            try
            {
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Text");
                this.Begin(__annot1, node.Text);
                try
                {
                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder(type: typeof(string));
                    this.Begin(__annot0, node.Text);
                    try
                    {
                        //this.VisitToken(node.Text);
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

        public virtual void VisitLWildCard(LWildCardSyntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.LWildCard));
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

        public virtual void VisitExpressionAlt1(ExpressionAlt1Syntax node)
        {
            this.Visit(node.SingleExpression);
        }

        public virtual void VisitExpressionAlt2(ExpressionAlt2Syntax node)
        {
            this.Visit(node.ArrayExpression);
        }

        public virtual void VisitSingleExpressionAlt1(SingleExpressionAlt1Syntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Expression));
            this.Begin(__annot2, node);
            try
            {
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Value");
                this.Begin(__annot1, node.Value);
                try
                {
                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder();
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
            finally
            {
                this.End(__annot2);
            }
        }

        public virtual void VisitSingleExpressionAlt2(SingleExpressionAlt2Syntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Expression));
            this.Begin(__annot2, node);
            try
            {
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Value");
                this.Begin(__annot1, node.Value);
                try
                {
                    var __annot0 = new MetaDslx.Languages.MetaCompiler.Symbols.ExpressionValueBinder();
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
            finally
            {
                this.End(__annot2);
            }
        }

        public virtual void VisitArrayExpression(ArrayExpressionSyntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.ArrayExpression));
            this.Begin(__annot0, node);
            try
            {
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

        public virtual void VisitParserAnnotation(ParserAnnotationSyntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Annotation));
            this.Begin(__annot2, node);
            try
            {
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "AttributeClass");
                this.Begin(__annot1, node.AttributeClass);
                try
                {
                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.Binding.Binder), typeof(MetaDslx.CodeAnalysis.Annotations.Annotation)), suffixes: ImmutableArray.Create<string>("Binder", "Annotation"));
                    this.Begin(__annot0, node.AttributeClass);
                    try
                    {
                        this.Visit(node.AttributeClass);
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

        public virtual void VisitLexerAnnotation(LexerAnnotationSyntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Languages.MetaCompiler.Model.Annotation));
            this.Begin(__annot2, node);
            try
            {
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "AttributeClass");
                this.Begin(__annot1, node.AttributeClass);
                try
                {
                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.Syntax.TokenKind), typeof(MetaDslx.CodeAnalysis.Annotations.Annotation)), suffixes: ImmutableArray.Create<string>("TokenKind", "Annotation"));
                    this.Begin(__annot0, node.AttributeClass);
                    try
                    {
                        this.Visit(node.AttributeClass);
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

        public virtual void VisitAssignment(AssignmentSyntax node)
        {
            if (node.Token.GetCompilerKind() != CompilerSyntaxKind.None)
            {
                switch (node.Token.GetCompilerKind())
                {
                    case CompilerSyntaxKind.TEq:
                        var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Assignment.Assign);
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
                    case CompilerSyntaxKind.TQuestionEq:
                        var __annot1 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Assignment.QuestionAssign);
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
                    case CompilerSyntaxKind.TExclEq:
                        var __annot2 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Assignment.NegatedAssign);
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
                    case CompilerSyntaxKind.TPlusEq:
                        var __annot3 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Assignment.PlusAssign);
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

        public virtual void VisitMultiplicity(MultiplicitySyntax node)
        {
            if (node.Token.GetCompilerKind() != CompilerSyntaxKind.None)
            {
                switch (node.Token.GetCompilerKind())
                {
                    case CompilerSyntaxKind.TQuestion:
                        var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.ZeroOrOne);
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
                    case CompilerSyntaxKind.TAsterisk:
                        var __annot1 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.ZeroOrMore);
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
                    case CompilerSyntaxKind.TPlus:
                        var __annot2 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.OneOrMore);
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
                    case CompilerSyntaxKind.TQuestionQuestion:
                        var __annot3 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.NonGreedyZeroOrOne);
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
                    case CompilerSyntaxKind.TAsteriskQuestion:
                        var __annot4 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.NonGreedyZeroOrMore);
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
                    case CompilerSyntaxKind.TPlusQuestion:
                        var __annot5 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Languages.MetaCompiler.Model.Multiplicity.NonGreedyOneOrMore);
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
                    default:
                        break;
                }
            }
            else
            {
                // default
            }
        }

        public virtual void VisitTypeReferenceIdentifierAlt1(TypeReferenceIdentifierAlt1Syntax node)
        {
            this.Visit(node.PrimitiveType);
        }

        public virtual void VisitTypeReferenceIdentifierAlt2(TypeReferenceIdentifierAlt2Syntax node)
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
            if (node.Token.GetCompilerKind() != CompilerSyntaxKind.None)
            {
                switch (node.Token.GetCompilerKind())
                {
                    case CompilerSyntaxKind.KObject:
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
                    case CompilerSyntaxKind.KBool:
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
                    case CompilerSyntaxKind.KChar:
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
                    case CompilerSyntaxKind.KString:
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
                    case CompilerSyntaxKind.KByte:
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
                    case CompilerSyntaxKind.KSbyte:
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
                    case CompilerSyntaxKind.KShort:
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
                    case CompilerSyntaxKind.KUshort:
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
                    case CompilerSyntaxKind.KInt:
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
                    case CompilerSyntaxKind.KUint:
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
                    case CompilerSyntaxKind.KLong:
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
                    case CompilerSyntaxKind.KUlong:
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
                    case CompilerSyntaxKind.KFloat:
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
                    case CompilerSyntaxKind.KDouble:
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
                    case CompilerSyntaxKind.KDecimal:
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
                    case CompilerSyntaxKind.KType:
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
                    case CompilerSyntaxKind.KSymbol:
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
                    case CompilerSyntaxKind.KVoid:
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
            this.Visit(node.Using);
        }

        public virtual void VisitMainBlock2(MainBlock2Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ScopeBinder();
            this.Begin(__annot0, node);
            try
            {
                this.Visit(node.LanguageDeclaration);
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitLanguageDeclarationBlock1(LanguageDeclarationBlock1Syntax node)
        {
            var baseLanguagesList = node.BaseLanguages;
            for (var baseLanguagesIndex = 0; baseLanguagesIndex < baseLanguagesList.Count; ++baseLanguagesIndex)
            {
                bool __itemHandled = false;
                bool __sepHandled = false;
                if (baseLanguagesIndex == 0)
                {
                    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "BaseLanguages");
                    this.Begin(__annot1, node.BaseLanguages[baseLanguagesIndex]);
                    try
                    {
                        var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.Language)), suffixes: ImmutableArray.Create<string>("Language"));
                        this.Begin(__annot0, node.BaseLanguages[baseLanguagesIndex]);
                        try
                        {
                            this.Visit(node.BaseLanguages[baseLanguagesIndex]);
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
                if (!__itemHandled && baseLanguagesIndex < node.BaseLanguages.Count)
                {
                    var __annot3 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "BaseLanguages");
                    this.Begin(__annot3, node.BaseLanguages[baseLanguagesIndex]);
                    try
                    {
                        var __annot2 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.Language)), suffixes: ImmutableArray.Create<string>("Language"));
                        this.Begin(__annot2, node.BaseLanguages[baseLanguagesIndex]);
                        try
                        {
                            this.Visit(node.BaseLanguages[baseLanguagesIndex]);
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
                if (!__sepHandled && baseLanguagesIndex < node.BaseLanguages.SeparatorCount)
                {
                    //this.VisitToken(node.BaseLanguages.GetSeparator(baseLanguagesIndex));
                }
            }
        }

        public virtual void VisitLanguageDeclarationBlock1baseLanguagesBlock(LanguageDeclarationBlock1baseLanguagesBlockSyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "BaseLanguages");
            this.Begin(__annot1, node.BaseLanguages);
            try
            {
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.CodeAnalysis.Language)), suffixes: ImmutableArray.Create<string>("Language"));
                this.Begin(__annot0, node.BaseLanguages);
                try
                {
                    this.Visit(node.BaseLanguages);
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

        public virtual void VisitRulealternativesBlock(RulealternativesBlockSyntax node)
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
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.NameBinder();
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

        public virtual void VisitAlternativeBlock1Block1Alt1(AlternativeBlock1Block1Alt1Syntax node)
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

        public virtual void VisitAlternativeBlock1Block1Alt2(AlternativeBlock1Block1Alt2Syntax node)
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
            this.Visit(node.Name);
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Assignment");
            this.Begin(__annot1, node.Assignment);
            try
            {
                this.Visit(node.Assignment);
            }
            finally
            {
                this.End(__annot1);
            }
        }

        public virtual void VisitBlockalternativesBlock(BlockalternativesBlockSyntax node)
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

        public virtual void VisitBlockAlternativeBlock1(BlockAlternativeBlock1Syntax node)
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

        public virtual void VisitRuleRefAlt3referencedTypesBlock(RuleRefAlt3referencedTypesBlockSyntax node)
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
            this.Visit(node.Name);
            if (node.Block != null)
            {
                this.Visit(node.Block);
            }
        }

        public virtual void VisitTokenBlock1Alt2(TokenBlock1Alt2Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsTrivia", values: ImmutableArray.Create<object?>(true));
            this.Begin(__annot0, node.IsTrivia);
            try
            {
                //this.VisitToken(node.IsTrivia);
            }
            finally
            {
                this.End(__annot0);
            }
            this.Visit(node.Name);
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

        public virtual void VisitTokenalternativesBlock(TokenalternativesBlockSyntax node)
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

        public virtual void VisitFragmentalternativesBlock(FragmentalternativesBlockSyntax node)
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

        public virtual void VisitLBlockalternativesBlock(LBlockalternativesBlockSyntax node)
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

        public virtual void VisitSingleExpressionAlt1Block1Alt1(SingleExpressionAlt1Block1Alt1Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder();
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt2(SingleExpressionAlt1Block1Alt2Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder();
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt3(SingleExpressionAlt1Block1Alt3Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder();
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt4(SingleExpressionAlt1Block1Alt4Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder();
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt5(SingleExpressionAlt1Block1Alt5Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder();
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt6(SingleExpressionAlt1Block1Alt6Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder();
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSingleExpressionAlt1Block1Alt7(SingleExpressionAlt1Block1Alt7Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ValueBinder();
            this.Begin(__annot0, node);
            try
            {
                this.Visit(node.PrimitiveType);
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitArrayExpressionBlock1(ArrayExpressionBlock1Syntax node)
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

        public virtual void VisitArrayExpressionBlock1itemsBlock(ArrayExpressionBlock1itemsBlockSyntax node)
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

        public virtual void VisitParserAnnotationBlock1(ParserAnnotationBlock1Syntax node)
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

        public virtual void VisitParserAnnotationBlock1argumentsBlock(ParserAnnotationBlock1argumentsBlockSyntax node)
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

        public virtual void VisitLexerAnnotationBlock1(LexerAnnotationBlock1Syntax node)
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

        public virtual void VisitLexerAnnotationBlock1argumentsBlock(LexerAnnotationBlock1argumentsBlockSyntax node)
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

        public virtual void VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            this.Visit(node.Identifier);
        }

        public virtual void VisitSkippedTokensTrivia(CompilerSkippedTokensTriviaSyntax node)
        {
        }
    }
}
