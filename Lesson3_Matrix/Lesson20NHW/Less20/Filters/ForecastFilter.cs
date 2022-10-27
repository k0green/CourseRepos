using Microsoft.AspNetCore.Mvc.Filters;

namespace Less20.Filters
{
    public class ForecastFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await next();
        }
    }
}
