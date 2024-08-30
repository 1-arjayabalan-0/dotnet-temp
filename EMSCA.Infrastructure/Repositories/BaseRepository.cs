using Microsoft.EntityFrameworkCore;
using EMSCA.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMSCA.Infrastructure.HelperInterfaces;

namespace EMSCA.Infrastructure.Repositories
{
    public abstract class BaseRepository<TContext> : IRepositoryInjection where TContext : DbContext
    {
        protected TContext Context { get; private set; }

        public BaseRepository(TContext context)
        {
            this.Context = context;
        }

        public IRepositoryInjection SetContext(DbContext context)
        {
            this.Context = (TContext)context;
            return this;
        }

        // public void Create(T entity)
        // {
        //     Context.Add(entity);
        // }

        // public void Update(T entity)
        // {
        //     Context.Update(entity);
        // }

        // public void Delete(T entity)
        // {
        //     entity.DateCreated = DateTimeOffset.UtcNow;
        //     Context.Update(entity);
        // }

        // public Task<T> Get(Guid id, CancellationToken cancellationToken)
        // {
        //     return Context.Set<T>().FirstOrDefaultAsync(x => x.ID == id, cancellationToken);
        // }

        // public Task<List<T>> GetAll(CancellationToken cancellationToken)
        // {
        //     return Context.Set<T>().ToListAsync(cancellationToken);
        // }
    }
}
