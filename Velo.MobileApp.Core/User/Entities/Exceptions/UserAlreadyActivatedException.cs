using System;
namespace Velo.MobileApp.Core.User.Entities.Exceptions
{
	public class UserAlreadyActivatedException : Exception
	{
		public UserAlreadyActivatedException() : base("User Already Activated")
		{
		}
	}
}

