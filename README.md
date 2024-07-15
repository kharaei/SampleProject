# SampleProject


### how to run project?
1- create docker container for sql :

```docker
docker run -d --name sqlserver -p 1433:1433 -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=<YOURPASSWORD>' mcr.microsoft.com/mssql/server
```

2- open solution folder in vscode and set string connection.

3- create the database by execution following code:
```csharp
cd SampleProject.Api
```
```csharp
dotnet ef database update --project ../SampleProject.Infra/SampleProject.Infra.csproj
```

4- run project by execution following code:
```csharp
dotnet run
```