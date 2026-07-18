# 🎓 EduCore
![.NET](https://img.shields.io/badge/.NET-8.0-purple)
![C#](https://img.shields.io/badge/C%23-Language-blue)
![Entity Framework Core](https://img.shields.io/badge/EF-Core-green)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-red)
![License](https://img.shields.io/badge/License-MIT-yellow)

A Console-based Learning Management System (LMS) built with **C#**, **.NET**, **Entity Framework Core**, and **SQL Server**.

This project was developed to practice **C#**, **LINQ**, **Entity Framework Core**, **Database Design**, and **Software Architecture** before moving to ASP.NET Core MVC.

---

# 🚀 Features

### 👨‍🎓 Student Management
- Add Student
- Update Student
- Delete Student
- Get Student By ID
- Search Student by Name
- List All Students
- Pagination

### 📚 Course Management
- Manage Courses
- Assign Instructors
- Assign Departments

### 👨‍🏫 Instructor Management
- Manage Instructors
- Department Assignment

### 🏢 Department Management
- Manage Departments

### 📝 Enrollment Management
- Student Enrollment
- Enrollment Progress
- Enrollment Status

### 📊 Reports
- Number of Courses per Student
- Course Statistics
- Department Statistics
- Top 5 Most Popular Courses
- Students Without Courses
- Courses Without Students
- Average Course Price per Department
- Dashboard Summary

---

# 🏗️ Project Structure

```text
EduCore
│
├── Application
│   ├── Interfaces
│   └── Services
│
├── Domain
│   ├── Entities
│   └── Enums
│
├── Infrastructure
│   ├── Configurations
│   ├── Data
│   ├── Repositories
│   ├── Seed
│
├── Migrations 
│
├── View
│   └── Menus
│
├── Program.cs
└── appsettings.json
```

# 🏛️ Architecture

The project follows a layered architecture:

- **Domain** → Entities and Enums
- **Infrastructure** → EF Core, Repositories, Configurations, Seed Data
- **Application** → Business Logic and Services
- **View** → Console Menus and User Interaction

---

# 🗄️ Database Design

The project database consists of the following entities:

- Student
- Course
- Instructor
- Department
- Enrollment

Implemented using:

- Entity Framework Core
- Fluent API
- Composite Primary Keys
- One-to-Many Relationships
- Many-to-Many Relationships
- Check Constraints
- Seed Data

## ER Diagram

![ERD](ERD.png)

---

# 📸 Screenshots

## Main Menu

![Main Menu](ScreenShots/MainMenu.png)

---

## Student Menu

![Student Menu](ScreenShots/StudentMenu.png)

---

## Dashboard

![Dashboard](ScreenShots/Dashboard.png)

---

## Reports

![Report 1](ScreenShots/Report1.png)

![Report 2](ScreenShots/Report2.png)

![Report 3](ScreenShots/Report3.png)

![Report 4](ScreenShots/Report4.png)


---

## Add Student

![Add Student](ScreenShots/AddStudent.png)


---


# 🛠️ Technologies Used

- C#
- .NET
- Entity Framework Core
- SQL Server
- LINQ
- Fluent API
- Repository Pattern
- Service Layer
- Console Application

---

# 📦 NuGet Packages

The project uses the following NuGet packages:

```text
Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.SqlServer

Microsoft.EntityFrameworkCore.Tools

Microsoft.EntityFrameworkCore.Design

Microsoft.Extensions.Configuration

Microsoft.Extensions.Configuration.Json

Microsoft.Extensions.Configuration.FileExtensions

Microsoft.Extensions.Configuration.Binder
```

You can restore all packages using:

```bash
dotnet restore
```

or simply open the solution using Visual Studio.

---

# 📋 Requirements

Before running the project, make sure you have installed:

- Visual Studio 2022
- .NET 8 SDK
- SQL Server
- SQL Server Management Studio (Optional)

  ---
  
# ⚙️ Getting Started

## 1. Clone the Repository

```bash
git clone https://github.com/gomaa1212/EduCore.git
```

---

## 2. Open the Project

Open the solution using **Visual Studio 2022**.

---

## 3. Restore NuGet Packages

```bash
dotnet restore
```

---

## 4. Configure SQL Server

Open:

```text
appsettings.json
```

Replace the connection string with your own SQL Server instance.

Example:

```json
{
  "constr": "Data Source=YOUR_SERVER;Initial Catalog=EduCore;Integrated Security=True;TrustServerCertificate=True;"
}
```

---

## 5. Create the Database

Run the existing migrations.

Using Package Manager Console:

```powershell
Update-Database
```

or using .NET CLI:

```bash
dotnet ef database update
```

The database will be created automatically and all **Seed Data** will be inserted.

---

## 6. Run the Project

Press **F5** in Visual Studio

or

```bash
dotnet run
```

---

# 📊 Available Reports

- Students and Number of Enrolled Courses
- Courses with Student Count
- Department Statistics
- Top 5 Popular Courses
- Students Without Enrollments
- Courses Without Students
- Average Course Price by Department
- System Dashboard

---

# 📚 What I Learned

During this project I practiced:

- Object-Oriented Programming (OOP)
- Entity Framework Core
- Fluent API
- SQL Server
- LINQ
- Navigation Properties
- Repository Pattern
- Service Layer
- Database Design
- Seed Data
- Console Application Architecture
- Reporting using LINQ

---

# 🔮 Future Improvements

- [ ] Convert the project to ASP.NET Core MVC
- [ ] Implement Dependency Injection
- [ ] Implement Generic Repository
- [ ] Convert repositories to Async
- [ ] Add Authentication & Authorization
- [ ] Add Validation
- [ ] Add Search & Filtering
- [ ] Add Sorting
- [ ] Add Unit Testing
- [ ] Add Logging

---

# 👨‍💻 Author

**Abdelrahman Mohamed**

.NET Backend Developer


LinkedIn:
https://www.linkedin.com/in/abdelrahman-mohammed-87445a284/
---

# ⭐ If you like this project

Please consider giving it a **Star ⭐** on GitHub.
