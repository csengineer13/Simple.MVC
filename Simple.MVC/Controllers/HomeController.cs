using System.Web.Mvc;
using Simple.ViewModel.ViewModels;

namespace Simple.MVC.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var vm = new HomeViewModel();
			return View(vm);
		}
	}
}