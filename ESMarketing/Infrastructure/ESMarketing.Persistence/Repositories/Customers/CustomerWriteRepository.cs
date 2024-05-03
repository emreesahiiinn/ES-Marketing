using ESMarketing.Application.Repositories.Customers;
using ESMarketing.Domain.Entities;
using ESMarketing.Persistence.Repositories.BaseRepositories;
using Microsoft.EntityFrameworkCore;

namespace ESMarketing.Persistence.Repositories.Customers;

public class CustomerWriteRepository(DbContext context) : WriteRepository<Customer>(context), ICustomerWriteRepository
{
}