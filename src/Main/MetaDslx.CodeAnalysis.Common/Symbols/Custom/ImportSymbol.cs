using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System.Collections.Concurrent;
using System.IO;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Symbols.__Impl
{
    public class ImportSymbolImpl : ImportSymbolBase
    {
        public override ImmutableArray<DeclarationSymbol> Complete_ImportedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var symbolsBuilder = ArrayBuilder<DeclarationSymbol>.GetInstance();
            symbolsBuilder.AddRange(Aliases);
            var compilation = DeclaringCompilation;
            if (Files.Length > 0 && this.IsSourceSymbol && compilation is not null)
            {
                if (compilation.Options.MergeGlobalNamespace)
                {
                    diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_FileImportsDisabled, this.Locations.FirstOrDefault()));
                }
                else
                {
                    var currentFilePaths = PooledHashSet<string>.GetInstance();
                    foreach (var syntaxReference in this.DeclaringSyntaxReferences)
                    {
                        currentFilePaths.Add(syntaxReference.SyntaxTree.FilePath);
                    }
                    foreach (var currentFilePath in currentFilePaths)
                    {
                        var currentDirectory = Path.GetDirectoryName(currentFilePath) ?? string.Empty;
                        foreach (var fileName in Files)
                        {
                            var importedFilePath = fileName;
                            var found = false;
                            if (!string.IsNullOrWhiteSpace(fileName))
                            {
                                importedFilePath = Path.GetFullPath(Path.IsPathRooted(fileName) ? fileName : Path.Combine(currentDirectory, fileName));
                                foreach (var syntaxTree in compilation.SyntaxTrees)
                                {
                                    if (!string.IsNullOrWhiteSpace(syntaxTree.FilePath))
                                    {
                                        var treeFilePath = Path.GetFullPath(syntaxTree.FilePath);
                                        if (importedFilePath == treeFilePath)
                                        {
                                            found = true;
                                            var fileNamespace = compilation.GetRootNamespace(syntaxTree);
                                            symbolsBuilder.AddRange(fileNamespace.Members);
                                        }
                                    }
                                }
                            }
                            if (!found)
                            {
                                diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_ImportedFileNotFound, this.Locations.FirstOrDefault(), fileName, importedFilePath));
                            }
                        }
                    }
                    currentFilePaths.Free();
                }
            }
            symbolsBuilder.AddRange(Symbols);
            symbolsBuilder.AddRange(Namespaces);
            return symbolsBuilder.ToImmutableAndFree();
        }
    }
}
