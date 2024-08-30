using EMSCA.Application.Repository;
using EMSCA.Domain.Interfaces;
using EMSCA.Infrastructure.HelperInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSCA.Infrastructure.UnitOfWork
{
    public class UnitOfWork : UnitOfWorkBase<DbContext>, IEntityFrameworkUow
    {

        public UnitOfWork(DbContext context, IServiceProvider serviceProvider) : base(context, serviceProvider) 
        {
            
        }
       
    }
}
