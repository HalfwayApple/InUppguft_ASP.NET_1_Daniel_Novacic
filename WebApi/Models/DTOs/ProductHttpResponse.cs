namespace WebApi.Models.DTOs
{
	public class ProductHttpResponse
	{
		public string ArticleNumber { get; set; } = null!;
		public string ProductName { get; set; } = null!;
		public string? Description { get; set; }
		public decimal Price { get; set; }
		public string Tag { get; set; } = null!;
	}
}
