using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Simple.Domain;
using Simple.Domain.Entities;
using Simple.MVC.Base;
using Simple.MVC.Common;
using Simple.ViewModel.Common;
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
			var vm = new UserViewModel { User = _loggedInUser };
			var resultSet = _unitOfWork.UserRepository.GetAll().ToList();
			vm.List = Mapper.Map<List<UserDTO>>(resultSet);
			return View(vm);
		}

		public ActionResult GetList()
		{
			var vm = new UserViewModel();
			return new JsonNetResult { Data = vm };
		}

		public ActionResult Item(Guid id)
		{
			var vm = new UserViewModel();
			return new JsonNetResult { Data = vm };
		}

		[HttpPost]
		public ActionResult Create(UserViewModel vm)
		{
			return new JsonNetResult { Data = vm };
		}

		[HttpPost]
		public ActionResult Edit(UserViewModel vm)
		{
			if (ModelState.IsValid)
			{
				var submittedEntity = vm.ItemDetail;
				var dbEntity = _unitOfWork.UserRepository.FindById(submittedEntity.Id);
				dbEntity = Mapper.Map<User>(submittedEntity);
				_unitOfWork.UserRepository.Update(dbEntity);
				_unitOfWork.SaveChanges();

				// Pulling back changes
				vm.ItemDetail = Mapper.Map<UserDetailDTO>(_unitOfWork.UserRepository.FindById(submittedEntity.Id));
				return new JsonNetResult {Data = vm};
			}

			var errorState = ModelState.ToJsonValidation();
			return new JsonNetResult { Data = errorState };
		}

		[HttpPost]
		public ActionResult Delete(Guid id)
		{
			// verify exists
			var dbEntity = _unitOfWork.UserRepository.FindById(id);
			_unitOfWork.UserRepository.Remove(dbEntity);
			_unitOfWork.SaveChanges();

			Response.StatusCode = 200;
			return new JsonNetResult{ Data = new SimpleModelState() };
		}
	}
}