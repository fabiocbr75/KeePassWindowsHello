using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FingerprintPlugin
{
	public class DbMasterKeyManager
	{
		List<DbMasterKey> _db = new List<DbMasterKey>();
		
		string _folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "KeePassWindowsHelloPlugin");
		string _dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "KeePassWindowsHelloPlugin", "DbMasterKey.dat");

		public DbMasterKeyManager()
		{
			string dbTextFile;
			try
			{
				Directory.CreateDirectory(_folderPath);
				if (File.Exists(_dbPath))
				{
					dbTextFile = File.ReadAllText(_dbPath);
					_db = JsonConvert.DeserializeObject<List<DbMasterKey>>(dbTextFile);
				}

			}
			catch (Exception e)
			{
				// Inform the user that an error occurred.
				MessageBox.Show("An error occurred while attempting to OpenOrCreate a DbMasterKey.dat " + "The error is:" + e.ToString());
			}

		}

		public void AddOrUpdate(string databaseName, string masterKey, byte[] sha256pwd)
		{
			try
			{
				var protectedPassword = masterKey.Protect(sha256pwd);

				var idx = _db.FindIndex(x => x.DatabaseName == databaseName);
				if (idx >= 0)
				{
					_db.RemoveAt(idx);
				}

				_db.Add(new DbMasterKey()
				{
					DatabaseName = databaseName,
					MasterKey = protectedPassword,
				});

			}
			catch (Exception e)
			{
				MessageBox.Show("An error occurred while attempting to AddOrUpdate a new password" + "The error is:" + e.ToString());
			}
		}

		public string GetMasterKey(string databaseName, byte[] sha256pwd)
		{
			var pwd = _db.Where(x => x.DatabaseName == databaseName).FirstOrDefault();

			return (pwd == null ? "" : pwd.MasterKey.Unprotect(sha256pwd));
		}


		public void Save()
		{
			try
			{
				File.WriteAllText(_dbPath, JsonConvert.SerializeObject(_db));
			}
			catch (IOException e)
			{
				// Inform the user that an error occurred.
				MessageBox.Show("An error occurred while attempting to Save a DbMasterKey.dat " + "The error is:" + e.ToString());
			}

		}
	}
}
