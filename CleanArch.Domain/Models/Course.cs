namespace CleanArch.Domain.Models
{
    public class Course
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Desctiption { get; set; }
        public string? ImageUrl { get; set; }
    }
}
