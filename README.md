# 🚀 Task Management API (.NET 10)

![.NET](https://img.shields.io/badge/.NET-10.0-blueviolet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET-Core-blue)
![EF Core](https://img.shields.io/badge/Entity%20Framework-Core-green)
![JWT](https://img.shields.io/badge/Auth-JWT-orange)
![License](https://img.shields.io/badge/License-MIT-lightgrey)

A secure and scalable **Task Management REST API** built with **ASP.NET Core (.NET 10)**, **Entity Framework Core**, and **JWT Authentication**.

This project demonstrates a clean backend architecture with authentication, authorization, and full CRUD operations for task management.

---

## ✨ Features

- 🔐 User Registration & Login
- 🔑 JWT Authentication & Authorization
- 📋 Full CRUD operations for Tasks
- 👤 User-based task ownership
- ⚠️ Global Exception Handling Middleware
- 🧱 Clean layered architecture (Controllers, Services, Repositories)
- 📄 Swagger API documentation

---

## 🛠️ Tech Stack

- ASP.NET Core Web API (.NET 10)
- Entity Framework Core
- SQL Server
- JWT Bearer Authentication
- Swagger / OpenAPI
- C#

---

## 🏗️ Project Structure

TaskManagementAPI
│
├── Controllers
│   ├── AuthController.cs
│   └── TasksController.cs
│
├── Data
│   └── ApplicationDbContext.cs
│
├── DTOs
│   ├── CreateTaskDto.cs
│   ├── LoginDto.cs
│   ├── RegisterDto.cs
│   └── UpdateTaskDto.cs
│
├── Middlewares
│   └── ExceptionMiddleware.cs
│
├── Models
│   ├── TaskItem.cs
│   └── User.cs
│
├── Repositories
│   ├── ITaskRepository.cs
│   └── TaskRepository.cs
│
├── Services
│   ├── ITaskService.cs
│   ├── TaskService.cs
│   └── JwtService.cs
│
├── Migrations
│
├── Program.cs
├── appsettings.json
└── launchsettings.json

---

## 🔐 Authentication Flow

This API uses JWT Bearer Token Authentication.

### Register
POST /api/Auth/register

### Login
POST /api/Auth/login

Response:
{
  "token": "your_jwt_token_here"
}

---

## 🔓 Swagger Authentication

1. Run project
2. Open:
https://localhost:7061/swagger
3. Click Authorize
4. Paste:
Bearer YOUR_TOKEN

---

## 📌 API Endpoints

### Auth
- POST /api/Auth/register → Register new user  
- POST /api/Auth/login → Login and get token  

### Tasks
- GET /api/Tasks → Get all tasks  
- GET /api/Tasks/{id} → Get task by id  
- POST /api/Tasks → Create task  
- PUT /api/Tasks/{id} → Update task  
- DELETE /api/Tasks/{id} → Delete task  

---

## ⚙️ Setup & Run

git clone https://github.com/your-username/TaskManagementAPI.git  
dotnet restore  
dotnet ef database update  
dotnet run  

---

## 📸 Swagger UI

https://localhost:7061/swagger

---

## 🧠 Architecture

Controllers → Handle requests  
Services → Business logic  
Repositories → Data access  
DTOs → Data transfer objects  
Middleware → Exception handling  
EF Core → Database layer  

---

## 👨‍💻 Author

Developed by Sebine Isgenderova

---

## 📌 Notes

- Requires SQL Server running  
- JWT required for task endpoints  
- Built with clean architecture principles
