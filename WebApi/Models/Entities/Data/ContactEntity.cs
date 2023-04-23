using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApi.Models.Entities.Data
{
	public class ContactEntity
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Email { get; set; } = null!;
		public string Comment { get; set; } = null!;
	}
}
