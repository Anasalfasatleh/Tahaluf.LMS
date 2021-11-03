

using System.Collections.Generic;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Services
{
    public interface ICourseService
    {
        bool Create(Course course);

        bool Update(Course course);

        bool Delete(Course course);

        IEnumerable<Course> GetAll();
        Course GetById(Course course);
        IEnumerable<Course> GetCheapestCourse();
        Course GetCourseByEndDate(Course course);
        Course GetCourseByName(Course course);
        Course GetCourseByPrice(Course course);
        Course GetCourseByStartDate(Course course);
        IEnumerable<Course> SearchCouresByName(string name);
    }
}