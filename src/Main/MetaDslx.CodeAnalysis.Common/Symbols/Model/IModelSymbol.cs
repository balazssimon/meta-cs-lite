using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public interface IModelSymbol
    {
        public IModel Model { get; }
        public IModelObject ModelObject { get; }
    }
}
