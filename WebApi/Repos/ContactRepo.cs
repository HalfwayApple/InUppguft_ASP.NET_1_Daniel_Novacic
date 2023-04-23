using WebApi.Contexts;
using WebApi.Models.Entities.Data;

namespace WebApi.Repos
{
	public class ContactRepo : BaseRepository<ContactEntity, DataContext>
	{
		public ContactRepo(DataContext context) : base(context)
		{
		}
	}
}
