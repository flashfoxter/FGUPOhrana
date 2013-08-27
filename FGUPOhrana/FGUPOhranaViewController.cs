using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace FGUPOhrana
{
	public partial class FGUPOhranaViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public FGUPOhranaViewController ()
			: base (UserInterfaceIdiomIsPhone ? "FGUPOhranaViewController_iPhone" : "FGUPOhranaViewController_iPad", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		void Initialize ()
		{
			//throw new NotImplementedException ();
			btnGoSite.TouchUpInside += btnGoSiteTouch;
		}

		void btnGoSiteTouch (object sender, EventArgs e)
		{
			
			//MVDapp mvdVc = new AccessViolationException
			MapVC mvdVC = new MapVC();
			this.NavigationController.PushViewController(mvdVC, true);
			
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			Initialize();

			// Perform any additional setup after loading the view, typically from a nib.
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			if (UserInterfaceIdiomIsPhone) {
				return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
			} else {
				return true;
			}
		}
	}
}

