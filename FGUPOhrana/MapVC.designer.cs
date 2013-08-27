// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace FGUPOhrana
{
	[Register ("MapVC")]
	partial class MapVC
	{
		[Outlet]
		MonoTouch.UIKit.UIWebView myWebView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIActivityIndicatorView webIndicator { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (myWebView != null) {
				myWebView.Dispose ();
				myWebView = null;
			}

			if (webIndicator != null) {
				webIndicator.Dispose ();
				webIndicator = null;
			}
		}
	}
}
