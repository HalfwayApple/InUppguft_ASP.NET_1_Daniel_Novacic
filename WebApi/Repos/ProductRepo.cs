using WebApi.Contexts;
using WebApi.Models.Entities.Data;

namespace WebApi.Repos
{
    public class ProductRepo : BaseRepository<ProductEntity, DataContext>
    {
        public ProductRepo(DataContext context) : base(context)
        {
        }
    }
}
