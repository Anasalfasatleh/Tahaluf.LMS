using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;
using Tahaluf.LMS.Core.Common;

namespace Tahaluf.LMS.Infra.Common
{
    public class DbContext : IDbContext
    {
        private DbConnection _connection;
        private readonly IConfiguration _configuration;

        public DbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(@"Data Source=MuradAwad;Initial Catalog=LMS;Integrated Security=True;Trusted_Connection=True;");
                    _connection.Open(); 
                }
                else if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }

        

    }
}