namespace Moodle.WebModels
{
    public class CourseRegistrationResponse
    {
        public bool IsSuccess { get; set; }
        public List<string> ThrowInvalid {  get; set; } = new List<string>();
    }
}
