using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.DTO;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Repository
{
    public interface IStudentCourseRepository : ICRUDRepository<StudentCourse>
    {
        IEnumerable<StudentCoursesResponseDTO> StudentCourses();
    }
}
