using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    public class ChartViewSampleController<TViewModel> : UIChartViewController<TViewModel> where TViewModel : class, IViewModel
    {
        protected override void InitializeView()
        {
            base.InitializeView();

            var actionPresenterButton = new UIBarButtonItem(UIBarButtonSystemItem.Action);
            this.NavigationItem.SetRightBarButtonItem(actionPresenterButton, false);
            this.NavigationItem.Title = this.Title;

            this.RegisterViewIdentifier("ActionPresenterButton", actionPresenterButton);
        }
    }
    
}