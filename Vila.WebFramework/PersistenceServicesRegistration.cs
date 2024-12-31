using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vila.Data.Context;
using Vila.Data.Contracts;
using Vila.Data.Repositories;

namespace Vila.WebFramework
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceService(this IServiceCollection service, IConfiguration configuration)
        {
            #region Context

            service.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"));
            });

            #endregion

            #region Dependency

            service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            #endregion

            return service;

        }
    }
}
