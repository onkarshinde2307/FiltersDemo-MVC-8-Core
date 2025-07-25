using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersDemo_In_MVC8_Core.Filters
{
    public class CustomResourceFilter : IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("📦 [ResourceFilter] BEFORE model binding");
            Console.ResetColor();
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("📦 [ResourceFilter] AFTER result executed");
            Console.ResetColor();
        }
    }
}
