using ESMarketing.Application.Repositories.Products;
using MediatR;

namespace ESMarketing.Application.Features.Queries.GetAllProducts;

public class GetAllProductQueryHandler(IProductReadRepository productReadRepository)
    : IRequestHandler<GetAllProductQueryRequest, GetAllProductQueryResponse>
{
    public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request,
        CancellationToken cancellationToken)
    {
        var totalCount = productReadRepository.GetAll(false).Count();
        var product = productReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
            .Select(x => new
            {
                x.Id,
                x.Name,
                x.Price,
                x.Stock,
                x.CreatedDate
            }).ToList();

        return new()
        {
            Products = product,
            TotalCount = totalCount
        };
    }
}