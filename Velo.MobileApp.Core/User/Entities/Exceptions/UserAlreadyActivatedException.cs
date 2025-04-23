using System;
using Velo.MobileApp.Core.Shared;

namespace Velo.MobileApp.Core.User.Entities.Exceptions
{
	public class UserAlreadyActivatedException : DomainException
	{
		public UserAlreadyActivatedException() : base("User Already Activated", "USER_UAA")
		{
		}
	}
}

