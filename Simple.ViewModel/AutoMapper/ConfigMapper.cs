using Simple.ViewModel.AutoMapper.Mappings;

namespace Simple.ViewModel.AutoMapper
{
	public static class ConfigMapper
	{
		public static void MapAll()
		{
			TestMapping.Map();
			UserMapping.Map();
		}
	}
}