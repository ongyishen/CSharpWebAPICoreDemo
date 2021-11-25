# CSharp ASP.Net API Core Demo

C# ASP.Net API Core Demo

Get your **free** Apple Stock when sign up & deposit to Tiger Brokers 
[ClickHere](https://www.tigerbrokers.com.sg/activity/forapp/invitflow-intl/signup.html?template=invite202011&lang=en_US&invite=E9WV2L)

Use my referral link https://crypto.com/app/gmdvtgv38s to sign up for **Crypto.com** and we both get **$25 USD** :)

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
