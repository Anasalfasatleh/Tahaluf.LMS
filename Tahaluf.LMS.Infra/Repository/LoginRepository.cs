using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Tahaluf.LMS.Core.Common;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Infra.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly IDbContext _dbContext;
        public LoginRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Create(Login login)
        {
            var p = new DynamicParameters();
            p.Add("@UserName", login.UserName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@Password", login.Password, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@RoleName", login.RoleName, dbType: DbType.String, ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("LoginInsert", p, commandType: CommandType.StoredProcedure);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Delete(Login login)
        {
            var p = new DynamicParameters();
            p.Add("@LoginId", login.LoginId, dbType: DbType.Int32, ParameterDirection.Input);
            var result = _dbContext.Connection.Execute("LoginDelete", p, commandType: CommandType.StoredProcedure);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Login> GetAll()
        {
            var result = _dbContext.Connection.Query<Login>("GetAllLogins", commandType: CommandType.StoredProcedure);
            return result;
        }

        public Login GetById(Login login)
        {
            var p = new DynamicParameters();
            p.Add("@LoginId", login.LoginId, DbType.Int32, ParameterDirection.Input);
            var result = _dbContext.Connection.QueryFirstOrDefault<Login>("LoginSelect", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public bool Update(Login login)
        {
            var p = new DynamicParameters();
            p.Add("@LoginId", login.LoginId, dbType: DbType.Int32, ParameterDirection.Input);
            p.Add("@UserName", login.UserName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@Password", login.Password, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@RoleName", login.RoleName, dbType: DbType.String, ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("LoginUpdate", p, commandType: CommandType.StoredProcedure);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
