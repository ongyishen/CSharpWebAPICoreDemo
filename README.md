# CSharp ASP.Net API Core Demo

C# ASP.Net API Core Demo

Get your **free** Apple Stock when sign up & deposit to Tiger Brokers
[![ClickHere](https://img.shields.io/badge/ClickMe-success?logo=Cliqz&?style=for-the-badge)](https://www.tigerbrokers.com.sg/activity/market/2022/welcome-sgp?template=AC1665389958774ybmreB&is_invite=true&utm_campaign=AC1665474511368tEOtbt&adcode=AC1665474511368tEOtbt&utm_medium=more_share&skin=1&edition=fundamental&shareID=fe086bba2a43a2b41bfc5bce405eea86&platform=android&account_display=standard&original_module=my_profile_activity&invite=E9WV2L&lang=en_US&utm_source=invite)

Use my referral link [![ClickHere](https://img.shields.io/badge/ClickMe-success?logo=Cliqz&?style=for-the-badge)](https://crypto.com/app/gmdvtgv38s) to sign up for **Crypto.com** and we both get **$25 USD** :)

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
