using Microsoft.Extensions.DependencyInjection;
using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public static class ServiceCollectionExtension
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICollectionRepository, CollectionRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
        }
    }
}
