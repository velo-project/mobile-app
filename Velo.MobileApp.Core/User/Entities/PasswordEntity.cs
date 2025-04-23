using System;
namespace Velo.MobileApp.Core.User.Entities
{
	public abstract class PasswordEntity
	{
		public string Value { get; protected set; } = string.Empty;
		public string Salt { get; protected set; } = string.Empty;

		public abstract string GenerateFrom(string value);
		public abstract bool MatchesWith(string value);
	}
}

