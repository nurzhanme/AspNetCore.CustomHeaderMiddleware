using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AspNetCore.CustomHeaderMiddleware
{
    public class CustomHeaderMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomHeaderMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context, string key, string value)
        {
            
            context.Response.Headers.Add(key, value);
            return _next(context);
        }
    }
}
