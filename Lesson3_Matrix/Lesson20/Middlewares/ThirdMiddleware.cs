using Lesson20.ExeptionClasses;

namespace Lesson20.Middlewares
{
    public class ThirdMiddleware
    {
        private readonly RequestDelegate _next;

        public ThirdMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(GeneralExeption ex3 )
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync(ex3.Message);
            }
        }
    }
}
