using Microsoft.AspNetCore.Mvc.Filters;

namespace Lesson20NHW.Filters
{
    public class ForecastFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await next();
        }
    }
}
