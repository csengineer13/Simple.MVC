using System;

namespace Simple.Domain.Model
{
	public class Address
	{
		public Guid Id { get; set; }

		public string Street1 { get; set; }
		public string Street2 { get; set; }
		public string Street3 { get; set; }
		public string Street4 { get; set; }
		public string City { get; set; }
		public string State { get; set; } // todo: enum
		public string ZipCode { get; set; }
		//public string County { get; set; }
		//public string CountryCode { get; set; }
		//public string Latitude { get; set; }
		//public string Longitude { get; set; }

		public bool IsPrimary { get; set; }
	}
}