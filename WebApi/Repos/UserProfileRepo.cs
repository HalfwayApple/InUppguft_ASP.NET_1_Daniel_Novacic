using Microsoft.EntityFrameworkCore;
using WebApi.Contexts;
using WebApi.Models.Entities.Identity;

namespace WebApi.Repos
{
	public class UserProfileRepo : BaseRepository<UserProfileEntity, IdentityContext>
	{
		public UserProfileRepo(IdentityContext identity) : base(identity)
		{
		}

		public async Task<bool> AddAddressAsync(UserProfileEntity userProfileEntity, AddressEntity addressEntity)
		{
			try
			{
				userProfileEntity.Addresses.Add(addressEntity);

				_context.Update(userProfileEntity);
				await _context.SaveChangesAsync();
				return true;
			}
			catch { return false; }
		}

		public override async Task<IEnumerable<UserProfileEntity>> GetAllAsync()
		{
			return await _context.UserProfiles
				.Include(x => x.User)
				.Include(x => x.Addresses)
				.ToListAsync();
		}
	}
}
