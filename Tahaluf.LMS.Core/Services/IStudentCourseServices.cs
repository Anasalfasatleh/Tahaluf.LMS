using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Services
{
    public interface IStudentCourseServices 
    {
        bool Create(StudentCourse studentCourse);

        bool Update(StudentCourse studentCourse);

        bool Delete(StudentCourse studentCourse);

        StudentCourse GetById(StudentCourse studentCourse);

        IEnumerable<StudentCourse> GetAll();
    }
}
