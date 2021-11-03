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

        public bool Delete(Course course)
        {
            return _courseRepository.Delete(course); 
        }

        public IEnumerable<Course> GetAll()
        {
            return _courseRepository.GetAll();
        }

        public Course GetById(Course course)
        {
            return _courseRepository.GetById(course);
        }

        public IEnumerable<Course> GetCheapestCourse()
        {
            return _courseRepository.GetCheapestCourse();
        }

        public Course GetCourseByEndDate(Course course)
        {
            return _courseRepository.GetCourseByEndDate(course);
        }

        public Course GetCourseByName(Course course)
        {
            return _courseRepository.GetCourseByName(course);
        }

        public Course GetCourseByPrice(Course course)
        {
            return _courseRepository.GetCourseByPrice(course);
        }

        public Course GetCourseByStartDate(Course course)
        {
            return _courseRepository.GetCourseByStartDate(course);
        }

        public IEnumerable<Course> SearchCouresByName(string name)
        {
            return _courseRepository.SearchCouresByName(name);

        }

        public bool Update(Course course)
        {
            return _courseRepository.Update(course);
        }
    }
}
