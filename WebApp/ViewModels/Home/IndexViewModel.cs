using WebApp.Models;

namespace WebApp.ViewModels.Home;

public class IndexViewModel
{
    public ShowcaseModel? ShowcaseModel { get; set; }
    public CollectionModel? FeaturedModel { get; set; }
    public CollectionModel? NewModel { get; set; }
    public CollectionModel? PopularModel { get; set; }
	public SpecialOffersModel? SpecialOffersModel { get; set; }
}
