using System.ComponentModel.DataAnnotations;

namespace Moodle.WebModels
{
    public class CreateCourseRequest
    {
        [Required]
        public string Title { get; set; }
    }
}
