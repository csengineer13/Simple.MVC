using System;
using System.Collections.Generic;

namespace Simple.Domain.Model
{
	public class Organization
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string CatchPhrase { get; set; }
		public string BSPhrase { get; set; }

		// Ref
		public DomainUser Owner { get; set; }

		// List Ref
		public List<Address> Addresses { get; set; }
		public List<DomainUser> Employees { get; set; }
	}
}