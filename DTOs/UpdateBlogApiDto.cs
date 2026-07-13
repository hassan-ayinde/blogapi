namespace MiniBlogingApi.DTOs
{
    public record UpdateBlogApiDTO
    (
        string Title,
        string Content,
        string Category,
        List<string> Tags
    );
}
