// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamariniOSActivityIndicator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnStart { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnStop { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIActivityIndicatorView indicator1 { get; set; }

        [Action ("BtnStart_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnStart_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnStop_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnStop_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnStart != null) {
                btnStart.Dispose ();
                btnStart = null;
            }

            if (btnStop != null) {
                btnStop.Dispose ();
                btnStop = null;
            }

            if (indicator1 != null) {
                indicator1.Dispose ();
                indicator1 = null;
            }
        }
    }
}