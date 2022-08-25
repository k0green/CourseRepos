using Lesson20.ExeptionClasses;

namespace Lesson20.Middlewares
{
    public class SecondMiddleware
    {
        private readonly RequestDelegate _next;

        public SecondMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                var token = context.Request.Headers.TryGetValue("token", out var tokens);
                if (string.IsNullOrEmpty(tokens))
                {
                    throw new CustomExeption2("token is invalid");
                }
                else
                {
                    await _next(context);
                    return;
                }
            }
            catch(CustomExeption2 ex2)
            {
                await context.Response.WriteAsync($"Error: {ex2.Message}");
            }
        }
    }
}
