using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bogus;

namespace Simple.MVC.Migrations.Seed
{
	public class UserSeed
	{
		public static void Seed(ApplicationDbContext context)
		{
			// CONFIG
			var numUsersToGen = 50;

			// USER RULES
			var testUsers = new Faker<ApplicationUser>()
				.RuleFor(u => u.Id, f => Guid.NewGuid().ToString())
				.RuleFor(u => u.UserName, f => f.Name.FirstName())
				//.RuleFor(u => u.Logins, f => 0)
				;

			while (numUsersToGen > 0)
			{
				context.Users.Add(testUsers.Generate());
				numUsersToGen--;
			}
		}
	}
}