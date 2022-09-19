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
                if(context.Request.Path== "/Home/AddCar"|| context.Request.Path == "/Home/DeleteCar" || context.Request.Path == "/Home")
                {
                    await _next(context);
                }
                else
                {
                    throw new CustomExeption1("Path is empty");
                }
            }
            catch(CustomExeption1 ex1)
            {
                await context.Response.WriteAsync($"Error: {ex1.Message}");
            }
        }
    }
}
