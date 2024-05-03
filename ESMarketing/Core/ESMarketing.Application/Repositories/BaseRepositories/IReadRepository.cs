using System.Linq.Expressions;
using ESMarketing.Domain.Entities.Common;

namespace ESMarketing.Application.Repositories.BaseRepositories;

public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll();
    IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
    Task<T?> GetSingleAsync(Expression<Func<T, bool>> method);
    Task<T?> GetByIdAsync(string id);
}