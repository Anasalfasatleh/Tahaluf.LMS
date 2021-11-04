using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Core.Services;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Infra.Services
{
    public class StudentCourseServices : IStudentCourseServices
    {
        private readonly IStudentCourseRepository _studentCourse;

        public StudentCourseServices(IStudentCourseRepository studentCourse)
        {
            this._studentCourse = studentCourse;
        }

        public bool Create(StudentCourse studentCourse)
        {
            return _studentCourse.Create(studentCourse);
        }

        public bool Delete(int id)
        {
            return _studentCourse.Delete( id);

        }

        public IEnumerable<StudentCourse> GetAll()
        {
            return _studentCourse.GetAll();

        }

        public StudentCourse GetById(int id)
        {
            return _studentCourse.GetById( id);

        }

        public bool Update(StudentCourse studentCourse)
        {
            return _studentCourse.Update(studentCourse);

        }
    }
}
