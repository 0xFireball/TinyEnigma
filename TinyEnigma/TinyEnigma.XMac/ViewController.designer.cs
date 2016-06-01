// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TinyEnigma.XMac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField statusTxt { get; set; }

		[Outlet]
		AppKit.NSSecureTextField tbPassphrase { get; set; }

		[Action ("browseBtnClick:")]
		partial void browseBtnClick (Foundation.NSObject sender);

		[Action ("btnDecryptClicked:")]
		partial void btnDecryptClicked (Foundation.NSObject sender);

		[Action ("btnEncryptClicked:")]
		partial void btnEncryptClicked (Foundation.NSObject sender);

		[Action ("showPassphraseChkChanged:")]
		partial void showPassphraseChkChanged (Foundation.NSObject sender);

		[Action ("tbPassphraseChanged:")]
		partial void tbPassphraseChanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (statusTxt != null) {
				statusTxt.Dispose ();
				statusTxt = null;
			}

			if (tbPassphrase != null) {
				tbPassphrase.Dispose ();
				tbPassphrase = null;
			}
		}
	}
}
