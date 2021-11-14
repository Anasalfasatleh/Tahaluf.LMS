using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.Data;

namespace Tahaluf.LMS.Core.Services
{
    public interface ICoursesServices
    {
        bool Create(Courses course);
        bool Delete(int id);
        IEnumerable<Courses> GetAll();
        bool Update(Courses course);
    }
}
