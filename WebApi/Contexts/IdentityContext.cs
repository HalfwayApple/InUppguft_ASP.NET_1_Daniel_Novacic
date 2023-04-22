using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities.Identity;

namespace WebApi.Contexts;

public class IdentityContext : IdentityDbContext<IdentityUser>
{
	public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
	{
	}

	public DbSet<UserProfileEntity> UserProfiles { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var adminRole = new IdentityRole 
        { 
            Id = Guid.NewGuid().ToString(),
            Name = "Admin",
            NormalizedName = "ADMIN",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        };
        var userRole = new IdentityRole
        {
            Id = Guid.NewGuid().ToString(),
            Name = "User",
            NormalizedName = "USER",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        };

        builder.Entity<IdentityRole>().HasData
			(
				adminRole,
                userRole
            );
    }
}
