using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using Windows.Security.Credentials;

namespace FingerprintPlugin
{
	public partial class OptionsForm : Form
	{
		private class FingerprintUnit
		{
			public FingerprintUnit(int id, string description)
			{
				Id = id;
				Description = description;
			}
			public int Id
			{
				get;
				set;
			}
			public string Description
			{
				get;
				set;
			}

			public override string ToString()
			{
				return string.Format("{0} - {1}", Id, Description);
			}
		}
		public OptionsForm()
		{
			InitializeComponent();
			this.ShowInTaskbar = false;
			//this.TopMost = true;
			this.Focus();
			this.BringToFront();
		}

		public string DatabaseName
		{
			get;
			set;
		}

		private void OptionsForm_Load(object sender, EventArgs e)
		{
			Initialize();
		}

		private void Initialize()
		{

		}

		private async void btnSave_Click(object sender, EventArgs e)
		{
			errorProvider.Clear();

			if (String.IsNullOrEmpty(tbxPassword.Text))
			{
				errorProvider.SetError(tbxPassword, FingerprintPlugin.Properties.Resources.EmptyPasswordError);
				return;
			}
			else
			{
				errorProvider.SetError(tbxPassword, String.Empty);

				if (tbxPassword.Text != tbxVerif.Text)
				{
					errorProvider.SetError(tbxVerif, FingerprintPlugin.Properties.Resources.PasswordMismatchError);
					return;
				}
				else
				{
					errorProvider.SetError(tbxVerif, String.Empty);
				}
			}

			KeyCredentialRetrievalResult keyCreationResult = await KeyCredentialManager.RequestCreateAsync(DatabaseName, KeyCredentialCreationOption.ReplaceExisting);
			switch (keyCreationResult.Status)
			{
				case KeyCredentialStatus.Success:
					var userKey = keyCreationResult.Credential;
					var dataWriter = new Windows.Storage.Streams.DataWriter();
					dataWriter.WriteString(DatabaseName);

					var signResult = await userKey.RequestSignAsync(dataWriter.DetachBuffer());
					if (signResult.Status == KeyCredentialStatus.Success)
					{
						var dr = Windows.Storage.Streams.DataReader.FromBuffer(signResult.Result);

						using (SHA256 mySHA256 = SHA256.Create())
						{
							byte[] sigArray = new byte[dr.UnconsumedBufferLength];
							dr.ReadBytes(sigArray);
							var pwd = mySHA256.ComputeHash(sigArray);

							DbMasterKeyManager dbManager = new DbMasterKeyManager();
							dbManager.AddOrUpdate(DatabaseName, tbxPassword.Text, pwd);
							dbManager.Save();
						}
					}
					Debug.WriteLine("Successfully made key");
					break;
				case KeyCredentialStatus.CredentialAlreadyExists:
					Debug.WriteLine("Credential already exists.");
					break;
				case KeyCredentialStatus.UserCanceled:
					Debug.WriteLine("User cancelled sign-in process.");
					break;
				case KeyCredentialStatus.NotFound:
					// User needs to setup Microsoft Passport
					Debug.WriteLine("Microsoft Passport is not setup!\nPlease go to Windows Settings and set up a PIN to use it.");
					break;
				default:
					break;
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
