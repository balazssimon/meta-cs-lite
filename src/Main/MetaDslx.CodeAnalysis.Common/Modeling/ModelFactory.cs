using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public class ModelFactory
    {
        private Model _model;

        public ModelFactory(Model model)
        {
            _model = model;
        }

        public Model Model => _model;

    }
}
