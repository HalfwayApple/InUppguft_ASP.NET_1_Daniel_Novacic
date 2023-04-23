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
        return await _context.Products.Include(x => x.Tag).ToListAsync();
    }

    public async Task<IEnumerable<ProductEntity>> GetByTagAsync(string tagName)
    {
        return await _context.Products
            .Where(x => x.Tag.TagName == tagName)
            .Include(x => x.Tag)
            .ToListAsync();
    }

    public async Task<ProductEntity> GetByIdAsync1(int id)
    {
        return await base.GetAsync(x => x.ArticleNumber == id);
    }

	public async Task<ProductEntity> GetByIdAsync(int id)
	{
        var result = await _context.Products.FirstOrDefaultAsync(x => x.ArticleNumber == id);
        return result;
	}
}
