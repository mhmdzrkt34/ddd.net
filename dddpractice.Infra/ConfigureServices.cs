using dddpractice.Domain.Repository;
using dddpractice.Infra.data;
using dddpractice.Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddpractice.Infra
{
    public static class ConfigureServices
    {

        public static IServiceCollection AddInfrastructureServices
             (this IServiceCollection services, IConfiguration configuration)
        {


            services.AddDbContext<AppDbContext>(options =>
            {

               options.UseSqlServer(configuration.GetSection("ConnectionStrings:DefaultConnection").Value);
            });
        
            services.AddTransient<ICarRepository, CarRepository>();

            return services;


        }


    }
}
