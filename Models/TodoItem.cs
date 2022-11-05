using System.ComponentModel.DataAnnotations;

namespace TodoAPI.Models
{
    public class TodoItem
    {
        [Required]
        public string? ID { get; set; }

        [Required]
        public string? Expression { get; set; }

        [Required]
        public string? Option1 { get; set; }

        [Required]
        public string? Option2 { get; set; }

        [Required]
        public string? Option3 { get; set; }

  
    }
}
