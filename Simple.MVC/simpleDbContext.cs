//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions;
//using Microsoft.AspNet.Identity.EntityFramework;
//using Simple.Domain.Model;
//using Simple.Domain.Model.User;

//// Help configuring contexts w/ Identity defaults
//// http://stackoverflow.com/questions/28531201/entitytype-identityuserlogin-has-no-key-defined-define-the-key-for-this-entit
//namespace Simple.MVC
//{
//	// You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
//	public class User : IdentityUser
//	{
//		public string FirstName { get; set; }
//		public string LastName { get; set; }
//		public string Email { get; set; }
//	}
//	 //public class ApplicationDbContext : IdentityDbContext<ApplicationUser, CustomRole, Guid, CustomUserLogin, CustomUserRole, CustomUserClaim>
//	public class ApplicationDbContext : IdentityDbContext<User> //IdentityDbContext<User, Role, Guid, UserLogin, UserRole, UserClaim>
//	{
//		public ApplicationDbContext()
//			: base("DefaultConnection")
//		{
//			//Database.SetInitializer<ApplicationDbContext>(null);
//			//Configuration.ProxyCreationEnabled = false;
//			//Configuration.LazyLoadingEnabled = false;
//		}

//		public static ApplicationDbContext Create()
//		{
//			return new ApplicationDbContext();
//		}

//		// Identity and Authorization
//		public DbSet<IdentityUserLogin> UserLogins { get; set; }
//		public DbSet<IdentityUserClaim> UserClaims { get; set; }
//		public DbSet<IdentityUserRole> UserRoles { get; set; }

//		// Custom DbSets
//		public DbSet<DomainUser> Users { get; set; }
//		public DbSet<Test> Tests { get; set; }


//		// Config for EF generation
//		protected override void OnModelCreating(DbModelBuilder modelBuilder)
//		{
//			base.OnModelCreating(modelBuilder);

//			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
//			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

//			// Configure Asp Net Identity Tables
//			modelBuilder.Entity<IdentityUser>().ToTable("User");
//			modelBuilder.Entity<User>().ToTable("User");
//			modelBuilder.Entity<DomainUser>().ToTable("User");
//			modelBuilder.Entity<IdentityUser>().Property(u => u.PasswordHash).HasMaxLength(500);
//			//modelBuilder.Entity<IdentityUser>().Property(u => u.Stamp).HasMaxLength(500);
//			//modelBuilder.Entity<IdentityUser>().Property(u => u.PhoneNumber).HasMaxLength(50);

//			modelBuilder.Entity<IdentityUserRole>().ToTable("Role");
//			modelBuilder.Entity<IdentityUserRole>().ToTable("UserRole");
//			modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogin");
//			modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaim");
//			modelBuilder.Entity<IdentityUserClaim>().Property(u => u.ClaimType).HasMaxLength(150);
//			modelBuilder.Entity<IdentityUserClaim>().Property(u => u.ClaimValue).HasMaxLength(500);

//			//modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(255));
//			//modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
//			//modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

//			// Additional DB Modeling can be done here. Most can be done with Domain Model Data Annotations
//		}
//	}
//}