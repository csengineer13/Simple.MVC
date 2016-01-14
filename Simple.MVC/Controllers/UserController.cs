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
			var resultSet = _unitOfWork.UserRepository.GetAll().ToList();
			vm.List = Mapper.Map<List<UserDTO>>(resultSet);
			return View(vm);
		}
	}
}