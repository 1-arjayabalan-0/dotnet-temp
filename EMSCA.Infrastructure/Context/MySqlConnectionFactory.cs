using System.Data;
using EMSCA.Infrastructure.Context;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace EMSCA.Infrastructure.Context
{


    public class MySqlConnectionFactory : IDbConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public MySqlConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            var connectionString = _configuration.GetConnectionString("EMSConn");
            return new MySqlConnection(connectionString);
        }
    }

}