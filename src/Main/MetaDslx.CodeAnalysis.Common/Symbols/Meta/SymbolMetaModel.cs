using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Meta
{
    internal class SymbolMetaModel : MetaModel
    {
        private readonly NamespaceSymbol _container;
        private readonly string _name;
        private readonly string _namespace;
        private readonly string _prefix;
        private readonly bool _isSymbolModel;

        public SymbolMetaModel(NamespaceSymbol container, string name, bool isSymbolModel)
        {
            if (container is null) throw new ArgumentNullException(nameof(container));
            if (name is null) throw new ArgumentNullException(nameof(name));
            _container = container;
            _name = name;
            _namespace = SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(container);
            _prefix = string.Concat(name.Where(c => char.IsUpper(c)).Select(c => char.ToLower(c)));
            _isSymbolModel = isSymbolModel;
        }

        public override string MName => _name;

        public override string MNamespace => _namespace;

        public override ModelVersion MVersion => default;

        public override string MUri => _namespace;

        public override string MPrefix => _prefix;

        public bool IsSymbolModel => _isSymbolModel;

        public override MetaDslx.Modeling.Model MModel => throw new NotImplementedException();

        public override ImmutableDictionary<MetaType, ModelEnumInfo> MEnumInfosByType => throw new NotImplementedException();

        public override ImmutableDictionary<string, ModelEnumInfo> MEnumInfosByName => throw new NotImplementedException();

        public override ImmutableDictionary<MetaType, ModelClassInfo> MClassInfosByType => throw new NotImplementedException();

        public override ImmutableDictionary<string, ModelClassInfo> MClassInfosByName => throw new NotImplementedException();

        public override ImmutableArray<MetaType> MEnumTypes => throw new NotImplementedException();

        public override ImmutableArray<ModelEnumInfo> MEnumInfos => throw new NotImplementedException();

        public override ImmutableArray<MetaType> MClassTypes => throw new NotImplementedException();

        public override ImmutableArray<ModelClassInfo> MClassInfos => throw new NotImplementedException();

        private void Compute()
        {

        }
    }
}
