using System;
using Simple.ViewModel.Interfaces;

namespace Simple.ViewModel.DTO
{
	public class LoggedInUserDTO : IDto<Guid>
	{
		public Guid Id { get; set; }
		public string ClientId { get; set; }

		public string UserName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
	}
}