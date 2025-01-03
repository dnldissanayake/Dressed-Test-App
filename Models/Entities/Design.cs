namespace dressed_backend.Models.Entities
{
    public class Design
    {
        public int Id { get; set; }
        public string DesignerId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string FileUrl { get; set; } = string.Empty;
    }
}
