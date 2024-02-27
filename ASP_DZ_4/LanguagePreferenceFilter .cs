using Microsoft.AspNetCore.Mvc.Filters;

namespace ASP_DZ_4
{
    public class LanguagePreferenceFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var acceptLanguageHeader = context.HttpContext.Request.Headers["Accept-Language"].ToString();
            var languagePreference = "Eng";

            if (acceptLanguageHeader.Contains("uk"))
            {
                languagePreference = "Ukr";
            }
            else if (acceptLanguageHeader.Contains("ru"))
            {
                languagePreference = "Rus";
            }

            context.HttpContext.Response.Headers.Add("Langs", languagePreference);
        }
    }
}
