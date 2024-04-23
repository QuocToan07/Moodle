using System.ComponentModel.DataAnnotations;

namespace Moodle.Models
{
    public class Course
    {
        [Required]
        public string? Id { get; set; }

        [Required]
        public string Title { get; set; }

        public bool IsDeleted { get; set; }
    }
}
