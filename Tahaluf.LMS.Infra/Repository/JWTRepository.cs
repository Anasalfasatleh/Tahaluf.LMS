using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Tahaluf.LMS.Core.Common;
using Tahaluf.LMS.Core.DTO;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Data;

namespace Tahaluf.LMS.Infra.Repository
{
    public class JWTRepository : IJWTRepository
    {
        private readonly IDbContext _dbContext;

        public JWTRepository(IDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public ResponseLoginDTO Authentication(RequestLoginDTO login)
        {
            var p = new DynamicParameters();
            p.Add("@UserName", login.UserName, dbType: DbType.String, ParameterDirection.Input);
            p.Add("@Password", login.Password, dbType: DbType.String, ParameterDirection.Input);
           
                var result = _dbContext.Connection.QueryFirstOrDefault<ResponseLoginDTO>("AuthLogin", p,commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
