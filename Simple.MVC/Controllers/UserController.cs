using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Simple.Domain;
using Simple.MVC.Base;
using Simple.ViewModel.DTO;
using Simple.ViewModel.ViewModels;

namespace Simple.MVC.Controllers
{
	[Authorize]
	public class UserController : BaseController
	{
		public UserController(IUnitOfWork unitOfWork)
			: base(unitOfWork)
		{
			
		}

		public ActionResult Index()
		{
			var vm = new UserViewModel {User = _loggedInUser};
			vm.List = Mapper.Map<List<UserDTO>>(_unitOfWork.UserRepository.GetAll().ToList());
			return View(vm);
		}
	}
}