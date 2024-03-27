using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Modeling
{
    public struct ResettableLazy<T>
    {
        private Lazy<T> _lazy;

        public ResettableLazy(Func<T> value)
        {
            _lazy = new Lazy<T>(value, true);
        }

        public T Value
        {
            get => _lazy.Value;
            set => Interlocked.Exchange(ref _lazy, new Lazy<T>(() => value, true));
        }
    }
}
