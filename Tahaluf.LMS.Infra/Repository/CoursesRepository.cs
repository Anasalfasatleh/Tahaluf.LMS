using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Tahaluf.LMS.Core.Common;
using Tahaluf.LMS.Core.Data;
using Tahaluf.LMS.Core.DTO;
using Tahaluf.LMS.Core.Repository;

namespace Tahaluf.LMS.Infra.Repository
{
    public class CoursesRepository : ICoursesRepository
    {
        private readonly IDbContext _dbContext;

        public CoursesRepository(IDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public bool Create(Courses courseModel)
        {
            var p = new DynamicParameters();
            p.Add("@OpertionType", "Create", dbType: DbType.String, ParameterDirection.Input);
            p.Add("@id", courseModel.Id, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@CourseName", courseModel.CourseName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@Price", courseModel.Price, dbType: DbType.Decimal, ParameterDirection.Input);


            var result = _dbContext.Connection.ExecuteAsync("CourseCRUD", p, commandType: CommandType.StoredProcedure);
            return true;

        }
        public bool Update(Courses courseModel)
        {
            var p = new DynamicParameters();

            p.Add("@OpertionType", "Update", dbType: DbType.String, ParameterDirection.Input);
            p.Add("@id", courseModel.Id, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@CourseName", courseModel.CourseName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@Price", courseModel.Price, dbType: DbType.Decimal, ParameterDirection.Input);


            var result = _dbContext.Connection.ExecuteAsync("CourseCRUD", p, commandType: CommandType.StoredProcedure);
            return true;

        }
        public IEnumerable<Courses> GetAll()
        {
            var p = new DynamicParameters();
            p.Add("@OpertionType", "GetAll", dbType: DbType.String, ParameterDirection.Input);

            var result = _dbContext.Connection.Query<Courses>("CourseCRUD", p, commandType: CommandType.StoredProcedure);
            return result;

        }
        public bool Delete(int id)
        {
            var p = new DynamicParameters();

            p.Add("@OpertionType", "Delete", dbType: DbType.String, ParameterDirection.Input);
            p.Add("@id", id, dbType: DbType.Int32, ParameterDirection.Input);

            var result = _dbContext.Connection.ExecuteAsync("CourseCRUD", p, commandType: CommandType.StoredProcedure);
            return true;

        }
    }
}
