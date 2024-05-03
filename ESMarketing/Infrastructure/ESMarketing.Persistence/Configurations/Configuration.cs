using ESMarketing.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ESMarketing.Persistence.Configurations;

static class Configuration
{
    public static string? ConfigurationString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),
                "../../Presentation/ESMarketing.API"));
            configurationManager.AddJsonFile("appsettings.json");

            DbContextOptionsBuilder<EsMarketingDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(configurationManager.GetConnectionString("Psql"));

            return configurationManager.GetConnectionString("Psql");
        }
    }
}