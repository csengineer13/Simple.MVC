using System.Web.Mvc;
using Simple.MVC.Base;
using Simple.ViewModel.ViewModels;

namespace Simple.MVC.Controllers
{
	public class HomeController : BaseController
	{	
		public ActionResult Index()
		{
			var vm = new HomeViewModel {User = _loggedInUser};
			return View(vm);
		}
	}
}