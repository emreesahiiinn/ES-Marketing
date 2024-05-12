using ESMarketing.Application.RequestParameters;
using MediatR;

namespace ESMarketing.Application.Features.Queries.GetAllProducts;

public class GetAllProductQueryRequest : IRequest<GetAllProductQueryResponse>
{
    public int Page { get; set; } = 0;
    public int Size { get; set; } = 5;
}