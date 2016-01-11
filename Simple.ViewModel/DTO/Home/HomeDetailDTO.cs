using System;
using Simple.ViewModel.Interfaces;

namespace Simple.ViewModel.DTO
{
	public class HomeDetailDTO : IDto<Guid>
	{
		public Guid Id { get; set; }
		public string ClientId { get; set; }
	}
}