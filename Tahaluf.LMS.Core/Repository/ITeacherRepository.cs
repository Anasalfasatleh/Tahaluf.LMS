using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Repository
{
    public interface ITeacherRepository : ICRUDRepository<Teacher>
    {
        Teacher GetByEmail(Teacher teacher);
      
    }
}