using System;
using System.Collections.Generic;
using System.Text;

using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Core.Services;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Infra.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            this._courseRepository = courseRepository;
        }

        public bool Create(Course course)
        {
            return _courseRepository.Create(course);
        }

        public bool Delete(int id)
        {
            return _courseRepository.Delete(id); 
        }

        public IEnumerable<Course> GetAll()
        {
            return _courseRepository.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseRepository.GetById(id);
        }

        public IEnumerable<Course> GetCheapestCourse()
        {
            return _courseRepository.GetCheapestCourse();
        }

        public IEnumerable<Course> GetCourseByEndDate(Course course)
        {
            return _courseRepository.GetCourseByEndDate(course);
        }

        public Course GetCourseByName(Course course)
        {
            return _courseRepository.GetCourseByName(course);
        }

        public IEnumerable<Course> GetCourseByPrice(Course course)
        {
            return _courseRepository.GetCourseByPrice(course);
        }

        public IEnumerable<Course> GetCourseByStartDate(Course course)
        {
            return _courseRepository.GetCourseByStartDate(course);
        }

        public IEnumerable<Course> SearchCouresByName(Course course)
        {
            return _courseRepository.SearchCouresByName( course);

        }

        public bool Update(Course course)
        {
            return _courseRepository.Update(course);
        }
    }
}
