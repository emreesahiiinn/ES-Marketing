using System.Collections.ObjectModel;
using ESMarketing.Domain.Entities.Common;

namespace ESMarketing.Domain.Entities;

public class Order : BaseEntity
{
    public Guid CustomerId { get; set; }
    public string Decription { get; set; }
    public string Address { get; set; }
    public Collection<Product> Products { get; set; }
    public Customer Customer { get; set; }
}