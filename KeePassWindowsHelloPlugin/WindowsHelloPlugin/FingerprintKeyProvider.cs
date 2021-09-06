using KeePassLib.Keys;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Security.Credentials;

namespace FingerprintPlugin
{
	public sealed class FingerprintKeyProvider : KeyProvider
	{
		public override string Name
		{
			get
			{
				return "Fingerprint Key Provider";
			}
		}

		public override bool GetKeyMightShowGui => true;

		public override byte[] GetKey(KeyProviderQueryContext ctx)
		{
			string pwd = string.Empty;

			string dbName = Path.GetFileNameWithoutExtension(ctx.DatabasePath);
			DbMasterKeyManager db = new DbMasterKeyManager();

			var t = Task.Run(async () => {
				KeyCredentialRetrievalResult keyCreationResult = await KeyCredentialManager.OpenAsync(dbName);
				if (keyCreationResult.Status == KeyCredentialStatus.Success)
				{
					var userKey = keyCreationResult.Credential;
					var dataWriter = new Windows.Storage.Streams.DataWriter();
					dataWriter.WriteString(dbName);

					var signResult = await userKey.RequestSignAsync(dataWriter.DetachBuffer());
					if (signResult.Status == KeyCredentialStatus.Success)
					{
						var dr = Windows.Storage.Streams.DataReader.FromBuffer(signResult.Result);

						using (SHA256 mySHA256 = SHA256.Create())
						{
							byte[] sigArray = new byte[dr.UnconsumedBufferLength];
							dr.ReadBytes(sigArray);

							DbMasterKeyManager dbManager = new DbMasterKeyManager();
							pwd = dbManager.GetMasterKey(dbName, mySHA256.ComputeHash(sigArray));
						}
					}
				}
			});

			t.Wait();

			return Encoding.ASCII.GetBytes(pwd);
		}
	}
}