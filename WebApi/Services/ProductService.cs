using Microsoft.EntityFrameworkCore;
using WebApi.Contexts;
using WebApi.Models.Entities.Data;
using WebApi.Repos;

namespace WebApi.Services
{
    public class ProductService
	{
		private readonly ProductRepo _productRepo;

        public ProductService(ProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<IEnumerable<ProductEntity>> GetAllAsync()
		{
			return await _productRepo.GetAllAsync();
		}

        public async Task<IEnumerable<ProductEntity>> GetByTagAsync(string tagName)
        {
            return await _productRepo.GetByTagAsync(tagName);
        }
    }
}
