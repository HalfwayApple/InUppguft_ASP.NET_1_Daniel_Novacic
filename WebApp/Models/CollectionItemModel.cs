namespace WebApp.Models
{
	public class CollectionItemModel
	{
		public string Id { get; set; } = null!;
		public string ImageUrl { get; set; } = null!;
		public string Title { get; set; } = null!;
		public decimal Price { get; set; }
		public int StarRating { get; set; }
	}
}
