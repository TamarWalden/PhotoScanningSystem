using Microsoft.Extensions.DependencyInjection;
using Repository;
using Service.Interfaces;
using Service.Services;

namespace Service
{
    public static class ServiceCollectionExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<ICollectionService, CollectionService>();
           // services.AddSingleton<IContext, AssignmentsContext>();
           // services.AddAutoMapper(typeof(Mapper));
        }
    }
}
