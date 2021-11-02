using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.LMS.Core.Common;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Models;

namespace Tahaluf.LMS.Infra.Repository
{
    public class CourseRepository 
    {

        private readonly IDbContext _dbContext;
        public CourseRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<bool> Create(Course course)
        {
            var p = new DynamicParameters();
            p.Add("@CourseName", course.CourseName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@Price", course.Price, dbType: DbType.Decimal, ParameterDirection.Input);
            p.Add("@StartDate", course.StartDate, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("@EndDate", course.EndDate, dbType: DbType.DateTime, ParameterDirection.Input);
            var result = await _dbContext.Connection.ExecuteAsync("CourseInsert", p, commandType: CommandType.StoredProcedure);
            if (result == 1)
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
            return result.ToList();
        }

        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@CourseId", id, dbType: DbType.DateTime, ParameterDirection.Input);
            var result = _dbContext.Connection.Execute("CourseDelete", p, commandType: CommandType.StoredProcedure);
            if (result == 1)
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
            p.Add("@CourseId", course.CourseName, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@CourseName", course.CourseName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@Price", course.Price, dbType: DbType.Decimal, ParameterDirection.Input);
            p.Add("@StartDate", course.StartDate, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("@EndDate", course.EndDate, dbType: DbType.DateTime, ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("CourseUpdate", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public async Task<Course> GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@CourseId", id, DbType.Int32, ParameterDirection.Input);

            var result = await _dbContext.Connection.QueryFirstOrDefaultAsync<Course>("CourseSelect", p, commandType: CommandType.StoredProcedure);
            var x = result;
            return x;
        }
    }
}
