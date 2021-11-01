using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Tahaluf.LMS.Models
{
    public class Student
    {
       
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Fname { get; set; }

        [Required]
        public string Lname { get; set; }

        public DateTime? BirthDate { get; set; }
        public double? Mark { get; set; }

        public  ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
