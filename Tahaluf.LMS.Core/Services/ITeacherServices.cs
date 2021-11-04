using System.Collections.Generic;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Services
{
    public interface ITeacherServices
    {
        bool Create(Teacher teacher);

        bool Update(Teacher teacher);

        bool Delete(int id);

        Teacher GetById(int id);

        IEnumerable<Teacher> GetAll();

        Teacher GetByEmail(Teacher teacher);

    }
}
