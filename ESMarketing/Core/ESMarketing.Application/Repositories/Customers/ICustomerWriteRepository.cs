using ESMarketing.Domain.Entities;
using ESMarketing.Application.Repositories.BaseRepositories;

namespace ESMarketing.Application.Repositories.Customers;

public interface ICustomerWriteRepository : IWriteRepository<Customer>
{
}