# UsefulAbstractions

Repo for nuget package, containing useful abstractions for C# programs.

## Deployment

1. Update version in file `build.ps1`
2. Run file `build.ps1` and output nupkg will be in the `./TDiblik.UsefulAbstractions/bin/out-nupkg`
3. Run this command (from powershell): `dotnet nuget push .\TDiblik.UsefulAbstractions\bin\out-nupkg\FILE_NAME --api-key INSERT_API_KEY --source https://api.nuget.org/v3/index.json`
