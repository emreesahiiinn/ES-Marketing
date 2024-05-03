using ESMarketing.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ESMarketing.Persistence.Contexts;

public class EsMarketingDbContext : DbContext
{
    public EsMarketingDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
}