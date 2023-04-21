using WebApi.Models.Entities.Data;

namespace WebApi.Models.DTOs;

public class ProductHttpRequest
{
	public string ArticleNumber { get; set; } = null!;
	public string ProductName { get; set; } = null!;
	public string? Description { get; set; }
	public decimal Price { get; set; }

    public ICollection<TagEntity> Tags { get; set; } = new HashSet<TagEntity>();



    public static implicit operator ProductEntity(ProductHttpRequest req)
	{
		return new ProductEntity
		{
			ArticleNumber = req.ArticleNumber,
			ProductName = req.ProductName,
			Description = req.Description,
			Price = req.Price,
			Tags = req.Tags

		};
	}
}
