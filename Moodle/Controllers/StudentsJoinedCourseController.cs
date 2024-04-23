using Moodle.WebModels;
using Microsoft.AspNetCore.Mvc;
using Moodle.Services;

namespace Moodle.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsJoinedCourseController : ControllerBase
    {

        private readonly ILogger<StudentsJoinedCourseController> _logger;

        public StudentsJoinedCourseController(ILogger<StudentsJoinedCourseController> logger)
        {
            _logger = logger;
        }

        [HttpPost("course-registration")]
        public IActionResult CourseRegistration([FromBody] CourseRegistrationRequest request)
        {
            var registrationRespon = StudentsJoinedCourseServices.CourseRegistration(request);
            if(registrationRespon != null)
            {
                return Ok(registrationRespon);
            }
            return NotFound($"Can be not found this id: {request.StudentId} or {request.CourseId}");
        }
    }
}
