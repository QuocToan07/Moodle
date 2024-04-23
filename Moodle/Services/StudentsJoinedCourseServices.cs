using Moodle.Models;
using Moodle.WebModels;
using Moodle.Services;

namespace Moodle.Services
{
    public class StudentsJoinedCourseServices
    {
        public static CourseRegistrationResponse CourseRegistration(CourseRegistrationRequest request)
        {
            var studentsJoinedCourse = Storage.Database.studentsJoinedCourse;
            var schedules = Storage.Database.schedules;

            var courseRegistrationResponse = new CourseRegistrationResponse();
            var schedulesDic = schedules.ToDictionary(x => x.CourseId, x => x);

            // th: môn kh có trong schedule
            var isOpen = schedules.Any(x => x.CourseId == request.CourseId);
            if (!isOpen)
            {
                courseRegistrationResponse.IsSuccess = false;
                courseRegistrationResponse.ThrowInvalid.Add($"Invalid courseId {request.CourseId}");
                return courseRegistrationResponse;
            }

            var coursesId = studentsJoinedCourse
                .Where(x => x.StudentId == request.StudentId)
                .Select(x => x.CouresId)
                .ToList();

            foreach (var courseId in coursesId)
            {
                // th: kh có course trong studentJoinedCourse
                if (courseId != request.CourseId)
                {
                    var newCourse = new StudentJoinedCourse()
                    {
                        Id = Guid.NewGuid().ToString(),
                        StudentId = request.StudentId,
                        CouresId = request.CourseId,
                        TeacherId = GetTeacherId(request.CourseId, schedulesDic),
                    };
                    studentsJoinedCourse.Add(newCourse);

                    courseRegistrationResponse.IsSuccess = true;
                    courseRegistrationResponse.ThrowInvalid = [];

                    return courseRegistrationResponse;
                }
                else if (courseId == request.CourseId) { }
                {
                    var targetScheduleOfStudent = schedules
                        .FirstOrDefault(x => x.CourseId == courseId);

                    var targetSchedules = schedules
                        .Where(x => x.CourseId == request.CourseId)
                        .Select(x => x)
                        .ToList();

                    foreach (var targetSchedule in targetSchedules)
                    {
                        // th: có trong studentJoinedCourse BUT trùng Day | Section -> kh cho ĐK | in ra ngày trùng
                        if (targetSchedule.Day == targetScheduleOfStudent.Day
                            &&
                           targetSchedule.Section == targetScheduleOfStudent.Section
                            &&
                           targetSchedule.TypeClass == targetScheduleOfStudent.TypeClass)
                        {
                            courseRegistrationResponse.IsSuccess = false;
                            courseRegistrationResponse.ThrowInvalid.Add($"Overlapping schedules at: " +
                                $"{ConvertServices.ConvertDayToString(targetScheduleOfStudent.Day)}" +
                                $"{ConvertServices.ConvertSectionToString(targetScheduleOfStudent.Section)}" +
                                $"{ConvertServices.ConvertClassifyToString(targetScheduleOfStudent.TypeClass)} \n"
                                );
                            return courseRegistrationResponse;
                        }
                    }
                }
            }
            // th: có trong studentJoinedCourse BUT trùng Day | Section -> kh cho ĐK | in ra ngày trùng
            var addCourse = new StudentJoinedCourse()
            {
                Id = Guid.NewGuid().ToString(),
                StudentId = request.StudentId,
                CouresId = request.CourseId,
                TeacherId = GetTeacherId(request.CourseId, schedulesDic),
            };
            studentsJoinedCourse.Add(addCourse);

            courseRegistrationResponse.IsSuccess = true;
            courseRegistrationResponse.ThrowInvalid = [];

            return courseRegistrationResponse;
        }
        public static string GetTeacherId(string courseId, Dictionary<string, Schedule> schedulesDic)
        {
            var teacherId = "";
            if (schedulesDic.ContainsKey(courseId))
            {
                teacherId = schedulesDic[courseId].TeacherId;
            }
            return teacherId;
        }
    }
}
