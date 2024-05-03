using ESMarketing.Domain.Entities;
using ESMarketing.Application.Repositories.BaseRepositories;

namespace ESMarketing.Application.Repositories.Orders;

public interface IOrderWriteRepository : IWriteRepository<Order>
{
}