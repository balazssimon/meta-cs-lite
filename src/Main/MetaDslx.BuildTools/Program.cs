using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis.MSBuild;

namespace MetaDslx.BuildTools
{
    public class Program
    {
        private const bool Testing = true;

        public static async Task Main(string[] args)
        {
            MSBuildLocator.RegisterDefaults();
            string currentDirectory = Directory.GetCurrentDirectory();
            if (Testing)
            {
                currentDirectory = @"c:\Users\balaz\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.BuildTools\";
            }
            var directoryInfo = new DirectoryInfo(currentDirectory);
            var csprojFiles = directoryInfo.GetFiles("*.csproj");
            if (csprojFiles.Length == 0)
            {
                await Console.Out.WriteLineAsync("ERROR: No .csproj files found in the current directory.");
                return;
            }
            if (csprojFiles.Length >= 2)
            {
                await Console.Out.WriteLineAsync("ERROR: More than .csproj files found in the current directory.");
                return;
            }
            var projectFile = csprojFiles[0].FullName;
            using (var workspace = MSBuildWorkspace.Create())
            {
                var project = await workspace.OpenProjectAsync(projectFile);
                foreach (var document in project.AdditionalDocuments)
                {
                    if (Path.GetExtension(document.FilePath) == ".mm")
                    {
                        await Console.Out.WriteLineAsync(document.FilePath);
                    }
                }
                var compilation = await project.GetCompilationAsync();
                if (compilation is not null)
                {
                    await Console.Out.WriteLineAsync(compilation.AssemblyName);
                }
                // Perform analysis...
            }
        }

    }
}

