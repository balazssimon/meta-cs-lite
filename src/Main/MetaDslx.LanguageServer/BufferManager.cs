using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.LanguageServer
{
    internal class BufferManager
    {
        private ConcurrentDictionary<string, SourceText> _buffers = new ConcurrentDictionary<string, SourceText>();

        public void UpdateBuffer(string documentPath, SourceText buffer)
        {
            _buffers.AddOrUpdate(documentPath, buffer, (k, v) => buffer);
        }

        public SourceText? GetBuffer(string documentPath)
        {
            return _buffers.TryGetValue(documentPath, out var buffer) ? buffer : null;
        }
    }
}
