using Lesson20.ExeptionClasses;
namespace Lesson20.Middlewares
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
                if(context.Request.Path== "/Home" || context.Request.Path == "/Home/Privacy" || context.Request.Path == "/Home/Check")
                {
                    await _next(context);
                }
                else
                {
                    throw new PathCheckExeption("Path is empty");
                }
            }
            catch(PathCheckExeption ex1)
            {
                await context.Response.WriteAsync($"Error: {ex1.Message}");
            }
        }
    }
}
