using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.DTO;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Services
{
    public interface IStudentCourseServices 
    {
        bool Create(StudentCourse studentCourse);

        bool Update(StudentCourse studentCourse);

        bool Delete(int id);

        StudentCourse GetById(int id);

        IEnumerable<StudentCourse> GetAll();
        IEnumerable<StudentCoursesResponseDTO> StudentCourses();
    }
}
