﻿namespace FingerprintPlugin
{
	partial class OptionsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panelBottom = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panelLeft = new System.Windows.Forms.Panel();
			this.imgLogo = new System.Windows.Forms.PictureBox();
			this.lblProductName = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.gpMasterKey = new System.Windows.Forms.GroupBox();
			this.lblVerif = new System.Windows.Forms.Label();
			this.tbxVerif = new System.Windows.Forms.TextBox();
			this.tbxPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.panelBottom.SuspendLayout();
			this.panelLeft.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
			this.gpMasterKey.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// panelBottom
			// 
			this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBottom.Controls.Add(this.btnCancel);
			this.panelBottom.Controls.Add(this.btnSave);
			this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBottom.Location = new System.Drawing.Point(142, 304);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new System.Drawing.Size(319, 30);
			this.panelBottom.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(161, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSave.Location = new System.Drawing.Point(80, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// panelLeft
			// 
			this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelLeft.Controls.Add(this.imgLogo);
			this.panelLeft.Controls.Add(this.lblProductName);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLeft.Location = new System.Drawing.Point(0, 0);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(142, 334);
			this.panelLeft.TabIndex = 1;
			// 
			// imgLogo
			// 
			this.imgLogo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imgLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.imgLogo.Location = new System.Drawing.Point(0, 241);
			this.imgLogo.Name = "imgLogo";
			this.imgLogo.Size = new System.Drawing.Size(140, 91);
			this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgLogo.TabIndex = 2;
			this.imgLogo.TabStop = false;
			this.toolTip.SetToolTip(this.imgLogo, "Open www.islog.com");
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductName.ForeColor = System.Drawing.Color.White;
			this.lblProductName.Location = new System.Drawing.Point(0, 0);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(142, 22);
			this.lblProductName.TabIndex = 2;
			this.lblProductName.Text = "Windows Hello";
			// 
			// gpMasterKey
			// 
			this.gpMasterKey.Controls.Add(this.lblVerif);
			this.gpMasterKey.Controls.Add(this.tbxVerif);
			this.gpMasterKey.Controls.Add(this.tbxPassword);
			this.gpMasterKey.Controls.Add(this.lblPassword);
			this.gpMasterKey.Dock = System.Windows.Forms.DockStyle.Top;
			this.gpMasterKey.Location = new System.Drawing.Point(142, 0);
			this.gpMasterKey.Name = "gpMasterKey";
			this.gpMasterKey.Size = new System.Drawing.Size(319, 174);
			this.gpMasterKey.TabIndex = 4;
			this.gpMasterKey.TabStop = false;
			this.gpMasterKey.Text = "Master Key";
			// 
			// lblVerif
			// 
			this.lblVerif.AutoSize = true;
			this.lblVerif.Location = new System.Drawing.Point(31, 68);
			this.lblVerif.Name = "lblVerif";
			this.lblVerif.Size = new System.Drawing.Size(62, 13);
			this.lblVerif.TabIndex = 9;
			this.lblVerif.Text = "Verification:";
			// 
			// tbxVerif
			// 
			this.tbxVerif.Location = new System.Drawing.Point(99, 65);
			this.tbxVerif.Name = "tbxVerif";
			this.tbxVerif.PasswordChar = '*';
			this.tbxVerif.Size = new System.Drawing.Size(154, 20);
			this.tbxVerif.TabIndex = 7;
			// 
			// tbxPassword
			// 
			this.tbxPassword.Location = new System.Drawing.Point(99, 39);
			this.tbxPassword.Name = "tbxPassword";
			this.tbxPassword.PasswordChar = '*';
			this.tbxPassword.Size = new System.Drawing.Size(154, 20);
			this.tbxPassword.TabIndex = 6;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(37, 42);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(56, 13);
			this.lblPassword.TabIndex = 8;
			this.lblPassword.Text = "Password:";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// OptionsForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(461, 334);
			this.Controls.Add(this.gpMasterKey);
			this.Controls.Add(this.panelBottom);
			this.Controls.Add(this.panelLeft);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "OptionsForm";
			this.ShowIcon = false;
			this.Text = "Windows Hello Options";
			this.Load += new System.EventHandler(this.OptionsForm_Load);
			this.panelBottom.ResumeLayout(false);
			this.panelLeft.ResumeLayout(false);
			this.panelLeft.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
			this.gpMasterKey.ResumeLayout(false);
			this.gpMasterKey.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelBottom;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.PictureBox imgLogo;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.GroupBox gpMasterKey;
		private System.Windows.Forms.Label lblVerif;
		private System.Windows.Forms.TextBox tbxVerif;
		private System.Windows.Forms.TextBox tbxPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}