namespace Moodle.WebModels
{
    public class GetStudentJoinedCourseResponse
    {
        public List<StudentResponse> StudentsJoined { get; set; } = new List<StudentResponse>();
    }

    public class StudentResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
