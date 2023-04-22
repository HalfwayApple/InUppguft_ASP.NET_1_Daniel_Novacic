using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using WebApp.Models.Forms;

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
}
