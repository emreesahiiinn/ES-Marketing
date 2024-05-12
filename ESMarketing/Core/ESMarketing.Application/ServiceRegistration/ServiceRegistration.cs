using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ESMarketing.Application.ServiceRegistration;

public static class ServiceRegistration
{
    public static void AddApplicationServices(this IServiceCollection collection)
    {
        collection.AddMediatR(typeof(ServiceRegistration));
        collection.AddHttpClient();
    }
}