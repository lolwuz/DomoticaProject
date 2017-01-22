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
    [ImportBinding(typeof(SimpleBindingProvider))]
    [RegisterNavigation(DeviceKind.Phone)]
    public partial class MainViewController : UIViewController<SimpleViewModel>
    {
		ChartView ChartView{ get; set; }

        #region Constructors

        public MainViewController()
        {
			
        }

        #endregion

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

			UIBarButtonItem changeDataButton = new UIBarButtonItem("Change Data",UIBarButtonItemStyle.Plain,null);
			UIBarButtonItem addSeriesButton = new UIBarButtonItem("Add Series",UIBarButtonItemStyle.Plain,null);
			UIBarButtonItem deleteSeriesButton = new UIBarButtonItem("Delete Series",UIBarButtonItemStyle.Plain,null);
			UIBarButtonItem resetSeriesButton = new UIBarButtonItem("Reset Series",UIBarButtonItemStyle.Plain,null);

			UIBarButtonItem[] barButton = new UIBarButtonItem[4];
			barButton [0] = changeDataButton;
			barButton [1] = addSeriesButton;
			barButton [2] = deleteSeriesButton;
			barButton [3] = resetSeriesButton;

			this.NavigationItem.SetLeftBarButtonItems(barButton,false);
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

        public override bool HideKeyboardOnTap
        {
            get
            {
                return true;
            }
        }

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();

            this.Title = "Crosslight App";
        }


        #endregion
    }
}