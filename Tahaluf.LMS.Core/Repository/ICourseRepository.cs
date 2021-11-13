using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Repository
{
    public interface ICourseRepository : ICRUDRepository<Course>
    {
        bool Addimage(int id, string path);
        IEnumerable<Course> GetCheapestCourse();
        IEnumerable<Course> GetCourseByEndDate(Course course);
        Course GetCourseByName(Course course);
        IEnumerable<Course> GetCourseByPrice(Course course);
        IEnumerable<Course>  GetCourseByStartDate(Course course);
        IEnumerable<Course> SearchCouresByName(Course course);
    }
}