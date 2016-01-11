using System;
using Simple.ViewModel.Interfaces;

namespace Simple.ViewModel.DTO
{
	public class TestDTO : IDto<Guid>
	{
		public Guid Id { get; set; }
		public string ClientId { get; set; }

		public string Name { get; set; }
		public string Derived { get; set; }
	}
}