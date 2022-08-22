namespace Less20.Middlware
{
    public class TokenMiddleware
    {
        private readonly RequestDelegate _next;

        public TokenMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Headers.TryGetValue("token", out var token))
            {
                await _next(context);

                return;
            }
            context.Response.StatusCode = 401;
        }
    }
}
