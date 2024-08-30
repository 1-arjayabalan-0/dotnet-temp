using EMSCA.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EMSCA.Infrastructure.HelperInterfaces
{

    public interface IEntityFrameworkUowBase : IUnitOfWorkBase
    {
        void OnCompleteTransaction(Action<ChangeTracker> func);

    }

}