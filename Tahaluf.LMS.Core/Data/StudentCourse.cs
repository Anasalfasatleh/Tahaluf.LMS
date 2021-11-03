using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Tahaluf.LMS.Data
{
    public class StudentCourse
    {
        [Key]
        public int StudentCourseId { get; set; }
        [Required]
        public int StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]

        [Required]
        public int CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]

        public  Course Course { get; set; }
        public  Student Student { get; set; }
    }
}
