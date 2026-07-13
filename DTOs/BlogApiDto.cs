

namespace MiniBlogingApi.DTOs
{
    public record BlogApiDto
    (
        int Id,
        string Title,
        string Content,
        string Category,
        List<string> Tags,
        DateTimeOffset CreatedAt,
        DateTimeOffset UpdatedAt
    );
}
