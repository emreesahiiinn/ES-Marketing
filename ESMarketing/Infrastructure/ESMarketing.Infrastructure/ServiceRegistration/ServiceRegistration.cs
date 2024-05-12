using ESMarketing.Application.Abstractions.Storage;
using ESMarketing.Infrastructure.Concretes.Storage;
using ESMarketing.Infrastructure.Concretes.Storage.Local;
using ESMarketing.Infrastructure.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace ESMarketing.Infrastructure.ServiceRegistration;

public static class ServiceRegistration
{
    public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IStorageService, StorageService>();
    }

    public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : Storage, IStorage
    {
        serviceCollection.AddScoped<IStorage, T>();
    }

    public static void AddStorage(this IServiceCollection serviceCollection, StorageType storageType)
    {
        switch (storageType)
        {
            case StorageType.Local:
                serviceCollection.AddScoped<IStorage, LocalStorage>();
                break;
            case StorageType.Azure:
                serviceCollection.AddScoped<IStorage, LocalStorage>();

                break;
            default:
                serviceCollection.AddScoped<IStorage, LocalStorage>();
                break;
        }
    }
}