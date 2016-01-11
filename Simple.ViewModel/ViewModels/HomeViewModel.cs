using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple.ViewModel.ViewModels
{
	public class HomeViewModel : ViewModelBase<HomeDto, HomeDetailDto, Guid>
	{
		public HomeViewModel()
		{
			Title = "Home";
		}

		public override Guid GetDefaultIdValue()
		{
			return new Guid();
		}

		public HomeViewModelMeta Meta { get; set; }
	}
}