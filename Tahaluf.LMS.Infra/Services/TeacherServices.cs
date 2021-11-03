using System.Collections.Generic;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Core.Services;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Infra.Services
{
    public class TeacherServices : ITeacherServices
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherServices(ITeacherRepository teacherRepository)
        {
            this._teacherRepository = teacherRepository;
        }
        public bool Create(Teacher teacher)
        {
            return _teacherRepository.Create(teacher);
        }

        public bool Delete(Teacher teacher)
        {
            return _teacherRepository.Delete(teacher);

        }

        public IEnumerable<Teacher> GetAll()
        {
            return _teacherRepository.GetAll();

        }

        public Teacher GetByEmail(Teacher teacher)
        {
            return _teacherRepository.GetByEmail(teacher);

        }

        public Teacher GetById(Teacher teacher)
        {
            return _teacherRepository.GetById(teacher);

        }

        public bool Update(Teacher teacher)
        {
            return _teacherRepository.Update(teacher);

        }
    }
}
