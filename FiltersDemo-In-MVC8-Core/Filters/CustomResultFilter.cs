using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersDemo_In_MVC8_Core.Filters
{
    public class CustomResultFilter : IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("📤 [ResultFilter] BEFORE view is rendered");
            Console.ResetColor();
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("📤 [ResultFilter] AFTER view is rendered");
            Console.ResetColor();
        }
    }
}
