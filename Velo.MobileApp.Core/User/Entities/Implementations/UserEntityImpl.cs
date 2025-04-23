using System;
using Velo.MobileApp.Core.User.Entities.Exceptions;

namespace Velo.MobileApp.Core.User.Entities.Implementations
{
	public sealed class UserEntityImpl : UserEntity
	{
		public UserEntityImpl()
		{
		}

        public sealed override void ActivateUser()
        {
            if (IsBlocked is false)
                throw new UserAlreadyActivatedException();

            IsBlocked = false;
        }

        public sealed override void BlockUser()
        {
            if (IsBlocked)
                throw new UserAlreadyBlockedException();

            IsBlocked = true;
        }
    }
}

