using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersDemo_In_MVC8_Core.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("💥 [ExceptionFilter] Error: " + context.Exception.Message);
            Console.ResetColor();

            context.Result = new ContentResult
            {
                Content = "💥 Custom Error: " + context.Exception.Message
            };
            context.ExceptionHandled = true;
        }
    }
}
