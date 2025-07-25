# 🚀 FiltersDemo - MVC 8 Core

A complete demo project to understand all **ASP.NET Core MVC 8 Filters** step-by-step — with clean logging, explanation, and full code 💡

---

## 📚 Filters Covered

| Filter Type        | Interface                 | Purpose                             |
|--------------------|----------------------------|--------------------------------------|
| 🔒 Authorization   | `IAuthorizationFilter`    | Access control before anything runs |
| 📦 Resource        | `IResourceFilter`         | Code before/after model binding     |
| ⚙️ Action          | `IActionFilter`           | Code before/after controller action |
| 📤 Result          | `IResultFilter`           | Code before/after result rendered   |
| 💥 Exception       | `IExceptionFilter`        | Catch and handle errors globally    |

---

## 🖼️ Screenshot

> Project view with filters in action

![Home Screenshot](./screenshot/FiltersHome.png)

---

## 🏗️ Project Structure

FiltersDemo-In-MVC8-Core/
│
├── Controllers/
│ └── HomeController.cs
├── Filters/
│ ├── CustomAuthorizationFilter.cs
│ ├── TimerActionFilter.cs
│ ├── CustomExceptionFilter.cs
│ └── CustomResultFilter.cs
├── Views/
│ └── Home/
│ └── Index.cshtml
├── screenshot/
│ └── FiltersHome.png
└── Program.cs
 

## 🧠 How Filters Work

- Filters execute in a **pipeline** — each filter type runs **in a specific order**.
- You can apply filters:
  - 🔹 **Globally** (in `Program.cs`)
  - 🔸 **On Controller or Action** using `[ServiceFilter]` or `[TypeFilter]`
- You can also create **custom filters** by implementing interfaces like `IActionFilter`, `IResultFilter`, etc.

---

## ✨ Run the Project

```bash
dotnet run
Then open:
http://localhost:xxxx/Home/Index

Check your terminal output for colored logs using Console.ForegroundColor.

📦 Technologies Used
.NET 8

ASP.NET Core MVC

C#

Visual Studio 2022

Git & GitHub

🔗 Author
Made with ❤️ by Onkar Shinde
📫 GitHub Profile
