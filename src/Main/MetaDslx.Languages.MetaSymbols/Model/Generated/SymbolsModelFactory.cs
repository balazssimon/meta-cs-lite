#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Model
{
    using __MetaMetaModel = global::MetaDslx.Languages.MetaModel.Model.Meta;
    using __MetaModelFactory = global::MetaDslx.Languages.MetaModel.Model.MetaModelFactory;
    using __Model = global::MetaDslx.Modeling.Model;
    using __MetaModel = global::MetaDslx.Modeling.MetaModel;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __ModelFactory = global::MetaDslx.Modeling.ModelFactory;
    using __MultiModelFactory = global::MetaDslx.Modeling.MultiModelFactory;
    using __ModelVersion = global::MetaDslx.Modeling.ModelVersion;
    using __ModelEnumInfo = global::MetaDslx.Modeling.ModelEnumInfo;
    using __ModelClassInfo = global::MetaDslx.Modeling.ModelClassInfo;
    using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
    using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
    using __ModelOperation = global::MetaDslx.Modeling.ModelOperation;
    using __ModelOperationInfo = global::MetaDslx.Modeling.ModelOperationInfo;
    using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
    using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
    using __MetaType = global::MetaDslx.CodeAnalysis.MetaType;
    using __MetaSymbol = global::MetaDslx.CodeAnalysis.MetaSymbol;
    using __Type = global::System.Type;
    using __Enum = global::System.Enum;

    public class SymbolsModelFactory : __ModelFactory
    {
        public SymbolsModelFactory(__Model model)
            : base(model, Symbols.MInstance)
        {
        }
    
        internal SymbolsModelFactory(__Model model, Symbols metaModel)
            : base(model, metaModel)
        {
        }
    
        public Declaration Declaration(string? id = null)
        {
            return (Declaration)Symbols.DeclarationInfo.Create(base.Model, id)!;
        }
    
        public Namespace Namespace(string? id = null)
        {
            return (Namespace)Symbols.NamespaceInfo.Create(base.Model, id)!;
        }
    
        public Operation Operation(string? id = null)
        {
            return (Operation)Symbols.OperationInfo.Create(base.Model, id)!;
        }
    
        public Parameter Parameter(string? id = null)
        {
            return (Parameter)Symbols.ParameterInfo.Create(base.Model, id)!;
        }
    
        public Property Property(string? id = null)
        {
            return (Property)Symbols.PropertyInfo.Create(base.Model, id)!;
        }
    
        public Symbol Symbol(string? id = null)
        {
            return (Symbol)Symbols.SymbolInfo.Create(base.Model, id)!;
        }
    
        public TypeReference TypeReference(string? id = null)
        {
            return (TypeReference)Symbols.TypeReferenceInfo.Create(base.Model, id)!;
        }
    
    }
    
    public class SymbolsModelMultiFactory : __MultiModelFactory
    {
        public SymbolsModelMultiFactory()
            : base(new __MetaModel[] { Symbols.MInstance })
        {
        }
    
        public Declaration Declaration(__Model model, string? id = null)
        {
            return (Declaration)Symbols.DeclarationInfo.Create(model, id)!;
        }
    
        public Namespace Namespace(__Model model, string? id = null)
        {
            return (Namespace)Symbols.NamespaceInfo.Create(model, id)!;
        }
    
        public Operation Operation(__Model model, string? id = null)
        {
            return (Operation)Symbols.OperationInfo.Create(model, id)!;
        }
    
        public Parameter Parameter(__Model model, string? id = null)
        {
            return (Parameter)Symbols.ParameterInfo.Create(model, id)!;
        }
    
        public Property Property(__Model model, string? id = null)
        {
            return (Property)Symbols.PropertyInfo.Create(model, id)!;
        }
    
        public Symbol Symbol(__Model model, string? id = null)
        {
            return (Symbol)Symbols.SymbolInfo.Create(model, id)!;
        }
    
        public TypeReference TypeReference(__Model model, string? id = null)
        {
            return (TypeReference)Symbols.TypeReferenceInfo.Create(model, id)!;
        }
    
    }
}
