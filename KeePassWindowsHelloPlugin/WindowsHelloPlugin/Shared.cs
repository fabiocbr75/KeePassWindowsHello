using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace FingerprintPlugin
{
	public static class Shared
	{
		public static string Protect(
			this string clearText,
			byte[] entropyBytes = null,
			DataProtectionScope scope = DataProtectionScope.CurrentUser)
		{
			if (clearText == null)
			{
				throw new ArgumentNullException("clearText");
			}
			byte[] clearBytes = Encoding.UTF8.GetBytes(clearText);
			byte[] encryptedBytes = ProtectedData.Protect(clearBytes, entropyBytes, scope);
			return Convert.ToBase64String(encryptedBytes);
		}

		public static string Unprotect(
			this string encryptedText,
			byte[] entropyBytes = null,
			DataProtectionScope scope = DataProtectionScope.CurrentUser)
		{
			if (encryptedText == null)
			{
				throw new ArgumentNullException("encryptedText");
			}
			byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
			byte[] clearBytes = ProtectedData.Unprotect(encryptedBytes, entropyBytes, scope);
			return Encoding.UTF8.GetString(clearBytes);
		}
	}
}
