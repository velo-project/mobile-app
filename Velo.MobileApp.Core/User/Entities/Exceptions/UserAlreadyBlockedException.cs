using System;
namespace Velo.MobileApp.Core.User.Entities.Exceptions
{
	public class UserAlreadyBlockedException : Exception
	{
		public UserAlreadyBlockedException() : base("User Already Blocked")
		{
		}
	}
}

