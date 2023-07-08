using System;
using Microsoft.AspNetCore.Authorization;

namespace PowerUtils.AspNetCore.Authentication.BasicAuth.Attributes
{
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary. The package will be completely removed after 2024/01/08.")]
    public class BasicAuthentication : AuthorizeAttribute
    {
        public const string AUTHENTICATION_SCHEME = "Basic";

        public BasicAuthentication()
            => AuthenticationSchemes = AUTHENTICATION_SCHEME;
    }
}
