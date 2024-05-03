using ESMarketing.Domain.Entities.Common;

namespace ESMarketing.Domain.Entities;
public class Customer : BaseEntity
{
    public ICollection<Order> Orders { get; set; }
}