using Moodle.Models;

namespace Moodle.Storage
{
    public class Database
    {
        public static List<Student> students = new List<Student>()
        {
            new Student(){
                Id = "1",
                Name = "Toan",
                DOB = new DateTime(1999, 05, 07),
                Address = "Tay Ninh",
                IsDeleted= false
            },

            new Student(){
                Id = "2",
                Name = "Duy",
                DOB = new DateTime(1998, 01, 05),
                Address = "Vung Tau",
                IsDeleted = false
            },

            new Student(){
                Id = "3",
                Name = "Diep",
                DOB = new DateTime(2000, 04, 30),
                Address = "Ha Tinh",
                IsDeleted = false
            },

            new Student(){
                Id = "4",
                Name = "Lin",
                DOB = new DateTime(2000, 04, 30),
                Address = "Ha Tinh",
                IsDeleted = false
            },
        };


        public static List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher(){
                Id = "1",
                Name = "Phuc",
                DOB = new DateTime(1978, 02, 17),
                Address = "Ben Tre",
                IsDeleted= false
            },

            new Teacher(){
                Id = "2",
                Name = "Quy",
                DOB = new DateTime(1989, 05, 20),
                Address = "Ha Noi",
                IsDeleted = false
            },

            new Teacher(){
                Id = "3",
                Name = "Dung",
                DOB = new DateTime(1990, 01, 10),
                Address = "Quang Nam",
                IsDeleted = false
            },


            new Teacher(){
                Id = "4",
                Name = "Tung",
                DOB = new DateTime(1993, 09, 30),
                Address = "Bac Giang",
                IsDeleted = false
            },
        };


        public static List<Course> courses = new List<Course>()
        {
            new Course(){
                Id = "CSE101",
                Title = "Nhap mon lap trinh",
                IsDeleted= false
            },

           new Course(){
                Id = "CSE102",
                Title = "Lap trinh co ban",
                IsDeleted= false
            },

            new Course(){
                Id = "CSE201",
                Title = "Cau truc & giai thuat",
                IsDeleted= false
            },

            new Course(){
                Id = "CSE202",
                Title = "Lap trinh web",
                IsDeleted= false
            },
        };


        public static List<StudentJoinedCourse> studentsJoinedCourse = new List<StudentJoinedCourse>()
        {
        //    new StudentJoinedCourse(){
        //        Id = "1",
        //        StudentId = "1",
        //        CouresId = "CSE101",
        //        TeacherId = "1"
        //    },

        //    new StudentJoinedCourse(){
        //        Id = "2",
        //        StudentId = "1",
        //        CouresId = "CSE102",
        //        TeacherId = "2"
        //    },

        //      new StudentJoinedCourse(){
        //        Id = "3",
        //        StudentId = "2",
        //        CouresId = "CSE101",
        //        TeacherId = "1"
        //    },

        //    new StudentJoinedCourse(){
        //        Id = "4",
        //        StudentId = "3",
        //        CouresId = "CSE201",
        //        TeacherId = "3"
        //    },

        //    new StudentJoinedCourse(){
        //        Id = "5",
        //        StudentId = "4",
        //        CouresId = "CSE202",
        //        TeacherId = "4"
        //    },
        };


        public static List<Schedule> schedules = new List<Schedule>()
        {
             new Schedule() {
                Id = "1",
                CourseId = "CSE101",
                TeacherId = "1",
                Day = Day.Monday,
                Section = Section.Section1,
                TypeClass = Classify.Theory
             },

              new Schedule() {
                Id = "2",
                CourseId = "CSE101",
                TeacherId = "1",
                Day = Day.Monday,
                Section = Section.Section3,
                TypeClass = Classify.Pratice
             },

             new Schedule() {
                Id = "3",
                CourseId = "CSE102",
                TeacherId = "2",
                Day = Day.Monday,
                Section = Section.Section1,
                TypeClass = Classify.Theory
             },

             new Schedule() {
                Id = "4",
                CourseId = "CSE102",
                TeacherId = "2",
                Day = Day.Tuesday,
                Section = Section.Section2,
                TypeClass = Classify.Pratice,
             },

             new Schedule() {
                Id = "5",
                CourseId = "CSE102",
                TeacherId = "2",
                Day = Day.Tuesday,
                Section = Section.Section3,
                TypeClass = Classify.Pratice,
             },

             new Schedule() {
                Id = "6",
                CourseId = "CSE201",
                TeacherId = "3",
                Day = Day.Wednesday,
                Section = Section.Section1,
                TypeClass = Classify.Theory,
             },

             new Schedule() {
                Id = "7",
                CourseId = "CSE201",
                TeacherId = "3",
                Day = Day.Wednesday,
                Section = Section.Section2,
                TypeClass = Classify.Pratice,
             },

             new Schedule() {
                Id = "8",
                CourseId = "CSE202",
                TeacherId = "4",
                Day = Day.Thursday,
                Section = Section.Section3,
                TypeClass = Classify.Theory,
             },

             new Schedule() {
                Id = "9",
                CourseId = "CSE202",
                TeacherId = "4",
                Day = Day.Saturday,
                Section = Section.Section3,
                TypeClass = Classify.Pratice,
             },
        };



    }
}
