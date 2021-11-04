

using System.Collections.Generic;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Services
{
    public interface ICourseService
    {
        bool Create(Course course);

        bool Update(Course course);

        bool Delete(int  id);

        IEnumerable<Course> GetAll();
        Course GetById(int id);
        IEnumerable<Course> GetCheapestCourse();
        IEnumerable<Course> GetCourseByEndDate(Course course);
        Course GetCourseByName(Course course);
        IEnumerable<Course> GetCourseByPrice(Course course);
        IEnumerable<Course> GetCourseByStartDate(Course course);
        IEnumerable<Course> SearchCouresByName(Course course);
    }
}