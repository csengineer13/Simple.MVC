using System.Web.Mvc;
using Simple.MVC.Base;
using Simple.ViewModel.ViewModels;

namespace Simple.MVC.Controllers
{
	[Authorize]
	public class UserController : BaseController
	{	
		public ActionResult Index()
		{
			var vm = new UserViewModel {User = _loggedInUser};
			return View(vm);
		}
	}
}