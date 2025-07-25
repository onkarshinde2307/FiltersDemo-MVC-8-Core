using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersDemo_In_MVC8_Core.Filters
{
    public class CustomActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("⚙️ [ActionFilter] BEFORE controller action");
            Console.ResetColor();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("⚙️ [ActionFilter] AFTER controller action");
            Console.ResetColor();
        }
    }
}
