using Microsoft.EntityFrameworkCore;
using WebApi.Contexts;
using WebApi.Models.Entities.Data;

namespace WebApi.Services
{
    public class ProductService
	{
		private readonly DataContext _context;

		public ProductService(DataContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<ProductEntity>> GetAllAsync()
		{
			return await _context.Products.ToListAsync();
		}
	}
}
