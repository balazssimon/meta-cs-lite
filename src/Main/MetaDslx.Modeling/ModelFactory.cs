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
            _model = model;
            _metaModel = metaModel;
        }

        public Model Model => _model;

        public MetaModel MetaModel => _metaModel;

        public IModelObject? Create(Type modelObjectType, string? id = null)
        {
            if (_metaModel.TryGetInfo(modelObjectType, out var info))
            {
                var mobj = info.Create(id);
                if (mobj is not null) mobj.Model = _model;
                return mobj;
            }
            return null;
        }

        public IModelObject? Create(string modelObjectTypeName, string? id = null)
        {
            if (_metaModel.TryGetInfo(modelObjectTypeName, out var info))
            {
                var mobj = info.Create(id);
                if (mobj is not null) mobj.Model = _model;
                return mobj;
            }
            return null;
        }

    }
}
