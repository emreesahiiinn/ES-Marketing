using ESMarketing.Domain.Entities;

namespace ESMarketing.Application.Abstractions;

public interface IProductService
{
    List<Product> GetProducts();
}