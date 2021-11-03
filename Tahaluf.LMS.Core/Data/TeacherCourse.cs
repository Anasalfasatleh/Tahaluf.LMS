using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tahaluf.LMS.Data
{
    public class TeacherCourse
    {
        [Key]
        public int TeacherCourseId { get; set; }

        [Required]
        public int TeacherId { get; set; }
        [ForeignKey(nameof(TeacherId))]

        [Required]
        public int CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]

        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}
