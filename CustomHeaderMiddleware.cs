using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareEstudo
{
    public class CustomHeaderMiddleware : IMiddleware
    {
        private readonly ILogger<CustomHeaderMiddleware> _logger;

        public CustomHeaderMiddleware(ILogger<CustomHeaderMiddleware> logger)
        {
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            context.Response.Headers.Add("X-Custom-Header", "Drigo ta bugado");
            await next(context);
        }
    }
}