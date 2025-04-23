using System;
using Velo.MobileApp.Core.Shared;

namespace Velo.MobileApp.Core.User.Entities.Exceptions
{
	public class UserAlreadyBlockedException : DomainException
	{
		public UserAlreadyBlockedException() : base("User Already Blocked", "USER_UAB")
		{
		}
	}
}

