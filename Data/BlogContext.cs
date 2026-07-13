using Microsoft.EntityFrameworkCore;
using MiniBlogingApi.Model;

namespace MiniBlogingApi.Data
{
    public class BlogContext(DbContextOptions<BlogContext> options) : DbContext(options)
    {
        public DbSet<Blog> Blogs { get; set; }
    }
}
