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
using Foundation;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(AdditionalDateTimeGridLinesBindingProvider))]
    [RegisterNavigation(DeviceKind.Phone)]
    public partial class AdditionalDateTimeViewController : UIViewController<AdditionalDateTimeGridLinesViewModel>
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

            UIBarButtonItem actionPresenterButton = new UIBarButtonItem(UIBarButtonSystemItem.Action);

            UIBarButtonItem[] barButton = new UIBarButtonItem[1];
            barButton[0] = actionPresenterButton;

            this.NavigationItem.SetRightBarButtonItems(barButton, false);
            this.NavigationItem.Title = "Additional DateTime GridLines";

            this.RegisterViewIdentifier("ActionPresenterButton", actionPresenterButton);
            this.RegisterViewIdentifier("ChartView", this.ChartView);
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