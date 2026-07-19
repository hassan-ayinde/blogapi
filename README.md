# 📝 Blog API

A RESTful Blog API built with **ASP.NET Core (.NET 10)** that enables users to create, read, update, and delete blog posts. The API uses **PostgreSQL** as its database and is deployed on **Railway**. Interactive API documentation is available through **Swagger/OpenAPI**.

---

## 🚀 Live Demo

### API Base URL

```
https://your-railway-url.up.railway.app
```

### Swagger Documentation

```
https://your-railway-url.up.railway.app/swagger
```

> Replace the URLs above with your Railway deployment URL.

---

## ✨ Features

- Create blog posts
- Retrieve all blog posts
- Retrieve a single blog post
- Update existing blog posts
- Delete blog posts
- PostgreSQL database integration
- Entity Framework Core
- Dependency Injection
- Swagger/OpenAPI documentation
- RESTful API architecture
- Data validation

---

## 🛠️ Tech Stack

- ASP.NET Core Web API (.NET 10)
- C#
- Entity Framework Core
- PostgreSQL
- Npgsql Entity Framework Provider
- Swagger / OpenAPI
- Railway (Deployment)
- Git & GitHub

---

## 📂 Project Structure

```
BlogApi/
│
├── Controllers/
├── Models/
├── DTOs/
├── Data/
├── Migrations/
├── appsettings.json
├── Program.cs
└── README.md
```

---

## 📦 Prerequisites

Before running locally, install:

- .NET 10 SDK
- PostgreSQL
- Visual Studio 2026 or VS Code
- Git

---

## ⚙️ Running Locally

### 1. Clone the repository

```bash
git clone https://github.com/yourusername/blog-api.git

cd blog-api
```

---

### 2. Configure the database

Update your connection string in **appsettings.json**

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=BlogDb;Username=postgres;Password=yourpassword"
  }
}
```

---

### 3. Restore packages

```bash
dotnet restore
```

---

### 4. Apply migrations

```bash
dotnet ef database update
```

---

### 5. Run the application

```bash
dotnet run
```

The API will be available at

```
https://localhost:5001
```

---

## 📖 API Documentation

Swagger is available at:

```
/swagger
```

Example:

```
https://localhost:5001/swagger
```

or

```
https://your-railway-url.up.railway.app/swagger
```

---

## 📌 API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/blogs` | Get all blog posts |
| GET | `/api/blogs/{id}` | Get a blog by ID |
| POST | `/api/blogs` | Create a blog post |
| PUT | `/api/blogs/{id}` | Update a blog post |
| DELETE | `/api/blogs/{id}` | Delete a blog post |

---

## 📝 Example Request

```json
{
  "title": "Getting Started with ASP.NET Core",
  "content": "This is my first blog post.",
  "author": "John Doe"
}
```

---

## 📄 Example Response

```json
{
  "id": 1,
  "title": "Getting Started with ASP.NET Core",
  "content": "This is my first blog post.",
  "author": "John Doe",
  "createdAt": "2026-07-18T15:30:00Z"
}
```

---

## 🚀 Deployment

The API is deployed on **Railway** using PostgreSQL.

Deployment includes:

- ASP.NET Core Web API
- PostgreSQL database
- Entity Framework Core migrations
- HTTPS support

---

## 🔧 Built With

- ASP.NET Core (.NET 10)
- Entity Framework Core
- PostgreSQL
- Npgsql
- Swagger
- Railway

## Project Url

[prject url](https://roadmap.sh/projects/blogging-platform-api)

---

## 📈 Future Improvements

- JWT Authentication
- User registration and login
- Role-based authorization
- Pagination
- Search functionality
- Categories
- Comments
- Image uploads
- Docker support
- Unit and integration tests
- CI/CD pipeline

---

## 🤝 Contributing

Contributions are welcome.

1. Fork the repository

2. Create a feature branch

```bash
git checkout -b feature/new-feature
```

3. Commit your changes

```bash
git commit -m "Add new feature"
```

4. Push your branch

```bash
git push origin feature/new-feature
```

5. Open a Pull Request

---

## 📄 License

This project is licensed under the MIT License.

---

## 👨‍💻 Author

**Your Name**

GitHub: https://github.com/yourusername

LinkedIn: https://linkedin.com/in/yourprofile

---

## ⭐ Show Your Support

If you found this project useful, consider giving it a ⭐ on GitHub.