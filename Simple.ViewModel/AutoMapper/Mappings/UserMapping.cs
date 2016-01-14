using AutoMapper;
using Simple.Domain.Entities;
using Simple.ViewModel.DTO;

namespace Simple.ViewModel.AutoMapper.Mappings
{
	public class UserMapping
	{
		public static void Map()
		{
			Mapper.CreateMap<User, LoggedInUserDTO>()
				.ForMember(d => d.Id, o => o.MapFrom(s => s.UserId.ToString()))
				;
		}
	}
}