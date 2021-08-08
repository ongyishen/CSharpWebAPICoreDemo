# CSharp ASP.Net API Core Demo

C# ASP.Net API Core Demo

### ORM Framework

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameWorkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

*Please create my-books-db Database & configure the DefaultConnectionString at appsettings.json according to your enviroment

### Migration Scripts (Run at Package Management Console)

```
Update-Database
```

### API Versioning

- Mirosoft.AspNetCore.MVC.Versioning
  - Query String - api/controller?api-version=1.1
  - URL Path  - api/v1/controller
  - HTTP Header - custom-version-header in HTTP
  - Media/Content-Type - content-type


### Logging

- Serilog.AspNetCore
- Serilog.Sinks.File
- Serilog.Sinks.MSSqlServer


### Unit Testing Frameworks

- [NUnit](https://nunit.org/)
- Micsrosoft.EntityFrameworkCore.InMemory

### Screenshot
<img src="https://github.com/ongyishen/CSharpWebAPICoreDemo/blob/main/Sample.gif?raw=true" />


#### Optional

If you want to reset the database migrations
```
Remove-Migration
```