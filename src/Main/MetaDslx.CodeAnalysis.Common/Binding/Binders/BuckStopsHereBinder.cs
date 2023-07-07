using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    /// <summary>
    /// A binder that knows no symbols and will not delegate further.
    /// </summary>
    public sealed class BuckStopsHereBinder : Binder
    {
        private Language _language;

        public BuckStopsHereBinder(Compilation compilation, Language language)
        {
            this.Compilation = compilation;
            _language = language;
        }

        public override Language Language => _language;
    }
}
