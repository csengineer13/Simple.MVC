using System;

namespace Simple.ViewModel.DTO.User
{
	public class LoggedInUserDTO
	{
		public Guid Id { get; set; }
		public string UserName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
	}
}