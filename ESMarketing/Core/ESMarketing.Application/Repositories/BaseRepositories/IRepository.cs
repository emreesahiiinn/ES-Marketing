using ESMarketing.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ESMarketing.Application.Repositories.BaseRepositories;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }
}