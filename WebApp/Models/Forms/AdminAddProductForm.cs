using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApp.Models.Forms;

public class AdminAddProductForm
{
	[Required(ErrorMessage = "Du måste ange en bild URL")]
	[DisplayName("Bild")]
	public string ImageUrl { get; set; } = null!;

	[Required(ErrorMessage = "Du måste ange ett produktnamn")]
	[MinLength(2, ErrorMessage = "Produktnamnet måste minst innehålla 2 tecken")]
	[DisplayName("Produktnamn")]
	public string ProductName { get; set; } = null!;

	[Required(ErrorMessage = "Du måste ange en beskrivning")]
	[DisplayName("Beskrivning")]
	public string Description { get; set; } = null!;

	[Required(ErrorMessage = "Du måste ange ett pris")]
	[DisplayName("Pris")]
	public decimal Price { get; set; }

	[Required(ErrorMessage = "Du måste ange en rating")]
	[DisplayName("Rating")]
	public int StarRating { get; set; }

	[Required(ErrorMessage = "Du måste ange en tagg")]
	[DisplayName("Tagg")]
	public string Tag { get; set; }
}
