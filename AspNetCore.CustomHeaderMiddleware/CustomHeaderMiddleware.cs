using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AspNetCore.CustomHeaderMiddleware
{
    public class CustomHeaderMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _name;
        private readonly string _value;

        public CustomHeaderMiddleware(RequestDelegate next, string name, string value)
        {
            _next = next;
            _name = name;
            _value = value;
        }

        public Task Invoke(HttpContext context)
        {
            
            context.Response.Headers.Add(_name, _value);
            return _next(context);
        }
    }
}
