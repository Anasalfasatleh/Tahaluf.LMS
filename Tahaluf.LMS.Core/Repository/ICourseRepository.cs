﻿using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Core.Repository
{
    public interface ICourseRepository : ICRUDRepository<Course>
    {
        Course GetById(Course course);
        IEnumerable<Course> GetCheapestCourse();
        Course GetCourseByEndDate(Course course);
        Course GetCourseByName(Course course);
        Course GetCourseByPrice(Course course);
        Course GetCourseByStartDate(Course course);
        IEnumerable<Course> SearchCouresByName(string name);
    }
}