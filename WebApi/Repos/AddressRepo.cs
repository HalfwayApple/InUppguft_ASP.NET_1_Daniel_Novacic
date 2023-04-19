using WebApi.Contexts;
using WebApi.Models.Entities.Identity;

namespace WebApi.Repos
{
	public class AddressRepo : BaseIdentityRepository<AddressEntity>
	{
		public AddressRepo(IdentityContext identity) : base(identity)
		{
		}

		public async Task<AddressEntity> GetOrCreateAsync(AddressEntity entity)
		{
			var addressEntity = await GetAsync(x => x.StreetName == entity.StreetName && x.PostalCode == entity.PostalCode && x.City == entity.City);
			addressEntity ??= await AddAsync(entity);

			return addressEntity;
		}
	}
}
