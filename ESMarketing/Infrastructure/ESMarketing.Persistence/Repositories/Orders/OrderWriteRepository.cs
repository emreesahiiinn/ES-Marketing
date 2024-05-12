using ESMarketing.Application.Repositories.Orders;
using ESMarketing.Domain.Entities;
using ESMarketing.Persistence.Contexts;
using ESMarketing.Persistence.Repositories.BaseRepositories;

namespace ESMarketing.Persistence.Repositories.Orders;

public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
{
    public OrderWriteRepository(EsMarketingDbContext context) : base(context)
    {
    }
}