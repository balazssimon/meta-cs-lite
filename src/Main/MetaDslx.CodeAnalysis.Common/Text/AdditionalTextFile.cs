using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetaDslx.CodeAnalysis.Text
{
    public class AdditionalTextFile : AdditionalText
    {
        private string _path;
        private string _source;

        public AdditionalTextFile(string path, string source)
        {
            _path = path;
            _source = source;
        }

        public override string Path => _path;

        public override Microsoft.CodeAnalysis.Text.SourceText? GetText(CancellationToken cancellationToken = default)
        {
            return Microsoft.CodeAnalysis.Text.SourceText.From(_source, Encoding.UTF8);
        }
    }
}
