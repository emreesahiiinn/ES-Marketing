using ESMarketing.Domain.Entities.Common;

namespace ESMarketing.Application.Repositories.BaseRepositories;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T model);
    Task<bool> AddRangeAsync(List<T> models);
    bool Update(T model);
    bool RemoveRange(List<T> models);
    bool Remove(T model);
    Task<bool> RemoveAsync(string id);
    Task<int> SaveAsync(T model);
}