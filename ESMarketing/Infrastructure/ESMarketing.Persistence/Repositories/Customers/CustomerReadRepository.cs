using ESMarketing.Application.Repositories.Customers;
using ESMarketing.Domain.Entities;
using ESMarketing.Persistence.Repositories.BaseRepositories;
using Microsoft.EntityFrameworkCore;

namespace ESMarketing.Persistence.Repositories.Customers;

public class CustomerReadRepository(DbContext context) : ReadRepository<Customer>(context), ICustomerReadRepository
{
}