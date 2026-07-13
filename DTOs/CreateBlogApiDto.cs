using System.ComponentModel.DataAnnotations;

namespace MiniBlogingApi.DTOs
{
    public record CreateBlogApiDto
    (
        [Required] string Title,
        [Required] string Content,
        [Required] string Category,
        [Required] [MinLength(1)] List<string> Tags
    );
}
