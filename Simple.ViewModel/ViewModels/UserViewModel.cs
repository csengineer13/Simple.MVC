using System;
using Simple.ViewModel.Base;
using Simple.ViewModel.DTO;

namespace Simple.ViewModel.ViewModels
{
	public class UserViewModel : ViewModelBase<UserDTO, UserDetailDTO, Guid>
	{
		public UserViewModel()
		{
			Title = "User";
		}

		public override Guid GetDefaultIdValue()
		{
			return new Guid();
		}

		// todo
		//public HomeViewModelMeta Meta { get; set; }
	}
}