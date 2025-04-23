using System;
namespace Velo.MobileApp.Core.Shared
{
	public class DomainException : Exception
	{
		public string Code { get; private set; }
		public Exception? OriginalException { get; private set; }

		public DomainException(string message, string code, Exception? originalException = null) : base(message)
		{
			Code = code;
			OriginalException = originalException;
		}
	}
}

