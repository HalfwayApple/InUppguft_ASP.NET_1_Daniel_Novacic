using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json.Linq;
using System.Security.Claims;
using WebApi.Models.Entities.Identity;
using Microsoft.Extensions.Configuration;
using WebApi.Helpers;
using WebApi.Models.DTOs;
using WebApi.Models.Entities;
using WebApi.Repos;
using System.Data;

namespace WebApi.Services;

public class AuthService
{
	private readonly UserProfileRepo _userProfileRepository;
	private readonly UserManager<IdentityUser> _userManager;
	private readonly SignInManager<IdentityUser> _signInManager;
	private readonly JwtToken _jwt;

	public AuthService(UserProfileRepo userProfileRepository, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, JwtToken jwt)
	{
		_userProfileRepository = userProfileRepository;
		_userManager = userManager;
		_signInManager = signInManager;
		_jwt = jwt;
	}

	public async Task<bool> RegisterAsync(AuthenticationRegistrationModel model)
	{
		try
		{
			// 1. Skapa en Identity User
			var identityResult = await _userManager.CreateAsync(model, model.Password);
			if (identityResult.Succeeded)
			{
				var identityUser = await _userManager.FindByEmailAsync(model.Email);

				// 2. Sätt roller
				var role = "Admin";
				var noRoles = await _userManager.GetUsersInRoleAsync("Admin");
				if (noRoles.Any())
				{
					role = "User";
				}

				// 2.1. Lägg till roll
				await _userManager.AddToRoleAsync(identityUser, role);

				// 3. Skapa en Användarprofil
				UserProfileEntity userProfileEntity = model;
				userProfileEntity.UserId = identityUser!.Id;
				await _userProfileRepository.AddAsync(userProfileEntity);

				return true;
			}

		}
		catch { }

		return false;
	}

	public async Task<string> LoginAsync(AuthenticationLoginModel model)
	{
		var identityUser = await _userManager.FindByEmailAsync(model.Email);
		if (identityUser != null)
		{
			var signInResult = await _signInManager.CheckPasswordSignInAsync(identityUser, model.Password, false);
			if (signInResult.Succeeded)
			{
                var roles = await _userManager.GetRolesAsync(identityUser);
                var claimsIdentity = new ClaimsIdentity(new Claim[]
				{
					new Claim("id", identityUser.Id.ToString()),
                    new Claim(ClaimTypes.Name, identityUser.Email!),
                    new Claim(ClaimTypes.Role, roles[0])
                });

				return _jwt.Generate(claimsIdentity, DateTime.Now.AddHours(1));
			}
		}

		return string.Empty;
	}
}
