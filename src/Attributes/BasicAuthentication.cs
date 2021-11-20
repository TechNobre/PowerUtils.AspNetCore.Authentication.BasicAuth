using Microsoft.AspNetCore.Authorization;

namespace PowerUtils.AspNetCore.Authentication.BasicAuth.Attributes
{
    public class BasicAuthentication : AuthorizeAttribute
    {
        public const string AUTHENTICATION_SCHEME = "Basic";

        public BasicAuthentication()
        {
            this.AuthenticationSchemes = AUTHENTICATION_SCHEME;
        }
    }
}