namespace MiniBlogingApi.Model
{
    public class Blog
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Content { get; set; }
        public string? Category { get; set;  }
        public string Tags { get; set; } = "";
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
