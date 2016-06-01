using System;
using System.Threading.Tasks;
using System.IO;
using AppKit;
using Foundation;
using TinyEngima.Core;

namespace TinyEnigma.XMac
{
	public partial class ViewController : NSViewController
	{
        string inputFilename;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.


		}

		partial void browseBtnClick (NSObject sender)
		{
            //Select input File
            inputFilename = FileBrowserUtil.BrowseForOpenFile(null, "Select an Input File");
		}

        partial void btnEncryptClicked(NSObject sender)
        {
            //Encrypt
            OnEncrypt();
        }

        private async void OnEncrypt()
        {
            string passphrase = tbPassphrase.StringValue;
            string outputFile = FileBrowserUtil.BrowseForSaveFile(null, "Save Output File");
            if (outputFile == null || inputFilename == null || passphrase == null)
            {
                MessageBox.Show("Please select all inputs and/or enter a passphrase.");
                return;
            }
            statusTxt.StringValue = "Encrypting...";
            await Task.Run(() => TinyEngimaCommon.RunCryptoOnFile(inputFilename, outputFile, passphrase, true));
            statusTxt.StringValue = "Completed.";
            MessageBox.Show("The operation completed successfully.");
        }

        partial void btnDecryptClicked(NSObject sender)
        {
            //Decrypt
            OnDecrypt();
        }

        private async void OnDecrypt()
        {
            string passphrase = tbPassphrase.StringValue;
            string outputFile = FileBrowserUtil.BrowseForSaveFile(null, "Save Output File");
            if (outputFile == null || inputFilename == null || passphrase == null)
            {
                MessageBox.Show("Please select all inputs and/or enter a passphrase.");
                return;
            }
            statusTxt.StringValue = "Decrypting...";
            await Task.Run(() => TinyEngimaCommon.RunCryptoOnFile(inputFilename, outputFile, passphrase, false));
            statusTxt.StringValue = "Completed.";
            MessageBox.Show("The operation completed successfully.");
        }

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}
	}
}
