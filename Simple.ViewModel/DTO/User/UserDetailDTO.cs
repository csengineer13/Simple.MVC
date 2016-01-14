using Simple.ViewModel.Interfaces;
using System;

namespace Simple.ViewModel.DTO
{
	public class UserDetailDTO : IDto<Guid>
	{
		public Guid Id { get; set; }
		public string ClientId { get; set; }

		public string Username { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
	}
}