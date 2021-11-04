using Dapper;
using System.Collections.Generic;
using System.Data;
using Tahaluf.LMS.Core.Common;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Infra.Repository
{
    public class CourseRepository : ICourseRepository
    {

        private readonly IDbContext _dbContext;
        public CourseRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool Create(Course course)
        {
            var p = new DynamicParameters();
            p.Add("@CourseName", course.CourseName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@Price", course.Price, dbType: DbType.Decimal, ParameterDirection.Input);
            p.Add("@StartDate", course.StartDate, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("@EndDate", course.EndDate, dbType: DbType.DateTime, ParameterDirection.Input);
            var result = _dbContext.Connection.Execute("CourseInsert", p, commandType: CommandType.StoredProcedure);
            if (result == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Course> GetAll()
        {
            var result = _dbContext.Connection.Query<Course>("GetAllCourse", commandType: CommandType.StoredProcedure);
            return result;
        }

        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@CourseId", id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = _dbContext.Connection.Execute("CourseDelete", p, commandType: CommandType.StoredProcedure);
            if (result == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(Course course)
        {
            var p = new DynamicParameters();
            p.Add("@CourseId", course.CourseId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@CourseName", course.CourseName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@Price", course.Price, dbType: DbType.Decimal, ParameterDirection.Input);
            p.Add("@StartDate", course.StartDate, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("@EndDate", course.EndDate, dbType: DbType.DateTime, ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("CourseUpdate", p, commandType: CommandType.StoredProcedure);
            if (result.Result == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Course GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@CourseId", id, DbType.Int32, ParameterDirection.Input);
            var result = _dbContext.Connection.QueryFirstOrDefault<Course>("CourseSelect", p, commandType: CommandType.StoredProcedure);
            return result;
        }


        public Course GetCourseByName(Course course)
        {
            var p = new DynamicParameters();
            p.Add("@CourseName", course.CourseName, dbType: DbType.String, ParameterDirection.Input);
            var result = _dbContext.Connection.QueryFirstOrDefault<Course>("GetByCourseName", p, commandType: CommandType.StoredProcedure);
            return result;
        }


        public IEnumerable<Course> GetCourseByPrice(Course course)
        {
            var p = new DynamicParameters();
            p.Add("@Price", course.Price, dbType: DbType.Double, ParameterDirection.Input);
            var result = _dbContext.Connection.Query<Course>("GetByCoursePrice", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<Course> GetCheapestCourse()
        {
            var result = _dbContext.Connection.Query<Course>("GetCheapestCourse", commandType: CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<Course> GetCourseByStartDate(Course course)
        {
            var p = new DynamicParameters();
            p.Add("@StartDate", course.StartDate, dbType: DbType.Date, ParameterDirection.Input);
            var result = _dbContext.Connection.Query<Course>("GetByCourseStartDate", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<Course> GetCourseByEndDate(Course course)
        {
            var p = new DynamicParameters();
            p.Add("@EndDate", course.EndDate, dbType: DbType.Date, ParameterDirection.Input);
            var result = _dbContext.Connection.Query<Course>("GetByCourseEndDate", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<Course> SearchCouresByName (Course course)
        {
            var p = new DynamicParameters();
            p.Add("@Name", course.CourseName, dbType: DbType.String, ParameterDirection.Input);
            var result = _dbContext.Connection.Query<Course>("SearchCouresByName", p, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
