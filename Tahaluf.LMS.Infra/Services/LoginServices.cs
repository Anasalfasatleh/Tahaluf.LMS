using System.Collections.Generic;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Core.Services;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Infra.Services
{
    public class LoginServices : ILoginServices
    {

        private readonly ILoginRepository _courseRepository;

        public LoginServices(ILoginRepository loginRepository)
        {
            this._courseRepository = loginRepository;
        }

        public bool Create(Login login)
        {
            return _courseRepository.Create(login);
        }

        public bool Delete(Login login)
        {
            return _courseRepository.Delete(login);

        }

        public IEnumerable<Login> GetAll()
        {
            return _courseRepository.GetAll();

        }

        public Login GetById(Login login)
        {
            return _courseRepository.GetById(login);

        }

        public bool Update(Login login)
        {
            return _courseRepository.Update(login);

        }
    }
}
