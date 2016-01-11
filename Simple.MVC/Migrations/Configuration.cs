using Simple.MVC.Migrations.Seed;

namespace Simple.MVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

		//  Seed Documentation: https://github.com/bchavez/Bogus
		//  This method will be called after migrating to the latest version.
        protected override void Seed(ApplicationDbContext context)
        {
	        UserSeed.Seed(context);

	        //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
	        //  to avoid creating duplicate seed data. E.g.
	        //
	        //    context.People.AddOrUpdate(
	        //      p => p.FullName,
	        //      new Person { FullName = "Andrew Peters" },
	        //      new Person { FullName = "Brice Lambson" },
	        //      new Person { FullName = "Rowan Miller" }
	        //    );
	        //
        }
    }
}
