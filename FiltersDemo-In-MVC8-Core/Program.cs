using FiltersDemo_In_MVC8_Core.Filters;

var builder = WebApplication.CreateBuilder(args);

// Register all custom filters with DI
builder.Services.AddScoped<CustomAuthorizationFilter>();
builder.Services.AddScoped<CustomResourceFilter>();
builder.Services.AddScoped<CustomActionFilter>();
builder.Services.AddScoped<CustomResultFilter>();
builder.Services.AddScoped<CustomExceptionFilter>();

// Apply filters globally
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<CustomAuthorizationFilter>();
    options.Filters.Add<CustomResourceFilter>();
    options.Filters.Add<CustomActionFilter>();
    options.Filters.Add<CustomResultFilter>();
    options.Filters.Add<CustomExceptionFilter>();
});

var app = builder.Build();

// Middleware pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
