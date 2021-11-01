using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.LMS.Core.Common;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Models;

namespace Tahaluf.LMS.Infra.Repository
{
    public class CourseRepository : ICourseRepository
    {

        private readonly IDbContext _dbContext;
        public CourseRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       
        public bool CreateCourse(Course course)
        {
            var p = new DynamicParameters();
            p.Add("@CourseName", course.CourseName,dbType:DbType.String,ParameterDirection.Input);
            p.Add("@Price", course.Price, dbType: DbType.Decimal, ParameterDirection.Input);
            p.Add("@StartDate", course.StartDate, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("@EndDate", course.EndDate, dbType: DbType.DateTime, ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("CourseInsert",p,commandType:CommandType.StoredProcedure);
            return true;
        }

        public List<Course> GetAllCourses()
        {
            var result = _dbContext.Connection.Query<Course>("GetAllCourse", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool DeleteCourse(int id)
        {
            var p = new DynamicParameters();
            p.Add("@CourseId", id, dbType: DbType.DateTime, ParameterDirection.Input);
            return true; 
        }

        public bool UpdateCourse(Course course)
        {
            var p = new DynamicParameters();
            p.Add("@CourseId", course.CourseName, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@CourseName", course.CourseName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@Price", course.Price, dbType: DbType.Decimal, ParameterDirection.Input);
            p.Add("@StartDate", course.StartDate, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("@EndDate", course.EndDate, dbType: DbType.DateTime, ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("CourseUpdate", p, commandType: CommandType.StoredProcedure);
            return true;
        }

    }
}
