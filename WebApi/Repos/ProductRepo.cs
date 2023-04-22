using Microsoft.EntityFrameworkCore;
using WebApi.Contexts;
using WebApi.Models.Entities.Data;

namespace WebApi.Repos;

public class ProductRepo : BaseRepository<ProductEntity, DataContext>
{
    public ProductRepo(DataContext context) : base(context)
    {
    }

    public override async Task<IEnumerable<ProductEntity>> GetAllAsync()
    {
        return await _context.Products.Include(x => x.Tags).ToListAsync();
    }

    public async Task<IEnumerable<ProductEntity>> GetByTagAsync(string tagName)
    {
        return await _context.Products
            .Where(x => x.Tags.Any(t => t.TagName == tagName))
            .Include(x => x.Tags)
            .ToListAsync();
    }

    public async Task<ProductEntity> GetById(int id)
    {
        return await base.GetAsync(x => x.ArticleNumber == id);
    }
}
