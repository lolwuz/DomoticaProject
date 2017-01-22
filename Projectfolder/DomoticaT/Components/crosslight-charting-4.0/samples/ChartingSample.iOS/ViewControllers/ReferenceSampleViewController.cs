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
    [ImportBinding(typeof(ReferenceSampleBindingProvider))]
    [RegisterNavigation(DeviceKind.Phone)]
    public partial class ReferenceSampleViewController : UIViewController<ReferenceSampleViewModel>
    {
        UIChartView ChartView { get; set; }

        UIChartView ChartView2 { get; set; }

        UIChartView ChartView3 { get; set; }

        UIChartView ChartView4 { get; set; }

        UILabel Label1 { get; set; }

        UILabel Label2 { get; set; }

        UILabel Label3 { get; set; }

        UILabel Label4 { get; set; }

        UILabel Label5 { get; set; }

        UILabel Label6 { get; set; }

        UILabel Label7 { get; set; }

        UILabel Label8 { get; set; }

        #region Methods

        protected override void InitializeView()
        {
            base.InitializeView();

            nfloat top = UIApplication.SharedApplication.StatusBarFrame.Height + this.NavigationController.NavigationBar.Bounds.Height;
            nfloat height = (UIScreen.MainScreen.Bounds.Height - top) / 4;
            nfloat top2 = top + height;
            nfloat top3 = top2 + height;
            nfloat top4 = top3 + height;

            this.Label1 = new UILabel()
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top, UIScreen.MainScreen.Bounds.Width / 6, height / 2),
                Text = "User",
                Font = UIFont.BoldSystemFontOfSize(10),
                TextAlignment = UITextAlignment.Right
            };
            View.AddSubview(this.Label1);

            this.Label2 = new UILabel()
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top + (height / 2), UIScreen.MainScreen.Bounds.Width / 6, 10),
                Font = UIFont.BoldSystemFontOfSize(14),
                TextAlignment = UITextAlignment.Right,
                TextColor = UIColor.FromRGB(88, 114, 253)
            };
            View.AddSubview(this.Label2);

            this.Label3 = new UILabel()
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top2, UIScreen.MainScreen.Bounds.Width / 6, height / 2),
                Text = "Download",
                Font = UIFont.BoldSystemFontOfSize(10),
                TextAlignment = UITextAlignment.Right    
            };
            View.AddSubview(this.Label3);

            this.Label4 = new UILabel()
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top2 + (height / 2), UIScreen.MainScreen.Bounds.Width / 6, 10),
                Font = UIFont.BoldSystemFontOfSize(14),
                TextAlignment = UITextAlignment.Right,
                TextColor = UIColor.FromRGB(5, 226, 117)
            };
            View.AddSubview(this.Label4);

            this.Label5 = new UILabel()
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top3, UIScreen.MainScreen.Bounds.Width / 6, height / 2),
                Text = "Upload",
                Font = UIFont.BoldSystemFontOfSize(10),
                TextAlignment = UITextAlignment.Right    
            };
            View.AddSubview(this.Label5);

            this.Label6 = new UILabel()
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top3 + (height / 2), UIScreen.MainScreen.Bounds.Width / 6, 10),
                Font = UIFont.BoldSystemFontOfSize(14),
                TextAlignment = UITextAlignment.Right,
                TextColor = UIColor.FromRGB(217, 39, 255)
            };
            View.AddSubview(this.Label6);

            this.Label7 = new UILabel()
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top4, UIScreen.MainScreen.Bounds.Width / 6, height / 2),
                Text = "Crashes",
                Font = UIFont.BoldSystemFontOfSize(10),
                TextAlignment = UITextAlignment.Right    
            };
            View.AddSubview(this.Label7);

            this.Label8 = new UILabel()
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top4 + (height / 2), UIScreen.MainScreen.Bounds.Width / 6, 10),
                Font = UIFont.BoldSystemFontOfSize(14),
                TextAlignment = UITextAlignment.Right,
                TextColor = UIColor.FromRGB(0, 176, 254)
            };
            View.AddSubview(this.Label8);

            this.ChartView = new UIChartView(){ Frame = new CGRect(UIScreen.MainScreen.Bounds.Left, top, UIScreen.MainScreen.Bounds.Width * 5 / 6, height) };
            View.AddSubview(this.ChartView);

            this.ChartView2 = new UIChartView(){ Frame = new CGRect(UIScreen.MainScreen.Bounds.Left, top2, UIScreen.MainScreen.Bounds.Width * 5 / 6, height) };
            View.AddSubview(this.ChartView2);

            this.ChartView3 = new UIChartView(){ Frame = new CGRect(UIScreen.MainScreen.Bounds.Left, top3, UIScreen.MainScreen.Bounds.Width * 5 / 6, height) };
            View.AddSubview(this.ChartView3);

            this.ChartView4 = new UIChartView(){ Frame = new CGRect(UIScreen.MainScreen.Bounds.Left, top4, UIScreen.MainScreen.Bounds.Width * 5 / 6, height) };
            View.AddSubview(this.ChartView4);

            UIBarButtonItem actionPresenterButton = new UIBarButtonItem(UIBarButtonSystemItem.Action);

            UIBarButtonItem[] barButton = new UIBarButtonItem[1];
            barButton[0] = actionPresenterButton;

            this.NavigationItem.SetRightBarButtonItems(barButton, false);
            this.NavigationItem.Title = "Website Statistics";

            this.RegisterViewIdentifier("ActionPresenterButton", actionPresenterButton);
            this.RegisterViewIdentifier("ChartView", this.ChartView);
            this.RegisterViewIdentifier("ChartView2", this.ChartView2);
            this.RegisterViewIdentifier("ChartView3", this.ChartView3);
            this.RegisterViewIdentifier("ChartView4", this.ChartView4);
            this.RegisterViewIdentifier("Label1", this.Label1);
            this.RegisterViewIdentifier("Label2", this.Label2);
            this.RegisterViewIdentifier("Label3", this.Label3);
            this.RegisterViewIdentifier("Label4", this.Label4);
            this.RegisterViewIdentifier("Label5", this.Label5);
            this.RegisterViewIdentifier("Label6", this.Label6);
            this.RegisterViewIdentifier("Label7", this.Label7);
            this.RegisterViewIdentifier("Label8", this.Label8);
        }

        public override void DidRotate(UIInterfaceOrientation fromInterfaceOrientation)
        {
            base.DidRotate(fromInterfaceOrientation);

            nfloat top = UIApplication.SharedApplication.StatusBarFrame.Height + this.NavigationController.NavigationBar.Bounds.Height;
            nfloat height = (UIScreen.MainScreen.Bounds.Height - top) / 4;
            nfloat top2 = top + height;
            nfloat top3 = top2 + height;
            nfloat top4 = top3 + height;

            this.ChartView.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left, top, UIScreen.MainScreen.Bounds.Width * 5 / 6  - 6, height);
            this.ChartView2.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left, top2, UIScreen.MainScreen.Bounds.Width * 5 / 6 - 6, height);
            this.ChartView3.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left, top3, UIScreen.MainScreen.Bounds.Width * 5 / 6 - 6, height);
            this.ChartView4.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left, top4, UIScreen.MainScreen.Bounds.Width * 5 / 6 - 6, height);
            this.Label1.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top, UIScreen.MainScreen.Bounds.Width / 6, height / 2);
            this.Label2.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top + (height / 2), UIScreen.MainScreen.Bounds.Width / 6, 10);
            this.Label3.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top2, UIScreen.MainScreen.Bounds.Width / 6, height / 2);
            this.Label4.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top2 + (height / 2), UIScreen.MainScreen.Bounds.Width / 6, 10);
            this.Label5.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top3, UIScreen.MainScreen.Bounds.Width / 6, height / 2);
            this.Label6.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top3 + (height / 2), UIScreen.MainScreen.Bounds.Width / 6, 10);
            this.Label7.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top4, UIScreen.MainScreen.Bounds.Width / 6, height / 2);
            this.Label8.Frame = new CGRect(UIScreen.MainScreen.Bounds.Left + (UIScreen.MainScreen.Bounds.Width * 5 / 6) - 6, top4 + (height / 2), UIScreen.MainScreen.Bounds.Width / 6, 10);

            this.InvokeOnMainThread(() =>
                {
                    this.ChartView.SetNeedsDisplay();
                    this.ChartView2.SetNeedsDisplay();
                    this.ChartView3.SetNeedsDisplay();
                    this.ChartView4.SetNeedsDisplay();
                });
        }

        #endregion
    }
}