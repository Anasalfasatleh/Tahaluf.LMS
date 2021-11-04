using System.Collections.Generic;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Core.Services;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Infra.Services
{
    public class TeacherCourseServices : ITeacherCourseServices
    {
        private readonly ITeacherCourseRepository _teacherCourse;

        public TeacherCourseServices(ITeacherCourseRepository teacherCourse)
        {
            this._teacherCourse = teacherCourse;
        }

        public bool Create(TeacherCourse teacherCourse)
        {
            return _teacherCourse.Create(teacherCourse);
        }

        public bool Delete(int id)
        {
            return _teacherCourse.Delete(id);
        }

        public IEnumerable<TeacherCourse> GetAll()
        {
            return _teacherCourse.GetAll();
        }

        public TeacherCourse GetById(int id)
        {
            return _teacherCourse.GetById(id);
        }

        public bool Update(TeacherCourse teacherCourse)
        {
            return _teacherCourse.Update(teacherCourse);
        }
    }
}
