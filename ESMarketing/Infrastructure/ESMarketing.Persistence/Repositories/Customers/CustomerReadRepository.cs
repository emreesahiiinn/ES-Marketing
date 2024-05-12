using ESMarketing.Application.Repositories.Customers;
using ESMarketing.Domain.Entities;
using ESMarketing.Persistence.Contexts;
using ESMarketing.Persistence.Repositories.BaseRepositories;

namespace ESMarketing.Persistence.Repositories.Customers;

public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(EsMarketingDbContext context) : base(context)
    {
    }
}