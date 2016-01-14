using System;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNet.Identity;
using Simple.ViewModel.DTO;

namespace Simple.MVC.Common
{
	public static class CustomIdentityExtensions
	{
		public static LoggedInUserDTO GetIdentityLoggedInUserDto(this IIdentity identity)
		{
			if (identity == null)
				return null;

			var user = new LoggedInUserDTO
			{
				Id = Guid.Parse(identity.GetUserId()), // Could blow up
				UserName = identity.GetUserName(),
				FirstName = (identity as ClaimsIdentity).FirstOrNull(ClaimTypes.GivenName),
				LastName = (identity as ClaimsIdentity).FirstOrNull(ClaimTypes.Surname)
			};

			return user;
		}

		internal static string FirstOrNull(this ClaimsIdentity identity, string claimType)
		{
			var val = identity.FindFirst(claimType);

			return val == null ? null : val.Value;
		}
	}
}