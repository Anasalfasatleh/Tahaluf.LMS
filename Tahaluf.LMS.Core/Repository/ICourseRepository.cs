using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Models;

namespace Tahaluf.LMS.Core.Repository
{
    public interface ICourseRepository
    {
        bool CreateCourse(Course course);
        bool DeleteCourse(int id);
        List<Course> GetAllCourses();
        bool UpdateCourse(Course course);
    }
}