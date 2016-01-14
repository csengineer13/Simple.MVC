using System;
using Simple.ViewModel.Base;
using Simple.ViewModel.DTO;

namespace Simple.ViewModel.ViewModels
{
	public class HomeViewModel : ViewModelBase<HomeDTO, HomeDetailDTO, Guid>
	{
		public HomeViewModel()
		{
			Title = "Home";
			LoginForm = new LoginViewModel();
			RegisterForm = new RegisterViewModel();
		}

		public LoginViewModel LoginForm { get; set; }
		public RegisterViewModel RegisterForm { get; set; }

		public override Guid GetDefaultIdValue()
		{
			return new Guid();
		}

		// todo
		//public HomeViewModelMeta Meta { get; set; }
	}
}