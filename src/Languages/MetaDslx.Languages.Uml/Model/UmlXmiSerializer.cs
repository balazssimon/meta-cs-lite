using MetaDslx.CodeAnalysis;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Languages.Uml.Model
{
    using __MetaModel = MetaDslx.Modeling.MetaModel;
    using __Model = MetaDslx.Modeling.Model;

    public class UmlXmiReadOptions : XmiReadOptions
    {
        public UmlXmiReadOptions()
        {
            this.NamespaceToMetaModelMap.Add(Uml.MInstance.MUri, Uml.MInstance);
            this.UriToModelMap.Add(Uml.MInstance.MUri, Uml.MInstance.MModel);
        }

        public UmlXmiReadOptions(__MetaModel metaModel)
            : base(metaModel)
        {
            if (metaModel != Uml.MInstance) this.NamespaceToMetaModelMap.Add(Uml.MInstance.MUri, Uml.MInstance);
            this.UriToModelMap.Add(Uml.MInstance.MUri, Uml.MInstance.MModel);
        }
    }

    public class UmlXmiWriteOptions : XmiWriteOptions
    {
        public UmlXmiWriteOptions()
        {
            this.ModelToUriMap.Add(Uml.MInstance.MModel, Uml.MInstance.MUri);
        }
    }

    public class UmlXmiSerializer
    {
        private XmiSerializer _xmiSerializer = new XmiSerializer();

        public __Model ReadModel(string xmiCode, __MetaModel metaModel)
        {
            return _xmiSerializer.ReadModel(xmiCode, new UmlXmiReadOptions(metaModel));
        }

        public __Model ReadModel(string xmiCode, __MetaModel metaModel, out ImmutableArray<Diagnostic> diagnostics)
        {
            return _xmiSerializer.ReadModel(xmiCode, new UmlXmiReadOptions(metaModel), out diagnostics);
        }

        public __Model ReadModel(string xmiCode, XmiReadOptions options)
        {
            return _xmiSerializer.ReadModel(xmiCode, options);
        }

        public __Model ReadModel(string xmiCode, XmiReadOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            return _xmiSerializer.ReadModel(xmiCode, options, out diagnostics);
        }

        public __Model ReadModelFromFile(string xmiFilePath, __MetaModel metaModel)
        {
            return _xmiSerializer.ReadModelFromFile(xmiFilePath, new UmlXmiReadOptions(metaModel));
        }

        public __Model ReadModelFromFile(string xmiFilePath, __MetaModel metaModel, out ImmutableArray<Diagnostic> diagnostics)
        {
            return _xmiSerializer.ReadModelFromFile(xmiFilePath, new UmlXmiReadOptions(metaModel), out diagnostics);
        }

        public __Model ReadModelFromFile(string xmiFilePath, UmlXmiReadOptions options)
        {
            return _xmiSerializer.ReadModelFromFile(xmiFilePath, options);
        }

        public __Model ReadModelFromFile(string xmiFilePath, UmlXmiReadOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            return _xmiSerializer.ReadModelFromFile(xmiFilePath, options, out diagnostics);
        }

        public ModelGroup ReadModelGroup(string xmiCode, __MetaModel metaModel)
        {
            return this.ReadModel(xmiCode, metaModel).ModelGroup!;
        }

        public ModelGroup ReadModelGroup(string xmiCode, __MetaModel metaModel, out ImmutableArray<Diagnostic> diagnostics)
        {
            return this.ReadModel(xmiCode, metaModel, out diagnostics).ModelGroup!;
        }

        public ModelGroup ReadModelGroup(string xmiCode, UmlXmiReadOptions options)
        {
            return this.ReadModel(xmiCode, options).ModelGroup!;
        }

        public ModelGroup ReadModelGroup(string xmiCode, UmlXmiReadOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            return this.ReadModel(xmiCode, options, out diagnostics).ModelGroup!;
        }

        public ModelGroup ReadModelGroupFromFile(string xmiFilePath, __MetaModel metaModel)
        {
            return this.ReadModelFromFile(xmiFilePath, metaModel).ModelGroup!;
        }

        public ModelGroup ReadModelGroupFromFile(string xmiFilePath, __MetaModel metaModel, out ImmutableArray<Diagnostic> diagnostics)
        {
            return this.ReadModelFromFile(xmiFilePath, metaModel, out diagnostics).ModelGroup!;
        }

        public ModelGroup ReadModelGroupFromFile(string xmiFilePath, UmlXmiReadOptions options)
        {
            return this.ReadModelFromFile(xmiFilePath, options).ModelGroup!;
        }

        public ModelGroup ReadModelGroupFromFile(string xmiFilePath, UmlXmiReadOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            return this.ReadModelFromFile(xmiFilePath, options, out diagnostics).ModelGroup!;
        }

        public string WriteModel(__Model model, UmlXmiWriteOptions options)
        {
            return _xmiSerializer.WriteModel(model, options);
        }

        public string WriteModel(__Model model, UmlXmiWriteOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            return _xmiSerializer.WriteModel(model, options, out diagnostics);
        }

        public void WriteModelToFile(string xmiFilePath, __Model model, UmlXmiWriteOptions? options = null)
        {
            _xmiSerializer.WriteModelToFile(xmiFilePath, model, options ?? new UmlXmiWriteOptions());
        }

        public void WriteModelToFile(string xmiFilePath, __Model model, UmlXmiWriteOptions? options, out ImmutableArray<Diagnostic> diagnostics)
        {
            _xmiSerializer.WriteModelToFile(xmiFilePath, model, options ?? new UmlXmiWriteOptions(), out diagnostics);
        }

        public IReadOnlyDictionary<string, string> WriteModelGroup(ModelGroup modelGroup, UmlXmiWriteOptions? options = null)
        {
            return _xmiSerializer.WriteModelGroup(modelGroup, options ?? new UmlXmiWriteOptions());
        }

        public IReadOnlyDictionary<string, string> WriteModelGroup(ModelGroup modelGroup, UmlXmiWriteOptions? options, out ImmutableArray<Diagnostic> diagnostics)
        {
            return _xmiSerializer.WriteModelGroup(modelGroup, options ?? new UmlXmiWriteOptions(), out diagnostics);
        }

        public void WriteModelGroupToFile(ModelGroup modelGroup, UmlXmiWriteOptions? options)
        {
            _xmiSerializer.WriteModelGroupToFile(modelGroup, options ?? new UmlXmiWriteOptions());
        }

        public void WriteModelGroupToFile(ModelGroup modelGroup, UmlXmiWriteOptions? options, out ImmutableArray<Diagnostic> diagnostics)
        {
            _xmiSerializer.WriteModelGroupToFile(modelGroup, options ?? new UmlXmiWriteOptions(), out diagnostics);
        }
    }

}
