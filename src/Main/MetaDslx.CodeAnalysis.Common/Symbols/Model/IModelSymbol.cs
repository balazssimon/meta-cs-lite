using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public interface IModelSymbol
    {
        IModel Model { get; }
        IModelObject ModelObject { get; }
        Type ModelObjectType { get; }
    }
}
