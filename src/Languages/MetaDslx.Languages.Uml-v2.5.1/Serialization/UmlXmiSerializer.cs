using MetaDslx.Languages.Uml.MetaModel;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.Uml.Serialization
{
    using Model = MetaDslx.Modeling.Model;

    public class UmlXmiReadOptions : XmiReadOptions
    {
        public UmlXmiReadOptions()
        {
            this.NamespaceToMetaModelMap.Add(UmlMetaModel.Instance.Uri, UmlMetaModel.Instance);
            //this.UriToModelMap.Add(UmlMetaModel.Instance.Uri, UmlMetaModel.Instance);
        }

        public UmlXmiReadOptions(IMetaModel metaModel)
            : base(metaModel)
        {
            this.NamespaceToMetaModelMap.Add(UmlMetaModel.Instance.Uri, UmlMetaModel.Instance);
            //this.UriToModelMap.Add(UmlInstance.MMetadata.Uri, UmlInstance.Model);
        }
    }

    public class UmlXmiWriteOptions : XmiWriteOptions
    {
        public UmlXmiWriteOptions()
        {
            //this.ModelToUriMap.Add(UmlMetaModel.Instance.Model, UmlMetaModel.Instance.Uri);
        }
    }

    public class UmlXmiSerializer
    {
        private XmiSerializer _xmiSerializer = new XmiSerializer();

        public Model ReadModel(string xmiCode, IMetaModel metaModel)
        {
            if (xmiCode == null) throw new ArgumentNullException(nameof(xmiCode));
            if (metaModel == null) throw new ArgumentNullException(nameof(metaModel));
            return _xmiSerializer.ReadModel(xmiCode, new UmlXmiReadOptions(metaModel));
        }

        public Model ReadModel(string xmiCode, UmlXmiReadOptions options = null)
        {
            if (xmiCode == null) throw new ArgumentNullException(nameof(xmiCode));
            return _xmiSerializer.ReadModel(xmiCode, options ?? new UmlXmiReadOptions());
        }

        public Model ReadModelFromFile(string xmiFilePath, IMetaModel metaModel)
        {
            if (xmiFilePath == null) throw new ArgumentNullException(nameof(xmiFilePath));
            if (metaModel == null) throw new ArgumentNullException(nameof(metaModel));
            return _xmiSerializer.ReadModelFromFile(xmiFilePath, new UmlXmiReadOptions(metaModel));
        }

        public Model ReadModelFromFile(string xmiFilePath, UmlXmiReadOptions options = null)
        {
            if (xmiFilePath == null) throw new ArgumentNullException(nameof(xmiFilePath));
            return _xmiSerializer.ReadModelFromFile(xmiFilePath, options ?? new UmlXmiReadOptions());
        }

        public ModelGroup ReadModelGroup(string xmiCode, IMetaModel metaModel)
        {
            return this.ReadModel(xmiCode, metaModel).ModelGroup;
        }

        public ModelGroup ReadModelGroup(string xmiCode, UmlXmiReadOptions options = null)
        {
            return this.ReadModel(xmiCode, options).ModelGroup;
        }

        public ModelGroup ReadModelGroupFromFile(string xmiFilePath, IMetaModel metaModel)
        {
            return this.ReadModelFromFile(xmiFilePath, metaModel).ModelGroup;
        }

        public ModelGroup ReadModelGroupFromFile(string xmiFilePath, UmlXmiReadOptions options = null)
        {
            return this.ReadModelFromFile(xmiFilePath, options).ModelGroup;
        }

        public string WriteModel(IModel model, UmlXmiWriteOptions options = null)
        {
            return _xmiSerializer.WriteModel(model, options);
        }

        public void WriteModelToFile(string xmiFilePath, IModel model, UmlXmiWriteOptions options = null)
        {
            _xmiSerializer.WriteModelToFile(xmiFilePath, model, options ?? new UmlXmiWriteOptions());
        }

        public IReadOnlyDictionary<string, string> WriteModelGroup(IModelGroup modelGroup, UmlXmiWriteOptions options = null)
        {
            return _xmiSerializer.WriteModelGroup(modelGroup, options);
        }

        public void WriteModelGroupToFile(IModelGroup modelGroup, UmlXmiWriteOptions options)
        {
            _xmiSerializer.WriteModelGroupToFile(modelGroup, options);
        }
    }

}
