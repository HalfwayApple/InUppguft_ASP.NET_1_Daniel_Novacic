using WebApi.Models.Entities.Data;

namespace WebApi.Models.DTOs;

public class ContactHttpRequest
{
	public string Name { get; set; } = null!;
	public string Email { get; set; } = null!;
	public string Comment { get; set; } = null!;

	public static implicit operator ContactEntity(ContactHttpRequest req)
	{
		return new ContactEntity
		{
			Name = req.Name,
			Email = req.Email,
			Comment = req.Comment
		};
	}
}
