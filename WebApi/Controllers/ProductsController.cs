using Microsoft.AspNetCore.Mvc;
using WebApi.Filters;
using WebApi.Services;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[UseApiKey]
[ApiController]
public class ProductsController : ControllerBase
{
	private readonly ProductService _productService;

    public ProductsController(ProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
	public async Task<IActionResult> Get()
	{
		return Ok(await _productService.GetAllAsync());
	}
}
