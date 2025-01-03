namespace dressed_backend.Models.DTOs
{
    public class GetDesignDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
    }
}
