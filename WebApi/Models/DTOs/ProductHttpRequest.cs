using WebApi.Models.Entities.Data;

namespace WebApi.Models.DTOs;

public class ProductHttpRequest
{
	public string ProductName { get; set; } = null!;
	public string? Description { get; set; }
	public decimal Price { get; set; }
	public string ImageUrl { get; set; }
	public int StarRating { get; set; }
	public string Tag { get; set; } = null!;



    public static implicit operator ProductEntity(ProductHttpRequest req)
	{
		return new ProductEntity
		{
			ProductName = req.ProductName,
			Description = req.Description,
			Price = req.Price,
			ImageURL = req.ImageUrl,
			StarRating = req.StarRating
		};
	}
}
