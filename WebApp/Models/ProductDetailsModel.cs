namespace WebApp.Models
{
	public class ProductDetailsModel
	{
		public int ArticleNumber { get; set; }
		public string ProductName { get; set; } = null!;
		public string? Description { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
		public int StarRating { get; set; }
	}
}
