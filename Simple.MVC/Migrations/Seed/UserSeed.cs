using System;
using Bogus;
using Simple.Domain.Model;

namespace Simple.MVC.Migrations.Seed
{
	public class UserSeed
	{
		public static void Seed(ApplicationDbContext context)
		{
			// CONFIG
			var numUsersToGen = 50;

			// USER RULES
			var testUsers = new Faker<DomainUser>()
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