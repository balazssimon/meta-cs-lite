using System;
using System.Collections.Immutable;
using MetaDslx.CodeAnalysis;

#nullable enable

namespace MetaDslx.Examples.Soal.Compiler.Binding
{
    using global::MetaDslx.Examples.Soal.Compiler.Syntax;

    public class SoalBinderFactoryVisitor : MetaDslx.CodeAnalysis.Binding.BinderFactoryVisitor, ISoalSyntaxVisitor
    {
        internal SoalBinderFactoryVisitor(MetaDslx.CodeAnalysis.Binding.BinderFactory binderFactory)
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

        public virtual void VisitDeclarationAlt1(DeclarationAlt1Syntax node)
        {
            this.Visit(node.EnumType);
        }

        public virtual void VisitDeclarationAlt2(DeclarationAlt2Syntax node)
        {
            this.Visit(node.StructType);
        }

        public virtual void VisitDeclarationAlt3(DeclarationAlt3Syntax node)
        {
            this.Visit(node.Interface);
        }

        public virtual void VisitDeclarationAlt4(DeclarationAlt4Syntax node)
        {
            this.Visit(node.Service);
        }

        public virtual void VisitEnumType(EnumTypeSyntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.EnumType));
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

        public virtual void VisitEnumLiteral(EnumLiteralSyntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.EnumLiteral));
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

        public virtual void VisitStructType(StructTypeSyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.StructType));
            this.Begin(__annot1, node);
            try
            {
                this.Visit(node.Name);
                if (node.Block != null)
                {
                    this.Visit(node.Block);
                }
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Fields");
                this.Begin(__annot0, node.Fields.Node);
                try
                {
                    var fieldsList = node.Fields;
                    for (var fieldsIndex = 0; fieldsIndex < fieldsList.Count; ++fieldsIndex)
                    {
                        this.Visit(node.Fields[fieldsIndex]);
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

        public virtual void VisitProperty(PropertySyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.Property));
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

        public virtual void VisitInterface(InterfaceSyntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.Interface));
            this.Begin(__annot2, node);
            try
            {
                this.Visit(node.Name);
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Resources");
                this.Begin(__annot0, node.Resources.Node);
                try
                {
                    var resourcesList = node.Resources;
                    for (var resourcesIndex = 0; resourcesIndex < resourcesList.Count; ++resourcesIndex)
                    {
                        this.Visit(node.Resources[resourcesIndex]);
                    }
                }
                finally
                {
                    this.End(__annot0);
                }
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Operations");
                this.Begin(__annot1, node.Operations.Node);
                try
                {
                    var operationsList = node.Operations;
                    for (var operationsIndex = 0; operationsIndex < operationsList.Count; ++operationsIndex)
                    {
                        this.Visit(node.Operations[operationsIndex]);
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

        public virtual void VisitResource(ResourceSyntax node)
        {
            var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.Resource));
            this.Begin(__annot3, node);
            try
            {
                if (node.IsReadOnly.GetSoalKind() != SoalSyntaxKind.None)
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
                var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Entity");
                this.Begin(__annot2, node.Entity);
                try
                {
                    var __annot1 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Examples.Soal.Model.StructType)));
                    this.Begin(__annot1, node.Entity);
                    try
                    {
                        this.Visit(node.Entity);
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
                if (node.Block != null)
                {
                    this.Visit(node.Block);
                }
            }
            finally
            {
                this.End(__annot3);
            }
        }

        public virtual void VisitOperation(OperationSyntax node)
        {
            var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.Operation));
            this.Begin(__annot3, node);
            try
            {
                if (node.IsAsync.GetSoalKind() != SoalSyntaxKind.None)
                {
                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsAsync", values: ImmutableArray.Create<object?>(true));
                    this.Begin(__annot0, node.IsAsync);
                    try
                    {
                        //this.VisitToken(node.IsAsync);
                    }
                    finally
                    {
                        this.End(__annot0);
                    }
                }
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "ResponseParameters");
                this.Begin(__annot1, node.ResponseParameters);
                try
                {
                    this.Visit(node.ResponseParameters);
                }
                finally
                {
                    this.End(__annot1);
                }
                this.Visit(node.Name);
                var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "RequestParameters");
                this.Begin(__annot2, node.RequestParameters);
                try
                {
                    this.Visit(node.RequestParameters);
                }
                finally
                {
                    this.End(__annot2);
                }
                if (node.Block != null)
                {
                    this.Visit(node.Block);
                }
            }
            finally
            {
                this.End(__annot3);
            }
        }

        public virtual void VisitInputParameterList(InputParameterListSyntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.ParameterList));
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

        public virtual void VisitOutputParameterListAlt1(OutputParameterListAlt1Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.ParameterList));
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitOutputParameterListAlt2(OutputParameterListAlt2Syntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.ParameterList));
            this.Begin(__annot1, node);
            try
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
            finally
            {
                this.End(__annot1);
            }
        }

        public virtual void VisitOutputParameterListAlt3(OutputParameterListAlt3Syntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.ParameterList));
            this.Begin(__annot2, node);
            try
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
            finally
            {
                this.End(__annot2);
            }
        }

        public virtual void VisitParameter(ParameterSyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.Parameter));
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

        public virtual void VisitSingleReturnParameter(SingleReturnParameterSyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.Parameter));
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
            }
            finally
            {
                this.End(__annot1);
            }
        }

        public virtual void VisitService(ServiceSyntax node)
        {
            var __annot3 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.Service));
            this.Begin(__annot3, node);
            try
            {
                this.Visit(node.Name);
                var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Interface");
                this.Begin(__annot1, node.Interface);
                try
                {
                    var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Examples.Soal.Model.Interface)));
                    this.Begin(__annot0, node.Interface);
                    try
                    {
                        this.Visit(node.Interface);
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
                var __annot2 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Binding");
                this.Begin(__annot2, node.Binding);
                try
                {
                    this.Visit(node.Binding);
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

        public virtual void VisitBindingKind(BindingKindSyntax node)
        {
            if (node.Token.GetSoalKind() != SoalSyntaxKind.None)
            {
                switch (node.Token.GetSoalKind())
                {
                    case SoalSyntaxKind.KREST:
                        var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Examples.Soal.Model.BindingKind.Rest);
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
                    case SoalSyntaxKind.KSOAP:
                        var __annot1 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Examples.Soal.Model.BindingKind.Soap);
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
                    default:
                        break;
                }
            }
            else
            {
                // default
            }
        }

        public virtual void VisitTypeReference(TypeReferenceSyntax node)
        {
            var __annot2 = new MetaDslx.CodeAnalysis.Binding.DefineBinder(type: typeof(MetaDslx.Examples.Soal.Model.TypeReference));
            this.Begin(__annot2, node);
            try
            {
                this.Visit(node.SimpleType);
                if (node.IsNullable.GetSoalKind() != SoalSyntaxKind.None)
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
                if (node.IsArray != null)
                {
                    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "IsArray", values: ImmutableArray.Create<object?>(true));
                    this.Begin(__annot1, node.IsArray);
                    try
                    {
                        this.Visit(node.IsArray);
                    }
                    finally
                    {
                        this.End(__annot1);
                    }
                }
            }
            finally
            {
                this.End(__annot2);
            }
        }

        public virtual void VisitSimpleTypeAlt1(SimpleTypeAlt1Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Examples.Soal.Model.Soal.ObjectType);
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSimpleTypeAlt2(SimpleTypeAlt2Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Examples.Soal.Model.Soal.BinaryType);
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSimpleTypeAlt3(SimpleTypeAlt3Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Examples.Soal.Model.Soal.BoolType);
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSimpleTypeAlt4(SimpleTypeAlt4Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Examples.Soal.Model.Soal.StringType);
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSimpleTypeAlt5(SimpleTypeAlt5Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Examples.Soal.Model.Soal.IntType);
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSimpleTypeAlt6(SimpleTypeAlt6Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Examples.Soal.Model.Soal.LongType);
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSimpleTypeAlt7(SimpleTypeAlt7Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Examples.Soal.Model.Soal.FloatType);
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSimpleTypeAlt8(SimpleTypeAlt8Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Examples.Soal.Model.Soal.DoubleType);
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSimpleTypeAlt9(SimpleTypeAlt9Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Examples.Soal.Model.Soal.DateType);
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSimpleTypeAlt10(SimpleTypeAlt10Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Examples.Soal.Model.Soal.TimeType);
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSimpleTypeAlt11(SimpleTypeAlt11Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Examples.Soal.Model.Soal.DateTimeType);
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSimpleTypeAlt12(SimpleTypeAlt12Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ConstantBinder(value: MetaDslx.Examples.Soal.Model.Soal.DurationType);
            this.Begin(__annot0, node);
            try
            {
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitSimpleTypeAlt13(SimpleTypeAlt13Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Examples.Soal.Model.Type)));
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

        public virtual void VisitMainBlock1(MainBlock1Syntax node)
        {
            var __annot0 = new MetaDslx.CodeAnalysis.Binding.ScopeBinder();
            this.Begin(__annot0, node);
            try
            {
                var declarationListList = node.DeclarationList;
                for (var declarationListIndex = 0; declarationListIndex < declarationListList.Count; ++declarationListIndex)
                {
                    this.Visit(node.DeclarationList[declarationListIndex]);
                }
            }
            finally
            {
                this.End(__annot0);
            }
        }

        public virtual void VisitEnumTypeBlock1(EnumTypeBlock1Syntax node)
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

        public virtual void VisitEnumTypeBlock1literalsBlock(EnumTypeBlock1literalsBlockSyntax node)
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

        public virtual void VisitStructTypeBlock1(StructTypeBlock1Syntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "BaseType");
            this.Begin(__annot1, node.BaseType);
            try
            {
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Examples.Soal.Model.StructType)));
                this.Begin(__annot0, node.BaseType);
                try
                {
                    this.Visit(node.BaseType);
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

        public virtual void VisitResourceBlock1(ResourceBlock1Syntax node)
        {
            var exceptionsList = node.Exceptions;
            for (var exceptionsIndex = 0; exceptionsIndex < exceptionsList.Count; ++exceptionsIndex)
            {
                bool __itemHandled = false;
                bool __sepHandled = false;
                if (exceptionsIndex == 0)
                {
                    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Exceptions");
                    this.Begin(__annot1, node.Exceptions[exceptionsIndex]);
                    try
                    {
                        var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Examples.Soal.Model.StructType)));
                        this.Begin(__annot0, node.Exceptions[exceptionsIndex]);
                        try
                        {
                            this.Visit(node.Exceptions[exceptionsIndex]);
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
                if (!__itemHandled && exceptionsIndex < node.Exceptions.Count)
                {
                    var __annot3 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Exceptions");
                    this.Begin(__annot3, node.Exceptions[exceptionsIndex]);
                    try
                    {
                        var __annot2 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Examples.Soal.Model.StructType)));
                        this.Begin(__annot2, node.Exceptions[exceptionsIndex]);
                        try
                        {
                            this.Visit(node.Exceptions[exceptionsIndex]);
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
                if (!__sepHandled && exceptionsIndex < node.Exceptions.SeparatorCount)
                {
                    //this.VisitToken(node.Exceptions.GetSeparator(exceptionsIndex));
                }
            }
        }

        public virtual void VisitResourceBlock1exceptionsBlock(ResourceBlock1exceptionsBlockSyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Exceptions");
            this.Begin(__annot1, node.Exceptions);
            try
            {
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Examples.Soal.Model.StructType)));
                this.Begin(__annot0, node.Exceptions);
                try
                {
                    this.Visit(node.Exceptions);
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

        public virtual void VisitOperationBlock1(OperationBlock1Syntax node)
        {
            var exceptionsList = node.Exceptions;
            for (var exceptionsIndex = 0; exceptionsIndex < exceptionsList.Count; ++exceptionsIndex)
            {
                bool __itemHandled = false;
                bool __sepHandled = false;
                if (exceptionsIndex == 0)
                {
                    var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Exceptions");
                    this.Begin(__annot1, node.Exceptions[exceptionsIndex]);
                    try
                    {
                        var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Examples.Soal.Model.StructType)));
                        this.Begin(__annot0, node.Exceptions[exceptionsIndex]);
                        try
                        {
                            this.Visit(node.Exceptions[exceptionsIndex]);
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
                if (!__itemHandled && exceptionsIndex < node.Exceptions.Count)
                {
                    var __annot3 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Exceptions");
                    this.Begin(__annot3, node.Exceptions[exceptionsIndex]);
                    try
                    {
                        var __annot2 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Examples.Soal.Model.StructType)));
                        this.Begin(__annot2, node.Exceptions[exceptionsIndex]);
                        try
                        {
                            this.Visit(node.Exceptions[exceptionsIndex]);
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
                if (!__sepHandled && exceptionsIndex < node.Exceptions.SeparatorCount)
                {
                    //this.VisitToken(node.Exceptions.GetSeparator(exceptionsIndex));
                }
            }
        }

        public virtual void VisitOperationBlock1exceptionsBlock(OperationBlock1exceptionsBlockSyntax node)
        {
            var __annot1 = new MetaDslx.CodeAnalysis.Binding.PropertyBinder(name: "Exceptions");
            this.Begin(__annot1, node.Exceptions);
            try
            {
                var __annot0 = new MetaDslx.CodeAnalysis.Binding.UseBinder(types: ImmutableArray.Create<System.Type>(typeof(MetaDslx.Examples.Soal.Model.StructType)));
                this.Begin(__annot0, node.Exceptions);
                try
                {
                    this.Visit(node.Exceptions);
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

        public virtual void VisitInputParameterListBlock1(InputParameterListBlock1Syntax node)
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

        public virtual void VisitInputParameterListBlock1parametersBlock(InputParameterListBlock1parametersBlockSyntax node)
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

        public virtual void VisitOutputParameterListAlt3parametersBlock(OutputParameterListAlt3parametersBlockSyntax node)
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

        public virtual void VisitTypeReferenceBlock1(TypeReferenceBlock1Syntax node)
        {
        }

        public virtual void VisitQualifierIdentifierBlock(QualifierIdentifierBlockSyntax node)
        {
            this.Visit(node.Identifier);
        }

        public virtual void VisitSkippedTokensTrivia(SoalSkippedTokensTriviaSyntax node)
        {
        }
    }
}
