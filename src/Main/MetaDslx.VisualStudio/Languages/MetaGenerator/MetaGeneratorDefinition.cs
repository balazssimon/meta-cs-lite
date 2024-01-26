using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.VisualStudio.Languages.MetaGenerator
{
    public sealed class MetaGeneratorDefinition
    {
        public const string ContentType = "MetaGenerator";
        public const string FileExtension = ".mxg";

        public const string GeneratorServiceGuid = "46F65E7B-4C31-43B1-B69C-E4FE342075DA";
        public const string GeneratorServiceName = "C# Code Generator for MetaDslx Generator";
        public const string FilterList = "MetaDslx Generator Files (*.mxg)\n*.mxg";

        /// <summary>
        /// Exports the MetaGenerator content type
        /// </summary>
        [Export(typeof(ContentTypeDefinition))]
        [Name(MetaGeneratorDefinition.ContentType)]
        [BaseDefinition(CodeRemoteContentDefinition.CodeRemoteContentTypeName)]
        public static ContentTypeDefinition MetaGeneratorContentType { get; set; }

        /// <summary>
        /// Exports the MetaGenerator file extension
        /// </summary>
		[Export(typeof(FileExtensionToContentTypeDefinition))]
        [ContentType(MetaGeneratorDefinition.ContentType)]
        [FileExtension(MetaGeneratorDefinition.FileExtension)]
        public static FileExtensionToContentTypeDefinition MetaGeneratorFileExtension { get; set; }

    }
}
