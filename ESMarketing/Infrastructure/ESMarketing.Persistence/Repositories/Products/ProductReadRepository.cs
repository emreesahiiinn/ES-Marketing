using ESMarketing.Application.Repositories.Products;
using ESMarketing.Domain.Entities;
using ESMarketing.Persistence.Repositories.BaseRepositories;
using Microsoft.EntityFrameworkCore;

namespace ESMarketing.Persistence.Repositories.Products;

public class ProductReadRepository(DbContext context) : ReadRepository<Product>(context), IProductReadRepository
{
}