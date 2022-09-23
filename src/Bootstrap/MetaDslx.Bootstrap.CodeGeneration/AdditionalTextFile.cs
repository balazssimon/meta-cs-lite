using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.CodeGeneration
{
    internal class AdditionalTextFile : AdditionalText
    {
        private string _path;
        private string _source;

        public AdditionalTextFile(string path, string source)
        {
            _path = path;
            _source = source;
        }

        public override string Path => _path;

        public override SourceText? GetText(CancellationToken cancellationToken = default)
        {
            return SourceText.From(_source, Encoding.UTF8);
        }
    }
}
