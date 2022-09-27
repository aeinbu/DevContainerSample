dotnet dev-certs https
dotnet tool restore

dotnet ef database update --project TestDatabaseConsole
