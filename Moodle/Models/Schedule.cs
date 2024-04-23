﻿namespace Moodle.Models
{
    public class Schedule
    {
        public string Id { get; set; }
        public string CourseId { get; set; }
        public string TeacherId { get; set; }
        public Day Day { get; set; }
        public Section Section { get; set; }
        public Classify TypeClass { get; set; }
    }
}

