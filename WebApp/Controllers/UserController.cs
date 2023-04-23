using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using WebApp.Models.Forms;
using static System.Net.WebRequestMethods;

namespace WebApp.Controllers;

public class UserController : Controller
{
	public IActionResult Index()
	{
		return View();
	}

	public IActionResult MyPage()
	{
        using var http = new HttpClient();

        var token = HttpContext.Request.Cookies["accessToken"];
        http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

		try
		{
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
			var readableToken = handler.ReadJwtToken(token);
			var roles = readableToken.Claims.Where(x => x.Type == "role").Select(x => x.Value).ToList();
            if (roles.Contains("Admin"))
			{
                return RedirectToAction("Admin", "User");
            }
        }
		catch {}

		return View();	
    }

	public IActionResult Register()
	{
		return View();
	}

	[HttpPost]
	public async Task<IActionResult> Register(UserRegistrationForm form)
	{
		if (ModelState.IsValid)
		{
			using var http = new HttpClient();

			var result = await http.PostAsJsonAsync("https://localhost:7230/api/Authentication/Register", form);

			if (result.IsSuccessStatusCode)
			{
				return RedirectToAction("Login", "Login");
			}

		}
		return View(form);
	}

	public IActionResult Admin()
	{
        return View();
    }

	[HttpPost]
	public async Task<IActionResult> Admin(AdminAddProductForm form)
	{
		if (ModelState.IsValid)
		{
			using var http = new HttpClient();

			var result = await http.PostAsJsonAsync("https://localhost:7230/api/Products/Create?key=755d128a-d2ae-43f9-a521-41712709f1b5", form);

			if (result.IsSuccessStatusCode)
			{
				return Created("", null);
			}

			return RedirectToAction("Index", "Home");
		}

		return View(form);
	}
}
