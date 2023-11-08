dotnet build-server shutdown
dotnet clean -c Release
dotnet pack Main\MetaDslx.CodeAnalysis -c Release
dotnet build-server shutdown
