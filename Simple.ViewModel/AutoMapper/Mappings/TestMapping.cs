using AutoMapper;
using Simple.Domain.Model;
using Simple.ViewModel.DTO;

namespace Simple.ViewModel.AutoMapper.Mappings
{
	public class TestMapping
	{
		public static void Map()
		{
			Mapper.CreateMap<Test, TestDTO>()
				.ForMember(dest => dest.Derived, options => options.MapFrom(source => source.Name + source.Id.ToString()));
		}
	}
}