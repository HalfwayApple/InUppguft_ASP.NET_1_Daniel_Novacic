using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace WebApp.Controllers;

public class UserController : Controller
{
	public async Task<IActionResult> Index()
	{
		using var http = new HttpClient();

		var token = HttpContext.Request.Cookies["accessToken"];
		http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
		var result = await http.GetFromJsonAsync<IEnumerable<dynamic>>("https://localhost:7230/api/users");

		if (User.Identity.IsAuthenticated)
		{
			return RedirectToAction("MyPage", "User");
		}
		else
		{
			return RedirectToAction("Register", "User");
		}
	}

	public IActionResult MyPage()
	{
		return View();
	}

	public IActionResult Register()
	{
		return View();
	}

	public IActionResult Login()
	{
		return View();
	}
}
