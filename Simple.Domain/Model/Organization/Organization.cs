using System;
using System.Collections.Generic;
using Simple.Domain.Entities;

namespace Simple.Domain.Model
{
	public class Organization
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string CatchPhrase { get; set; }
		public string BSPhrase { get; set; }

		// Ref
		public User Owner { get; set; }

		// List Ref
		public List<Address> Addresses { get; set; }
		public List<User> Employees { get; set; }
	}
}