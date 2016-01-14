using System.Web.Mvc;
using Simple.MVC.Common;
using Simple.ViewModel.Base;
using Simple.ViewModel.DTO;
using Simple.ViewModel.Interfaces;

namespace Simple.MVC.Base
{
	public abstract class BaseController : Controller

	{
		protected LoggedInUserDTO _loggedInUser = new LoggedInUserDTO();

		protected override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			base.OnActionExecuting(filterContext);
			
			if (User != null)
				_loggedInUser = User.Identity.GetIdentityLoggedInUserDto();

		}
	}
}