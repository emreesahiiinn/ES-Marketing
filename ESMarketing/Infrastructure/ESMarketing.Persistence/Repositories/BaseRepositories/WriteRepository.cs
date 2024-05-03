using Microsoft.EntityFrameworkCore;
using ESMarketing.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ESMarketing.Application.Repositories.BaseRepositories;

namespace ESMarketing.Persistence.Repositories.BaseRepositories;

public class WriteRepository<T>(DbContext context) : IWriteRepository<T> where T : BaseEntity
{
    public DbSet<T> Table => context.Set<T>();

    public async Task<bool> AddAsync(T model)
    {
        EntityEntry<T> entityEntry = await Table.AddAsync(model);

        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(List<T> models)
    {
        await Table.AddRangeAsync(models);
        return true;
    }

    public bool Update(T model)
    {
        EntityEntry entityEntry = Table.Update(model);
        return entityEntry.State == EntityState.Modified;
    }

    public bool RemoveRange(List<T> models)
    {
        Table.AddRange(models);
        return true;
    }

    public bool Remove(T model)
    {
        EntityEntry<T> entityEntry = Table.Remove(model);

        return entityEntry.State == EntityState.Deleted;
    }

    public async Task<bool> RemoveAsync(string id)
    {
        T model = (await Table.FirstOrDefaultAsync(x => x.Id.ToString() == id))!;
        return Remove(model);
    }

    public Task<int> SaveAsync(T model)
        => context.SaveChangesAsync();
}