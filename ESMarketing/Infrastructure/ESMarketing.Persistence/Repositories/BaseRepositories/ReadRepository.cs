using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ESMarketing.Domain.Entities.Common;
using ESMarketing.Application.Repositories.BaseRepositories;

namespace ESMarketing.Persistence.Repositories.BaseRepositories;

public class ReadRepository<T>(DbContext context) : IReadRepository<T>
    where T : BaseEntity
{
    public DbSet<T> Table => context.Set<T>();

    public IQueryable<T> GetAll()
        => Table;

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        => Table.Where(method);

    public async Task<T?> GetSingleAsync(Expression<Func<T, bool>> method)
        => await Table.FirstOrDefaultAsync(method);

    public async Task<T?> GetByIdAsync(string id)
        => await Table.FirstOrDefaultAsync(x => x.Id.ToString() == id);
}