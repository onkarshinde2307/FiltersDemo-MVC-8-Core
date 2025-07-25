using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersDemo_In_MVC8_Core.Filters
{
    public class CustomAuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("🔒 [AuthorizationFilter] Checking user access...");
            Console.ResetColor();
        }
    }
}
