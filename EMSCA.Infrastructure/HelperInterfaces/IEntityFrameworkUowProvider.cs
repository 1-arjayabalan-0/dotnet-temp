using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMSCA.Infrastructure.HelperInterfaces
{
    public interface IEntityFrameworkUowProvider
    {
        Task<IEntityFrameworkUow> CreateUnitOfWork(bool withTransaction, string TransactionName,bool trackChanges = true, bool enableLogging = false);
    }
}
