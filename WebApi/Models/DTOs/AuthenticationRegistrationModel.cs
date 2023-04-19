using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using WebApi.Models.Entities.Identity;

namespace WebApi.Models.DTOs;

public class AuthenticationRegistrationModel
{
	public string FirstName { get; set; } = null!;
	public string LastName { get; set; } = null!;

	[RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
	public string Email { get; set; } = null!;

	[RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$")]
	public string Password { get; set; } = null!;

	public string? PhoneNumber { get; set; }
	public string? StreetName { get; set; }
	public string? PostalCode { get; set; }
	public string? City { get; set; }

	// Implicit conversion from AuthenticationRegistrationModel to IdentityUser
	public static implicit operator IdentityUser(AuthenticationRegistrationModel model)
	{
		return new IdentityUser
		{
			UserName = model.Email,
			Email = model.Email,
			PhoneNumber = model.PhoneNumber
		};
	}

	// Implicit conversion from AuthenticationRegistrationModel to UserProfileEntity
	public static implicit operator UserProfileEntity(AuthenticationRegistrationModel model)
	{
		return new UserProfileEntity
		{
			FirstName = model.FirstName,
			LastName = model.LastName
		};
	}

	// Implicit conversion from AuthenticationRegistrationModel to AddressEntity
	public static implicit operator AddressEntity(AuthenticationRegistrationModel model)
	{
		return new AddressEntity
		{
			StreetName = model.StreetName!,
			PostalCode = model.PostalCode!,
			City = model.City!
		};
	}
}
