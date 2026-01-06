# NotesApp
NotesApp is an ASP.NET Core MVC web application that allows users to create, view, update, and delete notes.  
The project is built to demonstrate a clear understanding of MVC architecture, CRUD operations, and database interaction using Entity Framework Core.

---

## Features
- Create new notes
- View a list of saved notes
- Edit existing notes
- Delete notes
- Server-side validations
- Clean MVC separation (Controllers, Models, Views)
- Entity Framework Core with Code-First approach

---

## Tech Stack
- **Backend:** ASP.NET Core MVC, C#
- **ORM:** Entity Framework Core
- **Database:** SQL Server
- **Frontend:** HTML, CSS, JavaScript
- **UI Framework:** Bootstrap (default template)
- **IDE:** Visual Studio 2022

---

## Project Structure
NotesAppSolution
- │
- ├── NotesApp
- │ ├── Controllers # Handles HTTP requests and responses
- │ ├── Models # Domain models
- │ ├── Views # Razor views (UI layer)
- │ ├── Data # DbContext and database configuration
- │ ├── Services # Business logic (if applicable)
- │ ├── Migrations # EF Core migrations
- │ ├── wwwroot # Static files
- │ └── Program.cs
- │
- ├── NotesAppSolution.sln # Solution file
- ├── .gitignore
- └── README.md

---

## Getting Started

### Prerequisites
- Visual Studio 2022 or later
- .NET SDK compatible with the project
- SQL Server (LocalDB or full instance)

---

### Setup Instructions

1. **Clone the repository**
   ```bash
   git clone https://github.com/<your-username>/NotesApp.git

2. Open the solution
```bash
NotesAppSolution.sln
```


3. Configure database
- Add your SQL Server connection string in appsettings.json
- Ensure the database server is running

4. Apply migrations
From the Package Manager Console:
```bash
Update-Database
```

5. Run the application
Press F5 or click Run in Visual Studio

---

## Purpose of This Project
This project was created to strengthen hands-on understanding of:
- ASP.NET Core MVC workflow
- Entity Framework Core and database migrations
- CRUD implementation patterns
- Proper project and repository structure
- Real-world development practices with Git

---
## Author
Nincy Jain
