using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class ProductsController : Controller
{
	public async Task<IActionResult> Index()
	{
		using var http = new HttpClient();
		var result = await http.GetFromJsonAsync<IEnumerable<string>>("https://localhost:7075/api/products?key=755d128a-d2ae-43f9-a521-41712709f1b5");

		return View(result);
	}
}
