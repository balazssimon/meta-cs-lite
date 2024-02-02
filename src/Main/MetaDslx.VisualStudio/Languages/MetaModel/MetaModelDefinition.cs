using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.VisualStudio.Languages.MetaModel
{
    public sealed class MetaModelDefinition
    {
        public const string ContentType = "MetaModel";
        public const string FileExtension = ".mxm";

        public const string GeneratorServiceGuid = "20E88210-B715-4BFA-9E3F-2993161B5EC0";
        public const string GeneratorServiceName = "C# Code Generator for MetaDslx MetaModel";
        public const string FilterList = "MetaDslx MetaModel Files (*.mxm)\n*.mxm";

        /// <summary>
        /// Exports the MetaModel content type
        /// </summary>
        [Export(typeof(ContentTypeDefinition))]
        [Name(MetaModelDefinition.ContentType)]
        [BaseDefinition(CodeRemoteContentDefinition.CodeRemoteContentTypeName)]
        public static ContentTypeDefinition MetaModelContentType { get; set; }

        /// <summary>
        /// Exports the MetaModel file extension
        /// </summary>
		[Export(typeof(FileExtensionToContentTypeDefinition))]
        [ContentType(MetaModelDefinition.ContentType)]
        [FileExtension(MetaModelDefinition.FileExtension)]
        public static FileExtensionToContentTypeDefinition MetaModelFileExtension { get; set; }

    }
}
