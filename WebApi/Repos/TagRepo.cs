using WebApi.Contexts;
using WebApi.Models.Entities.Data;

namespace WebApi.Repos
{
	public class TagRepo : BaseRepository<TagEntity, DataContext>
	{
		public TagRepo(DataContext context) : base(context)
		{
		}

		public async Task<TagEntity> GetTagAsync(string tagName)
		{
			return await base.GetAsync(x => x.TagName == tagName);
		}
	}
}
