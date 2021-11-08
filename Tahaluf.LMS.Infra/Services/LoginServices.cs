using System.Collections.Generic;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Core.Services;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Infra.Services
{
    public class LoginServices : ILoginServices
    {

        private readonly ILoginRepository _loginRepository;

        public LoginServices(ILoginRepository loginRepository)
        {
            this._loginRepository = loginRepository;
        }

        public bool Create(Login login)
        {
            return _loginRepository.Create(login);
        }

        public bool Delete(int id)
        {
            return _loginRepository.Delete( id);

        }

        public IEnumerable<Login> GetAll()
        {
            return _loginRepository.GetAll();

        }

        public Login GetById(int id)
        {
            return _loginRepository.GetById( id);

        }

        public bool Update(Login login)
        {
            return _loginRepository.Update(login);

        }
    }
}
