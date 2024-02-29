using System.ComponentModel.DataAnnotations;

namespace PostgreDemo.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
