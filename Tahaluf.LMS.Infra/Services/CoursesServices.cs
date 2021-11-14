using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Core.Data;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Core.Services;

namespace Tahaluf.LMS.Infra.Services
{
    public class CoursesServices : ICoursesServices
    {
        private readonly ICoursesRepository _coursesRepository;

        public CoursesServices(ICoursesRepository coursesRepository)
        {
            this._coursesRepository = coursesRepository;
        }

        public bool Create(Courses course)
        {
            return _coursesRepository.Create(course);
        }

        public bool Delete(int id)
        {
            return _coursesRepository.Delete(id);
        }

        public IEnumerable<Courses> GetAll()
        {
            return _coursesRepository.GetAll();
        }

        public bool Update(Courses course)
        {
            return _coursesRepository.Update(course);
        }

    }
}
