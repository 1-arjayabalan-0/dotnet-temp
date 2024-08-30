using System.Data;
namespace EMSCA.Infrastructure.Context
{

    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }

}