using WebApi.Models.Entities.Identity;
using WebApi.Repos;

namespace WebApi.Services;

public class UserService
{
	private readonly UserProfileRepo _userProfileRepo;

	public UserService(UserProfileRepo userProfileRepository)
	{
		_userProfileRepo = userProfileRepository;
	}

	public async Task<IEnumerable<UserProfileEntity>> GetAllAsync()
	{
		return await _userProfileRepo.GetAllAsync();
	}
}
