using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels.Login;

namespace WebApp.Controllers;

public class LoginController : Controller
{
	public IActionResult Index()
	{
		return View();
	}

	[HttpPost]
	public async Task<IActionResult> Index(LoginViewModel viewModel)
	{
		if (ModelState.IsValid)
		{
			using var http = new HttpClient();

			var result = await http.PostAsJsonAsync("https://localhost:7075/api/authentication/login", viewModel);
			var token = await result.Content.ReadAsStringAsync();

			HttpContext.Response.Cookies.Append("accessToken", token, new CookieOptions
			{
				HttpOnly = true,
				Secure = true,
				Expires = DateTime.Now.AddDays(1)
			});

			return RedirectToAction("MyPage", "User");
		}

		ModelState.AddModelError("", "Incorrect email or password");

		return View(viewModel);
	}
}
