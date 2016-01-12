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

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}