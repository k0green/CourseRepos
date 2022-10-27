namespace Less20.Middlware
{
    public class SecondMiddleware
    {
        private readonly RequestDelegate _next;
        private static List<string> _logs = new List<string>();

        public SecondMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Headers.TryGetValue("token", out var token))
            {
                await _next(context);
                _logs.Add(context.Request.Path);
                return;
            }
            context.Response.StatusCode = 401;
        }
    }
}
