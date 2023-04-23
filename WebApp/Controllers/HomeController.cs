using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.ViewModels.Home;

namespace WebApp.Controllers
{
	public class HomeController : Controller
	{
		public async Task<IActionResult> IndexAsync()
		{
			using var http = new HttpClient();

			var featuredItems = await http.GetFromJsonAsync<IEnumerable<CollectionItemModel>>("https://localhost:7230/api/Products/Tag/Featured?key=755d128a-d2ae-43f9-a521-41712709f1b5");
			var newItems = await http.GetFromJsonAsync<IEnumerable<CollectionItemModel>>("https://localhost:7230/api/Products/Tag/New?key=755d128a-d2ae-43f9-a521-41712709f1b5");
			var popularItems = await http.GetFromJsonAsync<IEnumerable<CollectionItemModel>>("https://localhost:7230/api/Products/Tag/Popular?key=755d128a-d2ae-43f9-a521-41712709f1b5");


			var viewModel = new IndexViewModel()
			{
				ShowcaseModel = new ShowcaseModel
				{
					Title = "DONT MISS THIS OPPORTUNITY",
					Ingress = "GET UP TO 40% OFF",
					ButtonText = "SHOP NOW",
					ImageUrl = "images/showcase-img.png"
				},
				FeaturedModel = new CollectionModel
				{
					Title = "Featured",
					CollectionItems = featuredItems.Take(2)
				},
                NewModel = new CollectionModel
                {
                    Title = "New",
                    CollectionItems = newItems.Take(2)
                },
                PopularModel = new CollectionModel
                {
                    Title = "Popular",
                    CollectionItems = popularItems.Take(2)
                },
				SpecialOffersModel = new SpecialOffersModel()
			};

			return View(viewModel);
		}
	}
}
