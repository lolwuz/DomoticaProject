using System.Drawing;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using ChartingSample.ViewModels;
using UIKit;
using System;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using CoreAnimation;
using SceneKit;

namespace ChartingSample.iOS
{
	[ImportBinding(typeof(BarBindingProvider))]
	[RegisterNavigation(DeviceKind.Phone)]
	public partial class BarViewController : UIViewController<BarViewModel>
	{
		ChartView ChartView{ get; set; }

		#region Methods

		protected override void InitializeView ()
		{
			base.InitializeView ();

			foreach (UIView view in this.View) {
				view.RemoveFromSuperview ();
			}

			nfloat top = UIApplication.SharedApplication.StatusBarFrame.Height + this.NavigationController.NavigationBar.Bounds.Height;
            this.ChartView = new ChartView (){Frame=new CGRect(UIScreen.MainScreen.Bounds.Left,top,UIScreen.MainScreen.Bounds.Width,UIScreen.MainScreen.Bounds.Height-top) };
			View.AddSubview (this.ChartView);

			UIBarButtonItem changeDataButton = new UIBarButtonItem(UIBarButtonSystemItem.Action);
			UIBarButtonItem addSeriesButton = new UIBarButtonItem(UIBarButtonSystemItem.Add);
			UIBarButtonItem deleteSeriesButton = new UIBarButtonItem(UIBarButtonSystemItem.Trash);
			UIBarButtonItem resetSeriesButton = new UIBarButtonItem(UIBarButtonSystemItem.Refresh);

			UIBarButtonItem[] barButton = new UIBarButtonItem[4];
			barButton [3] = changeDataButton;
			barButton [2] = addSeriesButton;
			barButton [1] = deleteSeriesButton;
			barButton [0] = resetSeriesButton;

			this.NavigationItem.SetRightBarButtonItems(barButton,false);
			this.NavigationItem.Title = "";

			this.RegisterViewIdentifier ("ChangeDataButton", changeDataButton);
			this.RegisterViewIdentifier ("AddSeriesButton", addSeriesButton);
			this.RegisterViewIdentifier ("ResetSeriesButton", resetSeriesButton);
			this.RegisterViewIdentifier ("DeleteSeriesButton", deleteSeriesButton);
			this.RegisterViewIdentifier ("ChartView", this.ChartView);
		}

		public override void DidRotate (UIInterfaceOrientation fromInterfaceOrientation)
		{
			base.DidRotate (fromInterfaceOrientation);

			nfloat top = UIApplication.SharedApplication.StatusBarFrame.Height + this.NavigationController.NavigationBar.Bounds.Height;
            this.ChartView.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left,top,UIScreen.MainScreen.Bounds.Width,UIScreen.MainScreen.Bounds.Height-top);
			this.InvokeOnMainThread(() =>
				{
					this.ChartView.SetNeedsDisplay();
				});
		}

		#endregion
	}
}