using System;
using Velo.MobileApp.Core.User.Entities.Implementations;

namespace Velo.MobileApp.Core.User.Entities.Factories
{
	public static class PasswordEntityFactory
	{
		public static PasswordEntity CreateInstance(string value)
		{
			var entity = new PasswordEntityImpl();

			entity.GenerateFrom(value);

			return entity;
		}
	}
}

