using System.Web.Mvc;
using Simple.Domain;
using Simple.MVC.Common;
using Simple.ViewModel.DTO;

namespace Simple.MVC.Base
{
	public abstract class BaseController : Controller
	{
		protected LoggedInUserDTO _loggedInUser = new LoggedInUserDTO();
		protected IUnitOfWork _unitOfWork;

		protected BaseController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		protected override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			base.OnActionExecuting(filterContext);
			
			if (User != null)
				_loggedInUser = User.Identity.GetIdentityLoggedInUserDto();
		}
	}
}