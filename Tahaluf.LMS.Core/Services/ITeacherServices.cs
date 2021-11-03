using System.Collections.Generic;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Services
{
    public interface ITeacherServices
    {
        bool Create(Teacher teacher);

        bool Update(Teacher teacher);

        bool Delete(Teacher teacher);

        Teacher GetById(Teacher teacher);

        IEnumerable<Teacher> GetAll();

        Teacher GetByEmail(Teacher teacher);

    }
}
