using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EMSCA.Application.Repository;
using EMSCA.Infrastructure.Repositories;
using EMSCA.Infrastructure.CommonEntities;
using Microsoft.Extensions.DependencyInjection.Extensions;
using EMSCA.Infrastructure.UnitOfWork;
using EMSCA.Infrastructure.Data;
using EMSCA.Domain.Interfaces;

namespace EMSCA.WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDataAccess<TEntityContext> (this IServiceCollection services) where TEntityContext : EntityContextBase<TEntityContext>
        {
            RegisterDataAccess<TEntityContext>(services);
            return services;
        }

        private static void RegisterDataAccess<TEntityContext>(IServiceCollection services) where TEntityContext : EntityContextBase<TEntityContext>
        {
            services.TryAddScoped<IUowProvider, UowProvider>();
            services.TryAddTransient<IEntityContext, TEntityContext>();
            services.TryAddTransient(typeof(IRepository<>), typeof(GenericEntityRepository<>));

        }
        
        // public static void ConfigureInfrastructure(this IServiceCollection services, IConfiguration configuration)
        // {
        //     var connection = configuration.GetConnectionString("EMSConn");
        //     services.AddDbContext<DbContextHelper>(options => options.UseMySQL(connection));
        //     services.AddScoped<IUnitOfWork, UnitOfWork>();
        //     // services.AddScoped<ITestTakerRepository, TestTakerRepository>();
        // }
    }
}
