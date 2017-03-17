using System;

using UIKit;

namespace XamariniOSActivityIndicator
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}



		partial void BtnStart_TouchUpInside(UIButton sender)
		{
			indicator1.StartAnimating();
		}

		partial void BtnStop_TouchUpInside(UIButton sender)
		{
			indicator1.StopAnimating();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
