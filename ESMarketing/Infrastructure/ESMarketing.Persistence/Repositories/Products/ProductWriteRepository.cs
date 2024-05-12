using ESMarketing.Application.Repositories.Products;
using ESMarketing.Domain.Entities;
using ESMarketing.Persistence.Contexts;
using ESMarketing.Persistence.Repositories.BaseRepositories;

namespace ESMarketing.Persistence.Repositories.Products;

public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
{
    public ProductWriteRepository(EsMarketingDbContext context) : base(context)
    {
    }
}