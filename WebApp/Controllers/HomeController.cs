using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.ViewModels.Home;

namespace WebApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var viewModel = new IndexViewModel()
			{
				ShowcaseModel = new ShowcaseModel
				{
					Title = "Exclusive Chair gold Collection.",
					Ingress = "WELCOME TO BMERKETO SHOP",
					ButtonText = "SHOP NOW",
					ImageUrl = "images/showcase-img.png"
				},
				CollectionModel = new CollectionModel
				{
					Title = "Best Collection",
					Categories = new List<string>
					{
						"All", "Bag", "Dress", "Decoration", "Essentials", "Interior", "Laptop", "Mobile", "Beauty"
					},
					CollectionItems = new List<CollectionItemModel>
					{
						new CollectionItemModel { Id = "1", Title = "Apple watch", Price = 649.00m, ImageUrl = "images/placeholders/270x295.svg", StarRating = 4 },
						new CollectionItemModel { Id = "2", Title = "Samsung phone", Price = 699.00m, ImageUrl = "images/placeholders/270x295.svg", StarRating = 5 },
						new CollectionItemModel { Id = "3", Title = "Dell PC", Price = 299.00m, ImageUrl = "images/placeholders/270x295.svg", StarRating = 3 },
						new CollectionItemModel { Id = "4", Title = "Dyson vacuumcleaner", Price = 199.00m, ImageUrl = "images/placeholders/270x295.svg", StarRating = 5 },
						new CollectionItemModel { Id = "5", Title = "Apple watch collection", Price = 30.00m, ImageUrl = "images/placeholders/270x295.svg" },
						new CollectionItemModel { Id = "6", Title = "Apple watch collection", Price = 30.00m, ImageUrl = "images/placeholders/270x295.svg" },
						new CollectionItemModel { Id = "7", Title = "Apple watch collection", Price = 30.00m, ImageUrl = "images/placeholders/270x295.svg" },
						new CollectionItemModel { Id = "8", Title = "Apple watch collection", Price = 30.00m, ImageUrl = "images/placeholders/270x295.svg" },
					}
				},
				SpecialOffersModel = new SpecialOffersModel
				{

				}
			};

			return View(viewModel);
		}
	}
}
