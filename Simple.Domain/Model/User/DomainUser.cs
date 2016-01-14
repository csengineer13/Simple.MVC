using System;
using System.Collections.Generic;
using Simple.Domain.Model.User;

namespace Simple.Domain.Model
{
	public class DomainUser
	{
		public DomainUser()
		{
			Id = Guid.NewGuid().ToString();
			this.Claims = (ICollection<UserClaim>)new List<UserClaim>();
			this.Roles = (ICollection<UserRole>)new List<UserRole>();
			this.Logins = (ICollection<UserLogin>)new List<UserLogin>();
		}

		public DomainUser(string userName)
			: this()
		{
			UserName = userName;
		}

		// IdentityUser
		public virtual string Id { get; set; }
		public virtual string UserName { get; set; }
		public virtual string PasswordHash { get; set; }
		public virtual string SecurityStamp { get; set; }
		public virtual ICollection<UserRole> Roles { get; private set; }
		public virtual ICollection<UserClaim> Claims { get; private set; }
		public virtual ICollection<UserLogin> Logins { get; private set; }

		// User
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
	}

}