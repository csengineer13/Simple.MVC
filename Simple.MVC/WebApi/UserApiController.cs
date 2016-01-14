using System.Web.Http;
using Simple.Domain;
using Simple.ViewModel.ViewModels;

namespace Simple.MVC.WebApi
{
	public class UserApiController: ApiController
	{
		private IUnitOfWork _unitOfWork;

		public UserApiController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public UserViewModel Get()
		{
			return new UserViewModel();
		}
	}
}