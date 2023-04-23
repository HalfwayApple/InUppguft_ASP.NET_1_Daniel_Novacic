using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Forms;

namespace WebApp.Controllers;

public class ContactsController : Controller
{
	public IActionResult Index()
	{
		return View();
	}

	[HttpPost]
	public async Task<IActionResult> Index(ContactForm form)
	{
		if (ModelState.IsValid)
		{
			using var http = new HttpClient();

			var result = await http.PostAsJsonAsync("https://localhost:7230/api/Contact/Add?key=755d128a-d2ae-43f9-a521-41712709f1b5", form);

			if (result.IsSuccessStatusCode)
			{
                return RedirectToAction("Index", "Home");
            }
        }

		return View(form);
	}
}
