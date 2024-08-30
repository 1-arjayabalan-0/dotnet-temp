using EMSCA.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EMSCA.Infrastructure.HelperInterfaces
{

    public interface IEntityFrameworkUow : IUnitOfWork
    {
        DbContext GetContext<TRepository>();

        void OnCompleteTransaction(Action<ChangeTracker> func);
    }

}