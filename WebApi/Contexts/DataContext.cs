using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities.Data;

namespace WebApi.Contexts
{
    public class DataContext : DbContext
	{
		public DataContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<ProductEntity> Products { get; set; }
		public DbSet<TagEntity> Tags { get; set; }
	}
}
