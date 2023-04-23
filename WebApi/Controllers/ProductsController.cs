using Microsoft.AspNetCore.Mvc;
using WebApi.Filters;
using WebApi.Models.DTOs;
using WebApi.Services;

namespace WebApi.Controllers;

[Route("api/[controller]")]
//[UseApiKey]
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

    [HttpGet]
    [Route("Tag/{tagName}")]
    public async Task<IActionResult> GetByTag(string tagName)
    {
        return Ok(await _productService.GetByTagAsync(tagName));
    }

    [HttpGet]
    [Route("Id/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await _productService.GetByIdAsync(id));
    }

	[HttpPost]
	[Route("Create")]
	public async Task<IActionResult> CreateProduct(ProductHttpRequest model)
	{
		if (ModelState.IsValid)
		{
			if (await _productService.AddAsync(model) != null)
            {
				return Created("", null);
			}
		}

		return BadRequest(model);
	}
}
