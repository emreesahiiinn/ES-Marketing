using ESMarketing.Application.Abstractions;
using ESMarketing.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace ESMarketing.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}