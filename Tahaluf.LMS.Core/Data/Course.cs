using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Tahaluf.LMS.Data
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public double Price { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public  ICollection<Book> Books { get; set; }
        public  ICollection<StudentCourse> StudentCourses { get; set; }
        public  ICollection<TeacherCourse> TeacherCourses { get; set; }
    }

   

}
