using System;
using Simple.ViewModel.Interfaces;

namespace Simple.ViewModel.DTO
{
	public class HomeDTO : IDto<Guid>
	{
		public Guid Id { get; set; }
		public string ClientId { get; set; }
	}
}