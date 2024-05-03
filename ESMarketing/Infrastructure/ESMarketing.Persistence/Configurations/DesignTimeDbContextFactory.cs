using ESMarketing.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ESMarketing.Persistence.Configurations;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EsMarketingDbContext>
{
    public EsMarketingDbContext CreateDbContext(string[] args)
    {
        
        DbContextOptionsBuilder<EsMarketingDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseNpgsql(Configuration.ConfigurationString);
        return new EsMarketingDbContext(dbContextOptionsBuilder.Options);
    }
}