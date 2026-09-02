using api_ecommercer_ped.domain.Interfaces;
using api_ecommercer_ped.persistence.Context;
using api_ecommercer_ped.persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.persistence
{
    public static class ServicesExtension
    {

        public static void ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            //var ConnectionString = configuration.GetConnectionString("Sqlite");
            //services.AddDbContext<AppDbContext>(options =>
            //{
            //    options.UseSqlite(ConnectionString);
            //});
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
