using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public abstract class ValueInfo
    {
        private readonly object _value;

        public ValueInfo(object value)
        {
            if (value is IModelObject || value is Box)
            {
                _value = value;
            }
            else
            {
                throw new ArgumentException("Value must be either a model object or a box.", nameof(value));
            }
        }

        public object? Value => _value;

        public Model Model
        {
            get
            {
                if (_value is IModelObject mobj) return mobj.Model;
                if (_value is Box box) return box.Model;
                return null;
            }
        }

        public abstract Location? Location { get; set; }
        public abstract SourceLocation? SourceLocation { get; set; }
        public abstract Symbol? Symbol { get; set; }
        public abstract SyntaxReference? Syntax { get; set; }
        public abstract Microsoft.CodeAnalysis.ISymbol? CSharpSymbol { get; set; }

        public abstract object? Tag { get; set; }
    }
}
