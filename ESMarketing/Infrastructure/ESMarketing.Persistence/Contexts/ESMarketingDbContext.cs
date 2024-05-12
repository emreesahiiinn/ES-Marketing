using ESMarketing.Domain.Entities;
using ESMarketing.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace ESMarketing.Persistence.Contexts;

public class EsMarketingDbContext : DbContext
{
    public EsMarketingDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var data = ChangeTracker.Entries<BaseEntity>();

        foreach (var entry in data)
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdatedDate = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}