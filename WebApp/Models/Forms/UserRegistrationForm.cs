using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApp.Models.Forms
{
    public class UserRegistrationForm
    {
		[Required(ErrorMessage = "Du måste ange ett förnamn")]
		[MinLength(2, ErrorMessage = "Förnamnet måste minst innehålla 2 tecken")]
		[DisplayName("Förnamn")]
		public string FirstName { get; set; } = null!;

		[Required(ErrorMessage = "Du måste ange ett efternamn")]
		[MinLength(3, ErrorMessage = "Efternamnet måste minst innehålla 2 tecken")]
		[DisplayName("Efternamn")]
		public string LastName { get; set; } = null!;

		[EmailAddress]
		[RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "E-postadressen måste ha formatet a@a.aa")]
		[DisplayName("E-postadress")]
		public string Email { get; set; } = null!;

		[Required(ErrorMessage = "Du måste ange ett lösenord")]
		[DataType(DataType.Password)]
		[MinLength(8, ErrorMessage = "Lösenordet måste minst innehålla 8 tecken")]
		[DisplayName("Lösenord")]
		public string Password { get; set; } = null!;

		[Required(ErrorMessage = "Du måste upprepa lösenordet")]
		[DataType(DataType.Password)]
		[Compare(nameof(Password), ErrorMessage = "Lösenorden matchar inte")]
		public string ConfirmPassword { get; set; } = null!;

	}
}
