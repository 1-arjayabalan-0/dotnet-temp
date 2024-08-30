using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace EMSCA.Infrastructure.Context
{

    public class SqlServerConnectionFactory : IDbConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public SqlServerConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            var connectionString = _configuration.GetConnectionString("EMSConn");
            return new SqlConnection(connectionString);
        }
    }

}