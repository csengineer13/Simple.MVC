using System.Web.Mvc;
using Simple.Domain;
using Simple.MVC.Base;
using Simple.ViewModel.ViewModels;

namespace Simple.MVC.Controllers
{
	public class HomeController : BaseController
	{
		public HomeController(IUnitOfWork unitOfWork)
			:base(unitOfWork)
		{
			
		}

		public ActionResult Index()
		{
			var vm = new HomeViewModel {User = _loggedInUser};
			return View(vm);
		}
	}
}