using Microsoft.EntityFrameworkCore;
using WebApi.Contexts;
using WebApi.Models.DTOs;
using WebApi.Models.Entities.Data;
using WebApi.Repos;

namespace WebApi.Services
{
    public class ProductService
	{
		private readonly ProductRepo _productRepo;
        private readonly TagRepo _tagRepo;

		public ProductService(ProductRepo productRepo, TagRepo tagRepo)
		{
			_productRepo = productRepo;
			_tagRepo = tagRepo;
		}

		public async Task<IEnumerable<ProductEntity>> GetAllAsync()
		{
			return await _productRepo.GetAllAsync();
		}

        public async Task<IEnumerable<ProductEntity>> GetByTagAsync(string tagName)
        {
            return await _productRepo.GetByTagAsync(tagName);
        }

		public async Task<ProductEntity> GetByIdAsync(int id)
		{
			return await _productRepo.GetByIdAsync(id);
		}

		public async Task<ProductEntity> AddAsync(ProductHttpRequest req)
        {
            ProductEntity entity = req;
			entity.Tag = await _tagRepo.GetTagAsync(req.Tag);
			return await _productRepo.AddAsync(entity);
        }
    }
}
