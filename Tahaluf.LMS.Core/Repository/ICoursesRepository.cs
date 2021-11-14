using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.Data;
using Tahaluf.LMS.Core.DTO;

namespace Tahaluf.LMS.Core.Repository
{
    public interface ICoursesRepository
    {
        bool Create(Courses courseModel);
        bool Delete(int id);
        IEnumerable<Courses> GetAll();
        bool Update(Courses courseModel);
    }
}
