# Yazilim Academy Backend

A robust backend solution for the Yazilim Academy platform built with .NET using Clean Architecture principles.

## 🏗️ Architecture

The project follows Clean Architecture and is organized into the following layers:

- **YazilimAcademy.Domain**: Contains business entities, interfaces, and domain logic
- **YazilimAcademy.Application**: Houses application business rules and use cases
- **YazilimAcademy.Infrastructure**: Implements external concerns and infrastructure
- **YazilimAcademy.WebApi**: Handles HTTP requests and serves as the API endpoint

## 🚀 Getting Started

### Prerequisites

- .NET 9.0 SDK or later
- PostgreSQL
- Visual Studio 2022 or any preferred IDE

### Installation

1. Clone the repository
```bash
git clone https://github.com/yazilimacademy/yazilimacademy-backend
```

2. Navigate to the project directory
```bash
cd yazilimacademy-backend
```

3. Restore dependencies
```bash
dotnet restore
```

4. Update the PostgreSQL connection string in `appsettings.json`

5. Run migrations
```bash
dotnet ef database update
```

6. Run the application
```bash
dotnet run --project src/YazilimAcademy.WebApi
```

## 🛠️ Built With

- ASP.NET Core
- Entity Framework Core
- PostgreSQL
- Clean Architecture
- CQRS Pattern
- MediatR
- AutoMapper

## 📝 License

This project is licensed under the terms of the license included in the repository.

## ✨ Contributing

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📫 Contact

For any questions or suggestions, please feel free to reach out to the project maintainers.