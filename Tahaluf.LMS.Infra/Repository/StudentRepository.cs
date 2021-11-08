using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using Tahaluf.LMS.Core.Common;
using Tahaluf.LMS.Core.DTO;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Infra.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IDbContext _dbContext;

        public StudentRepository(IDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public bool Create(Student student)
        {
            var p = new DynamicParameters();
            p.Add("@Fname", student.Fname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@Lname", student.Lname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@BirthDate", student.BirthDate, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("@Mark", student.Mark, dbType: DbType.Double, ParameterDirection.Input);

            try
            {
                var result = _dbContext.Connection.Execute("StudentInsert", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@StudentId", id, dbType: DbType.Int32, ParameterDirection.Input);
            try
            {
                var result = _dbContext.Connection.Execute("StudentDelete", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<Student> GetAll()
        {
            var result = _dbContext.Connection.Query<Student>("GetAllStudents", commandType: CommandType.StoredProcedure);
            return result;
        }

        public Student GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@StudentId", id, DbType.Int32, ParameterDirection.Input);
            var result = _dbContext.Connection.QueryFirstOrDefault<Student>("StudentSelect", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public bool Update(Student student)
        {
            var p = new DynamicParameters();
            p.Add("@StudentId", student.StudentId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@Fname", student.Fname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@Lname", student.Lname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@BirthDate", student.BirthDate, dbType: DbType.DateTime, ParameterDirection.Input);
            p.Add("@Mark", student.Mark, dbType: DbType.Double, ParameterDirection.Input);

            try
            {
                var result = _dbContext.Connection.Execute("StudentUpdate", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public MarkDetailsResponseDTO GetMarkDetails()
        {
            var result = _dbContext.Connection.QuerySingle<MarkDetailsResponseDTO>("MarksDetails", commandType: CommandType.StoredProcedure);
            return result; 
        }
    }
}
