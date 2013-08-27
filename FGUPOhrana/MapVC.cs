
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace FGUPOhrana
{
	public partial class MapVC : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public MapVC ()
			: base (UserInterfaceIdiomIsPhone ? "MapVC_iPhone" : "MapVC_iPad", null)
		{
		}

		void Initialize () //TestFromVS
		{
			//throw new NotImplementedException ();

				//webIndicator.IsAnimating = true;/
				webIndicator.Hidden = false;//yest
				
				//var	url = String.Format ("http://{0}", url);
				NSUrl nsurl = new NSUrl ("http://m.scout-gps.ru");
				NSUrlRequest req = new NSUrlRequest (nsurl);
				//myWebView.sca//
				//myWebView.
				
				myWebView.LoadFinished += webViewFinished;
				
				//myWebView.EvaluateJavascript("var meta = document.createElement('meta'); " +  "meta.setAttribute( 'name', 'viewport' ); " + "meta.setAttribute( 'content', 'width = device-width, initial-scale = 5.0, user-scalable = yes' ); " +"document.getElementsByTagName('head')[0].appendChild(meta)");
				myWebView.ScalesPageToFit = true;

				myWebView.LoadRequest (req);
				
				//http://m.scout-gps.ru/

		}

		void webViewFinished (object sender, EventArgs e)
		{
			webIndicator.Hidden = true;

			//throw new NotImplementedException ();
		}
		//testing

		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Initialize();
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

