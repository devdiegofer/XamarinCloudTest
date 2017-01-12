using Foundation;
using UIKit;

namespace XamarinCloudTest
{
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public override UIWindow Window { get; set; }

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			this.Window = new UIWindow(UIScreen.MainScreen.Bounds);
			this.Window.RootViewController = new StartScreenViewController();
			this.Window.MakeKeyAndVisible();

			return true;
		}
	}
}

