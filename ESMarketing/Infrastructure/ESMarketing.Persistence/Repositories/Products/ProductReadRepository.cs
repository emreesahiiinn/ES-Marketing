using ESMarketing.Application.Repositories.Products;
using ESMarketing.Domain.Entities;
using ESMarketing.Persistence.Contexts;
using ESMarketing.Persistence.Repositories.BaseRepositories;
using Microsoft.EntityFrameworkCore;

namespace ESMarketing.Persistence.Repositories.Products;

public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
{
    public ProductReadRepository(EsMarketingDbContext context) : base(context)
    {
    }
}