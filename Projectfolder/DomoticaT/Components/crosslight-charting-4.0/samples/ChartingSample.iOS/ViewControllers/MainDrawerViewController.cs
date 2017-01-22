using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using UIKit;
using ChartingSample.ViewModels;

namespace ChartingSample.iOS
{
	[RegisterNavigation(IsRootView = true)]
	public class MainDrawerViewController : UIDrawerNavigationController<DrawerViewModel>
	{
		#region Constructors

		public MainDrawerViewController()
		{
			this.DrawerSettings.StatusBarTransitionMode = StatusBarTransitionMode.TranslucentBlur;
            this.DrawerSettings.LeftStatusBarColor = UIColor.Clear;
            this.DrawerSettings.DrawerAnimation = DrawerAnimationKind.SlideParallax;
            this.DrawerSettings.AutoSynchronizeSelection = true;
		}

        #endregion
	}
}