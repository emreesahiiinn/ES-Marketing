using ESMarketing.Application.Repositories.Orders;
using ESMarketing.Domain.Entities;
using ESMarketing.Persistence.Repositories.BaseRepositories;
using Microsoft.EntityFrameworkCore;

namespace ESMarketing.Persistence.Repositories.Orders;

public class OrderWriteRepository(DbContext context) : WriteRepository<Order>(context), IOrderWriteRepository
{
}