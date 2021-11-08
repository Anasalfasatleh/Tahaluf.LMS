using System.Collections.Generic;
using Tahaluf.LMS.Core.DTO;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Services
{
    public interface IStudentServices
    {
        bool Create(Student student);

        bool Update(Student student);

        bool Delete(int id);

        Student GetById(int id);

        IEnumerable<Student> GetAll();
        ResponseCalculateStudentsMarksDTO CalculateStudentsMarks();
    }
}
