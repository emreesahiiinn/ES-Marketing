using ESMarketing.Application.Repositories.Customers;
using ESMarketing.Application.Repositories.Orders;
using ESMarketing.Application.Repositories.Products;
using ESMarketing.Persistence.Configurations;
using ESMarketing.Persistence.Contexts;
using ESMarketing.Persistence.Repositories.Customers;
using ESMarketing.Persistence.Repositories.Orders;
using ESMarketing.Persistence.Repositories.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ESMarketing.Persistence.DependencyRegistration;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<EsMarketingDbContext>(option =>
            option.UseNpgsql(Configuration.ConfigurationString));

        services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
        services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
        services.AddScoped<IOrderReadRepository, OrderReadRepository>();
        services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
        services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        services.AddScoped<IProductReadRepository, ProductReadRepository>();
    }
}