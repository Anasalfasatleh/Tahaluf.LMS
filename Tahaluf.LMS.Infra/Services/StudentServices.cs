using System.Collections.Generic;
using Tahaluf.LMS.Core.DTO;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Core.Services;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Infra.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepository _studentRepository;

        public StudentServices(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }

        public bool Create(Student student)
        {
            return _studentRepository.Create(student);
        }

        public bool Delete(int id)
        {
            return _studentRepository.Delete(id);

        }

        public IEnumerable<Student> GetAll()
        {
            return _studentRepository.GetAll();

        }

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);

        }

        public bool Update(Student student)
        {
            return _studentRepository.Update(student);

        }
        public MarkDetailsResponseDTO GetMarkDetails()
        {
            return _studentRepository.GetMarkDetails();

        }

    }
}
