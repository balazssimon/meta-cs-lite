using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public class ModelFactory
    {
        private Model _model;
        private MetaModel _metaModel;
    
        public ModelFactory(Model model, MetaModel metaModel)
        {
            if (model is null) throw new ArgumentNullException(nameof(model));
            if (metaModel is null) throw new ArgumentNullException(nameof(metaModel));
            _model = model;
            _metaModel = metaModel;
        }

        public Model Model => _model;

        public MetaModel MetaModel => _metaModel;

        public IModelObject? Create(MetaType modelObjectType, string? id = null)
        {
            if (_metaModel.MClassInfosByType.TryGetValue(modelObjectType, out var info))
            {
                return info.Create(_model, id);
            }
            return null;
        }

        public IModelObject? Create(string modelObjectTypeName, string? id = null)
        {
            if (_metaModel.MClassInfosByName.TryGetValue(modelObjectTypeName, out var info))
            {
                return info.Create(_model, id);
            }
            return null;
        }

    }
}
