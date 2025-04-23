using System;
using System.Security.Cryptography;
using System.Text;

namespace Velo.MobileApp.Core.User.Entities.Implementations
{
	public class PasswordEntityImpl : PasswordEntity
	{
		public PasswordEntityImpl()
		{
		}

        public override string GenerateFrom(string value)
        {
            using var hmac = new HMACSHA256();

            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(value));

            Value = Convert.ToBase64String(hash);
            Salt = Convert.ToBase64String(hmac.Key);

            return Value;
        }

        public override bool MatchesWith(string value)
        {
            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(Salt));

            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(value));

            if (Convert.ToBase64String(hash) == Value)
                return true;

            return false;
        }
    }
}

