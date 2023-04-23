using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities.Data;

namespace WebApi.Contexts;

    public class DataContext : DbContext
{
	public DataContext(DbContextOptions options) : base(options)
	{
	}

	public DbSet<ProductEntity> Products { get; set; }
	public DbSet<TagEntity> Tags { get; set; }
	public DbSet<ContactEntity> Contacts { get; set; }

	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);

		builder.Entity<TagEntity>().HasData
			(
				new TagEntity { Id = 1, TagName = "Featured"},
				new TagEntity { Id = 2, TagName = "Popular"},
				new TagEntity { Id = 3, TagName = "New"}
			);
	}
}
