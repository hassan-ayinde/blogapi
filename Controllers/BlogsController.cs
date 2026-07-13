using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniBlogingApi.Data;
using MiniBlogingApi.DTOs;
using MiniBlogingApi.Model;

namespace MiniBlogingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly BlogContext _context;

        public BlogsController(BlogContext context)
        {
            _context = context;
        }

        // GET: api/blogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BlogApiDto>>> GetBlogs(string? search)
        {
            var query = _context.Blogs.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(blog =>
                    blog.Title.Contains(search) ||
                    (blog.Content != null && blog.Content.Contains(search)) ||
                    (blog.Category != null && blog.Category.Contains(search)));
            }

            var blogs = await query
                .Select(blog => new BlogApiDto(
                    blog.Id,
                    blog.Title,
                    blog.Content ?? "",
                    blog.Category ?? "",
                    blog.Tags.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList(),
                    blog.CreatedAt,
                    blog.UpdatedAt
                ))
                .ToListAsync();

            return Ok(blogs);
        }
        // GET: api/blogs/1
        [HttpGet("{id}")]
        public async Task<ActionResult<BlogApiDto>> GetBlogById(int id)
        {
            var blog = await _context.Blogs.FirstOrDefaultAsync(b => b.Id == id);

            if (blog == null)
            {
                return NotFound();
            }

            var blogDto = new BlogApiDto(
                blog.Id,
                blog.Title,
                blog.Content ?? "",
                blog.Category ?? "",
                blog.Tags.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList(),
                blog.CreatedAt,
                blog.UpdatedAt
            );

            return Ok(blogDto);
        }

        // POST: api/blogs
        [HttpPost]
        public async Task<ActionResult<BlogApiDto>> CreateBlog(CreateBlogApiDto dto)
        {
            var blog = new Blog
            {
                Title = dto.Title,
                Content = dto.Content,
                Category = dto.Category,
                Tags = string.Join(",", dto.Tags),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _context.Blogs.Add(blog);

            await _context.SaveChangesAsync();

            var blogDto = new BlogApiDto(
                blog.Id,
                blog.Title,
                blog.Content ?? "",
                blog.Category ?? "",
                blog.Tags.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList(),
                blog.CreatedAt,
                blog.UpdatedAt
            );

            return CreatedAtAction(
                nameof(GetBlogById),
                new { id = blog.Id },
                blogDto
            );
        }

        // PUT: api/blogs/1
        [HttpPut("{id}")]
        public async Task<ActionResult<BlogApiDto>> UpdateBlog(int id, UpdateBlogApiDTO dto)
        {
            var blog = await _context.Blogs.FindAsync(id);

            if (blog == null)
            {
                return NotFound();
            }

            blog.Title = dto.Title;
            blog.Content = dto.Content;
            blog.Category = dto.Category;
            blog.Tags = string.Join(",", dto.Tags);
            blog.UpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            var blogDto = new BlogApiDto(
                blog.Id,
                blog.Title,
                blog.Content ?? "",
                blog.Category ?? "",
                blog.Tags.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList(),
                blog.CreatedAt,
                blog.UpdatedAt
            );

            return Ok(blogDto);
        }

        // DELETE: api/blogs/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);

            if (blog == null)
            {
                return NotFound();
            }

            _context.Blogs.Remove(blog);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}