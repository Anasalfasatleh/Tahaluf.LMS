using Tahaluf.LMS.Core.DTO;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Repository
{
    public interface ITeacherRepository : ICRUDRepository<Teacher>
    {
        bool Create(CreateTeacherDTO teacher);
        Teacher GetByEmail(Teacher teacher);
      
    }
}