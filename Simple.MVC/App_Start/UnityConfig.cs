using Microsoft.AspNet.Identity;
using Microsoft.Practices.Unity;
using Simple.Repository;
using Simple.Domain;
using Simple.MVC.Identity;
using System;
using System.Web.Mvc;
using Unity.Mvc5;

namespace Simple.MVC
{
	public static class UnityConfig
	{
		public static void RegisterComponents()
		{
			var container = new UnityContainer();

			container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager(), new InjectionConstructor("SimpleMVCConnectionString"));
			container.RegisterType<IUserStore<IdentityUser, Guid>, UserStore>(new TransientLifetimeManager());
			container.RegisterType<RoleStore>(new TransientLifetimeManager());

			DependencyResolver.SetResolver(new UnityDependencyResolver(container));
		}
	}
}