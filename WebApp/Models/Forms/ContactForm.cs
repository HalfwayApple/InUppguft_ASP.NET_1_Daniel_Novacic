using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Forms;

public class ContactForm
{
	[Required(ErrorMessage = "Du måste ange ett namn")]
	[MinLength(2, ErrorMessage = "Namnet måste minst innehålla 2 tecken")]
	[DisplayName("Namn")]
	public string Name { get; set; } = null!;

	[EmailAddress]
	[RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "E-postadressen måste ha formatet a@a.aa")]
	[DisplayName("E-postadress")]
	public string Email { get; set; } = null!;

	[Required(ErrorMessage = "Du måste skriva något")]
	[DisplayName("Kommentar")]
	public string Comment { get; set; } = null!;
}
