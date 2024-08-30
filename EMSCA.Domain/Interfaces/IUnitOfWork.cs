

namespace EMSCA.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        IRepository<TEntity> GetRepository<TEntity>();
        TRepository GetCustomRepository<TRepository>();

        bool IsContextBeginTransaction();
    }
}
