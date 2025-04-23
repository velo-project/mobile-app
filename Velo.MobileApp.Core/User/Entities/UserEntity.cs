using System;
namespace Velo.MobileApp.Core.User.Entities
{
	public abstract class UserEntity
	{
		public int Id { get; protected set; }
		public string Name { get; protected set; } = string.Empty;
		public string? PrefferedName { get; protected set; }
		public string? ProfilePhotoUrl { get; protected set; }
		public string? BannerPhotoUrl { get; protected set; }
		public string? Description { get; protected set; }
		public bool IsBlocked { get; protected set; } = false;
		public PasswordEntity Password { get; protected set; }

		public abstract void BlockUser();
		public abstract void ActivateUser();
	}
}

