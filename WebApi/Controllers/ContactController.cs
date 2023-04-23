using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Filters;
using WebApi.Models.DTOs;
using WebApi.Services;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[UseApiKey]
	public class ContactController : ControllerBase
	{
		private readonly ContactService _contactService;

		public ContactController(ContactService contactService)
		{
			_contactService = contactService;
		}

		[HttpPost]
		[Route("Add")]
		public async Task<IActionResult> AddContact(ContactHttpRequest model)
		{
			if (ModelState.IsValid)
			{
				if (await _contactService.AddAsync(model) != null)
				{
					return Created("", null);
				}
			}

			return BadRequest(model);
		}
	}
}
