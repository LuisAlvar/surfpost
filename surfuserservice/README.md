## Surf Post Service 

Once you have create your models and your db context. 

Check to see if dotnet ef is install as a tool in your terminal. 

```bash 
  dotnet ef --version 
```

If there is no successfully response, then install the tool 

```bash 
  dotnet tool install --global dotnet-ef 
```

Now, check the version again. You should get a similar response.
```bash 
  Entity Framework Core .NET Command-line Tools
  6.0.8
```

Next, you need a runing instance of sql server 
```bash
docker run --cap-add SYS_PTRACE -e "ACCEPT_EULA=1" -e "MSSQL_SA_PASSWORD=12345@tech" -p 1433:1433 --name azuresqledge -d mcr.microsoft.com/azure-sql-edge
```

Run 
```bash
  donet ef migrations add InitialMigration
```

Upload to the database provider 
```bash 
  dotnet ef database update
```

