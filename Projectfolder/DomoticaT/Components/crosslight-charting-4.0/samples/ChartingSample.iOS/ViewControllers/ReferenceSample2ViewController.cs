using System;
using System.Drawing;
using ChartingSample.ViewModels;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using SceneKit;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(ReferenceSample2BindingProvider))]
    public partial class ReferenceSample2ViewController : UIViewController<ReferenceSample2ViewModel>
    {
        UIChartView ChartView { get; set; }

        UIChartView ChartView2 { get; set; }

        UIChartView ChartView3 { get; set; }

        #region Methods

        protected override void InitializeView()
        {
            base.InitializeView();

            nfloat top = UIApplication.SharedApplication.StatusBarFrame.Height + this.NavigationController.NavigationBar.Bounds.Height;
            nfloat height = (UIScreen.MainScreen.Bounds.Height - top) / 2;
            nfloat top2 = top + height;

            this.ChartView = new UIChartView(new CGRect(UIScreen.MainScreen.Bounds.Left, top, UIScreen.MainScreen.Bounds.Width, height));
            View.AddSubview(this.ChartView);

            this.ChartView2 = new UIChartView(new CGRect(UIScreen.MainScreen.Bounds.Left, top2, UIScreen.MainScreen.Bounds.Width / 2, height));
            View.AddSubview(this.ChartView2);

            this.ChartView3 = new UIChartView(new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width / 2), top2, UIScreen.MainScreen.Bounds.Width / 2, height));
            View.AddSubview(this.ChartView3);

            UIBarButtonItem actionPresenterButton = new UIBarButtonItem(UIBarButtonSystemItem.Action);
            this.NavigationItem.SetRightBarButtonItem(actionPresenterButton, false);
            this.NavigationItem.Title = "Downtime Statistics";

            this.RegisterViewIdentifier("ActionPresenterButton", actionPresenterButton);
            this.RegisterViewIdentifier("ChartView", this.ChartView);
            this.RegisterViewIdentifier("ChartView2", this.ChartView2);
            this.RegisterViewIdentifier("ChartView3", this.ChartView3);
        }

        public override void DidRotate(UIInterfaceOrientation fromInterfaceOrientation)
        {
            base.DidRotate(fromInterfaceOrientation);

            nfloat top = UIApplication.SharedApplication.StatusBarFrame.Height + this.NavigationController.NavigationBar.Bounds.Height;
            nfloat height = (UIScreen.MainScreen.Bounds.Height - top) / 2;
            nfloat top2 = top + height;

            this.ChartView.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left, top, UIScreen.MainScreen.Bounds.Width, height);
            this.ChartView2.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left, top2, UIScreen.MainScreen.Bounds.Width / 2, height);
            this.ChartView3.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width / 2), top2, UIScreen.MainScreen.Bounds.Width / 2, height);

            this.InvokeOnMainThread(() =>
            {
                this.ChartView.SetNeedsDisplay();
                this.ChartView2.SetNeedsDisplay();
                this.ChartView3.SetNeedsDisplay();
            });
        }

        #endregion
    }
}