using ESMarketing.Application.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace ESMarketing.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController(IProductService productService) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var products = productService.GetProducts();
            return Ok(products);
        }
    }
}