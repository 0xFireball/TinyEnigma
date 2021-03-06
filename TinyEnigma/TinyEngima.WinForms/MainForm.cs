﻿/*
 */
using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using TinyEngima.Core;

namespace TinyEngima.WinForms
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string inputFilename;
		string passphrase;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			inputFilename = FileDialogUtil.BrowseForOpenFile("All Files (*.*)|*.*", "Select Input File");
			if (inputFilename != null)
			{
				label2.Text = Path.GetFileName(inputFilename);
			}
		}
		async void Button2Click(object sender, EventArgs e)
		{
			//Encrypt
			string outputFile = FileDialogUtil.BrowseForSaveFile("All Files (*.*)|*.*", "Save Output File");
			if (outputFile == null || inputFilename == null || passphrase == null)
			{
				MessageBox.Show("Please select all inputs and/or enter a passphrase.");
				return;
			}
			label4.Text = "Encrypting...";
			await Task.Run(()=>TinyEngimaCommon.RunCryptoOnFile(inputFilename, outputFile, passphrase, true));
			label4.Text = "Completed.";
			MessageBox.Show("The operation completed successfully.");
		}
		async void Button3Click(object sender, EventArgs e)
		{
			//Decrypt
			string outputFile = FileDialogUtil.BrowseForSaveFile("All Files (*.*)|*.*", "Save Output File");
			if (outputFile == null || inputFilename == null || passphrase == null)
			{
				MessageBox.Show("Please select all inputs and/or enter a passphrase.");
				return;
			}
			label4.Text = "Decrypting...";
			await Task.Run(()=>TinyEngimaCommon.RunCryptoOnFile(inputFilename, outputFile, passphrase, false));
			label4.Text = "Completed.";
			MessageBox.Show("The operation completed successfully.");
		}
		void TbPassphraseTextChanged(object sender, EventArgs e)
		{
			passphrase = tbPassphrase.Text;
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				tbPassphrase.PasswordChar = (char)0;
			}
			else
			{
				tbPassphrase.PasswordChar = '*';
			}
		}
	}
}
