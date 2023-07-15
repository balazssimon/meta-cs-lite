using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public class ModelFactory : IModelFactory
    {
        private Model _model;
        private IMetaModel _metaModel;
        private IModelFactory? _metaFactory;

        public ModelFactory(Model model, IMetaModel metaModel)
        {
            _model = model;
            _metaModel = metaModel;
            _metaFactory = _metaModel.CreateFactory(_model);
        }

        public Model Model => _model;

        IModel IModelFactory.Model => _model;

        IMetaModel IModelFactory.MetaModel => _metaModel;

        IModelObject? IModelFactory.Create(Type modelObjectType, string? id)
        {
            return _metaFactory.Create(modelObjectType, id);
        }

        IModelObject? IModelFactory.Create(string modelObjectTypeName, string? id)
        {
            return _metaFactory.Create(modelObjectTypeName, id);
        }

    }
}
