namespace WebApp.Models
{
	public class CollectionModel
	{
		public string Title { get; set; } = null!;
		public List<string> Categories { get; set; } = null!;
		public List<CollectionItemModel> CollectionItems { get; set; } = null!;
	}
}
