using System;

using AppKit;
using Foundation;

namespace TinyEnigma.XMac
{
	public partial class ViewController : NSViewController
	{
        string inputFile;

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
            inputFile = FileBrowserUtil.BrowseForOpenFile(null, "Select an Input File");
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
