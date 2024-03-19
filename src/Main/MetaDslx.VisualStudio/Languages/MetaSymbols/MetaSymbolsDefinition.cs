using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.VisualStudio.Languages.MetaSymbols
{
    public sealed class MetaSymbolsDefinition
    {
        public const string ContentType = "MetaSymbols";
        public const string FileExtension = ".mxs";
        public const string FilterList = "MetaDslx MetaSymbols Files (*.mxs)\n*.mxs";

        /// <summary>
        /// Exports the MetaSymbols content type
        /// </summary>
        [Export(typeof(ContentTypeDefinition))]
        [Name(MetaSymbolsDefinition.ContentType)]
        [BaseDefinition(CodeRemoteContentDefinition.CodeRemoteContentTypeName)]
        public static ContentTypeDefinition MetaSymbolsContentType { get; set; }

        /// <summary>
        /// Exports the MetaSymbols file extension
        /// </summary>
		[Export(typeof(FileExtensionToContentTypeDefinition))]
        [ContentType(MetaSymbolsDefinition.ContentType)]
        [FileExtension(MetaSymbolsDefinition.FileExtension)]
        public static FileExtensionToContentTypeDefinition MetaSymbolsFileExtension { get; set; }

    }
}
