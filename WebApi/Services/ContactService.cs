using WebApi.Models.DTOs;
using WebApi.Models.Entities.Data;
using WebApi.Repos;

namespace WebApi.Services
{
	public class ContactService
	{
		private readonly ContactRepo _contactRepo;

		public ContactService(ContactRepo contactRepo)
		{
			_contactRepo = contactRepo;
		}

		public async Task<ContactEntity> AddAsync(ContactHttpRequest req)
		{
			return await _contactRepo.AddAsync(req);
		}
	}
}
