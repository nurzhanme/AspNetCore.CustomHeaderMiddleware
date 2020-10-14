using Microsoft.AspNetCore.Builder;

namespace AspNetCore.CustomHeaderMiddleware
{
    public static class CustomHeaderMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomHeaderMiddleware(this IApplicationBuilder builder, string name, string value)
        {
            return builder.UseMiddleware<CustomHeaderMiddleware>(name, value);
        }
    }
}
