using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Services
{
    public interface ITeacherCourseServices 
    {
        bool Create(TeacherCourse teacherCourse);

        bool Update(TeacherCourse teacherCourse);

        bool Delete(int id);

        TeacherCourse GetById(int id);

        IEnumerable<TeacherCourse> GetAll();
    }
}
