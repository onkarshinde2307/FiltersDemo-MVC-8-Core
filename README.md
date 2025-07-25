# 🚀 FiltersDemo - MVC 8 Core

A complete demo project to understand all **ASP.NET Core MVC 8 Filters** step-by-step — with clean logging, screenshots, explanation, and full code 💡

## 📚 Filters Covered

| Filter Type        | Interface                 | Purpose                             |
|--------------------|----------------------------|--------------------------------------|
| 🔒 Authorization   | `IAuthorizationFilter`    | Access control before anything runs |
| 📦 Resource        | `IResourceFilter`         | Code before/after model binding     |
| ⚙️ Action          | `IActionFilter`           | Code before/after controller action |
| 📤 Result          | `IResultFilter`           | Code before/after result rendered   |
| 💥 Exception       | `IExceptionFilter`        | Catch and handle errors globally    |

## 🧠 How Filters Work

- Filters execute in a **pipeline** — each filter type runs in a specific order.
- They are used to inject logic **before and after** the MVC request hits controller actions or results.
- Filters are helpful for:
  - Logging
  - Authentication/Authorization
  - Exception handling
  - Modifying request/response
- You can apply filters:
  - ✅ **Globally** via `Program.cs`
  - ✅ **At Controller or Action Level** using `[ServiceFilter]` or `[TypeFilter]`
- You can also create **custom filters** by implementing:
  - `IActionFilter`
  - `IResultFilter`
  - `IAuthorizationFilter`
  - `IExceptionFilter`
  - `IResourceFilter`

## 🏗️ Folder Structure

FiltersDemo-In-MVC8-Core/
│
├── Controllers/
│   └── HomeController.cs
│
├── Filters/
│   ├── CustomAuthorizationFilter.cs
│   ├── TimerActionFilter.cs
│   ├── CustomExceptionFilter.cs
│   └── CustomResultFilter.cs
│
├── Models/
│   └── (Your model files, if any)
│
├── Properties/
│   └── launchSettings.json
│
├── Screenshots/
│   └── FiltersHome.png
│
├── Views/
│   └── Home/
│       ├── Index.cshtml
│       └── Privacy.cshtml
│
├── wwwroot/
│   └── (Static files like CSS, JS, images)
│
├── bin/
│   └── Debug/
│       └── net8.0/
│
├── obj/
│
├── FiltersDemo-In-MVC8-Core.csproj
├── FiltersDemo-In-MVC8-Core.csproj.user
├── Program.cs
├── appsettings.Development.json
└── README.md ✅


## 🖼️ Screenshot

> Filters in action (Home page)

![Home Screenshot](./Screenshots/FiltersHome.png)

## 🚀 How to Run

```bash
dotnet run
Then open your browser:

arduino
Copy code
http://localhost:xxxx/Home/Index
You’ll see filters executing and logging in the terminal. Colored outputs are done using:

csharp
Copy code
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Logging from filter");
Console.ResetColor();
💻 Technologies Used
✅ ASP.NET Core MVC 8

✅ .NET 8 SDK

✅ C#

✅ Visual Studio 2022

✅ Git & GitHub

👨‍💻 Author
Made with ❤️ by Onkar Shinde
🔗 GitHub: onkarshinde2307
