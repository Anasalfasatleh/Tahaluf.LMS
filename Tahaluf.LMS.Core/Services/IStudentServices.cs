using System.Collections.Generic;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Services
{
    public interface IStudentServices
    {
        bool Create(Student student);

        bool Update(Student student);

        bool Delete(Student student);

        Student GetById(Student student);

        IEnumerable<Student> GetAll();
    }
}
