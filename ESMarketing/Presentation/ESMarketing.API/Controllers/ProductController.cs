using ESMarketing.Application.Features.Queries.GetAllProducts;
using ESMarketing.Application.Repositories.Products;
using ESMarketing.Application.ViewModels.Products;
using ESMarketing.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ESMarketing.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController(
    IProductReadRepository productReadRepository,
    IProductWriteRepository productWriteRepository,
    IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest productQueryRequest)
    {
        GetAllProductQueryResponse productQueryResponse= await mediator.Send(productQueryRequest);
        return Ok(productQueryResponse);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(string id)
    {
        var result = await productReadRepository.GetByIdAsync(id, false);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Post(ProductCreateModel productCreateModel)
    {
        var result = await productWriteRepository.AddAsync(new()
        {
            Name = productCreateModel.Name,
            Stock = productCreateModel.Stock,
            Price = productCreateModel.Price
        });
        await productWriteRepository.SaveAsync();
        return Ok(result);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Put(ProductUpdateModel productUpdateModel)
    {
        Product product = await productReadRepository.GetByIdAsync(productUpdateModel.Id);

        product.Name = productUpdateModel.Name;
        product.Stock = productUpdateModel.Stock;
        product.Price = productUpdateModel.Price;

        await productWriteRepository.SaveAsync();

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await productWriteRepository.RemoveAsync(id);
        await productWriteRepository.SaveAsync();
        return Ok();
    }
}