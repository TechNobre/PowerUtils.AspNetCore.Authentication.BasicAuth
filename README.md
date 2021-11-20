# PowerUtils.AspNetCore.Authentication.BasicAuth
Utils, helpers, extensions and attributes to work with Basic authentication

![CI](https://github.com/TechNobre/PowerUtils.AspNetCore.Authentication.BasicAuth/actions/workflows/main.yml/badge.svg)
[![NuGet](https://img.shields.io/nuget/v/PowerUtils.AspNetCore.Authentication.BasicAuth.svg)](https://www.nuget.org/packages/PowerUtils.AspNetCore.Authentication.BasicAuth)
[![Nuget](https://img.shields.io/nuget/dt/PowerUtils.AspNetCore.Authentication.BasicAuth.svg)](https://www.nuget.org/packages/PowerUtils.AspNetCore.Authentication.BasicAuth)




## Support to
- .NET 3.1, .NET 5.0 and .NET 6.0




## Features

- [Installation](#Installation)
- [Attributes](#Attributes)
  - [BasicAuthentication](#BasicAuthentication)


## Documentation

### Dependencies

- Microsoft.AspNetCore.Authorization [NuGet](https://www.nuget.org/packages/Microsoft.AspNetCore.Authorization/)

### How to use

#### Install NuGet package <a name="Installation"></a>
This package is available through Nuget Packages: https://www.nuget.org/packages/PowerUtils.AspNetCore.Authentication.BasicAuth

**Nuget**
```bash
Install-Package PowerUtils.AspNetCore.Authentication.BasicAuth
```

**.NET CLI**
```
dotnet add package PowerUtils.AspNetCore.Authentication.BasicAuth
```

### Attributes <a name="Attributes"></a>

#### BasicAuthentication; <a name="BasicAuthentication"></a>
Attribute to limit access to a controller or action with a basic authentication

```csharp
[BasicAuthentication]
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return this.Ok();
    }
}
```

```csharp
[ApiController]
public class TestController : ControllerBase
{
    [BasicAuthentication]
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return this.Ok();
    }
}
```



## Contribution

*Help me to help others*




## LICENSE

[MIT](https://github.com/TechNobre/PowerUtils.AspNetCore.Authentication.BasicAuth/blob/main/LICENSE)




## Release Notes


### v1.0.0 - 2021/11/20
- Kick start project