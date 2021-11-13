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
    public class TeacherRepository : ITeacherRepository
    {
        private readonly IDbContext _dbContext;
        public TeacherRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool Create(CreateTeacherDTO teacher)
        {
            var p = new DynamicParameters();
            p.Add("@UserName", teacher.UserName, DbType.String, ParameterDirection.Input);
            p.Add("@Password", teacher.Password, DbType.String, ParameterDirection.Input);
            p.Add("@RoleName", teacher.RoleName, DbType.String, ParameterDirection.Input);
            p.Add("@TeacherName", teacher.TeacherName, DbType.String, ParameterDirection.Input);
            p.Add("@Email", teacher.Email, DbType.String, ParameterDirection.Input);
            p.Add("@Salary", teacher.Salary, DbType.Double, ParameterDirection.Input);
            p.Add("@PhoneNumber", teacher.PhoneNumber, DbType.String, ParameterDirection.Input);

            try
            {
                var result = _dbContext.Connection.ExecuteAsync("CreateTeacher", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public bool Update(Teacher teacher)
        {
            var p = new DynamicParameters();
            p.Add("@TeacherId", teacher.TeacherId, DbType.Int32, ParameterDirection.Input);
            p.Add("@TeacherName", teacher.TeacherName, DbType.String, ParameterDirection.Input);
            p.Add("@Email", teacher.Email, DbType.String, ParameterDirection.Input);
            p.Add("@Salary", teacher.Salary, DbType.Double, ParameterDirection.Input);
            p.Add("@LoginId", teacher.LoginId, DbType.Int32, ParameterDirection.Input);

            try
            {
                var result = _dbContext.Connection.ExecuteAsync("TeacherUpdate", p, commandType: CommandType.StoredProcedure);
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
            p.Add("@TeacherId", id, dbType: DbType.Int32, ParameterDirection.Input);
            try
            {
                var result = _dbContext.Connection.ExecuteAsync("TeacherDelete", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Teacher GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@TeacherId", id, DbType.Int32, ParameterDirection.Input);
            var result = _dbContext.Connection.QueryFirstOrDefault<Teacher>("TeacherSelect", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<Teacher> GetAll()
        {
            var result = _dbContext.Connection.Query<Teacher>("GetAllTeachers", commandType: CommandType.StoredProcedure);
            return result;
        }

        public Teacher GetByEmail(Teacher teacher)
        {
            var p = new DynamicParameters();
            p.Add("@TeacherEmail", teacher.Email, DbType.String, ParameterDirection.Input);
            var result = _dbContext.Connection.QueryFirstOrDefault<Teacher>("GetTeacherByEmail", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public bool Create(Teacher t)
        {
            throw new NotImplementedException();
        }
    }
}
