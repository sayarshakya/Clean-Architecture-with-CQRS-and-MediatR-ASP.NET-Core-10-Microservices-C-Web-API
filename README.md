# Clean-Architecture-with-CQRS-and-MediatR-ASP.NET-Core-10-Microservices-C-Web-API

![GitHub stars](https://img.shields.io/github/stars/sayarshakya/Clean-Architecture-with-CQRS-and-MediatR-ASP.NET-Core-10-Microservices-C-Web-API.git?style=for-the-badge&logo=github) ![GitHub forks](https://img.shields.io/github/forks/sayarshakya/Clean-Architecture-with-CQRS-and-MediatR-ASP.NET-Core-10-Microservices-C-Web-API.git?style=for-the-badge&logo=github) ![GitHub issues](https://img.shields.io/github/issues/sayarshakya/Clean-Architecture-with-CQRS-and-MediatR-ASP.NET-Core-10-Microservices-C-Web-API.git?style=for-the-badge&logo=github) ![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

## 📑 Table of Contents

- [Description](#description)
- [Tech Stack](#tech-stack)
- [Quick Start](#quick-start)
- [Key Dependencies](#key-dependencies)
- [Screenshots](#screenshots)
- [Project Structure](#project-structure)
- [Development Setup](#development-setup)
- [Contributing](#contributing)

## 📝 Description

A sophisticated reference implementation and boilerplate for building scalable enterprise applications using ASP.NET Core 10. This project showcases the synergy between Clean Architecture, CQRS (Command Query Responsibility Segregation), and the MediatR library within a Microservices-based ecosystem. By leveraging C# and Web API, it provides a robust foundation that prioritizes separation of concerns, maintainability, and high performance. Ideal for developers looking to master modern architectural patterns or kickstart their next large-scale .NET project with industry-standard best practices.

## 🛠️ Tech Stack

- 🔷 .NET

## ⚡ Quick Start

```bash

# Clone the repository
git clone https://github.com/sayarshakya/Clean-Architecture-with-CQRS-and-MediatR-ASP.NET-Core-10-Microservices-C-Web-API.git

# Restore and run
dotnet restore && dotnet run
```

## 📦 Key Dependencies

```
Microsoft.AspNetCore.OpenApi: 10.0.7
```

## 📸 Screenshots

> **Tip:** You can auto-generate a beautiful project mockup image using the **Screenshot** button above!

<p align="center">
  <img src="https://via.placeholder.com/800x400?text=Main+Application+View" alt="Main Application View" width="80%"/>
</p>

<p align="center">
  <img src="https://via.placeholder.com/800x400?text=Feature+Showcase" alt="Feature Showcase" width="80%"/>
</p>

## 📁 Project Structure

```
.
├── MyApp.API
│   ├── Controllers
│   │   └── StudentController.cs
│   ├── DependencyInjection.cs
│   ├── MyApp.API.csproj
│   ├── MyApp.API.csproj.user
│   ├── MyApp.API.http
│   ├── MyApp.API.slnx
│   ├── Program.cs
│   ├── Properties
│   │   └── launchSettings.json
│   ├── appsettings.Development.json
│   └── appsettings.json
├── MyApp.Application
│   ├── Commands
│   │   ├── AddStudentCommand.cs
│   │   ├── DeleteStudentCommand.cs
│   │   └── UpdateStudentCommand.cs
│   ├── DependencyInjection.cs
│   ├── Interfaces
│   │   └── IStudentRepository.cs
│   ├── MyApp.Application.csproj
│   └── Queries
│       └── GetAllStudentsQuery.cs
├── MyApp.Domain
│   ├── DependencyInjection.cs
│   ├── Entities
│   │   └── Student.cs
│   └── MyApp.Domain.csproj
└── MyApp.Infrastructure
    ├── Data
    │   └── ApplicationDbContext.cs
    ├── DependencyInjection.cs
    ├── Migrations
    │   ├── 20260515044306_dbinit.Designer.cs
    │   ├── 20260515044306_dbinit.cs
    │   └── ApplicationDbContextModelSnapshot.cs
    ├── MyApp.Infrastructure.csproj
    └── Repositories
        └── StudentRepository.cs
```

## 🛠️ Development Setup

### .NET Setup
1. Install [.NET SDK](https://dotnet.microsoft.com/)
2. Restore dependencies: `dotnet restore`
3. Build the project: `dotnet build`
4. Run the project: `dotnet run`

## 👥 Contributing

Contributions are welcome! Here's how you can help:

1. **Fork** the repository
2. **Clone** your fork: `git clone https://github.com/sayarshakya/Clean-Architecture-with-CQRS-and-MediatR-ASP.NET-Core-10-Microservices-C-Web-API.git`
3. **Create** a new branch: `git checkout -b feature/your-feature`
4. **Commit** your changes: `git commit -am 'Add some feature'`
5. **Push** to your branch: `git push origin feature/your-feature`
6. **Open** a pull request

Please ensure your code follows the project's style guidelines and includes tests where applicable.

---
*This README was generated with ❤️ by [ReadmeBuddy](https://readmebuddy.com)*
