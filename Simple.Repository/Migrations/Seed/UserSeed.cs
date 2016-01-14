using System;
using Bogus;
using Simple.Domain.Entities;

namespace Simple.Repository.Migrations.Seed
{
	public class UserSeed
	{
		public static void Seed(ApplicationDbContext context)
		{
			// CONFIG
			var numUsersToGen = 50;

			// USER RULES
			var testUsers = new Faker<User>()
				.RuleFor(u => u.UserId, f => Guid.NewGuid())
				.RuleFor(u => u.UserName, f => f.Name.FirstName())
				.RuleFor(u => u.LastName, f => f.Name.LastName())
				.RuleFor(u => u.Email, f => f.Internet.Email())
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