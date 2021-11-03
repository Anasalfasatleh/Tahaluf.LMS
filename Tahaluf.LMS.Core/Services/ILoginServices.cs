using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Services
{
    public interface ILoginServices 
    {
        bool Create(Login login);

        bool Update(Login login);

        bool Delete(Login login);

        Login  GetById(Login login);

        IEnumerable<Login> GetAll();
    }
}
