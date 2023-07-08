# PowerUtils.AspNetCore.Authentication.BasicAuth

# :warning: DEPRECATED

This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary. The package will be completely removed after 2024/01/08.

![Logo](https://raw.githubusercontent.com/TechNobre/PowerUtils.AspNetCore.Authentication.BasicAuth/main/assets/logo/logo_128x128.png)

***Utils, helpers, extensions and attributes to work with Basic authentication***

[![NuGet](https://img.shields.io/nuget/v/PowerUtils.AspNetCore.Authentication.BasicAuth.svg)](https://www.nuget.org/packages/PowerUtils.AspNetCore.Authentication.BasicAuth)
[![Nuget](https://img.shields.io/nuget/dt/PowerUtils.AspNetCore.Authentication.BasicAuth.svg)](https://www.nuget.org/packages/PowerUtils.AspNetCore.Authentication.BasicAuth)
[![License: MIT](https://img.shields.io/github/license/TechNobre/PowerUtils.AspNetCore.Authentication.BasicAuth.svg)](https://github.com/TechNobre/PowerUtils.AspNetCore.Authentication.BasicAuth/blob/main/LICENSE)


- [Support](#support-to)
- [Dependencies](#dependencies)
- [How to use](#how-to-use)
  - [Installation](#Installation)
  - [Attributes](#Attributes)
    - [BasicAuthentication](#BasicAuthentication)
- [Contribution](#contribution)
- [License](./LICENSE)
- [Changelog](./CHANGELOG.md)



## Support to <a name="support-to"></a>
- .NET 6.0
- .NET 5.0
- .NET 3.1



## Dependencies <a name="dependencies"></a>

- Microsoft.AspNetCore.Authorization [NuGet](https://www.nuget.org/packages/Microsoft.AspNetCore.Authorization/)



## How to use <a name="how-to-use"></a>

### Install NuGet package <a name="Installation"></a>
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



## Contribution <a name="contribution"></a>

If you have any questions, comments, or suggestions, please open an [issue](https://github.com/TechNobre/PowerUtils.AspNetCore.Authentication.BasicAuth/issues/new/choose) or create a [pull request](https://github.com/TechNobre/PowerUtils.AspNetCore.Authentication.BasicAuth/compare)