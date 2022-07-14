dotnet build ".\TDiblik.UsefulAbstractions\TDiblik.UsefulAbstractions.csproj" -c Release /p:CI=true

dotnet pack ".\TDiblik.UsefulAbstractions\TDiblik.UsefulAbstractions.csproj" --no-build -c Release /p:PackageOutputPath=".\bin\out-nupkg" /p:CI=true /p:Version=1.1.0
