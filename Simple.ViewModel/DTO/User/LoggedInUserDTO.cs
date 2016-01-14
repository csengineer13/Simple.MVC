using System;
using Simple.ViewModel.Interfaces;

namespace Simple.ViewModel.DTO
{
	// Claims are set: SignInAsync()
	// And: GetIdentityLoggedInUserDto()
	public class LoggedInUserDTO : IDto<string>
	{
		public string Id { get; set; }
		public string ClientId { get; set; }

		public string UserName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
	}
}