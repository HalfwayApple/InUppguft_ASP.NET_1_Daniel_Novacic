using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class ProductController : Controller
{
	public async Task<IActionResult> Index()
	{
		using var http = new HttpClient();
		var result = await http.GetFromJsonAsync<IEnumerable<CollectionItemModel>>("https://localhost:7230/api/products?key=755d128a-d2ae-43f9-a521-41712709f1b5");

		return View(result);
	}

	public async Task<IActionResult> Details(int articleNumber)
	{
		using var http = new HttpClient();
		var result = await http.GetFromJsonAsync<CollectionItemModel>($"https://localhost:7230/api/products/id/{articleNumber}?key=755d128a-d2ae-43f9-a521-41712709f1b5");

		return View(result);
	}
}
