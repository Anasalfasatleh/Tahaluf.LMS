using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.DTO;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Repository
{
    public interface IStudentRepository : ICRUDRepository<Student>
    {
        ResponseCalculateStudentsMarksDTO CalculateStudentsMarks();
        IEnumerable<ResponseGetStudentCoursesDTO> GetStudentCourses();


    }
}
