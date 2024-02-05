using MetaDslx.CodeAnalysis;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Languages.Mof.Model
{
    using MetaModel = MetaDslx.Modeling.MetaModel;
    using Model = MetaDslx.Modeling.Model;

    public class MofXmiReadOptions : XmiReadOptions
    {
        public MofXmiReadOptions()
        {
            this.NamespaceToMetaModelMap.Add(Mof.MInstance.MUri, Mof.MInstance);
            this.NamespaceToMetaModelMap.Add("http://www.omg.org/spec/UML", Mof.MInstance);
            this.UriToModelMap.Add(Mof.MInstance.MUri, Mof.MInstance.MModel);
        }

        public MofXmiReadOptions(MetaModel metaModel)
            : base(metaModel)
        {
            if (metaModel != Mof.MInstance) this.NamespaceToMetaModelMap.Add(Mof.MInstance.MUri, Mof.MInstance);
            this.NamespaceToMetaModelMap.Add("http://www.omg.org/spec/UML", Mof.MInstance);
            this.UriToModelMap.Add(Mof.MInstance.MUri, Mof.MInstance.MModel);
        }
    }

    public class MofXmiWriteOptions : XmiWriteOptions
    {
        public MofXmiWriteOptions()
        {
            this.ModelToUriMap.Add(Mof.MInstance.MModel, Mof.MInstance.MUri);
        }
    }

    public class MofXmiSerializer
    {
        private XmiSerializer _xmiSerializer = new XmiSerializer();

        public Model ReadModel(string xmiCode, MetaModel metaModel)
        {
            return _xmiSerializer.ReadModel(xmiCode, new MofXmiReadOptions(metaModel));
        }

        public Model ReadModel(string xmiCode, MetaModel metaModel, out ImmutableArray<Diagnostic> diagnostics)
        {
            return _xmiSerializer.ReadModel(xmiCode, new MofXmiReadOptions(metaModel), out diagnostics);
        }

        public Model ReadModel(string xmiCode, XmiReadOptions options)
        {
            return _xmiSerializer.ReadModel(xmiCode, options);
        }

        public Model ReadModel(string xmiCode, XmiReadOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            return _xmiSerializer.ReadModel(xmiCode, options, out diagnostics);
        }

        public Model ReadModelFromFile(string xmiFilePath, MetaModel metaModel)
        {
            return _xmiSerializer.ReadModelFromFile(xmiFilePath, new MofXmiReadOptions(metaModel));
        }

        public Model ReadModelFromFile(string xmiFilePath, MetaModel metaModel, out ImmutableArray<Diagnostic> diagnostics)
        {
            return _xmiSerializer.ReadModelFromFile(xmiFilePath, new MofXmiReadOptions(metaModel), out diagnostics);
        }

        public Model ReadModelFromFile(string xmiFilePath, MofXmiReadOptions options)
        {
            return _xmiSerializer.ReadModelFromFile(xmiFilePath, options);
        }

        public Model ReadModelFromFile(string xmiFilePath, MofXmiReadOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            return _xmiSerializer.ReadModelFromFile(xmiFilePath, options, out diagnostics);
        }

        public ModelGroup ReadModelGroup(string xmiCode, MetaModel metaModel)
        {
            return this.ReadModel(xmiCode, metaModel).ModelGroup!;
        }

        public ModelGroup ReadModelGroup(string xmiCode, MetaModel metaModel, out ImmutableArray<Diagnostic> diagnostics)
        {
            return this.ReadModel(xmiCode, metaModel, out diagnostics).ModelGroup!;
        }

        public ModelGroup ReadModelGroup(string xmiCode, MofXmiReadOptions options)
        {
            return this.ReadModel(xmiCode, options).ModelGroup!;
        }

        public ModelGroup ReadModelGroup(string xmiCode, MofXmiReadOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            return this.ReadModel(xmiCode, options, out diagnostics).ModelGroup!;
        }

        public ModelGroup ReadModelGroupFromFile(string xmiFilePath, MetaModel metaModel)
        {
            return this.ReadModelFromFile(xmiFilePath, metaModel).ModelGroup!;
        }

        public ModelGroup ReadModelGroupFromFile(string xmiFilePath, MetaModel metaModel, out ImmutableArray<Diagnostic> diagnostics)
        {
            return this.ReadModelFromFile(xmiFilePath, metaModel, out diagnostics).ModelGroup!;
        }

        public ModelGroup ReadModelGroupFromFile(string xmiFilePath, MofXmiReadOptions options)
        {
            return this.ReadModelFromFile(xmiFilePath, options).ModelGroup!;
        }

        public ModelGroup ReadModelGroupFromFile(string xmiFilePath, MofXmiReadOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            return this.ReadModelFromFile(xmiFilePath, options, out diagnostics).ModelGroup!;
        }

        public string WriteModel(Model model, MofXmiWriteOptions options)
        {
            return _xmiSerializer.WriteModel(model, options);
        }

        public string WriteModel(Model model, MofXmiWriteOptions options, out ImmutableArray<Diagnostic> diagnostics)
        {
            return _xmiSerializer.WriteModel(model, options, out diagnostics);
        }

        public void WriteModelToFile(string xmiFilePath, Model model, MofXmiWriteOptions? options = null)
        {
            _xmiSerializer.WriteModelToFile(xmiFilePath, model, options ?? new MofXmiWriteOptions());
        }

        public void WriteModelToFile(string xmiFilePath, Model model, MofXmiWriteOptions? options, out ImmutableArray<Diagnostic> diagnostics)
        {
            _xmiSerializer.WriteModelToFile(xmiFilePath, model, options ?? new MofXmiWriteOptions(), out diagnostics);
        }

        public IReadOnlyDictionary<string, string> WriteModelGroup(ModelGroup modelGroup, MofXmiWriteOptions? options = null)
        {
            return _xmiSerializer.WriteModelGroup(modelGroup, options ?? new MofXmiWriteOptions());
        }

        public IReadOnlyDictionary<string, string> WriteModelGroup(ModelGroup modelGroup, MofXmiWriteOptions? options, out ImmutableArray<Diagnostic> diagnostics)
        {
            return _xmiSerializer.WriteModelGroup(modelGroup, options ?? new MofXmiWriteOptions(), out diagnostics);
        }

        public void WriteModelGroupToFile(ModelGroup modelGroup, MofXmiWriteOptions? options)
        {
            _xmiSerializer.WriteModelGroupToFile(modelGroup, options ?? new MofXmiWriteOptions());
        }

        public void WriteModelGroupToFile(ModelGroup modelGroup, MofXmiWriteOptions? options, out ImmutableArray<Diagnostic> diagnostics)
        {
            _xmiSerializer.WriteModelGroupToFile(modelGroup, options ?? new MofXmiWriteOptions(), out diagnostics);
        }
    }

}
