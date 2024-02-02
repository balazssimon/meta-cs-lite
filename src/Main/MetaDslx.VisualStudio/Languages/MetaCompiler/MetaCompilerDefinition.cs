using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.VisualStudio.Languages.MetaCompiler
{
    public sealed class MetaCompilerDefinition
    {
        public const string ContentType = "MetaCompiler";
        public const string FileExtension = ".mxl";

        public const string GeneratorServiceGuid = "C2721F96-ED8C-423D-A179-8538C4B3F328";
        public const string GeneratorServiceName = "C# Code Generator for MetaDslx MetaCompiler";
        public const string FilterList = "MetaDslx MetaLanguage Files (*.mxl)\n*.mxl";

        /// <summary>
        /// Exports the MetaCompiler content type
        /// </summary>
        [Export(typeof(ContentTypeDefinition))]
        [Name(MetaCompilerDefinition.ContentType)]
        [BaseDefinition(CodeRemoteContentDefinition.CodeRemoteContentTypeName)]
        public static ContentTypeDefinition MetaCompilerContentType { get; set; }

        /// <summary>
        /// Exports the MetaCompiler file extension
        /// </summary>
		[Export(typeof(FileExtensionToContentTypeDefinition))]
        [ContentType(MetaCompilerDefinition.ContentType)]
        [FileExtension(MetaCompilerDefinition.FileExtension)]
        public static FileExtensionToContentTypeDefinition MetaCompilerFileExtension { get; set; }

    }
}
