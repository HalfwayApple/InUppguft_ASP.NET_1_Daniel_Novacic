namespace WebApp.Models
{
	public class CollectionModel
	{
		public string Title { get; set; } = null!;
		public IEnumerable<CollectionItemModel> CollectionItems { get; set; } = null!;
	}
}
