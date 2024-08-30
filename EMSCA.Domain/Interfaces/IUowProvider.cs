using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMSCA.Domain.Interfaces
{
    public interface IUowProvider
    {
        IUnitOfWork CreateUnitOfWork(bool trackChanges = true, bool enableLogging = false);
        Task<IUnitOfWork> CreateUnitOfWork(bool withTransaction, string TransactionName,bool trackChanges = true, bool enableLogging = false);
        Task CommitTransaction(string transactionName);
    }
}
