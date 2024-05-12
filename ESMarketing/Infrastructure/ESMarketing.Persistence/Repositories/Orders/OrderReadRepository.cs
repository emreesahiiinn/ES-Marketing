using ESMarketing.Application.Repositories.Orders;
using ESMarketing.Domain.Entities;
using ESMarketing.Persistence.Contexts;
using ESMarketing.Persistence.Repositories.BaseRepositories;
using Microsoft.EntityFrameworkCore;

namespace ESMarketing.Persistence.Repositories.Orders;

public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
{
    public OrderReadRepository(EsMarketingDbContext context) : base(context)
    {
    }
}