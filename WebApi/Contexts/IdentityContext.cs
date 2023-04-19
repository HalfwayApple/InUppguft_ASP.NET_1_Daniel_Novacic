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

	public DbSet<AddressEntity> Addresses { get; set; }
}
