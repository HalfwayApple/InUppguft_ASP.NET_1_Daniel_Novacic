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

		public override async Task<IEnumerable<UserProfileEntity>> GetAllAsync()
		{
			return await _context.UserProfiles
				.Include(x => x.User)
				.ToListAsync();
		}
	}
}
