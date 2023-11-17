using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Meta;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.MetaModelImport
{
    internal class ImportedMetaProperty : MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>
    {
        private MetaType _type;
        private ModelPropertyFlags _flags;
        private MetaSymbol _defaultValue;
        private string? _symbolProperty;

        public ImportedMetaProperty(MetaClass<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> declaringType, CSharpDeclaredSymbol underlyingProperty)
            : base(declaringType, underlyingProperty)
        {
            var diagnostics = DiagnosticBag.GetInstance();
            _type = ((CSharpModuleSymbol)underlyingProperty.ContainingModule).SymbolFactory.GetSymbol<TypeSymbol>(CSharpProperty.Type, diagnostics, default);
            foreach (var attr in CSharpProperty.GetAttributes())
            {
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.DefaultValueAttribute")
                {
                    var arg = attr.ConstructorArguments[0];
                    _defaultValue = MetaSymbol.FromValue(arg.Value);
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.NameAttribute")
                {
                    _flags |= ModelPropertyFlags.Name;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.TypeAttribute")
                {
                    _flags |= ModelPropertyFlags.Type;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.UntrackedAttribute")
                {
                    _flags |= ModelPropertyFlags.Untracked;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.NonUniqueAttribute")
                {
                    _flags |= ModelPropertyFlags.NonUnique;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.UnorderedAttribute")
                {
                    _flags |= ModelPropertyFlags.Unordered;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.ContainmentAttribute")
                {
                    _flags |= ModelPropertyFlags.Containment;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.ReadOnlyAttribute")
                {
                    _flags |= ModelPropertyFlags.ReadOnly;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.DerivedAttribute")
                {
                    _flags |= ModelPropertyFlags.Derived;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.DerivedUnionAttribute")
                {
                    _flags |= ModelPropertyFlags.DerivedUnion;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.SymbolPropertyAttribute")
                {
                    if (_symbolProperty is null) _symbolProperty = attr.ConstructorArguments[0].Value as string;
                }
            }
        }

        public IPropertySymbol CSharpProperty => (IPropertySymbol)UnderlyingProperty.CSharpSymbol;

        public override string Name => CSharpProperty.Name;

        public override MetaType OriginalType => _type;

        public override ModelPropertyFlags OriginalFlags => _flags;

        public override bool HasSetter => CSharpProperty.SetMethod is not null;

        public override MetaSymbol DefaultValue => _defaultValue;

        public override string? SymbolProperty => _symbolProperty;

        internal protected override IEnumerable<(MetaType DeclaringType, string PropertyName)> GetOppositeProperties()
        {
            yield break;
        }

        internal protected override IEnumerable<(MetaType DeclaringType, string PropertyName)> GetRedefinedProperties()
        {
            yield break;
        }

        internal protected override IEnumerable<(MetaType DeclaringType, string PropertyName)> GetSubsettedProperties()
        {
            yield break;
        }
    }
}
