using ESMarketing.Application.Repositories.Customers;
using ESMarketing.Domain.Entities;
using ESMarketing.Persistence.Contexts;
using ESMarketing.Persistence.Repositories.BaseRepositories;
using Microsoft.EntityFrameworkCore;

namespace ESMarketing.Persistence.Repositories.Customers;

public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
{
    public CustomerWriteRepository(EsMarketingDbContext context) : base(context)
    {
    }
}