using MiniBlogingApi.DTOs;

namespace MiniBlogingApi.Data
{
    public class BlogStore
    {
        public static List<BlogApiDto> Blogs = new()
        {
            new BlogApiDto(
        1,
        "Introduction to ASP.NET Core",
        "Learn how to build modern Web APIs using ASP.NET Core.",
        "Programming",
        new List<string> { "C#", ".NET", "API" },
        DateTime.Now,
        DateTime.Now
    ),

            new BlogApiDto(
        2,
        "Understanding DTOs",
        "Learn why Data Transfer Objects are essential in API development.",
        "Programming",
        new List<string> { "DTO", "ASP.NET", "Backend" },
        DateTime.Now,
        DateTime.Now
    ),

            new BlogApiDto(
        3,
        "Getting Started with Entity Framework Core",
        "An introduction to EF Core and how it communicates with databases.",
        "Database",
        new List<string> { "EF Core", "ORM", "SQLite" },
        DateTime.Now,
        DateTime.Now
    ),

            new BlogApiDto(
        4,
        "REST API Best Practices",
        "Discover best practices for designing clean and scalable REST APIs.",
        "Web Development",
        new List<string> { "REST", "HTTP", "API" },
        DateTime.Now,
        DateTime.Now
    ),

            new BlogApiDto(
        5,
        "Dependency Injection Explained",
        "Understand how Dependency Injection works in ASP.NET Core.",
        "Programming",
        new List<string> { "DI", "ASP.NET Core", "Services" },
        DateTime.Now,
        DateTime.Now
    ),

            new BlogApiDto(
        6,
        "Working with Controllers",
        "Learn how controllers process incoming HTTP requests in ASP.NET Core.",
        "Backend",
        new List<string> { "Controllers", "Routing", "MVC" },
        DateTime.Now,
        DateTime.Now
    ),

            new BlogApiDto(
        7,
        "Introduction to SQL",
        "Learn basic SQL queries for creating and managing databases.",
        "Database",
        new List<string> { "SQL", "MySQL", "Database" },
        DateTime.Now,
        DateTime.Now
    ),

            new BlogApiDto(
        8,
        "Authentication vs Authorization",
        "Understand the difference between authentication and authorization.",
        "Security",
        new List<string> { "JWT", "Authentication", "Authorization" },
        DateTime.Now,
        DateTime.Now
    ),

            new BlogApiDto(
        9,
        "Building CRUD APIs",
        "Create APIs that support Create, Read, Update, and Delete operations.",
        "Backend",
        new List<string> { "CRUD", "REST API", "C#" },
        DateTime.Now,
        DateTime.Now
    ),

            new BlogApiDto(
        10,
        "Deploying an ASP.NET Core API",
        "Learn different ways to deploy your ASP.NET Core application.",
        "Deployment",
        new List<string> { "Azure", "Docker", "Deployment" },
        DateTime.Now,
        DateTime.Now
    )
        };
    }
}
