using Microsoft.AspNetCore.Mvc;

namespace ASP_DZ_4
{
    [ServiceFilter(typeof(LanguagePreferenceFilter))]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var language = HttpContext.Response.Headers["Langs"].FirstOrDefault() ?? "Eng";
            Console.WriteLine(language);
            string greeting = "";
            if (language == "Ukr") greeting = "Привіт світ!";
            else if (language == "Rus") greeting = "Привет мир!";
            else greeting = "Hellow World!";

            return Content(greeting);
        }
    }
}
