using Simple.Repository.Configuration;
using Simple.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Simple.Repository
{
	// 
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(string nameOrConnectionString)
			: base(nameOrConnectionString)
		{
		}

		public IDbSet<User> Users { get; set; }
		public IDbSet<Role> Roles { get; set; }
		public IDbSet<ExternalLogin> Logins { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new UserConfiguration());
			modelBuilder.Configurations.Add(new RoleConfiguration());
			modelBuilder.Configurations.Add(new ExternalLoginConfiguration());
			modelBuilder.Configurations.Add(new ClaimConfiguration());
		}
	}

	public class MigrationsContextFactory : IDbContextFactory<ApplicationDbContext>
	{
		public ApplicationDbContext Create()
		{
			return new ApplicationDbContext("SimpleMVCConnectionString");
		}
	}
}