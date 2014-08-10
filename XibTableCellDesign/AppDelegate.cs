using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace XibTableCellDesign
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;
		MyTableViewController _viewController;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			_viewController = new MyTableViewController ();
			window.RootViewController = _viewController;

			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}