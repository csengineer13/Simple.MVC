using System.Security.Claims;
using System.Security.Principal;
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
				Id = (identity as ClaimsIdentity).FirstOrNull(ClaimTypes.NameIdentifier),
				UserName = (identity as ClaimsIdentity).FirstOrNull(ClaimTypes.Name),
				FirstName = (identity as ClaimsIdentity).FirstOrNull(ClaimTypes.GivenName),
				LastName = (identity as ClaimsIdentity).FirstOrNull(ClaimTypes.Surname),
				Email = (identity as ClaimsIdentity).FirstOrNull(ClaimTypes.Email)
			};

			return user;
		}

		internal static string FirstOrNull(this ClaimsIdentity identity, string claimType)
		{
			var val = identity.FindFirst(claimType);

			return val == null ? "" : val.Value;
		}
	}
}