dotnet build-server shutdown
dotnet clean -c Debug
dotnet pack Main\MetaDslx.CodeAnalysis -c Debug
dotnet build-server shutdown
