using Garage.Attribute;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Garage.Middleware
{
    public class FirstMiddleware
    {
        private readonly RequestDelegate _next;

        public FirstMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await context.Response.WriteAsync("Validation error");
            }
        }
    }
}



