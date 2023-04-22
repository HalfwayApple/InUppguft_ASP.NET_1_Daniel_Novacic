using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers;

[Authorize(Roles = "Admin")]
[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
	private readonly UserService _userService;

	public UsersController(UserService userService)
	{
		_userService = userService;
	}

	[HttpGet]
	public async Task<IActionResult> GetAll()
	{
		return Ok(await _userService.GetAllAsync());
	}
}
