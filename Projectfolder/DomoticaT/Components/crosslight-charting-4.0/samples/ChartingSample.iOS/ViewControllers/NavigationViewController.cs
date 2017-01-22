using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using UIKit;
using ChartingSample.ViewModels;

namespace ChartingSample.iOS
{
	[ImportBinding(typeof(NavigationBindingProvider))]
	//[RegisterNavigation(IsRootView = true)]
	public class NavigationViewController : UITableViewController<NavigationViewModel>
	{
		#region Constructors

		public NavigationViewController()
		{
		}

		public NavigationViewController(NavigationViewModel viewModel)
			: base(viewModel)
		{
		}

		#endregion

		#region Properties

		public override bool DeselectRowOnNavigate
		{
			get { return false; }
		}

		public override TableViewInteraction InteractionMode
		{
			get { return TableViewInteraction.Navigation; }
		}

		public override bool ShowGroupHeader
		{
			get { return true; }
		}

		public override UITableViewStyle TableViewStyle
		{
			get { return UITableViewStyle.Grouped; }
		}

		#endregion

		#region Methods

		protected override void InitializeView()
		{
			base.InitializeView();

			// set TableCell appearance
            this.Appearance.BackgroundImage = "bg.png";
            this.Appearance.BackgroundBlurEnabled = true;
            this.Appearance.CellBackgroundColor = UIColor.Clear;
            this.Appearance.CellSelectedBackgroundColor = UIColor.White.ColorWithAlpha(0.5f);
            this.Appearance.HeaderTextColor = UIColor.Gray.ColorWithAlpha(0.5f);
            this.Appearance.SeparatorEffect = UIVibrancyEffect.FromBlurEffect(UIBlurEffect.FromStyle(UIBlurEffectStyle.ExtraLight));
            this.Appearance.TitleTextAttributes = new UITextAttributes() { Font = UIFont.FromName(".HelveticaNeueInterface-Light", 15f) };
			this.Appearance.ShowSeparator = true;
		}

		#endregion
	}
}