using System.Linq.Expressions;
using ESMarketing.Domain.Entities.Common;

namespace ESMarketing.Application.Repositories.BaseRepositories;

public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll(bool tracking = true);
    IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
    Task<T?> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
    Task<T?> GetByIdAsync(string id, bool tracking = true);
}