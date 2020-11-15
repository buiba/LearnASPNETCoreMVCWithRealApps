using LearnASPNETCoreMVCWithRealApps.Policy;
using Microsoft.AspNetCore.Builder;

namespace LearnASPNETCoreMVCWithRealApps.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseSecurityHeadersMiddleware(this IApplicationBuilder app, SecurityHeadersBuilder builder)
        {
            SecurityHeadersPolicy policy = builder.Build();
            return app.UseMiddleware<SecurityHeadersMiddleware>(policy);
        }
    }
}
